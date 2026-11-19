using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class CLLOJICBMEA : MonoBehaviour, IBeginDragHandler, IDragHandler, GCOMJHICFAB, IEventSystemHandler
{
	[Serializable]
	public class SelectionChangeStartEvent : UnityEvent
	{
	}

	[Serializable]
	public class SelectionPageChangedEvent : UnityEvent<int>
	{
	}

	[Serializable]
	public class SelectionChangeEndEvent : UnityEvent<int>
	{
	}

	internal Rect HKJKEIHLHBC;

	internal RectTransform CIIJLGEBFJC;

	internal bool NBIAFMGAIOC;

	internal int MJIFOHDGLGH = 1;

	internal float PNPADGBOJIO;

	internal float HMBJIEPFLNO;

	private float HOLICGJENJI;

	private float DLHNONFCONP;

	internal Vector2 ODFPGJFBKKH;

	internal ScrollRect MLGAAHHAMEN;

	internal Vector3 PBBIECOBIMP;

	internal bool MMLIINHECAD;

	internal bool HMANGOABAIE;

	internal bool KDHKNJKBGMB = true;

	internal Vector3 PDOLMPHAALB = default(Vector3);

	[Tooltip("The currently active page")]
	internal int APKEDCEFMGP;

	internal int GOLPFBPAIHM;

	internal int AMKMNBMIEKL;

	internal bool JHKDKPHHLNF;

	private int EMIFBMPNMMH;

	private int DPDKAGOKPCO;

	[Tooltip("The screen / page to start the control on\n*Note, this is a 0 indexed array")]
	[SerializeField]
	public int StartingScreen;

	[Range(0f, 8f)]
	[SerializeField]
	[Tooltip("The distance between two pages based on page height, by default pages are next to each other")]
	public float PageStep = 1f;

	[Tooltip("The gameobject that contains toggles which suggest pagination. (optional)")]
	public GameObject KHJIMAPPBHO;

	[Tooltip("Button to go to the previous page. (optional)")]
	public GameObject HLIAGFHAFOL;

	[Tooltip("Button to go to the next page. (optional)")]
	public GameObject LHJDINNGIMK;

	[Tooltip("Transition speed between pages. (optional)")]
	public float IFCNJIHKAPO = 7.5f;

	[Tooltip("Fast Swipe makes swiping page next / previous (optional)")]
	public bool NJBFBEGBKLF;

	[Tooltip("Offset for how far a swipe has to travel to initiate a page change (optional)")]
	public int AAEDCNOLIAF = 100;

	[Tooltip("Speed at which the ScrollRect will keep scrolling before slowing down and stopping (optional)")]
	public int DDDKDLGAKKB = 100;

	[Tooltip("The visible bounds area, controls which items are visible/enabled. *Note Should use a RectMask. (optional)")]
	public RectTransform CMANBHMNAMA;

	[Tooltip("Pixel size to buffer arround Mask Area. (optional)")]
	public float JEDNCIPJCAL = 1f;

	[Tooltip("By default the container will lerp to the start when enabled in the scene, this option overrides this and forces it to simply jump without lerping")]
	public bool DMCADOHDJJD;

	[Tooltip("By default the container will return to the original starting page when enabled, this option overrides this behaviour and stays on the current selection")]
	public bool DCKPOEMBFLD;

	[Tooltip("(Experimental)\nBy default, child array objects will use the parent transform\nHowever you can disable this for some interesting effects")]
	public bool BGBPKAOMGHL = true;

	[Tooltip("Scroll Snap children. (optional)\nEither place objects in the scene as children OR\nPrefabs in this array, NOT BOTH")]
	public GameObject[] HCLLCOBNNHP;

	[SerializeField]
	[Tooltip("Event fires when a user starts to change the selection")]
	private SelectionChangeStartEvent m_OnSelectionChangeStartEvent = new SelectionChangeStartEvent();

	[Tooltip("Event fires as the page changes, while dragging or jumping")]
	[SerializeField]
	private SelectionPageChangedEvent m_OnSelectionPageChangedEvent = new SelectionPageChangedEvent();

	[SerializeField]
	[Tooltip("Event fires when the page settles after a user has dragged")]
	private SelectionChangeEndEvent m_OnSelectionChangeEndEvent = new SelectionChangeEndEvent();

	public int PKKJBIDEMBH
	{
		get
		{
			return APKEDCEFMGP;
		}
		internal set
		{
			if ((value != APKEDCEFMGP && value >= 0 && value < CIIJLGEBFJC.childCount) || (value == 0 && CIIJLGEBFJC.childCount == 0))
			{
				GOLPFBPAIHM = APKEDCEFMGP;
				APKEDCEFMGP = value;
				if ((bool)CMANBHMNAMA)
				{
					IFAOCMEHKII();
				}
				if (!MMLIINHECAD)
				{
					IKHJOFPGJCK();
				}
				BKAOAPFOHHA(APKEDCEFMGP);
			}
		}
	}

	public SelectionChangeStartEvent FGMMALNAMMB
	{
		get
		{
			return m_OnSelectionChangeStartEvent;
		}
		set
		{
			m_OnSelectionChangeStartEvent = value;
		}
	}

	public SelectionPageChangedEvent GLKMJNNPDKJ
	{
		get
		{
			return m_OnSelectionPageChangedEvent;
		}
		set
		{
			m_OnSelectionPageChangedEvent = value;
		}
	}

	public SelectionChangeEndEvent PMNMBHFIACN
	{
		get
		{
			return m_OnSelectionChangeEndEvent;
		}
		set
		{
			m_OnSelectionChangeEndEvent = value;
		}
	}

	private void Awake()
	{
		if (MLGAAHHAMEN == null)
		{
			MLGAAHHAMEN = base.gameObject.GetComponent<ScrollRect>();
		}
		if ((bool)MLGAAHHAMEN.horizontalScrollbar && MLGAAHHAMEN.horizontal)
		{
			LKEBPANBIEG lKEBPANBIEG = MLGAAHHAMEN.horizontalScrollbar.gameObject.AddComponent<LKEBPANBIEG>();
			lKEBPANBIEG.AKLDKAGIIFG = this;
		}
		if ((bool)MLGAAHHAMEN.verticalScrollbar && MLGAAHHAMEN.vertical)
		{
			LKEBPANBIEG lKEBPANBIEG2 = MLGAAHHAMEN.verticalScrollbar.gameObject.AddComponent<LKEBPANBIEG>();
			lKEBPANBIEG2.AKLDKAGIIFG = this;
		}
		HKJKEIHLHBC = base.gameObject.GetComponent<RectTransform>().rect;
		if (StartingScreen < 0)
		{
			StartingScreen = 0;
		}
		CIIJLGEBFJC = MLGAAHHAMEN.content;
		DCIGCHANOON();
		if ((bool)LHJDINNGIMK)
		{
			LHJDINNGIMK.GetComponent<Button>().onClick.AddListener(delegate
			{
				NNKEMKABFND();
			});
		}
		if ((bool)HLIAGFHAFOL)
		{
			HLIAGFHAFOL.GetComponent<Button>().onClick.AddListener(delegate
			{
				IBJKIEHOPBK();
			});
		}
	}

	internal void DCIGCHANOON()
	{
		if (HCLLCOBNNHP != null && HCLLCOBNNHP.Length > 0)
		{
			if (CIIJLGEBFJC.transform.childCount > 0)
			{
				Debug.LogError("ScrollRect Content has children, this is not supported when using managed Child Objects\n Either remove the ScrollRect Content children or clear the ChildObjects array");
			}
			else
			{
				ANGMKFGLEDB();
			}
		}
		else
		{
			GHPHIJOAILA();
		}
	}

	internal void GHPHIJOAILA()
	{
		int childCount = CIIJLGEBFJC.childCount;
		HCLLCOBNNHP = new GameObject[childCount];
		for (int i = 0; i < childCount; i++)
		{
			HCLLCOBNNHP[i] = CIIJLGEBFJC.transform.GetChild(i).gameObject;
			if ((bool)CMANBHMNAMA && HCLLCOBNNHP[i].activeSelf)
			{
				HCLLCOBNNHP[i].SetActive(false);
			}
		}
	}

	internal void ANGMKFGLEDB()
	{
		int num = HCLLCOBNNHP.Length;
		for (int i = 0; i < num; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(HCLLCOBNNHP[i]);
			if (BGBPKAOMGHL)
			{
				RectTransform component = gameObject.GetComponent<RectTransform>();
				component.rotation = CIIJLGEBFJC.rotation;
				component.localScale = CIIJLGEBFJC.localScale;
				component.position = CIIJLGEBFJC.position;
			}
			gameObject.transform.SetParent(CIIJLGEBFJC.transform);
			HCLLCOBNNHP[i] = gameObject;
			if ((bool)CMANBHMNAMA && HCLLCOBNNHP[i].activeSelf)
			{
				HCLLCOBNNHP[i].SetActive(false);
			}
		}
	}

	internal void IFAOCMEHKII()
	{
		if (!CMANBHMNAMA || HCLLCOBNNHP == null || HCLLCOBNNHP.Length < 1 || CIIJLGEBFJC.childCount < 1)
		{
			return;
		}
		DLHNONFCONP = ((!NBIAFMGAIOC) ? CMANBHMNAMA.rect.width : CMANBHMNAMA.rect.height);
		AMKMNBMIEKL = (int)Math.Round(DLHNONFCONP / (HMBJIEPFLNO * JEDNCIPJCAL), MidpointRounding.AwayFromZero) / 2;
		EMIFBMPNMMH = (DPDKAGOKPCO = 0);
		for (int num = AMKMNBMIEKL + 1; num > 0; num--)
		{
			EMIFBMPNMMH = ((APKEDCEFMGP - num >= 0) ? num : 0);
			if (EMIFBMPNMMH > 0)
			{
				break;
			}
		}
		for (int num2 = AMKMNBMIEKL + 1; num2 > 0; num2--)
		{
			DPDKAGOKPCO = ((CIIJLGEBFJC.childCount - APKEDCEFMGP - num2 >= 0) ? num2 : 0);
			if (DPDKAGOKPCO > 0)
			{
				break;
			}
		}
		for (int i = PKKJBIDEMBH - EMIFBMPNMMH; i < PKKJBIDEMBH + DPDKAGOKPCO; i++)
		{
			try
			{
				HCLLCOBNNHP[i].SetActive(true);
			}
			catch
			{
				Debug.Log("Failed to setactive child [" + i + "]");
			}
		}
		if (APKEDCEFMGP > AMKMNBMIEKL)
		{
			HCLLCOBNNHP[PKKJBIDEMBH - EMIFBMPNMMH].SetActive(false);
		}
		if (CIIJLGEBFJC.childCount - APKEDCEFMGP > DPDKAGOKPCO)
		{
			HCLLCOBNNHP[PKKJBIDEMBH + DPDKAGOKPCO].SetActive(false);
		}
	}

	public void NNKEMKABFND()
	{
		if (APKEDCEFMGP < MJIFOHDGLGH - 1)
		{
			if (!MMLIINHECAD)
			{
				PLLNMOCPMDJ();
			}
			MMLIINHECAD = true;
			PKKJBIDEMBH = APKEDCEFMGP + 1;
			HMKBKLKMHOG(APKEDCEFMGP, ref PBBIECOBIMP);
			IKHJOFPGJCK();
		}
	}

	public void IBJKIEHOPBK()
	{
		if (APKEDCEFMGP > 0)
		{
			if (!MMLIINHECAD)
			{
				PLLNMOCPMDJ();
			}
			MMLIINHECAD = true;
			PKKJBIDEMBH = APKEDCEFMGP - 1;
			HMKBKLKMHOG(APKEDCEFMGP, ref PBBIECOBIMP);
			IKHJOFPGJCK();
		}
	}

	public void KGIJFBMOJPM(int AAPMABOOLNF)
	{
		if (AAPMABOOLNF <= MJIFOHDGLGH - 1 && AAPMABOOLNF >= 0)
		{
			if (!MMLIINHECAD)
			{
				PLLNMOCPMDJ();
			}
			MMLIINHECAD = true;
			PKKJBIDEMBH = AAPMABOOLNF;
			HMKBKLKMHOG(APKEDCEFMGP, ref PBBIECOBIMP);
			IKHJOFPGJCK();
		}
	}

	internal int JHNAJEMCIOP(Vector3 ELGIKGAIIOD)
	{
		return (!NBIAFMGAIOC) ? ((int)Math.Round((PNPADGBOJIO - ELGIKGAIIOD.x) / HMBJIEPFLNO)) : ((int)Math.Round((PNPADGBOJIO - ELGIKGAIIOD.y) / HMBJIEPFLNO));
	}

	internal bool JFBIAJNPHGN(Vector3 ELGIKGAIIOD)
	{
		return (!NBIAFMGAIOC) ? (0f - (ELGIKGAIIOD.x - PNPADGBOJIO) / HMBJIEPFLNO == (float)(-(int)Math.Round((ELGIKGAIIOD.x - PNPADGBOJIO) / HMBJIEPFLNO))) : (0f - (ELGIKGAIIOD.y - PNPADGBOJIO) / HMBJIEPFLNO == (float)(-(int)Math.Round((ELGIKGAIIOD.y - PNPADGBOJIO) / HMBJIEPFLNO)));
	}

	internal void HMKBKLKMHOG(int IDLNFNNFLDN, ref Vector3 EPCKLAKNAAG)
	{
		HOLICGJENJI = (0f - HMBJIEPFLNO) * (float)IDLNFNNFLDN;
		if (NBIAFMGAIOC)
		{
			EPCKLAKNAAG.y = HOLICGJENJI + PNPADGBOJIO;
		}
		else
		{
			EPCKLAKNAAG.x = HOLICGJENJI + PNPADGBOJIO;
		}
	}

	internal void HFDNGOOPIIM()
	{
		MMLIINHECAD = true;
		PKKJBIDEMBH = JHNAJEMCIOP(CIIJLGEBFJC.localPosition);
		HMKBKLKMHOG(APKEDCEFMGP, ref PBBIECOBIMP);
		BKAOAPFOHHA(APKEDCEFMGP);
	}

	internal void BKAOAPFOHHA(int GBDLJGOCNCG)
	{
		BLLLMEILBNI(GBDLJGOCNCG);
		JGCGNDNJAGB(GBDLJGOCNCG);
	}

	private void BLLLMEILBNI(int DACOBJCPHAE)
	{
		if ((bool)KHJIMAPPBHO)
		{
			for (int i = 0; i < KHJIMAPPBHO.transform.childCount; i++)
			{
				KHJIMAPPBHO.transform.GetChild(i).GetComponent<Toggle>().isOn = ((DACOBJCPHAE == i) ? true : false);
			}
		}
	}

	private void JGCGNDNJAGB(int DACOBJCPHAE)
	{
		if ((bool)HLIAGFHAFOL)
		{
			HLIAGFHAFOL.GetComponent<Button>().interactable = DACOBJCPHAE > 0;
		}
		if ((bool)LHJDINNGIMK)
		{
			LHJDINNGIMK.GetComponent<Button>().interactable = DACOBJCPHAE < CIIJLGEBFJC.transform.childCount - 1;
		}
	}

	private void OnValidate()
	{
		if (MLGAAHHAMEN == null)
		{
			MLGAAHHAMEN = GetComponent<ScrollRect>();
		}
		if (!MLGAAHHAMEN.horizontal && !MLGAAHHAMEN.vertical)
		{
			Debug.LogError("ScrollRect has to have a direction, please select either Horizontal OR Vertical with the appropriate control.");
		}
		if (MLGAAHHAMEN.horizontal && MLGAAHHAMEN.vertical)
		{
			Debug.LogError("ScrollRect has to be unidirectional, only use either Horizontal or Vertical on the ScrollRect, NOT both.");
		}
		int childCount = base.gameObject.GetComponent<ScrollRect>().content.childCount;
		if (childCount != 0 || HCLLCOBNNHP != null)
		{
			int num = ((HCLLCOBNNHP != null && HCLLCOBNNHP.Length != 0) ? HCLLCOBNNHP.Length : childCount);
			if (StartingScreen > num - 1)
			{
				StartingScreen = num - 1;
			}
			if (StartingScreen < 0)
			{
				StartingScreen = 0;
			}
		}
		if (JEDNCIPJCAL <= 0f)
		{
			JEDNCIPJCAL = 1f;
		}
		if (PageStep < 0f)
		{
			PageStep = 0f;
		}
		if (PageStep > 8f)
		{
			PageStep = 9f;
		}
	}

	public void PLLNMOCPMDJ()
	{
		if (!JHKDKPHHLNF)
		{
			JHKDKPHHLNF = true;
			FGMMALNAMMB.Invoke();
		}
	}

	internal void IKHJOFPGJCK()
	{
		GLKMJNNPDKJ.Invoke(APKEDCEFMGP);
	}

	internal void BACPABBAGJO()
	{
		PMNMBHFIACN.Invoke(APKEDCEFMGP);
		KDHKNJKBGMB = true;
		JHKDKPHHLNF = false;
	}

	public Transform GPIHJDMMBOA()
	{
		return CIIJLGEBFJC.GetChild(PKKJBIDEMBH);
	}

	public void GPIHJDMMBOA(out Transform OICDGABPMFJ)
	{
		OICDGABPMFJ = CIIJLGEBFJC.GetChild(PKKJBIDEMBH);
	}

	public void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		HMANGOABAIE = true;
		KDHKNJKBGMB = false;
		PLLNMOCPMDJ();
		PDOLMPHAALB = CIIJLGEBFJC.localPosition;
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		MMLIINHECAD = false;
	}

	int GCOMJHICFAB.CurrentPage()
	{
		return PKKJBIDEMBH = JHNAJEMCIOP(CIIJLGEBFJC.localPosition);
	}

	public void LKLOHLPDNLN(bool EHAPKEKPMOE)
	{
		MMLIINHECAD = EHAPKEKPMOE;
	}

	public void BGADMPCBOHJ(int IDLNFNNFLDN)
	{
		KGIJFBMOJPM(IDLNFNNFLDN);
	}

	[CompilerGenerated]
	private void CODPAIAOGEL()
	{
		NNKEMKABFND();
	}

	[CompilerGenerated]
	private void DPPCKFLKPHL()
	{
		IBJKIEHOPBK();
	}
}
