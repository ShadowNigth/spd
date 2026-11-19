using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class CPIIHEGALLE : FOGIOGKLNIP
{
	private sealed class HLGACINJADK
	{
		internal string ALLLIGGPLMK;

		internal bool BEKJDJFLJJC(KeyValuePair<KOKIAHKJOGP, string> AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.Value == ALLLIGGPLMK;
		}
	}

	public KOKIAHKJOGP DFBLCPBNMCM;

	public Dictionary<KOKIAHKJOGP, string> IKHNNOLFBMP = new Dictionary<KOKIAHKJOGP, string>(new MOOIMDDHDPC());

	public override void Awake()
	{
		FOGIOGKLNIP.BEAGCEMBJEA = this;
		base.Awake();
	}

	public Transform OEDDNKMMOAH(string NGIHJKGIKNA, Transform JNEBJLMLOLM)
	{
		GameObject gameObject = (GameObject)Resources.Load(NGIHJKGIKNA);
		GameObject gameObject2 = DHBGHDFFOLN(NGIHJKGIKNA);
		Transform transform = gameObject2.transform;
		Transform transform2 = gameObject.transform;
		transform.parent = JNEBJLMLOLM;
		transform.localPosition = transform2.position;
		transform.localRotation = transform2.rotation;
		return transform;
	}

	public GameObject DHBGHDFFOLN(string NGIHJKGIKNA)
	{
		HLGACINJADK hLGACINJADK = new HLGACINJADK();
		hLGACINJADK.ALLLIGGPLMK = Path.GetFileName(NGIHJKGIKNA) + "(Clone)";
		KOKIAHKJOGP kOKIAHKJOGP = IKHNNOLFBMP.FirstOrDefault(hLGACINJADK.BEKJDJFLJJC).Key;
		if (kOKIAHKJOGP != null && kOKIAHKJOGP.BGJOMCIIFAK == null)
		{
			Debug.LogError("Pool Model Removed");
			IKHNNOLFBMP.Remove(kOKIAHKJOGP);
			kOKIAHKJOGP = null;
		}
		if (kOKIAHKJOGP != null)
		{
			kOKIAHKJOGP.JOBLKDDBHEF();
			IKHNNOLFBMP.Remove(kOKIAHKJOGP);
			return kOKIAHKJOGP.BGJOMCIIFAK.gameObject;
		}
		Object obj = Resources.Load(NGIHJKGIKNA);
		if (obj == null)
		{
			return null;
		}
		return (GameObject)Object.Instantiate(obj);
	}

	public void OBKMIHILMLH(Transform BGJOMCIIFAK)
	{
		OBKMIHILMLH(BGJOMCIIFAK, false);
	}

	public void OBKMIHILMLH(Transform BGJOMCIIFAK, bool FMKJGFNJIBD)
	{
		KOKIAHKJOGP kOKIAHKJOGP = new KOKIAHKJOGP();
		kOKIAHKJOGP.BGJOMCIIFAK = BGJOMCIIFAK;
		if (FOGIOGKLNIP.OMMLFOEPEEK || !IKHNNOLFBMP.ContainsKey(kOKIAHKJOGP))
		{
			IKHNNOLFBMP.Add(kOKIAHKJOGP, BGJOMCIIFAK.name);
			kOKIAHKJOGP.BEAGCEMBJEA = this;
			kOKIAHKJOGP.PFKIHJCAFJH = FMKJGFNJIBD;
			kOKIAHKJOGP.KIJMAEJNGPI();
			BGJOMCIIFAK.parent = EHOEFMPLIFB;
		}
	}
}
