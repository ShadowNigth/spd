using UnityEngine;
using UnityEngine.UI;

public class MPEBFNENKNL : MonoBehaviour
{
	public Text LKBIFFOHJMI;

	public GameObject ENKNJFAFCKI;

	public Text BHJDPNBAFDL;

	public void EIJHBJMINJA(GameObject[] DHAHGNFFJFF)
	{
		foreach (GameObject original in DHAHGNFFJFF)
		{
			GameObject gameObject = Object.Instantiate(original, ENKNJFAFCKI.transform.position, ENKNJFAFCKI.transform.rotation);
			gameObject.transform.SetParent(ENKNJFAFCKI.transform);
		}
	}

	public void CACKNFCCFME(GameObject FNEFPKDFDAP)
	{
		GameObject gameObject = Object.Instantiate(FNEFPKDFDAP, ENKNJFAFCKI.transform.position, ENKNJFAFCKI.transform.rotation);
		gameObject.transform.SetParent(ENKNJFAFCKI.transform);
	}
}
