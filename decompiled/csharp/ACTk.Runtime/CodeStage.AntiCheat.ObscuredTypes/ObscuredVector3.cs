using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredVector3 : IOGAMCONEIG
{
	[Serializable]
	public struct RawEncryptedVector3
	{
		public int x;

		public int y;

		public int z;
	}

	private static readonly Vector3 Zero = Vector3.zero;

	[SerializeField]
	private int currentCryptoKey;

	[SerializeField]
	private RawEncryptedVector3 hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private Vector3 fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	public float x
	{
		get
		{
			float num = ObscuredFloat.MMNLMLIIDBO(hiddenValue.x, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.x) > global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.BOBIFNGMPOI)
			{
				global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
			}
			return num;
		}
		set
		{
			hiddenValue.x = ObscuredFloat.ALMGKPDPDCH(value, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA)
			{
				fakeValue.x = value;
				fakeValue.y = ObscuredFloat.MMNLMLIIDBO(hiddenValue.y, currentCryptoKey);
				fakeValue.z = ObscuredFloat.MMNLMLIIDBO(hiddenValue.z, currentCryptoKey);
				fakeValueActive = true;
			}
			else
			{
				fakeValueActive = false;
			}
		}
	}

	public float y
	{
		get
		{
			float num = ObscuredFloat.MMNLMLIIDBO(hiddenValue.y, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.y) > global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.BOBIFNGMPOI)
			{
				global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
			}
			return num;
		}
		set
		{
			hiddenValue.y = ObscuredFloat.ALMGKPDPDCH(value, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA)
			{
				fakeValue.x = ObscuredFloat.MMNLMLIIDBO(hiddenValue.x, currentCryptoKey);
				fakeValue.y = value;
				fakeValue.z = ObscuredFloat.MMNLMLIIDBO(hiddenValue.z, currentCryptoKey);
				fakeValueActive = true;
			}
			else
			{
				fakeValueActive = false;
			}
		}
	}

	public float z
	{
		get
		{
			float num = ObscuredFloat.MMNLMLIIDBO(hiddenValue.z, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.z) > global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.BOBIFNGMPOI)
			{
				global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
			}
			return num;
		}
		set
		{
			hiddenValue.z = ObscuredFloat.ALMGKPDPDCH(value, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA)
			{
				fakeValue.x = ObscuredFloat.MMNLMLIIDBO(hiddenValue.x, currentCryptoKey);
				fakeValue.y = ObscuredFloat.MMNLMLIIDBO(hiddenValue.y, currentCryptoKey);
				fakeValue.z = value;
				fakeValueActive = true;
			}
			else
			{
				fakeValueActive = false;
			}
		}
	}

	public float this[int JNDABHCJHHD]
	{
		get
		{
			return JNDABHCJHHD switch
			{
				0 => x, 
				1 => y, 
				2 => z, 
				_ => throw new IndexOutOfRangeException("Invalid ObscuredVector3 index!"), 
			};
		}
		set
		{
			switch (JNDABHCJHHD)
			{
			case 0:
				x = value;
				break;
			case 1:
				y = value;
				break;
			case 2:
				z = value;
				break;
			default:
				throw new IndexOutOfRangeException("Invalid ObscuredVector3 index!");
			}
		}
	}

	private ObscuredVector3(Vector3 EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? Zero : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public ObscuredVector3(float HKCJBFIKALL, float PIFPICMFHAD, float CDMFIAGPLDN)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(HKCJBFIKALL, PIFPICMFHAD, CDMFIAGPLDN, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValue = new Vector3(HKCJBFIKALL, PIFPICMFHAD, CDMFIAGPLDN);
			fakeValueActive = true;
		}
		else
		{
			fakeValue = Zero;
			fakeValueActive = false;
		}
		inited = true;
	}

	public static RawEncryptedVector3 ALMGKPDPDCH(Vector3 EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return ALMGKPDPDCH(EHAPKEKPMOE.x, EHAPKEKPMOE.y, EHAPKEKPMOE.z, JPBEBBODCJJ);
	}

	public static RawEncryptedVector3 ALMGKPDPDCH(float HKCJBFIKALL, float PIFPICMFHAD, float CDMFIAGPLDN, int JPBEBBODCJJ)
	{
		RawEncryptedVector3 result = default(RawEncryptedVector3);
		result.x = ObscuredFloat.ALMGKPDPDCH(HKCJBFIKALL, JPBEBBODCJJ);
		result.y = ObscuredFloat.ALMGKPDPDCH(PIFPICMFHAD, JPBEBBODCJJ);
		result.z = ObscuredFloat.ALMGKPDPDCH(CDMFIAGPLDN, JPBEBBODCJJ);
		return result;
	}

	public static Vector3 MMNLMLIIDBO(RawEncryptedVector3 EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		Vector3 result = default(Vector3);
		result.x = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.x, JPBEBBODCJJ);
		result.y = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.y, JPBEBBODCJJ);
		result.z = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.z, JPBEBBODCJJ);
		return result;
	}

	public static ObscuredVector3 GNMNDOIFIEJ(RawEncryptedVector3 OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		ObscuredVector3 result = default(ObscuredVector3);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static int GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LDCFDMADKJP();
	}

	private static bool DBOPJLNDDJL(Vector3 GIABFMFLKJA, Vector3 LOEGOBJONHD)
	{
		float bOBIFNGMPOI = global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.BOBIFNGMPOI;
		return Math.Abs(GIABFMFLKJA.x - LOEGOBJONHD.x) < bOBIFNGMPOI && Math.Abs(GIABFMFLKJA.y - LOEGOBJONHD.y) < bOBIFNGMPOI && Math.Abs(GIABFMFLKJA.z - LOEGOBJONHD.z) < bOBIFNGMPOI;
	}

	public RawEncryptedVector3 LOELJHDFOGP(out int JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(RawEncryptedVector3 OLPGDDPLCHG, int JPBEBBODCJJ)
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

	public Vector3 KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		Vector3 eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private Vector3 LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(Zero, currentCryptoKey);
			fakeValue = Zero;
			fakeValueActive = false;
			inited = true;
			return Zero;
		}
		Vector3 vector = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && !DBOPJLNDDJL(vector, fakeValue))
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return vector;
	}

	[SpecialName]
	public static ObscuredVector3 FNIPJFGEFFD(Vector3 EHAPKEKPMOE)
	{
		return new ObscuredVector3(EHAPKEKPMOE);
	}

	[SpecialName]
	public static Vector3 FNIPJFGEFFD(ObscuredVector3 EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredVector3 HGADPBHCGCI(ObscuredVector3 AEMBPMJMOAB, ObscuredVector3 LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() + LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3 HGADPBHCGCI(Vector3 AEMBPMJMOAB, ObscuredVector3 LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB + LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3 HGADPBHCGCI(ObscuredVector3 AEMBPMJMOAB, Vector3 LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() + LCBKHLLPIGM);
	}

	[SpecialName]
	public static ObscuredVector3 GAIIFHAAPIJ(ObscuredVector3 AEMBPMJMOAB, ObscuredVector3 LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() - LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3 GAIIFHAAPIJ(Vector3 AEMBPMJMOAB, ObscuredVector3 LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB - LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3 GAIIFHAAPIJ(ObscuredVector3 AEMBPMJMOAB, Vector3 LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() - LCBKHLLPIGM);
	}

	[SpecialName]
	public static ObscuredVector3 PAPIMAAOJBP(ObscuredVector3 AEMBPMJMOAB)
	{
		return FNIPJFGEFFD(-AEMBPMJMOAB.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3 NGKKANMMHNJ(ObscuredVector3 AEMBPMJMOAB, float CPFJBOMGNBF)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() * CPFJBOMGNBF);
	}

	[SpecialName]
	public static ObscuredVector3 NGKKANMMHNJ(float CPFJBOMGNBF, ObscuredVector3 AEMBPMJMOAB)
	{
		return FNIPJFGEFFD(CPFJBOMGNBF * AEMBPMJMOAB.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3 HHBEPBIGHBP(ObscuredVector3 AEMBPMJMOAB, float CPFJBOMGNBF)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() / CPFJBOMGNBF);
	}

	[SpecialName]
	public static bool JHLIPNMGNGC(ObscuredVector3 MPJIEHGPGLL, ObscuredVector3 OBLIHELAPMM)
	{
		return MPJIEHGPGLL.LHONECCIDNA() == OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JHLIPNMGNGC(Vector3 MPJIEHGPGLL, ObscuredVector3 OBLIHELAPMM)
	{
		return MPJIEHGPGLL == OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JHLIPNMGNGC(ObscuredVector3 MPJIEHGPGLL, Vector3 OBLIHELAPMM)
	{
		return MPJIEHGPGLL.LHONECCIDNA() == OBLIHELAPMM;
	}

	[SpecialName]
	public static bool JNBCJBNOFDH(ObscuredVector3 MPJIEHGPGLL, ObscuredVector3 OBLIHELAPMM)
	{
		return MPJIEHGPGLL.LHONECCIDNA() != OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JNBCJBNOFDH(Vector3 MPJIEHGPGLL, ObscuredVector3 OBLIHELAPMM)
	{
		return MPJIEHGPGLL != OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JNBCJBNOFDH(ObscuredVector3 MPJIEHGPGLL, Vector3 OBLIHELAPMM)
	{
		return MPJIEHGPGLL.LHONECCIDNA() != OBLIHELAPMM;
	}

	public override bool Equals(object OBKENFAPMCF)
	{
		return LHONECCIDNA().Equals(OBKENFAPMCF);
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

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(int AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static RawEncryptedVector3 ALMGKPDPDCH(Vector3 EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static Vector3 MMNLMLIIDBO(RawEncryptedVector3 EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public RawEncryptedVector3 LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(RawEncryptedVector3 OLPGDDPLCHG)
	{
	}
}
