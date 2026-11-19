using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class NLELPNHCJEO : FOGIOGKLNIP
{
	public GameObject DJOIFOBFCFN;

	private Vector3 IAFIDJLHGLC;

	private float DBEMCOIMJNE;

	private float NGOIMKPMKHO;

	private void Start()
	{
		DBEMCOIMJNE = Random.Range(ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.NGCBELPNJKJ), ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.NGCBELPNJKJ) + 4f);
		Object.Destroy(ICIEDCMDJFO, 60f / DBEMCOIMJNE);
	}

	private void Update()
	{
		EHOEFMPLIFB.Translate(0f, 0f, Time.deltaTime * DBEMCOIMJNE);
		Vector3 direction = base.ELGIKGAIIOD - IAFIDJLHGLC;
		RaycastHit hitInfo;
		if (IAFIDJLHGLC != Vector3.zero && Physics.Raycast(IAFIDJLHGLC, direction, out hitInfo, direction.magnitude, 268700672))
		{
			KKJBDENNKGF component = hitInfo.collider.transform.root.GetComponent<KKJBDENNKGF>();
			if (FOGIOGKLNIP.GMPBCIEDMCD != null && component == FOGIOGKLNIP.GMPBCIEDMCD)
			{
				FOGIOGKLNIP.NMGDHKIKCED.NCHOPAEKPBK(FOGIOGKLNIP.NMGDHKIKCED.KICNBMAHIEK);
			}
			if (component == null)
			{
				Object.Destroy(ICIEDCMDJFO);
			}
		}
		IAFIDJLHGLC = base.ELGIKGAIIOD;
	}
}
