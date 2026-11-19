using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/HoverTooltip")]
public class EGFNNEBEKKI : MonoBehaviour
{
	public int NNLEKIBDEKI;

	public int KKFLHIOFGEN;

	public Text FGEDCIEJIPG;

	public HorizontalLayoutGroup MAANLKLGBBA;

	public RectTransform LLNDNAAKBKO;

	private Image LCKMNMMLNPD;

	private bool LAAOAMMGDFG;

	private bool HOMCDMPCBMA;

	private RenderMode OGJFNEMGMDD;

	private Camera DHNMBMMDGOE;

	private Vector3 GEKPHPNBEHF;

	private Vector3 LOCHHMJEIKF;

	private float CJMHEIMOIMC;

	private float CFCCHKHAIMJ;

	private float IFEOLODNIKG;

	private float MLEIHOKOPHO;

	private float PBMAIPMMAAJ;

	private float IPIAECLLDLO;

	private void Start()
	{
		DHNMBMMDGOE = GameObject.Find("GUICamera").GetComponent<Camera>();
		OGJFNEMGMDD = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
		LCKMNMMLNPD = LLNDNAAKBKO.GetComponent<Image>();
		HOMCDMPCBMA = false;
		JHKDJCHAENI();
		base.transform.parent.gameObject.SetActive(value: false);
	}

	public void OBLLLKJOIPP(string KLLKONMADKA)
	{
		GIDAFGAKCEH();
		FGEDCIEJIPG.text = KLLKONMADKA;
		OHNGALMGKEJ();
	}

	public void OBLLLKJOIPP(string[] JHAFKFEJNPJ)
	{
		GIDAFGAKCEH();
		string text = string.Empty;
		int num = 0;
		foreach (string text2 in JHAFKFEJNPJ)
		{
			text = ((num != 0) ? (text + "\n" + text2) : (text + text2));
			num++;
		}
		FGEDCIEJIPG.text = text;
		OHNGALMGKEJ();
	}

	public void OBLLLKJOIPP(string KLLKONMADKA, bool LDIIPMIIBMA)
	{
		GIDAFGAKCEH();
		FGEDCIEJIPG.text = KLLKONMADKA;
		OHNGALMGKEJ();
	}

	public void OHNGALMGKEJ()
	{
		Vector3 position = DHNMBMMDGOE.ScreenToViewportPoint(UnityEngine.Input.mousePosition);
		float num = 0f;
		float num2 = 0f;
		float num3 = DHNMBMMDGOE.ViewportToScreenPoint(position).x + IPIAECLLDLO * LLNDNAAKBKO.pivot.x;
		if (num3 > LOCHHMJEIKF.x)
		{
			float num4 = LOCHHMJEIKF.x - num3;
			num2 = ((!((double)num4 > (double)MLEIHOKOPHO * 0.75)) ? (MLEIHOKOPHO - IPIAECLLDLO * 2f) : num4);
			Vector3 position2 = new Vector3(DHNMBMMDGOE.ViewportToScreenPoint(position).x + num2, 0f, 0f);
			position.x = DHNMBMMDGOE.ScreenToViewportPoint(position2).x;
		}
		num3 = DHNMBMMDGOE.ViewportToScreenPoint(position).x - IPIAECLLDLO * LLNDNAAKBKO.pivot.x;
		if (num3 < GEKPHPNBEHF.x)
		{
			float num5 = GEKPHPNBEHF.x - num3;
			num2 = ((!((double)num5 < (double)MLEIHOKOPHO * 0.75 - (double)IPIAECLLDLO)) ? (IPIAECLLDLO * 2f) : (0f - num5));
			Vector3 position3 = new Vector3(DHNMBMMDGOE.ViewportToScreenPoint(position).x - num2, 0f, 0f);
			position.x = DHNMBMMDGOE.ScreenToViewportPoint(position3).x;
		}
		num3 = DHNMBMMDGOE.ViewportToScreenPoint(position).y - (LLNDNAAKBKO.sizeDelta.y * CJMHEIMOIMC * LLNDNAAKBKO.pivot.y - PBMAIPMMAAJ);
		if (num3 > LOCHHMJEIKF.y)
		{
			float num6 = LOCHHMJEIKF.y - num3;
			num = LLNDNAAKBKO.sizeDelta.y * CJMHEIMOIMC * LLNDNAAKBKO.pivot.y;
			num = ((!((double)num6 > (double)IFEOLODNIKG * 0.75)) ? (IFEOLODNIKG - PBMAIPMMAAJ * 2f) : num6);
			Vector3 position4 = new Vector3(position.x, DHNMBMMDGOE.ViewportToScreenPoint(position).y + num, 0f);
			position.y = DHNMBMMDGOE.ScreenToViewportPoint(position4).y;
		}
		num3 = DHNMBMMDGOE.ViewportToScreenPoint(position).y - LLNDNAAKBKO.sizeDelta.y * CJMHEIMOIMC * LLNDNAAKBKO.pivot.y;
		if (num3 < GEKPHPNBEHF.y)
		{
			float num7 = GEKPHPNBEHF.y - num3;
			num = LLNDNAAKBKO.sizeDelta.y * CJMHEIMOIMC * LLNDNAAKBKO.pivot.y;
			num = ((!((double)num7 < (double)IFEOLODNIKG * 0.75 - (double)PBMAIPMMAAJ)) ? (PBMAIPMMAAJ * 2f) : num7);
			Vector3 position5 = new Vector3(position.x, DHNMBMMDGOE.ViewportToScreenPoint(position).y + num, 0f);
			position.y = DHNMBMMDGOE.ScreenToViewportPoint(position5).y;
		}
		base.transform.parent.transform.position = new Vector3(DHNMBMMDGOE.ViewportToWorldPoint(position).x, DHNMBMMDGOE.ViewportToWorldPoint(position).y, 0f);
		base.transform.parent.gameObject.SetActive(value: true);
		HOMCDMPCBMA = true;
	}

