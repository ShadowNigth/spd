using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGOENLEACHC : MonoBehaviour
{
	private List<Transform> GLIAIIIFFPG;

	private List<IMBDMJKBDIL> MIHJDPDBNLC;

	private IMBDMJKBDIL NGDCHDKOMAI;

	private EHKBCGLPBEJ MCDGGHJPKJC;

	private RectTransform PNMINMLBAMJ;

	private void OnEnable()
	{
		if ((bool)PNMINMLBAMJ)
		{
			StartCoroutine(MAAGMDOHEGC());
		}
	}

	public void OnTransformChildrenChanged()
	{
		if (base.isActiveAndEnabled)
		{
			StartCoroutine(MAAGMDOHEGC());
		}
	}

	public void HIBHJDCMMAJ(EHKBCGLPBEJ KPMNAGDBPJO)
	{
		MCDGGHJPKJC = KPMNAGDBPJO;
		PNMINMLBAMJ = GetComponent<RectTransform>();
		GLIAIIIFFPG = new List<Transform>();
		MIHJDPDBNLC = new List<IMBDMJKBDIL>();
		StartCoroutine(MAAGMDOHEGC());
	}

	private IEnumerator MAAGMDOHEGC()
	{
		for (int i = 0; i < PNMINMLBAMJ.childCount; i++)
		{
			if (!GLIAIIIFFPG.Contains(PNMINMLBAMJ.GetChild(i)))
			{
				NGDCHDKOMAI = PNMINMLBAMJ.GetChild(i).gameObject.GetComponent<IMBDMJKBDIL>() ?? PNMINMLBAMJ.GetChild(i).gameObject.AddComponent<IMBDMJKBDIL>();
				NGDCHDKOMAI.HIBHJDCMMAJ(MCDGGHJPKJC);
				GLIAIIIFFPG.Add(PNMINMLBAMJ.GetChild(i));
				MIHJDPDBNLC.Add(NGDCHDKOMAI);
			}
		}
		yield return 0;
		for (int num = GLIAIIIFFPG.Count - 1; num >= 0; num--)
		{
			if (GLIAIIIFFPG[num] == null)
			{
				GLIAIIIFFPG.RemoveAt(num);
				MIHJDPDBNLC.RemoveAt(num);
			}
		}
	}
}
