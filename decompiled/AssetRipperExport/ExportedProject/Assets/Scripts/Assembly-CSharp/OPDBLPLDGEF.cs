using UnityEngine;

public class OPDBLPLDGEF : FOGIOGKLNIP
{
	public bool DKDOMBOJLJI = true;

	public bool FFHOGJBIPJO;

	public bool JGHAOIGBDOH;

	private bool? CNLDPFOAGMB;

	public GUITexture IHANIHNINDE;

	public bool KIJMAEJNGPI
	{
		get
		{
			bool? cNLDPFOAGMB = CNLDPFOAGMB;
			bool value;
			if (cNLDPFOAGMB.HasValue)
			{
				value = cNLDPFOAGMB.Value;
			}
			else
			{
				bool? flag = (CNLDPFOAGMB = FOGIOGKLNIP.ICLCHCGKAPN("Hide" + base.name, FFHOGJBIPJO ? 1 : 0) == 1);
				value = flag.Value;
			}
			return value;
		}
		set
		{
			CNLDPFOAGMB = value;
			FOGIOGKLNIP.BBKFOHCEOCK("Hide" + base.name, value ? 1 : 0);
			GetComponent<GUITexture>().enabled = !value;
		}
	}

	public override void Awake()
	{
		base.Awake();
		base.enabled = false;
		EHOEFMPLIFB.position = new Vector3(FOGIOGKLNIP.CMBFGIGIDIP(base.name + "ButtonX", base.ELGIKGAIIOD.x), FOGIOGKLNIP.CMBFGIGIDIP(base.name + "ButtonY", base.ELGIKGAIIOD.y));
		if (IHANIHNINDE == null)
		{
			IHANIHNINDE = GetComponent<GUITexture>();
		}
		if (DKDOMBOJLJI)
		{
			Vector3 eHAPKEKPMOE = Vector3.one * FOGIOGKLNIP.CMBFGIGIDIP(name + "Scale", 0.125f);
			eHAPKEKPMOE.x *= (float)Screen.height / (float)Screen.width;
			GetComponent<GUITexture>().pixelInset = default(Rect);
			ALIEGLIAJOI = eHAPKEKPMOE;
		}
	}

	public void Start()
	{
	}

	public void Update()
	{
		if (!FOGIOGKLNIP.CIEBMCOJGCC.HNDGHLLDNKN && !JGHAOIGBDOH)
		{
			FOGIOGKLNIP.CIEBMCOJGCC.CPAKDFKNHLL = true;
			if (PBNCNLDIFIF(IHANIHNINDE, default(TouchPhase)))
			{
				FOGIOGKLNIP.CIEBMCOJGCC.HBANHGNGFLL = this;
				FOGIOGKLNIP.CIEBMCOJGCC.DLCCOFAPPDO = base.ALIEGLIAJOI;
			}
			if (FOGIOGKLNIP.HJDAJDIIMPD.Length == 1 && PBNCNLDIFIF(IHANIHNINDE, TouchPhase.Moved))
			{
				FOGIOGKLNIP.CIEBMCOJGCC.HNDGHLLDNKN = true;
				Vector3 position = FOGIOGKLNIP.KEBJNPDADMO.position;
				position.x /= Screen.width;
				position.y /= Screen.height;
				EHOEFMPLIFB.position = position;
				FOGIOGKLNIP.DEJNFKMKPKN(base.name + "ButtonX", base.ELGIKGAIIOD.x);
				FOGIOGKLNIP.DEJNFKMKPKN(base.name + "ButtonY", base.ELGIKGAIIOD.y);
			}
			FOGIOGKLNIP.CIEBMCOJGCC.CPAKDFKNHLL = false;
		}
	}
}
