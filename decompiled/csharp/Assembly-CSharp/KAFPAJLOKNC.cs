using UnityEngine;

public class KAFPAJLOKNC : MonoBehaviour
{
	public static void PGEAHMDMAFG(GameObject[] EGKJKMBGLFO, string ANMJMMNOLCP)
	{
		if (ANMJMMNOLCP == null || !(ANMJMMNOLCP == "progmesh"))
		{
			return;
		}
		for (int i = 0; i < EGKJKMBGLFO.Length; i++)
		{
			if (EGKJKMBGLFO[i].GetComponent<MeshFilter>().mesh != null)
			{
				Mesh mesh = EGKJKMBGLFO[i].GetComponent<MeshFilter>().mesh;
				string text = "_CM_" + mesh.name;
				if (mesh.vertices.Length > 255)
				{
					ONJJHGDKOMI oNJJHGDKOMI = new ONJJHGDKOMI();
					oNJJHGDKOMI.IHJKKKFFKMD(mesh);
					int num = Mathf.FloorToInt(255f + 4245f * ((float)oNJJHGDKOMI.FJCAJLGPADG / 65000f));
					if (num > oNJJHGDKOMI.FJCAJLGPADG)
					{
						num = oNJJHGDKOMI.FJCAJLGPADG;
					}
					oNJJHGDKOMI.PBIJGIGANCB(num);
					Mesh mesh2 = new Mesh();
					mesh2.vertices = oNJJHGDKOMI.NOLCOPNOPEF;
					mesh2.normals = oNJJHGDKOMI.MPNEKMFEGLD;
					mesh2.triangles = oNJJHGDKOMI.EKHEPCAKMGE;
					EGKJKMBGLFO[i].AddComponent<MeshCollider>();
					EGKJKMBGLFO[i].GetComponent<MeshCollider>().sharedMesh = mesh2;
					EGKJKMBGLFO[i].GetComponent<MeshCollider>().sharedMesh.name = text;
				}
				else
				{
					EGKJKMBGLFO[i].AddComponent<MeshCollider>();
					EGKJKMBGLFO[i].GetComponent<MeshCollider>().sharedMesh = EGKJKMBGLFO[i].GetComponent<MeshFilter>().mesh;
				}
			}
			else
			{
				Debug.Log("Transform Only :" + EGKJKMBGLFO[i].name);
			}
		}
	}
}
