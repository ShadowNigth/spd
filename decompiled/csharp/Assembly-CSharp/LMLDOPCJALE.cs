using System.Collections.Generic;
using UnityEngine;

public class LMLDOPCJALE
{
	public class JGJKIJIDEFF
	{
		public string ALLLIGGPLMK;

		public List<EIGBOLHECCA> ANNFEPGFKME;

		public List<NNOLKJOJPEP> MAOHIONHLED;

		public JGJKIJIDEFF()
		{
			ANNFEPGFKME = new List<EIGBOLHECCA>();
			MAOHIONHLED = new List<NNOLKJOJPEP>();
		}
	}

	public class EIGBOLHECCA
	{
		public string ALLLIGGPLMK;

		public string NINIOECCDFM;

		public List<NNOLKJOJPEP> CKDDAODLAOF;

		public bool KFPNJKLEAPM => CKDDAODLAOF.Count == 0;

		public EIGBOLHECCA()
		{
			CKDDAODLAOF = new List<NNOLKJOJPEP>();
		}
	}

	public List<JGJKIJIDEFF> HPALAEHEPEK;

	public List<Vector3> KOGKFEMKGBB;

	public List<Vector2> LIAPFPOHECF;

	public List<Vector3> FCKMEAFJCJN;

	private bool OLPNBGOBCMA;

	private JGJKIJIDEFF HAIBEGHBGHK;

	private EIGBOLHECCA GJMOIAAOKBA;

	public int GLAOOFIGOOK => HPALAEHEPEK.Count;

	public bool KFPNJKLEAPM => KOGKFEMKGBB.Count == 0;

	public bool LJADJBECLND => LIAPFPOHECF.Count > 0;

	public bool PBNDBKDNNLI => FCKMEAFJCJN.Count > 0;

	public LMLDOPCJALE()
	{
		HPALAEHEPEK = new List<JGJKIJIDEFF>();
		JGJKIJIDEFF jGJKIJIDEFF = new JGJKIJIDEFF
		{
			ALLLIGGPLMK = "_spc_default"
		};
		HPALAEHEPEK.Add(jGJKIJIDEFF);
		HAIBEGHBGHK = jGJKIJIDEFF;
		EIGBOLHECCA eIGBOLHECCA = new EIGBOLHECCA
		{
			ALLLIGGPLMK = "_spc_default",
			NINIOECCDFM = "_spc_default"
		};
		jGJKIJIDEFF.ANNFEPGFKME.Add(eIGBOLHECCA);
		GJMOIAAOKBA = eIGBOLHECCA;
		KOGKFEMKGBB = new List<Vector3>();
		LIAPFPOHECF = new List<Vector2>();
		FCKMEAFJCJN = new List<Vector3>();
	}

	public void HMJGHMMBPBN(string ALLLIGGPLMK)
	{
		if (GJMOIAAOKBA.KFPNJKLEAPM)
		{
			HPALAEHEPEK.Remove(HAIBEGHBGHK);
		}
		JGJKIJIDEFF jGJKIJIDEFF = new JGJKIJIDEFF();
		jGJKIJIDEFF.ALLLIGGPLMK = ALLLIGGPLMK;
		HPALAEHEPEK.Add(jGJKIJIDEFF);
		EIGBOLHECCA eIGBOLHECCA = new EIGBOLHECCA();
		eIGBOLHECCA.ALLLIGGPLMK = "_spc_default";
		jGJKIJIDEFF.ANNFEPGFKME.Add(eIGBOLHECCA);
		GJMOIAAOKBA = eIGBOLHECCA;
		HAIBEGHBGHK = jGJKIJIDEFF;
	}

	public void PNHBFKNONAK(string ALLLIGGPLMK)
	{
		if (GJMOIAAOKBA.KFPNJKLEAPM)
		{
			HAIBEGHBGHK.ANNFEPGFKME.Remove(GJMOIAAOKBA);
		}
		EIGBOLHECCA eIGBOLHECCA = new EIGBOLHECCA();
		eIGBOLHECCA.ALLLIGGPLMK = ALLLIGGPLMK;
		eIGBOLHECCA.NINIOECCDFM = "_spc_default";
		HAIBEGHBGHK.ANNFEPGFKME.Add(eIGBOLHECCA);
		GJMOIAAOKBA = eIGBOLHECCA;
	}

