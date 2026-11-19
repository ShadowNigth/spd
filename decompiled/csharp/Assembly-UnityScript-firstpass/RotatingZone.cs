using System;
using UnityEngine;

[Serializable]
public class RotatingZone : MonoBehaviour
{
	public float rotationSpeed;

	public RotatingZone()
	{
		rotationSpeed = 1f;
	}

	public virtual void Update()
	{
		transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
	}

	public virtual void Main()
	{
	}
}
