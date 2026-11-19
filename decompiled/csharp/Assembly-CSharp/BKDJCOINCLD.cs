using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/TextPic")]
[ExecuteInEditMode]
public class BKDJCOINCLD : Text, IPointerClickHandler, IPointerExitHandler, IPointerEnterHandler, ISelectHandler, IEventSystemHandler
{
	[Serializable]
	public struct IconName
	{
		public string name;

		public Sprite sprite;

		public Vector2 offset;

		public Vector2 scale;
	}

	[Serializable]
	public class HrefClickEvent : UnityEvent<string>
	{
	}

	private class KJPBGGNDGOG
	{
		public int MLJLPCDEJGD;

		public int GGNFLJOCINJ;

		public string ALLLIGGPLMK;

		public readonly List<Rect> EAGKNDELLDK = new List<Rect>();
	}

	private readonly List<Image> HAMACDLNIEP = new List<Image>();

	private readonly List<GameObject> LPEBEJKNKHI = new List<GameObject>();

	private bool ONBGDEMDDKB;

	private UnityEngine.Object NIPPDMMPJJL = new UnityEngine.Object();

	private readonly List<int> ACKPCECDADP = new List<int>();

	private static readonly Regex ICOIIJNJCHE = new Regex("<quad name=(.+?) size=(\\d*\\.?\\d+%?) width=(\\d*\\.?\\d+%?) />", RegexOptions.Singleline);

	private string DMCBDECLKGA;

	[Tooltip("Allow click events to be received by parents, (default) blocks")]
	[SerializeField]
	private bool m_ClickParents;

	private string IHOIDFMECBH;

	public IconName[] CAHLCGCINID;

	[Tooltip("Global scaling factor for all images")]
	public float AGAIMNLFEIF = 1f;

	public string BFLODACGFGL = "blue";

	[SerializeField]
	public Vector2 imageOffset = Vector2.zero;

	private Button PMHLHIIDMEG;

	private Selectable LDBIDLHFHOJ;

	private List<Vector2> FEOKJHDJILH = new List<Vector2>();

	private string EKLIHJFJGCB = string.Empty;

	public bool FLDENHPLEHC = true;

	private readonly List<KJPBGGNDGOG> FMJHAJBOGKC = new List<KJPBGGNDGOG>();

	private static readonly StringBuilder EKBEIHBBLGP = new StringBuilder();

	private static readonly Regex HPPLJNAFAAO = new Regex("<a href=([^>\\n\\s]+)>(.*?)(</a>)", RegexOptions.Singleline);

	[SerializeField]
	private HrefClickEvent m_OnHrefClick = new HrefClickEvent();

	[CompilerGenerated]
	private static Predicate<Image> ACJNADIPOMC;

	public bool MOHPABIOCMP
	{
		get
		{
			return m_ClickParents;
		}
		set
		{
			m_ClickParents = value;
		}
	}

	public HrefClickEvent MMKEKOFHHNF
	{
		get
		{
			return m_OnHrefClick;
		}
		set
		{
			m_OnHrefClick = value;
		}
	}

	public override void SetVerticesDirty()
	{
		base.SetVerticesDirty();
		NKIICOKKHBN();
	}

	private new void Start()
	{
		PMHLHIIDMEG = GetComponentInParent<Button>();
		if (PMHLHIIDMEG != null)
		{
			CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
			if (canvasGroup == null)
			{
				canvasGroup = base.gameObject.AddComponent<CanvasGroup>();
			}
			canvasGroup.blocksRaycasts = false;
			LDBIDLHFHOJ = canvasGroup.GetComponent<Selectable>();
		}
		else
		{
			LDBIDLHFHOJ = GetComponent<Selectable>();
		}
		EBLLBDBHEEB();
		base.Start();
	}

