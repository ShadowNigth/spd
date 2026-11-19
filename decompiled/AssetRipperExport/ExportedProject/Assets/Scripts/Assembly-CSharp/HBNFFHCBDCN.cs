using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HBNFFHCBDCN : MonoBehaviour
{
	[SerializeField]
	private AEHFMCKHGNK scrollView;

	[CompilerGenerated]
	private static Func<int, OMILCNOPMOF> ACJNADIPOMC;

	private void Start()
	{
		List<OMILCNOPMOF> pMPJLBPPCMF = (from FAGMOBEKJND in Enumerable.Range(0, 20)
			select new OMILCNOPMOF
			{
				BPBHMHNBHJB = "Cell " + FAGMOBEKJND
			}).ToList();
		scrollView.MLMELKCDEJF(pMPJLBPPCMF);
	}

	[CompilerGenerated]
	private static OMILCNOPMOF JDGOKBJLEBB(int FAGMOBEKJND)
	{
		return new OMILCNOPMOF
		{
			BPBHMHNBHJB = "Cell " + FAGMOBEKJND
		};
	}
}
