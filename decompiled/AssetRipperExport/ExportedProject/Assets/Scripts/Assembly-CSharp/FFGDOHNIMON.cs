using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class FFGDOHNIMON : IAPJEBKJEHC
{
	private sealed class HFKAKCCEOAO : IEnumerable, IEnumerable<RaycastHit>, IEnumerator, IDisposable, IEnumerator<RaycastHit>
	{
		internal Vector3[] LOFNALDPCFD;

		internal Vector3[] DKOBKNHODMO;

		internal int HGPJDOEGCEC;

		internal Vector3 JEDHJGOGGDK;

		internal float NINDANMNGPD;

		internal RaycastHit[] NCFOKGJPDLA;

		internal int DJKGPDKHMFK;

		internal RaycastHit BOMOOMGMEBB;

		internal FFGDOHNIMON KPHCHDHEKGH;

		internal RaycastHit HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		RaycastHit IEnumerator<RaycastHit>.Current
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
		public HFKAKCCEOAO()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				DKOBKNHODMO = LOFNALDPCFD;
				HGPJDOEGCEC = 0;
				goto IL_00f3;
			case 1u:
				{
					DJKGPDKHMFK++;
					goto IL_00d2;
				}
				IL_00f3:
				if (HGPJDOEGCEC < DKOBKNHODMO.Length)
				{
					JEDHJGOGGDK = DKOBKNHODMO[HGPJDOEGCEC];
					NCFOKGJPDLA = Physics.RaycastAll(KPHCHDHEKGH.ELGIKGAIIOD, JEDHJGOGGDK, NINDANMNGPD, 67378432);
					DJKGPDKHMFK = 0;
					goto IL_00d2;
				}
				GNNOELAJGPI = -1;
				break;
				IL_00d2:
				if (DJKGPDKHMFK < NCFOKGJPDLA.Length)
				{
					BOMOOMGMEBB = NCFOKGJPDLA[DJKGPDKHMFK];
					HLJEEFIJCOF = BOMOOMGMEBB;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					return true;
				}
				HGPJDOEGCEC++;
				goto IL_00f3;
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

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<RaycastHit>)this).GetEnumerator();
		}

		[DebuggerHidden]
		IEnumerator<RaycastHit> IEnumerable<RaycastHit>.GetEnumerator()
		{
			if (Interlocked.CompareExchange(ref GNNOELAJGPI, 0, -2) == -2)
			{
				return this;
			}
			HFKAKCCEOAO hFKAKCCEOAO = new HFKAKCCEOAO();
			hFKAKCCEOAO.KPHCHDHEKGH = KPHCHDHEKGH;
			hFKAKCCEOAO.LOFNALDPCFD = LOFNALDPCFD;
			hFKAKCCEOAO.NINDANMNGPD = NINDANMNGPD;
			return hFKAKCCEOAO;
		}
	}

	public bool LHHAIDFMPON;

	[Field(name = "Damage", min = 1f, max = 1000f, customOnly = true)]
	public ObscuredInt BKENMJFCFJI = ObscuredInt.FNIPJFGEFFD(60);

	private float PCBPDLMGPFJ;

	private float OBCCBIGCNOM;

	public override void Awake()
	{
		if (!ObscuredBool.FNIPJFGEFFD(HPFPFCNOKAM))
		{
			FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
		}
		base.Awake();
	}

	public override void Start()
	{
		base.Start();
	}

	public override void Update()
	{
		base.Update();
		MPELBBLOCFF = OOKLHOCJKAG || Time.time - OBCCBIGCNOM < 1f || Time.time - PCBPDLMGPFJ < 1f;
		if (!KAMAMHFJDGG || !(FOGIOGKLNIP.NGFDFPGNDCJ.NMJOJEDEJBO != null))
		{
			return;
		}
		if (((!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && !(NJEPMOIDJKH.JEPMMPCNEHO as JOCAFHIONFA)) || !(NJEPMOIDJKH.JEPMMPCNEHO as OLILBNAJMLF)) && (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.F) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.KPMFMBAMFCF, default(TouchPhase))))
		{
			NCHOPAEKPBK(KPMFMBAMFCF);
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			LHHAIDFMPON = !(Time.time - PCBPDLMGPFJ > ObscuredFloat.FNIPJFGEFFD(GHBFJKNMEPJ.Time) * 0.35f) || !(Time.time - OBCCBIGCNOM > ObscuredFloat.FNIPJFGEFFD(IJICAEBOFAF.Time) * 0.85f);
			if (!FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.EPBMIIPELPO.JLIBFOMLOGD(1) && !LHHAIDFMPON && !OOKLHOCJKAG)
			{
				NCHOPAEKPBK(GONCPMENBMN);
			}
			if ((!FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.EPBMIIPELPO.JLIBFOMLOGD(1) && !LHHAIDFMPON && !OOKLHOCJKAG && FOGIOGKLNIP.DGMBIMMABNO) || (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.OJJLMNMBGJJ, default(TouchPhase)) && !MPELBBLOCFF))
			{
				NCHOPAEKPBK(GONCPMENBMN);
			}
			if (OOKLHOCJKAG && !LHHAIDFMPON)
			{
				NCHOPAEKPBK(DLEAGBAJNBC);
			}
			if (!FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.isPlaying)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play("idle");
			}
		}
		if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
		{
			LHHAIDFMPON = !(Time.time - PCBPDLMGPFJ > ObscuredFloat.FNIPJFGEFFD(GHBFJKNMEPJ.Time) * 0.35f) || !(Time.time - OBCCBIGCNOM > ObscuredFloat.FNIPJFGEFFD(IJICAEBOFAF.Time) * 0.85f);
			if (!FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.EPBMIIPELPO.JLIBFOMLOGD(1) && !LHHAIDFMPON && !OOKLHOCJKAG)
			{
				NCHOPAEKPBK(GONCPMENBMN);
			}
			if ((!FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.EPBMIIPELPO.JLIBFOMLOGD(1) && !LHHAIDFMPON && !OOKLHOCJKAG && FOGIOGKLNIP.DGMBIMMABNO) || (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.OJJLMNMBGJJ, default(TouchPhase)) && !MPELBBLOCFF))
			{
				NCHOPAEKPBK(GONCPMENBMN);
			}
			if (OOKLHOCJKAG && !LHHAIDFMPON)
			{
				NCHOPAEKPBK(DLEAGBAJNBC);
			}
		}
	}

	public void IHBFPOOLCFD(int BKENMJFCFJI, float NINDANMNGPD, Action NHJKBABGLMB)
	{
		Vector3 vector = base.EHOEFMPLIFB.forward + Vector3.down * 0.3f;
		RaycastHit[] array = JMDCOENIBHK(NINDANMNGPD, new Vector3[3]
		{
			vector,
			vector + base.EHOEFMPLIFB.right * 0.3f,
			vector + base.EHOEFMPLIFB.right * -0.3f
		}).ToArray();
		RaycastHit[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			RaycastHit mBIEHEGKCMN = array2[i];
			if (!(mBIEHEGKCMN.transform.root != NJEPMOIDJKH.EHOEFMPLIFB))
			{
				continue;
			}
			KKJBDENNKGF component = mBIEHEGKCMN.transform.root.GetComponent<KKJBDENNKGF>();
			if (component != null)
			{
				if (!NGCHFCOBBNH(component))
				{
					FOGIOGKLNIP.PIOANBBCFFP.INNBPKJCELB(mBIEHEGKCMN);
					NCHOPAEKPBK(JNACBBICIJD);
					if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.MGDGJKCGHII) || (component.BJDCCKHBENA.JGECOECAJLK != NJEPMOIDJKH.BJDCCKHBENA.JGECOECAJLK && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE)) || (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE) && !ObscuredBool.FNIPJFGEFFD(component.BJDCCKHBENA.CMGBAIJNMEH)))
					{
						component.GGNFHJCPCBK(-IFHGMCKAKEC(BKENMJFCFJI, component, FBGNKPPMENN, NJEPMOIDJKH.BJDCCKHBENA), NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN, 2);
					}
					if (component.BJDCCKHBENA.JGECOECAJLK == NJEPMOIDJKH.BJDCCKHBENA.JGECOECAJLK && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.JABHAJEEFNO) && (float)ObscuredInt.FNIPJFGEFFD(component.BHFDJDDGHKA) < ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.OHGEMABOIBK))
					{
						NJEPMOIDJKH.BJDCCKHBENA.NCHOPAEKPBK(NJEPMOIDJKH.BJDCCKHBENA.FBBDIENBDGM, 20);
						component.NCHOPAEKPBK(component.DFJGLGGOKKN, ObscuredInt.FNIPJFGEFFD(component.BHFDJDDGHKA) + BKENMJFCFJI / 6);
					}
					return;
				}
			}
			else if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.JABHAJEEFNO))
			{
				PMDPIINLPHK component2 = mBIEHEGKCMN.transform.root.GetComponent<PMDPIINLPHK>();
				if (component2 != null && component2.BHFDJDDGHKA < component2.IAGBJCNHIPK)
				{
					component2.NCHOPAEKPBK(component2.DFJGLGGOKKN, component2.BHFDJDDGHKA + BKENMJFCFJI);
				}
			}
		}
		RaycastHit[] array3 = array;
		for (int j = 0; j < array3.Length; j++)
		{
			RaycastHit mBIEHEGKCMN2 = array3[j];
			if (!(mBIEHEGKCMN2.transform.root != NJEPMOIDJKH.EHOEFMPLIFB))
			{
				continue;
			}
			if (mBIEHEGKCMN2.rigidbody != null && !mBIEHEGKCMN2.rigidbody.isKinematic)
			{
				mBIEHEGKCMN2.rigidbody.AddForce(UnityEngine.Random.onUnitSphere * 500f);
				NCHOPAEKPBK(JNACBBICIJD);
			}
			else
			{
				FOGIOGKLNIP.PIOANBBCFFP.DDOFLINNNOB(mBIEHEGKCMN2);
				NCHOPAEKPBK(FPGKFJOLPOJ);
			}
			if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.JABHAJEEFNO) && mBIEHEGKCMN2.transform.parent != null)
			{
				PMDPIINLPHK component3 = mBIEHEGKCMN2.transform.parent.GetComponent<PMDPIINLPHK>();
				if (component3 != null)
				{
					component3.NCHOPAEKPBK(component3.PLEKGNIKPEH, component3.BHFDJDDGHKA - BKENMJFCFJI, mBIEHEGKCMN2.point);
				}
			}
			return;
		}
		NCHOPAEKPBK(ABPIKELCDLM);
	}

	[DebuggerHidden]
	private IEnumerable<RaycastHit> JMDCOENIBHK(float NINDANMNGPD, Vector3[] LOFNALDPCFD)
	{
		HFKAKCCEOAO hFKAKCCEOAO = new HFKAKCCEOAO();
		hFKAKCCEOAO.LOFNALDPCFD = LOFNALDPCFD;
		hFKAKCCEOAO.NINDANMNGPD = NINDANMNGPD;
		hFKAKCCEOAO.KPHCHDHEKGH = this;
		hFKAKCCEOAO.GNNOELAJGPI = -2;
		return hFKAKCCEOAO;
	}

	public override void ELPILFMDIKG()
	{
		base.ELPILFMDIKG();
	}

	[RPC]
	public override void KPMFMBAMFCF()
	{
		base.KPMFMBAMFCF();
	}

	[RPC]
	public void GONCPMENBMN()
	{
		MPELBBLOCFF = false;
		OBCCBIGCNOM = Time.time;
		if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			return;
		}
		FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Stop();
		FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play("stab1");
		if (KAMAMHFJDGG)
		{
			StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(0.3f, delegate
			{
				IHBFPOOLCFD(ObscuredInt.FNIPJFGEFFD(BKENMJFCFJI), 1.5f, BNFOBFEJCPM);
			}));
		}
	}

	[RPC]
	public void DLEAGBAJNBC()
	{
		MPELBBLOCFF = false;
		PCBPDLMGPFJ = Time.time;
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Stop();
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play("mid1");
			if (KAMAMHFJDGG)
			{
				IHBFPOOLCFD(ObscuredInt.FNIPJFGEFFD(BKENMJFCFJI) / 3, ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.Range), JNACBBICIJD);
			}
		}
	}

	[RPC]
	public void ABPIKELCDLM()
	{
		NJEPMOIDJKH.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.MidSlashKnife);
	}

	[RPC]
	public void FPGKFJOLPOJ()
	{
		NJEPMOIDJKH.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.HitWallKnife);
	}

	[RPC]
	public void BNFOBFEJCPM()
	{
		NJEPMOIDJKH.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.StabKnife);
	}

	[RPC]
	public void JNACBBICIJD()
	{
		NJEPMOIDJKH.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.HitKnife);
	}

	[CompilerGenerated]
	private void FPEPHHOBBML()
	{
		IHBFPOOLCFD(ObscuredInt.FNIPJFGEFFD(BKENMJFCFJI), 1.5f, BNFOBFEJCPM);
	}
}
