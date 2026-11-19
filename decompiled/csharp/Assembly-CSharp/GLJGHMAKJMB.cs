using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Return Key Trigger")]
[RequireComponent(typeof(InputField))]
public class GLJGHMAKJMB : MonoBehaviour, ISubmitHandler, IEventSystemHandler
{
	private EventSystem NHDBFMGNPBB;

	public Button PMHLHIIDMEG;

	private bool FHOPLPFAEPK = true;

	public float NJONJKLLNBK = 0.2f;

	private void Start()
	{
		NHDBFMGNPBB = EventSystem.current;
	}

	private void OPIIELMHBCE()
	{
		PMHLHIIDMEG.OnPointerExit(new PointerEventData(NHDBFMGNPBB));
	}

	public void OnSubmit(BaseEventData GBOFEMOALII)
	{
		if (FHOPLPFAEPK)
		{
			PMHLHIIDMEG.OnPointerEnter(new PointerEventData(NHDBFMGNPBB));
		}
		PMHLHIIDMEG.OnPointerClick(new PointerEventData(NHDBFMGNPBB));
		if (FHOPLPFAEPK)
		{
			Invoke("OPIIELMHBCE", NJONJKLLNBK);
		}
	}
}
