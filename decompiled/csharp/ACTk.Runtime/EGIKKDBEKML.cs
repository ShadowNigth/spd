using System;
using UnityEngine;

[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_obscured_cheating_detector.html")]
[DisallowMultipleComponent]
[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Obscured Cheating Detector")]
public class EGIKKDBEKML : global::OKIEDJFCLOA<EGIKKDBEKML>
{
	public const string DKKPFCBJAAO = "Obscured Cheating Detector";

	internal const string ECHFMJKEMLH = "[ACTk] Obscured Cheating Detector: ";

	[Tooltip("Max allowed difference between encrypted and fake values in ObscuredDouble. Increase in case of false positives.")]
	public double OJIJHMNKGIP = 0.0001;

	[Tooltip("Max allowed difference between encrypted and fake values in ObscuredFloat. Increase in case of false positives.")]
	public float AACEDBAHHLB = 0.0001f;

	[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector2. Increase in case of false positives.")]
	public float HGJGIKJOMLL = 0.1f;

	[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector3. Increase in case of false positives.")]
	public float BOBIFNGMPOI = 0.1f;

	[Tooltip("Max allowed difference between encrypted and fake values in ObscuredQuaternion. Increase in case of false positives.")]
	public float DPGDHBGDCMG = 0.1f;

	internal static bool LDMDOPOHCHA => (object)global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA != null && global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.MNDFOKODEPL;

	private EGIKKDBEKML()
	{
	}

	public static EGIKKDBEKML GFMJMLPFMCH()
	{
		return global::FOKPNHICOOH<EGIKKDBEKML>.AAANLLGDCHM;
	}

	public static EGIKKDBEKML DEEHLMMJMLA()
	{
		if (global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA != null)
		{
			return global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.APJJFPIOGKN(null);
		}
		Debug.LogError("[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		return null;
	}

	public static EGIKKDBEKML DEEHLMMJMLA(Action JLNCPFNPKMM)
	{
		return global::FOKPNHICOOH<EGIKKDBEKML>.AAANLLGDCHM.APJJFPIOGKN(JLNCPFNPKMM);
	}

	public static void PNAGMICMAKL()
	{
		if (global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.CNIPMALICAE();
		}
	}

	public static void MABNJHGIDLH()
	{
		if (global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<EGIKKDBEKML>.KHGDLGJPCCA.CBPNHEBFOFH();
		}
	}

	private EGIKKDBEKML APJJFPIOGKN(Action JLNCPFNPKMM)
	{
		if (CDOJMHCPDCB)
		{
			Debug.LogWarning("[ACTk] Obscured Cheating Detector: already running!", this);
			return this;
		}
		if (!base.enabled)
		{
			Debug.LogWarning("[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
			return this;
		}
		if (JLNCPFNPKMM != null && detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
		}
		if (JLNCPFNPKMM == null && !detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
			base.enabled = false;
			return this;
		}
		base.BJAAEHCDEFB += JLNCPFNPKMM;
		BFDIKKENINF = true;
		CDOJMHCPDCB = true;
		return this;
	}

	protected override void IHNNAFKGGMO()
	{
		APJJFPIOGKN(null);
	}

	protected override string NBJPADKALNN()
	{
		return "Obscured Cheating Detector";
	}
}
