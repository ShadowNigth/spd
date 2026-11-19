using UnityEngine;

public class BEMALDLIIMN : FOGIOGKLNIP, CJMKGJPLOPM
{
	public AnimationClip ADMBHHGPPAM;

	public AnimationClip IOELOKNDNDG;

	public bool AGAKCGHDIFO;

	public void Start()
	{
		if (FOGIOGKLNIP.PIOANBBCFFP == null)
		{
			Object.DestroyImmediate(ICIEDCMDJFO);
		}
		else
		{
			FOGIOGKLNIP.PIOANBBCFFP.BKFEGEAEIFB.Add(this);
		}
	}

	[RPC]
	public void DLHCHMALIPP(bool GNIHJGIJKLM)
	{
		AudioSource componentInChildren = GetComponentInChildren<AudioSource>();
		if (componentInChildren != null)
		{
			componentInChildren.Play();
		}
		AIAJBBMCIBK.Stop();
		AIAJBBMCIBK.Rewind();
		AGAKCGHDIFO = GNIHJGIJKLM;
		AIAJBBMCIBK.Play((!GNIHJGIJKLM) ? IOELOKNDNDG.name : ADMBHHGPPAM.name);
	}

	public override void BJGMKFIGEFA()
	{
		HBCEJOJNMNB(DLHCHMALIPP, AGAKCGHDIFO);
	}

	public void Reset()
	{
		DLHCHMALIPP(GNIHJGIJKLM: false);
	}
}
