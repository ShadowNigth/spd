using UnityEngine;

public class KOKIAHKJOGP
{
	public CPIIHEGALLE BEAGCEMBJEA;

	public Transform BGJOMCIIFAK;

	private Vector3 JJCCMCJHONB;

	private Quaternion FAJOFJFFDOK;

	private Component[] EOBAGPOICKH;

	private bool[] CICINBNDOIE;

	internal bool PFKIHJCAFJH;

	public void KIJMAEJNGPI()
	{
		if (!PFKIHJCAFJH)
		{
			BGJOMCIIFAK.gameObject.SetActive(value: false);
			return;
		}
		EOBAGPOICKH = BGJOMCIIFAK.GetComponentsInChildren<Component>();
		CICINBNDOIE = new bool[EOBAGPOICKH.Length];
		for (int i = 0; i < EOBAGPOICKH.Length; i++)
		{
			Renderer renderer = EOBAGPOICKH[i] as Renderer;
			if (renderer != null)
			{
				CICINBNDOIE[i] = renderer.enabled;
				renderer.enabled = false;
			}
			Collider collider = EOBAGPOICKH[i] as Collider;
			if (collider != null)
			{
				CICINBNDOIE[i] = collider.enabled;
				collider.enabled = false;
			}
			Behaviour behaviour = EOBAGPOICKH[i] as Behaviour;
			if (behaviour != null)
			{
				CICINBNDOIE[i] = behaviour.enabled;
				behaviour.enabled = false;
			}
			Rigidbody rigidbody = EOBAGPOICKH[i] as Rigidbody;
			if (rigidbody != null)
			{
				CICINBNDOIE[i] = rigidbody.isKinematic;
				rigidbody.isKinematic = true;
			}
		}
	}

	public void JOBLKDDBHEF()
	{
		if (!PFKIHJCAFJH)
		{
			BGJOMCIIFAK.gameObject.SetActive(value: true);
			Animation[] componentsInChildren = BGJOMCIIFAK.GetComponentsInChildren<Animation>();
			foreach (Animation animation in componentsInChildren)
			{
				animation.Rewind();
			}
			return;
		}
		for (int j = 0; j < EOBAGPOICKH.Length; j++)
		{
			Collider collider = EOBAGPOICKH[j] as Collider;
			if (collider != null)
			{
				collider.enabled = CICINBNDOIE[j];
			}
			Renderer renderer = EOBAGPOICKH[j] as Renderer;
			if (renderer != null)
			{
				renderer.enabled = CICINBNDOIE[j];
			}
			Behaviour behaviour = EOBAGPOICKH[j] as Behaviour;
			if (behaviour != null)
			{
				behaviour.enabled = CICINBNDOIE[j];
			}
			Rigidbody rigidbody = EOBAGPOICKH[j] as Rigidbody;
			if (rigidbody != null)
			{
				rigidbody.isKinematic = CICINBNDOIE[j];
			}
		}
	}
}
