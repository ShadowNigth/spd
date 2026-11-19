using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredVector2Int : IOGAMCONEIG
{
	[Serializable]
	public struct RawEncryptedVector2Int
	{
		public int x;

		public int y;
	}

	private static readonly Vector2Int Zero = Vector2Int.zero;

	[SerializeField]
	private int currentCryptoKey;

	[SerializeField]
	private RawEncryptedVector2Int hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private Vector2Int fakeValue;

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
				_ => throw new IndexOutOfRangeException("Invalid ObscuredVector2Int index!"), 
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
			default:
				throw new IndexOutOfRangeException("Invalid ObscuredVector2Int index!");
			}
		}
	}

	private ObscuredVector2Int(Vector2Int EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? Zero : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public ObscuredVector2Int(int HKCJBFIKALL, int PIFPICMFHAD)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(HKCJBFIKALL, PIFPICMFHAD, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValue = new Vector2Int(HKCJBFIKALL, PIFPICMFHAD);
			fakeValueActive = true;
		}
		else
		{
			fakeValue = Zero;
			fakeValueActive = false;
		}
		inited = true;
	}

	public static RawEncryptedVector2Int ALMGKPDPDCH(Vector2Int EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return ALMGKPDPDCH(EHAPKEKPMOE.x, EHAPKEKPMOE.y, JPBEBBODCJJ);
	}

	public static RawEncryptedVector2Int ALMGKPDPDCH(int HKCJBFIKALL, int PIFPICMFHAD, int JPBEBBODCJJ)
	{
		RawEncryptedVector2Int result = default(RawEncryptedVector2Int);
		result.x = ObscuredInt.ALMGKPDPDCH(HKCJBFIKALL, JPBEBBODCJJ);
		result.y = ObscuredInt.ALMGKPDPDCH(PIFPICMFHAD, JPBEBBODCJJ);
		return result;
	}

	public static Vector2Int MMNLMLIIDBO(RawEncryptedVector2Int EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		Vector2Int result = default(Vector2Int);
		result.x = ObscuredInt.MMNLMLIIDBO(EHAPKEKPMOE.x, JPBEBBODCJJ);
		result.y = ObscuredInt.MMNLMLIIDBO(EHAPKEKPMOE.y, JPBEBBODCJJ);
		return result;
	}

	public static ObscuredVector2Int GNMNDOIFIEJ(RawEncryptedVector2Int OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		ObscuredVector2Int result = default(ObscuredVector2Int);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static int GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LDCFDMADKJP();
	}

	public RawEncryptedVector2Int LOELJHDFOGP(out int JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(RawEncryptedVector2Int OLPGDDPLCHG, int JPBEBBODCJJ)
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

	public Vector2Int KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		Vector2Int eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private Vector2Int LHONECCIDNA()
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
		Vector2Int vector2Int = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && vector2Int != fakeValue)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return vector2Int;
	}

	[SpecialName]
	public static ObscuredVector2Int FNIPJFGEFFD(Vector2Int EHAPKEKPMOE)
	{
		return new ObscuredVector2Int(EHAPKEKPMOE);
	}

	[SpecialName]
	public static Vector2Int FNIPJFGEFFD(ObscuredVector2Int EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static Vector2 FNIPJFGEFFD(ObscuredVector2Int EHAPKEKPMOE)
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

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public static void BFFFOGDECJG(int AGBMLNDFAKC)
	{
	}

	[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
	public void PCAPKLHAAIL()
	{
	}

	[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
	public static RawEncryptedVector2Int ALMGKPDPDCH(Vector2Int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static Vector2Int MMNLMLIIDBO(RawEncryptedVector2Int EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public RawEncryptedVector2Int LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(RawEncryptedVector2Int OLPGDDPLCHG)
	{
	}
}