	public void GHLHIMFPBHL(string ALLLIGGPLMK)
	{
		bool flag = false;
		foreach (EIGBOLHECCA item in HAIBEGHBGHK.ANNFEPGFKME)
		{
			if (item.ALLLIGGPLMK == ALLLIGGPLMK)
			{
				GJMOIAAOKBA = item;
				GJMOIAAOKBA.NINIOECCDFM = ALLLIGGPLMK;
				flag = true;
				OLPNBGOBCMA = true;
			}
		}
		if (!flag)
		{
			if (GJMOIAAOKBA.KFPNJKLEAPM)
			{
				HAIBEGHBGHK.ANNFEPGFKME.Remove(GJMOIAAOKBA);
			}
			EIGBOLHECCA eIGBOLHECCA = new EIGBOLHECCA();
			eIGBOLHECCA.ALLLIGGPLMK = ALLLIGGPLMK;
			eIGBOLHECCA.NINIOECCDFM = ALLLIGGPLMK;
			HAIBEGHBGHK.ANNFEPGFKME.Add(eIGBOLHECCA);
			GJMOIAAOKBA = eIGBOLHECCA;
		}
	}

	public string[] LBLELCBCBBN()
	{
		int num = 0;
		foreach (JGJKIJIDEFF item in HPALAEHEPEK)
		{
			num += item.ANNFEPGFKME.Count;
		}
		string[] array = new string[num];
		num = 0;
		foreach (JGJKIJIDEFF item2 in HPALAEHEPEK)
		{
			foreach (EIGBOLHECCA item3 in item2.ANNFEPGFKME)
			{
				array[num] = item3.NINIOECCDFM;
				num++;
			}
		}
		return array;
	}

	public void JONEIMMKBEJ(Vector3 PDAKFGKELOC)
	{
		KOGKFEMKGBB.Add(PDAKFGKELOC);
	}

	public void EJLEOCHIPJC(Vector2 PDAKFGKELOC)
	{
		LIAPFPOHECF.Add(PDAKFGKELOC);
	}

	public void LCLMMAEKKHI(Vector3 PDAKFGKELOC)
	{
		FCKMEAFJCJN.Add(PDAKFGKELOC);
	}

	public void IOCHHBGENBN(NNOLKJOJPEP GHJBEEBMOKB)
	{
		GJMOIAAOKBA.CKDDAODLAOF.Add(GHJBEEBMOKB);
		HAIBEGHBGHK.MAOHIONHLED.Add(GHJBEEBMOKB);
	}

	public bool IBBDELGIHAA()
	{
		List<JGJKIJIDEFF> list = new List<JGJKIJIDEFF>();
		bool flag = true;
		bool flag2 = false;
		foreach (JGJKIJIDEFF item in HPALAEHEPEK)
		{
			if (item.MAOHIONHLED.Count > 65000)
			{
				foreach (EIGBOLHECCA item2 in item.ANNFEPGFKME)
				{
					if (item2.CKDDAODLAOF.Count > 65000)
					{
						flag = false;
						Debug.Log("Group with more than 65000 Verts");
					}
				}
				if (!flag)
				{
					break;
				}
				Debug.Log("Trying to Resolve");
				foreach (EIGBOLHECCA item3 in item.ANNFEPGFKME)
				{
					JGJKIJIDEFF jGJKIJIDEFF = new JGJKIJIDEFF();
					jGJKIJIDEFF.ALLLIGGPLMK = item3.ALLLIGGPLMK;
					jGJKIJIDEFF.ANNFEPGFKME.Add(item3);
					jGJKIJIDEFF.MAOHIONHLED = item3.CKDDAODLAOF;
					list.Add(jGJKIJIDEFF);
				}
			}
			else
			{
				list.Add(item);
			}
		}
		if (flag)
		{
			HPALAEHEPEK = list;
			return true;
		}
		return false;
	}

