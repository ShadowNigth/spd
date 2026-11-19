using UnityEngine;
using UnityEngine.EventSystems;

public class LKEBPANBIEG : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
{
	internal GCOMJHICFAB AKLDKAGIIFG;

	public void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		HOGOJEEBNOH();
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		AKLDKAGIIFG.PKKJBIDEMBH();
	}

	public void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		DJJPDOHOBEP();
	}

	public void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		HOGOJEEBNOH();
	}

	public void OnPointerUp(PointerEventData GBOFEMOALII)
	{
		DJJPDOHOBEP();
	}

	private void HOGOJEEBNOH()
	{
		if (AKLDKAGIIFG != null)
		{
			AKLDKAGIIFG.LKLOHLPDNLN(EHAPKEKPMOE: false);
			AKLDKAGIIFG.PLLNMOCPMDJ();
		}
	}

	private void DJJPDOHOBEP()
	{
		AKLDKAGIIFG.LKLOHLPDNLN(EHAPKEKPMOE: true);
		AKLDKAGIIFG.BGADMPCBOHJ(AKLDKAGIIFG.PKKJBIDEMBH());
	}
}
