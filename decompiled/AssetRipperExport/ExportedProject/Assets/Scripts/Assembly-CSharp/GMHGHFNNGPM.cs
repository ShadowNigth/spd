using System;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Primitives/UI Polygon")]
public class GMHGHFNNGPM : JEADEBLLCGO
{
	public bool DLFDBAIDGFB = true;

	public float FEHBICLJJHO = 5f;

	[Range(3f, 360f)]
	public int LJHOJBMPJIB = 3;

	[Range(0f, 360f)]
	public float JPINOKOACLM;

	[Range(0f, 1f)]
	public float[] ODDDCDBEMJG = new float[3];

	private float FKEENBIEOBN;

	public void CBBPDNANGIC(int AJEMPDONINF)
	{
		LJHOJBMPJIB = AJEMPDONINF;
		ODDDCDBEMJG = new float[AJEMPDONINF + 1];
		for (int i = 0; i < AJEMPDONINF; i++)
		{
			ODDDCDBEMJG[i] = 1f;
		}
		JPINOKOACLM = 0f;
		SetAllDirty();
	}

	public void CBBPDNANGIC(int AJEMPDONINF, float[] IAMACFCCNDH)
	{
		LJHOJBMPJIB = AJEMPDONINF;
		ODDDCDBEMJG = IAMACFCCNDH;
		JPINOKOACLM = 0f;
		SetAllDirty();
	}

	public void CBBPDNANGIC(int AJEMPDONINF, float[] IAMACFCCNDH, float MMLFPKFCBFG)
	{
		LJHOJBMPJIB = AJEMPDONINF;
		ODDDCDBEMJG = IAMACFCCNDH;
		JPINOKOACLM = MMLFPKFCBFG;
		SetAllDirty();
	}

	private void Update()
	{
		FKEENBIEOBN = base.rectTransform.rect.width;
		if (base.rectTransform.rect.width > base.rectTransform.rect.height)
		{
			FKEENBIEOBN = base.rectTransform.rect.height;
		}
		else
		{
			FKEENBIEOBN = base.rectTransform.rect.width;
		}
		FEHBICLJJHO = Mathf.Clamp(FEHBICLJJHO, 0f, FKEENBIEOBN / 2f);
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		MDEPPJOMAOE.Clear();
		Vector2 vector = Vector2.zero;
		Vector2 vector2 = Vector2.zero;
		Vector2 vector3 = new Vector2(0f, 0f);
		Vector2 vector4 = new Vector2(0f, 1f);
		Vector2 vector5 = new Vector2(1f, 1f);
		Vector2 vector6 = new Vector2(1f, 0f);
		float num = 360f / (float)LJHOJBMPJIB;
		int num2 = LJHOJBMPJIB + 1;
		if (ODDDCDBEMJG.Length != num2)
		{
			ODDDCDBEMJG = new float[num2];
			for (int i = 0; i < num2 - 1; i++)
			{
				ODDDCDBEMJG[i] = 1f;
			}
		}
		ODDDCDBEMJG[num2 - 1] = ODDDCDBEMJG[0];
		for (int j = 0; j < num2; j++)
		{
			float num3 = (0f - base.rectTransform.pivot.x) * FKEENBIEOBN * ODDDCDBEMJG[j];
			float num4 = (0f - base.rectTransform.pivot.x) * FKEENBIEOBN * ODDDCDBEMJG[j] + FEHBICLJJHO;
			float f = (float)Math.PI / 180f * ((float)j * num + JPINOKOACLM);
			float num5 = Mathf.Cos(f);
			float num6 = Mathf.Sin(f);
			vector3 = new Vector2(0f, 1f);
			vector4 = new Vector2(1f, 1f);
			vector5 = new Vector2(1f, 0f);
			vector6 = new Vector2(0f, 0f);
			Vector2 vector7 = vector;
			Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
			Vector2 vector9;
			Vector2 vector10;
			if (DLFDBAIDGFB)
			{
				vector9 = Vector2.zero;
				vector10 = Vector2.zero;
			}
			else
			{
				vector9 = new Vector2(num4 * num5, num4 * num6);
				vector10 = vector2;
			}
			vector = vector8;
			vector2 = vector9;
			MDEPPJOMAOE.AddUIVertexQuad(COBPHKPBIAF(new Vector2[4] { vector7, vector8, vector9, vector10 }, new Vector2[4] { vector3, vector4, vector5, vector6 }));
		}
	}
}
