using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/UI ScrollTo Selection XY")]
[RequireComponent(typeof(ScrollRect))]
public class CKIKNEKIFFF : MonoBehaviour
{
	public float AFALBNEEPOL = 10f;

	[SerializeField]
	private RectTransform layoutListGroup;

	private RectTransform GFHMGNEPBAE;

	private bool FHLELFKPDCI = true;

	private RectTransform HDBPDDFJPPN;

	private RectTransform IALJGDBEEDL;

	private ScrollRect BHOBNHAMPMH;

	private void Start()
	{
		BHOBNHAMPMH = GetComponent<ScrollRect>();
		HDBPDDFJPPN = BHOBNHAMPMH.GetComponent<RectTransform>();
	}

	private void Update()
	{
		NGPPCKEPDEG();
	}

	private void NGPPCKEPDEG()
	{
		EventSystem current = EventSystem.current;
		if (BHOBNHAMPMH == null || layoutListGroup == null || HDBPDDFJPPN == null)
		{
			return;
		}
		RectTransform rectTransform = ((!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>());
		if (rectTransform != GFHMGNEPBAE)
		{
			FHLELFKPDCI = true;
		}
		if (!(rectTransform == null) && FHLELFKPDCI && !(rectTransform.transform.parent != layoutListGroup.transform))
		{
			bool flag = false;
			bool flag2 = false;
			if (BHOBNHAMPMH.vertical)
			{
				float num = 0f - rectTransform.anchoredPosition.y;
				float y = layoutListGroup.anchoredPosition.y;
				float num2 = 0f;
				num2 = y - num;
				BHOBNHAMPMH.verticalNormalizedPosition += num2 / layoutListGroup.sizeDelta.y * Time.deltaTime * AFALBNEEPOL;
				flag2 = Mathf.Abs(num2) < 2f;
			}
			if (BHOBNHAMPMH.horizontal)
			{
				float num3 = 0f - rectTransform.anchoredPosition.x;
				float x = layoutListGroup.anchoredPosition.x;
				float num4 = 0f;
				num4 = x - num3;
				BHOBNHAMPMH.horizontalNormalizedPosition += num4 / layoutListGroup.sizeDelta.x * Time.deltaTime * AFALBNEEPOL;
				flag = Mathf.Abs(num4) < 2f;
			}
			if (flag && flag2)
			{
				FHLELFKPDCI = false;
			}
			GFHMGNEPBAE = rectTransform;
		}
	}
}
