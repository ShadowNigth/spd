using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public sealed class ObscuredString : IOGAMCONEIG, IComparable<ObscuredString>, IComparable<string>, IComparable
{
	[SerializeField]
	private string currentCryptoKey;

	[SerializeField]
	private byte[] hiddenValue;

	[SerializeField]
	private char[] cryptoKey;

	[SerializeField]
	private char[] hiddenChars;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private string fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	public int Length => hiddenChars.Length;

	public char this[int JNDABHCJHHD]
	{
		get
		{
			if (JNDABHCJHHD < 0 || JNDABHCJHHD >= Length)
			{
				throw new IndexOutOfRangeException();
			}
			return LHONECCIDNA()[JNDABHCJHHD];
		}
	}

	private ObscuredString()
	{
	}

	private ObscuredString(string EHAPKEKPMOE)
	{
		cryptoKey = new char[7];
		GPLMLGBLJHH(cryptoKey);
		hiddenChars = PKLAFGIKGAN(EHAPKEKPMOE.ToCharArray(), cryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? null : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public static char[] ALMGKPDPDCH(string EHAPKEKPMOE, string JPBEBBODCJJ)
	{
		return ALMGKPDPDCH(EHAPKEKPMOE, JPBEBBODCJJ.ToCharArray());
	}

	public static char[] ALMGKPDPDCH(string EHAPKEKPMOE, char[] JPBEBBODCJJ)
	{
		return ALMGKPDPDCH(EHAPKEKPMOE.ToCharArray(), JPBEBBODCJJ);
	}

	public static char[] ALMGKPDPDCH(char[] EHAPKEKPMOE, char[] JPBEBBODCJJ)
	{
		return PKLAFGIKGAN(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	public static string MMNLMLIIDBO(char[] EHAPKEKPMOE, string JPBEBBODCJJ)
	{
		return MMNLMLIIDBO(EHAPKEKPMOE, JPBEBBODCJJ.ToCharArray());
	}

	public static string MMNLMLIIDBO(char[] EHAPKEKPMOE, char[] JPBEBBODCJJ)
	{
		return new string(PKLAFGIKGAN(EHAPKEKPMOE, JPBEBBODCJJ));
	}

	public static ObscuredString GNMNDOIFIEJ(char[] OLPGDDPLCHG, char[] JPBEBBODCJJ)
	{
		ObscuredString obscuredString = new ObscuredString();
		obscuredString.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return obscuredString;
	}

	[Obsolete("Use this only to decrypt data encrypted with previous ACTk versions. Please use FromEncrypted(char[], char[]) in other cases.")]
	public static ObscuredString GNMNDOIFIEJ(string OLPGDDPLCHG, string JPBEBBODCJJ = "4441")
	{
		ObscuredString obscuredString = new ObscuredString();
		obscuredString.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return obscuredString;
	}

	public static char[] GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.DCDNEAFHFKB();
	}

	public static char[] GPLMLGBLJHH(char[] EONBHJFLNBJ)
	{
		return LFHFAFOPFIO.DCDNEAFHFKB(EONBHJFLNBJ);
	}

	internal static char[] PKLAFGIKGAN(char[] EHAPKEKPMOE, char[] JPBEBBODCJJ)
	{
		if (EHAPKEKPMOE == null || EHAPKEKPMOE.Length == 0)
		{
			return EHAPKEKPMOE;
		}
		if (JPBEBBODCJJ.Length == 0)
		{
			Debug.LogError("[ACTk] Empty key can't be used for string encryption or decryption!");
			return EHAPKEKPMOE;
		}
		int num = JPBEBBODCJJ.Length;
		int num2 = EHAPKEKPMOE.Length;
		char[] array = new char[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = (char)(EHAPKEKPMOE[i] ^ JPBEBBODCJJ[i % num]);
		}
		return array;
	}

	internal static string FOPCCIAILGE(string EHAPKEKPMOE, string JPBEBBODCJJ)
	{
		if (string.IsNullOrEmpty(EHAPKEKPMOE))
		{
			return string.Empty;
		}
		if (string.IsNullOrEmpty(JPBEBBODCJJ))
		{
			Debug.LogError("[ACTk] Empty key can't be used for string encryption or decryption!");
			return string.Empty;
		}
		int length = JPBEBBODCJJ.Length;
		int length2 = EHAPKEKPMOE.Length;
		char[] array = new char[length2];
		for (int i = 0; i < length2; i++)
		{
			array[i] = (char)(EHAPKEKPMOE[i] ^ JPBEBBODCJJ[i % length]);
		}
		return new string(array);
	}

	public char[] LOELJHDFOGP(out char[] JPBEBBODCJJ)
	{
		JPBEBBODCJJ = cryptoKey;
		return hiddenChars;
	}

	public void LBHPCBGLHKI(char[] OLPGDDPLCHG, char[] JPBEBBODCJJ)
	{
		inited = true;
		hiddenChars = OLPGDDPLCHG;
		cryptoKey = JPBEBBODCJJ;
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValueActive = false;
			fakeValue = MINANKKNGFL();
			fakeValueActive = true;
		}
		else
		{
			fakeValueActive = false;
		}
	}

	[Obsolete("Use this only to decrypt data encrypted with previous ACTk versions. Please use SetEncrypted(char[], char[]) in other cases.")]
	public void LBHPCBGLHKI(string OLPGDDPLCHG, string JPBEBBODCJJ)
	{
		inited = true;
		string eHAPKEKPMOE = FOPCCIAILGE(OLPGDDPLCHG, JPBEBBODCJJ);
		cryptoKey = GPLMLGBLJHH();
		hiddenChars = ALMGKPDPDCH(eHAPKEKPMOE, cryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValueActive = false;
			fakeValue = MINANKKNGFL();
			fakeValueActive = true;
		}
		else
		{
			fakeValueActive = false;
		}
	}

	public string KODPNIGCJPK()
	{
		return MINANKKNGFL();
	}

	public char[] CJCMLANLPKH()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		char[] eHAPKEKPMOE = LHONECCIDNA();
		GPLMLGBLJHH(cryptoKey);
		hiddenChars = PKLAFGIKGAN(eHAPKEKPMOE, cryptoKey);
	}

	private string MINANKKNGFL()
	{
		return new string(LHONECCIDNA());
	}

	private char[] LHONECCIDNA()
	{
		if (!inited)
		{
			cryptoKey = new char[7];
			GPLMLGBLJHH(cryptoKey);
			hiddenChars = PKLAFGIKGAN(new char[0], cryptoKey);
			fakeValue = string.Empty;
			fakeValueActive = false;
			inited = true;
			return new char[0];
		}
		if (!string.IsNullOrEmpty(currentCryptoKey))
		{
			LLCCLIBFIPG();
		}
		char[] array = PKLAFGIKGAN(hiddenChars, cryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && !GDEAJJGPBKK(array, fakeValue))
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return array;
	}

	private bool GDEAJJGPBKK(char[] MEDOBHGOPIE, string LGNIFJCEECH)
	{
		if (MEDOBHGOPIE.Length != LGNIFJCEECH.Length)
		{
			return false;
		}
		for (int i = 0; i < MEDOBHGOPIE.Length; i++)
		{
			if (MEDOBHGOPIE[i] != LGNIFJCEECH[i])
			{
				return false;
			}
		}
		return true;
	}

	internal void LLCCLIBFIPG()
	{
		string text = FOPCCIAILGE(ECNNMMOFDOO(hiddenValue), currentCryptoKey);
		GPLMLGBLJHH(cryptoKey);
		hiddenChars = PKLAFGIKGAN(text.ToCharArray(), cryptoKey);
		currentCryptoKey = null;
	}

	[SpecialName]
	public static ObscuredString FNIPJFGEFFD(string EHAPKEKPMOE)
	{
		return (EHAPKEKPMOE != null) ? new ObscuredString(EHAPKEKPMOE) : null;
	}

	[SpecialName]
	public static string FNIPJFGEFFD(ObscuredString EHAPKEKPMOE)
	{
		return (!JHLIPNMGNGC(EHAPKEKPMOE, null)) ? EHAPKEKPMOE.MINANKKNGFL() : null;
	}

	[SpecialName]
	public static bool JHLIPNMGNGC(ObscuredString AEMBPMJMOAB, ObscuredString LCBKHLLPIGM)
	{
		if (object.ReferenceEquals(AEMBPMJMOAB, LCBKHLLPIGM))
		{
			return true;
		}
		if (AEMBPMJMOAB == null || LCBKHLLPIGM == null)
		{
			return false;
		}
		if (AEMBPMJMOAB.cryptoKey == LCBKHLLPIGM.cryptoKey)
		{
			return PJLPHGPBBPN(AEMBPMJMOAB.hiddenChars, LCBKHLLPIGM.hiddenChars);
		}
		return PJLPHGPBBPN(AEMBPMJMOAB.LHONECCIDNA(), LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static bool JNBCJBNOFDH(ObscuredString AEMBPMJMOAB, ObscuredString LCBKHLLPIGM)
	{
		return !JHLIPNMGNGC(AEMBPMJMOAB, LCBKHLLPIGM);
	}

	public string PENBFFPLFBA(int MLJLPCDEJGD)
	{
		return PENBFFPLFBA(MLJLPCDEJGD, Length - MLJLPCDEJGD);
	}

	public string PENBFFPLFBA(int MLJLPCDEJGD, int JMBJALGFMPA)
	{
		return MINANKKNGFL().Substring(MLJLPCDEJGD, JMBJALGFMPA);
	}

	public bool GINECOMJOFE(string EHAPKEKPMOE, StringComparison BNCMBJCEPHH = StringComparison.CurrentCulture)
	{
		return MINANKKNGFL().StartsWith(EHAPKEKPMOE, BNCMBJCEPHH);
	}

	public bool ELJGKOOBJJJ(string EHAPKEKPMOE, StringComparison BNCMBJCEPHH = StringComparison.CurrentCulture)
	{
		return MINANKKNGFL().EndsWith(EHAPKEKPMOE, BNCMBJCEPHH);
	}

	public override int GetHashCode()
	{
		return MINANKKNGFL().GetHashCode();
	}

	public override string ToString()
	{
		return new string(LHONECCIDNA());
	}

	public override bool Equals(object FFBEPGEKANM)
	{
		ObscuredString obscuredString = FFBEPGEKANM as ObscuredString;
		return JNBCJBNOFDH(obscuredString, null) && AOCDNIPBFMK(obscuredString);
	}

	public bool AOCDNIPBFMK(ObscuredString EHAPKEKPMOE)
	{
		if (JHLIPNMGNGC(EHAPKEKPMOE, null))
		{
			return false;
		}
		if (cryptoKey == EHAPKEKPMOE.cryptoKey)
		{
			return PJLPHGPBBPN(hiddenChars, EHAPKEKPMOE.hiddenChars);
		}
		return PJLPHGPBBPN(LHONECCIDNA(), EHAPKEKPMOE.LHONECCIDNA());
	}

	public bool AOCDNIPBFMK(ObscuredString EHAPKEKPMOE, StringComparison BNCMBJCEPHH)
	{
		return JNBCJBNOFDH(EHAPKEKPMOE, null) && string.Equals(MINANKKNGFL(), EHAPKEKPMOE.MINANKKNGFL(), BNCMBJCEPHH);
	}

	public int CompareTo(ObscuredString OBKENFAPMCF)
	{
		return MINANKKNGFL().CompareTo(OBKENFAPMCF.MINANKKNGFL());
	}

	public int CompareTo(string OBKENFAPMCF)
	{
		return MINANKKNGFL().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return MINANKKNGFL().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(string AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
	public static string KMIFMPCLFGL(string EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
	public static string KMIFMPCLFGL(string EHAPKEKPMOE, string JPBEBBODCJJ)
	{
		return FOPCCIAILGE(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public string LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(string OLPGDDPLCHG)
	{
	}

	internal static string ECNNMMOFDOO(byte[] BKOEGJJBGBC)
	{
		char[] array = new char[BKOEGJJBGBC.Length / 2];
		Buffer.BlockCopy(BKOEGJJBGBC, 0, array, 0, BKOEGJJBGBC.Length);
		return new string(array);
	}

	internal static byte[] CFKJJCKAGFF(string DGPOLNOFCMB)
	{
		byte[] array = new byte[DGPOLNOFCMB.Length * 2];
		Buffer.BlockCopy(DGPOLNOFCMB.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	private static bool PJLPHGPBBPN(char[] ACMHNMNEFPA, char[] GJPNECIGCIM)
	{
		if (ACMHNMNEFPA == GJPNECIGCIM)
		{
			return true;
		}
		if (ACMHNMNEFPA == null || GJPNECIGCIM == null)
		{
			return false;
		}
		if (ACMHNMNEFPA.Length != GJPNECIGCIM.Length)
		{
			return false;
		}
		for (int i = 0; i < ACMHNMNEFPA.Length; i++)
		{
			if (ACMHNMNEFPA[i] != GJPNECIGCIM[i])
			{
				return false;
			}
		}
		return true;
	}
}
