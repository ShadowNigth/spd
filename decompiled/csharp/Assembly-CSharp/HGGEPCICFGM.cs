using System;
using System.Collections.Generic;

public class HGGEPCICFGM
{
	private string JCJBDEEHJMJ = string.Empty;

	private bool IMEIHNLOCKB;

	private char[] AAFOPLKEPLB;

	private int FBHNGEJHMOJ;

	private int DANEJPGCIAL;

	private List<char> HNMCODGODPN;

	private object GHLEKLDELIB;

	private int EGLKPKOAALE = int.MinValue;

	public HGGEPCICFGM(int LNPFKLOALHN = 32)
	{
		AAFOPLKEPLB = new char[DANEJPGCIAL = LNPFKLOALHN];
	}

	public bool GHCMBJDDFON()
	{
		return (!IMEIHNLOCKB) ? (FBHNGEJHMOJ == 0) : (JCJBDEEHJMJ == null);
	}

	public override string ToString()
	{
		if (!IMEIHNLOCKB)
		{
			JCJBDEEHJMJ = new string(AAFOPLKEPLB, 0, FBHNGEJHMOJ);
			IMEIHNLOCKB = true;
		}
		return JCJBDEEHJMJ;
	}

	public bool BKFDLFJDENO(int BODGOJKHJAG)
	{
		bool flag = BODGOJKHJAG != EGLKPKOAALE;
		if (flag)
		{
			EGLKPKOAALE = BODGOJKHJAG;
		}
		return flag;
	}

	public bool BKFDLFJDENO(object BODGOJKHJAG)
	{
		bool flag = !BODGOJKHJAG.Equals(GHLEKLDELIB);
		if (flag)
		{
			GHLEKLDELIB = BODGOJKHJAG;
		}
		return flag;
	}

	public void PJCKFCICIJF(string DGPOLNOFCMB)
	{
		GFJGDEKLFNB();
		EJJKCHAENEP(DGPOLNOFCMB);
		JCJBDEEHJMJ = DGPOLNOFCMB;
		IMEIHNLOCKB = true;
	}

	public void PJCKFCICIJF(object DGPOLNOFCMB)
	{
		PJCKFCICIJF(DGPOLNOFCMB.ToString());
	}

	public void PJCKFCICIJF<T1, T2>(T1 JFJAAIJCGGC, T2 GNAHJPMMAOB)
	{
		GFJGDEKLFNB();
		EJJKCHAENEP(JFJAAIJCGGC);
		EJJKCHAENEP(GNAHJPMMAOB);
	}

	public void PJCKFCICIJF<T1, T2, T3>(T1 JFJAAIJCGGC, T2 GNAHJPMMAOB, T3 JHDGOFELCFN)
	{
		GFJGDEKLFNB();
		EJJKCHAENEP(JFJAAIJCGGC);
		EJJKCHAENEP(GNAHJPMMAOB);
		EJJKCHAENEP(JHDGOFELCFN);
	}

	public void PJCKFCICIJF<T1, T2, T3, T4>(T1 JFJAAIJCGGC, T2 GNAHJPMMAOB, T3 JHDGOFELCFN, T4 KFJDLCEPENN)
	{
		GFJGDEKLFNB();
		EJJKCHAENEP(JFJAAIJCGGC);
		EJJKCHAENEP(GNAHJPMMAOB);
		EJJKCHAENEP(JHDGOFELCFN);
		EJJKCHAENEP(KFJDLCEPENN);
	}

	public void PJCKFCICIJF(params object[] DGPOLNOFCMB)
	{
		GFJGDEKLFNB();
		for (int i = 0; i < DGPOLNOFCMB.Length; i++)
		{
			EJJKCHAENEP(DGPOLNOFCMB[i]);
		}
	}

	public HGGEPCICFGM GFJGDEKLFNB()
	{
		FBHNGEJHMOJ = 0;
		IMEIHNLOCKB = false;
		return this;
	}

	public HGGEPCICFGM EJJKCHAENEP(string EHAPKEKPMOE)
	{
		FGJNDKLCPDG(EHAPKEKPMOE.Length);
		int length = EHAPKEKPMOE.Length;
		for (int i = 0; i < length; i++)
		{
			AAFOPLKEPLB[FBHNGEJHMOJ + i] = EHAPKEKPMOE[i];
		}
		FBHNGEJHMOJ += length;
		IMEIHNLOCKB = false;
		return this;
	}

	public HGGEPCICFGM EJJKCHAENEP(object EHAPKEKPMOE)
	{
		EJJKCHAENEP(EHAPKEKPMOE.ToString());
		return this;
	}

