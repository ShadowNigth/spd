using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("UI/Extensions/RescalePanels/ResizePanel")]
public class LKKFMIOAJOJ : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
{
	public Vector2 FKEBKFMHIMN;

	public Vector2 MMJJDDGGAEB;

	private RectTransform GEINAHMAFAM;

	private Vector2 IDFOGDNOMHH;

	private Vector2 FNAPLLCAMGP;

	private float BGICDOEPGHL;

	private void Awake()
	{
		GEINAHMAFAM = base.transform.parent.GetComponent<RectTransform>();
		float width = GEINAHMAFAM.rect.width;
		float height = GEINAHMAFAM.rect.height;
		BGICDOEPGHL = height / width;
		FKEBKFMHIMN = new Vector2(0.1f * width, 0.1f * height);
		MMJJDDGGAEB = new Vector2(10f * width, 10f * height);
	}

	public void OnPointerDown(PointerEventData PMPJLBPPCMF)
	{
		GEINAHMAFAM.SetAsLastSibling();
		RectTransformUtility.ScreenPointToLocalPointInRectangle(GEINAHMAFAM, PMPJLBPPCMF.position, PMPJLBPPCMF.pressEventCamera, out FNAPLLCAMGP);
	}

	public void OnDrag(PointerEventData PMPJLBPPCMF)
	{
		if (!(GEINAHMAFAM == null))
		{
			Vector2 sizeDelta = GEINAHMAFAM.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(GEINAHMAFAM, PMPJLBPPCMF.position, PMPJLBPPCMF.pressEventCamera, out IDFOGDNOMHH);
			Vector2 vector = IDFOGDNOMHH - FNAPLLCAMGP;
			sizeDelta += new Vector2(vector.x, BGICDOEPGHL * vector.x);
			sizeDelta = new Vector2(Mathf.Clamp(sizeDelta.x, FKEBKFMHIMN.x, MMJJDDGGAEB.x), Mathf.Clamp(sizeDelta.y, FKEBKFMHIMN.y, MMJJDDGGAEB.y));
			GEINAHMAFAM.sizeDelta = sizeDelta;
			FNAPLLCAMGP = IDFOGDNOMHH;
		}
	}
}
