using System.Collections.Generic;
using UnityEngine;

public class AEHFMCKHGNK : global::IIHKGGNCEPD<OMILCNOPMOF, DGNFCJPFDPD>
{
	[SerializeField]
	private GDCHNKKLCDA scrollPositionController;

	private new void Awake()
	{
		scrollPositionController.IEGIICJIICI.AddListener(base.DBFCKHHDNAN);
		scrollPositionController.CIDMKCHGNOF.AddListener(PLGKPHPPJJD);
		AJJGGENLDKG(new DGNFCJPFDPD
		{
			PBOMPMFNHNA = PBOMPMFNHNA
		});
		base.Awake();
	}

	public void MLMELKCDEJF(List<OMILCNOPMOF> PMPJLBPPCMF)
	{
		CGKCFEJNPMH = PMPJLBPPCMF;
		scrollPositionController.BKMNBJEHJMB(CGKCFEJNPMH.Count);
		OLFOGLIEFBF();
	}

	private void PBOMPMFNHNA(LDPEDMIGKKA HMMGOIOGJKE)
	{
		scrollPositionController.AHPCPBHKCOD(HMMGOIOGJKE.PGLLGABGMCO, 0.4f);
		KPFOIKPELPI.FGCFLEDFONL = HMMGOIOGJKE.PGLLGABGMCO;
		OLFOGLIEFBF();
	}

	private void PLGKPHPPJJD(int IEOFOLCGJGH)
	{
		KPFOIKPELPI.FGCFLEDFONL = IEOFOLCGJGH;
		OLFOGLIEFBF();
	}
}
