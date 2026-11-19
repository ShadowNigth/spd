using System;
using UnityEngine;

[Serializable]
public class FadeLight : MonoBehaviour
{
	public float delay;

	public float fadeTime;

	private float fadeSpeed;

	private float intensity;

	private Color color;

	public virtual void Start()
	{
		if (GetComponent<Light>() == null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		intensity = GetComponent<Light>().intensity;
		fadeTime = Mathf.Abs(fadeTime);
		if (!(fadeTime <= 0f))
		{
			fadeSpeed = intensity / fadeTime;
		}
		else
		{
			fadeSpeed = intensity;
		}
	}

	public virtual void Update()
	{
		if (!(delay <= 0f))
		{
			delay -= Time.deltaTime;
		}
		else if (!(intensity <= 0f))
		{
			intensity -= fadeSpeed * Time.deltaTime;
			GetComponent<Light>().intensity = intensity;
		}
	}
}
