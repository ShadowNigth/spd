using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform), typeof(LayoutElement))]
[AddComponentMenu("UI/Extensions/Accordion/Accordion Element")]
public class NLPKMNABHNI : Toggle
{
	[SerializeField]
	private float m_MinHeight = 18f;

	private KGBBAHHKIBP BANKAEEMHGN;

	private RectTransform NOCDCMPJEGP;

	private LayoutElement LKIEEHICFPG;

	[NonSerialized]
	private readonly global::HBNDNEIIGMI<DLDBIMEGKAM> CKHLBKNGCOB;

	protected NLPKMNABHNI()
	{
		if (CKHLBKNGCOB == null)
		{
			CKHLBKNGCOB = new global::HBNDNEIIGMI<DLDBIMEGKAM>();
		}
		CKHLBKNGCOB.HIBHJDCMMAJ(this);
	}

	protected override void Awake()
	{
		base.Awake();
		base.transition = Transition.None;
		toggleTransition = ToggleTransition.None;
		BANKAEEMHGN = base.gameObject.GetComponentInParent<KGBBAHHKIBP>();
		NOCDCMPJEGP = base.transform as RectTransform;
		LKIEEHICFPG = base.gameObject.GetComponent<LayoutElement>();
		onValueChanged.AddListener(ICOHIIJIPHE);
	}

	public void ICOHIIJIPHE(bool MEMMCMIHGKP)
	{
		if (LKIEEHICFPG == null)
		{
			return;
		}
		switch ((BANKAEEMHGN != null) ? BANKAEEMHGN.CJPKPIDEDMF : KGBBAHHKIBP.LKFDAJDBFAI.KNNLGDOIGAK)
		{
		case KGBBAHHKIBP.LKFDAJDBFAI.KNNLGDOIGAK:
			if (MEMMCMIHGKP)
			{
				LKIEEHICFPG.preferredHeight = -1f;
			}
			else
			{
				LKIEEHICFPG.preferredHeight = m_MinHeight;
			}
			break;
		case KGBBAHHKIBP.LKFDAJDBFAI.NLIPACMELFO:
			if (MEMMCMIHGKP)
			{
				CLAHIBCEFPC(m_MinHeight, IGBPJPMLIAJ());
			}
			else
			{
				CLAHIBCEFPC(NOCDCMPJEGP.rect.height, m_MinHeight);
			}
			break;
		}
	}

	protected float IGBPJPMLIAJ()
	{
		if (LKIEEHICFPG == null)
		{
			return m_MinHeight;
		}
		float preferredHeight = LKIEEHICFPG.preferredHeight;
		LKIEEHICFPG.preferredHeight = -1f;
		float preferredHeight2 = LayoutUtility.GetPreferredHeight(NOCDCMPJEGP);
		LKIEEHICFPG.preferredHeight = preferredHeight;
		return preferredHeight2;
	}

	protected void CLAHIBCEFPC(float ADBFOEIKDIJ, float LBABCBPBAHL)
	{
		float eHAPKEKPMOE = ((!(BANKAEEMHGN != null)) ? 0.3f : BANKAEEMHGN.JIJEMBGFLNO);
		DLDBIMEGKAM lIEKABKEJOG = new DLDBIMEGKAM
		{
			PJBGGDBFEEP = eHAPKEKPMOE,
			ADBFOEIKDIJ = ADBFOEIKDIJ,
			LBABCBPBAHL = LBABCBPBAHL
		};
		lIEKABKEJOG.IOMMGJKMPMM(AIKKOPBOFCP);
		lIEKABKEJOG.ADDDPKEAFFD = true;
		CKHLBKNGCOB.CLAHIBCEFPC(lIEKABKEJOG);
	}

	protected void AIKKOPBOFCP(float GAGNFGOGPHH)
	{
		if (!(LKIEEHICFPG == null))
		{
			LKIEEHICFPG.preferredHeight = GAGNFGOGPHH;
		}
	}
}
