using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KMNINECIIKM : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class FNOEJCFILOH
	{
		internal string IFNKGJDHGDD;

		internal bool BEKJDJFLJJC(GameObject AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.name == IFNKGJDHGDD;
		}
	}

	public Dropdown AMDBHPGJCJO;

	public Button GHHFCGPNOAA;

	public Button CHMNJNGCHGP;

	public Text COPCCANPDDI;

	public GameObject[] LJPGKKLOMKK;

	private readonly List<GameObject> OMAJMPINJLF = new List<GameObject>();

	private void Start()
	{
		PEBGMALNDLP(0.0);
	}

	private void HEJFNEBFBIO()
	{
		NGANNJFFIMG.FANNHPHFKJH();
		foreach (GameObject item in OMAJMPINJLF)
		{
			UnityEngine.Object.Destroy(item);
		}
		OMAJMPINJLF.Clear();
	}

	private void PEBGMALNDLP(double BOCNMCNAFIE)
	{
		COPCCANPDDI.text = "Time: " + BOCNMCNAFIE.ToString("0.00") + "ms" + Environment.NewLine + (NGANNJFFIMG.CPHDIDCBCLG + OMAJMPINJLF.Count) + " active." + Environment.NewLine + NGANNJFFIMG.JCIJINDMJAI + " cached. Instantiate count: " + HBLBGJPOHJI.NNIGHCEILNN + ", Spawn count: " + HBLBGJPOHJI.GPHCOEFOKEF + ", Return to pool count: " + HBLBGJPOHJI.GEFDEMFBBOK;
	}

	public GameObject PLDPIBGADEN(GameObject MDONKBLCDIP, Vector3 EGDGHLINBKN, Quaternion LKADJBDJNNF, Transform DJHGJAGNNLH = null)
	{
		GameObject gameObject = NGANNJFFIMG.OHGENNNIPJH(MDONKBLCDIP.name);
		if (gameObject == null)
		{
			NGANNJFFIMG.KMOLNKBLGDC(MDONKBLCDIP.name, MDONKBLCDIP);
			gameObject = NGANNJFFIMG.OHGENNNIPJH(MDONKBLCDIP.name);
			if (gameObject == null)
			{
				UnityEngine.Debug.LogErrorFormat("Unable to find object for key: {0}", MDONKBLCDIP.name);
				return null;
			}
		}
		if (DJHGJAGNNLH != null)
		{
			gameObject.transform.parent = DJHGJAGNNLH;
			gameObject.transform.localPosition = EGDGHLINBKN;
		}
		else
		{
			gameObject.transform.position = EGDGHLINBKN;
			gameObject.transform.rotation = LKADJBDJNNF;
		}
		return gameObject;
	}

	public GameObject PLDPIBGADEN(string IFNKGJDHGDD, Vector3 EGDGHLINBKN, Quaternion LKADJBDJNNF, Transform DJHGJAGNNLH = null)
	{
		GameObject gameObject = NGANNJFFIMG.OHGENNNIPJH(IFNKGJDHGDD);
		if (gameObject == null)
		{
			NGANNJFFIMG.KMOLNKBLGDC(IFNKGJDHGDD, LJPGKKLOMKK.Where((GameObject AEMBPMJMOAB) => AEMBPMJMOAB.name == IFNKGJDHGDD).First());
			gameObject = NGANNJFFIMG.OHGENNNIPJH(IFNKGJDHGDD);
			if (gameObject == null)
			{
				UnityEngine.Debug.LogErrorFormat("Unable to find object for key: {0}", IFNKGJDHGDD);
				return null;
			}
		}
		if (DJHGJAGNNLH != null)
		{
			gameObject.transform.parent = DJHGJAGNNLH;
			gameObject.transform.localPosition = EGDGHLINBKN;
		}
		else
		{
			gameObject.transform.position = EGDGHLINBKN;
			gameObject.transform.rotation = LKADJBDJNNF;
		}
		return gameObject;
	}

	public void EPNPELPOCDD()
	{
		HEJFNEBFBIO();
		string text = AMDBHPGJCJO.options[AMDBHPGJCJO.value].text;
		Stopwatch stopwatch = Stopwatch.StartNew();
		for (int i = 0; i < 1000; i++)
		{
			GameObject gameObject = PLDPIBGADEN(text, Vector3.zero, Quaternion.identity);
			Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
			gameObject.transform.position = onUnitSphere * UnityEngine.Random.Range(-5f, 5f);
			gameObject.transform.rotation = UnityEngine.Random.rotation;
		}
		stopwatch.Stop();
		PEBGMALNDLP(stopwatch.Elapsed.TotalMilliseconds);
	}

	public void BHAEBAAGLKP()
	{
		HEJFNEBFBIO();
		GameObject original = LJPGKKLOMKK[AMDBHPGJCJO.value];
		Stopwatch stopwatch = Stopwatch.StartNew();
		for (int i = 0; i < 1000; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(original);
			gameObject.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
			Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
			gameObject.transform.position = onUnitSphere * UnityEngine.Random.Range(-5f, 5f);
			gameObject.transform.rotation = UnityEngine.Random.rotation;
			OMAJMPINJLF.Add(gameObject);
		}
		stopwatch.Stop();
		PEBGMALNDLP(stopwatch.Elapsed.TotalMilliseconds);
	}

	public void OPLFNJFBHME()
	{
		SceneManager.LoadScene(0, LoadSceneMode.Single);
		HBLBGJPOHJI.NNIGHCEILNN = (HBLBGJPOHJI.GPHCOEFOKEF = (HBLBGJPOHJI.GEFDEMFBBOK = 0));
	}
}
