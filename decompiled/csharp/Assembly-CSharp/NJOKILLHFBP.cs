using System.Collections;
using UnityEngine;

[AddComponentMenu("UI/Extensions/UI Tween Scale")]
public class NJOKILLHFBP : MonoBehaviour
{
	public AnimationCurve AEBBIMKOPOK;

	[Tooltip("Animation speed multiplier")]
	public float CKGJADEKNGE = 1f;

	[Tooltip("If true animation will loop, for best effect set animation curve to loop on start and end point")]
	public bool DGGBKBLCPNK;

	[Tooltip("If true animation will start automatically, otherwise you need to call Play() method to start the animation")]
	public bool FDEJBHLHJHH;

	[Header("Non uniform scale")]
	[Space(10f)]
	[Tooltip("If true component will scale by the same amount in X and Y axis, otherwise use animCurve for X scale and animCurveY for Y scale")]
	public bool KEEGOBCDPOI = true;

	public AnimationCurve BIDCHMPPKHI;

	private Vector3 EKFLJPLHLNN;

	private Transform CIEDFCKKEEO;

	private Vector3 NGOKDJDDJLK = Vector3.one;

	private void Awake()
	{
		CIEDFCKKEEO = GetComponent<Transform>();
		EKFLJPLHLNN = CIEDFCKKEEO.localScale;
		if (FDEJBHLHJHH)
		{
			HNMNCIIMJHN();
		}
	}

	public void HNMNCIIMJHN()
	{
		StartCoroutine("NLIPACMELFO");
	}

	private IEnumerator NLIPACMELFO()
	{
		CIEDFCKKEEO.localScale = EKFLJPLHLNN;
		float num = 0f;
		float time = AEBBIMKOPOK.keys[AEBBIMKOPOK.length - 1].time;
		while (num < time || DGGBKBLCPNK)
		{
			num += CKGJADEKNGE * Time.deltaTime;
			if (!KEEGOBCDPOI)
			{
				NGOKDJDDJLK.x = 1f * AEBBIMKOPOK.Evaluate(num);
				NGOKDJDDJLK.y = 1f * BIDCHMPPKHI.Evaluate(num);
				CIEDFCKKEEO.localScale = NGOKDJDDJLK;
			}
			else
			{
				CIEDFCKKEEO.localScale = Vector3.one * AEBBIMKOPOK.Evaluate(num);
			}
			yield return null;
		}
	}

	public void LOLFDGKDECO()
	{
		StopCoroutine("NLIPACMELFO");
		CIEDFCKKEEO.localScale = EKFLJPLHLNN;
	}
}
