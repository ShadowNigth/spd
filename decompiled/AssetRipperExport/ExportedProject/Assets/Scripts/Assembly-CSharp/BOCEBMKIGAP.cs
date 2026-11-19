using System.Runtime.CompilerServices;
using UnityEngine;

public class BOCEBMKIGAP : ANCGOFOIADD
{
	public ParticleSystem FLBAMNHPPHP;

	internal bool BIDGHMKKIPC;

	public override void Start()
	{
		base.Start();
	}

	public override void Update()
	{
		FLBAMNHPPHP.transform.rotation = Quaternion.identity;
		base.Update();
	}

	public override void KIKEOPPIKNP()
	{
		NCHOPAEKPBK(CHDLHLJEAKP, base.ELGIKGAIIOD);
	}

	[RPC]
	public override void CHDLHLJEAKP(Vector3 ELGIKGAIIOD)
	{
		FLBAMNHPPHP.Play();
		FOGIOGKLNIP.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.GrenadeExplosion[PDNKHCIIDKJ], ELGIKGAIIOD, true, 0.5f, 1f, 1f);
		if (KAMAMHFJDGG)
		{
			StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(60f, delegate
			{
				APAMPKPNIPC();
			}));
		}
	}

	[RPC]
	public override void FAHNKLMLPDA(Vector3 OGJIDBEODPM, Vector3 PDAKFGKELOC, NetworkViewID JDKLJHNJNLG)
	{
		base.FAHNKLMLPDA(OGJIDBEODPM, PDAKFGKELOC, JDKLJHNJNLG);
	}

	[RPC]
	public override void FAHNKLMLPDA(Vector3 OGJIDBEODPM, Vector3 PDAKFGKELOC, PhotonViewID JDKLJHNJNLG)
	{
		base.FAHNKLMLPDA(OGJIDBEODPM, PDAKFGKELOC, JDKLJHNJNLG);
	}

	[CompilerGenerated]
	private void CCFIDEMAEBJ()
	{
		APAMPKPNIPC();
	}
}
