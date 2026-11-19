using System;
using UnityEngine;

[Serializable]
public class Script_missile : MonoBehaviour
{
	public float timeKill;

	private float randomSpeed;

	public virtual void Start()
	{
		transform.eulerAngles = new Vector3(0f, 180f, 0f);
		timeKill = Time.time;
		randomSpeed = UnityEngine.Random.Range(7f, 9f);
	}

	public virtual void Update()
	{
		float x = Time.deltaTime * randomSpeed;
		transform.Translate(x, 0f, 0f);
		if (!(Time.time <= timeKill + 6f))
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
