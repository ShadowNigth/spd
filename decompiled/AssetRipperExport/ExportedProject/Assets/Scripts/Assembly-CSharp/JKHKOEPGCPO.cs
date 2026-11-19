using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TouchControlsKit;
using UnityEngine;

public abstract class JKHKOEPGCPO : JNEFNLEGJMM
{
	private sealed class POOLMCMKBKE : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float GCJJPIAOLGD;

		internal JKHKOEPGCPO KPHCHDHEKGH;

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
		public POOLMCMKBKE()
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
				if (Math.Round(KPHCHDHEKGH.EFMADDOCBDN.value, 2) != Math.Round(GCJJPIAOLGD, 2))
				{
					KPHCHDHEKGH.EFMADDOCBDN.NFFMEMCHELF(Mathf.Lerp(KPHCHDHEKGH.EFMADDOCBDN.value, GCJJPIAOLGD, Time.smoothDeltaTime * KPHCHDHEKGH.PDNDECOLDGE));
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				KPHCHDHEKGH.EFMADDOCBDN.NFFMEMCHELF(GCJJPIAOLGD);
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

	private sealed class IFLKKILEIDH : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float GCJJPIAOLGD;

		internal JKHKOEPGCPO KPHCHDHEKGH;

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
		public IFLKKILEIDH()
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
				if (Math.Round(KPHCHDHEKGH.EKCJABJKODG.value, 2) != Math.Round(GCJJPIAOLGD, 2))
				{
					KPHCHDHEKGH.EKCJABJKODG.NFFMEMCHELF(Mathf.Lerp(KPHCHDHEKGH.EKCJABJKODG.value, GCJJPIAOLGD, Time.smoothDeltaTime * KPHCHDHEKGH.PDNDECOLDGE));
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				KPHCHDHEKGH.EKCJABJKODG.NFFMEMCHELF(GCJJPIAOLGD);
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

	[Range(1f, 10f)]
	public float ICKMBHMOHNC = 1f;

	[PNAJLEIJOKM("Lag")]
	public bool ADACLMGGJBL;

	[Range(5f, 25f)]
	public float PDNDECOLDGE = 10f;

	[PNAJLEIJOKM("X - [ Horizontal ]")]
	public Axis EFMADDOCBDN = new Axis();

	[PNAJLEIJOKM("Y - [ Vertical ]")]
	public Axis EKCJABJKODG = new Axis();

	[SerializeField]
	private bool showTouchZone = true;

	protected Vector2 PDHBDFKLGNH;

	protected Vector2 GJEBMIFOOBJ;

	protected Vector2 AEHOJDAMBCN;

	public bool DDICNHNKBHL
	{
		get
		{
			return showTouchZone;
		}
		set
		{
			if (showTouchZone != value)
			{
				showTouchZone = value;
				GNCONFIFGOM();
			}
		}
	}

	[POPCJHCKEFF]
	protected virtual void GNCONFIFGOM()
	{
		OFBMBFLODCF.color = ((!showTouchZone || !visible) ? Color.clear : MOKPACHAJFE(baseImageColor));
	}

	protected override void IPPGADPLAJM()
	{
		if (showTouchZone)
		{
			base.IPPGADPLAJM();
		}
	}

	protected override void NIECBKIMFNO()
	{
		GNCONFIFGOM();
	}

	protected void JLHLDODBIJG()
	{
		AIACCBOBNIN(0f, 0f);
	}

	protected void AIACCBOBNIN(Vector2 JKIBDNELCFM)
	{
		AIACCBOBNIN(JKIBDNELCFM.x, JKIBDNELCFM.y);
	}

	protected void AIACCBOBNIN(float HKCJBFIKALL, float PIFPICMFHAD)
	{
		HKCJBFIKALL = ((!EFMADDOCBDN.inverse) ? HKCJBFIKALL : (0f - HKCJBFIKALL));
		PIFPICMFHAD = ((!EKCJABJKODG.inverse) ? PIFPICMFHAD : (0f - PIFPICMFHAD));
		if (ADACLMGGJBL)
		{
			if (EFMADDOCBDN.enabled)
			{
				StopCoroutine("KINGEGOPHIB");
				StartCoroutine("KINGEGOPHIB", HKCJBFIKALL);
			}
			else
			{
				EFMADDOCBDN.NFFMEMCHELF(0f);
			}
			if (EKCJABJKODG.enabled)
			{
				StopCoroutine("DFMNILCFODB");
				StartCoroutine("DFMNILCFODB", PIFPICMFHAD);
			}
			else
			{
				EKCJABJKODG.NFFMEMCHELF(0f);
			}
		}
		else
		{
			EFMADDOCBDN.NFFMEMCHELF(HKCJBFIKALL);
			EKCJABJKODG.NFFMEMCHELF(PIFPICMFHAD);
		}
	}

	[DebuggerHidden]
	private IEnumerator KINGEGOPHIB(float GCJJPIAOLGD)
	{
		POOLMCMKBKE pOOLMCMKBKE = new POOLMCMKBKE();
		pOOLMCMKBKE.GCJJPIAOLGD = GCJJPIAOLGD;
		pOOLMCMKBKE.KPHCHDHEKGH = this;
		return pOOLMCMKBKE;
	}

	[DebuggerHidden]
	private IEnumerator DFMNILCFODB(float GCJJPIAOLGD)
	{
		IFLKKILEIDH iFLKKILEIDH = new IFLKKILEIDH();
		iFLKKILEIDH.GCJJPIAOLGD = GCJJPIAOLGD;
		iFLKKILEIDH.KPHCHDHEKGH = this;
		return iFLKKILEIDH;
	}

	protected override void NGCCFMHBKIO()
	{
		base.NGCCFMHBKIO();
		JLHLDODBIJG();
	}
}
