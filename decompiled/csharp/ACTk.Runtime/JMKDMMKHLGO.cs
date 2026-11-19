using System;
using System.IO;
using System.Reflection;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Injection Detector")]
[DisallowMultipleComponent]
[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_injection_detector.html")]
public class JMKDMMKHLGO : global::OKIEDJFCLOA<JMKDMMKHLGO>
{
	public delegate void MKKGGALHCHD(string JFIIGFFMFGJ);

	private class DHPDNBKMLHB
	{
		public readonly string ALLLIGGPLMK;

		public readonly int[] IHCLPJOAHED;

		public DHPDNBKMLHB(string ALLLIGGPLMK, int[] IHCLPJOAHED)
		{
			this.ALLLIGGPLMK = ALLLIGGPLMK;
			this.IHCLPJOAHED = IHCLPJOAHED;
		}
	}

	public const string DKKPFCBJAAO = "Injection Detector";

	internal const string ECHFMJKEMLH = "[ACTk] Injection Detector: ";

	private bool KLDLDKHLJJG;

	private bool AFNMMPBHMNN;

	private DHPDNBKMLHB[] HBFNNODKKKN;

	private string[] AGMOGFBLJFO;

	public new event MKKGGALHCHD BJAAEHCDEFB;

	private JMKDMMKHLGO()
	{
	}

	public static JMKDMMKHLGO GFMJMLPFMCH()
	{
		return global::FOKPNHICOOH<JMKDMMKHLGO>.AAANLLGDCHM;
	}

	public static JMKDMMKHLGO DEEHLMMJMLA()
	{
		if (global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA != null)
		{
			return global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA.APJJFPIOGKN(null);
		}
		Debug.LogError("[ACTk] Injection Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		return null;
	}

	public static JMKDMMKHLGO DEEHLMMJMLA(MKKGGALHCHD JLNCPFNPKMM)
	{
		return global::FOKPNHICOOH<JMKDMMKHLGO>.AAANLLGDCHM.APJJFPIOGKN(JLNCPFNPKMM);
	}

	public static void PNAGMICMAKL()
	{
		if (global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA.CNIPMALICAE();
		}
	}

	public static void MABNJHGIDLH()
	{
		if (global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA.CBPNHEBFOFH();
		}
	}

	private JMKDMMKHLGO APJJFPIOGKN(MKKGGALHCHD JLNCPFNPKMM)
	{
		if (CDOJMHCPDCB)
		{
			Debug.LogWarning("[ACTk] Injection Detector: already running!", this);
			return this;
		}
		if (!base.enabled)
		{
			Debug.LogWarning("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
			return this;
		}
		if ((this.BJAAEHCDEFB != null || JLNCPFNPKMM != null) && detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
		}
		if (this.BJAAEHCDEFB == null && JLNCPFNPKMM == null && !detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
			base.enabled = false;
			return this;
		}
		BJAAEHCDEFB += JLNCPFNPKMM;
		BFDIKKENINF = true;
		CDOJMHCPDCB = true;
		if (Application.isEditor)
		{
			Debug.Log("[ACTk] Injection Detector: does not work in Unity Editor.", this);
			return this;
		}
		if (HBFNNODKKKN == null)
		{
			ILFBPLLMMFN();
		}
		if (KLDLDKHLJJG)
		{
			HENEPAOMHDA("signatures are missing (did you enable Injection Detector?)");
		}
		else if (AFNMMPBHMNN)
		{
			HENEPAOMHDA("signatures are not genuine or damaged");
			return this;
		}
		if (!KANJCKCIGLF(out var MCDDMPHHNFO))
		{
			AppDomain.CurrentDomain.AssemblyLoad += LBELLIFKEMJ;
		}
		else
		{
			HENEPAOMHDA(MCDDMPHHNFO);
		}
		return this;
	}

	protected override void IHNNAFKGGMO()
	{
		APJJFPIOGKN(null);
	}

	protected override void MNGJCENJLOC()
	{
		AppDomain.CurrentDomain.AssemblyLoad -= LBELLIFKEMJ;
		base.MNGJCENJLOC();
	}

	protected override bool INJJKIJPBBG()
	{
		if (!base.INJJKIJPBBG())
		{
			return false;
		}
		AppDomain.CurrentDomain.AssemblyLoad += LBELLIFKEMJ;
		return true;
	}

	protected override bool MLCLGJBFMNM()
	{
		return base.MLCLGJBFMNM() || this.BJAAEHCDEFB != null;
	}

	protected override void CNIPMALICAE()
	{
		if (BFDIKKENINF)
		{
			AppDomain.CurrentDomain.AssemblyLoad -= LBELLIFKEMJ;
		}
		base.CNIPMALICAE();
	}

	protected override void CBPNHEBFOFH()
	{
		base.CBPNHEBFOFH();
		if (global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA == this)
		{
			global::FOKPNHICOOH<JMKDMMKHLGO>.KHGDLGJPCCA = null;
		}
	}

	protected override string NBJPADKALNN()
	{
		return "Injection Detector";
	}

	private void HENEPAOMHDA(string MCDDMPHHNFO)
	{
		base.OACFFKENAKG = true;
		if (this.BJAAEHCDEFB != null)
		{
			this.BJAAEHCDEFB(MCDDMPHHNFO);
		}
		if (detectionEventHasListener)
		{
			detectionEvent.Invoke();
		}
		if (IDIBIHLNMEG)
		{
			CBPNHEBFOFH();
		}
		else
		{
			CNIPMALICAE();
		}
	}

	private void LBELLIFKEMJ(object PHLFGFHJMIK, AssemblyLoadEventArgs JPJGKBJGHOE)
	{
		if (!DKEPHMPIBCM(JPJGKBJGHOE.LoadedAssembly))
		{
			HENEPAOMHDA(JPJGKBJGHOE.LoadedAssembly.FullName);
		}
	}

	private bool KANJCKCIGLF(out string MCDDMPHHNFO)
	{
		MCDDMPHHNFO = null;
		bool result = false;
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		if (assemblies.Length == 0)
		{
			MCDDMPHHNFO = "no assemblies";
			result = true;
		}
		else
		{
			Assembly[] array = assemblies;
			foreach (Assembly assembly in array)
			{
				if (!DKEPHMPIBCM(assembly))
				{
					MCDDMPHHNFO = assembly.FullName;
					result = true;
					break;
				}
			}
		}
		return result;
	}

	private bool DKEPHMPIBCM(Assembly OBGHOHAHIBE)
	{
		string text = OBGHOHAHIBE.GetName().Name;
		int value = KCDGMKBPMPK(OBGHOHAHIBE);
		bool result = false;
		for (int i = 0; i < HBFNNODKKKN.Length; i++)
		{
			DHPDNBKMLHB dHPDNBKMLHB = HBFNNODKKKN[i];
			if (dHPDNBKMLHB.ALLLIGGPLMK == text && Array.IndexOf(dHPDNBKMLHB.IHCLPJOAHED, value) != -1)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void ILFBPLLMMFN()
	{
		TextAsset textAsset = (TextAsset)Resources.Load("fndid", typeof(TextAsset));
		if (textAsset == null)
		{
			KLDLDKHLJJG = true;
			AFNMMPBHMNN = true;
			return;
		}
		string[] separator = new string[1] { ":" };
		MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
		BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.Unicode);
		int num = binaryReader.ReadInt32();
		HBFNNODKKKN = new DHPDNBKMLHB[num];
		for (int i = 0; i < num; i++)
		{
			int count = binaryReader.ReadInt32();
			char[] eHAPKEKPMOE = binaryReader.ReadChars(count);
			string text = ObscuredString.MMNLMLIIDBO(eHAPKEKPMOE, GIOKJJKOBLJ.IJCJGOBGKFN);
			string[] array = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			int num2 = array.Length;
			if (num2 > 1)
			{
				string aLLLIGGPLMK = array[0];
				int[] array2 = new int[num2 - 1];
				for (int j = 1; j < num2; j++)
				{
					int result = 0;
					if (int.TryParse(array[j], out result))
					{
						array2[j - 1] = result;
					}
					else
					{
						Debug.LogError("[ACTk] Injection Detector: Could not parse value: " + array[j] + ", line:\n" + text);
					}
				}
				HBFNNODKKKN[i] = new DHPDNBKMLHB(aLLLIGGPLMK, array2);
				continue;
			}
			AFNMMPBHMNN = true;
			binaryReader.Close();
			memoryStream.Close();
			return;
		}
		binaryReader.Close();
		memoryStream.Close();
		Resources.UnloadAsset(textAsset);
		AGMOGFBLJFO = new string[256];
		for (int k = 0; k < 256; k++)
		{
			AGMOGFBLJFO[k] = k.ToString("x2");
		}
	}

	private int KCDGMKBPMPK(Assembly OBGHOHAHIBE)
	{
		AssemblyName assemblyName = OBGHOHAHIBE.GetName();
		byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
		string text = ((publicKeyToken.Length < 8) ? assemblyName.Name : (assemblyName.Name + KDBPOHGIGJC(publicKeyToken)));
		int num = 0;
		int length = text.Length;
		for (int i = 0; i < length; i++)
		{
			num += text[i];
			num += num << 10;
			num ^= num >> 6;
		}
		num += num << 3;
		num ^= num >> 11;
		return num + (num << 15);
	}

	private string KDBPOHGIGJC(byte[] BKOEGJJBGBC)
	{
		string text = string.Empty;
		for (int i = 0; i < 8; i++)
		{
			text += AGMOGFBLJFO[BKOEGJJBGBC[i]];
		}
		return text;
	}
}
