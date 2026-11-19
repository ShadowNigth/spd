using UnityEngine;
using UnityEngine.UI;

public class BCJDBOOCJIA : global::HCFGEDOCPHD<EMFOGONPNBJ>
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Text message;

	private readonly int ACDEAMPEBOL = Animator.StringToHash("scroll");

	private void Start()
	{
		RectTransform rectTransform = base.transform as RectTransform;
		rectTransform.anchorMax = Vector2.one;
		rectTransform.anchorMin = Vector2.zero;
		rectTransform.anchoredPosition3D = Vector3.zero;
		DBFCKHHDNAN(0f);
	}

	public override void NILHMMADIDH(EMFOGONPNBJ CDFFHMDOEEO)
	{
		message.text = CDFFHMDOEEO.BPBHMHNBHJB;
	}

	public override void DBFCKHHDNAN(float GIDEOJGAFJH)
	{
		animator.Play(ACDEAMPEBOL, -1, GIDEOJGAFJH);
		animator.speed = 0f;
	}
}
