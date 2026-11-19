using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sabresaurus.SabreCSG
{
	internal static class MeshGroupManager
	{
		internal static Action<GameObject, Mesh> OnFinalizeVisualMesh;

		internal static Action<GameObject, Mesh> OnFinalizeCollisionMesh;

		private const int MESH_VERTEX_LIMIT = 65500;

		internal static void Cleanup(Transform meshGroupHolder)
		{
			MeshFilter[] componentsInChildren = meshGroupHolder.GetComponentsInChildren<MeshFilter>();
			MeshCollider[] componentsInChildren2 = meshGroupHolder.GetComponentsInChildren<MeshCollider>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(componentsInChildren[i].sharedMesh);
			}
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				UnityEngine.Object.DestroyImmediate(componentsInChildren2[j].sharedMesh);
			}
			meshGroupHolder.DestroyChildrenImmediate();
		}

		internal static void BuildVisual(Transform meshGroupHolder, PolygonEntry[] polygonIndex, CSGBuildSettings buildSettings, CSGBuildContext.BuildContext buildContext, MaterialMeshDictionary materialMeshDictionary)
		{
			materialMeshDictionary.Clear();
			buildContext.buildMetrics.TotalMeshes = 0;
			buildContext.buildMetrics.TotalVertices = 0;
			buildContext.buildMetrics.TotalTriangles = 0;
			Dictionary<Material, List<PolygonEntry>> dictionary = new Dictionary<Material, List<PolygonEntry>>();
			foreach (PolygonEntry polygonEntry in polygonIndex)
			{
				if (PolygonEntry.IsValid(polygonEntry) && polygonEntry.Positions.Length > 0 && !polygonEntry.ExcludeFromBuild)
				{
					Material material = polygonEntry.Material;
					if (material == null)
					{
						material = buildSettings.DefaultVisualMaterial;
					}
					if (dictionary.ContainsKey(material))
					{
						dictionary[material].Add(polygonEntry);
						continue;
					}
					dictionary.Add(material, new List<PolygonEntry> { polygonEntry });
				}
			}
			foreach (KeyValuePair<Material, List<PolygonEntry>> item in dictionary)
			{
				Mesh mesh = new Mesh();
				List<Vector3> list = new List<Vector3>();
				List<Vector3> list2 = new List<Vector3>();
				List<Vector2> list3 = new List<Vector2>();
				List<Color32> list4 = new List<Color32>();
				List<int> list5 = new List<int>();
				for (int j = 0; j < item.Value.Count; j++)
				{
					int num = list.Count;
					int count = list5.Count;
					PolygonEntry polygonEntry2 = item.Value[j];
					if (polygonEntry2.Positions.Length + num > 65500)
					{
						FinalizeVisualMesh(meshGroupHolder, mesh, item.Key, buildSettings, buildContext, list, list2, list3, list4, list5, materialMeshDictionary);
						mesh = new Mesh();
						list.Clear();
						list2.Clear();
						list3.Clear();
						list4.Clear();
						list5.Clear();
						num = 0;
					}
					list.AddRange(polygonEntry2.Positions);
					list2.AddRange(polygonEntry2.Normals);
					list3.AddRange(polygonEntry2.UV);
					list4.AddRange(polygonEntry2.Colors);
					for (int k = 0; k < polygonEntry2.Triangles.Length; k++)
					{
						list5.Add(polygonEntry2.Triangles[k] + num);
					}
					item.Value[j].BuiltMesh = mesh;
					item.Value[j].BuiltVertexOffset = num;
					item.Value[j].BuiltTriangleOffset = count;
				}
				FinalizeVisualMesh(meshGroupHolder, mesh, item.Key, buildSettings, buildContext, list, list2, list3, list4, list5, materialMeshDictionary);
			}
		}

		internal static void FinalizeVisualMesh(Transform meshGroupHolder, Mesh mesh, Material material, CSGBuildSettings buildSettings, CSGBuildContext.BuildContext buildContext, List<Vector3> positionsList, List<Vector3> normalsList, List<Vector2> uvList, List<Color32> colorsList, List<int> trianglesList, MaterialMeshDictionary materialMeshDictionary)
		{
			Vector3[] array = new Vector3[positionsList.Count];
			Vector3[] array2 = new Vector3[normalsList.Count];
			Vector2[] array3 = new Vector2[uvList.Count];
			Color32[] array4 = new Color32[colorsList.Count];
			int[] array5 = new int[trianglesList.Count];
			positionsList.CopyTo(array);
			normalsList.CopyTo(array2);
			uvList.CopyTo(array3);
			trianglesList.CopyTo(array5);
			colorsList.CopyTo(array4);
			mesh.vertices = array;
			mesh.normals = array2;
			mesh.uv = array3;
			mesh.colors32 = array4;
			if (meshGroupHolder.position != Vector3.zero || meshGroupHolder.rotation != Quaternion.identity || meshGroupHolder.lossyScale != Vector3.one)
			{
				mesh.LocalizeToTransform(meshGroupHolder);
			}
			mesh.triangles = array5;
			if (buildSettings.GenerateTangents)
			{
				mesh.GenerateTangents();
			}
			buildContext.buildMetrics.TotalMeshes++;
			buildContext.buildMetrics.TotalVertices += array.Length;
			buildContext.buildMetrics.TotalTriangles += array5.Length / 3;
			GameObject gameObject = new GameObject("MaterialMesh");
			if (OnFinalizeVisualMesh != null)
			{
				OnFinalizeVisualMesh(gameObject, mesh);
			}
			gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
			meshRenderer.sharedMaterial = material;
			meshRenderer.shadowCastingMode = buildSettings.ShadowCastingMode;
			meshRenderer.lightProbeUsage = LightProbeUsage.Off;
			meshRenderer.reflectionProbeUsage = buildSettings.ReflectionProbeUsage;
			gameObject.transform.SetParent(meshGroupHolder, false);
			materialMeshDictionary.Add(material, mesh, gameObject);
		}

		internal static void BuildCollision(Transform meshGroupHolder, PolygonEntry[] polygonIndex, CSGBuildSettings buildSettings, List<Mesh> collisionMeshDictionary)
		{
			collisionMeshDictionary.Clear();
			if (polygonIndex.Length <= 0)
			{
				return;
			}
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<Vector3> list2 = new List<Vector3>();
			List<Vector2> list3 = new List<Vector2>();
			List<int> list4 = new List<int>();
			for (int i = 0; i < polygonIndex.Length; i++)
			{
				if (polygonIndex[i] == null)
				{
					continue;
				}
				int num = list.Count;
				int count = list4.Count;
				PolygonEntry polygonEntry = polygonIndex[i];
				if (PolygonEntry.IsValid(polygonEntry) && polygonEntry.Positions.Length > 0 && !polygonEntry.ExcludeFromBuild)
				{
					if (polygonEntry.Positions.Length + num > 65500)
					{
						FinalizeCollisionMesh(meshGroupHolder, mesh, buildSettings, list, list2, list3, list4, collisionMeshDictionary);
						mesh = new Mesh();
						list.Clear();
						list2.Clear();
						list3.Clear();
						list4.Clear();
						num = 0;
					}
					list.AddRange(polygonEntry.Positions);
					list2.AddRange(polygonEntry.Normals);
					list3.AddRange(polygonEntry.UV);
					for (int j = 0; j < polygonEntry.Triangles.Length; j++)
					{
						list4.Add(polygonEntry.Triangles[j] + num);
					}
					polygonEntry.BuiltMesh = mesh;
					polygonEntry.BuiltVertexOffset = num;
					polygonEntry.BuiltTriangleOffset = count;
				}
			}
			FinalizeCollisionMesh(meshGroupHolder, mesh, buildSettings, list, list2, list3, list4, collisionMeshDictionary);
		}

		internal static void FinalizeCollisionMesh(Transform meshGroupHolder, Mesh mesh, CSGBuildSettings buildSettings, List<Vector3> positionsList, List<Vector3> normalsList, List<Vector2> uvList, List<int> trianglesList, List<Mesh> collisionMeshDictionary)
		{
			Vector3[] array = new Vector3[positionsList.Count];
			Vector3[] array2 = new Vector3[normalsList.Count];
			Vector2[] array3 = new Vector2[uvList.Count];
			int[] array4 = new int[trianglesList.Count];
			positionsList.CopyTo(array);
			normalsList.CopyTo(array2);
			uvList.CopyTo(array3);
			trianglesList.CopyTo(array4);
			mesh.vertices = array;
			mesh.normals = array2;
			mesh.uv = array3;
			if (meshGroupHolder.position != Vector3.zero || meshGroupHolder.rotation != Quaternion.identity || meshGroupHolder.lossyScale != Vector3.one)
			{
				mesh.LocalizeToTransform(meshGroupHolder);
			}
			mesh.triangles = array4;
			GameObject gameObject = new GameObject("CollisionMesh");
			if (OnFinalizeCollisionMesh != null)
			{
				OnFinalizeCollisionMesh(gameObject, mesh);
			}
			MeshCollider meshCollider = gameObject.AddComponent<MeshCollider>();
			meshCollider.sharedMesh = mesh;
			meshCollider.sharedMaterial = buildSettings.DefaultPhysicsMaterial;
			gameObject.transform.SetParent(meshGroupHolder, false);
			collisionMeshDictionary.Add(mesh);
		}

		internal static void TriangulateNewPolygons(bool individualVertices, Dictionary<int, List<Polygon>> groupedPolygons, PolygonEntry[] polygonIndex)
		{
			foreach (KeyValuePair<int, List<Polygon>> groupedPolygon in groupedPolygons)
			{
				List<Polygon> value = groupedPolygon.Value;
				int[] triangesToAppend;
				Vector3[] positions;
				Vector3[] normals;
				Vector2[] uv;
				Color32[] colors;
				TriangulatePolygons(individualVertices, value, out triangesToAppend, out positions, out normals, out uv, out colors);
				polygonIndex[groupedPolygon.Key] = new PolygonEntry(positions, normals, uv, colors, triangesToAppend, value[0].Material, value[0].UserExcludeFromFinal);
			}
		}

		internal static void TriangulatePolygons(bool individualVertices, List<Polygon> polygons, out int[] triangesToAppend, out Vector3[] positions, out Vector3[] normals, out Vector2[] uv, out Color32[] colors)
		{
			if (individualVertices)
			{
				int num = 0;
				for (int i = 0; i < polygons.Count; i++)
				{
					num += polygons[i].Vertices.Length - 2;
				}
				int num2 = num * 3;
				positions = new Vector3[num2];
				normals = new Vector3[num2];
				uv = new Vector2[num2];
				colors = new Color32[num2];
				triangesToAppend = new int[num * 3];
				int num3 = 0;
				int num4 = 0;
				for (int j = 0; j < polygons.Count; j++)
				{
					Polygon polygon = polygons[j];
					int num5 = polygons[j].Vertices.Length - 2;
					for (int k = 0; k < num5; k++)
					{
						int num6 = 0;
						positions[num4 + k * 3] = polygon.Vertices[num6].Position;
						normals[num4 + k * 3] = polygon.Vertices[num6].Normal;
						uv[num4 + k * 3] = polygon.Vertices[num6].UV;
						colors[num4 + k * 3] = polygon.Vertices[num6].Color;
						num6 = k + 1;
						positions[num4 + k * 3 + 1] = polygon.Vertices[num6].Position;
						normals[num4 + k * 3 + 1] = polygon.Vertices[num6].Normal;
						uv[num4 + k * 3 + 1] = polygon.Vertices[num6].UV;
						colors[num4 + k * 3 + 1] = polygon.Vertices[num6].Color;
						num6 = k + 2;
						positions[num4 + k * 3 + 2] = polygon.Vertices[num6].Position;
						normals[num4 + k * 3 + 2] = polygon.Vertices[num6].Normal;
						uv[num4 + k * 3 + 2] = polygon.Vertices[num6].UV;
						colors[num4 + k * 3 + 2] = polygon.Vertices[num6].Color;
					}
					for (int l = 0; l < num5; l++)
					{
						triangesToAppend[num3] = num3;
						triangesToAppend[num3 + 1] = num3 + 1;
						triangesToAppend[num3 + 2] = num3 + 2;
						num3 += 3;
					}
					num4 += num5 * 3;
				}
				return;
			}
			int num7 = 0;
			for (int m = 0; m < polygons.Count; m++)
			{
				num7 += polygons[m].Vertices.Length;
			}
			int num8 = num7 - 2 * polygons.Count;
			positions = new Vector3[num7];
			normals = new Vector3[num7];
			uv = new Vector2[num7];
			colors = new Color32[num7];
			triangesToAppend = new int[num8 * 3];
			int num9 = 0;
			int num10 = 0;
			for (int n = 0; n < polygons.Count; n++)
			{
				Polygon polygon2 = polygons[n];
				int num11 = polygon2.Vertices.Length;
				for (int num12 = 0; num12 < num11; num12++)
				{
					positions[num10 + num12] = polygon2.Vertices[num12].Position;
					normals[num10 + num12] = polygon2.Vertices[num12].Normal;
					uv[num10 + num12] = polygon2.Vertices[num12].UV;
					colors[num10 + num12] = polygon2.Vertices[num12].Color;
				}
				for (int num13 = 2; num13 < num11; num13++)
				{
					triangesToAppend[num9] = num10;
					triangesToAppend[num9 + 1] = num10 + (num13 - 1);
					triangesToAppend[num9 + 2] = num10 + num13;
					num9 += 3;
				}
				num10 += num11;
			}
		}
	}
}
