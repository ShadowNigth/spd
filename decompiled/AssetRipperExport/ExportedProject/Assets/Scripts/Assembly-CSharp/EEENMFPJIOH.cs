using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/ScrollRectEx")]
public class EEENMFPJIOH : ScrollRect
{
	private sealed class OBMEEPOLDIN
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IInitializePotentialDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnInitializePotentialDrag(GBOFEMOALII);
		}
	}

	private sealed class IODKIPIODKG
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnDrag(GBOFEMOALII);
		}
	}

	private sealed class BOIANGPCHBK
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IBeginDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnBeginDrag(GBOFEMOALII);
		}
	}

	private sealed class GHFHNPLDMHO
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IEndDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnEndDrag(GBOFEMOALII);
		}
	}

	private sealed class FFFOCANPKLI
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IScrollHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnScroll(GBOFEMOALII);
		}
	}

	private bool ADOBGCDBFKB;

	private void ILKEMEGABBK<T>(Action<T> FELGOOGHDPH) where T : IEventSystemHandler
	{
		Transform parent = base.transform.parent;
		while (parent != null)
		{
			Component[] components = parent.GetComponents<Component>();
			foreach (Component component in components)
			{
				if (component is T)
				{
					FELGOOGHDPH((T)(IEventSystemHandler)component);
				}
			}
			parent = parent.parent;
		}
	}

	public override void OnInitializePotentialDrag(PointerEventData GBOFEMOALII)
	{
		OBMEEPOLDIN oBMEEPOLDIN = new OBMEEPOLDIN();
		oBMEEPOLDIN.GBOFEMOALII = GBOFEMOALII;
		ILKEMEGABBK<IInitializePotentialDragHandler>(oBMEEPOLDIN.BEKJDJFLJJC);
		base.OnInitializePotentialDrag(oBMEEPOLDIN.GBOFEMOALII);
	}

	public override void OnDrag(PointerEventData GBOFEMOALII)
	{
		IODKIPIODKG iODKIPIODKG = new IODKIPIODKG();
		iODKIPIODKG.GBOFEMOALII = GBOFEMOALII;
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK<IDragHandler>(iODKIPIODKG.BEKJDJFLJJC);
		}
		else
		{
			base.OnDrag(iODKIPIODKG.GBOFEMOALII);
		}
	}

	public override void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		BOIANGPCHBK bOIANGPCHBK = new BOIANGPCHBK();
		bOIANGPCHBK.GBOFEMOALII = GBOFEMOALII;
		if (!base.horizontal && Math.Abs(bOIANGPCHBK.GBOFEMOALII.delta.x) > Math.Abs(bOIANGPCHBK.GBOFEMOALII.delta.y))
		{
			ADOBGCDBFKB = true;
		}
		else if (!base.vertical && Math.Abs(bOIANGPCHBK.GBOFEMOALII.delta.x) < Math.Abs(bOIANGPCHBK.GBOFEMOALII.delta.y))
		{
			ADOBGCDBFKB = true;
		}
		else
		{
			ADOBGCDBFKB = false;
		}
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK<IBeginDragHandler>(bOIANGPCHBK.BEKJDJFLJJC);
		}
		else
		{
			base.OnBeginDrag(bOIANGPCHBK.GBOFEMOALII);
		}
	}

	public override void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		GHFHNPLDMHO gHFHNPLDMHO = new GHFHNPLDMHO();
		gHFHNPLDMHO.GBOFEMOALII = GBOFEMOALII;
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK<IEndDragHandler>(gHFHNPLDMHO.BEKJDJFLJJC);
		}
		else
		{
			base.OnEndDrag(gHFHNPLDMHO.GBOFEMOALII);
		}
		ADOBGCDBFKB = false;
	}

	public virtual void LCGOIHBLJEN(PointerEventData GBOFEMOALII)
	{
		FFFOCANPKLI fFFOCANPKLI = new FFFOCANPKLI();
		fFFOCANPKLI.GBOFEMOALII = GBOFEMOALII;
		if (!base.horizontal && Math.Abs(fFFOCANPKLI.GBOFEMOALII.scrollDelta.x) > Math.Abs(fFFOCANPKLI.GBOFEMOALII.scrollDelta.y))
		{
			ADOBGCDBFKB = true;
		}
		else if (!base.vertical && Math.Abs(fFFOCANPKLI.GBOFEMOALII.scrollDelta.x) < Math.Abs(fFFOCANPKLI.GBOFEMOALII.scrollDelta.y))
		{
			ADOBGCDBFKB = true;
		}
		else
		{
			ADOBGCDBFKB = false;
		}
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK<IScrollHandler>(fFFOCANPKLI.BEKJDJFLJJC);
		}
		else
		{
			base.OnScroll(fFFOCANPKLI.GBOFEMOALII);
		}
	}
}
