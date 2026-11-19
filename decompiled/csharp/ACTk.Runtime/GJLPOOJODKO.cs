using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
[AddComponentMenu("")]
public class GJLPOOJODKO : global::FOKPNHICOOH<GJLPOOJODKO>
{
	private static bool BCEBFDPCLIA;

	private static bool HCPCMLOGOGL;

	private static float IIMLFMKIIGK;

	private static float MLDHADGKGAN;

	private static float GPKHIBBHJEI;

	private static float INENOLAADHK;

	private static float DOBMGKDKBDD;

	private static float FDOAKNDMKJH;

	private static bool CHFONMFBOHD;

	private long KBKHEFNGJME;

	private long CFJMGCLFLEJ;

	private long EGKMLGGMCMJ;

	public static float HLOAPHLPNJG
	{
		get
		{
			if (!BCEBFDPCLIA)
			{
				HIBHJDCMMAJ();
			}
			return (!HCPCMLOGOGL) ? Time.time : IIMLFMKIIGK;
		}
	}

	public static float OJIAODEDJLC
	{
		get
		{
			if (!BCEBFDPCLIA)
			{
				HIBHJDCMMAJ();
			}
			return (!HCPCMLOGOGL) ? Time.unscaledTime : GPKHIBBHJEI;
		}
	}

	public static float EPOKGKJCOAF
	{
		get
		{
			if (!BCEBFDPCLIA)
			{
				HIBHJDCMMAJ();
			}
			return (!HCPCMLOGOGL) ? Time.deltaTime : MLDHADGKGAN;
		}
	}

	public static float FIIPKBLJBNH
	{
		get
		{
			if (!BCEBFDPCLIA)
			{
				HIBHJDCMMAJ();
			}
			return (!HCPCMLOGOGL) ? Time.unscaledDeltaTime : INENOLAADHK;
		}
	}

	public static float BICMEDNKPHB
	{
		get
		{
			if (!BCEBFDPCLIA)
			{
				HIBHJDCMMAJ();
			}
			return (!HCPCMLOGOGL) ? Time.realtimeSinceStartup : DOBMGKDKBDD;
		}
	}

	public static float LIFMJBFNOLA
	{
		get
		{
			if (!BCEBFDPCLIA)
			{
				HIBHJDCMMAJ();
			}
			return (!HCPCMLOGOGL) ? Time.timeSinceLevelLoad : FDOAKNDMKJH;
		}
	}

	protected override string NBJPADKALNN()
	{
		return "SpeedHackProofTime";
	}

	private void Update()
	{
		if (!HCPCMLOGOGL)
		{
			BDAGCNNJAIM();
			return;
		}
		KBKHEFNGJME = PMPJFHOABPI.DPIIFADDFNL();
		EGKMLGGMCMJ = KBKHEFNGJME - CFJMGCLFLEJ;
		FJLGNIBBLPJ();
	}

	public static void HIBHJDCMMAJ()
	{
		BCEBFDPCLIA = global::FOKPNHICOOH<GJLPOOJODKO>.AAANLLGDCHM.GHECNMHOOLM();
	}

	public static void MABNJHGIDLH()
	{
		BCEBFDPCLIA = false;
		if (!(global::FOKPNHICOOH<GJLPOOJODKO>.KHGDLGJPCCA == null))
		{
			ALFOCCGOKEK aLFOCCGOKEK = global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA;
			if (aLFOCCGOKEK != null)
			{
				aLFOCCGOKEK.BJAAEHCDEFB -= global::FOKPNHICOOH<GJLPOOJODKO>.KHGDLGJPCCA.PIGMPKMALGJ;
			}
			Object.Destroy(global::FOKPNHICOOH<GJLPOOJODKO>.KHGDLGJPCCA.gameObject);
		}
	}

	private bool GHECNMHOOLM()
	{
		ALFOCCGOKEK aLFOCCGOKEK = global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA;
		if (aLFOCCGOKEK == null)
		{
			if (!CHFONMFBOHD)
			{
				Debug.LogWarning("[ACTk] Can't initialize SpeedHackProofTime class since it requires running SpeedHackDetector instance which was not found. Did you started SpeedHackDetector before using SpeedHackProofTime?\nSpeedHackProofTime will use unreliable vanilla Time.* APIs until you start SpeedHackDetector.");
				CHFONMFBOHD = true;
			}
			return false;
		}
		if (!aLFOCCGOKEK.MNDFOKODEPL)
		{
			if (!CHFONMFBOHD)
			{
				Debug.LogWarning("[ACTk] Can't initialize SpeedHackProofTime class since it requires running SpeedHackDetector instance but only idle instance was found. Did you started SpeedHackDetector before using SpeedHackProofTime?\nSpeedHackProofTime will use unreliable vanilla Time.* APIs until you start SpeedHackDetector.");
				CHFONMFBOHD = true;
			}
			return false;
		}
		aLFOCCGOKEK.BJAAEHCDEFB += PIGMPKMALGJ;
		return true;
	}

	private void BDAGCNNJAIM()
	{
		IIMLFMKIIGK = Time.time;
		MLDHADGKGAN = Time.deltaTime;
		GPKHIBBHJEI = Time.unscaledTime;
		INENOLAADHK = Time.unscaledDeltaTime;
		FDOAKNDMKJH = Time.timeSinceLevelLoad;
		DOBMGKDKBDD = Time.realtimeSinceStartup;
	}

	private void FJLGNIBBLPJ()
	{
		CFJMGCLFLEJ = KBKHEFNGJME;
		INENOLAADHK = (float)EGKMLGGMCMJ / 10000000f;
		MLDHADGKGAN = INENOLAADHK * Time.timeScale;
		IIMLFMKIIGK += MLDHADGKGAN;
		GPKHIBBHJEI += INENOLAADHK;
		DOBMGKDKBDD += INENOLAADHK;
		FDOAKNDMKJH += MLDHADGKGAN;
	}

	private void PIGMPKMALGJ()
	{
		HCPCMLOGOGL = true;
		CFJMGCLFLEJ = PMPJFHOABPI.DPIIFADDFNL();
	}

	protected override void DHEAKJLMOON(Scene AIHHFDJKLNO, LoadSceneMode PGCIDPHOAEC)
	{
		base.DHEAKJLMOON(AIHHFDJKLNO, PGCIDPHOAEC);
		FDOAKNDMKJH = 0f;
	}
}