	public bool NHDIJIMCOJK(bool EOLBOKFBNOI, bool AFNKOOBPFPJ)
	{
		bool result = true;
		if (AFNKOOBPFPJ)
		{
			Debug.Log("OBJ has " + HPALAEHEPEK.Count + " object(s)");
			Debug.Log("OBJ has " + KOGKFEMKGBB.Count + " vertice(s)");
			Debug.Log("OBJ has " + LIAPFPOHECF.Count + " uv(s)");
			Debug.Log("OBJ has " + FCKMEAFJCJN.Count + " normal(s)");
		}
		foreach (JGJKIJIDEFF item in HPALAEHEPEK)
		{
			if (AFNKOOBPFPJ)
			{
				Debug.Log(item.ALLLIGGPLMK + " has " + item.ANNFEPGFKME.Count + " group(s)" + item.MAOHIONHLED.Count + "faces");
			}
			if (item.MAOHIONHLED.Count >= 64000)
			{
				result = false;
			}
			foreach (EIGBOLHECCA item2 in item.ANNFEPGFKME)
			{
				if (AFNKOOBPFPJ)
				{
					Debug.Log(item.ALLLIGGPLMK + "/" + item2.ALLLIGGPLMK + " has " + item2.CKDDAODLAOF.Count + " faces(s)");
				}
			}
		}
		return result;
	}

	public void GHNKMCGIMMP(GameObject[] EGKJKMBGLFO, Dictionary<string, Material> JNMPELOGLDM)
	{
		if (EGKJKMBGLFO.Length != GLAOOFIGOOK)
		{
			return;
		}
		for (int i = 0; i < EGKJKMBGLFO.Length; i++)
		{
			JGJKIJIDEFF jGJKIJIDEFF = HPALAEHEPEK[i];
			if (OLPNBGOBCMA)
			{
				jGJKIJIDEFF.MAOHIONHLED = new List<NNOLKJOJPEP>();
				foreach (EIGBOLHECCA item in jGJKIJIDEFF.ANNFEPGFKME)
				{
					foreach (NNOLKJOJPEP item2 in item.CKDDAODLAOF)
					{
						jGJKIJIDEFF.MAOHIONHLED.Add(item2);
					}
				}
			}
			if (jGJKIJIDEFF.ALLLIGGPLMK != "_spc_default" && EGKJKMBGLFO.Length != 1)
			{
				EGKJKMBGLFO[i].name = jGJKIJIDEFF.ALLLIGGPLMK;
			}
			if (jGJKIJIDEFF.ALLLIGGPLMK != "_spc_default" && EGKJKMBGLFO.Length == 1 && EGKJKMBGLFO[0].name == "_spc_rename_")
			{
				EGKJKMBGLFO[i].name = jGJKIJIDEFF.ALLLIGGPLMK;
			}
			Vector3[] array = new Vector3[jGJKIJIDEFF.MAOHIONHLED.Count];
			Vector2[] array2 = new Vector2[jGJKIJIDEFF.MAOHIONHLED.Count];
			Vector3[] array3 = new Vector3[jGJKIJIDEFF.MAOHIONHLED.Count];
			int num = 0;
			foreach (NNOLKJOJPEP item3 in jGJKIJIDEFF.MAOHIONHLED)
			{
				ref Vector3 reference = ref array[num];
				reference = KOGKFEMKGBB[item3.HLIDCIJJNLC];
				if (LJADJBECLND)
				{
					ref Vector2 reference2 = ref array2[num];
					reference2 = LIAPFPOHECF[item3.CNNDMIEDIJB];
				}
				if (PBNDBKDNNLI)
				{
					ref Vector3 reference3 = ref array3[num];
					reference3 = FCKMEAFJCJN[item3.KMKKCKFLHNJ];
				}
				num++;
			}
			Mesh mesh = (EGKJKMBGLFO[i].GetComponent(typeof(MeshFilter)) as MeshFilter).mesh;
			mesh.vertices = array;
			if (LJADJBECLND)
			{
				mesh.uv = array2;
			}
			if (PBNDBKDNNLI)
			{
				mesh.normals = array3;
			}
			bool flag = false;
			if (jGJKIJIDEFF.ANNFEPGFKME.Count == 1)
			{
				EIGBOLHECCA eIGBOLHECCA = jGJKIJIDEFF.ANNFEPGFKME[0];
				int[] array4 = new int[eIGBOLHECCA.CKDDAODLAOF.Count];
				for (int j = 0; j < array4.Length; j++)
				{
					array4[j] = j;
				}
				mesh.triangles = array4;
				Material material = JNMPELOGLDM[eIGBOLHECCA.NINIOECCDFM];
				EGKJKMBGLFO[i].GetComponent<Renderer>().material = material;
				Material material2 = material;
				EGKJKMBGLFO[i].GetComponent<Renderer>().material.name = eIGBOLHECCA.NINIOECCDFM;
				if (material2.shader.name.Contains("Bumped "))
				{
					flag = true;
				}
			}
			else
			{
				int count = jGJKIJIDEFF.ANNFEPGFKME.Count;
				Material[] array5 = new Material[count];
				mesh.subMeshCount = count;
				int num2 = 0;
				for (int k = 0; k < count; k++)
				{
					array5[k] = JNMPELOGLDM[jGJKIJIDEFF.ANNFEPGFKME[k].NINIOECCDFM];
					array5[k].name = jGJKIJIDEFF.ANNFEPGFKME[k].NINIOECCDFM;
					int[] array6 = new int[jGJKIJIDEFF.ANNFEPGFKME[k].CKDDAODLAOF.Count];
					int num3 = jGJKIJIDEFF.ANNFEPGFKME[k].CKDDAODLAOF.Count + num2;
					int num4 = 0;
					while (num2 < num3)
					{
						array6[num4] = num2;
						num2++;
						num4++;
					}
					mesh.SetTriangles(array6, k);
					if (array5[k].shader.name.Contains("Bumped "))
					{
						flag = true;
					}
				}
				EGKJKMBGLFO[i].GetComponent<Renderer>().materials = array5;
			}
			if (!PBNDBKDNNLI)
			{
				mesh.RecalculateNormals();
			}
			if (flag)
			{
				NAIBFFHIBKK(mesh);
			}
		}
	}

