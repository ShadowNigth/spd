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
			GameObject PPBEJENPEPI;
			CFAGCFHNPEM.ICAFAJHPHKB(CFAGCFHNPEM.PKKJBIDEMBH, out PPBEJENPEPI);
			PPBEJENPEPI.SetActive(false);
		}
		if ((bool)POPGMEPPDOM)
		{
			GameObject PPBEJENPEPI2;
			POPGMEPPDOM.ICAFAJHPHKB(POPGMEPPDOM.PKKJBIDEMBH, out PPBEJENPEPI2);
			PPBEJENPEPI2.SetActive(false);
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
		Debug.Log(string.Format("Scroll Snap page changed to {0}", IDLNFNNFLDN));
	}

	public void APFCDPBAABN()
	{
		GameObject[] CMDLDKKJAGD;
		CFAGCFHNPEM.JIBMIEKODAJ(out CMDLDKKJAGD);
		POPGMEPPDOM.JIBMIEKODAJ(out CMDLDKKJAGD);
	}

	public void AJMDBPMOPJN(int IDLNFNNFLDN)
	{
		CFAGCFHNPEM.KGIJFBMOJPM(IDLNFNNFLDN);
	}
}
