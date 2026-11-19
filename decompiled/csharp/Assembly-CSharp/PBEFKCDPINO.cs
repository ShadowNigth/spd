using UnityEngine;

public class PBEFKCDPINO : MonoBehaviour
{
	private void Start()
	{
		Object.Destroy(base.gameObject, 6f);
	}

	private void Update()
	{
		base.transform.Translate(0f, 0f, 100f * Time.deltaTime);
	}
}
