using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("UI/Extensions/Menu Manager")]
public class LFKLFMNIBMC : MonoBehaviour
{
	public PAIJCIAAHDK[] KHDAIJEGPPC;

	public int PGHGJFDKEAG;

	private Stack<PAIJCIAAHDK> ADIMCHJAMFE = new Stack<PAIJCIAAHDK>();

	public static LFKLFMNIBMC KHGDLGJPCCA { get; set; }

	private void Awake()
	{
		KHGDLGJPCCA = this;
		if (KHDAIJEGPPC.Length > PGHGJFDKEAG)
		{
			CDOCOJDADMA(KHDAIJEGPPC[PGHGJFDKEAG].name);
			MECEJIJMFKH(KHDAIJEGPPC[PGHGJFDKEAG]);
		}
		else
		{
			Debug.LogError("Not enough Menu Screens configured");
		}
	}

	private void OnDestroy()
	{
		KHGDLGJPCCA = null;
	}

	public void CDOCOJDADMA<T>() where T : PAIJCIAAHDK
	{
		T original = ELKMMPDEDAK<T>();
		Object.Instantiate(original, base.transform);
	}

	public void CDOCOJDADMA(string CDGGNOIPKKM)
	{
		GameObject original = ELKMMPDEDAK(CDGGNOIPKKM);
		Object.Instantiate(original, base.transform);
	}

	public void MECEJIJMFKH(PAIJCIAAHDK KAGNKODNFOC)
	{
		if (ADIMCHJAMFE.Count > 0)
		{
			if (KAGNKODNFOC.FLGIBIMFKJC)
			{
				foreach (PAIJCIAAHDK item in ADIMCHJAMFE)
				{
					item.gameObject.SetActive(false);
					if (item.FLGIBIMFKJC)
					{
						break;
					}
				}
			}
			Canvas component = KAGNKODNFOC.GetComponent<Canvas>();
			Canvas component2 = ADIMCHJAMFE.Peek().GetComponent<Canvas>();
			component.sortingOrder = component2.sortingOrder + 1;
		}
		ADIMCHJAMFE.Push(KAGNKODNFOC);
	}

	private GameObject ELKMMPDEDAK(string EGOLODIGNCL)
	{
		for (int i = 0; i < KHDAIJEGPPC.Length; i++)
		{
			if (KHDAIJEGPPC[i].name == EGOLODIGNCL)
			{
				return KHDAIJEGPPC[i].gameObject;
			}
		}
		throw new MissingReferenceException("Prefab not found for " + EGOLODIGNCL);
	}

	private T ELKMMPDEDAK<T>() where T : PAIJCIAAHDK
	{
		FieldInfo[] fields = GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			T val = fieldInfo.GetValue(this) as T;
			if (val != null)
			{
				return val;
			}
		}
		throw new MissingReferenceException("Prefab not found for type " + typeof(T));
	}

	public void NGFHNFKFBPK(PAIJCIAAHDK IMDNCJODAEN)
	{
		if (ADIMCHJAMFE.Count == 0)
		{
			Debug.LogErrorFormat(IMDNCJODAEN, "{0} cannot be closed because menu stack is empty", IMDNCJODAEN.GetType());
		}
		else if (ADIMCHJAMFE.Peek() != IMDNCJODAEN)
		{
			Debug.LogErrorFormat(IMDNCJODAEN, "{0} cannot be closed because it is not on top of stack", IMDNCJODAEN.GetType());
		}
		else
		{
			KFOGGMJMKFD();
		}
	}

	public void KFOGGMJMKFD()
	{
		PAIJCIAAHDK pAIJCIAAHDK = ADIMCHJAMFE.Pop();
		if (pAIJCIAAHDK.AIIAGJOOLNI)
		{
			Object.Destroy(pAIJCIAAHDK.gameObject);
		}
		else
		{
			pAIJCIAAHDK.gameObject.SetActive(false);
		}
		foreach (PAIJCIAAHDK item in ADIMCHJAMFE)
		{
			item.gameObject.SetActive(true);
			if (item.FLGIBIMFKJC)
			{
				break;
			}
		}
	}

	private void Update()
	{
		if (UnityEngine.Input.GetKeyDown(KeyCode.Escape) && ADIMCHJAMFE.Count > 0)
		{
			ADIMCHJAMFE.Peek().PFAEMDIMGLK();
		}
	}
}
