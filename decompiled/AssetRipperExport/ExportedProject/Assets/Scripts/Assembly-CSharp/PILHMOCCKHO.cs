using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/Letter Spacing")]
public class PILHMOCCKHO : BaseMeshEffect
{
	[SerializeField]
	private float m_spacing;

	public float BKPLPFDNLII
	{
		get
		{
			return m_spacing;
		}
		set
		{
			if (m_spacing != value)
			{
				m_spacing = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}
	}

	protected PILHMOCCKHO()
	{
	}

	public override void ModifyMesh(VertexHelper MDEPPJOMAOE)
	{
		if (!IsActive())
		{
			return;
		}
		List<UIVertex> list = new List<UIVertex>();
		MDEPPJOMAOE.GetUIVertexStream(list);
		Text component = GetComponent<Text>();
		if (component == null)
		{
			Debug.LogWarning("LetterSpacing: Missing Text component");
			return;
		}
		string[] array = component.text.Split('\n');
		float num = BKPLPFDNLII * (float)component.fontSize / 100f;
		float num2 = 0f;
		int num3 = 0;
		switch (component.alignment)
		{
		case TextAnchor.UpperLeft:
		case TextAnchor.MiddleLeft:
		case TextAnchor.LowerLeft:
			num2 = 0f;
			break;
		case TextAnchor.UpperCenter:
		case TextAnchor.MiddleCenter:
		case TextAnchor.LowerCenter:
			num2 = 0.5f;
			break;
		case TextAnchor.UpperRight:
		case TextAnchor.MiddleRight:
		case TextAnchor.LowerRight:
			num2 = 1f;
			break;
		}
		foreach (string text in array)
		{
			float num4 = (float)(text.Length - 1) * num * num2;
			for (int j = 0; j < text.Length; j++)
			{
				int index = num3 * 6;
				int index2 = num3 * 6 + 1;
				int index3 = num3 * 6 + 2;
				int index4 = num3 * 6 + 3;
				int index5 = num3 * 6 + 4;
				int num5 = num3 * 6 + 5;
				if (num5 > list.Count - 1)
				{
					return;
				}
				UIVertex value = list[index];
				UIVertex value2 = list[index2];
				UIVertex value3 = list[index3];
				UIVertex value4 = list[index4];
				UIVertex value5 = list[index5];
				UIVertex value6 = list[num5];
				Vector3 vector = Vector3.right * (num * (float)j - num4);
				value.position += vector;
				value2.position += vector;
				value3.position += vector;
				value4.position += vector;
				value5.position += vector;
				value6.position += vector;
				list[index] = value;
				list[index2] = value2;
				list[index3] = value3;
				list[index4] = value4;
				list[index5] = value5;
				list[num5] = value6;
				num3++;
			}
			num3++;
		}
		MDEPPJOMAOE.Clear();
		MDEPPJOMAOE.AddUIVertexTriangleStream(list);
	}
}
