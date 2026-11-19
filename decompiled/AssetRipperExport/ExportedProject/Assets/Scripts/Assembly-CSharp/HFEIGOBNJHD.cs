using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SPD.EditorAttributes;
using UnityEngine;
using UnityEngine.UI;

public class HFEIGOBNJHD : MonoBehaviour
{
	[Serializable]
	public enum RenderType
	{
		RealTime = 0,
		Picture = 1
	}

	[Serializable]
	public enum RenderMode
	{
		Mode2D = 0,
		Mode3D = 1
	}

	[Serializable]
	public enum MapType
	{
		Target = 0,
		World = 1
	}

	private sealed class DNNDEHBIHGD : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float BHCHOIGLECH;

		internal HFEIGOBNJHD KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public DNNDEHBIHGD()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				KPHCHDHEKGH.RootAlpha.alpha = 0f;
				HLJEEFIJCOF = new WaitForSeconds(BHCHOIGLECH);
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				break;
			case 1u:
			case 2u:
				if (KPHCHDHEKGH.RootAlpha.alpha < 1f)
				{
					KPHCHDHEKGH.RootAlpha.alpha += Time.deltaTime;
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 2;
					}
					break;
				}
				KPHCHDHEKGH.LEADKKKIGCA = true;
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	[Separator("General Settings")]
	public GameObject ADFPACBGAPK;

	[LayerMask]
	public int OKBAJCDMFEL = 10;

	public Camera PLDNNNNKMGP;

	public RenderMode CNOFMEMEINO;

	public MapType HABGACGBLGK;

	public bool HCMACLPMFND;

	[Separator("Height")]
	[Range(0.05f, 2f)]
	public float EMDFJAIPJMO = 1f;

	[Range(5f, 500f)]
	public float JBPFHEDEELG = 30f;

	[Tooltip("Maximum heights that the camera can reach.")]
	public float JLKJGCBKMGE = 80f;

	[Tooltip("Minimum heights that the camera can reach.")]
	public float PDBOJFIIOOA = 5f;

	[Separator("Rotation")]
	[CustomToggle("Rotation Always in front")]
	public bool FCBLCNJGAJE = true;

	[Tooltip("Should the minimap rotate with the player?")]
	[CustomToggle("Dynamic Rotation")]
	public bool PEINOJDKCOO = true;

	[Tooltip("this work only is dynamic rotation.")]
	[CustomToggle("Smooth Rotation")]
	public bool GIPKGGKJNJP = true;

	[Range(1f, 15f)]
	public float JFHGPMBAADC = 8f;

	[Separator("Map Rect")]
	[Tooltip("Position for World Map.")]
	public Vector3 PPLMNHMGOCA = Vector2.zero;

	[Tooltip("Rotation for World Map.")]
	public Vector3 HJLJDLMOLDM = Vector3.zero;

	[Tooltip("Size of World Map.")]
	public Vector2 NKDDFEJCEDB = Vector2.zero;

	private Vector3 DKFPAGOEHLI = Vector2.zero;

	private Vector3 BPMNEMBAABK = Vector3.zero;

	private Vector2 LBMFNMJKEOE = Vector2.zero;

	[Space(5f)]
	[InspectorButton("GetFullMapSize")]
	public string NGDKCAMHDFO = string.Empty;

	[CustomToggle("Can Drag MiniMap")]
	[Separator("Drag Settings")]
	public bool OKLNBOIJJGE = true;

	[CustomToggle("Drag Only On Full screen")]
	public bool JIFJKLINAGF = true;

	public Vector2 OLOPBBACJCL = new Vector2(0.5f, 0.35f);

	public Vector2 EDPPBCEEOJC = new Vector2(1000f, 1000f);

	public Texture2D KDIJIEIPMOA;

	public Vector2 EAFHGECOEAJ = Vector2.zero;

	[Tooltip("Texture for MiniMap renderer, you can take a snapshot from map.")]
	[Separator("Picture Mode Settings")]
	public Texture BOIMJJBGINJ;

	public Color HODPBJLGFEO = new Color(1f, 1f, 1f, 0.9f);

	public Color HDPLJFHEDKC = new Color(1f, 1f, 1f, 0.9f);

	public Color FDKJCBECGGA = new Color(0f, 0f, 0f, 0.9f);

	[Range(0.1f, 4f)]
	public float GFINKCHAHNH = 1f;

	[SerializeField]
	private Material ReferenceMat;

	[Space(3f)]
	public GameObject PABJKEFDCEB;

	[SerializeField]
	private GameObject AreaPrefab;

	public RectTransform ONJEBHMIMIE;

	[Separator("UI")]
	public RectTransform IPINMKGEKJJ;

	public Image LCFJGAHFLNN;

	[SerializeField]
	private CanvasGroup RootAlpha;

	public static bool IPILKCDFPLA;

	public static Camera GIFGJFEBGED;

	public static RectTransform ENIHNMIIDME;

	private Vector3 OJMEBKKLIII = Vector3.zero;

	private Vector3 FLIADDJJKEC = Vector3.zero;

	private GameObject GKOBEBMMKAK;

	private float OBGEFHGDDOG;

	private const string DGAJHGLNOCP = "MinimapCameraHeight";

	private bool AEJJMMOFJIJ;

	private bool LEADKKKIGCA;

	private Transform GDKFLGBMPBB;

	private CJJCCNPKBCF CELEBAOFLHF;

	public Transform JBLHHCNLIAJ
	{
		get
		{
			if (ADFPACBGAPK != null)
			{
				return ADFPACBGAPK.GetComponent<Transform>();
			}
			return GetComponent<Transform>();
		}
	}

	public Vector3 JOAINBENLAK
	{
		get
		{
			Vector3 result = Vector3.zero;
			if (ADFPACBGAPK != null)
			{
				result = ADFPACBGAPK.transform.position;
			}
			return result;
		}
	}

	private Transform IEMAJHNJCNA
	{
		get
		{
			if (GDKFLGBMPBB == null)
			{
				GDKFLGBMPBB = GetComponent<Transform>();
			}
			return GDKFLGBMPBB;
		}
	}

	private CJJCCNPKBCF HLCLEEOPOHK
	{
		get
		{
			if (CELEBAOFLHF == null)
			{
				CELEBAOFLHF = base.transform.root.GetComponentInChildren<CJJCCNPKBCF>();
			}
			return CELEBAOFLHF;
		}
	}

	private void Awake()
	{
		FEBGJOFKCON();
		GIFGJFEBGED = PLDNNNNKMGP;
		ENIHNMIIDME = IPINMKGEKJJ;
		FLIADDJJKEC = IEMAJHNJCNA.eulerAngles;
		HPOAGEEHBIO(false);
		JBPFHEDEELG = PlayerPrefs.GetFloat("MinimapCameraHeight", JBPFHEDEELG);
		if (RootAlpha != null)
		{
			StartCoroutine(BOJBBJHLJHE(0f));
		}
	}

	private void OnEnable()
	{
		if (!LEADKKKIGCA && RootAlpha != null)
		{
			StartCoroutine(BOJBBJHLJHE(0f));
		}
	}

	private void HPOAGEEHBIO(bool FLOOGPFGPJM)
	{
		string value = LayerMask.LayerToName(OKBAJCDMFEL);
		if (string.IsNullOrEmpty(value))
		{
			UnityEngine.Debug.LogError("MiniMap Layer is null, please assign it in the inspector.");
			IPINMKGEKJJ.gameObject.SetActive(false);
			base.enabled = false;
			return;
		}
		MinimapWorldSettings minimapWorldSettings = UnityEngine.Object.FindObjectOfType<MinimapWorldSettings>();
		BOIMJJBGINJ = minimapWorldSettings.MinimapTexture;
		if (BOIMJJBGINJ == null)
		{
			UnityEngine.Debug.LogError("Map Texture has not been allocated.");
			return;
		}
		ONJEBHMIMIE = minimapWorldSettings.Rect;
		Vector3 localPosition = ONJEBHMIMIE.localPosition;
		Vector3 vector = ONJEBHMIMIE.sizeDelta;
		PLDNNNNKMGP.cullingMask = 1 << OKBAJCDMFEL;
		GKOBEBMMKAK = UnityEngine.Object.Instantiate(PABJKEFDCEB);
		GKOBEBMMKAK.transform.localPosition = localPosition;
		GKOBEBMMKAK.transform.localScale = new Vector3(vector.x, 10f, vector.y) / 10f;
		GKOBEBMMKAK.GetComponent<Renderer>().material = EFJAGCAMMBE();
		GKOBEBMMKAK.layer = OKBAJCDMFEL;
		GKOBEBMMKAK.SetActive(false);
		GKOBEBMMKAK.SetActive(true);
		GKOBEBMMKAK.transform.GetChild(0).gameObject.SetActive(false);
		Invoke("FCLKCLADIMC", 2f);
	}

	private void FCLKCLADIMC()
	{
		OBGEFHGDDOG = PLDNNNNKMGP.transform.position.y;
		AEJJMMOFJIJ = true;
	}

	private void Update()
	{
		if (!(ADFPACBGAPK == null) && !(PLDNNNNKMGP == null))
		{
			JPGPCMHBCMI();
			GENKEILEMMB();
		}
	}

	private void JPGPCMHBCMI()
	{
		if (HABGACGBLGK == MapType.Target)
		{
			Vector3 position = IEMAJHNJCNA.position;
			position.x = JBLHHCNLIAJ.position.x;
			if (!HCMACLPMFND)
			{
				position.z = JBLHHCNLIAJ.position.z;
			}
			else
			{
				position.y = JBLHHCNLIAJ.position.y;
			}
			position += OJMEBKKLIII;
			if (JBLHHCNLIAJ != null)
			{
				Vector3 lBEIKBOPGPK = PLDNNNNKMGP.WorldToViewportPoint(JOAINBENLAK);
				LCFJGAHFLNN.rectTransform.anchoredPosition = EJONJMEGEKJ.FHNGLMOJDIN(lBEIKBOPGPK, ENIHNMIIDME);
			}
			if (!HCMACLPMFND)
			{
				position.y = JLKJGCBKMGE + PDBOJFIIOOA / 2f + JBLHHCNLIAJ.position.y * 2f;
			}
			else
			{
				position.z = JBLHHCNLIAJ.position.z * 2f - (JLKJGCBKMGE + PDBOJFIIOOA / 2f);
			}
			IEMAJHNJCNA.position = Vector3.Lerp(IEMAJHNJCNA.position, position, Time.deltaTime * 10f);
		}
		if (GKOBEBMMKAK != null && AEJJMMOFJIJ)
		{
			Vector3 position2 = GKOBEBMMKAK.transform.position;
			Vector3 position3 = ONJEBHMIMIE.position;
			float num = OBGEFHGDDOG - PLDNNNNKMGP.transform.position.y;
			position2.y = position3.y - num;
			GKOBEBMMKAK.transform.position = position2;
		}
	}

	private void GENKEILEMMB()
	{
		RectTransform component = LCFJGAHFLNN.GetComponent<RectTransform>();
		if (PEINOJDKCOO && HABGACGBLGK != MapType.World)
		{
			Vector3 eulerAngles = IEMAJHNJCNA.eulerAngles;
			eulerAngles.y = JBLHHCNLIAJ.eulerAngles.y;
			if (GIPKGGKJNJP)
			{
				if (CNOFMEMEINO == RenderMode.Mode2D)
				{
					component.eulerAngles = Vector3.zero;
				}
				else
				{
					component.localEulerAngles = Vector3.zero;
				}
				if (IEMAJHNJCNA.eulerAngles.y != eulerAngles.y)
				{
					float num = eulerAngles.y - IEMAJHNJCNA.eulerAngles.y;
					if (num > 180f || num < -180f)
					{
						IEMAJHNJCNA.eulerAngles = eulerAngles;
					}
				}
				IEMAJHNJCNA.eulerAngles = Vector3.Lerp(base.transform.eulerAngles, eulerAngles, Time.deltaTime * JFHGPMBAADC);
			}
			else
			{
				IEMAJHNJCNA.eulerAngles = eulerAngles;
			}
		}
		else
		{
			IEMAJHNJCNA.eulerAngles = FLIADDJJKEC;
			if (CNOFMEMEINO == RenderMode.Mode2D)
			{
				Vector3 zero = Vector3.zero;
				zero.z = 0f - JBLHHCNLIAJ.eulerAngles.y;
				component.eulerAngles = zero;
			}
			else
			{
				Vector3 localEulerAngles = JBLHHCNLIAJ.localEulerAngles;
				Vector3 zero2 = Vector3.zero;
				zero2.z = 0f - localEulerAngles.y;
				component.localEulerAngles = zero2;
			}
		}
	}

	public void OFAHFNJFHJP(Vector3 ELGIKGAIIOD)
	{
		if (!JIFJKLINAGF || IPILKCDFPLA)
		{
			OJMEBKKLIII.x += (0f - ELGIKGAIIOD.x) * OLOPBBACJCL.x;
			OJMEBKKLIII.z += (0f - ELGIKGAIIOD.y) * OLOPBBACJCL.y;
			OJMEBKKLIII.x = Mathf.Clamp(OJMEBKKLIII.x, 0f - EDPPBCEEOJC.x, EDPPBCEEOJC.x);
			OJMEBKKLIII.z = Mathf.Clamp(OJMEBKKLIII.z, 0f - EDPPBCEEOJC.y, EDPPBCEEOJC.y);
		}
	}

	public void NEHODHJGPOA()
	{
		StopCoroutine("ResetOffset");
		StartCoroutine("ResetOffset");
	}

	public Material EFJAGCAMMBE()
	{
		Material material = new Material(ReferenceMat);
		material.mainTexture = BOIMJJBGINJ;
		return material;
	}

	private void FEBGJOFKCON()
	{
		LBMFNMJKEOE = IPINMKGEKJJ.sizeDelta;
		DKFPAGOEHLI = IPINMKGEKJJ.anchoredPosition;
		BPMNEMBAABK = IPINMKGEKJJ.eulerAngles;
	}

	[ContextMenu("GetFullMapRect")]
	private void AEAKOMAMEIA()
	{
		NKDDFEJCEDB = IPINMKGEKJJ.sizeDelta;
		PPLMNHMGOCA = IPINMKGEKJJ.anchoredPosition;
		HJLJDLMOLDM = IPINMKGEKJJ.eulerAngles;
	}

	[DebuggerHidden]
	private IEnumerator BOJBBJHLJHE(float BHCHOIGLECH)
	{
		DNNDEHBIHGD dNNDEHBIHGD = new DNNDEHBIHGD();
		dNNDEHBIHGD.BHCHOIGLECH = BHCHOIGLECH;
		dNNDEHBIHGD.KPHCHDHEKGH = this;
		return dNNDEHBIHGD;
	}
}
