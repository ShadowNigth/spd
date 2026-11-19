using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/Re-orderable list")]
public class EHKBCGLPBEJ : MonoBehaviour
{
	[Serializable]
	public struct ReorderableListEventStruct
	{
		public GameObject DroppedObject;

		public int FromIndex;

		public EHKBCGLPBEJ FromList;

		public bool IsAClone;

		public GameObject SourceObject;

		public int ToIndex;

		public EHKBCGLPBEJ ToList;

		public void PECEKKFIPNH()
		{
			SourceObject.GetComponent<IMBDMJKBDIL>().GIFGFAEDJPH = false;
		}
	}

	[Serializable]
	public class ReorderableListHandler : UnityEvent<ReorderableListEventStruct>
	{
	}

	[Tooltip("Child container with re-orderable items in a layout group")]
	public LayoutGroup HMHDADIFEOG;

	[Tooltip("Parent area to draw the dragged element on top of containers. Defaults to the root Canvas")]
	public RectTransform ELAFDHJFJHP;

	[Tooltip("Can items be dragged from the container?")]
	public bool ODPJFLGCFJL = true;

	[Tooltip("Should the draggable components be removed or cloned?")]
	public bool APKCNPCELFG;

	[Tooltip("Can new draggable items be dropped in to the container?")]
	public bool HMLKNIFDGEB = true;

	[Header("UI Re-orderable Events")]
	public ReorderableListHandler KCMELCDPPFE = new ReorderableListHandler();

	public ReorderableListHandler GPFPPBBAEBO = new ReorderableListHandler();

	public ReorderableListHandler GGLIHHENCME = new ReorderableListHandler();

	public ReorderableListHandler AKCIPCOEGMB = new ReorderableListHandler();

	private RectTransform INNDDKDMMLK;

	private NGOENLEACHC ALFPDHHNFIB;

	public RectTransform OCFFACJAJKB
	{
		get
		{
			if (INNDDKDMMLK == null)
			{
				INNDDKDMMLK = HMHDADIFEOG.GetComponent<RectTransform>();
			}
			return INNDDKDMMLK;
		}
	}

	private Canvas DLAHOMHAEKD()
	{
		Transform parent = base.transform;
		Canvas canvas = null;
		int num = 100;
		int num2 = 0;
		while (canvas == null && num2 < num)
		{
			canvas = parent.gameObject.GetComponent<Canvas>();
			if (canvas == null)
			{
				parent = parent.parent;
			}
			num2++;
		}
		return canvas;
	}

	private void Awake()
	{
		if (HMHDADIFEOG == null)
		{
			Debug.LogError("You need to have a child LayoutGroup content set for the list: " + base.name, base.gameObject);
			return;
		}
		if (ELAFDHJFJHP == null)
		{
			ELAFDHJFJHP = base.transform.root.GetComponentInChildren<Canvas>().GetComponent<RectTransform>();
		}
		if (HMLKNIFDGEB && !GetComponent<Graphic>())
		{
			Debug.LogError("You need to have a Graphic control (such as an Image) for the list [" + base.name + "] to be droppable", base.gameObject);
			return;
		}
		ALFPDHHNFIB = HMHDADIFEOG.gameObject.AddComponent<NGOENLEACHC>();
		ALFPDHHNFIB.HIBHJDCMMAJ(this);
	}

	public void IIGHOMLCBLM(ReorderableListEventStruct JLOFICCFAPA)
	{
		Debug.Log("Event Received");
		Debug.Log("Hello World, is my item a clone? [" + JLOFICCFAPA.IsAClone + "]");
	}
}
