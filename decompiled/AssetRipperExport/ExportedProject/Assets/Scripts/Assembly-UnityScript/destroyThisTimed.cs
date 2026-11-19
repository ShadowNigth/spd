using System;
using UnityEngine;

[Serializable]
public class destroyThisTimed : MonoBehaviour
{
	public float destroyTime;

	public destroyThisTimed()
	{
		destroyTime = 5f;
	}

	public virtual void Start()
	{
		UnityEngine.Object.Destroy(gameObject, destroyTime);
	}

	public virtual void Update()
	{
	}

	public virtual void Main()
	{
	}
}
