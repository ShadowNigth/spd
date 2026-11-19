using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public class VertexWeldToleranceOperation : VertexWeldOperation
	{
		private class VertexComparerTolerance : IEqualityComparer<Vertex>
		{
			private float squareTolerance;

			public VertexComparerTolerance(float tolerance)
			{
				squareTolerance = tolerance * tolerance;
			}

			public bool Equals(Vertex x, Vertex y)
			{
				float sqrMagnitude = (x.Position - y.Position).sqrMagnitude;
				return sqrMagnitude <= squareTolerance;
			}

			public int GetHashCode(Vertex obj)
			{
				return 1;
			}
		}

		protected float tolerance;

		public VertexWeldToleranceOperation(Polygon[] sourcePolygons, List<Vertex> sourceVertices, float tolerance)
			: base(sourcePolygons, sourceVertices)
		{
			this.tolerance = tolerance;
		}

		public override void PerformWeld()
		{
			List<List<Vertex>> list = new List<List<Vertex>>();
			VertexComparerTolerance comparer = new VertexComparerTolerance(tolerance);
			for (int i = 0; i < sourceVertices.Count; i++)
			{
				Vertex vertex = sourceVertices[i];
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].Contains(vertex, comparer))
					{
						list[j].Add(vertex);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(new List<Vertex> { vertex });
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				List<Vertex> list2 = list[k];
				if (list2.Count > 1)
				{
					Vector3 zero = Vector3.zero;
					for (int l = 0; l < list2.Count; l++)
					{
						zero += list2[l].Position;
					}
					zero /= (float)list2.Count;
					for (int m = 0; m < list2.Count; m++)
					{
						Polygon polygon = vertexPolygonMappings[list2[m]];
						list2[m].UV = GeometryHelper.GetUVForPosition(polygon, zero);
					}
					for (int n = 0; n < list2.Count; n++)
					{
						list2[n].Position = zero;
					}
				}
			}
		}
	}
}
