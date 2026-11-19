using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
[AddComponentMenu("UI/Extensions/Selection Box")]
public class ALFHIPMJNFJ : MonoBehaviour
{
	public class HCMNEKPKAPF : UnityEvent<DHIONDECIAP[]>
	{
	}

	public Color JPLPPELPDKF;

	public Sprite NDNNDEJFOOF;

	private Vector2 OOIJMCFMDHN;

	public RectTransform DLLGDKBABBH;

	private RectTransform PNIGHHBHHMJ;

	private DHIONDECIAP[] AGOFOAAMDLL;

	private MonoBehaviour[] JCGBEPAEMDN;

	private DHIONDECIAP NAGJJGHOOND;

	private DHIONDECIAP FGLOANBBHFO;

	public HCMNEKPKAPF OOBEHHFLHKG = new HCMNEKPKAPF();

	private void HCCIMDJHBOG()
	{
		Canvas component = base.gameObject.GetComponent<Canvas>();
		if (component.renderMode != 0)
		{
			throw new Exception("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.");
		}
		CanvasScaler component2 = base.gameObject.GetComponent<CanvasScaler>();
		if ((bool)component2 && component2.enabled && (!Mathf.Approximately(component2.scaleFactor, 1f) || component2.uiScaleMode != 0))
		{
			UnityEngine.Object.Destroy(component2);
			Debug.LogWarning("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.");
		}
	}

	private void IBMMMJJDOHG(IEnumerable<MonoBehaviour> IPKDPKMHLBD)
	{
		if (IPKDPKMHLBD == null)
		{
			JCGBEPAEMDN = null;
			return;
		}
		List<MonoBehaviour> list = new List<MonoBehaviour>();
		foreach (MonoBehaviour item in IPKDPKMHLBD)
		{
			if (item is DHIONDECIAP)
			{
				list.Add(item);
			}
		}
		JCGBEPAEMDN = list.ToArray();
	}

