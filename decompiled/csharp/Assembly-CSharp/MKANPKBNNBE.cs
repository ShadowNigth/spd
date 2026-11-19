using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Selectable))]
public class MKANPKBNNBE : UIBehaviour, IPointerClickHandler, ISubmitHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
{
	internal int JNDABHCJHHD;

	[SerializeField]
	private Color textColor;

	internal bool IFHCMHPAJGO => JNDABHCJHHD == 0;

	internal bool JEIINHGPAIL => JNDABHCJHHD == FAPHKLPDCKM.GPFBFACLBPE.Length - 1;

	public bool HNJBPICPKIJ
	{
		get
		{
			return FAPHKLPDCKM.ALOGHJDIPCI == PMHLHIIDMEG;
		}
		set
		{
			HELBDGFDCKA(value);
		}
	}

	internal HHJKMBNOEJE FAPHKLPDCKM => GetComponentInParent<HHJKMBNOEJE>();

	internal Selectable PMHLHIIDMEG => GetComponent<Selectable>();

	protected MKANPKBNNBE()
	{
	}

	public virtual void OnPointerClick(PointerEventData GBOFEMOALII)
	{
		if (GBOFEMOALII.button == PointerEventData.InputButton.Left)
		{
			HNJBPICPKIJ = true;
		}
	}

	public virtual void OnPointerEnter(PointerEventData GBOFEMOALII)
	{
		LGONBJHNBFO();
	}

	public virtual void OnPointerExit(PointerEventData GBOFEMOALII)
	{
		LGONBJHNBFO();
	}

	public virtual void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		LGONBJHNBFO();
	}

	public virtual void OnPointerUp(PointerEventData GBOFEMOALII)
	{
		LGONBJHNBFO();
	}

	public virtual void OnSelect(BaseEventData GBOFEMOALII)
	{
		LGONBJHNBFO();
	}

	public virtual void OnDeselect(BaseEventData GBOFEMOALII)
	{
		LGONBJHNBFO();
	}

	public virtual void OnSubmit(BaseEventData GBOFEMOALII)
	{
		HNJBPICPKIJ = true;
	}

	private void HELBDGFDCKA(bool EHAPKEKPMOE)
	{
		if (EHAPKEKPMOE && PMHLHIIDMEG.IsActive() && PMHLHIIDMEG.IsInteractable())
		{
			if (FAPHKLPDCKM.ALOGHJDIPCI == PMHLHIIDMEG)
			{
				if (FAPHKLPDCKM.LDPNJAJLLDF)
				{
					HLLJLCJHJDH();
				}
				else
				{
					LGONBJHNBFO();
				}
				return;
			}
			if ((bool)FAPHKLPDCKM.ALOGHJDIPCI)
			{
				MKANPKBNNBE component = FAPHKLPDCKM.ALOGHJDIPCI.GetComponent<MKANPKBNNBE>();
				FAPHKLPDCKM.ALOGHJDIPCI = null;
				component.HNMGHNHHLEC();
			}
			FAPHKLPDCKM.ALOGHJDIPCI = PMHLHIIDMEG;
			GNGMIMODHMN();
			HNMGHNHHLEC();
			FAPHKLPDCKM.DNMFLMKBGAP.Invoke(JNDABHCJHHD);
		}
		else if (FAPHKLPDCKM.ALOGHJDIPCI == PMHLHIIDMEG)
		{
			HLLJLCJHJDH();
		}
	}

	private void HLLJLCJHJDH()
	{
		FAPHKLPDCKM.ALOGHJDIPCI = null;
		HNMGHNHHLEC();
		FAPHKLPDCKM.DNMFLMKBGAP.Invoke(-1);
	}

	private void LGONBJHNBFO()
	{
		if (!(PMHLHIIDMEG != FAPHKLPDCKM.ALOGHJDIPCI))
		{
			HNMGHNHHLEC(HMBBDKGPJKN: true);
		}
	}

	internal void HNMGHNHHLEC()
	{
		HNMGHNHHLEC(HMBBDKGPJKN: false);
	}

	internal void HNMGHNHHLEC(bool HMBBDKGPJKN)
	{
		Color color = ((!HNJBPICPKIJ) ? PMHLHIIDMEG.colors.normalColor : FAPHKLPDCKM.selectedColor);
		Color color2 = ((!HNJBPICPKIJ) ? textColor : PMHLHIIDMEG.colors.normalColor);
		Sprite nMBMDJNAIIM = ((!HNJBPICPKIJ) ? null : PMHLHIIDMEG.spriteState.pressedSprite);
		string fLAMNMNIFKD = ((!HNJBPICPKIJ) ? PMHLHIIDMEG.animationTriggers.normalTrigger : PMHLHIIDMEG.animationTriggers.pressedTrigger);
		switch (PMHLHIIDMEG.transition)
		{
		case Selectable.Transition.ColorTint:
			CFFLEGGLLHM(color * PMHLHIIDMEG.colors.colorMultiplier, HMBBDKGPJKN);
			FAHLANILDID(color2 * PMHLHIIDMEG.colors.colorMultiplier);
			break;
		case Selectable.Transition.SpriteSwap:
			BGPMADMBGFB(nMBMDJNAIIM);
			break;
		case Selectable.Transition.Animation:
			FKPBNBBHMAB(fLAMNMNIFKD);
			break;
		}
	}

	private void CFFLEGGLLHM(Color EFHPDEEDENO, bool HMBBDKGPJKN)
	{
		if (!(PMHLHIIDMEG.targetGraphic == null))
		{
			PMHLHIIDMEG.targetGraphic.CrossFadeColor(EFHPDEEDENO, (!HMBBDKGPJKN) ? PMHLHIIDMEG.colors.fadeDuration : 0f, ignoreTimeScale: true, useAlpha: true);
		}
	}

	internal void GNGMIMODHMN()
	{
		Text componentInChildren = GetComponentInChildren<Text>();
		if ((bool)componentInChildren)
		{
			textColor = componentInChildren.color;
		}
	}

	private void FAHLANILDID(Color EFHPDEEDENO)
	{
		Text componentInChildren = GetComponentInChildren<Text>();
		if ((bool)componentInChildren)
		{
			componentInChildren.color = EFHPDEEDENO;
		}
	}

	private void BGPMADMBGFB(Sprite NMBMDJNAIIM)
	{
		if (!(PMHLHIIDMEG.image == null))
		{
			PMHLHIIDMEG.image.overrideSprite = NMBMDJNAIIM;
		}
	}

	private void FKPBNBBHMAB(string FLAMNMNIFKD)
	{
		if (!(PMHLHIIDMEG.animator == null) && PMHLHIIDMEG.animator.isActiveAndEnabled && PMHLHIIDMEG.animator.hasBoundPlayables && !string.IsNullOrEmpty(FLAMNMNIFKD))
		{
			PMHLHIIDMEG.animator.ResetTrigger(PMHLHIIDMEG.animationTriggers.normalTrigger);
			PMHLHIIDMEG.animator.ResetTrigger(PMHLHIIDMEG.animationTriggers.pressedTrigger);
			PMHLHIIDMEG.animator.ResetTrigger(PMHLHIIDMEG.animationTriggers.highlightedTrigger);
			PMHLHIIDMEG.animator.ResetTrigger(PMHLHIIDMEG.animationTriggers.disabledTrigger);
			PMHLHIIDMEG.animator.SetTrigger(FLAMNMNIFKD);
		}
	}
}
