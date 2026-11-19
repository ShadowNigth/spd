using UnityEngine;

public class DFLAMAILAKO : FOGIOGKLNIP
{
	public string KPBILNDCOPL;

	public override void Awake()
	{
		base.enabled = false;
		base.Awake();
	}

	public void OnGUI()
	{
		GUI.skin = FOGIOGKLNIP.LPLJMLGKCLK.EPDKDICMOHH;
		FOGIOGKLNIP.NGLMHFOKCHK(450, 250, string.Empty, HEKJLNDHNIC);
	}

	private void HEKJLNDHNIC(int JFLBOOBFAEF)
	{
		if (FOGIOGKLNIP.MHFCLILDBCM("Not now"))
		{
			base.enabled = false;
			KPBILNDCOPL = string.Empty;
			CHPOIHBIDDP();
		}
		GUILayout.Label(KPBILNDCOPL, GUILayout.ExpandWidth(expand: true));
	}

	private static void CHPOIHBIDDP()
	{
		if (FOGIOGKLNIP.INJKJFIDKJM != null)
		{
			if (FOGIOGKLNIP.INJKJFIDKJM.ILJOBCIBPBJ != null && FOGIOGKLNIP.DGMBIMMABNO)
			{
				FOGIOGKLNIP.INJKJFIDKJM.ILJOBCIBPBJ.Dispose();
			}
			FOGIOGKLNIP.INJKJFIDKJM.ILJOBCIBPBJ = null;
			if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
			{
				Network.Disconnect();
			}
		}
	}

	public void PBADCKNDABE(string MHCPAFPDMGO, string LIPFHCDCKFG)
	{
		KPBILNDCOPL = FOGIOGKLNIP.FHHPMGJCHJL(MHCPAFPDMGO + ": " + LIPFHCDCKFG);
		base.enabled = true;
	}
}
