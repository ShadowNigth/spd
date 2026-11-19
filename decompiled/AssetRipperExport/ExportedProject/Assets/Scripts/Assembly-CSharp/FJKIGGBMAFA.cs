using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Pagination Manager")]
public class FJKIGGBMAFA : ToggleGroup
{
	private List<Toggle> EJICDOHEAFN;

	[SerializeField]
	private CLLOJICBMEA scrollSnap;

	private bool KKHLDDCMBAI;

	public int PKKJBIDEMBH
	{
		get
		{
			return scrollSnap.PKKJBIDEMBH;
		}
	}

	protected FJKIGGBMAFA()
	{
	}

	protected override void Start()
	{
		base.Start();
		if (scrollSnap == null)
		{
			Debug.LogError("A ScrollSnap script must be attached");
			return;
		}
		if ((bool)scrollSnap.KHJIMAPPBHO)
		{
			scrollSnap.KHJIMAPPBHO = null;
		}
		scrollSnap.GLKMJNNPDKJ.AddListener(PIGECDLAILC);
		scrollSnap.PMNMBHFIACN.AddListener(JGCBNIFDNGN);
		EJICDOHEAFN = GetComponentsInChildren<Toggle>().ToList();
		for (int i = 0; i < EJICDOHEAFN.Count; i++)
		{
			EJICDOHEAFN[i].onValueChanged.AddListener(MGAOPILFFEK);
			EJICDOHEAFN[i].group = this;
			EJICDOHEAFN[i].isOn = false;
		}
		PIGECDLAILC(PKKJBIDEMBH);
		if (EJICDOHEAFN.Count != scrollSnap.MLGAAHHAMEN.content.childCount)
		{
			Debug.LogWarning("Uneven pagination icon to page count");
		}
	}

	public void KGIJFBMOJPM(int CJGGIOIEFGE)
	{
		scrollSnap.KGIJFBMOJPM(CJGGIOIEFGE);
	}

	private void MGAOPILFFEK(Toggle EPCKLAKNAAG)
	{
		if (!EPCKLAKNAAG.isOn)
		{
			KKHLDDCMBAI = true;
			KGIJFBMOJPM(EJICDOHEAFN.IndexOf(EPCKLAKNAAG));
		}
	}

	private void MGAOPILFFEK(bool DALIJHMFDNC)
	{
		if (!DALIJHMFDNC)
		{
			return;
		}
		for (int i = 0; i < EJICDOHEAFN.Count; i++)
		{
			if (EJICDOHEAFN[i].isOn)
			{
				KGIJFBMOJPM(i);
				break;
			}
		}
	}

	private void MGAOPILFFEK(int EPCKLAKNAAG)
	{
		KKHLDDCMBAI = true;
		KGIJFBMOJPM(EPCKLAKNAAG);
	}

	private void PIGECDLAILC(int CJGGIOIEFGE)
	{
		if (!KKHLDDCMBAI)
		{
			EJICDOHEAFN[CJGGIOIEFGE].isOn = true;
		}
	}

	private void JGCBNIFDNGN(int CJGGIOIEFGE)
	{
		KKHLDDCMBAI = false;
	}
}
