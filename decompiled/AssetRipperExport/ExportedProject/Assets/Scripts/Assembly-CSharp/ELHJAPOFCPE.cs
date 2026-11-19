using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/AutoComplete ComboBox")]
public class ELHJAPOFCPE : MonoBehaviour
{
	[Serializable]
	public class SelectionChangedEvent : UnityEvent<string, bool>
	{
	}

	[Serializable]
	public class SelectionTextChangedEvent : UnityEvent<string>
	{
	}

	[Serializable]
	public class SelectionValidityChangedEvent : UnityEvent<bool>
	{
	}

	private sealed class NGKPJIKCEAM
	{
		internal string ILFBCKPPMGC;

		internal ELHJAPOFCPE KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			KPHCHDHEKGH.HLHMEEKPPNG(ILFBCKPPMGC);
		}
	}

	private sealed class IJPMNDAEKKE
	{
		internal string ALPIHDDBFBD;

		internal bool BEKJDJFLJJC(string HKCJBFIKALL)
		{
			return !HKCJBFIKALL.Contains(ALPIHDDBFBD);
		}

		internal bool PMBKBKJIIPO(string HKCJBFIKALL)
		{
			return HKCJBFIKALL.Contains(ALPIHDDBFBD);
		}
	}

	public Color NGPMECFAOLB;

	public List<string> JDEOPHCJELG;

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

	private List<string> FFDIEDPLIBE;

	private Dictionary<string, GameObject> KKAAGNCOEJN;

	private GameObject HDPOBOPELIF;

	[SerializeField]
	private float _scrollBarWidth = 20f;

	[SerializeField]
	private int _itemsToDisplay;

	public bool GCOIAAPOBAM;

	[Tooltip("Change input text color based on matching items")]
	[SerializeField]
	private bool _ChangeInputTextColorBasedOnMatchingItems;

	public Color NJAKBJNPNFE = Color.green;

	public Color LGNLMCFONJH = Color.black;

	public Color BPFFLBMFGNA = Color.red;

	public PCINMBIPGLL IMNHDHFILJL = PCINMBIPGLL.OKPBELGPLPL;

	private bool KDMJDHPKKHP;

	public SelectionTextChangedEvent MNPHKAMOECA;

	public SelectionValidityChangedEvent AENHPCFBBNM;

	public SelectionChangedEvent KJMBNLEHECI;

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

	public bool JLOLGDHCDBJ
	{
		get
		{
			return _ChangeInputTextColorBasedOnMatchingItems;
		}
		set
		{
			_ChangeInputTextColorBasedOnMatchingItems = value;
			if (_ChangeInputTextColorBasedOnMatchingItems)
			{
				FBOEEEBMBPJ();
			}
		}
	}

	public void Awake()
	{
		ANDBBOOJKEL();
	}

	public void Start()
	{
		if (GCOIAAPOBAM && JDEOPHCJELG.Count > 0)
		{
			BLOLEKDMJEO(false);
			HLHMEEKPPNG(JDEOPHCJELG[0]);
		}
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
			JOCEEENMKPB.gameObject.SetActive(false);
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
			HDPOBOPELIF.SetActive(false);
		}
		catch (NullReferenceException exception)
		{
			Debug.LogException(exception);
			Debug.LogError("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
			result = false;
		}
		KKAAGNCOEJN = new Dictionary<string, GameObject>();
		FFDIEDPLIBE = new List<string>();
		FHPGKHIOAPJ = new List<string>();
		FLDDOOPLCLM();
		return result;
	}

	private void FLDDOOPLCLM()
	{
		FHPGKHIOAPJ.Clear();
		FFDIEDPLIBE.Clear();
		KKAAGNCOEJN.Clear();
		foreach (string item in JDEOPHCJELG)
		{
			FHPGKHIOAPJ.Add(item.ToLower());
		}
		List<GameObject> list = new List<GameObject>(KKAAGNCOEJN.Values);
		int num = 0;
		while (list.Count < JDEOPHCJELG.Count)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(HDPOBOPELIF);
			gameObject.name = "Item " + num;
			gameObject.transform.SetParent(NPMPIKKEACH, false);
			list.Add(gameObject);
			num++;
		}
		for (int i = 0; i < list.Count; i++)
		{
			list[i].SetActive(i <= JDEOPHCJELG.Count);
			if (i < JDEOPHCJELG.Count)
			{
				NGKPJIKCEAM nGKPJIKCEAM = new NGKPJIKCEAM();
				nGKPJIKCEAM.KPHCHDHEKGH = this;
				list[i].name = "Item " + i + " " + FHPGKHIOAPJ[i];
				list[i].transform.Find("Text").GetComponent<Text>().text = FHPGKHIOAPJ[i];
				Button component = list[i].GetComponent<Button>();
				component.onClick.RemoveAllListeners();
				nGKPJIKCEAM.ILFBCKPPMGC = FHPGKHIOAPJ[i];
				component.onClick.AddListener(nGKPJIKCEAM.BEKJDJFLJJC);
				KKAAGNCOEJN[FHPGKHIOAPJ[i]] = list[i];
			}
		}
		FBOEEEBMBPJ();
	}

	private void HLHMEEKPPNG(string JLOFICCFAPA)
	{
		BOLCJDBKMCA = JLOFICCFAPA;
		BCLKFBNOCAD.text = BOLCJDBKMCA;
		BLOLEKDMJEO(true);
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
			EGBNIJFJAHD.SetParent(base.transform, true);
			EGBNIJFJAHD.anchoredPosition = new Vector2(0f, 0f - NGMNDPBFLAN.sizeDelta.y);
			JOCEEENMKPB.SetParent(PGHEBMLLFKP.transform, false);
			JOCEEENMKPB.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, MPPPMABGECF.sizeDelta.x);
			JOCEEENMKPB.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, MPPPMABGECF.sizeDelta.y);
			JOCEEENMKPB.SetParent(base.transform, true);
			EGBNIJFJAHD.SetParent(JOCEEENMKPB, true);
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
		MCAKCKGHLCN(ALPIHDDBFBD);
		CPILACNNNNC();
		if (FHPGKHIOAPJ.Count == 0)
		{
			JNLAGEOGOAD = true;
			BLOLEKDMJEO(false);
		}
		else if (!JNLAGEOGOAD)
		{
			BLOLEKDMJEO(false);
		}
		bool flag = FHPGKHIOAPJ.Contains(BOLCJDBKMCA) != KDMJDHPKKHP;
		KDMJDHPKKHP = FHPGKHIOAPJ.Contains(BOLCJDBKMCA);
		KJMBNLEHECI.Invoke(BOLCJDBKMCA, KDMJDHPKKHP);
		MNPHKAMOECA.Invoke(BOLCJDBKMCA);
		if (flag)
		{
			AENHPCFBBNM.Invoke(KDMJDHPKKHP);
		}
		FBOEEEBMBPJ();
	}

	private void FBOEEEBMBPJ()
	{
		if (JLOLGDHCDBJ)
		{
			if (KDMJDHPKKHP)
			{
				BCLKFBNOCAD.textComponent.color = NJAKBJNPNFE;
			}
			else if (FHPGKHIOAPJ.Count > 0)
			{
				BCLKFBNOCAD.textComponent.color = LGNLMCFONJH;
			}
			else
			{
				BCLKFBNOCAD.textComponent.color = BPFFLBMFGNA;
			}
		}
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

	private void MCAKCKGHLCN(string ALPIHDDBFBD)
	{
		if (IMNHDHFILJL == PCINMBIPGLL.OKPBELGPLPL)
		{
			MOJEAMMHAPG(ALPIHDDBFBD);
		}
		else
		{
			GLBGKECGJGC(ALPIHDDBFBD);
		}
	}

	private void MOJEAMMHAPG(string ALPIHDDBFBD)
	{
		IJPMNDAEKKE iJPMNDAEKKE = new IJPMNDAEKKE();
		iJPMNDAEKKE.ALPIHDDBFBD = ALPIHDDBFBD;
		iJPMNDAEKKE.ALPIHDDBFBD = iJPMNDAEKKE.ALPIHDDBFBD.ToLower();
		string[] array = FHPGKHIOAPJ.Where(iJPMNDAEKKE.BEKJDJFLJJC).ToArray();
		string[] array2 = array;
		foreach (string text in array2)
		{
			KKAAGNCOEJN[text].SetActive(false);
			FHPGKHIOAPJ.Remove(text);
			FFDIEDPLIBE.Add(text);
		}
		string[] array3 = FFDIEDPLIBE.Where(iJPMNDAEKKE.PMBKBKJIIPO).ToArray();
		string[] array4 = array3;
		foreach (string text2 in array4)
		{
			KKAAGNCOEJN[text2].SetActive(true);
			FHPGKHIOAPJ.Add(text2);
			FFDIEDPLIBE.Remove(text2);
		}
	}

	private void GLBGKECGJGC(string ALPIHDDBFBD)
	{
		string value = ALPIHDDBFBD.ToLower();
		for (int num = FHPGKHIOAPJ.Count - 1; num >= 0; num--)
		{
			string text = FHPGKHIOAPJ[num];
			if (!text.Contains(value))
			{
				KKAAGNCOEJN[FHPGKHIOAPJ[num]].SetActive(false);
				FHPGKHIOAPJ.RemoveAt(num);
				FFDIEDPLIBE.Add(text);
			}
		}
		for (int num2 = FFDIEDPLIBE.Count - 1; num2 >= 0; num2--)
		{
			string text2 = FFDIEDPLIBE[num2];
			if (text2.Contains(value))
			{
				KKAAGNCOEJN[FFDIEDPLIBE[num2]].SetActive(true);
				FFDIEDPLIBE.RemoveAt(num2);
				FHPGKHIOAPJ.Add(text2);
			}
		}
	}
}
