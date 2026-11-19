using System.Collections.Generic;
using UnityEngine;

public static class NGANNJFFIMG
{
	private static readonly Dictionary<string, GameObject> PBKLEEAHIOI = new Dictionary<string, GameObject>();

	private static readonly Dictionary<GameObject, string> EIPCPCJNMEB = new Dictionary<GameObject, string>();

	private static readonly Dictionary<string, List<GameObject>> FIAGBBAIHEO = new Dictionary<string, List<GameObject>>();

	private static readonly Dictionary<string, List<GameObject>> MPKIKAIHJCM = new Dictionary<string, List<GameObject>>();

	private static readonly Dictionary<GameObject, LGDNCMAHFPA> BEJKEECJHDM = new Dictionary<GameObject, LGDNCMAHFPA>();

	private static int IPDDKMGLFFE;

	public static HideFlags LGDPJOIPACJ = HideFlags.HideInHierarchy | HideFlags.HideInInspector;

	public static int JCIJINDMJAI => IPDDKMGLFFE;

	public static int CPHDIDCBCLG => EIPCPCJNMEB.Count;

	private static List<GameObject> BKPJDINIOHB(string JPBEBBODCJJ)
	{
		if (!FIAGBBAIHEO.TryGetValue(JPBEBBODCJJ, out var value))
		{
			value = new List<GameObject>();
			FIAGBBAIHEO[JPBEBBODCJJ] = value;
		}
		return value;
	}

	private static void HOKIDKPBFKM(GameObject FFBEPGEKANM, string JPBEBBODCJJ)
	{
		if (FFBEPGEKANM == null)
		{
			Debug.LogErrorFormat("ActivateObject Key '{0}' Is Null!", JPBEBBODCJJ);
		}
		FFBEPGEKANM.SetActive(value: true);
		EIPCPCJNMEB[FFBEPGEKANM] = JPBEBBODCJJ;
		if (!MPKIKAIHJCM.TryGetValue(JPBEBBODCJJ, out var value))
		{
			value = new List<GameObject>();
			MPKIKAIHJCM[JPBEBBODCJJ] = value;
		}
		value.Add(FFBEPGEKANM);
	}

	public static void KMOLNKBLGDC(string JPBEBBODCJJ, GameObject AMPIHEJLALO)
	{
		Object.DontDestroyOnLoad(AMPIHEJLALO);
		PBKLEEAHIOI[JPBEBBODCJJ] = AMPIHEJLALO;
	}

	public static void KMOLNKBLGDC(GameObject AMPIHEJLALO)
	{
		Object.DontDestroyOnLoad(AMPIHEJLALO);
		PBKLEEAHIOI[AMPIHEJLALO.name] = AMPIHEJLALO;
	}

	public static void FCDBPNPMFNA(string JPBEBBODCJJ)
	{
		if (!PBKLEEAHIOI.Remove(JPBEBBODCJJ))
		{
			return;
		}
		List<GameObject> value = BKPJDINIOHB(JPBEBBODCJJ);
		foreach (GameObject item in value)
		{
			Object.Destroy(item);
		}
		IPDDKMGLFFE -= value.Count;
		FIAGBBAIHEO.Remove(JPBEBBODCJJ);
		if (!MPKIKAIHJCM.TryGetValue(JPBEBBODCJJ, out value))
		{
			return;
		}
		MPKIKAIHJCM.Remove(JPBEBBODCJJ);
		foreach (GameObject item2 in value)
		{
			EIPCPCJNMEB.Remove(item2);
			BEJKEECJHDM.Remove(item2);
			Object.Destroy(item2);
		}
	}

	public static bool ILGHLAIGJKP(string JPBEBBODCJJ)
	{
		return PBKLEEAHIOI.ContainsKey(JPBEBBODCJJ);
	}

	public static GameObject ELKMMPDEDAK(string JPBEBBODCJJ)
	{
		return PBKLEEAHIOI.TryGet(JPBEBBODCJJ);
	}

	public static void FGFAJCCGIMK()
	{
		string[] array = new string[PBKLEEAHIOI.Keys.Count];
		PBKLEEAHIOI.Keys.CopyTo(array, 0);
		string[] array2 = array;
		foreach (string jPBEBBODCJJ in array2)
		{
			FCDBPNPMFNA(jPBEBBODCJJ);
		}
		PBKLEEAHIOI.Clear();
		Resources.UnloadUnusedAssets();
	}

