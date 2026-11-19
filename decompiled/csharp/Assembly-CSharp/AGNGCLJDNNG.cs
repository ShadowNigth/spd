using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform), typeof(Button))]
public class AGNGCLJDNNG
{
	public RectTransform GEINAHMAFAM;

	public Button IECEOHEKBLE;

	public Text NFFPPKLIPBC;

	public Image MPIKHJGABMG;

	public Image FBAMCBALFCM;

	public GameObject KLDDCBIEAEK;

	public AGNGCLJDNNG(GameObject FJOBHMJJFKO)
	{
		KLDDCBIEAEK = FJOBHMJJFKO;
		GEINAHMAFAM = FJOBHMJJFKO.GetComponent<RectTransform>();
		MPIKHJGABMG = FJOBHMJJFKO.GetComponent<Image>();
		IECEOHEKBLE = FJOBHMJJFKO.GetComponent<Button>();
		NFFPPKLIPBC = GEINAHMAFAM.Find("Text").GetComponent<Text>();
		FBAMCBALFCM = GEINAHMAFAM.Find("Image").GetComponent<Image>();
	}
}
