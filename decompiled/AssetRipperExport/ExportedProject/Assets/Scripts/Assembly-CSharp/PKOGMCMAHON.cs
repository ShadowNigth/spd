using System;
using System.Collections.Generic;
using UnityEngine;

public class PKOGMCMAHON : FOGIOGKLNIP
{
	public int DOAJDAENIDF;

	public int OHAMOBDMCCJ;

	public string KALBBOCCOFB;

	public Action HEKJLNDHNIC;

	public Action MMJNLLMFOCD;

	public NBOGOKNEBGI GPDOGCMPINO = NBOGOKNEBGI.IPBFPHDFNNH;

	public Queue<GUI.WindowFunction> DENAHLOGHCO = new Queue<GUI.WindowFunction>();

	public Vector2 LOADKHHJCDK;

	private bool HDBDBEINKJJ;

	public override void Awake()
	{
		base.enabled = false;
		base.Awake();
	}

	public void Update()
	{
		if (MMJNLLMFOCD != null)
		{
			MMJNLLMFOCD();
		}
	}

	public void OnGUI()
	{
		NOMMEFIICHO.ONENCGHKFNI();
		FOGIOGKLNIP.EHBNELHGBHE = string.Empty;
		GUI.skin = FOGIOGKLNIP.LPLJMLGKCLK.EPDKDICMOHH;
		if (HEKJLNDHNIC == null)
		{
			base.enabled = false;
		}
		else
		{
			FOGIOGKLNIP.NGLMHFOKCHK(DOAJDAENIDF, OHAMOBDMCCJ, KALBBOCCOFB, KCDJCEKJFKL, FGJCEHCCEEO.FKLLHKLPIDE, GPDOGCMPINO, GUI.skin.window);
		}
	}

	public void KCDJCEKJFKL(int FAGMOBEKJND)
	{
		if (HDBDBEINKJJ)
		{
			LOADKHHJCDK = GUILayout.BeginScrollView(LOADKHHJCDK);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("<<Back"))
		{
			DLILAHLOKKC();
		}
		else
		{
			HEKJLNDHNIC();
		}
		if (HDBDBEINKJJ)
		{
			GUILayout.EndScrollView();
		}
	}

	public void MFEPFODPFHA(Action JCMELGFLGCD)
	{
		MonoBehaviour.print("Show Window " + JCMELGFLGCD.Method.Name);
		MFEPFODPFHA(300, 300, "Window", NBOGOKNEBGI.IPBFPHDFNNH, JCMELGFLGCD);
	}

	public void MFEPFODPFHA(int HKCJBFIKALL, int PIFPICMFHAD, string KALBBOCCOFB, NBOGOKNEBGI GPDOGCMPINO, Action JCMELGFLGCD, Action LBCKEAMIACO = null, bool DMHLBFCJLJG = false)
	{
		LOADKHHJCDK = Vector2.zero;
		base.MDBAFPKAKKK = false;
		base.enabled = true;
		HDBDBEINKJJ = DMHLBFCJLJG;
		DOAJDAENIDF = HKCJBFIKALL;
		OHAMOBDMCCJ = PIFPICMFHAD;
		this.KALBBOCCOFB = KALBBOCCOFB;
		this.GPDOGCMPINO = GPDOGCMPINO;
		HEKJLNDHNIC = JCMELGFLGCD;
		MMJNLLMFOCD = LBCKEAMIACO;
	}

	public void DLILAHLOKKC()
	{
		HEKJLNDHNIC = null;
		MMJNLLMFOCD = null;
	}
}
