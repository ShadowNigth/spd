using System.Collections.Generic;
using System.Linq;
using Sabresaurus.SabreCSG.ShapeEditor;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

internal static class PolygonFactory
{
	internal class SortVectorsClockwise : IComparer<Vector3>
	{
		private Quaternion cancellingRotation;

		private Vector3 rotatedCenter;

		public SortVectorsClockwise(Quaternion cancellingRotation, Vector3 rotatedCenter)
		{
			this.cancellingRotation = cancellingRotation;
			this.rotatedCenter = rotatedCenter;
		}

		public int Compare(Vector3 position1, Vector3 position2)
		{
			Vector3 vector = cancellingRotation * position1 - rotatedCenter;
			Vector3 vector2 = cancellingRotation * position2 - rotatedCenter;
			float num = Mathf.Atan2(vector.x, vector.y);
			float value = Mathf.Atan2(vector2.x, vector2.y);
			return num.CompareTo(value);
		}
	}

	internal class SortVerticesClockwise : IComparer<Vertex>
	{
		private Quaternion cancellingRotation;

		private Vector3 rotatedCenter;

		public SortVerticesClockwise(Quaternion cancellingRotation, Vector3 rotatedCenter)
		{
			this.cancellingRotation = cancellingRotation;
			this.rotatedCenter = rotatedCenter;
		}

		public int Compare(Vertex vertex1, Vertex vertex2)
		{
			Vector3 vector = cancellingRotation * vertex1.Position - rotatedCenter;
			Vector3 vector2 = cancellingRotation * vertex2.Position - rotatedCenter;
			float num = Mathf.Atan2(vector.x, vector.y);
			float value = Mathf.Atan2(vector2.x, vector2.y);
			return num.CompareTo(value);
		}
	}

	internal class SortVerticesByXThenY : IComparer<KeyValuePair<Vertex, Vector3>>
	{
		public int Compare(KeyValuePair<Vertex, Vector3> vertex1, KeyValuePair<Vertex, Vector3> vertex2)
		{
			Vector3 value = vertex1.Value;
			Vector3 value2 = vertex2.Value;
			if (value.x != value2.x)
			{
				return value.x.CompareTo(value2.x);
			}
			return value.y.CompareTo(value2.y);
		}
	}

	internal static bool SplitPolygonsByPlane(List<Polygon> polygons, Plane splitPlane, bool excludeNewPolygons, out List<Polygon> polygonsFront, out List<Polygon> polygonsBack)
	{
		polygonsFront = new List<Polygon>();
		polygonsBack = new List<Polygon>();
		if (!GeometryHelper.PolygonsIntersectPlane(polygons, splitPlane))
		{
			return false;
		}
		List<Vertex> list = new List<Vertex>();
		for (int i = 0; i < polygons.Count; i++)
		{
			Polygon.PolygonPlaneRelation polygonPlaneRelation = Polygon.TestPolygonAgainstPlane(polygons[i], splitPlane);
			if (polygonPlaneRelation == Polygon.PolygonPlaneRelation.Spanning)
			{
				if (Polygon.SplitPolygon(polygons[i], out var frontPolygon, out var backPolygon, out var newVertex, out var newVertex2, splitPlane))
				{
					polygonsFront.Add(frontPolygon);
					polygonsBack.Add(backPolygon);
					list.Add(newVertex);
					list.Add(newVertex2);
				}
				else if (frontPolygon != null)
				{
					polygonPlaneRelation = Polygon.PolygonPlaneRelation.InFront;
				}
				else if (backPolygon != null)
				{
					polygonPlaneRelation = Polygon.PolygonPlaneRelation.Behind;
				}
				else
				{
					polygonPlaneRelation = Polygon.PolygonPlaneRelation.InFront;
					Debug.LogError("Polygon splitting has resulted in two zero area polygons. This is unhandled.");
				}
			}
			if (polygonPlaneRelation == Polygon.PolygonPlaneRelation.Spanning)
			{
				continue;
			}
			for (int j = 0; j < polygons[i].Vertices.Length; j++)
			{
				if (Polygon.ComparePointToPlane(polygons[i].Vertices[j].Position, splitPlane) == Polygon.PointPlaneRelation.On)
				{
					list.Add(polygons[i].Vertices[j]);
				}
			}
			if (polygonPlaneRelation == Polygon.PolygonPlaneRelation.Behind)
			{
				polygonsBack.Add(polygons[i]);
			}
			else
			{
				polygonsFront.Add(polygons[i]);
			}
		}
		if (list.Count > 0 && polygonsBack.Count >= 3 && polygonsFront.Count >= 3)
		{
			List<Vector3> list2 = new List<Vector3>(list.Count);
			for (int k = 0; k < list.Count; k++)
			{
				list2.Add(list[k].Position);
			}
			Polygon polygon = ConstructPolygon(list2, removeExtraPositions: true);
			if (polygon != null)
			{
				if (!MathHelper.PlaneEqualsLooser(polygon.Plane, splitPlane) && Vector3.Dot(polygon.Plane.normal, splitPlane.normal) < -0.9f)
				{
					polygon.Flip();
				}
				polygon.ExcludeFromFinal = excludeNewPolygons;
				polygonsFront.Add(polygon);
				polygon = polygon.DeepCopy();
				polygon.Flip();
				polygon.ExcludeFromFinal = excludeNewPolygons;
				if (polygon.Plane.normal == Vector3.zero)
				{
					Debug.LogError("Invalid Normal! Shouldn't be zero. This is unexpected since extraneous positions should have been removed!");
				}
				polygonsBack.Add(polygon);
			}
			return true;
		}
		return false;
	}

