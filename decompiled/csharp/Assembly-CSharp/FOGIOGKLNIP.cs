using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Beebyte.Obfuscator;
using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using SPD.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

[DoNotFake]
public class FOGIOGKLNIP : IGPGFFNKCFO
{
	[CompilerGenerated]
	private sealed class HIFBMAFGDPD
	{
		internal Touch FJBCDEPOGDF;

		internal bool BEKJDJFLJJC(TouchPhase AEMBPMJMOAB)
		{
			return AEMBPMJMOAB == FJBCDEPOGDF.phase;
		}
	}

	[CompilerGenerated]
	private sealed class KBBBIIGFOKE
	{
		internal GUITexture FCCPLGMNKOK;

		internal TouchPhase[] LPHLAGOFNPF;

		internal bool BEKJDJFLJJC(Touch AEMBPMJMOAB)
		{
			return PBNCNLDIFIF(AEMBPMJMOAB, FCCPLGMNKOK, FCCPLGMNKOK.transform.localScale.x, LPHLAGOFNPF);
		}
	}

	[CompilerGenerated]
	private sealed class GABPBGEOFNL
	{
		internal GUI.WindowFunction AIJHAMAOMIA;

		internal void BEKJDJFLJJC(int AEMBPMJMOAB)
		{
			AIJHAMAOMIA(AEMBPMJMOAB);
			OFCBNEMGAPI(GUI.tooltip);
		}
	}

	[CompilerGenerated]
	private sealed class JHIJHMGIBKK
	{
		internal int DCABBCPLGEM;

		internal void BEKJDJFLJJC()
		{
			BGMIEGBKLFD.Remove(DCABBCPLGEM);
		}
	}

	public const string LNBOPJPBPOA = "ERROR_MDL";

	public static bool MACJBMALKEB = true;

	public bool? MOLCNHCFPHG;

	public static bool CJOGLBBCDEC;

	public static bool CNIAIOJACDA;

	public static bool OEHPFFJHJEJ;

	public static bool EKGNDFOPKLC;

	public static bool[] PBDAOOIJGIA = new bool[32];

	private static bool CLACKCEFKLH;

	private static bool? DHKLBPNIDLM;

	public static int KIODJDJJFBH = new System.Random().Next(50, 100);

	public static int KJIDCLAGBKG;

	public static int EFECLAMJIFH;

	public static int EDBEJGJJDDA;

	public static int ENJKFFABFIL;

	public const float OJIFMCFIIJN = 0.3f;

	public const float JNKPDCOMOMH = 0.02f;

	private static float DPNMFFMDCPB;

	public static string EHBNELHGBHE = string.Empty;

	public PhotonPlayer PDKHDCBCOMO;

	public NetworkPlayer EGHJJCHMKDF;

	public NetworkPlayer JHNKLKLOCBH;

	public static MONLDPMKIFB LGGHDMBKKCE;

	public static NOMMEFIICHO INJKJFIDKJM;

	public static Vector3 DDGKNLHJEFD;

	public static Vector3 FAFGMDJIOGN;

	public static FDLJKDJLMKK NGFDFPGNDCJ;

	public static AHDMBKHBJII EIIMBNKHJJA;

	public static CPIIHEGALLE BEAGCEMBJEA;

	public static AGOMNHKFDEF PIOANBBCFFP;

	public static GLBMELGGDNN OKJJJBOEGBJ;

	public static GLLKKENPCPH LBJBBGEDGJF;

	public static KKJBDENNKGF NMGDHKIKCED;

	public static FDGPLHOFOEN GMPBCIEDMCD;

	public static LAOFKFBJDGJ LPLJMLGKCLK;

	public static Touch KEBJNPDADMO;

	public static Action<string> IKJHNNLICBA;

	public static Touch[] HJDAJDIIMPD = new Touch[0];

	public static FOGIOGKLNIP POIFDHDCNMM;

	private static GUI.WindowFunction OGGMOGPPPHC;

	private Vector2? IAFIDJLHGLC;

	internal Transform EHOEFMPLIFB;

	internal GameObject ICIEDCMDJFO;

	internal Animation AIAJBBMCIBK;

	internal NetworkView GGANPFEPKJG;

	internal PhotonView EBHOPCCNJAO;

	internal AudioSource BMANAIHDHKF;

	private static GLLKKENPCPH EHNOJHCENCH;

	private static KLAPMPENAHP NGCBOMOHLGH;

	public static Dictionary EFPKGAAFKFG = new Dictionary();

	public static List<Dictionary> ICNGEHGPIFM = new List<Dictionary>();

	public static Dictionary<int, Action<BinaryReader>> BGMIEGBKLFD = new Dictionary<int, Action<BinaryReader>>();

	private static Dictionary<string, int> DLMAPMNLKEE = new Dictionary<string, int>();

	private static Dictionary<string, float> AAAMBCDLDHF = new Dictionary<string, float>();

	private static Dictionary<string, ObscuredVector3> ECACAAAECKN = new Dictionary<string, ObscuredVector3>();

	private static Dictionary<string, string> AHLLIHBFMEL = new Dictionary<string, string>();

	private static Dictionary<string, bool> PJMPKAMGHNF = new Dictionary<string, bool>();

	private static Dictionary<string, string> POBNHAPIIDH = new Dictionary<string, string>();

	internal string BCOHBGIIPFI = "JFFMCCDKBND";

	internal string HINJJBMHIMO = "Aim";

	internal string DBBNFKGHGJO = "ODMGBBKGLOD";

	internal string FMIODCPGFAB = "KPMFMBAMFCF";

	internal string HJOIGFNLIBK = "PINBKNKFBJC";

	internal string IBLPIHFLKMB = "Crouch";

	internal string KGJCIAALGEM = "Pause";

	internal string FKJHCOHBCIC = "Stats";

	internal string DNBGJDCBOKL = "Chat";

	internal string EHGAABBICAO = "Shop";

	internal string PFGBMKMOMDI = "Camera";

	internal GameObject ELDBCJIEPIE;

	public static bool OMMLFOEPEEK;

	public const int HDBJPDDFANG = 53003;

	public static float AAAIGHEPLCD;

	public static Rect IGBGDNLNDJM;

	public static Dictionary<string, GUIStyle> CEBPMBPFENM = new Dictionary<string, GUIStyle>();

	[CompilerGenerated]
	private static Func<Transform, bool> ACJNADIPOMC;

	[CompilerGenerated]
	private static Func<Transform, Renderer> HJJBAKLDAEB;

	[CompilerGenerated]
	private static Action<string> PLPLKIHGGOE;

	public static IBEPICCMOCK LMMFHEODOPM => LPLJMLGKCLK.IJIMIDACOOL;

	public static EHDGDCFLFBE HJLAMDIBCDO => LPLJMLGKCLK.BJCHPDPADMK;

	internal Transform CDKBABEPJCD => base.transform;

	public DownloadObjects BHCIEFHBOPB => LMMFHEODOPM.BHCIEFHBOPB;

	public PrefsObjs EKPLFFMMPEA => LMMFHEODOPM.EKPLFFMMPEA;

	public BPADKFMBHBE IOCECFNAKJM => new BPADKFMBHBE();

	public GUIStringObject FKICDOGJIFN => LMMFHEODOPM.FKICDOGJIFN;

	public float BILHMMNDCKA => 0.02f / Time.fixedDeltaTime;

	public bool NENPALDENAL => (!LPLJMLGKCLK.FDFIHADJLAO) ? PhotonNetwork.isMasterClient : Network.isServer;

	public object MFAGKFPCJFG => (!LPLJMLGKCLK.FDFIHADJLAO) ? EBHOPCCNJAO.viewID : ((object)GGANPFEPKJG.viewID);

	public int MPGJFDKDCPB => (!LPLJMLGKCLK.FDFIHADJLAO) ? EBHOPCCNJAO.viewID.ID : GGANPFEPKJG.viewID.GetHashCode();

	public object PDCFBMJNOBO => (!LPLJMLGKCLK.FDFIHADJLAO) ? EBHOPCCNJAO.owner : ((object)GGANPFEPKJG.owner);

	public object MIMFNICKFPC => (!LPLJMLGKCLK.FDFIHADJLAO) ? PhotonNetwork.player : ((object)Network.player);

	public int AEOCLPGEFEP => (!LPLJMLGKCLK.FDFIHADJLAO) ? EBHOPCCNJAO.owner.ID : GGANPFEPKJG.owner.GetHashCode();

	public bool JNPCOJFBJGP
	{
		get
		{
			return PhotonNetwork.offlineMode;
		}
		set
		{
			PhotonNetwork.offlineMode = value;
		}
	}

	public virtual bool KAMAMHFJDGG
	{
		get
		{
			bool? mOLCNHCFPHG = MOLCNHCFPHG;
			if (!mOLCNHCFPHG.HasValue)
			{
				MOLCNHCFPHG = ((!LPLJMLGKCLK.FDFIHADJLAO) ? EBHOPCCNJAO.isMine : GGANPFEPKJG.isMine);
			}
			return MOLCNHCFPHG.Value;
		}
	}

	public double ICDHGFCBPOJ => (!LPLJMLGKCLK.FDFIHADJLAO) ? PhotonNetwork.time : Network.time;

	public float OKPJDGNFBCK => (!LPLJMLGKCLK.FDFIHADJLAO) ? ((float)PhotonNetwork.time) : ((float)Network.time);

	public bool DDPGADAHEMF => (!LPLJMLGKCLK.FDFIHADJLAO) ? EBHOPCCNJAO.owner.isMasterClient : (MPGJFDKDCPB < 100);

	public Transform NOEOLIEMCPM => EHOEFMPLIFB;

	public Transform JNEBJLMLOLM
	{
		get
		{
			return NOEOLIEMCPM.parent;
		}
		set
		{
			NOEOLIEMCPM.parent = value;
		}
	}

	public Vector3 ALIEGLIAJOI
	{
		get
		{
			return NOEOLIEMCPM.localScale;
		}
		set
		{
			NOEOLIEMCPM.localScale = value;
		}
	}

	public float MEIGMHJEHBE
	{
		get
		{
			return ELGIKGAIIOD.x;
		}
		set
		{
			Vector3 eHAPKEKPMOE = ELGIKGAIIOD;
			eHAPKEKPMOE.x = value;
			ELGIKGAIIOD = eHAPKEKPMOE;
		}
	}

