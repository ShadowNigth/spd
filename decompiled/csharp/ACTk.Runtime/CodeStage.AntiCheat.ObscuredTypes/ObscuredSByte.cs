using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredSByte : IOGAMCONEIG, IFormattable, IEquatable<ObscuredSByte>, IComparable<ObscuredSByte>, IComparable<sbyte>, IComparable
{
	private sbyte currentCryptoKey;

	private sbyte hiddenValue;

	private bool inited;

	private sbyte fakeValue;

	private bool fakeValueActive;

	private ObscuredSByte(sbyte EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = (sbyte)(flag ? EHAPKEKPMOE : 0);
		fakeValueActive = flag;
		inited = true;
	}

	public static sbyte ALMGKPDPDCH(sbyte EHAPKEKPMOE, sbyte JPBEBBODCJJ)
	{
		return (sbyte)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static sbyte MMNLMLIIDBO(sbyte EHAPKEKPMOE, sbyte JPBEBBODCJJ)
	{
		return (sbyte)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static ObscuredSByte GNMNDOIFIEJ(sbyte OLPGDDPLCHG, sbyte JPBEBBODCJJ)
	{
		ObscuredSByte result = default(ObscuredSByte);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static sbyte GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LPOJDDINHAN();
	}

	public sbyte LOELJHDFOGP(out sbyte JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(sbyte OLPGDDPLCHG, sbyte JPBEBBODCJJ)
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

	public sbyte KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		sbyte eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private sbyte LHONECCIDNA()
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
		sbyte b = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && b != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return b;
	}

	[SpecialName]
	public static ObscuredSByte FNIPJFGEFFD(sbyte EHAPKEKPMOE)
	{
		return new ObscuredSByte(EHAPKEKPMOE);
	}

	[SpecialName]
	public static sbyte FNIPJFGEFFD(ObscuredSByte EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredSByte JKKOEENGPLM(ObscuredSByte MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredSByte LNCBKFJDIII(ObscuredSByte MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredSByte EJFCEMCFONM(ObscuredSByte MMKMICOONDG, int NDDHOAFLDNE)
	{
		sbyte eHAPKEKPMOE = (sbyte)(MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE);
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
		return FFBEPGEKANM is ObscuredSByte && Equals((ObscuredSByte)FFBEPGEKANM);
	}

	public bool Equals(ObscuredSByte FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredSByte OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(sbyte OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(sbyte AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
	public static sbyte KMIFMPCLFGL(sbyte EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
	public static sbyte KMIFMPCLFGL(sbyte EHAPKEKPMOE, sbyte JPBEBBODCJJ)
	{
		return (sbyte)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredSByte GNMNDOIFIEJ(sbyte OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public sbyte LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(sbyte OLPGDDPLCHG)
	{
	}
}
