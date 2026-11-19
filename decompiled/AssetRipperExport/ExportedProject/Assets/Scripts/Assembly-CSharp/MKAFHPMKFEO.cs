using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CodeStage.AntiCheat.ObscuredTypes;
using SPD.Audio;
using UnityEngine;

public class MKAFHPMKFEO : FOGIOGKLNIP
{
	private sealed class EMGLNAGAJBN : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal MKAFHPMKFEO KPHCHDHEKGH;

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
		public EMGLNAGAJBN()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				HLJEEFIJCOF = new WaitForSeconds(ObscuredFloat.FNIPJFGEFFD(KPHCHDHEKGH.NMEHFOFKEAE));
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				break;
			case 1u:
				KPHCHDHEKGH.JNHLCLCIPPJ.intensity = 1.56f;
				KPHCHDHEKGH.LEDCIPHCLEB(KPHCHDHEKGH.FALBAHFLMOI);
				HLJEEFIJCOF = new WaitForSeconds(0.1f);
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 2;
				}
				break;
			case 2u:
				KPHCHDHEKGH.JNHLCLCIPPJ.intensity = 0f;
				goto case 0u;
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

	public BankEntry FALBAHFLMOI;

	public BankEntry LFKLLILJLIH;

	public BankEntry DLIHELFCGCK;

	public BankEntry FAGOPCEFGJD;

	public BankEntry MEGIICIMILC;

	public BankEntry PMBJMLDNODH;

	public string PFOOKKOIPLM;

	public string LJFCKMMEJKN;

	public MeshFilter GAJGBAGAJLA;

	public MeshRenderer LNMHOBPJCGJ;

	public Light JNHLCLCIPPJ;

	public ObscuredBool BJLFIDLJNAH = ObscuredBool.FNIPJFGEFFD(false);

	internal ObscuredFloat NMEHFOFKEAE = ObscuredFloat.FNIPJFGEFFD(0.75f);

	public void Start()
	{
		JPBIAJIBLCG(PFOOKKOIPLM, LJFCKMMEJKN, GAJGBAGAJLA, LNMHOBPJCGJ);
		GameSoundsObject hLEOCDKAKMJ = FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ;
		JNHLCLCIPPJ = GetComponent<Light>();
		FALBAHFLMOI = hLEOCDKAKMJ.Pip;
		LFKLLILJLIH = hLEOCDKAKMJ.Explode;
		DLIHELFCGCK = hLEOCDKAKMJ.Difuse;
		FAGOPCEFGJD = hLEOCDKAKMJ.DifuseRadio;
		MEGIICIMILC = hLEOCDKAKMJ.BombPlanted;
		PMBJMLDNODH = hLEOCDKAKMJ.BombPlant;
		FOGIOGKLNIP.PIOANBBCFFP.LEDCIPHCLEB(MEGIICIMILC);
		LEDCIPHCLEB(PMBJMLDNODH);
		FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("Bomb has been planted", true);
		FOGIOGKLNIP.PIOANBBCFFP.JLFMGNFDGCK.Add(this);
		StartCoroutine(CDINBIGPDEJ());
	}

	public void OnDestroy()
	{
		if (!FOGIOGKLNIP.CJOGLBBCDEC)
		{
			FOGIOGKLNIP.PIOANBBCFFP.JLFMGNFDGCK.Remove(this);
		}
	}

	public void Update()
	{
		if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.OPKDMODBFGA) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.BOOJPIJMOEL))
		{
			NMEHFOFKEAE = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(NMEHFOFKEAE) - Time.deltaTime / 60f);
			if (KAMAMHFJDGG && ObscuredFloat.FNIPJFGEFFD(NMEHFOFKEAE) < 0f)
			{
				KIKEOPPIKNP();
			}
		}
	}

	[DebuggerHidden]
	public IEnumerator CDINBIGPDEJ()
	{
		EMGLNAGAJBN eMGLNAGAJBN = new EMGLNAGAJBN();
		eMGLNAGAJBN.KPHCHDHEKGH = this;
		return eMGLNAGAJBN;
	}

	public void KIKEOPPIKNP()
	{
		NCHOPAEKPBK(CHDLHLJEAKP);
		APAMPKPNIPC();
	}

	[RPC]
	private void CHDLHLJEAKP()
	{
		FOGIOGKLNIP.NGFDFPGNDCJ.LEDCIPHCLEB(LFKLLILJLIH);
		FOGIOGKLNIP.PIOANBBCFFP.OPKDMODBFGA = ObscuredBool.FNIPJFGEFFD(true);
		if (FOGIOGKLNIP.NMGDHKIKCED != null && (FOGIOGKLNIP.NMGDHKIKCED.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 5f)
		{
			FOGIOGKLNIP.NMGDHKIKCED.KNOEPICGNLK();
		}
		JMJLEDGJIJK("BigExplode", "Particles/", true, null, null, base.ELGIKGAIIOD, Quaternion.identity);
		foreach (JDILMODHLOJ item in FOGIOGKLNIP.PIOANBBCFFP.LDAKBEMPLEB)
		{
			if (item.JGECOECAJLK == GNMHJEPNHDL.Terrorists)
			{
				item.FBBDIENBDGM(1000);
			}
		}
	}

	public void NNKNOMCFFAL()
	{
		FOGIOGKLNIP.PIOANBBCFFP.MOAOGLECILB();
		NCHOPAEKPBK(DKLONEAPFHJ);
		APAMPKPNIPC();
	}

	[RPC]
	public void DKLONEAPFHJ()
	{
		FOGIOGKLNIP.NGFDFPGNDCJ.LEDCIPHCLEB(FAGOPCEFGJD);
		LEDCIPHCLEB(DLIHELFCGCK);
		FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("Bomb has been defused");
		FOGIOGKLNIP.PIOANBBCFFP.BOOJPIJMOEL = ObscuredBool.FNIPJFGEFFD(true);
	}
}
