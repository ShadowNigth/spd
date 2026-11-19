using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public static class Extensions
	{
		public static Vector3 Abs(this Vector3 a)
		{
			return new Vector3(Mathf.Abs(a.x), Mathf.Abs(a.y), Mathf.Abs(a.z));
		}

		public static Vector3 Multiply(this Vector3 a, Vector3 b)
		{
			return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		public static Vector3 Divide(this Vector3 a, Vector3 b)
		{
			return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z);
		}

		public static Vector3 SetAxis(this Vector3 vector, int axis, float newValue)
		{
			if (axis < 0 || axis > 2)
			{
				throw new ArgumentOutOfRangeException("Axis must be 0, 1 or 2");
			}
			vector[axis] = newValue;
			return vector;
		}

		public static int GetSetAxisCount(this Vector3 vector)
		{
			int num = 0;
			for (int i = 0; i < 3; i++)
			{
				if (Mathf.Abs(vector[i]) > 0.001f)
				{
					num++;
				}
			}
			return num++;
		}

		public static Vector2 Multiply(this Vector2 a, Vector2 b)
		{
			return new Vector2(a.x * b.x, a.y * b.y);
		}

		public static Vector2 Divide(this Vector2 a, Vector2 b)
		{
			return new Vector2(a.x / b.x, a.y / b.y);
		}

		public static bool HasComponent<T>(this MonoBehaviour behaviour) where T : Component
		{
			return behaviour.GetComponent<T>() != null;
		}

		public static bool HasComponent<T>(this GameObject gameObject) where T : Component
		{
			return gameObject.GetComponent<T>() != null;
		}

		public static T AddOrGetComponent<T>(this MonoBehaviour behaviour) where T : Component
		{
			T component = behaviour.GetComponent<T>();
			if (component != null)
			{
				return component;
			}
			return behaviour.gameObject.AddComponent<T>();
		}

		public static T AddOrGetComponent<T>(this GameObject gameObject) where T : Component
		{
			T component = gameObject.GetComponent<T>();
			if (component != null)
			{
				return component;
			}
			return gameObject.AddComponent<T>();
		}

		public static Vector2 Rotate(this Vector2 vector, float angle)
		{
			angle *= (float)Math.PI / 180f;
			return new Vector2(vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle), vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle));
		}

		public static float GetSmallestExtent(this Bounds bounds)
		{
			if (bounds.extents.x < bounds.extents.y && bounds.extents.x < bounds.extents.z)
			{
				return bounds.extents.x;
			}
			if (bounds.extents.y < bounds.extents.x && bounds.extents.y < bounds.extents.z)
			{
				return bounds.extents.y;
			}
			return bounds.extents.z;
		}

		public static float GetLargestExtent(this Bounds bounds)
		{
			if (bounds.extents.x > bounds.extents.y && bounds.extents.x > bounds.extents.z)
			{
				return bounds.extents.x;
			}
			if (bounds.extents.y > bounds.extents.x && bounds.extents.y > bounds.extents.z)
			{
				return bounds.extents.y;
			}
			return bounds.extents.z;
		}

		public static bool Equals(this Color32 color, Color32 other)
		{
			if (color.r == other.r && color.g == other.g && color.b == other.b && color.a == other.a)
			{
				return true;
			}
			return false;
		}

		public static bool NotEquals(this Color32 color, Color32 other)
		{
			if (color.r != other.r || color.g != other.g || color.b != other.b || color.a != other.a)
			{
				return true;
			}
			return false;
		}

		public static Transform AddChild(this Transform parentTransform, string name)
		{
			GameObject gameObject = new GameObject(name);
			gameObject.transform.parent = parentTransform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.transform.localScale = Vector3.one;
			return gameObject.transform;
		}

		public static void DestroyChildrenImmediate(this Transform parentTransform)
		{
			int childCount = parentTransform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				GameObject gameObject = parentTransform.GetChild(0).gameObject;
				UnityEngine.Object.DestroyImmediate(gameObject);
			}
		}

		public static bool IsParentOf(this Transform thisTransform, Transform otherTransform)
		{
			Transform parent = otherTransform.parent;
			while (parent != null)
			{
				if (parent == thisTransform)
				{
					return true;
				}
				parent = parent.parent;
			}
			return false;
		}

		public static void ForceRefreshSharedMesh(this MeshCollider meshCollider)
		{
			Mesh sharedMesh = meshCollider.sharedMesh;
			meshCollider.sharedMesh = null;
			meshCollider.sharedMesh = sharedMesh;
		}

		public static void ForceRefreshSharedMesh(this MeshFilter meshFilter)
		{
			Mesh sharedMesh = meshFilter.sharedMesh;
			Vector3[] vertices = sharedMesh.vertices;
			sharedMesh.vertices = vertices;
		}

		public static string ToStringLong(this Vector3 source)
		{
			return string.Format("{0},{1},{2}", source.x, source.y, source.z);
		}

		public static string ToStringLong(this Plane source)
		{
			return string.Format("{0}, {1}, {2} : {3}", source.normal.x, source.normal.y, source.normal.z, source.distance);
		}

		public static string ToStringWithSuffix(this int number, string suffixSingular, string suffixPlural)
		{
			if (number == 1)
			{
				return number + suffixSingular;
			}
			return number + suffixPlural;
		}

		public static bool ContentsEquals<T>(this T[] array1, T[] array2)
		{
			if (object.ReferenceEquals(array1, array2))
			{
				return true;
			}
			if (array1 == null || array2 == null)
			{
				return false;
			}
			if (array1.Length != array2.Length)
			{
				return false;
			}
			EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
			for (int i = 0; i < array1.Length; i++)
			{
				if (!equalityComparer.Equals(array1[i], array2[i]))
				{
					return false;
				}
			}
			return true;
		}

		public static bool ContentsEquals<T>(this List<T> list1, List<T> list2)
		{
			if (object.ReferenceEquals(list1, list2))
			{
				return true;
			}
			if (list1 == null || list2 == null)
			{
				return false;
			}
			if (list1.Count != list2.Count)
			{
				return false;
			}
			EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
			for (int i = 0; i < list1.Count; i++)
			{
				if (!equalityComparer.Equals(list1[i], list2[i]))
				{
					return false;
				}
			}
			return true;
		}

		public static int[] GetTrianglesSafe(this Mesh mesh)
		{
			if (mesh.vertexCount == 0)
			{
				return new int[0];
			}
			return mesh.triangles;
		}

		public static bool EqualsWithEpsilon(this float a, float b)
		{
			return Mathf.Abs(a - b) < 1E-05f;
		}

		public static bool EqualsWithEpsilon(this Vector3 a, Vector3 b)
		{
			return Mathf.Abs(a.x - b.x) < 1E-05f && Mathf.Abs(a.y - b.y) < 1E-05f && Mathf.Abs(a.z - b.z) < 1E-05f;
		}

		public static bool EqualsWithEpsilonLower(this Vector3 a, Vector3 b)
		{
			return Mathf.Abs(a.x - b.x) < 0.0001f && Mathf.Abs(a.y - b.y) < 0.0001f && Mathf.Abs(a.z - b.z) < 0.0001f;
		}

		public static bool EqualsWithEpsilonLower3(this Vector3 a, Vector3 b)
		{
			return Mathf.Abs(a.x - b.x) < 0.01f && Mathf.Abs(a.y - b.y) < 0.01f && Mathf.Abs(a.z - b.z) < 0.01f;
		}

		public static Rect ExpandFromCenter(this Rect rect, Vector2 expansion)
		{
			rect.size += expansion;
			rect.center -= expansion / 2f;
			return rect;
		}

		internal static bool Contains(this Bounds bounds1, Bounds bounds2)
		{
			if (bounds1.Contains(bounds2.min) && bounds1.Contains(bounds2.max))
			{
				return true;
			}
			return false;
		}

		internal static bool IntersectsApproximate(this Bounds bounds1, Bounds bounds2)
		{
			return bounds1.min.x - 0.001f <= bounds2.max.x && bounds1.max.x + 0.001f >= bounds2.min.x && bounds1.min.y - 0.001f <= bounds2.max.y && bounds1.max.y + 0.001f >= bounds2.min.y && bounds1.min.z - 0.001f <= bounds2.max.z && bounds1.max.z + 0.001f >= bounds2.min.z;
		}

		internal static bool ContainsWithin(this Bounds bounds1, Bounds bounds2)
		{
			return bounds2.min.x > bounds1.min.x && bounds2.min.y > bounds1.min.y && bounds2.min.z > bounds1.min.z && bounds2.max.x < bounds1.max.x && bounds2.max.y < bounds1.max.y && bounds2.max.z < bounds1.max.z;
		}

		internal static bool ContainsApproximate(this Bounds bounds1, Vector3 point)
		{
			return point.x > bounds1.min.x - 0.001f && point.y > bounds1.min.y - 0.001f && point.z > bounds1.min.z - 0.001f && point.x < bounds1.max.x + 0.001f && point.y < bounds1.max.y + 0.001f && point.z < bounds1.max.z + 0.001f;
		}

		internal static string ToGeneratedHierarchyString(this Bounds bounds)
		{
			string text = MathHelper.RoundFloat(bounds.size.x, 0.0001f).ToString(CultureInfo.InvariantCulture);
			string text2 = MathHelper.RoundFloat(bounds.size.y, 0.0001f).ToString(CultureInfo.InvariantCulture);
			string text3 = MathHelper.RoundFloat(bounds.size.z, 0.0001f).ToString(CultureInfo.InvariantCulture);
			return text + " x " + text2 + " x " + text3;
		}

		internal static bool Contains(this LayerMask layerMask, int layer)
		{
			return (int)layerMask == ((int)layerMask | (1 << layer));
		}

		public static Color Clamp01(this Color self)
		{
			return new Color(Mathf.Clamp01(self.r), Mathf.Clamp01(self.g), Mathf.Clamp01(self.b), Mathf.Clamp01(self.a));
		}

		public static Color Darken(this Color self, Color blend)
		{
			return new Color(Mathf.Min(self.r, blend.r), Mathf.Min(self.g, blend.g), Mathf.Min(self.b, blend.b), self.a);
		}

		public static Color Multiply(this Color self, Color blend)
		{
			return new Color(self.r * blend.r, self.g * blend.g, self.b * blend.b, self.a);
		}

		public static Color ColorBurn(this Color self, Color blend)
		{
			Color color = new Color(1f - self.r, 1f - self.g, 1f - self.b);
			Color color2 = new Color(color.r / blend.r, color.g / blend.g, color.b / blend.b);
			return new Color(1f - color2.r, 1f - color2.g, 1f - color2.b, self.a);
		}

		public static Color LinearBurn(this Color self, Color blend)
		{
			return new Color(self.r + blend.r - 1f, self.g + blend.g - 1f, self.b + blend.b - 1f, self.a);
		}

		public static Color Lighten(this Color self, Color blend)
		{
			return new Color(Mathf.Max(self.r, blend.r), Mathf.Max(self.g, blend.g), Mathf.Max(self.b, blend.b), self.a);
		}

		public static Color Screen(this Color self, Color blend)
		{
			Color color = new Color(1f - self.r, 1f - self.g, 1f - self.b);
			Color color2 = new Color(1f - blend.r, 1f - blend.g, 1f - blend.b);
			Color color3 = new Color(color.r * color2.r, color.g * color2.g, color.b * color.b);
			return new Color(1f - color3.r, 1f - color3.g, 1f - color3.b, self.a);
		}

		public static Color ColorDodge(this Color self, Color blend)
		{
			Color color = new Color(1f - blend.r, 1f - blend.g, 1f - blend.b);
			return new Color(self.r / color.r, self.g / color.g, self.b / color.b, self.a);
		}

		public static Color LinearDodge(this Color self, Color blend)
		{
			return new Color(self.r + blend.r, self.g + blend.g, self.b + blend.b, self.a);
		}
	}
}
