using UnityEngine;

public class LPCOCGPLLGL : MonoBehaviour
{
	public BKDJCOINCLD BNMMJCKJLBF;

	private void Awake()
	{
		BNMMJCKJLBF = GetComponent<BKDJCOINCLD>();
	}

	private void OnEnable()
	{
		BNMMJCKJLBF.MMKEKOFHHNF.AddListener(PEKLGCCBHOH);
	}

	private void OnDisable()
	{
		BNMMJCKJLBF.MMKEKOFHHNF.RemoveListener(PEKLGCCBHOH);
	}

	private void PEKLGCCBHOH(string MKOJMDEGGLB)
	{
		Debug.Log("Click on the " + MKOJMDEGGLB);
	}
}