	public void NAIBFFHIBKK(Mesh FAHIHINKFMC)
	{
		Vector3[] array = new Vector3[FAHIHINKFMC.vertices.Length];
		Vector3[] array2 = new Vector3[FAHIHINKFMC.vertices.Length];
		Vector4[] array3 = new Vector4[FAHIHINKFMC.vertices.Length];
		for (int i = 0; i < FAHIHINKFMC.triangles.Length; i += 3)
		{
			long num = FAHIHINKFMC.triangles[i];
			long num2 = FAHIHINKFMC.triangles[i + 1];
			long num3 = FAHIHINKFMC.triangles[i + 2];
			Vector3 vector = FAHIHINKFMC.vertices[num];
			Vector3 vector2 = FAHIHINKFMC.vertices[num2];
			Vector3 vector3 = FAHIHINKFMC.vertices[num3];
			Vector2 vector4 = FAHIHINKFMC.uv[num];
			Vector2 vector5 = FAHIHINKFMC.uv[num2];
			Vector2 vector6 = FAHIHINKFMC.uv[num3];
			float num4 = vector2.x - vector.x;
			float num5 = vector3.x - vector.x;
			float num6 = vector2.y - vector.y;
			float num7 = vector3.y - vector.y;
			float num8 = vector2.z - vector.z;
			float num9 = vector3.z - vector.z;
			float num10 = vector5.x - vector4.x;
			float num11 = vector6.x - vector4.x;
			float num12 = vector5.y - vector4.y;
			float num13 = vector6.y - vector4.y;
			float num14 = 1f / (num10 * num13 - num11 * num12);
			Vector3 vector7 = new Vector3((num13 * num4 - num12 * num5) * num14, (num13 * num6 - num12 * num7) * num14, (num13 * num8 - num12 * num9) * num14);
			Vector3 vector8 = new Vector3((num10 * num5 - num11 * num4) * num14, (num10 * num7 - num11 * num6) * num14, (num10 * num9 - num11 * num8) * num14);
			array2[num] += vector7;
			array2[num2] += vector7;
			array2[num3] += vector7;
			array[num] += vector8;
			array[num2] += vector8;
			array[num3] += vector8;
		}
		for (int j = 0; j < FAHIHINKFMC.vertices.Length; j++)
		{
			Vector3 normal = FAHIHINKFMC.normals[j];
			Vector3 tangent = array2[j];
			Vector3.OrthoNormalize(ref normal, ref tangent);
			array3[j].x = tangent.x;
			array3[j].y = tangent.y;
			array3[j].z = tangent.z;
			array3[j].w = ((!(Vector3.Dot(Vector3.Cross(normal, tangent), array[j]) < 0f)) ? 1f : (-1f));
		}
		FAHIHINKFMC.tangents = array3;
	}
}
