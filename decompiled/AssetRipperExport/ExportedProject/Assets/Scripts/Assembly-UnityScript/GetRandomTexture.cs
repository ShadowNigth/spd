using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class GetRandomTexture : MonoBehaviour
{
	public Texture[] textures;

	public float rndNr;

	public virtual void Awake()
	{
		rndNr = Mathf.Ceil(UnityEngine.Random.value * (float)Extensions.get_length((System.Array)textures));
		rndNr -= 1f;
		GetComponent<Renderer>().material.mainTexture = textures[(int)rndNr];
	}

	public virtual void Update()
	{
	}

	public virtual void Main()
	{
	}
}
