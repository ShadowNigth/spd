using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/Nicer Outline")]
public class NMFLKONAIDG : BaseMeshEffect
{
	[SerializeField]
	private Color m_EffectColor = new Color(0f, 0f, 0f, 0.5f);

	[SerializeField]
	private Vector2 m_EffectDistance = new Vector2(1f, -1f);

	[SerializeField]
	private bool m_UseGraphicAlpha = true;

	public Color BEPKIFMOCKG
	{
		get
		{
			return m_EffectColor;
		}
		set
		{
			m_EffectColor = value;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}
	}

	public Vector2 LMBBDHBLGMA
	{
		get
		{
			return m_EffectDistance;
		}
		set
		{
			if (value.x > 600f)
			{
				value.x = 600f;
			}
			if (value.x < -600f)
			{
				value.x = -600f;
			}
			if (value.y > 600f)
			{
				value.y = 600f;
			}
			if (value.y < -600f)
			{
				value.y = -600f;
			}
			if (!(m_EffectDistance == value))
			{
				m_EffectDistance = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}
	}

	public bool NBMLJIDKAIC
	{
		get
		{
			return m_UseGraphicAlpha;
		}
		set
		{
			m_UseGraphicAlpha = value;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}
	}

	protected void MAMEDKOJJLB(List<UIVertex> AOBHAPDKDDC, Color32 JPLPPELPDKF, int EHHGNIOBMDN, int HDMCLHKMFNO, float HKCJBFIKALL, float PIFPICMFHAD)
	{
		int num = AOBHAPDKDDC.Count * 2;
		if (AOBHAPDKDDC.Capacity < num)
		{
			AOBHAPDKDDC.Capacity = num;
		}
		for (int i = EHHGNIOBMDN; i < HDMCLHKMFNO; i++)
		{
			UIVertex uIVertex = AOBHAPDKDDC[i];
			AOBHAPDKDDC.Add(uIVertex);
			Vector3 position = uIVertex.position;
			position.x += HKCJBFIKALL;
			position.y += PIFPICMFHAD;
			uIVertex.position = position;
			Color32 color = JPLPPELPDKF;
			if (m_UseGraphicAlpha)
			{
				color.a = (byte)(color.a * AOBHAPDKDDC[i].color.a / 255);
			}
			uIVertex.color = color;
			AOBHAPDKDDC[i] = uIVertex;
		}
	}

	protected void FLFBPLDCFBG(List<UIVertex> AOBHAPDKDDC, Color32 JPLPPELPDKF, int EHHGNIOBMDN, int HDMCLHKMFNO, float HKCJBFIKALL, float PIFPICMFHAD)
	{
		int num = AOBHAPDKDDC.Count * 2;
		if (AOBHAPDKDDC.Capacity < num)
		{
			AOBHAPDKDDC.Capacity = num;
		}
		MAMEDKOJJLB(AOBHAPDKDDC, JPLPPELPDKF, EHHGNIOBMDN, HDMCLHKMFNO, HKCJBFIKALL, PIFPICMFHAD);
	}

	public override void ModifyMesh(VertexHelper MDEPPJOMAOE)
	{
		if (IsActive())
		{
			List<UIVertex> list = new List<UIVertex>();
			MDEPPJOMAOE.GetUIVertexStream(list);
			Text component = GetComponent<Text>();
			float num = 1f;
			if ((bool)component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = LMBBDHBLGMA.x * num;
			float num3 = LMBBDHBLGMA.y * num;
			int eHHGNIOBMDN = 0;
			int count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, num2, num3);
			eHHGNIOBMDN = count;
			count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, num2, 0f - num3);
			eHHGNIOBMDN = count;
			count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, 0f - num2, num3);
			eHHGNIOBMDN = count;
			count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, 0f - num2, 0f - num3);
			eHHGNIOBMDN = count;
			count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, num2, 0f);
			eHHGNIOBMDN = count;
			count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, 0f - num2, 0f);
			eHHGNIOBMDN = count;
			count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, 0f, num3);
			eHHGNIOBMDN = count;
			count = list.Count;
			FLFBPLDCFBG(list, BEPKIFMOCKG, eHHGNIOBMDN, list.Count, 0f, 0f - num3);
			MDEPPJOMAOE.Clear();
			MDEPPJOMAOE.AddUIVertexTriangleStream(list);
		}
	}
}
