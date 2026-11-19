using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredInt : IOGAMCONEIG, IFormattable, IEquatable<ObscuredInt>, IComparable<ObscuredInt>, IComparable<int>, IComparable
{
	[SerializeField]
	private int currentCryptoKey;

	[SerializeField]
	private int hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private int fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredInt(int EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = (flag ? EHAPKEKPMOE : 0);
		fakeValueActive = flag;
		inited = true;
	}

	public static int ALMGKPDPDCH(int EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return EHAPKEKPMOE ^ JPBEBBODCJJ;
	}

	public static int MMNLMLIIDBO(int EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return EHAPKEKPMOE ^ JPBEBBODCJJ;
	}

	public static ObscuredInt GNMNDOIFIEJ(int OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		ObscuredInt result = default(ObscuredInt);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static int GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LDCFDMADKJP();
	}

	public int LOELJHDFOGP(out int JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(int OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		inited = true;
		hiddenValue = OLPGDDPLCHG;
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

	public int KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		hiddenValue = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(hiddenValue, currentCryptoKey);
	}

	private int LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(0, currentCryptoKey);
			fakeValue = 0;
			fakeValueActive = false;
			inited = true;
			return 0;
		}
		int num = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && num != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredInt FNIPJFGEFFD(int EHAPKEKPMOE)
	{
		return new ObscuredInt(EHAPKEKPMOE);
	}

	[SpecialName]
	public static int FNIPJFGEFFD(ObscuredInt EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredFloat FNIPJFGEFFD(ObscuredInt EHAPKEKPMOE)
	{
		return ObscuredFloat.FNIPJFGEFFD(EHAPKEKPMOE.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredDouble FNIPJFGEFFD(ObscuredInt EHAPKEKPMOE)
	{
		return ObscuredDouble.FNIPJFGEFFD(EHAPKEKPMOE.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredUInt JDBGCLLOGHJ(ObscuredInt EHAPKEKPMOE)
	{
		return ObscuredUInt.FNIPJFGEFFD((uint)EHAPKEKPMOE.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredInt JKKOEENGPLM(ObscuredInt MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredInt LNCBKFJDIII(ObscuredInt MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredInt EJFCEMCFONM(ObscuredInt MMKMICOONDG, int NDDHOAFLDNE)
	{
		int eHAPKEKPMOE = MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE;
		MMKMICOONDG.hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, MMKMICOONDG.currentCryptoKey);
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
		return FFBEPGEKANM is ObscuredInt && Equals((ObscuredInt)FFBEPGEKANM);
	}

	public bool Equals(ObscuredInt FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredInt OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(int OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(int AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static int ALMGKPDPDCH(int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static int MMNLMLIIDBO(int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredInt GNMNDOIFIEJ(int OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public int LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(int OLPGDDPLCHG)
	{
	}
}
