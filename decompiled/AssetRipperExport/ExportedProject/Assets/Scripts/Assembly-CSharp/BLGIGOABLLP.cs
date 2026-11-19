using UnityEngine;

public class BLGIGOABLLP : MonoBehaviour
{
	private ONJJHGDKOMI LGEPGJALHOO;

	private Mesh FAHIHINKFMC;

	private float BGICDOEPGHL = 100f;

	private float AINMNNENBAP = 100f;

	private MeshFilter DJAAGAGDKJF;

	private Mesh IMCHAODCJCB;

	public GUISkin ELENLNLJDMA;

	private int AMGHFNGLHGD = 350;

	private int ALHLPADAOBL = 150;

	private int NCGCOGPPFEC = 100;

	private int OCJEOAOODGM = 100;

	private Rect BKHAKMENDDB;

	private bool EDJJHINEFKJ;

	private void HIBHJDCMMAJ()
	{
		AINMNNENBAP = BGICDOEPGHL;
		LGEPGJALHOO = new ONJJHGDKOMI();
		FAHIHINKFMC = GetComponent<MeshFilter>().mesh;
		LGEPGJALHOO.IHJKKKFFKMD(FAHIHINKFMC);
	}

	public void PBIJGIGANCB()
	{
		LGEPGJALHOO.PBIJGIGANCB(BGICDOEPGHL);
		FAHIHINKFMC.Clear();
		FAHIHINKFMC.vertices = LGEPGJALHOO.NOLCOPNOPEF;
		FAHIHINKFMC.normals = LGEPGJALHOO.MPNEKMFEGLD;
		FAHIHINKFMC.triangles = LGEPGJALHOO.EKHEPCAKMGE;
		GetComponent<MeshFilter>().mesh = FAHIHINKFMC;
	}

	private void Start()
	{
		BKHAKMENDDB = new Rect(NCGCOGPPFEC, OCJEOAOODGM, AMGHFNGLHGD, ALHLPADAOBL);
		HIBHJDCMMAJ();
	}

	private void Update()
	{
		if (LGEPGJALHOO.LJLJPFKCHAG && !LGEPGJALHOO.CDCPNKLKODO && EDJJHINEFKJ)
		{
			PBIJGIGANCB();
			EDJJHINEFKJ = false;
		}
	}

	private void OnGUI()
	{
		BKHAKMENDDB = GUI.Window(0, BKHAKMENDDB, HIIPAANNEKC, string.Empty);
	}

	private void HIIPAANNEKC(int GNLGFNFHMPI)
	{
		GUILayout.BeginArea(new Rect(10f, 10f, AMGHFNGLHGD - 20, ALHLPADAOBL - 20));
		GUI.Label(new Rect(0f, 0f, 200f, 25f), LGEPGJALHOO.FAAHIHCIFEM.ToString());
		if (!LGEPGJALHOO.CDCPNKLKODO)
		{
			BGICDOEPGHL = GUI.HorizontalSlider(new Rect(50f, 15f, 300f, 45f), BGICDOEPGHL, 0f, 100f);
			if (AINMNNENBAP != BGICDOEPGHL)
			{
				AINMNNENBAP = BGICDOEPGHL;
				EDJJHINEFKJ = true;
			}
		}
		if (GUI.Button(new Rect(0f, 60f, 100f, 40f), "Add Collider"))
		{
			base.transform.gameObject.AddComponent<MeshCollider>();
			GetComponent<MeshCollider>().sharedMesh = GetComponent<MeshFilter>().mesh;
		}
		GUILayout.EndArea();
		GUI.DragWindow();
	}
}
