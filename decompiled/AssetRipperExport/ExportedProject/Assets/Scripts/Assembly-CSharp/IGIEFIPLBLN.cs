using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Layout/Extensions/Curved Layout")]
public class IGIEFIPLBLN : LayoutGroup
{
	public Vector3 MBFIMGCMLLO;

	[Tooltip("axis along which to place the items, Normalized before use")]
	public Vector3 DLDNLHABCMH;

	[Tooltip("size of each item along the Normalized axis")]
	public float GBBMOANOHAG;

	public float HGABOCNGGGK = 0.5f;

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
		Vector2 pivot = new Vector2((float)((int)base.childAlignment % 3) * 0.5f, (float)((int)base.childAlignment / 3) * 0.5f);
		Vector3 vector = new Vector3(GetStartOffset(0, GetTotalPreferredSize(0)), GetStartOffset(1, GetTotalPreferredSize(1)), 0f);
		float num = 0f;
		float num2 = 1f / (float)base.transform.childCount;
		Vector3 vector2 = DLDNLHABCMH.normalized * GBBMOANOHAG;
		for (int i = 0; i < base.transform.childCount; i++)
		{
			RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
			if (rectTransform != null)
			{
				m_Tracker.Add(this, rectTransform, DrivenTransformProperties.Anchors | DrivenTransformProperties.AnchoredPosition | DrivenTransformProperties.Pivot);
				Vector3 vector3 = vector + vector2;
				vector = (rectTransform.localPosition = vector3 + (num - HGABOCNGGGK) * MBFIMGCMLLO);
				rectTransform.pivot = pivot;
				Vector2 anchorMin = (rectTransform.anchorMax = new Vector2(0.5f, 0.5f));
				rectTransform.anchorMin = anchorMin;
				num += num2;
			}
		}
	}
}
