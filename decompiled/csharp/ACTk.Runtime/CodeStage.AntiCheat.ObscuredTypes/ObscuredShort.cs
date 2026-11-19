using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredShort : IOGAMCONEIG, IFormattable, IEquatable<ObscuredShort>, IComparable<ObscuredShort>, IComparable<short>, IComparable
{
	[SerializeField]
	private short currentCryptoKey;

	[SerializeField]
	private short hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private short fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredShort(short EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = (short)(flag ? EHAPKEKPMOE : 0);
		fakeValueActive = flag;
		inited = true;
	}

	public static short ALMGKPDPDCH(short EHAPKEKPMOE, short JPBEBBODCJJ)
	{
		return (short)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static short MMNLMLIIDBO(short EHAPKEKPMOE, short JPBEBBODCJJ)
	{
		return (short)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static ObscuredShort GNMNDOIFIEJ(short OLPGDDPLCHG, short JPBEBBODCJJ)
	{
		ObscuredShort result = default(ObscuredShort);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static short GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.BDCLEDLADKM();
	}

	public short LOELJHDFOGP(out short JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(short OLPGDDPLCHG, short JPBEBBODCJJ)
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

	public short KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		short eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private short LHONECCIDNA()
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
		short num = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && num != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredShort FNIPJFGEFFD(short EHAPKEKPMOE)
	{
		return new ObscuredShort(EHAPKEKPMOE);
	}

	[SpecialName]
	public static short FNIPJFGEFFD(ObscuredShort EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredShort JKKOEENGPLM(ObscuredShort MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredShort LNCBKFJDIII(ObscuredShort MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredShort EJFCEMCFONM(ObscuredShort MMKMICOONDG, int NDDHOAFLDNE)
	{
		short eHAPKEKPMOE = (short)(MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE);
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
		return FFBEPGEKANM is ObscuredShort && Equals((ObscuredShort)FFBEPGEKANM);
	}

	public bool Equals(ObscuredShort FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredShort OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(short OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(short AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
	public static short KMIFMPCLFGL(short EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
	public static short KMIFMPCLFGL(short EHAPKEKPMOE, short JPBEBBODCJJ)
	{
		return (short)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredShort GNMNDOIFIEJ(short OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public short LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(short OLPGDDPLCHG)
	{
	}
}
