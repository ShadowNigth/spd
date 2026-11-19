using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	[Serializable]
	public class PolygonEntry : IDeepCopyable<PolygonEntry>
	{
		[SerializeField]
		public Vector3[] Positions;

		[SerializeField]
		public Vector3[] Normals;

		[SerializeField]
		public Vector2[] UV;

		[SerializeField]
		public Color32[] Colors;

		[SerializeField]
		public int[] Triangles;

		[SerializeField]
		public Material Material;

		[SerializeField]
		public bool ExcludeFromBuild;

		[SerializeField]
		public Mesh BuiltMesh;

		[SerializeField]
		public int BuiltVertexOffset;

		[SerializeField]
		public int BuiltTriangleOffset;

		public PolygonEntry(Vector3[] positions, Vector3[] normals, Vector2[] uv, Color32[] colors, int[] triangles, Material material, bool excludeFromBuild)
		{
			Positions = positions;
			Normals = normals;
			UV = uv;
			Colors = colors;
			Triangles = triangles;
			Material = material;
			ExcludeFromBuild = excludeFromBuild;
		}

		public PolygonEntry DeepCopy()
		{
			return new PolygonEntry(Positions, Normals, UV, Colors, Triangles, Material, ExcludeFromBuild);
		}

		public static bool IsValid(PolygonEntry entry)
		{
			if (entry == null)
			{
				return false;
			}
			if (entry.Positions == null || entry.UV == null)
			{
				return false;
			}
			return true;
		}

		public static bool IsValidAndBuilt(PolygonEntry entry)
		{
			if (IsValid(entry) && entry.BuiltMesh != null)
			{
				return true;
			}
			return false;
		}
	}
}
