using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Primitives/UILineTextureRenderer")]
public class GBCDAHEDCML : JEADEBLLCGO
{
	[SerializeField]
	private Rect m_UVRect = new Rect(0f, 0f, 1f, 1f);

	[SerializeField]
	private Vector2[] m_points;

	public float LPMLBOMMJBL = 2f;

	public bool AJHMLFDIEGN;

	public Vector2 BDEGHFGHLKO;

	public bool HLLEMLDLHHK;

	public Rect NAPCDJLCMNL
	{
		get
		{
			return m_UVRect;
		}
		set
		{
			if (!(m_UVRect == value))
			{
				m_UVRect = value;
				SetVerticesDirty();
			}
		}
	}

	public Vector2[] EDEEPJMIFBD
	{
		get
		{
			return m_points;
		}
		set
		{
			if (m_points != value)
			{
				m_points = value;
				SetAllDirty();
			}
		}
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		if (m_points == null || m_points.Length < 2)
		{
			m_points = new Vector2[2]
			{
				new Vector2(0f, 0f),
				new Vector2(1f, 1f)
			};
		}
		int num = 24;
		float num2 = base.rectTransform.rect.width;
		float num3 = base.rectTransform.rect.height;
		float num4 = (0f - base.rectTransform.pivot.x) * base.rectTransform.rect.width;
		float num5 = (0f - base.rectTransform.pivot.y) * base.rectTransform.rect.height;
		if (!HLLEMLDLHHK)
		{
			num2 = 1f;
			num3 = 1f;
		}
		List<Vector2> list = new List<Vector2>();
		list.Add(m_points[0]);
		Vector2 item = m_points[0] + (m_points[1] - m_points[0]).normalized * num;
		list.Add(item);
		for (int i = 1; i < m_points.Length - 1; i++)
		{
			list.Add(m_points[i]);
		}
		item = m_points[m_points.Length - 1] - (m_points[m_points.Length - 1] - m_points[m_points.Length - 2]).normalized * num;
		list.Add(item);
		list.Add(m_points[m_points.Length - 1]);
		Vector2[] array = list.ToArray();
		if (AJHMLFDIEGN)
		{
			num2 -= BDEGHFGHLKO.x;
			num3 -= BDEGHFGHLKO.y;
			num4 += BDEGHFGHLKO.x / 2f;
			num5 += BDEGHFGHLKO.y / 2f;
		}
		MDEPPJOMAOE.Clear();
		Vector2 vector = Vector2.zero;
		Vector2 vector2 = Vector2.zero;
		for (int j = 1; j < array.Length; j++)
		{
			Vector2 vector3 = array[j - 1];
			Vector2 vector4 = array[j];
			vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
			vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
			float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 180f / (float)Math.PI;
			Vector2 vector5 = vector3 + new Vector2(0f, (0f - LPMLBOMMJBL) / 2f);
			Vector2 vector6 = vector3 + new Vector2(0f, LPMLBOMMJBL / 2f);
			Vector2 vector7 = vector4 + new Vector2(0f, LPMLBOMMJBL / 2f);
			Vector2 vector8 = vector4 + new Vector2(0f, (0f - LPMLBOMMJBL) / 2f);
			vector5 = PDCGBKIJPGH(vector5, vector3, new Vector3(0f, 0f, z));
			vector6 = PDCGBKIJPGH(vector6, vector3, new Vector3(0f, 0f, z));
			vector7 = PDCGBKIJPGH(vector7, vector4, new Vector3(0f, 0f, z));
			vector8 = PDCGBKIJPGH(vector8, vector4, new Vector3(0f, 0f, z));
			Vector2 zero = Vector2.zero;
			Vector2 vector9 = new Vector2(0f, 1f);
			Vector2 vector10 = new Vector2(0.5f, 0f);
			Vector2 vector11 = new Vector2(0.5f, 1f);
			Vector2 vector12 = new Vector2(1f, 0f);
			Vector2 vector13 = new Vector2(1f, 1f);
			Vector2[] lIAPFPOHECF = new Vector2[4] { vector10, vector11, vector11, vector10 };
			if (j > 1)
			{
				MDEPPJOMAOE.AddUIVertexQuad(COBPHKPBIAF(new Vector2[4] { vector, vector2, vector5, vector6 }, lIAPFPOHECF));
			}
			if (j == 1)
			{
				lIAPFPOHECF = new Vector2[4] { zero, vector9, vector11, vector10 };
			}
			else if (j == array.Length - 1)
			{
				lIAPFPOHECF = new Vector2[4] { vector10, vector11, vector13, vector12 };
			}
			MDEPPJOMAOE.AddUIVertexQuad(COBPHKPBIAF(new Vector2[4] { vector5, vector6, vector7, vector8 }, lIAPFPOHECF));
			vector = vector7;
			vector2 = vector8;
		}
	}

	public Vector3 PDCGBKIJPGH(Vector3 LEIHNANFKGD, Vector3 KDNDIGFHFJD, Vector3 BPLGMECFGKF)
	{
		Vector3 vector = LEIHNANFKGD - KDNDIGFHFJD;
		vector = Quaternion.Euler(BPLGMECFGKF) * vector;
		LEIHNANFKGD = vector + KDNDIGFHFJD;
		return LEIHNANFKGD;
	}
}
