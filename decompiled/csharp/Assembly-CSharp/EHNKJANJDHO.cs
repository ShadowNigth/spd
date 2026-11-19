using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("Layout/Extensions/Vertical Scroll Snap")]
[RequireComponent(typeof(ScrollRect))]
public class EHNKJANJDHO : CLLOJICBMEA, IEndDragHandler, IEventSystemHandler
{
	private void Start()
	{
		NBIAFMGAIOC = true;
		ODFPGJFBKKH = new Vector2(0.5f, 0f);
		APKEDCEFMGP = StartingScreen;
		HKJKEIHLHBC = base.gameObject.GetComponent<RectTransform>().rect;
		KOGHKEKNGJI();
	}

	private void Update()
	{
		if (!MMLIINHECAD && MLGAAHHAMEN.velocity == Vector2.zero)
		{
			if (!KDHKNJKBGMB && !HMANGOABAIE && !JFBIAJNPHGN(CIIJLGEBFJC.localPosition))
			{
				HFDNGOOPIIM();
			}
			return;
		}
		if (MMLIINHECAD)
		{
			CIIJLGEBFJC.localPosition = Vector3.Lerp(CIIJLGEBFJC.localPosition, PBBIECOBIMP, IFCNJIHKAPO * Time.deltaTime);
			if (Vector3.Distance(CIIJLGEBFJC.localPosition, PBBIECOBIMP) < 0.1f)
			{
				CIIJLGEBFJC.localPosition = PBBIECOBIMP;
				MMLIINHECAD = false;
				BACPABBAGJO();
			}
		}
		base.PKKJBIDEMBH = JHNAJEMCIOP(CIIJLGEBFJC.localPosition);
		if (!HMANGOABAIE && ((double)MLGAAHHAMEN.velocity.y > 0.01 || (double)MLGAAHHAMEN.velocity.y < -0.01) && CNMGGDGIMJI(0f))
		{
			HFDNGOOPIIM();
		}
	}

	private bool CNMGGDGIMJI(float ELCLLPDNECD)
	{
		return (MLGAAHHAMEN.velocity.y > ELCLLPDNECD && MLGAAHHAMEN.velocity.y < (float)DDDKDLGAKKB) || (MLGAAHHAMEN.velocity.y < ELCLLPDNECD && MLGAAHHAMEN.velocity.y > (float)(-DDDKDLGAKKB));
	}

	public void JAELKLHJJCG()
	{
		MJIFOHDGLGH = CIIJLGEBFJC.childCount;
		MLGAAHHAMEN.verticalNormalizedPosition = 0f;
		float num = 0f;
		float num2 = 0f;
		Rect rect = base.gameObject.GetComponent<RectTransform>().rect;
		float num3 = 0f;
		float num4 = (HMBJIEPFLNO = (float)(int)rect.height * ((PageStep != 0f) ? PageStep : 3f));
		for (int i = 0; i < CIIJLGEBFJC.transform.childCount; i++)
		{
			RectTransform component = CIIJLGEBFJC.transform.GetChild(i).gameObject.GetComponent<RectTransform>();
			num3 = num + (float)i * num4;
			component.sizeDelta = new Vector2(rect.width, rect.height);
			component.anchoredPosition = new Vector2(0f, num3);
			Vector2 vector = (component.pivot = ODFPGJFBKKH);
			vector = (component.anchorMax = vector);
			component.anchorMin = vector;
		}
		num2 = num3 + num * -1f;
		CIIJLGEBFJC.GetComponent<RectTransform>().offsetMax = new Vector2(0f, num2);
	}

	public void KIOCGJMNDMH(GameObject LGLJJHBAOMP)
	{
		KIOCGJMNDMH(LGLJJHBAOMP, EAINCGGKFDP: false);
	}

	public void KIOCGJMNDMH(GameObject LGLJJHBAOMP, bool EAINCGGKFDP)
	{
		MLGAAHHAMEN.verticalNormalizedPosition = 0f;
		LGLJJHBAOMP.transform.SetParent(CIIJLGEBFJC, EAINCGGKFDP);
		GHPHIJOAILA();
		JAELKLHJJCG();
		if ((bool)CMANBHMNAMA)
		{
			IFAOCMEHKII();
		}
		ECPGNNCKGNH();
	}

