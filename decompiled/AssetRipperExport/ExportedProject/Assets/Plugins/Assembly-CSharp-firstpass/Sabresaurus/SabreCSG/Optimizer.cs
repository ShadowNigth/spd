using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	internal static class Optimizer
	{
		internal static List<Polygon> CalculateConvexHulls(List<Polygon> polygons)
		{
			for (int i = 0; i < polygons.Count; i++)
			{
				for (int j = i + 1; j < polygons.Count; j++)
				{
					if (!MathHelper.PlaneEqualsLooser(polygons[i].Plane, polygons[j].Plane))
					{
						return polygons;
					}
				}
			}
			Vector3 normal = polygons[0].Plane.normal;
			List<SimpleEdge> list = new List<SimpleEdge>();
			for (int k = 0; k < polygons.Count; k++)
			{
				Polygon polygon = polygons[k];
				Edge[] edges = polygon.GetEdges();
				for (int l = 0; l < edges.Length; l++)
				{
					Vector3 position1 = edges[l].Vertex1.Position;
					Vector3 position2 = edges[l].Vertex2.Position;
					List<SimpleEdge> list2 = list.FindAll((SimpleEdge simpleEdge) => simpleEdge.CollinearIntersects(position1, position2));
					if (list2.Count > 0)
					{
						for (int num = 0; num < list2.Count; num++)
						{
							list2[num].Count++;
						}
						list.Add(new SimpleEdge(position1, position2, polygons[0].Plane.normal, 2));
					}
					else
					{
						list.Add(new SimpleEdge(position1, position2, polygons[0].Plane.normal));
					}
				}
			}
			List<SimpleEdge> list3 = new List<SimpleEdge>();
			for (int num2 = 0; num2 < list.Count; num2++)
			{
				if (list[num2].Count == 1)
				{
					list3.Add(list[num2]);
				}
			}
			List<Polygon> polygonsToProcess = new List<Polygon>(polygons);
			TriangulationNode triangulationNode = new TriangulationNode(polygonsToProcess, list3);
			List<List<Polygon>> aggregated = triangulationNode.GetAggregated();
			List<Polygon> list4 = new List<Polygon>(aggregated.Count);
			for (int num3 = 0; num3 < aggregated.Count; num3++)
			{
				List<Vertex> list5 = new List<Vertex>();
				for (int num4 = 0; num4 < aggregated[num3].Count; num4++)
				{
					list5.AddRange(aggregated[num3][num4].Vertices.DeepCopy());
				}
				if (list5.Count >= 3)
				{
					List<Vertex> list6 = PolygonFactory.RefineVertices(normal, list5, true, true, true);
					Polygon item = new Polygon(list6.ToArray(), polygons[0].Material, polygons[0].ExcludeFromFinal, polygons[0].UserExcludeFromFinal, polygons[0].UniqueIndex);
					list4.Add(item);
				}
			}
			return list4;
		}
	}
}
