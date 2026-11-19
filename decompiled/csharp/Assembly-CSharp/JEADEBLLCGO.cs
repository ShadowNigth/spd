using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JEADEBLLCGO : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter
{
	protected static Material JOBGFPFMPBL;

	[SerializeField]
	private Sprite m_Sprite;

	[NonSerialized]
	private Sprite JFNDBHECHAM;

	internal float MAJPOAFOLJA = 1f;

	[SerializeField]
	private GKOFMHEFHDN m_improveResolution;

	[SerializeField]
	protected float m_Resolution;

	[SerializeField]
	private bool m_useNativeSize;

	public Sprite DJPCGOFJIJE
	{
		get
		{
			return m_Sprite;
		}
		set
		{
			if (CBONCPDADKB.KDINNNBJOID(ref m_Sprite, value))
			{
				MJKMNMCBIJG();
			}
			SetAllDirty();
		}
	}

	public Sprite JDFEJICNJJB
	{
		get
		{
			return GGCJMOJEIGI;
		}
		set
		{
			if (CBONCPDADKB.KDINNNBJOID(ref JFNDBHECHAM, value))
			{
				MJKMNMCBIJG();
			}
			SetAllDirty();
		}
	}

	protected Sprite GGCJMOJEIGI => (!(JFNDBHECHAM != null)) ? DJPCGOFJIJE : JFNDBHECHAM;

	public float EBDMFMIHJEJ
	{
		get
		{
			return MAJPOAFOLJA;
		}
		set
		{
			MAJPOAFOLJA = value;
		}
	}

	public GKOFMHEFHDN GOLBFNKNDMN
	{
		get
		{
			return m_improveResolution;
		}
		set
		{
			m_improveResolution = value;
			SetAllDirty();
		}
	}

	public float AEFDGHFEKLJ
	{
		get
		{
			return m_Resolution;
		}
		set
		{
			m_Resolution = value;
			SetAllDirty();
		}
	}

	public bool GKJPIBDFADG
	{
		get
		{
			return m_useNativeSize;
		}
		set
		{
			m_useNativeSize = value;
			SetAllDirty();
		}
	}

	public static Material BKBALDOFILP
	{
		get
		{
			if (JOBGFPFMPBL == null)
			{
				JOBGFPFMPBL = Canvas.GetETC1SupportedCanvasMaterial();
			}
			return JOBGFPFMPBL;
		}
	}

	public override Texture NOIJLEAHPOI
	{
		get
		{
			if (GGCJMOJEIGI == null)
			{
				if (material != null && material.mainTexture != null)
				{
					return material.mainTexture;
				}
				return Graphic.s_WhiteTexture;
			}
			return GGCJMOJEIGI.texture;
		}
	}

	public bool BLFDPDGNCAG
	{
		get
		{
			if (GGCJMOJEIGI != null)
			{
				return GGCJMOJEIGI.border.sqrMagnitude > 0f;
			}
			return false;
		}
	}

	public float HBABEIIIBLC
	{
		get
		{
			float num = 100f;
			if ((bool)GGCJMOJEIGI)
			{
				num = GGCJMOJEIGI.pixelsPerUnit;
			}
			float num2 = 100f;
			if ((bool)base.canvas)
			{
				num2 = base.canvas.referencePixelsPerUnit;
			}
			return num / num2;
		}
	}

	public override Material EPGGGAFGIEK
	{
		get
		{
			if (m_Material != null)
			{
				return m_Material;
			}
			if ((bool)GGCJMOJEIGI && GGCJMOJEIGI.associatedAlphaSplitTexture != null)
			{
				return BKBALDOFILP;
			}
			return defaultMaterial;
		}
		set
		{
			base.material = value;
		}
	}

	public virtual float KIEDMFFAJJB => 0f;

	public virtual float IIKNCIGNMOM
	{
		get
		{
			if (JDFEJICNJJB == null)
			{
				return 0f;
			}
			return JDFEJICNJJB.rect.size.x / HBABEIIIBLC;
		}
	}

	public virtual float OHICLECIIKA => -1f;

	public virtual float PDBOJFIIOOA => 0f;

	public virtual float DEMCKKPIKFP
	{
		get
		{
			if (JDFEJICNJJB == null)
			{
				return 0f;
			}
			return JDFEJICNJJB.rect.size.y / HBABEIIIBLC;
		}
	}

	public virtual float JIDIBMNMEPA => -1f;

	public virtual int PHFGDJLKFKG => 0;

	protected JEADEBLLCGO()
	{
		base.useLegacyMeshGeneration = false;
	}

	protected UIVertex[] COBPHKPBIAF(Vector2[] KOGKFEMKGBB, Vector2[] LIAPFPOHECF)
	{
		UIVertex[] array = new UIVertex[4];
		for (int i = 0; i < KOGKFEMKGBB.Length; i++)
		{
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = color;
			simpleVert.position = KOGKFEMKGBB[i];
			simpleVert.uv0 = LIAPFPOHECF[i];
			array[i] = simpleVert;
		}
		return array;
	}

	protected Vector2[] HOLIHOCHFHN(Vector2[] MMKMICOONDG)
	{
		List<Vector2> list = new List<Vector2>();
		switch (GOLBFNKNDMN)
		{
		case GKOFMHEFHDN.DMPMOIBJGJP:
		{
			float num3 = 0f;
			float num = 0f;
			for (int j = 0; j < MMKMICOONDG.Length - 1; j++)
			{
				num3 += Vector2.Distance(MMKMICOONDG[j], MMKMICOONDG[j + 1]);
			}
			ILMCHGCPMNE(num3);
			num = num3 / m_Resolution;
			int num4 = 0;
			for (int k = 0; k < MMKMICOONDG.Length - 1; k++)
			{
				Vector2 vector3 = MMKMICOONDG[k];
				list.Add(vector3);
				Vector2 vector4 = MMKMICOONDG[k + 1];
				float num5 = Vector2.Distance(vector3, vector4) / num;
				float num6 = 1f / num5;
				for (int l = 0; (float)l < num5; l++)
				{
					list.Add(Vector2.Lerp(vector3, vector4, (float)l * num6));
					num4++;
				}
				list.Add(vector4);
			}
			break;
		}
		case GKOFMHEFHDN.KABMPLDONIL:
		{
			for (int i = 0; i < MMKMICOONDG.Length - 1; i++)
			{
				Vector2 vector = MMKMICOONDG[i];
				list.Add(vector);
				Vector2 vector2 = MMKMICOONDG[i + 1];
				ILMCHGCPMNE(Vector2.Distance(vector, vector2));
				float num = 1f / m_Resolution;
				for (float num2 = 1f; num2 < m_Resolution; num2 += 1f)
				{
					list.Add(Vector2.Lerp(vector, vector2, num * num2));
				}
				list.Add(vector2);
			}
			break;
		}
		}
		return list.ToArray();
	}

	protected virtual void MJKMNMCBIJG()
	{
	}

	protected virtual void ILMCHGCPMNE(float IBKGHLIGCBN)
	{
	}

	public virtual void CalculateLayoutInputHorizontal()
	{
	}

	public virtual void CalculateLayoutInputVertical()
	{
	}

	public virtual bool IsRaycastLocationValid(Vector2 BFPNHJOEFOE, Camera FECAPMFFGFI)
	{
		if (MAJPOAFOLJA >= 1f)
		{
			return true;
		}
		Sprite sprite = JDFEJICNJJB;
		if (sprite == null)
		{
			return true;
		}
		RectTransformUtility.ScreenPointToLocalPointInRectangle(base.rectTransform, BFPNHJOEFOE, FECAPMFFGFI, out var localPoint);
		Rect pixelAdjustedRect = GetPixelAdjustedRect();
		localPoint.x += base.rectTransform.pivot.x * pixelAdjustedRect.width;
		localPoint.y += base.rectTransform.pivot.y * pixelAdjustedRect.height;
		localPoint = JGPBPECDDMG(localPoint, pixelAdjustedRect);
		Rect textureRect = sprite.textureRect;
		Vector2 vector = new Vector2(localPoint.x / textureRect.width, localPoint.y / textureRect.height);
		float u = Mathf.Lerp(textureRect.x, textureRect.xMax, vector.x) / (float)sprite.texture.width;
		float v = Mathf.Lerp(textureRect.y, textureRect.yMax, vector.y) / (float)sprite.texture.height;
		try
		{
			return sprite.texture.GetPixelBilinear(u, v).a >= MAJPOAFOLJA;
		}
		catch (UnityException ex)
		{
			Debug.LogError("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + ex.Message + " Also make sure to disable sprite packing for this sprite.", this);
			return true;
		}
	}

	private Vector2 JGPBPECDDMG(Vector2 KOMIKFHDCMM, Rect LLNPLBDOCGC)
	{
		Rect rect = DJPCGOFJIJE.rect;
		return new Vector2(KOMIKFHDCMM.x * LLNPLBDOCGC.width, KOMIKFHDCMM.y * LLNPLBDOCGC.height);
	}

	private Vector4 NHDLPCCHGJD(Vector4 FPONEKCGONC, Rect LLNPLBDOCGC)
	{
		for (int i = 0; i <= 1; i++)
		{
			float num = FPONEKCGONC[i] + FPONEKCGONC[i + 2];
			if (LLNPLBDOCGC.size[i] < num && num != 0f)
			{
				float num2 = LLNPLBDOCGC.size[i] / num;
				FPONEKCGONC[i] *= num2;
				FPONEKCGONC[i + 2] *= num2;
			}
		}
		return FPONEKCGONC;
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		SetAllDirty();
	}
}
