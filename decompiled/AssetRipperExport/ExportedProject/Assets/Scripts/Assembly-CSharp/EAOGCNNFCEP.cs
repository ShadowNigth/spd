using System.Collections.Generic;
using UnityEngine;

public class EAOGCNNFCEP
{
	private Vector3[] EILKCJJDOEE;

	private Vector3[] DGDHDOKMFBP;

	private List<int> JKIFGGPCIGL = new List<int>();

	private int[] JNGOHBDEIIP;

	private int[] PLPAGOMEGEN;

	public int[] FGJBKAFIGNI(Vector3[] EDEEPJMIFBD)
	{
		EILKCJJDOEE = EDEEPJMIFBD;
		INDKDGHEFMG();
		return JNGOHBDEIIP;
	}

	private bool INDKDGHEFMG()
	{
		bool result = false;
		if (EILKCJJDOEE != null && EILKCJJDOEE.Length > 2)
		{
			result = true;
			Vector3 vector = EILKCJJDOEE[0];
			Vector3 vector2 = EILKCJJDOEE[0];
			for (int i = 0; i < EILKCJJDOEE.Length; i++)
			{
				Vector3 vector3 = EILKCJJDOEE[i];
				if (vector3.x < vector.x)
				{
					vector.x = vector3.x;
				}
				if (vector3.y < vector.y)
				{
					vector.y = vector3.y;
				}
				if (vector3.z < vector.z)
				{
					vector.z = vector3.z;
				}
				if (vector3.x > vector2.x)
				{
					vector2.x = vector3.x;
				}
				if (vector3.y > vector2.y)
				{
					vector2.y = vector3.y;
				}
				if (vector3.z > vector2.z)
				{
					vector2.z = vector3.z;
				}
			}
			float num = vector2.x - vector.x;
			float num2 = vector2.y - vector.y;
			float num3 = vector2.z - vector.z;
			int index;
			int index2;
			int index3;
			if (num > num2 && num > num3)
			{
				index = 0;
				if (num2 > num3)
				{
					index2 = 1;
					index3 = 2;
				}
				else
				{
					index2 = 2;
					index3 = 1;
				}
			}
			else if (num2 > num && num2 > num3)
			{
				index = 1;
				if (num > num3)
				{
					index2 = 0;
					index3 = 2;
				}
				else
				{
					index2 = 2;
					index3 = 0;
				}
			}
			else
			{
				index = 2;
				if (num > num2)
				{
					index2 = 0;
					index3 = 1;
				}
				else
				{
					index2 = 1;
					index3 = 0;
				}
			}
			DGDHDOKMFBP = new Vector3[EILKCJJDOEE.Length];
			Vector3 vector4 = default(Vector3);
			for (int j = 0; j < EILKCJJDOEE.Length; j++)
			{
				vector4 = EILKCJJDOEE[j];
				DGDHDOKMFBP[j] = new Vector3(vector4[index], vector4[index2], vector4[index3]);
			}
			KIHJMODPIGP();
			if (JKIFGGPCIGL.Count > 2)
			{
				JNGOHBDEIIP = new int[JKIFGGPCIGL.Count];
				for (int k = 0; k < JKIFGGPCIGL.Count; k++)
				{
					JNGOHBDEIIP[k] = JKIFGGPCIGL[k];
				}
			}
			else
			{
				result = false;
				JNGOHBDEIIP = new int[1];
				JNGOHBDEIIP[0] = -1;
			}
		}
		return result;
	}

	private void KIHJMODPIGP()
	{
		int num = DGDHDOKMFBP.Length;
		PLPAGOMEGEN = new int[num];
		bool flag = false;
		if (0f < ICIDJNOAEPB())
		{
			for (int i = 0; i < num; i++)
			{
				PLPAGOMEGEN[i] = i;
			}
		}
		else
		{
			flag = true;
			for (int j = 0; j < num; j++)
			{
				PLPAGOMEGEN[j] = num - 1 - j;
			}
		}
		int num2 = num;
		int num3 = 2 * num2;
		int num4 = 0;
		int num5 = num2 - 1;
		while (num2 > 2 && 0 < num3--)
		{
			int num6 = num5;
			if (num2 <= num6)
			{
				num6 = 0;
			}
			num5 = num6 + 1;
			if (num2 <= num5)
			{
				num5 = 0;
			}
			int num7 = num5 + 1;
			if (num2 <= num7)
			{
				num7 = 0;
			}
			if (KEEBNKIIGJN(num6, num5, num7, num2))
			{
				int item = PLPAGOMEGEN[num6];
				int item2 = PLPAGOMEGEN[num5];
				int item3 = PLPAGOMEGEN[num7];
				if (flag)
				{
					JKIFGGPCIGL.Add(item);
					JKIFGGPCIGL.Add(item2);
					JKIFGGPCIGL.Add(item3);
				}
				else
				{
					JKIFGGPCIGL.Add(item3);
					JKIFGGPCIGL.Add(item2);
					JKIFGGPCIGL.Add(item);
				}
				num4++;
				int num8 = num5;
				for (int k = num5 + 1; k < num2; k++)
				{
					PLPAGOMEGEN[num8] = PLPAGOMEGEN[k];
					num8++;
				}
				num2--;
				num3 = 2 * num2;
			}
		}
	}

