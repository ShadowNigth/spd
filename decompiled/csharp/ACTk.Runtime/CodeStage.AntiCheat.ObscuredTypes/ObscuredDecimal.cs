using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredDecimal : IOGAMCONEIG, IFormattable, IEquatable<ObscuredDecimal>, IComparable<ObscuredDecimal>, IComparable<decimal>, IComparable
{
	[StructLayout(LayoutKind.Explicit)]
	private struct DNDDDJKEDBG
	{
		[FieldOffset(0)]
		private decimal CPFJBOMGNBF;

		[FieldOffset(0)]
		private long MJCICLALGEJ;

		[FieldOffset(8)]
		private long OPJJHEHHCKK;

		[FieldOffset(0)]
		private ACTkByte16 ALECDFJONOJ;

		internal static decimal HIBNPFDMCAG(decimal EHAPKEKPMOE, long JPBEBBODCJJ)
		{
			return OIHLCEMEELM(EHAPKEKPMOE).NBMJDAPGCLN(JPBEBBODCJJ).CPFJBOMGNBF;
		}

		internal static ACTkByte16 EKNAKHKGBJO(decimal EHAPKEKPMOE, long JPBEBBODCJJ)
		{
			return OIHLCEMEELM(EHAPKEKPMOE).NBMJDAPGCLN(JPBEBBODCJJ).ALECDFJONOJ;
		}

		internal static decimal KMPPHNEMBDA(ACTkByte16 EHAPKEKPMOE, long JPBEBBODCJJ)
		{
			return HCGGBHDMFKN(EHAPKEKPMOE).NBMJDAPGCLN(JPBEBBODCJJ).CPFJBOMGNBF;
		}

		internal static decimal BEPOFJOCBBB(ACTkByte16 EHAPKEKPMOE)
		{
			return HCGGBHDMFKN(EHAPKEKPMOE).CPFJBOMGNBF;
		}

		internal static ACTkByte16 OKGBCCJKNNL(decimal EHAPKEKPMOE)
		{
			return OIHLCEMEELM(EHAPKEKPMOE).ALECDFJONOJ;
		}

		private static DNDDDJKEDBG OIHLCEMEELM(decimal EHAPKEKPMOE)
		{
			DNDDDJKEDBG result = default(DNDDDJKEDBG);
			result.CPFJBOMGNBF = EHAPKEKPMOE;
			return result;
		}

		private static DNDDDJKEDBG HCGGBHDMFKN(ACTkByte16 EHAPKEKPMOE)
		{
			DNDDDJKEDBG result = default(DNDDDJKEDBG);
			result.ALECDFJONOJ = EHAPKEKPMOE;
			return result;
		}

		private DNDDDJKEDBG NBMJDAPGCLN(long JPBEBBODCJJ)
		{
			MJCICLALGEJ ^= JPBEBBODCJJ;
			OPJJHEHHCKK ^= JPBEBBODCJJ;
			return this;
		}
	}

	[SerializeField]
	private long currentCryptoKey;

	[SerializeField]
	private ACTkByte16 hiddenValue;

	[SerializeField]
	private bool inited;

	private decimal fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredDecimal(decimal EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = EGGILFJMHOD(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? 0m : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public static decimal ALMGKPDPDCH(decimal EHAPKEKPMOE, long JPBEBBODCJJ)
	{
		return DNDDDJKEDBG.HIBNPFDMCAG(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	public static decimal MMNLMLIIDBO(decimal EHAPKEKPMOE, long JPBEBBODCJJ)
	{
		return DNDDDJKEDBG.HIBNPFDMCAG(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	public static ObscuredDecimal GNMNDOIFIEJ(decimal OLPGDDPLCHG, long JPBEBBODCJJ)
	{
		ObscuredDecimal result = default(ObscuredDecimal);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static long GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.JDMIDOCOJPL();
	}

	public decimal LOELJHDFOGP(out long JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return DNDDDJKEDBG.BEPOFJOCBBB(hiddenValue);
	}

	public void LBHPCBGLHKI(decimal OLPGDDPLCHG, long JPBEBBODCJJ)
	{
		inited = true;
		hiddenValue = DNDDDJKEDBG.OKGBCCJKNNL(OLPGDDPLCHG);
		currentCryptoKey = JPBEBBODCJJ;
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValueActive = false;
			fakeValue = LHONECCIDNA();
			fakeValueActive = true;
		}
		else
		{
			fakeValueActive = false;
		}
	}

	public decimal KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		decimal eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = EGGILFJMHOD(eHAPKEKPMOE, currentCryptoKey);
	}

	private static ACTkByte16 EGGILFJMHOD(decimal EHAPKEKPMOE, long JPBEBBODCJJ)
	{
		return DNDDDJKEDBG.EKNAKHKGBJO(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	private decimal LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = EGGILFJMHOD(0m, currentCryptoKey);
			fakeValue = 0m;
			fakeValueActive = false;
			inited = true;
			return 0m;
		}
		decimal num = DNDDDJKEDBG.KMPPHNEMBDA(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && num != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredDecimal FNIPJFGEFFD(decimal EHAPKEKPMOE)
	{
		return new ObscuredDecimal(EHAPKEKPMOE);
	}

	[SpecialName]
	public static decimal FNIPJFGEFFD(ObscuredDecimal EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredDecimal JDBGCLLOGHJ(ObscuredFloat GHJBEEBMOKB)
	{
		return FNIPJFGEFFD((decimal)ObscuredFloat.FNIPJFGEFFD(GHJBEEBMOKB));
	}

	[SpecialName]
	public static ObscuredDecimal JKKOEENGPLM(ObscuredDecimal MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1m);
	}

	[SpecialName]
	public static ObscuredDecimal LNCBKFJDIII(ObscuredDecimal MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1m);
	}

	private static ObscuredDecimal EJFCEMCFONM(ObscuredDecimal MMKMICOONDG, decimal NDDHOAFLDNE)
	{
		decimal eHAPKEKPMOE = MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE;
		MMKMICOONDG.hiddenValue = EGGILFJMHOD(eHAPKEKPMOE, MMKMICOONDG.currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			MMKMICOONDG.fakeValue = eHAPKEKPMOE;
			MMKMICOONDG.fakeValueActive = true;
		}
		else
		{
			MMKMICOONDG.fakeValueActive = false;
		}
		return MMKMICOONDG;
	}

	public override int GetHashCode()
	{
		return LHONECCIDNA().GetHashCode();
	}

	public override string ToString()
	{
		return LHONECCIDNA().ToString();
	}

	public string JIAPBCDODBJ(string MFAEBIAHAOP)
	{
		return LHONECCIDNA().ToString(MFAEBIAHAOP);
	}

	public string JIAPBCDODBJ(IFormatProvider EDDHFMOAMCE)
	{
		return LHONECCIDNA().ToString(EDDHFMOAMCE);
	}

	public string ToString(string MFAEBIAHAOP, IFormatProvider EDDHFMOAMCE)
	{
		return LHONECCIDNA().ToString(MFAEBIAHAOP, EDDHFMOAMCE);
	}

	public override bool Equals(object FFBEPGEKANM)
	{
		return FFBEPGEKANM is ObscuredDecimal && Equals((ObscuredDecimal)FFBEPGEKANM);
	}

	public bool Equals(ObscuredDecimal FFBEPGEKANM)
	{
		return FFBEPGEKANM.LHONECCIDNA().Equals(LHONECCIDNA());
	}

	public int CompareTo(ObscuredDecimal OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(decimal OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(long AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static decimal ALMGKPDPDCH(decimal EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static decimal MMNLMLIIDBO(decimal EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredDecimal GNMNDOIFIEJ(decimal OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public decimal LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(decimal OLPGDDPLCHG)
	{
	}
}
