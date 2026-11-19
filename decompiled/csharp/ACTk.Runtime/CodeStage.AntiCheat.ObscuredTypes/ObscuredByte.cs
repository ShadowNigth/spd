using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredByte : IOGAMCONEIG, IFormattable, IEquatable<ObscuredByte>, IComparable<ObscuredByte>, IComparable<byte>, IComparable
{
	private byte currentCryptoKey;

	private byte hiddenValue;

	private bool inited;

	private byte fakeValue;

	private bool fakeValueActive;

	private ObscuredByte(byte EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = (byte)(flag ? EHAPKEKPMOE : 0);
		fakeValueActive = flag;
		inited = true;
	}

	public static byte ALMGKPDPDCH(byte EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		return (byte)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static void ALMGKPDPDCH(byte[] EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		int num = EHAPKEKPMOE.Length;
		for (int i = 0; i < num; i++)
		{
			EHAPKEKPMOE[i] = ALMGKPDPDCH(EHAPKEKPMOE[i], JPBEBBODCJJ);
		}
	}

	public static byte MMNLMLIIDBO(byte EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		return (byte)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	public static void MMNLMLIIDBO(byte[] EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		int num = EHAPKEKPMOE.Length;
		for (int i = 0; i < num; i++)
		{
			EHAPKEKPMOE[i] = MMNLMLIIDBO(EHAPKEKPMOE[i], JPBEBBODCJJ);
		}
	}

	public static ObscuredByte GNMNDOIFIEJ(byte OLPGDDPLCHG, byte JPBEBBODCJJ)
	{
		ObscuredByte result = default(ObscuredByte);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static byte GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LEKELLEGIPE();
	}

	public byte LOELJHDFOGP(out byte JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(byte OLPGDDPLCHG, byte JPBEBBODCJJ)
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

	public byte KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		byte eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private byte LHONECCIDNA()
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
		byte b = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && b != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return b;
	}

	[SpecialName]
	public static ObscuredByte FNIPJFGEFFD(byte EHAPKEKPMOE)
	{
		return new ObscuredByte(EHAPKEKPMOE);
	}

	[SpecialName]
	public static byte FNIPJFGEFFD(ObscuredByte EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredByte JKKOEENGPLM(ObscuredByte MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredByte LNCBKFJDIII(ObscuredByte MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredByte EJFCEMCFONM(ObscuredByte MMKMICOONDG, int NDDHOAFLDNE)
	{
		byte eHAPKEKPMOE = (byte)(MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE);
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
		return FFBEPGEKANM is ObscuredByte && Equals((ObscuredByte)FFBEPGEKANM);
	}

	public bool Equals(ObscuredByte FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredByte OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(byte OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(byte AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
	public static byte KMIFMPCLFGL(byte EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
	public static byte KMIFMPCLFGL(byte[] EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
	public static byte KMIFMPCLFGL(byte EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		return (byte)(EHAPKEKPMOE ^ JPBEBBODCJJ);
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
	public static void KMIFMPCLFGL(byte[] EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		int num = EHAPKEKPMOE.Length;
		for (int i = 0; i < num; i++)
		{
			EHAPKEKPMOE[i] = KMIFMPCLFGL(EHAPKEKPMOE[i], JPBEBBODCJJ);
		}
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredByte GNMNDOIFIEJ(byte OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public byte LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(byte OLPGDDPLCHG)
	{
	}
}
