using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredFloat : IOGAMCONEIG, IFormattable, IEquatable<ObscuredFloat>, IComparable<ObscuredFloat>, IComparable<float>, IComparable
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct HLKGNFJCOKH
	{
		[FieldOffset(0)]
		internal float GHJBEEBMOKB;

		[FieldOffset(0)]
		internal int FAGMOBEKJND;

		[FieldOffset(0)]
		internal ACTkByte4 FBLGBAAPJFA;

		public static int OKHLHAOOOAP(int EHAPKEKPMOE, byte EHHIDOPHKKO, byte DPPALFLEBJG)
		{
			HLKGNFJCOKH hLKGNFJCOKH = DGJKHCHMIJO(EHAPKEKPMOE);
			if (EHHIDOPHKKO < 2 && DPPALFLEBJG == 2)
			{
				hLKGNFJCOKH.FBLGBAAPJFA.IINPFBMPOHF();
			}
			return hLKGNFJCOKH.FAGMOBEKJND;
		}

		internal static int AAPMCAHFBNP(float EHAPKEKPMOE, int JPBEBBODCJJ)
		{
			return DHKCFOEEHNA(EHAPKEKPMOE).IINPFBMPOHF(JPBEBBODCJJ).FAGMOBEKJND;
		}

		internal static float MMJBOCBONNN(int EHAPKEKPMOE, int JPBEBBODCJJ)
		{
			return DGJKHCHMIJO(EHAPKEKPMOE).KIFEICJLOFN(JPBEBBODCJJ).GHJBEEBMOKB;
		}

		private static HLKGNFJCOKH DHKCFOEEHNA(float EHAPKEKPMOE)
		{
			HLKGNFJCOKH result = default(HLKGNFJCOKH);
			result.GHJBEEBMOKB = EHAPKEKPMOE;
			return result;
		}

		private static HLKGNFJCOKH DGJKHCHMIJO(int EHAPKEKPMOE)
		{
			HLKGNFJCOKH result = default(HLKGNFJCOKH);
			result.FAGMOBEKJND = EHAPKEKPMOE;
			return result;
		}

		private HLKGNFJCOKH IINPFBMPOHF(int JPBEBBODCJJ)
		{
			FAGMOBEKJND ^= JPBEBBODCJJ;
			FBLGBAAPJFA.IINPFBMPOHF();
			return this;
		}

		private HLKGNFJCOKH KIFEICJLOFN(int JPBEBBODCJJ)
		{
			FBLGBAAPJFA.KIFEICJLOFN();
			FAGMOBEKJND ^= JPBEBBODCJJ;
			return this;
		}
	}

	[SerializeField]
	private int currentCryptoKey;

	[SerializeField]
	private int hiddenValue;

	[FormerlySerializedAs("hiddenValue")]
	[SerializeField]
	private ACTkByte4 hiddenValueOldByte4;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private float fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredFloat(float EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		hiddenValueOldByte4 = default(ACTkByte4);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? 0f : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public static int ALMGKPDPDCH(float EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return HLKGNFJCOKH.AAPMCAHFBNP(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	public static float MMNLMLIIDBO(int EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return HLKGNFJCOKH.MMJBOCBONNN(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	public static int NJLOHHJHDKF(int OLPGDDPLCHG, byte EHHIDOPHKKO = 0, byte DPPALFLEBJG = 2)
	{
		return HLKGNFJCOKH.OKHLHAOOOAP(OLPGDDPLCHG, EHHIDOPHKKO, DPPALFLEBJG);
	}

	public static ObscuredFloat GNMNDOIFIEJ(int OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		ObscuredFloat result = default(ObscuredFloat);
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

	public float KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		float eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private float LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(0f, currentCryptoKey);
			fakeValue = 0f;
			fakeValueActive = false;
			inited = true;
			return 0f;
		}
		float num = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue) > global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.AACEDBAHHLB)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredFloat FNIPJFGEFFD(float EHAPKEKPMOE)
	{
		return new ObscuredFloat(EHAPKEKPMOE);
	}

	[SpecialName]
	public static float FNIPJFGEFFD(ObscuredFloat EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredFloat JKKOEENGPLM(ObscuredFloat MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1);
	}

	[SpecialName]
	public static ObscuredFloat LNCBKFJDIII(ObscuredFloat MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1);
	}

	private static ObscuredFloat EJFCEMCFONM(ObscuredFloat MMKMICOONDG, int NDDHOAFLDNE)
	{
		float eHAPKEKPMOE = MMKMICOONDG.LHONECCIDNA() + (float)NDDHOAFLDNE;
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
		return FFBEPGEKANM is ObscuredFloat && Equals((ObscuredFloat)FFBEPGEKANM);
	}

	public bool Equals(ObscuredFloat FFBEPGEKANM)
	{
		return FFBEPGEKANM.LHONECCIDNA().Equals(LHONECCIDNA());
	}

	public int CompareTo(ObscuredFloat OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(float OBKENFAPMCF)
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
	public static int ALMGKPDPDCH(float EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static float MMNLMLIIDBO(int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredFloat GNMNDOIFIEJ(int OLPGDDPLCHG)
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
