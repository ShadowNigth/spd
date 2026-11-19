using System;
using UnityEngine;

[Serializable]
public class LookatTarget : MonoBehaviour
{
	public GameObject lookatTarget;

	public virtual void Update()
	{
		transform.LookAt(lookatTarget.transform);
	}

	public virtual void Main()
	{
	}
}
