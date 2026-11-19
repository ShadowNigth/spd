using UnityEngine;
using UnityEngine.UI;

public class JCFMCGHAJAE : MonoBehaviour, DHIONDECIAP
{
	private bool IKDNNPIDHHK;

	private bool BOKGPAIDANA;

	private SpriteRenderer DOCOELHIAJO;

	private Image GBCLDBHACGH;

	private Text KLLKONMADKA;

	public bool HNJBPICPKIJ
	{
		get
		{
			return IKDNNPIDHHK;
		}
		set
		{
			IKDNNPIDHHK = value;
		}
	}

	public bool EMNPHMEIKKK
	{
		get
		{
			return BOKGPAIDANA;
		}
		set
		{
			BOKGPAIDANA = value;
		}
	}

	Transform DHIONDECIAP.transform
	{
		get
		{
			return base.transform;
		}
	}

	private void Start()
	{
		DOCOELHIAJO = base.transform.GetComponent<SpriteRenderer>();
		GBCLDBHACGH = base.transform.GetComponent<Image>();
		KLLKONMADKA = base.transform.GetComponent<Text>();
	}

	private void Update()
	{
		Color color = Color.white;
		if (EMNPHMEIKKK)
		{
			color = Color.yellow;
		}
		if (HNJBPICPKIJ)
		{
			color = Color.green;
		}
		if ((bool)DOCOELHIAJO)
		{
			DOCOELHIAJO.color = color;
		}
		else if ((bool)KLLKONMADKA)
		{
			KLLKONMADKA.color = color;
		}
		else if ((bool)GBCLDBHACGH)
		{
			GBCLDBHACGH.color = color;
		}
		else if ((bool)GetComponent<Renderer>())
		{
			GetComponent<Renderer>().material.color = color;
		}
	}
}
