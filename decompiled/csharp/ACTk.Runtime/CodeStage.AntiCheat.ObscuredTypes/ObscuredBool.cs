using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredBool : IOGAMCONEIG, IEquatable<ObscuredBool>, IComparable<ObscuredBool>, IComparable<bool>, IComparable
{
	[SerializeField]
	private byte currentCryptoKey;

	[SerializeField]
	private int hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private bool fakeValue;

	[SerializeField]
	[FormerlySerializedAs("fakeValueChanged")]
	private bool fakeValueActive;

	private ObscuredBool(bool EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = flag && EHAPKEKPMOE;
		fakeValueActive = flag;
		inited = true;
	}

	public static int ALMGKPDPDCH(bool EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		return ((!EHAPKEKPMOE) ? 181 : 213) ^ JPBEBBODCJJ;
	}

	public static bool MMNLMLIIDBO(int EHAPKEKPMOE, byte JPBEBBODCJJ)
	{
		return (EHAPKEKPMOE ^ JPBEBBODCJJ) != 181;
	}

	public static ObscuredBool GNMNDOIFIEJ(int OLPGDDPLCHG, byte JPBEBBODCJJ)
	{
		ObscuredBool result = default(ObscuredBool);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static byte GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LEKELLEGIPE();
	}

	public int LOELJHDFOGP(out byte JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(int OLPGDDPLCHG, byte JPBEBBODCJJ)
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

	public bool KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		bool eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private bool LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE: false, currentCryptoKey);
			fakeValue = false;
			fakeValueActive = false;
			inited = true;
			return false;
		}
		bool flag = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && flag != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return flag;
	}

	[SpecialName]
	public static ObscuredBool FNIPJFGEFFD(bool EHAPKEKPMOE)
	{
		return new ObscuredBool(EHAPKEKPMOE);
	}

	[SpecialName]
	public static bool FNIPJFGEFFD(ObscuredBool EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	public override int GetHashCode()
	{
		return LHONECCIDNA().GetHashCode();
	}

	public override string ToString()
	{
		return LHONECCIDNA().ToString();
	}

	public override bool Equals(object FFBEPGEKANM)
	{
		return FFBEPGEKANM is ObscuredBool && Equals((ObscuredBool)FFBEPGEKANM);
	}

	public bool Equals(ObscuredBool FFBEPGEKANM)
	{
		if (currentCryptoKey == FFBEPGEKANM.currentCryptoKey)
		{
			return hiddenValue.Equals(FFBEPGEKANM.hiddenValue);
		}
		return MMNLMLIIDBO(hiddenValue, currentCryptoKey).Equals(MMNLMLIIDBO(FFBEPGEKANM.hiddenValue, FFBEPGEKANM.currentCryptoKey));
	}

	public int CompareTo(ObscuredBool OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(bool OBKENFAPMCF)
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

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static int ALMGKPDPDCH(bool EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static bool MMNLMLIIDBO(int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredBool GNMNDOIFIEJ(int OLPGDDPLCHG)
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
