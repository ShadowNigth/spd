using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("Event/Extensions/Tab Navigation Helper")]
[RequireComponent(typeof(EventSystem))]
public class COKDJMDHAPK : MonoBehaviour
{
	private EventSystem NHDBFMGNPBB;

	private Selectable KPKBBEKNJDJ;

	private Selectable MGDMPADEBCN;

	[Tooltip("The path to take when user is tabbing through ui components.")]
	public Selectable[] KMFCNLKGMFJ;

	[Tooltip("Use the default Unity navigation system or a manual fixed order using Navigation Path")]
	public ACNHODEKDIL GECBKONLDEO;

	[Tooltip("If True, this will loop the tab order from last to first automatically")]
	public bool CJBHAHOGPKM;

	private void Start()
	{
		NHDBFMGNPBB = GetComponent<EventSystem>();
		if (NHDBFMGNPBB == null)
		{
			Debug.LogError("Needs to be attached to the Event System component in the scene");
		}
		if (GECBKONLDEO == ACNHODEKDIL.FPIMDFBPKOI && KMFCNLKGMFJ.Length > 0)
		{
			KPKBBEKNJDJ = KMFCNLKGMFJ[0].gameObject.GetComponent<Selectable>();
		}
		if (KPKBBEKNJDJ == null && CJBHAHOGPKM)
		{
			NGLFJFPHJFM(out KPKBBEKNJDJ);
		}
	}

	public void Update()
	{
		Selectable ECGNIEAODDJ = null;
		if (MGDMPADEBCN == null && NHDBFMGNPBB.currentSelectedGameObject != null)
		{
			ECGNIEAODDJ = NHDBFMGNPBB.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
			while (ECGNIEAODDJ != null)
			{
				MGDMPADEBCN = ECGNIEAODDJ;
				ECGNIEAODDJ = ECGNIEAODDJ.FindSelectableOnDown();
			}
		}
		if (UnityEngine.Input.GetKeyDown(KeyCode.Tab) && UnityEngine.Input.GetKey(KeyCode.LeftShift))
		{
			if (GECBKONLDEO == ACNHODEKDIL.FPIMDFBPKOI && KMFCNLKGMFJ.Length > 0)
			{
				for (int num = KMFCNLKGMFJ.Length - 1; num >= 0; num--)
				{
					if (!(NHDBFMGNPBB.currentSelectedGameObject != KMFCNLKGMFJ[num].gameObject))
					{
						ECGNIEAODDJ = ((num != 0) ? KMFCNLKGMFJ[num - 1] : KMFCNLKGMFJ[KMFCNLKGMFJ.Length - 1]);
						break;
					}
				}
			}
			else if (NHDBFMGNPBB.currentSelectedGameObject != null)
			{
				ECGNIEAODDJ = NHDBFMGNPBB.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				if (ECGNIEAODDJ == null && CJBHAHOGPKM)
				{
					ECGNIEAODDJ = MGDMPADEBCN;
				}
			}
			else
			{
				NGLFJFPHJFM(out ECGNIEAODDJ);
			}
		}
		else if (UnityEngine.Input.GetKeyDown(KeyCode.Tab))
		{
			if (GECBKONLDEO == ACNHODEKDIL.FPIMDFBPKOI && KMFCNLKGMFJ.Length > 0)
			{
				for (int i = 0; i < KMFCNLKGMFJ.Length; i++)
				{
					if (!(NHDBFMGNPBB.currentSelectedGameObject != KMFCNLKGMFJ[i].gameObject))
					{
						ECGNIEAODDJ = ((i != KMFCNLKGMFJ.Length - 1) ? KMFCNLKGMFJ[i + 1] : KMFCNLKGMFJ[0]);
						break;
					}
				}
			}
			else if (NHDBFMGNPBB.currentSelectedGameObject != null)
			{
				ECGNIEAODDJ = NHDBFMGNPBB.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				if (ECGNIEAODDJ == null && CJBHAHOGPKM)
				{
					ECGNIEAODDJ = KPKBBEKNJDJ;
				}
			}
			else
			{
				NGLFJFPHJFM(out ECGNIEAODDJ);
			}
		}
		else if (NHDBFMGNPBB.currentSelectedGameObject == null)
		{
			NGLFJFPHJFM(out ECGNIEAODDJ);
		}
		if (CJBHAHOGPKM && KPKBBEKNJDJ == null)
		{
			KPKBBEKNJDJ = ECGNIEAODDJ;
		}
		IMGLNDLJNLH(ECGNIEAODDJ);
	}

	private void NGLFJFPHJFM(out Selectable ECGNIEAODDJ)
	{
		if ((bool)NHDBFMGNPBB.firstSelectedGameObject)
		{
			ECGNIEAODDJ = NHDBFMGNPBB.firstSelectedGameObject.GetComponent<Selectable>();
		}
		else
		{
			ECGNIEAODDJ = null;
		}
	}

	private void IMGLNDLJNLH(Selectable DCJIIFODKFE)
	{
		if (DCJIIFODKFE != null)
		{
			InputField component = DCJIIFODKFE.GetComponent<InputField>();
			if (component != null)
			{
				component.OnPointerClick(new PointerEventData(NHDBFMGNPBB));
			}
			NHDBFMGNPBB.SetSelectedGameObject(DCJIIFODKFE.gameObject, new BaseEventData(NHDBFMGNPBB));
		}
	}
}
