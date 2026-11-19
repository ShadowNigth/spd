using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
[AddComponentMenu("UI/Extensions/UIScrollToSelection")]
public class LBPIHKACBOA : MonoBehaviour
{
	public enum MPJALGGGOLF
	{
		EBFCKGNELBJ = 0,
		KBENNBFCHJB = 1,
		GGANJMIOBJK = 2
	}

	[Header("[ Settings ]")]
	[SerializeField]
	private MPJALGGGOLF scrollDirection;

	[SerializeField]
	private float scrollSpeed = 10f;

	[SerializeField]
	[Header("[ Input ]")]
	private bool cancelScrollOnInput;

	[SerializeField]
	private List<KeyCode> cancelScrollKeycodes = new List<KeyCode>();

	protected RectTransform PDBIHDKLGGC
	{
		get
		{
			return (!(AHDLGKJHJHL != null)) ? null : AHDLGKJHJHL.content;
		}
	}

	protected MPJALGGGOLF NLJFNBKHMLD
	{
		get
		{
			return scrollDirection;
		}
	}

	protected float GOHIDEBDMJJ
	{
		get
		{
			return scrollSpeed;
		}
	}

	protected bool FECNDCLIOHA
	{
		get
		{
			return cancelScrollOnInput;
		}
	}

	protected List<KeyCode> DLFPEJIPJJK
	{
		get
		{
			return cancelScrollKeycodes;
		}
	}

	protected RectTransform DDEIFONOPEI { get; set; }

	protected ScrollRect AHDLGKJHJHL { get; set; }

	protected EventSystem AKPFLEPHLFO
	{
		get
		{
			return EventSystem.current;
		}
	}

	protected GameObject MGBCDOIHFLG { get; set; }

	protected GameObject MFFGINFKHBG
	{
		get
		{
			return EventSystem.current.currentSelectedGameObject;
		}
	}

	protected RectTransform PMMPJEDIPID { get; set; }

	protected bool IJEDBKCBPBN { get; set; }

	protected virtual void Awake()
	{
		AHDLGKJHJHL = GetComponent<ScrollRect>();
		DDEIFONOPEI = AHDLGKJHJHL.GetComponent<RectTransform>();
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
		BFMFEPOMCPP();
		KFGOJGILGMF();
		NGPPCKEPDEG();
	}

	private void BFMFEPOMCPP()
	{
		if (MFFGINFKHBG != MGBCDOIHFLG)
		{
			PMMPJEDIPID = ((!(MFFGINFKHBG != null)) ? null : MFFGINFKHBG.GetComponent<RectTransform>());
			if (MFFGINFKHBG != null && MFFGINFKHBG.transform.parent == PDBIHDKLGGC.transform)
			{
				IJEDBKCBPBN = false;
			}
		}
		MGBCDOIHFLG = MFFGINFKHBG;
	}

	private void KFGOJGILGMF()
	{
		if (!FECNDCLIOHA || IJEDBKCBPBN)
		{
			return;
		}
		for (int i = 0; i < DLFPEJIPJJK.Count; i++)
		{
			if (UnityEngine.Input.GetKeyDown(DLFPEJIPJJK[i]))
			{
				IJEDBKCBPBN = true;
				break;
			}
		}
	}

	private void NGPPCKEPDEG()
	{
		if (AHDLGKJHJHL == null || PDBIHDKLGGC == null || DDEIFONOPEI == null || IJEDBKCBPBN)
		{
			return;
		}
		RectTransform rectTransform = PMMPJEDIPID;
		if (!(rectTransform == null) && !(rectTransform.transform.parent != PDBIHDKLGGC.transform))
		{
			switch (NLJFNBKHMLD)
			{
			case MPJALGGGOLF.EBFCKGNELBJ:
				ECEKJFNMMLF(rectTransform);
				break;
			case MPJALGGGOLF.KBENNBFCHJB:
				LMCGFJJPNBF(rectTransform);
				break;
			case MPJALGGGOLF.GGANJMIOBJK:
				ECEKJFNMMLF(rectTransform);
				LMCGFJJPNBF(rectTransform);
				break;
			}
		}
	}

	private void ECEKJFNMMLF(RectTransform CMFEFBDCOGA)
	{
		float gIDEOJGAFJH = 0f - CMFEFBDCOGA.anchoredPosition.y - CMFEFBDCOGA.rect.height * (1f - CMFEFBDCOGA.pivot.y);
		float height = CMFEFBDCOGA.rect.height;
		float height2 = DDEIFONOPEI.rect.height;
		float y = PDBIHDKLGGC.anchoredPosition.y;
		float num = AGNENPCFIKF(gIDEOJGAFJH, y, height, height2);
		AHDLGKJHJHL.verticalNormalizedPosition += num / PDBIHDKLGGC.rect.height * Time.unscaledDeltaTime * scrollSpeed;
	}

	private void LMCGFJJPNBF(RectTransform CMFEFBDCOGA)
	{
		float gIDEOJGAFJH = 0f - CMFEFBDCOGA.anchoredPosition.x - CMFEFBDCOGA.rect.width * (1f - CMFEFBDCOGA.pivot.x);
		float width = CMFEFBDCOGA.rect.width;
		float width2 = DDEIFONOPEI.rect.width;
		float gFADABDIIBE = 0f - PDBIHDKLGGC.anchoredPosition.x;
		float num = 0f - AGNENPCFIKF(gIDEOJGAFJH, gFADABDIIBE, width, width2);
		AHDLGKJHJHL.horizontalNormalizedPosition += num / PDBIHDKLGGC.rect.width * Time.unscaledDeltaTime * scrollSpeed;
	}

	private float AGNENPCFIKF(float GIDEOJGAFJH, float GFADABDIIBE, float CPIHNAMFDAD, float MAFBMFMICKL)
	{
		if (GIDEOJGAFJH < GFADABDIIBE + CPIHNAMFDAD / 2f)
		{
			return GFADABDIIBE + MAFBMFMICKL - (GIDEOJGAFJH - CPIHNAMFDAD);
		}
		if (GIDEOJGAFJH + CPIHNAMFDAD > GFADABDIIBE + MAFBMFMICKL)
		{
			return GFADABDIIBE + MAFBMFMICKL - (GIDEOJGAFJH + CPIHNAMFDAD);
		}
		return 0f;
	}
}
