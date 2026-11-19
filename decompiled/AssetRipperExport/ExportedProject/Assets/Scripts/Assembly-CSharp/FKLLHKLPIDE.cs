using System.Collections.Generic;
using UnityEngine;

public class FKLLHKLPIDE : FOGIOGKLNIP
{
	private static Stack<string> HMJCPCFNFIE = new Stack<string>();

	public string KPBILNDCOPL;

	public override void Awake()
	{
		base.enabled = false;
		base.Awake();
	}

	public void OnGUI()
	{
		NOMMEFIICHO.ONENCGHKFNI();
		GUI.skin = FOGIOGKLNIP.LPLJMLGKCLK.EPDKDICMOHH;
		FOGIOGKLNIP.NGLMHFOKCHK(450, 300, string.Empty, HEKJLNDHNIC);
	}

	private void HEKJLNDHNIC(int JFLBOOBFAEF)
	{
		GUI.FocusWindow(JFLBOOBFAEF);
		if (FOGIOGKLNIP.MHFCLILDBCM("Dismiss"))
		{
			base.enabled = false;
			KPBILNDCOPL = string.Empty;
			CHPOIHBIDDP();
		}
		GUILayout.Label(KPBILNDCOPL, GUILayout.ExpandWidth(true));
	}

	public static void CHPOIHBIDDP()
	{
		if (FOGIOGKLNIP.INJKJFIDKJM != null)
		{
			FOGIOGKLNIP.INJKJFIDKJM.ILJOBCIBPBJ = null;
			if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
			{
				Network.Disconnect();
			}
			if (PhotonNetwork.room != null)
			{
				PhotonNetwork.LeaveRoom();
			}
		}
		if (HMJCPCFNFIE.Count > 0)
		{
			HMJCPCFNFIE.Pop();
		}
		if (HMJCPCFNFIE.Count > 0)
		{
			string lIPFHCDCKFG = HMJCPCFNFIE.Peek();
			FOGIOGKLNIP.LPLJMLGKCLK.CODBKMAMEHL.PBADCKNDABE(string.Empty, lIPFHCDCKFG, "ok", true);
		}
	}

	public new void PBADCKNDABE(string MHCPAFPDMGO, string LIPFHCDCKFG, string KALGPODLAEM = "OK", bool MMJNLLMFOCD = false, bool INFLOKFCACB = false)
	{
		if (!base.enabled)
		{
			HMJCPCFNFIE.Clear();
		}
		if (!MMJNLLMFOCD)
		{
			MonoBehaviour.print("PopUp: " + LIPFHCDCKFG);
		}
		KPBILNDCOPL = FOGIOGKLNIP.FHHPMGJCHJL(MHCPAFPDMGO) + ": " + FOGIOGKLNIP.FHHPMGJCHJL(LIPFHCDCKFG);
		if (!MMJNLLMFOCD)
		{
			HMJCPCFNFIE.Push(LIPFHCDCKFG);
		}
		base.enabled = true;
	}
}
