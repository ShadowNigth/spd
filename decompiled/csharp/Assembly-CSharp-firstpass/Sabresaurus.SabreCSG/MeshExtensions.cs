using UnityEngine;

namespace Sabresaurus.SabreCSG;

internal static class MeshExtensions
{
	internal static void GenerateTangents(this Mesh mesh)
	{
		int[] triangles = mesh.triangles;
		Vector3[] vertices = mesh.vertices;
		Vector2[] uv = mesh.uv;
		Vector3[] normals = mesh.normals;
		int num = triangles.Length;
		int num2 = vertices.Length;
		Vector3[] array = new Vector3[num2];
		Vector3[] array2 = new Vector3[num2];
		Vector4[] array3 = new Vector4[num2];
		for (long num3 = 0L; num3 < num; num3 += 3)
		{
			long num4 = triangles[num3];
			long num5 = triangles[num3 + 1];
			long num6 = triangles[num3 + 2];
			Vector3 vector = vertices[num4];
			Vector3 vector2 = vertices[num5];
			Vector3 vector3 = vertices[num6];
			Vector2 vector4 = uv[num4];
			Vector2 vector5 = uv[num5];
			Vector2 vector6 = uv[num6];
			float num7 = vector2.x - vector.x;
			float num8 = vector3.x - vector.x;
			float num9 = vector2.y - vector.y;
			float num10 = vector3.y - vector.y;
			float num11 = vector2.z - vector.z;
			float num12 = vector3.z - vector.z;
			float num13 = vector5.x - vector4.x;
			float num14 = vector6.x - vector4.x;
			float num15 = vector5.y - vector4.y;
			float num16 = vector6.y - vector4.y;
			float num17 = num13 * num16 - num14 * num15;
			float num18 = ((num17 != 0f) ? (1f / num17) : 0f);
			Vector3 vector7 = new Vector3((num16 * num7 - num15 * num8) * num18, (num16 * num9 - num15 * num10) * num18, (num16 * num11 - num15 * num12) * num18);
			Vector3 vector8 = new Vector3((num13 * num8 - num14 * num7) * num18, (num13 * num10 - num14 * num9) * num18, (num13 * num12 - num14 * num11) * num18);
			array[num4] += vector7;
			array[num5] += vector7;
			array[num6] += vector7;
			array2[num4] += vector8;
			array2[num5] += vector8;
			array2[num6] += vector8;
		}
		for (long num19 = 0L; num19 < num2; num19++)
		{
			Vector3 normal = normals[num19];
			Vector3 tangent = array[num19];
			Vector3.OrthoNormalize(ref normal, ref tangent);
			array3[num19].x = tangent.x;
			array3[num19].y = tangent.y;
			array3[num19].z = tangent.z;
			array3[num19].w = ((!(Vector3.Dot(Vector3.Cross(normal, tangent), array2[num19]) < 0f)) ? 1f : (-1f));
		}
		mesh.tangents = array3;
	}

	internal static void LocalizeToTransform(this Mesh mesh, Transform referenceTransform)
	{
		Vector3[] vertices = mesh.vertices;
		Vector3[] normals = mesh.normals;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			ref Vector3 reference = ref vertices[i];
			reference = referenceTransform.InverseTransformPoint(vertices[i]);
			ref Vector3 reference2 = ref normals[i];
			reference2 = referenceTransform.InverseTransformDirection(normals[i]);
		}
		mesh.vertices = vertices;
		mesh.normals = normals;
		mesh.RecalculateBounds();
	}
}
