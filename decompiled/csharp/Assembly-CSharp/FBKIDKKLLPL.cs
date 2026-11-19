using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Read Only Input Field", 32)]
public class FBKIDKKLLPL : InputField
{
	private Event FEFNAAKPBCE = new Event();

	public override void OnUpdateSelected(BaseEventData GBOFEMOALII)
	{
		if (!base.isFocused)
		{
			return;
		}
		bool flag = false;
		while (Event.PopEvent(FEFNAAKPBCE))
		{
			if (FEFNAAKPBCE.rawType == EventType.KeyDown && BBBMJGMBJGN(FEFNAAKPBCE))
			{
				flag = true;
				EditState editState = KeyPressed(FEFNAAKPBCE);
				if (editState == EditState.Finish)
				{
					DeactivateInputField();
					break;
				}
			}
		}
		if (flag)
		{
			UpdateLabel();
		}
		GBOFEMOALII.Use();
	}

	private bool BBBMJGMBJGN(Event EEOICAIGPJJ)
	{
		EventModifiers modifiers = EEOICAIGPJJ.modifiers;
		RuntimePlatform platform = Application.platform;
		bool flag = ((platform != 0 && platform != RuntimePlatform.OSXPlayer && platform != RuntimePlatform.WebGLPlayer) ? ((modifiers & EventModifiers.Control) != 0) : ((modifiers & EventModifiers.Command) != 0));
		switch (EEOICAIGPJJ.keyCode)
		{
		case KeyCode.Home:
		case KeyCode.End:
		case KeyCode.RightControl:
		case KeyCode.LeftControl:
			return true;
		case KeyCode.A:
			if (flag)
			{
				return true;
			}
			break;
		case KeyCode.C:
			if (flag)
			{
				return true;
			}
			break;
		case KeyCode.UpArrow:
		case KeyCode.DownArrow:
		case KeyCode.RightArrow:
		case KeyCode.LeftArrow:
			return true;
		}
		return false;
	}
}
