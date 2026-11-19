using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class BOFCNCOCHHI<T> : PAIJCIAAHDK where T : global::BOFCNCOCHHI<T>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static T _003CPBMIIONAEDH_003Ek__BackingField;

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
			val.gameObject.SetActive(true);
		}
		LFKLFMNIBMC.KHGDLGJPCCA.MECEJIJMFKH(KHGDLGJPCCA);
	}

	protected static void IOELOKNDNDG()
	{
		if (KHGDLGJPCCA == null)
		{
			UnityEngine.Debug.LogErrorFormat("Trying to close menu {0} but Instance is null", typeof(T));
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
