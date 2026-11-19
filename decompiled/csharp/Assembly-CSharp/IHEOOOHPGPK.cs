using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

[AddComponentMenu("UI/Extensions/Dropdown List")]
[RequireComponent(typeof(RectTransform))]
public class IHEOOOHPGPK : MonoBehaviour
{
	[Serializable]
	public class SelectionChangedEvent : UnityEvent<int>
	{
	}

	[CompilerGenerated]
	private sealed class DGIMNJBCEEJ
	{
		internal int EHFGIDMPGDL;

		internal DropDownListItem JLOFICCFAPA;

		internal IHEOOOHPGPK KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			KPHCHDHEKGH.HLHMEEKPPNG(EHFGIDMPGDL);
			if (JLOFICCFAPA.OnSelect != null)
			{
				JLOFICCFAPA.OnSelect();
			}
		}
	}

	public Color NGPMECFAOLB;

	public List<DropDownListItem> JLIJBGPHKOA;

	public bool GACKBOPNAKH = true;

	private bool JNLAGEOGOAD;

	private bool KEMJOMDHBKE;

	private AGNGCLJDNNG OFOBCFFAKFG;

	private RectTransform NGMNDPBFLAN;

	private RectTransform JOCEEENMKPB;

	private RectTransform EGBNIJFJAHD;

	private RectTransform DECINFBKILN;

	private RectTransform GHBLLLOJOFP;

	private RectTransform NPMPIKKEACH;

	private Canvas PGHEBMLLFKP;

	private RectTransform MPPPMABGECF;

	private ScrollRect GLKLNJJAEAB;

	private List<AGNGCLJDNNG> FHPGKHIOAPJ;

	private GameObject NGODOEPODFI;

	[SerializeField]
	private float _scrollBarWidth = 20f;

	private int ODDGGKOBHLI = -1;

	[SerializeField]
	private int _itemsToDisplay;

	public bool GCOIAAPOBAM;

	public SelectionChangedEvent KJMBNLEHECI;

	public DropDownListItem KKPIPKBOGCO { get; private set; }

	public float LMIPNFFGJBN
	{
		get
		{
			return _scrollBarWidth;
		}
		set
		{
			_scrollBarWidth = value;
			CPILACNNNNC();
		}
	}

	public int DNHLEPPAKAP
	{
		get
		{
			return _itemsToDisplay;
		}
		set
		{
			_itemsToDisplay = value;
			CPILACNNNNC();
		}
	}

	public void Start()
	{
		ANDBBOOJKEL();
		if (GCOIAAPOBAM && JLIJBGPHKOA.Count > 0)
		{
			BLOLEKDMJEO(NNNOIEGNLGF: false);
			HLHMEEKPPNG(0);
		}
	}

	private bool ANDBBOOJKEL()
	{
		bool result = true;
		try
		{
			NGMNDPBFLAN = GetComponent<RectTransform>();
			OFOBCFFAKFG = new AGNGCLJDNNG(NGMNDPBFLAN.Find("MainButton").gameObject);
			JOCEEENMKPB = NGMNDPBFLAN.Find("Overlay").GetComponent<RectTransform>();
			JOCEEENMKPB.gameObject.SetActive(value: false);
			EGBNIJFJAHD = JOCEEENMKPB.Find("ScrollPanel").GetComponent<RectTransform>();
			DECINFBKILN = EGBNIJFJAHD.Find("Scrollbar").GetComponent<RectTransform>();
			GHBLLLOJOFP = DECINFBKILN.Find("SlidingArea").GetComponent<RectTransform>();
			NPMPIKKEACH = EGBNIJFJAHD.Find("Items").GetComponent<RectTransform>();
			PGHEBMLLFKP = GetComponentInParent<Canvas>();
			MPPPMABGECF = PGHEBMLLFKP.GetComponent<RectTransform>();
			GLKLNJJAEAB = EGBNIJFJAHD.GetComponent<ScrollRect>();
			GLKLNJJAEAB.scrollSensitivity = NGMNDPBFLAN.sizeDelta.y / 2f;
			GLKLNJJAEAB.movementType = ScrollRect.MovementType.Clamped;
			GLKLNJJAEAB.content = NPMPIKKEACH;
			NGODOEPODFI = NGMNDPBFLAN.Find("ItemTemplate").gameObject;
			NGODOEPODFI.SetActive(value: false);
		}
		catch (NullReferenceException exception)
		{
			Debug.LogException(exception);
			Debug.LogError("Something is setup incorrectly with the dropdownlist component causing a Null Reference Exception");
			result = false;
		}
		FHPGKHIOAPJ = new List<AGNGCLJDNNG>();
		FLDDOOPLCLM();
		CPILACNNNNC();
		return result;
	}

	private void FLDDOOPLCLM()
	{
		if (JLIJBGPHKOA.Count == 0)
		{
			return;
		}
		int num = FHPGKHIOAPJ.Count;
		while (FHPGKHIOAPJ.Count < JLIJBGPHKOA.Count)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(NGODOEPODFI);
			gameObject.name = "Item " + num;
			gameObject.transform.SetParent(NPMPIKKEACH, worldPositionStays: false);
			FHPGKHIOAPJ.Add(new AGNGCLJDNNG(gameObject));
			num++;
		}
		for (int i = 0; i < FHPGKHIOAPJ.Count; i++)
		{
			if (i < JLIJBGPHKOA.Count)
			{
				DropDownListItem JLOFICCFAPA = JLIJBGPHKOA[i];
				FHPGKHIOAPJ[i].NFFPPKLIPBC.text = JLOFICCFAPA.Caption;
				if (JLOFICCFAPA.IsDisabled)
				{
					FHPGKHIOAPJ[i].NFFPPKLIPBC.color = NGPMECFAOLB;
				}
				if (FHPGKHIOAPJ[i].MPIKHJGABMG != null)
				{
					FHPGKHIOAPJ[i].MPIKHJGABMG.sprite = null;
				}
				FHPGKHIOAPJ[i].FBAMCBALFCM.sprite = JLOFICCFAPA.Image;
				FHPGKHIOAPJ[i].FBAMCBALFCM.color = ((JLOFICCFAPA.Image == null) ? new Color(1f, 1f, 1f, 0f) : ((!JLOFICCFAPA.IsDisabled) ? Color.white : new Color(1f, 1f, 1f, 0.5f)));
				int EHFGIDMPGDL = i;
				FHPGKHIOAPJ[i].IECEOHEKBLE.onClick.RemoveAllListeners();
				FHPGKHIOAPJ[i].IECEOHEKBLE.onClick.AddListener(delegate
				{
					HLHMEEKPPNG(EHFGIDMPGDL);
					if (JLOFICCFAPA.OnSelect != null)
					{
						JLOFICCFAPA.OnSelect();
					}
				});
			}
			FHPGKHIOAPJ[i].KLDDCBIEAEK.SetActive(i < JLIJBGPHKOA.Count);
		}
	}

	private void HLHMEEKPPNG(int AOIDAFNIOEF)
	{
		if (AOIDAFNIOEF != ODDGGKOBHLI && KJMBNLEHECI != null)
		{
			KJMBNLEHECI.Invoke(AOIDAFNIOEF);
		}
		ODDGGKOBHLI = AOIDAFNIOEF;
		BLOLEKDMJEO(NNNOIEGNLGF: true);
		KKMIDBFHMBD();
	}

	private void KKMIDBFHMBD()
	{
		KKPIPKBOGCO = ((ODDGGKOBHLI <= -1 || ODDGGKOBHLI >= JLIJBGPHKOA.Count) ? null : JLIJBGPHKOA[ODDGGKOBHLI]);
		if (KKPIPKBOGCO == null)
		{
			return;
		}
		if (KKPIPKBOGCO.Image != null)
		{
			OFOBCFFAKFG.FBAMCBALFCM.sprite = KKPIPKBOGCO.Image;
			OFOBCFFAKFG.FBAMCBALFCM.color = Color.white;
		}
		else
		{
			OFOBCFFAKFG.FBAMCBALFCM.sprite = null;
		}
		OFOBCFFAKFG.NFFPPKLIPBC.text = KKPIPKBOGCO.Caption;
		if (GACKBOPNAKH)
		{
			for (int i = 0; i < NPMPIKKEACH.childCount; i++)
			{
				FHPGKHIOAPJ[i].MPIKHJGABMG.color = ((ODDGGKOBHLI != i) ? new Color(0f, 0f, 0f, 0f) : OFOBCFFAKFG.IECEOHEKBLE.colors.highlightedColor);
			}
		}
	}

	private void CPILACNNNNC()
	{
		float num = ((JLIJBGPHKOA.Count <= DNHLEPPAKAP) ? 0f : _scrollBarWidth);
		if (!KEMJOMDHBKE || NGMNDPBFLAN.sizeDelta != OFOBCFFAKFG.GEINAHMAFAM.sizeDelta)
		{
			KEMJOMDHBKE = true;
			OFOBCFFAKFG.GEINAHMAFAM.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, NGMNDPBFLAN.sizeDelta.x);
			OFOBCFFAKFG.GEINAHMAFAM.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, NGMNDPBFLAN.sizeDelta.y);
			OFOBCFFAKFG.NFFPPKLIPBC.rectTransform.offsetMax = new Vector2(4f, 0f);
			EGBNIJFJAHD.SetParent(base.transform, worldPositionStays: true);
			EGBNIJFJAHD.anchoredPosition = new Vector2(0f, 0f - NGMNDPBFLAN.sizeDelta.y);
			JOCEEENMKPB.SetParent(PGHEBMLLFKP.transform, worldPositionStays: false);
			JOCEEENMKPB.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, MPPPMABGECF.sizeDelta.x);
			JOCEEENMKPB.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, MPPPMABGECF.sizeDelta.y);
			JOCEEENMKPB.SetParent(base.transform, worldPositionStays: true);
			EGBNIJFJAHD.SetParent(JOCEEENMKPB, worldPositionStays: true);
		}
		if (JLIJBGPHKOA.Count >= 1)
		{
			float num2 = NGMNDPBFLAN.sizeDelta.y * (float)Mathf.Min(_itemsToDisplay, JLIJBGPHKOA.Count);
			EGBNIJFJAHD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			EGBNIJFJAHD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, NGMNDPBFLAN.sizeDelta.x);
			NPMPIKKEACH.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, EGBNIJFJAHD.sizeDelta.x - num - 5f);
			NPMPIKKEACH.anchoredPosition = new Vector2(5f, 0f);
			DECINFBKILN.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			DECINFBKILN.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			GHBLLLOJOFP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0f);
			GHBLLLOJOFP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - DECINFBKILN.sizeDelta.x);
		}
	}

	public void BLOLEKDMJEO(bool NNNOIEGNLGF)
	{
		JOCEEENMKPB.transform.localScale = new Vector3(1f, 1f, 1f);
		DECINFBKILN.transform.localScale = new Vector3(1f, 1f, 1f);
		JNLAGEOGOAD = !JNLAGEOGOAD;
		JOCEEENMKPB.gameObject.SetActive(JNLAGEOGOAD);
		if (JNLAGEOGOAD)
		{
			base.transform.SetAsLastSibling();
		}
		else if (!NNNOIEGNLGF)
		{
		}
	}
}
