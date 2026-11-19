using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(ScrollRect))]
[AddComponentMenu("UI/Extensions/Scroll Snap")]
public class KKFLDFBPJNO : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, GCOMJHICFAB, IEventSystemHandler
{
	public enum MKHIHMMIKGD
	{
		CKGPDOGEHBB,
		IOKNFMCJIHM
	}

	public delegate void KHOJMIBIFID(int IDLNFNNFLDN);

	private ScrollRect MLGAAHHAMEN;

	private RectTransform DAACBPDBFFA;

	private Transform FDKNFAOCJON;

	private int KDADCMMLJIP;

	private int LMDDJBBONHK;

	private Vector3[] CHAFDHBBPDK;

	private Vector3 OINHILLMCOA;

	private bool MMLIINHECAD;

	private float OKHPIIIJHPA;

	private float BOHEMFEAIIE;

	private float IHKCDAPJHNK;

	private RectTransform GMKPNLFCKEL;

	private Vector2 NIBNLKAJHFG;

	private float HDKEIFEMMFG;

	private int NAPJLMKIMCE;

	private bool NLMDIOKKIMF = true;

	private Vector3 JBKONGMBJBK = default(Vector3);

	private int FEHOJPLGMDN;

	private bool FJMCNHBNCHJ;

	private int KNJGLNIBPNI;

	private int DPIHNGJKBNM = 10;

	[Tooltip("Button to go to the next page. (optional)")]
	public Button LHJDINNGIMK;

	[Tooltip("Button to go to the previous page. (optional)")]
	public Button HLIAGFHAFOL;

	[Range(1f, 100f)]
	[Tooltip("Number of items visible in one page of scroll frame.")]
	public int AEIOIJFJHAP = 1;

	[Tooltip("Sets minimum width of list items to 1/itemsVisibleAtOnce.")]
	public bool NGHMBAEIICE = true;

	[Tooltip("If you wish to update scrollbar numberOfSteps to number of active children on list.")]
	public bool NDJEJDEPDBM;

	[Tooltip("If you wish to update scrollrect sensitivity to size of list element.")]
	public bool OALLGBLEPFI;

	public bool NJBFBEGBKLF = true;

	public int AAEDCNOLIAF = 100;

	public MKHIHMMIKGD BADIHIKMKJF;

	private bool FPOGFFLMOJK;

	public event KHOJMIBIFID DLAMDHDOEGL;

	private void Start()
	{
		MMLIINHECAD = false;
		MLGAAHHAMEN = base.gameObject.GetComponent<ScrollRect>();
		DAACBPDBFFA = base.gameObject.GetComponent<RectTransform>();
		FDKNFAOCJON = MLGAAHHAMEN.content;
		GMKPNLFCKEL = FDKNFAOCJON.GetComponent<RectTransform>();
		CDLFECHNEDA();
		IECGLJJGALP();
		GOPNDAOKGNH(PKKJBIDEMBH());
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
		if (MLGAAHHAMEN.horizontalScrollbar != null && MLGAAHHAMEN.horizontal)
		{
			LKEBPANBIEG lKEBPANBIEG = MLGAAHHAMEN.horizontalScrollbar.gameObject.AddComponent<LKEBPANBIEG>();
			lKEBPANBIEG.AKLDKAGIIFG = this;
		}
		if (MLGAAHHAMEN.verticalScrollbar != null && MLGAAHHAMEN.vertical)
		{
			LKEBPANBIEG lKEBPANBIEG2 = MLGAAHHAMEN.verticalScrollbar.gameObject.AddComponent<LKEBPANBIEG>();
			lKEBPANBIEG2.AKLDKAGIIFG = this;
		}
	}

