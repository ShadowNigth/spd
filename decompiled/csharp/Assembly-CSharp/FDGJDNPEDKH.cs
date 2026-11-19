using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("Layout/Extensions/Tile Size Fitter")]
[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
public class FDGJDNPEDKH : UIBehaviour, ILayoutSelfController, ILayoutController
{
	[SerializeField]
	private Vector2 m_Border = Vector2.zero;

	[SerializeField]
	private Vector2 m_TileSize = Vector2.zero;

	[NonSerialized]
	private RectTransform IFFIOAEJGKF;

	private DrivenRectTransformTracker MLPLFIPMOJH;

	public Vector2 IHPLOMNOBCP
	{
		get
		{
			return m_Border;
		}
		set
		{
			if (CBONCPDADKB.NOINEEJPMBG(ref m_Border, value))
			{
				HAPPCOBHMHM();
			}
		}
	}

	public Vector2 BKKHIOMJDMN
	{
		get
		{
			return m_TileSize;
		}
		set
		{
			if (CBONCPDADKB.NOINEEJPMBG(ref m_TileSize, value))
			{
				HAPPCOBHMHM();
			}
		}
	}

	private RectTransform GEINAHMAFAM
	{
		get
		{
			if (IFFIOAEJGKF == null)
			{
				IFFIOAEJGKF = GetComponent<RectTransform>();
			}
			return IFFIOAEJGKF;
		}
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		HAPPCOBHMHM();
	}

	protected override void OnDisable()
	{
		MLPLFIPMOJH.Clear();
		LayoutRebuilder.MarkLayoutForRebuild(GEINAHMAFAM);
		base.OnDisable();
	}

	protected override void OnRectTransformDimensionsChange()
	{
		CEKFLICCMDN();
	}

	private void CEKFLICCMDN()
	{
		if (IsActive())
		{
			MLPLFIPMOJH.Clear();
			MLPLFIPMOJH.Add(this, GEINAHMAFAM, DrivenTransformProperties.Anchors | DrivenTransformProperties.AnchoredPosition);
			GEINAHMAFAM.anchorMin = Vector2.zero;
			GEINAHMAFAM.anchorMax = Vector2.one;
			GEINAHMAFAM.anchoredPosition = Vector2.zero;
			MLPLFIPMOJH.Add(this, GEINAHMAFAM, DrivenTransformProperties.SizeDelta);
			Vector2 vector = IEDKCPLAHHL() - IHPLOMNOBCP;
			if (BKKHIOMJDMN.x > 0.001f)
			{
				vector.x -= Mathf.Floor(vector.x / BKKHIOMJDMN.x) * BKKHIOMJDMN.x;
			}
			else
			{
				vector.x = 0f;
			}
			if (BKKHIOMJDMN.y > 0.001f)
			{
				vector.y -= Mathf.Floor(vector.y / BKKHIOMJDMN.y) * BKKHIOMJDMN.y;
			}
			else
			{
				vector.y = 0f;
			}
			GEINAHMAFAM.sizeDelta = -vector;
		}
	}

	private Vector2 IEDKCPLAHHL()
	{
		RectTransform rectTransform = GEINAHMAFAM.parent as RectTransform;
		if (!rectTransform)
		{
			return Vector2.zero;
		}
		return rectTransform.rect.size;
	}

	public virtual void SetLayoutHorizontal()
	{
	}

	public virtual void SetLayoutVertical()
	{
	}

	protected void HAPPCOBHMHM()
	{
		if (IsActive())
		{
			CEKFLICCMDN();
		}
	}
}
