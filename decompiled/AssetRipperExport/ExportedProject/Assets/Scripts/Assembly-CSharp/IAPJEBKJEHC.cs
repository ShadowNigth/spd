using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class IAPJEBKJEHC : FOGIOGKLNIP
{
	[Serializable]
	public struct AnimClassObj
	{
		public string NameClip;

		public ObscuredFloat Time;
	}

	public string LKECMBJJLPJ;

	public ObscuredBool LHBMNHLCJLA = ObscuredBool.FNIPJFGEFFD(true);

	public ObscuredBool EABMOMPIMOF;

	[Field(name = "Settings Weapon")]
	public WeaponObject FLGDGHPCNDK;

	public EJDKALEIBBG POPPJPKOABC;

	public ObscuredBool JJJGDHGBPHJ;

	public bool OOKLHOCJKAG;

	protected bool FHPNFKMCACF;

	internal bool MPELBBLOCFF;

	internal ObscuredBool EMIEPBFBJBB;

	internal bool BCEBFDPCLIA;

	[Field(name = "Disable Weapon", ignore = new Type[] { typeof(FFGDOHNIMON) })]
	public ObscuredBool HPFPFCNOKAM;

	public ObscuredBool BCCOHOIIGPP;

	public int KOPFHECCACK;

	public FLPGHBAMHAM LONHFLHGMIH;

	public FBKBAJFPLNK KJPPJJDLFJH;

	public int FBGNKPPMENN;

	internal ObscuredInt OHOMLPAIOAH;

	public string JJHIFNAJIBK;

	public int NNBDEKBINFP;

	internal bool ADMHKBHIKLG;

	internal int BEPLCKCIMBE;

	internal bool GMLKEKBDLAJ;

	internal bool OGLMKDFNMKC;

	internal bool OCFONJIEDJO;

	public LMJDOOEODJK LMJDOOEODJK;

	public AnimClassObj PKIACGNBAFC;

	public AnimClassObj OIGICLNICIP;

	public AnimClassObj ILEPKAHGJFG;

	public AnimClassObj DEBAEHIAEGA;

	public AnimClassObj NOPMHLBAJAF;

	public AnimClassObj KBFCIDBJPGE;

	public AnimClassObj MACGCABBLHJ;

	public AnimClassObj GHNMHBBGAOL;

	public AnimClassObj NNGEBJFEGKA;

	public AnimClassObj MBPLCJKIDCA;

	public AnimClassObj IFFHNOJMPMB;

	public AnimClassObj AEMLDOIPGPK;

	public AnimClassObj PNNMFOAPAOC;

	public AnimClassObj ODPDBIENMGH;

	public AnimClassObj GHBFJKNMEPJ;

	public AnimClassObj IJICAEBOFAF;

	public int[] NMEGIDDBNGF = new int[4];

	[Field(name = "Guns Available in shop", min = 1f, max = 20f, ignore = new Type[] { typeof(FFGDOHNIMON) }, dependsOn = new string[] { "enableGunAmout" })]
	public int FPCJLIGOHOH = 10;

	[Field(name = "Ammo in Clips", customOnly = true, ignore = new Type[]
	{
		typeof(OLILBNAJMLF),
		typeof(FFGDOHNIMON)
	})]
	public ObscuredInt ABHFBECBPBA;

	public float HGKIJKINBMK = 1f;

	public float BFJBLHHNGHA = 1f;

	public float KDIEIJEFDCM;

	internal float HCKBKGINDPI;

	public string MOLNOFIHKPP;

	public string MEGEODGDDAH;

	public string PNNOKHOAEJC;

	protected string KPDIHKJBLJO = "reload";

	private string[] PEJDCGNFCDE;

	private string[] GKJMACEHDMI;

	public bool FFHOGJBIPJO;

	internal ObscuredFloat AMNOHEEAFPD;

	internal bool KNAEGLBCLDL;

	internal ObscuredBool DGECFCEDDGB;

	public FDGPLHOFOEN NJEPMOIDJKH;

	[Field(name = "Gun Price", ignore = new Type[]
	{
		typeof(OLILBNAJMLF),
		typeof(FFGDOHNIMON)
	}, max = 90000f, customOnly = true)]
	public ObscuredInt BBCLFKDCOAJ;

	[Field(name = "Kill Award", ignore = new Type[]
	{
		typeof(OLILBNAJMLF),
		typeof(FFGDOHNIMON)
	}, max = 90000f, customOnly = true)]
	public ObscuredInt FGNODBMMDBF;

	public bool CIHFBOLAMCO;

	internal int GNOBBODJHNF = -1;

	internal int EJCOGJOCEFF = -1;

	public ObscuredInt CNMKGNNGPDD
	{
		get
		{
			return OHOMLPAIOAH;
		}
		set
		{
			OHOMLPAIOAH = value;
		}
	}

	public GameObject DECONHBIJAA
	{
		get
		{
			if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && FOGIOGKLNIP.NGFDFPGNDCJ.NGAFJKJCJNB.Silencer != null)
			{
				return FOGIOGKLNIP.NGFDFPGNDCJ.NGAFJKJCJNB.Silencer;
			}
			return null;
		}
	}

	public new Vector3 ELGIKGAIIOD
	{
		get
		{
			return NJEPMOIDJKH.MPCGHDNMNKN.ELGIKGAIIOD;
		}
	}

	public new Transform EHOEFMPLIFB
	{
		get
		{
			return NJEPMOIDJKH.GGBCAOAGPPM;
		}
	}

	public virtual ObscuredBool FEAMJAKLLLO
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD((ObscuredBool.FNIPJFGEFFD(EABMOMPIMOF) && !ObscuredBool.FNIPJFGEFFD(HPFPFCNOKAM)) || (NJEPMOIDJKH.BJDCCKHBENA != null && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK)));
		}
		set
		{
			EABMOMPIMOF = value;
		}
	}

	public ObscuredBool CGGHOLCLFDG
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(CNMKGNNGPDD) + LMJDOOEODJK.FOEACCEIBME(JJHIFNAJIBK) > 0 && !ObscuredBool.FNIPJFGEFFD(HPFPFCNOKAM));
		}
	}

	internal string[] AIOGABFEOJB
	{
		get
		{
			if (PEJDCGNFCDE == null)
			{
				PEJDCGNFCDE = new string[10]
				{
					MEGEODGDDAH + "1",
					MEGEODGDDAH + "1",
					MEGEODGDDAH + "2",
					MEGEODGDDAH + "3",
					MEGEODGDDAH + "4",
					MEGEODGDDAH + "5",
					MEGEODGDDAH + "6",
					MEGEODGDDAH + "7",
					MEGEODGDDAH + "8",
					MEGEODGDDAH + "9"
				};
			}
			return PEJDCGNFCDE;
		}
	}

	internal string[] BFFNBGNAEMI
	{
		get
		{
			if (GKJMACEHDMI == null)
			{
				GKJMACEHDMI = new string[10]
				{
					PNNOKHOAEJC + "1",
					PNNOKHOAEJC + "1",
					PNNOKHOAEJC + "2",
					PNNOKHOAEJC + "3",
					PNNOKHOAEJC + "4",
					PNNOKHOAEJC + "5",
					PNNOKHOAEJC + "6",
					PNNOKHOAEJC + "7",
					PNNOKHOAEJC + "8",
					PNNOKHOAEJC + "9"
				};
			}
			return GKJMACEHDMI;
		}
	}

	public AnimationState EICAHINMHBH
	{
		get
		{
			AnimationState animationState = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["lookat"];
			return (!(animationState == null)) ? animationState : FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["idle"];
		}
	}

	public AnimationState DPFPDBOOGHP
	{
		get
		{
			AnimationState animationState = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["idle"];
			return (!(animationState == null)) ? animationState : FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["idle"];
		}
	}

	public AnimationState DFMAGFMJGDH
	{
		get
		{
			AnimationState animationState = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["draw"];
			return (!(animationState == null)) ? animationState : FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["draw"];
		}
	}

	public bool AHCGBDNLKEO
	{
		get
		{
			return ((bool)FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot_left1"] && (bool)FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot_right1"]) ? true : false;
		}
	}

	public override void Awake()
	{
		base.Awake();
		base.enabled = false;
	}

	public virtual void Start()
	{
		KDIEIJEFDCM = Time.time;
		BCEBFDPCLIA = true;
		EHOEFMPLIFB.localScale = new Vector3(-1f, 1f, 1f);
		NNBDEKBINFP = LMJDOOEODJK.OEPFDDDGLIG(JJHIFNAJIBK);
	}

	public virtual void ELPILFMDIKG()
	{
		OOKLHOCJKAG = false;
		if (FOGIOGKLNIP.CIEBMCOJGCC != null && FOGIOGKLNIP.PIOANBBCFFP != null)
		{
			if (!(this is KCNCDAJBGFM) && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
			{
				FOGIOGKLNIP.CIEBMCOJGCC.LGCEFPBECPF = true;
			}
			if (this is KCNCDAJBGFM && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
			{
				FOGIOGKLNIP.CIEBMCOJGCC.LGCEFPBECPF = false;
				GNOBBODJHNF = -1;
				EJCOGJOCEFF = -1;
				EMIEPBFBJBB = ObscuredBool.FNIPJFGEFFD(false);
				MPELBBLOCFF = false;
			}
			AMNOHEEAFPD = ObscuredFloat.FNIPJFGEFFD(-1f);
			GMLKEKBDLAJ = false;
		}
		KDIEIJEFDCM = Time.time;
	}

	public void OnDisable()
	{
		EMIEPBFBJBB = ObscuredBool.FNIPJFGEFFD(false);
		ADMHKBHIKLG = false;
		GNOBBODJHNF = -1;
		if (!FOGIOGKLNIP.CJOGLBBCDEC && BCEBFDPCLIA)
		{
			StopAllCoroutines();
		}
	}

	public virtual void PIALCLIEKDB()
	{
	}

	public void GLCDJFFPBOA()
	{
	}

	public virtual void Reset()
	{
	}

	public bool NGCHFCOBBNH(KKJBDENNKGF FGLJAKDJFBE)
	{
		if ((FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD != IMCJHBIFEAK.CTF && FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD != IMCJHBIFEAK.TDM && FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD != IMCJHBIFEAK.DeathMatch) || base.JNPCOJFBJGP || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.HBLCBDGCHGH))
		{
			return false;
		}
		if ((Time.time - ObscuredFloat.FNIPJFGEFFD(FGLJAKDJFBE.PPCFJBJDMDC) < 3f || Time.time - ObscuredFloat.FNIPJFGEFFD(NJEPMOIDJKH.PPCFJBJDMDC) < 3f) && FOGIOGKLNIP.NMGDHKIKCED == NJEPMOIDJKH)
		{
			if (Time.time - ObscuredFloat.FNIPJFGEFFD(NJEPMOIDJKH.PPCFJBJDMDC) < 3f)
			{
				FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("you can't kill anybody for 3 seconds when spawned");
			}
			else
			{
				FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("you can't kill just spawned enemy");
			}
			return true;
		}
		return false;
	}

	public virtual void Update()
	{
		if (FOGIOGKLNIP.NMGDHKIKCED == NJEPMOIDJKH)
		{
			if (!base.MDBAFPKAKKK && !FOGIOGKLNIP.DGMBIMMABNO)
			{
				OOKLHOCJKAG = false;
			}
			if (!ObscuredBool.FNIPJFGEFFD(FEAMJAKLLLO))
			{
				NJEPMOIDJKH.LIFLOGLLGIG();
			}
		}
	}

	[RPC]
	public virtual void KPMFMBAMFCF()
	{
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && (FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.IsPlaying(DPFPDBOOGHP.name) || FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.IsPlaying(EICAHINMHBH.name)))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.PlayQueued(EICAHINMHBH.name, QueueMode.PlayNow);
		}
	}

	[RPC]
	public virtual void CHEOEJNGLFP(bool EHAPKEKPMOE)
	{
		FHPNFKMCACF = EHAPKEKPMOE;
	}

	[RPC]
	public virtual void ELNKLGHNLEP(bool JFLFLCDEEEI)
	{
		KNAEGLBCLDL = JFLFLCDEEEI;
		if (FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH != null && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH.IIPDOGECCPA) && KAMAMHFJDGG)
		{
			DECONHBIJAA.GetComponent<Renderer>().enabled = KNAEGLBCLDL;
		}
	}

	[RPC]
	public virtual void EPADPNIJNNJ()
	{
		if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) || ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
		{
			return;
		}
		if (!KNAEGLBCLDL)
		{
			if (!FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD)
			{
				DECONHBIJAA.GetComponent<Renderer>().enabled = true;
			}
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.PlayQueued("attach", QueueMode.PlayNow);
		}
		else
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.PlayQueued("deattach", QueueMode.PlayNow);
		}
		StartCoroutine((NJEPMOIDJKH.JEPMMPCNEHO as NGBCDAIIEFP).NHLJONCKCGE());
	}

	[RPC]
	public virtual void LKDPJIEAPIF(bool JFLFLCDEEEI)
	{
		DGECFCEDDGB = ObscuredBool.FNIPJFGEFFD(JFLFLCDEEEI);
	}

	[RPC]
	public virtual void GOPIBMLFMBC(int EHAPKEKPMOE)
	{
		GNOBBODJHNF = EHAPKEKPMOE;
		NJEPMOIDJKH.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Zoom);
		switch (GNOBBODJHNF)
		{
		case 0:
			EMIEPBFBJBB = ObscuredBool.FNIPJFGEFFD(true);
			break;
		case 1:
			EMIEPBFBJBB = ObscuredBool.FNIPJFGEFFD(true);
			break;
		case 2:
			EMIEPBFBJBB = ObscuredBool.FNIPJFGEFFD(false);
			break;
		}
	}

	public virtual void DONIMNAJJIB()
	{
	}

	public virtual void PCLEFKOPNCJ()
	{
	}

	public virtual void ODMGBBKGLOD()
	{
	}
}
