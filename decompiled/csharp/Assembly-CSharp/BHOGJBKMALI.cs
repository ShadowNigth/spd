using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class BHOGJBKMALI : MonoBehaviour
{
	public MMNLCPKOLKO JONKJCJGLCO;

	public Text LGOAOBLIFBP;

	private Image EPCKLAKNAAG;

	private string KAEBNFNELAG;

	private void Start()
	{
		if (JONKJCJGLCO == null)
		{
			Debug.LogError("Missing Cooldown Button assignment");
		}
		EPCKLAKNAAG = GetComponent<Image>();
	}

	private void Update()
	{
		EPCKLAKNAAG.fillAmount = Mathf.Lerp(0f, 1f, JONKJCJGLCO.PDDDJCELIGC / JONKJCJGLCO.PNEFNPOGFCD);
		if ((bool)LGOAOBLIFBP)
		{
			LGOAOBLIFBP.text = $"{JONKJCJGLCO.PFBPBIOOPMP}%";
		}
	}

	private void OnDisable()
	{
		if ((bool)LGOAOBLIFBP)
		{
			LGOAOBLIFBP.text = KAEBNFNELAG;
		}
	}

	private void OnEnable()
	{
		if ((bool)LGOAOBLIFBP)
		{
			KAEBNFNELAG = LGOAOBLIFBP.text;
		}
	}
}
