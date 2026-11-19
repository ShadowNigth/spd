using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(Image))]
[AddComponentMenu("UI/Effects/Extensions/Shining Effect")]
public class FGOBHFAOCAD : MonoBehaviour
{
	public LMFNAENJECO GIINCLHOEHK;

	[SerializeField]
	[HideInInspector]
	private GameObject effectRoot;

	[Range(-1f, 1f)]
	public float LBMGNFLAJNM = -1f;

	[Range(0.1f, 1f)]
	public float KAPGDBCIGHP = 0.5f;

	private RectTransform OBOEMKPBOMN;

	public float LOBEHCABKCL
	{
		get
		{
			return LBMGNFLAJNM;
		}
		set
		{
			EKGCLGKGIEP(value);
			LBMGNFLAJNM = value;
		}
	}

	private void OnEnable()
	{
		if (GIINCLHOEHK == null)
		{
			GameObject gameObject = new GameObject("effector");
			effectRoot = new GameObject("ShineEffect");
			effectRoot.transform.SetParent(base.transform);
			effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
			effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
			effectRoot.AddComponent<Mask>().showMaskGraphic = false;
			effectRoot.transform.localScale = Vector3.one;
			effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
			effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
			effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
			effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
			effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
			effectRoot.transform.SetAsFirstSibling();
			gameObject.AddComponent<RectTransform>();
			gameObject.transform.SetParent(effectRoot.transform);
			OBOEMKPBOMN = gameObject.GetComponent<RectTransform>();
			OBOEMKPBOMN.localScale = Vector3.one;
			OBOEMKPBOMN.anchoredPosition3D = Vector3.zero;
			OBOEMKPBOMN.gameObject.AddComponent<LMFNAENJECO>();
			OBOEMKPBOMN.anchorMax = Vector2.one;
			OBOEMKPBOMN.anchorMin = Vector2.zero;
			OBOEMKPBOMN.Rotate(0f, 0f, -8f);
			GIINCLHOEHK = gameObject.GetComponent<LMFNAENJECO>();
			OBOEMKPBOMN.offsetMax = Vector2.zero;
			OBOEMKPBOMN.offsetMin = Vector2.zero;
			OnValidate();
		}
	}

	private void OnValidate()
	{
		GIINCLHOEHK.CDBOLIECGNB = LBMGNFLAJNM;
		GIINCLHOEHK.HACOGJLHFJI = KAPGDBCIGHP;
		if (LBMGNFLAJNM <= -1f || LBMGNFLAJNM >= 1f)
		{
			effectRoot.SetActive(value: false);
		}
		else if (!effectRoot.activeSelf)
		{
			effectRoot.SetActive(value: true);
		}
	}

	private void EKGCLGKGIEP(float EHAPKEKPMOE)
	{
		GIINCLHOEHK.CDBOLIECGNB = EHAPKEKPMOE;
		if (EHAPKEKPMOE <= -1f || EHAPKEKPMOE >= 1f)
		{
			effectRoot.SetActive(value: false);
		}
		else if (!effectRoot.activeSelf)
		{
			effectRoot.SetActive(value: true);
		}
	}

	private void OnDestroy()
	{
		if (!Application.isPlaying)
		{
			Object.DestroyImmediate(effectRoot);
		}
		else
		{
			Object.Destroy(effectRoot);
		}
	}
}
