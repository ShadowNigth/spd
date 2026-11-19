using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct ObscuredQuaternion : IOGAMCONEIG
{
	[Serializable]
	public struct RawEncryptedQuaternion
	{
		public int x;

		public int y;

		public int z;

		public int w;
	}

	private static readonly Quaternion Identity = Quaternion.identity;

	[SerializeField]
	private int currentCryptoKey;

	[SerializeField]
	private RawEncryptedQuaternion hiddenValue;

	[SerializeField]
	private bool inited;

	[SerializeField]
	private Quaternion fakeValue;

	[SerializeField]
	private bool fakeValueActive;

	private ObscuredQuaternion(Quaternion EHAPKEKPMOE)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(EHAPKEKPMOE, currentCryptoKey);
		bool flag = EGIKKDBEKML.LDMDOPOHCHA;
		fakeValue = ((!flag) ? Identity : EHAPKEKPMOE);
		fakeValueActive = flag;
		inited = true;
	}

	public ObscuredQuaternion(float HKCJBFIKALL, float PIFPICMFHAD, float CDMFIAGPLDN, float GDIFBJBOCJM)
	{
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(HKCJBFIKALL, PIFPICMFHAD, CDMFIAGPLDN, GDIFBJBOCJM, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA)
		{
			fakeValue = new Quaternion(HKCJBFIKALL, PIFPICMFHAD, CDMFIAGPLDN, GDIFBJBOCJM);
			fakeValueActive = true;
		}
		else
		{
			fakeValue = Identity;
			fakeValueActive = false;
		}
		inited = true;
	}

	public static RawEncryptedQuaternion ALMGKPDPDCH(Quaternion EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		return ALMGKPDPDCH(EHAPKEKPMOE.x, EHAPKEKPMOE.y, EHAPKEKPMOE.z, EHAPKEKPMOE.w, JPBEBBODCJJ);
	}

	public static RawEncryptedQuaternion ALMGKPDPDCH(float HKCJBFIKALL, float PIFPICMFHAD, float CDMFIAGPLDN, float GDIFBJBOCJM, int JPBEBBODCJJ)
	{
		RawEncryptedQuaternion result = default(RawEncryptedQuaternion);
		result.x = ObscuredFloat.ALMGKPDPDCH(HKCJBFIKALL, JPBEBBODCJJ);
		result.y = ObscuredFloat.ALMGKPDPDCH(PIFPICMFHAD, JPBEBBODCJJ);
		result.z = ObscuredFloat.ALMGKPDPDCH(CDMFIAGPLDN, JPBEBBODCJJ);
		result.w = ObscuredFloat.ALMGKPDPDCH(GDIFBJBOCJM, JPBEBBODCJJ);
		return result;
	}

	public static Quaternion MMNLMLIIDBO(RawEncryptedQuaternion EHAPKEKPMOE, int JPBEBBODCJJ)
	{
		Quaternion result = default(Quaternion);
		result.x = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.x, JPBEBBODCJJ);
		result.y = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.y, JPBEBBODCJJ);
		result.z = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.z, JPBEBBODCJJ);
		result.w = ObscuredFloat.MMNLMLIIDBO(EHAPKEKPMOE.w, JPBEBBODCJJ);
		return result;
	}

	public static ObscuredQuaternion GNMNDOIFIEJ(RawEncryptedQuaternion OLPGDDPLCHG, int JPBEBBODCJJ)
	{
		ObscuredQuaternion result = default(ObscuredQuaternion);
		result.LBHPCBGLHKI(OLPGDDPLCHG, JPBEBBODCJJ);
		return result;
	}

	public static int GPLMLGBLJHH()
	{
		return LFHFAFOPFIO.LDCFDMADKJP();
	}

	private static bool PFPLFKMIOKN(Quaternion GJLKLGGCJFB, Quaternion BHIIFLGNCBJ)
	{
		float dPGDHBGDCMG = global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.DPGDHBGDCMG;
		return Math.Abs(GJLKLGGCJFB.x - BHIIFLGNCBJ.x) < dPGDHBGDCMG && Math.Abs(GJLKLGGCJFB.y - BHIIFLGNCBJ.y) < dPGDHBGDCMG && Math.Abs(GJLKLGGCJFB.z - BHIIFLGNCBJ.z) < dPGDHBGDCMG && Math.Abs(GJLKLGGCJFB.w - BHIIFLGNCBJ.w) < dPGDHBGDCMG;
	}

	public RawEncryptedQuaternion LOELJHDFOGP(out int JPBEBBODCJJ)
	{
		JPBEBBODCJJ = currentCryptoKey;
		return hiddenValue;
	}

	public void LBHPCBGLHKI(RawEncryptedQuaternion OLPGDDPLCHG, int JPBEBBODCJJ)
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

	public Quaternion KODPNIGCJPK()
	{
		return LHONECCIDNA();
	}

	public void FFOIJMJCCEB()
	{
		Quaternion eHAPKEKPMOE = LHONECCIDNA();
		currentCryptoKey = GPLMLGBLJHH();
		hiddenValue = ALMGKPDPDCH(eHAPKEKPMOE, currentCryptoKey);
	}

	private Quaternion LHONECCIDNA()
	{
		if (!inited)
		{
			currentCryptoKey = GPLMLGBLJHH();
			hiddenValue = ALMGKPDPDCH(Identity, currentCryptoKey);
			fakeValue = Identity;
			fakeValueActive = false;
			inited = true;
			return Identity;
		}
		Quaternion quaternion = MMNLMLIIDBO(hiddenValue, currentCryptoKey);
		if (EGIKKDBEKML.LDMDOPOHCHA && fakeValueActive && !PFPLFKMIOKN(quaternion, fakeValue))
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.HENEPAOMHDA();
		}
		return quaternion;
	}

	[SpecialName]
	public static ObscuredQuaternion FNIPJFGEFFD(Quaternion EHAPKEKPMOE)
	{
		return new ObscuredQuaternion(EHAPKEKPMOE);
	}

	[SpecialName]
	public static Quaternion FNIPJFGEFFD(ObscuredQuaternion EHAPKEKPMOE)
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
	public static RawEncryptedQuaternion ALMGKPDPDCH(Quaternion EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
	public static Quaternion MMNLMLIIDBO(RawEncryptedQuaternion EHAPKEKPMOE)
	{
		throw new Exception();
	}

	[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
	public RawEncryptedQuaternion LOELJHDFOGP()
	{
		throw new Exception();
	}

	[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
	public void LBHPCBGLHKI(RawEncryptedQuaternion OLPGDDPLCHG)
	{
	}
}
