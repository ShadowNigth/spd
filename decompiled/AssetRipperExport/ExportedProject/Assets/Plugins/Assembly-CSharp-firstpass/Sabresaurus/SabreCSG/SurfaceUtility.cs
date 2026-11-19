using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public static class SurfaceUtility
	{
		public static void FacetPolygon(Polygon polygon)
		{
			for (int i = 0; i < polygon.Vertices.Length; i++)
			{
				Vertex vertex = polygon.Vertices[i];
				vertex.Normal = polygon.Plane.normal;
			}
		}

		public static void SmoothPolygon(Polygon polygon, Polygon[] allPolygons, float smoothingAngle = 60f)
		{
			for (int i = 0; i < polygon.Vertices.Length; i++)
			{
				Vertex vertex = polygon.Vertices[i];
				Vector3 normal = polygon.Plane.normal;
				Vector3 vector = normal;
				int num = 1;
				foreach (Polygon polygon2 in allPolygons)
				{
					if (polygon2 == polygon)
					{
						continue;
					}
					for (int k = 0; k < polygon2.Vertices.Length; k++)
					{
						Vertex vertex2 = polygon2.Vertices[k];
						if (vertex2.Position == vertex.Position && Vector3.Angle(normal, polygon2.Plane.normal) <= smoothingAngle)
						{
							vector += polygon2.Plane.normal;
							num++;
						}
					}
				}
				vertex.Normal = vector * (1f / (float)num);
			}
		}

		public static void ExtrudePolygon(Polygon sourcePolygon, float extrusionDistance, out Polygon[] outputPolygons, out Quaternion rotation)
		{
			bool flag = false;
			if (extrusionDistance < 0f)
			{
				sourcePolygon.Flip();
				extrusionDistance = 0f - extrusionDistance;
				flag = true;
			}
			Polygon polygon = sourcePolygon.DeepCopy();
			polygon.UniqueIndex = -1;
			rotation = Quaternion.LookRotation(polygon.Plane.normal);
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vertex[] vertices = polygon.Vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				vertices[i].Position = quaternion * vertices[i].Position;
				vertices[i].Normal = quaternion * vertices[i].Normal;
			}
			polygon.Vertices = vertices;
			Vector3 normal = polygon.Plane.normal;
			Polygon polygon2 = polygon.DeepCopy();
			polygon2.UniqueIndex = -1;
			polygon.Flip();
			vertices = polygon2.Vertices;
			for (int j = 0; j < vertices.Length; j++)
			{
				vertices[j].Position += normal * extrusionDistance;
			}
			polygon2.Vertices = vertices;
			Polygon[] array = new Polygon[sourcePolygon.Vertices.Length];
			for (int k = 0; k < polygon.Vertices.Length; k++)
			{
				Vertex vertex = polygon.Vertices[k].DeepCopy();
				Vertex vertex2 = polygon.Vertices[(k + 1) % polygon.Vertices.Length].DeepCopy();
				float num = Vector3.Distance(vertex.Position, vertex2.Position);
				float num2 = Vector2.Distance(vertex.UV, vertex2.UV);
				float num3 = num / num2;
				vertex.UV = Vector2.zero;
				if (flag)
				{
					vertex2.UV = new Vector2((0f - num) / num3, 0f);
				}
				else
				{
					vertex2.UV = new Vector2(num / num3, 0f);
				}
				Vector2 vector = vertex2.UV - vertex.UV;
				Vector2 vector2 = vector.Rotate(90f) * (extrusionDistance / num);
				Vertex vertex3 = vertex.DeepCopy();
				vertex3.Position += normal * extrusionDistance;
				vertex3.UV += vector2;
				Vertex vertex4 = vertex2.DeepCopy();
				vertex4.Position += normal * extrusionDistance;
				vertex4.UV += vector2;
				Vertex[] vertices2 = new Vertex[4] { vertex, vertex2, vertex4, vertex3 };
				array[k] = new Polygon(vertices2, sourcePolygon.Material, false, false);
				array[k].Flip();
				array[k].ResetVertexNormals();
			}
			List<Polygon> list = new List<Polygon>();
			list.Add(polygon);
			list.Add(polygon2);
			list.AddRange(array);
			outputPolygons = list.ToArray();
		}

		public static void GetPrimaryPolygonDescribers(Polygon polygon, out Vertex vertex1, out Vertex vertex2, out Vertex vertex3)
		{
			int num = 0;
			int num2 = 1;
			int i = 2;
			Vector3 position = polygon.Vertices[num].Position;
			Vector3 position2 = polygon.Vertices[num2].Position;
			Vector3 position3 = polygon.Vertices[i].Position;
			if (new Plane(position, position2, position3).normal == Vector3.zero && polygon.Vertices.Length > 3)
			{
				for (i = 3; i < polygon.Vertices.Length; i++)
				{
					position3 = polygon.Vertices[i].Position;
					if (new Plane(position, position2, position3).normal != Vector3.zero)
					{
						break;
					}
				}
			}
			vertex1 = polygon.Vertices[num];
			vertex2 = polygon.Vertices[num2];
			vertex3 = polygon.Vertices[i];
		}

		public static UVOrientation GetNorthEastVectors(Polygon polygon, Transform brushTransform)
		{
			Vertex vertex;
			Vertex vertex2;
			Vertex vertex3;
			GetPrimaryPolygonDescribers(polygon, out vertex, out vertex2, out vertex3);
			Vector3 vector = brushTransform.TransformPoint(vertex.Position);
			Vector3 vector2 = brushTransform.TransformPoint(vertex2.Position);
			Vector3 vector3 = brushTransform.TransformPoint(vertex3.Position);
			Vector2 uV = vertex.UV;
			Vector2 uV2 = vertex2.UV;
			Vector2 uV3 = vertex3.UV;
			Matrix2x2 matrix2x = new Matrix2x2
			{
				m00 = uV2.x - uV.x,
				m10 = uV3.x - uV.x,
				m01 = uV2.y - uV.y,
				m11 = uV3.y - uV.y
			};
			Matrix2x2 inverse = matrix2x.Inverse;
			Matrix3x2 matrix3x = new Matrix3x2
			{
				m00 = vector2.x - vector.x,
				m10 = vector3.x - vector.x,
				m01 = vector2.y - vector.y,
				m11 = vector3.y - vector.y,
				m02 = vector2.z - vector.z,
				m12 = vector3.z - vector.z
			};
			Matrix3x2 matrix3x2 = matrix3x.Multiply(inverse);
			Vector3 vector4 = new Vector3(matrix3x2.m00, matrix3x2.m01, matrix3x2.m02);
			Vector3 vector5 = new Vector3(matrix3x2.m10, matrix3x2.m11, matrix3x2.m12);
			UVOrientation uVOrientation = new UVOrientation();
			uVOrientation.NorthVector = vector5.normalized;
			uVOrientation.EastVector = vector4.normalized;
			uVOrientation.NorthScale = vector5.magnitude;
			uVOrientation.EastScale = vector4.magnitude;
			return uVOrientation;
		}

		public static Vector2 GetUVOffset(Polygon polygon)
		{
			Vertex vertex;
			Vertex vertex2;
			Vertex vertex3;
			GetPrimaryPolygonDescribers(polygon, out vertex, out vertex2, out vertex3);
			return GeometryHelper.GetUVForPosition(vertex.Position, vertex2.Position, vertex3.Position, vertex.UV, vertex2.UV, vertex3.UV, polygon.GetCenterPoint());
		}

		public static Pair<float?, float?> GetUVOffset(List<Polygon> polygons)
		{
			float? second = 0f;
			float? first = 0f;
			for (int i = 0; i < polygons.Count; i++)
			{
				Polygon polygon = polygons[i];
				Vector2 uVOffset = GetUVOffset(polygon);
				if (i == 0)
				{
					second = uVOffset.y;
					first = uVOffset.x;
					continue;
				}
				if (!second.HasValue || !second.Value.EqualsWithEpsilon(uVOffset.y))
				{
					second = null;
				}
				if (!first.HasValue || !first.Value.EqualsWithEpsilon(uVOffset.x))
				{
					first = null;
				}
			}
			return new Pair<float?, float?>(first, second);
		}

		public static void SetAllPolygonsMaterials(Brush brush, Material material)
		{
			Polygon[] polygons = brush.GetPolygons();
			for (int i = 0; i < polygons.Length; i++)
			{
				polygons[i].Material = material;
			}
		}
	}
}
