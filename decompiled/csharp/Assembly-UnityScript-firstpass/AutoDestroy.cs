using System;
using UnityEngine;

[Serializable]
public class AutoDestroy : MonoBehaviour
{
	public float time;

	public virtual void Update()
	{
		time -= Time.deltaTime;
		if (!(time >= 0f))
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}
}
