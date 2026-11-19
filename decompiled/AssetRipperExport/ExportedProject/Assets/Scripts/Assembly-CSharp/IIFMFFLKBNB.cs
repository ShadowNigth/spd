using UnityEngine;

public class IIFMFFLKBNB : FOGIOGKLNIP
{
	private bool BNLDNBOKJOB;

	public WWW KGEFJGEPFJD;

	public void Update()
	{
		if (KGEFJGEPFJD == null && FOGIOGKLNIP.LPLJMLGKCLK.AAJJJOONGJB.Length > 0)
		{
			JJGDBDMFKPO();
		}
		if (BMANAIHDHKF.clip != null && BMANAIHDHKF.clip.isReadyToPlay && !BMANAIHDHKF.isPlaying)
		{
			if (BNLDNBOKJOB)
			{
				Debug.LogWarning("Next");
				BNLDNBOKJOB = false;
				JJGDBDMFKPO();
			}
			else
			{
				Debug.LogWarning("Play");
				BNLDNBOKJOB = true;
				BMANAIHDHKF.Play();
			}
		}
	}

	public void OnDisable()
	{
		BNLDNBOKJOB = false;
		KGEFJGEPFJD = null;
	}

	private void JJGDBDMFKPO()
	{
		string text = FOGIOGKLNIP.LPLJMLGKCLK.AAJJJOONGJB.Random();
		KGEFJGEPFJD = new WWW(text);
		Debug.LogWarning("Download " + text);
		BMANAIHDHKF.clip = KGEFJGEPFJD.GetAudioClip(false, true);
	}
}
