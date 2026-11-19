using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG.ShapeEditor.Decomposition
{
	public static class BayazitDecomposer
	{
		private static class MathUtils
		{
			public static float Area(Vector2 a, Vector2 b, Vector2 c)
			{
				return Area(ref a, ref b, ref c);
			}

			public static float Area(ref Vector2 a, ref Vector2 b, ref Vector2 c)
			{
				return a.x * (b.y - c.y) + b.x * (c.y - a.y) + c.x * (a.y - b.y);
			}

			public static bool FloatEquals(float value1, float value2)
			{
				return Math.Abs(value1 - value2) <= SettingsEpsilon;
			}

			public static bool Collinear(ref Vector2 a, ref Vector2 b, ref Vector2 c)
			{
				return Collinear(ref a, ref b, ref c, 0f);
			}

			public static bool Collinear(ref Vector2 a, ref Vector2 b, ref Vector2 c, float tolerance)
			{
				return FloatInRange(Area(ref a, ref b, ref c), 0f - tolerance, tolerance);
			}

			public static bool FloatInRange(float value, float min, float max)
			{
				return value >= min && value <= max;
			}

			public static int NextIndex(Vector2[] vertices, int index)
			{
				return (index + 1 <= vertices.Length - 1) ? (index + 1) : 0;
			}

			public static int PreviousIndex(Vector2[] vertices, int index)
			{
				return (index - 1 >= 0) ? (index - 1) : (vertices.Length - 1);
			}
		}

		private static class LineTools
		{
			public static Vector2 LineIntersect(Vector2 p1, Vector2 p2, Vector2 q1, Vector2 q2)
			{
				Vector2 zero = Vector2.zero;
				float num = p2.y - p1.y;
				float num2 = p1.x - p2.x;
				float num3 = num * p1.x + num2 * p1.y;
				float num4 = q2.y - q1.y;
				float num5 = q1.x - q2.x;
				float num6 = num4 * q1.x + num5 * q1.y;
				float num7 = num * num5 - num4 * num2;
				if (!MathUtils.FloatEquals(num7, 0f))
				{
					zero.x = (num5 * num3 - num2 * num6) / num7;
					zero.y = (num * num6 - num4 * num3) / num7;
				}
				return zero;
			}

			public static bool LineIntersect(Vector2 point1, Vector2 point2, Vector2 point3, Vector2 point4, out Vector2 intersectionPoint)
			{
				return LineIntersect(ref point1, ref point2, ref point3, ref point4, true, true, out intersectionPoint);
			}

			public static bool LineIntersect(Vector2 point1, Vector2 point2, Vector2 point3, Vector2 point4, bool firstIsSegment, bool secondIsSegment, out Vector2 intersectionPoint)
			{
				return LineIntersect(ref point1, ref point2, ref point3, ref point4, firstIsSegment, secondIsSegment, out intersectionPoint);
			}

			public static bool LineIntersect(ref Vector2 point1, ref Vector2 point2, ref Vector2 point3, ref Vector2 point4, bool firstIsSegment, bool secondIsSegment, out Vector2 point)
			{
				point = default(Vector2);
				float num = point4.y - point3.y;
				float num2 = point2.x - point1.x;
				float num3 = point4.x - point3.x;
				float num4 = point2.y - point1.y;
				float num5 = num * num2 - num3 * num4;
				if (!(num5 >= 0f - SettingsEpsilon) || !(num5 <= SettingsEpsilon))
				{
					float num6 = point1.y - point3.y;
					float num7 = point1.x - point3.x;
					float num8 = 1f / num5;
					float num9 = num3 * num6 - num * num7;
					num9 *= num8;
					if (!firstIsSegment || (num9 >= 0f && num9 <= 1f))
					{
						float num10 = num2 * num6 - num4 * num7;
						num10 *= num8;
						if ((!secondIsSegment || (num10 >= 0f && num10 <= 1f)) && (num9 != 0f || num10 != 0f))
						{
							point.x = point1.x + num9 * num2;
							point.y = point1.y + num9 * num4;
							return true;
						}
					}
				}
				return false;
			}
		}

		private static class SimplifyTools
		{
			public static Vector2[] CollinearSimplify(Vector2[] vertices, float collinearityTolerance)
			{
				if (vertices.Length < 3)
				{
					return vertices;
				}
				List<Vector2> list = new List<Vector2>();
				for (int i = 0; i < vertices.Length; i++)
				{
					int num = MathUtils.PreviousIndex(vertices, i);
					int num2 = MathUtils.NextIndex(vertices, i);
					Vector2 a = vertices[num];
					Vector2 b = vertices[i];
					Vector2 c = vertices[num2];
					if (!MathUtils.Collinear(ref a, ref b, ref c, collinearityTolerance))
					{
						list.Add(b);
					}
				}
				return list.ToArray();
			}
		}

		public static float SettingsEpsilon = 0.0001f;

		public static int MaxPolygonVertices = 1024;

		private static Vector2 At(int i, Vector2[] vertices)
		{
			int num = vertices.Length;
			return vertices[(i >= 0) ? (i % num) : (num - -i % num)];
		}

		private static Vector2[] Copy(int i, int j, Vector2[] vertices)
		{
			List<Vector2> list = new List<Vector2>();
			while (j < i)
			{
				j += vertices.Length;
			}
			while (i <= j)
			{
				list.Add(At(i, vertices));
				i++;
			}
			return list.ToArray();
		}

		public static List<Vector2[]> ConvexPartition(Vector2[] vertices)
		{
			List<Vector2[]> list = new List<Vector2[]>();
			Vector2 vector = default(Vector2);
			Vector2 vector2 = default(Vector2);
			int num = 0;
			int i = 0;
			for (int j = 0; j < vertices.Length; j++)
			{
				if (!Reflex(j, vertices))
				{
					continue;
				}
				float num3;
				float num2 = (num3 = float.MaxValue);
				for (int k = 0; k < vertices.Length; k++)
				{
					Vector2 vector3;
					if (Left(At(j - 1, vertices), At(j, vertices), At(k, vertices)) && RightOn(At(j - 1, vertices), At(j, vertices), At(k - 1, vertices)))
					{
						vector3 = LineTools.LineIntersect(At(j - 1, vertices), At(j, vertices), At(k, vertices), At(k - 1, vertices));
						if (Right(At(j + 1, vertices), At(j, vertices), vector3))
						{
							float num4 = SquareDist(At(j, vertices), vector3);
							if (num4 < num2)
							{
								num2 = num4;
								vector = vector3;
								num = k;
							}
						}
					}
					if (!Left(At(j + 1, vertices), At(j, vertices), At(k + 1, vertices)) || !RightOn(At(j + 1, vertices), At(j, vertices), At(k, vertices)))
					{
						continue;
					}
					vector3 = LineTools.LineIntersect(At(j + 1, vertices), At(j, vertices), At(k, vertices), At(k + 1, vertices));
					if (Left(At(j - 1, vertices), At(j, vertices), vector3))
					{
						float num4 = SquareDist(At(j, vertices), vector3);
						if (num4 < num3)
						{
							num3 = num4;
							i = k;
							vector2 = vector3;
						}
					}
				}
				List<Vector2> list2;
				List<Vector2> list3;
				if (num == (i + 1) % vertices.Length)
				{
					Vector2 item = (vector + vector2) / 2f;
					list2 = Copy(j, i, vertices).ToList();
					list2.Add(item);
					list3 = Copy(num, j, vertices).ToList();
					list3.Add(item);
				}
				else
				{
					double num5 = 0.0;
					double num6 = num;
					for (; i < num; i += vertices.Length)
					{
					}
					for (int l = num; l <= i; l++)
					{
						if (CanSee(j, l, vertices))
						{
							double num7 = 1f / (SquareDist(At(j, vertices), At(l, vertices)) + 1f);
							num7 = ((!Reflex(l, vertices)) ? (num7 + 1.0) : ((!RightOn(At(l - 1, vertices), At(l, vertices), At(j, vertices)) || !LeftOn(At(l + 1, vertices), At(l, vertices), At(j, vertices))) ? (num7 + 2.0) : (num7 + 3.0)));
							if (num7 > num5)
							{
								num6 = l;
								num5 = num7;
							}
						}
					}
					list2 = Copy(j, (int)num6, vertices).ToList();
					list3 = Copy((int)num6, j, vertices).ToList();
				}
				list.AddRange(ConvexPartition(list2.ToArray()));
				list.AddRange(ConvexPartition(list3.ToArray()));
				return list;
			}
			if (vertices.Length > MaxPolygonVertices)
			{
				List<Vector2> list2 = Copy(0, vertices.Length / 2, vertices).ToList();
				List<Vector2> list3 = Copy(vertices.Length / 2, 0, vertices).ToList();
				list.AddRange(ConvexPartition(list2.ToArray()));
				list.AddRange(ConvexPartition(list3.ToArray()));
			}
			else
			{
				list.Add(vertices);
			}
			for (int m = 0; m < list.Count; m++)
			{
				list[m] = SimplifyTools.CollinearSimplify(list[m], 0f);
			}
			for (int num8 = list.Count - 1; num8 >= 0; num8--)
			{
				if (list[num8].Length == 0)
				{
					list.RemoveAt(num8);
				}
			}
			return list;
		}

		private static bool CanSee(int i, int j, Vector2[] vertices)
		{
			if (Reflex(i, vertices))
			{
				if (LeftOn(At(i, vertices), At(i - 1, vertices), At(j, vertices)) && RightOn(At(i, vertices), At(i + 1, vertices), At(j, vertices)))
				{
					return false;
				}
			}
			else if (RightOn(At(i, vertices), At(i + 1, vertices), At(j, vertices)) || LeftOn(At(i, vertices), At(i - 1, vertices), At(j, vertices)))
			{
				return false;
			}
			if (Reflex(j, vertices))
			{
				if (LeftOn(At(j, vertices), At(j - 1, vertices), At(i, vertices)) && RightOn(At(j, vertices), At(j + 1, vertices), At(i, vertices)))
				{
					return false;
				}
			}
			else if (RightOn(At(j, vertices), At(j + 1, vertices), At(i, vertices)) || LeftOn(At(j, vertices), At(j - 1, vertices), At(i, vertices)))
			{
				return false;
			}
			for (int k = 0; k < vertices.Length; k++)
			{
				Vector2 intersectionPoint;
				if ((k + 1) % vertices.Length != i && k != i && (k + 1) % vertices.Length != j && k != j && LineTools.LineIntersect(At(i, vertices), At(j, vertices), At(k, vertices), At(k + 1, vertices), out intersectionPoint))
				{
					return false;
				}
			}
			return true;
		}

		private static bool Reflex(int i, Vector2[] vertices)
		{
			return Right(i, vertices);
		}

		private static bool Right(int i, Vector2[] vertices)
		{
			return Right(At(i - 1, vertices), At(i, vertices), At(i + 1, vertices));
		}

		private static bool Left(Vector2 a, Vector2 b, Vector2 c)
		{
			return MathUtils.Area(ref a, ref b, ref c) > 0f;
		}

		private static bool LeftOn(Vector2 a, Vector2 b, Vector2 c)
		{
			return MathUtils.Area(ref a, ref b, ref c) >= 0f;
		}

		private static bool Right(Vector2 a, Vector2 b, Vector2 c)
		{
			return MathUtils.Area(ref a, ref b, ref c) < 0f;
		}

		private static bool RightOn(Vector2 a, Vector2 b, Vector2 c)
		{
			return MathUtils.Area(ref a, ref b, ref c) <= 0f;
		}

		private static float SquareDist(Vector2 a, Vector2 b)
		{
			float num = b.x - a.x;
			float num2 = b.y - a.y;
			return num * num + num2 * num2;
		}
	}
}
