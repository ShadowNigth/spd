using UnityEngine;

public static class HMCMONHGIPF
{
	public static Canvas PEGDBOBCHNE(this RectTransform AABJBHGEFPE)
	{
		RectTransform rectTransform = AABJBHGEFPE;
		Canvas canvas = AABJBHGEFPE.GetComponent<Canvas>();
		int num = 0;
		while (canvas == null || num > 50)
		{
			canvas = AABJBHGEFPE.GetComponentInParent<Canvas>();
			if (canvas == null)
			{
				rectTransform = rectTransform.parent.GetComponent<RectTransform>();
				num++;
			}
		}
		return canvas;
	}
}
