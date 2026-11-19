using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Stepper")]
[RequireComponent(typeof(RectTransform))]
public class DCGAAHOLAAD : UIBehaviour
{
	[Serializable]
	public class StepperValueChangedEvent : UnityEvent<int>
	{
	}

	private Selectable[] AJEMPDONINF;

	[Tooltip("The current step value of the control")]
	[SerializeField]
	private int _value;

	[Tooltip("The minimum step value allowed by the control. When reached it will disable the '-' button")]
	[SerializeField]
	private int _minimum;

	[SerializeField]
	[Tooltip("The maximum step value allowed by the control. When reached it will disable the '+' button")]
	private int _maximum = 100;

	[Tooltip("The step increment used to increment / decrement the step value")]
	[SerializeField]
	private int _step = 1;

	[SerializeField]
	[Tooltip("Does the step value loop around from end to end")]
	private bool _wrap;

	[SerializeField]
	[Tooltip("A GameObject with an Image to use as a separator between segments. Size of the RectTransform will determine the size of the separator used.\nNote, make sure to disable the separator GO so that it does not affect the scene")]
	private Graphic _separator;

	private float HGCJFMFJDCI;

	[SerializeField]
	private StepperValueChangedEvent _onValueChanged = new StepperValueChangedEvent();

	private float KJCJFAIDINJ
	{
		get
		{
			if (HGCJFMFJDCI == 0f && (bool)BILDIDFCNDN)
			{
				HGCJFMFJDCI = BILDIDFCNDN.rectTransform.rect.width;
				Image component = BILDIDFCNDN.GetComponent<Image>();
				if ((bool)component)
				{
					HGCJFMFJDCI /= component.pixelsPerUnit;
				}
			}
			return HGCJFMFJDCI;
		}
	}

	public Selectable[] LJHOJBMPJIB
	{
		get
		{
			if (AJEMPDONINF == null || AJEMPDONINF.Length == 0)
			{
				AJEMPDONINF = OCAJAGDOFPP();
			}
			return AJEMPDONINF;
		}
	}

	public int EHAPKEKPMOE
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public int AANGLCPJNHI
	{
		get
		{
			return _minimum;
		}
		set
		{
			_minimum = value;
		}
	}

	public int AIJMEGDJJCL
	{
		get
		{
			return _maximum;
		}
		set
		{
			_maximum = value;
		}
	}

	public int KGDJAALEIAA
	{
		get
		{
			return _step;
		}
		set
		{
			_step = value;
		}
	}

	public bool DMNAGPPBFAO
	{
		get
		{
			return _wrap;
		}
		set
		{
			_wrap = value;
		}
	}

	public Graphic BILDIDFCNDN
	{
		get
		{
			return _separator;
		}
		set
		{
			_separator = value;
			HGCJFMFJDCI = 0f;
			GEAJJDOPDBC(LJHOJBMPJIB);
		}
	}

	public StepperValueChangedEvent DNMFLMKBGAP
	{
		get
		{
			return _onValueChanged;
		}
		set
		{
			_onValueChanged = value;
		}
	}

	protected DCGAAHOLAAD()
	{
	}

	private Selectable[] OCAJAGDOFPP()
	{
		Selectable[] componentsInChildren = GetComponentsInChildren<Selectable>();
		if (componentsInChildren.Length != 2)
		{
			throw new InvalidOperationException("A stepper must have two Button children");
		}
		for (int i = 0; i < 2; i++)
		{
			DDFJDMPGPLP component = componentsInChildren[i].GetComponent<DDFJDMPGPLP>();
			if (component == null)
			{
				component = componentsInChildren[i].gameObject.AddComponent<DDFJDMPGPLP>();
			}
		}
		if (!DMNAGPPBFAO)
		{
			JMHACGAGDDC(componentsInChildren);
		}
		GEAJJDOPDBC(componentsInChildren);
		return componentsInChildren;
	}

	public void MPAACDIFFPH()
	{
		NHCDKFNHNPB(KGDJAALEIAA);
	}

	public void JIKDFIGHKMD()
	{
		NHCDKFNHNPB(-KGDJAALEIAA);
	}

	private void NHCDKFNHNPB(int DKOMKIMDDGM)
	{
		EHAPKEKPMOE += DKOMKIMDDGM;
		if (DMNAGPPBFAO)
		{
			if (EHAPKEKPMOE > AIJMEGDJJCL)
			{
				EHAPKEKPMOE = AANGLCPJNHI;
			}
			if (EHAPKEKPMOE < AANGLCPJNHI)
			{
				EHAPKEKPMOE = AIJMEGDJJCL;
			}
		}
		else
		{
			EHAPKEKPMOE = Math.Max(AANGLCPJNHI, EHAPKEKPMOE);
			EHAPKEKPMOE = Math.Min(AIJMEGDJJCL, EHAPKEKPMOE);
			JMHACGAGDDC(LJHOJBMPJIB);
		}
		_onValueChanged.Invoke(EHAPKEKPMOE);
	}

	private void JMHACGAGDDC(Selectable[] LJHOJBMPJIB)
	{
		LJHOJBMPJIB[0].interactable = DMNAGPPBFAO || EHAPKEKPMOE > AANGLCPJNHI;
		LJHOJBMPJIB[1].interactable = DMNAGPPBFAO || EHAPKEKPMOE < AIJMEGDJJCL;
	}

	private void PMLAFKANKPJ(Selectable[] LJHOJBMPJIB)
	{
		for (int i = 0; i < 2; i++)
		{
			if (LJHOJBMPJIB[i].image == null)
			{
				continue;
			}
			Sprite sprite = LJHOJBMPJIB[i].image.sprite;
			if (sprite.border.x != 0f && sprite.border.z != 0f)
			{
				Rect rect = sprite.rect;
				Vector4 border = sprite.border;
				if (i == 0)
				{
					rect.xMax = border.z;
					border.z = 0f;
				}
				else
				{
					rect.xMin = border.x;
					border.x = 0f;
				}
				LJHOJBMPJIB[i].image.sprite = Sprite.Create(sprite.texture, rect, sprite.pivot, sprite.pixelsPerUnit, 0u, SpriteMeshType.FullRect, border);
			}
		}
	}

	public void GEAJJDOPDBC(Selectable[] LJHOJBMPJIB = null)
	{
		LJHOJBMPJIB = LJHOJBMPJIB ?? this.LJHOJBMPJIB;
		PMLAFKANKPJ(LJHOJBMPJIB);
		RectTransform rectTransform = base.transform as RectTransform;
		float num = rectTransform.rect.width / 2f - KJCJFAIDINJ;
		for (int i = 0; i < 2; i++)
		{
			float inset = ((i != 0) ? (num + KJCJFAIDINJ) : 0f);
			RectTransform component = LJHOJBMPJIB[i].GetComponent<RectTransform>();
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.zero;
			component.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, inset, num);
			component.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0f, rectTransform.rect.height);
		}
		if ((bool)BILDIDFCNDN)
		{
			Transform transform = base.gameObject.transform.Find("Separator");
			Graphic graphic = ((!(transform != null)) ? UnityEngine.Object.Instantiate(BILDIDFCNDN.gameObject).GetComponent<Graphic>() : transform.GetComponent<Graphic>());
			graphic.gameObject.name = "Separator";
			graphic.gameObject.SetActive(true);
			graphic.rectTransform.SetParent(base.transform, false);
			graphic.rectTransform.anchorMin = Vector2.zero;
			graphic.rectTransform.anchorMax = Vector2.zero;
			graphic.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, num, KJCJFAIDINJ);
			graphic.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0f, rectTransform.rect.height);
		}
	}
}
