using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public static class VertexUtility
	{
		public static Polygon[] WeldVerticesToCenter(Polygon[] sourcePolygons, List<Vertex> sourceVertices)
		{
			VertexWeldOperation vertexWeldOperation = new VertexWeldCentroidOperation(sourcePolygons, sourceVertices);
			return vertexWeldOperation.Execute().ToArray();
		}

		public static Polygon[] WeldNearbyVertices(float tolerance, Polygon[] sourcePolygons, List<Vertex> sourceVertices)
		{
			VertexWeldOperation vertexWeldOperation = new VertexWeldToleranceOperation(sourcePolygons, sourceVertices, tolerance);
			return vertexWeldOperation.Execute().ToArray();
		}

		private static bool AreNeighbours(int index1, int index2, int length)
		{
			if ((index1 == length - 1 && index2 == 0) || (index2 == length - 1 && index1 == 0))
			{
				return true;
			}
			if (index2 - index1 == 1 || index1 - index2 == 1)
			{
				return true;
			}
			return false;
		}

		public static Polygon[] ConnectVertices(Polygon[] polygons, List<Vertex> sourceVertices, out List<Edge> newEdges)
		{
			List<Polygon> list = new List<Polygon>(polygons);
			newEdges = new List<Edge>();
			for (int i = 0; i < list.Count; i++)
			{
				int num = -1;
				int num2 = -1;
				for (int j = 0; j < sourceVertices.Count; j++)
				{
					int num3 = Array.IndexOf(list[i].Vertices, sourceVertices[j]);
					if (num3 != -1)
					{
						if (num == -1)
						{
							num = num3;
						}
						else if (num2 == -1)
						{
							num2 = num3;
						}
					}
				}
				if (num != -1 && num2 != -1 && !AreNeighbours(num, num2, list[i].Vertices.Length))
				{
					Vector3 c = list[i].Vertices[num].Position + list[i].Plane.normal;
					Polygon frontPolygon;
					Polygon backPolygon;
					Vertex newVertex;
					Vertex newVertex2;
					if (Polygon.SplitPolygon(clipPlane: new Plane(list[i].Vertices[num].Position, list[i].Vertices[num2].Position, c), polygon: list[i], frontPolygon: out frontPolygon, backPolygon: out backPolygon, newVertex1: out newVertex, newVertex2: out newVertex2))
					{
						list[i] = frontPolygon;
						list.Insert(i + 1, backPolygon);
						i++;
						newEdges.Add(new Edge(newVertex, newVertex2));
					}
					else
					{
						Debug.LogWarning("Split polygon failed");
					}
				}
			}
			return list.ToArray();
		}

		public static void DisplacePolygons(Polygon[] polygons, float distance)
		{
			Polygon.VertexComparerEpsilon comparer = new Polygon.VertexComparerEpsilon();
			Polygon.Vector3ComparerEpsilon comparer2 = new Polygon.Vector3ComparerEpsilon();
			List<List<Vertex>> list = new List<List<Vertex>>();
			List<List<Vector3>> list2 = new List<List<Vector3>>();
			Dictionary<Vertex, Polygon> dictionary = new Dictionary<Vertex, Polygon>();
			for (int i = 0; i < polygons.Length; i++)
			{
				Vertex[] vertices = polygons[i].Vertices;
				foreach (Vertex vertex in vertices)
				{
					dictionary[vertex] = polygons[i];
					bool flag = false;
					for (int k = 0; k < list.Count; k++)
					{
						if (list[k].Contains(vertex, comparer))
						{
							list[k].Add(vertex);
							if (!list2[k].Contains(polygons[i].Plane.normal, comparer2))
							{
								list2[k].Add(polygons[i].Plane.normal);
							}
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list.Add(new List<Vertex> { vertex });
						list2.Add(new List<Vector3> { polygons[i].Plane.normal });
					}
				}
			}
			List<List<Vector3>> list3 = new List<List<Vector3>>();
			List<List<Vector2>> list4 = new List<List<Vector2>>();
			for (int l = 0; l < list.Count; l++)
			{
				list3.Add(new List<Vector3>());
				list4.Add(new List<Vector2>());
				for (int m = 0; m < list[l].Count; m++)
				{
					Vector3 position = list[l][m].Position;
					for (int n = 0; n < list2[l].Count; n++)
					{
						position += list2[l][n] * distance;
					}
					Polygon polygon = dictionary[list[l][m]];
					Vector2 uVForPosition = GeometryHelper.GetUVForPosition(polygon, position);
					list3[l].Add(position);
					list4[l].Add(uVForPosition);
				}
			}
			for (int num = 0; num < list.Count; num++)
			{
				for (int num2 = 0; num2 < list[num].Count; num2++)
				{
					Vertex vertex2 = list[num][num2];
					vertex2.Position = list3[num][num2];
					vertex2.UV = list4[num][num2];
				}
			}
			for (int num3 = 0; num3 < polygons.Length; num3++)
			{
				polygons[num3].CalculatePlane();
			}
		}

		public static void TranslateSpecifiedVertices(Brush brush, List<Vertex> specifiedVertices, Vector3 localDelta)
		{
			Polygon.Vector3ComparerEpsilon comparer = new Polygon.Vector3ComparerEpsilon();
			List<Vector3> source = specifiedVertices.Select((Vertex item) => item.Position).ToList();
			List<Polygon> list = new List<Polygon>();
			Polygon[] polygons = brush.GetPolygons();
			foreach (Polygon polygon in polygons)
			{
				int num2 = polygon.Vertices.Length;
				Vector3[] array = new Vector3[num2];
				Vector2[] array2 = new Vector2[num2];
				for (int num3 = 0; num3 < num2; num3++)
				{
					array[num3] = polygon.Vertices[num3].Position;
					array2[num3] = polygon.Vertices[num3].UV;
				}
				bool flag = false;
				for (int num4 = 0; num4 < num2; num4++)
				{
					Vertex vertex = polygon.Vertices[num4];
					if (source.Contains(vertex.Position, comparer))
					{
						Vector3 vector = vertex.Position + localDelta;
						array[num4] = vector;
						array2[num4] = GeometryHelper.GetUVForPosition(polygon, vector);
						flag = true;
					}
				}
				if (flag)
				{
					list.Add(polygon);
				}
				for (int num5 = 0; num5 < num2; num5++)
				{
					Vertex vertex2 = polygon.Vertices[num5];
					vertex2.Position = array[num5];
					vertex2.UV = array2[num5];
				}
				polygon.CalculatePlane();
			}
			if (list.Count > 0)
			{
				for (int num6 = 0; num6 < list.Count; num6++)
				{
					list[num6].ResetVertexNormals();
				}
			}
		}
	}
}
