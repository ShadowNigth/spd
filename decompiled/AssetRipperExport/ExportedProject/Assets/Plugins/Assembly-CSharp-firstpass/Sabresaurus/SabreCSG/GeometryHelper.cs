using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public static class GeometryHelper
	{
		public static bool IsBrushConvex(Polygon[] polygons)
		{
			for (int i = 0; i < polygons.Length; i++)
			{
				for (int j = 0; j < polygons[i].Vertices.Length; j++)
				{
					foreach (Polygon polygon in polygons)
					{
						for (int l = 2; l < polygon.Vertices.Length; l++)
						{
							Plane plane = new Plane(polygon.Vertices[0].Position, polygon.Vertices[l - 1].Position, polygon.Vertices[l].Position);
							float num = Vector3.Dot(plane.normal, polygons[i].Vertices[j].Position) + plane.distance;
							if (num > 0.01f)
							{
								return false;
							}
						}
						for (int m = 0; m < polygon.Vertices.Length; m++)
						{
							Plane plane2 = new Plane(polygon.Vertices[m].Position, polygon.Vertices[(m + 1) % polygon.Vertices.Length].Position, polygon.Vertices[(m + 2) % polygon.Vertices.Length].Position);
							float num2 = Vector3.Dot(plane2.normal, polygons[i].Vertices[j].Position) + plane2.distance;
							if (num2 > 0.01f)
							{
								return false;
							}
						}
					}
				}
			}
			return true;
		}

		public static List<PolygonRaycastHit> RaycastPolygonsAll(List<Polygon> polygons, Ray ray, float polygonSkin = 0f)
		{
			List<PolygonRaycastHit> list = new List<PolygonRaycastHit>();
			if (polygons != null)
			{
				for (int i = 0; i < polygons.Count; i++)
				{
					if (!polygons[i].ExcludeFromFinal && !(Vector3.Dot(polygons[i].Plane.normal, ray.direction) > 0f) && RaycastPolygon(polygons[i], ray, polygonSkin))
					{
						float enter;
						polygons[i].Plane.Raycast(ray, out enter);
						Vector3 point = ray.GetPoint(enter);
						list.Add(new PolygonRaycastHit
						{
							Distance = enter,
							Point = point,
							Normal = polygons[i].Plane.normal,
							GameObject = null,
							Polygon = polygons[i]
						});
					}
				}
			}
			list.Sort((PolygonRaycastHit x, PolygonRaycastHit y) => x.Distance.CompareTo(y.Distance));
			return list;
		}

		public static Polygon RaycastPolygons(List<Polygon> polygons, Ray ray, out float hitDistance, float polygonSkin = 0f)
		{
			Polygon result = null;
			float num = float.PositiveInfinity;
			hitDistance = 0f;
			if (polygons != null)
			{
				for (int i = 0; i < polygons.Count; i++)
				{
					if (!polygons[i].ExcludeFromFinal && !(Vector3.Dot(polygons[i].Plane.normal, ray.direction) > 0f) && RaycastPolygon(polygons[i], ray, polygonSkin))
					{
						float enter;
						polygons[i].Plane.Raycast(ray, out enter);
						Vector3 point = ray.GetPoint(enter);
						float sqrMagnitude = (ray.origin - point).sqrMagnitude;
						if (sqrMagnitude < num)
						{
							result = polygons[i];
							num = sqrMagnitude;
							hitDistance = enter;
						}
					}
				}
			}
			return result;
		}

		public static bool RaycastPolygon(Polygon polygon, Ray ray, float polygonSkin = 0f)
		{
			Plane plane = polygon.Plane;
			float enter = 0f;
			if (plane.Raycast(ray, out enter))
			{
				Vector3 point = ray.GetPoint(enter);
				for (int i = 0; i < polygon.Vertices.Length; i++)
				{
					Vector3 position = polygon.Vertices[i].Position;
					Vector3 position2 = polygon.Vertices[(i + 1) % polygon.Vertices.Length].Position;
					Vector3 lhs = position2 - position;
					Vector3 normal = plane.normal;
					Vector3 lhs2 = Vector3.Cross(lhs, normal);
					Vector3 vector = (position + position2) * 0.5f;
					if (polygonSkin != 0f)
					{
						vector += lhs2.normalized * polygonSkin;
					}
					Vector3 rhs = vector - point;
					if (Vector3.Dot(lhs2, rhs) < 0f)
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		public static bool PolygonsIntersectPlane(List<Polygon> polygons, Plane testPlane)
		{
			int num = 0;
			int num2 = 0;
			float a = 0f;
			float a2 = 0f;
			for (int i = 0; i < polygons.Count; i++)
			{
				for (int j = 0; j < polygons[i].Vertices.Length; j++)
				{
					Vector3 position = polygons[i].Vertices[j].Position;
					float distanceToPoint = testPlane.GetDistanceToPoint(position);
					if (distanceToPoint < -0.003f)
					{
						num++;
						a = Mathf.Min(a, distanceToPoint);
					}
					else if (distanceToPoint > 0.003f)
					{
						num2++;
						a2 = Mathf.Max(a2, distanceToPoint);
					}
				}
			}
			if (num > 0 && num2 > 0)
			{
				return true;
			}
			return false;
		}

		public static Vector2 GetUVForPosition(Polygon polygon, Vector3 newPosition)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = num + 1; i < polygon.Vertices.Length; i++)
			{
				if (!polygon.Vertices[i].Position.EqualsWithEpsilon(polygon.Vertices[num].Position))
				{
					num2 = i;
					break;
				}
			}
			for (int j = num2 + 1; j < polygon.Vertices.Length; j++)
			{
				if (!polygon.Vertices[j].Position.EqualsWithEpsilon(polygon.Vertices[num2].Position))
				{
					num3 = j;
					break;
				}
			}
			Vector3 position = polygon.Vertices[num].Position;
			Vector3 position2 = polygon.Vertices[num2].Position;
			Vector3 position3 = polygon.Vertices[num3].Position;
			Plane plane = new Plane(position, position2, position3);
			if (plane.normal == Vector3.zero)
			{
				for (int k = 2; k < polygon.Vertices.Length; k++)
				{
					num3 = k;
					position3 = polygon.Vertices[num3].Position;
					if (new Plane(position, position2, position3).normal != Vector3.zero)
					{
						break;
					}
				}
				plane = new Plane(position, position2, position3);
			}
			Vector3 vector = MathHelper.ClosestPointOnPlane(newPosition, plane);
			Vector2 uV = polygon.Vertices[num].UV;
			Vector2 uV2 = polygon.Vertices[num2].UV;
			Vector2 uV3 = polygon.Vertices[num3].UV;
			Vector3 vector2 = position - vector;
			Vector3 vector3 = position2 - vector;
			Vector3 vector4 = position3 - vector;
			Vector3 lhs = Vector3.Cross(position - position2, position - position3);
			Vector3 rhs = Vector3.Cross(vector3, vector4);
			Vector3 rhs2 = Vector3.Cross(vector4, vector2);
			Vector3 rhs3 = Vector3.Cross(vector2, vector3);
			float magnitude = lhs.magnitude;
			float num4 = rhs.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs));
			float num5 = rhs2.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs2));
			float num6 = rhs3.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs3));
			return uV * num4 + uV2 * num5 + uV3 * num6;
		}

		public static Vector2 GetUVForPosition(Vector3 pos1, Vector3 pos2, Vector3 pos3, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 newPosition)
		{
			Plane plane = new Plane(pos1, pos2, pos3);
			Vector3 vector = MathHelper.ClosestPointOnPlane(newPosition, plane);
			Vector3 vector2 = pos1 - vector;
			Vector3 vector3 = pos2 - vector;
			Vector3 vector4 = pos3 - vector;
			Vector3 lhs = Vector3.Cross(pos1 - pos2, pos1 - pos3);
			Vector3 rhs = Vector3.Cross(vector3, vector4);
			Vector3 rhs2 = Vector3.Cross(vector4, vector2);
			Vector3 rhs3 = Vector3.Cross(vector2, vector3);
			float magnitude = lhs.magnitude;
			float num = rhs.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs));
			float num2 = rhs2.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs2));
			float num3 = rhs3.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs3));
			return uv1 * num + uv2 * num2 + uv3 * num3;
		}

		internal static bool PolyhedronContainsPointEpsilon2(List<Polygon> polygons, Vector3 point)
		{
			for (int i = 0; i < polygons.Count; i++)
			{
				Plane plane = polygons[i].Plane;
				float num = Vector3.Dot(plane.normal, point) + plane.distance;
				if (num > 0.0001f)
				{
					return false;
				}
			}
			return true;
		}

		internal static bool PolyhedronContainsPointEpsilon3(List<Polygon> polygons, Vector3 point)
		{
			for (int i = 0; i < polygons.Count; i++)
			{
				Plane plane = polygons[i].Plane;
				float num = Vector3.Dot(plane.normal, point) + plane.distance;
				if (num > 0.001f)
				{
					return false;
				}
			}
			return true;
		}

		internal static bool PolyhedronContainsPoint(List<Polygon> polygons, Vector3 point)
		{
			for (int i = 0; i < polygons.Count; i++)
			{
				Plane plane = polygons[i].Plane;
				if (Vector3.Dot(plane.normal, point) + plane.distance > 0f)
				{
					return false;
				}
			}
			return true;
		}

		internal static bool PolyhedronContainsPolyhedron(Polygon[] polygons1, List<Polygon> polygons2)
		{
			for (int i = 0; i < polygons2.Count; i++)
			{
				for (int j = 0; j < polygons2[i].Vertices.Length; j++)
				{
					Vector3 position = polygons2[i].Vertices[j].Position;
					for (int k = 0; k < polygons1.Length; k++)
					{
						Plane plane = polygons1[k].Plane;
						float num = Vector3.Dot(plane.normal, position) + plane.distance;
						if (num > 0.003f)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		internal static bool PolyhedronContainsPolyhedron(Polygon[] polygons1, Polygon[] polygons2)
		{
			for (int i = 0; i < polygons2.Length; i++)
			{
				for (int j = 0; j < polygons2[i].Vertices.Length; j++)
				{
					Vector3 position = polygons2[i].Vertices[j].Position;
					for (int k = 0; k < polygons1.Length; k++)
					{
						Plane plane = polygons1[k].Plane;
						float num = Vector3.Dot(plane.normal, position) + plane.distance;
						if (num >= 0f)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		internal static bool PolyhedronContainsPoint(Polygon[] polygons, Vector3 point)
		{
			for (int i = 0; i < polygons.Length; i++)
			{
				Plane plane = polygons[i].Plane;
				float num = Vector3.Dot(plane.normal, point) + plane.distance;
				if (num > 1E-05f)
				{
					return false;
				}
			}
			return true;
		}

		internal static float PolyhedronContainsPointDistance(Polygon[] polygons, Vector3 point)
		{
			float num = float.PositiveInfinity;
			for (int i = 0; i < polygons.Length; i++)
			{
				Plane plane = polygons[i].Plane;
				float num2 = 0f - (Vector3.Dot(plane.normal, point) + plane.distance);
				if (num2 < num)
				{
					num = num2;
				}
				if (num < -1E-05f)
				{
					return -1f;
				}
			}
			return num;
		}

		internal static bool PolyhedronContainsPointEpsilon1(Polygon[] polygons, Vector3 point)
		{
			for (int i = 0; i < polygons.Length; i++)
			{
				Plane plane = polygons[i].Plane;
				if (Vector3.Dot(plane.normal, point) + plane.distance >= -1E-05f)
				{
					return false;
				}
			}
			return true;
		}

		internal static bool PolyhedronContainsPointEpsilon1(List<Polygon> polygons, Vector3 point)
		{
			for (int i = 0; i < polygons.Count; i++)
			{
				Plane plane = polygons[i].Plane;
				if (Vector3.Dot(plane.normal, point) + plane.distance >= -1E-05f)
				{
					return false;
				}
			}
			return true;
		}

		internal static bool PolyhedronIntersectsLine(Polygon[] polygons, Vector3 lineStart, Vector3 lineEnd)
		{
			float num = 0f;
			float num2 = 1f;
			Vector3 rhs = lineEnd - lineStart;
			for (int i = 0; i < polygons.Length; i++)
			{
				Plane plane = polygons[i].Plane;
				float num3 = Vector3.Dot(plane.normal, rhs);
				float num4 = (0f - (Vector3.Dot(plane.normal, lineStart) + plane.distance)) / num3;
				if (num3 < 0f)
				{
					if (num4 > num)
					{
						num = num4;
					}
				}
				else if (num3 > 0f)
				{
					if (num4 < num2)
					{
						num2 = num4;
					}
				}
				else if (Polygon.ComparePointToPlane(lineStart, polygons[i].Plane) == Polygon.PointPlaneRelation.Behind)
				{
					return false;
				}
				if (num2 - num <= 0f)
				{
					return false;
				}
			}
			return true;
		}

		internal static bool PolyhedraIntersect(Polygon[] polygons1, Polygon[] polygons2)
		{
			for (int i = 0; i < polygons1.Length; i++)
			{
				int num = polygons1[i].Vertices.Length;
				for (int j = 0; j < num; j++)
				{
					Vertex vertex = polygons1[i].Vertices[j];
					Vertex vertex2 = polygons1[i].Vertices[(j + 1) % num];
					if (PolyhedronIntersectsLine(polygons2, vertex.Position, vertex2.Position))
					{
						return true;
					}
				}
			}
			for (int k = 0; k < polygons2.Length; k++)
			{
				int num2 = polygons2[k].Vertices.Length;
				for (int l = 0; l < num2; l++)
				{
					Vertex vertex3 = polygons2[k].Vertices[l];
					Vertex vertex4 = polygons2[k].Vertices[(l + 1) % num2];
					if (PolyhedronIntersectsLine(polygons1, vertex3.Position, vertex4.Position))
					{
						return true;
					}
				}
			}
			for (int m = 0; m < polygons1.Length; m++)
			{
				Vector3 centerPoint = polygons1[m].GetCenterPoint();
				if (PolyhedronContainsPoint(polygons2, centerPoint))
				{
					return true;
				}
			}
			for (int n = 0; n < polygons2.Length; n++)
			{
				Vector3 centerPoint2 = polygons2[n].GetCenterPoint();
				if (PolyhedronContainsPoint(polygons1, centerPoint2))
				{
					return true;
				}
			}
			return false;
		}

		internal static bool PolygonContainsPolygon(Polygon container, Polygon containee)
		{
			if (MathHelper.PlaneEqualsLooserWithFlip(container.Plane, containee.Plane))
			{
				Plane plane = container.Plane;
				for (int i = 0; i < container.Vertices.Length; i++)
				{
					Vector3 position = container.Vertices[i].Position;
					Vector3 position2 = container.Vertices[(i + 1) % container.Vertices.Length].Position;
					Vector3 lhs = position2 - position;
					Vector3 normal = plane.normal;
					Vector3 lhs2 = Vector3.Cross(lhs, normal);
					Vector3 vector = (position + position2) * 0.5f;
					float num = 0.03f;
					if (num != 0f)
					{
						vector += lhs2.normalized * num;
					}
					for (int j = 0; j < containee.Vertices.Length; j++)
					{
						Vector3 position3 = containee.Vertices[j].Position;
						Vector3 rhs = vector - position3;
						if (Vector3.Dot(lhs2, rhs) < 0f)
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}
	}
}
