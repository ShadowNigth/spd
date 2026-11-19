using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/Cylinder Text")]
[RequireComponent(typeof(Text), typeof(RectTransform))]
public class PNOOHIPMJOA : BaseMeshEffect
{
	public float DOGLMPODLGL;

	private RectTransform NIKILPJFCBI;

	protected override void Awake()
	{
		base.Awake();
		NIKILPJFCBI = GetComponent<RectTransform>();
		OnRectTransformDimensionsChange();
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		NIKILPJFCBI = GetComponent<RectTransform>();
		OnRectTransformDimensionsChange();
	}

	public override void ModifyMesh(VertexHelper MDEPPJOMAOE)
	{
		if (!IsActive())
		{
			return;
		}
		int currentVertCount = MDEPPJOMAOE.currentVertCount;
		if (IsActive() && currentVertCount != 0)
		{
			for (int i = 0; i < MDEPPJOMAOE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				MDEPPJOMAOE.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = (0f - DOGLMPODLGL) * Mathf.Cos(x / DOGLMPODLGL);
				vertex.position.x = DOGLMPODLGL * Mathf.Sin(x / DOGLMPODLGL);
				MDEPPJOMAOE.SetUIVertex(vertex, i);
			}
		}
	}
}
