using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/UI Highlightable Extension")]
[RequireComponent(typeof(RectTransform), typeof(Graphic))]
public class DEGNDBGIFOH : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	[Serializable]
	public class InteractableChangedEvent : UnityEvent<bool>
	{
	}

	private Graphic PEOEJMBLJPF;

	private bool FOCBOLENPGD;

	private bool DHBOHCKMEKC;

	[SerializeField]
	[Tooltip("Can this panel be interacted with or is it disabled? (does not affect child components)")]
	private bool m_Interactable = true;

	[Tooltip("Does the panel remain in the pressed state when clicked? (default false)")]
	[SerializeField]
	private bool m_ClickToHold;

	[Tooltip("The default color for the panel")]
	public Color PEOGJBEPKNI = Color.grey;

	[Tooltip("The color for the panel when a mouse is over it or it is in focus")]
	public Color OMGLAFPBAFL = Color.yellow;

	[Tooltip("The color for the panel when it is clicked/held")]
	public Color DDJJMONJDGB = Color.green;

	[Tooltip("The color for the panel when it is not interactable (see Interactable)")]
	public Color JEKGEJDOBLH = Color.gray;

	[Tooltip("Event for when the panel is enabled / disabled, to enable disabling / enabling of child or other gameobjects")]
	public InteractableChangedEvent ANKMLLHDJHF;

	public bool EJMOEBEOCBB
	{
		get
		{
			return m_Interactable;
		}
		set
		{
			m_Interactable = value;
			LBBMGAONHDL(PEOEJMBLJPF);
			ANKMLLHDJHF.Invoke(m_Interactable);
		}
	}

	public bool DPFOFOOAGHE
	{
		get
		{
			return m_ClickToHold;
		}
		set
		{
			m_ClickToHold = value;
		}
	}

	private void Awake()
	{
		PEOEJMBLJPF = GetComponent<Graphic>();
	}

	public void OnPointerEnter(PointerEventData GBOFEMOALII)
	{
		if (EJMOEBEOCBB && !DHBOHCKMEKC)
		{
			FOCBOLENPGD = true;
			PEOEJMBLJPF.color = OMGLAFPBAFL;
		}
	}

	public void OnPointerExit(PointerEventData GBOFEMOALII)
	{
		if (EJMOEBEOCBB && !DHBOHCKMEKC)
		{
			FOCBOLENPGD = false;
			PEOEJMBLJPF.color = PEOGJBEPKNI;
		}
	}

	public void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		if (EJMOEBEOCBB)
		{
			PEOEJMBLJPF.color = DDJJMONJDGB;
			if (DPFOFOOAGHE)
			{
				DHBOHCKMEKC = !DHBOHCKMEKC;
			}
		}
	}

	public void OnPointerUp(PointerEventData GBOFEMOALII)
	{
		if (!DHBOHCKMEKC)
		{
			LBBMGAONHDL(PEOEJMBLJPF);
		}
	}

	private void LBBMGAONHDL(Graphic EOIKKBCNCBN)
	{
		if (m_Interactable)
		{
			if (FOCBOLENPGD)
			{
				EOIKKBCNCBN.color = OMGLAFPBAFL;
			}
			else
			{
				EOIKKBCNCBN.color = PEOGJBEPKNI;
			}
		}
		else
		{
			EOIKKBCNCBN.color = JEKGEJDOBLH;
		}
	}
}
