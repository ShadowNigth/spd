using UnityEngine;

public class EJDKALEIBBG : FOGIOGKLNIP
{
	public int MKBNKANDCDB;

	public int CMPKOEMBHDO;

	public int MGFENAGABOE;

	public string JJHIFNAJIBK;

	public int FPNFMBGAFDE;

	public bool DECONHBIJAA;

	public GameObject CHOGGEDPGIE;

	public int PLDMNFCBFDD;

	public float KMLPDIHOPNC;

	public float JPBAFJFNCDO;

	private Vector3 IAFIDJLHGLC;

	public Rigidbody KCBGABFLFCL;

	public MeshFilter MLENJBJHECL;

	public MeshRenderer CFPLIEMIEOD;

	public MeshCollider KKBFMBENBGF;

	public MeshFilter POMDDJECBJA;

	public MeshRenderer HNHAAIICGHO;

	internal bool AHBGGKFEHBF;

	public void Start()
	{
		KMLPDIHOPNC = Time.time;
		if (CHOGGEDPGIE != null)
		{
			CHOGGEDPGIE.SetActive(DECONHBIJAA);
		}
	}

	private void OnCollisionStay()
	{
		AHBGGKFEHBF = true;
	}

	private void OnCollisionExit()
	{
		AHBGGKFEHBF = false;
	}

	private void Update()
	{
		if (AHBGGKFEHBF)
		{
			if (JPBAFJFNCDO < 3f)
			{
				if (KCBGABFLFCL.velocity.magnitude <= 0f && KCBGABFLFCL != null)
				{
					JPBAFJFNCDO += Time.deltaTime;
				}
			}
			else
			{
				Object.DestroyImmediate(KCBGABFLFCL);
				base.enabled = false;
			}
		}
		else
		{
			JPBAFJFNCDO = 0f;
		}
	}

	public void BCKOICGHJJJ(bool JFLFLCDEEEI)
	{
		DECONHBIJAA = JFLFLCDEEEI;
		CHOGGEDPGIE.SetActive(JFLFLCDEEEI);
	}
}
