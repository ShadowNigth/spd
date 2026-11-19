using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public static class NGANNJFFIMG
{
	private sealed class JHFFALPABFJ : IEnumerable, IEnumerable<KeyValuePair<GameObject, string>>, IEnumerator, IDisposable, IEnumerator<KeyValuePair<GameObject, string>>
	{
		internal Dictionary<GameObject, string>.Enumerator DKOBKNHODMO;

		internal KeyValuePair<GameObject, string> JEDHJGOGGDK;

		internal KeyValuePair<GameObject, string> HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		KeyValuePair<GameObject, string> IEnumerator<KeyValuePair<GameObject, string>>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public JHFFALPABFJ()
		{
		}

		public bool MoveNext()
		{
			uint num = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				DKOBKNHODMO = EIPCPCJNMEB.GetEnumerator();
				num = 4294967293u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (DKOBKNHODMO.MoveNext())
						{
							JEDHJGOGGDK = DKOBKNHODMO.Current;
							HLJEEFIJCOF = JEDHJGOGGDK;
							if (!JMOBJHKGFMH)
							{
								GNNOELAJGPI = 1;
							}
							flag = true;
							goto IL_00ae;
						}
						break;
					}
				}
				finally
				{
					if (!flag)
					{
						((IDisposable)DKOBKNHODMO/*cast due to .constrained prefix*/).Dispose();
					}
				}
				GNNOELAJGPI = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00ae:
				return true;
			}
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					((IDisposable)DKOBKNHODMO/*cast due to .constrained prefix*/).Dispose();
				}
			case 0u:
				break;
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<GameObject, string>>)this).GetEnumerator();
		}

		[DebuggerHidden]
		IEnumerator<KeyValuePair<GameObject, string>> IEnumerable<KeyValuePair<GameObject, string>>.GetEnumerator()
		{
			if (Interlocked.CompareExchange(ref GNNOELAJGPI, 0, -2) == -2)
			{
				return this;
			}
			return new JHFFALPABFJ();
		}
	}

	private static readonly Dictionary<string, GameObject> PBKLEEAHIOI = new Dictionary<string, GameObject>();

	private static readonly Dictionary<GameObject, string> EIPCPCJNMEB = new Dictionary<GameObject, string>();

	private static readonly Dictionary<string, List<GameObject>> FIAGBBAIHEO = new Dictionary<string, List<GameObject>>();

	private static readonly Dictionary<string, List<GameObject>> MPKIKAIHJCM = new Dictionary<string, List<GameObject>>();

	private static readonly Dictionary<GameObject, LGDNCMAHFPA> BEJKEECJHDM = new Dictionary<GameObject, LGDNCMAHFPA>();

	private static int IPDDKMGLFFE;

	public static HideFlags LGDPJOIPACJ = HideFlags.HideInHierarchy | HideFlags.HideInInspector;

	public static int JCIJINDMJAI
	{
		get
		{
			return IPDDKMGLFFE;
		}
	}

	public static int CPHDIDCBCLG
	{
		get
		{
			return EIPCPCJNMEB.Count;
		}
	}

	private static List<GameObject> BKPJDINIOHB(string JPBEBBODCJJ)
	{
		List<GameObject> value;
		if (!FIAGBBAIHEO.TryGetValue(JPBEBBODCJJ, out value))
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
			UnityEngine.Debug.LogErrorFormat("ActivateObject Key '{0}' Is Null!", JPBEBBODCJJ);
		}
		FFBEPGEKANM.SetActive(true);
		EIPCPCJNMEB[FFBEPGEKANM] = JPBEBBODCJJ;
		List<GameObject> value;
		if (!MPKIKAIHJCM.TryGetValue(JPBEBBODCJJ, out value))
		{
			value = new List<GameObject>();
			MPKIKAIHJCM[JPBEBBODCJJ] = value;
		}
		value.Add(FFBEPGEKANM);
	}

	public static void KMOLNKBLGDC(string JPBEBBODCJJ, GameObject AMPIHEJLALO)
	{
		UnityEngine.Object.DontDestroyOnLoad(AMPIHEJLALO);
		PBKLEEAHIOI[JPBEBBODCJJ] = AMPIHEJLALO;
	}

	public static void KMOLNKBLGDC(GameObject AMPIHEJLALO)
	{
		UnityEngine.Object.DontDestroyOnLoad(AMPIHEJLALO);
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
			UnityEngine.Object.Destroy(item);
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
			UnityEngine.Object.Destroy(item2);
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
			GameObject value;
			if (!PBKLEEAHIOI.TryGetValue(JPBEBBODCJJ, out value))
			{
				return null;
			}
			gameObject = UnityEngine.Object.Instantiate(value);
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
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
			LGDNCMAHFPA value2;
			if (BEJKEECJHDM.TryGetValue(gameObject, out value2))
			{
				value2.JJEOFIHCGNA();
			}
		}
		if (gameObject == null)
		{
			UnityEngine.Debug.LogErrorFormat("pooledObject Key: {0} Is Null!", JPBEBBODCJJ);
		}
		HOKIDKPBFKM(gameObject, JPBEBBODCJJ);
		return gameObject;
	}

	public static bool GIBDBKPJOKJ(this GameObject FEPNAJAHLDG)
	{
		string value;
		if (!EIPCPCJNMEB.TryGetValue(FEPNAJAHLDG, out value))
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
		List<GameObject> value;
		if (!FIAGBBAIHEO.TryGetValue(JPBEBBODCJJ, out value))
		{
			return false;
		}
		value.Add(FEPNAJAHLDG);
		EIPCPCJNMEB.Remove(FEPNAJAHLDG);
		if (MPKIKAIHJCM.TryGetValue(JPBEBBODCJJ, out value))
		{
			value.Remove(FEPNAJAHLDG);
		}
		FEPNAJAHLDG.SetActive(false);
		IPDDKMGLFFE++;
		LGDNCMAHFPA value2;
		if (BEJKEECJHDM.TryGetValue(FEPNAJAHLDG, out value2))
		{
			value2.HOIBNEFCLPC();
		}
		return true;
	}

	[DebuggerHidden]
	public static IEnumerable<KeyValuePair<GameObject, string>> OHHENALHOKJ()
	{
		JHFFALPABFJ jHFFALPABFJ = new JHFFALPABFJ();
		jHFFALPABFJ.GNNOELAJGPI = -2;
		return jHFFALPABFJ;
	}

	public static void FANNHPHFKJH()
	{
		foreach (KeyValuePair<GameObject, string> item in EIPCPCJNMEB)
		{
			List<GameObject> value;
			if (FIAGBBAIHEO.TryGetValue(item.Value, out value))
			{
				value.Add(item.Key);
				item.Key.SetActive(false);
				IPDDKMGLFFE++;
				LGDNCMAHFPA value2;
				if (BEJKEECJHDM.TryGetValue(item.Key, out value2))
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
				UnityEngine.Object.Destroy(item.Key);
			}
			EIPCPCJNMEB.Clear();
			MPKIKAIHJCM.Clear();
		}
		foreach (KeyValuePair<string, List<GameObject>> item2 in FIAGBBAIHEO)
		{
			foreach (GameObject item3 in item2.Value)
			{
				BEJKEECJHDM.Remove(item3);
				UnityEngine.Object.Destroy(item3);
			}
		}
		FIAGBBAIHEO.Clear();
		IPDDKMGLFFE = 0;
	}

	public static int KKBMGGECOJE(string JPBEBBODCJJ)
	{
		List<GameObject> value;
		if (MPKIKAIHJCM.TryGetValue(JPBEBBODCJJ, out value))
		{
			return value.Count;
		}
		return 0;
	}
}
