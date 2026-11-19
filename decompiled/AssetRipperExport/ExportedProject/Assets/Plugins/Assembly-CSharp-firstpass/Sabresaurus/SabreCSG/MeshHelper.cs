using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public static class MeshHelper
	{
		public static void Displace(ref Mesh mesh, float displacement)
		{
			Vector3[] vertices = mesh.vertices;
			for (int i = 0; i < mesh.vertices.Length; i++)
			{
				vertices[i] += mesh.normals[i] * displacement;
			}
			mesh.vertices = vertices;
		}

		public static void Invert(ref Mesh mesh)
		{
			Vector3[] normals = mesh.normals;
			for (int i = 0; i < mesh.normals.Length; i++)
			{
				normals[i] *= -1f;
			}
			int[] triangles = mesh.triangles;
			for (int j = 0; j < triangles.Length; j += 3)
			{
				int num = triangles[j];
				int num2 = triangles[j + 1];
				int num3 = triangles[j + 2];
				triangles[j + 2] = num;
				triangles[j + 1] = num2;
				triangles[j] = num3;
			}
			mesh.triangles = triangles;
			mesh.normals = normals;
		}
	}
}
