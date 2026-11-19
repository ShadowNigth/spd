using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Primitives/Cut Corners")]
public class DFNNFBLDJEC : JEADEBLLCGO
{
	public Vector2 DBKHAJBOKKM = new Vector2(16f, 16f);

	[SerializeField]
	[Header("Corners to cut")]
	private bool m_cutUL = true;

	[SerializeField]
	private bool m_cutUR;

	[SerializeField]
	private bool m_cutLL;

	[SerializeField]
	private bool m_cutLR;

	[Tooltip("Up-Down colors become Left-Right colors")]
	[SerializeField]
	private bool m_makeColumns;

	[Header("Color the cut bars differently")]
	[SerializeField]
	private bool m_useColorUp;

	[SerializeField]
	private Color32 m_colorUp;

	[SerializeField]
	private bool m_useColorDown;

	[SerializeField]
	private Color32 m_colorDown;

	public bool KCFPLPGAGGA
	{
		get
		{
			return m_cutUL;
		}
		set
		{
			m_cutUL = value;
			SetAllDirty();
		}
	}

	public bool NAMGOMKHNLE
	{
		get
		{
			return m_cutUR;
		}
		set
		{
			m_cutUR = value;
			SetAllDirty();
		}
	}

	public bool LLEFJIJANDI
	{
		get
		{
			return m_cutLL;
		}
		set
		{
			m_cutLL = value;
			SetAllDirty();
		}
	}

	public bool FHNFOKMIDGB
	{
		get
		{
			return m_cutLR;
		}
		set
		{
			m_cutLR = value;
			SetAllDirty();
		}
	}

	public bool KPBKNFDALNI
	{
		get
		{
			return m_makeColumns;
		}
		set
		{
			m_makeColumns = value;
			SetAllDirty();
		}
	}

	public bool KLLDAOLBIDO
	{
		get
		{
			return m_useColorUp;
		}
		set
		{
			m_useColorUp = value;
		}
	}

	public Color32 JJNLCBEDJFK
	{
		get
		{
			return m_colorUp;
		}
		set
		{
			m_colorUp = value;
		}
	}

	public bool KANOPFPOBHE
	{
		get
		{
			return m_useColorDown;
		}
		set
		{
			m_useColorDown = value;
		}
	}

	public Color32 NFBNBAOMKML
	{
		get
		{
			return m_colorDown;
		}
		set
		{
			m_colorDown = value;
		}
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		Rect rect = base.rectTransform.rect;
		Rect rect2 = rect;
		Color32 color = this.color;
		bool flag = m_cutUL | m_cutUR;
		bool flag2 = m_cutLL | m_cutLR;
		bool flag3 = m_cutLL | m_cutUL;
		bool flag4 = m_cutLR | m_cutUR;
		if (!(flag || flag2) || !(DBKHAJBOKKM.sqrMagnitude > 0f))
		{
			return;
		}
		MDEPPJOMAOE.Clear();
		if (flag3)
		{
			rect2.xMin += DBKHAJBOKKM.x;
		}
		if (flag2)
		{
			rect2.yMin += DBKHAJBOKKM.y;
		}
		if (flag)
		{
			rect2.yMax -= DBKHAJBOKKM.y;
		}
		if (flag4)
		{
			rect2.xMax -= DBKHAJBOKKM.x;
		}
		Vector2 vector;
		Vector2 vector2;
		Vector2 vector3;
		Vector2 vector4;
		if (m_makeColumns)
		{
			vector = new Vector2(rect.xMin, (!m_cutUL) ? rect.yMax : rect2.yMax);
			vector2 = new Vector2(rect.xMax, (!m_cutUR) ? rect.yMax : rect2.yMax);
			vector3 = new Vector2(rect.xMin, (!m_cutLL) ? rect.yMin : rect2.yMin);
			vector4 = new Vector2(rect.xMax, (!m_cutLR) ? rect.yMin : rect2.yMin);
			if (flag3)
			{
				COKBGMHNOEJ(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!m_useColorUp) ? color : m_colorUp, MDEPPJOMAOE);
			}
			if (flag4)
			{
				COKBGMHNOEJ(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!m_useColorDown) ? color : m_colorDown, MDEPPJOMAOE);
			}
		}
		else
		{
			vector = new Vector2((!m_cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
			vector2 = new Vector2((!m_cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
			vector3 = new Vector2((!m_cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
			vector4 = new Vector2((!m_cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
			if (flag2)
			{
				COKBGMHNOEJ(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!m_useColorDown) ? color : m_colorDown, MDEPPJOMAOE);
			}
			if (flag)
			{
				COKBGMHNOEJ(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!m_useColorUp) ? color : m_colorUp, MDEPPJOMAOE);
			}
		}
		if (m_makeColumns)
		{
			COKBGMHNOEJ(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, MDEPPJOMAOE);
		}
		else
		{
			COKBGMHNOEJ(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, MDEPPJOMAOE);
		}
	}

	private static void COKBGMHNOEJ(Rect LLNPLBDOCGC, Rect PFGIHODANIB, Color32 IGPIMDAHPHE, VertexHelper MDEPPJOMAOE)
	{
		int num = PLOKDJGGFEM(LLNPLBDOCGC.xMin, LLNPLBDOCGC.yMin, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		int idx = PLOKDJGGFEM(LLNPLBDOCGC.xMin, LLNPLBDOCGC.yMax, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		int num2 = PLOKDJGGFEM(LLNPLBDOCGC.xMax, LLNPLBDOCGC.yMax, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		int idx2 = PLOKDJGGFEM(LLNPLBDOCGC.xMax, LLNPLBDOCGC.yMin, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		MDEPPJOMAOE.AddTriangle(num, idx, num2);
		MDEPPJOMAOE.AddTriangle(num2, idx2, num);
	}

	private static void COKBGMHNOEJ(Vector2 AEMBPMJMOAB, Vector2 LCBKHLLPIGM, Vector2 FCCPLGMNKOK, Vector2 CPFJBOMGNBF, Rect PFGIHODANIB, Color32 IGPIMDAHPHE, VertexHelper MDEPPJOMAOE)
	{
		int num = PLOKDJGGFEM(AEMBPMJMOAB.x, AEMBPMJMOAB.y, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		int idx = PLOKDJGGFEM(LCBKHLLPIGM.x, LCBKHLLPIGM.y, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		int num2 = PLOKDJGGFEM(FCCPLGMNKOK.x, FCCPLGMNKOK.y, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		int idx2 = PLOKDJGGFEM(CPFJBOMGNBF.x, CPFJBOMGNBF.y, PFGIHODANIB, IGPIMDAHPHE, MDEPPJOMAOE);
		MDEPPJOMAOE.AddTriangle(num, idx, num2);
		MDEPPJOMAOE.AddTriangle(num2, idx2, num);
	}

	private static int PLOKDJGGFEM(float HKCJBFIKALL, float PIFPICMFHAD, Rect FLOOGPFGPJM, Color32 IGPIMDAHPHE, VertexHelper MDEPPJOMAOE)
	{
		MDEPPJOMAOE.AddVert(uv0: new Vector2(Mathf.InverseLerp(FLOOGPFGPJM.xMin, FLOOGPFGPJM.xMax, HKCJBFIKALL), Mathf.InverseLerp(FLOOGPFGPJM.yMin, FLOOGPFGPJM.yMax, PIFPICMFHAD)), position: new Vector3(HKCJBFIKALL, PIFPICMFHAD), color: IGPIMDAHPHE);
		return MDEPPJOMAOE.currentVertCount - 1;
	}
}
