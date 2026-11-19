using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[AddComponentMenu("UI/Extensions/Selectable Scalar")]
public class NODBJMCDEGE : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	private sealed class CLLFGLMBMCO : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float JOHAFHCGHJG;

		internal float GEMCFMCIGCH;

		internal NODBJMCDEGE KPHCHDHEKGH;

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
		public CLLFGLMBMCO()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (KPHCHDHEKGH.AEBBIMKOPOK.keys.Length > 0)
				{
					KPHCHDHEKGH.EPCKLAKNAAG.localScale = KPHCHDHEKGH.EKFLJPLHLNN;
					JOHAFHCGHJG = 0f;
					GEMCFMCIGCH = KPHCHDHEKGH.AEBBIMKOPOK.keys[KPHCHDHEKGH.AEBBIMKOPOK.length - 1].time;
					goto case 1u;
				}
				goto IL_0110;
			case 1u:
				if (JOHAFHCGHJG < GEMCFMCIGCH)
				{
					JOHAFHCGHJG += KPHCHDHEKGH.CKGJADEKNGE * Time.unscaledDeltaTime;
					KPHCHDHEKGH.EPCKLAKNAAG.localScale = Vector3.one * KPHCHDHEKGH.AEBBIMKOPOK.Evaluate(JOHAFHCGHJG);
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				goto IL_0110;
			default:
				{
					return false;
				}
				IL_0110:
				GNNOELAJGPI = -1;
				goto default;
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

	private sealed class LCNJPLFGIAA : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float JOHAFHCGHJG;

		internal float GEMCFMCIGCH;

		internal NODBJMCDEGE KPHCHDHEKGH;

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
		public LCNJPLFGIAA()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (KPHCHDHEKGH.AEBBIMKOPOK.keys.Length > 0)
				{
					JOHAFHCGHJG = 0f;
					GEMCFMCIGCH = KPHCHDHEKGH.AEBBIMKOPOK.keys[KPHCHDHEKGH.AEBBIMKOPOK.length - 1].time;
					goto case 1u;
				}
				goto IL_0117;
			case 1u:
				if (JOHAFHCGHJG < GEMCFMCIGCH)
				{
					JOHAFHCGHJG += KPHCHDHEKGH.CKGJADEKNGE * Time.unscaledDeltaTime;
					KPHCHDHEKGH.EPCKLAKNAAG.localScale = Vector3.one * KPHCHDHEKGH.AEBBIMKOPOK.Evaluate(GEMCFMCIGCH - JOHAFHCGHJG);
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				KPHCHDHEKGH.transform.localScale = KPHCHDHEKGH.EKFLJPLHLNN;
				goto IL_0117;
			default:
				{
					return false;
				}
				IL_0117:
				GNNOELAJGPI = -1;
				goto default;
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

	private Vector3 EKFLJPLHLNN;

	public Transform EPCKLAKNAAG;

	private Selectable DCJIIFODKFE;

	public Selectable JBLHHCNLIAJ
	{
		get
		{
			if (DCJIIFODKFE == null)
			{
				DCJIIFODKFE = GetComponent<Selectable>();
			}
			return DCJIIFODKFE;
		}
	}

	private void Awake()
	{
		if (EPCKLAKNAAG == null)
		{
			EPCKLAKNAAG = base.transform;
		}
		EKFLJPLHLNN = EPCKLAKNAAG.localScale;
	}

	private void OnEnable()
	{
		EPCKLAKNAAG.localScale = EKFLJPLHLNN;
	}

	public void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		if (!(JBLHHCNLIAJ != null) || JBLHHCNLIAJ.interactable)
		{
			StopCoroutine("OAHEKJONADE");
			StartCoroutine("CMJPAEFNJDD");
		}
	}

	public void OnPointerUp(PointerEventData GBOFEMOALII)
	{
		if (!(JBLHHCNLIAJ != null) || JBLHHCNLIAJ.interactable)
		{
			StopCoroutine("CMJPAEFNJDD");
			StartCoroutine("OAHEKJONADE");
		}
	}

	[DebuggerHidden]
	private IEnumerator CMJPAEFNJDD()
	{
		CLLFGLMBMCO cLLFGLMBMCO = new CLLFGLMBMCO();
		cLLFGLMBMCO.KPHCHDHEKGH = this;
		return cLLFGLMBMCO;
	}

	[DebuggerHidden]
	private IEnumerator OAHEKJONADE()
	{
		LCNJPLFGIAA lCNJPLFGIAA = new LCNJPLFGIAA();
		lCNJPLFGIAA.KPHCHDHEKGH = this;
		return lCNJPLFGIAA;
	}
}
