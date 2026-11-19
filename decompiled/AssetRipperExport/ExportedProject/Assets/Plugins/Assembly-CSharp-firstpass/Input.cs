using System;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
	private enum ButtonState
	{
		RELEASED = 0,
		PRESSING = 1,
		PRESSED = 2,
		RELEASING = 3
	}

	public class Axis
	{
		public string name;

		public int id = -1;

		public float value;
	}

	public static Action<KeyCode> on_button_up_event = null;

	public static Action<KeyCode> on_button_down_event = null;

	private const float ANALOG_DEADZONE = 0.19f;

	private static GameObject mogaManager = null;

	private static Moga_ControllerManager mogaControllerManager = null;

	private static Dictionary<string, Axis> s_axes = new Dictionary<string, Axis>();

	private static Dictionary<int, ButtonState> s_buttons = new Dictionary<int, ButtonState>();

	private static Dictionary<string, int> s_strings_to_button = new Dictionary<string, int>();

	private static Dictionary<KeyCode, int> s_codes_to_buttons = new Dictionary<KeyCode, int>();

	private static Dictionary<int, KeyCode> s_buttons_to_codes = new Dictionary<int, KeyCode>();

	private static bool s_any_key_down = false;

	private static bool s_any_key = false;

	public static bool IsSupported
	{
		get
		{
			return true;
		}
	}

	public static Vector3 acceleration
	{
		get
		{
			return UnityEngine.Input.acceleration;
		}
	}

	public static int accelerationEventCount
	{
		get
		{
			return UnityEngine.Input.accelerationEventCount;
		}
	}

	public static bool anyKey
	{
		get
		{
			return s_any_key || UnityEngine.Input.anyKey;
		}
	}

	public static bool anyKeyDown
	{
		get
		{
			return s_any_key_down || UnityEngine.Input.anyKeyDown;
		}
	}

	public static Compass compass
	{
		get
		{
			return UnityEngine.Input.compass;
		}
	}

	public static string compositionString
	{
		get
		{
			return UnityEngine.Input.compositionString;
		}
	}

	public static Vector2 compositionCursorPos
	{
		get
		{
			return UnityEngine.Input.compositionCursorPos;
		}
	}

	public static DeviceOrientation deviceOrientation
	{
		get
		{
			return UnityEngine.Input.deviceOrientation;
		}
	}

	public static Gyroscope gyro
	{
		get
		{
			return UnityEngine.Input.gyro;
		}
	}

	public static IMECompositionMode imeCompositionMode
	{
		get
		{
			return UnityEngine.Input.imeCompositionMode;
		}
		set
		{
			UnityEngine.Input.imeCompositionMode = value;
		}
	}

	public static bool imeIsSelected
	{
		get
		{
			return UnityEngine.Input.imeIsSelected;
		}
	}

	public static string inputString
	{
		get
		{
			return UnityEngine.Input.inputString;
		}
	}

	public static Vector3 mousePosition
	{
		get
		{
			return UnityEngine.Input.mousePosition;
		}
	}

	public static bool multiTouchEnabled
	{
		get
		{
			return UnityEngine.Input.multiTouchEnabled;
		}
		set
		{
			UnityEngine.Input.multiTouchEnabled = value;
		}
	}

	public static int touchCount
	{
		get
		{
			return UnityEngine.Input.touchCount;
		}
	}

	public static Touch[] touches
	{
		get
		{
			return UnityEngine.Input.touches;
		}
	}

	public static LocationService location
	{
		get
		{
			Debug.LogError("Define GPS_ENABLED to use this property");
			return null;
		}
	}

	private void Update()
	{
		if (mogaManager == null || Moga_ControllerManager.sMogaController == null || !mogaControllerManager || !mogaControllerManager.isControllerConnected())
		{
			return;
		}
		foreach (KeyValuePair<string, Axis> s_axis in s_axes)
		{
			Axis value = s_axis.Value;
			value.value = Moga_ControllerManager.sMogaController.getAxisValue(value.id);
		}
		s_any_key_down = false;
		s_any_key = false;
		foreach (KeyValuePair<int, ButtonState> s_button in s_buttons)
		{
			int keyCode = Moga_ControllerManager.sMogaController.getKeyCode(s_button.Key);
			switch (s_button.Value)
			{
			case ButtonState.RELEASED:
				if (keyCode == 0)
				{
					s_buttons[s_button.Key] = ButtonState.PRESSING;
				}
				break;
			case ButtonState.PRESSING:
				if (keyCode == 1)
				{
					s_buttons[s_button.Key] = ButtonState.RELEASING;
				}
				else
				{
					s_buttons[s_button.Key] = ButtonState.PRESSED;
				}
				break;
			case ButtonState.PRESSED:
				s_any_key_down = true;
				s_any_key = true;
				if (keyCode == 1)
				{
					s_buttons[s_button.Key] = ButtonState.RELEASING;
				}
				break;
			case ButtonState.RELEASING:
				if (keyCode == 0)
				{
					s_buttons[s_button.Key] = ButtonState.PRESSING;
				}
				else
				{
					s_buttons[s_button.Key] = ButtonState.RELEASED;
				}
				break;
			}
			if (s_buttons[s_button.Key] == ButtonState.RELEASING && on_button_up_event != null)
			{
				on_button_up_event(s_buttons_to_codes[s_button.Key]);
			}
			else if (s_buttons[s_button.Key] == ButtonState.PRESSING && on_button_down_event != null)
			{
				on_button_down_event(s_buttons_to_codes[s_button.Key]);
			}
		}
	}

	public static void RegisterMogaController()
	{
		mogaManager = GameObject.Find("MogaControllerManager");
		if (mogaManager != null)
		{
			mogaControllerManager = mogaManager.GetComponent<Moga_ControllerManager>();
		}
		if (mogaControllerManager == null)
		{
			Debug.Log("MOGA Controller Manager could not be found.  Access the MOGA Menu to create one!");
		}
		else
		{
			MapController();
		}
	}

	private static void MapController()
	{
		RegisterInputKey(mogaControllerManager.p1ButtonA, 96);
		RegisterInputKey(mogaControllerManager.p1ButtonB, 97);
		RegisterInputKey(mogaControllerManager.p1ButtonX, 99);
		RegisterInputKey(mogaControllerManager.p1ButtonY, 100);
		RegisterInputKey(mogaControllerManager.p1ButtonL1, 102);
		RegisterInputKey(mogaControllerManager.p1ButtonR1, 103);
		RegisterInputKey(mogaControllerManager.p1ButtonSelect, 109);
		RegisterInputKey(mogaControllerManager.p1ButtonStart, 108);
		RegisterInputKey(mogaControllerManager.p1ButtonL3, 106);
		RegisterInputKey(mogaControllerManager.p1ButtonR3, 107);
		RegisterInputKey(mogaControllerManager.p1ButtonL2, 104);
		RegisterInputKey(mogaControllerManager.p1ButtonR2, 105);
		RegisterInputKey(mogaControllerManager.p1ButtonDPadUp, 19);
		RegisterInputKey(mogaControllerManager.p1ButtonDPadDown, 20);
		RegisterInputKey(mogaControllerManager.p1ButtonDPadLeft, 21);
		RegisterInputKey(mogaControllerManager.p1ButtonDPadRight, 22);
		RegisterInputAxis(mogaControllerManager.p1AxisHorizontal, 0);
		RegisterInputAxis(mogaControllerManager.p1AxisVertical, 1);
		RegisterInputAxis(mogaControllerManager.p1AxisLookHorizontal, 11);
		RegisterInputAxis(mogaControllerManager.p1AxisLookVertical, 14);
		RegisterInputAxis(mogaControllerManager.p1AxisL2, 17);
		RegisterInputAxis(mogaControllerManager.p1AxisR2, 18);
	}

	private static void RegisterInputAxis(string name, int id)
	{
		Axis value;
		if (!s_axes.TryGetValue(name, out value))
		{
			value = new Axis();
			s_axes[name] = value;
		}
		value.name = name;
		value.id = id;
		value.value = 0f;
	}

	private static void RegisterInputButton(string name, int button)
	{
		if (!s_strings_to_button.ContainsKey(name))
		{
			s_strings_to_button.Add(name, button);
			s_buttons.Add(button, ButtonState.RELEASED);
		}
	}

	private static void RegisterInputKey(KeyCode code, int buttonID)
	{
		if (!s_codes_to_buttons.ContainsKey(code))
		{
			s_codes_to_buttons.Add(code, buttonID);
			s_buttons_to_codes.Add(buttonID, code);
			s_buttons.Add(buttonID, ButtonState.RELEASED);
		}
	}

	public static AccelerationEvent GetAccelerationEvent(int index)
	{
		return UnityEngine.Input.GetAccelerationEvent(index);
	}

	public static float GetAxis(string axisName)
	{
		Axis value;
		if (s_axes.TryGetValue(axisName, out value) && Math.Abs(value.value) > 0.19f)
		{
			return value.value;
		}
		return UnityEngine.Input.GetAxis(axisName);
	}

	public static float GetAxisRaw(string axisName)
	{
		Axis value;
		if (s_axes.TryGetValue(axisName, out value) && Math.Abs(value.value) > 0.19f)
		{
			return value.value;
		}
		return UnityEngine.Input.GetAxisRaw(axisName);
	}

	public static bool GetButton(string buttonName)
	{
		int value;
		ButtonState value2;
		if (s_strings_to_button.TryGetValue(buttonName, out value) && s_buttons.TryGetValue(value, out value2) && (value2 == ButtonState.PRESSING || value2 == ButtonState.PRESSED))
		{
			return true;
		}
		return UnityEngine.Input.GetButton(buttonName);
	}

	public static bool GetButtonDown(string buttonName)
	{
		int value;
		ButtonState value2;
		if (s_strings_to_button.TryGetValue(buttonName, out value) && s_buttons.TryGetValue(value, out value2) && value2 == ButtonState.PRESSING)
		{
			return true;
		}
		return UnityEngine.Input.GetButtonDown(buttonName);
	}

	public static bool GetButtonUp(string buttonName)
	{
		int value;
		ButtonState value2;
		if (s_strings_to_button.TryGetValue(buttonName, out value) && s_buttons.TryGetValue(value, out value2) && value2 == ButtonState.RELEASING)
		{
			return true;
		}
		return UnityEngine.Input.GetButtonUp(buttonName);
	}

	public static string[] GetJoystickNames()
	{
		if ((bool)mogaControllerManager && mogaControllerManager.isControllerConnected())
		{
			return new string[1] { "Moga" };
		}
		return UnityEngine.Input.GetJoystickNames();
	}

	public static bool GetKey(KeyCode key)
	{
		int value;
		ButtonState value2;
		if (s_codes_to_buttons.TryGetValue(key, out value) && s_buttons.TryGetValue(value, out value2) && (value2 == ButtonState.PRESSING || value2 == ButtonState.PRESSED))
		{
			return true;
		}
		return UnityEngine.Input.GetKey(key);
	}

	public static bool GetKey(string name)
	{
		int value;
		ButtonState value2;
		if (s_strings_to_button.TryGetValue(name, out value) && s_buttons.TryGetValue(value, out value2) && (value2 == ButtonState.PRESSING || value2 == ButtonState.PRESSED))
		{
			return true;
		}
		return UnityEngine.Input.GetKey(name);
	}

	public static bool GetKeyDown(KeyCode key)
	{
		int value;
		ButtonState value2;
		if (s_codes_to_buttons.TryGetValue(key, out value) && s_buttons.TryGetValue(value, out value2) && value2 == ButtonState.PRESSING)
		{
			return true;
		}
		return UnityEngine.Input.GetKeyDown(key);
	}

	public static bool GetKeyDown(string name)
	{
		int value;
		ButtonState value2;
		if (s_strings_to_button.TryGetValue(name, out value) && s_buttons.TryGetValue(value, out value2) && value2 == ButtonState.PRESSING)
		{
			return true;
		}
		return UnityEngine.Input.GetKeyDown(name);
	}

	public static bool GetKeyUp(KeyCode key)
	{
		int value;
		ButtonState value2;
		if (s_codes_to_buttons.TryGetValue(key, out value) && s_buttons.TryGetValue(value, out value2) && value2 == ButtonState.RELEASING)
		{
			return true;
		}
		return UnityEngine.Input.GetKeyUp(key);
	}

	public static bool GetKeyUp(string name)
	{
		int value;
		ButtonState value2;
		if (s_strings_to_button.TryGetValue(name, out value) && s_buttons.TryGetValue(value, out value2) && value2 == ButtonState.RELEASING)
		{
			return true;
		}
		return UnityEngine.Input.GetKeyUp(name);
	}

	public static bool GetMouseButton(int button)
	{
		return UnityEngine.Input.GetMouseButton(button);
	}

	public static bool GetMouseButtonDown(int button)
	{
		return UnityEngine.Input.GetMouseButtonUp(button);
	}

	public static bool GetMouseButtonUp(int button)
	{
		return UnityEngine.Input.GetMouseButtonUp(button);
	}

	public static Touch GetTouch(int index)
	{
		return UnityEngine.Input.GetTouch(index);
	}

	public static void ResetInputAxes()
	{
		foreach (KeyValuePair<string, Axis> s_axis in s_axes)
		{
			Axis value = s_axis.Value;
			value.value = 0f;
		}
		foreach (KeyValuePair<int, ButtonState> s_button in s_buttons)
		{
			s_buttons[s_button.Key] = ButtonState.RELEASED;
		}
		UnityEngine.Input.ResetInputAxes();
	}
}
