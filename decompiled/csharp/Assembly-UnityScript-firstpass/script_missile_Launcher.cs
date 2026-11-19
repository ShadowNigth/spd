using System;
using UnityEngine;

[Serializable]
public class script_missile_Launcher : MonoBehaviour
{
	public GameObject projectile;

	public int fireRate;

	private float nextFire;

	public script_missile_Launcher()
	{
		fireRate = 2;
	}

	public virtual void Update()
	{
		if (!(Time.time <= nextFire))
		{
			nextFire = Time.time + (float)fireRate;
			GameObject gameObject = UnityEngine.Object.Instantiate(projectile, transform.position, transform.rotation);
		}
	}

	public virtual void Main()
	{
	}
}