	public void MIJCNPJKAIG()
	{
		if (OGJFNEMGMDD == RenderMode.ScreenSpaceCamera && this != null)
		{
			base.transform.parent.gameObject.SetActive(value: false);
			HOMCDMPCBMA = false;
			JHKDJCHAENI();
		}
	}

	private void Update()
	{
		BMPJPMJJBEN();
		if (HOMCDMPCBMA && OGJFNEMGMDD == RenderMode.ScreenSpaceCamera)
		{
			OHNGALMGKEJ();
		}
	}

	private void BMPJPMJJBEN()
	{
		if (LAAOAMMGDFG)
		{
			LAAOAMMGDFG = false;
			LLNDNAAKBKO.sizeDelta = new Vector2(MAANLKLGBBA.preferredWidth + (float)NNLEKIBDEKI, MAANLKLGBBA.preferredHeight + (float)KKFLHIOFGEN);
			IFEOLODNIKG = LLNDNAAKBKO.sizeDelta.y * CJMHEIMOIMC * LLNDNAAKBKO.pivot.y;
			MLEIHOKOPHO = LLNDNAAKBKO.sizeDelta.x * CFCCHKHAIMJ * LLNDNAAKBKO.pivot.x;
			PBMAIPMMAAJ = LLNDNAAKBKO.sizeDelta.y * CJMHEIMOIMC;
			IPIAECLLDLO = LLNDNAAKBKO.sizeDelta.x * CFCCHKHAIMJ;
			DPPOAPOFBGC();
		}
	}

	private void GIDAFGAKCEH()
	{
		LAAOAMMGDFG = true;
		GEKPHPNBEHF = DHNMBMMDGOE.ViewportToScreenPoint(new Vector3(0f, 0f, 0f));
		LOCHHMJEIKF = DHNMBMMDGOE.ViewportToScreenPoint(new Vector3(1f, 1f, 0f));
		CJMHEIMOIMC = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
		CFCCHKHAIMJ = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
	}

	public void DPPOAPOFBGC()
	{
		Color color = FGEDCIEJIPG.color;
		FGEDCIEJIPG.color = new Color(color.r, color.g, color.b, 1f);
		LCKMNMMLNPD.color = new Color(LCKMNMMLNPD.color.r, LCKMNMMLNPD.color.g, LCKMNMMLNPD.color.b, 0.8f);
	}

	public void JHKDJCHAENI()
	{
		Color color = FGEDCIEJIPG.color;
		FGEDCIEJIPG.color = new Color(color.r, color.g, color.b, 0f);
		LCKMNMMLNPD.color = new Color(LCKMNMMLNPD.color.r, LCKMNMMLNPD.color.g, LCKMNMMLNPD.color.b, 0f);
	}
}
