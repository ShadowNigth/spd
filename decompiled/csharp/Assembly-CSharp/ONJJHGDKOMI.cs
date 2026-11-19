using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ONJJHGDKOMI
{
	private class GKGJKEJOPPA
	{
		public NBEMBAPBCPL[] OGKFNOEIENF;

		public Vector3 EFMOCJNMMCE;

		public bool HPCEFDLBHEF;

		public GKGJKEJOPPA(NBEMBAPBCPL CLNGODPJGBG, NBEMBAPBCPL CHKGNHIEKJO, NBEMBAPBCPL ILAGBCLIHOH)
		{
			OGKFNOEIENF = new NBEMBAPBCPL[3];
			OGKFNOEIENF[0] = CLNGODPJGBG;
			OGKFNOEIENF[1] = CHKGNHIEKJO;
			OGKFNOEIENF[2] = ILAGBCLIHOH;
			NPOLDGOLCIM();
			for (int i = 0; i < 3; i++)
			{
				OGKFNOEIENF[i].FPDDPIMAPKI.Add(this);
				for (int j = 0; j < 3; j++)
				{
					if (i == j)
					{
						continue;
					}
					bool flag = false;
					for (int k = 0; k < OGKFNOEIENF[i].ACBKGCDHMLC.Count; k++)
					{
						if (OGKFNOEIENF[i].ACBKGCDHMLC[k].JFLBOOBFAEF == OGKFNOEIENF[j].JFLBOOBFAEF)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						OGKFNOEIENF[i].ACBKGCDHMLC.Add(OGKFNOEIENF[j]);
					}
				}
			}
		}

		public void AKLLNEEOCHA()
		{
			for (int i = 0; i < 3; i++)
			{
				if (OGKFNOEIENF[i] != null)
				{
					OGKFNOEIENF[i].FPDDPIMAPKI.Remove(this);
				}
			}
			for (int i = 0; i < 3; i++)
			{
				int num = (i + 1) % 3;
				if (OGKFNOEIENF[i] != null && OGKFNOEIENF[num] != null)
				{
					OGKFNOEIENF[i].GFJKFIBIIDF(OGKFNOEIENF[num]);
					OGKFNOEIENF[num].GFJKFIBIIDF(OGKFNOEIENF[i]);
				}
			}
		}

		public bool OFFLBCHMDIL(NBEMBAPBCPL PDAKFGKELOC)
		{
			return PDAKFGKELOC == OGKFNOEIENF[0] || PDAKFGKELOC == OGKFNOEIENF[1] || PDAKFGKELOC == OGKFNOEIENF[2];
		}

		public void NPOLDGOLCIM()
		{
			Vector3 gIDEOJGAFJH = OGKFNOEIENF[1].GIDEOJGAFJH;
			EFMOCJNMMCE = Vector3.Cross(gIDEOJGAFJH - OGKFNOEIENF[0].GIDEOJGAFJH, OGKFNOEIENF[2].GIDEOJGAFJH - gIDEOJGAFJH);
			if (EFMOCJNMMCE.magnitude != 0f)
			{
				EFMOCJNMMCE.Normalize();
			}
		}

		public void NHGNHGOPIAC(NBEMBAPBCPL BHCOHKPNFII, NBEMBAPBCPL ENLCEMIFKLF)
		{
			if (BHCOHKPNFII == OGKFNOEIENF[0])
			{
				OGKFNOEIENF[0] = ENLCEMIFKLF;
			}
			else if (BHCOHKPNFII == OGKFNOEIENF[1])
			{
				OGKFNOEIENF[1] = ENLCEMIFKLF;
			}
			else
			{
				OGKFNOEIENF[2] = ENLCEMIFKLF;
			}
			BHCOHKPNFII.FPDDPIMAPKI.Remove(this);
			ENLCEMIFKLF.FPDDPIMAPKI.Add(this);
			for (int i = 0; i < 3; i++)
			{
				BHCOHKPNFII.GFJKFIBIIDF(OGKFNOEIENF[i]);
				OGKFNOEIENF[i].GFJKFIBIIDF(BHCOHKPNFII);
			}
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (i != j && !OGKFNOEIENF[i].ACBKGCDHMLC.Contains(OGKFNOEIENF[j]))
					{
						OGKFNOEIENF[i].ACBKGCDHMLC.Add(OGKFNOEIENF[j]);
					}
				}
			}
			NPOLDGOLCIM();
		}
	}

	private class NBEMBAPBCPL
	{
		public Vector3 GIDEOJGAFJH;

		public List<GKGJKEJOPPA> FPDDPIMAPKI;

		public List<NBEMBAPBCPL> ACBKGCDHMLC;

		public int JFLBOOBFAEF;

		public float BBCLFKDCOAJ;

		public NBEMBAPBCPL AABOBMOPBFF;

		private bool? LMGHOIJBKAD;

		public bool CJPEPFBMMEK
		{
			get
			{
				if (!LMGHOIJBKAD.HasValue)
				{
					LMGHOIJBKAD = BPPKPNJDEAK(this);
				}
				return LMGHOIJBKAD.Value;
			}
		}

		public NBEMBAPBCPL(Vector3 KOCKIFEOLJK, int AINBMJEKGPD)
		{
			GIDEOJGAFJH = KOCKIFEOLJK;
			JFLBOOBFAEF = AINBMJEKGPD;
			ACBKGCDHMLC = new List<NBEMBAPBCPL>();
			FPDDPIMAPKI = new List<GKGJKEJOPPA>();
		}

		public void NLMJCDNBBMP()
		{
			while (ACBKGCDHMLC.Count > 0)
			{
				ACBKGCDHMLC[0].ACBKGCDHMLC.Remove(this);
				ACBKGCDHMLC.Remove(ACBKGCDHMLC[0]);
			}
		}

		private static bool BPPKPNJDEAK(NBEMBAPBCPL PDAKFGKELOC)
		{
			for (int i = 0; i < PDAKFGKELOC.ACBKGCDHMLC.Count; i++)
			{
				int num = 0;
				for (int j = 0; j < PDAKFGKELOC.FPDDPIMAPKI.Count; j++)
				{
					if (PDAKFGKELOC.FPDDPIMAPKI[j].OFFLBCHMDIL(PDAKFGKELOC.ACBKGCDHMLC[i]))
					{
						num++;
					}
				}
				if (num == 1)
				{
					return true;
				}
			}
			return false;
		}

		public void GFJKFIBIIDF(NBEMBAPBCPL PDAKFGKELOC)
		{
			if (!ACBKGCDHMLC.Contains(PDAKFGKELOC))
			{
				return;
			}
			for (int i = 0; i < FPDDPIMAPKI.Count; i++)
			{
				if (FPDDPIMAPKI[i].OFFLBCHMDIL(PDAKFGKELOC))
				{
					return;
				}
			}
			ACBKGCDHMLC.Remove(PDAKFGKELOC);
		}
	}

	public int FAAHIHCIFEM;

	public bool LJLJPFKCHAG;

	public bool CDCPNKLKODO;

	public int FJCAJLGPADG;

	private Vector3[] GLNBMGCDDMI;

	private Vector3[] ADEMMAIDCJB;

	private int[] AOJAKNBLDBJ;

	private Vector3[] EDEDAIFEDPH;

	private Vector3[] LKDKPAPAGNB;

	private int[] JIHGOKBMKOO;

	private static List<GKGJKEJOPPA> LGGOBEDBLDO = new List<GKGJKEJOPPA>();

	private static List<NBEMBAPBCPL> KOGKFEMKGBB = new List<NBEMBAPBCPL>();

	private int[] DACLIJPONJK;

	private int[] DCPBGAJDEHH;

	public Vector3[] NOLCOPNOPEF;

	public Vector3[] MPNEKMFEGLD;

	public int[] EKHEPCAKMGE;

	[CompilerGenerated]
	private static Predicate<GKGJKEJOPPA> PLPLKIHGGOE;

	private static bool HPCEFDLBHEF(GKGJKEJOPPA GDKFLGBMPBB)
	{
		if (GDKFLGBMPBB.HPCEFDLBHEF)
		{
			return true;
		}
		return false;
	}

	private float GMJEGJHNDAK(NBEMBAPBCPL CMDFJBOALAO, NBEMBAPBCPL PDAKFGKELOC)
	{
		float magnitude = (PDAKFGKELOC.GIDEOJGAFJH - CMDFJBOALAO.GIDEOJGAFJH).magnitude;
		float num = 0f;
		List<GKGJKEJOPPA> list = new List<GKGJKEJOPPA>();
		for (int i = 0; i < CMDFJBOALAO.FPDDPIMAPKI.Count; i++)
		{
			if (CMDFJBOALAO.FPDDPIMAPKI[i].OFFLBCHMDIL(PDAKFGKELOC))
			{
				list.Add(CMDFJBOALAO.FPDDPIMAPKI[i]);
			}
		}
		for (int i = 0; i < CMDFJBOALAO.FPDDPIMAPKI.Count; i++)
		{
			float num2 = 1f;
			for (int j = 0; j < list.Count; j++)
			{
				float num3 = Vector3.Dot(CMDFJBOALAO.FPDDPIMAPKI[i].EFMOCJNMMCE, list[j].EFMOCJNMMCE);
				num2 = Mathf.Min(num2, (1f - num3) / 2f);
			}
			num = Mathf.Max(num, num2);
		}
		if (CMDFJBOALAO.CJPEPFBMMEK && list.Count > 1)
		{
			num = 1f;
		}
		return magnitude * num;
	}

	private void JNBKDMMEOMO(NBEMBAPBCPL PDAKFGKELOC)
	{
		if (PDAKFGKELOC.ACBKGCDHMLC.Count == 0)
		{
			PDAKFGKELOC.AABOBMOPBFF = null;
			PDAKFGKELOC.BBCLFKDCOAJ = -0.01f;
			return;
		}
		PDAKFGKELOC.BBCLFKDCOAJ = 1000000f;
		PDAKFGKELOC.AABOBMOPBFF = null;
		for (int i = 0; i < PDAKFGKELOC.ACBKGCDHMLC.Count; i++)
		{
			float num = GMJEGJHNDAK(PDAKFGKELOC, PDAKFGKELOC.ACBKGCDHMLC[i]);
			if (num < PDAKFGKELOC.BBCLFKDCOAJ)
			{
				PDAKFGKELOC.AABOBMOPBFF = PDAKFGKELOC.ACBKGCDHMLC[i];
				PDAKFGKELOC.BBCLFKDCOAJ = num;
			}
		}
	}

	private void EOMNBBNFCFO()
	{
		for (int i = 0; i < KOGKFEMKGBB.Count; i++)
		{
			JNBKDMMEOMO(KOGKFEMKGBB[i]);
		}
	}

	private void OFHJGOPCBDP(NBEMBAPBCPL CMDFJBOALAO, NBEMBAPBCPL PDAKFGKELOC)
	{
		if (PDAKFGKELOC == null)
		{
			CMDFJBOALAO.NLMJCDNBBMP();
			KOGKFEMKGBB.Remove(CMDFJBOALAO);
			return;
		}
		List<NBEMBAPBCPL> list = new List<NBEMBAPBCPL>();
		for (int i = 0; i < CMDFJBOALAO.ACBKGCDHMLC.Count; i++)
		{
			list.Add(CMDFJBOALAO.ACBKGCDHMLC[i]);
		}
		for (int i = CMDFJBOALAO.FPDDPIMAPKI.Count - 1; i >= 0; i--)
		{
			if (CMDFJBOALAO.FPDDPIMAPKI[i].OFFLBCHMDIL(PDAKFGKELOC))
			{
				CMDFJBOALAO.FPDDPIMAPKI[i].HPCEFDLBHEF = true;
			}
		}
		foreach (GKGJKEJOPPA item in CMDFJBOALAO.FPDDPIMAPKI.FindAll(HPCEFDLBHEF))
		{
			item.AKLLNEEOCHA();
		}
		for (int i = CMDFJBOALAO.FPDDPIMAPKI.Count - 1; i >= 0; i--)
		{
			CMDFJBOALAO.FPDDPIMAPKI[i].NHGNHGOPIAC(CMDFJBOALAO, PDAKFGKELOC);
		}
		CMDFJBOALAO.NLMJCDNBBMP();
		KOGKFEMKGBB.Remove(CMDFJBOALAO);
		for (int i = 0; i < list.Count; i++)
		{
			JNBKDMMEOMO(list[i]);
		}
	}

	private NBEMBAPBCPL PGPHOKEKLDL()
	{
		NBEMBAPBCPL nBEMBAPBCPL = KOGKFEMKGBB[0];
		for (int i = 0; i < KOGKFEMKGBB.Count; i++)
		{
			if (KOGKFEMKGBB[i].BBCLFKDCOAJ < nBEMBAPBCPL.BBCLFKDCOAJ)
			{
				nBEMBAPBCPL = KOGKFEMKGBB[i];
			}
		}
		return nBEMBAPBCPL;
	}

	public void IHJKKKFFKMD(Mesh FAHIHINKFMC)
	{
		LJLJPFKCHAG = false;
		GLNBMGCDDMI = FAHIHINKFMC.vertices;
		ADEMMAIDCJB = FAHIHINKFMC.normals;
		AOJAKNBLDBJ = FAHIHINKFMC.triangles;
		if (0 == 0)
		{
			int num = -1;
			int[] triangles = FAHIHINKFMC.triangles;
			List<Vector3> list = new List<Vector3>();
			List<Vector3> list2 = new List<Vector3>();
			for (int i = 0; i < triangles.Length; i++)
			{
				int num2 = triangles[i];
				Vector3 vector = GLNBMGCDDMI[num2];
				Vector3 item = ADEMMAIDCJB[num2];
				int count = list.Count;
				num = -1;
				for (int j = 0; j < count; j++)
				{
					if (list[j] == vector)
					{
						num = j;
						break;
					}
				}
				if (num != -1)
				{
					triangles[i] = num;
					continue;
				}
				triangles[i] = count;
				list.Add(vector);
				list2.Add(item);
			}
			JIHGOKBMKOO = triangles;
			EDEDAIFEDPH = list.ToArray();
			LKDKPAPAGNB = list2.ToArray();
		}
		else
		{
			JIHGOKBMKOO = AOJAKNBLDBJ;
			EDEDAIFEDPH = GLNBMGCDDMI;
			LKDKPAPAGNB = ADEMMAIDCJB;
		}
		int num3 = EDEDAIFEDPH.Length;
		int num4 = JIHGOKBMKOO.Length;
		DACLIJPONJK = new int[EDEDAIFEDPH.Length];
		DCPBGAJDEHH = new int[EDEDAIFEDPH.Length];
		KOGKFEMKGBB = null;
		KOGKFEMKGBB = new List<NBEMBAPBCPL>();
		for (int i = 0; i < num3; i++)
		{
			NBEMBAPBCPL item2 = new NBEMBAPBCPL(EDEDAIFEDPH[i], i);
			KOGKFEMKGBB.Add(item2);
		}
		LGGOBEDBLDO = null;
		LGGOBEDBLDO = new List<GKGJKEJOPPA>();
		for (int i = 0; i < num4; i += 3)
		{
			GKGJKEJOPPA item3 = new GKGJKEJOPPA(KOGKFEMKGBB[JIHGOKBMKOO[i]], KOGKFEMKGBB[JIHGOKBMKOO[i + 1]], KOGKFEMKGBB[JIHGOKBMKOO[i + 2]]);
			LGGOBEDBLDO.Add(item3);
		}
		EOMNBBNFCFO();
		while (KOGKFEMKGBB.Count > 0)
		{
			NBEMBAPBCPL nBEMBAPBCPL = PGPHOKEKLDL();
			DCPBGAJDEHH[nBEMBAPBCPL.JFLBOOBFAEF] = KOGKFEMKGBB.Count - 1;
			DACLIJPONJK[KOGKFEMKGBB.Count - 1] = ((nBEMBAPBCPL.AABOBMOPBFF == null) ? (-1) : nBEMBAPBCPL.AABOBMOPBFF.JFLBOOBFAEF);
			OFHJGOPCBDP(nBEMBAPBCPL, nBEMBAPBCPL.AABOBMOPBFF);
		}
		for (int i = 0; i < DACLIJPONJK.Length; i++)
		{
			DACLIJPONJK[i] = ((DACLIJPONJK[i] != -1) ? DCPBGAJDEHH[DACLIJPONJK[i]] : 0);
		}
		GPOHIEKKJPE();
		LJLJPFKCHAG = true;
		FJCAJLGPADG = EDEDAIFEDPH.Length;
	}

	private int PCDPKPCGOLF(int AEMBPMJMOAB, int HGFHDJOAHEJ)
	{
		if (HGFHDJOAHEJ <= 0)
		{
			return 0;
		}
		while (AEMBPMJMOAB >= HGFHDJOAHEJ)
		{
			AEMBPMJMOAB = DACLIJPONJK[AEMBPMJMOAB];
		}
		return AEMBPMJMOAB;
	}

	private void GPOHIEKKJPE()
	{
		List<Vector3> list = new List<Vector3>();
		List<Vector3> list2 = new List<Vector3>();
		if (DCPBGAJDEHH.Length == EDEDAIFEDPH.Length)
		{
			for (int i = 0; i < EDEDAIFEDPH.Length; i++)
			{
				list.Add(EDEDAIFEDPH[i]);
				list2.Add(LKDKPAPAGNB[i]);
			}
			for (int i = 0; i < EDEDAIFEDPH.Length; i++)
			{
				ref Vector3 reference = ref EDEDAIFEDPH[DCPBGAJDEHH[i]];
				reference = list[i];
				ref Vector3 reference2 = ref LKDKPAPAGNB[DCPBGAJDEHH[i]];
				reference2 = list2[i];
			}
			for (int i = 0; i < AOJAKNBLDBJ.Length; i += 3)
			{
				JIHGOKBMKOO[i] = DCPBGAJDEHH[JIHGOKBMKOO[i]];
				JIHGOKBMKOO[i + 1] = DCPBGAJDEHH[JIHGOKBMKOO[i + 1]];
				JIHGOKBMKOO[i + 2] = DCPBGAJDEHH[JIHGOKBMKOO[i + 2]];
			}
		}
	}

	public void PBIJGIGANCB(float BGICDOEPGHL)
	{
		PBIJGIGANCB(Mathf.RoundToInt((float)EDEDAIFEDPH.Length * (BGICDOEPGHL * 0.01f)));
	}

	public void PBIJGIGANCB(int NLPFEOOCNGH)
	{
		CDCPNKLKODO = true;
		FAAHIHCIFEM = NLPFEOOCNGH;
		if (DACLIJPONJK.Length > 0)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < JIHGOKBMKOO.Length; i += 3)
			{
				int num = PCDPKPCGOLF(JIHGOKBMKOO[i], FAAHIHCIFEM);
				int num2 = PCDPKPCGOLF(JIHGOKBMKOO[i + 1], FAAHIHCIFEM);
				int num3 = PCDPKPCGOLF(JIHGOKBMKOO[i + 2], FAAHIHCIFEM);
				if (num != num2 && num2 != num3 && num3 != num)
				{
					list.Add(num);
					list.Add(num2);
					list.Add(num3);
				}
			}
			EKHEPCAKMGE = list.ToArray();
			NOLCOPNOPEF = null;
			NOLCOPNOPEF = new Vector3[FAAHIHCIFEM];
			MPNEKMFEGLD = null;
			MPNEKMFEGLD = new Vector3[FAAHIHCIFEM];
			for (int j = 0; j < EKHEPCAKMGE.Length; j++)
			{
				ref Vector3 reference = ref MPNEKMFEGLD[EKHEPCAKMGE[j]];
				reference = LKDKPAPAGNB[EKHEPCAKMGE[j]];
				ref Vector3 reference2 = ref NOLCOPNOPEF[EKHEPCAKMGE[j]];
				reference2 = EDEDAIFEDPH[EKHEPCAKMGE[j]];
			}
		}
		CDCPNKLKODO = false;
	}
}
