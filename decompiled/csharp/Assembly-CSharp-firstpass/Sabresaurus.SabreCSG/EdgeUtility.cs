using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public static class EdgeUtility
{
	public static void SplitPolygonsByEdges(Polygon[] polygons, List<Edge> sourceEdges, out Polygon[] finalPolygons, out List<Edge> newEdges)
	{
		List<Polygon> list = new List<Polygon>(polygons);
		newEdges = new List<Edge>();
		List<Edge> list2 = new List<Edge>();
		for (int i = 0; i < sourceEdges.Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < polygons.Length; j++)
			{
				if (flag)
				{
					break;
				}
				Edge edge = sourceEdges[i];
				for (int k = 0; k < sourceEdges.Count; k++)
				{
					if (flag)
					{
						break;
					}
					if (k == i)
					{
						continue;
					}
					Edge edge2 = sourceEdges[k];
					bool flag2 = Polygon.ContainsEdge(polygons[j], edge);
					bool flag3 = Polygon.ContainsEdge(polygons[j], edge2);
					if (flag2 && flag3)
					{
						if (!list2.Contains(edge))
						{
							list2.Add(edge);
						}
						if (!list2.Contains(edge2))
						{
							list2.Add(edge2);
						}
						flag = true;
					}
				}
			}
		}
		foreach (Polygon polygon in polygons)
		{
			List<Edge> list3 = new List<Edge>();
			for (int m = 0; m < list2.Count; m++)
			{
				Edge edge3 = list2[m];
				if (Polygon.ContainsEdge(polygon, edge3))
				{
					list3.Add(edge3);
				}
			}
			if (list3.Count == 1)
			{
				if (!SplitPolygonAtEdge(polygon, list3[0], out var _))
				{
					Debug.LogError("Could not add vertex to adjacent polygon");
				}
			}
			else if (list3.Count == 2)
			{
				Edge edge4 = list3[0];
				Edge edge5 = list3[1];
				Vector3 centerPoint = edge4.CenterPoint;
				Vector3 centerPoint2 = edge5.CenterPoint;
				Vector3 c = centerPoint + polygon.Plane.normal;
				Plane clipPlane = new Plane(centerPoint, centerPoint2, c);
				Polygon.SplitPolygon(polygon, out var frontPolygon, out var backPolygon, out var newVertex2, out var newVertex3, clipPlane);
				newEdges.Add(new Edge(newVertex2, newVertex3));
				list.Remove(polygon);
				list.Add(frontPolygon);
				list.Add(backPolygon);
			}
		}
		finalPolygons = list.ToArray();
	}

	public static bool SplitPolygonAtEdge(Polygon polygon, Edge edge, out Vertex newVertex)
	{
		newVertex = null;
		List<Vertex> list = new List<Vertex>(polygon.Vertices);
		for (int i = 0; i < polygon.Vertices.Length; i++)
		{
			Vector3 position = polygon.Vertices[i].Position;
			Vector3 position2 = polygon.Vertices[(i + 1) % polygon.Vertices.Length].Position;
			if ((edge.Vertex1.Position.EqualsWithEpsilon(position) && edge.Vertex2.Position.EqualsWithEpsilon(position2)) || (edge.Vertex1.Position.EqualsWithEpsilon(position2) && edge.Vertex2.Position.EqualsWithEpsilon(position)))
			{
				newVertex = Vertex.Lerp(polygon.Vertices[i], polygon.Vertices[(i + 1) % polygon.Vertices.Length], 0.5f);
				list.Insert(i + 1, newVertex);
				break;
			}
		}
		if (list.Count == polygon.Vertices.Length)
		{
			return false;
		}
		polygon.Vertices = list.ToArray();
		return true;
	}

	public static bool FindSharedEdge(Polygon polygon1, Polygon polygon2, out Edge matchedEdge1, out Edge matchedEdge2)
	{
		for (int i = 0; i < polygon1.Vertices.Length; i++)
		{
			Edge edge = new Edge(polygon1.Vertices[i], polygon1.Vertices[(i + 1) % polygon1.Vertices.Length]);
			for (int j = 0; j < polygon2.Vertices.Length; j++)
			{
				Edge edge2 = new Edge(polygon2.Vertices[j], polygon2.Vertices[(j + 1) % polygon2.Vertices.Length]);
				if (EdgeMatches(edge, edge2))
				{
					matchedEdge1 = edge;
					matchedEdge2 = new Edge(edge2.Vertex2, edge2.Vertex1);
					return true;
				}
			}
		}
		matchedEdge1 = null;
		matchedEdge2 = null;
		return false;
	}

	public static bool EdgeMatches(Edge edge1, Edge edge2)
	{
		Vector3 rhs = edge1.Vertex2.Position - edge1.Vertex1.Position;
		Vector3 vector = edge2.Vertex2.Position - edge2.Vertex1.Position;
		Vector3 normalized = rhs.normalized;
		Vector3 normalized2 = vector.normalized;
		float num = Vector3.Dot(normalized, normalized2);
		if (num > 0.999f || num < -0.999f)
		{
			float f = Vector3.Dot(normalized, Vector3.up);
			Vector3 lhs = ((!(Mathf.Abs(f) > 0.9f)) ? Vector3.Cross(Vector3.up, normalized).normalized : Vector3.Cross(Vector3.forward, normalized).normalized);
			Vector3 lhs2 = Vector3.Cross(lhs, rhs);
			Vector3 rhs2 = edge2.Vertex2.Position - edge1.Vertex1.Position;
			float f2 = Vector3.Dot(lhs, rhs2);
			float f3 = Vector3.Dot(lhs2, rhs2);
			if (Mathf.Abs(f2) < 0.0001f && Mathf.Abs(f3) < 0.0001f)
			{
				float num2 = 0f;
				Plane plane = new Plane(normalized, edge1.Vertex2.Position);
				num2 = plane.GetDistanceToPoint(edge2.Vertex1.Position);
				if (num2 >= 0f)
				{
					return true;
				}
				num2 = plane.GetDistanceToPoint(edge2.Vertex2.Position);
				if (num2 >= 0f)
				{
					return true;
				}
				Plane plane2 = new Plane(-normalized, edge1.Vertex1.Position);
				num2 = plane2.GetDistanceToPoint(edge2.Vertex1.Position);
				if (num2 <= 0f)
				{
					return true;
				}
				num2 = plane2.GetDistanceToPoint(edge2.Vertex2.Position);
				if (num2 <= 0f)
				{
					return true;
				}
				Plane plane3 = new Plane(normalized2, edge2.Vertex2.Position);
				num2 = plane3.GetDistanceToPoint(edge1.Vertex1.Position);
				if (num2 <= 0f)
				{
					return true;
				}
				num2 = plane3.GetDistanceToPoint(edge1.Vertex2.Position);
				if (num2 <= 0f)
				{
					return true;
				}
				Plane plane4 = new Plane(-normalized2, edge2.Vertex1.Position);
				num2 = plane4.GetDistanceToPoint(edge1.Vertex1.Position);
				if (num2 >= 0f)
				{
					return true;
				}
				num2 = plane4.GetDistanceToPoint(edge1.Vertex2.Position);
				if (num2 >= 0f)
				{
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}
}
