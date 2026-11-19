using System;
using System.Collections;
using TouchControlsKit;
using UnityEngine;

public abstract class JKHKOEPGCPO : JNEFNLEGJMM
{
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

	private IEnumerator KINGEGOPHIB(float GCJJPIAOLGD)
	{
		while (Math.Round(EFMADDOCBDN.value, 2) != Math.Round(GCJJPIAOLGD, 2))
		{
			EFMADDOCBDN.NFFMEMCHELF(Mathf.Lerp(EFMADDOCBDN.value, GCJJPIAOLGD, Time.smoothDeltaTime * PDNDECOLDGE));
			yield return null;
		}
		EFMADDOCBDN.NFFMEMCHELF(GCJJPIAOLGD);
	}

	private IEnumerator DFMNILCFODB(float GCJJPIAOLGD)
	{
		while (Math.Round(EKCJABJKODG.value, 2) != Math.Round(GCJJPIAOLGD, 2))
		{
			EKCJABJKODG.NFFMEMCHELF(Mathf.Lerp(EKCJABJKODG.value, GCJJPIAOLGD, Time.smoothDeltaTime * PDNDECOLDGE));
			yield return null;
		}
		EKCJABJKODG.NFFMEMCHELF(GCJJPIAOLGD);
	}

	protected override void NGCCFMHBKIO()
	{
		base.NGCCFMHBKIO();
		JLHLDODBIJG();
	}
}
