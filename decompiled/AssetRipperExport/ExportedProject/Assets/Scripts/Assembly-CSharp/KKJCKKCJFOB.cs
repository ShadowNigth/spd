using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Radial Slider")]
[RequireComponent(typeof(Image))]
public class KKJCKKCJFOB : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	[Serializable]
	public class RadialSliderValueChangedEvent : UnityEvent<int>
	{
	}

	[Serializable]
	public class RadialSliderTextValueChangedEvent : UnityEvent<string>
	{
	}

	private bool APANJNCPJMC;

	private bool NCEMFFDKDGG;

	private bool HKPDCPCAAOM;

	private Vector2 NFFJHLKOPHK;

	private float OFJJFIBHKJB;

	private float KDOEFCGNEON;

	private float LLPCBPBNKEA;

	private float ONANCLFDDGA;

	private float COMPJGMMMNN;

	private Camera BGEJIGNFDLG;

	private Image DAPHIBGDIOM;

	[SerializeField]
	[Tooltip("Radial Gradient Start Color")]
	private Color m_startColor = Color.green;

	[Tooltip("Radial Gradient End Color")]
	[SerializeField]
	private Color m_endColor = Color.red;

	[SerializeField]
	[Tooltip("Move slider absolute or use Lerping?\nDragging only supported with absolute")]
	private bool m_lerpToTarget;

	[Tooltip("Curve to apply to the Lerp\nMust be set to enable Lerp")]
	[SerializeField]
	private AnimationCurve m_lerpCurve;

	[SerializeField]
	[Tooltip("Event fired when value of control changes, outputs an INT angle value")]
	private RadialSliderValueChangedEvent _onValueChanged = new RadialSliderValueChangedEvent();

	[Tooltip("Event fired when value of control changes, outputs a TEXT angle value")]
	[SerializeField]
	private RadialSliderTextValueChangedEvent _onTextValueChanged = new RadialSliderTextValueChangedEvent();

	public float BCDDIILCAAF
	{
		get
		{
			return GCBAMPBIOKO.fillAmount * 360f;
		}
		set
		{
			if (DPJHOLCPHOM)
			{
				PJGBOLOIBCK(value / 360f);
			}
			else
			{
				PHBLEKADLLB(value / 360f);
			}
		}
	}

	public float JFLFLCDEEEI
	{
		get
		{
			return GCBAMPBIOKO.fillAmount;
		}
		set
		{
			if (DPJHOLCPHOM)
			{
				PJGBOLOIBCK(value);
			}
			else
			{
				PHBLEKADLLB(value);
			}
		}
	}

	public Color PIBCGEHEIOB
	{
		get
		{
			return m_endColor;
		}
		set
		{
			m_endColor = value;
		}
	}

	public Color HEIDGDJCNKN
	{
		get
		{
			return m_startColor;
		}
		set
		{
			m_startColor = value;
		}
	}

	public bool DPJHOLCPHOM
	{
		get
		{
			return m_lerpToTarget;
		}
		set
		{
			m_lerpToTarget = value;
		}
	}

	public AnimationCurve DNBCGEBKOAE
	{
		get
		{
			return m_lerpCurve;
		}
		set
		{
			m_lerpCurve = value;
			COMPJGMMMNN = DNBCGEBKOAE[DNBCGEBKOAE.length - 1].time;
		}
	}

	public bool CLCJGPJPONK
	{
		get
		{
			return HKPDCPCAAOM;
		}
	}

	public Image GCBAMPBIOKO
	{
		get
		{
			if (DAPHIBGDIOM == null)
			{
				DAPHIBGDIOM = GetComponent<Image>();
				DAPHIBGDIOM.type = Image.Type.Filled;
				DAPHIBGDIOM.fillMethod = Image.FillMethod.Radial360;
				DAPHIBGDIOM.fillOrigin = 3;
				DAPHIBGDIOM.fillAmount = 0f;
			}
			return DAPHIBGDIOM;
		}
	}

	public RadialSliderValueChangedEvent DNMFLMKBGAP
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

	public RadialSliderTextValueChangedEvent KCDOKBCHBJG
	{
		get
		{
			return _onTextValueChanged;
		}
		set
		{
			_onTextValueChanged = value;
		}
	}

	private void Awake()
	{
		if (DNBCGEBKOAE != null && DNBCGEBKOAE.length > 0)
		{
			COMPJGMMMNN = DNBCGEBKOAE[DNBCGEBKOAE.length - 1].time;
		}
		else
		{
			COMPJGMMMNN = 1f;
		}
	}

	private void Update()
	{
		if (APANJNCPJMC)
		{
			OFJJFIBHKJB = IAKEKPMCBPG();
			if (!HKPDCPCAAOM)
			{
				if (!DPJHOLCPHOM)
				{
					PHBLEKADLLB(OFJJFIBHKJB);
					LEONECLAMKJ();
				}
				else
				{
					if (NCEMFFDKDGG)
					{
						PJGBOLOIBCK(OFJJFIBHKJB);
					}
					NCEMFFDKDGG = false;
				}
			}
		}
		if (HKPDCPCAAOM && JFLFLCDEEEI != KDOEFCGNEON)
		{
			ONANCLFDDGA += Time.deltaTime;
			float num = ONANCLFDDGA / COMPJGMMMNN;
			if (DNBCGEBKOAE != null && DNBCGEBKOAE.length > 0)
			{
				PHBLEKADLLB(Mathf.Lerp(LLPCBPBNKEA, KDOEFCGNEON, DNBCGEBKOAE.Evaluate(num)));
			}
			else
			{
				PHBLEKADLLB(Mathf.Lerp(LLPCBPBNKEA, KDOEFCGNEON, num));
			}
		}
		if (ONANCLFDDGA >= COMPJGMMMNN || JFLFLCDEEEI == KDOEFCGNEON)
		{
			HKPDCPCAAOM = false;
			PHBLEKADLLB(KDOEFCGNEON);
			LEONECLAMKJ();
		}
	}

	private void PJGBOLOIBCK(float JHLFGABJNFD)
	{
		if (!HKPDCPCAAOM)
		{
			LLPCBPBNKEA = JFLFLCDEEEI;
			KDOEFCGNEON = JHLFGABJNFD;
			ONANCLFDDGA = 0f;
			HKPDCPCAAOM = true;
		}
	}

	private float IAKEKPMCBPG()
	{
		RectTransformUtility.ScreenPointToLocalPointInRectangle(base.transform as RectTransform, UnityEngine.Input.mousePosition, BGEJIGNFDLG, out NFFJHLKOPHK);
		return (Mathf.Atan2(0f - NFFJHLKOPHK.y, NFFJHLKOPHK.x) * 180f / (float)Math.PI + 180f) / 360f;
	}

	private void PHBLEKADLLB(float JHLFGABJNFD)
	{
		GCBAMPBIOKO.fillAmount = JHLFGABJNFD;
		GCBAMPBIOKO.color = Color.Lerp(m_startColor, m_endColor, JHLFGABJNFD);
	}

	private void LEONECLAMKJ()
	{
		_onValueChanged.Invoke((int)(OFJJFIBHKJB * 360f));
		_onTextValueChanged.Invoke(((int)(OFJJFIBHKJB * 360f)/*cast due to .constrained prefix*/).ToString());
	}

	public void OnPointerEnter(PointerEventData GBOFEMOALII)
	{
		BGEJIGNFDLG = GBOFEMOALII.enterEventCamera;
	}

	public void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		BGEJIGNFDLG = GBOFEMOALII.enterEventCamera;
		APANJNCPJMC = true;
	}

	public void OnPointerUp(PointerEventData GBOFEMOALII)
	{
		APANJNCPJMC = false;
		NCEMFFDKDGG = true;
	}
}