	public void CDLFECHNEDA()
	{
		float num = 0f;
		float num2 = 0f;
		if (BADIHIKMKJF == MKHIHMMIKGD.CKGPDOGEHBB)
		{
			num = DAACBPDBFFA.rect.width / (float)AEIOIJFJHAP;
			num2 = GMKPNLFCKEL.rect.width / (float)NAPJLMKIMCE;
		}
		else
		{
			num = DAACBPDBFFA.rect.height / (float)AEIOIJFJHAP;
			num2 = GMKPNLFCKEL.rect.height / (float)NAPJLMKIMCE;
		}
		HDKEIFEMMFG = num;
		if (OALLGBLEPFI)
		{
			MLGAAHHAMEN.scrollSensitivity = HDKEIFEMMFG;
		}
		if (!NGHMBAEIICE || num2 == num || NAPJLMKIMCE <= 0)
		{
			return;
		}
		if (BADIHIKMKJF == MKHIHMMIKGD.CKGPDOGEHBB)
		{
			foreach (object item in FDKNFAOCJON)
			{
				GameObject gameObject = ((Transform)item).gameObject;
				if (gameObject.activeInHierarchy)
				{
					LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
					if (layoutElement == null)
					{
						layoutElement = gameObject.AddComponent<LayoutElement>();
					}
					layoutElement.minWidth = HDKEIFEMMFG;
				}
			}
			return;
		}
		foreach (object item2 in FDKNFAOCJON)
		{
			GameObject gameObject2 = ((Transform)item2).gameObject;
			if (gameObject2.activeInHierarchy)
			{
				LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
				if (layoutElement2 == null)
				{
					layoutElement2 = gameObject2.AddComponent<LayoutElement>();
				}
				layoutElement2.minHeight = HDKEIFEMMFG;
			}
		}
	}

	public void IECGLJJGALP()
	{
		if (GMKPNLFCKEL.rect.size.Equals(NIBNLKAJHFG))
		{
			return;
		}
		int num = 0;
		foreach (object item in FDKNFAOCJON)
		{
			if (((Transform)item).gameObject.activeInHierarchy)
			{
				num++;
			}
		}
		NAPJLMKIMCE = 0;
		Array.Resize(ref CHAFDHBBPDK, num);
		if (num > 0)
		{
			KDADCMMLJIP = Mathf.Max(num - AEIOIJFJHAP + 1, 1);
			if (BADIHIKMKJF == MKHIHMMIKGD.CKGPDOGEHBB)
			{
				MLGAAHHAMEN.horizontalNormalizedPosition = 0f;
				BOHEMFEAIIE = FDKNFAOCJON.localPosition.x;
				MLGAAHHAMEN.horizontalNormalizedPosition = 1f;
				OKHPIIIJHPA = FDKNFAOCJON.localPosition.x;
				IHKCDAPJHNK = BOHEMFEAIIE - OKHPIIIJHPA;
				for (int i = 0; i < KDADCMMLJIP; i++)
				{
					ref Vector3 reference = ref CHAFDHBBPDK[i];
					reference = new Vector3(BOHEMFEAIIE - HDKEIFEMMFG * (float)i, FDKNFAOCJON.localPosition.y, FDKNFAOCJON.localPosition.z);
				}
			}
			else
			{
				MLGAAHHAMEN.verticalNormalizedPosition = 1f;
				OKHPIIIJHPA = FDKNFAOCJON.localPosition.y;
				MLGAAHHAMEN.verticalNormalizedPosition = 0f;
				BOHEMFEAIIE = FDKNFAOCJON.localPosition.y;
				IHKCDAPJHNK = BOHEMFEAIIE - OKHPIIIJHPA;
				for (int j = 0; j < KDADCMMLJIP; j++)
				{
					ref Vector3 reference2 = ref CHAFDHBBPDK[j];
					reference2 = new Vector3(FDKNFAOCJON.localPosition.x, OKHPIIIJHPA + HDKEIFEMMFG * (float)j, FDKNFAOCJON.localPosition.z);
				}
			}
			AEBFGGPAAJL(NDJEJDEPDBM);
			LMDDJBBONHK = Mathf.Min(LMDDJBBONHK, KDADCMMLJIP);
			IGOGBJNHEBM();
		}
		if (NAPJLMKIMCE != num)
		{
			GOPNDAOKGNH(PKKJBIDEMBH());
		}
		NAPJLMKIMCE = num;
		NIBNLKAJHFG.Set(GMKPNLFCKEL.rect.size.x, GMKPNLFCKEL.rect.size.y);
	}

