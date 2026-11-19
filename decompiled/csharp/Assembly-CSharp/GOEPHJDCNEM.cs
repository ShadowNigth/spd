using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("UI/Extensions/RescalePanels/RescalePanel")]
public class GOEPHJDCNEM : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
{
	public Vector2 FKEBKFMHIMN;

	public Vector2 MMJJDDGGAEB;

	private RectTransform GEINAHMAFAM;

	private Transform FCIDHFNMEPD;

	private Vector2 IDFOGDNOMHH;

	private Vector2 FNAPLLCAMGP;

	private RectTransform DLDFPJNPCCE;

	private Vector2 EJEOCNKIGEN;

	private void Awake()
	{
		GEINAHMAFAM = base.transform.parent.GetComponent<RectTransform>();
		FCIDHFNMEPD = base.transform.parent;
		DLDFPJNPCCE = GetComponent<RectTransform>();
		EJEOCNKIGEN = DLDFPJNPCCE.sizeDelta;
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
			Vector3 localScale = FCIDHFNMEPD.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(GEINAHMAFAM, PMPJLBPPCMF.position, PMPJLBPPCMF.pressEventCamera, out IDFOGDNOMHH);
			Vector2 vector = IDFOGDNOMHH - FNAPLLCAMGP;
			localScale += new Vector3((0f - vector.y) * 0.001f, (0f - vector.y) * 0.001f, 0f);
			localScale = new Vector3(Mathf.Clamp(localScale.x, FKEBKFMHIMN.x, MMJJDDGGAEB.x), Mathf.Clamp(localScale.y, FKEBKFMHIMN.y, MMJJDDGGAEB.y), 1f);
			FCIDHFNMEPD.localScale = localScale;
			FNAPLLCAMGP = IDFOGDNOMHH;
			float num = EJEOCNKIGEN.x / FCIDHFNMEPD.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			DLDFPJNPCCE.sizeDelta = sizeDelta;
		}
	}
}
