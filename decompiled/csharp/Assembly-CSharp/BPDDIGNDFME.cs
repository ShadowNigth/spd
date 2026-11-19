using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class BPDDIGNDFME : MonoBehaviour
{
	public KFANEHLIPBI AJFCGCFFDLP;

	public OBFKGLEJBII EBMKGCIKJCA;

	private Slider PDPNNLBIHCG;

	private bool ONMGFAMDBAN = true;

	private void Awake()
	{
		PDPNNLBIHCG = GetComponent<Slider>();
		AJFCGCFFDLP.DNMFLMKBGAP.AddListener(JKPBFDAAKFK);
		AJFCGCFFDLP.HAKHGCCNIAJ.AddListener(EDFOHOLLKJO);
		PDPNNLBIHCG.onValueChanged.AddListener(CFHIJPEBFHI);
	}

	private void OnDestroy()
	{
		AJFCGCFFDLP.DNMFLMKBGAP.RemoveListener(JKPBFDAAKFK);
		AJFCGCFFDLP.HAKHGCCNIAJ.RemoveListener(EDFOHOLLKJO);
		PDPNNLBIHCG.onValueChanged.RemoveListener(CFHIJPEBFHI);
	}

	private void JKPBFDAAKFK(Color GNKGIKCFKMF)
	{
		ONMGFAMDBAN = false;
		switch (EBMKGCIKJCA)
		{
		case OBFKGLEJBII.ADGHIINBKLJ:
			PDPNNLBIHCG.normalizedValue = GNKGIKCFKMF.r;
			break;
		case OBFKGLEJBII.KECBPPLFKDA:
			PDPNNLBIHCG.normalizedValue = GNKGIKCFKMF.g;
			break;
		case OBFKGLEJBII.EDGDMFJAFEM:
			PDPNNLBIHCG.normalizedValue = GNKGIKCFKMF.b;
			break;
		case OBFKGLEJBII.PLLNCPNCAHN:
			PDPNNLBIHCG.normalizedValue = GNKGIKCFKMF.a;
			break;
		}
	}

	private void EDFOHOLLKJO(float OEHMBFPIKBP, float CDDPBGMABAJ, float EHAPKEKPMOE)
	{
		ONMGFAMDBAN = false;
		switch (EBMKGCIKJCA)
		{
		case OBFKGLEJBII.NMGHODPCLGP:
			PDPNNLBIHCG.normalizedValue = OEHMBFPIKBP;
			break;
		case OBFKGLEJBII.GFMADABILAD:
			PDPNNLBIHCG.normalizedValue = CDDPBGMABAJ;
			break;
		case OBFKGLEJBII.JFLFLCDEEEI:
			PDPNNLBIHCG.normalizedValue = EHAPKEKPMOE;
			break;
		}
	}

	private void CFHIJPEBFHI(float AAHPIGOGNEJ)
	{
		if (ONMGFAMDBAN)
		{
			AAHPIGOGNEJ = PDPNNLBIHCG.normalizedValue;
			AJFCGCFFDLP.JLJKHPPCGLH(EBMKGCIKJCA, AAHPIGOGNEJ);
		}
		ONMGFAMDBAN = true;
	}
}
