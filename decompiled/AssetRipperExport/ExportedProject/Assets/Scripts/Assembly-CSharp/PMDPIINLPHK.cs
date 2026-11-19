using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class PMDPIINLPHK : FOGIOGKLNIP, CJMKGJPLOPM, MNDLKGJCJCC
{
	public bool EOAJBHMJKKK;

	public GameObject EEEKBBONOAJ;

	public int BHFDJDDGHKA;

	public int IAGBJCNHIPK;

	public GNMHJEPNHDL JGECOECAJLK;

	public string EMILGEDOKKL()
	{
		return (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.JABHAJEEFNO)) ? string.Empty : ("life: " + BHFDJDDGHKA);
	}

	public void Start()
	{
		if (FOGIOGKLNIP.PIOANBBCFFP == null)
		{
			Object.DestroyImmediate(ICIEDCMDJFO);
		}
		else if (!EOAJBHMJKKK)
		{
			FOGIOGKLNIP.PIOANBBCFFP.BKFEGEAEIFB.Add(this);
		}
		int result;
		if (int.TryParse(base.name, out result))
		{
			BHFDJDDGHKA = result;
		}
		IAGBJCNHIPK = BHFDJDDGHKA;
	}

	[RPC]
	public void INKCDEBODNE(int JGECOECAJLK)
	{
		BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.ECFKJNJEMBP);
		this.JGECOECAJLK = (GNMHJEPNHDL)JGECOECAJLK;
	}

	[RPC]
	public void PMDLMNLNFMH(Vector3 ELGIKGAIIOD, Quaternion KHGAOLHJCMO)
	{
		Object.Destroy(GetComponent<Rigidbody>());
		EHOEFMPLIFB.position = ELGIKGAIIOD;
		EHOEFMPLIFB.rotation = KHGAOLHJCMO;
	}

	public override void BJGMKFIGEFA()
	{
		HBCEJOJNMNB(PLEKGNIKPEH, BHFDJDDGHKA, EHOEFMPLIFB.position);
		HBCEJOJNMNB(INKCDEBODNE, (int)JGECOECAJLK);
	}

	public void Reset()
	{
		BHFDJDDGHKA = IAGBJCNHIPK;
		ICIEDCMDJFO.SetActive(true);
	}

	public void OnEnable()
	{
		if (FOGIOGKLNIP.PIOANBBCFFP != null)
		{
			FOGIOGKLNIP.PIOANBBCFFP.HEGNCGKJMJF.Add(this);
		}
	}

	public void OnDisable()
	{
		FOGIOGKLNIP.PIOANBBCFFP.HEGNCGKJMJF.Remove(this);
	}

	[RPC]
	public void DFJGLGGOKKN(int BHFDJDDGHKA)
	{
		PLEKGNIKPEH(BHFDJDDGHKA, base.ELGIKGAIIOD);
	}

	[RPC]
	public void PLEKGNIKPEH(int BHFDJDDGHKA, Vector3 ELGIKGAIIOD)
	{
		this.BHFDJDDGHKA = BHFDJDDGHKA;
		MOHMCMAMDAL(CILHLJOJKKF.NMJPIBHOJLM, "setlife glass");
		if (BHFDJDDGHKA >= 0)
		{
			return;
		}
		Collider componentInChildren = GetComponentInChildren<Collider>();
		if (!componentInChildren)
		{
			return;
		}
		Vector3 size = componentInChildren.bounds.size;
		if (size.magnitude > 0.3f && NHGEPCNECIC(ELGIKGAIIOD) && FOGIOGKLNIP.EDBEJGJJDDA++ < base.EGPFOCNKAKB)
		{
			GameObject gameObject = Object.Instantiate(EEEKBBONOAJ, EHOEFMPLIFB.position, Quaternion.identity);
			Object.Destroy(gameObject, 3f);
			gameObject.transform.localScale = size;
			foreach (Transform transform in gameObject.transform.GetTransforms())
			{
				if (transform.GetComponent<Rigidbody>() != null)
				{
					transform.GetComponent<Rigidbody>().AddExplosionForce(50f * base.BILHMMNDCKA, ELGIKGAIIOD, 1f);
					transform.GetComponent<Renderer>().material = componentInChildren.GetComponent<Renderer>().sharedMaterial;
				}
			}
			AudioSource componentInChildren2 = GetComponentInChildren<AudioSource>();
			if (componentInChildren2 != null)
			{
				FOGIOGKLNIP.LEDCIPHCLEB(componentInChildren2.clip, ELGIKGAIIOD, 1f, true, 0.5f, 1f, 1f);
			}
		}
		if (EOAJBHMJKKK)
		{
			if (KAMAMHFJDGG)
			{
				APAMPKPNIPC();
			}
			else
			{
				Object.Destroy(ICIEDCMDJFO);
			}
		}
		else
		{
			ICIEDCMDJFO.SetActive(false);
		}
	}
}
