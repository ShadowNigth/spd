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
		CBKKNOHGABL.text += string.Format("From {0} at Index {1} \n", KCDECOKLIAN.FromList.name, KCDECOKLIAN.FromIndex);
		CBKKNOHGABL.text += string.Format("To {0} at Index {1} \n", KCDECOKLIAN.ToList.name, KCDECOKLIAN.ToIndex);
	}
}
