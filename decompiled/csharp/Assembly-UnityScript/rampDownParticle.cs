using System;
using UnityEngine;

[Serializable]
public class rampDownParticle : MonoBehaviour
{
	public float delayTime;

	public float delayPlusTime;

	public float rampDownTime;

	public float origMinEmission;

	public float origMaxEmission;

	public rampDownParticle()
	{
		rampDownTime = 1f;
	}

	public virtual void Start()
	{
		origMinEmission = GetComponent<ParticleEmitter>().minEmission;
		origMaxEmission = GetComponent<ParticleEmitter>().maxEmission;
		GetComponent<ParticleEmitter>().emit = false;
	}

	public virtual void Update()
	{
		if (!(delayTime + delayPlusTime <= 0f))
		{
			delayTime -= Time.deltaTime;
		}
		if (!(delayTime > 0f) && !GetComponent<ParticleEmitter>().emit)
		{
			GetComponent<ParticleEmitter>().emit = true;
		}
		if (!(delayTime + delayPlusTime > 0f))
		{
			GetComponent<ParticleEmitter>().minEmission = origMinEmission * rampDownTime;
			GetComponent<ParticleEmitter>().maxEmission = origMaxEmission * rampDownTime;
			rampDownTime -= Time.deltaTime;
			if (!(rampDownTime >= 0f))
			{
				rampDownTime = 0f;
			}
		}
	}

	public virtual void Main()
	{
	}
}
