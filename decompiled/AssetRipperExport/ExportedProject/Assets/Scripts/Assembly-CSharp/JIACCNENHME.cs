using System.Collections.Generic;
using UnityEngine;

public class JIACCNENHME : global::PBNEHKLJAKF<EMFOGONPNBJ>
{
	[SerializeField]
	private GDCHNKKLCDA scrollPositionController;

	private new void Awake()
	{
		base.Awake();
		scrollPositionController.IEGIICJIICI.AddListener(base.DBFCKHHDNAN);
	}

	public void MLMELKCDEJF(List<EMFOGONPNBJ> PMPJLBPPCMF)
	{
		CGKCFEJNPMH = PMPJLBPPCMF;
		scrollPositionController.BKMNBJEHJMB(CGKCFEJNPMH.Count);
		OLFOGLIEFBF();
	}
}
