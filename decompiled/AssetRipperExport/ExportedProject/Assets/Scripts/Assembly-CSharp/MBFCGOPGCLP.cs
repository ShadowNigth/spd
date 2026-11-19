using System;
using System.Linq;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using ProtoBuf;
using UnityEngine;

[ProtoContract]
public class MBFCGOPGCLP : KKJBDENNKGF
{
	public GIKMCNPDMML GIKMCNPDMML;

	private GIKMCNPDMML HEJOJGAHGJP;

	private Vector3 HNECHFHBJEH;

	public bool BBIPJLBDNEC;

	private bool OHFELOOMFPG;

	public float GEMJHMNGMII = 1f;

	public float IGPCEPBEBFL = 1f;

	public float MBDHBPPANLD = 0.1f;

	public float AOFKGLHMPOG = 1f;

	public float AFCANONDMID = 1f;

	public float IDBLCLEIHBM = 1f;

	public float EIFFCOBIAGH;

	public float CKGJADEKNGE = 1.5f;

	public float NACCMKIOGOJ = 0.1f;

	private float MAGDHKEACJB;

	private float LONKMLCCGDE;

	private float MHKCMDKPGEK = -100f;

	private float ABJENGDOFJL;

	private float GCFHBEKBGMB;

	public float DJHMCCJJCPD;

	private float JPEIKGBJBPG = 20f;

	public string EEFMBJEFONJ;

	public string HJOMJDIFMPD;

	public string AFONBGOHNJB;

	public string OMHLIBEAOID;

	public string NHEAJPDEPLJ;

	public string[] NGPBIJLDMKO = new string[1] { "chars/fatty_New" };

	private const string DPFPDBOOGHP = "idle";

	private const string NDGJKBCPANC = "run";

	private const string BJPPBDNAPLN = "walk";

	private int GMNKDMGBLKL = 1000;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> ACJNADIPOMC;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> HJJBAKLDAEB;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> MPCENNEMFPB;

	public override void Awake()
	{
		base.Awake();
		MAGDHKEACJB = OFKMCBJGALN.center.y;
		LONKMLCCGDE = OFKMCBJGALN.height;
		MEDGPMAAALA();
	}

