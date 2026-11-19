using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/Segmented Control")]
public class HHJKMBNOEJE : UIBehaviour
{
	[Serializable]
	public class SegmentSelectedEvent : UnityEvent<int>
	{
	}

	private Selectable[] PJMEPAIEPJL;

	[SerializeField]
	[Tooltip("A GameObject with an Image to use as a separator between segments. Size of the RectTransform will determine the size of the separator used.\nNote, make sure to disable the separator GO so that it does not affect the scene")]
	private Graphic m_separator;

	private float HFFAMKAAJPH;

	[SerializeField]
	[Tooltip("When True, it allows each button to be toggled on/off")]
	private bool m_allowSwitchingOff;

	[SerializeField]
	[Tooltip("The selected default for the control (zero indexed array)")]
	private int m_selectedSegmentIndex = -1;

	[Tooltip("Event to fire once the selection has been changed")]
	[SerializeField]
	private SegmentSelectedEvent m_onValueChanged = new SegmentSelectedEvent();

	protected internal Selectable ALOGHJDIPCI;

	[SerializeField]
	public Color selectedColor;

	protected float HJEEALECICF
	{
		get
		{
			if (HFFAMKAAJPH == 0f && (bool)BILDIDFCNDN)
			{
				HFFAMKAAJPH = BILDIDFCNDN.rectTransform.rect.width;
				Image component = BILDIDFCNDN.GetComponent<Image>();
				if ((bool)component)
				{
					HFFAMKAAJPH /= component.pixelsPerUnit;
				}
			}
			return HFFAMKAAJPH;
		}
	}

	public Selectable[] GPFBFACLBPE
	{
		get
		{
			if (PJMEPAIEPJL == null || PJMEPAIEPJL.Length == 0)
			{
				PJMEPAIEPJL = KPMOLBGEHFO();
			}
			return PJMEPAIEPJL;
		}
	}

	public Graphic BILDIDFCNDN
	{
		get
		{
			return m_separator;
		}
		set
		{
			m_separator = value;
			HFFAMKAAJPH = 0f;
			DGGJLCDBIGJ();
		}
	}

	public bool LDPNJAJLLDF
	{
		get
		{
			return m_allowSwitchingOff;
		}
		set
		{
			m_allowSwitchingOff = value;
		}
	}

	public int ANCCJIHAKKG
	{
		get
		{
			return Array.IndexOf(GPFBFACLBPE, ALOGHJDIPCI);
		}
		set
		{
			value = Math.Max(value, -1);
			value = Math.Min(value, GPFBFACLBPE.Length - 1);
			m_selectedSegmentIndex = value;
			if (value == -1)
			{
				if ((bool)ALOGHJDIPCI)
				{
					ALOGHJDIPCI.GetComponent<MKANPKBNNBE>().HNJBPICPKIJ = false;
					ALOGHJDIPCI = null;
				}
			}
			else
			{
				GPFBFACLBPE[value].GetComponent<MKANPKBNNBE>().HNJBPICPKIJ = true;
			}
		}
	}

	public SegmentSelectedEvent DNMFLMKBGAP
	{
		get
		{
			return m_onValueChanged;
		}
		set
		{
			m_onValueChanged = value;
		}
	}

	protected HHJKMBNOEJE()
	{
	}

	protected override void Start()
	{
		base.Start();
		DGGJLCDBIGJ();
		if (m_selectedSegmentIndex != -1)
		{
			ANCCJIHAKKG = m_selectedSegmentIndex;
		}
	}

	private Selectable[] KPMOLBGEHFO()
	{
		Selectable[] componentsInChildren = GetComponentsInChildren<Selectable>();
		if (componentsInChildren.Length < 2)
		{
			throw new InvalidOperationException("A segmented control must have at least two Button children");
		}
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			MKANPKBNNBE mKANPKBNNBE = componentsInChildren[i].GetComponent<MKANPKBNNBE>();
			if (mKANPKBNNBE == null)
			{
				mKANPKBNNBE = componentsInChildren[i].gameObject.AddComponent<MKANPKBNNBE>();
			}
			mKANPKBNNBE.JNDABHCJHHD = i;
		}
		return componentsInChildren;
	}

	public void JDCAKPOADIH()
	{
		ALOGHJDIPCI = null;
	}

	private void PMLAFKANKPJ()
	{
		for (int i = 0; i < GPFBFACLBPE.Length; i++)
		{
			if (GPFBFACLBPE[i].image == null)
			{
				continue;
			}
			Sprite sprite = GPFBFACLBPE[i].image.sprite;
			if (sprite.border.x != 0f && sprite.border.z != 0f)
			{
				Rect rect = sprite.rect;
				Vector4 border = sprite.border;
				if (i > 0)
				{
					rect.xMin = border.x;
					border.x = 0f;
				}
				if (i < GPFBFACLBPE.Length - 1)
				{
					rect.xMax = border.z;
					border.z = 0f;
				}
				GPFBFACLBPE[i].image.sprite = Sprite.Create(sprite.texture, rect, sprite.pivot, sprite.pixelsPerUnit, 0u, SpriteMeshType.FullRect, border);
			}
		}
	}

	public void DGGJLCDBIGJ()
	{
		PMLAFKANKPJ();
		RectTransform rectTransform = base.transform as RectTransform;
		float num = rectTransform.rect.width / (float)GPFBFACLBPE.Length - HJEEALECICF * (float)(GPFBFACLBPE.Length - 1);
		for (int i = 0; i < GPFBFACLBPE.Length; i++)
		{
			float num2 = (num + HJEEALECICF) * (float)i;
			RectTransform component = GPFBFACLBPE[i].GetComponent<RectTransform>();
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.zero;
			component.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, num2, num);
			component.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0f, rectTransform.rect.height);
			if ((bool)BILDIDFCNDN && i > 0)
			{
				Transform transform = base.gameObject.transform.Find("Separator " + i);
				Graphic graphic = ((!(transform != null)) ? UnityEngine.Object.Instantiate(BILDIDFCNDN.gameObject).GetComponent<Graphic>() : transform.GetComponent<Graphic>());
				graphic.gameObject.name = "Separator " + i;
				graphic.gameObject.SetActive(true);
				graphic.rectTransform.SetParent(base.transform, false);
				graphic.rectTransform.anchorMin = Vector2.zero;
				graphic.rectTransform.anchorMax = Vector2.zero;
				graphic.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, num2 - HJEEALECICF, HJEEALECICF);
				graphic.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0f, rectTransform.rect.height);
			}
		}
	}
}
