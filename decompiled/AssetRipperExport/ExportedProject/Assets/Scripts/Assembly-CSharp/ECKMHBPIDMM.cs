using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("Event/VR Input Module")]
public class ECKMHBPIDMM : BaseInputModule
{
	public static GameObject FAEFCHJMCDN;

	private static ECKMHBPIDMM OJNGMPHEHNA;

	private int BNKCGGAMLMD;

	private static bool KNFAPCOEIJE;

	public static Vector3 PGHLNJBACEK;

	protected override void Awake()
	{
		OJNGMPHEHNA = this;
	}

	public override void Process()
	{
		if (FAEFCHJMCDN == null)
		{
			KNFAPCOEIJE = false;
		}
	}

	public static void ODKIDIIMGAE(GameObject FFBEPGEKANM)
	{
		FAEFCHJMCDN = FFBEPGEKANM;
		KNFAPCOEIJE = true;
		if (KNFAPCOEIJE)
		{
			BaseEventData baseEventData = new BaseEventData(OJNGMPHEHNA.eventSystem);
			baseEventData.selectedObject = FAEFCHJMCDN;
			ExecuteEvents.Execute(FAEFCHJMCDN, baseEventData, ExecuteEvents.submitHandler);
			MonoBehaviour.print("clicked " + FAEFCHJMCDN.name);
			KNFAPCOEIJE = false;
		}
	}

	public static void ILFNPKMFCOJ(GameObject FFBEPGEKANM)
	{
		MonoBehaviour.print("PointerExit " + FFBEPGEKANM.name);
		PointerEventData eventData = new PointerEventData(OJNGMPHEHNA.eventSystem);
		ExecuteEvents.Execute(FFBEPGEKANM, eventData, ExecuteEvents.pointerExitHandler);
		ExecuteEvents.Execute(FFBEPGEKANM, eventData, ExecuteEvents.deselectHandler);
	}

	public static void FPGALCJDMFC(GameObject FFBEPGEKANM)
	{
		MonoBehaviour.print("PointerEnter " + FFBEPGEKANM.name);
		PointerEventData pointerEventData = new PointerEventData(OJNGMPHEHNA.eventSystem);
		pointerEventData.pointerEnter = FFBEPGEKANM;
		RaycastResult pointerCurrentRaycast = new RaycastResult
		{
			worldPosition = PGHLNJBACEK
		};
		pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
		ExecuteEvents.Execute(FFBEPGEKANM, pointerEventData, ExecuteEvents.pointerEnterHandler);
	}
}
