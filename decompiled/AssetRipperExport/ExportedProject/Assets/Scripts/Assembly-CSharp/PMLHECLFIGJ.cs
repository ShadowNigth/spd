using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class PMLHECLFIGJ : JKHKOEPGCPO, IPointerUpHandler, IPointerDownHandler, IDragHandler, IPointerEnterHandler, IEventSystemHandler
{
	private sealed class IHDCBDIMCDP : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float FEPIKKJGGIA;

		internal Vector2 GIDEOJGAFJH;

		internal PMLHECLFIGJ KPHCHDHEKGH;

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
		public IHDCBDIMCDP()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				FEPIKKJGGIA = 0f;
				goto IL_005e;
			case 1u:
				FEPIKKJGGIA += Time.deltaTime;
				goto IL_005e;
			default:
				{
					return false;
				}
				IL_005e:
				if (FEPIKKJGGIA < 0.0025f)
				{
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				if (KPHCHDHEKGH.BHCMDCLOFGL)
				{
					KPHCHDHEKGH.DBFCKHHDNAN(GIDEOJGAFJH);
				}
				else
				{
					KPHCHDHEKGH.NGCCFMHBKIO();
				}
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

	private GameObject DJOGEDCEAPL;

	protected override void NIECBKIMFNO()
	{
	}

	protected override void DBFCKHHDNAN(Vector2 FHIGFGMCPPK)
	{
		if (!EFMADDOCBDN.enabled && !EKCJABJKODG.enabled)
		{
			return;
		}
		base.DBFCKHHDNAN(FHIGFGMCPPK);
		if (BHCMDCLOFGL)
		{
			if (EFMADDOCBDN.enabled)
			{
				GJEBMIFOOBJ.x = FHIGFGMCPPK.x;
			}
			if (EKCJABJKODG.enabled)
			{
				GJEBMIFOOBJ.y = FHIGFGMCPPK.y;
			}
			AEHOJDAMBCN = GJEBMIFOOBJ - PDHBDFKLGNH;
			float num = Vector2.Distance(PDHBDFKLGNH, GJEBMIFOOBJ) * 2f;
			PDHBDFKLGNH = GJEBMIFOOBJ;
			AIACCBOBNIN(AEHOJDAMBCN.normalized * num / 100f * ICKMBHMOHNC);
		}
		else
		{
			BHCMDCLOFGL = true;
			MNAANMAOECP = IJCCPIAIFDJ.PDNIPNGGDGC;
			GJEBMIFOOBJ = (PDHBDFKLGNH = FHIGFGMCPPK);
			DBFCKHHDNAN(FHIGFGMCPPK);
			JLHLDODBIJG();
		}
	}

	public void OnPointerEnter(PointerEventData MOCIGEGKFHL)
	{
		if (MOCIGEGKFHL.pointerPress == null)
		{
			return;
		}
		if (MOCIGEGKFHL.pointerPress == base.gameObject)
		{
			OnPointerDown(MOCIGEGKFHL);
			return;
		}
		BACLJEFBAMJ component = MOCIGEGKFHL.pointerPress.GetComponent<BACLJEFBAMJ>();
		if (component != null && component.FDCGDOMLAGH)
		{
			DJOGEDCEAPL = MOCIGEGKFHL.pointerPress;
			MOCIGEGKFHL.pointerDrag = base.gameObject;
			MOCIGEGKFHL.pointerPress = base.gameObject;
			OnPointerDown(MOCIGEGKFHL);
		}
	}

	public void OnPointerDown(PointerEventData MOCIGEGKFHL)
	{
		if (!BHCMDCLOFGL)
		{
			EMDIGKNNNNK = MOCIGEGKFHL.pointerId;
			DBFCKHHDNAN(MOCIGEGKFHL.position);
		}
	}

	public void OnDrag(PointerEventData MOCIGEGKFHL)
	{
		if (Input.touchCount >= EMDIGKNNNNK && BHCMDCLOFGL)
		{
			DBFCKHHDNAN(MOCIGEGKFHL.position);
			StopCoroutine("MELLCABAONH");
			StartCoroutine("MELLCABAONH", MOCIGEGKFHL.position);
		}
	}

	[DebuggerHidden]
	private IEnumerator MELLCABAONH(Vector2 GIDEOJGAFJH)
	{
		IHDCBDIMCDP iHDCBDIMCDP = new IHDCBDIMCDP();
		iHDCBDIMCDP.GIDEOJGAFJH = GIDEOJGAFJH;
		iHDCBDIMCDP.KPHCHDHEKGH = this;
		return iHDCBDIMCDP;
	}

	public void OnPointerUp(PointerEventData MOCIGEGKFHL)
	{
		if (DJOGEDCEAPL != null)
		{
			ExecuteEvents.Execute(DJOGEDCEAPL, MOCIGEGKFHL, ExecuteEvents.pointerUpHandler);
			DJOGEDCEAPL = null;
		}
		NGCCFMHBKIO();
	}
}
