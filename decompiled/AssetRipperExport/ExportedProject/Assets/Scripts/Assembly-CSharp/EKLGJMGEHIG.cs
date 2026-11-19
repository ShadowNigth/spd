using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("UI/Extensions/RescalePanels/RescaleDragPanel")]
public class EKLGJMGEHIG : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
{
	private Vector2 EFNGOBJJCOH;

	private RectTransform DCJAIAIPIKM;

	private RectTransform MCHOLNOCPMK;

	private Transform FCIDHFNMEPD;

	private void Awake()
	{
		Canvas componentInParent = GetComponentInParent<Canvas>();
		if (componentInParent != null)
		{
			DCJAIAIPIKM = componentInParent.transform as RectTransform;
			MCHOLNOCPMK = base.transform.parent as RectTransform;
			FCIDHFNMEPD = base.transform.parent;
		}
	}

	public void OnPointerDown(PointerEventData PMPJLBPPCMF)
	{
		MCHOLNOCPMK.SetAsLastSibling();
		RectTransformUtility.ScreenPointToLocalPointInRectangle(MCHOLNOCPMK, PMPJLBPPCMF.position, PMPJLBPPCMF.pressEventCamera, out EFNGOBJJCOH);
	}

	public void OnDrag(PointerEventData PMPJLBPPCMF)
	{
		if (!(MCHOLNOCPMK == null))
		{
			Vector2 screenPoint = EGMBBOBGDNC(PMPJLBPPCMF);
			Vector2 localPoint;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(DCJAIAIPIKM, screenPoint, PMPJLBPPCMF.pressEventCamera, out localPoint))
			{
				MCHOLNOCPMK.localPosition = localPoint - new Vector2(EFNGOBJJCOH.x * FCIDHFNMEPD.localScale.x, EFNGOBJJCOH.y * FCIDHFNMEPD.localScale.y);
			}
		}
	}

	private Vector2 EGMBBOBGDNC(PointerEventData PMPJLBPPCMF)
	{
		Vector2 position = PMPJLBPPCMF.position;
		Vector3[] array = new Vector3[4];
		DCJAIAIPIKM.GetWorldCorners(array);
		float x = Mathf.Clamp(position.x, array[0].x, array[2].x);
		float y = Mathf.Clamp(position.y, array[0].y, array[2].y);
		return new Vector2(x, y);
	}
}
