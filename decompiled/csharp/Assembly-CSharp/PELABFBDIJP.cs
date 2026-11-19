using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/ScrollRectTweener")]
[RequireComponent(typeof(ScrollRect))]
public class PELABFBDIJP : MonoBehaviour, IDragHandler, IEventSystemHandler
{
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

	private IEnumerator EBDMBBNAAEA(float PJBGGDBFEEP)
	{
		if (!(PJBGGDBFEEP < 0.05f))
		{
			Vector2 nKGAONCGHLA = IGKLJEJOEKE - MPGNEHBHEKE;
			float num = 0f;
			while (num < PJBGGDBFEEP)
			{
				num += Time.deltaTime;
				CODNNIKNIHB.normalizedPosition = LODLEFJLHLC(num, MPGNEHBHEKE, nKGAONCGHLA, PJBGGDBFEEP);
				yield return null;
			}
			CODNNIKNIHB.normalizedPosition = IGKLJEJOEKE;
			if (KFDFOECJOOP)
			{
				EPOHIEPGGIP();
			}
		}
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
