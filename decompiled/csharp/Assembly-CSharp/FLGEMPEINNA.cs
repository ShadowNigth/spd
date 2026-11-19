using System.IO;
using UnityEngine;

public class FLGEMPEINNA : MonoBehaviour
{
	private static byte[] ILACFGJIGIK(Mesh FAHIHINKFMC)
	{
		if (!FAHIHINKFMC)
		{
			MonoBehaviour.print("No mesh given!");
			return null;
		}
		bool flag = false;
		Vector3[] vertices = FAHIHINKFMC.vertices;
		Vector3[] normals = FAHIHINKFMC.normals;
		Vector4[] tangents = FAHIHINKFMC.tangents;
		Vector2[] uv = FAHIHINKFMC.uv;
		int[] triangles = FAHIHINKFMC.triangles;
		byte b = 1;
		if (normals.Length > 0)
		{
			b = (byte)(b | 2u);
		}
		if (tangents.Length > 0)
		{
			b = (byte)(b | 4u);
			flag = true;
		}
		if (uv.Length > 0)
		{
			b = (byte)(b | 8u);
		}
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		ushort value = (ushort)vertices.Length;
		ushort value2 = (ushort)(triangles.Length / 3);
		binaryWriter.Write(value);
		binaryWriter.Write(value2);
		binaryWriter.Write(b);
		IFKFMILLJON(vertices, binaryWriter);
		FGBLKACNNMA(normals, binaryWriter);
		if (flag)
		{
			PPNKKIDBPDL(tangents, binaryWriter);
		}
		EHJOHJGHDID(uv, binaryWriter);
		int[] array = triangles;
		foreach (int num in array)
		{
			ushort value3 = (ushort)num;
			binaryWriter.Write(value3);
		}
		binaryWriter.Close();
		return memoryStream.ToArray();
	}

	private static void IFKFMILLJON(Vector3[] OGJJOAFACJH, BinaryWriter EGNEKNMKBCG)
	{
		if (OGJJOAFACJH.Length != 0)
		{
			Bounds bounds = new Bounds(OGJJOAFACJH[0], new Vector3(0.001f, 0.001f, 0.001f));
			foreach (Vector3 point in OGJJOAFACJH)
			{
				bounds.Encapsulate(point);
			}
			Vector3 min = bounds.min;
			Vector3 max = bounds.max;
			EGNEKNMKBCG.Write(min.x);
			EGNEKNMKBCG.Write(max.x);
			EGNEKNMKBCG.Write(min.y);
			EGNEKNMKBCG.Write(max.y);
			EGNEKNMKBCG.Write(min.z);
			EGNEKNMKBCG.Write(max.z);
			for (int j = 0; j < OGJJOAFACJH.Length; j++)
			{
				Vector3 vector = OGJJOAFACJH[j];
				float num = Mathf.Clamp((vector.x - min.x) / (max.x - min.x) * 65535f, 0f, 65535f);
				float num2 = Mathf.Clamp((vector.y - min.y) / (max.y - min.y) * 65535f, 0f, 65535f);
				float num3 = Mathf.Clamp((vector.z - min.z) / (max.z - min.z) * 65535f, 0f, 65535f);
				ushort value = (ushort)num;
				ushort value2 = (ushort)num2;
				ushort value3 = (ushort)num3;
				EGNEKNMKBCG.Write(value);
				EGNEKNMKBCG.Write(value2);
				EGNEKNMKBCG.Write(value3);
			}
		}
	}

	private static void EHJOHJGHDID(Vector2[] OGJJOAFACJH, BinaryWriter EGNEKNMKBCG)
	{
		if (OGJJOAFACJH.Length != 0)
		{
			Vector2 vector = OGJJOAFACJH[0] - new Vector2(0.001f, 0.001f);
			Vector2 vector2 = OGJJOAFACJH[0] + new Vector2(0.001f, 0.001f);
			for (int i = 0; i < OGJJOAFACJH.Length; i++)
			{
				Vector2 vector3 = OGJJOAFACJH[i];
				vector.x = Mathf.Min(vector.x, vector3.x);
				vector.y = Mathf.Min(vector.y, vector3.y);
				vector2.x = Mathf.Max(vector2.x, vector3.x);
				vector2.y = Mathf.Max(vector2.y, vector3.y);
			}
			EGNEKNMKBCG.Write(vector.x);
			EGNEKNMKBCG.Write(vector2.x);
			EGNEKNMKBCG.Write(vector.y);
			EGNEKNMKBCG.Write(vector2.y);
			for (int j = 0; j < OGJJOAFACJH.Length; j++)
			{
				Vector2 vector4 = OGJJOAFACJH[j];
				float num = (vector4.x - vector.x) / (vector2.x - vector.x) * 65535f;
				float num2 = (vector4.y - vector.y) / (vector2.y - vector.y) * 65535f;
				ushort value = (ushort)num;
				ushort value2 = (ushort)num2;
				EGNEKNMKBCG.Write(value);
				EGNEKNMKBCG.Write(value2);
			}
		}
	}

	private static void FGBLKACNNMA(Vector3[] OGJJOAFACJH, BinaryWriter EGNEKNMKBCG)
	{
		for (int i = 0; i < OGJJOAFACJH.Length; i++)
		{
			Vector3 vector = OGJJOAFACJH[i];
			byte value = (byte)Mathf.Clamp(vector.x * 127f + 128f, 0f, 255f);
			byte value2 = (byte)Mathf.Clamp(vector.y * 127f + 128f, 0f, 255f);
			byte value3 = (byte)Mathf.Clamp(vector.z * 127f + 128f, 0f, 255f);
			EGNEKNMKBCG.Write(value);
			EGNEKNMKBCG.Write(value2);
			EGNEKNMKBCG.Write(value3);
		}
	}

	private static void PPNKKIDBPDL(Vector4[] OGJJOAFACJH, BinaryWriter EGNEKNMKBCG)
	{
		for (int i = 0; i < OGJJOAFACJH.Length; i++)
		{
			Vector4 vector = OGJJOAFACJH[i];
			byte value = (byte)Mathf.Clamp(vector.x * 127f + 128f, 0f, 255f);
			byte value2 = (byte)Mathf.Clamp(vector.y * 127f + 128f, 0f, 255f);
			byte value3 = (byte)Mathf.Clamp(vector.z * 127f + 128f, 0f, 255f);
			byte value4 = (byte)Mathf.Clamp(vector.w * 127f + 128f, 0f, 255f);
			EGNEKNMKBCG.Write(value);
			EGNEKNMKBCG.Write(value2);
			EGNEKNMKBCG.Write(value3);
			EGNEKNMKBCG.Write(value4);
		}
	}

	public static void ILACFGJIGIK(Mesh FAHIHINKFMC, string GIGKOEGBDMM)
	{
		byte[] array = ILACFGJIGIK(FAHIHINKFMC);
		FileStream fileStream = new FileStream(GIGKOEGBDMM, FileMode.Create);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
	}

	public static void OMKELOJPBCI(Texture2D GNHIFFCKLJD, string GIGKOEGBDMM)
	{
		byte[] array = GNHIFFCKLJD.EncodeToPNG();
		try
		{
			using BinaryWriter binaryWriter = new BinaryWriter(File.Open(GIGKOEGBDMM, FileMode.Create));
			binaryWriter.Write(array, 0, array.Length);
			binaryWriter.Close();
		}
		catch
		{
			Debug.Log("Error writing texture");
		}
	}
}
