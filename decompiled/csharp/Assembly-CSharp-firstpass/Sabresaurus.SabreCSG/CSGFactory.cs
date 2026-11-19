using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public static class CSGFactory
{
	private const bool ENABLE_OPTIMIZE_GEOMETRY = false;

	private static List<Brush> brushes;

	private static CSGBuildSettings buildSettings;

	private static CSGBuildContext.BuildContext buildContext;

	private static Transform rootTransform;

	private static MaterialMeshDictionary materialMeshDictionary;

	private static List<Mesh> collisionMeshDictionary;

	private static bool polygonsRemoved;

	private static bool forceRebuild;

	private static Action<float> onProgressChange;

	private static Action<GameObject, Mesh> onFinalizeVisualMesh;

	private static Action<GameObject, Mesh> onFinalizeCollisionMesh;

	private static DateTime buildStartTime = DateTime.Now;

	private static DateTime time1 = DateTime.Now;

	private static int brushesBuilt = 0;

	private static bool buildInProgress = false;

	private static bool readyForFinalize = false;

	private static Transform meshGroup;

	private static Transform meshGroupHolder;

	private static bool Prepare(Transform rootTransform)
	{
		meshGroupHolder = rootTransform.Find("MeshGroup");
		if (meshGroupHolder != null)
		{
			meshGroupHolder.SetAsLastSibling();
			return false;
		}
		meshGroupHolder = rootTransform.AddChild("MeshGroup");
		return true;
	}

	internal static BuildStatus Build(List<Brush> brushes, CSGBuildSettings buildSettings, CSGBuildContext.BuildContext buildContext, Transform rootTransform, MaterialMeshDictionary materialMeshDictionary, List<Mesh> collisionMeshDictionary, bool polygonsRemoved, bool forceRebuild, Action<float> onProgressChange, Action<GameObject, Mesh> onFinalizeVisualMesh, Action<GameObject, Mesh> onFinalizeCollisionMesh, bool multithreaded)
	{
		CSGFactory.brushes = brushes;
		CSGFactory.buildSettings = buildSettings;
		CSGFactory.buildContext = buildContext;
		CSGFactory.rootTransform = rootTransform;
		CSGFactory.materialMeshDictionary = materialMeshDictionary;
		CSGFactory.collisionMeshDictionary = collisionMeshDictionary;
		CSGFactory.polygonsRemoved = polygonsRemoved;
		CSGFactory.forceRebuild = forceRebuild;
		CSGFactory.onProgressChange = onProgressChange;
		CSGFactory.onFinalizeVisualMesh = onFinalizeVisualMesh;
		CSGFactory.onFinalizeCollisionMesh = onFinalizeCollisionMesh;
		if (buildInProgress)
		{
			Debug.LogWarning("Existing build has not completed");
		}
		if (multithreaded)
		{
			readyForFinalize = false;
			buildInProgress = true;
			ThreadPool.QueueUserWorkItem(CoreBuild, true);
			return BuildStatus.Started;
		}
		readyForFinalize = false;
		CoreBuild(null);
		bool flag = FinalizeBuild();
		buildInProgress = false;
		return flag ? BuildStatus.Complete : BuildStatus.Unnecessary;
	}

	internal static void CoreBuild(object state)
	{
		MeshGroupManager.OnFinalizeVisualMesh = onFinalizeVisualMesh;
		MeshGroupManager.OnFinalizeCollisionMesh = onFinalizeCollisionMesh;
		if (forceRebuild)
		{
			buildContext.ClearAll();
		}
		buildStartTime = DateTime.Now;
		int num = 0;
		brushesBuilt = 0;
		BrushCache[] array = new BrushCache[brushes.Count];
		int num2 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = brushes[i].BrushCache;
			num2 += array[i].Polygons.Length;
		}
		PolygonEntry[] visualPolygonIndex = buildContext.VisualPolygonIndex;
		PolygonEntry[] collisionPolygonIndex = buildContext.CollisionPolygonIndex;
		PolygonEntry[] array2 = new PolygonEntry[num2];
		PolygonEntry[] array3 = new PolygonEntry[num2];
		int num3 = 0;
		for (int j = 0; j < array.Length; j++)
		{
			brushes[j].AssignUniqueIDs(num3);
			num3 += array[j].AssignUniqueIDs(num3, brushes[j].IsVisible, visualPolygonIndex, array2, brushes[j].HasCollision, collisionPolygonIndex, array3);
		}
		buildContext.VisualPolygonIndex = array2;
		buildContext.CollisionPolygonIndex = array3;
		bool[] array4 = new bool[array.Length];
		bool[] array5 = new bool[array.Length];
		for (int k = 0; k < array.Length; k++)
		{
			if (array[k].Built || !brushes[k].IsVisible)
			{
				continue;
			}
			array4[k] = true;
			num++;
			foreach (BrushCache intersectingVisualBrushCache in array[k].IntersectingVisualBrushCaches)
			{
				int num4 = Array.IndexOf(array, intersectingVisualBrushCache);
				if (num4 == -1 || array4[num4] || !brushes[num4].IsVisible)
				{
					continue;
				}
				array4[num4] = true;
				num++;
				if (brushes[num4].Mode != CSGMode.Subtract)
				{
					continue;
				}
				foreach (BrushCache intersectingVisualBrushCache2 in array[num4].IntersectingVisualBrushCaches)
				{
					int num5 = Array.IndexOf(array, intersectingVisualBrushCache2);
					if (num5 != -1 && !array4[num5] && brushes[num5].IsVisible)
					{
						array4[num5] = true;
						num++;
					}
				}
			}
		}
		for (int l = 0; l < array.Length; l++)
		{
			if (array[l].Built || !brushes[l].HasCollision)
			{
				continue;
			}
			array5[l] = true;
			foreach (BrushCache intersectingCollisionBrushCache in array[l].IntersectingCollisionBrushCaches)
			{
				int num6 = Array.IndexOf(array, intersectingCollisionBrushCache);
				if (num6 == -1 || array5[num6] || !brushes[num6].HasCollision)
				{
					continue;
				}
				array5[num6] = true;
				num++;
				if (brushes[num6].Mode != CSGMode.Subtract)
				{
					continue;
				}
				foreach (BrushCache intersectingCollisionBrushCache2 in array[num6].IntersectingCollisionBrushCaches)
				{
					int num7 = Array.IndexOf(array, intersectingCollisionBrushCache2);
					if (num7 != -1 && !array5[num7] && brushes[num7].HasCollision)
					{
						array5[num7] = true;
						num++;
					}
				}
			}
		}
		for (int m = 0; m < array.Length; m++)
		{
			if (array4[m] || array5[m])
			{
				array[m].ResetForBuild(array2, array3);
			}
		}
		bool flag = false;
		if (DateTime.Now - buildStartTime > new TimeSpan(0, 0, 1))
		{
			flag = true;
			if (state == null && onProgressChange != null)
			{
				onProgressChange(0f);
			}
		}
		for (int n = 0; n < array.Length; n++)
		{
			if (!array4[n])
			{
				continue;
			}
			BrushBuilder.Build(array[n], n, array, isCollisionPass: false);
			brushesBuilt++;
			if (!array5[n] || !buildSettings.GenerateCollisionMeshes)
			{
				array[n].SetBuilt();
			}
			if (flag)
			{
				if (state == null && onProgressChange != null)
				{
					onProgressChange((float)brushesBuilt / (float)num);
				}
			}
			else if (DateTime.Now - buildStartTime > new TimeSpan(0, 0, 1))
			{
				flag = true;
				if (state == null && onProgressChange != null)
				{
					onProgressChange((float)brushesBuilt / (float)num);
				}
			}
		}
		for (int num8 = 0; num8 < array.Length; num8++)
		{
			if (array4[num8])
			{
				BrushCache.ReclaimStolenVisualPolygons(array[num8]);
			}
		}
		if (buildSettings.GenerateCollisionMeshes)
		{
			for (int num9 = 0; num9 < array.Length; num9++)
			{
				if (!array5[num9])
				{
					continue;
				}
				if (!array[num9].CollisionVisualEqual)
				{
					BrushBuilder.Build(array[num9], num9, array, isCollisionPass: true);
					brushesBuilt++;
					if (flag)
					{
						if (state == null && onProgressChange != null)
						{
							onProgressChange((float)brushesBuilt / (float)num);
						}
					}
					else if (DateTime.Now - buildStartTime > new TimeSpan(0, 0, 1))
					{
						flag = true;
						if (state == null && onProgressChange != null)
						{
							onProgressChange((float)brushesBuilt / (float)num);
						}
					}
				}
				array[num9].SetBuilt();
			}
			for (int num10 = 0; num10 < array.Length; num10++)
			{
				if (array5[num10] && !array[num10].CollisionVisualEqual)
				{
					BrushCache.ReclaimStolenCollisionPolygons(array[num10]);
				}
			}
		}
		time1 = DateTime.Now;
		if (brushesBuilt > 0)
		{
			Dictionary<int, List<Polygon>> dictionary = new Dictionary<int, List<Polygon>>();
			for (int num11 = 0; num11 < array.Length; num11++)
			{
				if (!array4[num11])
				{
					continue;
				}
				Dictionary<int, List<Polygon>> dictionary2 = null;
				dictionary2 = ((!buildSettings.OptimizeGeometry) ? array[num11].GetGroupedBuiltVisualPolygons() : BrushCache.OptimizeVisual(array[num11]));
				List<Polygon> builtVisualPolygons = array[num11].BuiltVisualPolygons;
				buildContext.SetVisualMapping(brushes[num11], builtVisualPolygons);
				foreach (KeyValuePair<int, List<Polygon>> item in dictionary2)
				{
					dictionary.Add(item.Key, item.Value);
				}
			}
			bool generateLightmapUVs = buildSettings.GenerateLightmapUVs;
			MeshGroupManager.TriangulateNewPolygons(generateLightmapUVs, dictionary, buildContext.VisualPolygonIndex);
			if (buildSettings.GenerateCollisionMeshes)
			{
				dictionary.Clear();
				for (int num12 = 0; num12 < array.Length; num12++)
				{
					if (!array5[num12])
					{
						continue;
					}
					if (array[num12].CollisionVisualEqual)
					{
						List<Polygon> builtVisualPolygons2 = array[num12].BuiltVisualPolygons;
						for (int num13 = 0; num13 < builtVisualPolygons2.Count; num13++)
						{
							PolygonEntry polygonEntry = buildContext.VisualPolygonIndex[builtVisualPolygons2[num13].UniqueIndex];
							if (polygonEntry != null)
							{
								buildContext.CollisionPolygonIndex[builtVisualPolygons2[num13].UniqueIndex] = polygonEntry.DeepCopy();
							}
						}
						continue;
					}
					Dictionary<int, List<Polygon>> dictionary3 = null;
					dictionary3 = ((!buildSettings.OptimizeGeometry) ? array[num12].GetGroupedBuiltCollisionPolygons() : BrushCache.OptimizeCollision(array[num12]));
					foreach (KeyValuePair<int, List<Polygon>> item2 in dictionary3)
					{
						dictionary.Add(item2.Key, item2.Value);
					}
				}
				generateLightmapUVs = false;
				MeshGroupManager.TriangulateNewPolygons(generateLightmapUVs, dictionary, buildContext.CollisionPolygonIndex);
			}
		}
		if (state != null)
		{
			readyForFinalize = true;
		}
	}

	internal static bool FinalizeBuild()
	{
		if (brushesBuilt > 0)
		{
			buildContext.WriteVisualMappings();
		}
		bool flag = Prepare(rootTransform);
		if (brushesBuilt > 0 || polygonsRemoved || flag)
		{
			MeshGroupManager.Cleanup(meshGroupHolder);
			MeshGroupManager.BuildVisual(meshGroupHolder, buildContext.VisualPolygonIndex, buildSettings, buildContext, materialMeshDictionary);
			if (buildSettings.GenerateCollisionMeshes)
			{
				MeshGroupManager.BuildCollision(meshGroupHolder, buildContext.CollisionPolygonIndex, buildSettings, collisionMeshDictionary);
			}
			DateTime now = DateTime.Now;
			buildContext.buildMetrics.BuildMetaData = (time1 - buildStartTime).TotalSeconds + " " + (now - time1).TotalSeconds + " " + brushesBuilt;
			buildContext.buildMetrics.BuildTime = (float)(DateTime.Now - buildStartTime).TotalSeconds;
			buildInProgress = false;
			return true;
		}
		buildInProgress = false;
		return false;
	}

	internal static bool Tick()
	{
		if (readyForFinalize)
		{
			readyForFinalize = false;
			return FinalizeBuild();
		}
		return false;
	}

	public static GameObject CreateMaterialMesh(Transform rootTransform, Material material, Mesh mesh)
	{
		meshGroup = rootTransform.Find("MeshGroup");
		if (meshGroup == null)
		{
			meshGroup = new GameObject("MeshGroup").transform;
			meshGroup.parent = rootTransform;
		}
		GameObject gameObject = new GameObject("MaterialMesh", typeof(MeshFilter), typeof(MeshRenderer));
		gameObject.transform.SetParent(meshGroup, worldPositionStays: false);
		gameObject.GetComponent<MeshFilter>().sharedMesh = mesh;
		gameObject.GetComponent<Renderer>().material = material;
		return gameObject;
	}

	public static GameObject CreateCollisionMesh(Transform rootTransform, Mesh mesh)
	{
		meshGroup = rootTransform.Find("MeshGroup");
		if (meshGroup == null)
		{
			meshGroup = new GameObject("MeshGroup").transform;
			meshGroup.parent = rootTransform;
		}
		GameObject gameObject = new GameObject("CollisionMesh", typeof(MeshCollider));
		gameObject.transform.SetParent(meshGroup, worldPositionStays: false);
		gameObject.GetComponent<MeshCollider>().sharedMesh = mesh;
		return gameObject;
	}
}
