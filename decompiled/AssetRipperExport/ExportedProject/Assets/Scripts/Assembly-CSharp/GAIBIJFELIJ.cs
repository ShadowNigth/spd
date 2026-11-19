using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Bound Tooltip/Tooltip Item")]
public class GAIBIJFELIJ : MonoBehaviour
{
	public Text FHIAMIFEENP;

	public Vector3 AELLFLAIBMI;

	private static GAIBIJFELIJ KAGNKODNFOC;

	public bool IOCGFJFOLIL
	{
		get
		{
			return base.gameObject.activeSelf;
		}
	}

	public static GAIBIJFELIJ KHGDLGJPCCA
	{
		get
		{
			if (KAGNKODNFOC == null)
			{
				KAGNKODNFOC = Object.FindObjectOfType<GAIBIJFELIJ>();
			}
			return KAGNKODNFOC;
		}
	}

	private void Awake()
	{
		KAGNKODNFOC = this;
		if (!FHIAMIFEENP)
		{
			FHIAMIFEENP = GetComponentInChildren<Text>();
		}
		MIJCNPJKAIG();
	}

	public void LLPDIIKPAMP(string KLLKONMADKA, Vector3 ELGIKGAIIOD)
	{
		if (FHIAMIFEENP.text != KLLKONMADKA)
		{
			FHIAMIFEENP.text = KLLKONMADKA;
		}
		base.transform.position = ELGIKGAIIOD + AELLFLAIBMI;
		base.gameObject.SetActive(true);
	}

	public void MIJCNPJKAIG()
	{
		base.gameObject.SetActive(false);
	}
}
