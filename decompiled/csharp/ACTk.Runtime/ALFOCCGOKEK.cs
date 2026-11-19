using System;
using UnityEngine;

[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
[DisallowMultipleComponent]
[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_speed_hack_detector.html")]
public class ALFOCCGOKEK : global::OKIEDJFCLOA<ALFOCCGOKEK>
{
	public const string DKKPFCBJAAO = "Speed Hack Detector";

	internal const string ECHFMJKEMLH = "[ACTk] Speed Hack Detector: ";

	[Tooltip("Time (in seconds) between detector checks.")]
	public float NGLNCGJHLEF = 1f;

	[Range(0.05f, 5f)]
	[Tooltip("Allowed speed multiplier threshold. Do not set to too low values (e.g. 0 or 0.00*) since there are timer fluctuations on different hardware.")]
	public float MNBIENILFIB = 0.2f;

	[Tooltip("Maximum false positives count allowed before registering speed hack.")]
	public byte JFDACACAECG = 3;

	[Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
	public int ENFFLFEMCMN = 30;

	private byte DIKMAFJINJO;

	private int PIGFKPCBBHH;

	private long BPDDMAIHCEB;

	private long JCNLBABEAGI;

	private long LDBDNJLMLAA;

	private ALFOCCGOKEK()
	{
	}

	public static ALFOCCGOKEK GFMJMLPFMCH()
	{
		return global::FOKPNHICOOH<ALFOCCGOKEK>.AAANLLGDCHM;
	}

	public static ALFOCCGOKEK DEEHLMMJMLA()
	{
		if (global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA != null)
		{
			return global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA.APJJFPIOGKN(null, global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA.NGLNCGJHLEF, global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA.JFDACACAECG, global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA.ENFFLFEMCMN);
		}
		Debug.LogError("[ACTk] Speed Hack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		return null;
	}

	public static ALFOCCGOKEK DEEHLMMJMLA(Action JLNCPFNPKMM)
	{
		return DEEHLMMJMLA(JLNCPFNPKMM, global::FOKPNHICOOH<ALFOCCGOKEK>.AAANLLGDCHM.NGLNCGJHLEF);
	}

	public static ALFOCCGOKEK DEEHLMMJMLA(Action JLNCPFNPKMM, float NGLNCGJHLEF)
	{
		return DEEHLMMJMLA(JLNCPFNPKMM, NGLNCGJHLEF, global::FOKPNHICOOH<ALFOCCGOKEK>.AAANLLGDCHM.JFDACACAECG);
	}

	public static ALFOCCGOKEK DEEHLMMJMLA(Action JLNCPFNPKMM, float NGLNCGJHLEF, byte JFDACACAECG)
	{
		return DEEHLMMJMLA(JLNCPFNPKMM, NGLNCGJHLEF, JFDACACAECG, global::FOKPNHICOOH<ALFOCCGOKEK>.AAANLLGDCHM.ENFFLFEMCMN);
	}

	public static ALFOCCGOKEK DEEHLMMJMLA(Action JLNCPFNPKMM, float NGLNCGJHLEF, byte JFDACACAECG, int ENFFLFEMCMN)
	{
		return global::FOKPNHICOOH<ALFOCCGOKEK>.AAANLLGDCHM.APJJFPIOGKN(JLNCPFNPKMM, NGLNCGJHLEF, JFDACACAECG, ENFFLFEMCMN);
	}

	public static void PNAGMICMAKL()
	{
		if (global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA.CNIPMALICAE();
		}
	}

	public static void MABNJHGIDLH()
	{
		if (global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<ALFOCCGOKEK>.KHGDLGJPCCA.CBPNHEBFOFH();
		}
	}

	private void OnApplicationPause(bool LPGMIADPAEC)
	{
		if (!LPGMIADPAEC && BFDIKKENINF)
		{
			ONKHGNLNDDK();
		}
	}

	private void Update()
	{
		if (!CDOJMHCPDCB)
		{
			return;
		}
		long num = PMPJFHOABPI.DPIIFADDFNL();
		long num2 = (long)(NGLNCGJHLEF * 10000000f);
		if (num - BPDDMAIHCEB < num2)
		{
			return;
		}
		long num3 = PMPJFHOABPI.KEKPMLAMCCO();
		long num4 = PMPJFHOABPI.LAJHPDKCDOO();
		long num5 = num - BPDDMAIHCEB;
		long num6 = num3 - JCNLBABEAGI;
		double num7 = Math.Abs(1.0 - (double)num6 / (double)num5);
		long num8 = num4 - LDBDNJLMLAA;
		double num9 = Math.Abs(1.0 - (double)num8 / (double)num5);
		bool flag = num7 > (double)MNBIENILFIB;
		bool flag2 = num9 > (double)MNBIENILFIB;
		if (flag || flag2)
		{
			DIKMAFJINJO++;
			if (DIKMAFJINJO > JFDACACAECG)
			{
				HENEPAOMHDA();
			}
			else
			{
				PIGFKPCBBHH = 0;
				ONKHGNLNDDK();
			}
		}
		else if (DIKMAFJINJO > 0 && ENFFLFEMCMN > 0)
		{
			PIGFKPCBBHH++;
			if (PIGFKPCBBHH >= ENFFLFEMCMN)
			{
				DIKMAFJINJO = 0;
			}
		}
		BPDDMAIHCEB = num;
		JCNLBABEAGI = num3;
		LDBDNJLMLAA = num4;
	}

	private ALFOCCGOKEK APJJFPIOGKN(Action JLNCPFNPKMM, float DEHLOLLDGHL, byte IFPDPLOIEEM, int KOAHDNDINHB)
	{
		if (CDOJMHCPDCB)
		{
			Debug.LogWarning("[ACTk] Speed Hack Detector: already running!", this);
			return this;
		}
		if (!base.enabled)
		{
			Debug.LogWarning("[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
			return this;
		}
		if (JLNCPFNPKMM != null && detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
		}
		if (JLNCPFNPKMM == null && !detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
			base.enabled = false;
			return this;
		}
		base.BJAAEHCDEFB += JLNCPFNPKMM;
		NGLNCGJHLEF = DEHLOLLDGHL;
		JFDACACAECG = IFPDPLOIEEM;
		ENFFLFEMCMN = KOAHDNDINHB;
		ONKHGNLNDDK();
		DIKMAFJINJO = 0;
		PIGFKPCBBHH = 0;
		BFDIKKENINF = true;
		CDOJMHCPDCB = true;
		return this;
	}

	protected override void IHNNAFKGGMO()
	{
		APJJFPIOGKN(null, NGLNCGJHLEF, JFDACACAECG, ENFFLFEMCMN);
	}

	protected override string NBJPADKALNN()
	{
		return "Speed Hack Detector";
	}

	private void ONKHGNLNDDK()
	{
		BPDDMAIHCEB = PMPJFHOABPI.DPIIFADDFNL();
		JCNLBABEAGI = PMPJFHOABPI.KEKPMLAMCCO();
		LDBDNJLMLAA = PMPJFHOABPI.LAJHPDKCDOO();
	}
}
