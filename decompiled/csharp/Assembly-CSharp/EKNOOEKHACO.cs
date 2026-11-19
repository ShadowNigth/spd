using UnityEngine;
using UnityEngine.UI;

public class EKNOOEKHACO : MonoBehaviour
{
	public Text CBKKNOHGABL;

	private void Awake()
	{
		EHKBCGLPBEJ[] array = Object.FindObjectsOfType<EHKBCGLPBEJ>();
		foreach (EHKBCGLPBEJ eHKBCGLPBEJ in array)
		{
			eHKBCGLPBEJ.KCMELCDPPFE.AddListener(FJGFCJPCEIB);
		}
	}

	private void FJGFCJPCEIB(EHKBCGLPBEJ.ReorderableListEventStruct KCDECOKLIAN)
	{
		CBKKNOHGABL.text = string.Empty;
		Text cBKKNOHGABL = CBKKNOHGABL;
		cBKKNOHGABL.text = cBKKNOHGABL.text + "Dropped Object: " + KCDECOKLIAN.DroppedObject.name + "\n";
		Text cBKKNOHGABL2 = CBKKNOHGABL;
		string text = cBKKNOHGABL2.text;
		cBKKNOHGABL2.text = text + "Is Clone ?: " + KCDECOKLIAN.IsAClone + "\n";
		if (KCDECOKLIAN.IsAClone)
		{
			Text cBKKNOHGABL3 = CBKKNOHGABL;
			cBKKNOHGABL3.text = cBKKNOHGABL3.text + "Source Object: " + KCDECOKLIAN.SourceObject.name + "\n";
		}
		CBKKNOHGABL.text += $"From {KCDECOKLIAN.FromList.name} at Index {KCDECOKLIAN.FromIndex} \n";
		CBKKNOHGABL.text += $"To {KCDECOKLIAN.ToList.name} at Index {KCDECOKLIAN.ToIndex} \n";
	}
}
