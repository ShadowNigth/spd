using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	internal class TriangulationNode
	{
		private TriangulationNode front;

		private TriangulationNode back;

		private List<Polygon> polygonsAtNode = new List<Polygon>();

		internal TriangulationNode(List<Polygon> polygonsToProcess, List<SimpleEdge> edges)
		{
			List<Polygon> polygonsToProcess2 = null;
			List<Polygon> polygonsToProcess3 = null;
			List<SimpleEdge> edges2 = null;
			List<SimpleEdge> edges3 = null;
			bool flag = false;
			for (int i = 0; i < edges.Count; i++)
			{
				List<Polygon> polygonsFront;
				List<Polygon> polygonsBack;
				if (!PolygonFactory.SplitCoplanarPolygonsByPlane(polygonsToProcess, edges[i].Plane, out polygonsFront, out polygonsBack))
				{
					continue;
				}
				List<SimpleEdge> list = new List<SimpleEdge>();
				List<SimpleEdge> list2 = new List<SimpleEdge>();
				bool flag2 = false;
				for (int j = 0; j < edges.Count; j++)
				{
					if (i == j)
					{
						continue;
					}
					Vector3 position = edges[j].Position1;
					Vector3 position2 = edges[j].Position2;
					int sideThick = MathHelper.GetSideThick(edges[i].Plane, position);
					int sideThick2 = MathHelper.GetSideThick(edges[i].Plane, position2);
					if (sideThick * sideThick2 >= 0)
					{
						if (sideThick + sideThick2 < 0)
						{
							list.Add(edges[j]);
						}
						else
						{
							list2.Add(edges[j]);
						}
					}
					else
					{
						flag2 = true;
						list.Add(edges[j]);
						list2.Add(edges[j]);
					}
				}
				if (flag2)
				{
					flag = true;
					polygonsToProcess2 = polygonsFront;
					polygonsToProcess3 = polygonsBack;
					edges2 = list;
					edges3 = list2;
					continue;
				}
				front = new TriangulationNode(polygonsFront, list);
				back = new TriangulationNode(polygonsBack, list2);
				return;
			}
			if (flag)
			{
				front = new TriangulationNode(polygonsToProcess2, edges2);
				back = new TriangulationNode(polygonsToProcess3, edges3);
			}
			else
			{
				polygonsAtNode = polygonsToProcess;
			}
		}

		public List<List<Polygon>> GetAggregated()
		{
			List<List<Polygon>> list = new List<List<Polygon>>();
			if (polygonsAtNode.Count > 0)
			{
				list.Add(polygonsAtNode);
			}
			if (front != null)
			{
				list.AddRange(front.GetAggregated());
			}
			if (back != null)
			{
				list.AddRange(back.GetAggregated());
			}
			return list;
		}
	}
}
