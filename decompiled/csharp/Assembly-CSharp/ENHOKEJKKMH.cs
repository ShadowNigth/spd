using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
[AddComponentMenu("Layout/Extensions/Vertical Scroller")]
public class ENHOKEJKKMH : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class FIPGMBPNCOK
	{
		internal int JNDABHCJHHD;

		internal ENHOKEJKKMH KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			KPHCHDHEKGH.HEFFMNAPJFI(JNDABHCJHHD);
		}
	}

	[Tooltip("Scrollable area (content of desired ScrollRect)")]
	public RectTransform DKJPAEEDJDB;

	[Tooltip("Elements to populate inside the scroller")]
	public GameObject[] CFIAHMHCIIB;

	[Tooltip("Center display area (position of zoomed content)")]
	public RectTransform LJOMPCFDMDI;

	[Tooltip("Select the item to be in center on start. (optional)")]
	public int NEJCBKINODK = -1;

	[Tooltip("Button to go to the next page. (optional)")]
	public GameObject JDBMOLGDMNO;

	[Tooltip("Button to go to the previous page. (optional)")]
	public GameObject GCCGLFHHHJN;

	[Tooltip("Event fired when a specific item is clicked, exposes index number of item. (optional)")]
	public UnityEvent<int> CACAGBDLJFJ;

	private float[] OFGCFIECEPP;

	private float[] IBKGHLIGCBN;

	private int ONGPCPOLDMH;

	private int JMHIIPHFBAH;

	private float IHFHJMAPBOH;

	private string NMOAEBLHDEB;

	public ENHOKEJKKMH()
	{
	}

	public ENHOKEJKKMH(RectTransform MADMJOMBFFM, GameObject[] KDIPNPGIFHL, RectTransform LKBIKDGBMAL)
	{
		DKJPAEEDJDB = MADMJOMBFFM;
		CFIAHMHCIIB = KDIPNPGIFHL;
		LJOMPCFDMDI = LKBIKDGBMAL;
	}

	public void Awake()
	{
		ScrollRect component = GetComponent<ScrollRect>();
		if (!DKJPAEEDJDB)
		{
			DKJPAEEDJDB = component.content;
		}
		if (!LJOMPCFDMDI)
		{
			Debug.LogError("Please define the RectTransform for the Center viewport of the scrollable area");
		}
		if (CFIAHMHCIIB != null && CFIAHMHCIIB.Length != 0)
		{
			return;
		}
		int childCount = component.content.childCount;
		if (childCount > 0)
		{
			CFIAHMHCIIB = new GameObject[childCount];
			for (int i = 0; i < childCount; i++)
			{
				CFIAHMHCIIB[i] = component.content.GetChild(i).gameObject;
			}
		}
	}

	public void Start()
	{
		if (CFIAHMHCIIB.Length < 1)
		{
			Debug.Log("No child content found, exiting..");
			return;
		}
		JMHIIPHFBAH = CFIAHMHCIIB.Length;
		IBKGHLIGCBN = new float[JMHIIPHFBAH];
		OFGCFIECEPP = new float[JMHIIPHFBAH];
		IHFHJMAPBOH = CFIAHMHCIIB[0].GetComponent<RectTransform>().rect.height * (float)JMHIIPHFBAH / 3f * 2f;
		Vector2 anchoredPosition = new Vector2(DKJPAEEDJDB.anchoredPosition.x, 0f - IHFHJMAPBOH);
		DKJPAEEDJDB.anchoredPosition = anchoredPosition;
		for (int i = 0; i < CFIAHMHCIIB.Length; i++)
		{
			NECGJOKHBGM(CFIAHMHCIIB[i], i);
		}
		if ((bool)JDBMOLGDMNO)
		{
			JDBMOLGDMNO.GetComponent<Button>().onClick.AddListener(delegate
			{
				GNNAGHKEBHE();
			});
		}
		if ((bool)GCCGLFHHHJN)
		{
			GCCGLFHHHJN.GetComponent<Button>().onClick.AddListener(delegate
			{
				PIBFILIFOBI();
			});
		}
		if (NEJCBKINODK > -1)
		{
			NEJCBKINODK = ((NEJCBKINODK <= CFIAHMHCIIB.Length) ? NEJCBKINODK : (CFIAHMHCIIB.Length - 1));
			LGNGEBMKDLP(NEJCBKINODK);
		}
	}

	private void NECGJOKHBGM(GameObject PMHLHIIDMEG, int JNDABHCJHHD)
	{
		PMHLHIIDMEG.GetComponent<Button>().onClick.AddListener(delegate
		{
			HEFFMNAPJFI(JNDABHCJHHD);
		});
	}

	private void HEFFMNAPJFI(int JNDABHCJHHD)
	{
		if (CACAGBDLJFJ != null)
		{
			CACAGBDLJFJ.Invoke(JNDABHCJHHD);
		}
	}

	public void Update()
	{
		if (CFIAHMHCIIB.Length < 1)
		{
			return;
		}
		for (int i = 0; i < JMHIIPHFBAH; i++)
		{
			OFGCFIECEPP[i] = LJOMPCFDMDI.GetComponent<RectTransform>().position.y - CFIAHMHCIIB[i].GetComponent<RectTransform>().position.y;
			IBKGHLIGCBN[i] = Mathf.Abs(OFGCFIECEPP[i]);
			float num = Mathf.Max(0.7f, 1f / (1f + IBKGHLIGCBN[i] / 200f));
			CFIAHMHCIIB[i].GetComponent<RectTransform>().transform.localScale = new Vector3(num, num, 1f);
		}
		float num2 = Mathf.Min(IBKGHLIGCBN);
		for (int j = 0; j < JMHIIPHFBAH; j++)
		{
			CFIAHMHCIIB[j].GetComponent<CanvasGroup>().interactable = false;
			if (num2 == IBKGHLIGCBN[j])
			{
				ONGPCPOLDMH = j;
				CFIAHMHCIIB[j].GetComponent<CanvasGroup>().interactable = true;
				NMOAEBLHDEB = CFIAHMHCIIB[j].GetComponentInChildren<Text>().text;
			}
		}
		DJFCIEHLAPL(0f - CFIAHMHCIIB[ONGPCPOLDMH].GetComponent<RectTransform>().anchoredPosition.y);
	}

	private void DJFCIEHLAPL(float GIDEOJGAFJH)
	{
		float y = Mathf.Lerp(DKJPAEEDJDB.anchoredPosition.y, GIDEOJGAFJH, Time.deltaTime * 1f);
		Vector2 anchoredPosition = new Vector2(DKJPAEEDJDB.anchoredPosition.x, y);
		DKJPAEEDJDB.anchoredPosition = anchoredPosition;
	}

	public string LBILGMBGDNP()
	{
		return NMOAEBLHDEB;
	}

	public void LGNGEBMKDLP(int MLDGFBHKOCN)
	{
		float num = CFIAHMHCIIB[0].GetComponent<RectTransform>().rect.height * (float)MLDGFBHKOCN;
		Vector2 anchoredPosition = new Vector2(DKJPAEEDJDB.anchoredPosition.x, 0f - num);
		DKJPAEEDJDB.anchoredPosition = anchoredPosition;
	}

	public void GNNAGHKEBHE()
	{
		float num = CFIAHMHCIIB[0].GetComponent<RectTransform>().rect.height / 1.2f;
		Vector2 b = new Vector2(DKJPAEEDJDB.anchoredPosition.x, DKJPAEEDJDB.anchoredPosition.y - num);
		DKJPAEEDJDB.anchoredPosition = Vector2.Lerp(DKJPAEEDJDB.anchoredPosition, b, 1f);
	}

	public void PIBFILIFOBI()
	{
		float num = CFIAHMHCIIB[0].GetComponent<RectTransform>().rect.height / 1.2f;
		Vector2 anchoredPosition = new Vector2(DKJPAEEDJDB.anchoredPosition.x, DKJPAEEDJDB.anchoredPosition.y + num);
		DKJPAEEDJDB.anchoredPosition = anchoredPosition;
	}

	[CompilerGenerated]
	private void JDGOKBJLEBB()
	{
		GNNAGHKEBHE();
	}

	[CompilerGenerated]
	private void CGHOOLFHOMD()
	{
		PIBFILIFOBI();
	}
}