	public HGGEPCICFGM EJJKCHAENEP(int EHAPKEKPMOE)
	{
		FGJNDKLCPDG(16);
		if (EHAPKEKPMOE < 0)
		{
			EHAPKEKPMOE = -EHAPKEKPMOE;
			AAFOPLKEPLB[FBHNGEJHMOJ++] = '-';
		}
		int num = 0;
		do
		{
			AAFOPLKEPLB[FBHNGEJHMOJ++] = (char)(48 + EHAPKEKPMOE % 10);
			EHAPKEKPMOE /= 10;
			num++;
		}
		while (EHAPKEKPMOE != 0);
		for (int num2 = num / 2 - 1; num2 >= 0; num2--)
		{
			char c = AAFOPLKEPLB[FBHNGEJHMOJ - num2 - 1];
			AAFOPLKEPLB[FBHNGEJHMOJ - num2 - 1] = AAFOPLKEPLB[FBHNGEJHMOJ - num + num2];
			AAFOPLKEPLB[FBHNGEJHMOJ - num + num2] = c;
		}
		IMEIHNLOCKB = false;
		return this;
	}

	public HGGEPCICFGM EJJKCHAENEP(float FMOJBBNPOCJ)
	{
		double num = FMOJBBNPOCJ;
		IMEIHNLOCKB = false;
		FGJNDKLCPDG(32);
		if (num == 0.0)
		{
			AAFOPLKEPLB[FBHNGEJHMOJ++] = '0';
			return this;
		}
		if (num < 0.0)
		{
			num = 0.0 - num;
			AAFOPLKEPLB[FBHNGEJHMOJ++] = '-';
		}
		int num2 = 0;
		while (num < 1000000.0)
		{
			num *= 10.0;
			num2++;
		}
		long num3 = (long)Math.Round(num);
		int num4 = 0;
		bool flag = true;
		while (num3 != 0 || num2 >= 0)
		{
			if (num3 % 10 != 0 || num2 <= 0)
			{
				flag = false;
			}
			if (!flag)
			{
				AAFOPLKEPLB[FBHNGEJHMOJ + num4++] = (char)(48 + num3 % 10);
			}
			if (--num2 == 0 && !flag)
			{
				AAFOPLKEPLB[FBHNGEJHMOJ + num4++] = '.';
			}
			num3 /= 10;
		}
		FBHNGEJHMOJ += num4;
		for (int num5 = num4 / 2 - 1; num5 >= 0; num5--)
		{
			char c = AAFOPLKEPLB[FBHNGEJHMOJ - num5 - 1];
			AAFOPLKEPLB[FBHNGEJHMOJ - num5 - 1] = AAFOPLKEPLB[FBHNGEJHMOJ - num4 + num5];
			AAFOPLKEPLB[FBHNGEJHMOJ - num4 + num5] = c;
		}
		return this;
	}

	public HGGEPCICFGM LPIJBPFJLCK(string MLKOGGCOIGA, string AKACIJLLAOL)
	{
		if (FBHNGEJHMOJ == 0)
		{
			return this;
		}
		if (HNMCODGODPN == null)
		{
			HNMCODGODPN = new List<char>();
		}
		for (int i = 0; i < FBHNGEJHMOJ; i++)
		{
			bool flag = false;
			if (AAFOPLKEPLB[i] == MLKOGGCOIGA[0])
			{
				int j;
				for (j = 1; j < MLKOGGCOIGA.Length && AAFOPLKEPLB[i + j] == MLKOGGCOIGA[j]; j++)
				{
				}
				flag = j >= MLKOGGCOIGA.Length;
			}
			if (flag)
			{
				i += MLKOGGCOIGA.Length - 1;
				if (AKACIJLLAOL != null)
				{
					for (int k = 0; k < AKACIJLLAOL.Length; k++)
					{
						HNMCODGODPN.Add(AKACIJLLAOL[k]);
					}
				}
			}
			else
			{
				HNMCODGODPN.Add(AAFOPLKEPLB[i]);
			}
		}
		FGJNDKLCPDG(HNMCODGODPN.Count - FBHNGEJHMOJ);
		for (int l = 0; l < HNMCODGODPN.Count; l++)
		{
			AAFOPLKEPLB[l] = HNMCODGODPN[l];
		}
		FBHNGEJHMOJ = HNMCODGODPN.Count;
		HNMCODGODPN.Clear();
		IMEIHNLOCKB = false;
		return this;
	}

	private void FGJNDKLCPDG(int ANFNHBLPEHO)
	{
		if (FBHNGEJHMOJ + ANFNHBLPEHO > DANEJPGCIAL)
		{
			DANEJPGCIAL = Math.Max(DANEJPGCIAL + ANFNHBLPEHO, DANEJPGCIAL * 2);
			char[] array = new char[DANEJPGCIAL];
			AAFOPLKEPLB.CopyTo(array, 0);
			AAFOPLKEPLB = array;
		}
	}
}
