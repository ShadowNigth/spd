using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using UnityEngine;
using UnityEngine.Profiling;

public class LAOFKFBJDGJ : FOGIOGKLNIP
{
	public enum LPOPPAECGCE
	{
		BLBOPPEBDFH = 0,
		IMHJBLKBPCG = 1,
		FBNOALALNHF = 2
	}

	private sealed class NDAPJFCBMDD : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal LAOFKFBJDGJ KPHCHDHEKGH;

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
		public NDAPJFCBMDD()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				Application.targetFrameRate = KPHCHDHEKGH.GCPLACLAKKH;
				AudioListener.volume = FOGIOGKLNIP.LPLJMLGKCLK.JPNLKCBPIED;
				MasterServer.ipAddress = "gametestlan.servegame.com";
				Network.natFacilitatorIP = "gametestlan.servegame.com";
				Network.proxyIP = "gametestlan.servegame.com";
				KPHCHDHEKGH.PKLNHOEOKBH = FOGIOGKLNIP.CEKCOJEJPAN("mapsdled2", string.Empty).Split2("|").ToList();
				FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF.Clear();
				KPHCHDHEKGH.EAPNLIMNCOK = false;
				KPHCHDHEKGH.DKLHCPOGOBI = false;
				KPHCHDHEKGH.PresetSettings(2);
				KPHCHDHEKGH.IPGDADMKHBI = 0;
				KPHCHDHEKGH.DPKFCDBODHB = 254;
				KPHCHDHEKGH.KDOJPMAILED = 22;
				KPHCHDHEKGH.JDJOIFBLOCJ = 255;
				KPHCHDHEKGH.KGOMBPAOCFJ = 20f;
				KPHCHDHEKGH.BCGCADMJKCN = 2.5f;
				KPHCHDHEKGH.PBAMBLHDMFN = 3f;
				KPHCHDHEKGH.AOGMLGLJCOJ = 128;
				KPHCHDHEKGH.GCPLACLAKKH = 60;
				FOGIOGKLNIP.BBKFOHCEOCK("FirstLaunch", 1);
				KPHCHDHEKGH.PresetSettingsLoad(KPHCHDHEKGH.EMFJACGNHEJ);
				FOGIOGKLNIP.LPLJMLGKCLK.NABKAAPMFAO.enabled = false;
				if (FOGIOGKLNIP.INJKJFIDKJM != null)
				{
					KPHCHDHEKGH.NDFPLDPNNMG = FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD;
				}
				UnityEngine.Object.DontDestroyOnLoad(KPHCHDHEKGH.EHOEFMPLIFB.root);
				HLJEEFIJCOF = null;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				GNNOELAJGPI = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class LKMIPEEKNFO
	{
		internal StringBuilder OCCOEHJFDKM;

		internal LAOFKFBJDGJ KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			KPHCHDHEKGH.LOADKHHJCDK = GUILayout.BeginScrollView(KPHCHDHEKGH.LOADKHHJCDK);
			GUILayout.TextArea(OCCOEHJFDKM.ToString());
			GUILayout.EndScrollView();
		}
	}

	private sealed class PGHOKPIOOCA : IEnumerator, IDisposable, IEnumerator<object>
	{
		private sealed class MMDGIEHLFAI
		{
			internal WWW GDIFBJBOCJM;

			internal PGHOKPIOOCA IFDCFFEIPCD;

			internal void BEKJDJFLJJC()
			{
				GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL(IFDCFFEIPCD.KPHCHDHEKGH.FKICDOGJIFN.ScreenshotUploadingScreenshot));
			}

			internal void PMBKBKJIIPO()
			{
				GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL(IFDCFFEIPCD.KPHCHDHEKGH.FKICDOGJIFN.ScreenshotCopyScreenshotUrlToClipboard));
				GUILayout.TextArea(GDIFBJBOCJM.text);
			}
		}

		internal int GIJGINKBMCP;

		internal int KDJLNLIACAP;

		internal Texture2D DHJNPMPDBDA;

		internal byte[] OJJFCDEBHLF;

		internal WWWForm DHAHOBCEAKG;

		internal LAOFKFBJDGJ KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		private MMDGIEHLFAI DKOBKNHODMO;

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
		public PGHOKPIOOCA()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				DKOBKNHODMO = new MMDGIEHLFAI();
				DKOBKNHODMO.IFDCFFEIPCD = this;
				HLJEEFIJCOF = new WaitForEndOfFrame();
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				break;
			case 1u:
				GIJGINKBMCP = Screen.width;
				KDJLNLIACAP = Screen.height;
				DHJNPMPDBDA = new Texture2D(GIJGINKBMCP, KDJLNLIACAP, TextureFormat.RGB24, false);
				DHJNPMPDBDA.ReadPixels(new Rect(0f, 0f, GIJGINKBMCP, KDJLNLIACAP), 0, 0);
				DHJNPMPDBDA.Apply();
				HLJEEFIJCOF = new WaitForEndOfFrame();
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 2;
				}
				break;
			case 2u:
				OJJFCDEBHLF = DHJNPMPDBDA.EncodeToPNG();
				UnityEngine.Object.Destroy(DHJNPMPDBDA);
				DHAHOBCEAKG = new WWWForm();
				DHAHOBCEAKG.AddField(KPHCHDHEKGH.BHCIEFHBOPB.UploadScreenshotName, KPHCHDHEKGH.GPJONKKMEKD);
				DHAHOBCEAKG.AddBinaryData(KPHCHDHEKGH.BHCIEFHBOPB.UploaddScreenshotFile, OJJFCDEBHLF);
				DKOBKNHODMO.GDIFBJBOCJM = new WWW(KPHCHDHEKGH.BIJHBGLFDAP + KPHCHDHEKGH.BHCIEFHBOPB.UploaddScreenshot, DHAHOBCEAKG);
				FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(DKOBKNHODMO.BEKJDJFLJJC);
				HLJEEFIJCOF = DKOBKNHODMO.GDIFBJBOCJM;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 3;
				}
				break;
			case 3u:
				FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(DKOBKNHODMO.PMBKBKJIIPO);
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	public IBEPICCMOCK IJIMIDACOOL;

	public EHDGDCFLFBE BJCHPDPADMK;

	public string HLPNOMCCCKD;

	internal bool GEIGNOAKBEP;

	internal bool IGPPHPINEOI;

	private bool BNOKFFHMOJJ;

	private bool PIKEJKMABHA;

	private bool CHIIGOHCCHH;

	private bool EAAGMHKCPCM;

	internal bool EHAGHHJANMF;

	internal bool KIAPJFGPAME;

	public bool FDFIHADJLAO;

	public bool PBPPMJLAODE;

	public bool HJMJAHOBJND;

	internal int IMHMMKJKCBK;

	internal int? PKBJHIBOIMM;

	private int NDEFDFEDKFL;

	private int FGKNGGICNFB;

	internal static int JAPPMNIGMOG;

	internal static int JNDJIDDPCME;

	internal static int NKPNJDBLBAI;

	internal static int EAAHOGDOKND;

	internal static int CHOJEDHPCMN = 1;

	public float KEEOGKIBGCO = 2f;

	public ObscuredFloat LIMCHPFAJHC = ObscuredFloat.FNIPJFGEFFD(4f);

	internal float EGBIDFJOJJE = float.MinValue;

	private float? LAIOLFNFEBN;

	private float? HPFMKOLHJLN;

	private float? JBDBMEAPIMC;

	private float? FIGODLIKLMN;

	private float? HEJHNCHJOJE;

	private float? GBOCHHBDJHK;

	private float? CFOKCPPNNKL;

	public string PBKOADAIOGF;

	public ObscuredInt EBDDPFMJGCO;

	public string NHFIJHBHCGO;

	public string JAIHLALJHHO;

	public string PDDELHFGPNK;

	public string MHCPAFPDMGO;

	public string DIFJMNBNFEN;

	public string KKECGAFLPLJ;

	public string NDFPLDPNNMG;

	public string LAMLNFNHFCF;

	public string FBEIOJNLJAD = string.Empty;

	public int KNBFEKNJDHF = -5;

	public int BMCFEONOPJB = 5;

	private string AGEJEPNLEHL;

	private string FBDPFIDNILM;

	private string BMPDDJECPGE;

	private string HAMALJNDBLC;

	private string FEBCGHJOJIE;

	private string MPPMLJGCOFC;

	private string HPJBBIFLBJH;

	internal string NEJPKFAKOGO = string.Empty;

	public string[] HFFHMPJFIAE;

	public string[] NEKEPCHBFPL;

	public string[] AAJJJOONGJB;

	internal List<string> FAMKGFFBIME = new List<string>();

	public GameSoundsObject HLEOCDKAKMJ;

	public new NCGNCLMDIKB BEHFNEAKDAL;

	public FDGPLHOFOEN IFLCIAMAFAL;

	public Font ODFFBHMOJAA;

	public GUISkin HKFHMOLHBGM;

	public GUISkin KPFKCKDHIFE;

	public GUIText LIEKABKEJOG;

	public GUIText NABKAAPMFAO;

	public DateTime? OPJPOHHMIPC;

	public BEJHFGDPDLI JDFKPOMKMNJ = new BEJHFGDPDLI();

	public BEJHFGDPDLI CMEFDJLJODE = new BEJHFGDPDLI();

	public Texture2D[] OGBANGJIOGG;

	public UnityEngine.Object[] PMLHDDBDKDE;

	public AudioClip HMHHBHNOLEM;

	public IMCJHBIFEAK DNHLBGLJBBD;

	public Material PKAMMNLNMJA;

	public Material KFLJHHCLICH;

	public Material GONADMGJENH;

	public Material HALJJFLCNFG;

	public Material EBFHOGEICPE;

	public WWW ILJOBCIBPBJ;

	public bool HHHPAGPAPPF;

	internal LIFMGPEMIBO CDKNILAFIKI;

	private StringBuilder FMLLJHBHGID = new StringBuilder();

	private Vector2 LOADKHHJCDK;

	public FKLLHKLPIDE CODBKMAMEHL;

	public LBIKOOKJNPJ FCFCLEJNAGI;

	public PKOGMCMAHON DFDEMPKPIMK;

	public ObscuredString BAJMNNGLLPG;

	public ObscuredString EFHKDJENFGF;

	public ObscuredString CMGNHPKMAEH;

	public ObscuredString MOAJNIGKHND;

	public string[] DFJGGHLGPEP;

	internal string[] PLCNLNLHHND;

	public List<string> HAGGFHKMNJG = new List<string>();

	public List<AKMCGPMIBPN> DIMLDJIBEOB = new List<AKMCGPMIBPN>();

	public List<string> DOPDNNMJMHO = new List<string>();

	public List<string> MLCAJKEMIIB = new List<string>();

	public List<string> MCKBPMNFNAD = new List<string>();

	public List<string> JANKNNJPOCL = new List<string>();

	internal List<string> PKLNHOEOKBH = new List<string>();

	public Dictionary<string, string> GONADBNJCNH;

	internal bool ODECOFAOJAF;

	internal PresetSettings HLDBDOIEIIK;

	internal bool GLLABHFOBEI;

	public float MNNLFCILJHM;

	internal bool DKHCDLFJMPA;

	public float HLIOOMPKGIF;

	public EGIKKDBEKML MGIJCPBGLAM;

	public ALFOCCGOKEK FAPLGJOHDGD;

	public LPOPPAECGCE HPMNDJHHJIO;

	private bool DHGLEHNHAMJ;

	public bool GGHONDPCMMA;

	public float IBBEADDNCGF;

	private bool? LAENDHNLDDO;

	private bool? DJABDEMHCPI;

	private bool? APDDJJCCLIC;

	private bool? GNAOLJODGBL;

	private bool? EIJMODCEFPC;

	private bool? KAABDFGELAB;

	private bool? BNDFPFPOPKH;

	private bool? FPMNNHCAGPD;

	private bool? OBKEAGONEEK;

	private bool? JKGCBMDKJMH;

	private bool? DEGFDCNGOGC;

	private bool? GBLOLBHOOKI;

	private bool? IEMPHAKHCEJ;

	private bool? IELMILMBPAE;

	private bool? NCMADJOFCLA;

	private bool? PHBMBAHDIPN;

	private bool? LKGBMPHACPB;

	private bool? BEGEEAMCCPB;

	private bool? DDKLFPKFHGJ;

	private bool? DOBKNJCJHCL;

	internal bool? EAPNLIMNCOK;

	internal bool? DKLHCPOGOBI;

	private string NEKGKDNKLFO;

	private bool? BJJGGKIOLOC;

	public Dictionary<string, float> PLOHPAEKDHN = new Dictionary<string, float>();

	public Dictionary<string, string> CDLHHDAOOPA = new Dictionary<string, string>();

	[CompilerGenerated]
	private static Func<Resolution, string> ACJNADIPOMC;

	[CompilerGenerated]
	private static Func<Texture, float> HJJBAKLDAEB;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> MPCENNEMFPB;

	public bool DNNNAGAOKJC
	{
		get
		{
			return (DateTime.Now - ENIEEBOOKEL).TotalDays < 1.0;
		}
	}

	public bool GIOACCEINCF
	{
		get
		{
			return CODBKMAMEHL.enabled || DFDEMPKPIMK.enabled || FCFCLEJNAGI.enabled;
		}
	}

	public ObscuredBool GDBJMGHGPBA
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.Classic);
		}
	}

	public ObscuredBool KBGDFEDOIJJ
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.TDM || DNHLBGLJBBD == IMCJHBIFEAK.CTF || DNHLBGLJBBD == IMCJHBIFEAK.DeathMatch || DNHLBGLJBBD == IMCJHBIFEAK.Juggernaut || DNHLBGLJBBD == IMCJHBIFEAK.ECACNDFNADN);
		}
	}

	public ObscuredBool DIKFFLBGJDE
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.DeathMatch);
		}
	}

	public ObscuredBool FHEIEHKHDHL
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.Survival || DNHLBGLJBBD == IMCJHBIFEAK.ECACNDFNADN);
		}
	}

	public ObscuredBool GDFHLAHHCME
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.Survival);
		}
	}

	public ObscuredBool NJMJONEFFLP
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.Survival || DNHLBGLJBBD == IMCJHBIFEAK.ECACNDFNADN || base.JNPCOJFBJGP);
		}
	}

	public ObscuredBool ECACNDFNADN
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.ECACNDFNADN);
		}
	}

	public ObscuredBool FIDHEJHJKMP
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(DNHLBGLJBBD == IMCJHBIFEAK.CTF);
		}
	}

	public ObscuredBool FJAJABCHEMI
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD == IMCJHBIFEAK.ZombieMode);
		}
	}

	public ObscuredBool NBFGNGGJDNB
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD == IMCJHBIFEAK.Juggernaut);
		}
	}

	public ObscuredBool DFCJBJLBABJ
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.AEIBIFEDBFB("ColorPlayer2"));
		}
		set
		{
			FOGIOGKLNIP.EDFAGIMHLFA("ColorPlayer2", ObscuredBool.FNIPJFGEFFD(value));
		}
	}

	public ObscuredBool FMMCPMGODMO
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.ICLCHCGKAPN("AutoFullScreen") == 1);
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("AutoFullScreen", ObscuredBool.FNIPJFGEFFD(value) ? 1 : 0);
		}
	}

	public ObscuredBool HAAKPBDMIDN
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.ICLCHCGKAPN("AutoLogin") == 1);
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("AutoLogin", ObscuredBool.FNIPJFGEFFD(value) ? 1 : 0);
		}
	}

	public ObscuredBool JGJGKDGFFAA
	{
		get
		{
			return BEHFNEAKDAL.IBPALGFPAKO.JGJGKDGFFAA;
		}
	}

	internal bool KDOPJMADIAL
	{
		get
		{
			return false;
		}
	}

	public GUISkin EPDKDICMOHH
	{
		get
		{
			return (!FOGIOGKLNIP.DGMBIMMABNO || !BNMAONPAJBO) ? HKFHMOLHBGM : KPFKCKDHIFE;
		}
	}

	public DateTime ENIEEBOOKEL
	{
		get
		{
			DateTime? oPJPOHHMIPC = OPJPOHHMIPC;
			if (oPJPOHHMIPC.HasValue)
			{
				return OPJPOHHMIPC.Value;
			}
			DateTime result;
			if (!DateTime.TryParse(FOGIOGKLNIP.CEKCOJEJPAN("DatePlay", string.Empty), out result))
			{
				ENIEEBOOKEL = DateTime.Now;
				OPJPOHHMIPC = DateTime.Now;
				return DateTime.Now;
			}
			OPJPOHHMIPC = result;
			return result;
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("DatePlay", value.ToString(CultureInfo.InvariantCulture));
		}
	}

	public string DKPGCEABLDP
	{
		get
		{
			return FOGIOGKLNIP.LMMFHEODOPM.DKPGCEABLDP;
		}
		set
		{
			FOGIOGKLNIP.LMMFHEODOPM.DKPGCEABLDP = value;
		}
	}

	public float JPNLKCBPIED
	{
		get
		{
			return FOGIOGKLNIP.CMBFGIGIDIP("SoundVolume", 1f);
		}
		set
		{
			FOGIOGKLNIP.DEJNFKMKPKN("SoundVolume", value);
		}
	}

	public int CPMLPMOOKCP
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("iosKills");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("iosKills", value);
		}
	}

	public int GKEINLKJHMP
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("iosBotKills");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("iosBotKills", value);
		}
	}

	public int PHKHCLDIDII
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("ScreenWidth", 1024);
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("ScreenWidth", value);
		}
	}

	public int JFIHPKDAJGE
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("ScreenHeight", 768);
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("ScreenHeight", value);
		}
	}

	public string LMPOJOBJNJO
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("ip", string.Empty);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("ip", value);
		}
	}

	public string EHDHGCLEKMI
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("updatedTime", string.Empty);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("updatedTime", value);
		}
	}

	public string KPBILNDCOPL
	{
		set
		{
			CODBKMAMEHL.PBADCKNDABE(string.Empty, value, "OK", true);
		}
	}

	public string NOFFNEEHPED
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("LastError", string.Empty);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("LastError", value);
		}
	}

	internal string BIJHBGLFDAP
	{
		get
		{
			return FOGIOGKLNIP.LMMFHEODOPM.MHOHCMOOGCC ? "http://localhost/server/" : ((!FOGIOGKLNIP.OMMLFOEPEEK) ? FOGIOGKLNIP.CEKCOJEJPAN("mainsite", LAMLNFNHFCF) : LAMLNFNHFCF);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("mainsite", value);
		}
	}

	internal string ALOMJBBEPNK
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("Country", "hz");
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("Country", value);
		}
	}

	internal string IIGIKNBFIKL
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("SelectedLang", ALOMJBBEPNK);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("SelectedLang", value);
		}
	}

	public bool CACDJKOKMKF
	{
		get
		{
			bool? nCMADJOFCLA = NCMADJOFCLA;
			bool value;
			if (nCMADJOFCLA.HasValue)
			{
				value = nCMADJOFCLA.Value;
			}
			else
			{
				bool? flag = (NCMADJOFCLA = FOGIOGKLNIP.ICLCHCGKAPN("EnableNoiseRemover", 1) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			NCMADJOFCLA = value;
			FOGIOGKLNIP.BBKFOHCEOCK("EnableNoiseRemover", value ? 1 : 0);
		}
	}

	public bool DLELCCHDHCF
	{
		get
		{
			bool? pHBMBAHDIPN = PHBMBAHDIPN;
			bool value;
			if (pHBMBAHDIPN.HasValue)
			{
				value = pHBMBAHDIPN.Value;
			}
			else
			{
				bool? flag = (PHBMBAHDIPN = FOGIOGKLNIP.ICLCHCGKAPN("WeaponAutoSwitch", 1) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			PHBMBAHDIPN = value;
			FOGIOGKLNIP.BBKFOHCEOCK("WeaponAutoSwitch", value ? 1 : 0);
		}
	}

	public bool JDLEAJFAMMG
	{
		get
		{
			bool? lKGBMPHACPB = LKGBMPHACPB;
			bool value;
			if (lKGBMPHACPB.HasValue)
			{
				value = lKGBMPHACPB.Value;
			}
			else
			{
				bool? flag = (LKGBMPHACPB = FOGIOGKLNIP.ICLCHCGKAPN("EnableSmooth") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			LKGBMPHACPB = value;
			FOGIOGKLNIP.BBKFOHCEOCK("EnableSmooth", value ? 1 : 0);
		}
	}

	public bool HNCIPILFFHF
	{
		get
		{
			bool? bEGEEAMCCPB = BEGEEAMCCPB;
			bool value;
			if (bEGEEAMCCPB.HasValue)
			{
				value = bEGEEAMCCPB.Value;
			}
			else
			{
				bool? flag = (BEGEEAMCCPB = FOGIOGKLNIP.ICLCHCGKAPN("disableLights") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			BEGEEAMCCPB = value;
			FOGIOGKLNIP.BBKFOHCEOCK("disableLights", value ? 1 : 0);
		}
	}

	public bool KANOGBJDGOD
	{
		get
		{
			bool? dDKLFPKFHGJ = DDKLFPKFHGJ;
			bool value;
			if (dDKLFPKFHGJ.HasValue)
			{
				value = dDKLFPKFHGJ.Value;
			}
			else
			{
				bool? flag = (DDKLFPKFHGJ = FOGIOGKLNIP.ICLCHCGKAPN("DisableHeadShotSound") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			DDKLFPKFHGJ = value;
			FOGIOGKLNIP.BBKFOHCEOCK("DisableHeadShotSound", value ? 1 : 0);
		}
	}

	public bool COONIIIICJK
	{
		get
		{
			bool? dOBKNJCJHCL = DOBKNJCJHCL;
			bool value;
			if (dOBKNJCJHCL.HasValue)
			{
				value = dOBKNJCJHCL.Value;
			}
			else
			{
				bool? flag = (DOBKNJCJHCL = FOGIOGKLNIP.ICLCHCGKAPN("EnableBulletEffect", 1) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			DOBKNJCJHCL = value;
			FOGIOGKLNIP.BBKFOHCEOCK("EnableBulletEffect", value ? 1 : 0);
		}
	}

	public bool MDMGBLDECOP
	{
		get
		{
			bool? gBLOLBHOOKI = GBLOLBHOOKI;
			bool value;
			if (gBLOLBHOOKI.HasValue)
			{
				value = gBLOLBHOOKI.Value;
			}
			else
			{
				bool? flag = (GBLOLBHOOKI = FOGIOGKLNIP.ICLCHCGKAPN("DisableAnims") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			GBLOLBHOOKI = value;
			FOGIOGKLNIP.BBKFOHCEOCK("DisableAnims", value ? 1 : 0);
		}
	}

	public bool BNMAONPAJBO
	{
		get
		{
			bool? lAENDHNLDDO = LAENDHNLDDO;
			bool value;
			if (lAENDHNLDDO.HasValue)
			{
				value = lAENDHNLDDO.Value;
			}
			else
			{
				bool? flag = (LAENDHNLDDO = FOGIOGKLNIP.ICLCHCGKAPN("BigButtons", 1) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			LAENDHNLDDO = value;
			FOGIOGKLNIP.BBKFOHCEOCK("BigButtons", value ? 1 : 0);
		}
	}

	public bool FKLGOCGMGAM
	{
		get
		{
			bool? dJABDEMHCPI = DJABDEMHCPI;
			bool value;
			if (dJABDEMHCPI.HasValue)
			{
				value = dJABDEMHCPI.Value;
			}
			else
			{
				bool? flag = (DJABDEMHCPI = FOGIOGKLNIP.ICLCHCGKAPN("InSpace") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			DJABDEMHCPI = value;
			FOGIOGKLNIP.BBKFOHCEOCK("InSpace", value ? 1 : 0);
		}
	}

	public bool AICIJPIMOLH
	{
		get
		{
			bool? aPDDJJCCLIC = APDDJJCCLIC;
			bool value;
			if (aPDDJJCCLIC.HasValue)
			{
				value = aPDDJJCCLIC.Value;
			}
			else
			{
				bool? flag = (APDDJJCCLIC = FOGIOGKLNIP.ICLCHCGKAPN("touch2", (!FOGIOGKLNIP.LFENOGAECJD) ? 1 : 0) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			APDDJJCCLIC = value;
			FOGIOGKLNIP.BBKFOHCEOCK("touch2", value ? 1 : 0);
		}
	}

	public bool NGIPHFLPPCH
	{
		get
		{
			bool? iEMPHAKHCEJ = IEMPHAKHCEJ;
			bool value;
			if (iEMPHAKHCEJ.HasValue)
			{
				value = iEMPHAKHCEJ.Value;
			}
			else
			{
				bool? flag = (IEMPHAKHCEJ = FOGIOGKLNIP.ICLCHCGKAPN("ShootOnDoubleTouch2") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			IEMPHAKHCEJ = value;
			FOGIOGKLNIP.BBKFOHCEOCK("ShootOnDoubleTouch2", value ? 1 : 0);
		}
	}

	public bool NCJHLHGHGGI
	{
		get
		{
			bool? gNAOLJODGBL = GNAOLJODGBL;
			bool value;
			if (gNAOLJODGBL.HasValue)
			{
				value = gNAOLJODGBL.Value;
			}
			else
			{
				bool? flag = (GNAOLJODGBL = FOGIOGKLNIP.ICLCHCGKAPN("DoubleTouchJump2") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			GNAOLJODGBL = value;
			FOGIOGKLNIP.BBKFOHCEOCK("DoubleTouchJump2", value ? 1 : 0);
		}
	}

	public bool HFMHEMNBNPK
	{
		get
		{
			bool? eIJMODCEFPC = EIJMODCEFPC;
			bool value;
			if (eIJMODCEFPC.HasValue)
			{
				value = eIJMODCEFPC.Value;
			}
			else
			{
				bool? flag = (EIJMODCEFPC = FOGIOGKLNIP.ICLCHCGKAPN("MobileSkins2", base.MJEAIGGPIKN ? 1 : 0) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			EIJMODCEFPC = value;
			FOGIOGKLNIP.BBKFOHCEOCK("MobileSkins2", value ? 1 : 0);
		}
	}

	public bool LHLPDGMPKCG
	{
		get
		{
			bool? kAABDFGELAB = KAABDFGELAB;
			bool value;
			if (kAABDFGELAB.HasValue)
			{
				value = kAABDFGELAB.Value;
			}
			else
			{
				bool? flag = (KAABDFGELAB = FOGIOGKLNIP.ICLCHCGKAPN("DisableRiggedBodies3") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			KAABDFGELAB = value;
			FOGIOGKLNIP.BBKFOHCEOCK("DisableRiggedBodies3", value ? 1 : 0);
		}
	}

	public bool PPBEICAAFBD
	{
		get
		{
			bool? dEGFDCNGOGC = DEGFDCNGOGC;
			bool value;
			if (dEGFDCNGOGC.HasValue)
			{
				value = dEGFDCNGOGC.Value;
			}
			else
			{
				bool? flag = (DEGFDCNGOGC = FOGIOGKLNIP.ICLCHCGKAPN("ShowAvatars", (!FOGIOGKLNIP.DGMBIMMABNO) ? 1 : 0) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			DEGFDCNGOGC = value;
			FOGIOGKLNIP.BBKFOHCEOCK("ShowAvatars", value ? 1 : 0);
		}
	}

	public bool MOIFEJDLHOK
	{
		get
		{
			bool? bNDFPFPOPKH = BNDFPFPOPKH;
			bool value;
			if (bNDFPFPOPKH.HasValue)
			{
				value = bNDFPFPOPKH.Value;
			}
			else
			{
				bool? flag = (BNDFPFPOPKH = FOGIOGKLNIP.ICLCHCGKAPN("EnableBlood", 1) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			BNDFPFPOPKH = value;
			FOGIOGKLNIP.BBKFOHCEOCK("EnableBlood", value ? 1 : 0);
		}
	}

	public int EMFJACGNHEJ
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("PresetSettings");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("PresetSettings", value);
		}
	}

	public bool AJGOGHOEFIH
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("EnableQuakeSounds");
		}
		set
		{
			FOGIOGKLNIP.EDFAGIMHLFA("EnableQuakeSounds", value);
		}
	}

	public bool COKMEOGCMBJ
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("DisableRadar");
		}
		set
		{
			FOGIOGKLNIP.EDFAGIMHLFA("DisableRadar", value);
		}
	}

	public int NPNFEBBLGBM
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("PixelLightCount");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("PixelLightCount", value);
		}
	}

	public int AALDBAOHNJK
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("TextureQuality");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("TextureQuality", value);
		}
	}

	public int KNPLLEIIJNK
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("AnisotropicFiltering");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("AnisotropicFiltering", value);
		}
	}

	public int GCPLACLAKKH
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("targetFrameRate", 60);
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("targetFrameRate", value);
		}
	}

	public int KNJEMOMJBHC
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("AntiAliasing");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("AntiAliasing", value);
		}
	}

	public int KLHMPJBEJIA
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("ShadowProjection");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("ShadowProjection", value);
		}
	}

	public bool JCFBLCHKBPO
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("DisableDynamicCrosshair");
		}
		set
		{
			FOGIOGKLNIP.EDFAGIMHLFA("DisableDynamicCrosshair", value);
		}
	}

	public int IPGDADMKHBI
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("redCrosshair");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("redCrosshair", value);
		}
	}

	public int DPKFCDBODHB
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("greenCrosshair");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("greenCrosshair", value);
		}
	}

	public int KDOJPMAILED
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("blueCrosshair");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("blueCrosshair", value);
		}
	}

	public int JDJOIFBLOCJ
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("alphaCrosshair");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("alphaCrosshair", value);
		}
	}

	public float KGOMBPAOCFJ
	{
		get
		{
			return FOGIOGKLNIP.CMBFGIGIDIP("cLength");
		}
		set
		{
			FOGIOGKLNIP.DEJNFKMKPKN("cLength", value);
		}
	}

	public float BCGCADMJKCN
	{
		get
		{
			return FOGIOGKLNIP.CMBFGIGIDIP("cWidth");
		}
		set
		{
			FOGIOGKLNIP.DEJNFKMKPKN("cWidth", value);
		}
	}

	public float PBAMBLHDMFN
	{
		get
		{
			return FOGIOGKLNIP.CMBFGIGIDIP("borderSize");
		}
		set
		{
			FOGIOGKLNIP.DEJNFKMKPKN("borderSize", value);
		}
	}

	public bool DEFMNAPCCJP
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("FireToScope");
		}
		set
		{
			FOGIOGKLNIP.EDFAGIMHLFA("FireToScope", value);
		}
	}

	public int AOGMLGLJCOJ
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("AlphaColorControls");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("AlphaColorControls", value);
		}
	}

	public int NAOGCJNODFD
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("ShadowCascades");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("ShadowCascades", value);
		}
	}

	public float OABMHDAFACP
	{
		get
		{
			return FOGIOGKLNIP.CMBFGIGIDIP("ShadowDistance");
		}
		set
		{
			FOGIOGKLNIP.DEJNFKMKPKN("ShadowDistance", value);
		}
	}

	public int AMJMDOEJODJ
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("Blend Weight");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("Blend Weight", value);
		}
	}

	public int JMDMDFAFLKH
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("VSyncCount");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("VSyncCount", value);
		}
	}

	public float IGIMPALINNK
	{
		get
		{
			return FOGIOGKLNIP.CMBFGIGIDIP("LodBias");
		}
		set
		{
			FOGIOGKLNIP.DEJNFKMKPKN("LodBias", value);
		}
	}

	public int LOKEEGHKNAN
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("ParticleRaycastBudjet");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("ParticleRaycastBudjet", value);
		}
	}

	public int EMAKHKAILGI
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("RenderingMode");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("RenderingMode", value);
		}
	}

	public bool FDCJJPMBMDL
	{
		get
		{
			bool? oBKEAGONEEK = OBKEAGONEEK;
			bool value;
			if (oBKEAGONEEK.HasValue)
			{
				value = oBKEAGONEEK.Value;
			}
			else
			{
				bool? flag = (OBKEAGONEEK = FOGIOGKLNIP.ICLCHCGKAPN("EnableEffects2", 1) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			OBKEAGONEEK = value;
			FOGIOGKLNIP.BBKFOHCEOCK("EnableEffects2", value ? 1 : 0);
		}
	}

	public bool JBKEJALNEPA
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("MotionBlur");
		}
		set
		{
			if (value != JBKEJALNEPA && FOGIOGKLNIP.PIOANBBCFFP != null)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JBKEJALNEPA.enabled = value;
			}
			FOGIOGKLNIP.EDFAGIMHLFA("MotionBlur", value);
		}
	}

	public bool BIGHBGFEKDA
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("Tilt");
		}
		set
		{
			if (FOGIOGKLNIP.PIOANBBCFFP != null && BIGHBGFEKDA != value)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.BIGHBGFEKDA.enabled = value;
			}
			FOGIOGKLNIP.EDFAGIMHLFA("Tilt", value);
		}
	}

	public bool JPIAKBLNOKB
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("Contrast", true);
		}
		set
		{
			if (FOGIOGKLNIP.PIOANBBCFFP != null && JPIAKBLNOKB != value)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.BNAJCBLBADI.enabled = value;
			}
			FOGIOGKLNIP.EDFAGIMHLFA("Contrast", value);
		}
	}

	public bool OHJEFFLDDGE
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("GlobalKey", ODECOFAOJAF);
		}
		set
		{
			bool flag = OHJEFFLDDGE;
			FOGIOGKLNIP.EDFAGIMHLFA("GlobalKey", value);
			if (FOGIOGKLNIP.LPLJMLGKCLK != null && flag != value)
			{
				ODECOFAOJAF = value;
			}
		}
	}

	public bool FCHKEPDEHNG
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("EnableHighQuality3", base.MJEAIGGPIKN);
		}
		set
		{
			bool flag = FCHKEPDEHNG;
			FOGIOGKLNIP.EDFAGIMHLFA("EnableHighQuality3", value);
			if (FOGIOGKLNIP.NGFDFPGNDCJ != null && flag != value)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.NPHMFNGCHMF();
			}
		}
	}

	public bool IOPFGEHPNDP
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("SSAO");
		}
		set
		{
			if (FOGIOGKLNIP.PIOANBBCFFP != null && IOPFGEHPNDP != value)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.HANKMNMDLJJ.enabled = value;
			}
			FOGIOGKLNIP.EDFAGIMHLFA("SSAO", value);
		}
	}

	public bool BIIJNLIBIFJ
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("Bloom");
		}
		set
		{
			if (FOGIOGKLNIP.PIOANBBCFFP != null && BIIJNLIBIFJ != value)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.ALPMOODPECH.enabled = value;
			}
			FOGIOGKLNIP.EDFAGIMHLFA("Bloom", value);
		}
	}

	internal bool FJPCBLEEIOH
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("EnableSound", true);
		}
		set
		{
			if (value != FOGIOGKLNIP.LPLJMLGKCLK.FJPCBLEEIOH)
			{
				FOGIOGKLNIP.EDFAGIMHLFA("EnableSound", value);
				FOGIOGKLNIP.LPLJMLGKCLK.FJPCBLEEIOH = value;
				if (!value)
				{
					CGOCPOIKOCB();
				}
			}
		}
	}

	public int CODAPFIJMCK
	{
		get
		{
			int? pKBJHIBOIMM = PKBJHIBOIMM;
			int value;
			if (pKBJHIBOIMM.HasValue)
			{
				value = pKBJHIBOIMM.Value;
			}
			else
			{
				int? num = (PKBJHIBOIMM = FOGIOGKLNIP.ICLCHCGKAPN("MaxVisiblePlayers"));
				value = num.Value;
			}
			return value;
		}
		set
		{
			PKBJHIBOIMM = value;
			FOGIOGKLNIP.BBKFOHCEOCK("MaxVisiblePlayers", value);
		}
	}

	public float MDJJENIIEIK
	{
		get
		{
			float? jBDBMEAPIMC = JBDBMEAPIMC;
			float value;
			if (jBDBMEAPIMC.HasValue)
			{
				value = jBDBMEAPIMC.Value;
			}
			else
			{
				float? num = (JBDBMEAPIMC = FOGIOGKLNIP.CMBFGIGIDIP("NoiseRemover", 60f));
				value = num.Value;
			}
			return value;
		}
		set
		{
			JBDBMEAPIMC = value;
			FOGIOGKLNIP.DEJNFKMKPKN("NoiseRemover", value);
		}
	}

	public float AMMJIPDNCPG
	{
		get
		{
			float? fIGODLIKLMN = FIGODLIKLMN;
			float value;
			if (fIGODLIKLMN.HasValue)
			{
				value = fIGODLIKLMN.Value;
			}
			else
			{
				float? num = (FIGODLIKLMN = FOGIOGKLNIP.CMBFGIGIDIP("sx4", 1f));
				value = num.Value;
			}
			return value;
		}
		set
		{
			FIGODLIKLMN = value;
			FOGIOGKLNIP.DEJNFKMKPKN("sx4", value);
		}
	}

	public float GHEIOMKADNN
	{
		get
		{
			float? hEJHNCHJOJE = HEJHNCHJOJE;
			float value;
			if (hEJHNCHJOJE.HasValue)
			{
				value = hEJHNCHJOJE.Value;
			}
			else
			{
				float? num = (HEJHNCHJOJE = FOGIOGKLNIP.CMBFGIGIDIP("sy4", 1f));
				value = num.Value;
			}
			return value;
		}
		set
		{
			HEJHNCHJOJE = value;
			FOGIOGKLNIP.DEJNFKMKPKN("sy4", value);
		}
	}

	public float LHPIFFJKBPL
	{
		get
		{
			float? gBOCHHBDJHK = GBOCHHBDJHK;
			float value;
			if (gBOCHHBDJHK.HasValue)
			{
				value = gBOCHHBDJHK.Value;
			}
			else
			{
				float? num = (GBOCHHBDJHK = FOGIOGKLNIP.CMBFGIGIDIP("smoothIn4Scope", 0.3f));
				value = num.Value;
			}
			return value;
		}
		set
		{
			GBOCHHBDJHK = value;
			FOGIOGKLNIP.DEJNFKMKPKN("smoothIn4Scope", value);
		}
	}

	public float LMFBKPAKLAP
	{
		get
		{
			float? cFOKCPPNNKL = CFOKCPPNNKL;
			float value;
			if (cFOKCPPNNKL.HasValue)
			{
				value = cFOKCPPNNKL.Value;
			}
			else
			{
				float? num = (CFOKCPPNNKL = FOGIOGKLNIP.CMBFGIGIDIP("androidSmooth2", 0.85f));
				value = num.Value;
			}
			return value;
		}
		set
		{
			CFOKCPPNNKL = value;
			FOGIOGKLNIP.DEJNFKMKPKN("androidSmooth2", value);
		}
	}

	public float FOOCGCIEOIO
	{
		get
		{
			float? lAIOLFNFEBN = LAIOLFNFEBN;
			float value;
			if (lAIOLFNFEBN.HasValue)
			{
				value = lAIOLFNFEBN.Value;
			}
			else
			{
				float? num = (LAIOLFNFEBN = FOGIOGKLNIP.CMBFGIGIDIP("ping", 200f));
				value = num.Value;
			}
			return value;
		}
		set
		{
			LAIOLFNFEBN = value;
			FOGIOGKLNIP.DEJNFKMKPKN("ping", value);
		}
	}

	internal string GPJONKKMEKD
	{
		get
		{
			return NEKGKDNKLFO ?? (NEKGKDNKLFO = FOGIOGKLNIP.CEKCOJEJPAN("PlayerName2" + Application.platform, "Player" + UnityEngine.Random.Range(0, 9999)));
		}
		set
		{
			NEKGKDNKLFO = value;
			FOGIOGKLNIP.GKKEPIMNFBB("PlayerName2" + Application.platform, NEKGKDNKLFO);
			BEHFNEAKDAL.IBPALGFPAKO.NIGOGFAMFIB = NEKGKDNKLFO;
		}
	}

	internal string PGCILJPMKFB
	{
		get
		{
			return HAMALJNDBLC ?? (HAMALJNDBLC = FOGIOGKLNIP.CEKCOJEJPAN("email2" + Application.platform, string.Empty));
		}
		set
		{
			HAMALJNDBLC = value;
			FOGIOGKLNIP.GKKEPIMNFBB("email2" + Application.platform, HAMALJNDBLC);
		}
	}

	internal string JFIFKGEINNI
	{
		get
		{
			return FEBCGHJOJIE ?? (FEBCGHJOJIE = FOGIOGKLNIP.CEKCOJEJPAN("notes2", string.Empty));
		}
		set
		{
			FEBCGHJOJIE = value;
			FOGIOGKLNIP.GKKEPIMNFBB("notes2", FEBCGHJOJIE);
		}
	}

	internal string MHCPDOOKBCM
	{
		get
		{
			return MPPMLJGCOFC ?? (MPPMLJGCOFC = FOGIOGKLNIP.CEKCOJEJPAN("lastestVersion2", string.Empty));
		}
		set
		{
			MPPMLJGCOFC = value;
			FOGIOGKLNIP.GKKEPIMNFBB("lastestVersion2", MPPMLJGCOFC);
		}
	}

	internal string IIKAFLBAEML
	{
		get
		{
			return HPJBBIFLBJH ?? (HPJBBIFLBJH = FOGIOGKLNIP.CEKCOJEJPAN("playerPassword2", string.Empty));
		}
		set
		{
			HPJBBIFLBJH = value;
			FOGIOGKLNIP.GKKEPIMNFBB("playerPassword2", HPJBBIFLBJH);
		}
	}

	public bool FABPKKNPCBF
	{
		get
		{
			bool? bJJGGKIOLOC = BJJGGKIOLOC;
			bool value;
			if (bJJGGKIOLOC.HasValue)
			{
				value = bJJGGKIOLOC.Value;
			}
			else
			{
				bool? flag = (BJJGGKIOLOC = FOGIOGKLNIP.ICLCHCGKAPN("lockFire") == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			BJJGGKIOLOC = value;
			FOGIOGKLNIP.BBKFOHCEOCK("lockFire", value ? 1 : 0);
		}
	}

	public string CPDEKOKAOEE
	{
		get
		{
			return FOGIOGKLNIP.HJLAMDIBCDO.NNANOABLNMJ;
		}
		set
		{
			FOGIOGKLNIP.HJLAMDIBCDO.NNANOABLNMJ = value;
		}
	}

	public override void AILPFINEAEK()
	{
		base.AILPFINEAEK();
	}

	public override void Awake()
	{
		base.Awake();
		if (UnityEngine.Object.FindObjectsOfType(typeof(LAOFKFBJDGJ)).Length > 1)
		{
			base.enabled = false;
			UnityEngine.Object.DestroyImmediate(ICIEDCMDJFO);
			return;
		}
		FOGIOGKLNIP.LPLJMLGKCLK = this;
		SecureInt.started = true;
		FOGIOGKLNIP.LMMFHEODOPM.MBOGPAHFGMF();
		DIFJMNBNFEN = NOFFNEEHPED;
		Application.RegisterLogCallback(LLPAAKCFIGO);
		HEFNEJOEKNC.AFCLIGKFEFH = FOGIOGKLNIP.OMMLFOEPEEK;
		CKLGHCPEJIO(FOGIOGKLNIP.LPLJMLGKCLK.CPDEKOKAOEE);
		GONADBNJCNH = DKGBMMLALJL();
		DNHLBGLJBBD = IMCJHBIFEAK.Classic;
	}

	[DebuggerHidden]
	public IEnumerator Start()
	{
		NDAPJFCBMDD nDAPJFCBMDD = new NDAPJFCBMDD();
		nDAPJFCBMDD.KPHCHDHEKGH = this;
		return nDAPJFCBMDD;
	}

	public void CKLGHCPEJIO(string KLLKONMADKA)
	{
		Dictionary<string, float> dictionary = new Dictionary<string, float>();
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		try
		{
			string[] array = KLLKONMADKA.Split2();
			foreach (string text in array)
			{
				string[] array2 = text.Split('=');
				float result;
				if (float.TryParse(array2[1], out result))
				{
					if (!dictionary.ContainsKey(array2[0]))
					{
						dictionary.Add(array2[0], result);
					}
				}
				else if (!dictionary2.ContainsKey(array2[0]))
				{
					dictionary2.Add(array2[0], array2[1]);
				}
			}
			FOGIOGKLNIP.LPLJMLGKCLK.PLOHPAEKDHN = dictionary;
			FOGIOGKLNIP.LPLJMLGKCLK.CDLHHDAOOPA = dictionary2;
		}
		catch (Exception ex)
		{
			BKKHMNCDFLF(ex);
		}
	}

	public void DCEHIHHHCLE(string FPEOKHGBPDH)
	{
		string[] array = FPEOKHGBPDH.Split('|');
		HEFNEJOEKNC.MPPJKGBHFJK = array[1];
		HEFNEJOEKNC.NKKJKAJINBL = array[0];
		HEFNEJOEKNC.FGMKEDCMECI = array[2];
		HEFNEJOEKNC.AFCLIGKFEFH = true;
	}

	public void JBAFPDNCFPM(params object[] JDKLJHNJNLG)
	{
	}

	public void JBAFPDNCFPM(MonoBehaviour IDGNMFBAEED, params object[] JDKLJHNJNLG)
	{
	}

	public void Update()
	{
		FOGIOGKLNIP.OMMLFOEPEEK = FOGIOGKLNIP.LMMFHEODOPM.FMFBOFDMIOG;
		if (Input.GetKeyUp(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.Tab) && FOGIOGKLNIP.OMMLFOEPEEK)
		{
			UnityEngine.Debug.Break();
		}
		if (Input.GetMouseButtonDown(0))
		{
			IBBEADDNCGF = 0f;
		}
		else if (Input.GetMouseButton(0))
		{
			IBBEADDNCGF += new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")).magnitude;
		}
		FOGIOGKLNIP.EPBMIIPELPO.ACFFCBCMAKO();
		if (FOGIOGKLNIP.DGMBIMMABNO)
		{
			FOGIOGKLNIP.HJDAJDIIMPD = Input.touches;
		}
		if (JDFKPOMKMNJ.NFMIBMIGJMH((!FOGIOGKLNIP.OMMLFOEPEEK) ? 1000 : 100))
		{
			NDEFDFEDKFL = (int)JDFKPOMKMNJ.LIMEEBFFDFC();
		}
		if (JDFKPOMKMNJ.NFMIBMIGJMH(100) || FOGIOGKLNIP.OMMLFOEPEEK)
		{
			KKLOJNNJGLD();
		}
		if (FMLLJHBHGID.Length > 0)
		{
			FMLLJHBHGID = new StringBuilder();
			FMLLJHBHGID.AppendLine();
		}
		if (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.Home))
		{
			BEHFNEAKDAL.enabled = !BEHFNEAKDAL.enabled;
			BEHFNEAKDAL.IMDNCJODAEN = NCGNCLMDIKB.Menu.Chat;
			base.MDBAFPKAKKK = false;
		}
		if (JDFKPOMKMNJ.NFMIBMIGJMH(2000))
		{
			if (BEHFNEAKDAL.EPMOFPNGEAG && BEHFNEAKDAL.JBINCAPMEBD != null)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.NABKAAPMFAO.text = FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AccountPMs) + BEHFNEAKDAL.JBINCAPMEBD.IBAAPDEFEAB + ")";
			}
			FOGIOGKLNIP.LPLJMLGKCLK.NABKAAPMFAO.enabled = true;
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.NABKAAPMFAO.HitTest(Input.mousePosition))
		{
			if (Input.GetMouseButtonDown(0))
			{
				BEHFNEAKDAL.IMDNCJODAEN = NCGNCLMDIKB.Menu.Chat;
				BEHFNEAKDAL.enabled = !BEHFNEAKDAL.enabled;
			}
			FOGIOGKLNIP.LPLJMLGKCLK.NABKAAPMFAO.material.color = Color.green;
		}
		else
		{
			FOGIOGKLNIP.LPLJMLGKCLK.NABKAAPMFAO.material.color = Color.white;
		}
		if (BEHFNEAKDAL != null)
		{
			BEHFNEAKDAL.DGHNJLMEHLC();
		}
		if (Input.GetKeyDown(KeyCode.F12) || (Input.GetKeyDown(KeyCode.Return) && Input.GetKey(KeyCode.LeftAlt)))
		{
			EBLJPNFHNAI();
		}
		if (Input.GetKeyDown(KeyCode.Backslash))
		{
			if (FOGIOGKLNIP.GLNAMCPCICH.enabled)
			{
				FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
			}
			else
			{
				FBDPFIDNILM = null;
				FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(500, 500, base.FKICDOGJIFN.Console, NBOGOKNEBGI.IPBFPHDFNNH, BIAMBEAFLNB);
			}
		}
		if (FOGIOGKLNIP.EPBMIIPELPO.KJEDAPMICGD)
		{
			FOGIOGKLNIP.EFECLAMJIFH++;
		}
		if (FOGIOGKLNIP.EPBMIIPELPO.LKLNCHHHMBI)
		{
			FOGIOGKLNIP.EFECLAMJIFH--;
		}
		FOGIOGKLNIP.ENJKFFABFIL = 0;
		if (JEGLPMBDKGF())
		{
			FOGIOGKLNIP.ENJKFFABFIL = 1;
		}
		if (!Input.GetMouseButton(0))
		{
			FOGIOGKLNIP.AAAIGHEPLCD = 0f;
		}
		if (Input.GetKeyDown(KeyCode.F1))
		{
			FCFCLEJNAGI.enabled = !FCFCLEJNAGI.enabled;
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
		CMEFDJLJODE.OJFAJPLDPPK();
		if (MGIJCPBGLAM.OACFFKENAKG || FAPLGJOHDGD.OACFFKENAKG)
		{
			Application.Quit();
		}
	}

	private void KKLOJNNJGLD()
	{
		if (Profiler.enabled)
		{
			FGKNGGICNFB = (int)(Profiler.usedHeapSize / 1024000);
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (ObscuredBool.FNIPJFGEFFD(BEHFNEAKDAL.IBPALGFPAKO.POPPLIPEOGF) || base.FCFBGBPEPOL || FOGIOGKLNIP.OMMLFOEPEEK)
		{
			ANEANGKPJAE(stringBuilder);
		}
		else
		{
			stringBuilder.AppendLine(FOGIOGKLNIP.LMMFHEODOPM.GJPOFKBMIEE.ToString()).AppendLine(NDEFDFEDKFL.ToString());
			if (NKPNJDBLBAI > 0)
			{
				stringBuilder.AppendLine(NKPNJDBLBAI.ToString());
			}
		}
		if (FMLLJHBHGID.Length > 0)
		{
			stringBuilder.Append(FMLLJHBHGID);
		}
		LIEKABKEJOG.text = stringBuilder.ToString();
	}

	public static bool JEGLPMBDKGF()
	{
		return FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.RightShift) || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.G) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter);
	}

	public void GKONNOBAOKJ(string BCMIEDNPHMN)
	{
	}

	public void FPIHDMECCEO()
	{
		if (DKLHCPOGOBI == true)
		{
			foreach (Dictionary item in FOGIOGKLNIP.ICNGEHGPIFM)
			{
				if (FOGIOGKLNIP.MHFCLILDBCM(item.name, GUILayout.ExpandWidth(true)))
				{
					FOGIOGKLNIP.EFPKGAAFKFG = item;
					FOGIOGKLNIP.LPLJMLGKCLK.IIGIKNBFIKL = item.code;
					DKLHCPOGOBI = false;
					DFDEMPKPIMK.DLILAHLOKKC();
				}
			}
		}
		if (DKLHCPOGOBI == true)
		{
			return;
		}
		foreach (Dictionary item2 in FOGIOGKLNIP.ICNGEHGPIFM)
		{
			if (FOGIOGKLNIP.MHFCLILDBCM(item2.name, GUILayout.ExpandWidth(true)))
			{
				FOGIOGKLNIP.EFPKGAAFKFG = item2;
				FOGIOGKLNIP.LPLJMLGKCLK.IIGIKNBFIKL = item2.code;
			}
		}
	}

	public void IBEPICCMOCK()
	{
		FOGIOGKLNIP.IAOONCAPLGK(string.Format("{0} {1} {2} {3}", FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.SettingsVersion), FOGIOGKLNIP.LMMFHEODOPM.GJPOFKBMIEE, FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP, FOGIOGKLNIP.LMMFHEODOPM.NJAGHCNHJAO));
		if (HPMNDJHHJIO == LPOPPAECGCE.BLBOPPEBDFH)
		{
			if (ICJMBAECLIN() || CJAGICNCKCO())
			{
				return;
			}
			GUILayout.BeginHorizontal();
			if (!FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.MHFCLILDBCM(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.SettingsFullScreen) + base.FKICDOGJIFN.SettingsFullScreenF12))
			{
				EBLJPNFHNAI();
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.SettingsSetResolution))
			{
				CHIIGOHCCHH = true;
			}
			GUILayout.EndHorizontal();
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.SettingsSelectLanguage, GUILayout.ExpandWidth(true)))
			{
				MFEPFODPFHA(FPIHDMECCEO, 400, 500, string.Empty);
			}
			FOGIOGKLNIP.LPLJMLGKCLK.FJPCBLEEIOH = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LPLJMLGKCLK.FJPCBLEEIOH, base.FKICDOGJIFN.SettingsEnableSound);
			if (FOGIOGKLNIP.LPLJMLGKCLK.FJPCBLEEIOH)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.JPNLKCBPIED = JJCCBMNJNEF(base.FKICDOGJIFN.SettingsSoundVol, FOGIOGKLNIP.LPLJMLGKCLK.JPNLKCBPIED, 0f, 1f);
				AudioListener.volume = FOGIOGKLNIP.LPLJMLGKCLK.JPNLKCBPIED;
			}
			if (FOGIOGKLNIP.MHFCLILDBCM("Graphics Settings"))
			{
				HPMNDJHHJIO = LPOPPAECGCE.FBNOALALNHF;
			}
			if (FOGIOGKLNIP.MHFCLILDBCM("Game / Misc Settings"))
			{
				HPMNDJHHJIO = LPOPPAECGCE.IMHJBLKBPCG;
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.SettingsResetAllSettingstodefault))
			{
				CEAJGBPHELN();
				return;
			}
			if (FOGIOGKLNIP.OMMLFOEPEEK && FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.SettingsShowMemory))
			{
				EAAGMHKCPCM = !EAAGMHKCPCM;
			}
		}
		if (HPMNDJHHJIO == LPOPPAECGCE.FBNOALALNHF)
		{
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.CancelText))
			{
				HPMNDJHHJIO = LPOPPAECGCE.BLBOPPEBDFH;
			}
			FOGIOGKLNIP.LPLJMLGKCLK.CODAPFIJMCK = (int)JJCCBMNJNEF(base.FKICDOGJIFN.SettingsMaxVisiblePlayers, FOGIOGKLNIP.LPLJMLGKCLK.CODAPFIJMCK, 0f, 50f, 1f);
			if (FOGIOGKLNIP.PIOANBBCFFP != null && FOGIOGKLNIP.NGFDFPGNDCJ.MHBJNLEHIFC.shader.isSupported)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.MHBJNLEHIFC.enabled = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.NGFDFPGNDCJ.MHBJNLEHIFC.enabled, base.FKICDOGJIFN.Settingsbrightness) && FOGIOGKLNIP.NGFDFPGNDCJ.MHBJNLEHIFC.shader.isSupported;
				if (FOGIOGKLNIP.NGFDFPGNDCJ.MHBJNLEHIFC.enabled)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.MHBJNLEHIFC.brightness = JJCCBMNJNEF(base.FKICDOGJIFN.Settingsbrightness, FOGIOGKLNIP.NGFDFPGNDCJ.MHBJNLEHIFC.brightness, 1f, 2f);
				}
			}
			if (!FOGIOGKLNIP.DGMBIMMABNO)
			{
				JBKEJALNEPA = FOGIOGKLNIP.HGHFNJMFLHM(JBKEJALNEPA, base.FKICDOGJIFN.SettingsMotionblur);
				if (FOGIOGKLNIP.PIOANBBCFFP != null && JBKEJALNEPA)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.JBKEJALNEPA.Strength = 5200f - JJCCBMNJNEF(base.FKICDOGJIFN.SettingsMotionblur, 5200f - FOGIOGKLNIP.NGFDFPGNDCJ.JBKEJALNEPA.Strength, 0f, 5000f, 1f);
				}
				BIIJNLIBIFJ = FOGIOGKLNIP.HGHFNJMFLHM(BIIJNLIBIFJ, base.FKICDOGJIFN.SettingsBloom);
				if (FOGIOGKLNIP.PIOANBBCFFP != null && FOGIOGKLNIP.NGFDFPGNDCJ.ALPMOODPECH.enabled)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.ALPMOODPECH.bloomIntensity = JJCCBMNJNEF(base.FKICDOGJIFN.SettingsBloomIntensivity, FOGIOGKLNIP.NGFDFPGNDCJ.ALPMOODPECH.bloomIntensity, 0f, 1f);
				}
				IOPFGEHPNDP = FOGIOGKLNIP.HGHFNJMFLHM(IOPFGEHPNDP, base.FKICDOGJIFN.SettingsAmbientShadows);
				if (FOGIOGKLNIP.PIOANBBCFFP != null && FOGIOGKLNIP.NGFDFPGNDCJ.HANKMNMDLJJ.enabled)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.HANKMNMDLJJ.m_OcclusionIntensity = JJCCBMNJNEF(base.FKICDOGJIFN.SettingsAmbientShadowsintensivity, FOGIOGKLNIP.NGFDFPGNDCJ.HANKMNMDLJJ.m_OcclusionIntensity, 0f, 4f);
					FOGIOGKLNIP.NGFDFPGNDCJ.HANKMNMDLJJ.m_Radius = JJCCBMNJNEF(base.FKICDOGJIFN.SettingsAmbientShadowsRadius, FOGIOGKLNIP.NGFDFPGNDCJ.HANKMNMDLJJ.m_Radius, 0f, 1f);
				}
				JPIAKBLNOKB = FOGIOGKLNIP.HGHFNJMFLHM(JPIAKBLNOKB, base.FKICDOGJIFN.SettingsContrastEnhance);
				BIGHBGFEKDA = FOGIOGKLNIP.HGHFNJMFLHM(BIGHBGFEKDA, base.FKICDOGJIFN.SettingsTiltShift);
				if (FOGIOGKLNIP.PIOANBBCFFP != null && FOGIOGKLNIP.NGFDFPGNDCJ.BIGHBGFEKDA.enabled)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.BIGHBGFEKDA.maxBlurSize = 80f - JJCCBMNJNEF(base.FKICDOGJIFN.SettingsTiltShift, 80f - FOGIOGKLNIP.NGFDFPGNDCJ.BIGHBGFEKDA.maxBlurSize, 0f, 80f, 1f);
				}
			}
			AAEEEDGLDNA();
			CKDAEOBGOHB();
		}
		if (HPMNDJHHJIO == LPOPPAECGCE.IMHJBLKBPCG)
		{
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.CancelText))
			{
				HPMNDJHHJIO = LPOPPAECGCE.BLBOPPEBDFH;
			}
			MFAOJJJJLLH();
			if (FJPCBLEEIOH)
			{
				AJGOGHOEFIH = FOGIOGKLNIP.HGHFNJMFLHM(AJGOGHOEFIH, "Enable Quake Sounds (Firstblood & etc...)");
			}
			if (FOGIOGKLNIP.PIOANBBCFFP == null)
			{
				COKMEOGCMBJ = FOGIOGKLNIP.HGHFNJMFLHM(COKMEOGCMBJ, "Disable Radar (May increase game performance!)");
				LHLPDGMPKCG = FOGIOGKLNIP.HGHFNJMFLHM(LHLPDGMPKCG, "Disable Ragdoll Physics(Increases fps)");
			}
			AGOMNHKFDEF.HLDLJFOALII = FOGIOGKLNIP.HGHFNJMFLHM(AGOMNHKFDEF.HLDLJFOALII, base.FKICDOGJIFN.SettingsDisableChat);
			if (FOGIOGKLNIP.PIOANBBCFFP != null)
			{
				FOGIOGKLNIP.CIEBMCOJGCC.CDFEAMOFDPE = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.CIEBMCOJGCC.CDFEAMOFDPE, "Disable HUD");
				FOGIOGKLNIP.NGFDFPGNDCJ.EKEBFAPDBHJ.enabled = !FOGIOGKLNIP.CIEBMCOJGCC.CDFEAMOFDPE;
				float num = JJCCBMNJNEF(base.FKICDOGJIFN.SettingsFieldofView, FOGIOGKLNIP.NGFDFPGNDCJ.EKJHJPABMBB, 65f, 100f, 1f);
				if (FOGIOGKLNIP.NGFDFPGNDCJ.EKJHJPABMBB != num)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.EKJHJPABMBB = num;
					FOGIOGKLNIP.NGFDFPGNDCJ.KCMICODJAOD.fieldOfView = FOGIOGKLNIP.NGFDFPGNDCJ.EKJHJPABMBB / Mathf.Atan(815.48f / (2f * FOGIOGKLNIP.NGFDFPGNDCJ.EKJHJPABMBB));
					Camera.main.fieldOfView = (int)FOGIOGKLNIP.NGFDFPGNDCJ.EKJHJPABMBB;
				}
			}
			FOGIOGKLNIP.LPLJMLGKCLK.HFMHEMNBNPK = false;
			if ((FOGIOGKLNIP.DGMBIMMABNO | FOGIOGKLNIP.OMMLFOEPEEK) && FOGIOGKLNIP.PIOANBBCFFP != null)
			{
				Camera.main.useOcclusionCulling = FOGIOGKLNIP.HGHFNJMFLHM(Camera.main.useOcclusionCulling, base.FKICDOGJIFN.SettingsOcclusionculling);
			}
			FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL, base.FKICDOGJIFN.SettingsEnableEffects);
			FOGIOGKLNIP.LPLJMLGKCLK.COONIIIICJK = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LPLJMLGKCLK.COONIIIICJK, base.FKICDOGJIFN.SettingsEnableBulleteffect);
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.SettingsShowLog))
			{
				FBDPFIDNILM = null;
				PIKEJKMABHA = true;
				FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(500, 500, base.FKICDOGJIFN.Console, NBOGOKNEBGI.IPBFPHDFNNH, BIAMBEAFLNB);
			}
			FOGIOGKLNIP.LPLJMLGKCLK.HNCIPILFFHF = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LPLJMLGKCLK.HNCIPILFFHF, base.FKICDOGJIFN.SettingsdisableLights);
			bool flag = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LPLJMLGKCLK.FCFBGBPEPOL, base.FKICDOGJIFN.SettingsEnableLogging);
			if (flag != FOGIOGKLNIP.LPLJMLGKCLK.FCFBGBPEPOL)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.FCFBGBPEPOL = flag;
				BIHOCPAKHNF(base.FKICDOGJIFN.SettingsEnableLogging + flag);
			}
			FOGIOGKLNIP.LPLJMLGKCLK.MOIFEJDLHOK = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LPLJMLGKCLK.MOIFEJDLHOK, base.FKICDOGJIFN.SettingsEnableBlood);
			FOGIOGKLNIP.LPLJMLGKCLK.KANOGBJDGOD = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LPLJMLGKCLK.KANOGBJDGOD, base.FKICDOGJIFN.SettingsDisableHeadShotsound);
		}
		if (FOGIOGKLNIP.OMMLFOEPEEK && FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.Settingslist))
		{
			LKMIPEEKNFO lKMIPEEKNFO = new LKMIPEEKNFO();
			lKMIPEEKNFO.KPHCHDHEKGH = this;
			lKMIPEEKNFO.OCCOEHJFDKM = new StringBuilder();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				lKMIPEEKNFO.OCCOEHJFDKM.AppendLine(assembly.GetName().Name);
			}
			DFDEMPKPIMK.MFEPFODPFHA(600, 600, string.Empty, NBOGOKNEBGI.IPBFPHDFNNH, lKMIPEEKNFO.BEKJDJFLJJC);
		}
		if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.LeftControl))
		{
			FOGIOGKLNIP.OMMLFOEPEEK = GUILayout.Toggle(FOGIOGKLNIP.OMMLFOEPEEK, string.Empty);
		}
		else
		{
			GUILayout.Label(string.Empty);
		}
	}

	internal void MFEPFODPFHA(Action AEMBPMJMOAB, int GDIFBJBOCJM = 500, int MBIEHEGKCMN = 500, string MHCPAFPDMGO = "")
	{
		DFDEMPKPIMK.MFEPFODPFHA(GDIFBJBOCJM, MBIEHEGKCMN, MHCPAFPDMGO, NBOGOKNEBGI.IPBFPHDFNNH, AEMBPMJMOAB, null, true);
	}

	private bool CJAGICNCKCO()
	{
		if (CHIIGOHCCHH)
		{
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.BackText))
			{
				CHIIGOHCCHH = false;
			}
			if (!FOGIOGKLNIP.DGMBIMMABNO)
			{
				FOGIOGKLNIP.PHINLFLBAOJ();
				int num = GUILayout.SelectionGrid(-1, Screen.resolutions.SelectF((Resolution AEMBPMJMOAB) => AEMBPMJMOAB.width + "x" + AEMBPMJMOAB.height + "x" + AEMBPMJMOAB.refreshRate + "hz").ToArray(), 2);
				FOGIOGKLNIP.LKLLDMLLIML();
				if (num != -1)
				{
					FOGIOGKLNIP.LPLJMLGKCLK.PHKHCLDIDII = Screen.resolutions[num].width;
					FOGIOGKLNIP.LPLJMLGKCLK.JFIHPKDAJGE = Screen.resolutions[num].height;
					EBLJPNFHNAI();
					CHIIGOHCCHH = false;
				}
			}
			else
			{
				FOGIOGKLNIP.IAOONCAPLGK("Changing the resolution settings may result in poor game performance!");
				if (FOGIOGKLNIP.MHFCLILDBCM("Smaller Resolution"))
				{
					Screen.SetResolution(Screen.currentResolution.width / 2, Screen.currentResolution.height / 2, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("Bigger Resolution"))
				{
					Screen.SetResolution(Screen.currentResolution.width * 2, Screen.currentResolution.height * 2, true);
				}
				FOGIOGKLNIP.IAOONCAPLGK("4:3 ");
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 640×480"))
				{
					Screen.SetResolution(640, 480, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 800×600"))
				{
					Screen.SetResolution(800, 600, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 960×720"))
				{
					Screen.SetResolution(960, 720, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 1024×768"))
				{
					Screen.SetResolution(1024, 768, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 1280×960"))
				{
					Screen.SetResolution(1280, 960, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 1400×1050"))
				{
					Screen.SetResolution(1400, 1050, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 1440×1080"))
				{
					Screen.SetResolution(1440, 1080, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 1600×1200"))
				{
					Screen.SetResolution(1600, 1200, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 1856×1392"))
				{
					Screen.SetResolution(1856, 1392, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 1920×1440"))
				{
					Screen.SetResolution(1920, 1440, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("4:3 - 2048×1536"))
				{
					Screen.SetResolution(2048, 1536, true);
				}
				FOGIOGKLNIP.IAOONCAPLGK("16:10 ");
				if (FOGIOGKLNIP.MHFCLILDBCM("16:10 - 1280×800"))
				{
					Screen.SetResolution(1280, 800, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:10 - 1440×900"))
				{
					Screen.SetResolution(1440, 900, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:10 - 1680×1050"))
				{
					Screen.SetResolution(1680, 1050, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:10 - 1920×1200"))
				{
					Screen.SetResolution(1920, 1200, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:10 - 2560×1600"))
				{
					Screen.SetResolution(2560, 1600, true);
				}
				FOGIOGKLNIP.IAOONCAPLGK("16:9 ");
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 1024×576"))
				{
					Screen.SetResolution(1024, 576, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 1152×648"))
				{
					Screen.SetResolution(1152, 648, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 1280×720 (HD)"))
				{
					Screen.SetResolution(1280, 720, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 1366×768"))
				{
					Screen.SetResolution(1366, 768, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 1600×900"))
				{
					Screen.SetResolution(1600, 900, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 1920×1080 (FHD)"))
				{
					Screen.SetResolution(1920, 1080, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 2560×1440"))
				{
					Screen.SetResolution(2560, 1440, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 3840×2160 (4K)"))
				{
					Screen.SetResolution(3840, 2160, true);
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("16:9 - 7680 x 4320 (8K)"))
				{
					Screen.SetResolution(7680, 4320, true);
				}
			}
			return true;
		}
		return false;
	}

	public StringBuilder ICALMCIJBNG(bool KLCALOOGPJF = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(base.FKICDOGJIFN.ConsoleExitError).AppendLine(DIFJMNBNFEN);
		stringBuilder.AppendLine(base.FKICDOGJIFN.ConsoleLines);
		foreach (AKMCGPMIBPN item in DIMLDJIBEOB.TakeLast(20))
		{
			stringBuilder.AppendFormat(base.FKICDOGJIFN.ConsoleFormatGet1, item.EJBGEPJBLEN, item.LIPFHCDCKFG, (!KLCALOOGPJF) ? string.Empty : item.HOPOOBBEGND, (!KLCALOOGPJF) ? item.HLOAPHLPNJG.ToShortTimeString() : item.HLOAPHLPNJG.ToString());
		}
		ANEANGKPJAE(stringBuilder);
		return stringBuilder;
	}

	public void CGOCPOIKOCB()
	{
		UnityEngine.Object[] array = Resources.FindObjectsOfTypeAll(typeof(AudioClip));
		UnityEngine.Object[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			AudioClip assetToUnload = (AudioClip)array2[i];
			Resources.UnloadAsset(assetToUnload);
		}
	}

	public void EBLJPNFHNAI()
	{
		if (!Screen.fullScreen)
		{
			Screen.SetResolution(FOGIOGKLNIP.LPLJMLGKCLK.PHKHCLDIDII, FOGIOGKLNIP.LPLJMLGKCLK.JFIHPKDAJGE, true);
		}
		else
		{
			Screen.SetResolution(FOGIOGKLNIP.LPLJMLGKCLK.PHKHCLDIDII, FOGIOGKLNIP.LPLJMLGKCLK.JFIHPKDAJGE, false);
		}
	}

	public void LLPAAKCFIGO(string JBBAPHBEMJH, string HOPOOBBEGND, LogType EBMKGCIKJCA)
	{
		if (JBBAPHBEMJH == null)
		{
			return;
		}
		switch (EBMKGCIKJCA)
		{
		case LogType.Error:
			JNDJIDDPCME++;
			break;
		case LogType.Exception:
			NKPNJDBLBAI++;
			break;
		default:
			EAAHOGDOKND++;
			break;
		}
		FCFCLEJNAGI.JPHLNGJEFHF(JBBAPHBEMJH, HOPOOBBEGND, EBMKGCIKJCA);
		if ((NKPNJDBLBAI != 1 && NKPNJDBLBAI != 500) || EBMKGCIKJCA != LogType.Exception || !FOGIOGKLNIP.LFENOGAECJD)
		{
		}
		if (EBMKGCIKJCA == LogType.Exception)
		{
			AGEJEPNLEHL = JBBAPHBEMJH.Substring(0, Math.Min(JBBAPHBEMJH.Length, 80));
		}
		if (FOGIOGKLNIP.DGMBIMMABNO && DIMLDJIBEOB.Count > 20)
		{
			DIMLDJIBEOB.RemoveAt(0);
		}
		AKMCGPMIBPN item = new AKMCGPMIBPN
		{
			HLOAPHLPNJG = DateTime.Now,
			EJBGEPJBLEN = EBMKGCIKJCA,
			LIPFHCDCKFG = JBBAPHBEMJH,
			HOPOOBBEGND = HOPOOBBEGND
		};
		DIMLDJIBEOB.Add(item);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(base.FKICDOGJIFN.ConsoleOnLogAppendWarning).Append(JNDJIDDPCME).Append(base.FKICDOGJIFN.ConsoleOnLogAppendError)
			.Append(NKPNJDBLBAI)
			.Append(" Print:")
			.Append(EAAHOGDOKND)
			.AppendLine();
		NOFFNEEHPED = stringBuilder.Append(item.KKNHDKLDCHI()).ToString();
		if (Application.platform == RuntimePlatform.WebGLPlayer && (ALOMJBBEPNK == base.FKICDOGJIFN.Country || FOGIOGKLNIP.OMMLFOEPEEK))
		{
			string text = base.FKICDOGJIFN.ConsoleOnLogCallUnity + JBBAPHBEMJH + ((EBMKGCIKJCA != LogType.Exception) ? string.Empty : ("\r\n" + HOPOOBBEGND));
			string consoleOnLogCallConsole = base.FKICDOGJIFN.ConsoleOnLogCallConsole;
			string text2;
			switch (EBMKGCIKJCA)
			{
			case LogType.Exception:
				text2 = base.FKICDOGJIFN.ConsoleOnLogCallError;
				break;
			case LogType.Log:
				text2 = base.FKICDOGJIFN.ConsoleOnLogCallLog;
				break;
			default:
				text2 = base.FKICDOGJIFN.ConsoleOnLogCallWarn;
				break;
			}
			Application.ExternalCall(consoleOnLogCallConsole + text2, text);
		}
	}

	public Texture2D JNLFEKJBJKP(int ECKDHMKHHJJ)
	{
		if (ECKDHMKHHJJ == 0)
		{
			return FOGIOGKLNIP.LPLJMLGKCLK.OGBANGJIOGG[FOGIOGKLNIP.LPLJMLGKCLK.OGBANGJIOGG.Length - 1];
		}
		return FOGIOGKLNIP.LPLJMLGKCLK.OGBANGJIOGG[Mathf.Min(FOGIOGKLNIP.LPLJMLGKCLK.OGBANGJIOGG.Length - 1, JLHPEDEELDG(ECKDHMKHHJJ))];
	}

	public int JLHPEDEELDG(int ECKDHMKHHJJ)
	{
		int num = 0;
		int num2 = 0;
		int num3 = FOGIOGKLNIP.EELPLHEEEDB("rankInterval", 1);
		for (int i = 0; i < 10; i++)
		{
			num2 += num3;
			num += num2;
			if (ECKDHMKHHJJ <= num)
			{
				return i;
			}
		}
		return 10;
	}

	public void OnApplicationQuit()
	{
		FOGIOGKLNIP.CJOGLBBCDEC = true;
	}

	public string NGPOKCMGHPJ(string LGNIFJCEECH)
	{
		return Regex.Replace(LGNIFJCEECH.ToLower(), string.Format("{0}", base.FKICDOGJIFN.RegexTrimChars), string.Empty);
	}

	public static Dictionary<string, string> DKGBMMLALJL()
	{
		string empty = string.Empty;
		if (string.IsNullOrEmpty(empty) || empty.IndexOf("?", StringComparison.Ordinal) == -1 || empty.IndexOf("?", StringComparison.Ordinal) == empty.Length - 1)
		{
			return new Dictionary<string, string>();
		}
		empty = empty.Substring(empty.IndexOf("?", StringComparison.Ordinal) + 1);
		return JAGCLJJMALB(empty);
	}

	public static string LNIJEHIBMOL(Dictionary<string, string> ENDBDAIKKEE)
	{
		string text = string.Empty;
		bool flag = true;
		foreach (KeyValuePair<string, string> item in ENDBDAIKKEE)
		{
			string text2 = text;
			text = text2 + ((!flag) ? "&" : "?") + WWW.EscapeURL(item.Key) + "=" + WWW.EscapeURL(item.Value);
			flag = false;
		}
		return text;
	}

	public string PCHICPPDHKI(string EFJJOIJBCEB)
	{
		return EFJJOIJBCEB;
	}

	[DebuggerHidden]
	protected IEnumerator PJICGHJMBOD()
	{
		PGHOKPIOOCA pGHOKPIOOCA = new PGHOKPIOOCA();
		pGHOKPIOOCA.KPHCHDHEKGH = this;
		return pGHOKPIOOCA;
	}

	private void CEAJGBPHELN()
	{
		bool flag = JKPOJMOFFMF.BCHKAKOPNKB("Rated");
		string eHAPKEKPMOE = GPJONKKMEKD;
		string eHAPKEKPMOE2 = IIKAFLBAEML;
		ObscuredInt lBKOHPIDKFH = BEHFNEAKDAL.IBPALGFPAKO.LBKOHPIDKFH;
		ObscuredInt kIDFODCBGNA = BEHFNEAKDAL.IBPALGFPAKO.KIDFODCBGNA;
		DateTime eHAPKEKPMOE3 = ENIEEBOOKEL;
		JKPOJMOFFMF.FBEPNCOCNBF();
		if (flag)
		{
			FOGIOGKLNIP.BBKFOHCEOCK("Rated", 1);
		}
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		FieldInfo[] fields = GetType().GetFields(bindingAttr);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (Nullable.GetUnderlyingType(fieldInfo.FieldType) != null)
			{
				fieldInfo.SetValue(this, null);
			}
		}
		FOGIOGKLNIP.BKFOLNBKJCO();
		BEHFNEAKDAL.IBPALGFPAKO.KIDFODCBGNA = kIDFODCBGNA;
		BEHFNEAKDAL.IBPALGFPAKO.LBKOHPIDKFH = lBKOHPIDKFH;
		GPJONKKMEKD = eHAPKEKPMOE;
		IIKAFLBAEML = eHAPKEKPMOE2;
		ENIEEBOOKEL = eHAPKEKPMOE3;
	}

	private bool ICJMBAECLIN()
	{
		if (FOGIOGKLNIP.OMMLFOEPEEK && EAAGMHKCPCM)
		{
			string text = string.Empty;
			UnityEngine.Object[] array = Resources.FindObjectsOfTypeAll(typeof(Texture));
			UnityEngine.Object[] array2 = Resources.FindObjectsOfTypeAll(typeof(AnimationClip));
			UnityEngine.Object[] array3 = Resources.FindObjectsOfTypeAll(typeof(AudioClip));
			UnityEngine.Object[] array4 = array2;
			foreach (UnityEngine.Object obj in array4)
			{
				text = text + obj.name + " ";
			}
			GUILayout.Label(base.FKICDOGJIFN.ShowMemoryTextures + array.Length + base.FKICDOGJIFN.ShowMemoryAnimations + array2.Length + base.FKICDOGJIFN.ShowMemorySounds + array3.Length);
			GUILayout.Label(text);
			if (GUILayout.Button(base.FKICDOGJIFN.ShowMemoryUnload))
			{
				Resources.UnloadUnusedAssets();
			}
			foreach (Texture item in from AEMBPMJMOAB in array.Cast<Texture>().Distinct()
				orderby AEMBPMJMOAB.texelSize.magnitude
				select AEMBPMJMOAB)
			{
				GUILayout.Label(item.name);
				GUILayout.Label(item);
			}
			return true;
		}
		return false;
	}

	private bool DOGDDILACJO()
	{
		return false;
	}

	private void AAEEEDGLDNA()
	{
		if (FOGIOGKLNIP.PIOANBBCFFP != null)
		{
			FOGIOGKLNIP.IAOONCAPLGK("Rendering Modes");
			FOGIOGKLNIP.IAOONCAPLGK(string.Format("{0} {1}", FOGIOGKLNIP.FHHPMGJCHJL("Current rendering mode:"), FOGIOGKLNIP.NGFDFPGNDCJ.CICDHCEOLLE.renderingPath));
			if (FOGIOGKLNIP.MHFCLILDBCM("Forward Rendering (Complex rendering, decreses fps)"))
			{
				EMAKHKAILGI = 1;
				FOGIOGKLNIP.NGFDFPGNDCJ.GENGIPHHADE(EMAKHKAILGI);
			}
			if (FOGIOGKLNIP.MHFCLILDBCM("VertexLit Rendering (Simple & Performance Rendering)"))
			{
				EMAKHKAILGI = 0;
				FOGIOGKLNIP.NGFDFPGNDCJ.GENGIPHHADE(EMAKHKAILGI);
			}
		}
	}

	private void MFAOJJJJLLH()
	{
		JCFBLCHKBPO = FOGIOGKLNIP.HGHFNJMFLHM(JCFBLCHKBPO, "Disable Dynamic Crosshair");
		IPGDADMKHBI = (int)JJCCBMNJNEF("Crosshair Red Color: ", IPGDADMKHBI, 0f, 255f, 1f);
		DPKFCDBODHB = (int)JJCCBMNJNEF("Crosshair Green Color: ", DPKFCDBODHB, 0f, 255f, 1f);
		KDOJPMAILED = (int)JJCCBMNJNEF("Crosshair Blue Color: ", KDOJPMAILED, 0f, 255f, 1f);
		JDJOIFBLOCJ = (int)JJCCBMNJNEF("Crosshair Alpha Color: ", JDJOIFBLOCJ, 0f, 255f, 1f);
		KGOMBPAOCFJ = JJCCBMNJNEF("Crosshair Length: ", KGOMBPAOCFJ, 0f, 100f, 0.1f);
		BCGCADMJKCN = JJCCBMNJNEF("Crosshair Width: ", BCGCADMJKCN, 0f, 100f, 0.1f);
		PBAMBLHDMFN = JJCCBMNJNEF("Crosshair Border Size: ", PBAMBLHDMFN, 0f, 10f, 0.1f);
		DEFMNAPCCJP = FOGIOGKLNIP.HGHFNJMFLHM(DEFMNAPCCJP, "Enable auto scope mode (Only Sniper Rifles!)");
	}

	private void WeaponSwaySettings()
	{
	}

	private void CKDAEOBGOHB()
	{
		string[] names = QualitySettings.names;
		FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsPresetSlected + names[QualitySettings.GetQualityLevel()]);
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.PresetSettingsLow, GUILayout.ExpandWidth(true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.PresetSettings(0);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.PresetSettingsMedium, GUILayout.ExpandWidth(true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.PresetSettings(1);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.PresetSettingsHigh, GUILayout.ExpandWidth(true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.PresetSettings(2);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.PresetSettingsVeryHigh, GUILayout.ExpandWidth(true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.PresetSettings(3);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.PresetSettingsUltra, GUILayout.ExpandWidth(true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.PresetSettings(4);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.PresetSettingsCustomUser, GUILayout.ExpandWidth(true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.PresetSettings(5);
		}
		FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsRendering);
		NPNFEBBLGBM = (int)JJCCBMNJNEF(base.FKICDOGJIFN.RenderSettingsPixelLightCount, NPNFEBBLGBM, 0f, 4f, 1f);
		if (QualitySettings.pixelLightCount != NPNFEBBLGBM)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.pixelLightCount = NPNFEBBLGBM;
		}
		AALDBAOHNJK = (int)JJCCBMNJNEF(base.FKICDOGJIFN.RenderSettingsTextureQuality, AALDBAOHNJK, 0f, 3f, 1f);
		if (QualitySettings.masterTextureLimit != AALDBAOHNJK)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.masterTextureLimit = AALDBAOHNJK;
		}
		KNPLLEIIJNK = (int)JJCCBMNJNEF(base.FKICDOGJIFN.RenderSettingsAnisotropicFiltering, KNPLLEIIJNK, 0f, 2f, 1f);
		if (QualitySettings.anisotropicFiltering != (AnisotropicFiltering)KNPLLEIIJNK)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.anisotropicFiltering = (AnisotropicFiltering)KNPLLEIIJNK;
		}
		FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsShadowProjectionMode + QualitySettings.shadowProjection);
		KLHMPJBEJIA = (int)JJCCBMNJNEF(base.FKICDOGJIFN.RenderSettingsShadowProjection, KLHMPJBEJIA, 0f, 1f, 1f);
		if (QualitySettings.shadowProjection != (ShadowProjection)KLHMPJBEJIA)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.shadowProjection = (ShadowProjection)KLHMPJBEJIA;
		}
		if (NAOGCJNODFD == 0)
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsShadowCascadesModeNoCascades);
		}
		if (NAOGCJNODFD == 2)
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsShadowCascadesModeTwoCascades);
		}
		if (NAOGCJNODFD == 4)
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsShadowCascadesModeFourCascades);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettingsNoCascades))
		{
			NAOGCJNODFD = 0;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettingsTwoCascades))
		{
			NAOGCJNODFD = 2;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettingsFourCascades))
		{
			NAOGCJNODFD = 4;
		}
		if (QualitySettings.shadowCascades != NAOGCJNODFD)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.shadowCascades = NAOGCJNODFD;
		}
		OABMHDAFACP = JJCCBMNJNEF(base.FKICDOGJIFN.RenderSettingsShadowDistance, OABMHDAFACP, 0f, 150f, 1f);
		if (QualitySettings.shadowDistance != OABMHDAFACP)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.shadowDistance = OABMHDAFACP;
		}
		FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.OtherText);
		FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsBlendWeightMode + QualitySettings.blendWeights);
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettings1Bone))
		{
			AMJMDOEJODJ = 1;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettings2Bone))
		{
			AMJMDOEJODJ = 2;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettings4Bone))
		{
			AMJMDOEJODJ = 4;
		}
		if (QualitySettings.blendWeights != (BlendWeights)AMJMDOEJODJ)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.blendWeights = (BlendWeights)AMJMDOEJODJ;
		}
		FOGIOGKLNIP.IAOONCAPLGK(string.Format("<color=#FF4B25>{0}.</color>", FOGIOGKLNIP.FHHPMGJCHJL("Attention! If the frame rate limit value is higher, this may result in reduced performance")));
		GCPLACLAKKH = (int)JJCCBMNJNEF("Frame Rate Limit", GCPLACLAKKH, 30f, 300f, 1f);
		if (Application.targetFrameRate != GCPLACLAKKH)
		{
			EMFJACGNHEJ = 5;
			Application.targetFrameRate = GCPLACLAKKH;
		}
		if (JMDMDFAFLKH == 0)
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsVSyncModeDontSync);
		}
		if (JMDMDFAFLKH == 1)
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsVSyncModeEveryVBlank);
		}
		if (JMDMDFAFLKH == 2)
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.RenderSettingsVSyncModeEverySecondVBlank);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettingsDontSync))
		{
			JMDMDFAFLKH = 0;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettingsEveryVBlank))
		{
			JMDMDFAFLKH = 1;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.RenderSettingsEverySecondVBlank))
		{
			JMDMDFAFLKH = 2;
		}
		if (QualitySettings.vSyncCount != JMDMDFAFLKH)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.vSyncCount = JMDMDFAFLKH;
		}
		IGIMPALINNK = JJCCBMNJNEF(base.FKICDOGJIFN.RenderSettingsLodBias, IGIMPALINNK, 0f, 4f, 1f);
		if (QualitySettings.lodBias != IGIMPALINNK)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.lodBias = IGIMPALINNK;
		}
		LOKEEGHKNAN = (int)JJCCBMNJNEF(base.FKICDOGJIFN.RenderSettingsParticleRaycastBudget, LOKEEGHKNAN, 0f, 4096f, 1f);
		if (QualitySettings.particleRaycastBudget != LOKEEGHKNAN)
		{
			EMFJACGNHEJ = 5;
			QualitySettings.particleRaycastBudget = LOKEEGHKNAN;
		}
		QualitySettings.SetQualityLevel(EMFJACGNHEJ);
	}

	public void PresetSettings(int _presetSettings)
	{
		EMFJACGNHEJ = _presetSettings;
		QualitySettings.SetQualityLevel(EMFJACGNHEJ);
		NPNFEBBLGBM = QualitySettings.pixelLightCount;
		AALDBAOHNJK = QualitySettings.masterTextureLimit;
		KNPLLEIIJNK = (int)QualitySettings.anisotropicFiltering;
		KNJEMOMJBHC = QualitySettings.antiAliasing;
		KLHMPJBEJIA = (int)QualitySettings.shadowProjection;
		NAOGCJNODFD = QualitySettings.shadowCascades;
		OABMHDAFACP = QualitySettings.shadowDistance;
		AMJMDOEJODJ = (int)QualitySettings.blendWeights;
		JMDMDFAFLKH = QualitySettings.vSyncCount;
		IGIMPALINNK = QualitySettings.lodBias;
		LOKEEGHKNAN = QualitySettings.particleRaycastBudget;
	}

	public void PresetSettingsLoad(int _presetSettings)
	{
		EMFJACGNHEJ = _presetSettings;
		QualitySettings.SetQualityLevel(EMFJACGNHEJ);
		QualitySettings.pixelLightCount = NPNFEBBLGBM;
		QualitySettings.masterTextureLimit = AALDBAOHNJK;
		QualitySettings.anisotropicFiltering = (AnisotropicFiltering)KNPLLEIIJNK;
		QualitySettings.antiAliasing = KNJEMOMJBHC;
		QualitySettings.shadowProjection = (ShadowProjection)KLHMPJBEJIA;
		QualitySettings.shadowCascades = NAOGCJNODFD;
		QualitySettings.shadowDistance = OABMHDAFACP;
		QualitySettings.blendWeights = (BlendWeights)AMJMDOEJODJ;
		QualitySettings.vSyncCount = JMDMDFAFLKH;
		QualitySettings.lodBias = IGIMPALINNK;
		QualitySettings.particleRaycastBudget = LOKEEGHKNAN;
	}

	private void BIAMBEAFLNB()
	{
		if (FBDPFIDNILM == null || JDFKPOMKMNJ.NFMIBMIGJMH(300))
		{
			string text = ICALMCIJBNG(PIKEJKMABHA).ToString();
			if (text != FBDPFIDNILM)
			{
				FBDPFIDNILM = text;
				LOADKHHJCDK.y = 100000f;
			}
		}
		GUILayout.Label(base.FKICDOGJIFN.ConsoleOnClickLog);
		PIKEJKMABHA = GUILayout.Toggle(PIKEJKMABHA, base.FKICDOGJIFN.ConsoleShowCallStack);
		LOADKHHJCDK = GUILayout.BeginScrollView(LOADKHHJCDK);
		bool wordWrap = GUI.skin.textArea.wordWrap;
		GUI.skin.textArea.wordWrap = false;
		GUILayout.TextArea(FBDPFIDNILM);
		HAOBLEPABFD(FBDPFIDNILM.Length);
		GUI.skin.textArea.wordWrap = wordWrap;
		GUILayout.EndScrollView();
		BMPDDJECPGE = GUILayout.TextField(BMPDDJECPGE);
		if (Event.current.keyCode == KeyCode.Return && BMPDDJECPGE.Length > 0)
		{
			Application.ExternalEval(BMPDDJECPGE);
			BMPDDJECPGE = string.Empty;
		}
	}

	public static void HAOBLEPABFD(int IJDNFLAKFON)
	{
		TextEditor textEditor = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), GUIUtility.keyboardControl);
		textEditor.cursorIndex = 0;
		textEditor.selectIndex = IJDNFLAKFON;
		textEditor.MoveTextEnd();
	}

	private void ANEANGKPJAE(StringBuilder OCCOEHJFDKM)
	{
		OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendVersion + FOGIOGKLNIP.LMMFHEODOPM.GJPOFKBMIEE + " " + DKPGCEABLDP);
		OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendErrors);
		OCCOEHJFDKM.Append(NKPNJDBLBAI);
		if (FOGIOGKLNIP.PIOANBBCFFP != null)
		{
			OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendVisible);
			OCCOEHJFDKM.Append(FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.CGCEAEFHDIF)));
		}
		OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendWarning);
		OCCOEHJFDKM.Append(JNDJIDDPCME);
		OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendPrint);
		OCCOEHJFDKM.Append(EAAHOGDOKND);
		OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendDict);
		OCCOEHJFDKM.Append(FOGIOGKLNIP.EFPKGAAFKFG.dict.Count);
		if (FOGIOGKLNIP.OMMLFOEPEEK)
		{
			OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendRPC);
			OCCOEHJFDKM.Append(JAPPMNIGMOG);
			int num = 0;
			num += JDFKPOMKMNJ.KMGLLLGMADC.Count + CMEFDJLJODE.KMGLLLGMADC.Count;
			if (FOGIOGKLNIP.PIOANBBCFFP != null)
			{
				num += FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.KMGLLLGMADC.Count;
			}
			OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendTimer + num);
		}
		if (FOGIOGKLNIP.BEAGCEMBJEA != null)
		{
			OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendPool + FOGIOGKLNIP.BEAGCEMBJEA.IKHNNOLFBMP.Count);
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendCon);
			OCCOEHJFDKM.Append(Network.connections.Length);
		}
		if (Profiler.enabled)
		{
			OCCOEHJFDKM.Append(base.FKICDOGJIFN.ConsoleOnLogAppendMem + FGKNGGICNFB);
		}
		OCCOEHJFDKM.Append("   ").Append(AGEJEPNLEHL);
		if (!FOGIOGKLNIP.DGMBIMMABNO)
		{
			OCCOEHJFDKM.Append(FMLLJHBHGID);
		}
		OCCOEHJFDKM.Append("\n").Append(NDEFDFEDKFL.ToString());
	}

	private static Dictionary<string, string> JAGCLJJMALB(string PFMPJIJLLFA)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string[] array = PFMPJIJLLFA.Split('&');
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split('=');
			string key = WWW.UnEscapeURL(array3[0]);
			string value = WWW.UnEscapeURL(array3[1]);
			dictionary.Add(key, value);
		}
		return dictionary;
	}

	private static string[] NFODFMGNBBC(Dictionary<string, string> GHJBEEBMOKB)
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, string> item in GHJBEEBMOKB)
		{
			list.Add(item.Key);
			list.Add(item.Value);
		}
		return list.ToArray();
	}

	[CompilerGenerated]
	private static string KCIIIDJKDMM(Resolution AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.width + "x" + AEMBPMJMOAB.height + "x" + AEMBPMJMOAB.refreshRate + "hz";
	}

	[CompilerGenerated]
	private static float FEHOPNCNNDF(Texture AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.texelSize.magnitude;
	}

	[CompilerGenerated]
	private static bool MHFGKCOOCFJ(KKJBDENNKGF AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.CGCEAEFHDIF);
	}
}