	public void IGOGBJNHEBM()
	{
		if (BADIHIKMKJF == MKHIHMMIKGD.CKGPDOGEHBB)
		{
			MLGAAHHAMEN.horizontalNormalizedPosition = ((KDADCMMLJIP <= 1) ? 0f : ((float)LMDDJBBONHK / (float)(KDADCMMLJIP - 1)));
		}
		else
		{
			MLGAAHHAMEN.verticalNormalizedPosition = ((KDADCMMLJIP <= 1) ? 0f : ((float)(KDADCMMLJIP - LMDDJBBONHK - 1) / (float)(KDADCMMLJIP - 1)));
		}
	}

	private void AEBFGGPAAJL(bool KHJMCPOJJMF)
	{
		if (KHJMCPOJJMF)
		{
			if (BADIHIKMKJF == MKHIHMMIKGD.CKGPDOGEHBB)
			{
				if (MLGAAHHAMEN.horizontalScrollbar != null)
				{
					MLGAAHHAMEN.horizontalScrollbar.numberOfSteps = KDADCMMLJIP;
				}
			}
			else if (MLGAAHHAMEN.verticalScrollbar != null)
			{
				MLGAAHHAMEN.verticalScrollbar.numberOfSteps = KDADCMMLJIP;
			}
		}
		else if (BADIHIKMKJF == MKHIHMMIKGD.CKGPDOGEHBB)
		{
			if (MLGAAHHAMEN.horizontalScrollbar != null)
			{
				MLGAAHHAMEN.horizontalScrollbar.numberOfSteps = 0;
			}
		}
		else if (MLGAAHHAMEN.verticalScrollbar != null)
		{
			MLGAAHHAMEN.verticalScrollbar.numberOfSteps = 0;
		}
	}

	private void LateUpdate()
	{
		CDLFECHNEDA();
		IECGLJJGALP();
		if (MMLIINHECAD)
		{
			AEBFGGPAAJL(KHJMCPOJJMF: false);
			FDKNFAOCJON.localPosition = Vector3.Lerp(FDKNFAOCJON.localPosition, OINHILLMCOA, 7.5f * Time.deltaTime);
			if (Vector3.Distance(FDKNFAOCJON.localPosition, OINHILLMCOA) < 0.001f)
			{
				FDKNFAOCJON.localPosition = OINHILLMCOA;
				MMLIINHECAD = false;
				AEBFGGPAAJL(NDJEJDEPDBM);
			}
			if (Vector3.Distance(FDKNFAOCJON.localPosition, OINHILLMCOA) < 10f)
			{
				GOPNDAOKGNH(PKKJBIDEMBH());
			}
		}
		if (FJMCNHBNCHJ)
		{
			KNJGLNIBPNI++;
		}
	}

	public void NNKEMKABFND()
	{
		IECGLJJGALP();
		if (PKKJBIDEMBH() < KDADCMMLJIP - 1)
		{
			MMLIINHECAD = true;
			OINHILLMCOA = CHAFDHBBPDK[PKKJBIDEMBH() + 1];
			GOPNDAOKGNH(PKKJBIDEMBH() + 1);
		}
	}

	public void IBJKIEHOPBK()
	{
		IECGLJJGALP();
		if (PKKJBIDEMBH() > 0)
		{
			MMLIINHECAD = true;
			OINHILLMCOA = CHAFDHBBPDK[PKKJBIDEMBH() - 1];
			GOPNDAOKGNH(PKKJBIDEMBH() - 1);
		}
	}

	private void GNMBJEJHCNM()
	{
		if (FEHOJPLGMDN < KDADCMMLJIP - 1)
		{
			int num = Mathf.Min(KDADCMMLJIP - 1, FEHOJPLGMDN + AEIOIJFJHAP);
			MMLIINHECAD = true;
			OINHILLMCOA = CHAFDHBBPDK[num];
			GOPNDAOKGNH(num);
		}
	}

