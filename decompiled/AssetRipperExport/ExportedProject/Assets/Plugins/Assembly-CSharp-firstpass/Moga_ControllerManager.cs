using UnityEngine;

public class Moga_ControllerManager : MonoBehaviour
{
	[HideInInspector]
	public KeyCode p1ButtonA = KeyCode.Joystick1Button14;

	[HideInInspector]
	public KeyCode p1ButtonB = KeyCode.Joystick1Button13;

	[HideInInspector]
	public KeyCode p1ButtonX = KeyCode.Joystick1Button15;

	[HideInInspector]
	public KeyCode p1ButtonY = KeyCode.Joystick1Button12;

	[HideInInspector]
	public KeyCode p1ButtonL1 = KeyCode.Joystick1Button8;

	[HideInInspector]
	public KeyCode p1ButtonR1 = KeyCode.Joystick1Button9;

	[HideInInspector]
	public KeyCode p1ButtonSelect = KeyCode.Joystick1Button1;

	[HideInInspector]
	public KeyCode p1ButtonStart = KeyCode.Joystick1Button0;

	[HideInInspector]
	public KeyCode p1ButtonL3 = KeyCode.Joystick1Button2;

	[HideInInspector]
	public KeyCode p1ButtonR3 = KeyCode.Joystick1Button3;

	[HideInInspector]
	public KeyCode p1ButtonL2 = KeyCode.Joystick1Button10;

	[HideInInspector]
	public KeyCode p1ButtonR2 = KeyCode.Joystick1Button11;

	[HideInInspector]
	public KeyCode p1ButtonDPadUp = KeyCode.Joystick1Button6;

	[HideInInspector]
	public KeyCode p1ButtonDPadDown = KeyCode.Joystick1Button7;

	[HideInInspector]
	public KeyCode p1ButtonDPadLeft = KeyCode.Joystick1Button4;

	[HideInInspector]
	public KeyCode p1ButtonDPadRight = KeyCode.Joystick1Button5;

	[HideInInspector]
	public string p1AxisHorizontal = "Horizontal";

	[HideInInspector]
	public string p1AxisVertical = "Vertical";

	[HideInInspector]
	public string p1AxisLookHorizontal = "LookHorizontal";

	[HideInInspector]
	public string p1AxisLookVertical = "LookVertical";

	[HideInInspector]
	public string p1AxisL2 = "L2";

	[HideInInspector]
	public string p1AxisR2 = "R2";

	[HideInInspector]
	public static Moga_Controller sMogaController;

	private bool mFocused;

	private void Awake()
	{
		if (sMogaController == null)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			AndroidJavaObject activity = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			AndroidJavaObject instance = Moga_Controller.getInstance(activity);
			sMogaController = new Moga_Controller(activity, instance);
			sMogaController.init();
		}
	}

	private void OnApplicationFocus(bool focus)
	{
		mFocused = focus;
		if (mFocused && sMogaController != null)
		{
			sMogaController.onResume();
		}
	}

	private void OnDestroy()
	{
		if (sMogaController != null)
		{
			sMogaController.onExit();
		}
	}

	public bool isControllerConnected()
	{
		if (sMogaController.getState(1) == 1)
		{
			return true;
		}
		return false;
	}

	public int numberOfConnectedControllers()
	{
		return sMogaController.getInfo(1);
	}

	public bool isControllerMogaPro()
	{
		if (sMogaController.getState(4) == 1)
		{
			return true;
		}
		return false;
	}
}
