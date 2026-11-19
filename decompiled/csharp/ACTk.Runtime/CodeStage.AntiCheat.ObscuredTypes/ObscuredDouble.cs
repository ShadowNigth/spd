using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredDouble : IOGAMCONEIG, IFormattable, IEquatable<ObscuredDouble>, IComparable<ObscuredDouble>, IComparable<double>, IComparable
{
	[StructLayout(LayoutKind.Explicit)]
	private struct BHDEHOJCCEK
	{
		[FieldOffset(0)]
		internal double CPFJBOMGNBF;

		[FieldOffset(0)]
		internal long BCHJGIJOPFN;

		[FieldOffset(0)]
		internal ACTkByte8 OFHICGFHBFJ;

		internal static long OKHLHAOOOAP(long EHAPKEKPMOE, byte EHHIDOPHKKO, byte DPPALFLEBJG)
		{
			BHDEHOJCCEK bHDEHOJCCEK = HJFJILAJEBJ(EHAPKEKPMOE);
			if (EHHIDOPHKKO < 2 && DPPALFLEBJG == 2)
			{
				bHDEHOJCCEK.OFHICGFHBFJ.IINPFBMPOHF();
			}
			return bHDEHOJCCEK.BCHJGIJOPFN;
		}

		internal static long DNHEGLNKINK(double EHAPKEKPMOE, long JPBEBBODCJJ)
		{
			return ILHEENJNIJJ(EHAPKEKPMOE).IINPFBMPOHF(JPBEBBODCJJ).BCHJGIJOPFN;
		}

		internal static double NFJPFBCEIAN(long EHAPKEKPMOE, long JPBEBBODCJJ)
		{
			return HJFJILAJEBJ(EHAPKEKPMOE).KIFEICJLOFN(JPBEBBODCJJ).CPFJBOMGNBF;
		}

		private static BHDEHOJCCEK ILHEENJNIJJ(double EHAPKEKPMOE)
		{
			BHDEHOJCCEK result = default(BHDEHOJCCEK);
			result.CPFJBOMGNBF = EHAPKEKPMOE;
			return result;
		}

		private static BHDEHOJCCEK HJFJILAJEBJ(long EHAPKEKPMOE)
		{
			BHDEHOJCCEK result = default(BHDEHOJCCEK);
			result.BCHJGIJOPFN = EHAPKEKPMOE;
			return result;
		}

		private BHDEHOJCCEK IINPFBMPOHF(long JPBEBBODCJJ)
		{
			BCHJGIJOPFN ^= JPBEBBODCJJ;
			OFHICGFHBFJ.IINPFBMPOHF();
			return this;
		}

		private BHDEHOJCCEK KIFEICJLOFN(long JPBEBBODCJJ)
		{
			OFHICGFHBFJ.KIFEICJLOFN();
			BCHJGIJOPFN ^= JPBEBBODCJJ;
			return this;
		}
	}

	[SerializeField]
	private long currentCryptoKey;

	[SerializeField]
	private long hiddenValue;

	[SerializeField]
	[FormerlySerializedAs("hiddenValue")]
	private ACTkByte8 hiddenValueOldByte8;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private double fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredDouble(double EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		hiddenValueOldByte8 = default(ACTkByte8);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? 0.0 : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public static long ALMGKPDPDCH(double EHAPKEKPMOE, long JPBEBBODCJJ)
	{
		return BHDEHOJCCEK.DNHEGLNKINK(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	public static double MMNLMLIIDBO(long EHAPKEKPMOE, long JPBEBBODCJJ)
	{
		return BHDEHOJCCEK.NFJPFBCEIAN(EHAPKEKPMOE, JPBEBBODCJJ);
	}

	public static long NJLOHHJHDKF(long OLPGDDPLCHG, byte EHHIDOPHKKO = 0, byte DPPALFLEBJG = 2)
	{
		return BHDEHOJCCEK.OKHLHAOOOAP(OLPGDDPLCHG, EHHIDOPHKKO, DPPALFLEBJG);
	}

	public static ObscuredDouble GNMNDOIFIEJ(long OLPGDDPLCHG, long JPBEBBODCJJ)
	{
		ObscuredDouble result = default(ObscuredDouble);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static long GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.JDMIDOCOJPL();
	}

	public long LOELJHDFOGP(out long JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(long OLPGDDPLCHG, long JPBEBBODCJJ)
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

	public double KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		double eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private double LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(0.0, currentCryptoKey);
			fakeValue = 0.0;
			fakeValueActive = false;
			inited = true;
			return 0.0;
		}
		double num = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue) > global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.OJIJHMNKGIP)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return num;
	}

	[SpecialName]
	public static ObscuredDouble FNIPJFGEFFD(double EHAPKEKPMOE)
	{
		return new ObscuredDouble(EHAPKEKPMOE);
	}

	[SpecialName]
	public static double FNIPJFGEFFD(ObscuredDouble EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredDouble JDBGCLLOGHJ(ObscuredFloat GHJBEEBMOKB)
	{
		return FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(GHJBEEBMOKB));
	}

	[SpecialName]
	public static ObscuredDouble JKKOEENGPLM(ObscuredDouble MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, 1.0);
	}

	[SpecialName]
	public static ObscuredDouble LNCBKFJDIII(ObscuredDouble MMKMICOONDG)
	{
		return EJFCEMCFONM(MMKMICOONDG, -1.0);
	}

	private static ObscuredDouble EJFCEMCFONM(ObscuredDouble MMKMICOONDG, double NDDHOAFLDNE)
	{
		double eHAPKEKPMOE = MMKMICOONDG.LHONECCIDNA() + NDDHOAFLDNE;
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
		return FFBEPGEKANM is ObscuredDouble && Equals((ObscuredDouble)FFBEPGEKANM);
	}

	public bool Equals(ObscuredDouble FFBEPGEKANM)
	{
		return FFBEPGEKANM.LHONECCIDNA().Equals(LHONECCIDNA());
	}

	public int CompareTo(ObscuredDouble OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF.LHONECCIDNA());
	}

	public int CompareTo(double OBKENFAPMCF)
	{
		return LHONECCIDNA().CompareTo(OBKENFAPMCF);
	}

	public int CompareTo(object FFBEPGEKANM)
	{
		return LHONECCIDNA().CompareTo(FFBEPGEKANM);
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(long AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static long ALMGKPDPDCH(double EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static double MMNLMLIIDBO(long EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
	public static ObscuredDouble GNMNDOIFIEJ(long OLPGDDPLCHG)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public long LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(long OLPGDDPLCHG)
	{
	}
}
