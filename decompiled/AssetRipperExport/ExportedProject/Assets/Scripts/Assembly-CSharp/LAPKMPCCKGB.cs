using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EventSystem))]
[AddComponentMenu("UI/Extensions/DragCorrector")]
public class LAPKMPCCKGB : MonoBehaviour
{
	public int ONBFGDLMPJM = 6;

	public int CCMKEJPHDFN = 210;

	public int EGKJGEGHCKM;

	private void Start()
	{
		EGKJGEGHCKM = ONBFGDLMPJM * (int)Screen.dpi / CCMKEJPHDFN;
		EventSystem component = GetComponent<EventSystem>();
		if ((bool)component)
		{
			component.pixelDragThreshold = EGKJGEGHCKM;
		}
	}
}