	private float ICIDJNOAEPB()
	{
		int num = DGDHDOKMFBP.Length;
		float num2 = 0f;
		int num3 = num - 1;
		int num4 = 0;
		while (num4 < num)
		{
			Vector3 vector = DGDHDOKMFBP[num3];
			Vector3 vector2 = DGDHDOKMFBP[num4];
			num2 += vector.x * vector2.y - vector2.x * vector.y;
			num3 = num4++;
		}
		return num2 * 0.5f;
	}

	private bool KEEBNKIIGJN(int CMDFJBOALAO, int PDAKFGKELOC, int GDIFBJBOCJM, int DOIIKMIPLNH)
	{
		Vector3 pLLNCPNCAHN = DGDHDOKMFBP[PLPAGOMEGEN[CMDFJBOALAO]];
		Vector3 eDGDMFJAFEM = DGDHDOKMFBP[PLPAGOMEGEN[PDAKFGKELOC]];
		Vector3 cDKCBJBMPOL = DGDHDOKMFBP[PLPAGOMEGEN[GDIFBJBOCJM]];
		if (Mathf.Epsilon > (eDGDMFJAFEM.x - pLLNCPNCAHN.x) * (cDKCBJBMPOL.y - pLLNCPNCAHN.y) - (eDGDMFJAFEM.y - pLLNCPNCAHN.y) * (cDKCBJBMPOL.x - pLLNCPNCAHN.x))
		{
			return false;
		}
		for (int i = 0; i < DOIIKMIPLNH; i++)
		{
			if (i != CMDFJBOALAO && i != PDAKFGKELOC && i != GDIFBJBOCJM)
			{
				Vector3 bDNOFMFIDPM = DGDHDOKMFBP[PLPAGOMEGEN[i]];
				if (CJMOKNGDFCA(pLLNCPNCAHN, eDGDMFJAFEM, cDKCBJBMPOL, bDNOFMFIDPM))
				{
					return false;
				}
			}
		}
		return true;
	}

	private bool CJMOKNGDFCA(Vector3 PLLNCPNCAHN, Vector3 EDGDMFJAFEM, Vector3 CDKCBJBMPOL, Vector3 BDNOFMFIDPM)
	{
		float num = CDKCBJBMPOL.x - EDGDMFJAFEM.x;
		float num2 = CDKCBJBMPOL.y - EDGDMFJAFEM.y;
		float num3 = PLLNCPNCAHN.x - CDKCBJBMPOL.x;
		float num4 = PLLNCPNCAHN.y - CDKCBJBMPOL.y;
		float num5 = EDGDMFJAFEM.x - PLLNCPNCAHN.x;
		float num6 = EDGDMFJAFEM.y - PLLNCPNCAHN.y;
		float num7 = BDNOFMFIDPM.x - PLLNCPNCAHN.x;
		float num8 = BDNOFMFIDPM.y - PLLNCPNCAHN.y;
		float num9 = BDNOFMFIDPM.x - EDGDMFJAFEM.x;
		float num10 = BDNOFMFIDPM.y - EDGDMFJAFEM.y;
		float num11 = BDNOFMFIDPM.x - CDKCBJBMPOL.x;
		float num12 = BDNOFMFIDPM.y - CDKCBJBMPOL.y;
		float num13 = num * num10 - num2 * num9;
		float num14 = num5 * num8 - num6 * num7;
		float num15 = num3 * num12 - num4 * num11;
		return num13 >= 0f && num15 >= 0f && num14 >= 0f;
	}
}
