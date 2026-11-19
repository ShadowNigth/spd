using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class LMFPHFMDKDK
{
	private sealed class JJCMMDPOHDD : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal AudioSource AEMBPMJMOAB;

		internal float BABHBOHAODO;

		internal float PJBGGDBFEEP;

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
		public JJCMMDPOHDD()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				BABHBOHAODO = AEMBPMJMOAB.volume;
				goto case 1u;
			case 1u:
				if (AEMBPMJMOAB.volume > 0f)
				{
					AEMBPMJMOAB.volume -= BABHBOHAODO * Time.deltaTime / PJBGGDBFEEP;
					HLJEEFIJCOF = new WaitForEndOfFrame();
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				AEMBPMJMOAB.Stop();
				AEMBPMJMOAB.volume = BABHBOHAODO;
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

	public static void OCMFKPOIEJK(this AudioSource AEMBPMJMOAB, float PJBGGDBFEEP)
	{
		AEMBPMJMOAB.GetComponent<MonoBehaviour>().StartCoroutine(EIJJHDICGLL(AEMBPMJMOAB, PJBGGDBFEEP));
	}

	[DebuggerHidden]
	private static IEnumerator EIJJHDICGLL(AudioSource AEMBPMJMOAB, float PJBGGDBFEEP)
	{
		JJCMMDPOHDD jJCMMDPOHDD = new JJCMMDPOHDD();
		jJCMMDPOHDD.AEMBPMJMOAB = AEMBPMJMOAB;
		jJCMMDPOHDD.PJBGGDBFEEP = PJBGGDBFEEP;
		return jJCMMDPOHDD;
	}
}
