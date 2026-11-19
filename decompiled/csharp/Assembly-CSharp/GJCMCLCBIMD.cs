using System;
using UnityEngine;
using UnityEngine.EventSystems;

[AddComponentMenu("UI/Extensions/UI Window Base")]
[RequireComponent(typeof(RectTransform))]
public class GJCMCLCBIMD : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IEventSystemHandler
{
	private RectTransform KFEFIEHDLHP;

	private bool PPNFCDJOGCO;

	public static bool EHDOOPNJKDK;

	private Vector3 BLJHEJCJMCL = Vector3.zero;

	private Canvas ADPOABHCBLM;

	private RectTransform NEGLMCEEKMK;

	public int KMFKHCIKLOF = 5;

	private void Start()
	{
		KFEFIEHDLHP = GetComponent<RectTransform>();
		BLJHEJCJMCL = KFEFIEHDLHP.position;
		ADPOABHCBLM = GetComponentInParent<Canvas>();
		NEGLMCEEKMK = ADPOABHCBLM.GetComponent<RectTransform>();
	}

	private void Update()
	{
		if (EHDOOPNJKDK)
		{
			HDODKBPJMAH();
		}
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (PPNFCDJOGCO)
		{
			Vector3 vector = EFFBBMMKLAN(GBOFEMOALII.position) - EFFBBMMKLAN(GBOFEMOALII.position - GBOFEMOALII.delta);
			KFEFIEHDLHP.localPosition += vector;
		}
	}

	public void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		if (!(GBOFEMOALII.pointerCurrentRaycast.gameObject == null) && GBOFEMOALII.pointerCurrentRaycast.gameObject.name == base.name)
		{
			PPNFCDJOGCO = true;
		}
	}

	public void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		PPNFCDJOGCO = false;
	}

	private void HDODKBPJMAH()
	{
		KFEFIEHDLHP.position = BLJHEJCJMCL;
		EHDOOPNJKDK = false;
	}

	private Vector3 EFFBBMMKLAN(Vector3 ENBOOMPFEPO)
	{
		Vector2 sizeDelta = NEGLMCEEKMK.sizeDelta;
		Vector3 result;
		Vector2 vector;
		Vector2 vector2;
		if (ADPOABHCBLM.renderMode == RenderMode.ScreenSpaceOverlay || (ADPOABHCBLM.renderMode == RenderMode.ScreenSpaceCamera && ADPOABHCBLM.worldCamera == null))
		{
			result = ENBOOMPFEPO;
			vector = Vector2.zero;
			vector2 = sizeDelta;
		}
		else
		{
			Ray ray = ADPOABHCBLM.worldCamera.ScreenPointToRay(ENBOOMPFEPO);
			if (!new Plane(NEGLMCEEKMK.forward, NEGLMCEEKMK.position).Raycast(ray, out var enter))
			{
				throw new Exception("Is it practically possible?");
			}
			Vector3 position = ray.origin + ray.direction * enter;
			result = NEGLMCEEKMK.InverseTransformPoint(position);
			vector = -Vector2.Scale(sizeDelta, NEGLMCEEKMK.pivot);
			vector2 = Vector2.Scale(sizeDelta, Vector2.one - NEGLMCEEKMK.pivot);
		}
		result.x = Mathf.Clamp(result.x, vector.x + (float)KMFKHCIKLOF, vector2.x - (float)KMFKHCIKLOF);
		result.y = Mathf.Clamp(result.y, vector.y + (float)KMFKHCIKLOF, vector2.y - (float)KMFKHCIKLOF);
		return result;
	}
}
