using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class ZombieCreator : MonoBehaviour
{
	public float CD;

	public GameObject[] createThis;

	public float rndNr;

	public ZombieCreator()
	{
		CD = 1f;
	}

	public virtual void Update()
	{
		CD -= Time.deltaTime;
		if (!(CD >= 0f))
		{
			rndNr = Mathf.Ceil(UnityEngine.Random.value * (float)Extensions.get_length((System.Array)createThis));
			rndNr -= 1f;
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z), transform.rotation);
			CD = 0.2f;
		}
		if (Input.GetKeyDown("space"))
		{
			rndNr = Mathf.Ceil(UnityEngine.Random.value * (float)Extensions.get_length((System.Array)createThis));
			rndNr -= 1f;
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
			UnityEngine.Object.Instantiate(createThis[(int)rndNr], new Vector3(transform.position.x - 5f + UnityEngine.Random.value * 10f, transform.position.y, transform.position.z + UnityEngine.Random.value * 13f), transform.rotation);
		}
	}

	public virtual void Main()
	{
	}
}
