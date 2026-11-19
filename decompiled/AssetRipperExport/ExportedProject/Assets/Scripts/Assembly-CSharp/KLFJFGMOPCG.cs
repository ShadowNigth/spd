using SPD.EditorAttributes;
using UnityEngine;
using UnityEngine.UI;

public class KLFJFGMOPCG : FOGIOGKLNIP
{
	[Separator("TARGET")]
	[Tooltip("UI Prefab")]
	public GameObject OKMPLMOAMCL;

	[Tooltip("Transform to UI Icon will be follow")]
	public Transform JBLHHCNLIAJ;

	[Tooltip("Custom Position from target position")]
	public Vector3 BPNCNIBKGMA = Vector3.zero;

	[Separator("ICON")]
	public Sprite FNEFPKDFDAP;

	public Sprite MEEOMHDDGEK;

	public Color KDNEJKPIFHA = new Color(1f, 1f, 1f, 0.9f);

	[Range(1f, 100f)]
	public float PPLJEHCDHLA = 20f;

	[Separator("CIRCLE AREA")]
	public bool PJGBNALGNHP;

	[Range(1f, 100f)]
	public float NANMNFGBKDJ = 10f;

	public Color BCIAMPCFHGH = new Color(1f, 1f, 1f, 0.9f);

	[Tooltip("UI can interact when press it?")]
	[Separator("ICON BUTTON")]
	[CustomToggle("is Interact-able")]
	public bool IDFNEFKMDIB = true;

	[TextArea(2, 2)]
	public string MEKJFIOEDPI = "Info Icon here";

	[Tooltip("Can Icon / Text show when is off screen?")]
	[Separator("SETTINGS")]
	[CustomToggle("Off Screen")]
	public bool FAJCKMEDFJL = true;

	[CustomToggle("Destroy Icon with object")]
	public bool NOLBOFKEBAI;

	[Range(0f, 5f)]
	public float GALLAAHEKOJ = 0.01f;

	[Range(1f, 50f)]
	public float BCBCCBDHGPH = 10f;

	[CustomToggle("isHoofdPunt")]
	public bool LFOAOMCOOML;

	[Range(0f, 3f)]
	[Tooltip("Time before render/show item in minimap after instance")]
	public float PAFMHEFCKFJ = 0.3f;

	public BEEODMJBIIK CBCJFPHCHON = BEEODMJBIIK.BLBOPPEBDFH;

	internal Image FNELAENIDML;

	private RectTransform HDLHDCHJGJH;

	internal GameObject LOPJEPPAFPH;

	private RectTransform IEJLDLJMIAG;

	internal Vector3 GIDEOJGAFJH;

	private HFEIGOBNJHD FLAOLGPBHOO;

	private HFEIGOBNJHD LKBEGPJJCBA;

	public Vector3 JOAINBENLAK
	{
		get
		{
			if (JBLHHCNLIAJ == null)
			{
				return Vector3.zero;
			}
			return new Vector3(JBLHHCNLIAJ.position.x, 0f, JBLHHCNLIAJ.position.z);
		}
	}

	private HFEIGOBNJHD MCAILHEHEBB
	{
		get
		{
			if (LKBEGPJJCBA == null)
			{
				LKBEGPJJCBA = LOPJEPPAFPH.transform.root.GetComponentInChildren<HFEIGOBNJHD>();
			}
			return LKBEGPJJCBA;
		}
	}

	private void Start()
	{
		if (!FOGIOGKLNIP.PIOANBBCFFP.NBLJJDANCFG)
		{
			FLAOLGPBHOO = EJONJMEGEKJ.HJBIHDIGPKG();
			if (HFEIGOBNJHD.ENIHNMIIDME != null)
			{
				CACKNFCCFME();
			}
			else
			{
				Debug.Log("You need a MiniMap in scene for use MiniMap Items.");
			}
		}
	}

	private void CACKNFCCFME()
	{
		LOPJEPPAFPH = Object.Instantiate(OKMPLMOAMCL);
		HDLHDCHJGJH = EJONJMEGEKJ.HJBIHDIGPKG().IPINMKGEKJJ;
		FNELAENIDML = LOPJEPPAFPH.GetComponent<Image>();
		if (FNEFPKDFDAP != null)
		{
			FNELAENIDML.sprite = FNEFPKDFDAP;
			FNELAENIDML.color = KDNEJKPIFHA;
		}
		LOPJEPPAFPH.transform.SetParent(HDLHDCHJGJH.transform, false);
		FNELAENIDML.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
		LOPJEPPAFPH.GetComponent<CanvasGroup>().interactable = IDFNEFKMDIB;
		if (JBLHHCNLIAJ == null)
		{
			JBLHHCNLIAJ = GetComponent<Transform>();
		}
		KEDMLMNOKLH();
		DBDCHDJAEEF component = LOPJEPPAFPH.GetComponent<DBDCHDJAEEF>();
		component.NDCOHIJKLIP(PAFMHEFCKFJ);
		component.NNDPLGOCGII(MEKJFIOEDPI);
		if (PJGBNALGNHP)
		{
			IEJLDLJMIAG = component.FAIBPHBCFCM(NANMNFGBKDJ, BCIAMPCFHGH);
		}
	}

