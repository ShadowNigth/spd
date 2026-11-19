using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BEJHFGDPDLI
{
	internal class KBMNONKFIDB
	{
		public int JLMLDDKBMMB;

		public Func<bool> JCMELGFLGCD;

		public Action KKHOKAKMACM;
	}

	[CompilerGenerated]
	private sealed class AAHDJFEPNIA
	{
		internal Action KKHOKAKMACM;

		internal bool BEKJDJFLJJC(KBMNONKFIDB AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.KKHOKAKMACM == KKHOKAKMACM;
		}
	}

	public int OGJLDIACBOL = Environment.TickCount;

	private int LBPAAKDGHHJ = new System.Random().Next(100);

	public int LMJFLFEIKOG;

	public int KPFGHOHAJFP;

	public int FHJJEJFBBCL;

	public int AJBDCOIIJHN;

	public double NAKLOBHIAMF;

	internal List<KBMNONKFIDB> KMGLLLGMADC = new List<KBMNONKFIDB>();

	public double JCLFOJMODIO => (double)AJBDCOIIJHN / 1000.0;

	public int HMEEAAJGEIP => FHJJEJFBBCL - AJBDCOIIJHN;

	public void IPBKDPKONHH(Action KKHOKAKMACM)
	{
		IPBKDPKONHH(100, KKHOKAKMACM, null, BNLDNBOKJOB: true);
	}

	public void IPBKDPKONHH(Func<bool> JCMELGFLGCD, Action KKHOKAKMACM)
	{
		IPBKDPKONHH(100, KKHOKAKMACM, JCMELGFLGCD, BNLDNBOKJOB: false);
	}

	public void IPBKDPKONHH(int JLMLDDKBMMB, Action KKHOKAKMACM)
	{
		IPBKDPKONHH(JLMLDDKBMMB, KKHOKAKMACM, null, BNLDNBOKJOB: true);
	}

	public void IPBKDPKONHH(int JLMLDDKBMMB, Action KKHOKAKMACM, Func<bool> JCMELGFLGCD, bool BNLDNBOKJOB)
	{
		KBMNONKFIDB kBMNONKFIDB = null;
		if (!BNLDNBOKJOB)
		{
			kBMNONKFIDB = KMGLLLGMADC.FirstOrDefault((KBMNONKFIDB AEMBPMJMOAB) => AEMBPMJMOAB.KKHOKAKMACM == KKHOKAKMACM);
		}
		if (kBMNONKFIDB == null)
		{
			kBMNONKFIDB = new KBMNONKFIDB();
			lock (KMGLLLGMADC)
			{
				KMGLLLGMADC.Add(kBMNONKFIDB);
			}
		}
		kBMNONKFIDB.KKHOKAKMACM = KKHOKAKMACM;
		kBMNONKFIDB.JLMLDDKBMMB = JLMLDDKBMMB;
		kBMNONKFIDB.JCMELGFLGCD = JCMELGFLGCD;
	}

	public void GFJGDEKLFNB()
	{
		lock (KMGLLLGMADC)
		{
			KMGLLLGMADC.Clear();
		}
	}

	public bool ELKBOHAOPDL(int LNEGIAHLNDI, int LBPAAKDGHHJ = 0)
	{
		if (LBPAAKDGHHJ == 0)
		{
			LBPAAKDGHHJ = this.LBPAAKDGHHJ;
		}
		return (Time.frameCount + LBPAAKDGHHJ) % LNEGIAHLNDI == 0;
	}

	public double LIMEEBFFDFC()
	{
		if (KPFGHOHAJFP > 0)
		{
			double num = NAKLOBHIAMF / (double)KPFGHOHAJFP;
			KPFGHOHAJFP = 0;
			NAKLOBHIAMF = 0.0;
			if (num == double.PositiveInfinity)
			{
				return 0.0;
			}
			return num;
		}
		return 0.0;
	}

	public bool NFMIBMIGJMH(int IBIDGNMCHHA)
	{
		if (AJBDCOIIJHN > IBIDGNMCHHA || IBIDGNMCHHA == 0)
		{
			return true;
		}
		if (FHJJEJFBBCL % IBIDGNMCHHA < HMEEAAJGEIP % IBIDGNMCHHA)
		{
			return true;
		}
		return false;
	}

	public void OJFAJPLDPPK()
	{
		FHJJEJFBBCL = Environment.TickCount - OGJLDIACBOL;
		AJBDCOIIJHN = FHJJEJFBBCL - LMJFLFEIKOG;
		if (AJBDCOIIJHN > 0)
		{
			LMJFLFEIKOG = FHJJEJFBBCL;
			KPFGHOHAJFP++;
			NAKLOBHIAMF += Time.timeScale / Time.deltaTime;
			ENCOAODDCKB();
		}
	}

	private void ENCOAODDCKB()
	{
		KBMNONKFIDB kBMNONKFIDB = null;
		lock (KMGLLLGMADC)
		{
			foreach (KBMNONKFIDB item in KMGLLLGMADC)
			{
				item.JLMLDDKBMMB -= AJBDCOIIJHN;
				if (item.JLMLDDKBMMB < 0 && (item.JCMELGFLGCD == null || item.JCMELGFLGCD()) && (kBMNONKFIDB == null || kBMNONKFIDB.JLMLDDKBMMB > item.JLMLDDKBMMB))
				{
					kBMNONKFIDB = item;
				}
			}
		}
		if (kBMNONKFIDB != null)
		{
			KMGLLLGMADC.Remove(kBMNONKFIDB);
			kBMNONKFIDB.KKHOKAKMACM();
		}
	}
}
