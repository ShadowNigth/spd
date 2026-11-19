using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("Event/Extensions/GamePad Input Module")]
public class JCGHELOADKA : BaseInputModule
{
	private float KJMNIPLPIIE;

	private Vector2 IKNCJNFHKHA;

	private int BJEGKDAFPFD;

	[SerializeField]
	private string m_HorizontalAxis = "Horizontal";

	[SerializeField]
	private string m_VerticalAxis = "Vertical";

	[SerializeField]
	private string m_SubmitButton = "Submit";

	[SerializeField]
	private string m_CancelButton = "Cancel";

	[SerializeField]
	private float m_InputActionsPerSecond = 10f;

	[SerializeField]
	private float m_RepeatDelay = 0.1f;

	public float OGBDCJFEHDB
	{
		get
		{
			return m_InputActionsPerSecond;
		}
		set
		{
			m_InputActionsPerSecond = value;
		}
	}

	public float ALLCGGOMJJG
	{
		get
		{
			return m_RepeatDelay;
		}
		set
		{
			m_RepeatDelay = value;
		}
	}

	public string EJKJLODIKAE
	{
		get
		{
			return m_HorizontalAxis;
		}
		set
		{
			m_HorizontalAxis = value;
		}
	}

	public string NICEACJDALB
	{
		get
		{
			return m_VerticalAxis;
		}
		set
		{
			m_VerticalAxis = value;
		}
	}

	public string FFDMMAIKFJE
	{
		get
		{
			return m_SubmitButton;
		}
		set
		{
			m_SubmitButton = value;
		}
	}

	public string LDIIKFONNLP
	{
		get
		{
			return m_CancelButton;
		}
		set
		{
			m_CancelButton = value;
		}
	}

	protected JCGHELOADKA()
	{
	}

	public override bool ShouldActivateModule()
	{
		if (!base.ShouldActivateModule())
		{
			return false;
		}
		bool flag = true;
		flag |= UnityEngine.Input.GetButtonDown(m_SubmitButton);
		flag |= UnityEngine.Input.GetButtonDown(m_CancelButton);
		flag |= !Mathf.Approximately(UnityEngine.Input.GetAxisRaw(m_HorizontalAxis), 0f);
		return flag | !Mathf.Approximately(UnityEngine.Input.GetAxisRaw(m_VerticalAxis), 0f);
	}

	public override void ActivateModule()
	{
		StandaloneInputModule component = GetComponent<StandaloneInputModule>();
		if ((bool)component && component.enabled)
		{
			Debug.LogError("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use");
		}
		base.ActivateModule();
		GameObject gameObject = base.eventSystem.currentSelectedGameObject;
		if (gameObject == null)
		{
			gameObject = base.eventSystem.firstSelectedGameObject;
		}
		base.eventSystem.SetSelectedGameObject(gameObject, GetBaseEventData());
	}

	public override void DeactivateModule()
	{
		base.DeactivateModule();
	}

	public override void Process()
	{
		bool flag = OPKLMJGDKOH();
		if (base.eventSystem.sendNavigationEvents)
		{
			if (!flag)
			{
				flag |= IEOONJNAELI();
			}
			if (!flag)
			{
				KPKGANKKBKP();
			}
		}
	}

	protected bool KPKGANKKBKP()
	{
		if (base.eventSystem.currentSelectedGameObject == null)
		{
			return false;
		}
		BaseEventData baseEventData = GetBaseEventData();
		if (UnityEngine.Input.GetButtonDown(m_SubmitButton))
		{
			ExecuteEvents.Execute(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
		}
		if (UnityEngine.Input.GetButtonDown(m_CancelButton))
		{
			ExecuteEvents.Execute(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
		}
		return baseEventData.used;
	}

	private Vector2 FAMILKDGDHM()
	{
		Vector2 zero = Vector2.zero;
		zero.x = UnityEngine.Input.GetAxisRaw(m_HorizontalAxis);
		zero.y = UnityEngine.Input.GetAxisRaw(m_VerticalAxis);
		if (UnityEngine.Input.GetButtonDown(m_HorizontalAxis))
		{
			if (zero.x < 0f)
			{
				zero.x = -1f;
			}
			if (zero.x > 0f)
			{
				zero.x = 1f;
			}
		}
		if (UnityEngine.Input.GetButtonDown(m_VerticalAxis))
		{
			if (zero.y < 0f)
			{
				zero.y = -1f;
			}
			if (zero.y > 0f)
			{
				zero.y = 1f;
			}
		}
		return zero;
	}

	protected bool IEOONJNAELI()
	{
		float unscaledTime = Time.unscaledTime;
		Vector2 vector = FAMILKDGDHM();
		if (Mathf.Approximately(vector.x, 0f) && Mathf.Approximately(vector.y, 0f))
		{
			BJEGKDAFPFD = 0;
			return false;
		}
		bool flag = UnityEngine.Input.GetButtonDown(m_HorizontalAxis) || UnityEngine.Input.GetButtonDown(m_VerticalAxis);
		bool flag2 = Vector2.Dot(vector, IKNCJNFHKHA) > 0f;
		if (!flag)
		{
			flag = ((!flag2 || BJEGKDAFPFD != 1) ? (unscaledTime > KJMNIPLPIIE + 1f / m_InputActionsPerSecond) : (unscaledTime > KJMNIPLPIIE + m_RepeatDelay));
		}
		if (!flag)
		{
			return false;
		}
		AxisEventData axisEventData = GetAxisEventData(vector.x, vector.y, 0.6f);
		ExecuteEvents.Execute(base.eventSystem.currentSelectedGameObject, axisEventData, ExecuteEvents.moveHandler);
		if (!flag2)
		{
			BJEGKDAFPFD = 0;
		}
		BJEGKDAFPFD++;
		KJMNIPLPIIE = unscaledTime;
		IKNCJNFHKHA = vector;
		return axisEventData.used;
	}

	protected bool OPKLMJGDKOH()
	{
		if (base.eventSystem.currentSelectedGameObject == null)
		{
			return false;
		}
		BaseEventData baseEventData = GetBaseEventData();
		ExecuteEvents.Execute(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
		return baseEventData.used;
	}
}
