using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/BestFit Outline")]
public class CMFLDAAKDJK : Shadow
{
	protected CMFLDAAKDJK()
	{
	}

	public override void ModifyMesh(Mesh FAHIHINKFMC)
	{
		if (!IsActive())
		{
			return;
		}
		List<UIVertex> list = new List<UIVertex>();
		using (VertexHelper vertexHelper = new VertexHelper(FAHIHINKFMC))
		{
			vertexHelper.GetUIVertexStream(list);
		}
		Text component = GetComponent<Text>();
		float num = 1f;
		if ((bool)component && component.resizeTextForBestFit)
		{
			num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
		}
		int start = 0;
		int count = list.Count;
		ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, base.effectDistance.x * num, base.effectDistance.y * num);
		start = count;
		count = list.Count;
		ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, base.effectDistance.x * num, (0f - base.effectDistance.y) * num);
		start = count;
		count = list.Count;
		ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, (0f - base.effectDistance.x) * num, base.effectDistance.y * num);
		start = count;
		count = list.Count;
		ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, (0f - base.effectDistance.x) * num, (0f - base.effectDistance.y) * num);
		using VertexHelper vertexHelper2 = new VertexHelper();
		vertexHelper2.AddUIVertexTriangleStream(list);
		vertexHelper2.FillMesh(FAHIHINKFMC);
	}
}
