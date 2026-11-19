using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class NGBCDAIIEFP : IAPJEBKJEHC
{
	public class JECEBKMEHMH
	{
		public float HEJLMDDPNBC;

		public RaycastHit? FDEFKLBMPJL;

		public Vector3 BADIHIKMKJF;

		public Vector3 OOIJMCFMDHN;

		public float CHJKAPFOEML;

		public float FAGMOBEKJND;
	}

	private sealed class EJMOGFHIDJM : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal NGBCDAIIEFP KPHCHDHEKGH;

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
		public EJMOGFHIDJM()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (KPHCHDHEKGH.OBPLDGGKLOJ && KPHCHDHEKGH.MPELBBLOCFF)
				{
					goto default;
				}
				KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.LKDPJIEAPIF, true);
				if (KPHCHDHEKGH.KAMAMHFJDGG && ObscuredBool.FNIPJFGEFFD(KPHCHDHEKGH.NJEPMOIDJKH.IIPDOGECCPA) && !ObscuredBool.FNIPJFGEFFD(KPHCHDHEKGH.NJEPMOIDJKH.HIBLODEGHAK))
				{
					if (!KPHCHDHEKGH.KNAEGLBCLDL)
					{
						HLJEEFIJCOF = new WaitForSeconds(ObscuredFloat.FNIPJFGEFFD(KPHCHDHEKGH.GHNMHBBGAOL.Time));
						if (!JMOBJHKGFMH)
						{
							GNNOELAJGPI = 1;
						}
					}
					else
					{
						HLJEEFIJCOF = new WaitForSeconds(ObscuredFloat.FNIPJFGEFFD(KPHCHDHEKGH.NNGEBJFEGKA.Time));
						if (!JMOBJHKGFMH)
						{
							GNNOELAJGPI = 2;
						}
					}
					break;
				}
				goto IL_01fa;
			case 1u:
				KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.NJEPMOIDJKH.ELNKLGHNLEP, !KPHCHDHEKGH.KNAEGLBCLDL, KPHCHDHEKGH.FBGNKPPMENN);
				KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.NJEPMOIDJKH.LKDPJIEAPIF, false);
				goto IL_01fa;
			case 2u:
				KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.NJEPMOIDJKH.ELNKLGHNLEP, !KPHCHDHEKGH.KNAEGLBCLDL, KPHCHDHEKGH.FBGNKPPMENN);
				KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.NJEPMOIDJKH.LKDPJIEAPIF, false);
				goto IL_01fa;
			default:
				{
					return false;
				}
				IL_01fa:
				GNNOELAJGPI = -1;
				goto default;
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

	private sealed class EGEHDPBNENM : IEnumerable, IEnumerable<RaycastHit>, IEnumerator, IDisposable, IEnumerator<RaycastHit>
	{
		internal float NINDANMNGPD;

		internal Ray FMAHAOKDPJI;

		internal RaycastHit NLDNKHINGJI;

		internal int PJLCBKIFKEA;

		internal RaycastHit HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal float NBIDKMAELHK;

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
		public EGEHDPBNENM()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
			case 1u:
				if (NINDANMNGPD > 0f && Physics.Raycast(FMAHAOKDPJI, out NLDNKHINGJI, NINDANMNGPD, PJLCBKIFKEA))
				{
					NINDANMNGPD -= NLDNKHINGJI.distance;
					FMAHAOKDPJI.origin = NLDNKHINGJI.point - NLDNKHINGJI.normal * 0.01f;
					HLJEEFIJCOF = NLDNKHINGJI;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
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
			EGEHDPBNENM eGEHDPBNENM = new EGEHDPBNENM();
			eGEHDPBNENM.NINDANMNGPD = NBIDKMAELHK;
			eGEHDPBNENM.FMAHAOKDPJI = FMAHAOKDPJI;
			eGEHDPBNENM.PJLCBKIFKEA = PJLCBKIFKEA;
			return eGEHDPBNENM;
		}
	}

	private sealed class HBPPDOGCFKM
	{
		internal Ray FMAHAOKDPJI;

		internal NGBCDAIIEFP KPHCHDHEKGH;
	}

	private sealed class CNLIBCONPFE
	{
		internal Ray PCHDGCKMHKC;

		internal HBPPDOGCFKM DNBMGNLNCGC;

		internal void BEKJDJFLJJC()
		{
			RaycastHit[] array = Physics.RaycastAll(PCHDGCKMHKC, 100f, 16781312);
			for (int i = 0; i < array.Length; i++)
			{
				RaycastHit mBIEHEGKCMN = array[i];
				if (mBIEHEGKCMN.rigidbody != null && !mBIEHEGKCMN.rigidbody.isKinematic)
				{
					if (mBIEHEGKCMN.collider.gameObject.layer == 12)
					{
						FOGIOGKLNIP.PIOANBBCFFP.INNBPKJCELB(mBIEHEGKCMN);
					}
					if (mBIEHEGKCMN.rigidbody.velocity.magnitude < 10f)
					{
						mBIEHEGKCMN.rigidbody.velocity = Vector3.zero;
						mBIEHEGKCMN.rigidbody.AddForceAtPosition(DNBMGNLNCGC.FMAHAOKDPJI.direction * DNBMGNLNCGC.KPHCHDHEKGH.BNGINMFPMIF * DNBMGNLNCGC.KPHCHDHEKGH.BILHMMNDCKA * ((!FOGIOGKLNIP.DGMBIMMABNO) ? 1f : 0.5f), mBIEHEGKCMN.point);
					}
				}
			}
		}
	}

	private sealed class PBFGCELHLAA : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal JECEBKMEHMH DBPDHHOOHBP;

		internal Ray CDHLCJDFGDA;

		internal float JEDHJGOGGDK;

		internal NGBCDAIIEFP KPHCHDHEKGH;

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
		public PBFGCELHLAA()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				DBPDHHOOHBP = new JECEBKMEHMH();
				DBPDHHOOHBP.BADIHIKMKJF = CDHLCJDFGDA.direction;
				DBPDHHOOHBP.OOIJMCFMDHN = CDHLCJDFGDA.origin;
				goto IL_0143;
			case 1u:
				DBPDHHOOHBP.FAGMOBEKJND += 1f;
				goto IL_0143;
			case 2u:
				{
					GNNOELAJGPI = -1;
					break;
				}
				IL_0143:
				if (DBPDHHOOHBP.FAGMOBEKJND < 1000f)
				{
					JEDHJGOGGDK = Time.deltaTime * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IIMBKIJMFNB) * ObscuredFloat.FNIPJFGEFFD(KPHCHDHEKGH.FLGDGHPCNDK.bulletSpeedFactor);
					if (!KPHCHDHEKGH.DOJNPCJDIOB(JEDHJGOGGDK, DBPDHHOOHBP))
					{
						DBPDHHOOHBP.OOIJMCFMDHN += DBPDHHOOHBP.BADIHIKMKJF * JEDHJGOGGDK;
						DBPDHHOOHBP.CHJKAPFOEML += JEDHJGOGGDK;
						if (!(DBPDHHOOHBP.CHJKAPFOEML > 200f))
						{
							HLJEEFIJCOF = null;
							if (!JMOBJHKGFMH)
							{
								GNNOELAJGPI = 1;
							}
							goto IL_017c;
						}
					}
				}
				HLJEEFIJCOF = null;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 2;
				}
				goto IL_017c;
				IL_017c:
				return true;
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

	private sealed class GDJFNCEEEFC : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal NGBCDAIIEFP KPHCHDHEKGH;

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
		public GDJFNCEEEFC()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (!KPHCHDHEKGH.GMLKEKBDLAJ && KPHCHDHEKGH.LMJDOOEODJK.DJEALLIOJEO(KPHCHDHEKGH.NNBDEKBINFP) > 0 && ObscuredInt.FNIPJFGEFFD(KPHCHDHEKGH.CNMKGNNGPDD) != ObscuredInt.FNIPJFGEFFD(KPHCHDHEKGH.ABHFBECBPBA))
				{
					KPHCHDHEKGH.GMLKEKBDLAJ = true;
					if (KPHCHDHEKGH.GMLKEKBDLAJ)
					{
						if (KPHCHDHEKGH is FACHOPPILGM)
						{
							KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.NJEPMOIDJKH.PCLEFKOPNCJ);
							HLJEEFIJCOF = new WaitForSeconds(ObscuredFloat.FNIPJFGEFFD((KPHCHDHEKGH.NJEPMOIDJKH.JEPMMPCNEHO as FACHOPPILGM).PJBGJIAOPID));
							if (!JMOBJHKGFMH)
							{
								GNNOELAJGPI = 1;
							}
						}
						else
						{
							HLJEEFIJCOF = new WaitForSeconds(ObscuredFloat.FNIPJFGEFFD(KPHCHDHEKGH.ILEPKAHGJFG.Time));
							if (!JMOBJHKGFMH)
							{
								GNNOELAJGPI = 4;
							}
						}
						break;
					}
				}
				goto default;
			case 2u:
			{
				if (!ObscuredBool.FNIPJFGEFFD(KPHCHDHEKGH.NJEPMOIDJKH.NBFGNGGJDNB) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
				{
					KPHCHDHEKGH.LMJDOOEODJK.NKOHBFHAELH(KPHCHDHEKGH.NNBDEKBINFP, -1);
				}
				NGBCDAIIEFP kPHCHDHEKGH = KPHCHDHEKGH;
				kPHCHDHEKGH.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(kPHCHDHEKGH.CNMKGNNGPDD) + 1);
				KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.NJEPMOIDJKH.ODMGBBKGLOD);
				goto case 1u;
			}
			case 1u:
				if (KPHCHDHEKGH.LMJDOOEODJK.DJEALLIOJEO(KPHCHDHEKGH.NNBDEKBINFP) > 0 && ObscuredInt.FNIPJFGEFFD(KPHCHDHEKGH.CNMKGNNGPDD) != ObscuredInt.FNIPJFGEFFD(KPHCHDHEKGH.ABHFBECBPBA) && !FOGIOGKLNIP.CNIAIOJACDA)
				{
					KPHCHDHEKGH.FMMAKOLBPBL();
					HLJEEFIJCOF = new WaitForSeconds(ObscuredFloat.FNIPJFGEFFD((KPHCHDHEKGH.NJEPMOIDJKH.JEPMMPCNEHO as FACHOPPILGM).JKDPFBMAGOL));
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 2;
					}
				}
				else
				{
					KPHCHDHEKGH.NJEPMOIDJKH.NCHOPAEKPBK(KPHCHDHEKGH.NJEPMOIDJKH.DONIMNAJJIB);
					HLJEEFIJCOF = new WaitForSeconds(ObscuredFloat.FNIPJFGEFFD((KPHCHDHEKGH.NJEPMOIDJKH.JEPMMPCNEHO as FACHOPPILGM).CAJODIOPHDN));
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 3;
					}
				}
				break;
			case 4u:
				KPHCHDHEKGH.GMLKEKBDLAJ = false;
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

	public bool OOGBPCDNDMC;

	public bool CBPCNKICEOH;

	public int BNGINMFPMIF = 2000;

	public int IOKJADJOLIJ = 1;

	[Field(name = "Damage", customOnly = true)]
	public ObscuredInt BKENMJFCFJI = ObscuredInt.FNIPJFGEFFD(26);

	public float BMOICBJLLDP;

	public float DADNFALCGCC;

	private float DGLPPHEALII;

	private string IANBJADJBPL;

	public Vector3 IDOPEEGELCK = new Vector3(-90f, -90f, 90f);

	internal bool BBKKINKGGIC = true;

	internal bool FNDJENIEFJJ;

	internal int DFCGJIBGBIP;

	internal int EANKGJJAMCO;

	internal int JHKBOHNABHK;

	private bool CFOBBOCEIBB;

	public bool OBPLDGGKLOJ
	{
		get
		{
			return Time.time - ObscuredFloat.FNIPJFGEFFD(AMNOHEEAFPD) < ObscuredFloat.FNIPJFGEFFD(ILEPKAHGJFG.Time) * (float)((!(this is FACHOPPILGM)) ? 1 : 2);
		}
	}

	public bool MGIDELDNDFE
	{
		get
		{
			return Time.time - (DGLPPHEALII - ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.shootTime)) < ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.shootTime);
		}
	}

	public bool MJCFBFOMBNA
	{
		get
		{
			return Time.time - KDIEIJEFDCM < ObscuredFloat.FNIPJFGEFFD(PKIACGNBAFC.Time) * 0.7f;
		}
	}

	public AnimationState OADKFGNCGMP
	{
		get
		{
			AnimationState animationState = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM[KPDIHKJBLJO];
			return (!(animationState == null)) ? animationState : FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["reload"];
		}
	}

	public AnimationState JNKBMKOCPPL
	{
		get
		{
			AnimationState animationState = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot1"];
			return (!(animationState == null)) ? animationState : FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot"];
		}
	}

	private static AnimationState EKMIDOBFFAG
	{
		get
		{
			AnimationState animationState = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot_left1"];
			return (!(animationState == null)) ? animationState : FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot_left1"];
		}
	}

	private static AnimationState BFKPMGIIKEL
	{
		get
		{
			AnimationState animationState = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot_right1"];
			return (!(animationState == null)) ? animationState : FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["shoot_right1"];
		}
	}

	public override bool KAMAMHFJDGG
	{
		get
		{
			return NJEPMOIDJKH.KAMAMHFJDGG;
		}
	}

	public override void Awake()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		IANBJADJBPL = MEGEODGDDAH + KPDIHKJBLJO;
		base.Awake();
		GLCDJFFPBOA();
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	public override void Start()
	{
		Reset();
		base.Start();
	}

	[DebuggerHidden]
	public IEnumerator NHLJONCKCGE()
	{
		EJMOGFHIDJM eJMOGFHIDJM = new EJMOGFHIDJM();
		eJMOGFHIDJM.KPHCHDHEKGH = this;
		return eJMOGFHIDJM;
	}

	public override void Update()
	{
		base.Update();
		if (!NJEPMOIDJKH.IAALHLCLAOD)
		{
			return;
		}
		MPELBBLOCFF = Time.time - ObscuredFloat.FNIPJFGEFFD(NJEPMOIDJKH.IBAMOAMDJGP) < 0.2f;
		HCKBKGINDPI = Mathf.MoveTowards(HCKBKGINDPI, 0f, Time.deltaTime * ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.cursorRecovery));
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			FOGIOGKLNIP.CIEBMCOJGCC.LCDLBHHNJIA = HCKBKGINDPI;
			if (ObscuredBool.FNIPJFGEFFD(BCCOHOIIGPP) && !MGIDELDNDFE && !OBPLDGGKLOJ)
			{
				switch (GNOBBODJHNF)
				{
				case 0:
					FOGIOGKLNIP.NGFDFPGNDCJ.CICDHCEOLLE.fieldOfView = 40f;
					break;
				case 1:
					FOGIOGKLNIP.NGFDFPGNDCJ.CICDHCEOLLE.fieldOfView = 15f;
					break;
				case 2:
					FOGIOGKLNIP.NGFDFPGNDCJ.CICDHCEOLLE.fieldOfView = FOGIOGKLNIP.NGFDFPGNDCJ.EKJHJPABMBB;
					break;
				}
				if (EJCOGJOCEFF != -1)
				{
					NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.GOPIBMLFMBC, EJCOGJOCEFF);
					EJCOGJOCEFF = -1;
				}
			}
			if (FOGIOGKLNIP.CNIAIOJACDA && ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) == 0 && Time.time <= DGLPPHEALII)
			{
				NJEPMOIDJKH.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.DryFire);
			}
			if (!FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD && !OBPLDGGKLOJ && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && !FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.isPlaying)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play(base.DPFPDBOOGHP.name);
			}
			if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && (bool)base.DECONHBIJAA && !ObscuredBool.FNIPJFGEFFD(DGECFCEDDGB) && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && !FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD)
			{
				base.DECONHBIJAA.GetComponent<Renderer>().enabled = KNAEGLBCLDL;
			}
			if (base.DECONHBIJAA != null && FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD)
			{
				base.DECONHBIJAA.GetComponent<Renderer>().enabled = false;
			}
			if (ObscuredBool.FNIPJFGEFFD(DGECFCEDDGB) && !FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD)
			{
				base.DECONHBIJAA.GetComponent<Renderer>().enabled = true;
			}
			if (NJEPMOIDJKH.KAMAMHFJDGG && ObscuredBool.FNIPJFGEFFD(BCCOHOIIGPP) && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && !MGIDELDNDFE && !OBPLDGGKLOJ && ((FOGIOGKLNIP.EPBMIIPELPO.JEMHJCCILMN(1) && !FOGIOGKLNIP.DGMBIMMABNO) || (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.OJJLMNMBGJJ, default(TouchPhase)) && FOGIOGKLNIP.DGMBIMMABNO)))
			{
				if (!FOGIOGKLNIP.LPLJMLGKCLK.DEFMNAPCCJP)
				{
					NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.GOPIBMLFMBC, (GNOBBODJHNF != 2) ? (GNOBBODJHNF + 1) : 0);
				}
				else
				{
					NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.GOPIBMLFMBC, (GNOBBODJHNF == 0) ? 2 : 0);
				}
			}
			if (((NJEPMOIDJKH.KAMAMHFJDGG && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && !OBPLDGGKLOJ && !(NJEPMOIDJKH.JEPMMPCNEHO as JOCAFHIONFA)) || !(NJEPMOIDJKH.JEPMMPCNEHO as OLILBNAJMLF)) && (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.KPMFMBAMFCF, default(TouchPhase)) || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.F)))
			{
				NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.KPMFMBAMFCF);
			}
			if (((NJEPMOIDJKH.KAMAMHFJDGG && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && OOKLHOCJKAG == FOGIOGKLNIP.PIOANBBCFFP.CPPEBEEIOEG && (bool)(NJEPMOIDJKH.JEPMMPCNEHO as OENJLELADOM)) || (bool)(NJEPMOIDJKH.JEPMMPCNEHO as MELEBCPOMHB)) && !FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.IsPlaying(base.DFMAGFMJGDH.name) && !ObscuredBool.FNIPJFGEFFD(DGECFCEDDGB) && !OBPLDGGKLOJ && (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.OJJLMNMBGJJ, default(TouchPhase)) || (FOGIOGKLNIP.EPBMIIPELPO.JEMHJCCILMN(1) && !FOGIOGKLNIP.DGMBIMMABNO)))
			{
				NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.EPADPNIJNNJ);
			}
		}
		if (KAMAMHFJDGG)
		{
			if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP) <= 0 && ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) <= 0)
			{
				switch (KOPFHECCACK)
				{
				case 1:
					NJEPMOIDJKH.PCOIDKLMEAD(2);
					break;
				case 2:
					NJEPMOIDJKH.PCOIDKLMEAD(3);
					break;
				}
			}
			if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) <= 0)
			{
				if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) > ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) + 1)
				{
					base.CNMKGNNGPDD = ABHFBECBPBA;
					NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.ODMGBBKGLOD);
				}
				if (FHPNFKMCACF)
				{
					NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.CHEOEJNGLFP, false);
				}
				if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) <= 0 && !OBPLDGGKLOJ && !MJCFBFOMBNA && !MGIDELDNDFE && LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP) > 0)
				{
					NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.ODMGBBKGLOD);
				}
			}
			else if (OOKLHOCJKAG != FHPNFKMCACF && (Time.time - BMOICBJLLDP > ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.shootTimeNonAuto) || !OOKLHOCJKAG))
			{
				NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.CHEOEJNGLFP, OOKLHOCJKAG);
			}
		}
		if (FHPNFKMCACF && !ObscuredBool.FNIPJFGEFFD(DGECFCEDDGB) && !OBPLDGGKLOJ && !MJCFBFOMBNA && Time.time >= DGLPPHEALII)
		{
			DGLPPHEALII = Time.time + ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.shootTime);
			FMJLAGBKCKJ();
		}
		if (!((NJEPMOIDJKH.FDAGHIAOOJF != NHBBNDBBHJH.MDCGNDPBALA) ? OOGBPCDNDMC : CBPCNKICEOH) || !(NJEPMOIDJKH.GCNMEJLGIOE != null) || NJEPMOIDJKH.GCNMEJLGIOE[IANBJADJBPL].enabled)
		{
			return;
		}
		foreach (Transform item in NJEPMOIDJKH.LDFLDCLLEPN)
		{
			item.rotation = NJEPMOIDJKH.MPCGHDNMNKN.KHGAOLHJCMO * Quaternion.Euler(IDOPEEGELCK);
		}
	}

	public override void ELPILFMDIKG()
	{
		base.ELPILFMDIKG();
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.CBBMOOPHDHM) && NJEPMOIDJKH.GCNMEJLGIOE != null)
		{
			NJEPMOIDJKH.GCNMEJLGIOE[IANBJADJBPL].speed = ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.handsReloadSpeed);
		}
		GMLKEKBDLAJ = false;
	}

	public virtual void JFFMJKAEMLB()
	{
	}

	public void GPDBDCBJNOE()
	{
		base.enabled = true;
	}

	public void GEMPBPLEFAE(Ray PCHDGCKMHKC)
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.COONIIIICJK)
		{
			PCHDGCKMHKC.origin += PCHDGCKMHKC.direction.normalized * 2f;
			if (FOGIOGKLNIP.PIOANBBCFFP.GEMPBPLEFAE != null)
			{
				FOGIOGKLNIP.PIOANBBCFFP.GEMPBPLEFAE.transform.position = PCHDGCKMHKC.origin;
				FOGIOGKLNIP.PIOANBBCFFP.GEMPBPLEFAE.transform.forward = PCHDGCKMHKC.direction;
				FOGIOGKLNIP.PIOANBBCFFP.GEMPBPLEFAE.Emit(1);
			}
			else
			{
				FOGIOGKLNIP.PIOANBBCFFP.GEMPBPLEFAE = JMJLEDGJIJK("BulletTrace", "Particles/", false, null, null, PCHDGCKMHKC.origin, Quaternion.LookRotation(PCHDGCKMHKC.direction)).GetComponent<ParticleSystem>();
				FOGIOGKLNIP.PIOANBBCFFP.GEMPBPLEFAE.Emit(1);
			}
		}
	}

	private static Bounds DENGEAMLDGF(KKJBDENNKGF FGLJAKDJFBE)
	{
		SkinnedMeshRenderer skinnedMeshRenderer = FGLJAKDJFBE.LMAEEPFEPPE as SkinnedMeshRenderer;
		if (skinnedMeshRenderer != null)
		{
			return FGLJAKDJFBE.LMAEEPFEPPE.bounds;
		}
		return new Bounds(Vector3.zero, Vector3.zero);
	}

	private void EHGILPJPBGI(RaycastHit MBIEHEGKCMN)
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL && FOGIOGKLNIP.EDBEJGJJDDA++ < base.EGPFOCNKAKB)
		{
			GameObject gameObject = JMJLEDGJIJK((!(MBIEHEGKCMN.transform.tag == "Glass")) ? "DecalHole" : "DecalGlassHole", null, false, null, null, MBIEHEGKCMN.point + MBIEHEGKCMN.normal * 0.02f, Quaternion.LookRotation(MBIEHEGKCMN.normal));
			gameObject.transform.parent = MBIEHEGKCMN.transform;
			UnityEngine.Object.Destroy(gameObject, 10f);
		}
	}

	[DebuggerHidden]
	private IEnumerable<RaycastHit> COHNFNBJBDN(Ray FMAHAOKDPJI, float NINDANMNGPD, int PJLCBKIFKEA)
	{
		EGEHDPBNENM eGEHDPBNENM = new EGEHDPBNENM();
		eGEHDPBNENM.NINDANMNGPD = NINDANMNGPD;
		eGEHDPBNENM.FMAHAOKDPJI = FMAHAOKDPJI;
		eGEHDPBNENM.PJLCBKIFKEA = PJLCBKIFKEA;
		eGEHDPBNENM.NBIDKMAELHK = NINDANMNGPD;
		eGEHDPBNENM.GNNOELAJGPI = -2;
		return eGEHDPBNENM;
	}

	private void FMMAKOLBPBL()
	{
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play(OADKFGNCGMP.name);
		}
	}

	public virtual void FMJLAGBKCKJ()
	{
		HBPPDOGCFKM hBPPDOGCFKM = new HBPPDOGCFKM();
		hBPPDOGCFKM.KPHCHDHEKGH = this;
		float num = ObscuredFloat.FNIPJFGEFFD((!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.FEONAHKMPNE)) ? FLGDGHPCNDK.RunInaccuraty : ObscuredFloat.FNIPJFGEFFD(1f));
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.NPCDJBMMJKA))
		{
			num = ((!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.MGJPMGGABLN)) ? num : (1f / ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.RunInaccuraty)));
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.CBBMOOPHDHM) && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.JEFKKCFOHCE) && NJEPMOIDJKH.GCNMEJLGIOE != null)
		{
			NJEPMOIDJKH.GCNMEJLGIOE.Stop(IANBJADJBPL);
		}
		hBPPDOGCFKM.FMAHAOKDPJI = new Ray(NJEPMOIDJKH.LGIJCFNJGDA - NJEPMOIDJKH.GGBCAOAGPPM.transform.forward * 0.3f + ((!FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD && !(NJEPMOIDJKH != FOGIOGKLNIP.NMGDHKIKCED)) ? Vector3.zero : (Vector3.down * 0.15f)), NJEPMOIDJKH.GGBCAOAGPPM.transform.forward);
		hBPPDOGCFKM.FMAHAOKDPJI.direction += UnityEngine.Random.insideUnitSphere * HCKBKGINDPI * ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.accuraty) * num;
		base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) - 1);
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			ILLCLOOGDEH(FLGDGHPCNDK.up_base, FLGDGHPCNDK.lateral_base, FLGDGHPCNDK.up_modifier, FLGDGHPCNDK.lateral_modifier, FLGDGHPCNDK.up_max, FLGDGHPCNDK.lateral_max, FLGDGHPCNDK.direction_change);
			if (!KNAEGLBCLDL)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.WeaponAction[FLGDGHPCNDK.IndexShootBank]);
			}
			else
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.WeaponSilencerAction[FLGDGHPCNDK.IndexShootSilencerBank]);
			}
		}
		else if (!KNAEGLBCLDL)
		{
			FOGIOGKLNIP.LEDCIPHCLEB((!((FOGIOGKLNIP.NGFDFPGNDCJ.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < FOGIOGKLNIP.HJLAMDIBCDO.FEEEDNPNBAE)) ? FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.WeaponActionDistance[FLGDGHPCNDK.IndexShootDistanceBank] : FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.WeaponAction[FLGDGHPCNDK.IndexShootBank], base.ELGIKGAIIOD, true, 0.5f, 1f, 1f);
		}
		else
		{
			FOGIOGKLNIP.LEDCIPHCLEB((!((FOGIOGKLNIP.NGFDFPGNDCJ.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < FOGIOGKLNIP.HJLAMDIBCDO.FEEEDNPNBAE)) ? FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.WeaponActionSilencerDistance[FLGDGHPCNDK.IndexShootSilencerDistanceBank] : FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.WeaponSilencerAction[FLGDGHPCNDK.IndexShootSilencerBank], base.ELGIKGAIIOD, true, 0.5f, 1f, 1f);
		}
		NJEPMOIDJKH.IBAMOAMDJGP = ObscuredFloat.FNIPJFGEFFD(Time.time);
		if (!NJEPMOIDJKH.IAALHLCLAOD)
		{
			return;
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.CGCEAEFHDIF) && (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) || FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD) && NJEPMOIDJKH.GJPJKPJOBGJ != null && !KNAEGLBCLDL)
		{
			NJEPMOIDJKH.HCALMEMBBJN.position = NJEPMOIDJKH.GJPJKPJOBGJ.position;
			NJEPMOIDJKH.HCALMEMBBJN.rotation = base.EHOEFMPLIFB.rotation;
			NJEPMOIDJKH.HCALMEMBBJN.GetComponent<Renderer>().useLightProbes = true;
			NJEPMOIDJKH.FKBCKBMJOKH = Time.renderedFrameCount;
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) || ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
		{
			for (int i = 0; i < ObscuredInt.FNIPJFGEFFD(FLGDGHPCNDK.bulletsPerShoot); i++)
			{
				CNLIBCONPFE cNLIBCONPFE = new CNLIBCONPFE();
				cNLIBCONPFE.DNBMGNLNCGC = hBPPDOGCFKM;
				cNLIBCONPFE.PCHDGCKMHKC = ((!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.FEONAHKMPNE) || !ObscuredBool.FNIPJFGEFFD(BCCOHOIIGPP) || !ObscuredBool.FNIPJFGEFFD(EMIEPBFBJBB)) ? new Ray(hBPPDOGCFKM.FMAHAOKDPJI.origin, hBPPDOGCFKM.FMAHAOKDPJI.direction + (ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.staticAccuraty) + ObscuredFloat.FNIPJFGEFFD((!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.FEONAHKMPNE)) ? FLGDGHPCNDK.staticRunAccuraty : ObscuredFloat.FNIPJFGEFFD(0f))) * UnityEngine.Random.insideUnitSphere) : hBPPDOGCFKM.FMAHAOKDPJI);
				if (UnityEngine.Random.value > 0.7f || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.FGEGAEBIMID) || FOGIOGKLNIP.LMMFHEODOPM.IDNIJGEJJKH)
				{
					GEMPBPLEFAE(cNLIBCONPFE.PCHDGCKMHKC);
				}
				if (!FOGIOGKLNIP.DGMBIMMABNO || ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) || ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
				{
					if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.FGEGAEBIMID))
					{
						StartCoroutine(IIFGFLBJDIN(cNLIBCONPFE.PCHDGCKMHKC));
					}
					else
					{
						DOJNPCJDIOB(cNLIBCONPFE.PCHDGCKMHKC);
					}
					if (!FOGIOGKLNIP.LPLJMLGKCLK.LHLPDGMPKCG)
					{
						StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(new WaitForSeconds(0.1f), cNLIBCONPFE.BEKJDJFLJJC));
					}
				}
			}
			if ((ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && FOGIOGKLNIP.NGFDFPGNDCJ.NMJOJEDEJBO != null && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.MGJPMGGABLN) && JNKBMKOCPPL != null) || (EKMIDOBFFAG != null && BFKPMGIIKEL != null))
			{
				BDODDNEKDEO();
			}
		}
		HCKBKGINDPI = Mathf.Min(HCKBKGINDPI + ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.shootCursor), ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.shootCursorMax));
	}

	private void DOJNPCJDIOB(Ray FMAHAOKDPJI)
	{
		JECEBKMEHMH jECEBKMEHMH = new JECEBKMEHMH();
		jECEBKMEHMH.OOIJMCFMDHN = FMAHAOKDPJI.origin;
		jECEBKMEHMH.BADIHIKMKJF = FMAHAOKDPJI.direction;
		DOJNPCJDIOB(200f, jECEBKMEHMH);
	}

	private bool DOJNPCJDIOB(float NINDANMNGPD, JECEBKMEHMH DDHGAEFFFOI)
	{
		foreach (RaycastHit item in COHNFNBJBDN(new Ray(DDHGAEFFFOI.OOIJMCFMDHN, DDHGAEFFFOI.BADIHIKMKJF), NINDANMNGPD, 335813888))
		{
			Transform transform = item.transform;
			Transform root = transform.root;
			if (transform.tag == "Destroyable" && transform.GetComponent<Animation>() != null)
			{
				transform.GetComponent<Animation>().Play();
				if (transform.GetComponent<Collider>() != null)
				{
					transform.GetComponent<Collider>().enabled = false;
				}
				return true;
			}
			IKGLMHJAOGB layer = (IKGLMHJAOGB)item.collider.gameObject.layer;
			bool flag = layer == IKGLMHJAOGB.JOIJIECIMOH || layer == IKGLMHJAOGB.PMDPIINLPHK || layer == IKGLMHJAOGB.BEMALDLIIMN;
			int layerMask = 268698624;
			if (layer == IKGLMHJAOGB.FDGPLHOFOEN || flag)
			{
				RaycastHit? fDEFKLBMPJL = DDHGAEFFFOI.FDEFKLBMPJL;
				if (fDEFKLBMPJL.HasValue)
				{
					if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.MDDBCIILKHG))
					{
						return true;
					}
					RaycastHit hitInfo;
					if (Physics.Raycast(item.point, DDHGAEFFFOI.BADIHIKMKJF * -1f, out hitInfo, 100f, layerMask))
					{
						float magnitude = (DDHGAEFFFOI.FDEFKLBMPJL.Value.point - hitInfo.point).magnitude;
						DDHGAEFFFOI.HEJLMDDPNBC += magnitude;
						if (DDHGAEFFFOI.HEJLMDDPNBC > (float)IOKJADJOLIJ)
						{
							return true;
						}
						DDHGAEFFFOI.HEJLMDDPNBC += 3f;
						EHGILPJPBGI(hitInfo);
					}
				}
				else if (KAMAMHFJDGG && Physics.Raycast(item.point, DDHGAEFFFOI.BADIHIKMKJF * -1f, item.distance, layerMask))
				{
					return true;
				}
			}
			if (flag && FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL && FOGIOGKLNIP.EDBEJGJJDDA++ < base.EGPFOCNKAKB)
			{
				FOGIOGKLNIP.PIOANBBCFFP.DDOFLINNNOB(item);
				EHGILPJPBGI(item);
				FOGIOGKLNIP.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Bulletric, item.point, true, 0.1f, 1f, 1f);
			}
			PMDPIINLPHK componentInParrent = transform.GetComponentInParrent<PMDPIINLPHK>();
			if (componentInParrent != null && KAMAMHFJDGG && componentInParrent.JGECOECAJLK != NJEPMOIDJKH.BJDCCKHBENA.JGECOECAJLK)
			{
				componentInParrent.NCHOPAEKPBK(componentInParrent.PLEKGNIKPEH, componentInParrent.BHFDJDDGHKA - (int)((float)ObscuredInt.FNIPJFGEFFD(BKENMJFCFJI) * ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL)) ? 1f : 0.2f)), item.point);
				DDHGAEFFFOI.HEJLMDDPNBC += 5f;
			}
			if (flag)
			{
				DDHGAEFFFOI.FDEFKLBMPJL = item;
			}
			if (layer != IKGLMHJAOGB.FDGPLHOFOEN && layer != IKGLMHJAOGB.JGEBCFFCMOE)
			{
				continue;
			}
			KKJBDENNKGF component = root.GetComponent<KKJBDENNKGF>();
			if (!(component != null))
			{
				continue;
			}
			try
			{
				if (component == NJEPMOIDJKH || item.collider is CharacterController || ((component.BJDCCKHBENA.JGECOECAJLK == NJEPMOIDJKH.BJDCCKHBENA.JGECOECAJLK || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE)) && (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE) || ObscuredBool.FNIPJFGEFFD(component.BJDCCKHBENA.CMGBAIJNMEH)) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.MGDGJKCGHII)))
				{
					continue;
				}
				goto IL_03e0;
			}
			catch (Exception)
			{
				goto IL_03e0;
			}
			IL_03e0:
			bool flag2 = false;
			if (!DENGEAMLDGF(component).IntersectRay(new Ray(DDHGAEFFFOI.OOIJMCFMDHN, DDHGAEFFFOI.BADIHIKMKJF)))
			{
				flag2 = true;
			}
			if ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IHNHCNGJKIK) && flag2) || NGCHFCOBBNH(component))
			{
				continue;
			}
			if (KAMAMHFJDGG)
			{
				int num = IFHGMCKAKEC(ObscuredInt.FNIPJFGEFFD(BKENMJFCFJI), component, FBGNKPPMENN, NJEPMOIDJKH.BJDCCKHBENA) / FLGDGHPCNDK.DivideDamage;
				if ((item.point - base.ELGIKGAIIOD).magnitude > ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.Range))
				{
					num /= 2;
				}
				if (flag2)
				{
					num /= 3;
				}
				if (base.JNPCOJFBJGP && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && UnityEngine.Random.value > ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.HDGCFPAMGKE) * 3f)
				{
					return true;
				}
				if (!ObscuredBool.FNIPJFGEFFD(component.BJDCCKHBENA.HIBLODEGHAK) && ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.BJDCCKHBENA.HIBLODEGHAK))
				{
					num = (int)((float)num * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.HDGCFPAMGKE));
				}
				if (DDHGAEFFFOI.HEJLMDDPNBC != 0f)
				{
					num = (int)((float)num * ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.WallThroughFactor));
				}
				DDHGAEFFFOI.HEJLMDDPNBC += 3f;
				ObscuredFloat eHAPKEKPMOE = ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GOMHFBFGHBI) && !(this is FACHOPPILGM)) ? FLGDGHPCNDK.headDamageFactor : ObscuredFloat.FNIPJFGEFFD(1f));
				if (!(component is MBFCGOPGCLP))
				{
					Collider[] dFANPPDHPKL = component.DFANPPDHPKL;
					foreach (Collider collider in dFANPPDHPKL)
					{
						collider.enabled = true;
						RaycastHit hitInfo2;
						if (collider.Raycast(new Ray(DDHGAEFFFOI.OOIJMCFMDHN, DDHGAEFFFOI.BADIHIKMKJF), out hitInfo2, 1000f))
						{
							FOGIOGKLNIP.PIOANBBCFFP.INNBPKJCELB(hitInfo2);
							FOGIOGKLNIP.CIEBMCOJGCC.BHHEOGIMOLJ = Time.time;
							if (ObscuredString.JHLIPNMGNGC(ObscuredString.FNIPJFGEFFD(collider.tag), FOGIOGKLNIP.LPLJMLGKCLK.BAJMNNGLLPG))
							{
								component.GGNFHJCPCBK(-(int)((float)num * ObscuredFloat.FNIPJFGEFFD(eHAPKEKPMOE)), NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN, 1);
								if (NJEPMOIDJKH == FOGIOGKLNIP.NMGDHKIKCED && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
								{
									NJEPMOIDJKH.BJDCCKHBENA.GCLAPAMJCHG = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(NJEPMOIDJKH.BJDCCKHBENA.GCLAPAMJCHG) + 1);
								}
							}
							if (ObscuredString.JHLIPNMGNGC(ObscuredString.FNIPJFGEFFD(collider.tag), FOGIOGKLNIP.LPLJMLGKCLK.EFHKDJENFGF))
							{
								float num2 = (float)num * ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.handDamageFactor);
								component.GGNFHJCPCBK(-(int)num2, NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN);
							}
							if (ObscuredString.JHLIPNMGNGC(ObscuredString.FNIPJFGEFFD(collider.tag), FOGIOGKLNIP.LPLJMLGKCLK.CMGNHPKMAEH))
							{
								float num3 = (float)num * ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.TorsoDamageFactor);
								component.GGNFHJCPCBK(-(int)num3, NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN);
							}
							if (ObscuredString.JHLIPNMGNGC(ObscuredString.FNIPJFGEFFD(collider.tag), FOGIOGKLNIP.LPLJMLGKCLK.MOAJNIGKHND))
							{
								float num4 = (float)num * ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.LegsDamageFactor);
								component.GGNFHJCPCBK(-(int)num4, NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN);
							}
							else
							{
								component.GGNFHJCPCBK(-num, NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN);
							}
							collider.enabled = false;
							break;
						}
						collider.enabled = false;
					}
					continue;
				}
				FOGIOGKLNIP.PIOANBBCFFP.INNBPKJCELB(item);
				component.OKNKADHMJAJ.GetComponent<Collider>().enabled = true;
				RaycastHit hitInfo3;
				if (component.OKNKADHMJAJ.GetComponent<Collider>().Raycast(new Ray(DDHGAEFFFOI.OOIJMCFMDHN, DDHGAEFFFOI.BADIHIKMKJF), out hitInfo3, 1000f))
				{
					component.GGNFHJCPCBK(-(int)((float)num * ObscuredFloat.FNIPJFGEFFD(eHAPKEKPMOE)), NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN, 1);
					if (NJEPMOIDJKH == FOGIOGKLNIP.NMGDHKIKCED && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
					{
						NJEPMOIDJKH.BJDCCKHBENA.GCLAPAMJCHG = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(NJEPMOIDJKH.BJDCCKHBENA.GCLAPAMJCHG) + 1);
					}
				}
				else
				{
					component.GGNFHJCPCBK(-num, NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN);
				}
				component.OKNKADHMJAJ.GetComponent<Collider>().enabled = false;
			}
			else
			{
				FOGIOGKLNIP.PIOANBBCFFP.INNBPKJCELB(item);
			}
		}
		return false;
	}

	private void JJKAHMFBHDP(KKJBDENNKGF FGLJAKDJFBE, int NIKCLNGCOHL, int GFGPMFOMAKN)
	{
		if (FGLJAKDJFBE != null)
		{
			if (GFGPMFOMAKN != 0)
			{
				FGLJAKDJFBE.GGNFHJCPCBK(-NIKCLNGCOHL, NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN, (byte)GFGPMFOMAKN);
			}
			else
			{
				FGLJAKDJFBE.GGNFHJCPCBK(-NIKCLNGCOHL, NJEPMOIDJKH.BJDCCKHBENA, (byte)FBGNKPPMENN);
			}
		}
	}

	public void BDODDNEKDEO()
	{
		if (ObscuredBool.FNIPJFGEFFD(EMIEPBFBJBB) && (!ADMHKBHIKLG || ADMHKBHIKLG) && ObscuredBool.FNIPJFGEFFD(BCCOHOIIGPP) && (double)ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.shootTime) > 0.9 && KAMAMHFJDGG && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
		{
			EJCOGJOCEFF = GNOBBODJHNF;
			NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.GOPIBMLFMBC, 2);
		}
		if (!OGLMKDFNMKC && base.AHCGBDNLKEO)
		{
			OCFONJIEDJO = true;
		}
		if (!OCFONJIEDJO)
		{
			if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.PlayQueued(JNKBMKOCPPL.name, QueueMode.PlayNow);
			}
		}
		else if (BBKKINKGGIC)
		{
			BBKKINKGGIC = false;
			FNDJENIEFJJ = true;
			if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.PlayQueued(BFKPMGIIKEL.name, QueueMode.PlayNow);
			}
		}
		else if (FNDJENIEFJJ)
		{
			BBKKINKGGIC = true;
			FNDJENIEFJJ = false;
			if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.PlayQueued(EKMIDOBFFAG.name, QueueMode.PlayNow);
			}
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Stop(OADKFGNCGMP.name);
		}
	}

	[DebuggerHidden]
	private IEnumerator IIFGFLBJDIN(Ray CDHLCJDFGDA)
	{
		PBFGCELHLAA pBFGCELHLAA = new PBFGCELHLAA();
		pBFGCELHLAA.CDHLCJDFGDA = CDHLCJDFGDA;
		pBFGCELHLAA.KPHCHDHEKGH = this;
		return pBFGCELHLAA;
	}

	public Quaternion JNIDFLJPPIO()
	{
		return NJEPMOIDJKH.GGBCAOAGPPM.rotation;
	}

	public void FJABFJDIEIF(Quaternion FGAODIIEHDO)
	{
		NJEPMOIDJKH.GGBCAOAGPPM.localRotation = Quaternion.Euler(FGAODIIEHDO.x, FGAODIIEHDO.y, FGAODIIEHDO.z);
	}

	public void ILLCLOOGDEH(float PPFCCPBHLGD, float BBBKCJKPIHO, float OOOFHFNDFGO, float GOCOBGIMPDI, float EBGICALGJAN, float EBKOGBODEFH, int NCDMIOKPJCK)
	{
		float num;
		float num2;
		if ((int)HCKBKGINDPI == 1)
		{
			num = PPFCCPBHLGD;
			num2 = BBBKCJKPIHO;
		}
		else
		{
			num = PPFCCPBHLGD + (float)(int)HCKBKGINDPI * OOOFHFNDFGO;
			num2 = BBBKCJKPIHO + (float)(int)HCKBKGINDPI * GOCOBGIMPDI;
		}
		Quaternion fGAODIIEHDO = JNIDFLJPPIO();
		fGAODIIEHDO.x -= num;
		if (fGAODIIEHDO.x < -1f * EBGICALGJAN)
		{
			fGAODIIEHDO.x = -1f * EBGICALGJAN;
		}
		if (DFCGJIBGBIP == 1)
		{
			fGAODIIEHDO.y += num2;
			if (fGAODIIEHDO.y > EBKOGBODEFH)
			{
				fGAODIIEHDO.y = EBKOGBODEFH;
			}
		}
		else
		{
			fGAODIIEHDO.y -= num2;
			if (fGAODIIEHDO.y < -1f * EBKOGBODEFH)
			{
				fGAODIIEHDO.y = -1f * EBKOGBODEFH;
			}
		}
		if (UnityEngine.Random.Range(0, NCDMIOKPJCK) <= 0)
		{
			DFCGJIBGBIP = 1 - DFCGJIBGBIP;
		}
		FJABFJDIEIF(fGAODIIEHDO);
	}

	[RPC]
	public override void EPADPNIJNNJ()
	{
		base.EPADPNIJNNJ();
	}

	[RPC]
	public override void ELNKLGHNLEP(bool JFLFLCDEEEI)
	{
		base.ELNKLGHNLEP(JFLFLCDEEEI);
	}

	[RPC]
	public override void LKDPJIEAPIF(bool FFBEPGEKANM)
	{
		base.LKDPJIEAPIF(FFBEPGEKANM);
	}

	[RPC]
	public override void GOPIBMLFMBC(int EHAPKEKPMOE)
	{
		base.GOPIBMLFMBC(EHAPKEKPMOE);
	}

	public override void PIALCLIEKDB()
	{
		if (NJEPMOIDJKH.IAALHLCLAOD && ((!MJCFBFOMBNA && this is FACHOPPILGM && !GMLKEKBDLAJ) || (!OBPLDGGKLOJ && ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) != ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) && LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP) > 0 && !ObscuredBool.FNIPJFGEFFD(DGECFCEDDGB))))
		{
			NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.ODMGBBKGLOD);
		}
	}

	[RPC]
	public override void DONIMNAJJIB()
	{
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Stop();
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.CrossFade("after_reload");
			GMLKEKBDLAJ = false;
		}
	}

	[RPC]
	public override void PCLEFKOPNCJ()
	{
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Stop();
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.CrossFade("start_reload");
			StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(ObscuredFloat.FNIPJFGEFFD(MBPLCJKIDCA.Time), delegate
			{
				JHKBOHNABHK = 1;
			}));
		}
	}

	[RPC]
	public override void ODMGBBKGLOD()
	{
		if (!BCEBFDPCLIA)
		{
			return;
		}
		if (KAMAMHFJDGG && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) && ObscuredBool.FNIPJFGEFFD(EMIEPBFBJBB))
		{
			EJCOGJOCEFF = GNOBBODJHNF;
			NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.GOPIBMLFMBC, 2);
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			if (this is FACHOPPILGM)
			{
				if (FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM[OADKFGNCGMP.name] != null)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM[OADKFGNCGMP.name].speed = ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.handsReloadSpeed) * 1.3f;
				}
			}
			else if (FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM[OADKFGNCGMP.name] != null)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM[OADKFGNCGMP.name].speed = ObscuredFloat.FNIPJFGEFFD(FLGDGHPCNDK.handsReloadSpeed);
			}
		}
		AMNOHEEAFPD = ObscuredFloat.FNIPJFGEFFD(Time.time);
		EMIEPBFBJBB = ObscuredBool.FNIPJFGEFFD(false);
		if (NJEPMOIDJKH == FOGIOGKLNIP.NMGDHKIKCED)
		{
			EMIEPBFBJBB = ObscuredBool.FNIPJFGEFFD(false);
		}
		if (KAMAMHFJDGG)
		{
			if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
			{
				float num = ObscuredFloat.FNIPJFGEFFD(ILEPKAHGJFG.Time);
				num = ((!(this is FACHOPPILGM)) ? (num * 0.9f) : (num * 1.1f));
				if (!(this is FACHOPPILGM))
				{
					StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(num, delegate
					{
						int num3 = Mathf.Min(ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) - ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD), LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP));
						base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) + num3);
						if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.NBFGNGGJDNB) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
						{
							LMJDOOEODJK.NKOHBFHAELH(NNBDEKBINFP, -num3);
						}
					}));
				}
				StartCoroutine(EAHNBBENHFD());
			}
			else
			{
				float num2 = ObscuredFloat.FNIPJFGEFFD(ILEPKAHGJFG.Time);
				num2 = ((!(this is FACHOPPILGM)) ? (num2 * 0.9f) : (num2 * 1.1f));
				StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(num2, delegate
				{
					if (this is FACHOPPILGM)
					{
						if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) < ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) && LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP) > 0)
						{
							base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) + 1);
							if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.NBFGNGGJDNB) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
							{
								LMJDOOEODJK.NKOHBFHAELH(NNBDEKBINFP, -1);
							}
						}
						if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) < ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) && LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP) > 0 && !FOGIOGKLNIP.CNIAIOJACDA)
						{
							NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.ODMGBBKGLOD);
						}
						else
						{
							NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.DONIMNAJJIB);
						}
					}
					else
					{
						int num3 = Mathf.Min(ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) - ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD), LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP));
						base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) + num3);
						if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.NBFGNGGJDNB) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
						{
							LMJDOOEODJK.NKOHBFHAELH(NNBDEKBINFP, -num3);
						}
					}
				}));
			}
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && !(this is FACHOPPILGM))
		{
			FMMAKOLBPBL();
		}
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.CBBMOOPHDHM))
		{
			NJEPMOIDJKH.GCNMEJLGIOE.CrossFade(IANBJADJBPL);
		}
		NJEPMOIDJKH.MEKBDDDHJFO = ObscuredBool.FNIPJFGEFFD(false);
	}

	[DebuggerHidden]
	public IEnumerator EAHNBBENHFD()
	{
		GDJFNCEEEFC gDJFNCEEEFC = new GDJFNCEEEFC();
		gDJFNCEEEFC.KPHCHDHEKGH = this;
		return gDJFNCEEEFC;
	}

	[RPC]
	public override void CHEOEJNGLFP(bool EHAPKEKPMOE)
	{
		if (EHAPKEKPMOE)
		{
			BMOICBJLLDP = Time.time;
			DGLPPHEALII = 0f;
		}
		base.CHEOEJNGLFP(EHAPKEKPMOE);
	}

	[CompilerGenerated]
	private void HEGMEJKGCHH()
	{
		JHKBOHNABHK = 1;
	}

	[CompilerGenerated]
	private void CHEPPHKMJMA()
	{
		int num = Mathf.Min(ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) - ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD), LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP));
		base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) + num);
		if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.NBFGNGGJDNB) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
		{
			LMJDOOEODJK.NKOHBFHAELH(NNBDEKBINFP, -num);
		}
	}

	[CompilerGenerated]
	private void CNFLNBOCPDN()
	{
		if (this is FACHOPPILGM)
		{
			if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) < ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) && LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP) > 0)
			{
				base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) + 1);
				if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.NBFGNGGJDNB) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
				{
					LMJDOOEODJK.NKOHBFHAELH(NNBDEKBINFP, -1);
				}
			}
			if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) < ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) && LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP) > 0 && !FOGIOGKLNIP.CNIAIOJACDA)
			{
				NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.ODMGBBKGLOD);
			}
			else
			{
				NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.DONIMNAJJIB);
			}
		}
		else
		{
			int num = Mathf.Min(ObscuredInt.FNIPJFGEFFD(ABHFBECBPBA) - ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD), LMJDOOEODJK.DJEALLIOJEO(NNBDEKBINFP));
			base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) + num);
			if (!ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.NBFGNGGJDNB) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
			{
				LMJDOOEODJK.NKOHBFHAELH(NNBDEKBINFP, -num);
			}
		}
	}
}
