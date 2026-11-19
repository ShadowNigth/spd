using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Selectable))]
public class DDFJDMPGPLP : UIBehaviour, IPointerClickHandler, ISubmitHandler, IEventSystemHandler
{
	private Selectable PMHLHIIDMEG => GetComponent<Selectable>();

	private DCGAAHOLAAD CBMMAIBHFJK => GetComponentInParent<DCGAAHOLAAD>();

	private bool IFHCMHPAJGO => PMHLHIIDMEG == CBMMAIBHFJK.LJHOJBMPJIB[0];

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