	protected void NKIICOKKHBN()
	{
		IHOIDFMECBH = AGOOLHDLEDB();
		ACKPCECDADP.Clear();
		foreach (Match item2 in ICOIIJNJCHE.Matches(IHOIDFMECBH))
		{
			int index = item2.Index;
			int item = index * 4 + 3;
			ACKPCECDADP.Add(item);
			HAMACDLNIEP.RemoveAll((Image GBCLDBHACGH) => GBCLDBHACGH == null);
			if (HAMACDLNIEP.Count == 0)
			{
				GetComponentsInChildren(HAMACDLNIEP);
			}
			if (ACKPCECDADP.Count > HAMACDLNIEP.Count)
			{
				GameObject gameObject = DefaultControls.CreateImage(default(DefaultControls.Resources));
				gameObject.layer = base.gameObject.layer;
				RectTransform rectTransform = gameObject.transform as RectTransform;
				if ((bool)rectTransform)
				{
					rectTransform.SetParent(base.rectTransform);
					rectTransform.localPosition = Vector3.zero;
					rectTransform.localRotation = Quaternion.identity;
					rectTransform.localScale = Vector3.one;
				}
				HAMACDLNIEP.Add(gameObject.GetComponent<Image>());
			}
			string value = item2.Groups[1].Value;
			Image image = HAMACDLNIEP[ACKPCECDADP.Count - 1];
			Vector2 vector = Vector2.zero;
			if ((image.sprite == null || image.sprite.name != value) && CAHLCGCINID != null && CAHLCGCINID.Length > 0)
			{
				IconName[] cAHLCGCINID = CAHLCGCINID;
				for (int i = 0; i < cAHLCGCINID.Length; i++)
				{
					IconName iconName = cAHLCGCINID[i];
					if (iconName.name == value)
					{
						image.sprite = iconName.sprite;
						image.rectTransform.sizeDelta = new Vector2((float)base.fontSize * AGAIMNLFEIF * iconName.scale.x, (float)base.fontSize * AGAIMNLFEIF * iconName.scale.y);
						vector = iconName.offset;
						break;
					}
				}
			}
			image.enabled = true;
			if (FEOKJHDJILH.Count == HAMACDLNIEP.Count)
			{
				image.rectTransform.anchoredPosition = (FEOKJHDJILH[ACKPCECDADP.Count - 1] += vector);
			}
		}
		for (int j = ACKPCECDADP.Count; j < HAMACDLNIEP.Count; j++)
		{
			if ((bool)HAMACDLNIEP[j])
			{
				HAMACDLNIEP[j].gameObject.SetActive(value: false);
				HAMACDLNIEP[j].gameObject.hideFlags = HideFlags.HideAndDontSave;
				LPEBEJKNKHI.Add(HAMACDLNIEP[j].gameObject);
				HAMACDLNIEP.Remove(HAMACDLNIEP[j]);
			}
		}
		if (LPEBEJKNKHI.Count > 1)
		{
			ONBGDEMDDKB = true;
		}
	}

	protected override void OnPopulateMesh(VertexHelper IMJMIDPBDHN)
	{
		string text = m_Text;
		m_Text = AGOOLHDLEDB();
		base.OnPopulateMesh(IMJMIDPBDHN);
		m_Text = text;
		FEOKJHDJILH.Clear();
		UIVertex vertex = default(UIVertex);
		for (int i = 0; i < ACKPCECDADP.Count; i++)
		{
			int num = ACKPCECDADP[i];
			RectTransform rectTransform = HAMACDLNIEP[i].rectTransform;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			if (num < IMJMIDPBDHN.currentVertCount)
			{
				IMJMIDPBDHN.PopulateUIVertex(ref vertex, num);
				FEOKJHDJILH.Add(new Vector2(vertex.position.x + sizeDelta.x / 2f, vertex.position.y + sizeDelta.y / 2f) + imageOffset);
				IMJMIDPBDHN.PopulateUIVertex(ref vertex, num - 3);
				Vector3 position = vertex.position;
				int num2 = num;
				int num3 = num - 3;
				while (num2 > num3)
				{
					IMJMIDPBDHN.PopulateUIVertex(ref vertex, num);
					vertex.position = position;
					IMJMIDPBDHN.SetUIVertex(vertex, num2);
					num2--;
				}
			}
		}
		if (ACKPCECDADP.Count != 0)
		{
			ACKPCECDADP.Clear();
		}
		foreach (KJPBGGNDGOG item in FMJHAJBOGKC)
		{
			item.EAGKNDELLDK.Clear();
			if (item.MLJLPCDEJGD >= IMJMIDPBDHN.currentVertCount)
			{
				continue;
			}
			IMJMIDPBDHN.PopulateUIVertex(ref vertex, item.MLJLPCDEJGD);
			Vector3 position2 = vertex.position;
			Bounds bounds = new Bounds(position2, Vector3.zero);
			int j = item.MLJLPCDEJGD;
			for (int gGNFLJOCINJ = item.GGNFLJOCINJ; j < gGNFLJOCINJ && j < IMJMIDPBDHN.currentVertCount; j++)
			{
				IMJMIDPBDHN.PopulateUIVertex(ref vertex, j);
				position2 = vertex.position;
				if (position2.x < bounds.min.x)
				{
					item.EAGKNDELLDK.Add(new Rect(bounds.min, bounds.size));
					bounds = new Bounds(position2, Vector3.zero);
				}
				else
				{
					bounds.Encapsulate(position2);
				}
			}
			item.EAGKNDELLDK.Add(new Rect(bounds.min, bounds.size));
		}
		NKIICOKKHBN();
	}

