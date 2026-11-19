using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

internal class HBNDNEIIGMI<T> where T : struct, KEDIOCMEKPK
{
	private sealed class DDJOPLCFOND : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal T JNCDBDFDJCP;

		internal float DLMFCLBHFHE;

		internal float PDGNMMCDPOM;

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
		public DDJOPLCFOND()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (!JNCDBDFDJCP.EDGKDFKMFDL())
				{
					goto default;
				}
				DLMFCLBHFHE = 0f;
				goto case 1u;
			case 1u:
				if (DLMFCLBHFHE < JNCDBDFDJCP.PJBGGDBFEEP)
				{
					DLMFCLBHFHE += ((!JNCDBDFDJCP.ADDDPKEAFFD) ? Time.deltaTime : Time.unscaledDeltaTime);
					PDGNMMCDPOM = Mathf.Clamp01(DLMFCLBHFHE / JNCDBDFDJCP.PJBGGDBFEEP);
					JNCDBDFDJCP.NAPEJNEJBMM(PDGNMMCDPOM);
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				JNCDBDFDJCP.NAPEJNEJBMM(1f);
				JNCDBDFDJCP.PKEPNLCEPDP();
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

	protected MonoBehaviour NEBHGFIAJBK;

	protected IEnumerator ILIDLFEILNB;

	[DebuggerHidden]
	private static IEnumerator JMLAEOGOGDP(T JNCDBDFDJCP)
	{
		DDJOPLCFOND dDJOPLCFOND = new DDJOPLCFOND();
		dDJOPLCFOND.JNCDBDFDJCP = JNCDBDFDJCP;
		return dDJOPLCFOND;
	}

	public void HIBHJDCMMAJ(MonoBehaviour FBNIEBCLOHG)
	{
		NEBHGFIAJBK = FBNIEBCLOHG;
	}

	public void CLAHIBCEFPC(T LIEKABKEJOG)
	{
		if (NEBHGFIAJBK == null)
		{
			UnityEngine.Debug.LogWarning("Coroutine container not configured... did you forget to call Init?");
			return;
		}
		if (ILIDLFEILNB != null)
		{
			NEBHGFIAJBK.StopCoroutine(ILIDLFEILNB);
			ILIDLFEILNB = null;
		}
		if (!NEBHGFIAJBK.gameObject.activeInHierarchy)
		{
			LIEKABKEJOG.NAPEJNEJBMM(1f);
			return;
		}
		ILIDLFEILNB = JMLAEOGOGDP(LIEKABKEJOG);
		NEBHGFIAJBK.StartCoroutine(ILIDLFEILNB);
	}
}
