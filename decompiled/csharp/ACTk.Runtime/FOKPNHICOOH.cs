using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class FOKPNHICOOH<T> : MonoBehaviour where T : global::FOKPNHICOOH<T>
{
	[Tooltip("Detector will survive new level (scene) load if checked.")]
	public bool NELIGJMLLGN = true;

	protected int HKLKGKLDJAM;

	public static T KHGDLGJPCCA { get; protected set; }

	protected static T AAANLLGDCHM
	{
		get
		{
			if (KHGDLGJPCCA != null)
			{
				return KHGDLGJPCCA;
			}
			if (COAOANHJNAD.GPMJFPKAGLL == null)
			{
				COAOANHJNAD.GPMJFPKAGLL = new GameObject("Anti-Cheat Toolkit");
			}
			KHGDLGJPCCA = COAOANHJNAD.GPMJFPKAGLL.AddComponent<T>();
			return KHGDLGJPCCA;
		}
	}

	protected virtual void Awake()
	{
		HKLKGKLDJAM++;
		if (HIBHJDCMMAJ(KHGDLGJPCCA, NBJPADKALNN()))
		{
			KHGDLGJPCCA = (T)this;
		}
	}

	protected virtual void Start()
	{
		if (COAOANHJNAD.GPMJFPKAGLL == null && base.gameObject.name == "Anti-Cheat Toolkit")
		{
			COAOANHJNAD.GPMJFPKAGLL = base.gameObject;
		}
		SceneManager.sceneLoaded += DHEAKJLMOON;
	}

	protected virtual void OnDestroy()
	{
		int num = GetComponentsInChildren<Component>().Length;
		if (base.transform.childCount == 0 && num <= 2)
		{
			Object.Destroy(base.gameObject);
		}
		else if (base.name == "Anti-Cheat Toolkit" && num <= 2)
		{
			Object.Destroy(base.gameObject);
		}
		HKLKGKLDJAM--;
		SceneManager.sceneLoaded -= DHEAKJLMOON;
		if (KHGDLGJPCCA == this)
		{
			KHGDLGJPCCA = (T)null;
		}
	}

	protected virtual void DHEAKJLMOON(Scene AIHHFDJKLNO, LoadSceneMode PGCIDPHOAEC)
	{
		if (HKLKGKLDJAM < 2)
		{
			if (!NELIGJMLLGN)
			{
				CBPNHEBFOFH();
			}
		}
		else if (!NELIGJMLLGN && KHGDLGJPCCA != this)
		{
			CBPNHEBFOFH();
		}
	}

	protected virtual bool HIBHJDCMMAJ(T KAGNKODNFOC, string IIIHGIINJJL)
	{
		if (KAGNKODNFOC != null && KAGNKODNFOC != this && KAGNKODNFOC.NELIGJMLLGN)
		{
			CBPNHEBFOFH();
			return false;
		}
		Object.DontDestroyOnLoad((!(base.transform.parent != null)) ? base.gameObject : base.transform.root.gameObject);
		return true;
	}

	protected virtual void CBPNHEBFOFH()
	{
		Object.Destroy(this);
	}

	protected abstract string NBJPADKALNN();
}
