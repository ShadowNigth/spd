using UnityEngine;

[AddComponentMenu("UI/Extensions/VR Cursor")]
public class HGDLLBHKFEI : MonoBehaviour
{
	public float AKEBEBCKJLG;

	public float PECDKDFBNKO;

	private Collider APAKBPDLPFP;

	private void Update()
	{
		Vector3 position = default(Vector3);
		position.x = UnityEngine.Input.mousePosition.x * AKEBEBCKJLG;
		position.y = UnityEngine.Input.mousePosition.y * PECDKDFBNKO - 1f;
		position.z = base.transform.position.z;
		base.transform.position = position;
		ECKMHBPIDMM.PGHLNJBACEK = base.transform.position;
		if (UnityEngine.Input.GetMouseButtonDown(0) && (bool)APAKBPDLPFP)
		{
			ECKMHBPIDMM.ODKIDIIMGAE(APAKBPDLPFP.gameObject);
		}
	}

	private void OnTriggerEnter(Collider OBKENFAPMCF)
	{
		ECKMHBPIDMM.FPGALCJDMFC(OBKENFAPMCF.gameObject);
		APAKBPDLPFP = OBKENFAPMCF;
	}

	private void OnTriggerExit(Collider OBKENFAPMCF)
	{
		ECKMHBPIDMM.ILFNPKMFCOJ(OBKENFAPMCF.gameObject);
		APAKBPDLPFP = null;
	}
}
