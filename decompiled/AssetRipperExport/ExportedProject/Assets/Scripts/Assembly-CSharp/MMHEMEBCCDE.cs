using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(LayoutElement))]
[RequireComponent(typeof(InputField))]
public class MMHEMEBCCDE : UIBehaviour
{
	private sealed class MNKFACPKLJF : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal MMHEMEBCCDE KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public MNKFACPKLJF()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				HLJEEFIJCOF = new WaitForEndOfFrame();
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				if (KPHCHDHEKGH.CODNNIKNIHB != null)
				{
					KPHCHDHEKGH.CODNNIKNIHB.verticalNormalizedPosition = 0f;
				}
				GNNOELAJGPI = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	[Range(0f, 50f)]
	internal int JDJAKHKAGCO;

	public ScrollRect CODNNIKNIHB;

	private RectTransform EPBIEGMDFOC;

	private CanvasScaler DBPDBKDEMOL;

	private HorizontalOrVerticalLayoutGroup CLECMOGFBMD;

	private LayoutElement MGJIEBDBKOG;

	private InputField FEPIJNJBLOO;

	private RectTransform LLNPLBDOCGC;

	private Vector2 FBJKLKCKELF;

	private RectTransform HBBCKMAJJLE
	{
		get
		{
			if ((bool)CODNNIKNIHB && !EPBIEGMDFOC)
			{
				EPBIEGMDFOC = CODNNIKNIHB.GetComponent<RectTransform>();
			}
			return EPBIEGMDFOC;
		}
	}

	private float DNPLLDKKOAL
	{
		get
		{
			if (!DBPDBKDEMOL)
			{
				DBPDBKDEMOL = GetComponentInParent<CanvasScaler>();
			}
			return (!DBPDBKDEMOL) ? 1f : DBPDBKDEMOL.scaleFactor;
		}
	}

	private HorizontalOrVerticalLayoutGroup PBLJMNKLFDO
	{
		get
		{
			CLECMOGFBMD = base.transform.parent.GetComponent<HorizontalOrVerticalLayoutGroup>();
			return CLECMOGFBMD;
		}
	}

	private LayoutElement FFLFKMIONJH
	{
		get
		{
			if (!MGJIEBDBKOG)
			{
				MGJIEBDBKOG = GetComponent<LayoutElement>();
			}
			return MGJIEBDBKOG;
		}
	}

	private InputField FKJADFJKADI
	{
		get
		{
			if (!FEPIJNJBLOO)
			{
				FEPIJNJBLOO = GetComponent<InputField>();
			}
			return FEPIJNJBLOO;
		}
	}

	private RectTransform LACLEAPHNGF
	{
		get
		{
			if (!LLNPLBDOCGC)
			{
				LLNPLBDOCGC = GetComponent<RectTransform>();
			}
			return LLNPLBDOCGC;
		}
	}

	private float NMFHKGPNBCA
	{
		get
		{
			return FKJADFJKADI.placeholder.rectTransform.offsetMin.y - FKJADFJKADI.placeholder.rectTransform.offsetMax.y;
		}
	}

	protected override void Awake()
	{
		FKJADFJKADI.onValueChanged.AddListener(AGAGCOOKHLH);
	}

	private void Update()
	{
		if ((bool)CODNNIKNIHB && (FBJKLKCKELF == Vector2.zero || FBJKLKCKELF != HBBCKMAJJLE.rect.size))
		{
			FBJKLKCKELF = HBBCKMAJJLE.rect.size;
			AGAGCOOKHLH();
		}
	}

	private void AGAGCOOKHLH()
	{
		AGAGCOOKHLH(FKJADFJKADI.text);
	}

	private void AGAGCOOKHLH(string KLLKONMADKA)
	{
		TextGenerationSettings generationSettings = FKJADFJKADI.textComponent.GetGenerationSettings(FKJADFJKADI.textComponent.rectTransform.rect.size);
		generationSettings.generateOutOfBounds = false;
		float height = FKJADFJKADI.textComponent.rectTransform.rect.height;
		float num = new TextGenerator().GetPreferredHeight(FKJADFJKADI.text, generationSettings) / DNPLLDKKOAL + NMFHKGPNBCA;
		float num2 = new TextGenerator().GetPreferredHeight(string.Empty, generationSettings) / DNPLLDKKOAL + NMFHKGPNBCA;
		if (height < num || height > num)
		{
			if (num > num2)
			{
				if ((bool)PBLJMNKLFDO)
				{
					FFLFKMIONJH.preferredHeight = num;
				}
				else
				{
					LACLEAPHNGF.sizeDelta = new Vector2(LACLEAPHNGF.rect.width, num);
				}
			}
			else if ((bool)PBLJMNKLFDO)
			{
				FFLFKMIONJH.preferredHeight = num2;
			}
			else
			{
				LACLEAPHNGF.sizeDelta = new Vector2(LACLEAPHNGF.rect.width, num2);
			}
		}
		else if ((bool)PBLJMNKLFDO)
		{
			FFLFKMIONJH.preferredHeight = num2;
		}
		else
		{
			LACLEAPHNGF.sizeDelta = new Vector2(LACLEAPHNGF.rect.width, num2);
		}
		if ((bool)CODNNIKNIHB)
		{
			StartCoroutine(EGMPEKLLEPC());
		}
	}

	[DebuggerHidden]
	private IEnumerator EGMPEKLLEPC()
	{
		MNKFACPKLJF mNKFACPKLJF = new MNKFACPKLJF();
		mNKFACPKLJF.KPHCHDHEKGH = this;
		return mNKFACPKLJF;
	}
}
