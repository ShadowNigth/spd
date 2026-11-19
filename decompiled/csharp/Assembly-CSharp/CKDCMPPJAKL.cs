using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/BoxSlider")]
public class CKDCMPPJAKL : Selectable, IDragHandler, IInitializePotentialDragHandler, ICanvasElement, IEventSystemHandler
{
	public enum DCHLONHPMGA
	{
		GMJEHNJNFHD,
		BONCBJNOGIM,
		GNNFMIPJFEP,
		GCEHHHEPILC
	}

	[Serializable]
	public class BoxSliderEvent : UnityEvent<float, float>
	{
	}

	private enum FLHBGLJDLDB
	{
		CKGPDOGEHBB,
		IOKNFMCJIHM
	}

	[SerializeField]
	private RectTransform m_HandleRect;

	[SerializeField]
	[Space(6f)]
	private float m_MinValue;

	[SerializeField]
	private float m_MaxValue = 1f;

	[SerializeField]
	private bool m_WholeNumbers;

	[SerializeField]
	private float m_ValueX = 1f;

	[SerializeField]
	private float m_ValueY = 1f;

	[SerializeField]
	[Space(6f)]
	private BoxSliderEvent m_OnValueChanged = new BoxSliderEvent();

	private Transform LADNANAHFBO;

	private RectTransform OHKHBNEJOGB;

	private Vector2 LHKLBKIKOKA = Vector2.zero;

	private DrivenRectTransformTracker MLPLFIPMOJH;

	public RectTransform OIKBCNMBJKK
	{
		get
		{
			return m_HandleRect;
		}
		set
		{
			if (KDINNNBJOID(ref m_HandleRect, value))
			{
				NLPIACPONJF();
				KGKNDPAOMNE();
			}
		}
	}

	public float COGJIBDIJKG
	{
		get
		{
			return m_MinValue;
		}
		set
		{
			if (NOINEEJPMBG(ref m_MinValue, value))
			{
				HJCDFPANPNC(m_ValueX);
				CBKKJOBCHBJ(m_ValueY);
				KGKNDPAOMNE();
			}
		}
	}

	public float ONIBILHEOAI
	{
		get
		{
			return m_MaxValue;
		}
		set
		{
			if (NOINEEJPMBG(ref m_MaxValue, value))
			{
				HJCDFPANPNC(m_ValueX);
				CBKKJOBCHBJ(m_ValueY);
				KGKNDPAOMNE();
			}
		}
	}

	public bool KEMICOEICNL
	{
		get
		{
			return m_WholeNumbers;
		}
		set
		{
			if (NOINEEJPMBG(ref m_WholeNumbers, value))
			{
				HJCDFPANPNC(m_ValueX);
				CBKKJOBCHBJ(m_ValueY);
				KGKNDPAOMNE();
			}
		}
	}

	public float EIDJFCIBPDO
	{
		get
		{
			if (KEMICOEICNL)
			{
				return Mathf.Round(m_ValueX);
			}
			return m_ValueX;
		}
		set
		{
			HJCDFPANPNC(value);
		}
	}

	public float NHPABFOCMIA
	{
		get
		{
			if (Mathf.Approximately(COGJIBDIJKG, ONIBILHEOAI))
			{
				return 0f;
			}
			return Mathf.InverseLerp(COGJIBDIJKG, ONIBILHEOAI, EIDJFCIBPDO);
		}
		set
		{
			EIDJFCIBPDO = Mathf.Lerp(COGJIBDIJKG, ONIBILHEOAI, value);
		}
	}

	public float HMLLALNGMNI
	{
		get
		{
			if (KEMICOEICNL)
			{
				return Mathf.Round(m_ValueY);
			}
			return m_ValueY;
		}
		set
		{
			CBKKJOBCHBJ(value);
		}
	}

	public float NGCBJCIOABB
	{
		get
		{
			if (Mathf.Approximately(COGJIBDIJKG, ONIBILHEOAI))
			{
				return 0f;
			}
			return Mathf.InverseLerp(COGJIBDIJKG, ONIBILHEOAI, HMLLALNGMNI);
		}
		set
		{
			HMLLALNGMNI = Mathf.Lerp(COGJIBDIJKG, ONIBILHEOAI, value);
		}
	}

	public BoxSliderEvent ICOHIIJIPHE
	{
		get
		{
			return m_OnValueChanged;
		}
		set
		{
			m_OnValueChanged = value;
		}
	}

	private float ANNPGIIIANP => (!KEMICOEICNL) ? ((ONIBILHEOAI - COGJIBDIJKG) * 0.1f) : 1f;

	protected CKDCMPPJAKL()
	{
	}

	public virtual void Rebuild(CanvasUpdate IAIHCHJCDDF)
	{
	}

	public void LayoutComplete()
	{
	}

	public void GraphicUpdateComplete()
	{
	}

	public static bool KDINNNBJOID<T>(ref T MIEPDOFPFKD, T AAHPIGOGNEJ) where T : class
	{
		if ((MIEPDOFPFKD == null && AAHPIGOGNEJ == null) || (MIEPDOFPFKD != null && MIEPDOFPFKD.Equals(AAHPIGOGNEJ)))
		{
			return false;
		}
		MIEPDOFPFKD = AAHPIGOGNEJ;
		return true;
	}

	public static bool NOINEEJPMBG<T>(ref T MIEPDOFPFKD, T AAHPIGOGNEJ) where T : struct
	{
		if (MIEPDOFPFKD.Equals(AAHPIGOGNEJ))
		{
			return false;
		}
		MIEPDOFPFKD = AAHPIGOGNEJ;
		return true;
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		NLPIACPONJF();
		HJCDFPANPNC(m_ValueX, IKOLIOBMMPN: false);
		CBKKJOBCHBJ(m_ValueY, IKOLIOBMMPN: false);
		KGKNDPAOMNE();
	}

