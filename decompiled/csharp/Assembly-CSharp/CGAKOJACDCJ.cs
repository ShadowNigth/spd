using System;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Layout/Extensions/Radial Layout")]
public class CGAKOJACDCJ : LayoutGroup
{
	public float BILAEINFGGM;

	[Range(0f, 360f)]
	public float BIPMLNHDIEG;

	[Range(0f, 360f)]
	public float ICNKPFDNLFE;

	[Range(0f, 360f)]
	public float JNIAKJCGPAD;

	protected override void OnEnable()
	{
		base.OnEnable();
		OOJHDIHOFIL();
	}

	public override void SetLayoutHorizontal()
	{
	}

	public override void SetLayoutVertical()
	{
	}

	public override void CalculateLayoutInputVertical()
	{
		OOJHDIHOFIL();
	}

	public override void CalculateLayoutInputHorizontal()
	{
		OOJHDIHOFIL();
	}

	private void OOJHDIHOFIL()
	{
		m_Tracker.Clear();
		if (base.transform.childCount == 0)
		{
			return;
		}
		float num = (ICNKPFDNLFE - BIPMLNHDIEG) / (float)base.transform.childCount;
		float num2 = JNIAKJCGPAD;
		for (int i = 0; i < base.transform.childCount; i++)
		{
			RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
			if (rectTransform != null)
			{
				m_Tracker.Add(this, rectTransform, DrivenTransformProperties.Anchors | DrivenTransformProperties.AnchoredPosition | DrivenTransformProperties.Pivot);
				Vector3 vector = new Vector3(Mathf.Cos(num2 * ((float)Math.PI / 180f)), Mathf.Sin(num2 * ((float)Math.PI / 180f)), 0f);
				rectTransform.localPosition = vector * BILAEINFGGM;
				Vector2 vector3 = (rectTransform.pivot = new Vector2(0.5f, 0.5f));
				vector3 = (rectTransform.anchorMax = vector3);
				rectTransform.anchorMin = vector3;
				num2 += num;
			}
		}
	}
}