	public float NCJPOGNEDKP
	{
		get
		{
			return ELGIKGAIIOD.y;
		}
		set
		{
			Vector3 eHAPKEKPMOE = ELGIKGAIIOD;
			eHAPKEKPMOE.y = value;
			ELGIKGAIIOD = eHAPKEKPMOE;
		}
	}

	public float BMHBDKDOIFB
	{
		get
		{
			return ELGIKGAIIOD.z;
		}
		set
		{
			Vector3 eHAPKEKPMOE = ELGIKGAIIOD;
			eHAPKEKPMOE.z = value;
			ELGIKGAIIOD = eHAPKEKPMOE;
		}
	}

	public float HPEIDGPCCAM
	{
		get
		{
			return KHGAOLHJCMO.eulerAngles.x;
		}
		set
		{
			Vector3 eulerAngles = KHGAOLHJCMO.eulerAngles;
			eulerAngles.x = value;
			KHGAOLHJCMO = Quaternion.Euler(eulerAngles);
		}
	}

	public float GMLOJKFBLBN
	{
		get
		{
			return KHGAOLHJCMO.eulerAngles.y;
		}
		set
		{
			Vector3 eulerAngles = KHGAOLHJCMO.eulerAngles;
			eulerAngles.y = value;
			KHGAOLHJCMO = Quaternion.Euler(eulerAngles);
		}
	}

	public float DKIOOBGLMBK
	{
		get
		{
			return KHGAOLHJCMO.eulerAngles.z;
		}
		set
		{
			Vector3 eulerAngles = KHGAOLHJCMO.eulerAngles;
			eulerAngles.z = value;
			KHGAOLHJCMO = Quaternion.Euler(eulerAngles);
		}
	}

	public Vector3 ELGIKGAIIOD
	{
		get
		{
			return NOEOLIEMCPM.position;
		}
		set
		{
			NOEOLIEMCPM.position = value;
		}
	}

	public Quaternion KHGAOLHJCMO
	{
		get
		{
			return NOEOLIEMCPM.rotation;
		}
		set
		{
			NOEOLIEMCPM.rotation = value;
		}
	}

	public Vector3 PJKFFDKJIHO
	{
		get
		{
			return NOEOLIEMCPM.rotation.eulerAngles;
		}
		set
		{
			NOEOLIEMCPM.rotation = Quaternion.Euler(value);
		}
	}

	public float APEMLIBKMFI
	{
		get
		{
			return LOEFGMHIMCC.eulerAngles.x;
		}
		set
		{
			Vector3 eulerAngles = LOEFGMHIMCC.eulerAngles;
			eulerAngles.x = value;
			LOEFGMHIMCC = Quaternion.Euler(eulerAngles);
		}
	}

	public float IIMKONCKMHH
	{
		get
		{
			return LOEFGMHIMCC.eulerAngles.y;
		}
		set
		{
			Vector3 eulerAngles = LOEFGMHIMCC.eulerAngles;
			eulerAngles.y = value;
			LOEFGMHIMCC = Quaternion.Euler(eulerAngles);
		}
	}

	public float DJHKBFELFCG
	{
		get
		{
			return LOEFGMHIMCC.eulerAngles.z;
		}
		set
		{
			Vector3 eulerAngles = LOEFGMHIMCC.eulerAngles;
			eulerAngles.z = value;
			LOEFGMHIMCC = Quaternion.Euler(eulerAngles);
		}
	}

	public Vector3 NHAJGHBINOL
	{
		get
		{
			return LOEFGMHIMCC.eulerAngles;
		}
		set
		{
			LOEFGMHIMCC = Quaternion.Euler(value);
		}
	}

	public Quaternion LOEFGMHIMCC
	{
		get
		{
			return NOEOLIEMCPM.localRotation;
		}
		set
		{
			NOEOLIEMCPM.localRotation = value;
		}
	}

