using System.Collections.Generic;
using UnityEngine;

public class IKMDDLIMHEA : global::IIHKGGNCEPD<BOAJOPBLBIL, OAINNAGAGKM>
{
	[SerializeField]
	private GDCHNKKLCDA scrollPositionController;

	private new void Awake()
	{
		scrollPositionController.IEGIICJIICI.AddListener(base.DBFCKHHDNAN);
		scrollPositionController.CIDMKCHGNOF.AddListener(PLGKPHPPJJD);
		AJJGGENLDKG(new OAINNAGAGKM
		{
			PBOMPMFNHNA = PBOMPMFNHNA
		});
		base.Awake();
	}

	public void MLMELKCDEJF(List<BOAJOPBLBIL> PMPJLBPPCMF)
	{
		CGKCFEJNPMH = PMPJLBPPCMF;
		scrollPositionController.BKMNBJEHJMB(CGKCFEJNPMH.Count);
		OLFOGLIEFBF();
	}

	private void PBOMPMFNHNA(FHHJJMIBHLK HMMGOIOGJKE)
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
