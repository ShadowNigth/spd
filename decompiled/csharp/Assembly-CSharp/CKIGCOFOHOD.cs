using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/ComboBox")]
public class CKIGCOFOHOD : MonoBehaviour
{
	[Serializable]
	public class SelectionChangedEvent : UnityEvent<string>
	{
	}

	[CompilerGenerated]
	private sealed class GNJMKIEIACK
	{
		internal string ILFBCKPPMGC;

		internal CKIGCOFOHOD KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			KPHCHDHEKGH.HLHMEEKPPNG(ILFBCKPPMGC);
		}
	}

	public Color NGPMECFAOLB;

	public List<string> JDEOPHCJELG;

	[SerializeField]
	private float _scrollBarWidth = 20f;

	[SerializeField]
	private int _itemsToDisplay;

	public SelectionChangedEvent KJMBNLEHECI;

	private bool JNLAGEOGOAD;

	private bool KEMJOMDHBKE;

	private InputField BCLKFBNOCAD;

	private RectTransform MEALFNKLAOE;

	private RectTransform NGMNDPBFLAN;

	private RectTransform JOCEEENMKPB;

	private RectTransform EGBNIJFJAHD;

	private RectTransform DECINFBKILN;

	private RectTransform GHBLLLOJOFP;

	private RectTransform NPMPIKKEACH;

	private Canvas PGHEBMLLFKP;

	private RectTransform MPPPMABGECF;

	private ScrollRect GLKLNJJAEAB;

	private List<string> FHPGKHIOAPJ;

	private Dictionary<string, GameObject> KKAAGNCOEJN;

	private GameObject HDPOBOPELIF;

	public DropDownListItem KKPIPKBOGCO { get; private set; }

	public string BOLCJDBKMCA { get; private set; }

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

	public void Awake()
	{
		ANDBBOOJKEL();
	}

	private bool ANDBBOOJKEL()
	{
		bool result = true;
		try
		{
			NGMNDPBFLAN = GetComponent<RectTransform>();
			MEALFNKLAOE = NGMNDPBFLAN.Find("InputField").GetComponent<RectTransform>();
			BCLKFBNOCAD = MEALFNKLAOE.GetComponent<InputField>();
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
			HDPOBOPELIF = NGMNDPBFLAN.Find("ItemTemplate").gameObject;
			HDPOBOPELIF.SetActive(value: false);
		}
		catch (NullReferenceException exception)
		{
			Debug.LogException(exception);
			Debug.LogError("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
			result = false;
		}
		KKAAGNCOEJN = new Dictionary<string, GameObject>();
		FHPGKHIOAPJ = JDEOPHCJELG.ToList();
		FLDDOOPLCLM();
		return result;
	}

	private void FLDDOOPLCLM()
	{
		FHPGKHIOAPJ.Clear();
		foreach (string item in JDEOPHCJELG)
		{
			FHPGKHIOAPJ.Add(item.ToLower());
		}
		FHPGKHIOAPJ.Sort();
		List<GameObject> list = new List<GameObject>(KKAAGNCOEJN.Values);
		KKAAGNCOEJN.Clear();
		int num = 0;
		while (list.Count < JDEOPHCJELG.Count)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(HDPOBOPELIF);
			gameObject.name = "Item " + num;
			gameObject.transform.SetParent(NPMPIKKEACH, worldPositionStays: false);
			list.Add(gameObject);
			num++;
		}
		for (int i = 0; i < list.Count; i++)
		{
			list[i].SetActive(i <= JDEOPHCJELG.Count);
			if (i < JDEOPHCJELG.Count)
			{
				list[i].name = "Item " + i + " " + FHPGKHIOAPJ[i];
				list[i].transform.Find("Text").GetComponent<Text>().text = FHPGKHIOAPJ[i];
				Button component = list[i].GetComponent<Button>();
				component.onClick.RemoveAllListeners();
				string ILFBCKPPMGC = FHPGKHIOAPJ[i];
				component.onClick.AddListener(delegate
				{
					HLHMEEKPPNG(ILFBCKPPMGC);
				});
				KKAAGNCOEJN[FHPGKHIOAPJ[i]] = list[i];
			}
		}
	}

	private void HLHMEEKPPNG(string JLOFICCFAPA)
	{
		BOLCJDBKMCA = JLOFICCFAPA;
		BCLKFBNOCAD.text = BOLCJDBKMCA;
		BLOLEKDMJEO(NNNOIEGNLGF: true);
	}

	private void CPILACNNNNC()
	{
		float num = ((FHPGKHIOAPJ.Count <= DNHLEPPAKAP) ? 0f : _scrollBarWidth);
		DECINFBKILN.gameObject.SetActive(FHPGKHIOAPJ.Count > DNHLEPPAKAP);
		if (!KEMJOMDHBKE || NGMNDPBFLAN.sizeDelta != MEALFNKLAOE.sizeDelta)
		{
			KEMJOMDHBKE = true;
			MEALFNKLAOE.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, NGMNDPBFLAN.sizeDelta.x);
			MEALFNKLAOE.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, NGMNDPBFLAN.sizeDelta.y);
			EGBNIJFJAHD.SetParent(base.transform, worldPositionStays: true);
			EGBNIJFJAHD.anchoredPosition = new Vector2(0f, 0f - NGMNDPBFLAN.sizeDelta.y);
			JOCEEENMKPB.SetParent(PGHEBMLLFKP.transform, worldPositionStays: false);
			JOCEEENMKPB.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, MPPPMABGECF.sizeDelta.x);
			JOCEEENMKPB.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, MPPPMABGECF.sizeDelta.y);
			JOCEEENMKPB.SetParent(base.transform, worldPositionStays: true);
			EGBNIJFJAHD.SetParent(JOCEEENMKPB, worldPositionStays: true);
		}
		if (FHPGKHIOAPJ.Count >= 1)
		{
			float num2 = NGMNDPBFLAN.sizeDelta.y * (float)Mathf.Min(_itemsToDisplay, FHPGKHIOAPJ.Count);
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

	public void ICOHIIJIPHE(string ALPIHDDBFBD)
	{
		BOLCJDBKMCA = ALPIHDDBFBD;
		CPILACNNNNC();
		if (FHPGKHIOAPJ.Count == 0)
		{
			JNLAGEOGOAD = true;
			BLOLEKDMJEO(NNNOIEGNLGF: false);
		}
		else if (!JNLAGEOGOAD)
		{
			BLOLEKDMJEO(NNNOIEGNLGF: false);
		}
		KJMBNLEHECI.Invoke(BOLCJDBKMCA);
	}

	public void BLOLEKDMJEO(bool NNNOIEGNLGF)
	{
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
