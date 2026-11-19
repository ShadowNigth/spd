using System;
using UnityEngine;

public class OEMDPHCFKKJ
{
	[SerializeField]
	private float xAxis;

	[SerializeField]
	private float yAxis;

	[SerializeField]
	private int steps;

	public float ILCAPNDJNIL
	{
		get
		{
			return xAxis;
		}
		set
		{
			xAxis = value;
		}
	}

	public float LEFMEKFNCIO
	{
		get
		{
			return yAxis;
		}
		set
		{
			yAxis = value;
		}
	}

	public int GFJHOLCEFHI
	{
		get
		{
			return steps;
		}
		set
		{
			steps = value;
		}
	}

	public OEMDPHCFKKJ(float DOGLMPODLGL)
	{
		xAxis = DOGLMPODLGL;
		yAxis = DOGLMPODLGL;
		steps = 1;
	}

	public OEMDPHCFKKJ(float DOGLMPODLGL, int HKBPANDAEFC)
	{
		xAxis = DOGLMPODLGL;
		yAxis = DOGLMPODLGL;
		steps = HKBPANDAEFC;
	}

	public OEMDPHCFKKJ(float HHNFAHAHAKD, float BICBMIDJNEL)
	{
		xAxis = HHNFAHAHAKD;
		yAxis = BICBMIDJNEL;
		steps = 10;
	}

	public OEMDPHCFKKJ(float HHNFAHAHAKD, float BICBMIDJNEL, int HKBPANDAEFC)
	{
		xAxis = HHNFAHAHAKD;
		yAxis = BICBMIDJNEL;
		steps = HKBPANDAEFC;
	}

	public Vector2 EHFBCALDAAL(float GDKFLGBMPBB)
	{
		float num = 360f / (float)steps;
		float f = (float)Math.PI / 180f * num * GDKFLGBMPBB;
		float x = Mathf.Sin(f) * xAxis;
		float y = Mathf.Cos(f) * yAxis;
		return new Vector2(x, y);
	}

	public void EHFBCALDAAL(float GDKFLGBMPBB, out Vector2 EKEBBCBJAFP)
	{
		float num = 360f / (float)steps;
		float f = (float)Math.PI / 180f * num * GDKFLGBMPBB;
		EKEBBCBJAFP.x = Mathf.Sin(f) * xAxis;
		EKEBBCBJAFP.y = Mathf.Cos(f) * yAxis;
	}
}
