using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.AI;

public class ENFDKNAODIJ : FOGIOGKLNIP, CJMKGJPLOPM
{
	public Transform EGBJDPHCDPN;

	public KKJBDENNKGF EPCKLAKNAAG;

	private NavMeshAgent MGOEIFJCLAJ;

	private Animation GCNMEJLGIOE;

	public Vector3 NBMHPFIFGJA;

	public Renderer[] PINCOHHLKGB;

	private Animation[] BCONCFOPNHA;

	private BEJHFGDPDLI JDFKPOMKMNJ = new BEJHFGDPDLI();

	public KLFJFGMOPCG AADHMELMIBK;

	public bool JGDLDJLBKEF;

	private bool CGCEAEFHDIF = true;

	public AnimationState OHOMIPCPDNO => GCNMEJLGIOE["run"];

	public AnimationState NIKPGHCOOCG => GCNMEJLGIOE["idle"];

	public override void Awake()
	{
		PINCOHHLKGB = GetComponentsInChildren<Renderer>();
		BCONCFOPNHA = GetComponentsInChildren<Animation>();
		if (!FOGIOGKLNIP.PIOANBBCFFP.NBLJJDANCFG)
		{
			AADHMELMIBK = GetComponent<KLFJFGMOPCG>();
		}
		else
		{
			GetComponent<KLFJFGMOPCG>().enabled = false;
		}
		FOGIOGKLNIP.PIOANBBCFFP.IJMPPAPBMAJ.Add(this);
		FOGIOGKLNIP.PIOANBBCFFP.BKFEGEAEIFB.Add(this);
		base.Awake();
	}

