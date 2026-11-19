using System;
using UnityEngine;

[Serializable]
public class Raycast : MonoBehaviour
{
	public GameObject moveThis;

	public RaycastHit hit;

	public GameObject[] createThis;

	public GameObject explosion;

	public float cooldown;

	public float changeCooldown;

	public int selected;

	public GUIText writeThis;

	public virtual void Start()
	{
		writeThis.text = selected.ToString();
	}

	public virtual void Update()
	{
		if (!(cooldown <= 0f))
		{
			cooldown -= Time.deltaTime;
		}
		if (!(changeCooldown <= 0f))
		{
			changeCooldown -= Time.deltaTime;
		}
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit))
		{
			moveThis.transform.position = hit.point;
			if (Input.GetMouseButton(0) && !(cooldown > 0f))
			{
				UnityEngine.Object.Instantiate(createThis[0], moveThis.transform.position, moveThis.transform.rotation);
				UnityEngine.Object.Instantiate(explosion, moveThis.transform.position, moveThis.transform.rotation);
				cooldown = 0.05f;
			}
		}
	}

	public virtual void Main()
	{
	}
}
