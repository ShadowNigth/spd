using UnityEngine;
using UnityEngine.UI;

public class NEPBCALOJCD : MonoBehaviour
{
	public OPHEMGAFKCE CFAGCFHNPEM;

	public EHNKJANJDHO POPGMEPPDOM;

	public GameObject IECJEIMDNCP;

	public GameObject MEBLGLPNPDH;

	public InputField PLBGBBOAEIA;

	public void PBJAIGLEMGI()
	{
		if ((bool)CFAGCFHNPEM)
		{
			GameObject lGLJJHBAOMP = Object.Instantiate(IECJEIMDNCP);
			CFAGCFHNPEM.KIOCGJMNDMH(lGLJJHBAOMP);
		}
		if ((bool)POPGMEPPDOM)
		{
			GameObject lGLJJHBAOMP2 = Object.Instantiate(MEBLGLPNPDH);
			POPGMEPPDOM.KIOCGJMNDMH(lGLJJHBAOMP2);
		}
	}

	public void CMNCOMEGAHO()
	{
		if ((bool)CFAGCFHNPEM)
		{
			CFAGCFHNPEM.ICAFAJHPHKB(CFAGCFHNPEM.PKKJBIDEMBH, out var PPBEJENPEPI);
			PPBEJENPEPI.SetActive(value: false);
		}
		if ((bool)POPGMEPPDOM)
		{
			POPGMEPPDOM.ICAFAJHPHKB(POPGMEPPDOM.PKKJBIDEMBH, out var PPBEJENPEPI2);
			PPBEJENPEPI2.SetActive(value: false);
		}
	}

	public void MPJGINGKJNO()
	{
		int aAPMABOOLNF = int.Parse(PLBGBBOAEIA.text);
		if ((bool)CFAGCFHNPEM)
		{
			CFAGCFHNPEM.KGIJFBMOJPM(aAPMABOOLNF);
		}
		if ((bool)POPGMEPPDOM)
		{
			POPGMEPPDOM.KGIJFBMOJPM(aAPMABOOLNF);
		}
	}

	public void PNDNLEHAHBH()
	{
		Debug.Log("Scroll Snap change started");
	}

	public void IBEANCEOAGM()
	{
		Debug.Log("Scroll Snap change finished");
	}

	public void JMAGLOELEBM(int IDLNFNNFLDN)
	{
		Debug.Log($"Scroll Snap page changed to {IDLNFNNFLDN}");
	}

	public void APFCDPBAABN()
	{
		CFAGCFHNPEM.JIBMIEKODAJ(out var CMDLDKKJAGD);
		POPGMEPPDOM.JIBMIEKODAJ(out CMDLDKKJAGD);
	}

	public void AJMDBPMOPJN(int IDLNFNNFLDN)
	{
		CFAGCFHNPEM.KGIJFBMOJPM(IDLNFNNFLDN);
	}
}
