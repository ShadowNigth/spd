using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_time_cheating_detector.html")]
[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Time Cheating Detector")]
[DisallowMultipleComponent]
public class DKKOBJAPMOJ : global::OKIEDJFCLOA<DKKOBJAPMOJ>
{
	public delegate void AJPPHFONBIB(PEKAGFEGMCH NMOAEBLHDEB);

	public delegate void MGFOJIFNKNP(ACAGNJBMJJP NMOAEBLHDEB, PJCKMFJLPAA JBBAPHBEMJH);

	public struct PEKAGFEGMCH
	{
		public bool BOKKIDJHFMI;

		public string JBBAPHBEMJH;

		public long OKJLHNDIDIC;

		public double OMDEEFADJBA;

		internal void IDLOGJGDBBN(double KJLLEGNJEMJ)
		{
			BOKKIDJHFMI = true;
			JBBAPHBEMJH = null;
			OKJLHNDIDIC = -1L;
			OMDEEFADJBA = KJLLEGNJEMJ;
		}

		internal void LHMKGGPJMGB(string LELLCLPMMOC, long DFEFMPJNKMI = -1L)
		{
			BOKKIDJHFMI = false;
			JBBAPHBEMJH = LELLCLPMMOC;
			OKJLHNDIDIC = DFEFMPJNKMI;
			OMDEEFADJBA = -1.0;
		}

		public override string ToString()
		{
			if (BOKKIDJHFMI)
			{
				return "onlineSecondsUtc: " + OMDEEFADJBA;
			}
			return "Error response code: " + OKJLHNDIDIC + "\nError: " + JBBAPHBEMJH;
		}
	}

	public enum ACAGNJBMJJP
	{
		PEDDDHJCFHL = 0,
		OJDHBBGDODA = 5,
		CGNPPGBLFCH = 10,
		BJAAEHCDEFB = 15,
		MDAGMEKENHO = 100
	}

	public enum PJCKMFJLPAA
	{
		ICLBKODJGPC = 0,
		HNOKJAIHLJF = 3,
		LLPEPMLCDID = 5,
		MGBFNNFLLNH = 10,
		HADJNKJNBCB = 15,
		PEDDDHJCFHL = 100
	}

	public enum BHAHJHBELIL
	{
		CEEDIBEPOCB,
		CJELHLLGJLG
	}

	[CompilerGenerated]
	private sealed class FLHPJJGECLJ : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal PEKAGFEGMCH IFJJPBHBJFB;

		internal Uri PILHMKHMJGI;

		internal BHAHJHBELIL ANMJMMNOLCP;

		internal UnityWebRequest OBGKFHICEDB;

		internal AJPPHFONBIB JLNCPFNPKMM;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public FLHPJJGECLJ()
		{
		}

		public bool MoveNext()
		{
			uint num = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				if (CLBEEHLMDON)
				{
					HLJEEFIJCOF = JMMJGEDCPNG;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				goto case 1u;
			case 1u:
				CLBEEHLMDON = true;
				IFJJPBHBJFB = default(PEKAGFEGMCH);
				OBGKFHICEDB = HBKILPCMIEB(PILHMKHMJGI, ANMJMMNOLCP);
				num = 4294967293u;
				goto case 2u;
			case 2u:
				try
				{
					switch (num)
					{
					default:
						HLJEEFIJCOF = OBGKFHICEDB.SendWebRequest();
						if (!JMOBJHKGFMH)
						{
							GNNOELAJGPI = 2;
						}
						flag = true;
						goto end_IL_0011;
					case 2u:
						BMAEDEDCOGP(OBGKFHICEDB, ref IFJJPBHBJFB);
						break;
					}
				}
				finally
				{
					if (!flag)
					{
						OKOKNFKILLM();
					}
				}
				if (JLNCPFNPKMM != null)
				{
					JLNCPFNPKMM(IFJJPBHBJFB);
				}
				CLBEEHLMDON = false;
				GNNOELAJGPI = -1;
				goto default;
			default:
				{
					return false;
				}
				end_IL_0011:
				break;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 2u:
				try
				{
					break;
				}
				finally
				{
					OKOKNFKILLM();
				}
			case 0u:
			case 1u:
				break;
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		private void OKOKNFKILLM()
		{
			if (OBGKFHICEDB != null)
			{
				((IDisposable)OBGKFHICEDB).Dispose();
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct LMJIDFMAJKC : IAsyncStateMachine
	{
		internal string AKMKNECKCAP;

		internal Uri JJFFLPCELHF;

		internal BHAHJHBELIL ANMJMMNOLCP;

		internal AsyncTaskMethodBuilder<PEKAGFEGMCH> GKCHAGKLODM;

		internal int GNNOELAJGPI;

		private TaskAwaiter<PEKAGFEGMCH> MKPDMOCMMFM;

		public void MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			PEKAGFEGMCH result;
			try
			{
				switch (gNNOELAJGPI)
				{
				default:
					return;
				case 0u:
					JJFFLPCELHF = HCLFNHFJPOL(AKMKNECKCAP);
					MKPDMOCMMFM = CCBCKPEIHFE(JJFFLPCELHF, ANMJMMNOLCP).GetAwaiter();
					if (!MKPDMOCMMFM.IsCompleted)
					{
						GNNOELAJGPI = 1;
						GKCHAGKLODM.AwaitUnsafeOnCompleted(ref MKPDMOCMMFM, ref this);
						return;
					}
					break;
				case 1u:
					break;
				}
				result = MKPDMOCMMFM.GetResult();
			}
			catch (Exception exception)
			{
				GNNOELAJGPI = -1;
				GKCHAGKLODM.SetException(exception);
				return;
			}
			GNNOELAJGPI = -1;
			GKCHAGKLODM.SetResult(result);
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine CKENGCPKBGJ)
		{
			GKCHAGKLODM.SetStateMachine(CKENGCPKBGJ);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct JEMHHKGCJGL : IAsyncStateMachine
	{
		internal PEKAGFEGMCH IFJJPBHBJFB;

		internal Uri PILHMKHMJGI;

		internal BHAHJHBELIL ANMJMMNOLCP;

		internal UnityWebRequest OBGKFHICEDB;

		internal UnityWebRequestAsyncOperation BMGCLBDJNJG;

		internal AsyncTaskMethodBuilder<PEKAGFEGMCH> GKCHAGKLODM;

		internal int GNNOELAJGPI;

		private TaskAwaiter MKPDMOCMMFM;

		public void MoveNext()
		{
			uint num = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			bool flag = false;
			PEKAGFEGMCH iFJJPBHBJFB;
			try
			{
				switch (num)
				{
				default:
					return;
				case 1u:
					MKPDMOCMMFM.GetResult();
					goto case 0u;
				case 0u:
					if (CLBEEHLMDON)
					{
						MKPDMOCMMFM = Task.Delay(100).GetAwaiter();
						if (!MKPDMOCMMFM.IsCompleted)
						{
							GNNOELAJGPI = 1;
							flag = true;
							GKCHAGKLODM.AwaitUnsafeOnCompleted(ref MKPDMOCMMFM, ref this);
							return;
						}
						goto case 1u;
					}
					CLBEEHLMDON = true;
					IFJJPBHBJFB = default(PEKAGFEGMCH);
					OBGKFHICEDB = HBKILPCMIEB(PILHMKHMJGI, ANMJMMNOLCP);
					num = 4294967293u;
					break;
				case 2u:
					break;
				}
				try
				{
					switch (num)
					{
					default:
						BMGCLBDJNJG = OBGKFHICEDB.SendWebRequest();
						goto IL_0121;
					case 2u:
						{
							MKPDMOCMMFM.GetResult();
							goto IL_0121;
						}
						IL_0121:
						if (!BMGCLBDJNJG.isDone)
						{
							MKPDMOCMMFM = Task.Delay(100).GetAwaiter();
							if (!MKPDMOCMMFM.IsCompleted)
							{
								GNNOELAJGPI = 2;
								flag = true;
								GKCHAGKLODM.AwaitUnsafeOnCompleted(ref MKPDMOCMMFM, ref this);
								return;
							}
							goto case 2u;
						}
						BMAEDEDCOGP(OBGKFHICEDB, ref IFJJPBHBJFB);
						break;
					}
				}
				finally
				{
					if (!flag && OBGKFHICEDB != null)
					{
						((IDisposable)OBGKFHICEDB).Dispose();
					}
				}
				CLBEEHLMDON = false;
				iFJJPBHBJFB = IFJJPBHBJFB;
			}
			catch (Exception exception)
			{
				GNNOELAJGPI = -1;
				GKCHAGKLODM.SetException(exception);
				return;
			}
			GNNOELAJGPI = -1;
			GKCHAGKLODM.SetResult(iFJJPBHBJFB);
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine CKENGCPKBGJ)
		{
			GKCHAGKLODM.SetStateMachine(CKENGCPKBGJ);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct MNDMKOCONCM : IAsyncStateMachine
	{
		internal DKKOBJAPMOJ KPHCHDHEKGH;

		internal AsyncTaskMethodBuilder<ACAGNJBMJJP> GKCHAGKLODM;

		internal int GNNOELAJGPI;

		private TaskAwaiter MKPDMOCMMFM;

		public void MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			ACAGNJBMJJP result;
			try
			{
				switch (gNNOELAJGPI)
				{
				default:
					return;
				case 0u:
					if (!KPHCHDHEKGH.BFDIKKENINF || !KPHCHDHEKGH.CDOJMHCPDCB)
					{
						UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: Detector should be started to use ForceCheckTask().");
						KPHCHDHEKGH.IKJJPIFLPEF = PJCKMFJLPAA.MGBFNNFLLNH;
						KPHCHDHEKGH.IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
						result = KPHCHDHEKGH.IJBFDAADFCH;
					}
					else
					{
						if (!KPHCHDHEKGH.HPPCDJLKCLJ)
						{
							KPHCHDHEKGH.FJGINGLNAKB = 0f;
							KPHCHDHEKGH.StartCoroutine(KPHCHDHEKGH.MFBHNACEJAK());
							MKPDMOCMMFM = Task.Delay(50).GetAwaiter();
							if (!MKPDMOCMMFM.IsCompleted)
							{
								GNNOELAJGPI = 1;
								GKCHAGKLODM.AwaitUnsafeOnCompleted(ref MKPDMOCMMFM, ref this);
								return;
							}
							goto case 1u;
						}
						UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: Can't force cheating check since another check is already in progress.");
						KPHCHDHEKGH.IKJJPIFLPEF = PJCKMFJLPAA.HADJNKJNBCB;
						KPHCHDHEKGH.IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
						result = KPHCHDHEKGH.IJBFDAADFCH;
					}
					goto end_IL_000e;
				case 1u:
					MKPDMOCMMFM.GetResult();
					if (!KPHCHDHEKGH.HPPCDJLKCLJ)
					{
						break;
					}
					goto IL_0191;
				case 2u:
					{
						MKPDMOCMMFM.GetResult();
						goto IL_0191;
					}
					IL_0191:
					if (!KPHCHDHEKGH.HPPCDJLKCLJ)
					{
						break;
					}
					MKPDMOCMMFM = Task.Delay(50).GetAwaiter();
					if (!MKPDMOCMMFM.IsCompleted)
					{
						GNNOELAJGPI = 2;
						GKCHAGKLODM.AwaitUnsafeOnCompleted(ref MKPDMOCMMFM, ref this);
						return;
					}
					goto case 2u;
				}
				result = KPHCHDHEKGH.IJBFDAADFCH;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				GNNOELAJGPI = -1;
				GKCHAGKLODM.SetException(exception);
				return;
			}
			GNNOELAJGPI = -1;
			GKCHAGKLODM.SetResult(result);
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine CKENGCPKBGJ)
		{
			GKCHAGKLODM.SetStateMachine(CKENGCPKBGJ);
		}
	}

	public const string DKKPFCBJAAO = "Time Cheating Detector";

	private const string ECHFMJKEMLH = "[ACTk] Time Cheating Detector: ";

	private const int PNJMMKBCGJB = 10;

	private static readonly WaitForEndOfFrame JMMJGEDCPNG = new WaitForEndOfFrame();

	private static bool CLBEEHLMDON;

	private static int GKPEFBOLFKB;

	[SerializeField]
	[Tooltip("Absolute URL which will return correct datetime in response headers (you may use popular web servers like google.com, microsoft.com etc.).")]
	[Header("Request settings")]
	private string requestUrl = "https://google.com";

	[Tooltip("Method to use for url request. Use Head method if possible and fall back to get if server does not reply or block head requests.")]
	public BHAHJHBELIL ELIHCKHFLEA;

	[Tooltip("Online time request timeout in seconds.")]
	public int HNAGAGPOFBC = 10;

	[Range(0f, 60f)]
	[Tooltip("Time (in minutes) between detector checks.")]
	[Header("Settings in minutes")]
	public float NGLNCGJHLEF = 5f;

	[Range(10f, 180f)]
	[Tooltip("Maximum allowed difference between subsequent measurements, in minutes.")]
	[FormerlySerializedAs("threshold")]
	public int IONFFIAABKL = 65;

	[Tooltip("Maximum allowed difference between local and online time, in minutes.")]
	[Range(1f, 180f)]
	public int BDCGNANPKBO = 65;

	[Tooltip("Ignore case when time changes to be in sync with online correct time. Wrong time threshold is taken into account.")]
	public bool JIHLIKMJFMM = true;

	private readonly string JDNJLNCMLFC = CAICFBNFPHL.KFDHCOPFDGP(ObscuredString.ALMGKPDPDCH("onlineOfflineSecondsDifference", "TeslaOnMars".ToCharArray()));

	private Uri GBCKLPPEKDC;

	private MGFOJIFNKNP HHHKCAPAPEP;

	private float FJGINGLNAKB;

	private bool MGHDABNKKNM;

	private double COCGGEFHFGI;

	[NonSerialized]
	[Obsolete("Use wrongTimeThreshold instead.", true)]
	public int MNBIENILFIB = 65;

	[NonSerialized]
	[Obsolete("Use requestUrl instead", true)]
	public string FEEPJGMGFCL = "google.com";

	public string BBEBHNNEADK
	{
		get
		{
			return requestUrl;
		}
		set
		{
			if (!(requestUrl == value) && Application.isPlaying)
			{
				requestUrl = value;
				GBCKLPPEKDC = HCLFNHFJPOL(requestUrl);
			}
		}
	}

	public PJCKMFJLPAA IKJJPIFLPEF { get; private set; }

	public ACAGNJBMJJP IJBFDAADFCH { get; private set; }

	public bool HPPCDJLKCLJ { get; private set; }

	public event MGFOJIFNKNP HPLBGBCLFDC;

	[Obsolete("Please use CheatChecked event instead", true)]
	public event Action<PJCKMFJLPAA> MDAGMEKENHO;

	[Obsolete("Please use CheatChecked event instead", true)]
	public event Action OJDHBBGDODA;

	protected override string NBJPADKALNN()
	{
		return "Time Cheating Detector";
	}

	private void OnApplicationPause(bool BGDGPJAENDF)
	{
		if (BFDIKKENINF)
		{
			if (BGDGPJAENDF)
			{
				MNGJCENJLOC();
			}
			else
			{
				INJJKIJPBBG();
			}
		}
	}

	private void Update()
	{
		if (!BFDIKKENINF || !CDOJMHCPDCB || !(NGLNCGJHLEF > 0f))
		{
			return;
		}
		if (MGHDABNKKNM)
		{
			MGHDABNKKNM = false;
			return;
		}
		FJGINGLNAKB += Time.unscaledDeltaTime;
		if (FJGINGLNAKB >= NGLNCGJHLEF * 60f)
		{
			FJGINGLNAKB = 0f;
			StartCoroutine(MFBHNACEJAK());
		}
	}

	public static DKKOBJAPMOJ GFMJMLPFMCH()
	{
		return global::FOKPNHICOOH<DKKOBJAPMOJ>.AAANLLGDCHM;
	}

	public static DKKOBJAPMOJ DEEHLMMJMLA(MGFOJIFNKNP OMFDGCKELDF = null)
	{
		if (OMFDGCKELDF == null)
		{
			if (global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA != null)
			{
				return global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA.APJJFPIOGKN(global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA.NGLNCGJHLEF);
			}
			return DEEHLMMJMLA(global::FOKPNHICOOH<DKKOBJAPMOJ>.AAANLLGDCHM.NGLNCGJHLEF);
		}
		return DEEHLMMJMLA(global::FOKPNHICOOH<DKKOBJAPMOJ>.AAANLLGDCHM.NGLNCGJHLEF, OMFDGCKELDF);
	}

	public static DKKOBJAPMOJ DEEHLMMJMLA(float LJLFFCGMHDG, MGFOJIFNKNP OMFDGCKELDF = null)
	{
		return global::FOKPNHICOOH<DKKOBJAPMOJ>.AAANLLGDCHM.APJJFPIOGKN(LJLFFCGMHDG, OMFDGCKELDF);
	}

	public static void PNAGMICMAKL()
	{
		if (global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA.CNIPMALICAE();
		}
	}

	public static void MABNJHGIDLH()
	{
		if (global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA.CBPNHEBFOFH();
		}
	}

	public static IEnumerator CHNBMKPFCBB(string AKMKNECKCAP, AJPPHFONBIB JLNCPFNPKMM, BHAHJHBELIL ANMJMMNOLCP = BHAHJHBELIL.CEEDIBEPOCB)
	{
		Uri pILHMKHMJGI = HCLFNHFJPOL(AKMKNECKCAP);
		yield return CHNBMKPFCBB(pILHMKHMJGI, JLNCPFNPKMM, ANMJMMNOLCP);
	}

	public static IEnumerator CHNBMKPFCBB(Uri PILHMKHMJGI, AJPPHFONBIB JLNCPFNPKMM, BHAHJHBELIL ANMJMMNOLCP = BHAHJHBELIL.CEEDIBEPOCB)
	{
		if (CLBEEHLMDON)
		{
			yield return JMMJGEDCPNG;
		}
		CLBEEHLMDON = true;
		PEKAGFEGMCH NMOAEBLHDEB = default(PEKAGFEGMCH);
		UnityWebRequest unityWebRequest = HBKILPCMIEB(PILHMKHMJGI, ANMJMMNOLCP);
		try
		{
			yield return unityWebRequest.SendWebRequest();
			BMAEDEDCOGP(unityWebRequest, ref NMOAEBLHDEB);
		}
		finally
		{
			((FLHPJJGECLJ)(object)this).OKOKNFKILLM();
		}
		JLNCPFNPKMM?.Invoke(NMOAEBLHDEB);
		CLBEEHLMDON = false;
	}

	[AsyncStateMachine(typeof(LMJIDFMAJKC))]
	[DebuggerStepThrough]
	public static Task<PEKAGFEGMCH> CCBCKPEIHFE(string AKMKNECKCAP, BHAHJHBELIL ANMJMMNOLCP = BHAHJHBELIL.CEEDIBEPOCB)
	{
		LMJIDFMAJKC stateMachine = default(LMJIDFMAJKC);
		stateMachine.AKMKNECKCAP = AKMKNECKCAP;
		stateMachine.ANMJMMNOLCP = ANMJMMNOLCP;
		stateMachine.GKCHAGKLODM = AsyncTaskMethodBuilder<PEKAGFEGMCH>.Create();
		ref AsyncTaskMethodBuilder<PEKAGFEGMCH> gKCHAGKLODM = ref stateMachine.GKCHAGKLODM;
		gKCHAGKLODM.Start(ref stateMachine);
		return gKCHAGKLODM.Task;
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JEMHHKGCJGL))]
	public static Task<PEKAGFEGMCH> CCBCKPEIHFE(Uri PILHMKHMJGI, BHAHJHBELIL ANMJMMNOLCP = BHAHJHBELIL.CEEDIBEPOCB)
	{
		JEMHHKGCJGL stateMachine = default(JEMHHKGCJGL);
		stateMachine.PILHMKHMJGI = PILHMKHMJGI;
		stateMachine.ANMJMMNOLCP = ANMJMMNOLCP;
		stateMachine.GKCHAGKLODM = AsyncTaskMethodBuilder<PEKAGFEGMCH>.Create();
		ref AsyncTaskMethodBuilder<PEKAGFEGMCH> gKCHAGKLODM = ref stateMachine.GKCHAGKLODM;
		gKCHAGKLODM.Start(ref stateMachine);
		return gKCHAGKLODM.Task;
	}

	private static UnityWebRequest HBKILPCMIEB(Uri PILHMKHMJGI, BHAHJHBELIL ANMJMMNOLCP)
	{
		UnityWebRequest unityWebRequest = new UnityWebRequest(PILHMKHMJGI.AbsoluteUri, (ANMJMMNOLCP != 0) ? "GET" : "HEAD");
		unityWebRequest.useHttpContinue = false;
		unityWebRequest.timeout = ((!global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA) ? 10 : global::FOKPNHICOOH<DKKOBJAPMOJ>.KHGDLGJPCCA.HNAGAGPOFBC);
		UnityWebRequest unityWebRequest2 = unityWebRequest;
		if (ANMJMMNOLCP == BHAHJHBELIL.CEEDIBEPOCB)
		{
			try
			{
				if (GKPEFBOLFKB == 0)
				{
					GKPEFBOLFKB = NAJMMBGBHPF();
				}
				if (GKPEFBOLFKB <= 17)
				{
					unityWebRequest2.SetRequestHeader("Accept-Encoding", string.Empty);
				}
			}
			catch (Exception)
			{
				UnityEngine.Debug.LogError("[ACTk] Time Cheating Detector: Couldn't get SDK version or set Accept-Encoding header.");
			}
		}
		return unityWebRequest2;
	}

	private static void BMAEDEDCOGP(UnityWebRequest BIHPHLKBAPL, ref PEKAGFEGMCH NMOAEBLHDEB)
	{
		if (!string.IsNullOrEmpty(BIHPHLKBAPL.error))
		{
			NMOAEBLHDEB.LHMKGGPJMGB(BIHPHLKBAPL.error, BIHPHLKBAPL.responseCode);
		}
		else
		{
			string responseHeader = BIHPHLKBAPL.GetResponseHeader("Date");
			if (!string.IsNullOrEmpty(responseHeader))
			{
				if (DOOAKJNCJIC(responseHeader, out var KBGGPOCBNGG))
				{
					double kJLLEGNJEMJ = (double)KBGGPOCBNGG.ToUniversalTime().Ticks / 10000000.0;
					NMOAEBLHDEB.IDLOGJGDBBN(kJLLEGNJEMJ);
				}
				else
				{
					NMOAEBLHDEB.LHMKGGPJMGB("Couldn't parse 'Date' response header value\n " + responseHeader, BIHPHLKBAPL.responseCode);
				}
			}
			else
			{
				NMOAEBLHDEB.LHMKGGPJMGB("Couldn't find 'Date' response header value!", BIHPHLKBAPL.responseCode);
			}
		}
		if (!NMOAEBLHDEB.BOKKIDJHFMI)
		{
			UnityEngine.Debug.Log("[ACTk] Time Cheating Detector: Online Time Retrieve error:\n" + NMOAEBLHDEB);
		}
	}

	private static Uri HCLFNHFJPOL(string AKMKNECKCAP)
	{
		if (!Uri.TryCreate(AKMKNECKCAP, UriKind.Absolute, out var result))
		{
			UnityEngine.Debug.LogError("[ACTk] Time Cheating Detector: Could not create URI from URL: " + AKMKNECKCAP);
		}
		return result;
	}

	private static bool DOOAKJNCJIC(string FCBABFMAPBI, out DateTime KBGGPOCBNGG)
	{
		try
		{
			char[] array = FCBABFMAPBI.ToCharArray(5, 20);
			int num = array[0] & 0xF;
			int num2 = array[1] & 0xF;
			int day = num * 10 + num2;
			int num3 = array[4];
			int num4 = array[5];
			int month = (num3 + num4) switch
			{
				207 => 1, 
				199 => 2, 
				211 => 3, 
				226 => 4, 
				218 => 5, 
				227 => 6, 
				225 => 7, 
				220 => 8, 
				213 => 9, 
				215 => 10, 
				229 => 11, 
				200 => 12, 
				_ => 1, 
			};
			int num5 = array[7] & 0xF;
			int num6 = array[8] & 0xF;
			int num7 = array[9] & 0xF;
			int num8 = array[10] & 0xF;
			int year = num5 * 1000 + num6 * 100 + num7 * 10 + num8;
			int num9 = array[12] & 0xF;
			int num10 = array[13] & 0xF;
			int hour = num9 * 10 + num10;
			int num11 = array[15] & 0xF;
			int num12 = array[16] & 0xF;
			int minute = num11 * 10 + num12;
			int num13 = array[18] & 0xF;
			int num14 = array[19] & 0xF;
			int second = num13 * 10 + num14;
			KBGGPOCBNGG = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
			return true;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("[ACTk] Time Cheating Detector: Error while parsing date: " + ex);
			KBGGPOCBNGG = default(DateTime);
			return false;
		}
	}

	public bool ABDEAPBPDLG()
	{
		if (!BFDIKKENINF || !CDOJMHCPDCB)
		{
			UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: Detector should be started to use ForceCheck().");
			IKJJPIFLPEF = PJCKMFJLPAA.MGBFNNFLLNH;
			IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
			return false;
		}
		if (HPPCDJLKCLJ)
		{
			UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: Can't force cheating check since another check is already in progress.");
			IKJJPIFLPEF = PJCKMFJLPAA.HADJNKJNBCB;
			IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
			return false;
		}
		FJGINGLNAKB = 0f;
		StartCoroutine(MFBHNACEJAK());
		return true;
	}

	public IEnumerator EELCNLIGFAJ()
	{
		if (!BFDIKKENINF || !CDOJMHCPDCB)
		{
			UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: Detector should be started to use ForceCheckEnumerator().");
			IKJJPIFLPEF = PJCKMFJLPAA.MGBFNNFLLNH;
			IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
			yield break;
		}
		if (HPPCDJLKCLJ)
		{
			UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: Can't force cheating check since another check is already in progress.");
			IKJJPIFLPEF = PJCKMFJLPAA.HADJNKJNBCB;
			IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
			yield break;
		}
		FJGINGLNAKB = 0f;
		yield return MFBHNACEJAK();
		while (HPPCDJLKCLJ)
		{
			yield return JMMJGEDCPNG;
		}
	}

	[AsyncStateMachine(typeof(MNDMKOCONCM))]
	[DebuggerStepThrough]
	public Task<ACAGNJBMJJP> DEGCDEOAPNG()
	{
		MNDMKOCONCM stateMachine = default(MNDMKOCONCM);
		stateMachine.KPHCHDHEKGH = this;
		stateMachine.GKCHAGKLODM = AsyncTaskMethodBuilder<ACAGNJBMJJP>.Create();
		ref AsyncTaskMethodBuilder<ACAGNJBMJJP> gKCHAGKLODM = ref stateMachine.GKCHAGKLODM;
		gKCHAGKLODM.Start(ref stateMachine);
		return gKCHAGKLODM.Task;
	}

	private DKKOBJAPMOJ APJJFPIOGKN(float DEHLOLLDGHL, MGFOJIFNKNP OMFDGCKELDF = null)
	{
		if (CDOJMHCPDCB)
		{
			UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: already running!", this);
			return this;
		}
		if (!base.enabled)
		{
			UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
			return this;
		}
		if (OMFDGCKELDF != null && detectionEventHasListener)
		{
			UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: has properly configured Detection Event in the inspector, but still get started with TimeCheatingDetectorCallback callback. Both TimeCheatingDetectorCallback and Detection Event will be called on detection. Are you sure you wish to do this?", this);
		}
		FJGINGLNAKB = 0f;
		HHHKCAPAPEP = OMFDGCKELDF;
		NGLNCGJHLEF = DEHLOLLDGHL;
		BFDIKKENINF = true;
		CDOJMHCPDCB = true;
		return this;
	}

	protected override bool HIBHJDCMMAJ(DKKOBJAPMOJ KAGNKODNFOC, string IIIHGIINJJL)
	{
		if (GBCKLPPEKDC == null)
		{
			GBCKLPPEKDC = HCLFNHFJPOL(requestUrl);
		}
		return base.HIBHJDCMMAJ(KAGNKODNFOC, IIIHGIINJJL);
	}

	protected override void IHNNAFKGGMO()
	{
		APJJFPIOGKN(NGLNCGJHLEF);
	}

	protected override bool MLCLGJBFMNM()
	{
		return base.MLCLGJBFMNM() || this.HPLBGBCLFDC != null || HHHKCAPAPEP != null;
	}

	protected override void MNGJCENJLOC()
	{
		base.MNGJCENJLOC();
		MGHDABNKKNM = true;
	}

	protected override void CNIPMALICAE()
	{
		base.CNIPMALICAE();
		HHHKCAPAPEP = null;
		this.HPLBGBCLFDC = null;
	}

	private IEnumerator MFBHNACEJAK()
	{
		if (!CDOJMHCPDCB || HPPCDJLKCLJ)
		{
			yield break;
		}
		HPPCDJLKCLJ = true;
		IKJJPIFLPEF = PJCKMFJLPAA.ICLBKODJGPC;
		IJBFDAADFCH = ACAGNJBMJJP.PEDDDHJCFHL;
		if (GBCKLPPEKDC == null)
		{
			IKJJPIFLPEF = PJCKMFJLPAA.HNOKJAIHLJF;
			IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
		}
		else
		{
			yield return CHNBMKPFCBB(GBCKLPPEKDC, OKPGHMOEFJP, ELIHCKHFLEA);
		}
		if (!BFDIKKENINF || !CDOJMHCPDCB)
		{
			IKJJPIFLPEF = PJCKMFJLPAA.PEDDDHJCFHL;
		}
		if (COCGGEFHFGI <= 0.0 && IKJJPIFLPEF == PJCKMFJLPAA.ICLBKODJGPC)
		{
			IKJJPIFLPEF = PJCKMFJLPAA.PEDDDHJCFHL;
		}
		if (IKJJPIFLPEF != 0 && IKJJPIFLPEF != PJCKMFJLPAA.HADJNKJNBCB)
		{
			IJBFDAADFCH = ACAGNJBMJJP.MDAGMEKENHO;
			ENBFNIGEHJA();
			HPPCDJLKCLJ = false;
			yield break;
		}
		IKJJPIFLPEF = PJCKMFJLPAA.ICLBKODJGPC;
		double num = DLBHJJFHPKO();
		int num2 = (int)Math.Abs(COCGGEFHFGI - num);
		IJBFDAADFCH = ACAGNJBMJJP.OJDHBBGDODA;
		if (num2 > BDCGNANPKBO * 60)
		{
			IJBFDAADFCH = ACAGNJBMJJP.CGNPPGBLFCH;
		}
		int @int = PlayerPrefs.GetInt(JDNJLNCMLFC, 0);
		if (@int != 0)
		{
			@int ^= 0x7FFFFFFF;
			int num3 = Math.Abs(num2 - @int);
			if (IONFFIAABKL < 10)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Time Cheating Detector: Please consider increasing realCheatThreshold to reduce false positives chance!");
			}
			if (num3 > IONFFIAABKL * 60 && (IJBFDAADFCH == ACAGNJBMJJP.CGNPPGBLFCH || !JIHLIKMJFMM))
			{
				IJBFDAADFCH = ACAGNJBMJJP.BJAAEHCDEFB;
			}
		}
		PlayerPrefs.SetInt(JDNJLNCMLFC, num2 ^ 0x7FFFFFFF);
		HPPCDJLKCLJ = false;
		ENBFNIGEHJA();
	}

	private void ENBFNIGEHJA()
	{
		if (HHHKCAPAPEP != null)
		{
			HHHKCAPAPEP(IJBFDAADFCH, IKJJPIFLPEF);
		}
		if (this.HPLBGBCLFDC != null)
		{
			this.HPLBGBCLFDC(IJBFDAADFCH, IKJJPIFLPEF);
		}
		switch (IJBFDAADFCH)
		{
		case ACAGNJBMJJP.BJAAEHCDEFB:
			HENEPAOMHDA();
			break;
		case ACAGNJBMJJP.PEDDDHJCFHL:
		case ACAGNJBMJJP.OJDHBBGDODA:
		case ACAGNJBMJJP.CGNPPGBLFCH:
		case ACAGNJBMJJP.MDAGMEKENHO:
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private void OKPGHMOEFJP(PEKAGFEGMCH NMOAEBLHDEB)
	{
		if (NMOAEBLHDEB.BOKKIDJHFMI)
		{
			COCGGEFHFGI = NMOAEBLHDEB.OMDEEFADJBA;
			return;
		}
		COCGGEFHFGI = -1.0;
		IKJJPIFLPEF = PJCKMFJLPAA.LLPEPMLCDID;
	}

	private double DLBHJJFHPKO()
	{
		return (double)DateTime.UtcNow.Ticks / 10000000.0;
	}

	private static int NAJMMBGBHPF()
	{
		string operatingSystem = SystemInfo.operatingSystem;
		if (string.IsNullOrEmpty(operatingSystem))
		{
			return -1;
		}
		int num = operatingSystem.IndexOf("-", StringComparison.Ordinal);
		if (num <= 0)
		{
			return -1;
		}
		if (operatingSystem.Length < num + 3)
		{
			return -1;
		}
		string text = operatingSystem.Substring(num + 1, 2);
		if (string.IsNullOrEmpty(text))
		{
			return -1;
		}
		if (!int.TryParse(text, out var result))
		{
			return -1;
		}
		return result;
	}

	[Obsolete("Please use GetOnlineTimeCoroutine or GetOnlineTimeTask instead", true)]
	public static double CBMBDOINLIL(string HMLCHMNCHIP)
	{
		return -1.0;
	}

	[Obsolete("Please use Instance.Error event instead.", true)]
	public static void GONELKNFLGB(Action<PJCKMFJLPAA> AMNPJFEGDNB)
	{
	}

	[Obsolete("Please use StartDetection(int, ...) instead.", true)]
	public static void DEEHLMMJMLA(Action OACNLGPFJHG, int NGLNCGJHLEF)
	{
	}

	[Obsolete("Please use StartDetection(int, ...) instead.", true)]
	public static void DEEHLMMJMLA(Action OACNLGPFJHG, Action<PJCKMFJLPAA> AMNPJFEGDNB, int NGLNCGJHLEF)
	{
	}

	[Obsolete("Please use other overloads of this method instead", true)]
	public static void DEEHLMMJMLA(float NGLNCGJHLEF, Action OACNLGPFJHG, Action<PJCKMFJLPAA> AMNPJFEGDNB, Action FAENDHAEBOG)
	{
	}
}
