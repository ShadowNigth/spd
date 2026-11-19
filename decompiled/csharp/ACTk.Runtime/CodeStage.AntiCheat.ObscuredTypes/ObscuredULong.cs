using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredULong : IOGAMCONEIG, IFormattable, IEquatable<ObscuredULong>, IComparable<ObscuredULong>, IComparable<ulong>, IComparable
{
	[SerializeField]
	private ulong currentCryptoKey;

	[SerializeField]
	private ulong hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private ulong fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredULong(ulong EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? 0 : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public static ulong ALMGKPDPDCH(ulong EHAPKEKPMOE, ulong JPBEBBODCJJ)
	{
		return EHAPKEKPMOE ^ JPBEBBODCJJ;
	}

	public static ulong MMNLMLIIDBO(ulong EHAPKEKPMOE, ulong JPBEBBODCJJ)
	{
		return EHAPKEKPMOE ^ JPBEBBODCJJ;
	}

	public static ObscuredULong GNMNDOIFIEJ(ulong OLPGDDPLCHG, ulong JPBEBBODCJJ)
	{
		ObscuredULong result = default(ObscuredULong);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static ulong GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.GMBLKBCBBMJ();
	}

	public ulong LOELJHDFOGP(out ulong JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(ulong OLPGDDPLCHG, ulong JPBEBBODCJJ)
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

	public ulong KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		ulong eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private ulong LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(0uL, currentCryptoKey);
			fakeValue = 0uL;
			fakeValueActive = false;
			inited = true;
			return 0uL;
		}
		ulong num = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && num != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredULong FNIPJFGEFFD(ulong EHAPKEKPMOE)
	{
		return new ObscuredULong(EHAPKEKPMOE);
	}

	[SpecialName]
	public static ulong FNIPJFGEFFD(ObscuredULong EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredULong JKKOEENGPLM(ObscuredULong MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredULong LNCBKFJDIII(ObscuredULong MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredULong EJFCEMCFONM(ObscuredULong MMKMICOONDG, int NDDHOAFLDNE)
	{
		ulong eHAPKEKPMOE = ((NDDHOAFLDNE != 1) ? (MMKMICOONDG.LHONECCIDNA() - 1) : (MMKMICOONDG.LHONECCIDNA() + 1));
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
		return FFBEPGEKANM is ObscuredULong && Equals((ObscuredULong)FFBEPGEKANM);
	}

	public bool Equals(ObscuredULong FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredULong OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(ulong OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(ulong AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static ulong ALMGKPDPDCH(ulong EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static ulong MMNLMLIIDBO(ulong EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredULong GNMNDOIFIEJ(ulong OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public ulong LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(ulong OLPGDDPLCHG)
	{
	}
}
