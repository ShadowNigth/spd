using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredChar : IOGAMCONEIG, IEquatable<ObscuredChar>, IComparable<ObscuredChar>, IComparable<char>, IComparable
{
	private char currentCryptoKey;

	private char hiddenValue;

	private bool inited;

	private char fakeValue;

	private bool fakeValueActive;

	private ObscuredChar(char EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = (flag ? EHAPKEKPMOE : '\0');
		fakeValueActive = flag;
		inited = true;
	}

	public static char ALMGKPDPDCH(char EHAPKEKPMOE, char JPBEBBODCJJ)
	{
		return (char)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static char MMNLMLIIDBO(char EHAPKEKPMOE, char JPBEBBODCJJ)
	{
		return (char)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static ObscuredChar GNMNDOIFIEJ(char OLPGDDPLCHG, char JPBEBBODCJJ)
	{
		ObscuredChar result = default(ObscuredChar);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static char GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.FJKMPNOHNBN();
	}

	public char LOELJHDFOGP(out char JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(char OLPGDDPLCHG, char JPBEBBODCJJ)
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

	public char KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		char eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private char LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH('\0', currentCryptoKey);
			fakeValue = '\0';
			fakeValueActive = false;
			inited = true;
			return '\0';
		}
		char c = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && c != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return c;
	}

	[SpecialName]
	public static ObscuredChar FNIPJFGEFFD(char EHAPKEKPMOE)
	{
		return new ObscuredChar(EHAPKEKPMOE);
	}

	[SpecialName]
	public static char FNIPJFGEFFD(ObscuredChar EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredChar JKKOEENGPLM(ObscuredChar MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredChar LNCBKFJDIII(ObscuredChar MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredChar EJFCEMCFONM(ObscuredChar MMKMICOONDG, int NDDHOAFLDNE)
	{
		char eHAPKEKPMOE = (char)(MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE);
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

	public string JIAPBCDODBJ(IFormatProvider EDDHFMOAMCE)
	{
		return LHONECCIDNA().ToString(EDDHFMOAMCE);
	}

	public override bool Equals(object FFBEPGEKANM)
	{
		return FFBEPGEKANM is ObscuredChar && Equals((ObscuredChar)FFBEPGEKANM);
	}

	public bool Equals(ObscuredChar FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredChar OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(char OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(char AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
	public static char KMIFMPCLFGL(char EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
	public static char KMIFMPCLFGL(char EHAPKEKPMOE, char JPBEBBODCJJ)
	{
		return (char)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredChar GNMNDOIFIEJ(char OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public char LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(char OLPGDDPLCHG)
	{
	}
}
