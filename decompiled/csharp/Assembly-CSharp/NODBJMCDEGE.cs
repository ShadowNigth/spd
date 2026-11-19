using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[AddComponentMenu("UI/Extensions/Selectable Scalar")]
public class NODBJMCDEGE : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	public AnimationCurve AEBBIMKOPOK;

	[Tooltip("Animation speed multiplier")]
	public float CKGJADEKNGE = 1f;

	private Vector3 EKFLJPLHLNN;

	public Transform EPCKLAKNAAG;

	private Selectable DCJIIFODKFE;

	public Selectable JBLHHCNLIAJ
	{
		get
		{
			if (DCJIIFODKFE == null)
			{
				DCJIIFODKFE = GetComponent<Selectable>();
			}
			return DCJIIFODKFE;
		}
	}

	private void Awake()
	{
		if (EPCKLAKNAAG == null)
		{
			EPCKLAKNAAG = base.transform;
		}
		EKFLJPLHLNN = EPCKLAKNAAG.localScale;
	}

	private void OnEnable()
	{
		EPCKLAKNAAG.localScale = EKFLJPLHLNN;
	}

	public void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		if (!(JBLHHCNLIAJ != null) || JBLHHCNLIAJ.interactable)
		{
			StopCoroutine("OAHEKJONADE");
			StartCoroutine("CMJPAEFNJDD");
		}
	}

	public void OnPointerUp(PointerEventData GBOFEMOALII)
	{
		if (!(JBLHHCNLIAJ != null) || JBLHHCNLIAJ.interactable)
		{
			StopCoroutine("CMJPAEFNJDD");
			StartCoroutine("OAHEKJONADE");
		}
	}

	private IEnumerator CMJPAEFNJDD()
	{
		if (AEBBIMKOPOK.keys.Length > 0)
		{
			EPCKLAKNAAG.localScale = EKFLJPLHLNN;
			float num = 0f;
			float time = AEBBIMKOPOK.keys[AEBBIMKOPOK.length - 1].time;
			while (num < time)
			{
				num += CKGJADEKNGE * Time.unscaledDeltaTime;
				EPCKLAKNAAG.localScale = Vector3.one * AEBBIMKOPOK.Evaluate(num);
				yield return null;
			}
		}
	}

	private IEnumerator OAHEKJONADE()
	{
		if (AEBBIMKOPOK.keys.Length > 0)
		{
			float num = 0f;
			float time = AEBBIMKOPOK.keys[AEBBIMKOPOK.length - 1].time;
			while (num < time)
			{
				num += CKGJADEKNGE * Time.unscaledDeltaTime;
				EPCKLAKNAAG.localScale = Vector3.one * AEBBIMKOPOK.Evaluate(time - num);
				yield return null;
			}
			base.transform.localScale = EKFLJPLHLNN;
		}
	}
}
