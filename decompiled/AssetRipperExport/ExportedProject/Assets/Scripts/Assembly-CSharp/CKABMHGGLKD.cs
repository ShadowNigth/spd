using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("Event/Extensions/Aimer Input Module")]
[RequireComponent(typeof(EventSystem))]
public class CKABMHGGLKD : PointerInputModule
{
	public string IPMFAFHKECI = "Submit";

	public Vector2 OPFOAEGMICA = new Vector2(0f, 0f);

	public static GameObject IHEJFOKDLMF;

	protected CKABMHGGLKD()
	{
	}

	public override void ActivateModule()
	{
		StandaloneInputModule component = GetComponent<StandaloneInputModule>();
		if (component != null && component.enabled)
		{
			Debug.LogError("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
		}
	}

	public override void Process()
	{
		bool buttonDown = UnityEngine.Input.GetButtonDown(IPMFAFHKECI);
		bool buttonUp = UnityEngine.Input.GetButtonUp(IPMFAFHKECI);
		PointerEventData pointerEventData = JJBOMJFGEEC();
		CNBBHCFFEEJ(pointerEventData, buttonDown, buttonUp);
		if (!buttonUp)
		{
			ProcessMove(pointerEventData);
		}
		else
		{
			RemovePointerData(pointerEventData);
		}
	}

	protected virtual PointerEventData JJBOMJFGEEC()
	{
		PointerEventData data;
		GetPointerData(-2, out data, true);
		data.Reset();
		data.position = new Vector2((float)Screen.width * 0.5f, (float)Screen.height * 0.5f) + OPFOAEGMICA;
		base.eventSystem.RaycastAll(data, m_RaycastResultCache);
		RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(m_RaycastResultCache);
		data.pointerCurrentRaycast = pointerCurrentRaycast;
		m_RaycastResultCache.Clear();
		return data;
	}

	private void CNBBHCFFEEJ(PointerEventData MLKIGIOHEJK, bool LFPOGGCKHGF, bool MEDEMPHCEJE)
	{
		GameObject gameObject = MLKIGIOHEJK.pointerCurrentRaycast.gameObject;
		IHEJFOKDLMF = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
		if (LFPOGGCKHGF)
		{
			MLKIGIOHEJK.eligibleForClick = true;
			MLKIGIOHEJK.delta = Vector2.zero;
			MLKIGIOHEJK.pressPosition = MLKIGIOHEJK.position;
			MLKIGIOHEJK.pointerPressRaycast = MLKIGIOHEJK.pointerCurrentRaycast;
			GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy(gameObject, MLKIGIOHEJK, ExecuteEvents.submitHandler);
			if (gameObject2 == null)
			{
				gameObject2 = ExecuteEvents.ExecuteHierarchy(gameObject, MLKIGIOHEJK, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
			}
			else
			{
				MLKIGIOHEJK.eligibleForClick = false;
			}
			if (gameObject2 != MLKIGIOHEJK.pointerPress)
			{
				MLKIGIOHEJK.pointerPress = gameObject2;
				MLKIGIOHEJK.rawPointerPress = gameObject;
				MLKIGIOHEJK.clickCount = 0;
			}
			MLKIGIOHEJK.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
			if (MLKIGIOHEJK.pointerDrag != null)
			{
				ExecuteEvents.Execute(MLKIGIOHEJK.pointerDrag, MLKIGIOHEJK, ExecuteEvents.beginDragHandler);
			}
		}
		if (!MEDEMPHCEJE)
		{
			return;
		}
		ExecuteEvents.Execute(MLKIGIOHEJK.pointerPress, MLKIGIOHEJK, ExecuteEvents.pointerUpHandler);
		GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
		if (MLKIGIOHEJK.pointerPress == eventHandler && MLKIGIOHEJK.eligibleForClick)
		{
			float unscaledTime = Time.unscaledTime;
			if (unscaledTime - MLKIGIOHEJK.clickTime < 0.3f)
			{
				MLKIGIOHEJK.clickCount++;
			}
			else
			{
				MLKIGIOHEJK.clickCount = 1;
			}
			MLKIGIOHEJK.clickTime = unscaledTime;
			ExecuteEvents.Execute(MLKIGIOHEJK.pointerPress, MLKIGIOHEJK, ExecuteEvents.pointerClickHandler);
		}
		else if (MLKIGIOHEJK.pointerDrag != null)
		{
			ExecuteEvents.ExecuteHierarchy(gameObject, MLKIGIOHEJK, ExecuteEvents.dropHandler);
		}
		MLKIGIOHEJK.eligibleForClick = false;
		MLKIGIOHEJK.pointerPress = null;
		MLKIGIOHEJK.rawPointerPress = null;
		if (MLKIGIOHEJK.pointerDrag != null)
		{
			ExecuteEvents.Execute(MLKIGIOHEJK.pointerDrag, MLKIGIOHEJK, ExecuteEvents.endDragHandler);
		}
		MLKIGIOHEJK.pointerDrag = null;
	}

	public override void DeactivateModule()
	{
		base.DeactivateModule();
		ClearSelection();
	}
}
