using System;
using UnityEngine;
using UnityEngine.UI;

public class NMIPMNLBCJE : MonoBehaviour
{
	public RectTransform DFPKECLLMFH;

	public RectTransform EACBMOGIHOI;

	public RectTransform NIGOFFNLGIG;

	public GameObject FPKKIKELBHL;

	public GameObject PNKPBIJGOMG;

	public GameObject PPBBKDBDHCL;

	private GameObject[] FKGCAFEMBCC;

	private GameObject[] BLLJOLCBJEK;

	private GameObject[] DGLMCOBAAFO;

	public RectTransform CKAHKOPCNME;

	public RectTransform FFPPIMJGMGO;

	public RectTransform NCLMELAPBCE;

	private ENHOKEJKKMH IHHFBNKFGOH;

	private ENHOKEJKKMH LNOJLJHIFLG;

	private ENHOKEJKKMH POMAAAAJAFA;

	public InputField JKALBFJGELO;

	public InputField PPEEBKKMCPO;

	public InputField OCLNFBHBAIJ;

	public Text CGCDANJCECC;

	private int OAMHLMNAICN;

	private int AMJIGCKBBIP;

	private int HIHIMJELEPG;

	private void MILEAFJJBGB()
	{
		int num = int.Parse(DateTime.Now.ToString("yyyy"));
		int[] array = new int[num + 1 - 1900];
		BLLJOLCBJEK = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 1900 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(FPKKIKELBHL, new Vector3(0f, i * 80, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(EACBMOGIHOI, false);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "Year_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			BLLJOLCBJEK[i] = gameObject;
		}
	}

	private void LEGMIFKDIAK()
	{
		int[] array = new int[12];
		FKGCAFEMBCC = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(PNKPBIJGOMG, new Vector3(0f, i * 80, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(DFPKECLLMFH, false);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			switch (i)
			{
			case 0:
				text = "Jan";
				break;
			case 1:
				text = "Feb";
				break;
			case 2:
				text = "Mar";
				break;
			case 3:
				text = "Apr";
				break;
			case 4:
				text = "May";
				break;
			case 5:
				text = "Jun";
				break;
			case 6:
				text = "Jul";
				break;
			case 7:
				text = "Aug";
				break;
			case 8:
				text = "Sep";
				break;
			case 9:
				text = "Oct";
				break;
			case 10:
				text = "Nov";
				break;
			case 11:
				text = "Dec";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "Month_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			FKGCAFEMBCC[i] = gameObject;
		}
	}

	private void HOJHMGFAEEO()
	{
		int[] array = new int[31];
		DGLMCOBAAFO = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate(PPBBKDBDHCL, new Vector3(0f, i * 80, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(NIGOFFNLGIG, false);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "Day_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DGLMCOBAAFO[i] = gameObject;
		}
	}

	public void Awake()
	{
		MILEAFJJBGB();
		LEGMIFKDIAK();
		HOJHMGFAEEO();
		LNOJLJHIFLG = new ENHOKEJKKMH(DFPKECLLMFH, FKGCAFEMBCC, CKAHKOPCNME);
		IHHFBNKFGOH = new ENHOKEJKKMH(EACBMOGIHOI, BLLJOLCBJEK, FFPPIMJGMGO);
		POMAAAAJAFA = new ENHOKEJKKMH(NIGOFFNLGIG, DGLMCOBAAFO, NCLMELAPBCE);
		LNOJLJHIFLG.Start();
		IHHFBNKFGOH.Start();
		POMAAAAJAFA.Start();
	}

	public void FLKCEFHKHKM()
	{
		OAMHLMNAICN = int.Parse(JKALBFJGELO.text) - 1;
		AMJIGCKBBIP = int.Parse(PPEEBKKMCPO.text) - 1;
		HIHIMJELEPG = int.Parse(OCLNFBHBAIJ.text) - 1900;
		POMAAAAJAFA.LGNGEBMKDLP(OAMHLMNAICN);
		LNOJLJHIFLG.LGNGEBMKDLP(AMJIGCKBBIP);
		IHHFBNKFGOH.LGNGEBMKDLP(HIHIMJELEPG);
	}

	private void Update()
	{
		LNOJLJHIFLG.Update();
		IHHFBNKFGOH.Update();
		POMAAAAJAFA.Update();
		string text = POMAAAAJAFA.LBILGMBGDNP();
		string text2 = LNOJLJHIFLG.LBILGMBGDNP();
		string text3 = IHHFBNKFGOH.LBILGMBGDNP();
		text = ((text.EndsWith("1") && text != "11") ? (text + "st") : ((text.EndsWith("2") && text != "12") ? (text + "nd") : ((!text.EndsWith("3") || !(text != "13")) ? (text + "th") : (text + "rd"))));
		CGCDANJCECC.text = text2 + " " + text + " " + text3;
	}

	public void PJCKPNFCKCH()
	{
		POMAAAAJAFA.GNNAGHKEBHE();
	}

	public void DDLHGLKGPLL()
	{
		POMAAAAJAFA.PIBFILIFOBI();
	}

	public void BKDNKGILFMA()
	{
		LNOJLJHIFLG.GNNAGHKEBHE();
	}

	public void DCFGLELEFBC()
	{
		LNOJLJHIFLG.PIBFILIFOBI();
	}

	public void EEPIGPCEAAF()
	{
		IHHFBNKFGOH.GNNAGHKEBHE();
	}

	public void BDBLMOPAIPG()
	{
		IHHFBNKFGOH.PIBFILIFOBI();
	}
}
