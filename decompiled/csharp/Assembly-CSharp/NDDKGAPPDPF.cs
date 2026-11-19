using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NDDKGAPPDPF : MonoBehaviour
{
	[SerializeField]
	private IKMDDLIMHEA scrollView;

	[CompilerGenerated]
	private static Func<int, BOAJOPBLBIL> ACJNADIPOMC;

	private void Start()
	{
		List<BOAJOPBLBIL> pMPJLBPPCMF = (from FAGMOBEKJND in Enumerable.Range(0, 20)
			select new BOAJOPBLBIL
			{
				BPBHMHNBHJB = "Cell " + FAGMOBEKJND
			}).ToList();
		scrollView.MLMELKCDEJF(pMPJLBPPCMF);
	}

	[CompilerGenerated]
	private static BOAJOPBLBIL JDGOKBJLEBB(int FAGMOBEKJND)
	{
		return new BOAJOPBLBIL
		{
			BPBHMHNBHJB = "Cell " + FAGMOBEKJND
		};
	}
}