	protected string AGOOLHDLEDB()
	{
		EKBEIHBBLGP.Length = 0;
		int num = 0;
		DMCBDECLKGA = text;
		if (CAHLCGCINID != null && CAHLCGCINID.Length > 0)
		{
			IconName[] cAHLCGCINID = CAHLCGCINID;
			for (int i = 0; i < cAHLCGCINID.Length; i++)
			{
				IconName iconName = cAHLCGCINID[i];
				if (iconName.name != null && iconName.name != string.Empty)
				{
					DMCBDECLKGA = DMCBDECLKGA.Replace(iconName.name, "<quad name=" + iconName.name + " size=" + base.fontSize + " width=1 />");
				}
			}
		}
		int num2 = 0;
		foreach (Match item2 in HPPLJNAFAAO.Matches(DMCBDECLKGA))
		{
			EKBEIHBBLGP.Append(DMCBDECLKGA.Substring(num, item2.Index - num));
			EKBEIHBBLGP.Append("<color=" + BFLODACGFGL + ">");
			Group group = item2.Groups[1];
			if (FLDENHPLEHC)
			{
				KJPBGGNDGOG kJPBGGNDGOG = new KJPBGGNDGOG();
				kJPBGGNDGOG.MLJLPCDEJGD = EKBEIHBBLGP.Length * 4;
				kJPBGGNDGOG.GGNFLJOCINJ = (EKBEIHBBLGP.Length + item2.Groups[2].Length - 1) * 4 + 3;
				kJPBGGNDGOG.ALLLIGGPLMK = group.Value;
				KJPBGGNDGOG item = kJPBGGNDGOG;
				FMJHAJBOGKC.Add(item);
			}
			else if (FMJHAJBOGKC.Count > 0)
			{
				FMJHAJBOGKC[num2].MLJLPCDEJGD = EKBEIHBBLGP.Length * 4;
				FMJHAJBOGKC[num2].GGNFLJOCINJ = (EKBEIHBBLGP.Length + item2.Groups[2].Length - 1) * 4 + 3;
				num2++;
			}
			EKBEIHBBLGP.Append(item2.Groups[2].Value);
			EKBEIHBBLGP.Append("</color>");
			num = item2.Index + item2.Length;
		}
		if (FLDENHPLEHC)
		{
			FLDENHPLEHC = false;
		}
		EKBEIHBBLGP.Append(DMCBDECLKGA.Substring(num, DMCBDECLKGA.Length - num));
		return EKBEIHBBLGP.ToString();
	}

	public void OnPointerClick(PointerEventData GBOFEMOALII)
	{
		RectTransformUtility.ScreenPointToLocalPointInRectangle(base.rectTransform, GBOFEMOALII.position, GBOFEMOALII.pressEventCamera, out var localPoint);
		foreach (KJPBGGNDGOG item in FMJHAJBOGKC)
		{
			List<Rect> eAGKNDELLDK = item.EAGKNDELLDK;
			for (int i = 0; i < eAGKNDELLDK.Count; i++)
			{
				if (eAGKNDELLDK[i].Contains(localPoint))
				{
					m_OnHrefClick.Invoke(item.ALLLIGGPLMK);
					return;
				}
			}
		}
	}

	public void OnPointerEnter(PointerEventData GBOFEMOALII)
	{
		if (HAMACDLNIEP.Count < 1)
		{
			return;
		}
		foreach (Image item in HAMACDLNIEP)
		{
			if (LDBIDLHFHOJ != null && LDBIDLHFHOJ.isActiveAndEnabled)
			{
				item.color = LDBIDLHFHOJ.colors.highlightedColor;
			}
		}
	}

	public void OnPointerExit(PointerEventData GBOFEMOALII)
	{
		if (HAMACDLNIEP.Count < 1)
		{
			return;
		}
		foreach (Image item in HAMACDLNIEP)
		{
			if (LDBIDLHFHOJ != null && LDBIDLHFHOJ.isActiveAndEnabled)
			{
				item.color = LDBIDLHFHOJ.colors.normalColor;
			}
			else
			{
				item.color = color;
			}
		}
	}

	public void OnSelect(BaseEventData GBOFEMOALII)
	{
		if (HAMACDLNIEP.Count < 1)
		{
			return;
		}
		foreach (Image item in HAMACDLNIEP)
		{
			if (LDBIDLHFHOJ != null && LDBIDLHFHOJ.isActiveAndEnabled)
			{
				item.color = LDBIDLHFHOJ.colors.highlightedColor;
			}
		}
	}

	private void Update()
	{
		lock (NIPPDMMPJJL)
		{
			if (ONBGDEMDDKB)
			{
				for (int i = 0; i < LPEBEJKNKHI.Count; i++)
				{
					UnityEngine.Object.DestroyImmediate(LPEBEJKNKHI[i]);
				}
				LPEBEJKNKHI.Clear();
				ONBGDEMDDKB = false;
			}
		}
		if (EKLIHJFJGCB != text)
		{
			EBLLBDBHEEB();
		}
	}

	private void EBLLBDBHEEB()
	{
		EKLIHJFJGCB = text;
		FMJHAJBOGKC.Clear();
		FLDENHPLEHC = true;
	}

	[CompilerGenerated]
	private static bool CCJBKIKBKHP(Image GBCLDBHACGH)
	{
		return GBCLDBHACGH == null;
	}
}
