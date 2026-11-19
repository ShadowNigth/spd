using UnityEngine;
using UnityEngine.UI;

public class LDPEDMIGKKA : global::JOJJJIAJEAE<OMILCNOPMOF, DGNFCJPFDPD>
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Text message;

	[SerializeField]
	private Image image;

	[SerializeField]
	private Button button;

	private readonly int ACDEAMPEBOL = Animator.StringToHash("scroll");

	private DGNFCJPFDPD KPFOIKPELPI;

	private void Start()
	{
		RectTransform rectTransform = base.transform as RectTransform;
		rectTransform.anchorMax = Vector2.one;
		rectTransform.anchorMin = Vector2.zero;
		rectTransform.anchoredPosition3D = Vector3.zero;
		DBFCKHHDNAN(0f);
		button.onClick.AddListener(PBOMPMFNHNA);
	}

	public override void AJJGGENLDKG(DGNFCJPFDPD KPFOIKPELPI)
	{
		this.KPFOIKPELPI = KPFOIKPELPI;
	}

	public override void NILHMMADIDH(OMILCNOPMOF CDFFHMDOEEO)
	{
		message.text = CDFFHMDOEEO.BPBHMHNBHJB;
		if (KPFOIKPELPI != null)
		{
			bool flag = KPFOIKPELPI.FGCFLEDFONL == base.PGLLGABGMCO;
			image.color = ((!flag) ? new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 77) : new Color32(0, byte.MaxValue, byte.MaxValue, 100));
		}
	}

	public override void DBFCKHHDNAN(float GIDEOJGAFJH)
	{
		animator.Play(ACDEAMPEBOL, -1, GIDEOJGAFJH);
		animator.speed = 0f;
	}

	public void PBOMPMFNHNA()
	{
		if (KPFOIKPELPI != null)
		{
			KPFOIKPELPI.PBOMPMFNHNA(this);
		}
	}
}
