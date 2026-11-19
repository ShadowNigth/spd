using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredVector2 : IOGAMCONEIG
{
	[Serializable]
	public struct RawEncryptedVector2
	{
		public int x;

		public int y;
	}

	private static readonly Vector2 Zero = Vector2.zero;

	[SerializeField]
	private int currentCryptoKey;

	[SerializeField]
	private RawEncryptedVector2 hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private Vector2 fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	public float x
	{
		get
		{
			float num = ObscuredFloat.MMNLMLIIDBO(hiddenValue.x, currentCryptoKey);
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.x) > global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HGJGIKJOMLL)
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
			if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && Math.Abs(num - fakeValue.y) > global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HGJGIKJOMLL)
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
				_ => throw new IndexOutOfRangeException("Invalid ObscuredVector2 index!"), 
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
				throw new IndexOutOfRangeException("Invalid ObscuredVector2 index!");
			}
		}
	}

	private ObscuredVector2(Vector2 EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? Zero : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public ObscuredVector2(float HKCJBFIKALL, float PIFPICMFHAD)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(HKCJBFIKALL, PIFPICMFHAD, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValue = new Vector2(HKCJBFIKALL, PIFPICMFHAD);
			fakeValueActive = true;
		}
		else
		{
			fakeValue = Zero;
			fakeValueActive = false;
		}
		inited = true;
	}

	public static RawEncryptedVector2 ALMGKPDPDCH(Vector2 EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return ALMGKPDPDCH(EHAPKEKPMOE.x, EHAPKEKPMOE.y, JPBEBBODCJJ);
	}

	public static RawEncryptedVector2 ALMGKPDPDCH(float HKCJBFIKALL, float PIFPICMFHAD, int JPBEBBODCJJ)
	{
		RawEncryptedVector2 result = default(RawEncryptedVector2);
		result.x = ObscuredFloat.ALMGKPDPDCH(HKCJBFIKALL, JPBEBBODCJJ);
		result.y = ObscuredFloat.ALMGKPDPDCH(PIFPICMFHAD, JPBEBBODCJJ);
		return result;
	}

	public static Vector2 MMNLMLIIDBO(RawEncryptedVector2 EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		Vector2 result = default(Vector2);
		result.x = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.x, JPBEBBODCJJ);
		result.y = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.y, JPBEBBODCJJ);
		return result;
	}

	public static ObscuredVector2 GNMNDOIFIEJ(RawEncryptedVector2 OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		ObscuredVector2 result = default(ObscuredVector2);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static int GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LDCFDMADKJP();
	}

	private static bool DBOPJLNDDJL(Vector2 GIABFMFLKJA, Vector2 LOEGOBJONHD)
	{
		float hGJGIKJOMLL = global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HGJGIKJOMLL;
		return Math.Abs(GIABFMFLKJA.x - LOEGOBJONHD.x) < hGJGIKJOMLL && Math.Abs(GIABFMFLKJA.y - LOEGOBJONHD.y) < hGJGIKJOMLL;
	}

	public RawEncryptedVector2 LOELJHDFOGP(out int JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(RawEncryptedVector2 OLPGDDPLCHG, int JPBEBBODCJJ)
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

	public Vector2 KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		Vector2 eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private Vector2 LHONECCIDNA()
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
		Vector2 vector = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && !DBOPJLNDDJL(vector, fakeValue))
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return vector;
	}

	[SpecialName]
	public static ObscuredVector2 FNIPJFGEFFD(Vector2 EHAPKEKPMOE)
	{
		return new ObscuredVector2(EHAPKEKPMOE);
	}

	[SpecialName]
	public static Vector2 FNIPJFGEFFD(ObscuredVector2 EHAPKEKPMOE)
	{
		return EHAPKEKPMOE.LHONECCIDNA();
	}

	[SpecialName]
	public static Vector3 FNIPJFGEFFD(ObscuredVector2 EHAPKEKPMOE)
	{
		Vector2 vector = EHAPKEKPMOE.LHONECCIDNA();
		return new Vector3(vector.x, vector.y, 0f);
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
	public static RawEncryptedVector2 ALMGKPDPDCH(Vector2 EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static Vector2 MMNLMLIIDBO(RawEncryptedVector2 EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public RawEncryptedVector2 LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(RawEncryptedVector2 OLPGDDPLCHG)
	{
	}
}
