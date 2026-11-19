using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredUShort : IOGAMCONEIG, IFormattable, IEquatable<ObscuredUShort>, IComparable<ObscuredUShort>, IComparable<ushort>, IComparable
{
	private ushort currentCryptoKey;

	private ushort hiddenValue;

	private bool inited;

	private ushort fakeValue;

	private bool fakeValueActive;

	private ObscuredUShort(ushort EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = (ushort)(flag ? EHAPKEKPMOE : 0);
		fakeValueActive = flag;
		inited = true;
	}

	public static ushort ALMGKPDPDCH(ushort EHAPKEKPMOE, ushort JPBEBBODCJJ)
	{
		return (ushort)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static ushort MMNLMLIIDBO(ushort EHAPKEKPMOE, ushort JPBEBBODCJJ)
	{
		return (ushort)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static ObscuredUShort GNMNDOIFIEJ(ushort OLPGDDPLCHG, ushort JPBEBBODCJJ)
	{
		ObscuredUShort result = default(ObscuredUShort);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static ushort GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.HNMOBICLMCM();
	}

	public ushort LOELJHDFOGP(out ushort JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(ushort OLPGDDPLCHG, ushort JPBEBBODCJJ)
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

	public ushort KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		ushort eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private ushort LHONECCIDNA()
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
		ushort num = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && num != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredUShort FNIPJFGEFFD(ushort EHAPKEKPMOE)
	{
		return new ObscuredUShort(EHAPKEKPMOE);
	}

	[SpecialName]
	public static ushort FNIPJFGEFFD(ObscuredUShort EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredUShort JKKOEENGPLM(ObscuredUShort MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredUShort LNCBKFJDIII(ObscuredUShort MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredUShort EJFCEMCFONM(ObscuredUShort MMKMICOONDG, int NDDHOAFLDNE)
	{
		ushort eHAPKEKPMOE = (ushort)(MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE);
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
		return FFBEPGEKANM is ObscuredUShort && Equals((ObscuredUShort)FFBEPGEKANM);
	}

	public bool Equals(ObscuredUShort FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredUShort OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(ushort OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(ushort AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
	public static ushort KMIFMPCLFGL(ushort EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
	public static ushort KMIFMPCLFGL(ushort EHAPKEKPMOE, ushort JPBEBBODCJJ)
	{
		return (ushort)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredUShort GNMNDOIFIEJ(ushort OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public ushort LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(ushort OLPGDDPLCHG)
	{
	}
}
