using System.Collections.Generic;
using UnityEngine;

public class IIHKGGNCEPD<TData, TContext> : MonoBehaviour where TContext : class
{
	[SerializeField]
	[Range(float.Epsilon, 1f)]
	private float cellInterval;

	[SerializeField]
	[Range(0f, 1f)]
	private float cellOffset;

	[SerializeField]
	private bool loop;

	[SerializeField]
	private GameObject cellBase;

	private float GJEBMIFOOBJ;

	private readonly List<global::JOJJJIAJEAE<TData, TContext>> CLBEJHBNJGE = new List<global::JOJJJIAJEAE<TData, TContext>>();

	protected TContext KPFOIKPELPI;

	protected List<TData> CGKCFEJNPMH = new List<TData>();

	protected void Awake()
	{
		cellBase.SetActive(false);
	}

	protected void AJJGGENLDKG(TContext KPFOIKPELPI)
	{
		this.KPFOIKPELPI = KPFOIKPELPI;
		for (int i = 0; i < CLBEJHBNJGE.Count; i++)
		{
			CLBEJHBNJGE[i].AJJGGENLDKG(KPFOIKPELPI);
		}
	}

	private global::JOJJJIAJEAE<TData, TContext> NKMDCDOOLBP()
	{
		GameObject gameObject = Object.Instantiate(cellBase);
		gameObject.SetActive(true);
		global::JOJJJIAJEAE<TData, TContext> component = gameObject.GetComponent<global::JOJJJIAJEAE<TData, TContext>>();
		RectTransform rectTransform = component.transform as RectTransform;
		Vector3 localScale = component.transform.localScale;
		Vector2 sizeDelta = Vector2.zero;
		Vector2 offsetMin = Vector2.zero;
		Vector2 offsetMax = Vector2.zero;
		if ((bool)rectTransform)
		{
			sizeDelta = rectTransform.sizeDelta;
			offsetMin = rectTransform.offsetMin;
			offsetMax = rectTransform.offsetMax;
		}
		component.transform.SetParent(cellBase.transform.parent);
		component.transform.localScale = localScale;
		if ((bool)rectTransform)
		{
			rectTransform.sizeDelta = sizeDelta;
			rectTransform.offsetMin = offsetMin;
			rectTransform.offsetMax = offsetMax;
		}
		component.AJJGGENLDKG(KPFOIKPELPI);
		component.BJICICKEIND(false);
		return component;
	}

	private void GLCCPPMEDAD(global::JOJJJIAJEAE<TData, TContext> HMMGOIOGJKE, int IJFPFDGCMEB)
	{
		if (loop)
		{
			IJFPFDGCMEB = EODGONNCHHD(IJFPFDGCMEB, CGKCFEJNPMH.Count);
		}
		else if (IJFPFDGCMEB < 0 || IJFPFDGCMEB > CGKCFEJNPMH.Count - 1)
		{
			HMMGOIOGJKE.BJICICKEIND(false);
			return;
		}
		HMMGOIOGJKE.BJICICKEIND(true);
		HMMGOIOGJKE.PGLLGABGMCO = IJFPFDGCMEB;
		HMMGOIOGJKE.NILHMMADIDH(CGKCFEJNPMH[IJFPFDGCMEB]);
	}

	private int EODGONNCHHD(int JNDABHCJHHD, int JMBJALGFMPA)
	{
		if (JNDABHCJHHD < 0)
		{
			JNDABHCJHHD = JMBJALGFMPA - 1 + (JNDABHCJHHD + 1) % JMBJALGFMPA;
		}
		else if (JNDABHCJHHD > JMBJALGFMPA - 1)
		{
			JNDABHCJHHD %= JMBJALGFMPA;
		}
		return JNDABHCJHHD;
	}

	protected void OLFOGLIEFBF()
	{
		DBFCKHHDNAN(GJEBMIFOOBJ);
	}

	protected void DBFCKHHDNAN(float GIDEOJGAFJH)
	{
		GJEBMIFOOBJ = GIDEOJGAFJH;
		float num = GIDEOJGAFJH - cellOffset / cellInterval;
		float num2 = (Mathf.Ceil(num) - num) * cellInterval;
		int num3 = Mathf.CeilToInt(num);
		int num4 = 0;
		int num5 = 0;
		float num6 = num2;
		while (num6 <= 1f)
		{
			if (num4 >= CLBEJHBNJGE.Count)
			{
				CLBEJHBNJGE.Add(NKMDCDOOLBP());
			}
			num6 += cellInterval;
			num4++;
		}
		num4 = 0;
		for (float num7 = num2; num7 <= 1f; num7 += cellInterval)
		{
			int num8 = num3 + num4;
			num5 = EODGONNCHHD(num8, CLBEJHBNJGE.Count);
			if (CLBEJHBNJGE[num5].gameObject.activeSelf)
			{
				CLBEJHBNJGE[num5].DBFCKHHDNAN(num7);
			}
			GLCCPPMEDAD(CLBEJHBNJGE[num5], num8);
			num4++;
		}
		num5 = EODGONNCHHD(num3 + num4, CLBEJHBNJGE.Count);
		while (num4 < CLBEJHBNJGE.Count)
		{
			CLBEJHBNJGE[num5].BJICICKEIND(false);
			num4++;
			num5 = EODGONNCHHD(num3 + num4, CLBEJHBNJGE.Count);
		}
	}
}