	public void Start()
	{
		NBMHPFIFGJA = base.ELGIKGAIIOD;
		GCNMEJLGIOE = EGBJDPHCDPN.GetComponent<Animation>();
		OHOMIPCPDNO.speed = 0.7f;
		NIKPGHCOOCG.speed = 0.5f;
		ANIKOIHCHLH();
		StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(2f, delegate
		{
			FOGIOGKLNIP.PIOANBBCFFP.HGHGHLHBAMA(ICIEDCMDJFO, "H");
		}));
	}

	public void Reset()
	{
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA))
		{
			OBKMIHILMLH(EHAPKEKPMOE: false);
			Object.DestroyImmediate(MGOEIFJCLAJ);
			EPCKLAKNAAG = null;
			base.ELGIKGAIIOD = NBMHPFIFGJA;
			ANIKOIHCHLH();
		}
	}

	private void ANIKOIHCHLH()
	{
		MGOEIFJCLAJ = ICIEDCMDJFO.AddComponent<NavMeshAgent>();
		MGOEIFJCLAJ.angularSpeed = 3600f;
		if (!FOGIOGKLNIP.PIOANBBCFFP.NBLJJDANCFG && AADHMELMIBK != null && AADHMELMIBK.LOPJEPPAFPH != null)
		{
			AADHMELMIBK.MHMKAGPKJFP();
		}
	}

	[RPC]
	public void OBKMIHILMLH(bool EHAPKEKPMOE)
	{
		BIHOCPAKHNF("OBKMIHILMLH" + EHAPKEKPMOE);
		if (EHAPKEKPMOE)
		{
			FOGIOGKLNIP.PIOANBBCFFP.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Rescued);
		}
		JGDLDJLBKEF = EHAPKEKPMOE;
		if (EPCKLAKNAAG != null && EPCKLAKNAAG.KAMAMHFJDGG)
		{
			FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ.FBBDIENBDGM(FOGIOGKLNIP.EELPLHEEEDB("hostage", 1000));
		}
		if (!FOGIOGKLNIP.PIOANBBCFFP.NBLJJDANCFG && AADHMELMIBK != null && AADHMELMIBK.LOPJEPPAFPH != null)
		{
			AADHMELMIBK.BHDMLGFBPDN();
		}
		ICIEDCMDJFO.SetActive(!EHAPKEKPMOE);
	}

	public override void BJGMKFIGEFA()
	{
		if (EPCKLAKNAAG != null)
		{
			HBCEJOJNMNB(KDIIPCNBDGP, EPCKLAKNAAG.MFAGKFPCJFG);
		}
		HBCEJOJNMNB(OBKMIHILMLH, JGDLDJLBKEF);
	}

	public void Update()
	{
		if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ))
		{
			if (FOGIOGKLNIP.NMGDHKIKCED != null && FOGIOGKLNIP.NMGDHKIKCED.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists && EPCKLAKNAAG == null && (FOGIOGKLNIP.NMGDHKIKCED.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 2f && (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.E) || (FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.CIEBMCOJGCC.PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.OJJLMNMBGJJ, default(TouchPhase)))))
			{
				NCHOPAEKPBK(KDIIPCNBDGP, FOGIOGKLNIP.NMGDHKIKCED.MFAGKFPCJFG);
			}
			if (base.NENPALDENAL && (base.ELGIKGAIIOD - FOGIOGKLNIP.PIOANBBCFFP.LNPHCAOCEBD.position).magnitude < 5f)
			{
				FOGIOGKLNIP.EIIMBNKHJJA.ONHMHNKCHEK();
				NCHOPAEKPBK(OBKMIHILMLH, OGJIDBEODPM: true);
			}
		}
		if (JDFKPOMKMNJ.ELKBOHAOPDL(10))
		{
			Vector3 direction = base.ELGIKGAIIOD + Vector3.up * 1.5f - FOGIOGKLNIP.NGFDFPGNDCJ.ELGIKGAIIOD;
			bool flag = FOGIOGKLNIP.LPLJMLGKCLK.DKHCDLFJMPA || !Physics.Raycast(FOGIOGKLNIP.NGFDFPGNDCJ.ELGIKGAIIOD, direction, direction.magnitude, 1024);
			if (CGCEAEFHDIF != flag)
			{
				CGCEAEFHDIF = flag;
				Renderer[] pINCOHHLKGB = PINCOHHLKGB;
				foreach (Renderer renderer in pINCOHHLKGB)
				{
					if (renderer != null || FOGIOGKLNIP.OMMLFOEPEEK)
					{
						renderer.enabled = CGCEAEFHDIF;
					}
				}
				Animation[] bCONCFOPNHA = BCONCFOPNHA;
				foreach (Animation animation in bCONCFOPNHA)
				{
					if (animation != null || FOGIOGKLNIP.OMMLFOEPEEK)
					{
						animation.enabled = CGCEAEFHDIF;
					}
				}
			}
		}
		if (CGCEAEFHDIF || base.NENPALDENAL)
		{
			if (MGOEIFJCLAJ.velocity.magnitude > 0.5f)
			{
				GCNMEJLGIOE.Play("run");
			}
			else
			{
				GCNMEJLGIOE.Play("idle");
			}
		}
		if (EPCKLAKNAAG != null && (double)(base.ELGIKGAIIOD - EPCKLAKNAAG.ELGIKGAIIOD).magnitude > 0.5 && ICIEDCMDJFO.activeInHierarchy)
		{
			MGOEIFJCLAJ.destination = EPCKLAKNAAG.ELGIKGAIIOD + (base.ELGIKGAIIOD - EPCKLAKNAAG.ELGIKGAIIOD).normalized * 1f;
		}
		if (EPCKLAKNAAG == null)
		{
			MGOEIFJCLAJ.destination = base.ELGIKGAIIOD;
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
	}

	[RPC]
	public void KDIIPCNBDGP(NetworkViewID FIOKJLLBGDI)
	{
		KDIIPCNBDGP((object)FIOKJLLBGDI);
	}

	[RPC]
	public void KDIIPCNBDGP(PhotonViewID FIOKJLLBGDI)
	{
		KDIIPCNBDGP((object)FIOKJLLBGDI);
	}

	public void KDIIPCNBDGP(object FIOKJLLBGDI)
	{
		BIHOCPAKHNF("KDIIPCNBDGP");
		if (EPCKLAKNAAG == null)
		{
			LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.LetsGo);
		}
		EPCKLAKNAAG = FOGIOGKLNIP.AAPLAPBIFMD<KKJBDENNKGF>(FIOKJLLBGDI);
	}

	public virtual void OnSerializeNetworkView(BitStream IILDKLHJIDE, NetworkMessageInfo LIEKABKEJOG)
	{
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA))
		{
			Vector3 value = base.ELGIKGAIIOD;
			IILDKLHJIDE.Serialize(ref value);
			if (IILDKLHJIDE.isReading)
			{
				MGOEIFJCLAJ.Move(value - base.ELGIKGAIIOD);
			}
		}
	}

	public virtual void OnPhotonSerializeView(PhotonStream IILDKLHJIDE, PhotonMessageInfo LIEKABKEJOG)
	{
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA))
		{
			if (IILDKLHJIDE.isReading)
			{
				MGOEIFJCLAJ.Move((Vector3)IILDKLHJIDE.ReceiveNext() - base.ELGIKGAIIOD);
			}
			if (IILDKLHJIDE.isWriting)
			{
				IILDKLHJIDE.SendNext(base.ELGIKGAIIOD);
			}
		}
	}

	[CompilerGenerated]
	private void JDGOKBJLEBB()
	{
		FOGIOGKLNIP.PIOANBBCFFP.HGHGHLHBAMA(ICIEDCMDJFO, "H");
	}
}
