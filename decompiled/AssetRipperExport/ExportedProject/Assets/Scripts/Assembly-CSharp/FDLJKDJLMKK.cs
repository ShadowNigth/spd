using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class FDLJKDJLMKK : FOGIOGKLNIP
{
	public enum FJMOHBLNMCE
	{
		HMFFPDOAJND = 0,
		DNAPHKHJGKH = 1,
		IEOFPDMAINK = 2,
		ALKAPMBLGOM = 3,
		JAGKCILIPJP = 4,
		MFCBIONDFAJ = 5
	}

	public bool AEBCFFNADHM;

	private bool HGGOHFCNLJB;

	private bool HDFJJKGDCPK;

	internal bool APHNCCJIKPD = true;

	public int KPEBCILOPFF;

	public float AAFLGILMEKL;

	public float HINBLECFGLP = 30f;

	public float DGIJIBDEAAP;

	public float NKANJNBHHPA = 30f;

	public float EKJHJPABMBB = 70f;

	public float JFIGFPGBIKP;

	public float MKALEMDJDIJ = 0.7f;

	public float KHPGHHBJGFH = 1f;

	public float BPHFFEJMNDE = 5f;

	public float HDBDPPIHDBI = 7f;

	public float GAIOPCMJAAG = 0.2f;

	public float BDENDOMDMLF = 1f;

	public float JEOHBGJLIDH = 0.7f;

	public float DMHDBMLFEFG = 1f;

	public float FAOBHMEHKIJ;

	public const float OADKKKGMKCB = 0.15f;

	private float EDCBEJOOPHP;

	internal float FCJKMAEOFJD = float.MinValue;

	private const float CPFJBOMGNBF = 3f;

	private const float IJDNFLAKFON = 5f;

	public GameObject HDNIFFMMIEK;

	public ParticleSystem EKMBKLKFMFK;

	public Renderer EMIEPBFBJBB;

	public Renderer FFFIGADBDGD;

	public Animation EEMEJPLAPHG;

	public Transform AHFIIBLKEDH;

	public Transform HDLMCABHEIC;

	public Transform BGJOMCIIFAK;

	public Transform NMJOJEDEJBO;

	public AnimationEvents NGAFJKJCJNB;

	public Dictionary<string, GameObject> FINLHOBJNIJ = new Dictionary<string, GameObject>();

	public Dictionary<string, GameObject> FGGHEHODNLA = new Dictionary<string, GameObject>();

	public ParticleSystem IBHKEHPIOLB;

	public ParticleSystem MOKICNDDNBF;

	public Animation JDFOMNBKFHM;

	public Transform HHDMNFKCEML;

	internal Transform HDIMJIENKHH;

	public BEJHFGDPDLI JDFKPOMKMNJ = new BEJHFGDPDLI();

	private Vector3 HDKGHJNGBJG;

	public Vector3 NLFDDJAPCED;

	private Vector3 OMMPMKLENHG;

	public Vector3 DLIEJHBPKEJ;

	public Vector3 NCNAKNJIPCP;

	public Vector3 KMPCNPNIMFF;

	private Vector3[] IKHNNOLFBMP = new Vector3[8]
	{
		Vector3.left * 3f,
		Vector3.left * 8f,
		Vector3.up * 3f,
		Vector3.up * 8f,
		Vector3.right * 3f,
		Vector3.right * 8f,
		Vector3.down * 3f,
		Vector3.down * 8f
	};

	public Matrix4x4 ENBFKDLPLED;

	private static Material MOLIPJMBNFB;

	private static Material FKBACDAJJCF;

	private static Material LJHAAOJAIGJ;

	private static Material IAMFEPHIEAD;

	public SSAOEffect HANKMNMDLJJ;

	public ContrastEnhance BNAJCBLBADI;

	public TiltShift BIGHBGFEKDA;

	public ScreenSpaceMotionBlur JBKEJALNEPA;

	public BloomAndFlares ALPMOODPECH;

	public ScreenBrightness MHBJNLEHIFC;

	public DepthOfFieldDeprecated PMLFBKOCLCB;

	public Camera CICDHCEOLLE;

	public Camera KCMICODJAOD;

	public GUILayer EKEBFAPDBHJ;

	public FDGPLHOFOEN HIGGLBKGOFJ;

	public KKJBDENNKGF FHBCKOLJBCH;

	internal KKJBDENNKGF AFPAFBBOLLK;

	internal Renderer[] ENHDLEEOICI = new Renderer[0];

	public float MMNACGPLKEF = 1f;

	internal bool NCCBEFIEDEH;

	internal float BBMGNILMBKO;

	internal float FKBCKBMJOKH;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> ACJNADIPOMC;

	public bool AIBOANMOJJD
	{
		get
		{
			return HIGGLBKGOFJ != null && ObscuredBool.FNIPJFGEFFD(HIGGLBKGOFJ.JEPMMPCNEHO.EMIEPBFBJBB) && (!APHNCCJIKPD || NJEPMOIDJKH.KAMAMHFJDGG);
		}
	}

	public KKJBDENNKGF NJEPMOIDJKH
	{
		get
		{
			return AFPAFBBOLLK;
		}
		set
		{
			if (AFPAFBBOLLK != null)
			{
				AFPAFBBOLLK.IIPDOGECCPA = ObscuredBool.FNIPJFGEFFD(false);
			}
			HDFJJKGDCPK = true;
			AFPAFBBOLLK = value;
			AFPAFBBOLLK.IIPDOGECCPA = ObscuredBool.FNIPJFGEFFD(true);
			if (AFPAFBBOLLK != null)
			{
				base.KHGAOLHJCMO = AFPAFBBOLLK.KHGAOLHJCMO;
			}
			NCNAKNJIPCP = Vector3.zero;
		}
	}

	public override void Awake()
	{
		CICDHCEOLLE = GetComponent<Camera>();
		DepthOfFieldDeprecated pMLFBKOCLCB = PMLFBKOCLCB;
		bool flag = false;
		HANKMNMDLJJ.enabled = flag;
		flag = flag;
		BNAJCBLBADI.enabled = flag;
		flag = flag;
		JBKEJALNEPA.enabled = flag;
		flag = flag;
		BIGHBGFEKDA.enabled = flag;
		flag = flag;
		ALPMOODPECH.enabled = flag;
		pMLFBKOCLCB.enabled = flag;
		FOGIOGKLNIP.NGFDFPGNDCJ = this;
		float[] array = new float[32];
		if (FOGIOGKLNIP.DGMBIMMABNO)
		{
			array[LayerMask.NameToLayer("Effect")] = 30f;
		}
		GetComponentInChildren<Camera>().layerCullDistances = array;
		KPEBCILOPFF = CICDHCEOLLE.cullingMask;
		CICDHCEOLLE.useOcclusionCulling = FOGIOGKLNIP.DGMBIMMABNO;
		EKJHJPABMBB = CICDHCEOLLE.fieldOfView;
		KCMICODJAOD.fieldOfView = EKJHJPABMBB / Mathf.Atan(815.48f / (2f * EKJHJPABMBB));
		GENGIPHHADE(FOGIOGKLNIP.LPLJMLGKCLK.EMAKHKAILGI);
		ENBFKDLPLED = Camera.main.projectionMatrix;
		LJHAAOJAIGJ = GDFOFBBCBPC(new Color(0f, 0f, 0f, 1f));
		if (!FOGIOGKLNIP.LPLJMLGKCLK.FJPCBLEEIOH)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.CGOCPOIKOCB();
		}
		base.Awake();
	}

	public void Start()
	{
		HDNIFFMMIEK = GameObject.Find("dcam");
	}

	public void Update()
	{
		HIGGLBKGOFJ = NJEPMOIDJKH as FDGPLHOFOEN;
		if (FHBCKOLJBCH != NJEPMOIDJKH)
		{
			if (NJEPMOIDJKH is MBFCGOPGCLP)
			{
				APHNCCJIKPD = true;
			}
			FDGPLHOFOEN fDGPLHOFOEN = NJEPMOIDJKH as FDGPLHOFOEN;
			if (fDGPLHOFOEN != null && NJEPMOIDJKH != FOGIOGKLNIP.NMGDHKIKCED)
			{
				IMCKIAHNAKK(fDGPLHOFOEN.JEPMMPCNEHO);
			}
		}
		FHBCKOLJBCH = NJEPMOIDJKH;
		if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IHCFILFBIJF) && FOGIOGKLNIP.GMPBCIEDMCD != null && JDFKPOMKMNJ.NFMIBMIGJMH(1000))
		{
			APHNCCJIKPD = false;
		}
		if ((NJEPMOIDJKH != FOGIOGKLNIP.NMGDHKIKCED || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IHCFILFBIJF) || NJEPMOIDJKH is MBFCGOPGCLP) && ((FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.C) && !FOGIOGKLNIP.PIOANBBCFFP.IGJKLHOGPHL) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.POBECKGDBMO, default(TouchPhase))))
		{
			if (!AEBCFFNADHM && APHNCCJIKPD && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ))
			{
				AEBCFFNADHM = true;
				CLEIHBGGHMD("toopdwon");
			}
			else if (APHNCCJIKPD && AEBCFFNADHM)
			{
				APHNCCJIKPD = (AEBCFFNADHM = false);
				AHFIIBLKEDH.localPosition = Vector3.zero;
			}
			else
			{
				AHFIIBLKEDH.localPosition = Vector3.zero;
				APHNCCJIKPD = !APHNCCJIKPD;
			}
		}
		if (FOGIOGKLNIP.NMGDHKIKCED != null && NJEPMOIDJKH != FOGIOGKLNIP.NMGDHKIKCED && FOGIOGKLNIP.NMGDHKIKCED.enabled && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.NMGDHKIKCED.JEFKKCFOHCE))
		{
			NJEPMOIDJKH = FOGIOGKLNIP.NMGDHKIKCED;
		}
		if (FOGIOGKLNIP.NMGDHKIKCED == null && FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.AnyF((KKJBDENNKGF AEMBPMJMOAB) => !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) || base.JNPCOJFBJGP || FOGIOGKLNIP.OMMLFOEPEEK))
		{
			if (NJEPMOIDJKH == null && Time.time - FAOBHMEHKIJ > 3f)
			{
				APHNCCJIKPD = true;
				NJEPMOIDJKH = FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.FirstOrDefaultF();
			}
			if ((FOGIOGKLNIP.PIOANBBCFFP.CPPEBEEIOEG || Input.GetAxis("Mouse ScrollWheel") != 0f) && Time.time - ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.FAOBHMEHKIJ) > 0.1f)
			{
				bool aPHNCCJIKPD = APHNCCJIKPD;
				if (NJEPMOIDJKH == null)
				{
					NJEPMOIDJKH = FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.FirstOrDefaultF();
				}
				List<KKJBDENNKGF> list = FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.WhereF((KKJBDENNKGF AEMBPMJMOAB) => !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) || base.JNPCOJFBJGP || FOGIOGKLNIP.OMMLFOEPEEK);
				if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.DMAICBDPFKC) && FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ.JGECOECAJLK != GNMHJEPNHDL.Spectators)
				{
					list = list.WhereF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ.JGECOECAJLK);
				}
				NJEPMOIDJKH = ((!(Input.GetAxis("Mouse ScrollWheel") > 0f)) ? list.Next(NJEPMOIDJKH) : list.Prev(NJEPMOIDJKH));
				APHNCCJIKPD = aPHNCCJIKPD;
			}
		}
		if (NJEPMOIDJKH != null)
		{
			AAFLGILMEKL = (NJEPMOIDJKH.MPCGHDNMNKN.ELGIKGAIIOD - HDLMCABHEIC.position).magnitude;
			if (HGGOHFCNLJB != AIBOANMOJJD)
			{
				FOGIOGKLNIP.CIEBMCOJGCC.JKNNIEDOLDD.gameObject.SetActive(AIBOANMOJJD);
				CICDHCEOLLE.cullingMask = ((!AIBOANMOJJD) ? KPEBCILOPFF : (KPEBCILOPFF & -4194305));
			}
			HGGOHFCNLJB = AIBOANMOJJD;
			if (Time.time - ObscuredFloat.FNIPJFGEFFD(NJEPMOIDJKH.BOCKAJGNBOE) > 1f && !AIBOANMOJJD && CICDHCEOLLE.fieldOfView != EKJHJPABMBB)
			{
				CICDHCEOLLE.fieldOfView = EKJHJPABMBB;
			}
			NCCBEFIEDEH = !APHNCCJIKPD && !AEBCFFNADHM;
			if (NCCBEFIEDEH)
			{
				Vector3 vector = NJEPMOIDJKH.MPCGHDNMNKN.KHGAOLHJCMO * Vector3.forward;
				base.ELGIKGAIIOD = NJEPMOIDJKH.LGIJCFNJGDA - vector * DGIJIBDEAAP - vector * EDCBEJOOPHP;
				RaycastHit hitInfo;
				if (Physics.Raycast(NJEPMOIDJKH.ELGIKGAIIOD, Vector3.up, out hitInfo, (NJEPMOIDJKH.ELGIKGAIIOD - NJEPMOIDJKH.LGIJCFNJGDA).magnitude, 1024))
				{
					base.ELGIKGAIIOD = NJEPMOIDJKH.PONALLDHFGB;
				}
				float num = 0.1f;
				bool flag = Physics.Raycast(NJEPMOIDJKH.MPCGHDNMNKN.ELGIKGAIIOD, vector * num, out hitInfo, num, 1024);
				EDCBEJOOPHP = Mathf.Lerp(EDCBEJOOPHP, (!flag) ? 0f : (num - hitInfo.distance), Time.deltaTime * 10f);
				base.KHGAOLHJCMO = NJEPMOIDJKH.GGBCAOAGPPM.rotation;
				DLIEJHBPKEJ = base.KHGAOLHJCMO.eulerAngles;
				if (BGJOMCIIFAK != null)
				{
					if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.MGJPMGGABLN) && Time.time - ObscuredFloat.FNIPJFGEFFD(NJEPMOIDJKH.BOCKAJGNBOE) < 1f)
					{
						BGJOMCIIFAK.transform.localPosition = Vector3.Lerp(BGJOMCIIFAK.transform.localPosition, OMMPMKLENHG, Time.deltaTime * 10f);
						CICDHCEOLLE.fieldOfView = Mathf.Lerp(CICDHCEOLLE.fieldOfView, EKJHJPABMBB, Time.deltaTime * 10f);
					}
					if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.MGJPMGGABLN) && HDIMJIENKHH != null)
					{
						BGJOMCIIFAK.transform.localPosition += (HDIMJIENKHH.InverseTransformPoint(EHOEFMPLIFB.position) + NLFDDJAPCED) * Time.deltaTime * 10f;
						CICDHCEOLLE.fieldOfView = Mathf.Lerp(CICDHCEOLLE.fieldOfView, NKANJNBHHPA, Time.deltaTime * 10f);
					}
				}
			}
			else if (AEBCFFNADHM)
			{
				CICDHCEOLLE.fieldOfView = 30f;
				Vector3 eHAPKEKPMOE = Vector3.Lerp(NJEPMOIDJKH.ELGIKGAIIOD, HDLMCABHEIC.position, MKALEMDJDIJ);
				eHAPKEKPMOE.y = NJEPMOIDJKH.ELGIKGAIIOD.y + BPHFFEJMNDE;
				base.ELGIKGAIIOD = eHAPKEKPMOE;
				EHOEFMPLIFB.forward = Vector3.down;
				NCNAKNJIPCP += new Vector3(FOGIOGKLNIP.DDGKNLHJEFD.y, 0f, 0f - FOGIOGKLNIP.DDGKNLHJEFD.x) * GAIOPCMJAAG;
				float num2 = (float)Screen.width / (float)Screen.height;
				AHFIIBLKEDH.position = NJEPMOIDJKH.LGIJCFNJGDA;
				NCNAKNJIPCP.x /= num2;
				NCNAKNJIPCP = Vector3.ClampMagnitude(NCNAKNJIPCP, HDBDPPIHDBI);
				NCNAKNJIPCP.x *= num2;
				HDLMCABHEIC.position = new Vector3(NJEPMOIDJKH.ELGIKGAIIOD.x + NCNAKNJIPCP.x, NJEPMOIDJKH.ELGIKGAIIOD.y, NJEPMOIDJKH.ELGIKGAIIOD.z + NCNAKNJIPCP.z);
				RaycastHit raycastHit = new RaycastHit
				{
					point = FOGIOGKLNIP.NGFDFPGNDCJ.HDLMCABHEIC.position
				};
			}
			else if (APHNCCJIKPD)
			{
				DLIEJHBPKEJ += FOGIOGKLNIP.DDGKNLHJEFD;
				DLIEJHBPKEJ.x = Mathf.Clamp(CCKPOMBKIBB(DLIEJHBPKEJ.x), -85f, 85f);
				base.PJKFFDKJIHO = DLIEJHBPKEJ;
				Vector3 vector2 = NJEPMOIDJKH.ELGIKGAIIOD + Vector3.up * 2f + base.KHGAOLHJCMO * Vector3.back * 3f;
				RaycastHit hitInfo2;
				if (!HDFJJKGDCPK && Physics.Raycast(NJEPMOIDJKH.LGIJCFNJGDA, (vector2 - NJEPMOIDJKH.LGIJCFNJGDA).normalized, out hitInfo2, (NJEPMOIDJKH.LGIJCFNJGDA - vector2).magnitude, 1024))
				{
					base.ELGIKGAIIOD = Vector3.Lerp(base.ELGIKGAIIOD, hitInfo2.point - (vector2 - NJEPMOIDJKH.LGIJCFNJGDA).normalized * 0.1f, Time.deltaTime * 20f);
				}
				else if (Vector3.Distance(base.ELGIKGAIIOD, vector2) > 0.5f && HDFJJKGDCPK)
				{
					base.ELGIKGAIIOD = Vector3.MoveTowards(base.ELGIKGAIIOD, vector2, Time.deltaTime * (20f + 2f * Vector3.Distance(base.ELGIKGAIIOD, vector2)));
				}
				else
				{
					HDFJJKGDCPK = false;
					base.ELGIKGAIIOD = vector2;
				}
			}
			if (!AEBCFFNADHM)
			{
				Ray ray = Camera.main.ViewportPointToRay(Vector3.one / 2f);
				if (APHNCCJIKPD)
				{
					ray.origin += ray.direction.normalized * 5f;
				}
				if (NJEPMOIDJKH != null)
				{
					RaycastHit hitInfo3;
					if (Physics.Raycast(ray, out hitInfo3, 1000f, 1024))
					{
						HDLMCABHEIC.position = hitInfo3.point;
					}
					else
					{
						HDLMCABHEIC.position = NJEPMOIDJKH.MPCGHDNMNKN.ELGIKGAIIOD + base.NOEOLIEMCPM.forward * 1000f;
					}
				}
			}
		}
		CICDHCEOLLE.nearClipPlane = (AEBCFFNADHM ? JFIGFPGBIKP : ((!FOGIOGKLNIP.DGMBIMMABNO && !FOGIOGKLNIP.OMMLFOEPEEK) ? 0.01f : 0.01f));
		if (BIGHBGFEKDA.enabled)
		{
			BIGHBGFEKDA.blurArea = Vector3.Distance(EHOEFMPLIFB.position, HDLMCABHEIC.position);
		}
		if (!FOGIOGKLNIP.DGMBIMMABNO || JDFKPOMKMNJ.ELKBOHAOPDL(10))
		{
			foreach (MeshRenderer item in FOGIOGKLNIP.PIOANBBCFFP.NNNDNKCHANB)
			{
				item.transform.LookAt(EHOEFMPLIFB);
			}
		}
		if (!FOGIOGKLNIP.DGMBIMMABNO || JDFKPOMKMNJ.ELKBOHAOPDL(50))
		{
			foreach (MeshRenderer item2 in FOGIOGKLNIP.PIOANBBCFFP.NNNDNKCHANB)
			{
				item2.enabled = !CNLHEJPILGH(item2.transform.position);
			}
		}
		bool flag2 = NJEPMOIDJKH != null && !APHNCCJIKPD && !AIBOANMOJJD && NJEPMOIDJKH is FDGPLHOFOEN;
		Renderer[] eNHDLEEOICI = ENHDLEEOICI;
		foreach (Renderer renderer in eNHDLEEOICI)
		{
			if (renderer != null)
			{
				renderer.enabled = flag2;
			}
		}
		EKMBKLKFMFK.enableEmission = flag2 && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.EFCLACBNGCL);
		if (!FOGIOGKLNIP.DGMBIMMABNO && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.EMEKGPGIPOI))
		{
			HANKMNMDLJJ.enabled = false;
		}
		if (HDNIFFMMIEK != null && FOGIOGKLNIP.PIOANBBCFFP.LDAKBEMPLEB.Count == 1 && FOGIOGKLNIP.NMGDHKIKCED == null)
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.ELGIKGAIIOD = HDNIFFMMIEK.transform.position;
			FOGIOGKLNIP.NGFDFPGNDCJ.KHGAOLHJCMO = HDNIFFMMIEK.transform.rotation;
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
	}

	public void GENGIPHHADE(int JFLFLCDEEEI)
	{
		FOGIOGKLNIP.NGFDFPGNDCJ.CICDHCEOLLE.renderingPath = (RenderingPath)JFLFLCDEEEI;
		FOGIOGKLNIP.NGFDFPGNDCJ.KCMICODJAOD.renderingPath = (RenderingPath)JFLFLCDEEEI;
	}

	public void NPHMFNGCHMF()
	{
		CLEIHBGGHMD("Sethq");
		if (!FOGIOGKLNIP.DGMBIMMABNO)
		{
			BNAJCBLBADI.enabled = FOGIOGKLNIP.LPLJMLGKCLK.JPIAKBLNOKB;
			HANKMNMDLJJ.enabled = FOGIOGKLNIP.LPLJMLGKCLK.IOPFGEHPNDP;
			JBKEJALNEPA.enabled = FOGIOGKLNIP.LPLJMLGKCLK.JBKEJALNEPA && JBKEJALNEPA.compositeShader.isSupported;
			ALPMOODPECH.enabled = FOGIOGKLNIP.LPLJMLGKCLK.BIIJNLIBIFJ;
			BIGHBGFEKDA.enabled = FOGIOGKLNIP.LPLJMLGKCLK.BIGHBGFEKDA;
		}
	}

	public void IMCKIAHNAKK(IAPJEBKJEHC JEPMMPCNEHO)
	{
		foreach (Transform item in HHDMNFKCEML)
		{
			item.gameObject.GIBDBKPJOKJ();
		}
		string text = JEPMMPCNEHO.MOLNOFIHKPP;
		BGJOMCIIFAK = JMJLEDGJIJK(text, "Weapons/", true, null, null, Vector3.zero, Quaternion.identity, true).transform;
		BGJOMCIIFAK.parent = HHDMNFKCEML;
		Vector3 localPosition = CFBOHBGDAGD(text, "Weapons/", true).transform.localPosition;
		BGJOMCIIFAK.transform.localPosition = localPosition;
		OMMPMKLENHG = localPosition;
		if (BGJOMCIIFAK.name.Contains("ERROR_MDL"))
		{
			text = BGJOMCIIFAK.name.Replace("(Clone)", string.Empty);
		}
		BGJOMCIIFAK.transform.localRotation = Quaternion.identity;
		NMJOJEDEJBO = BGJOMCIIFAK.Find(text);
		NGAFJKJCJNB = NMJOJEDEJBO.GetComponent<AnimationEvents>();
		JDFOMNBKFHM = NMJOJEDEJBO.GetComponent<Animation>();
		if (NMJOJEDEJBO == null)
		{
			MonoBehaviour.print(text);
			foreach (Transform item2 in BGJOMCIIFAK)
			{
				MonoBehaviour.print(item2.name);
			}
		}
		HDIMJIENKHH = BGJOMCIIFAK.Find("pivot");
		try
		{
			bool active = NJEPMOIDJKH.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
			bool active2 = NJEPMOIDJKH.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists;
			if (NGAFJKJCJNB.CTHandsCache == null && NGAFJKJCJNB.THandsCache == null)
			{
				NGAFJKJCJNB.CreateHands();
			}
			if (NGAFJKJCJNB.CTHandsCache != null && NGAFJKJCJNB.THandsCache != null)
			{
				NGAFJKJCJNB.CTHandsCache.SetActive(active);
				NGAFJKJCJNB.THandsCache.SetActive(active2);
			}
			GameObject cTWeaponModel = NGAFJKJCJNB.CTWeaponModel;
			GameObject tWeaponModel = NGAFJKJCJNB.TWeaponModel;
			if (cTWeaponModel != null && tWeaponModel != null)
			{
				NGAFJKJCJNB.CTWeaponModel.SetActive(active);
				NGAFJKJCJNB.TWeaponModel.SetActive(active2);
			}
		}
		catch (Exception)
		{
		}
		JDFOMNBKFHM.Rewind();
		if (NMJOJEDEJBO == null)
		{
			CLEIHBGGHMD(text);
		}
		ENHDLEEOICI = NMJOJEDEJBO.GetComponentsInChildren<Renderer>();
		JDFOMNBKFHM.cullingType = AnimationCullingType.AlwaysAnimate;
		FFGDOHNIMON fFGDOHNIMON = JEPMMPCNEHO as FFGDOHNIMON;
		JOCAFHIONFA jOCAFHIONFA = JEPMMPCNEHO as JOCAFHIONFA;
		OLILBNAJMLF oLILBNAJMLF = JEPMMPCNEHO as OLILBNAJMLF;
		if (!fFGDOHNIMON && !jOCAFHIONFA && !oLILBNAJMLF)
		{
			if (!FINLHOBJNIJ.ContainsKey(NGAFJKJCJNB.MuzzleFlashEffect))
			{
				FINLHOBJNIJ.Add(NGAFJKJCJNB.MuzzleFlashEffect, JMJLEDGJIJK(NGAFJKJCJNB.MuzzleFlashEffect, "Particles/", true, null, null, Vector3.zero, Quaternion.identity));
			}
			if (!FGGHEHODNLA.ContainsKey(NGAFJKJCJNB.ShellEjectEffect))
			{
				FGGHEHODNLA.Add(NGAFJKJCJNB.ShellEjectEffect, JMJLEDGJIJK(NGAFJKJCJNB.ShellEjectEffect, "Particles/", true, null, null, Vector3.zero, Quaternion.identity));
			}
			IBHKEHPIOLB = FINLHOBJNIJ[NGAFJKJCJNB.MuzzleFlashEffect].GetComponent<ParticleSystem>();
			MOKICNDDNBF = FGGHEHODNLA[NGAFJKJCJNB.ShellEjectEffect].GetComponent<ParticleSystem>();
		}
		if (JDFOMNBKFHM[JEPMMPCNEHO.DFMAGFMJGDH.name] != null && JEPMMPCNEHO is OLILBNAJMLF)
		{
			JDFOMNBKFHM["idle"].wrapMode = WrapMode.Loop;
			JDFOMNBKFHM["idle"].layer = 1;
		}
		if (JDFOMNBKFHM["shoot1"] != null && !JDFOMNBKFHM["shoot1"])
		{
			JDFOMNBKFHM["shoot1"].speed = 0.5f;
		}
		if (JDFOMNBKFHM["shoot_left1"] != null && !JDFOMNBKFHM["shoot_left1"])
		{
			JDFOMNBKFHM["shoot_left1"].speed = 0.5f;
		}
		if (JDFOMNBKFHM["shoot_right1"] != null && !JDFOMNBKFHM["shoot_right1"])
		{
			JDFOMNBKFHM["shoot_right1"].speed = 0.5f;
		}
		if (JDFOMNBKFHM["mid1"] != null)
		{
			JDFOMNBKFHM["mid1"].speed = 1.5f;
			JDFOMNBKFHM["stab1"].speed = 1.2f;
			AnimationState animationState = JDFOMNBKFHM["stab1"];
			int layer = 2;
			JDFOMNBKFHM["mid1"].layer = layer;
			animationState.layer = layer;
		}
		if (JDFOMNBKFHM["start"] != null)
		{
			JDFOMNBKFHM["start"].wrapMode = WrapMode.ClampForever;
		}
		if (JDFOMNBKFHM[JEPMMPCNEHO.DFMAGFMJGDH.name] != null)
		{
			JDFOMNBKFHM[JEPMMPCNEHO.DFMAGFMJGDH.name].layer = 0;
		}
		if (JDFOMNBKFHM["pressbutton"] != null)
		{
			JDFOMNBKFHM["pressbutton"].wrapMode = WrapMode.ClampForever;
			JDFOMNBKFHM["pressbutton"].layer = 1;
		}
	}

	public void OnPostRender()
	{
		if (!(FOGIOGKLNIP.PIOANBBCFFP == null) && (FOGIOGKLNIP.NMGDHKIKCED != null || (!FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD && FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH != null)))
		{
			FDGPLHOFOEN fDGPLHOFOEN = FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH as FDGPLHOFOEN;
			if (fDGPLHOFOEN != null && ObscuredBool.FNIPJFGEFFD(fDGPLHOFOEN.JEPMMPCNEHO.EMIEPBFBJBB))
			{
				FOGIOGKLNIP.CIEBMCOJGCC.LGCEFPBECPF = false;
				LJHAAOJAIGJ.SetPass(0);
				GL.LoadOrtho();
				GL.Begin(1);
				GL.Vertex(new Vector3(0.5f, 0f));
				GL.Vertex(new Vector3(0.5f, 1f));
				GL.Vertex(new Vector3(0f, 0.5f));
				GL.Vertex(new Vector3(1f, 0.5f));
				GL.End();
			}
		}
	}

	public override void LEDCIPHCLEB(AudioClip FPJLDJIGIEK, float HJIINNCJCCD = 1f)
	{
		base.LEDCIPHCLEB(FPJLDJIGIEK, HJIINNCJCCD * 0.5f);
	}

	public override void AILPFINEAEK()
	{
		if (GUILayout.Button("PlayDamage"))
		{
			AIAJBBMCIBK.Play();
		}
		base.AILPFINEAEK();
	}

	private static Material GDFOFBBCBPC(Color FCCPLGMNKOK)
	{
		Shader shader = Shader.Find("Hidden/Internal-Colored");
		Material material = new Material(shader);
		material.SetColor("_Color", FCCPLGMNKOK);
		material.hideFlags = HideFlags.HideAndDontSave;
		material.SetInt("_SrcBlend", 5);
		material.SetInt("_DstBlend", 10);
		material.SetInt("_Cull", 0);
		material.SetInt("_ZWrite", 0);
		return material;
	}

	public void GGOMJFMFLIO()
	{
		string animation = "damage" + UnityEngine.Random.Range(1, 5);
		AIAJBBMCIBK[animation].blendMode = AnimationBlendMode.Additive;
		AIAJBBMCIBK.Play(animation);
	}

	[CompilerGenerated]
	private bool CGOJPCBLPOI(KKJBDENNKGF AEMBPMJMOAB)
	{
		return !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) || base.JNPCOJFBJGP || FOGIOGKLNIP.OMMLFOEPEEK;
	}

	[CompilerGenerated]
	private bool NBECBCLALHF(KKJBDENNKGF AEMBPMJMOAB)
	{
		return !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) || base.JNPCOJFBJGP || FOGIOGKLNIP.OMMLFOEPEEK;
	}

	[CompilerGenerated]
	private static bool JKLLLKFGKJP(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ.JGECOECAJLK;
	}
}