	internal static bool SplitCoplanarPolygonsByPlane(List<Polygon> polygons, Plane splitPlane, out List<Polygon> polygonsFront, out List<Polygon> polygonsBack)
	{
		polygonsFront = new List<Polygon>();
		polygonsBack = new List<Polygon>();
		for (int i = 0; i < polygons.Count; i++)
		{
			Polygon.PolygonPlaneRelation polygonPlaneRelation = Polygon.TestPolygonAgainstPlane(polygons[i], splitPlane);
			if (polygonPlaneRelation == Polygon.PolygonPlaneRelation.Spanning)
			{
				if (Polygon.SplitPolygon(polygons[i], out var frontPolygon, out var backPolygon, out var _, out var _, splitPlane))
				{
					polygonsFront.Add(frontPolygon);
					polygonsBack.Add(backPolygon);
				}
				else if (frontPolygon != null)
				{
					polygonPlaneRelation = Polygon.PolygonPlaneRelation.InFront;
				}
				else if (backPolygon != null)
				{
					polygonPlaneRelation = Polygon.PolygonPlaneRelation.Behind;
				}
				else
				{
					polygonPlaneRelation = Polygon.PolygonPlaneRelation.InFront;
					Debug.LogError("Polygon splitting has resulted in two zero area polygons. This is unhandled.");
				}
			}
			switch (polygonPlaneRelation)
			{
			case Polygon.PolygonPlaneRelation.Behind:
				polygonsBack.Add(polygons[i]);
				break;
			default:
				polygonsFront.Add(polygons[i]);
				break;
			case Polygon.PolygonPlaneRelation.Spanning:
				break;
			}
		}
		if (polygonsBack.Count >= 1 && polygonsFront.Count >= 1)
		{
			return true;
		}
		return false;
	}

