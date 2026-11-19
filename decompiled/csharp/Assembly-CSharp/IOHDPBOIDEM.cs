using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[DisallowMultipleComponent]
[AddComponentMenu("UI/Extensions/Extensions Toggle Group")]
public class IOHDPBOIDEM : UIBehaviour
{
	[Serializable]
	public class ToggleGroupEvent : UnityEvent<bool>
	{
	}

	[SerializeField]
	private bool m_AllowSwitchOff;

	private List<EAFLPBFMOLI> NGIMJHDLNCL = new List<EAFLPBFMOLI>();

	public ToggleGroupEvent BKELDHNDLHH = new ToggleGroupEvent();

	public ToggleGroupEvent HICIKELKLOG = new ToggleGroupEvent();

	[CompilerGenerated]
	private static Predicate<EAFLPBFMOLI> ACJNADIPOMC;

	[CompilerGenerated]
	private static Func<EAFLPBFMOLI, bool> HJJBAKLDAEB;

	public bool ONKGKIKOMCI
	{
		get
		{
			return m_AllowSwitchOff;
		}
		set
		{
			m_AllowSwitchOff = value;
		}
	}

	public EAFLPBFMOLI HGBCAMEPOID { get; private set; }

	protected IOHDPBOIDEM()
	{
	}

	private void CAJMOPFADON(EAFLPBFMOLI DALIJHMFDNC)
	{
		if (DALIJHMFDNC == null || !NGIMJHDLNCL.Contains(DALIJHMFDNC))
		{
			throw new ArgumentException(string.Format("Toggle {0} is not part of ToggleGroup {1}", new object[2] { DALIJHMFDNC, this }));
		}
	}

	public void GLNGOBMANGC(EAFLPBFMOLI DALIJHMFDNC)
	{
		CAJMOPFADON(DALIJHMFDNC);
		for (int i = 0; i < NGIMJHDLNCL.Count; i++)
		{
			if (NGIMJHDLNCL[i] == DALIJHMFDNC)
			{
				HGBCAMEPOID = DALIJHMFDNC;
			}
			else
			{
				NGIMJHDLNCL[i].HKNNIMAAIOF = false;
			}
		}
		BKELDHNDLHH.Invoke(JPFNCNEDHEE());
	}

	public void NJPMAIHHFBO(EAFLPBFMOLI DALIJHMFDNC)
	{
		if (NGIMJHDLNCL.Contains(DALIJHMFDNC))
		{
			NGIMJHDLNCL.Remove(DALIJHMFDNC);
			DALIJHMFDNC.DNMFLMKBGAP.RemoveListener(DHCAJFLLJBN);
		}
	}

	private void DHCAJFLLJBN(bool AMAJPFBCKDI)
	{
		HICIKELKLOG.Invoke(AMAJPFBCKDI);
	}

	public void BOKGIDCDEIF(EAFLPBFMOLI DALIJHMFDNC)
	{
		if (!NGIMJHDLNCL.Contains(DALIJHMFDNC))
		{
			NGIMJHDLNCL.Add(DALIJHMFDNC);
			DALIJHMFDNC.DNMFLMKBGAP.AddListener(DHCAJFLLJBN);
		}
	}

	public bool JPFNCNEDHEE()
	{
		return NGIMJHDLNCL.Find((EAFLPBFMOLI HKCJBFIKALL) => HKCJBFIKALL.HKNNIMAAIOF) != null;
	}

	public IEnumerable<EAFLPBFMOLI> MAKBLMGKGAI()
	{
		return NGIMJHDLNCL.Where((EAFLPBFMOLI HKCJBFIKALL) => HKCJBFIKALL.HKNNIMAAIOF);
	}

	public void HKOHLFNKAAG()
	{
		bool allowSwitchOff = m_AllowSwitchOff;
		m_AllowSwitchOff = true;
		for (int i = 0; i < NGIMJHDLNCL.Count; i++)
		{
			NGIMJHDLNCL[i].HKNNIMAAIOF = false;
		}
		m_AllowSwitchOff = allowSwitchOff;
	}

	public void FAJGHMNMEOB(bool EHAPKEKPMOE)
	{
		Debug.Log("Testing, the group has toggled [" + EHAPKEKPMOE + "]");
	}

	public void CLHEPNMGKLJ(bool EHAPKEKPMOE)
	{
		Debug.Log("Testing, a toggle has toggled [" + EHAPKEKPMOE + "]");
	}

	[CompilerGenerated]
	private static bool HHOLDKFGALH(EAFLPBFMOLI HKCJBFIKALL)
	{
		return HKCJBFIKALL.HKNNIMAAIOF;
	}

	[CompilerGenerated]
	private static bool JFKJONDNIBP(EAFLPBFMOLI HKCJBFIKALL)
	{
		return HKCJBFIKALL.HKNNIMAAIOF;
	}
}
