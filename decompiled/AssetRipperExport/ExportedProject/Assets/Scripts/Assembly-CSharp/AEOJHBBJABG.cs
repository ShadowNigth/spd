using System;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Primitives/Diamond Graph")]
public class AEOJHBBJABG : JEADEBLLCGO
{
	[SerializeField]
	private float m_a = 1f;

	[SerializeField]
	private float m_b = 1f;

	[SerializeField]
	private float m_c = 1f;

	[SerializeField]
	private float m_d = 1f;

	public float PLLNCPNCAHN
	{
		get
		{
			return m_a;
		}
		set
		{
			m_a = value;
		}
	}

	public float EDGDMFJAFEM
	{
		get
		{
			return m_b;
		}
		set
		{
			m_b = value;
		}
	}

	public float CDKCBJBMPOL
	{
		get
		{
			return m_c;
		}
		set
		{
			m_c = value;
		}
	}

	public float ACFJDANAFMK
	{
		get
		{
			return m_d;
		}
		set
		{
			m_d = value;
		}
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		MDEPPJOMAOE.Clear();
		float num = base.rectTransform.rect.width / 2f;
		m_a = Math.Min(1f, Math.Max(0f, m_a));
		m_b = Math.Min(1f, Math.Max(0f, m_b));
		m_c = Math.Min(1f, Math.Max(0f, m_c));
		m_d = Math.Min(1f, Math.Max(0f, m_d));
		Color32 color = this.color;
		MDEPPJOMAOE.AddVert(new Vector3((0f - num) * m_a, 0f), color, new Vector2(0f, 0f));
		MDEPPJOMAOE.AddVert(new Vector3(0f, num * m_b), color, new Vector2(0f, 1f));
		MDEPPJOMAOE.AddVert(new Vector3(num * m_c, 0f), color, new Vector2(1f, 1f));
		MDEPPJOMAOE.AddVert(new Vector3(0f, (0f - num) * m_d), color, new Vector2(1f, 0f));
		MDEPPJOMAOE.AddTriangle(0, 1, 2);
		MDEPPJOMAOE.AddTriangle(2, 3, 0);
	}
}
