using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/ScrollRectTweener")]
[RequireComponent(typeof(ScrollRect))]
public class PELABFBDIJP : MonoBehaviour, IDragHandler, IEventSystemHandler
{
	private sealed class OLLEJNAIFKJ : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal float PJBGGDBFEEP;

		internal Vector2 BOHCMFMIOBL;

		internal float GIEDFDKIMIA;

		internal PELABFBDIJP KPHCHDHEKGH;

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
		public OLLEJNAIFKJ()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (PJBGGDBFEEP < 0.05f)
				{
					goto default;
				}
				BOHCMFMIOBL = KPHCHDHEKGH.IGKLJEJOEKE - KPHCHDHEKGH.MPGNEHBHEKE;
				GIEDFDKIMIA = 0f;
				goto case 1u;
			case 1u:
				if (GIEDFDKIMIA < PJBGGDBFEEP)
				{
					GIEDFDKIMIA += Time.deltaTime;
					KPHCHDHEKGH.CODNNIKNIHB.normalizedPosition = KPHCHDHEKGH.LODLEFJLHLC(GIEDFDKIMIA, KPHCHDHEKGH.MPGNEHBHEKE, BOHCMFMIOBL, PJBGGDBFEEP);
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				KPHCHDHEKGH.CODNNIKNIHB.normalizedPosition = KPHCHDHEKGH.IGKLJEJOEKE;
				if (KPHCHDHEKGH.KFDFOECJOOP)
				{
					KPHCHDHEKGH.EPOHIEPGGIP();
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

	private ScrollRect CODNNIKNIHB;

	private Vector2 MPGNEHBHEKE;

	private Vector2 IGKLJEJOEKE;

	private bool BDGBLHAOKDE;

	private bool JCAJJIFIOGE;

	public float EDADKGABCKN = 5000f;

	public bool KFDFOECJOOP;

	private void Awake()
	{
		CODNNIKNIHB = GetComponent<ScrollRect>();
		BDGBLHAOKDE = CODNNIKNIHB.horizontal;
		JCAJJIFIOGE = CODNNIKNIHB.vertical;
	}

	public void LJCNDJLAMFD(float JPBPLGBLIDO)
	{
		JJCCBMNJNEF(new Vector2(JPBPLGBLIDO, CODNNIKNIHB.verticalNormalizedPosition));
	}

	public void LJCNDJLAMFD(float JPBPLGBLIDO, float PJBGGDBFEEP)
	{
		JJCCBMNJNEF(new Vector2(JPBPLGBLIDO, CODNNIKNIHB.verticalNormalizedPosition), PJBGGDBFEEP);
	}

	public void LJACIPGOODL(float OBKKEODANFA)
	{
		JJCCBMNJNEF(new Vector2(CODNNIKNIHB.horizontalNormalizedPosition, OBKKEODANFA));
	}

	public void LJACIPGOODL(float OBKKEODANFA, float PJBGGDBFEEP)
	{
		JJCCBMNJNEF(new Vector2(CODNNIKNIHB.horizontalNormalizedPosition, OBKKEODANFA), PJBGGDBFEEP);
	}

	public void JJCCBMNJNEF(Vector2 GAGGFBEJNND)
	{
		JJCCBMNJNEF(GAGGFBEJNND, KFEJHHCPOCN(GAGGFBEJNND));
	}

	private float KFEJHHCPOCN(Vector2 GAGGFBEJNND)
	{
		Vector2 gAGGFBEJNND = DBPFCCNBHIO();
		return Vector2.Distance(PIGJDAMIDDP(gAGGFBEJNND), PIGJDAMIDDP(GAGGFBEJNND)) / EDADKGABCKN;
	}

	private Vector2 PIGJDAMIDDP(Vector2 GAGGFBEJNND)
	{
		return new Vector2(GAGGFBEJNND.x * CODNNIKNIHB.content.rect.width, GAGGFBEJNND.y * CODNNIKNIHB.content.rect.height);
	}

	private Vector2 DBPFCCNBHIO()
	{
		return new Vector2(CODNNIKNIHB.horizontalNormalizedPosition, CODNNIKNIHB.verticalNormalizedPosition);
	}

	public void JJCCBMNJNEF(Vector2 GAGGFBEJNND, float PJBGGDBFEEP)
	{
		MPGNEHBHEKE = DBPFCCNBHIO();
		IGKLJEJOEKE = GAGGFBEJNND;
		if (KFDFOECJOOP)
		{
			OCINHOKBFPG();
		}
		StopAllCoroutines();
		StartCoroutine(EBDMBBNAAEA(PJBGGDBFEEP));
	}

	[DebuggerHidden]
	private IEnumerator EBDMBBNAAEA(float PJBGGDBFEEP)
	{
		OLLEJNAIFKJ oLLEJNAIFKJ = new OLLEJNAIFKJ();
		oLLEJNAIFKJ.PJBGGDBFEEP = PJBGGDBFEEP;
		oLLEJNAIFKJ.KPHCHDHEKGH = this;
		return oLLEJNAIFKJ;
	}

	public Vector2 LODLEFJLHLC(float FAIKNCKNKKL, Vector2 AOMJDPPKAPL, Vector2 NKGAONCGHLA, float PJBGGDBFEEP)
	{
		return new Vector2(NKGAONCGHLA.x * Mathf.Sin(FAIKNCKNKKL / PJBGGDBFEEP * ((float)Math.PI / 2f)) + AOMJDPPKAPL.x, NKGAONCGHLA.y * Mathf.Sin(FAIKNCKNKKL / PJBGGDBFEEP * ((float)Math.PI / 2f)) + AOMJDPPKAPL.y);
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (!KFDFOECJOOP)
		{
			DLABFINNHPD();
		}
	}

	private void DLABFINNHPD()
	{
		StopAllCoroutines();
		if (KFDFOECJOOP)
		{
			EPOHIEPGGIP();
		}
	}

	private void OCINHOKBFPG()
	{
		CODNNIKNIHB.horizontal = false;
		CODNNIKNIHB.vertical = false;
	}

	private void EPOHIEPGGIP()
	{
		CODNNIKNIHB.horizontal = BDGBLHAOKDE;
		CODNNIKNIHB.vertical = JCAJJIFIOGE;
	}
}
