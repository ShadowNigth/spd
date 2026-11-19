using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LAKMNECADIN : MonoBehaviour
{
	public KFANEHLIPBI MBFJEBHOFCC;

	public OBFKGLEJBII EBMKGCIKJCA;

	public string MEGEODGDDAH = "R: ";

	public float ANOEFHMLOKL;

	public float OBFNPJEKFLL = 255f;

	public int AAAMAJLOOIP;

	private Text MGDJNMNHMFM;

	private void Awake()
	{
		MGDJNMNHMFM = GetComponent<Text>();
	}

	private void OnEnable()
	{
		if (Application.isPlaying && MBFJEBHOFCC != null)
		{
			MBFJEBHOFCC.DNMFLMKBGAP.AddListener(JKPBFDAAKFK);
			MBFJEBHOFCC.HAKHGCCNIAJ.AddListener(EDFOHOLLKJO);
		}
	}

	private void OnDestroy()
	{
		if (MBFJEBHOFCC != null)
		{
			MBFJEBHOFCC.DNMFLMKBGAP.RemoveListener(JKPBFDAAKFK);
			MBFJEBHOFCC.HAKHGCCNIAJ.RemoveListener(EDFOHOLLKJO);
		}
	}

	private void JKPBFDAAKFK(Color JPLPPELPDKF)
	{
		JIAHFLEIFJG();
	}

	private void EDFOHOLLKJO(float OEHMBFPIKBP, float NEACBGMLPAN, float EHAPKEKPMOE)
	{
		JIAHFLEIFJG();
	}

	private void JIAHFLEIFJG()
	{
		if (MBFJEBHOFCC == null)
		{
			MGDJNMNHMFM.text = MEGEODGDDAH + "-";
			return;
		}
		float eHAPKEKPMOE = ANOEFHMLOKL + MBFJEBHOFCC.IBDCGCNGOCL(EBMKGCIKJCA) * (OBFNPJEKFLL - ANOEFHMLOKL);
		MGDJNMNHMFM.text = MEGEODGDDAH + EENGCJOJPDC(eHAPKEKPMOE);
	}

	private string EENGCJOJPDC(float EHAPKEKPMOE)
	{
		if (AAAMAJLOOIP > 0)
		{
			return EHAPKEKPMOE.ToString("f " + AAAMAJLOOIP);
		}
		return Mathf.FloorToInt(EHAPKEKPMOE).ToString();
	}
}
