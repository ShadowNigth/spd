using System.Collections;
using UnityEngine;

public static class LMFPHFMDKDK
{
	public static void OCMFKPOIEJK(this AudioSource AEMBPMJMOAB, float PJBGGDBFEEP)
	{
		AEMBPMJMOAB.GetComponent<MonoBehaviour>().StartCoroutine(EIJJHDICGLL(AEMBPMJMOAB, PJBGGDBFEEP));
	}

	private static IEnumerator EIJJHDICGLL(AudioSource AEMBPMJMOAB, float PJBGGDBFEEP)
	{
		float volume = AEMBPMJMOAB.volume;
		while (AEMBPMJMOAB.volume > 0f)
		{
			AEMBPMJMOAB.volume -= volume * Time.deltaTime / PJBGGDBFEEP;
			yield return new WaitForEndOfFrame();
		}
		AEMBPMJMOAB.Stop();
		AEMBPMJMOAB.volume = volume;
	}
}
