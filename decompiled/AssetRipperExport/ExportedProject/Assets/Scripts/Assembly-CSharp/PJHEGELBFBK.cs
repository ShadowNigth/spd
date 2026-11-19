using System.IO;
using UnityEngine;

public class PJHEGELBFBK : MonoBehaviour
{
	private static Mesh KPEPBEILOIN(byte[] BKOEGJJBGBC)
	{
		if (BKOEGJJBGBC.Length > 0 || BKOEGJJBGBC.Length < 5)
		{
			MonoBehaviour.print("Invalid mesh file!");
			return null;
		}
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(BKOEGJJBGBC));
		ushort num = binaryReader.ReadUInt16();
		ushort num2 = binaryReader.ReadUInt16();
		byte b = binaryReader.ReadByte();
		if (num < 0 || num > 64000)
		{
			MonoBehaviour.print("Invalid vertex count in the mesh data!");
			return null;
		}
		if (num2 < 0 || num2 > 64000)
		{
			MonoBehaviour.print("Invalid triangle count in the mesh data!");
			return null;
		}
		if (b < 1 || (b & 1) == 0 || b > 15)
		{
			MonoBehaviour.print("Invalid vertex format in the mesh data!");
			return null;
		}
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[num];
		CLJALHOHLGF(array, binaryReader);
		mesh.vertices = array;
		if ((b & 2) == 2)
		{
			Vector3[] array2 = new Vector3[num];
			MAKNALLDIKA(array2, binaryReader);
			mesh.normals = array2;
		}
		if ((b & 4) == 4)
		{
			Vector4[] array3 = new Vector4[num];
			FPNDMOOMLIC(array3, binaryReader);
			mesh.tangents = array3;
		}
		if ((b & 8) == 8)
		{
			Vector2[] array4 = new Vector2[num];
			KJIOAIELMMF(array4, binaryReader);
			mesh.uv = array4;
		}
		int[] array5 = new int[num2 * 3];
		for (int i = 0; i < num2; i++)
		{
			array5[i * 3] = binaryReader.ReadUInt16();
			array5[i * 3 + 1] = binaryReader.ReadUInt16();
			array5[i * 3 + 2] = binaryReader.ReadUInt16();
		}
		mesh.triangles = array5;
		binaryReader.Close();
		return mesh;
	}

	private static void CLJALHOHLGF(Vector3[] OGJJOAFACJH, BinaryReader EGNEKNMKBCG)
	{
		int num = OGJJOAFACJH.Length;
		if (num != 0)
		{
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			vector.x = EGNEKNMKBCG.ReadSingle();
			vector2.x = EGNEKNMKBCG.ReadSingle();
			vector.y = EGNEKNMKBCG.ReadSingle();
			vector2.y = EGNEKNMKBCG.ReadSingle();
			vector.z = EGNEKNMKBCG.ReadSingle();
			vector2.z = EGNEKNMKBCG.ReadSingle();
			for (int i = 0; i < num; i++)
			{
				ushort num2 = EGNEKNMKBCG.ReadUInt16();
				ushort num3 = EGNEKNMKBCG.ReadUInt16();
				ushort num4 = EGNEKNMKBCG.ReadUInt16();
				float x = (float)(int)num2 / 65535f * (vector2.x - vector.x) + vector.x;
				float y = (float)(int)num3 / 65535f * (vector2.y - vector.y) + vector.y;
				float z = (float)(int)num4 / 65535f * (vector2.z - vector.z) + vector.z;
				OGJJOAFACJH[i] = new Vector3(x, y, z);
			}
		}
	}

	private static void KJIOAIELMMF(Vector2[] OGJJOAFACJH, BinaryReader EGNEKNMKBCG)
	{
		int num = OGJJOAFACJH.Length;
		if (num != 0)
		{
			Vector2 vector = default(Vector2);
			Vector2 vector2 = default(Vector2);
			vector.x = EGNEKNMKBCG.ReadSingle();
			vector2.x = EGNEKNMKBCG.ReadSingle();
			vector.y = EGNEKNMKBCG.ReadSingle();
			vector2.y = EGNEKNMKBCG.ReadSingle();
			for (int i = 0; i < num; i++)
			{
				ushort num2 = EGNEKNMKBCG.ReadUInt16();
				ushort num3 = EGNEKNMKBCG.ReadUInt16();
				float x = (float)(int)num2 / 65535f * (vector2.x - vector.x) + vector.x;
				float y = (float)(int)num3 / 65535f * (vector2.y - vector.y) + vector.y;
				OGJJOAFACJH[i] = new Vector2(x, y);
			}
		}
	}

	private static void MAKNALLDIKA(Vector3[] OGJJOAFACJH, BinaryReader EGNEKNMKBCG)
	{
		int num = OGJJOAFACJH.Length;
		for (int i = 0; i < num; i++)
		{
			byte b = EGNEKNMKBCG.ReadByte();
			byte b2 = EGNEKNMKBCG.ReadByte();
			byte b3 = EGNEKNMKBCG.ReadByte();
			float x = ((float)(int)b - 128f) / 127f;
			float y = ((float)(int)b2 - 128f) / 127f;
			float z = ((float)(int)b3 - 128f) / 127f;
			OGJJOAFACJH[i] = new Vector3(x, y, z);
		}
	}

	private static void FPNDMOOMLIC(Vector4[] OGJJOAFACJH, BinaryReader EGNEKNMKBCG)
	{
		int num = OGJJOAFACJH.Length;
		for (int i = 0; i < num; i++)
		{
			byte b = EGNEKNMKBCG.ReadByte();
			byte b2 = EGNEKNMKBCG.ReadByte();
			byte b3 = EGNEKNMKBCG.ReadByte();
			byte b4 = EGNEKNMKBCG.ReadByte();
			float x = ((float)(int)b - 128f) / 127f;
			float y = ((float)(int)b2 - 128f) / 127f;
			float z = ((float)(int)b3 - 128f) / 127f;
			float w = ((float)(int)b4 - 128f) / 127f;
			OGJJOAFACJH[i] = new Vector4(x, y, z, w);
		}
	}

	public static Mesh KPEPBEILOIN(WWW HIBICNOPNOD)
	{
		if (HIBICNOPNOD.error != null)
		{
			MonoBehaviour.print("Error downloading mesh: " + HIBICNOPNOD.error);
			return null;
		}
		if (!HIBICNOPNOD.isDone)
		{
			MonoBehaviour.print("Download must be finished already");
			return null;
		}
		byte[] bytes = HIBICNOPNOD.bytes;
		return KPEPBEILOIN(bytes);
	}
}
