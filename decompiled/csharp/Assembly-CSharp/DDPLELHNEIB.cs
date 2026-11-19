using UnityEngine;
using UnityEngine.UI;

public class DDPLELHNEIB : MonoBehaviour
{
	public KFANEHLIPBI MBFJEBHOFCC;

	public GameObject[] MKGHIDDLMKA;

	public Image CNKOIOHMBMA;

	private void Awake()
	{
		MBFJEBHOFCC.DNMFLMKBGAP.AddListener(JKPBFDAAKFK);
	}

	public void HABEPIPLKNN()
	{
		for (int i = 0; i < MKGHIDDLMKA.Length; i++)
		{
			if (!MKGHIDDLMKA[i].activeSelf)
			{
				MKGHIDDLMKA[i].SetActive(value: true);
				MKGHIDDLMKA[i].GetComponent<Image>().color = MBFJEBHOFCC.MHGKIBFILBG;
				break;
			}
		}
	}

	public void PDLICAFOCLB(Image PHLFGFHJMIK)
	{
		MBFJEBHOFCC.MHGKIBFILBG = PHLFGFHJMIK.color;
	}

	private void JKPBFDAAKFK(Color JPLPPELPDKF)
	{
		CNKOIOHMBMA.color = JPLPPELPDKF;
	}
}
