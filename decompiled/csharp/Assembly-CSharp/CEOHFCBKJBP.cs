using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/UI Infinite Scroll")]
public class CEOHFCBKJBP : MonoBehaviour
{
	[Tooltip("If false, will Init automatically, otherwise you need to call Init() method")]
	public bool CKPBPNGGBNA;

	private ScrollRect GLKLNJJAEAB;

	private ContentSizeFitter BONEMANIBPN;

	private VerticalLayoutGroup FLKNJOFPGFB;

	private HorizontalLayoutGroup JMODBGDECPJ;

	private GridLayoutGroup NPMNKPKMHLN;

	private bool NBIAFMGAIOC;

	private bool ECECOGFBLHD;

	private float EABAAFIMBCL;

	private float JBGFLOPHMJN;

	private bool PIGIJFICHHO;

	private List<RectTransform> GFGGAMOGDJA = new List<RectTransform>();

	private Vector2 FOMECPPJGHN = Vector2.zero;

	private float IILFBNJDEFO = 100f;

	private int ICADIDMKHDC;

	private float AHNCBGLKDDJ;

	private float DIBNACBFGPE;

	private void Awake()
	{
		if (!CKPBPNGGBNA)
		{
			HIBHJDCMMAJ();
		}
	}

	public void HIBHJDCMMAJ()
	{
		if (GetComponent<ScrollRect>() != null)
		{
			GLKLNJJAEAB = GetComponent<ScrollRect>();
			GLKLNJJAEAB.onValueChanged.AddListener(LCGOIHBLJEN);
			GLKLNJJAEAB.movementType = ScrollRect.MovementType.Unrestricted;
			for (int i = 0; i < GLKLNJJAEAB.content.childCount; i++)
			{
				GFGGAMOGDJA.Add(GLKLNJJAEAB.content.GetChild(i).GetComponent<RectTransform>());
			}
			if (GLKLNJJAEAB.content.GetComponent<VerticalLayoutGroup>() != null)
			{
				FLKNJOFPGFB = GLKLNJJAEAB.content.GetComponent<VerticalLayoutGroup>();
			}
			if (GLKLNJJAEAB.content.GetComponent<HorizontalLayoutGroup>() != null)
			{
				JMODBGDECPJ = GLKLNJJAEAB.content.GetComponent<HorizontalLayoutGroup>();
			}
			if (GLKLNJJAEAB.content.GetComponent<GridLayoutGroup>() != null)
			{
				NPMNKPKMHLN = GLKLNJJAEAB.content.GetComponent<GridLayoutGroup>();
			}
			if (GLKLNJJAEAB.content.GetComponent<ContentSizeFitter>() != null)
			{
				BONEMANIBPN = GLKLNJJAEAB.content.GetComponent<ContentSizeFitter>();
			}
			ECECOGFBLHD = GLKLNJJAEAB.horizontal;
			NBIAFMGAIOC = GLKLNJJAEAB.vertical;
			if (ECECOGFBLHD && NBIAFMGAIOC)
			{
				Debug.LogError("UI_InfiniteScroll doesn't support scrolling in both directions, plase choose one direction (horizontal or vertical)");
			}
			ICADIDMKHDC = GLKLNJJAEAB.content.childCount;
		}
		else
		{
			Debug.LogError("UI_InfiniteScroll => No ScrollRect component found");
		}
	}

	private void BJCLFBPCHBC()
	{
		if (NBIAFMGAIOC)
		{
			DIBNACBFGPE = GFGGAMOGDJA[0].GetComponent<RectTransform>().anchoredPosition.y - GFGGAMOGDJA[1].GetComponent<RectTransform>().anchoredPosition.y;
			JBGFLOPHMJN = DIBNACBFGPE * (float)ICADIDMKHDC / 2f;
		}
		if (ECECOGFBLHD)
		{
			AHNCBGLKDDJ = GFGGAMOGDJA[1].GetComponent<RectTransform>().anchoredPosition.x - GFGGAMOGDJA[0].GetComponent<RectTransform>().anchoredPosition.x;
			EABAAFIMBCL = AHNCBGLKDDJ * (float)ICADIDMKHDC / 2f;
		}
		if ((bool)FLKNJOFPGFB)
		{
			FLKNJOFPGFB.enabled = false;
		}
		if ((bool)JMODBGDECPJ)
		{
			JMODBGDECPJ.enabled = false;
		}
		if ((bool)BONEMANIBPN)
		{
			BONEMANIBPN.enabled = false;
		}
		if ((bool)NPMNKPKMHLN)
		{
			NPMNKPKMHLN.enabled = false;
		}
		PIGIJFICHHO = true;
	}

	public void LCGOIHBLJEN(Vector2 ELGIKGAIIOD)
	{
		if (!PIGIJFICHHO)
		{
			BJCLFBPCHBC();
		}
		for (int i = 0; i < GFGGAMOGDJA.Count; i++)
		{
			if (ECECOGFBLHD)
			{
				if (GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].gameObject.transform.position).x > EABAAFIMBCL + IILFBNJDEFO)
				{
					FOMECPPJGHN = GFGGAMOGDJA[i].anchoredPosition;
					FOMECPPJGHN.x -= (float)ICADIDMKHDC * AHNCBGLKDDJ;
					GFGGAMOGDJA[i].anchoredPosition = FOMECPPJGHN;
					GLKLNJJAEAB.content.GetChild(ICADIDMKHDC - 1).transform.SetAsFirstSibling();
				}
				else if (GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].gameObject.transform.position).x < 0f - EABAAFIMBCL)
				{
					FOMECPPJGHN = GFGGAMOGDJA[i].anchoredPosition;
					FOMECPPJGHN.x += (float)ICADIDMKHDC * AHNCBGLKDDJ;
					GFGGAMOGDJA[i].anchoredPosition = FOMECPPJGHN;
					GLKLNJJAEAB.content.GetChild(0).transform.SetAsLastSibling();
				}
			}
			if (NBIAFMGAIOC)
			{
				if (GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].gameObject.transform.position).y > JBGFLOPHMJN + IILFBNJDEFO)
				{
					FOMECPPJGHN = GFGGAMOGDJA[i].anchoredPosition;
					FOMECPPJGHN.y -= (float)ICADIDMKHDC * DIBNACBFGPE;
					GFGGAMOGDJA[i].anchoredPosition = FOMECPPJGHN;
					GLKLNJJAEAB.content.GetChild(ICADIDMKHDC - 1).transform.SetAsFirstSibling();
				}
				else if (GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].gameObject.transform.position).y < 0f - JBGFLOPHMJN)
				{
					FOMECPPJGHN = GFGGAMOGDJA[i].anchoredPosition;
					FOMECPPJGHN.y += (float)ICADIDMKHDC * DIBNACBFGPE;
					GFGGAMOGDJA[i].anchoredPosition = FOMECPPJGHN;
					GLKLNJJAEAB.content.GetChild(0).transform.SetAsLastSibling();
				}
			}
		}
	}
}
