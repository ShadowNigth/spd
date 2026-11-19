using System;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Primitives/UI Circle")]
public class KHLMNEFNOGE : JEADEBLLCGO
{
	[SerializeField]
	[Range(0f, 100f)]
	[Tooltip("The circular fill percentage of the primitive, affected by FixedToSegments")]
	private int m_fillPercent = 100;

	[Tooltip("Should the primitive fill draw by segments or absolute percentage")]
	public bool AEEKMNDECEA;

	[Tooltip("Draw the primitive filled or as a line")]
	[SerializeField]
	private bool m_fill = true;

	[SerializeField]
	[Tooltip("If not filled, the thickness of the primitive line")]
	private float m_thickness = 5f;

	[Tooltip("The number of segments to draw the primitive, more segments = smoother primitive")]
	[Range(0f, 360f)]
	[SerializeField]
	private int m_segments = 360;

	public int IOIGOJLAFMF
	{
		get
		{
			return m_fillPercent;
		}
		set
		{
			m_fillPercent = value;
			SetAllDirty();
		}
	}

	public bool BMHGJIENHHP
	{
		get
		{
			return m_fill;
		}
		set
		{
			m_fill = value;
			SetAllDirty();
		}
	}

	public float OFCOPPMILAJ
	{
		get
		{
			return m_thickness;
		}
		set
		{
			m_thickness = value;
			SetAllDirty();
		}
	}

	public int OOKGKOLJPGG
	{
		get
		{
			return m_segments;
		}
		set
		{
			m_segments = value;
			SetAllDirty();
		}
	}

	private void Update()
	{
		m_thickness = Mathf.Clamp(m_thickness, 0f, base.rectTransform.rect.width / 2f);
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		float lGPOJCDGPNA = (0f - base.rectTransform.pivot.x) * base.rectTransform.rect.width;
		float mLICKIDCOCK = (0f - base.rectTransform.pivot.x) * base.rectTransform.rect.width + m_thickness;
		MDEPPJOMAOE.Clear();
		Vector2 EMMOHKLICJG = Vector2.zero;
		Vector2 OEBEIPJICLC = Vector2.zero;
		Vector2 vector = new Vector2(0f, 0f);
		Vector2 vector2 = new Vector2(0f, 1f);
		Vector2 vector3 = new Vector2(1f, 1f);
		Vector2 vector4 = new Vector2(1f, 0f);
		Vector2 JJMEHCBPPNH;
		Vector2 CJMJPOJMOAD;
		Vector2 KJOBGFNIJGH;
		Vector2 CADNFEKJFPF;
		if (AEEKMNDECEA)
		{
			float num = (float)m_fillPercent / 100f;
			float num2 = 360f / (float)m_segments;
			int num3 = (int)((float)(m_segments + 1) * num);
			for (int i = 0; i < num3; i++)
			{
				float f = (float)Math.PI / 180f * ((float)i * num2);
				float fCCPLGMNKOK = Mathf.Cos(f);
				float lGNIFJCEECH = Mathf.Sin(f);
				vector = new Vector2(0f, 1f);
				vector2 = new Vector2(1f, 1f);
				vector3 = new Vector2(1f, 0f);
				vector4 = new Vector2(0f, 0f);
				AHDPKFHBJOG(lGPOJCDGPNA, mLICKIDCOCK, ref EMMOHKLICJG, ref OEBEIPJICLC, out JJMEHCBPPNH, out CJMJPOJMOAD, out KJOBGFNIJGH, out CADNFEKJFPF, fCCPLGMNKOK, lGNIFJCEECH);
				MDEPPJOMAOE.AddUIVertexQuad(COBPHKPBIAF(new Vector2[4] { JJMEHCBPPNH, CJMJPOJMOAD, KJOBGFNIJGH, CADNFEKJFPF }, new Vector2[4] { vector, vector2, vector3, vector4 }));
			}
			return;
		}
		float width = base.rectTransform.rect.width;
		float height = base.rectTransform.rect.height;
		float num4 = (float)m_fillPercent / 100f * ((float)Math.PI * 2f) / (float)m_segments;
		float num5 = 0f;
		for (int j = 0; j < m_segments + 1; j++)
		{
			float fCCPLGMNKOK2 = Mathf.Cos(num5);
			float lGNIFJCEECH2 = Mathf.Sin(num5);
			AHDPKFHBJOG(lGPOJCDGPNA, mLICKIDCOCK, ref EMMOHKLICJG, ref OEBEIPJICLC, out JJMEHCBPPNH, out CJMJPOJMOAD, out KJOBGFNIJGH, out CADNFEKJFPF, fCCPLGMNKOK2, lGNIFJCEECH2);
			vector = new Vector2(JJMEHCBPPNH.x / width + 0.5f, JJMEHCBPPNH.y / height + 0.5f);
			vector2 = new Vector2(CJMJPOJMOAD.x / width + 0.5f, CJMJPOJMOAD.y / height + 0.5f);
			vector3 = new Vector2(KJOBGFNIJGH.x / width + 0.5f, KJOBGFNIJGH.y / height + 0.5f);
			vector4 = new Vector2(CADNFEKJFPF.x / width + 0.5f, CADNFEKJFPF.y / height + 0.5f);
			MDEPPJOMAOE.AddUIVertexQuad(COBPHKPBIAF(new Vector2[4] { JJMEHCBPPNH, CJMJPOJMOAD, KJOBGFNIJGH, CADNFEKJFPF }, new Vector2[4] { vector, vector2, vector3, vector4 }));
			num5 += num4;
		}
	}

	private void AHDPKFHBJOG(float LGPOJCDGPNA, float MLICKIDCOCK, ref Vector2 EMMOHKLICJG, ref Vector2 OEBEIPJICLC, out Vector2 JJMEHCBPPNH, out Vector2 CJMJPOJMOAD, out Vector2 KJOBGFNIJGH, out Vector2 CADNFEKJFPF, float FCCPLGMNKOK, float LGNIFJCEECH)
	{
		JJMEHCBPPNH = EMMOHKLICJG;
		CJMJPOJMOAD = new Vector2(LGPOJCDGPNA * FCCPLGMNKOK, LGPOJCDGPNA * LGNIFJCEECH);
		if (m_fill)
		{
			KJOBGFNIJGH = Vector2.zero;
			CADNFEKJFPF = Vector2.zero;
		}
		else
		{
			KJOBGFNIJGH = new Vector2(MLICKIDCOCK * FCCPLGMNKOK, MLICKIDCOCK * LGNIFJCEECH);
			CADNFEKJFPF = OEBEIPJICLC;
		}
		EMMOHKLICJG = CJMJPOJMOAD;
		OEBEIPJICLC = KJOBGFNIJGH;
	}
}
