using System;
using CodeStage.AntiCheat.ObscuredTypes;
using SPD.Audio;
using UnityEngine;

public class AnimationEvents : FOGIOGKLNIP
{
	[Serializable]
	public class CustomParticle
	{
		public enum EmitType
		{
			Emit = 0,
			Play = 1,
			PlayWithChildrens = 2
		}

		public ParticleSystem Particle;

		public EmitType EmitMode;

		public int CountEmit = 1;
	}

	[Header("Muzzle Flash Parent")]
	public Transform MuzzleFlashParent;

	public Vector3 MuzzleFlashRotation;

	public Vector3 MuzzleFlashScale;

	[Header("Muzzle Flash Parent Second")]
	public Transform MuzzleFlashParentSecond;

	public Vector3 MuzzleFlashRotationSecond;

	public Vector3 MuzzleFlashScaleSecond;

	[Header("Shell Eject Parent")]
	public Transform ShellEjectParent;

	public Vector3 ShellEjectRotation;

	public Vector3 ShellEjectScale;

	[Header("Shell Eject Parent Second")]
	public Transform ShellEjectParentSecond;

	public Vector3 ShellEjectRotationSecond;

	public Vector3 ShellEjectScaleSecond;

	public string MuzzleFlashEffect = "MuzzleFlashEffect";

	public string ShellEjectEffect = "shell_9mm";

	[Header("Custom Particles for Animation Event")]
	public CustomParticle[] CustomParticles;

	[Header("Silencer model (Only for USP-S or M4A1-S)")]
	public GameObject Silencer;

	[Header("Code on panel C4 (It's can be used on any objects)")]
	public TextMesh PanelCode;

	[Header("Special weapon model for Counter-Terrorists")]
	public GameObject CTWeaponModel;

	[Header("Special weapon model for Terrorists")]
	public GameObject TWeaponModel;

	[Header("Special hands model for Counter-Terrorists")]
	public string CTHandsPath = "ct_arms";

	[Header("Special hands model for Terrorists")]
	public string THandsPath = "t_arms";

	internal GameObject CTHandsCache;

	internal GameObject THandsCache;

	public void CreateHands()
	{
		if (CTHandsPath != string.Empty && THandsPath != string.Empty)
		{
			CTHandsCache = NPDKFEEDEGM(CTHandsPath, "Weapons/", true, EHOEFMPLIFB);
			CTHandsCache.SetLayer(22);
			THandsCache = NPDKFEEDEGM(THandsPath, "Weapons/", true, EHOEFMPLIFB);
			THandsCache.SetLayer(22);
		}
		else
		{
			Debug.LogError("CT and T arm models path is empty.");
		}
	}

	public void EmitSound(AudioClip Audio)
	{
		FOGIOGKLNIP.NGFDFPGNDCJ.LEDCIPHCLEB(Audio ?? FOGIOGKLNIP.HJLAMDIBCDO.FPJLDJIGIEK, 2f);
	}

	public void EmitSoundByBank(BankEntry Audio)
	{
		FOGIOGKLNIP.NGFDFPGNDCJ.LEDCIPHCLEB(Audio);
	}

	public void EmitByID(int ID)
	{
	}

	public void EmitCode(string Value)
	{
		PanelCode.text = Value;
	}

	public void EmitMuzzleFlashMain()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL)
		{
			if (FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB != null && FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.parent != MuzzleFlashParent)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.parent = MuzzleFlashParent;
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.localPosition = Vector3.zero;
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.localRotation = Quaternion.Euler(MuzzleFlashRotation);
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.localScale = MuzzleFlashScale;
			}
			if (FOGIOGKLNIP.NGFDFPGNDCJ.NCCBEFIEDEH && !FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH.JEPMMPCNEHO.KNAEGLBCLDL && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH.JEPMMPCNEHO.EMIEPBFBJBB))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.Emit(1);
			}
		}
	}

	public void EmitMuzzleFlashSecond()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL)
		{
			if (FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB != null && FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.parent != MuzzleFlashParentSecond)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.parent = MuzzleFlashParentSecond;
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.localPosition = Vector3.zero;
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.localRotation = Quaternion.Euler(MuzzleFlashRotationSecond);
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.transform.localScale = MuzzleFlashScaleSecond;
			}
			if (FOGIOGKLNIP.NGFDFPGNDCJ.NCCBEFIEDEH && !FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH.JEPMMPCNEHO.KNAEGLBCLDL && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH.JEPMMPCNEHO.EMIEPBFBJBB))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.IBHKEHPIOLB.Emit(1);
			}
		}
	}

	public void EmitShellParentMain()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL)
		{
			if (FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF != null && FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.parent != ShellEjectParent)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.parent = ShellEjectParent;
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.localPosition = Vector3.zero;
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.localRotation = Quaternion.Euler(ShellEjectRotation);
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.localScale = ShellEjectScale;
			}
			if (FOGIOGKLNIP.NGFDFPGNDCJ.NCCBEFIEDEH && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH.JEPMMPCNEHO.EMIEPBFBJBB))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.Emit(1);
			}
		}
	}

	public void EmitShellParentSecond()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL)
		{
			if (FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF != null && FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.parent != ShellEjectParentSecond)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.parent = ShellEjectParentSecond;
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.localPosition = Vector3.zero;
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.localRotation = Quaternion.Euler(ShellEjectRotationSecond);
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.transform.localScale = ShellEjectScaleSecond;
			}
			if (FOGIOGKLNIP.NGFDFPGNDCJ.NCCBEFIEDEH && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH.JEPMMPCNEHO.EMIEPBFBJBB))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.MOKICNDDNBF.Emit(1);
			}
		}
	}

	public void EmitCustomParticle(int IndexParticle)
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL)
		{
			CustomParticle customParticle = CustomParticles[IndexParticle];
			switch (customParticle.EmitMode)
			{
			default:
				customParticle.Particle.Emit(customParticle.CountEmit);
				break;
			case CustomParticle.EmitType.Play:
				customParticle.Particle.Play();
				break;
			case CustomParticle.EmitType.PlayWithChildrens:
				customParticle.Particle.Play(true);
				break;
			}
		}
	}

	public void OnReloaded()
	{
	}

	public void Walk()
	{
		EHOEFMPLIFB.parent.SendMessage("GADAMODPCON", SendMessageOptions.DontRequireReceiver);
	}

	public void Hit()
	{
		EHOEFMPLIFB.parent.SendMessage("IHBFPOOLCFD", SendMessageOptions.DontRequireReceiver);
	}
}
