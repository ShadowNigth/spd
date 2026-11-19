using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class IMBDMJKBDIL : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IEventSystemHandler
{
	[Tooltip("Can this element be dragged?")]
	public bool BCEKHHABPAC = true;

	[Tooltip("Can this element be transfered to another list")]
	public bool HAPKLKENKDB = true;

	[Tooltip("Can this element be dropped in space?")]
	public bool HNPOLGMAPOM;

	private readonly List<RaycastResult> GIIANPAPGIL = new List<RaycastResult>();

	private EHKBCGLPBEJ IJODLAAAFNG;

	private RectTransform KPEAEBBBFHJ;

	private LayoutElement NOKPLHMPAMB;

	private Vector2 DPFHGEPOOMI;

	private RectTransform IIMENMOFHLA;

	private LayoutElement GEDNOPGKNJC;

	private int CDIOHIMAHEN;

	private bool PPNFCDJOGCO;

	private RectTransform PNMINMLBAMJ;

	private EHKBCGLPBEJ CJCPDLLNKKP;

	internal bool GIFGFAEDJPH;

	public void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		GIFGFAEDJPH = true;
		if (CJCPDLLNKKP == null)
		{
			return;
		}
		if (!CJCPDLLNKKP.ODPJFLGCFJL || !BCEKHHABPAC)
		{
			KPEAEBBBFHJ = null;
			return;
		}
		if (!CJCPDLLNKKP.APKCNPCELFG)
		{
			KPEAEBBBFHJ = PNMINMLBAMJ;
			CDIOHIMAHEN = PNMINMLBAMJ.GetSiblingIndex();
			if (CJCPDLLNKKP.GGLIHHENCME != null)
			{
				CJCPDLLNKKP.GGLIHHENCME.Invoke(new EHKBCGLPBEJ.ReorderableListEventStruct
				{
					DroppedObject = KPEAEBBBFHJ.gameObject,
					IsAClone = CJCPDLLNKKP.APKCNPCELFG,
					SourceObject = ((!CJCPDLLNKKP.APKCNPCELFG) ? KPEAEBBBFHJ.gameObject : base.gameObject),
					FromList = CJCPDLLNKKP,
					FromIndex = CDIOHIMAHEN
				});
			}
			if (!GIFGFAEDJPH)
			{
				KPEAEBBBFHJ = null;
				return;
			}
		}
		else
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(base.gameObject);
			KPEAEBBBFHJ = gameObject.GetComponent<RectTransform>();
		}
		DPFHGEPOOMI = base.gameObject.GetComponent<RectTransform>().rect.size;
		NOKPLHMPAMB = KPEAEBBBFHJ.GetComponent<LayoutElement>();
		KPEAEBBBFHJ.SetParent(CJCPDLLNKKP.ELAFDHJFJHP, worldPositionStays: true);
		KPEAEBBBFHJ.SetAsLastSibling();
		IIMENMOFHLA = new GameObject("Fake").AddComponent<RectTransform>();
		GEDNOPGKNJC = IIMENMOFHLA.gameObject.AddComponent<LayoutElement>();
		DNHKLHCKKFC();
		if (CJCPDLLNKKP.GPFPPBBAEBO != null)
		{
			CJCPDLLNKKP.GPFPPBBAEBO.Invoke(new EHKBCGLPBEJ.ReorderableListEventStruct
			{
				DroppedObject = KPEAEBBBFHJ.gameObject,
				IsAClone = CJCPDLLNKKP.APKCNPCELFG,
				SourceObject = ((!CJCPDLLNKKP.APKCNPCELFG) ? KPEAEBBBFHJ.gameObject : base.gameObject),
				FromList = CJCPDLLNKKP,
				FromIndex = CDIOHIMAHEN
			});
			if (!GIFGFAEDJPH)
			{
				JIGEFBILIFB();
				return;
			}
		}
		PPNFCDJOGCO = true;
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (!PPNFCDJOGCO)
		{
			return;
		}
		if (!GIFGFAEDJPH)
		{
			JIGEFBILIFB();
			return;
		}
		Canvas componentInParent = KPEAEBBBFHJ.GetComponentInParent<Canvas>();
		RectTransformUtility.ScreenPointToWorldPointInRectangle(componentInParent.GetComponent<RectTransform>(), GBOFEMOALII.position, componentInParent.worldCamera, out var worldPoint);
		KPEAEBBBFHJ.position = worldPoint;
		EventSystem.current.RaycastAll(GBOFEMOALII, GIIANPAPGIL);
		for (int i = 0; i < GIIANPAPGIL.Count; i++)
		{
			IJODLAAAFNG = GIIANPAPGIL[i].gameObject.GetComponent<EHKBCGLPBEJ>();
			if (IJODLAAAFNG != null)
			{
				break;
			}
		}
		if (IJODLAAAFNG == null || !IJODLAAAFNG.HMLKNIFDGEB)
		{
			DNHKLHCKKFC();
			IIMENMOFHLA.transform.SetParent(CJCPDLLNKKP.ELAFDHJFJHP, worldPositionStays: false);
			return;
		}
		if (IIMENMOFHLA.parent != IJODLAAAFNG)
		{
			IIMENMOFHLA.SetParent(IJODLAAAFNG.OCFFACJAJKB, worldPositionStays: false);
		}
		float num = float.PositiveInfinity;
		int siblingIndex = 0;
		float num2 = 0f;
		for (int j = 0; j < IJODLAAAFNG.OCFFACJAJKB.childCount; j++)
		{
			RectTransform component = IJODLAAAFNG.OCFFACJAJKB.GetChild(j).GetComponent<RectTransform>();
			if (IJODLAAAFNG.HMHDADIFEOG is VerticalLayoutGroup)
			{
				num2 = Mathf.Abs(component.position.y - worldPoint.y);
			}
			else if (IJODLAAAFNG.HMHDADIFEOG is HorizontalLayoutGroup)
			{
				num2 = Mathf.Abs(component.position.x - worldPoint.x);
			}
			else if (IJODLAAAFNG.HMHDADIFEOG is GridLayoutGroup)
			{
				num2 = Mathf.Abs(component.position.x - worldPoint.x) + Mathf.Abs(component.position.y - worldPoint.y);
			}
			if (num2 < num)
			{
				num = num2;
				siblingIndex = j;
			}
		}
		DNHKLHCKKFC();
		IIMENMOFHLA.SetSiblingIndex(siblingIndex);
		IIMENMOFHLA.gameObject.SetActive(value: true);
	}

	public void OnEndDrag(PointerEventData GBOFEMOALII)
	{
		PPNFCDJOGCO = false;
		if (KPEAEBBBFHJ != null)
		{
			if (IJODLAAAFNG != null && IJODLAAAFNG.HMLKNIFDGEB && (HAPKLKENKDB || IJODLAAAFNG == CJCPDLLNKKP))
			{
				EHKBCGLPBEJ.ReorderableListEventStruct reorderableListEventStruct = default(EHKBCGLPBEJ.ReorderableListEventStruct);
				reorderableListEventStruct.DroppedObject = KPEAEBBBFHJ.gameObject;
				reorderableListEventStruct.IsAClone = CJCPDLLNKKP.APKCNPCELFG;
				reorderableListEventStruct.SourceObject = ((!CJCPDLLNKKP.APKCNPCELFG) ? KPEAEBBBFHJ.gameObject : base.gameObject);
				reorderableListEventStruct.FromList = CJCPDLLNKKP;
				reorderableListEventStruct.FromIndex = CDIOHIMAHEN;
				reorderableListEventStruct.ToList = IJODLAAAFNG;
				reorderableListEventStruct.ToIndex = IIMENMOFHLA.GetSiblingIndex();
				EHKBCGLPBEJ.ReorderableListEventStruct arg = reorderableListEventStruct;
				if ((bool)CJCPDLLNKKP && CJCPDLLNKKP.KCMELCDPPFE != null)
				{
					CJCPDLLNKKP.KCMELCDPPFE.Invoke(arg);
				}
				if (!GIFGFAEDJPH)
				{
					JIGEFBILIFB();
					return;
				}
				DNHKLHCKKFC();
				KPEAEBBBFHJ.SetParent(IJODLAAAFNG.OCFFACJAJKB, worldPositionStays: false);
				KPEAEBBBFHJ.rotation = IJODLAAAFNG.transform.rotation;
				KPEAEBBBFHJ.SetSiblingIndex(IIMENMOFHLA.GetSiblingIndex());
				CJCPDLLNKKP.AKCIPCOEGMB.Invoke(arg);
				if (!GIFGFAEDJPH)
				{
					throw new Exception("It's too late to cancel the Transfer! Do so in OnElementDropped!");
				}
			}
			else if (HNPOLGMAPOM)
			{
				CJCPDLLNKKP.KCMELCDPPFE.Invoke(new EHKBCGLPBEJ.ReorderableListEventStruct
				{
					DroppedObject = KPEAEBBBFHJ.gameObject,
					IsAClone = CJCPDLLNKKP.APKCNPCELFG,
					SourceObject = ((!CJCPDLLNKKP.APKCNPCELFG) ? KPEAEBBBFHJ.gameObject : base.gameObject),
					FromList = CJCPDLLNKKP,
					FromIndex = CDIOHIMAHEN
				});
			}
			else
			{
				JIGEFBILIFB();
			}
		}
		if (IIMENMOFHLA != null)
		{
			UnityEngine.Object.Destroy(IIMENMOFHLA.gameObject);
		}
	}

	private void JIGEFBILIFB()
	{
		PPNFCDJOGCO = false;
		if (CJCPDLLNKKP.APKCNPCELFG)
		{
			UnityEngine.Object.Destroy(KPEAEBBBFHJ.gameObject);
		}
		else
		{
			DNHKLHCKKFC();
			KPEAEBBBFHJ.SetParent(CJCPDLLNKKP.OCFFACJAJKB, worldPositionStays: false);
			KPEAEBBBFHJ.rotation = CJCPDLLNKKP.OCFFACJAJKB.transform.rotation;
			KPEAEBBBFHJ.SetSiblingIndex(CDIOHIMAHEN);
			EHKBCGLPBEJ.ReorderableListEventStruct reorderableListEventStruct = default(EHKBCGLPBEJ.ReorderableListEventStruct);
			reorderableListEventStruct.DroppedObject = KPEAEBBBFHJ.gameObject;
			reorderableListEventStruct.IsAClone = CJCPDLLNKKP.APKCNPCELFG;
			reorderableListEventStruct.SourceObject = ((!CJCPDLLNKKP.APKCNPCELFG) ? KPEAEBBBFHJ.gameObject : base.gameObject);
			reorderableListEventStruct.FromList = CJCPDLLNKKP;
			reorderableListEventStruct.FromIndex = CDIOHIMAHEN;
			reorderableListEventStruct.ToList = CJCPDLLNKKP;
			reorderableListEventStruct.ToIndex = CDIOHIMAHEN;
			EHKBCGLPBEJ.ReorderableListEventStruct arg = reorderableListEventStruct;
			CJCPDLLNKKP.AKCIPCOEGMB.Invoke(arg);
			if (!GIFGFAEDJPH)
			{
				throw new Exception("Transfer is already Cancelled.");
			}
		}
		if (IIMENMOFHLA != null)
		{
			UnityEngine.Object.Destroy(IIMENMOFHLA.gameObject);
		}
	}

	private void DNHKLHCKKFC()
	{
		Vector2 sizeDelta = DPFHGEPOOMI;
		if (IJODLAAAFNG != null && IJODLAAAFNG.HMLKNIFDGEB && IJODLAAAFNG.OCFFACJAJKB.childCount > 0)
		{
			Transform child = IJODLAAAFNG.OCFFACJAJKB.GetChild(0);
			if (child != null)
			{
				sizeDelta = child.GetComponent<RectTransform>().rect.size;
			}
		}
		KPEAEBBBFHJ.sizeDelta = sizeDelta;
		LayoutElement gEDNOPGKNJC = GEDNOPGKNJC;
		float y = sizeDelta.y;
		NOKPLHMPAMB.preferredHeight = y;
		gEDNOPGKNJC.preferredHeight = y;
		LayoutElement gEDNOPGKNJC2 = GEDNOPGKNJC;
		y = sizeDelta.x;
		NOKPLHMPAMB.preferredWidth = y;
		gEDNOPGKNJC2.preferredWidth = y;
	}

	public void HIBHJDCMMAJ(EHKBCGLPBEJ DDLDHGCPBLO)
	{
		CJCPDLLNKKP = DDLDHGCPBLO;
		PNMINMLBAMJ = GetComponent<RectTransform>();
	}
}
