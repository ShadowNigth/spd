using UnityEngine;

public class GJCPDJIJIHD : MonoBehaviour
{
	[Tooltip("This target can be null, this will be take the same target of minimap")]
	public Transform JBLHHCNLIAJ;

	[Space(7f)]
	public RectTransform OHDOHKGPANN;

	public RectTransform DCMHDIOKKMP;

	public RectTransform POEMALECIHF;

	public RectTransform MIIKDALHGOA;

	public RectTransform FDIHENGALJB;

	[HideInInspector]
	public int FGEGJILGPLJ;

	private int GDNILHGBJDD;

	private Transform GDKFLGBMPBB;

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

	private void Start()
	{
		if (JBLHHCNLIAJ == null && GetComponent<HFEIGOBNJHD>() != null)
		{
			JBLHHCNLIAJ = GetComponent<HFEIGOBNJHD>().JBLHHCNLIAJ;
		}
	}

	private void Update()
	{
		if (JBLHHCNLIAJ != null)
		{
			GDNILHGBJDD = (int)Mathf.Abs(JBLHHCNLIAJ.eulerAngles.y);
		}
		else
		{
			GDNILHGBJDD = (int)Mathf.Abs(IEMAJHNJCNA.eulerAngles.y);
		}
		if (GDNILHGBJDD > 360)
		{
			GDNILHGBJDD %= 360;
		}
		FGEGJILGPLJ = GDNILHGBJDD;
		if (FGEGJILGPLJ > 180)
		{
			FGEGJILGPLJ -= 360;
		}
		DCMHDIOKKMP.anchoredPosition = new Vector2(OHDOHKGPANN.sizeDelta.x * 0.5f - (float)(FGEGJILGPLJ * 2) - OHDOHKGPANN.sizeDelta.x * 0.5f, 0f);
		POEMALECIHF.anchoredPosition = new Vector2(OHDOHKGPANN.sizeDelta.x * 0.5f - (float)(GDNILHGBJDD * 2) + 360f - OHDOHKGPANN.sizeDelta.x * 0.5f, 0f);
		MIIKDALHGOA.anchoredPosition = new Vector2(OHDOHKGPANN.sizeDelta.x * 0.5f - (float)(FGEGJILGPLJ * 2) + 180f - OHDOHKGPANN.sizeDelta.x * 0.5f, 0f);
		FDIHENGALJB.anchoredPosition = new Vector2(OHDOHKGPANN.sizeDelta.x * 0.5f - (float)(GDNILHGBJDD * 2) + 540f - OHDOHKGPANN.sizeDelta.x * 0.5f, 0f);
	}
}
