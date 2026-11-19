using UnityEngine;
using UnityEngine.Events;

public struct DLDBIMEGKAM : KEDIOCMEKPK
{
	public class MMIGKDCNEKP : UnityEvent<float>
	{
	}

	public class HBNKNCHMKNN : UnityEvent
	{
	}

	private float KCNJCJMNECO;

	private float LHNHDKNBHBD;

	private float IIHGEBFOFKF;

	private bool KDBPPOHBMJA;

	private MMIGKDCNEKP ADFPACBGAPK;

	private HBNKNCHMKNN ANNNOLPBEOK;

	public float ADBFOEIKDIJ
	{
		get
		{
			return KCNJCJMNECO;
		}
		set
		{
			KCNJCJMNECO = value;
		}
	}

	public float LBABCBPBAHL
	{
		get
		{
			return LHNHDKNBHBD;
		}
		set
		{
			LHNHDKNBHBD = value;
		}
	}

	public float PJBGGDBFEEP
	{
		get
		{
			return IIHGEBFOFKF;
		}
		set
		{
			IIHGEBFOFKF = value;
		}
	}

	public bool ADDDPKEAFFD
	{
		get
		{
			return KDBPPOHBMJA;
		}
		set
		{
			KDBPPOHBMJA = value;
		}
	}

	public void NAPEJNEJBMM(float IHDFAOBLIJG)
	{
		if (EDGKDFKMFDL())
		{
			ADFPACBGAPK.Invoke(Mathf.Lerp(KCNJCJMNECO, LHNHDKNBHBD, IHDFAOBLIJG));
		}
	}

	public void IOMMGJKMPMM(UnityAction<float> JLNCPFNPKMM)
	{
		if (ADFPACBGAPK == null)
		{
			ADFPACBGAPK = new MMIGKDCNEKP();
		}
		ADFPACBGAPK.AddListener(JLNCPFNPKMM);
	}

	public void NOKBJEOIGDF(UnityAction JLNCPFNPKMM)
	{
		if (ANNNOLPBEOK == null)
		{
			ANNNOLPBEOK = new HBNKNCHMKNN();
		}
		ANNNOLPBEOK.AddListener(JLNCPFNPKMM);
	}

	public bool CLEHNBDHEFE()
	{
		return KDBPPOHBMJA;
	}

	public float MGAFINLONFJ()
	{
		return IIHGEBFOFKF;
	}

	public bool EDGKDFKMFDL()
	{
		return ADFPACBGAPK != null;
	}

	public void PKEPNLCEPDP()
	{
		if (ANNNOLPBEOK != null)
		{
			ANNNOLPBEOK.Invoke();
		}
	}
}
