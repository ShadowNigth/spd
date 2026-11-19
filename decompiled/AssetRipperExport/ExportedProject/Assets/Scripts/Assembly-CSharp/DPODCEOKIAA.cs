using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DPODCEOKIAA : MonoBehaviour
{
	[SerializeField]
	private JIACCNENHME scrollView;

	[CompilerGenerated]
	private static Func<int, EMFOGONPNBJ> ACJNADIPOMC;

	private void Start()
	{
		List<EMFOGONPNBJ> pMPJLBPPCMF = (from FAGMOBEKJND in Enumerable.Range(0, 20)
			select new EMFOGONPNBJ
			{
				BPBHMHNBHJB = "Cell " + FAGMOBEKJND
			}).ToList();
		scrollView.MLMELKCDEJF(pMPJLBPPCMF);
	}

	[CompilerGenerated]
	private static EMFOGONPNBJ JDGOKBJLEBB(int FAGMOBEKJND)
	{
		return new EMFOGONPNBJ
		{
			BPBHMHNBHJB = "Cell " + FAGMOBEKJND
		};
	}
}