	private void Update()
	{
		if (!(JBLHHCNLIAJ == null) && !(FNELAENIDML == null))
		{
			if (LFOAOMCOOML && FLAOLGPBHOO.JBLHHCNLIAJ != null)
			{
				EHOEFMPLIFB.position = FLAOLGPBHOO.JBLHHCNLIAJ.TransformPoint(FLAOLGPBHOO.JBLHHCNLIAJ.forward * 100f);
			}
			RectTransform component = FNELAENIDML.GetComponent<RectTransform>();
			Vector3 position = JOAINBENLAK + BPNCNIBKGMA;
			Vector2 vector = HFEIGOBNJHD.GIFGJFEBGED.WorldToViewportPoint(position);
			GIDEOJGAFJH = new Vector2(vector.x * HDLHDCHJGJH.sizeDelta.x - HDLHDCHJGJH.sizeDelta.x * 0.5f, vector.y * HDLHDCHJGJH.sizeDelta.y - HDLHDCHJGJH.sizeDelta.y * 0.5f);
			Vector2 anchoredPosition = GIDEOJGAFJH;
			if (FAJCKMEDFJL)
			{
				GIDEOJGAFJH.x = Mathf.Clamp(GIDEOJGAFJH.x, 0f - (HDLHDCHJGJH.sizeDelta.x * 0.5f - GALLAAHEKOJ), HDLHDCHJGJH.sizeDelta.x * 0.5f - GALLAAHEKOJ);
				GIDEOJGAFJH.y = Mathf.Clamp(GIDEOJGAFJH.y, 0f - (HDLHDCHJGJH.sizeDelta.y * 0.5f - GALLAAHEKOJ), HDLHDCHJGJH.sizeDelta.y * 0.5f - GALLAAHEKOJ);
			}
			float pPLJEHCDHLA = PPLJEHCDHLA;
			pPLJEHCDHLA = ((GIDEOJGAFJH.x != HDLHDCHJGJH.sizeDelta.x * 0.5f - GALLAAHEKOJ && GIDEOJGAFJH.y != HDLHDCHJGJH.sizeDelta.y * 0.5f - GALLAAHEKOJ && GIDEOJGAFJH.x != 0f - HDLHDCHJGJH.sizeDelta.x * 0.5f - GALLAAHEKOJ && 0f - GIDEOJGAFJH.y != HDLHDCHJGJH.sizeDelta.y * 0.5f - GALLAAHEKOJ) ? PPLJEHCDHLA : BCBCCBDHGPH);
			component.anchoredPosition = GIDEOJGAFJH;
			if (IEJLDLJMIAG != null)
			{
				IEJLDLJMIAG.anchoredPosition = anchoredPosition;
			}
			float num = pPLJEHCDHLA * FLAOLGPBHOO.EMDFJAIPJMO;
			component.sizeDelta = Vector2.Lerp(component.sizeDelta, new Vector2(num, num), Time.deltaTime * 8f);
			if (FLAOLGPBHOO.FCBLCNJGAJE)
			{
				Quaternion identity = Quaternion.identity;
				identity.x = JBLHHCNLIAJ.rotation.x;
				component.localRotation = identity;
			}
			else
			{
				Vector3 eulerAngles = FLAOLGPBHOO.transform.eulerAngles;
				Vector3 zero = Vector3.zero;
				zero.z = 0f - JBLHHCNLIAJ.rotation.eulerAngles.y + eulerAngles.y;
				Quaternion rotation = Quaternion.Euler(zero);
				component.rotation = rotation;
			}
		}
	}

	private void KEDMLMNOKLH()
	{
		Animator component = FNELAENIDML.GetComponent<Animator>();
		if (CBCJFPHCHON == BEEODMJBIIK.CADEMBMDJCK)
		{
			component.SetInteger("Type", 2);
		}
		else if (CBCJFPHCHON == BEEODMJBIIK.CGPKGIPGDLP)
		{
			component.SetInteger("Type", 1);
		}
	}

	public void LJLADCEBOAN(bool FHAFNDJLBIP)
	{
		if (FNELAENIDML == null)
		{
			Debug.Log("Graphic Item of " + base.name + " not exist in scene");
		}
		else if (MEEOMHDDGEK == null || FHAFNDJLBIP)
		{
			FNELAENIDML.GetComponent<DBDCHDJAEEF>().FHADFLKMLFL(FHAFNDJLBIP);
		}
		else
		{
			FNELAENIDML.GetComponent<DBDCHDJAEEF>().FHADFLKMLFL(FHAFNDJLBIP, MEEOMHDDGEK);
		}
	}

	public void CIKBLCGBPMM(Sprite EIBPFKJIJEH)
	{
		if (LOPJEPPAFPH == null)
		{
			Debug.LogWarning("You can't set a icon before create the item.");
		}
		else
		{
			LOPJEPPAFPH.GetComponent<DBDCHDJAEEF>().CIKBLCGBPMM(EIBPFKJIJEH);
		}
	}

	public void FAIBPHBCFCM(float DOGLMPODLGL, Color FPONCFJJCOK)
	{
		IEJLDLJMIAG = LOPJEPPAFPH.GetComponent<DBDCHDJAEEF>().FAIBPHBCFCM(DOGLMPODLGL, FPONCFJJCOK);
	}

	public void GGGKKDLCEHP()
	{
		LOPJEPPAFPH.GetComponent<DBDCHDJAEEF>().GGGKKDLCEHP();
		IEJLDLJMIAG = null;
	}

	public void BHDMLGFBPDN()
	{
		if (LOPJEPPAFPH != null)
		{
			LOPJEPPAFPH.SetActive(false);
		}
		else
		{
			Debug.Log("There is no item to disable.");
		}
	}

	public void MHMKAGPKJFP()
	{
		if (LOPJEPPAFPH != null)
		{
			LOPJEPPAFPH.SetActive(true);
			LOPJEPPAFPH.GetComponent<DBDCHDJAEEF>().LHEADNLIAIG();
		}
		else
		{
			Debug.Log("There is no item to active.");
		}
	}

	private void OnDestroy()
	{
		if (NOLBOFKEBAI)
		{
			LJLADCEBOAN(true);
		}
	}
}
