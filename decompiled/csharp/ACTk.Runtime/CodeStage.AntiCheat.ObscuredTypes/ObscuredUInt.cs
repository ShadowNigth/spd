using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredUInt : IOGAMCONEIG, IFormattable, IEquatable<ObscuredUInt>, IComparable<ObscuredUInt>, IComparable<uint>, IComparable
{
	[SerializeField]
	private uint currentCryptoKey;

	[SerializeField]
	private uint hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private uint fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredUInt(uint EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = (flag ? EHAPKEKPMOE : 0u);
		fakeValueActive = flag;
		inited = true;
	}

	public static uint ALMGKPDPDCH(uint EHAPKEKPMOE, uint JPBEBBODCJJ)
	{
		return EHAPKEKPMOE ^ JPBEBBODCJJ;
	}

	public static uint MMNLMLIIDBO(uint EHAPKEKPMOE, uint JPBEBBODCJJ)
	{
		return EHAPKEKPMOE ^ JPBEBBODCJJ;
	}

	public static ObscuredUInt GNMNDOIFIEJ(uint OLPGDDPLCHG, uint JPBEBBODCJJ)
	{
		ObscuredUInt result = default(ObscuredUInt);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static uint GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.IBDHCIJCBLM();
	}

	public uint LOELJHDFOGP(out uint JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(uint OLPGDDPLCHG, uint JPBEBBODCJJ)
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

	public uint KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		uint eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private uint LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(0u, currentCryptoKey);
			fakeValue = 0u;
			fakeValueActive = false;
			inited = true;
			return 0u;
		}
		uint num = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && num != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredUInt FNIPJFGEFFD(uint EHAPKEKPMOE)
	{
		return new ObscuredUInt(EHAPKEKPMOE);
	}

	[SpecialName]
	public static uint FNIPJFGEFFD(ObscuredUInt EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredInt JDBGCLLOGHJ(ObscuredUInt EHAPKEKPMOE)
	{
		return ObscuredInt.FNIPJFGEFFD((int)EHAPKEKPMOE.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredUInt JKKOEENGPLM(ObscuredUInt MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredUInt LNCBKFJDIII(ObscuredUInt MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredUInt EJFCEMCFONM(ObscuredUInt MMKMICOONDG, int NDDHOAFLDNE)
	{
		uint eHAPKEKPMOE = (uint)(MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE);
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
		return FFBEPGEKANM is ObscuredUInt && Equals((ObscuredUInt)FFBEPGEKANM);
	}

	public bool Equals(ObscuredUInt FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredUInt OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(uint OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(uint AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static int ALMGKPDPDCH(uint EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static int MMNLMLIIDBO(uint EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredUInt GNMNDOIFIEJ(uint OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public uint LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(uint OLPGDDPLCHG)
	{
	}
}
