using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
[AddComponentMenu("UI/Extensions/Scrollrect Conflict Manager")]
public class MLBNCGPPCGB : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
{
	public ScrollRect AAFGHHBECII;

	private ScrollRect INPHOBHHNFI;

	private bool EALDGOEBKAI;

	private bool DOHMKMCMJNG;

	private void Awake()
	{
		INPHOBHHNFI = GetComponent<ScrollRect>();
		DOHMKMCMJNG = INPHOBHHNFI.vertical;
		if (DOHMKMCMJNG)
		{
			if (INPHOBHHNFI.horizontal)
			{
				Debug.Log("You have added the SecondScrollRect to a scroll view that already has both directions selected");
			}
			if (!AAFGHHBECII.horizontal)
			{
				Debug.Log("The other scroll rect doesnt support scrolling horizontally");
			}
		}
		else if (!AAFGHHBECII.vertical)
		{
			Debug.Log("The other scroll rect doesnt support scrolling vertically");
		}
	}

	public void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		float num = Mathf.Abs(GBOFEMOALII.position.x - GBOFEMOALII.pressPosition.x);
		float num2 = Mathf.Abs(GBOFEMOALII.position.y - GBOFEMOALII.pressPosition.y);
		if (DOHMKMCMJNG)
		{
			if (num > num2)
			{
				EALDGOEBKAI = true;
				INPHOBHHNFI.enabled = false;
				AAFGHHBECII.OnBeginDrag(GBOFEMOALII);
			}
		}
		else if (num2 > num)
		{
			EALDGOEBKAI = true;
			INPHOBHHNFI.enabled = false;
			AAFGHHBECII.OnBeginDrag(GBOFEMOALII);
		}
	}

	public void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		if (EALDGOEBKAI)
		{
			EALDGOEBKAI = false;
			INPHOBHHNFI.enabled = true;
			AAFGHHBECII.OnEndDrag(GBOFEMOALII);
		}
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (EALDGOEBKAI)
		{
			AAFGHHBECII.OnDrag(GBOFEMOALII);
		}
	}
}
