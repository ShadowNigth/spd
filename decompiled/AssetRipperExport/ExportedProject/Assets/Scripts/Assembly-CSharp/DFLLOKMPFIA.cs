using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/MultiTouchScrollRect")]
public class DFLLOKMPFIA : ScrollRect
{
	private int IOJMMDEEHGG = -100;

	public override void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		IOJMMDEEHGG = GBOFEMOALII.pointerId;
		base.OnBeginDrag(GBOFEMOALII);
	}

	public override void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (IOJMMDEEHGG == GBOFEMOALII.pointerId)
		{
			base.OnDrag(GBOFEMOALII);
		}
	}

	public override void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		IOJMMDEEHGG = -100;
		base.OnEndDrag(GBOFEMOALII);
	}
}