	public override void Start()
	{
		KKNBDBLKNAN();
		base.Start();
		HDOGJKGOEIG(MMFMIIEFEEG, 0.02f);
		BGJOMCIIFAK.ICIEDCMDJFO.layer = 8;
		base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD((int)((float)((BJDCCKHBENA.GHKPKNMDMLH != IBOGNCENEHO.Fatty) ? 150 : 220) * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.JDFKPCHDKIJ)) * ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI)) ? 1 : 5));
		DJHMCCJJCPD = ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA);
	}

	public override void Update()
	{
		base.Update();
		if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.HHDMNFKCEML.localRotation = Quaternion.Slerp(FOGIOGKLNIP.NGFDFPGNDCJ.HHDMNFKCEML.localRotation, Quaternion.identity, Time.deltaTime * 5f / 4f);
		}
		if (KAMAMHFJDGG)
		{
			if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
			{
				if (!FOGIOGKLNIP.PIOANBBCFFP.DALNPKPJAJF || !FOGIOGKLNIP.LPLJMLGKCLK.JNPCOJFBJGP)
				{
					CMGGAOANIIP();
				}
			}
			else
			{
				MFPLNEMIFMJ();
			}
		}
		if (base.IAALHLCLAOD)
		{
			NHOGOKJGLJD();
			PPBLJMDIFKB();
		}
		if (KAMAMHFJDGG || ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK))
		{
			DJJMBCGHPCP();
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI) && JDFKPOMKMNJ.NFMIBMIGJMH(200))
		{
			if ((float)ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA) < DJHMCCJJCPD && !ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
			{
				base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA) + 10);
			}
			if (Time.time - ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) > 5f)
			{
				base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD((int)Mathf.Min(DJHMCCJJCPD * ((float)FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB is FDGPLHOFOEN) / (float)FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count), ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA)));
			}
			else
			{
				base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD(2000);
			}
			AFCANONDMID = Mathf.Max(1f, (float)FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB is FDGPLHOFOEN) / (float)FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count * 2f);
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
	}

	public void MMFMIIEFEEG()
	{
		if (KPKNIABCJOC.magnitude < 0.7f && Time.time - ObscuredFloat.FNIPJFGEFFD(BHHEOGIMOLJ) > 0.2f)
		{
			KPKNIABCJOC = Vector3.zero;
		}
		Vector3 vector = CBOOLAKHHHG;
		if (GIKMCNPDMML == GIKMCNPDMML.CGKLJIOMDDG)
		{
			vector *= 0.7f;
		}
		if (Time.time - EIFFCOBIAGH < 0.4f)
		{
			vector *= 0.5f;
		}
		if (Time.time - ABJENGDOFJL < IDBLCLEIHBM)
		{
			vector = Vector3.zero;
		}
		KPKNIABCJOC += vector * CKGJADEKNGE * AFCANONDMID * AOFKGLHMPOG * ((BJDCCKHBENA.GHKPKNMDMLH != IBOGNCENEHO.Monster || !(Time.time - ObscuredFloat.FNIPJFGEFFD(BHHEOGIMOLJ) < 0.2f)) ? 1f : 0.5f);
		KPKNIABCJOC *= 0.65f;
		CBOOLAKHHHG *= 0.78f;
	}

	private void NHOGOKJGLJD()
	{
		if (ObscuredBool.FNIPJFGEFFD(PMKOJMNEFOF))
		{
			CBOOLAKHHHG = HMADAKBKEPJ;
		}
		if (FOGIOGKLNIP.KDCGBDNNCHM(CBOOLAKHHHG).magnitude > 0.1f)
		{
			bool flag = this == FOGIOGKLNIP.NMGDHKIKCED || !FOGIOGKLNIP.DGMBIMMABNO;
			Vector3 vector = FOGIOGKLNIP.BMLFFBGLAFI(CBOOLAKHHHG);
			if ((HNECHFHBJEH - vector).magnitude > 0.2f || flag)
			{
				HNECHFHBJEH = vector;
				Quaternion quaternion = Quaternion.LookRotation(vector);
				Quaternion eHAPKEKPMOE = MPCGHDNMNKN.KHGAOLHJCMO;
				base.KHGAOLHJCMO = ((!flag) ? quaternion : Quaternion.Lerp(base.KHGAOLHJCMO, quaternion, Time.deltaTime * 10f));
				MPCGHDNMNKN.KHGAOLHJCMO = eHAPKEKPMOE;
			}
		}
		Vector3 vector2 = Vector3.zero;
		if (ObscuredBool.FNIPJFGEFFD(PFIFFLMAPOO))
		{
			vector2 = LCBBMGAPMFL(vector2);
		}
		if (!ObscuredBool.FNIPJFGEFFD(LKGMKGCNHMA))
		{
			PGAEOIANOAP += Physics.gravity * base.EPOKGKJCOAF;
		}
		else if (Time.time - ObscuredFloat.FNIPJFGEFFD(JOGBGBDCOEB) > 1f)
		{
			PGAEOIANOAP = Vector3.zero;
		}
		vector2 += (KPKNIABCJOC + PGAEOIANOAP) * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.EBJHGFLAOAL) * base.EPOKGKJCOAF + new Vector3(0f, yvel * 1.5f, 0f) * base.EPOKGKJCOAF / 0.02f;
		LCFNDAMNKGM(vector2);
		PMKOJMNEFOF = ObscuredBool.FNIPJFGEFFD(false);
	}

	private void MFPLNEMIFMJ()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		CBOOLAKHHHG = Vector3.Lerp(CBOOLAKHHHG, FOGIOGKLNIP.FAFGMDJIOGN, 0.9f);
		if (CBOOLAKHHHG != Vector3.zero)
		{
			if (FOGIOGKLNIP.EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.LeftShift))
			{
				GIKMCNPDMML = GIKMCNPDMML.CGKLJIOMDDG;
			}
			else
			{
				GIKMCNPDMML = GIKMCNPDMML.DFIGPIIOAEH;
			}
		}
		else
		{
			GIKMCNPDMML = GIKMCNPDMML.INBCLMHIHFL;
			CBOOLAKHHHG = Vector3.zero;
		}
		if (FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD)
		{
			CBOOLAKHHHG = ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IDHNLOELEDI) || ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK)) ? FOGIOGKLNIP.KDCGBDNNCHM(FOGIOGKLNIP.NGFDFPGNDCJ.KHGAOLHJCMO * CBOOLAKHHHG) : (FOGIOGKLNIP.NGFDFPGNDCJ.KHGAOLHJCMO * CBOOLAKHHHG));
		}
		else
		{
			CBOOLAKHHHG = ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IDHNLOELEDI) || ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK)) ? FOGIOGKLNIP.KDCGBDNNCHM(MPCGHDNMNKN.KHGAOLHJCMO * CBOOLAKHHHG) : (MPCGHDNMNKN.KHGAOLHJCMO * CBOOLAKHHHG));
			MPCGHDNMNKN.GMLOJKFBLBN += FOGIOGKLNIP.DDGKNLHJEFD.y;
		}
		if (((Input.GetMouseButton(1) && !FOGIOGKLNIP.DGMBIMMABNO) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.FPNFOCPNIJH, default(TouchPhase))) && Time.time - MHKCMDKPGEK > (float)ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.FNLJEMBMLHN))
		{
			MHKCMDKPGEK = Time.time;
			NCHOPAEKPBK(AIBJEPEJLOK, MPCGHDNMNKN.ELGIKGAIIOD, Quaternion.LookRotation(FOGIOGKLNIP.NGFDFPGNDCJ.HDLMCABHEIC.position + Vector3.up - MPCGHDNMNKN.ELGIKGAIIOD));
		}
		if (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.LeftControl))
		{
			NCHOPAEKPBK(AEKHKKFJCGH);
		}
		if (FOGIOGKLNIP.CNIAIOJACDA && Time.time - EIFFCOBIAGH > 1f)
		{
			HPBIKGLFOLD();
		}
		if ((FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.Space) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.HHLEMDPBFME, default(TouchPhase))) && ObscuredBool.FNIPJFGEFFD(base.BJJCGMPNGDL))
		{
			NCHOPAEKPBK(LFOBPCEANDN);
		}
		base.PGPEDGPEJHH = ObscuredFloat.FNIPJFGEFFD(Mathf.Clamp(CCKPOMBKIBB(ObscuredFloat.FNIPJFGEFFD(base.PGPEDGPEJHH)) + FOGIOGKLNIP.DDGKNLHJEFD.x, -85f, 85f));
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	protected void CMGGAOANIIP()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		CBOOLAKHHHG = Vector3.zero;
		if (ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) - Time.time > 4.2f)
		{
			return;
		}
		OHJJOGICBJE();
		if (!BLNPMMNGCAG)
		{
			if (Time.time > GCFHBEKBGMB)
			{
				GCFHBEKBGMB = Time.time + UnityEngine.Random.Range(0f, 10f);
				OHFELOOMFPG = !OHFELOOMFPG;
			}
			GIKMCNPDMML = (FOGIOGKLNIP.LMMFHEODOPM.AJJPBLBJNFB ? GIKMCNPDMML.DFIGPIIOAEH : ((!OHFELOOMFPG) ? GIKMCNPDMML.DFIGPIIOAEH : GIKMCNPDMML.CGKLJIOMDDG));
			if ((ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM) && Time.time - ABJENGDOFJL < base.GCNMEJLGIOE["sight"].length) || (Time.time - EIFFCOBIAGH < 1f && FOGIOGKLNIP.LMMFHEODOPM.AJJPBLBJNFB))
			{
				CBOOLAKHHHG = Vector3.zero;
			}
			LAGKPBMDGEH();
			if (CBOOLAKHHHG == Vector3.zero)
			{
				GIKMCNPDMML = GIKMCNPDMML.INBCLMHIHFL;
			}
			HHNAKLKEFIP();
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.KJHFLGPLMFF) && BJDCCKHBENA.GHKPKNMDMLH == IBOGNCENEHO.Monster && JDFKPOMKMNJ.NFMIBMIGJMH(GMNKDMGBLKL) && CKBFMCAMMBD != null && !IIGANLCMBGC(CKBFMCAMMBD.LGIJCFNJGDA, LGIJCFNJGDA) && (CKBFMCAMMBD.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude > 3f && (CKBFMCAMMBD.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 10f)
			{
				GMNKDMGBLKL = UnityEngine.Random.Range(1000 * ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.FNLJEMBMLHN), 1000 * ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.FNLJEMBMLHN) + 5000);
				NCHOPAEKPBK(AIBJEPEJLOK, MPCGHDNMNKN.ELGIKGAIIOD, Quaternion.LookRotation(CKBFMCAMMBD.PONALLDHFGB - LGIJCFNJGDA));
			}
			if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
			{
			}
		}
	}

	private void PPBLJMDIFKB()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (KAMAMHFJDGG)
		{
			if (BBIPJLBDNEC && JDFKPOMKMNJ.NFMIBMIGJMH(3000))
			{
				NCHOPAEKPBK(ENDKPDAEDPD, Mathf.Lerp(1f, AOFKGLHMPOG + UnityEngine.Random.value, 0.4f));
			}
			if (GIKMCNPDMML != HEJOJGAHGJP)
			{
				NCHOPAEKPBK(EHGEDOFDCGI, (int)GIKMCNPDMML);
				HEJOJGAHGJP = GIKMCNPDMML;
			}
		}
		if (JPEIKGBJBPG < Time.time && KAMAMHFJDGG)
		{
			JPEIKGBJBPG = Time.time + (float)UnityEngine.Random.Range(10, 20);
			if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
			{
				NCHOPAEKPBK(AEKHKKFJCGH);
			}
			else
			{
				NCHOPAEKPBK(HIBOGCGDLEC);
			}
		}
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			if (base.FDAGHIAOOJF != NHBBNDBBHJH.MDCGNDPBALA)
			{
				base.GCNMEJLGIOE["walk"].speed = Mathf.Max(IGPCEPBEBFL * 0.6f, IGPCEPBEBFL * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.EBJHGFLAOAL) * AOFKGLHMPOG);
				base.GCNMEJLGIOE["run"].speed = Mathf.Max(GEMJHMNGMII * 0.6f, GEMJHMNGMII * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.EBJHGFLAOAL) * AOFKGLHMPOG);
			}
			if (GIKMCNPDMML == GIKMCNPDMML.INBCLMHIHFL)
			{
				CGPKGIPGDLP("idle");
			}
			else if (GIKMCNPDMML == GIKMCNPDMML.DFIGPIIOAEH)
			{
				CGPKGIPGDLP("run");
			}
			else if (GIKMCNPDMML == GIKMCNPDMML.CGKLJIOMDDG)
			{
				CGPKGIPGDLP("walk");
			}
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (CKBFMCAMMBD != null)
		{
			if (FOGIOGKLNIP.NMGDHKIKCED != null && CCDNEAIKNGG(FOGIOGKLNIP.NMGDHKIKCED.ELGIKGAIIOD) && FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ.JGECOECAJLK != BJDCCKHBENA.JGECOECAJLK && Time.time - EIFFCOBIAGH > 1f)
			{
				HPBIKGLFOLD();
			}
			else if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK) && CKBFMCAMMBD.BJDCCKHBENA.JGECOECAJLK != BJDCCKHBENA.JGECOECAJLK && CCDNEAIKNGG(CKBFMCAMMBD.ELGIKGAIIOD) && Time.time - EIFFCOBIAGH > 1f)
			{
				HPBIKGLFOLD();
			}
		}
		if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK) && KAMAMHFJDGG && Time.time - EIFFCOBIAGH > 1f && Time.time - ObscuredFloat.FNIPJFGEFFD(OFCJCMGEGFB) < 1f)
		{
			HPBIKGLFOLD();
		}
	}

	public override void OnPhotonSerializeView(PhotonStream IILDKLHJIDE, PhotonMessageInfo LIEKABKEJOG)
	{
		base.OnPhotonSerializeView(IILDKLHJIDE, LIEKABKEJOG);
	}

	public override void BJGMKFIGEFA()
	{
		HBCEJOJNMNB(DFJGLGGOKKN, ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA));
		HBCEJOJNMNB(EHGEDOFDCGI, (int)GIKMCNPDMML);
	}

	public override void MEDGPMAAALA()
	{
		string text = OMHLIBEAOID.Replace("chars/", string.Empty);
		BGJOMCIIFAK = JMJLEDGJIJK(text, "chars/", false, null, null, Vector3.zero, Quaternion.identity, true, true).GetComponent<FOGIOGKLNIP>();
		if (BGJOMCIIFAK.AIAJBBMCIBK != null)
		{
			BGJOMCIIFAK.AIAJBBMCIBK.enabled = true;
		}
		JOMDDKHMPIB = BGJOMCIIFAK.GetComponent<Collider>();
		Vector3 position = BGJOMCIIFAK.EHOEFMPLIFB.position;
		Quaternion rotation = BGJOMCIIFAK.EHOEFMPLIFB.rotation;
		BGJOMCIIFAK.EHOEFMPLIFB.parent = EHOEFMPLIFB;
		BGJOMCIIFAK.EHOEFMPLIFB.position = base.ELGIKGAIIOD + position;
		BGJOMCIIFAK.EHOEFMPLIFB.rotation = Quaternion.Euler(rotation.eulerAngles + EHOEFMPLIFB.rotation.eulerAngles);
		OKNKADHMJAJ = BGJOMCIIFAK.EHOEFMPLIFB.FindInChild("head", "Head", "Base HumanHead", "Bip01 Head");
		if (!FOGIOGKLNIP.LMMFHEODOPM.AJJPBLBJNFB)
		{
			SphereCollider sphereCollider = OKNKADHMJAJ.GetComponent<Collider>() as SphereCollider;
			sphereCollider.radius = 0.08f / sphereCollider.transform.localScale.x;
		}
		NPDKFEEDEGM(text, "characters/", true, BGJOMCIIFAK.EHOEFMPLIFB);
		base.MEDGPMAAALA();
	}

	private void KKNBDBLKNAN()
	{
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			base.GCNMEJLGIOE["attack2"].layer = 1;
			if (base.GCNMEJLGIOE["sight"] != null)
			{
				base.GCNMEJLGIOE["sight"].layer = ((!FOGIOGKLNIP.LMMFHEODOPM.AJJPBLBJNFB) ? 1 : 0);
			}
			base.GCNMEJLGIOE["run"].speed = GEMJHMNGMII;
			base.GCNMEJLGIOE["walk"].speed = IGPCEPBEBFL;
			AnimationState animationState = base.GCNMEJLGIOE["walk"];
			WrapMode wrapMode = WrapMode.Loop;
			base.GCNMEJLGIOE["run"].wrapMode = wrapMode;
			wrapMode = wrapMode;
			base.GCNMEJLGIOE["idle"].wrapMode = wrapMode;
			animationState.wrapMode = wrapMode;
			if (base.GCNMEJLGIOE[DCCGFOCHEIH] != null)
			{
				base.GCNMEJLGIOE[DCCGFOCHEIH].layer = 5;
				base.GCNMEJLGIOE[DCCGFOCHEIH].wrapMode = WrapMode.ClampForever;
			}
		}
	}

	private bool CCDNEAIKNGG(Vector3 PDJFCIDHIGF, float DFHHDIMKIAN = 1.4f)
	{
		return Vector3.Distance(base.ELGIKGAIIOD, PDJFCIDHIGF) < ObscuredFloat.FNIPJFGEFFD(AAFLGILMEKL) * DFHHDIMKIAN && Vector2.Angle(EHOEFMPLIFB.forward, PDJFCIDHIGF - base.ELGIKGAIIOD) < 180f;
	}

	private void HPBIKGLFOLD()
	{
		KKJBDENNKGF kKJBDENNKGF = base.MMPHADBLLCL.FirstOrDefault((KKJBDENNKGF AEMBPMJMOAB) => CCDNEAIKNGG(AEMBPMJMOAB.ELGIKGAIIOD));
		if (kKJBDENNKGF != null)
		{
			float num = ((FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD != IMCJHBIFEAK.ZombieMode) ? (ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IHCDJPIJMGE) * (float)((!(kKJBDENNKGF is MBFCGOPGCLP)) ? 1 : 2)) : (ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IHCDJPIJMGE) * ((float)FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB is FDGPLHOFOEN) / (float)FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count)));
			kKJBDENNKGF.GGNFHJCPCBK(-(int)num, BJDCCKHBENA);
		}
		PMDPIINLPHK pMDPIINLPHK = FOGIOGKLNIP.PIOANBBCFFP.HEGNCGKJMJF.FirstOrDefault((PMDPIINLPHK AEMBPMJMOAB) => (AEMBPMJMOAB.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 3f);
		if (pMDPIINLPHK != null)
		{
			pMDPIINLPHK.NCHOPAEKPBK(pMDPIINLPHK.PLEKGNIKPEH, pMDPIINLPHK.BHFDJDDGHKA - 10, base.ELGIKGAIIOD);
		}
		NCHOPAEKPBK(GBPOJPDJECH);
	}

	[RPC]
	public override void NLFAGMBGHII(Vector3 JOHJJGPKAON)
	{
		base.NLFAGMBGHII(JOHJJGPKAON);
	}

	[RPC]
	private void AIBJEPEJLOK(Vector3 ANGOHMFNNBN, Quaternion DKHKBNIGGBK)
	{
		if (ObscuredBool.FNIPJFGEFFD(CGCEAEFHDIF) || !FOGIOGKLNIP.DGMBIMMABNO)
		{
			GBPOJPDJECH();
			UnityEngine.Object.Instantiate(Resources.Load("game/fireBall"), ANGOHMFNNBN, DKHKBNIGGBK);
		}
	}

	[RPC]
	private void LFOBPCEANDN()
	{
		AIAJBBMCIBK["jumpCustom"].layer = 2;
		AIAJBBMCIBK.Play("jumpCustom");
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Footsteps);
		KPKNIABCJOC *= 1.2f;
	}

	[RPC]
	private void HIBOGCGDLEC()
	{
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Sigh);
	}

	[RPC]
	private void AEKHKKFJCGH()
	{
		ABJENGDOFJL = Time.time;
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			base.GCNMEJLGIOE.Blend("sight");
		}
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Sigh);
	}

	[RPC]
	public void EHGEDOFDCGI(int MEMMCMIHGKP)
	{
		GIKMCNPDMML = (GIKMCNPDMML)MEMMCMIHGKP;
		if (BJDCCKHBENA.GHKPKNMDMLH == IBOGNCENEHO.Monster)
		{
			if (GIKMCNPDMML == GIKMCNPDMML.CGKLJIOMDDG)
			{
				OFKMCBJGALN.center = Vector3.up * 0.37f;
				OFKMCBJGALN.height = 0.5f;
			}
			else
			{
				OFKMCBJGALN.center = Vector3.up * MAGDHKEACJB;
				OFKMCBJGALN.height = LONKMLCCGDE;
			}
		}
	}

	[RPC]
	private void GBPOJPDJECH()
	{
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Melee);
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			base.GCNMEJLGIOE["attack2"].time = 0f;
			base.GCNMEJLGIOE.Blend("attack2");
		}
		EIFFCOBIAGH = Time.time;
	}

	[RPC]
	public override void KKLDMBHEHCE(bool PDAKFGKELOC)
	{
		base.KKLDMBHEHCE(PDAKFGKELOC);
	}

	[RPC]
	public override void PLEKGNIKPEH(int BHFDJDDGHKA, NetworkViewID JFLBOOBFAEF)
	{
		PLEKGNIKPEH(BHFDJDDGHKA, (object)JFLBOOBFAEF);
	}

	[RPC]
	public override void PLEKGNIKPEH(int BHFDJDDGHKA, PhotonViewID JFLBOOBFAEF)
	{
		PLEKGNIKPEH(BHFDJDDGHKA, (object)JFLBOOBFAEF);
	}

	protected override void PLEKGNIKPEH(int BHFDJDDGHKA, object FIOKJLLBGDI)
	{
		JDILMODHLOJ jDILMODHLOJ = FOGIOGKLNIP.AAPLAPBIFMD<JDILMODHLOJ>(FIOKJLLBGDI);
		if (jDILMODHLOJ != null && jDILMODHLOJ.NJEPMOIDJKH != null)
		{
			LCFNDAMNKGM((base.ELGIKGAIIOD - jDILMODHLOJ.NJEPMOIDJKH.ELGIKGAIIOD).normalized * NACCMKIOGOJ);
		}
		if (KAMAMHFJDGG)
		{
			AOFKGLHMPOG = (AOFKGLHMPOG + 1f) / 2f;
		}
		base.PLEKGNIKPEH(BHFDJDDGHKA, FIOKJLLBGDI);
	}

	[RPC]
	public void ENDKPDAEDPD(float CKGJADEKNGE)
	{
		AOFKGLHMPOG = CKGJADEKNGE;
	}

	[RPC]
	public override void AGKCCJFMFFO(int NDEFDFEDKFL, int MHEOBOMBCFM, int KAPIOMFEAHB)
	{
		base.AGKCCJFMFFO(NDEFDFEDKFL, MHEOBOMBCFM, KAPIOMFEAHB);
	}

	[RPC]
	public override void DFJGLGGOKKN(int BHFDJDDGHKA)
	{
		base.DFJGLGGOKKN(BHFDJDDGHKA);
	}

	[RPC]
	protected override void ABMGCEBCICJ(byte[] JPJGKBJGHOE)
	{
		base.ABMGCEBCICJ(JPJGKBJGHOE);
	}

	[RPC]
	public override void MCHAGMJPOIK(NetworkViewID BJDCCKHBENA)
	{
		base.MCHAGMJPOIK(BJDCCKHBENA);
	}

	[RPC]
	public override void KICNBMAHIEK()
	{
		base.KICNBMAHIEK();
	}

	[RPC]
	public override void MCHAGMJPOIK(PhotonViewID BJDCCKHBENA)
	{
		base.MCHAGMJPOIK(BJDCCKHBENA);
	}

	[RPC]
	public override void CDBPCIPAJHF()
	{
		base.CDBPCIPAJHF();
	}

	[RPC]
	public override void FEJDDCGBLBD(Vector3 ELGIKGAIIOD)
	{
		base.FEJDDCGBLBD(ELGIKGAIIOD);
	}

	[RPC]
	public override void FAEDGHBACGA(Vector3 ELGIKGAIIOD, bool GHPHAJGLGGL)
	{
		base.FAEDGHBACGA(ELGIKGAIIOD, GHPHAJGLGGL);
	}

	[CompilerGenerated]
	private static bool CGOJPCBLPOI(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB is FDGPLHOFOEN;
	}

	[CompilerGenerated]
	private static bool NBECBCLALHF(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB is FDGPLHOFOEN;
	}

	[CompilerGenerated]
	private bool IJLBOAEGPKL(KKJBDENNKGF AEMBPMJMOAB)
	{
		return CCDNEAIKNGG(AEMBPMJMOAB.ELGIKGAIIOD);
	}

	[CompilerGenerated]
	private static bool FCGHOPMANFP(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB is FDGPLHOFOEN;
	}

	[CompilerGenerated]
	private bool EJIGHHCOOEB(PMDPIINLPHK AEMBPMJMOAB)
	{
		return (AEMBPMJMOAB.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 3f;
	}
}
