using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredVector3Int : IOGAMCONEIG
{
	[Serializable]
	public struct RawEncryptedVector3Int
	{
		public int x;

		public int y;

		public int z;
	}

	private static readonly Vector3Int Zero = Vector3Int.zero;

	[SerializeField]
	private int currentCryptoKey;

	[SerializeField]
	private RawEncryptedVector3Int hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private Vector3Int fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	public int x
	{
		get
		{
			int num = ObscuredInt.MMNLMLIIDBO(hiddenValue.x, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.x) > 0)
			{
				global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
			}
			return num;
		}
		set
		{
			hiddenValue.x = ObscuredInt.ALMGKPDPDCH(value, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA)
			{
				fakeValue.x = value;
				fakeValue.y = ObscuredInt.MMNLMLIIDBO(hiddenValue.y, currentCryptoKey);
				fakeValue.z = ObscuredInt.MMNLMLIIDBO(hiddenValue.z, currentCryptoKey);
				fakeValueActive = true;
			}
			else
			{
				fakeValueActive = false;
			}
		}
	}

	public int y
	{
		get
		{
			int num = ObscuredInt.MMNLMLIIDBO(hiddenValue.y, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.y) > 0)
			{
				global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
			}
			return num;
		}
		set
		{
			hiddenValue.y = ObscuredInt.ALMGKPDPDCH(value, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA)
			{
				fakeValue.x = ObscuredInt.MMNLMLIIDBO(hiddenValue.x, currentCryptoKey);
				fakeValue.y = value;
				fakeValue.z = ObscuredInt.MMNLMLIIDBO(hiddenValue.z, currentCryptoKey);
				fakeValueActive = true;
			}
			else
			{
				fakeValueActive = false;
			}
		}
	}

	public int z
	{
		get
		{
			int num = ObscuredInt.MMNLMLIIDBO(hiddenValue.z, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.z) > 0)
			{
				global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
			}
			return num;
		}
		set
		{
			hiddenValue.z = ObscuredInt.ALMGKPDPDCH(value, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA)
			{
				fakeValue.x = ObscuredInt.MMNLMLIIDBO(hiddenValue.x, currentCryptoKey);
				fakeValue.y = ObscuredInt.MMNLMLIIDBO(hiddenValue.y, currentCryptoKey);
				fakeValue.z = value;
				fakeValueActive = true;
			}
			else
			{
				fakeValueActive = false;
			}
		}
	}

	public int this[int JNDABHCJHHD]
	{
		get
		{
			return JNDABHCJHHD switch
			{
				0 => x, 
				1 => y, 
				2 => z, 
				_ => throw new IndexOutOfRangeException("Invalid ObscuredVector3Int index!"), 
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
				throw new IndexOutOfRangeException("Invalid ObscuredVector3Int index!");
			}
		}
	}

	private ObscuredVector3Int(Vector3Int EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? Zero : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public ObscuredVector3Int(int HKCJBFIKALL, int PIFPICMFHAD, int CDMFIAGPLDN)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(HKCJBFIKALL, PIFPICMFHAD, CDMFIAGPLDN, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValue = new Vector3Int
			{
				x = HKCJBFIKALL,
				y = PIFPICMFHAD,
				z = CDMFIAGPLDN
			};
			fakeValueActive = true;
		}
		else
		{
			fakeValue = Zero;
			fakeValueActive = false;
		}
		inited = true;
	}

	public static RawEncryptedVector3Int ALMGKPDPDCH(Vector3Int EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return ALMGKPDPDCH(EHAPKEKPMOE.x, EHAPKEKPMOE.y, EHAPKEKPMOE.z, JPBEBBODCJJ);
	}

	public static RawEncryptedVector3Int ALMGKPDPDCH(int HKCJBFIKALL, int PIFPICMFHAD, int CDMFIAGPLDN, int JPBEBBODCJJ)
	{
		RawEncryptedVector3Int result = default(RawEncryptedVector3Int);
		result.x = ObscuredInt.ALMGKPDPDCH(HKCJBFIKALL, JPBEBBODCJJ);
		result.y = ObscuredInt.ALMGKPDPDCH(PIFPICMFHAD, JPBEBBODCJJ);
		result.z = ObscuredInt.ALMGKPDPDCH(CDMFIAGPLDN, JPBEBBODCJJ);
		return result;
	}

	public static Vector3Int MMNLMLIIDBO(RawEncryptedVector3Int EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		Vector3Int result = default(Vector3Int);
		result.x = ObscuredInt.MMNLMLIIDBO(EHAPKEKPMOE.x, JPBEBBODCJJ);
		result.y = ObscuredInt.MMNLMLIIDBO(EHAPKEKPMOE.y, JPBEBBODCJJ);
		result.z = ObscuredInt.MMNLMLIIDBO(EHAPKEKPMOE.z, JPBEBBODCJJ);
		return result;
	}

	public static ObscuredVector3Int GNMNDOIFIEJ(RawEncryptedVector3Int OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		ObscuredVector3Int result = default(ObscuredVector3Int);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static int GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LDCFDMADKJP();
	}

	public RawEncryptedVector3Int LOELJHDFOGP(out int JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(RawEncryptedVector3Int OLPGDDPLCHG, int JPBEBBODCJJ)
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

	public Vector3Int KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		Vector3Int eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private Vector3Int LHONECCIDNA()
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
		Vector3Int vector3Int = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && vector3Int != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return vector3Int;
	}

	[SpecialName]
	public static ObscuredVector3Int FNIPJFGEFFD(Vector3Int EHAPKEKPMOE)
	{
		return new ObscuredVector3Int(EHAPKEKPMOE);
	}

	[SpecialName]
	public static Vector3Int FNIPJFGEFFD(ObscuredVector3Int EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static Vector3 FNIPJFGEFFD(ObscuredVector3Int EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static ObscuredVector3Int HGADPBHCGCI(ObscuredVector3Int AEMBPMJMOAB, ObscuredVector3Int LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() + LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3Int HGADPBHCGCI(Vector3Int AEMBPMJMOAB, ObscuredVector3Int LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB + LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3Int HGADPBHCGCI(ObscuredVector3Int AEMBPMJMOAB, Vector3Int LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() + LCBKHLLPIGM);
	}

	[SpecialName]
	public static ObscuredVector3Int GAIIFHAAPIJ(ObscuredVector3Int AEMBPMJMOAB, ObscuredVector3Int LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() - LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3Int GAIIFHAAPIJ(Vector3Int AEMBPMJMOAB, ObscuredVector3Int LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB - LCBKHLLPIGM.LHONECCIDNA());
	}

	[SpecialName]
	public static ObscuredVector3Int GAIIFHAAPIJ(ObscuredVector3Int AEMBPMJMOAB, Vector3Int LCBKHLLPIGM)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() - LCBKHLLPIGM);
	}

	[SpecialName]
	public static ObscuredVector3Int NGKKANMMHNJ(ObscuredVector3Int AEMBPMJMOAB, int CPFJBOMGNBF)
	{
		return FNIPJFGEFFD(AEMBPMJMOAB.LHONECCIDNA() * CPFJBOMGNBF);
	}

	[SpecialName]
	public static bool JHLIPNMGNGC(ObscuredVector3Int MPJIEHGPGLL, ObscuredVector3Int OBLIHELAPMM)
	{
		return MPJIEHGPGLL.LHONECCIDNA() == OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JHLIPNMGNGC(Vector3Int MPJIEHGPGLL, ObscuredVector3Int OBLIHELAPMM)
	{
		return MPJIEHGPGLL == OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JHLIPNMGNGC(ObscuredVector3Int MPJIEHGPGLL, Vector3Int OBLIHELAPMM)
	{
		return MPJIEHGPGLL.LHONECCIDNA() == OBLIHELAPMM;
	}

	[SpecialName]
	public static bool JNBCJBNOFDH(ObscuredVector3Int MPJIEHGPGLL, ObscuredVector3Int OBLIHELAPMM)
	{
		return MPJIEHGPGLL.LHONECCIDNA() != OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JNBCJBNOFDH(Vector3Int MPJIEHGPGLL, ObscuredVector3Int OBLIHELAPMM)
	{
		return MPJIEHGPGLL != OBLIHELAPMM.LHONECCIDNA();
	}

	[SpecialName]
	public static bool JNBCJBNOFDH(ObscuredVector3Int MPJIEHGPGLL, Vector3Int OBLIHELAPMM)
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
	public static RawEncryptedVector3Int ALMGKPDPDCH(Vector3Int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static Vector3Int MMNLMLIIDBO(RawEncryptedVector3Int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public RawEncryptedVector3Int LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(RawEncryptedVector3Int OLPGDDPLCHG)
	{
	}
}
