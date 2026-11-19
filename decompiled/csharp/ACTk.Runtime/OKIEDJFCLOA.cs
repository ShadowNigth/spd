using System;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("")]
public abstract class OKIEDJFCLOA<T> : global::FOKPNHICOOH<T> where T : global::OKIEDJFCLOA<T>
{
	protected const string AEKFMHBDLIP = "Code Stage/Anti-Cheat Toolkit/";

	[Tooltip("Automatically start detector. Detection Event will be called on detection.")]
	public bool CPEMAJGFJEN = true;

	[Tooltip("Automatically dispose Detector after firing callback.")]
	public bool IDIBIHLNMEG = true;

	[SerializeField]
	protected UnityEvent detectionEvent;

	[SerializeField]
	protected bool detectionEventHasListener;

	protected bool BFDIKKENINF;

	protected bool CDOJMHCPDCB;

	public bool OACFFKENAKG { get; protected set; }

	public bool EGPHPICPJLO => BFDIKKENINF;

	public bool MNDFOKODEPL => CDOJMHCPDCB;

	public event Action BJAAEHCDEFB;

	protected override void Start()
	{
		base.Start();
		if (CPEMAJGFJEN && !BFDIKKENINF)
		{
			IHNNAFKGGMO();
		}
	}

	private void OnEnable()
	{
		INJJKIJPBBG();
	}

	private void OnDisable()
	{
		MNGJCENJLOC();
	}

	private void OnApplicationQuit()
	{
		CBPNHEBFOFH();
	}

	protected override void OnDestroy()
	{
		CNIPMALICAE();
		base.OnDestroy();
	}

	internal virtual void HENEPAOMHDA()
	{
		OACFFKENAKG = true;
		if (this.BJAAEHCDEFB != null)
		{
			this.BJAAEHCDEFB();
		}
		if (detectionEventHasListener)
		{
			detectionEvent.Invoke();
		}
		if (IDIBIHLNMEG)
		{
			CBPNHEBFOFH();
		}
		else
		{
			CNIPMALICAE();
		}
	}

	protected virtual bool MLCLGJBFMNM()
	{
		return this.BJAAEHCDEFB != null || detectionEventHasListener;
	}

	protected virtual void CNIPMALICAE()
	{
		this.BJAAEHCDEFB = null;
		BFDIKKENINF = false;
		CDOJMHCPDCB = false;
	}

	protected virtual void MNGJCENJLOC()
	{
		if (BFDIKKENINF)
		{
			CDOJMHCPDCB = false;
		}
	}

	protected virtual bool INJJKIJPBBG()
	{
		if (!BFDIKKENINF || !MLCLGJBFMNM())
		{
			return false;
		}
		CDOJMHCPDCB = true;
		return true;
	}

	protected abstract void IHNNAFKGGMO();
}
