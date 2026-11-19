using System.Collections;
using SPD.EditorAttributes;
using UnityEngine;
using UnityEngine.UI;

public class DBDCHDJAEEF : MonoBehaviour
{
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
			CircleAreaRect.gameObject.SetActive(value: false);
		}
	}

	public void FHADFLKMLFL(bool FHAFNDJLBIP)
	{
		if (FHAFNDJLBIP)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		TargetGrapihc.sprite = MEEOMHDDGEK;
		Object.Destroy(base.gameObject, KGBFCKJLOFJ);
	}

	public void FHADFLKMLFL(bool FHAFNDJLBIP, Sprite NKNPENHJDND)
	{
		if (FHAFNDJLBIP)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		TargetGrapihc.sprite = NKNPENHJDND;
		Object.Destroy(base.gameObject, KGBFCKJLOFJ);
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
		CircleAreaRect.GetComponent<Image>().CrossFadeColor(FPONCFJJCOK, 1f, ignoreTimeScale: true, useAlpha: true);
		CircleAreaRect.gameObject.SetActive(value: true);
		return CircleAreaRect;
	}

	public void GGGKKDLCEHP()
	{
		CircleAreaRect.SetParent(base.transform);
		CircleAreaRect.gameObject.SetActive(value: false);
	}

	private IEnumerator PHOHALBOIAJ()
	{
		yield return new WaitForSeconds(BHCHOIGLECH);
		while (BJMMJCBPOPO.alpha < 1f)
		{
			BJMMJCBPOPO.alpha += Time.deltaTime * 2f;
			yield return null;
		}
		if (KLNNBKIOHDJ != null)
		{
			KLNNBKIOHDJ.enabled = true;
		}
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
			component.SetBool("Open", value: true);
		}
		else
		{
			component.SetBool("Open", value: false);
		}
	}

	public void NDCOHIJKLIP(float PDAKFGKELOC)
	{
		BHCHOIGLECH = PDAKFGKELOC;
		StartCoroutine(PHOHALBOIAJ());
	}
}