	public static Polygon ConstructPolygon(List<Vector3> sourcePositions, bool removeExtraPositions)
	{
		List<Vector3> list;
		if (removeExtraPositions)
		{
			list = new List<Vector3>();
			for (int i = 0; i < sourcePositions.Count; i++)
			{
				Vector3 vector = sourcePositions[i];
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].EqualsWithEpsilonLower(vector))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(vector);
				}
			}
		}
		else
		{
			list = sourcePositions;
		}
		if (list.Count < 3)
		{
			return null;
		}
		Vector3 vector2 = list[0];
		for (int k = 1; k < list.Count; k++)
		{
			vector2 += list[k];
		}
		vector2 *= 1f / (float)list.Count;
		if (list.Count < 3)
		{
			Debug.LogError("Position count is below 3, this is probably unhandled");
		}
		Plane plane = new Plane(list[0], list[1], list[2]);
		Quaternion quaternion = ((!(plane.normal != Vector3.zero)) ? Quaternion.identity : Quaternion.Inverse(Quaternion.LookRotation(plane.normal)));
		Vector3 rotatedCenter = quaternion * vector2;
		IComparer<Vector3> comparer = new SortVectorsClockwise(quaternion, rotatedCenter);
		list.Sort(comparer);
		Vertex[] array = new Vertex[list.Count];
		for (int l = 0; l < list.Count; l++)
		{
			array[l] = new Vertex(list[l], -plane.normal, quaternion * list[l] * 0.5f);
		}
		Polygon polygon = new Polygon(array, null, isTemporary: false, userExcludeFromFinal: false);
		if (polygon.Plane.normal == Vector3.zero)
		{
			Debug.LogError("Zero normal found, this leads to invalid polyhedron-point tests");
			return null;
		}
		return polygon;
	}

	public static List<Vertex> RefineVertices(Vector3 normal, List<Vertex> sourceVertices, bool removeExtraPositions, bool removeCollinearPoints, bool constructConvexHull)
	{
		List<Vertex> list;
		if (removeExtraPositions)
		{
			list = new List<Vertex>();
			for (int i = 0; i < sourceVertices.Count; i++)
			{
				Vertex vertex = sourceVertices[i];
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].Position.EqualsWithEpsilonLower(vertex.Position))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(vertex);
				}
			}
		}
		else
		{
			list = sourceVertices;
		}
		if (list.Count < 3)
		{
			return null;
		}
		Vector3 position = list[0].Position;
		for (int k = 1; k < list.Count; k++)
		{
			position += list[k].Position;
		}
		position *= 1f / (float)list.Count;
		if (list.Count < 3)
		{
			Debug.LogError("Vertex count is below 3, this is probably unhandled");
		}
		Quaternion quaternion = ((!(normal != Vector3.zero)) ? Quaternion.identity : Quaternion.Inverse(Quaternion.LookRotation(normal)));
		Vector3 rotatedCenter = quaternion * position;
		if (constructConvexHull)
		{
			list = CalculateConvexHull(list, quaternion, rotatedCenter);
		}
		IComparer<Vertex> comparer = new SortVerticesClockwise(quaternion, rotatedCenter);
		list.Sort(comparer);
		if (removeCollinearPoints)
		{
			List<Vertex> list2 = new List<Vertex>();
			Vector3 lhs = (list[0].Position - list[list.Count - 1].Position).normalized;
			for (int l = 0; l < list.Count; l++)
			{
				Vector3 normalized = (list[(l + 1) % list.Count].Position - list[l].Position).normalized;
				if (Vector3.Dot(lhs, normalized) < 1f)
				{
					list2.Add(list[l]);
				}
				lhs = normalized;
			}
			list = list2;
		}
		list.Reverse();
		return list;
	}

	public static float Cross(Vector3 origin, Vector3 pointA, Vector3 pointB)
	{
		return (pointA.x - origin.x) * (pointB.y - origin.y) - (pointA.y - origin.y) * (pointB.x - origin.x);
	}

	public static List<Vertex> CalculateConvexHull(List<Vertex> positions, Quaternion cancellingRotation, Vector3 rotatedCenter)
	{
		List<KeyValuePair<Vertex, Vector3>> list = new List<KeyValuePair<Vertex, Vector3>>(positions.Count);
		for (int i = 0; i < positions.Count; i++)
		{
			list.Add(new KeyValuePair<Vertex, Vector3>(positions[i], cancellingRotation * positions[i].Position));
		}
		IComparer<KeyValuePair<Vertex, Vector3>> comparer = new SortVerticesByXThenY();
		list.Sort(comparer);
		int count = positions.Count;
		int num = 0;
		KeyValuePair<Vertex, Vector3>[] array = new KeyValuePair<Vertex, Vector3>[2 * count];
		for (int j = 0; j < count; j++)
		{
			while (num >= 2 && Cross(array[num - 2].Value, array[num - 1].Value, list[j].Value) <= 0f)
			{
				num--;
			}
			ref KeyValuePair<Vertex, Vector3> reference = ref array[num];
			reference = list[j];
			num++;
		}
		int num2 = count - 2;
		int num3 = num + 1;
		while (num2 >= 0)
		{
			while (num >= num3 && Cross(array[num - 2].Value, array[num - 1].Value, list[num2].Value) <= 0f)
			{
				num--;
			}
			ref KeyValuePair<Vertex, Vector3> reference2 = ref array[num];
			reference2 = list[num2];
			num++;
			num2--;
		}
		List<Vertex> list2 = new List<Vertex>(num);
		for (int k = 0; k < num; k++)
		{
			list2.Add(array[k].Key);
		}
		return RemoveExtraneous(list2);
	}

	private static List<Vertex> RemoveExtraneous(List<Vertex> sourceVertices)
	{
		List<Vertex> list = new List<Vertex>();
		for (int i = 0; i < sourceVertices.Count; i++)
		{
			Vertex vertex = sourceVertices[i];
			bool flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].Position.EqualsWithEpsilonLower(vertex.Position))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(vertex);
			}
		}
		return list;
	}

	internal static bool ChamferPolygons(List<Polygon> polygons, List<Edge> edges, float distance, int iterations, out List<Polygon> resultPolygons)
	{
		List<Plane> list = new List<Plane>();
		List<Material> list2 = new List<Material>();
		for (int i = 0; i < edges.Count; i++)
		{
			Edge edge = edges[i];
			Polygon[] array = polygons.Where((Polygon p) => Polygon.ContainsEdge(p, edge)).ToArray();
			if (array.Length != 2)
			{
				resultPolygons = null;
				return false;
			}
			Polygon.FindEdge(array[0], edge, out var foundEdge);
			Polygon.FindEdge(array[1], edge, out var foundEdge2);
			Vector3 vector = foundEdge.Vertex1.Position - ChamferPolygons_GetNormal(foundEdge.Vertex1.Position, foundEdge.Vertex2.Position, array[0].GetCenterPoint()).normalized * distance;
			Vector3 vector2 = foundEdge.Vertex2.Position - ChamferPolygons_GetNormal(foundEdge.Vertex1.Position, foundEdge.Vertex2.Position, array[0].GetCenterPoint()).normalized * distance;
			Vector3 p2 = foundEdge2.Vertex2.Position - ChamferPolygons_GetNormal(foundEdge2.Vertex1.Position, foundEdge2.Vertex2.Position, array[1].GetCenterPoint()).normalized * distance;
			for (int j = 0; j < iterations; j++)
			{
				float num = 1f / (float)iterations;
				Vector3 point = Bezier.GetPoint(vector, foundEdge.Vertex1.Position, p2, num * (float)j);
				Vector3 point2 = Bezier.GetPoint(vector, foundEdge.Vertex1.Position, p2, num * (float)(j + 1));
				list.Add(new Plane(point, point2, point + (vector - vector2).normalized));
				list2.Add((!(array[0].Material != null)) ? array[1].Material : array[0].Material);
			}
		}
		resultPolygons = polygons.DeepCopy();
		for (int k = 0; k < list.Count; k++)
		{
			if (SplitPolygonsByPlane(resultPolygons, list[k], excludeNewPolygons: false, out var polygonsFront, out var _))
			{
				resultPolygons = polygonsFront;
			}
			for (int l = 0; l < resultPolygons.Count; l++)
			{
				if (resultPolygons[l].Plane.normal.EqualsWithEpsilonLower3(list[k].normal))
				{
					resultPolygons[l].Material = list2[k];
				}
			}
		}
		return true;
	}

	private static Vector3 ChamferPolygons_GetNormal(Vector3 a, Vector3 b, Vector3 c)
	{
		Vector3 lhs = b - a;
		Vector3 rhs = c - a;
		return Vector3.Cross(lhs, rhs).normalized;
	}

	internal static void GenerateMeshFromPolygons(Polygon[] polygons, ref Mesh mesh)
	{
		if (mesh == null)
		{
			mesh = new Mesh();
		}
		mesh.Clear();
		List<Vector3> list = new List<Vector3>();
		List<Vector3> list2 = new List<Vector3>();
		List<Vector2> list3 = new List<Vector2>();
		List<Color32> list4 = new List<Color32>();
		List<int> list5 = new List<int>();
		VertexList vertexList = new VertexList();
		foreach (Polygon polygon in polygons)
		{
			List<int> list6 = new List<int>();
			for (int j = 0; j < polygon.Vertices.Length; j++)
			{
				int item = vertexList.Add(polygon.Vertices[j]);
				list6.Add(item);
			}
			for (int k = 2; k < list6.Count; k++)
			{
				list5.Add(list6[0]);
				list5.Add(list6[k - 1]);
				list5.Add(list6[k]);
			}
		}
		for (int l = 0; l < vertexList.Vertices.Count; l++)
		{
			list.Add(vertexList.Vertices[l].Position);
			list2.Add(vertexList.Vertices[l].Normal);
			list3.Add(vertexList.Vertices[l].UV);
		}
		mesh.vertices = list.ToArray();
		mesh.normals = list2.ToArray();
		mesh.colors32 = list4.ToArray();
		mesh.uv = list3.ToArray();
		mesh.triangles = list5.ToArray();
	}

	internal static Polygon[] Triangulate(Polygon polygon)
	{
		int num = polygon.Vertices.Length - 2;
		Polygon[] array = new Polygon[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = new Polygon(new Vertex[3]
			{
				polygon.Vertices[0],
				polygon.Vertices[i + 1],
				polygon.Vertices[i + 2]
			}, polygon.Material, isTemporary: true, userExcludeFromFinal: true);
		}
		return array;
	}
}
