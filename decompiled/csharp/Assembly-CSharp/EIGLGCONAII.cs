using UnityEngine;

public class EIGLGCONAII : MonoBehaviour
{
	public AudioClip[] HLJNGODBOBO;

	private void Start()
	{
		if (!GetComponent<AudioSource>().playOnAwake)
		{
			GetComponent<AudioSource>().clip = HLJNGODBOBO[Random.Range(0, HLJNGODBOBO.Length)];
			GetComponent<AudioSource>().Play();
		}
	}

	private void Update()
	{
		if (!GetComponent<AudioSource>().isPlaying)
		{
			GetComponent<AudioSource>().clip = HLJNGODBOBO[Random.Range(0, HLJNGODBOBO.Length)];
			GetComponent<AudioSource>().Play();
		}
	}
}
