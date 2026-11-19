using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class PMLHECLFIGJ : JKHKOEPGCPO, IPointerUpHandler, IPointerDownHandler, IDragHandler, IPointerEnterHandler, IEventSystemHandler
{
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

	private IEnumerator MELLCABAONH(Vector2 GIDEOJGAFJH)
	{
		for (float num = 0f; num < 0.0025f; num += Time.deltaTime)
		{
			yield return null;
		}
		if (BHCMDCLOFGL)
		{
			DBFCKHHDNAN(GIDEOJGAFJH);
		}
		else
		{
			NGCCFMHBKIO();
		}
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
