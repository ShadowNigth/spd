using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(LayoutElement))]
[RequireComponent(typeof(InputField))]
public class MMHEMEBCCDE : UIBehaviour
{
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

	private float NMFHKGPNBCA => FKJADFJKADI.placeholder.rectTransform.offsetMin.y - FKJADFJKADI.placeholder.rectTransform.offsetMax.y;

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

	private IEnumerator EGMPEKLLEPC()
	{
		yield return new WaitForEndOfFrame();
		if (CODNNIKNIHB != null)
		{
			CODNNIKNIHB.verticalNormalizedPosition = 0f;
		}
	}
}
