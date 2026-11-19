using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class PPLFOAOJIDC : MonoBehaviour
{
	public KFANEHLIPBI MBFJEBHOFCC;

	private Image GBCLDBHACGH;

	private void Awake()
	{
		GBCLDBHACGH = GetComponent<Image>();
		MBFJEBHOFCC.DNMFLMKBGAP.AddListener(JKPBFDAAKFK);
	}

	private void OnDestroy()
	{
		MBFJEBHOFCC.DNMFLMKBGAP.RemoveListener(JKPBFDAAKFK);
	}

	private void JKPBFDAAKFK(Color GNKGIKCFKMF)
	{
		GBCLDBHACGH.color = GNKGIKCFKMF;
	}
}