	private void EMLFKIFCFJI()
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Selection Box";
		gameObject.transform.parent = base.transform;
		gameObject.AddComponent<Image>();
		PNIGHHBHHMJ = gameObject.transform as RectTransform;
	}

	private void FKIDEBADKMI()
	{
		Image component = PNIGHHBHHMJ.GetComponent<Image>();
		component.color = JPLPPELPDKF;
		component.sprite = NDNNDEJFOOF;
		OOIJMCFMDHN = Vector2.zero;
		PNIGHHBHHMJ.anchoredPosition = Vector2.zero;
		PNIGHHBHHMJ.sizeDelta = Vector2.zero;
		PNIGHHBHHMJ.anchorMax = Vector2.zero;
		PNIGHHBHHMJ.anchorMin = Vector2.zero;
		PNIGHHBHHMJ.pivot = Vector2.zero;
		PNIGHHBHHMJ.gameObject.SetActive(value: false);
	}

	private void MOAGHFKBKLB()
	{
		if (!UnityEngine.Input.GetMouseButtonDown(0))
		{
			return;
		}
		PNIGHHBHHMJ.gameObject.SetActive(value: true);
		OOIJMCFMDHN = new Vector2(UnityEngine.Input.mousePosition.x, UnityEngine.Input.mousePosition.y);
		if (!FPIFEIFDMHI(OOIJMCFMDHN))
		{
			FKIDEBADKMI();
			return;
		}
		PNIGHHBHHMJ.anchoredPosition = OOIJMCFMDHN;
		MonoBehaviour[] array = ((JCGBEPAEMDN != null) ? JCGBEPAEMDN : UnityEngine.Object.FindObjectsOfType<MonoBehaviour>());
		List<DHIONDECIAP> list = new List<DHIONDECIAP>();
		MonoBehaviour[] array2 = array;
		foreach (MonoBehaviour monoBehaviour in array2)
		{
			if (monoBehaviour is DHIONDECIAP dHIONDECIAP)
			{
				list.Add(dHIONDECIAP);
				if (!UnityEngine.Input.GetKey(KeyCode.LeftShift))
				{
					dHIONDECIAP.HNJBPICPKIJ = false;
				}
			}
		}
		AGOFOAAMDLL = list.ToArray();
		NAGJJGHOOND = ADMKDGNNCDF();
	}

	private bool FPIFEIFDMHI(Vector2 BFPNHJOEFOE)
	{
		if (!DLLGDKBABBH)
		{
			return true;
		}
		Camera cam = OIHOFJMIMMI(DLLGDKBABBH);
		return RectTransformUtility.RectangleContainsScreenPoint(DLLGDKBABBH, BFPNHJOEFOE, cam);
	}

	private DHIONDECIAP ADMKDGNNCDF()
	{
		if (!FPIFEIFDMHI(UnityEngine.Input.mousePosition))
		{
			return null;
		}
		DHIONDECIAP[] aGOFOAAMDLL = AGOFOAAMDLL;
		foreach (DHIONDECIAP dHIONDECIAP in aGOFOAAMDLL)
		{
			RectTransform rectTransform = dHIONDECIAP.EHOEFMPLIFB as RectTransform;
			if ((bool)rectTransform)
			{
				Camera cam = OIHOFJMIMMI(rectTransform);
				if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, UnityEngine.Input.mousePosition, cam))
				{
					return dHIONDECIAP;
				}
				continue;
			}
			float magnitude = dHIONDECIAP.EHOEFMPLIFB.GetComponent<Renderer>().bounds.extents.magnitude;
			Vector2 a = ODDIHNPJDNL(dHIONDECIAP);
			if (Vector2.Distance(a, UnityEngine.Input.mousePosition) <= magnitude)
			{
				return dHIONDECIAP;
			}
		}
		return null;
	}

	private void APPOPJDADJN()
	{
		if (UnityEngine.Input.GetMouseButton(0) && PNIGHHBHHMJ.gameObject.activeSelf)
		{
			Vector2 vector = new Vector2(UnityEngine.Input.mousePosition.x, UnityEngine.Input.mousePosition.y);
			Vector2 sizeDelta = vector - OOIJMCFMDHN;
			Vector2 oOIJMCFMDHN = OOIJMCFMDHN;
			if (sizeDelta.x < 0f)
			{
				oOIJMCFMDHN.x = vector.x;
				sizeDelta.x = 0f - sizeDelta.x;
			}
			if (sizeDelta.y < 0f)
			{
				oOIJMCFMDHN.y = vector.y;
				sizeDelta.y = 0f - sizeDelta.y;
			}
			PNIGHHBHHMJ.anchoredPosition = oOIJMCFMDHN;
			PNIGHHBHHMJ.sizeDelta = sizeDelta;
			DHIONDECIAP[] aGOFOAAMDLL = AGOFOAAMDLL;
			foreach (DHIONDECIAP dHIONDECIAP in aGOFOAAMDLL)
			{
				Vector3 vector2 = ODDIHNPJDNL(dHIONDECIAP);
				dHIONDECIAP.EMNPHMEIKKK = RectTransformUtility.RectangleContainsScreenPoint(PNIGHHBHHMJ, vector2, null) && FPIFEIFDMHI(vector2);
			}
			if (NAGJJGHOOND != null)
			{
				NAGJJGHOOND.EMNPHMEIKKK = true;
			}
		}
	}

	private void FLDCNCPALMD()
	{
		if (NAGJJGHOOND != null && FGLOANBBHFO != null && NAGJJGHOOND.HNJBPICPKIJ && NAGJJGHOOND.EHOEFMPLIFB == FGLOANBBHFO.EHOEFMPLIFB)
		{
			NAGJJGHOOND.HNJBPICPKIJ = false;
			NAGJJGHOOND.EMNPHMEIKKK = false;
		}
	}

	private void LMJFLFLFIPK()
	{
		DHIONDECIAP[] aGOFOAAMDLL = AGOFOAAMDLL;
		foreach (DHIONDECIAP dHIONDECIAP in aGOFOAAMDLL)
		{
			if (dHIONDECIAP.EMNPHMEIKKK)
			{
				dHIONDECIAP.HNJBPICPKIJ = true;
				dHIONDECIAP.EMNPHMEIKKK = false;
			}
		}
	}

	private Vector2 ODDIHNPJDNL(DHIONDECIAP DCJIIFODKFE)
	{
		RectTransform rectTransform = DCJIIFODKFE.EHOEFMPLIFB as RectTransform;
		if ((bool)rectTransform)
		{
			Camera cam = OIHOFJMIMMI(rectTransform);
			return RectTransformUtility.WorldToScreenPoint(cam, DCJIIFODKFE.EHOEFMPLIFB.position);
		}
		return Camera.main.WorldToScreenPoint(DCJIIFODKFE.EHOEFMPLIFB.position);
	}

	private Camera OIHOFJMIMMI(RectTransform GEINAHMAFAM)
	{
		Canvas canvas = null;
		RectTransform rectTransform = GEINAHMAFAM;
		do
		{
			canvas = rectTransform.GetComponent<Canvas>();
			if ((bool)canvas && !canvas.isRootCanvas)
			{
				canvas = null;
			}
			rectTransform = (RectTransform)rectTransform.parent;
		}
		while (canvas == null);
		return canvas.renderMode switch
		{
			RenderMode.ScreenSpaceOverlay => null, 
			RenderMode.ScreenSpaceCamera => (!canvas.worldCamera) ? Camera.main : canvas.worldCamera, 
			_ => Camera.main, 
		};
	}

	public DHIONDECIAP[] GAKLANLAKAH()
	{
		if (AGOFOAAMDLL == null)
		{
			return new DHIONDECIAP[0];
		}
		List<DHIONDECIAP> list = new List<DHIONDECIAP>();
		DHIONDECIAP[] aGOFOAAMDLL = AGOFOAAMDLL;
		foreach (DHIONDECIAP dHIONDECIAP in aGOFOAAMDLL)
		{
			if (dHIONDECIAP.HNJBPICPKIJ)
			{
				list.Add(dHIONDECIAP);
			}
		}
		return list.ToArray();
	}

	private void BEFOKAAHFHC()
	{
		if (UnityEngine.Input.GetMouseButtonUp(0) && PNIGHHBHHMJ.gameObject.activeSelf)
		{
			FGLOANBBHFO = ADMKDGNNCDF();
			FLDCNCPALMD();
			LMJFLFLFIPK();
			FKIDEBADKMI();
			OOBEHHFLHKG.Invoke(GAKLANLAKAH());
		}
	}

	private void Start()
	{
		HCCIMDJHBOG();
		EMLFKIFCFJI();
		FKIDEBADKMI();
	}

	private void Update()
	{
		MOAGHFKBKLB();
		APPOPJDADJN();
		BEFOKAAHFHC();
	}
}
