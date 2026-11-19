using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/UI Selectable Extension")]
[RequireComponent(typeof(Selectable))]
public class KGFOODJENOM : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	[Serializable]
	public class UIButtonEvent : UnityEvent<PointerEventData.InputButton>
	{
	}

	[Tooltip("Event that fires when a button is initially pressed down")]
	public UIButtonEvent NDBEMPEAOLO;

	[Tooltip("Event that fires when a button is released")]
	public UIButtonEvent MDNCHCBNKJF;

	[Tooltip("Event that continually fires while a button is held down")]
	public UIButtonEvent HMFPCBHDADM;

	private bool MBINCMCILKL;

	private PointerEventData LDLMIAMOKGN;

	void IPointerDownHandler.OnPointerDown(PointerEventData GBOFEMOALII)
	{
		if (NDBEMPEAOLO != null)
		{
			NDBEMPEAOLO.Invoke(GBOFEMOALII.button);
		}
		MBINCMCILKL = true;
		LDLMIAMOKGN = GBOFEMOALII;
	}

	void IPointerUpHandler.OnPointerUp(PointerEventData GBOFEMOALII)
	{
		if (MDNCHCBNKJF != null)
		{
			MDNCHCBNKJF.Invoke(GBOFEMOALII.button);
		}
		MBINCMCILKL = false;
		LDLMIAMOKGN = null;
	}

	private void Update()
	{
		if (MBINCMCILKL && HMFPCBHDADM != null)
		{
			HMFPCBHDADM.Invoke(LDLMIAMOKGN.button);
		}
	}

	public void JHLNODCFIDG()
	{
	}

	public void GKLGHPBBKKA()
	{
	}

	public void EBOKLJOPGIH()
	{
	}

	public void LNMJJLJLBEK()
	{
	}

	private void OnDisable()
	{
		MBINCMCILKL = false;
	}
}
