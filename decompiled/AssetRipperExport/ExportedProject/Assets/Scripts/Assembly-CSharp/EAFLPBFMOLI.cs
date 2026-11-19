using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/Extensions Toggle", 31)]
public class EAFLPBFMOLI : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement, IEventSystemHandler
{
	public enum NBLDKFAKPLB
	{
		BLBOPPEBDFH = 0,
		CGPKGIPGDLP = 1
	}

	[Serializable]
	public class ToggleEvent : UnityEvent<bool>
	{
	}

	[Serializable]
	public class ToggleEventObject : UnityEvent<EAFLPBFMOLI>
	{
	}

	public string LNFAHGBOCCP;

	public NBLDKFAKPLB DJIJHMBDEHI = NBLDKFAKPLB.CGPKGIPGDLP;

	public Graphic EOIKKBCNCBN;

	[SerializeField]
	private IOHDPBOIDEM m_Group;

	[Tooltip("Use this event if you only need the bool state of the toggle that was changed")]
	public ToggleEvent DNMFLMKBGAP = new ToggleEvent();

	[Tooltip("Use this event if you need access to the toggle that was changed")]
	public ToggleEventObject FMBDGHKDJNO = new ToggleEventObject();

	[Tooltip("Is the toggle currently on or off?")]
	[FormerlySerializedAs("m_IsActive")]
	[SerializeField]
	private bool m_IsOn;

	public IOHDPBOIDEM IPMJPELCHNN
	{
		get
		{
			return m_Group;
		}
		set
		{
			m_Group = value;
			HFJKEFBFLKL(m_Group, true);
			IBLHJOIBINC(true);
		}
	}

	public bool HKNNIMAAIOF
	{
		get
		{
			return m_IsOn;
		}
		set
		{
			PJCKFCICIJF(value);
		}
	}

	Transform ICanvasElement.transform
	{
		get
		{
			return base.transform;
		}
	}

	protected EAFLPBFMOLI()
	{
	}

	public virtual void Rebuild(CanvasUpdate IAIHCHJCDDF)
	{
	}

	public virtual void LayoutComplete()
	{
	}

	public virtual void GraphicUpdateComplete()
	{
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		HFJKEFBFLKL(m_Group, false);
		IBLHJOIBINC(true);
	}

	protected override void OnDisable()
	{
		HFJKEFBFLKL(null, false);
		base.OnDisable();
	}

	protected override void OnDidApplyAnimationProperties()
	{
		if (EOIKKBCNCBN != null)
		{
			bool flag = !Mathf.Approximately(EOIKKBCNCBN.canvasRenderer.GetColor().a, 0f);
			if (m_IsOn != flag)
			{
				m_IsOn = flag;
				PJCKFCICIJF(!flag);
			}
		}
		base.OnDidApplyAnimationProperties();
	}

	private void HFJKEFBFLKL(IOHDPBOIDEM GDMEJMFDKOH, bool NNMDECCDEJI)
	{
		IOHDPBOIDEM iOHDPBOIDEM = m_Group;
		if (m_Group != null)
		{
			m_Group.NJPMAIHHFBO(this);
		}
		if (NNMDECCDEJI)
		{
			m_Group = GDMEJMFDKOH;
		}
		if (m_Group != null && IsActive())
		{
			m_Group.BOKGIDCDEIF(this);
		}
		if (GDMEJMFDKOH != null && GDMEJMFDKOH != iOHDPBOIDEM && HKNNIMAAIOF && IsActive())
		{
			m_Group.GLNGOBMANGC(this);
		}
	}

	private void PJCKFCICIJF(bool EHAPKEKPMOE)
	{
		PJCKFCICIJF(EHAPKEKPMOE, true);
	}

	private void PJCKFCICIJF(bool EHAPKEKPMOE, bool IKOLIOBMMPN)
	{
		if (m_IsOn != EHAPKEKPMOE)
		{
			m_IsOn = EHAPKEKPMOE;
			if (m_Group != null && IsActive() && (m_IsOn || (!m_Group.JPFNCNEDHEE() && !m_Group.ONKGKIKOMCI)))
			{
				m_IsOn = true;
				m_Group.GLNGOBMANGC(this);
			}
			IBLHJOIBINC(DJIJHMBDEHI == NBLDKFAKPLB.BLBOPPEBDFH);
			if (IKOLIOBMMPN)
			{
				DNMFLMKBGAP.Invoke(m_IsOn);
				FMBDGHKDJNO.Invoke(this);
			}
		}
	}

	private void IBLHJOIBINC(bool HMBBDKGPJKN)
	{
		if (!(EOIKKBCNCBN == null))
		{
			EOIKKBCNCBN.CrossFadeAlpha((!m_IsOn) ? 0f : 1f, (!HMBBDKGPJKN) ? 0.1f : 0f, true);
		}
	}

	protected override void Start()
	{
		IBLHJOIBINC(true);
	}

	private void LDKEDFCADON()
	{
		if (IsActive() && IsInteractable())
		{
			HKNNIMAAIOF = !HKNNIMAAIOF;
		}
	}

	public virtual void OnPointerClick(PointerEventData GBOFEMOALII)
	{
		if (GBOFEMOALII.button == PointerEventData.InputButton.Left)
		{
			LDKEDFCADON();
		}
	}

	public virtual void OnSubmit(BaseEventData GBOFEMOALII)
	{
		LDKEDFCADON();
	}

	bool ICanvasElement.IsDestroyed()
	{
		return IsDestroyed();
	}
}
