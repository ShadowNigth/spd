using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("UI/Extensions/Bound Tooltip/Tooltip Trigger")]
public class CNCMJMDJLAB : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
{
	[TextArea]
	public string KLLKONMADKA;

	public bool FCONLLDEFMH;

	public Vector3 DFHHDIMKIAN;

	public void OnPointerEnter(PointerEventData GBOFEMOALII)
	{
		if (FCONLLDEFMH)
		{
			LDPGFHPEKPG(new Vector3(GBOFEMOALII.position.x, GBOFEMOALII.position.y, 0f));
		}
		else
		{
			LDPGFHPEKPG(base.transform.position + DFHHDIMKIAN);
		}
	}

	public void OnSelect(BaseEventData GBOFEMOALII)
	{
		LDPGFHPEKPG(base.transform.position);
	}

	public void OnPointerExit(PointerEventData GBOFEMOALII)
	{
		IFGCMGFLNOF();
	}

	public void OnDeselect(BaseEventData GBOFEMOALII)
	{
		IFGCMGFLNOF();
	}

	private void LDPGFHPEKPG(Vector3 GIDEOJGAFJH)
	{
		GAIBIJFELIJ.KHGDLGJPCCA.LLPDIIKPAMP(KLLKONMADKA, GIDEOJGAFJH);
	}

	private void IFGCMGFLNOF()
	{
		GAIBIJFELIJ.KHGDLGJPCCA.MIJCNPJKAIG();
	}
}
