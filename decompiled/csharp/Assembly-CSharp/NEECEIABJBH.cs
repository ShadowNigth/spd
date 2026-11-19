using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/Gradient")]
public class NEECEIABJBH : BaseMeshEffect
{
	[SerializeField]
	private NCCICBAAOAI _gradientMode;

	[SerializeField]
	private FKPIALFLPJC _gradientDir;

	[SerializeField]
	private bool _overwriteAllColor;

	[SerializeField]
	private Color _vertex1 = Color.white;

	[SerializeField]
	private Color _vertex2 = Color.black;

	private Graphic BLGLENANNBG;

	public NCCICBAAOAI ADMFGMNHCIO
	{
		get
		{
			return _gradientMode;
		}
		set
		{
			_gradientMode = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public FKPIALFLPJC BOLGPDGNAAP
	{
		get
		{
			return _gradientDir;
		}
		set
		{
			_gradientDir = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public bool GPAAGNIEEDJ
	{
		get
		{
			return _overwriteAllColor;
		}
		set
		{
			_overwriteAllColor = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public Color OBGHNCFDIIJ
	{
		get
		{
			return _vertex1;
		}
		set
		{
			_vertex1 = value;
			base.graphic.SetAllDirty();
		}
	}

	public Color PPNAECIDFNN
	{
		get
		{
			return _vertex2;
		}
		set
		{
			_vertex2 = value;
			base.graphic.SetAllDirty();
		}
	}

	protected override void Awake()
	{
		BLGLENANNBG = GetComponent<Graphic>();
	}

	public override void ModifyMesh(VertexHelper MDEPPJOMAOE)
	{
		int currentVertCount = MDEPPJOMAOE.currentVertCount;
		if (!IsActive() || currentVertCount == 0)
		{
			return;
		}
		List<UIVertex> list = new List<UIVertex>();
		MDEPPJOMAOE.GetUIVertexStream(list);
		UIVertex vertex = default(UIVertex);
		if (_gradientMode == NCCICBAAOAI.BJFBKNMLIBD)
		{
			if (_gradientDir == FKPIALFLPJC.CBLGMECAALG || _gradientDir == FKPIALFLPJC.HJOEKPHKFNN)
			{
				_gradientDir = FKPIALFLPJC.IOKNFMCJIHM;
			}
			float num = ((_gradientDir != 0) ? list[list.Count - 1].position.x : list[list.Count - 1].position.y);
			float num2 = ((_gradientDir != 0) ? list[0].position.x : list[0].position.y);
			float num3 = num2 - num;
			for (int i = 0; i < currentVertCount; i++)
			{
				MDEPPJOMAOE.PopulateUIVertex(ref vertex, i);
				if (_overwriteAllColor || !(vertex.color != BLGLENANNBG.color))
				{
					vertex.color *= Color.Lerp(_vertex2, _vertex1, (((_gradientDir != 0) ? vertex.position.x : vertex.position.y) - num) / num3);
					MDEPPJOMAOE.SetUIVertex(vertex, i);
				}
			}
			return;
		}
		for (int j = 0; j < currentVertCount; j++)
		{
			MDEPPJOMAOE.PopulateUIVertex(ref vertex, j);
			if (_overwriteAllColor || CCIPNBPOMAE(vertex.color, BLGLENANNBG.color))
			{
				switch (_gradientDir)
				{
				case FKPIALFLPJC.IOKNFMCJIHM:
					vertex.color *= ((j % 4 != 0 && (j - 1) % 4 != 0) ? _vertex2 : _vertex1);
					break;
				case FKPIALFLPJC.CKGPDOGEHBB:
					vertex.color *= ((j % 4 != 0 && (j - 3) % 4 != 0) ? _vertex2 : _vertex1);
					break;
				case FKPIALFLPJC.CBLGMECAALG:
					vertex.color *= ((j % 4 == 0) ? _vertex1 : (((j - 2) % 4 != 0) ? Color.Lerp(_vertex2, _vertex1, 0.5f) : _vertex2));
					break;
				case FKPIALFLPJC.HJOEKPHKFNN:
					vertex.color *= (((j - 1) % 4 == 0) ? _vertex1 : (((j - 3) % 4 != 0) ? Color.Lerp(_vertex2, _vertex1, 0.5f) : _vertex2));
					break;
				}
				MDEPPJOMAOE.SetUIVertex(vertex, j);
			}
		}
	}

	private bool CCIPNBPOMAE(Color IOLDEDJCDDF, Color LGODGMPOEGK)
	{
		if (Mathf.Abs(IOLDEDJCDDF.r - LGODGMPOEGK.r) < 0.003f && Mathf.Abs(IOLDEDJCDDF.g - LGODGMPOEGK.g) < 0.003f && Mathf.Abs(IOLDEDJCDDF.b - LGODGMPOEGK.b) < 0.003f && Mathf.Abs(IOLDEDJCDDF.a - LGODGMPOEGK.a) < 0.003f)
		{
			return true;
		}
		return false;
	}
}
