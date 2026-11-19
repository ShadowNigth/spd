using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public class CSGModelBase : MonoBehaviour
{
	public class RayHitComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			return ((RaycastHit)x).distance.CompareTo(((RaycastHit)y).distance);
		}
	}

	public const string VERSION_STRING = "1.8.0";

	protected const string DEFAULT_FALLBACK_MATERIAL_PATH = "Materials/Default_Map";

	protected const int MESH_VERTEX_LIMIT = 65500;

	[SerializeField]
	[HideInInspector]
	protected List<Brush> brushes = new List<Brush>();

	[SerializeField]
	[HideInInspector]
	protected List<Brush> builtBrushes = new List<Brush>();

	[SerializeField]
	[HideInInspector]
	protected MaterialMeshDictionary materialMeshDictionary = new MaterialMeshDictionary();

	[SerializeField]
	[HideInInspector]
	protected List<Mesh> collisionMeshDictionary = new List<Mesh>();

	[SerializeField]
	[HideInInspector]
	protected bool polygonsRemoved;

	[SerializeField]
	[HideInInspector]
	protected CSGBuildSettings buildSettings = new CSGBuildSettings();

	[SerializeField]
	[HideInInspector]
	protected CSGBuildSettings lastBuildSettings = new CSGBuildSettings();

	[NonSerialized]
	protected CSGBuildContext buildContextBehaviour;

	[NonSerialized]
	protected CSGBuildContext.BuildContext buildContext;

	private int updateCounter;

	public CSGBuildContext.BuildContext BuildContext
	{
		get
		{
			if (buildContext == null)
			{
				SetUpBuildContext();
			}
			return buildContext;
		}
	}

	internal bool IsUpdating => updateCounter > 0;

	public BuildMetrics BuildMetrics => BuildContext.buildMetrics;

	public int BrushCount
	{
		get
		{
			int num = 0;
			for (int i = 0; i < brushes.Count; i++)
			{
				if (brushes[i] != null)
				{
					num++;
				}
			}
			return num;
		}
	}

	public bool LastBuildHadTangents => lastBuildSettings.GenerateTangents;

	public virtual bool AreBrushesVisible => false;

	public List<Polygon> VisualPolygons => BuildContext.VisualPolygons;

	internal void BeginUpdate()
	{
		updateCounter++;
	}

	internal void EndUpdate()
	{
		updateCounter--;
		if (updateCounter < 0)
		{
			updateCounter = 0;
		}
	}

	public PolygonEntry GetVisualPolygonEntry(int index)
	{
		int num = BuildContext.VisualPolygonIndex.Length;
		if (num == 0 || index >= num || index < 0)
		{
			return null;
		}
		return BuildContext.VisualPolygonIndex[index];
	}

	public PolygonEntry GetCollisionPolygonEntry(int index)
	{
		int num = BuildContext.CollisionPolygonIndex.Length;
		if (num == 0 || index >= num || index < 0)
		{
			return null;
		}
		return BuildContext.CollisionPolygonIndex[index];
	}

	public List<Brush> GetBrushes()
	{
		return brushes;
	}

	private void Awake()
	{
		SetUpBuildContext();
	}

	private void SetUpBuildContext()
	{
		buildContextBehaviour = this.AddOrGetComponent<CSGBuildContext>();
		buildContext = buildContextBehaviour.GetBuildContext();
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
		if (Application.isPlaying && CSGFactory.Tick())
		{
			OnBuildComplete();
		}
	}

	public virtual void Build(bool forceRebuild, bool buildInBackground)
	{
		if (!lastBuildSettings.IsBuilt || CSGBuildSettings.AreDifferent(buildSettings, lastBuildSettings))
		{
			forceRebuild = true;
		}
		brushes = new List<Brush>(base.transform.GetComponentsInChildren<Brush>(includeInactive: false));
		for (int i = 0; i < brushes.Count; i++)
		{
			brushes[i].PrepareToBuild(brushes, forceRebuild);
		}
		Material defaultMaterial = GetDefaultMaterial();
		if (defaultMaterial == null)
		{
			Debug.LogError("Default fallback material file is missing, try reimporting SabreCSG");
		}
		if (buildContext == null)
		{
			buildContext = BuildContext;
		}
		BuildStatus buildStatus = CSGFactory.Build(brushes, buildSettings, buildContext, base.transform, materialMeshDictionary, collisionMeshDictionary, polygonsRemoved, forceRebuild, OnBuildProgressChanged, OnFinalizeVisualMesh, OnFinalizeCollisionMesh, buildInBackground);
		if (buildStatus == BuildStatus.Complete)
		{
			OnBuildComplete();
		}
	}

	public virtual void OnBuildComplete()
	{
		polygonsRemoved = false;
		builtBrushes.Clear();
		builtBrushes.AddRange(brushes);
		lastBuildSettings = buildSettings.ShallowCopy();
		lastBuildSettings.IsBuilt = true;
		FirePostBuildEvents();
	}

	private void FirePostBuildEvents()
	{
		Transform meshGroupTransform = GetMeshGroupTransform();
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		foreach (Assembly assembly in array)
		{
			if (!assembly.FullName.StartsWith("Assembly-CSharp"))
			{
				continue;
			}
			Type[] types = assembly.GetTypes();
			for (int j = 0; j < types.Length; j++)
			{
				MethodInfo[] methods = types[j].GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				for (int k = 0; k < methods.Length; k++)
				{
					if (Attribute.IsDefined(methods[k], typeof(PostProcessCSGBuildAttribute)))
					{
						methods[k].Invoke(null, new object[1] { meshGroupTransform });
					}
				}
			}
		}
		IPostBuildListener[] componentsInChildren = base.transform.GetComponentsInChildren<IPostBuildListener>();
		for (int l = 0; l < componentsInChildren.Length; l++)
		{
			componentsInChildren[l].OnBuildFinished(meshGroupTransform);
		}
	}

	public bool TrackBrush(Brush brush)
	{
		if (!brushes.Contains(brush))
		{
			brushes.Add(brush);
			return true;
		}
		return false;
	}

	public void OnBrushDisabled(PrimitiveBrush brush)
	{
		polygonsRemoved = true;
	}

	public Polygon RaycastBuiltPolygons(Ray ray)
	{
		if (BuildContext.VisualPolygons != null)
		{
			float hitDistance = 0f;
			return GeometryHelper.RaycastPolygons(BuildContext.VisualPolygons, ray, out hitDistance);
		}
		return null;
	}

	public List<PolygonRaycastHit> RaycastBuiltPolygonsAll(Ray ray)
	{
		if (BuildContext.VisualPolygons != null)
		{
			return GeometryHelper.RaycastPolygonsAll(BuildContext.VisualPolygons, ray);
		}
		return null;
	}

	public Brush FindBrushFromPolygon(Polygon sourcePolygon)
	{
		for (int i = 0; i < brushes.Count; i++)
		{
			if (brushes[i] != null && Array.IndexOf(brushes[i].GetPolygonIDs(), sourcePolygon.UniqueIndex) != -1)
			{
				return brushes[i];
			}
		}
		return null;
	}

	public List<Polygon> GetAllSourcePolygons()
	{
		List<Polygon> visualPolygons = BuildContext.VisualPolygons;
		List<int> list = new List<int>();
		for (int i = 0; i < visualPolygons.Count; i++)
		{
			if (!list.Contains(visualPolygons[i].UniqueIndex))
			{
				list.Add(visualPolygons[i].UniqueIndex);
			}
		}
		List<Polygon> list2 = new List<Polygon>(list.Count);
		for (int j = 0; j < list.Count; j++)
		{
			Polygon sourcePolygon = GetSourcePolygon(list[j]);
			list2.Add(sourcePolygon);
		}
		return list2;
	}

	public Polygon[] BuiltPolygonsByIndex(int uniquePolygonIndex)
	{
		if (BuildContext == null || BuildContext.VisualPolygons == null)
		{
			return new Polygon[0];
		}
		List<Polygon> list = new List<Polygon>();
		for (int i = 0; i < BuildContext.VisualPolygons.Count; i++)
		{
			Polygon polygon = BuildContext.VisualPolygons[i];
			if (polygon.UniqueIndex == uniquePolygonIndex && !polygon.ExcludeFromFinal)
			{
				list.Add(polygon);
			}
		}
		return list.ToArray();
	}

	public List<PolygonRaycastHit> RaycastBrushesAll(Ray ray, bool testAllModels)
	{
		List<PolygonRaycastHit> list = new List<PolygonRaycastHit>();
		List<Brush> list2;
		if (testAllModels)
		{
			list2 = new List<Brush>();
			CSGModelBase[] array = UnityEngine.Object.FindObjectsOfType<CSGModelBase>();
			for (int i = 0; i < array.Length; i++)
			{
				list2.AddRange(array[i].brushes);
			}
		}
		else
		{
			list2 = brushes;
		}
		for (int j = 0; j < list2.Count; j++)
		{
			if (!(list2[j] == null))
			{
				Polygon[] collection = list2[j].GenerateTransformedPolygons();
				float hitDistance;
				Polygon polygon = GeometryHelper.RaycastPolygons(new List<Polygon>(collection), ray, out hitDistance);
				if (polygon != null)
				{
					list.Add(new PolygonRaycastHit
					{
						Distance = hitDistance,
						Point = ray.GetPoint(hitDistance),
						Normal = polygon.Plane.normal,
						GameObject = list2[j].gameObject,
						Polygon = polygon
					});
				}
			}
		}
		list.Sort((PolygonRaycastHit x, PolygonRaycastHit y) => x.Distance.CompareTo(y.Distance));
		return list;
	}

	public List<BrushBase> ExtractBrushBases(List<Brush> sourceBrushes)
	{
		List<BrushBase> list = new List<BrushBase>();
		for (int i = 0; i < sourceBrushes.Count; i++)
		{
			if (sourceBrushes[i].GetType() == typeof(PrimitiveBrush))
			{
				GroupBrush groupBrush = null;
				if ((bool)sourceBrushes[i].transform.parent)
				{
					groupBrush = sourceBrushes[i].transform.parent.GetComponent<GroupBrush>();
				}
				BrushBase brushController = ((PrimitiveBrush)sourceBrushes[i]).BrushController;
				if (groupBrush != null)
				{
					if (!list.Contains(groupBrush))
					{
						list.Add(groupBrush);
					}
				}
				else if (brushController != null)
				{
					if (!list.Contains(brushController))
					{
						list.Add(brushController);
					}
				}
				else
				{
					list.Add(sourceBrushes[i]);
				}
			}
			else
			{
				list.Add(sourceBrushes[i]);
			}
		}
		return list;
	}

	public bool HasBrushBeenBuilt(Brush candidateBrush)
	{
		return builtBrushes.Contains(candidateBrush);
	}

	public GameObject CreateBrush(PrimitiveBrushType brushType, Vector3 localPosition, Vector3 localSize = default(Vector3), Quaternion localRotation = default(Quaternion), Material material = null, CSGMode csgMode = CSGMode.Add, string brushName = null)
	{
		GameObject gameObject = (string.IsNullOrEmpty(brushName) ? new GameObject(string.Empty) : new GameObject(brushName));
		gameObject.transform.localScale = base.transform.lossyScale;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = localPosition;
		if (localRotation != default(Quaternion))
		{
			gameObject.transform.localRotation = localRotation;
		}
		PrimitiveBrush primitiveBrush = gameObject.AddComponent<PrimitiveBrush>();
		primitiveBrush.BrushType = brushType;
		primitiveBrush.Mode = csgMode;
		primitiveBrush.ResetPolygons();
		if (localSize != default(Vector3) && localSize != new Vector3(2f, 2f, 2f))
		{
			BrushUtility.Resize(primitiveBrush, localSize);
		}
		else
		{
			primitiveBrush.Invalidate(polygonsChanged: true);
		}
		if (material != null)
		{
			SurfaceUtility.SetAllPolygonsMaterials(primitiveBrush, material);
		}
		return gameObject;
	}

	public GameObject CreateCompoundBrush<T>(Vector3 localPosition, Vector3 localSize = default(Vector3), Quaternion localRotation = default(Quaternion), Material material = null, CSGMode csgMode = CSGMode.Add, string brushName = null) where T : CompoundBrush
	{
		return CreateCompoundBrush(typeof(T), localPosition, localSize, localRotation, material, csgMode, brushName);
	}

	public GameObject CreateCompoundBrush(Type compoundBrushType, Vector3 localPosition, Vector3 localSize = default(Vector3), Quaternion localRotation = default(Quaternion), Material material = null, CSGMode csgMode = CSGMode.Add, string brushName = null)
	{
		if (!typeof(CompoundBrush).IsAssignableFrom(compoundBrushType))
		{
			throw new ArgumentException("Specified type must be derived from CompoundBrush");
		}
		GameObject gameObject = (string.IsNullOrEmpty(brushName) ? new GameObject(string.Empty) : new GameObject(brushName));
		gameObject.transform.localScale = base.transform.lossyScale;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = localPosition;
		if (localRotation != default(Quaternion))
		{
			gameObject.transform.localRotation = localRotation;
		}
		CompoundBrush compoundBrush = (CompoundBrush)gameObject.AddComponent(compoundBrushType);
		compoundBrush.Mode = csgMode;
		compoundBrush.Invalidate(polygonsChanged: true);
		if (material != null)
		{
		}
		return gameObject;
	}

	public GameObject CreateCustomBrush(Polygon[] polygons)
	{
		GameObject gameObject = new GameObject(string.Empty);
		gameObject.transform.parent = base.transform;
		PrimitiveBrush primitiveBrush = gameObject.AddComponent<PrimitiveBrush>();
		primitiveBrush.SetPolygons(polygons);
		return gameObject;
	}

	public Polygon GetSourcePolygon(int uniqueIndex)
	{
		for (int i = 0; i < brushes.Count; i++)
		{
			if (!(brushes[i] != null))
			{
				continue;
			}
			Polygon[] polygons = brushes[i].GetPolygons();
			for (int j = 0; j < polygons.Length; j++)
			{
				if (polygons[j].UniqueIndex == uniqueIndex)
				{
					return polygons[j];
				}
			}
		}
		return null;
	}

	public Transform GetMeshGroupTransform()
	{
		return base.transform.Find("MeshGroup");
	}

	public void RefreshMeshGroup()
	{
		Transform meshGroupTransform = GetMeshGroupTransform();
		if (meshGroupTransform != null && meshGroupTransform.gameObject.activeInHierarchy)
		{
			meshGroupTransform.gameObject.SetActive(value: false);
			meshGroupTransform.gameObject.SetActive(value: true);
		}
	}

	public virtual void OnBuildProgressChanged(float progress)
	{
	}

	public virtual void OnFinalizeVisualMesh(GameObject newGameObject, Mesh mesh)
	{
	}

	public virtual void OnFinalizeCollisionMesh(GameObject newGameObject, Mesh mesh)
	{
	}

	public void NotifyPolygonsRemoved()
	{
		polygonsRemoved = true;
	}

	public Material GetDefaultMaterial()
	{
		EnsureDefaultMaterialSet();
		return buildSettings.DefaultVisualMaterial;
	}

	public void EnsureDefaultMaterialSet()
	{
		if (buildSettings.DefaultVisualMaterial == null)
		{
			buildSettings.DefaultVisualMaterial = GetDefaultFallbackMaterial();
		}
	}

	public virtual Material GetDefaultFallbackMaterial()
	{
		return Resources.Load("Materials/Default_Map") as Material;
	}
}
