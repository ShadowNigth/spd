using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SPD.EditorAttributes;
using UnityEngine;
using UnityEngine.UI;

public class DBDCHDJAEEF : MonoBehaviour
{
	private sealed class DDLPEDHEHPN : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal DBDCHDJAEEF KPHCHDHEKGH;

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
		public DDLPEDHEHPN()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				HLJEEFIJCOF = new WaitForSeconds(KPHCHDHEKGH.BHCHOIGLECH);
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				break;
			case 1u:
			case 2u:
				if (KPHCHDHEKGH.BJMMJCBPOPO.alpha < 1f)
				{
					KPHCHDHEKGH.BJMMJCBPOPO.alpha += Time.deltaTime * 2f;
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 2;
					}
					break;
				}
				if (KPHCHDHEKGH.KLNNBKIOHDJ != null)
				{
					KPHCHDHEKGH.KLNNBKIOHDJ.enabled = true;
				}
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
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

	[Separator("SETTINGS")]
	public float KGBFCKJLOFJ = 5f;

	[Separator("REFERENCES")]
	[SerializeField]
	private Image TargetGrapihc;

	[SerializeField]
	private RectTransform CircleAreaRect;

	public Sprite MEEOMHDDGEK;

	[SerializeField]
	private Text InfoText;

	private CanvasGroup BJMMJCBPOPO;

	private Animator KLNNBKIOHDJ;

	private float BHCHOIGLECH = 0.1f;

	private CJJCCNPKBCF NKNODBFDJMP;

	private bool GNIHJGIJKLM;

	private void Awake()
	{
		if (GetComponent<CanvasGroup>() != null)
		{
			BJMMJCBPOPO = GetComponent<CanvasGroup>();
		}
		else
		{
			BJMMJCBPOPO = base.gameObject.AddComponent<CanvasGroup>();
		}
		if (GetComponent<Animator>() != null)
		{
			KLNNBKIOHDJ = GetComponent<Animator>();
		}
		if (KLNNBKIOHDJ != null)
		{
			KLNNBKIOHDJ.enabled = false;
		}
		BJMMJCBPOPO.alpha = 0f;
		if (CircleAreaRect != null)
		{
			CircleAreaRect.gameObject.SetActive(false);
		}
	}

	public void FHADFLKMLFL(bool FHAFNDJLBIP)
	{
		if (FHAFNDJLBIP)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		TargetGrapihc.sprite = MEEOMHDDGEK;
		UnityEngine.Object.Destroy(base.gameObject, KGBFCKJLOFJ);
	}

	public void FHADFLKMLFL(bool FHAFNDJLBIP, Sprite NKNPENHJDND)
	{
		if (FHAFNDJLBIP)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		TargetGrapihc.sprite = NKNPENHJDND;
		UnityEngine.Object.Destroy(base.gameObject, KGBFCKJLOFJ);
	}

	public void NNDPLGOCGII(string LIEKABKEJOG, float HPEFCKHDPEC = 0f)
	{
		if (!(InfoText == null))
		{
			InfoText.text = LIEKABKEJOG;
		}
	}

	public void CIKBLCGBPMM(Sprite EIBPFKJIJEH)
	{
		TargetGrapihc.sprite = EIBPFKJIJEH;
	}

	public RectTransform FAIBPHBCFCM(float DOGLMPODLGL, Color FPONCFJJCOK)
	{
		if (CircleAreaRect == null)
		{
			return null;
		}
		NKNODBFDJMP = base.transform.root.GetComponentInChildren<CJJCCNPKBCF>();
		NKNODBFDJMP.OPNDAKJODHA(CircleAreaRect);
		DOGLMPODLGL *= 10f;
		DOGLMPODLGL *= EJONJMEGEKJ.HJBIHDIGPKG().EMDFJAIPJMO;
		Vector2 sizeDelta = new Vector2(DOGLMPODLGL, DOGLMPODLGL);
		CircleAreaRect.sizeDelta = sizeDelta;
		CircleAreaRect.GetComponent<Image>().CrossFadeColor(FPONCFJJCOK, 1f, true, true);
		CircleAreaRect.gameObject.SetActive(true);
		return CircleAreaRect;
	}

	public void GGGKKDLCEHP()
	{
		CircleAreaRect.SetParent(base.transform);
		CircleAreaRect.gameObject.SetActive(false);
	}

	[DebuggerHidden]
	private IEnumerator PHOHALBOIAJ()
	{
		DDLPEDHEHPN dDLPEDHEHPN = new DDLPEDHEHPN();
		dDLPEDHEHPN.KPHCHDHEKGH = this;
		return dDLPEDHEHPN;
	}

	public void LHEADNLIAIG()
	{
		BJMMJCBPOPO.alpha = 1f;
	}

	public void MEKJFIOEDPI()
	{
		GNIHJGIJKLM = !GNIHJGIJKLM;
		Animator component = GetComponent<Animator>();
		if (GNIHJGIJKLM)
		{
			component.SetBool("Open", true);
		}
		else
		{
			component.SetBool("Open", false);
		}
	}

	public void NDCOHIJKLIP(float PDAKFGKELOC)
	{
		BHCHOIGLECH = PDAKFGKELOC;
		StartCoroutine(PHOHALBOIAJ());
	}
}
