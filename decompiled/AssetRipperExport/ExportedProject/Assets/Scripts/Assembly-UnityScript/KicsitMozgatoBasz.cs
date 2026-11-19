using System;
using UnityEngine;

[Serializable]
public class KicsitMozgatoBasz : MonoBehaviour
{
	public float curX;

	public float curZ;

	public virtual void Start()
	{
		curX = transform.position.x;
		curZ = transform.position.z;
	}

	public virtual void Update()
	{
		transform.Translate(0.01f * Time.deltaTime, 0f, 0.01f * Time.deltaTime);
		if (!(transform.position.x <= curX + 0.01f))
		{
			float x = curX;
			Vector3 position = transform.position;
			float num = (position.x = x);
			Vector3 vector = (transform.position = position);
		}
		if (!(transform.position.z <= curZ + 0.007f))
		{
			float z = curZ;
			Vector3 position2 = transform.position;
			float num2 = (position2.z = z);
			Vector3 vector3 = (transform.position = position2);
		}
	}

	public virtual void Main()
	{
	}
}
