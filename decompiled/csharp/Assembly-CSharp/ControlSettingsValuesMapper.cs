using System;

[Serializable]
public class ControlSettingsValuesMapper
{
	public int AlphaColorControls;

	public float sensivityX;

	public float sensivityY;

	public float smoothIn4Scope;

	public bool WeaponAutoSwitch;

	public bool lockFire;

	public bool touch2;

	public bool EnableSmooth;

	public float androidSmooth;

	public bool EnableNoiseRemover;

	public float NoiseRemover;

	public bool ShootOnDoubleTouch;

	public bool DoubleTouchJump;

	public bool secondControll;

	public bool InvertMouseX;

	public bool InvertMouseY;

	public ControlSettingsValuesMapper(int AlphaColorControls, float sensivityX, float sensivityY, float smoothIn4Scope, bool WeaponAutoSwitch, bool lockFire, bool touch2, bool EnableSmooth, float androidSmooth, bool EnableNoiseRemover, float NoiseRemover, bool ShootOnDoubleTouch, bool DoubleTouchJump, bool secondControll, bool InvertMouseX, bool InvertMouseY)
	{
		this.AlphaColorControls = AlphaColorControls;
		this.sensivityX = sensivityX;
		this.sensivityY = sensivityY;
		this.smoothIn4Scope = smoothIn4Scope;
		this.WeaponAutoSwitch = WeaponAutoSwitch;
		this.lockFire = lockFire;
		this.touch2 = touch2;
		this.EnableSmooth = EnableSmooth;
		this.androidSmooth = androidSmooth;
		this.EnableNoiseRemover = EnableNoiseRemover;
		this.NoiseRemover = NoiseRemover;
		this.ShootOnDoubleTouch = ShootOnDoubleTouch;
		this.DoubleTouchJump = DoubleTouchJump;
		this.secondControll = secondControll;
		this.InvertMouseX = InvertMouseX;
		this.InvertMouseY = InvertMouseY;
	}
}
