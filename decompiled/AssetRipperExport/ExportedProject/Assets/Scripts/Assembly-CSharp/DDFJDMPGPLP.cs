using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Selectable))]
public class DDFJDMPGPLP : UIBehaviour, IPointerClickHandler, ISubmitHandler, IEventSystemHandler
{
	private Selectable PMHLHIIDMEG
	{
		get
		{
			return GetComponent<Selectable>();
		}
	}

	private DCGAAHOLAAD CBMMAIBHFJK
	{
		get
		{
			return GetComponentInParent<DCGAAHOLAAD>();
		}
	}

	private bool IFHCMHPAJGO
	{
		get
		{
			return PMHLHIIDMEG == CBMMAIBHFJK.LJHOJBMPJIB[0];
		}
	}

	protected DDFJDMPGPLP()
	{
	}

	public virtual void OnPointerClick(PointerEventData GBOFEMOALII)
	{
		if (GBOFEMOALII.button == PointerEventData.InputButton.Left)
		{
			MLAHIBNJKDJ();
		}
	}

	public virtual void OnSubmit(BaseEventData GBOFEMOALII)
	{
		MLAHIBNJKDJ();
	}

	private void MLAHIBNJKDJ()
	{
		if (PMHLHIIDMEG.IsActive() && PMHLHIIDMEG.IsInteractable())
		{
			if (IFHCMHPAJGO)
			{
				CBMMAIBHFJK.JIKDFIGHKMD();
			}
			else
			{
				CBMMAIBHFJK.MPAACDIFFPH();
			}
		}
	}
}
