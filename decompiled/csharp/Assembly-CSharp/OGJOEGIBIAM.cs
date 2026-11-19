using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/UI Scrollrect Occlusion")]
public class OGJOEGIBIAM : MonoBehaviour
{
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

	private bool FBJHDAPNMJE;

	private List<RectTransform> GFGGAMOGDJA = new List<RectTransform>();

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
			ECECOGFBLHD = GLKLNJJAEAB.horizontal;
			NBIAFMGAIOC = GLKLNJJAEAB.vertical;
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
		}
		else
		{
			Debug.LogError("UI_ScrollRectOcclusion => No ScrollRect component found");
		}
	}

	private void BJCLFBPCHBC()
	{
		if (NBIAFMGAIOC)
		{
			JBGFLOPHMJN = GLKLNJJAEAB.GetComponent<RectTransform>().rect.height / 2f + GFGGAMOGDJA[0].sizeDelta.y;
		}
		if (ECECOGFBLHD)
		{
			EABAAFIMBCL = GLKLNJJAEAB.GetComponent<RectTransform>().rect.width / 2f + GFGGAMOGDJA[0].sizeDelta.x;
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
		FBJHDAPNMJE = true;
	}

	public void LCGOIHBLJEN(Vector2 ELGIKGAIIOD)
	{
		if (!FBJHDAPNMJE)
		{
			BJCLFBPCHBC();
		}
		for (int i = 0; i < GFGGAMOGDJA.Count; i++)
		{
			if (NBIAFMGAIOC && ECECOGFBLHD)
			{
				if (GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).y < 0f - JBGFLOPHMJN || GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).y > JBGFLOPHMJN || GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).x < 0f - EABAAFIMBCL || GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).x > EABAAFIMBCL)
				{
					GFGGAMOGDJA[i].gameObject.SetActive(value: false);
				}
				else
				{
					GFGGAMOGDJA[i].gameObject.SetActive(value: true);
				}
				continue;
			}
			if (NBIAFMGAIOC)
			{
				if (GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).y < 0f - JBGFLOPHMJN || GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).y > JBGFLOPHMJN)
				{
					GFGGAMOGDJA[i].gameObject.SetActive(value: false);
				}
				else
				{
					GFGGAMOGDJA[i].gameObject.SetActive(value: true);
				}
			}
			if (ECECOGFBLHD)
			{
				if (GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).x < 0f - EABAAFIMBCL || GLKLNJJAEAB.transform.InverseTransformPoint(GFGGAMOGDJA[i].position).x > EABAAFIMBCL)
				{
					GFGGAMOGDJA[i].gameObject.SetActive(value: false);
				}
				else
				{
					GFGGAMOGDJA[i].gameObject.SetActive(value: true);
				}
			}
		}
	}
}