	public static GameObject OHGENNNIPJH(string JPBEBBODCJJ)
	{
		List<GameObject> list = BKPJDINIOHB(JPBEBBODCJJ);
		GameObject gameObject;
		if (list.Count == 0)
		{
			if (!PBKLEEAHIOI.TryGetValue(JPBEBBODCJJ, out var value))
			{
				return null;
			}
			gameObject = Object.Instantiate(value);
			Object.DontDestroyOnLoad(gameObject);
			LGDNCMAHFPA component = gameObject.GetComponent<LGDNCMAHFPA>();
			if (component != null)
			{
				BEJKEECJHDM[gameObject] = component;
				component.ANIGJEBGHOE();
			}
		}
		else
		{
			int index = list.Count - 1;
			gameObject = list[index];
			list.RemoveAt(index);
			IPDDKMGLFFE--;
			if (BEJKEECJHDM.TryGetValue(gameObject, out var value2))
			{
				value2.JJEOFIHCGNA();
			}
		}
		if (gameObject == null)
		{
			Debug.LogErrorFormat("pooledObject Key: {0} Is Null!", JPBEBBODCJJ);
		}
		HOKIDKPBFKM(gameObject, JPBEBBODCJJ);
		return gameObject;
	}

	public static bool GIBDBKPJOKJ(this GameObject FEPNAJAHLDG)
	{
		if (!EIPCPCJNMEB.TryGetValue(FEPNAJAHLDG, out var value))
		{
			return false;
		}
		return FEPNAJAHLDG.GIBDBKPJOKJ(value);
	}

	public static bool GIBDBKPJOKJ(this GameObject FEPNAJAHLDG, string JPBEBBODCJJ)
	{
		if (FEPNAJAHLDG == null)
		{
			return false;
		}
		if (!FIAGBBAIHEO.TryGetValue(JPBEBBODCJJ, out var value))
		{
			return false;
		}
		value.Add(FEPNAJAHLDG);
		EIPCPCJNMEB.Remove(FEPNAJAHLDG);
		if (MPKIKAIHJCM.TryGetValue(JPBEBBODCJJ, out value))
		{
			value.Remove(FEPNAJAHLDG);
		}
		FEPNAJAHLDG.SetActive(value: false);
		IPDDKMGLFFE++;
		if (BEJKEECJHDM.TryGetValue(FEPNAJAHLDG, out var value2))
		{
			value2.HOIBNEFCLPC();
		}
		return true;
	}

	public static IEnumerable<KeyValuePair<GameObject, string>> OHHENALHOKJ()
	{
		foreach (KeyValuePair<GameObject, string> item in EIPCPCJNMEB)
		{
			yield return item;
		}
	}

	public static void FANNHPHFKJH()
	{
		foreach (KeyValuePair<GameObject, string> item in EIPCPCJNMEB)
		{
			if (FIAGBBAIHEO.TryGetValue(item.Value, out var value))
			{
				value.Add(item.Key);
				item.Key.SetActive(value: false);
				IPDDKMGLFFE++;
				if (BEJKEECJHDM.TryGetValue(item.Key, out var value2))
				{
					value2.HOIBNEFCLPC();
				}
			}
		}
		EIPCPCJNMEB.Clear();
		MPKIKAIHJCM.Clear();
	}

	public static void GFJGDEKLFNB(bool HADGECHAEAE)
	{
		if (HADGECHAEAE)
		{
			foreach (KeyValuePair<GameObject, string> item in EIPCPCJNMEB)
			{
				BEJKEECJHDM.Remove(item.Key);
				Object.Destroy(item.Key);
			}
			EIPCPCJNMEB.Clear();
			MPKIKAIHJCM.Clear();
		}
		foreach (KeyValuePair<string, List<GameObject>> item2 in FIAGBBAIHEO)
		{
			foreach (GameObject item3 in item2.Value)
			{
				BEJKEECJHDM.Remove(item3);
				Object.Destroy(item3);
			}
		}
		FIAGBBAIHEO.Clear();
		IPDDKMGLFFE = 0;
	}

	public static int KKBMGGECOJE(string JPBEBBODCJJ)
	{
		if (MPKIKAIHJCM.TryGetValue(JPBEBBODCJJ, out var value))
		{
			return value.Count;
		}
		return 0;
	}
}