	private void EGLOAPPPALL()
	{
		if (FEHOJPLGMDN > 0)
		{
			int num = Mathf.Max(0, FEHOJPLGMDN - AEIOIJFJHAP);
			MMLIINHECAD = true;
			OINHILLMCOA = CHAFDHBBPDK[num];
			GOPNDAOKGNH(num);
		}
	}

	public int PKKJBIDEMBH()
	{
		float value;
		if (BADIHIKMKJF == MKHIHMMIKGD.CKGPDOGEHBB)
		{
			value = BOHEMFEAIIE - FDKNFAOCJON.localPosition.x;
			value = Mathf.Clamp(value, 0f, IHKCDAPJHNK);
		}
		else
		{
			value = FDKNFAOCJON.localPosition.y - OKHPIIIJHPA;
			value = Mathf.Clamp(value, 0f, IHKCDAPJHNK);
		}
		float f = value / HDKEIFEMMFG;
		return Mathf.Clamp(Mathf.RoundToInt(f), 0, KDADCMMLJIP);
	}

	public void LKLOHLPDNLN(bool EHAPKEKPMOE)
	{
		MMLIINHECAD = EHAPKEKPMOE;
	}

	public void BGADMPCBOHJ(int IDLNFNNFLDN)
	{
		if (0 <= IDLNFNNFLDN && IDLNFNNFLDN < KDADCMMLJIP)
		{
			MMLIINHECAD = true;
			OINHILLMCOA = CHAFDHBBPDK[IDLNFNNFLDN];
			GOPNDAOKGNH(IDLNFNNFLDN);
		}
	}

	private void GOPNDAOKGNH(int PAIAMNLHNMH)
	{
		LMDDJBBONHK = PAIAMNLHNMH;
		if ((bool)LHJDINNGIMK)
		{
			LHJDINNGIMK.interactable = PAIAMNLHNMH < KDADCMMLJIP - 1;
		}
		if ((bool)HLIAGFHAFOL)
		{
			HLIAGFHAFOL.interactable = PAIAMNLHNMH > 0;
		}
		if (this.DLAMDHDOEGL != null)
		{
			this.DLAMDHDOEGL(PAIAMNLHNMH);
		}
	}

	public void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		AEBFGGPAAJL(KHJMCPOJJMF: false);
		KNJGLNIBPNI = 0;
		FJMCNHBNCHJ = true;
		JBKONGMBJBK = GBOFEMOALII.position;
		FEHOJPLGMDN = PKKJBIDEMBH();
	}

	public void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		NLMDIOKKIMF = true;
		float num = 0f;
		num = ((BADIHIKMKJF != 0) ? (0f - JBKONGMBJBK.y + GBOFEMOALII.position.y) : (JBKONGMBJBK.x - GBOFEMOALII.position.x));
		if (NJBFBEGBKLF)
		{
			FPOGFFLMOJK = false;
			FJMCNHBNCHJ = false;
			if (KNJGLNIBPNI <= DPIHNGJKBNM && Math.Abs(num) > (float)AAEDCNOLIAF)
			{
				FPOGFFLMOJK = true;
			}
			if (FPOGFFLMOJK)
			{
				if (num > 0f)
				{
					GNMBJEJHCNM();
				}
				else
				{
					EGLOAPPPALL();
				}
			}
			else
			{
				MMLIINHECAD = true;
				OINHILLMCOA = CHAFDHBBPDK[PKKJBIDEMBH()];
			}
		}
		else
		{
			MMLIINHECAD = true;
			OINHILLMCOA = CHAFDHBBPDK[PKKJBIDEMBH()];
		}
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		MMLIINHECAD = false;
		if (NLMDIOKKIMF)
		{
			OnBeginDrag(GBOFEMOALII);
			NLMDIOKKIMF = false;
		}
	}

	public void PLLNMOCPMDJ()
	{
	}

	[CompilerGenerated]
	private void JDGOKBJLEBB()
	{
		NNKEMKABFND();
	}

	[CompilerGenerated]
	private void CGHOOLFHOMD()
	{
		IBJKIEHOPBK();
	}
}
