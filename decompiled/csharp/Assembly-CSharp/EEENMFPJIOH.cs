using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/ScrollRectEx")]
public class EEENMFPJIOH : ScrollRect
{
	[CompilerGenerated]
	private sealed class OBMEEPOLDIN
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IInitializePotentialDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnInitializePotentialDrag(GBOFEMOALII);
		}
	}

	[CompilerGenerated]
	private sealed class IODKIPIODKG
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnDrag(GBOFEMOALII);
		}
	}

	[CompilerGenerated]
	private sealed class BOIANGPCHBK
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IBeginDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnBeginDrag(GBOFEMOALII);
		}
	}

	[CompilerGenerated]
	private sealed class GHFHNPLDMHO
	{
		internal PointerEventData GBOFEMOALII;

		internal void BEKJDJFLJJC(IEndDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnEndDrag(GBOFEMOALII);
		}
	}

	[CompilerGenerated]
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
		ILKEMEGABBK(delegate(IInitializePotentialDragHandler JNEBJLMLOLM)
		{
			JNEBJLMLOLM.OnInitializePotentialDrag(GBOFEMOALII);
		});
		base.OnInitializePotentialDrag(GBOFEMOALII);
	}

	public override void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK(delegate(IDragHandler JNEBJLMLOLM)
			{
				JNEBJLMLOLM.OnDrag(GBOFEMOALII);
			});
		}
		else
		{
			base.OnDrag(GBOFEMOALII);
		}
	}

	public override void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		if (!base.horizontal && Math.Abs(GBOFEMOALII.delta.x) > Math.Abs(GBOFEMOALII.delta.y))
		{
			ADOBGCDBFKB = true;
		}
		else if (!base.vertical && Math.Abs(GBOFEMOALII.delta.x) < Math.Abs(GBOFEMOALII.delta.y))
		{
			ADOBGCDBFKB = true;
		}
		else
		{
			ADOBGCDBFKB = false;
		}
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK(delegate(IBeginDragHandler JNEBJLMLOLM)
			{
				JNEBJLMLOLM.OnBeginDrag(GBOFEMOALII);
			});
		}
		else
		{
			base.OnBeginDrag(GBOFEMOALII);
		}
	}

	public override void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK(delegate(IEndDragHandler JNEBJLMLOLM)
			{
				JNEBJLMLOLM.OnEndDrag(GBOFEMOALII);
			});
		}
		else
		{
			base.OnEndDrag(GBOFEMOALII);
		}
		ADOBGCDBFKB = false;
	}

	public virtual void LCGOIHBLJEN(PointerEventData GBOFEMOALII)
	{
		if (!base.horizontal && Math.Abs(GBOFEMOALII.scrollDelta.x) > Math.Abs(GBOFEMOALII.scrollDelta.y))
		{
			ADOBGCDBFKB = true;
		}
		else if (!base.vertical && Math.Abs(GBOFEMOALII.scrollDelta.x) < Math.Abs(GBOFEMOALII.scrollDelta.y))
		{
			ADOBGCDBFKB = true;
		}
		else
		{
			ADOBGCDBFKB = false;
		}
		if (ADOBGCDBFKB)
		{
			ILKEMEGABBK(delegate(IScrollHandler JNEBJLMLOLM)
			{
				JNEBJLMLOLM.OnScroll(GBOFEMOALII);
			});
		}
		else
		{
			base.OnScroll(GBOFEMOALII);
		}
	}
}