	public void ICAFAJHPHKB(int JNDABHCJHHD, out GameObject PPBEJENPEPI)
	{
		ICAFAJHPHKB(JNDABHCJHHD, EAINCGGKFDP: false, out PPBEJENPEPI);
	}

	public void ICAFAJHPHKB(int JNDABHCJHHD, bool EAINCGGKFDP, out GameObject PPBEJENPEPI)
	{
		PPBEJENPEPI = null;
		if (JNDABHCJHHD >= 0 && JNDABHCJHHD <= CIIJLGEBFJC.childCount)
		{
			MLGAAHHAMEN.verticalNormalizedPosition = 0f;
			Transform child = CIIJLGEBFJC.transform.GetChild(JNDABHCJHHD);
			child.SetParent(null, EAINCGGKFDP);
			PPBEJENPEPI = child.gameObject;
			GHPHIJOAILA();
			JAELKLHJJCG();
			if ((bool)CMANBHMNAMA)
			{
				IFAOCMEHKII();
			}
			if (APKEDCEFMGP > MJIFOHDGLGH - 1)
			{
				base.PKKJBIDEMBH = MJIFOHDGLGH - 1;
			}
			ECPGNNCKGNH();
		}
	}

	public void JIBMIEKODAJ(out GameObject[] CMDLDKKJAGD)
	{
		JIBMIEKODAJ(EAINCGGKFDP: false, out CMDLDKKJAGD);
	}

	public void JIBMIEKODAJ(bool EAINCGGKFDP, out GameObject[] CMDLDKKJAGD)
	{
		int childCount = CIIJLGEBFJC.childCount;
		CMDLDKKJAGD = new GameObject[childCount];
		for (int num = childCount - 1; num >= 0; num--)
		{
			CMDLDKKJAGD[num] = CIIJLGEBFJC.GetChild(num).gameObject;
			CMDLDKKJAGD[num].transform.SetParent(null, EAINCGGKFDP);
		}
		MLGAAHHAMEN.verticalNormalizedPosition = 0f;
		base.PKKJBIDEMBH = 0;
		GHPHIJOAILA();
		JAELKLHJJCG();
		if ((bool)CMANBHMNAMA)
		{
			IFAOCMEHKII();
		}
	}

	private void ECPGNNCKGNH()
	{
		PNPADGBOJIO = CIIJLGEBFJC.localPosition.y;
		MLGAAHHAMEN.verticalNormalizedPosition = (float)APKEDCEFMGP / (float)(MJIFOHDGLGH - 1);
		BKAOAPFOHHA(APKEDCEFMGP);
	}

	public void KOGHKEKNGJI()
	{
		MMLIINHECAD = false;
		JAELKLHJJCG();
		if ((bool)CMANBHMNAMA)
		{
			IFAOCMEHKII();
		}
		ECPGNNCKGNH();
		BKAOAPFOHHA(APKEDCEFMGP);
	}

	private void LEDGCEMMBCJ()
	{
		if (ODFPGJFBKKH != Vector2.zero)
		{
			KOGHKEKNGJI();
		}
	}

	private void OnEnable()
	{
		GHPHIJOAILA();
		JAELKLHJJCG();
		if ((bool)CMANBHMNAMA)
		{
			IFAOCMEHKII();
		}
		if (DMCADOHDJJD || !DCKPOEMBFLD)
		{
			ECPGNNCKGNH();
		}
		if (DCKPOEMBFLD)
		{
			KGIJFBMOJPM(StartingScreen);
		}
	}

	public void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		HMANGOABAIE = false;
		if (!MLGAAHHAMEN.vertical)
		{
			return;
		}
		float num = Vector3.Distance(PDOLMPHAALB, CIIJLGEBFJC.localPosition);
		if (NJBFBEGBKLF && num < HKJKEIHLHBC.height + (float)AAEDCNOLIAF && num >= 1f)
		{
			MLGAAHHAMEN.velocity = Vector3.zero;
			if (PDOLMPHAALB.y - CIIJLGEBFJC.localPosition.y > 0f)
			{
				NNKEMKABFND();
			}
			else
			{
				IBJKIEHOPBK();
			}
		}
	}
}
