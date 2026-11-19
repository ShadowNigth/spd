using UnityEngine;

[RequireComponent(typeof(FLEACMFGOMO))]
public class OEFDOEGPPDO : MonoBehaviour
{
	public MMNLCPKOLKO JONKJCJGLCO;

	private FLEACMFGOMO LOJADNBCFGA;

	private void Start()
	{
		if (JONKJCJGLCO == null)
		{
			Debug.LogError("Missing Cooldown Button assignment");
		}
		LOJADNBCFGA = GetComponent<FLEACMFGOMO>();
	}

	private void Update()
	{
		LOJADNBCFGA.DAAGIBKFPHK = Mathf.Lerp(0f, 1f, JONKJCJGLCO.IACAAOGEIHG / JONKJCJGLCO.PNEFNPOGFCD);
	}
}
