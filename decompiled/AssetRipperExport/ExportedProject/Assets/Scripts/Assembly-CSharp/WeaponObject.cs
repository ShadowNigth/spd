using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

[Serializable]
public class WeaponObject : ScriptableObject
{
	public int DivideDamage = 1;

	public float up_base = 1f;

	public float lateral_base = 1f;

	public float up_modifier = 1f;

	public float lateral_modifier = 1f;

	public float up_max = 1f;

	public float lateral_max = 1f;

	public int direction_change = 1;

	public ObscuredInt cost;

	public ObscuredInt award;

	public ObscuredInt damage;

	public ObscuredFloat time;

	public ObscuredInt maxPatrons;

	public int gunNumber;

	public bool sniper;

	public ObscuredFloat DrawSpeed;

	public ObscuredFloat staticRunAccuraty;

	public ObscuredFloat handsReloadSpeed;

	public ObscuredFloat staticAccuraty;

	public ObscuredFloat accuraty;

	public ObscuredFloat RunInaccuraty;

	public ObscuredFloat RunSpeedFactor;

	public ObscuredFloat Range;

	public ObscuredFloat handDamageFactor;

	public ObscuredFloat TorsoDamageFactor;

	public ObscuredFloat LegsDamageFactor;

	public ObscuredFloat headDamageFactor;

	public ObscuredFloat WallThroughFactor;

	public ObscuredFloat shootCursor;

	public ObscuredFloat cursorRecovery;

	public ObscuredFloat shootCursorMax;

	public ObscuredFloat shootTime;

	public ObscuredFloat shootTimeNonAuto;

	public ObscuredInt bulletsPerShoot;

	public ObscuredFloat bulletSpeedFactor;

	public int IndexShootDistanceBank;

	public int IndexShootBank;

	public int IndexShootSilencerDistanceBank;

	public int IndexShootSilencerBank;

	public int IndexShellBank;
}
