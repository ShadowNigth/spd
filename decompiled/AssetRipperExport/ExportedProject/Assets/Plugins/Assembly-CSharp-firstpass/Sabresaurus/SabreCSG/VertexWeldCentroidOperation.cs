using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public class VertexWeldCentroidOperation : VertexWeldOperation
	{
		public VertexWeldCentroidOperation(Polygon[] sourcePolygons, List<Vertex> sourceVertices)
			: base(sourcePolygons, sourceVertices)
		{
		}

		public override void PerformWeld()
		{
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < sourceVertices.Count; i++)
			{
				zero += sourceVertices[i].Position;
			}
			zero /= (float)sourceVertices.Count;
			for (int j = 0; j < sourceVertices.Count; j++)
			{
				Polygon polygon = vertexPolygonMappings[sourceVertices[j]];
				sourceVertices[j].UV = GeometryHelper.GetUVForPosition(polygon, zero);
			}
			for (int k = 0; k < sourceVertices.Count; k++)
			{
				sourceVertices[k].Position = zero;
			}
		}
	}
}