	protected override void OnDisable()
	{
		MLPLFIPMOJH.Clear();
		base.OnDisable();
	}

	private void NLPIACPONJF()
	{
		if ((bool)m_HandleRect)
		{
			LADNANAHFBO = m_HandleRect.transform;
			if (LADNANAHFBO.parent != null)
			{
				OHKHBNEJOGB = LADNANAHFBO.parent.GetComponent<RectTransform>();
			}
		}
		else
		{
			OHKHBNEJOGB = null;
		}
	}

	private void HJCDFPANPNC(float MMKMICOONDG)
	{
		HJCDFPANPNC(MMKMICOONDG, IKOLIOBMMPN: true);
	}

	private void HJCDFPANPNC(float MMKMICOONDG, bool IKOLIOBMMPN)
	{
		float num = Mathf.Clamp(MMKMICOONDG, COGJIBDIJKG, ONIBILHEOAI);
		if (KEMICOEICNL)
		{
			num = Mathf.Round(num);
		}
		if (m_ValueX != num)
		{
			m_ValueX = num;
			KGKNDPAOMNE();
			if (IKOLIOBMMPN)
			{
				m_OnValueChanged.Invoke(num, HMLLALNGMNI);
			}
		}
	}

	private void CBKKJOBCHBJ(float MMKMICOONDG)
	{
		CBKKJOBCHBJ(MMKMICOONDG, IKOLIOBMMPN: true);
	}

	private void CBKKJOBCHBJ(float MMKMICOONDG, bool IKOLIOBMMPN)
	{
		float num = Mathf.Clamp(MMKMICOONDG, COGJIBDIJKG, ONIBILHEOAI);
		if (KEMICOEICNL)
		{
			num = Mathf.Round(num);
		}
		if (m_ValueY != num)
		{
			m_ValueY = num;
			KGKNDPAOMNE();
			if (IKOLIOBMMPN)
			{
				m_OnValueChanged.Invoke(EIDJFCIBPDO, num);
			}
		}
	}

	protected override void OnRectTransformDimensionsChange()
	{
		base.OnRectTransformDimensionsChange();
		KGKNDPAOMNE();
	}

	private void KGKNDPAOMNE()
	{
		MLPLFIPMOJH.Clear();
		if (OHKHBNEJOGB != null)
		{
			MLPLFIPMOJH.Add(this, m_HandleRect, DrivenTransformProperties.Anchors);
			Vector2 zero = Vector2.zero;
			Vector2 one = Vector2.one;
			float value = (one[0] = NHPABFOCMIA);
			zero[0] = value;
			value = (one[1] = NGCBJCIOABB);
			zero[1] = value;
			m_HandleRect.anchorMin = zero;
			m_HandleRect.anchorMax = one;
		}
	}

	private void FOBMGKILIIC(PointerEventData GBOFEMOALII, Camera KAFHIBHGLGJ)
	{
		RectTransform oHKHBNEJOGB = OHKHBNEJOGB;
		if (oHKHBNEJOGB != null && oHKHBNEJOGB.rect.size[0] > 0f && RectTransformUtility.ScreenPointToLocalPointInRectangle(oHKHBNEJOGB, GBOFEMOALII.position, KAFHIBHGLGJ, out var localPoint))
		{
			localPoint -= oHKHBNEJOGB.rect.position;
			float eHAPKEKPMOE = Mathf.Clamp01((localPoint - LHKLBKIKOKA)[0] / oHKHBNEJOGB.rect.size[0]);
			NHPABFOCMIA = eHAPKEKPMOE;
			float eHAPKEKPMOE2 = Mathf.Clamp01((localPoint - LHKLBKIKOKA)[1] / oHKHBNEJOGB.rect.size[1]);
			NGCBJCIOABB = eHAPKEKPMOE2;
		}
	}

	private bool BJECAFGKCKA(PointerEventData GBOFEMOALII)
	{
		return IsActive() && IsInteractable() && GBOFEMOALII.button == PointerEventData.InputButton.Left;
	}

	public override void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		if (!BJECAFGKCKA(GBOFEMOALII))
		{
			return;
		}
		base.OnPointerDown(GBOFEMOALII);
		LHKLBKIKOKA = Vector2.zero;
		if (OHKHBNEJOGB != null && RectTransformUtility.RectangleContainsScreenPoint(m_HandleRect, GBOFEMOALII.position, GBOFEMOALII.enterEventCamera))
		{
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(m_HandleRect, GBOFEMOALII.position, GBOFEMOALII.pressEventCamera, out var localPoint))
			{
				LHKLBKIKOKA = localPoint;
			}
			LHKLBKIKOKA.y = 0f - LHKLBKIKOKA.y;
		}
		else
		{
			FOBMGKILIIC(GBOFEMOALII, GBOFEMOALII.pressEventCamera);
		}
	}

	public virtual void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (BJECAFGKCKA(GBOFEMOALII))
		{
			FOBMGKILIIC(GBOFEMOALII, GBOFEMOALII.pressEventCamera);
		}
	}

	public virtual void OnInitializePotentialDrag(PointerEventData GBOFEMOALII)
	{
		GBOFEMOALII.useDragThreshold = false;
	}

	Transform ICanvasElement.get_transform()
	{
		return base.transform;
	}

	bool ICanvasElement.IsDestroyed()
	{
		return IsDestroyed();
	}
}
