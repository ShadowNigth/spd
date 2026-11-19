using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[AddComponentMenu("UI/Extensions/UI Tween Scale")]
public class NJOKILLHFBP : MonoBehaviour
{
	private sealed class NGCHHAHEANH : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float CHFMDANPNGD;

		internal float LDBMEOMNFBC;

		internal NJOKILLHFBP KPHCHDHEKGH;

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
		public NGCHHAHEANH()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				KPHCHDHEKGH.CIEDFCKKEEO.localScale = KPHCHDHEKGH.EKFLJPLHLNN;
				CHFMDANPNGD = 0f;
				LDBMEOMNFBC = KPHCHDHEKGH.AEBBIMKOPOK.keys[KPHCHDHEKGH.AEBBIMKOPOK.length - 1].time;
				goto case 1u;
			case 1u:
				if (CHFMDANPNGD < LDBMEOMNFBC || KPHCHDHEKGH.DGGBKBLCPNK)
				{
					CHFMDANPNGD += KPHCHDHEKGH.CKGJADEKNGE * Time.deltaTime;
					if (!KPHCHDHEKGH.KEEGOBCDPOI)
					{
						KPHCHDHEKGH.NGOKDJDDJLK.x = 1f * KPHCHDHEKGH.AEBBIMKOPOK.Evaluate(CHFMDANPNGD);
						KPHCHDHEKGH.NGOKDJDDJLK.y = 1f * KPHCHDHEKGH.BIDCHMPPKHI.Evaluate(CHFMDANPNGD);
						KPHCHDHEKGH.CIEDFCKKEEO.localScale = KPHCHDHEKGH.NGOKDJDDJLK;
					}
					else
					{
						KPHCHDHEKGH.CIEDFCKKEEO.localScale = Vector3.one * KPHCHDHEKGH.AEBBIMKOPOK.Evaluate(CHFMDANPNGD);
					}
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
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

	public AnimationCurve AEBBIMKOPOK;

	[Tooltip("Animation speed multiplier")]
	public float CKGJADEKNGE = 1f;

	[Tooltip("If true animation will loop, for best effect set animation curve to loop on start and end point")]
	public bool DGGBKBLCPNK;

	[Tooltip("If true animation will start automatically, otherwise you need to call Play() method to start the animation")]
	public bool FDEJBHLHJHH;

	[Header("Non uniform scale")]
	[Space(10f)]
	[Tooltip("If true component will scale by the same amount in X and Y axis, otherwise use animCurve for X scale and animCurveY for Y scale")]
	public bool KEEGOBCDPOI = true;

	public AnimationCurve BIDCHMPPKHI;

	private Vector3 EKFLJPLHLNN;

	private Transform CIEDFCKKEEO;

	private Vector3 NGOKDJDDJLK = Vector3.one;

	private void Awake()
	{
		CIEDFCKKEEO = GetComponent<Transform>();
		EKFLJPLHLNN = CIEDFCKKEEO.localScale;
		if (FDEJBHLHJHH)
		{
			HNMNCIIMJHN();
		}
	}

	public void HNMNCIIMJHN()
	{
		StartCoroutine("NLIPACMELFO");
	}

	[DebuggerHidden]
	private IEnumerator NLIPACMELFO()
	{
		NGCHHAHEANH nGCHHAHEANH = new NGCHHAHEANH();
		nGCHHAHEANH.KPHCHDHEKGH = this;
		return nGCHHAHEANH;
	}

	public void LOLFDGKDECO()
	{
		StopCoroutine("NLIPACMELFO");
		CIEDFCKKEEO.localScale = EKFLJPLHLNN;
	}
}
