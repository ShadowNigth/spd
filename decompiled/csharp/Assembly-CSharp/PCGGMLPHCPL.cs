using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCGGMLPHCPL : MonoBehaviour
{
	[Serializable]
	public struct SpawningPoolEntry
	{
		public string Key;

		public GameObject Prefab;
	}

	private static PCGGMLPHCPL KAGNKODNFOC;

	private bool JMMMMFLHOLI;

	[Tooltip("List of prefabs to add to the spawning pool upon start")]
	public SpawningPoolEntry[] LJPGKKLOMKK;

	[Tooltip("Whether to return spawned objects to cache on level load.")]
	public bool DDEDIOICDJN = true;

	[Tooltip("Whether to remove spawned prefabs on level load.")]
	public bool PAIKFIHIHPM;

	public static PCGGMLPHCPL KHGDLGJPCCA => KAGNKODNFOC;

	private void PKFPKKBJBIK(Scene AIHHFDJKLNO, LoadSceneMode PGCIDPHOAEC)
	{
		NGANNJFFIMG.GFJGDEKLFNB(HADGECHAEAE: true);
	}

	private void Awake()
	{
		if (JMMMMFLHOLI)
		{
			return;
		}
		if (KAGNKODNFOC == null)
		{
			JMMMMFLHOLI = true;
			KAGNKODNFOC = this;
			UnityEngine.Object.DontDestroyOnLoad(this);
			if (LJPGKKLOMKK != null)
			{
				SpawningPoolEntry[] lJPGKKLOMKK = LJPGKKLOMKK;
				for (int i = 0; i < lJPGKKLOMKK.Length; i++)
				{
					SpawningPoolEntry spawningPoolEntry = lJPGKKLOMKK[i];
					NGANNJFFIMG.KMOLNKBLGDC(spawningPoolEntry.Key, spawningPoolEntry.Prefab);
				}
			}
			SceneManager.sceneLoaded += PKFPKKBJBIK;
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
