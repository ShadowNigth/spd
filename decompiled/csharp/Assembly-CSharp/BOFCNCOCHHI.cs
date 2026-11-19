using UnityEngine;

public abstract class BOFCNCOCHHI<T> : PAIJCIAAHDK where T : global::BOFCNCOCHHI<T>
{
	public static T KHGDLGJPCCA { get; private set; }

	protected virtual void Awake()
	{
		KHGDLGJPCCA = (T)this;
	}

	protected virtual void OnDestroy()
	{
		KHGDLGJPCCA = (T)null;
	}

	protected static void ADMBHHGPPAM()
	{
		if (KHGDLGJPCCA == null)
		{
			LFKLFMNIBMC.KHGDLGJPCCA.CDOCOJDADMA(typeof(T).Name);
		}
		else
		{
			T val = KHGDLGJPCCA;
			val.gameObject.SetActive(value: true);
		}
		LFKLFMNIBMC.KHGDLGJPCCA.MECEJIJMFKH(KHGDLGJPCCA);
	}

	protected static void IOELOKNDNDG()
	{
		if (KHGDLGJPCCA == null)
		{
			Debug.LogErrorFormat("Trying to close menu {0} but Instance is null", typeof(T));
		}
		else
		{
			LFKLFMNIBMC.KHGDLGJPCCA.NGFHNFKFBPK(KHGDLGJPCCA);
		}
	}

	public override void PFAEMDIMGLK()
	{
		IOELOKNDNDG();
	}
}
