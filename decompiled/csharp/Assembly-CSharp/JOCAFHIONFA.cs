using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class JOCAFHIONFA : IAPJEBKJEHC
{
	public static bool GGEBNCCEOGD;

	public float EEEDEAGBIGH = 15f;

	public float BCIHMPMMBBP = 3f;

	private float LKEDAHHEBFF;

	private float KFCGJEJJHDH;

	[Field(name = "More Settings", customOnly = true)]
	public GameObject DLHLKPMGHOO;

	public Material JALAIOCAOPL;

	public override ObscuredBool FEAMJAKLLLO
	{
		get
		{
			return base.CGGHOLCLFDG;
		}
		set
		{
			EABMOMPIMOF = value;
			if (!ObscuredBool.FNIPJFGEFFD(value))
			{
				base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(0);
			}
		}
	}

	public override void Update()
	{
		base.Update();
		MPELBBLOCFF = Time.time - KFCGJEJJHDH < 1f && KFCGJEJJHDH != 0f;
		if (!(NJEPMOIDJKH == FOGIOGKLNIP.NMGDHKIKCED))
		{
			return;
		}
		if (LKEDAHHEBFF == 0f)
		{
			if ((FOGIOGKLNIP.CNIAIOJACDA || GGEBNCCEOGD) && ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) > 0)
			{
				GGEBNCCEOGD = false;
				LKEDAHHEBFF = Time.time;
				NCHOPAEKPBK(ENJLCEJIANC, "start");
			}
		}
		else
		{
			if (!(Time.time - LKEDAHHEBFF > ObscuredFloat.FNIPJFGEFFD(ODPDBIENMGH.Time) * 0.5f / 1f) || FOGIOGKLNIP.CNIAIOJACDA)
			{
				return;
			}
			LKEDAHHEBFF = 0f;
			NCHOPAEKPBK(ENJLCEJIANC, "throw");
			NCHOPAEKPBK(JFFMCCDKBND);
			StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(ObscuredFloat.FNIPJFGEFFD(ODPDBIENMGH.Time) * 0.35f, delegate
			{
				base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) - 1);
				ANCGOFOIADD component = ICONFJBEJPN(DLHLKPMGHOO, base.ELGIKGAIIOD, Quaternion.identity, 2).GetComponent<ANCGOFOIADD>();
				component.NCHOPAEKPBK(component.FAHNKLMLPDA, base.ELGIKGAIIOD, base.EHOEFMPLIFB.forward * EEEDEAGBIGH + base.EHOEFMPLIFB.up * BCIHMPMMBBP, NJEPMOIDJKH.BJDCCKHBENA.MFAGKFPCJFG);
				StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(0.5f, delegate
				{
					if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) > 0 && !FOGIOGKLNIP.DGMBIMMABNO)
					{
						NCHOPAEKPBK(ENJLCEJIANC, "draw");
					}
					else
					{
						NJEPMOIDJKH.CFINPAOKCDB();
					}
				}));
			}));
		}
	}

	public override void ELPILFMDIKG()
	{
		LKEDAHHEBFF = 0f;
		base.ELPILFMDIKG();
	}

	[RPC]
	public override void CHEOEJNGLFP(bool EHAPKEKPMOE)
	{
		base.CHEOEJNGLFP(EHAPKEKPMOE);
	}

	[RPC]
	public void JFFMCCDKBND()
	{
		KFCGJEJJHDH = Time.time;
		NJEPMOIDJKH.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.GrenadeThrow);
	}

	[RPC]
	public void ENJLCEJIANC(string LGNIFJCEECH)
	{
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Stop();
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play(LGNIFJCEECH);
		}
	}

	[CompilerGenerated]
	private void CGOJPCBLPOI()
	{
		base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) - 1);
		ANCGOFOIADD component = ICONFJBEJPN(DLHLKPMGHOO, base.ELGIKGAIIOD, Quaternion.identity, 2).GetComponent<ANCGOFOIADD>();
		component.NCHOPAEKPBK(component.FAHNKLMLPDA, base.ELGIKGAIIOD, base.EHOEFMPLIFB.forward * EEEDEAGBIGH + base.EHOEFMPLIFB.up * BCIHMPMMBBP, NJEPMOIDJKH.BJDCCKHBENA.MFAGKFPCJFG);
		StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(0.5f, delegate
		{
			if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) > 0 && !FOGIOGKLNIP.DGMBIMMABNO)
			{
				NCHOPAEKPBK(ENJLCEJIANC, "draw");
			}
			else
			{
				NJEPMOIDJKH.CFINPAOKCDB();
			}
		}));
	}

	[CompilerGenerated]
	private void NBECBCLALHF()
	{
		if (ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) > 0 && !FOGIOGKLNIP.DGMBIMMABNO)
		{
			NCHOPAEKPBK(ENJLCEJIANC, "draw");
		}
		else
		{
			NJEPMOIDJKH.CFINPAOKCDB();
		}
	}
}
