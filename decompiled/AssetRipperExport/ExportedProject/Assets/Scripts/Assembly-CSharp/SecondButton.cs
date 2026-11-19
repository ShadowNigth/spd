using System.Collections.Generic;
using UnityEngine;

public class SecondButton : MonoBehaviour
{
	public List<GameObject> OldBtns;

	public List<GameObject> NewBtns;

	private bool Changed;

	public void Change()
	{
		if (!Changed)
		{
			Changed = true;
			foreach (GameObject oldBtn in OldBtns)
			{
				oldBtn.SetActive(false);
			}
			{
				foreach (GameObject newBtn in NewBtns)
				{
					newBtn.SetActive(true);
				}
				return;
			}
		}
		Changed = false;
		foreach (GameObject oldBtn2 in OldBtns)
		{
			oldBtn2.SetActive(true);
		}
		foreach (GameObject newBtn2 in NewBtns)
		{
			newBtn2.SetActive(false);
		}
	}
}