	public bool HGCLIIOIAHM => EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.W);

	public bool DFODLKHDLGG => EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.S);

	public bool MGLIGHIBNEH => EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.D);

	public bool BNMLPNBIJLN => EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.A);

	public static KLAPMPENAHP CIEBMCOJGCC
	{
		get
		{
			if (NGCBOMOHLGH == null)
			{
				NGCBOMOHLGH = (KLAPMPENAHP)UnityEngine.Object.FindObjectOfType(typeof(KLAPMPENAHP));
			}
			return NGCBOMOHLGH;
		}
	}

	public static PKOGMCMAHON GLNAMCPCICH => LPLJMLGKCLK.DFDEMPKPIMK;

	public static LIFMGPEMIBO EPBMIIPELPO => LPLJMLGKCLK.CDKNILAFIKI;

	public static NCGNCLMDIKB BEHFNEAKDAL => LPLJMLGKCLK.BEHFNEAKDAL;

	public int EGPFOCNKAKB => (!DGMBIMMABNO) ? 5000 : 10;

	public static bool DGMBIMMABNO => LMMFHEODOPM.ICOMKPIKMDK;

	public static bool LFENOGAECJD => Application.platform == RuntimePlatform.IPhonePlayer;

	public bool MJEAIGGPIKN => Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer;

	public bool DAAKJBPLJNK
	{
		get
		{
			return CJOGLBBCDEC;
		}
		set
		{
			CJOGLBBCDEC = value;
		}
	}

	public static bool ODADKOIJOLK => false;

	public bool MDBAFPKAKKK
	{
		get
		{
			return Cursor.lockState == CursorLockMode.Locked && !MJEAIGGPIKN;
		}
		set
		{
			if (value)
			{
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
			}
			else
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}
	}

	public bool FCFBGBPEPOL
	{
		get
		{
			return LMMFHEODOPM.JOKJANPLMHI;
		}
		set
		{
			LMMFHEODOPM.JOKJANPLMHI = value;
		}
	}

	public static int ICLENOJCEGB => (int)(DateTime.Now.Ticks / 36000000000L);

	public static int BMHGJFJCOGC => (int)(DateTime.Now.Ticks / 10000000) - int.MaxValue;

	public int IFHGMCKAKEC(int BKENMJFCFJI, KKJBDENNKGF NAHBCJFEMKB, int FBGNKPPMENN, JDILMODHLOJ BJDCCKHBENA)
	{
		if (ObscuredBool.FNIPJFGEFFD(NAHBCJFEMKB.MIAIFPBNBDJ))
		{
			NAHBCJFEMKB.CLNFNDEEGHB(-BKENMJFCFJI / 2, BJDCCKHBENA, (byte)FBGNKPPMENN, 1);
			if (BKENMJFCFJI > ObscuredInt.FNIPJFGEFFD(NAHBCJFEMKB.DEAOKMPMDFJ))
			{
				return BKENMJFCFJI - ObscuredInt.FNIPJFGEFFD(NAHBCJFEMKB.DEAOKMPMDFJ) / 2;
			}
			return BKENMJFCFJI;
		}
		return BKENMJFCFJI;
	}

	public Transform GFJGDEKLFNB(Transform EHOEFMPLIFB)
	{
		foreach (Transform item in EHOEFMPLIFB)
		{
			UnityEngine.Object.Destroy(item.gameObject);
		}
		return EHOEFMPLIFB;
	}

	public bool NBBHJJELPCP(NetworkPlayer MIHHNFLOJEP)
	{
		if (NENPALDENAL)
		{
			return MIHHNFLOJEP.ipAddress == string.Empty;
		}
		return MIHHNFLOJEP.ipAddress == LPLJMLGKCLK.PDDELHFGPNK;
	}

	public static NetworkPlayer NIICAPPLIGM()
	{
		if (Network.isServer)
		{
			return Network.player;
		}
		if (Network.isClient)
		{
			return Network.connections[0];
		}
		return NetworkViewID.unassigned.owner;
	}

	public static ulong BEIBKCFAFIE(DateTime KBGGPOCBNGG)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
		return (ulong)Math.Floor((KBGGPOCBNGG.ToUniversalTime() - dateTime).TotalSeconds);
	}

	public static void LKLLDMLLIML()
	{
		CLACKCEFKLH = GUI.skin.button.wordWrap;
		DPNMFFMDCPB = GUI.skin.button.fixedHeight;
		GUI.skin.button.fixedHeight = 0f;
		GUI.skin.button.wordWrap = true;
	}

	public static void PHINLFLBAOJ()
	{
		GUI.skin.button.fixedHeight = DPNMFFMDCPB;
		GUI.skin.button.wordWrap = CLACKCEFKLH;
	}

	public static string FNOCDPLPAIJ(string LGNIFJCEECH)
	{
		return FHHPMGJCHJL(LGNIFJCEECH).Replace(" ", "_");
	}

	public static string FHHPMGJCHJL(string LGNIFJCEECH, Dictionary<string, string> CCHMDKPJECN = null, string DNDEOKKABEJ = null)
	{
		if (DNDEOKKABEJ == null)
		{
			DNDEOKKABEJ = LGNIFJCEECH;
		}
		if (CCHMDKPJECN == null)
		{
			CCHMDKPJECN = EFPKGAAFKFG.dict;
		}
		if (LGNIFJCEECH == null || LGNIFJCEECH.Length > 1000)
		{
			return DNDEOKKABEJ;
		}
		if (CCHMDKPJECN.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		string key = Regex.Replace(LGNIFJCEECH.Trim(), "[^\\w ]", string.Empty);
		if (!CCHMDKPJECN.TryGetValue(key, out value))
		{
			value = DNDEOKKABEJ;
		}
		CCHMDKPJECN.Add(LGNIFJCEECH, value);
		return DNDEOKKABEJ;
	}

	public static float PBENJCPCOLN(string LGNIFJCEECH, float DNDEOKKABEJ)
	{
		if (LPLJMLGKCLK.PLOHPAEKDHN.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		if (LPLJMLGKCLK.FCFBGBPEPOL)
		{
			Debug.Log("Failed get value: " + LGNIFJCEECH);
		}
		return DNDEOKKABEJ;
	}

	public static int EELPLHEEEDB(string LGNIFJCEECH, int DNDEOKKABEJ = -1)
	{
		if (LPLJMLGKCLK.PLOHPAEKDHN.TryGetValue(LGNIFJCEECH, out var value))
		{
			return (int)value;
		}
		if (LPLJMLGKCLK.FCFBGBPEPOL)
		{
			Debug.Log("Failed get value: " + LGNIFJCEECH);
		}
		return DNDEOKKABEJ;
	}

	public static string CHDJHJFGMNA(string LGNIFJCEECH)
	{
		if (LPLJMLGKCLK.CDLHHDAOOPA.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		if (LPLJMLGKCLK.FCFBGBPEPOL)
		{
			Debug.Log("Failed get value: " + LGNIFJCEECH);
		}
		return string.Empty;
	}

	public static T AAPLAPBIFMD<T>(object JFLBOOBFAEF) where T : Component
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			NetworkView networkView = NetworkView.Find((NetworkViewID)JFLBOOBFAEF);
			if (networkView == null)
			{
				return (T)null;
			}
			return networkView.GetComponent<T>();
		}
		PhotonView photonView = PhotonView.Find(((PhotonViewID)JFLBOOBFAEF).ID);
		if (photonView == null)
		{
			return (T)null;
		}
		return photonView.GetComponent<T>();
	}

	public float OMIPNBBJLOD()
	{
		if (Input.touchCount > 0)
		{
			Touch touch = HJDAJDIIMPD.FirstOrDefaultF();
			float num = ((!IAFIDJLHGLC.HasValue || !(IAFIDJLHGLC.Value != Vector2.zero)) ? 0f : (touch.position - IAFIDJLHGLC.Value).y);
			IAFIDJLHGLC = touch.position;
			AAAIGHEPLCD += num / 2f;
			return num / 2f;
		}
		IAFIDJLHGLC = null;
		return 0f;
	}

	public IEnumerable<Renderer> PELIGKBMOHG(Transform GDKFLGBMPBB)
	{
		return from AEMBPMJMOAB in GDKFLGBMPBB.GetTransforms()
			where AEMBPMJMOAB.GetComponent<SkinnedMeshRenderer>() != null
			select AEMBPMJMOAB.GetComponent<Renderer>();
	}

	public virtual void Awake()
	{
		GGANPFEPKJG = GetComponent<NetworkView>();
		AIAJBBMCIBK = GetComponent<Animation>();
		ICIEDCMDJFO = base.gameObject;
		EHOEFMPLIFB = base.transform;
		EBHOPCCNJAO = base.photonView;
		BMANAIHDHKF = GetComponent<AudioSource>();
		if (BMANAIHDHKF != null)
		{
			BMANAIHDHKF.volume = 0.3f;
		}
		if (LPLJMLGKCLK != null && EBHOPCCNJAO != null && GGANPFEPKJG != null)
		{
			if (LPLJMLGKCLK.FDFIHADJLAO)
			{
				EBHOPCCNJAO.enabled = false;
			}
			else
			{
				GGANPFEPKJG.enabled = false;
			}
		}
	}

	public static void LEDCIPHCLEB(AudioClip FPJLDJIGIEK, Vector3 GIDEOJGAFJH, float HJIINNCJCCD = 1f, bool AACEDKHGOAA = false, float GOPGHEPNKOA = 0f, float NGMNCAFNKLI = 0f, float BEIMCMDOMMI = 0f)
	{
		if (FPJLDJIGIEK == null)
		{
			LIJNLAAEENC("Warning no audioclip");
			return;
		}
		GameObject gameObject = new GameObject("One shot audio");
		gameObject.transform.position = GIDEOJGAFJH;
		gameObject.hideFlags = HideFlags.HideInHierarchy;
		GameObject gameObject2 = gameObject;
		AudioSource audioSource = gameObject2.AddComponent<AudioSource>();
		audioSource.clip = FPJLDJIGIEK;
		audioSource.volume = 0.3f * LMMFHEODOPM.OGAIBIOLFCN(FPJLDJIGIEK) * HJIINNCJCCD;
		if (AACEDKHGOAA)
		{
			audioSource.spatialBlend = BEIMCMDOMMI;
			audioSource.minDistance = GOPGHEPNKOA;
			audioSource.maxDistance = NGMNCAFNKLI;
		}
		audioSource.Play();
		UnityEngine.Object.Destroy(gameObject2, FPJLDJIGIEK.length);
	}

	public static void LEDCIPHCLEB(BankEntry BOEAIAJENJO, Vector3 GIDEOJGAFJH, bool AACEDKHGOAA = false, float GOPGHEPNKOA = 0f, float NGMNCAFNKLI = 0f, float BEIMCMDOMMI = 0f)
	{
		if (BOEAIAJENJO == null)
		{
			LEDCIPHCLEB(HJLAMDIBCDO.FPJLDJIGIEK, GIDEOJGAFJH, 1f, AACEDKHGOAA, GOPGHEPNKOA, NGMNCAFNKLI, BEIMCMDOMMI);
			return;
		}
		AudioClip audioClip = ((!BOEAIAJENJO.RandomClip) ? BOEAIAJENJO.Clip : BOEAIAJENJO.Clips.Random());
		if (audioClip == null)
		{
			LIJNLAAEENC("Warning no audioclip");
			audioClip = HJLAMDIBCDO.FPJLDJIGIEK;
		}
		GameObject gameObject = new GameObject("One shot audio");
		gameObject.transform.position = GIDEOJGAFJH;
		gameObject.hideFlags = HideFlags.HideInHierarchy;
		GameObject gameObject2 = gameObject;
		AudioSource audioSource = gameObject2.AddComponent<AudioSource>();
		audioSource.clip = audioClip;
		audioSource.pitch = BOEAIAJENJO.Pitch;
		audioSource.volume = 0.3f * LMMFHEODOPM.OGAIBIOLFCN(audioClip) * BOEAIAJENJO.Volume;
		if (AACEDKHGOAA)
		{
			audioSource.spatialBlend = BEIMCMDOMMI;
			audioSource.minDistance = GOPGHEPNKOA;
			audioSource.maxDistance = NGMNCAFNKLI;
		}
		audioSource.Play();
		UnityEngine.Object.Destroy(gameObject2, audioClip.length);
	}

	public virtual void LEDCIPHCLEB(BankEntry BOEAIAJENJO)
	{
		if (BOEAIAJENJO == null)
		{
			LEDCIPHCLEB(HJLAMDIBCDO.FPJLDJIGIEK);
			return;
		}
		AudioClip audioClip = ((!BOEAIAJENJO.RandomClip) ? BOEAIAJENJO.Clip : BOEAIAJENJO.Clips.Random());
		if (audioClip == null)
		{
			LIJNLAAEENC("Warning no audioclip");
			audioClip = HJLAMDIBCDO.FPJLDJIGIEK;
		}
		if (BMANAIHDHKF == null)
		{
			LIJNLAAEENC("No audioSource found");
		}
		if (LPLJMLGKCLK.FJPCBLEEIOH && BMANAIHDHKF != null)
		{
			BMANAIHDHKF.pitch = BOEAIAJENJO.Pitch;
			BMANAIHDHKF.PlayOneShot(audioClip, LMMFHEODOPM.OGAIBIOLFCN(audioClip) * BOEAIAJENJO.Volume);
		}
	}

	public void LEDCIPHCLEB(AudioClip[] FPJLDJIGIEK)
	{
		if (FPJLDJIGIEK.Length > 0)
		{
			LEDCIPHCLEB(FPJLDJIGIEK[UnityEngine.Random.Range(0, FPJLDJIGIEK.Length)]);
		}
	}

	public virtual void LEDCIPHCLEB(AudioClip FPJLDJIGIEK, float HJIINNCJCCD = 1f)
	{
		if (FPJLDJIGIEK == null)
		{
			LIJNLAAEENC("Warning no audioclip");
			return;
		}
		if (BMANAIHDHKF == null)
		{
			LIJNLAAEENC("No audioSource found");
		}
		if (LPLJMLGKCLK.FJPCBLEEIOH && BMANAIHDHKF != null)
		{
			BMANAIHDHKF.PlayOneShot(FPJLDJIGIEK, LMMFHEODOPM.OGAIBIOLFCN(FPJLDJIGIEK) * HJIINNCJCCD);
		}
	}

	public static float MCLLEALOPDI()
	{
		if (HJDAJDIIMPD.Length > 1)
		{
			Vector2 vector = HJDAJDIIMPD[0].position - HJDAJDIIMPD[1].position;
			Vector2 vector2 = HJDAJDIIMPD[0].position - HJDAJDIIMPD[0].deltaPosition - (HJDAJDIIMPD[1].position - HJDAJDIIMPD[1].deltaPosition);
			return vector.magnitude - vector2.magnitude;
		}
		return 0f;
	}

	public static bool PBNCNLDIFIF(Touch FJBCDEPOGDF, GUITexture FCCPLGMNKOK, float DOGLMPODLGL, params TouchPhase[] LPHLAGOFNPF)
	{
		CIEBMCOJGCC.DKLFCGDEEFJ[FCCPLGMNKOK] = Time.time;
		if (!FCCPLGMNKOK.enabled)
		{
			return false;
		}
		if (PIOANBBCFFP.DALNPKPJAJF)
		{
			return false;
		}
		if (!CIEBMCOJGCC.CPAKDFKNHLL && CIEBMCOJGCC.CDBHMBHFDGI)
		{
			return false;
		}
		if (LPHLAGOFNPF.Length == 0 || LPHLAGOFNPF.AnyF((TouchPhase AEMBPMJMOAB) => AEMBPMJMOAB == FJBCDEPOGDF.phase))
		{
			Vector2 vector = FCCPLGMNKOK.transform.position;
			Vector2 position = FJBCDEPOGDF.position;
			if (OMMLFOEPEEK)
			{
				position.y += 40f;
			}
			position.x /= Screen.width;
			position.y /= Screen.height;
			if ((vector - position).magnitude < DOGLMPODLGL)
			{
				KEBJNPDADMO = FJBCDEPOGDF;
				OPDBLPLDGEF component = FCCPLGMNKOK.GetComponent<OPDBLPLDGEF>();
				if (!CIEBMCOJGCC.AJCCILLLJDP && component != null && !CIEBMCOJGCC.CDBHMBHFDGI && component.FFHOGJBIPJO)
				{
					CIEBMCOJGCC.NKBMFNOFACO(MBIEHEGKCMN: true);
				}
				return true;
			}
		}
		return false;
	}

	public bool PBNCNLDIFIF(GUITexture FCCPLGMNKOK, params TouchPhase[] LPHLAGOFNPF)
	{
		CIEBMCOJGCC.DKLFCGDEEFJ[FCCPLGMNKOK] = Time.time;
		if (!FCCPLGMNKOK.enabled || !FCCPLGMNKOK.gameObject.activeInHierarchy)
		{
			return false;
		}
		if (!DGMBIMMABNO)
		{
			return false;
		}
		if (!CIEBMCOJGCC.CPAKDFKNHLL && CIEBMCOJGCC.CDBHMBHFDGI)
		{
			return false;
		}
		return HJDAJDIIMPD.AnyF((Touch AEMBPMJMOAB) => PBNCNLDIFIF(AEMBPMJMOAB, FCCPLGMNKOK, FCCPLGMNKOK.transform.localScale.x, LPHLAGOFNPF));
	}

	protected float CPGHBAEAGDO(float AEMBPMJMOAB)
	{
		if (AEMBPMJMOAB < 0f)
		{
			return AEMBPMJMOAB + 360f;
		}
		if (AEMBPMJMOAB > 360f)
		{
			return AEMBPMJMOAB - 360f;
		}
		return AEMBPMJMOAB;
	}

	protected float CCKPOMBKIBB(float AEMBPMJMOAB)
	{
		if (AEMBPMJMOAB > 180f)
		{
			return AEMBPMJMOAB - 360f;
		}
		if (AEMBPMJMOAB < -180f)
		{
			return AEMBPMJMOAB + 360f;
		}
		return AEMBPMJMOAB;
	}

	public void HDOGJKGOEIG(Action AEMBPMJMOAB, float HLOAPHLPNJG)
	{
		InvokeRepeating(AEMBPMJMOAB.Method.Name, 0f, HLOAPHLPNJG);
	}

	public void NCHOPAEKPBK(Action DOIIKMIPLNH)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name);
	}

	public void NCHOPAEKPBK<T>(Action<T> DOIIKMIPLNH, T OGJIDBEODPM)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM);
	}

	public void NCHOPAEKPBK<T, T2>(Action<T, T2> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH);
	}

	public void NCHOPAEKPBK<T, T2, T3>(Action<T, T2, T3> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO);
	}

	public void NCHOPAEKPBK<T, T2, T3, T4>(Action<T, T2, T3, T4> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE);
	}

	public void NCHOPAEKPBK<T, T2, T3, T4, T5>(global::JHIIGINPKNB<T, T2, T3, T4, T5> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM);
	}

	public void NCHOPAEKPBK<T, T2, T3, T4, T5, T6>(global::JAMHELEMHCN<T, T2, T3, T4, T5, T6> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH);
	}

	public void NCHOPAEKPBK<T, T2, T3, T4, T5, T6, T7>(global::CJEOHNBBIJD<T, T2, T3, T4, T5, T6, T7> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO);
	}

	public void NCHOPAEKPBK<T, T2, T3, T4, T5, T6, T7, T8>(global::BLGJCFGHFJE<T, T2, T3, T4, T5, T6, T7, T8> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO, T8 EDCGFFAOEGM)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO, EDCGFFAOEGM);
	}

	public void NCHOPAEKPBK<T, T2, T3, T4, T5, T6, T7, T8, T9>(global::JJIHJOLLOPC<T, T2, T3, T4, T5, T6, T7, T8, T9> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO, T8 EDCGFFAOEGM, T9 DLKCKEJJEKI)
	{
		NCHOPAEKPBK(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO, EDCGFFAOEGM, DLKCKEJJEKI);
	}

	public void HBCEJOJNMNB(Action DOIIKMIPLNH)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name);
	}

	public void HBCEJOJNMNB<T>(Action<T> DOIIKMIPLNH, T OGJIDBEODPM)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM);
	}

	public void HBCEJOJNMNB<T, T2>(Action<T, T2> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH);
	}

	public void HBCEJOJNMNB<T, T2, T3>(Action<T, T2, T3> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO);
	}

	public void HBCEJOJNMNB<T, T2, T3, T4>(Action<T, T2, T3, T4> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE);
	}

	public void HBCEJOJNMNB<T, T2, T3, T4, T5>(global::JHIIGINPKNB<T, T2, T3, T4, T5> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM);
	}

	public void HBCEJOJNMNB<T, T2, T3, T4, T5, T6>(global::JAMHELEMHCN<T, T2, T3, T4, T5, T6> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH);
	}

	public void HBCEJOJNMNB<T, T2, T3, T4, T5, T6, T7>(global::CJEOHNBBIJD<T, T2, T3, T4, T5, T6, T7> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO);
	}

	public void HBCEJOJNMNB<T, T2, T3, T4, T5, T6, T7, T8>(global::BLGJCFGHFJE<T, T2, T3, T4, T5, T6, T7, T8> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO, T8 EDCGFFAOEGM)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO, EDCGFFAOEGM);
	}

	public void HBCEJOJNMNB<T, T2, T3, T4, T5, T6, T7, T8, T9>(global::JJIHJOLLOPC<T, T2, T3, T4, T5, T6, T7, T8, T9> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO, T8 EDCGFFAOEGM, T9 DLKCKEJJEKI)
	{
		HBCEJOJNMNB(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO, EDCGFFAOEGM, DLKCKEJJEKI);
	}

	public void NCHOPAEKPBK(string DKOEIHOBGHC, params object[] OGJIDBEODPM)
	{
		if (Application.isEditor)
		{
			if (LPLJMLGKCLK.FDFIHADJLAO)
			{
				LAOFKFBJDGJ.JAPPMNIGMOG++;
				GGANPFEPKJG.RPC(DKOEIHOBGHC, RPCMode.All, OGJIDBEODPM);
			}
			else
			{
				EBHOPCCNJAO.RPC(DKOEIHOBGHC, PhotonTargets.All, OGJIDBEODPM);
			}
			return;
		}
		try
		{
			if (LPLJMLGKCLK.FDFIHADJLAO)
			{
				LAOFKFBJDGJ.JAPPMNIGMOG++;
				GGANPFEPKJG.RPC(DKOEIHOBGHC, RPCMode.All, OGJIDBEODPM);
			}
			else
			{
				EBHOPCCNJAO.RPC(DKOEIHOBGHC, PhotonTargets.All, OGJIDBEODPM);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void FBLBAHLKJEO(object JDKLJHNJNLG, bool LHONKKGAOMD = false)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			Network.CloseConnection((NetworkPlayer)JDKLJHNJNLG, LHONKKGAOMD);
		}
		else
		{
			PhotonNetwork.CloseConnection((PhotonPlayer)JDKLJHNJNLG);
		}
	}

	public void EDBBJHKFJFC(params string[] BPLPPEKMNJB)
	{
		if (LPLJMLGKCLK.FCFBGBPEPOL)
		{
			string message = string.Join(", ", BPLPPEKMNJB);
			Debug.Log(message, this);
		}
	}

	public void HCNJDLNHFIF(string DKOEIHOBGHC, params object[] OGJIDBEODPM)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			GGANPFEPKJG.RPC(DKOEIHOBGHC, RPCMode.AllBuffered, OGJIDBEODPM);
		}
		else
		{
			EBHOPCCNJAO.RPC(DKOEIHOBGHC, PhotonTargets.AllBuffered, OGJIDBEODPM);
		}
	}

	public void PNIJFLNFOPM(string DKOEIHOBGHC, object GCLNIFACGLM, params object[] OGJIDBEODPM)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			GGANPFEPKJG.RPC(DKOEIHOBGHC, (NetworkPlayer)GCLNIFACGLM, OGJIDBEODPM);
		}
		else
		{
			EBHOPCCNJAO.RPC(DKOEIHOBGHC, (PhotonPlayer)GCLNIFACGLM, OGJIDBEODPM);
		}
	}

	public void AFJNAHAPJEE(Action DOIIKMIPLNH)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name);
	}

	public void AFJNAHAPJEE<T>(Action<T> DOIIKMIPLNH, T OGJIDBEODPM)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM);
	}

	public void AFJNAHAPJEE<T, T2>(Action<T, T2> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH);
	}

	public void AFJNAHAPJEE<T, T2, T3>(Action<T, T2, T3> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO);
	}

	public void AFJNAHAPJEE<T, T2, T3, T4>(Action<T, T2, T3, T4> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE);
	}

	public void AFJNAHAPJEE<T, T2, T3, T4, T5>(global::JHIIGINPKNB<T, T2, T3, T4, T5> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM);
	}

	public void AFJNAHAPJEE<T, T2, T3, T4, T5, T6>(global::JAMHELEMHCN<T, T2, T3, T4, T5, T6> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH);
	}

	public void AFJNAHAPJEE<T, T2, T3, T4, T5, T6, T7>(global::CJEOHNBBIJD<T, T2, T3, T4, T5, T6, T7> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO);
	}

	public void AFJNAHAPJEE<T, T2, T3, T4, T5, T6, T7, T8>(global::BLGJCFGHFJE<T, T2, T3, T4, T5, T6, T7, T8> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO, T8 EDCGFFAOEGM)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO, EDCGFFAOEGM);
	}

	public void AFJNAHAPJEE<T, T2, T3, T4, T5, T6, T7, T8, T9>(global::JJIHJOLLOPC<T, T2, T3, T4, T5, T6, T7, T8, T9> DOIIKMIPLNH, T OGJIDBEODPM, T2 PLPIOMGGMJH, T3 LFGFNKJJDAO, T4 LDLCHCDHIKE, T5 PJEBMLPJGPM, T6 MFMNEFJCNLH, T7 DOHGFGGFJGO, T8 EDCGFFAOEGM, T9 DLKCKEJJEKI)
	{
		AFJNAHAPJEE(DOIIKMIPLNH.Method.Name, OGJIDBEODPM, PLPIOMGGMJH, LFGFNKJJDAO, LDLCHCDHIKE, PJEBMLPJGPM, MFMNEFJCNLH, DOHGFGGFJGO, EDCGFFAOEGM, DLKCKEJJEKI);
	}

	public void AFJNAHAPJEE(string DKOEIHOBGHC, params object[] OGJIDBEODPM)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			if (NENPALDENAL)
			{
				GetType().GetMethod(DKOEIHOBGHC).Invoke(this, OGJIDBEODPM);
			}
			else
			{
				GGANPFEPKJG.RPC(DKOEIHOBGHC, RPCMode.Server, OGJIDBEODPM);
			}
		}
		else
		{
			EBHOPCCNJAO.RPC(DKOEIHOBGHC, PhotonTargets.MasterClient, OGJIDBEODPM);
		}
	}

	public void HBCEJOJNMNB(string DKOEIHOBGHC, params object[] OGJIDBEODPM)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			GGANPFEPKJG.RPC(DKOEIHOBGHC, EGHJJCHMKDF, OGJIDBEODPM);
		}
		else
		{
			EBHOPCCNJAO.RPC(DKOEIHOBGHC, PDKHDCBCOMO, OGJIDBEODPM);
		}
	}

	public void OnPhotonPlayerConnected(PhotonPlayer KIMKOKHHENG)
	{
		PDKHDCBCOMO = KIMKOKHHENG;
		if (PhotonNetwork.isMasterClient)
		{
			BJGMKFIGEFA();
		}
	}

	public virtual void BJGMKFIGEFA()
	{
	}

	[RPC]
	public void MJIBIOLJNEP()
	{
		GGANPFEPKJG.RPC("AMOJPENNNLB", RPCMode.AllBuffered);
	}

	public void APAMPKPNIPC()
	{
		BIHOCPAKHNF("destroy " + ICIEDCMDJFO.name);
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			GGANPFEPKJG.RPC("AMOJPENNNLB", RPCMode.AllBuffered);
		}
		else
		{
			PhotonNetwork.Destroy(ICIEDCMDJFO);
		}
	}

	public void APMAPOPIOAB()
	{
		BIHOCPAKHNF("destroy " + ICIEDCMDJFO.name);
		if (LPLJMLGKCLK.FDFIHADJLAO || JNPCOJFBJGP)
		{
			Network.Destroy(ICIEDCMDJFO);
		}
	}

	[RPC]
	public virtual void KACJNPGMJLD()
	{
		if (KAMAMHFJDGG)
		{
			PhotonNetwork.Destroy(ICIEDCMDJFO);
		}
		else
		{
			ICIEDCMDJFO.SetActive(value: false);
		}
	}

	[RPC]
	internal void AMOJPENNNLB()
	{
		if (KAMAMHFJDGG)
		{
			if (GGANPFEPKJG.group != 0)
			{
				Network.RemoveRPCs(GGANPFEPKJG.owner, GGANPFEPKJG.group);
				PBDAOOIJGIA[GGANPFEPKJG.group] = false;
			}
			else
			{
				EDBBJHKFJFC("0 Group Destroy");
			}
		}
		UnityEngine.Object.Destroy(ICIEDCMDJFO);
	}

	public void OENODCJHEOG()
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			Network.Disconnect();
		}
		else
		{
			PhotonNetwork.LeaveRoom();
		}
		PIOANBBCFFP.OnLeftRoom();
	}

	public void MPJGBJBIKGK(int MKBNKANDCDB)
	{
		SceneManager.LoadScene(MKBNKANDCDB);
	}

	public void LKJPNMPAGND(string JPBEBBODCJJ, string NGIHJKGIKNA, bool BAFJCPENDPG, GameObject BIMHAGOKNME = null)
	{
		string text = ((!BAFJCPENDPG) ? (NGIHJKGIKNA + JPBEBBODCJJ) : JPBEBBODCJJ);
		if (!NGANNJFFIMG.ILGHLAIGJKP(text))
		{
			try
			{
				NGANNJFFIMG.KMOLNKBLGDC(text, (BIMHAGOKNME != null) ? BIMHAGOKNME : ((!BAFJCPENDPG) ? Resources.Load<GameObject>(text) : OKJJJBOEGBJ.ICKGAFPAEEI(text, NGIHJKGIKNA).LoadAsset<GameObject>(text)));
			}
			catch (Exception message)
			{
				Debug.LogErrorFormat(">>Error cache '{0}' Return null!", text);
				Debug.LogError(message);
				NGANNJFFIMG.KMOLNKBLGDC(text, NGANNJFFIMG.ELKMMPDEDAK("ERROR_MDL"));
			}
		}
	}

	public GameObject JMJLEDGJIJK(string JPBEBBODCJJ, string NGIHJKGIKNA, bool BAFJCPENDPG, GameObject BIMHAGOKNME, Transform JNEBJLMLOLM, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, bool HHGMPEKADME = false, bool JHJCGOIEMOF = false)
	{
		LKJPNMPAGND(JPBEBBODCJJ, NGIHJKGIKNA, BAFJCPENDPG, BIMHAGOKNME);
		string jPBEBBODCJJ = ((!BAFJCPENDPG) ? (NGIHJKGIKNA + JPBEBBODCJJ) : JPBEBBODCJJ);
		Transform obj;
		if (!JNEBJLMLOLM)
		{
			obj = NGANNJFFIMG.OHGENNNIPJH(jPBEBBODCJJ).transform;
		}
		else
		{
			NGANNJFFIMG.OHGENNNIPJH(jPBEBBODCJJ).transform.parent = JNEBJLMLOLM;
			obj = JNEBJLMLOLM;
		}
		Transform transform = obj;
		if (!HHGMPEKADME)
		{
			transform.position = GIDEOJGAFJH;
		}
		if (!JHJCGOIEMOF)
		{
			transform.rotation = JPINOKOACLM;
		}
		return transform.gameObject;
	}

	public GameObject CFBOHBGDAGD(string JPBEBBODCJJ, string NGIHJKGIKNA = null, bool BAFJCPENDPG = false)
	{
		LKJPNMPAGND(JPBEBBODCJJ, NGIHJKGIKNA, BAFJCPENDPG);
		return NGANNJFFIMG.ELKMMPDEDAK(JPBEBBODCJJ);
	}

	public void JPBIAJIBLCG(string BDLEDKLPBLI, string NGIHJKGIKNA, MeshFilter KNEAHNDGMNO, MeshRenderer NOHDDMNKKBF)
	{
		GameObject gameObject = CFBOHBGDAGD(BDLEDKLPBLI, NGIHJKGIKNA, BAFJCPENDPG: true);
		KNEAHNDGMNO.sharedMesh = gameObject.GetComponent<MeshFilter>().sharedMesh;
		NOHDDMNKKBF.sharedMaterials = gameObject.GetComponent<MeshRenderer>().sharedMaterials;
	}

	public GameObject NPDKFEEDEGM(string BDLEDKLPBLI, string NGIHJKGIKNA, bool BAFJCPENDPG, Transform DJHGJAGNNLH = null)
	{
		GameObject result = null;
		GameObject gameObject = CFBOHBGDAGD(BDLEDKLPBLI, NGIHJKGIKNA, BAFJCPENDPG);
		try
		{
			SkinnedMeshRenderer[] componentsInChildren = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMesh in componentsInChildren)
			{
				result = DJHGJAGNNLH.CreateSubModel(skinnedMesh);
			}
		}
		catch (Exception message)
		{
			result = JMJLEDGJIJK("ERROR_MDL", null, BAFJCPENDPG: false, null, DJHGJAGNNLH, DJHGJAGNNLH.position, DJHGJAGNNLH.rotation);
			Debug.LogError(message);
		}
		return result;
	}

	public GameObject JGAIKNAONPN(UnityEngine.Object AMPIHEJLALO, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		return JGAIKNAONPN(AMPIHEJLALO.name, GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
	}

	public GameObject JGAIKNAONPN(string JNEBMCPAJAE, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			PBDAOOIJGIA[0] = true;
			int num = Array.IndexOf(PBDAOOIJGIA, value: false);
			PBDAOOIJGIA[num] = true;
			BIHOCPAKHNF("NetworkInstantiate " + ICIEDCMDJFO.name + ":" + JNEBMCPAJAE);
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load(JNEBMCPAJAE), GIDEOJGAFJH, JPINOKOACLM, num);
			gameObject.GetComponent<NetworkView>().RPC("ONPLFIBKCDB", RPCMode.AllBuffered, num);
			return gameObject;
		}
		return PhotonNetwork.Instantiate(JNEBMCPAJAE, GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
	}

	public GameObject EEAPILCEHAF(UnityEngine.Object AMPIHEJLALO, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		return EEAPILCEHAF(AMPIHEJLALO.name, GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
	}

	public GameObject EEAPILCEHAF(string JNEBMCPAJAE, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			return (GameObject)Network.Instantiate(Resources.Load(JNEBMCPAJAE), GIDEOJGAFJH, JPINOKOACLM, 0);
		}
		return PhotonNetwork.Instantiate(JNEBMCPAJAE, GIDEOJGAFJH, JPINOKOACLM, 0);
	}

	public GameObject ICONFJBEJPN(UnityEngine.Object AMPIHEJLALO, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		return ICONFJBEJPN(AMPIHEJLALO.name, GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
	}

	public GameObject ICONFJBEJPN(string JNEBMCPAJAE, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			PBDAOOIJGIA[0] = true;
			int num = Array.IndexOf(PBDAOOIJGIA, value: false);
			PBDAOOIJGIA[num] = true;
			BIHOCPAKHNF("NetworkInstantiate " + ICIEDCMDJFO.name + ":" + JNEBMCPAJAE);
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load(JNEBMCPAJAE), GIDEOJGAFJH, JPINOKOACLM, num);
			gameObject.GetComponent<NetworkView>().RPC("ONPLFIBKCDB", RPCMode.All, num);
			return gameObject;
		}
		return PhotonNetwork.Instantiate(JNEBMCPAJAE, GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
	}

	public GameObject FKNLKLHNDHH(UnityEngine.Object AMPIHEJLALO, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		return FKNLKLHNDHH(AMPIHEJLALO.name, GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
	}

	public GameObject FKNLKLHNDHH(string JNEBMCPAJAE, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, int EEOADOGBGFH)
	{
		if (LPLJMLGKCLK.FDFIHADJLAO)
		{
			return (GameObject)Network.Instantiate(Resources.Load(JNEBMCPAJAE), GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
		}
		return PhotonNetwork.Instantiate(JNEBMCPAJAE, GIDEOJGAFJH, JPINOKOACLM, EEOADOGBGFH);
	}

	public void OnPlayerConnected(NetworkPlayer KIMKOKHHENG)
	{
		if (Network.isServer && GGANPFEPKJG != null)
		{
			GGANPFEPKJG.RPC("ONPLFIBKCDB", KIMKOKHHENG, GGANPFEPKJG.group);
		}
		EGHJJCHMKDF = KIMKOKHHENG;
		BJGMKFIGEFA();
	}

	[RPC]
	public void ONPLFIBKCDB(int GIPIKICBHKA)
	{
		GGANPFEPKJG.group = GIPIKICBHKA;
	}

	public bool MHFCLILDBCM(GUIContent KLLKONMADKA, params GUILayoutOption[] OGJIDBEODPM)
	{
		return MHFCLILDBCM(null, null, KLLKONMADKA, null, OGJIDBEODPM);
	}

	public static bool MHFCLILDBCM(string KLLKONMADKA, GUIStyle EPDKDICMOHH, params GUILayoutOption[] OGJIDBEODPM)
	{
		return MHFCLILDBCM(KLLKONMADKA, EPDKDICMOHH, null, null, OGJIDBEODPM);
	}

	public static bool MHFCLILDBCM(string KLLKONMADKA, params GUILayoutOption[] OGJIDBEODPM)
	{
		return MHFCLILDBCM(KLLKONMADKA, null, null, null, OGJIDBEODPM);
	}

	public static bool MHFCLILDBCM(string KLLKONMADKA, GUIStyle EPDKDICMOHH, GUIContent AGPGDJIGBOM, Texture2D INEHJPNOKOB, params GUILayoutOption[] OGJIDBEODPM)
	{
		KJIDCLAGBKG++;
		string text = FHHPMGJCHJL(KLLKONMADKA);
		string tooltip = FHHPMGJCHJL(KLLKONMADKA, EFPKGAAFKFG.tips, string.Empty);
		if (EHBNELHGBHE != string.Empty && (text == null || !text.ToLower().Contains(EHBNELHGBHE)))
		{
			return false;
		}
		if (EFECLAMJIFH == KJIDCLAGBKG)
		{
			text = ">" + text;
		}
		bool flag = ((EPDKDICMOHH != null) ? GUILayout.Button(new GUIContent(text, tooltip), EPDKDICMOHH, OGJIDBEODPM) : ((AGPGDJIGBOM == null) ? GUILayout.Button(new GUIContent(text, tooltip), OGJIDBEODPM) : GUILayout.Button(AGPGDJIGBOM, OGJIDBEODPM)));
		if (ENJKFFABFIL > 0 && EFECLAMJIFH == KJIDCLAGBKG)
		{
			ENJKFFABFIL = 0;
			flag = true;
		}
		if (flag)
		{
			GGDOAMMBEAJ(KLLKONMADKA);
		}
		return flag;
	}

	private static void GGDOAMMBEAJ(string KLLKONMADKA)
	{
		MonoBehaviour.print("Button click " + KLLKONMADKA);
		if (LPLJMLGKCLK.FJPCBLEEIOH)
		{
			LPLJMLGKCLK.BMANAIHDHKF.PlayOneShot(LPLJMLGKCLK.HMHHBHNOLEM);
		}
	}

	public static string ODCONJOFBPD(string KLLKONMADKA, params GUILayoutOption[] FBABKGEPFFF)
	{
		return GUILayout.TextField(KLLKONMADKA, FBABKGEPFFF).ToLower();
	}

	public static string HJNJCLGIEIH(string KLLKONMADKA, params GUILayoutOption[] FBABKGEPFFF)
	{
		return GUILayout.TextField(KLLKONMADKA, FBABKGEPFFF);
	}

	public static void IAOONCAPLGK(string KLLKONMADKA, params GUILayoutOption[] OGJIDBEODPM)
	{
		string tooltip = FHHPMGJCHJL(KLLKONMADKA, EFPKGAAFKFG.tips, string.Empty);
		string text = FHHPMGJCHJL(KLLKONMADKA);
		if (!(EHBNELHGBHE != string.Empty) || text.ToLower().Contains(EHBNELHGBHE))
		{
			GUILayout.Label(new GUIContent(text, tooltip), OGJIDBEODPM);
		}
	}

	public float JJCCBMNJNEF(string KLLKONMADKA, float GOEDOMPFLHO, float CNCBDDAFLCK, float CAFPPIFOMLO)
	{
		return JJCCBMNJNEF(KLLKONMADKA, GOEDOMPFLHO, CNCBDDAFLCK, CAFPPIFOMLO, 100f);
	}

	public float JJCCBMNJNEF(string KLLKONMADKA, float GOEDOMPFLHO, float CNCBDDAFLCK, float CAFPPIFOMLO, float LMGLPJKCHKE)
	{
		string text = FHHPMGJCHJL(KLLKONMADKA);
		string tooltip = FHHPMGJCHJL(KLLKONMADKA, EFPKGAAFKFG.tips, string.Empty);
		if (EHBNELHGBHE != string.Empty && !text.ToLower().Contains(EHBNELHGBHE))
		{
			return GOEDOMPFLHO;
		}
		GUILayout.BeginHorizontal();
		GUILayout.Label(new GUIContent(text, tooltip), GUILayout.ExpandWidth(expand: false));
		GOEDOMPFLHO = GUILayout.HorizontalSlider(GOEDOMPFLHO, CNCBDDAFLCK, CAFPPIFOMLO);
		GUILayout.Label((int)(GOEDOMPFLHO * LMGLPJKCHKE) + ((LMGLPJKCHKE != 100f) ? string.Empty : "%"), GUILayout.ExpandWidth(expand: false));
		GUILayout.EndHorizontal();
		return GOEDOMPFLHO;
	}

	public static bool HGHFNJMFLHM(bool EHAPKEKPMOE, string KLLKONMADKA, params GUILayoutOption[] FBABKGEPFFF)
	{
		string text = FHHPMGJCHJL(KLLKONMADKA);
		string tooltip = FHHPMGJCHJL(KLLKONMADKA, EFPKGAAFKFG.tips, string.Empty);
		if (EHBNELHGBHE == string.Empty || text.ToLower().Contains(EHBNELHGBHE))
		{
			return GUILayout.Toggle(EHAPKEKPMOE, new GUIContent(text, tooltip), FBABKGEPFFF);
		}
		return EHAPKEKPMOE;
	}

	public static string PNDGEJONGLI()
	{
		DateTime now = DateTime.Now;
		return now.Minute + ":" + now.Second;
	}

	public static void PBADCKNDABE(string PGLLNPGKJBE)
	{
		GLNAMCPCICH.DLILAHLOKKC();
		LPLJMLGKCLK.CODBKMAMEHL.PBADCKNDABE(string.Empty, PGLLNPGKJBE);
	}

	public static void PBADCKNDABE(string MHCPAFPDMGO, string PGLLNPGKJBE, string PMHLHIIDMEG = "OK", bool MMJNLLMFOCD = false, bool INFLOKFCACB = false)
	{
		LPLJMLGKCLK.CODBKMAMEHL.PBADCKNDABE(MHCPAFPDMGO, PGLLNPGKJBE, PMHLHIIDMEG, MMJNLLMFOCD, INFLOKFCACB);
	}

	protected Vector3 DCBCHPFICFO(Vector3 AEMBPMJMOAB)
	{
		if (AEMBPMJMOAB.x > 180f)
		{
			AEMBPMJMOAB.x -= 360f;
		}
		if (AEMBPMJMOAB.y > 180f)
		{
			AEMBPMJMOAB.y -= 360f;
		}
		if (AEMBPMJMOAB.z > 180f)
		{
			AEMBPMJMOAB.z -= 360f;
		}
		return AEMBPMJMOAB;
	}

	public static string JJHNFGLOCBC(string FCBABFMAPBI)
	{
		string text = string.Empty;
		MatchCollection matchCollection = Regex.Matches(FCBABFMAPBI, "\\w*\\s*");
		for (int i = 0; i < matchCollection.Count - 1; i++)
		{
			string text2 = text;
			text = text2 + "{" + i + ",-" + matchCollection[i].Length + "}";
		}
		return text;
	}

	public static bool DNJOLNHKJAA(KeyCode HINLOMMOGKI)
	{
		if (OMMLFOEPEEK && Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(HINLOMMOGKI) && (PIOANBBCFFP == null || !PIOANBBCFFP.IGJKLHOGPHL))
		{
			return true;
		}
		return false;
	}

	public string IMPKMAEGMMF(string LGNIFJCEECH)
	{
		int num = LGNIFJCEECH.IndexOf("\r\n", StringComparison.Ordinal) + 2;
		return LGNIFJCEECH.Substring(num, LGNIFJCEECH.Length - num);
	}

	public static Vector3 KDCGBDNNCHM(Vector3 PDAKFGKELOC)
	{
		PDAKFGKELOC.y = 0f;
		return PDAKFGKELOC;
	}

	public static Vector3 MLBFELNKLPM(Vector3 PDAKFGKELOC)
	{
		PDAKFGKELOC.z = 0f;
		return PDAKFGKELOC;
	}

	public static Vector3 AENMOAHJKBD(Vector3 PDAKFGKELOC)
	{
		PDAKFGKELOC.z = 0f;
		PDAKFGKELOC.x = 0f;
		return PDAKFGKELOC;
	}

	public static string HOFLHGIGCBP(string LGNIFJCEECH)
	{
		return Regex.Replace(LGNIFJCEECH, "[\\d]", string.Empty, RegexOptions.IgnoreCase);
	}

	public static string GIGJFCBMKMO(string LGNIFJCEECH)
	{
		if (POBNHAPIIDH.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(LGNIFJCEECH);
		fileNameWithoutExtension = fileNameWithoutExtension.Replace("%20", " ");
		string extension = Path.GetExtension(LGNIFJCEECH);
		string text;
		if (!extension.StartsWith(".unity") && !extension.StartsWith(".dae"))
		{
			text = LGNIFJCEECH;
			POBNHAPIIDH[LGNIFJCEECH] = text;
			return text;
		}
		text = fileNameWithoutExtension;
		POBNHAPIIDH[LGNIFJCEECH] = text;
		return text;
	}

	public static Vector3 BMLFFBGLAFI(Vector3 PDAKFGKELOC)
	{
		PDAKFGKELOC.y = 0f;
		return PDAKFGKELOC.normalized;
	}

	public Quaternion MHHIMJKEAGH(byte[] BKOEGJJBGBC)
	{
		using MemoryStream input = new MemoryStream(BKOEGJJBGBC);
		BinaryReader binaryReader = new BinaryReader(input);
		float x = (float)(int)binaryReader.ReadByte() / 255f * 360f;
		float y = (float)(int)binaryReader.ReadByte() / 255f * 360f;
		return Quaternion.Euler(x, y, 0f);
	}

	public byte[] MHHIMJKEAGH(Quaternion HMJCPCFNFIE)
	{
		Vector3 eulerAngles = HMJCPCFNFIE.eulerAngles;
		using MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write((byte)(eulerAngles.x / 360f * 255f));
		binaryWriter.Write((byte)(eulerAngles.y / 360f * 255f));
		return memoryStream.ToArray();
	}

	public byte[] AHFBNDAFFNG(Vector3 PDAKFGKELOC)
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write((short)(Mathf.Clamp(PDAKFGKELOC.x, -100f, 100f) / 100f * 16383f));
		binaryWriter.Write((short)(Mathf.Clamp(PDAKFGKELOC.y, -100f, 100f) / 100f * 16383f));
		binaryWriter.Write((short)(Mathf.Clamp(PDAKFGKELOC.z, -100f, 100f) / 100f * 16383f));
		return memoryStream.ToArray();
	}

	public Vector3 AHFBNDAFFNG(byte[] BKOEGJJBGBC)
	{
		using MemoryStream input = new MemoryStream(BKOEGJJBGBC);
		BinaryReader binaryReader = new BinaryReader(input);
		short num = binaryReader.ReadInt16();
		short num2 = binaryReader.ReadInt16();
		short num3 = binaryReader.ReadInt16();
		return new Vector3((float)num / 16383f * 100f, (float)num2 / 16383f * 100f, (float)num3 / 16383f * 100f);
	}

	public bool NHGEPCNECIC(Vector3 ELGIKGAIIOD)
	{
		return ((ELGIKGAIIOD - Camera.main.transform.position).magnitude < 10f && !DGMBIMMABNO) || CNLHEJPILGH(Camera.main.transform, ELGIKGAIIOD);
	}

	public bool CNLHEJPILGH(Vector3 ELGIKGAIIOD, int IBAAKMHOOJI = 1024, float HBDCNBDNJMN = 0f)
	{
		return CNLHEJPILGH(NGFDFPGNDCJ.EHOEFMPLIFB, ELGIKGAIIOD, IBAAKMHOOJI);
	}

	public bool CNLHEJPILGH(Transform GDKFLGBMPBB, Vector3 ELGIKGAIIOD, int IBAAKMHOOJI = 1024, float HBDCNBDNJMN = 0f)
	{
		Vector3 vector = NGFDFPGNDCJ.CICDHCEOLLE.WorldToViewportPoint(ELGIKGAIIOD);
		if (new Rect(0f, 0f, 1f, 1f).Contains(NGFDFPGNDCJ.CICDHCEOLLE.WorldToViewportPoint(ELGIKGAIIOD)) && vector.z >= 0f)
		{
			if (NGFDFPGNDCJ.AEBCFFNADHM)
			{
				return false;
			}
			Vector3 position = GDKFLGBMPBB.position;
			if (OMMLFOEPEEK)
			{
				Debug.DrawLine(position, ELGIKGAIIOD);
			}
			ELGIKGAIIOD += (position - ELGIKGAIIOD).normalized * 0.1f;
			Vector3 direction = ELGIKGAIIOD - position;
			float num = direction.magnitude - HBDCNBDNJMN;
			if (num < 0f)
			{
				return true;
			}
			return !Physics.Raycast(position, direction, num, IBAAKMHOOJI);
		}
		return false;
	}

	public bool IIGANLCMBGC(Vector3 HPPAAHDIPDE, Vector3 GCLNIFACGLM, int CGCKIAPBFBI = 1024)
	{
		Vector3 direction = GCLNIFACGLM - HPPAAHDIPDE;
		return Physics.Raycast(HPPAAHDIPDE, direction, direction.magnitude, CGCKIAPBFBI);
	}

	public static void NGLMHFOKCHK(int GDIFBJBOCJM, int MBIEHEGKCMN, string LKDPILFBEAI, GUI.WindowFunction AIJHAMAOMIA, FGJCEHCCEEO PEACKNKHECJ = FGJCEHCCEEO.FKLLHKLPIDE)
	{
		NGLMHFOKCHK(GDIFBJBOCJM, MBIEHEGKCMN, LKDPILFBEAI, AIJHAMAOMIA, PEACKNKHECJ, NBOGOKNEBGI.IPBFPHDFNNH, GUI.skin.window);
	}

	public static void NGLMHFOKCHK(int GDIFBJBOCJM, int MBIEHEGKCMN, string LKDPILFBEAI, GUI.WindowFunction AIJHAMAOMIA, FGJCEHCCEEO PEACKNKHECJ, NBOGOKNEBGI GPDOGCMPINO, GUIStyle CKMCOIMLNPJ, float DBHBGABEKJH = 0f, float OFJKFGMMHFL = 0f)
	{
		KJIDCLAGBKG = 0;
		if (AIJHAMAOMIA != OGGMOGPPPHC)
		{
			EFECLAMJIFH = 0;
		}
		OGGMOGPPPHC = AIJHAMAOMIA;
		Vector3 zero = Vector3.zero;
		int num = (int)((float)Screen.width / NOMMEFIICHO.JDDEBAANKEA.x);
		int num2 = (int)((float)Screen.height / NOMMEFIICHO.JDDEBAANKEA.y);
		Vector3 vector = new Vector3(Mathf.Min(num, GDIFBJBOCJM), Mathf.Min(num2, MBIEHEGKCMN)) / 2f;
		zero = GPDOGCMPINO switch
		{
			NBOGOKNEBGI.GDGBPJODALD => new Vector3((float)num - vector.x - 20f, (float)num2 / 2f), 
			NBOGOKNEBGI.ILDFJCPEPLF => new Vector3(0f, (float)num2 / 2f), 
			NBOGOKNEBGI.DJBGAOOAGEO => new Vector3(DBHBGABEKJH, (float)num2 / OFJKFGMMHFL), 
			_ => new Vector3(num, num2) / 2f, 
		};
		Vector3 vector2 = zero - vector;
		Vector3 vector3 = zero + vector;
		IGBGDNLNDJM = Rect.MinMaxRect(vector2.x, vector2.y, vector3.x, vector3.y);
		GUI.Window((int)PEACKNKHECJ, IGBGDNLNDJM, delegate(int AEMBPMJMOAB)
		{
			AIJHAMAOMIA(AEMBPMJMOAB);
			OFCBNEMGAPI(GUI.tooltip);
		}, LKDPILFBEAI, CKMCOIMLNPJ);
	}

	public static void OFCBNEMGAPI(string BMDKKJDOAHL)
	{
		if (!string.IsNullOrEmpty(GUI.tooltip) && BMDKKJDOAHL == GUI.tooltip)
		{
			GUI.Box(new Rect(80f, Event.current.mousePosition.y - 60f, 500f, 40f), GUI.tooltip);
		}
	}

	public static WWW MPLIECCKLCO(string LGNIFJCEECH, Action<string> AEMBPMJMOAB, params object[] IAKLBHKKNFM)
	{
		int num = UnityEngine.Random.Range(0, 50000);
		string text = BEHFNEAKDAL.BIJHBGLFDAP;
		IEnumerable<object> source = new object[10]
		{
			"name",
			LPLJMLGKCLK.GPJONKKMEKD,
			"password",
			LPLJMLGKCLK.IIKAFLBAEML,
			"msgID",
			num,
			"uid",
			BEHFNEAKDAL.NAHEOIEEACO,
			"md5",
			Ext.CalculateMD5Hash(LPLJMLGKCLK.GPJONKKMEKD + num + "er54")
		}.Concat(IAKLBHKKNFM);
		return KFEIIDMFOLF(text + LGNIFJCEECH, AEMBPMJMOAB, source.ToArray());
	}

	public static WWW KFEIIDMFOLF(string LGNIFJCEECH, params object[] IAKLBHKKNFM)
	{
		return KFEIIDMFOLF(LGNIFJCEECH, KEPLDHKBEJG, IAKLBHKKNFM);
	}

	private static void KEPLDHKBEJG(string KLLKONMADKA)
	{
	}

	public static WWW KFEIIDMFOLF(string LGNIFJCEECH, Action<string> AEMBPMJMOAB, params object[] IAKLBHKKNFM)
	{
		WWW wWW;
		if (IAKLBHKKNFM.Length > 0)
		{
			StringBuilder stringBuilder = new StringBuilder(LGNIFJCEECH);
			WWWForm wWWForm = new WWWForm();
			for (int i = 0; i < IAKLBHKKNFM.Length; i += 2)
			{
				if (EKGNDFOPKLC)
				{
					if (IAKLBHKKNFM[i + 1] is byte[])
					{
						wWWForm.AddBinaryData(IAKLBHKKNFM[i].ToString(), (byte[])IAKLBHKKNFM[i + 1]);
					}
					else
					{
						wWWForm.AddField(IAKLBHKKNFM[i].ToString(), IAKLBHKKNFM[i + 1].ToString());
					}
				}
				else
				{
					stringBuilder.Append((i == 0) ? '?' : '&');
					stringBuilder.Append(string.Concat(IAKLBHKKNFM[i], "=", WWW.EscapeURL(IAKLBHKKNFM[i + 1].ToString())));
				}
			}
			wWW = ((!EKGNDFOPKLC) ? new WWW(stringBuilder.ToString()) : new WWW(stringBuilder.ToString(), wWWForm));
		}
		else
		{
			wWW = new WWW(LGNIFJCEECH);
		}
		LPLJMLGKCLK.StartCoroutine(MIDHNNIKOJJ(AEMBPMJMOAB, wWW));
		EKGNDFOPKLC = false;
		return wWW;
	}

	public GUIStyle MBKHABKMDLJ(string LGNIFJCEECH)
	{
		if (CEBPMBPFENM.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		GUIStyle gUIStyle = GUI.skin.FindStyle(LGNIFJCEECH);
		CEBPMBPFENM[LGNIFJCEECH] = gUIStyle;
		return gUIStyle;
	}

	private static IEnumerator MIDHNNIKOJJ(Action<string> AEMBPMJMOAB, WWW GDIFBJBOCJM)
	{
		Action<string> iKJHNNLICBA = IKJHNNLICBA;
		IKJHNNLICBA = null;
		yield return GDIFBJBOCJM;
		if (string.IsNullOrEmpty(GDIFBJBOCJM.error) && !GDIFBJBOCJM.text.Trim().StartsWith("<") && !GDIFBJBOCJM.text.Trim().StartsWith("java.net"))
		{
			AEMBPMJMOAB(GDIFBJBOCJM.text);
		}
		else if (iKJHNNLICBA != null)
		{
			iKJHNNLICBA(GDIFBJBOCJM.error);
		}
		else if (GDIFBJBOCJM.error != null && GDIFBJBOCJM.error.StartsWith("Could not resolve host:"))
		{
			PBADCKNDABE("Error", FHHPMGJCHJL("No network connection"));
		}
	}

	public static IEnumerator IPBKDPKONHH(float DGJBIAGPCEE, Action OMBCDMOHJOK)
	{
		yield return new WaitForSeconds(DGJBIAGPCEE);
		OMBCDMOHJOK();
	}

	public static IEnumerator IPBKDPKONHH(YieldInstruction PIFPICMFHAD, Action OMBCDMOHJOK)
	{
		yield return PIFPICMFHAD;
		OMBCDMOHJOK();
	}

	public static IEnumerator IPBKDPKONHH(Action OMBCDMOHJOK)
	{
		yield return null;
		OMBCDMOHJOK();
	}

	public static IEnumerator IPBKDPKONHH(WWW KGEFJGEPFJD, Action OMBCDMOHJOK)
	{
		yield return KGEFJGEPFJD;
		OMBCDMOHJOK();
	}

	public int DDCEGGMMPDG(Action<BinaryReader> OMBCDMOHJOK)
	{
		int DCABBCPLGEM = UnityEngine.Random.Range(0, int.MaxValue);
		BGMIEGBKLFD.Add(DCABBCPLGEM, OMBCDMOHJOK);
		StartCoroutine(IPBKDPKONHH(5f, delegate
		{
			BGMIEGBKLFD.Remove(DCABBCPLGEM);
		}));
		return DCABBCPLGEM;
	}

	public static void BKFOLNBKJCO()
	{
		DLMAPMNLKEE.Clear();
		AAAMBCDLDHF.Clear();
		AHLLIHBFMEL.Clear();
		PJMPKAMGHNF.Clear();
	}

	public static bool AEIBIFEDBFB(string LGNIFJCEECH, bool PDDIANLEPOC = false)
	{
		if (PJMPKAMGHNF.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		bool flag = JKPOJMOFFMF.GMOOMLGMADD(LGNIFJCEECH, PDDIANLEPOC ? 1 : 0) == 1;
		PJMPKAMGHNF[LGNIFJCEECH] = flag;
		return flag;
	}

	public static void EDFAGIMHLFA(string LGNIFJCEECH, bool EHAPKEKPMOE)
	{
		if (!PJMPKAMGHNF.TryGetValue(LGNIFJCEECH, out var value) || value != EHAPKEKPMOE)
		{
			PJMPKAMGHNF[LGNIFJCEECH] = EHAPKEKPMOE;
			JKPOJMOFFMF.OLEHBAMBPDE(LGNIFJCEECH, EHAPKEKPMOE ? 1 : 0);
		}
	}

	public static int ICLCHCGKAPN(string LGNIFJCEECH, int PDDIANLEPOC = 0)
	{
		if (DLMAPMNLKEE.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		int num = JKPOJMOFFMF.GMOOMLGMADD(LGNIFJCEECH, PDDIANLEPOC);
		DLMAPMNLKEE[LGNIFJCEECH] = num;
		return num;
	}

	public static void BBKFOHCEOCK(string LGNIFJCEECH, int EHAPKEKPMOE)
	{
		if (!DLMAPMNLKEE.TryGetValue(LGNIFJCEECH, out var value) || value != EHAPKEKPMOE)
		{
			DLMAPMNLKEE[LGNIFJCEECH] = EHAPKEKPMOE;
			JKPOJMOFFMF.OLEHBAMBPDE(LGNIFJCEECH, EHAPKEKPMOE);
		}
	}

	public static float CMBFGIGIDIP(string LGNIFJCEECH, float PDDIANLEPOC = 0f)
	{
		if (AAAMBCDLDHF.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		float num = JKPOJMOFFMF.OKJLGPNLEIG(LGNIFJCEECH, PDDIANLEPOC);
		AAAMBCDLDHF[LGNIFJCEECH] = num;
		return num;
	}

	public static void DEJNFKMKPKN(string LGNIFJCEECH, float IFKMKLFPKGG)
	{
		if (!AAAMBCDLDHF.TryGetValue(LGNIFJCEECH, out var value) || value != IFKMKLFPKGG)
		{
			AAAMBCDLDHF[LGNIFJCEECH] = IFKMKLFPKGG;
			JKPOJMOFFMF.FOFEDEEKMNC(LGNIFJCEECH, IFKMKLFPKGG);
		}
	}

	public static Vector3 KOICGINMHBC(string LGNIFJCEECH, Vector3 PDDIANLEPOC = default(Vector3))
	{
		if (ECACAAAECKN.TryGetValue(LGNIFJCEECH, out var value))
		{
			return ObscuredVector3.FNIPJFGEFFD(value);
		}
		ObscuredVector3 obscuredVector = ObscuredVector3.FNIPJFGEFFD(JKPOJMOFFMF.FLKFPOGOJCH(LGNIFJCEECH, PDDIANLEPOC));
		ECACAAAECKN[LGNIFJCEECH] = obscuredVector;
		return ObscuredVector3.FNIPJFGEFFD(obscuredVector);
	}

	public static void GGHJLOOHGGO(string LGNIFJCEECH, Vector3 IFKMKLFPKGG)
	{
		if (!ECACAAAECKN.TryGetValue(LGNIFJCEECH, out var value) || !ObscuredVector3.JHLIPNMGNGC(value, IFKMKLFPKGG))
		{
			ECACAAAECKN[LGNIFJCEECH] = ObscuredVector3.FNIPJFGEFFD(IFKMKLFPKGG);
			JKPOJMOFFMF.PCLHLBLCNCP(LGNIFJCEECH, IFKMKLFPKGG);
		}
	}

	public static string CEKCOJEJPAN(string LGNIFJCEECH, string PDDIANLEPOC = "")
	{
		if (AHLLIHBFMEL.TryGetValue(LGNIFJCEECH, out var value))
		{
			return value;
		}
		string text = JKPOJMOFFMF.KKNHDKLDCHI(LGNIFJCEECH, PDDIANLEPOC);
		AHLLIHBFMEL[LGNIFJCEECH] = text;
		return text;
	}

	public static void GKKEPIMNFBB(string LGNIFJCEECH, string EHAPKEKPMOE)
	{
		if (!AHLLIHBFMEL.TryGetValue(LGNIFJCEECH, out var value) || !(value == EHAPKEKPMOE))
		{
			AHLLIHBFMEL[LGNIFJCEECH] = EHAPKEKPMOE;
			JKPOJMOFFMF.DCGOPJDMEEG(LGNIFJCEECH, EHAPKEKPMOE);
		}
	}

	public static string NGGMNKJEKEN(IEnumerable<string> JDKLJHNJNLG)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in JDKLJHNJNLG)
		{
			stringBuilder.Append(item).Append(", ");
		}
		return stringBuilder.ToString();
	}

	public void LOPMIMBIEOG(params object[] JDKLJHNJNLG)
	{
		MOHMCMAMDAL(CILHLJOJKKF.JBAFPDNCFPM, JDKLJHNJNLG);
	}

	public void CLEIHBGGHMD(params object[] JDKLJHNJNLG)
	{
		MOHMCMAMDAL(CILHLJOJKKF.JPNFCFCIJNP, JDKLJHNJNLG);
	}

	public void MOHMCMAMDAL(CILHLJOJKKF CHEKIKNMBNF, params object[] JDKLJHNJNLG)
	{
		if (Debug.isDebugBuild && LMMFHEODOPM.FOIAAEMIIMM(CHEKIKNMBNF) && LMMFHEODOPM.FCFBGBPEPOL)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(CHEKIKNMBNF).Append(":");
			foreach (object value in JDKLJHNJNLG)
			{
				stringBuilder.Append(value).Append(", ");
			}
			Debug.Log(stringBuilder.ToString(), this);
		}
	}

	public static void BIHOCPAKHNF(CILHLJOJKKF CHEKIKNMBNF, params object[] JDKLJHNJNLG)
	{
		if (Debug.isDebugBuild && LMMFHEODOPM.FOIAAEMIIMM(CHEKIKNMBNF) && LMMFHEODOPM.FCFBGBPEPOL)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(CHEKIKNMBNF).Append(":");
			foreach (object value in JDKLJHNJNLG)
			{
				stringBuilder.Append(value).Append(", ");
			}
			Debug.Log(stringBuilder.ToString());
		}
	}

	public void BIHOCPAKHNF(params object[] JDKLJHNJNLG)
	{
		MOHMCMAMDAL(CILHLJOJKKF.CNOMFIALJKC, JDKLJHNJNLG);
	}

	public void BKKHMNCDFLF(params object[] JDKLJHNJNLG)
	{
		MOHMCMAMDAL(CILHLJOJKKF.JGFDILAHNMG, JDKLJHNJNLG);
	}

	public static void LIJNLAAEENC(params object[] JDKLJHNJNLG)
	{
		BIHOCPAKHNF(CILHLJOJKKF.IBKKNAGAAKC, JDKLJHNJNLG);
	}

	public static void BCKENJMGBIJ(params object[] JDKLJHNJNLG)
	{
		BIHOCPAKHNF(CILHLJOJKKF.NMJPIBHOJLM, JDKLJHNJNLG);
	}

	[CompilerGenerated]
	private static bool AMPPEEAEECN(Transform AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.GetComponent<SkinnedMeshRenderer>() != null;
	}

	[CompilerGenerated]
	private static Renderer CNKBGPKKJHH(Transform AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.GetComponent<Renderer>();
	}
}
