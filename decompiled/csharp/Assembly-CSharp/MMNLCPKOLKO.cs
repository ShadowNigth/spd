using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[AddComponentMenu("UI/Extensions/Cooldown Button")]
public class MMNLCPKOLKO : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Serializable]
	public class CooldownButtonEvent : UnityEvent<PointerEventData.InputButton>
	{
	}

	[SerializeField]
	private float cooldownTimeout;

	[SerializeField]
	private float cooldownSpeed = 1f;

	[GMMAMJCBKMO]
	[SerializeField]
	private bool cooldownActive;

	[GMMAMJCBKMO]
	[SerializeField]
	private bool cooldownInEffect;

	[GMMAMJCBKMO]
	[SerializeField]
	private float cooldownTimeElapsed;

	[SerializeField]
	[GMMAMJCBKMO]
	private float cooldownTimeRemaining;

	[GMMAMJCBKMO]
	[SerializeField]
	private int cooldownPercentRemaining;

	[SerializeField]
	[GMMAMJCBKMO]
	private int cooldownPercentComplete;

	private PointerEventData JPIOBJMLIEP;

	[Tooltip("Event that fires when a button is initially pressed down")]
	public CooldownButtonEvent GFJDPLFNDDN;

	[Tooltip("Event that fires when a button is released")]
	public CooldownButtonEvent GPGMAKFGIMN;

	[Tooltip("Event that continually fires while a button is held down")]
	public CooldownButtonEvent DFJFABLBFII;

	public float PNEFNPOGFCD
	{
		get
		{
			return cooldownTimeout;
		}
		set
		{
			cooldownTimeout = value;
		}
	}

	public float BNLECKLJHPB
	{
		get
		{
			return cooldownSpeed;
		}
		set
		{
			cooldownSpeed = value;
		}
	}

	public bool NFPFMFBHGHC => cooldownInEffect;

	public bool GABIEPNJJEH
	{
		get
		{
			return cooldownActive;
		}
		set
		{
			cooldownActive = value;
		}
	}

	public float IACAAOGEIHG
	{
		get
		{
			return cooldownTimeElapsed;
		}
		set
		{
			cooldownTimeElapsed = value;
		}
	}

	public float PDDDJCELIGC => cooldownTimeRemaining;

	public int HGDOLBPENLM => cooldownPercentRemaining;

	public int PFBPBIOOPMP => cooldownPercentComplete;

	private void Update()
	{
		if (GABIEPNJJEH)
		{
			cooldownTimeRemaining -= Time.deltaTime * cooldownSpeed;
			cooldownTimeElapsed = PNEFNPOGFCD - PDDDJCELIGC;
			if (cooldownTimeRemaining < 0f)
			{
				GBJEFJEGFLI();
				return;
			}
			cooldownPercentRemaining = (int)(100f * cooldownTimeRemaining * PNEFNPOGFCD / 100f);
			cooldownPercentComplete = (int)((PNEFNPOGFCD - cooldownTimeRemaining) / PNEFNPOGFCD * 100f);
		}
	}

	public void FLKLKKLHKBL()
	{
		if (NFPFMFBHGHC)
		{
			GABIEPNJJEH = false;
		}
	}

	public void OPNDMBONCLP()
	{
		if (NFPFMFBHGHC)
		{
			GABIEPNJJEH = true;
		}
	}

	public void GBJEFJEGFLI()
	{
		cooldownTimeElapsed = PNEFNPOGFCD;
		cooldownTimeRemaining = 0f;
		cooldownPercentRemaining = 0;
		cooldownPercentComplete = 100;
		cooldownActive = (cooldownInEffect = false);
		if (DFJFABLBFII != null)
		{
			DFJFABLBFII.Invoke(JPIOBJMLIEP.button);
		}
	}

	public void IMJFBMPDJDC()
	{
		cooldownActive = (cooldownInEffect = false);
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData GBOFEMOALII)
	{
		JPIOBJMLIEP = GBOFEMOALII;
		if (NFPFMFBHGHC && GPGMAKFGIMN != null)
		{
			GPGMAKFGIMN.Invoke(GBOFEMOALII.button);
		}
		if (!NFPFMFBHGHC)
		{
			if (GFJDPLFNDDN != null)
			{
				GFJDPLFNDDN.Invoke(GBOFEMOALII.button);
			}
			cooldownTimeRemaining = cooldownTimeout;
			cooldownActive = (cooldownInEffect = true);
		}
	}
}
