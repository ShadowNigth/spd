using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sabresaurus.SabreCSG
{
	[ExecuteInEditMode]
	public class PrimitiveBrush : Brush
	{
		[SerializeField]
		private Polygon[] polygons;

		[SerializeField]
		[HideInInspector]
		private int prismSideCount = 6;

		[SerializeField]
		[HideInInspector]
		private int cylinderSideCount = 20;

		[SerializeField]
		[HideInInspector]
		private int coneSideCount = 20;

		[SerializeField]
		[HideInInspector]
		private int capsuleSideCount = 12;

		[SerializeField]
		[HideInInspector]
		private float capsuleHeight = 2f;

		[SerializeField]
		[HideInInspector]
		private int sphereSideCount = 6;

		[SerializeField]
		[HideInInspector]
		private int icoSphereIterationCount = 1;

		[SerializeField]
		[HideInInspector]
		private PrimitiveBrushType brushType;

		[SerializeField]
		[HideInInspector]
		private bool tracked;

		[SerializeField]
		[HideInInspector]
		private BrushOrder cachedBrushOrder;

		[SerializeField]
		private BrushBase brushController;

		private int cachedInstanceID;

		private CSGModelBase parentCsgModel;

		[SerializeField]
		private WorldTransformData cachedWorldTransform;

		[SerializeField]
		private int objectVersionSerialized;

		private int objectVersionUnserialized;

		public int PrismSideCount
		{
			get
			{
				return prismSideCount;
			}
			set
			{
				prismSideCount = value;
			}
		}

		public int CylinderSideCount
		{
			get
			{
				return cylinderSideCount;
			}
			set
			{
				cylinderSideCount = value;
			}
		}

		public int ConeSideCount
		{
			get
			{
				return coneSideCount;
			}
			set
			{
				coneSideCount = value;
			}
		}

		public int CapsuleSideCount
		{
			get
			{
				return capsuleSideCount;
			}
			set
			{
				capsuleSideCount = value;
			}
		}

		public float CapsuleHeight
		{
			get
			{
				return capsuleHeight;
			}
			set
			{
				capsuleHeight = value;
			}
		}

		public int SphereSideCount
		{
			get
			{
				return sphereSideCount;
			}
			set
			{
				sphereSideCount = value;
			}
		}

		public int IcoSphereIterationCount
		{
			get
			{
				return icoSphereIterationCount;
			}
			set
			{
				icoSphereIterationCount = value;
			}
		}

		public PrimitiveBrushType BrushType
		{
			get
			{
				return brushType;
			}
			set
			{
				brushType = value;
			}
		}

		public BrushBase BrushController
		{
			get
			{
				return brushController;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return brushController != null;
			}
		}

		public override string BeautifulBrushName
		{
			get
			{
				switch (brushType)
				{
				case PrimitiveBrushType.Cube:
					return "Cube Brush";
				case PrimitiveBrushType.Sphere:
					return "Sphere Brush";
				case PrimitiveBrushType.Cylinder:
					return "Cylinder Brush";
				case PrimitiveBrushType.Prism:
					return "Prism Brush";
				case PrimitiveBrushType.Custom:
					return "Custom Brush";
				case PrimitiveBrushType.IcoSphere:
					return "Icosphere Brush";
				case PrimitiveBrushType.Cone:
					return "Cone Brush";
				case PrimitiveBrushType.Capsule:
					return "Capsule Brush";
				default:
					return base.BeautifulBrushName;
				}
			}
		}

		public void SetBrushController(BrushBase brushController)
		{
			this.brushController = brushController;
		}

		public void SetPolygons(Polygon[] polygons, bool breakTypeRelation = true)
		{
			this.polygons = polygons;
			Invalidate(true);
			if (breakTypeRelation)
			{
				BreakTypeRelation();
			}
		}

		public void BreakTypeRelation()
		{
			brushType = PrimitiveBrushType.Custom;
		}

		private void Start()
		{
			cachedWorldTransform = new WorldTransformData(base.transform);
			EnsureWellFormed();
			Invalidate(false);
			if (brushCache == null || brushCache.Polygons == null || brushCache.Polygons.Length == 0)
			{
				RecachePolygons(true);
			}
			objectVersionUnserialized = objectVersionSerialized;
		}

		public void ResetPolygons()
		{
			if (brushType == PrimitiveBrushType.Cube)
			{
				polygons = BrushFactory.GenerateCube();
			}
			else if (brushType == PrimitiveBrushType.Cylinder)
			{
				if (cylinderSideCount < 3)
				{
					cylinderSideCount = 3;
				}
				polygons = BrushFactory.GenerateCylinder(cylinderSideCount);
			}
			else if (brushType == PrimitiveBrushType.Sphere)
			{
				if (sphereSideCount < 3)
				{
					sphereSideCount = 3;
				}
				polygons = BrushFactory.GeneratePolarSphere(sphereSideCount, sphereSideCount * 2);
			}
			else if (brushType == PrimitiveBrushType.IcoSphere)
			{
				if (icoSphereIterationCount < 0)
				{
					icoSphereIterationCount = 0;
				}
				else if (icoSphereIterationCount > 2)
				{
					icoSphereIterationCount = 2;
				}
				polygons = BrushFactory.GenerateIcoSphere(icoSphereIterationCount);
			}
			else if (brushType == PrimitiveBrushType.Prism)
			{
				if (prismSideCount < 3)
				{
					prismSideCount = 3;
				}
				polygons = BrushFactory.GeneratePrism(prismSideCount);
			}
			else if (brushType == PrimitiveBrushType.Cone)
			{
				if (coneSideCount < 3)
				{
					coneSideCount = 3;
				}
				polygons = BrushFactory.GenerateCone(coneSideCount);
			}
			else if (brushType == PrimitiveBrushType.Capsule)
			{
				if (capsuleHeight < 0.001f)
				{
					capsuleHeight = 0.001f;
				}
				if (capsuleSideCount < 3)
				{
					capsuleSideCount = 3;
				}
				polygons = BrushFactory.GenerateCapsule(capsuleHeight, 0.5f, capsuleSideCount);
			}
			else
			{
				if (brushType != PrimitiveBrushType.Custom)
				{
					throw new NotImplementedException();
				}
				Debug.LogError("PrimitiveBrushType.Custom is not a valid type for new brush creation");
			}
		}

		private void DrawPolygons(Color color, params Polygon[] polygons)
		{
			GL.Begin(4);
			color.a = 0.7f;
			GL.Color(color);
			foreach (Polygon polygon in polygons)
			{
				Vector3 position = polygon.Vertices[0].Position;
				for (int j = 1; j < polygon.Vertices.Length - 1; j++)
				{
					GL.Vertex(base.transform.TransformPoint(position));
					GL.Vertex(base.transform.TransformPoint(polygon.Vertices[j].Position));
					GL.Vertex(base.transform.TransformPoint(polygon.Vertices[j + 1].Position));
				}
			}
			GL.End();
		}

		public override Polygon[] GenerateTransformedPolygons()
		{
			Polygon[] array = polygons.DeepCopy();
			Vector3 position = base.transform.position;
			Quaternion rotation = base.transform.rotation;
			Vector3 lossyScale = base.transform.lossyScale;
			for (int i = 0; i < polygons.Length; i++)
			{
				for (int j = 0; j < polygons[i].Vertices.Length; j++)
				{
					array[i].Vertices[j].Position = rotation * array[i].Vertices[j].Position.Multiply(lossyScale) + position;
					array[i].Vertices[j].Normal = rotation * array[i].Vertices[j].Normal;
				}
				array[i].CalculatePlane();
			}
			return array;
		}

		public override void RecalculateBrushCache()
		{
			RecachePolygons(true);
			RecalculateIntersections();
		}

		public override void RecachePolygons(bool markUnbuilt)
		{
			if (brushCache == null)
			{
				brushCache = new BrushCache();
			}
			Polygon[] array = GenerateTransformedPolygons();
			Bounds boundsTransformed = GetBoundsTransformed();
			brushCache.Set(mode, array, boundsTransformed, markUnbuilt);
		}

		public override void RecalculateIntersections()
		{
			CSGModelBase cSGModel = GetCSGModel();
			if (!(cSGModel != null))
			{
				return;
			}
			List<Brush> brushes = GetCSGModel().GetBrushes();
			IComparer<Brush> comparer = new BrushOrderComparer();
			for (int i = 0; i < brushes.Count; i++)
			{
				if (brushes[i] == null)
				{
					brushes.RemoveAt(i);
					i--;
				}
			}
			for (int j = 0; j < brushes.Count; j++)
			{
				brushes[j].UpdateCachedBrushOrder();
			}
			brushes.Sort(comparer);
			RecalculateIntersections(brushes, true);
		}

		public override void RecalculateIntersections(List<Brush> brushes, bool isRootChange)
		{
			List<Brush> intersectingVisualBrushes = brushCache.IntersectingVisualBrushes;
			List<Brush> intersectingCollisionBrushes = brushCache.IntersectingCollisionBrushes;
			List<Brush> list = Brush.CalculateIntersectingBrushes(this, brushes, false);
			List<Brush> list2 = Brush.CalculateIntersectingBrushes(this, brushes, true);
			brushCache.SetIntersection(list, list2);
			if (!isRootChange)
			{
				return;
			}
			List<Brush> list3 = new List<Brush>();
			List<Brush> list4 = new List<Brush>();
			for (int i = 0; i < list.Count; i++)
			{
				if (!(list[i] != null))
				{
					continue;
				}
				if (!intersectingVisualBrushes.Contains(list[i]))
				{
					if (!list3.Contains(list[i]))
					{
						list3.Add(list[i]);
					}
				}
				else if (!list4.Contains(list[i]))
				{
					list4.Add(list[i]);
				}
			}
			for (int j = 0; j < intersectingVisualBrushes.Count; j++)
			{
				if (intersectingVisualBrushes[j] != null && !list.Contains(intersectingVisualBrushes[j]) && !list3.Contains(intersectingVisualBrushes[j]))
				{
					list3.Add(intersectingVisualBrushes[j]);
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!(list2[k] != null))
				{
					continue;
				}
				if (!intersectingCollisionBrushes.Contains(list2[k]))
				{
					if (!list3.Contains(list2[k]))
					{
						list3.Add(list2[k]);
					}
				}
				else if (!list4.Contains(list2[k]))
				{
					list4.Add(list2[k]);
				}
			}
			for (int l = 0; l < intersectingCollisionBrushes.Count; l++)
			{
				if (intersectingCollisionBrushes[l] != null && !list2.Contains(intersectingCollisionBrushes[l]) && !list3.Contains(intersectingCollisionBrushes[l]))
				{
					list3.Add(intersectingCollisionBrushes[l]);
				}
			}
			for (int m = 0; m < list3.Count; m++)
			{
				list3[m].RecalculateIntersections(brushes, false);
				list3[m].BrushCache.SetUnbuilt();
			}
			for (int n = 0; n < list4.Count; n++)
			{
				list4[n].RecalculateIntersections(brushes, false);
			}
		}

		public override void OnUndoRedoPerformed()
		{
			if (objectVersionSerialized != objectVersionUnserialized)
			{
				Invalidate(true);
			}
		}

		private void EnsureWellFormed()
		{
			if (polygons == null || polygons.Length == 0)
			{
				if (brushType == PrimitiveBrushType.Custom)
				{
					brushType = PrimitiveBrushType.Cube;
				}
				ResetPolygons();
			}
		}

		private void OnDisable()
		{
			if (base.enabled && (base.gameObject.activeInHierarchy || !base.transform.root.gameObject.activeInHierarchy))
			{
				return;
			}
			GetCSGModel().OnBrushDisabled(this);
			List<Brush> list = new List<Brush>(brushCache.IntersectingVisualBrushes);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] != null)
				{
					list[i].RecalculateIntersections();
					list[i].BrushCache.SetUnbuilt();
				}
			}
		}

		private void UpdateTracking()
		{
			CSGModelBase cSGModel = GetCSGModel();
			if (cSGModel != null)
			{
				if (!parentCsgModel.IsUpdating)
				{
					if (cSGModel.TrackBrush(this))
					{
						MeshFilter meshFilter = base.gameObject.AddOrGetComponent<MeshFilter>();
						meshFilter.sharedMesh = new Mesh();
						brushCache = new BrushCache();
						EnsureWellFormed();
						RecalculateBrushCache();
					}
					Invalidate(false);
					tracked = true;
				}
			}
			else
			{
				tracked = false;
			}
		}

		private void OnEnable()
		{
			UpdateTracking();
		}

		protected override void Update()
		{
			base.Update();
			if (!tracked)
			{
				UpdateTracking();
			}
			if (cachedWorldTransform.SetFromTransform(base.transform))
			{
				Invalidate(true);
			}
		}

		public override void Invalidate(bool polygonsChanged)
		{
			base.Invalidate(polygonsChanged);
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			MeshCollider[] components = GetComponents<MeshCollider>();
			if (components.Length > 0)
			{
				for (int i = 0; i < components.Length; i++)
				{
					UnityEngine.Object.DestroyImmediate(components[i]);
				}
			}
			MeshFilter meshFilter = base.gameObject.AddOrGetComponent<MeshFilter>();
			MeshRenderer meshRenderer = base.gameObject.AddOrGetComponent<MeshRenderer>();
			bool flag = false;
			if (cachedInstanceID == 0 || base.gameObject.GetInstanceID() != cachedInstanceID)
			{
				flag = true;
				cachedInstanceID = base.gameObject.GetInstanceID();
			}
			Mesh mesh = meshFilter.sharedMesh;
			if (flag)
			{
				mesh = new Mesh();
			}
			if (polygons != null)
			{
				BrushFactory.GenerateMeshFromPolygonsFast(polygons, ref mesh, (mode != CSGMode.Add) ? (-0.001f) : 0.001f);
			}
			if (mode == CSGMode.Subtract)
			{
				MeshHelper.Invert(ref mesh);
			}
			meshFilter.sharedMesh = mesh;
			meshRenderer.receiveShadows = false;
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshFilter.hideFlags = HideFlags.NotEditable;
			meshRenderer.hideFlags = HideFlags.NotEditable;
			if (polygonsChanged)
			{
				RecalculateBrushCache();
			}
			UpdateVisibility();
			objectVersionSerialized++;
			objectVersionUnserialized = objectVersionSerialized;
			if (cachedWorldTransform == null)
			{
				cachedWorldTransform = new WorldTransformData(base.transform);
			}
			cachedWorldTransform.SetFromTransform(base.transform);
		}

		public override void UpdateVisibility()
		{
			CSGModelBase cSGModel = GetCSGModel();
			bool flag = false;
			if (cSGModel == null || cSGModel.AreBrushesVisible)
			{
				flag = true;
			}
			MeshRenderer component = GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = flag;
			}
		}

		public override Bounds GetBounds()
		{
			if (polygons != null && polygons.Length > 0)
			{
				Bounds result = new Bounds(polygons[0].Vertices[0].Position, Vector3.zero);
				for (int i = 0; i < polygons.Length; i++)
				{
					for (int j = 0; j < polygons[i].Vertices.Length; j++)
					{
						result.Encapsulate(polygons[i].Vertices[j].Position);
					}
				}
				return result;
			}
			return new Bounds(Vector3.zero, Vector3.zero);
		}

		public override void SetBounds(Bounds newBounds)
		{
			throw new NotImplementedException();
		}

		public override Bounds GetBoundsTransformed()
		{
			if (polygons.Length > 0)
			{
				Bounds result = new Bounds(base.transform.TransformPoint(polygons[0].Vertices[0].Position), Vector3.zero);
				for (int i = 0; i < polygons.Length; i++)
				{
					for (int j = 0; j < polygons[i].Vertices.Length; j++)
					{
						result.Encapsulate(base.transform.TransformPoint(polygons[i].Vertices[j].Position));
					}
				}
				return result;
			}
			return new Bounds(Vector3.zero, Vector3.zero);
		}

		public override Bounds GetBoundsLocalTo(Transform otherTransform)
		{
			if (polygons.Length > 0)
			{
				Bounds result = new Bounds(otherTransform.InverseTransformPoint(base.transform.TransformPoint(polygons[0].Vertices[0].Position)), Vector3.zero);
				for (int i = 0; i < polygons.Length; i++)
				{
					for (int j = 0; j < polygons[i].Vertices.Length; j++)
					{
						result.Encapsulate(otherTransform.InverseTransformPoint(base.transform.TransformPoint(polygons[i].Vertices[j].Position)));
					}
				}
				return result;
			}
			return new Bounds(Vector3.zero, Vector3.zero);
		}

		public float CalculateExtentsInAxis(Vector3 worldAxis)
		{
			Vector3 rhs = base.transform.InverseTransformDirection(worldAxis);
			float num = Vector3.Dot(polygons[0].Vertices[0].Position, rhs);
			float num2 = num;
			for (int i = 0; i < polygons.Length; i++)
			{
				for (int j = 0; j < polygons[i].Vertices.Length; j++)
				{
					float a = Vector3.Dot(polygons[i].Vertices[j].Position, rhs);
					num = Mathf.Min(a, num);
					num2 = Mathf.Max(a, num2);
				}
			}
			return num2 - num;
		}

		public override int[] GetPolygonIDs()
		{
			int[] array = new int[polygons.Length];
			for (int i = 0; i < polygons.Length; i++)
			{
				array[i] = polygons[i].UniqueIndex;
			}
			return array;
		}

		public override Polygon[] GetPolygons()
		{
			return polygons;
		}

		public override int AssignUniqueIDs(int startingIndex)
		{
			for (int i = 0; i < polygons.Length; i++)
			{
				int uniqueIndex = startingIndex + i;
				polygons[i].UniqueIndex = uniqueIndex;
			}
			return polygons.Length;
		}

		public void ResetPivot()
		{
			Vector3 center = GetBounds().center;
			for (int i = 0; i < polygons.Length; i++)
			{
				for (int j = 0; j < polygons[i].Vertices.Length; j++)
				{
					polygons[i].Vertices[j].Position -= center;
				}
			}
			base.transform.Translate(center.Multiply(base.transform.localScale));
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>(true);
			for (int k = 0; k < componentsInChildren.Length; k++)
			{
				if (componentsInChildren[k] != base.transform)
				{
					componentsInChildren[k].Translate(-center);
				}
			}
			if (center != Vector3.zero)
			{
				Invalidate(true);
			}
		}

		public GameObject Duplicate()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(base.gameObject);
			gameObject.name = base.gameObject.name;
			gameObject.transform.parent = null;
			gameObject.transform.localScale = base.transform.lossyScale;
			gameObject.transform.parent = base.transform.parent;
			gameObject.transform.position = base.transform.position;
			if (base.Volume != null)
			{
				base.Volume = UnityEngine.Object.Instantiate(base.Volume);
			}
			return gameObject;
		}

		public override void PrepareToBuild(List<Brush> brushes, bool forceRebuild)
		{
			if (forceRebuild)
			{
				brushCache.SetUnbuilt();
				RecachePolygons(true);
				RecalculateIntersections(brushes, false);
			}
		}

		public CSGModelBase GetCSGModel()
		{
			if (parentCsgModel == null)
			{
				CSGModelBase[] componentsInParent = base.transform.GetComponentsInParent<CSGModelBase>(true);
				if (componentsInParent.Length > 0)
				{
					parentCsgModel = componentsInParent[0];
				}
			}
			return parentCsgModel;
		}

		public override void UpdateCachedBrushOrder()
		{
			Transform transform = GetCSGModel().transform;
			List<int> list = new List<int>();
			Transform parent = base.transform;
			list.Add(parent.GetSiblingIndex());
			while (parent.parent != null && parent.parent != transform)
			{
				parent = parent.parent;
				list.Add(parent.GetSiblingIndex());
			}
			BrushOrder brushOrder = new BrushOrder();
			int count = list.Count;
			brushOrder.Position = new int[count];
			for (int i = 0; i < count; i++)
			{
				brushOrder.Position[i] = list[count - 1 - i];
			}
			cachedBrushOrder = brushOrder;
		}

		public override BrushOrder GetBrushOrder()
		{
			if (cachedBrushOrder == null)
			{
				UpdateCachedBrushOrder();
			}
			return cachedBrushOrder;
		}
	}
}
