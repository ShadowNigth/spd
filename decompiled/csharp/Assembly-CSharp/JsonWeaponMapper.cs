using System;

[Serializable]
public class JsonWeaponMapper
{
	public string GunBaseName;

	public int damage;

	public float up_base;

	public float lateral_base;

	public float up_modifier;

	public float lateral_modifier;

	public float up_max;

	public float lateral_max;

	public int direction_change;

	public float staticRunAccuraty;

	public float handsReloadSpeed;

	public float staticAccuraty;

	public float accuraty;

	public float RunInaccuraty;

	public float RunSpeedFactor;

	public float handDamageFactor;

	public float TorsoDamageFactor;

	public float LegsDamageFactor;

	public float headDamageFactor;

	public float WallThroughFactor;

	public float shootCursor;

	public float cursorRecovery;

	public float shootCursorMax;

	public float shootTime;

	public float shootTimeNonAuto;

	public float bulletSpeedFactor;

	public JsonWeaponMapper(string GunBaseName, int damage, float up_base, float lateral_base, float up_modifier, float lateral_modifier, float up_max, float lateral_max, int direction_change, float staticRunAccuraty, float handsReloadSpeed, float staticAccuraty, float accuraty, float RunInaccuraty, float RunSpeedFactor, float handDamageFactor, float TorsoDamageFactor, float LegsDamageFactor, float headDamageFactor, float WallThroughFactor, float shootCursor, float cursorRecovery, float shootCursorMax, float shootTime, float shootTimeNonAuto, float bulletSpeedFactor)
	{
		this.GunBaseName = GunBaseName;
		this.damage = damage;
		this.up_base = up_base;
		this.lateral_base = lateral_base;
		this.up_modifier = up_modifier;
		this.lateral_modifier = lateral_modifier;
		this.up_max = up_max;
		this.lateral_max = lateral_max;
		this.direction_change = direction_change;
		this.staticRunAccuraty = staticRunAccuraty;
		this.handsReloadSpeed = handsReloadSpeed;
		this.staticAccuraty = staticAccuraty;
		this.accuraty = accuraty;
		this.RunInaccuraty = RunInaccuraty;
		this.RunSpeedFactor = RunSpeedFactor;
		this.handDamageFactor = handDamageFactor;
		this.TorsoDamageFactor = TorsoDamageFactor;
		this.LegsDamageFactor = LegsDamageFactor;
		this.headDamageFactor = headDamageFactor;
		this.WallThroughFactor = WallThroughFactor;
		this.shootCursor = shootCursor;
		this.cursorRecovery = cursorRecovery;
		this.shootCursorMax = shootCursorMax;
		this.shootTime = shootTime;
		this.shootTimeNonAuto = shootTimeNonAuto;
		this.bulletSpeedFactor = bulletSpeedFactor;
	}
}
