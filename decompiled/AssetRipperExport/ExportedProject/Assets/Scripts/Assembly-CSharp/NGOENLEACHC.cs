using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NGOENLEACHC : MonoBehaviour
{
	private sealed class JDDGLIAPECC : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal NGOENLEACHC KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public JDDGLIAPECC()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
			{
				for (int i = 0; i < KPHCHDHEKGH.PNMINMLBAMJ.childCount; i++)
				{
					if (!KPHCHDHEKGH.GLIAIIIFFPG.Contains(KPHCHDHEKGH.PNMINMLBAMJ.GetChild(i)))
					{
						KPHCHDHEKGH.NGDCHDKOMAI = KPHCHDHEKGH.PNMINMLBAMJ.GetChild(i).gameObject.GetComponent<IMBDMJKBDIL>() ?? KPHCHDHEKGH.PNMINMLBAMJ.GetChild(i).gameObject.AddComponent<IMBDMJKBDIL>();
						KPHCHDHEKGH.NGDCHDKOMAI.HIBHJDCMMAJ(KPHCHDHEKGH.MCDGGHJPKJC);
						KPHCHDHEKGH.GLIAIIIFFPG.Add(KPHCHDHEKGH.PNMINMLBAMJ.GetChild(i));
						KPHCHDHEKGH.MIHJDPDBNLC.Add(KPHCHDHEKGH.NGDCHDKOMAI);
					}
				}
				HLJEEFIJCOF = 0;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			}
			case 1u:
			{
				for (int num = KPHCHDHEKGH.GLIAIIIFFPG.Count - 1; num >= 0; num--)
				{
					if (KPHCHDHEKGH.GLIAIIIFFPG[num] == null)
					{
						KPHCHDHEKGH.GLIAIIIFFPG.RemoveAt(num);
						KPHCHDHEKGH.MIHJDPDBNLC.RemoveAt(num);
					}
				}
				GNNOELAJGPI = -1;
				break;
			}
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

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

	[DebuggerHidden]
	private IEnumerator MAAGMDOHEGC()
	{
		JDDGLIAPECC jDDGLIAPECC = new JDDGLIAPECC();
		jDDGLIAPECC.KPHCHDHEKGH = this;
		return jDDGLIAPECC;
	}
}
