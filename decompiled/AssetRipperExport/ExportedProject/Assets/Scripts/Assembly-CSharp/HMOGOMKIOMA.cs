using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Layout/Extensions/NonDrawingGraphic")]
public class HMOGOMKIOMA : MaskableGraphic
{
	public override void SetMaterialDirty()
	{
	}

	public override void SetVerticesDirty()
	{
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		MDEPPJOMAOE.Clear();
	}
}
