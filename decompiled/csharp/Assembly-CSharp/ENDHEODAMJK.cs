using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text), typeof(RectTransform))]
[AddComponentMenu("UI/Effects/Extensions/Curved Text")]
public class ENDHEODAMJK : BaseMeshEffect
{
	[SerializeField]
	private AnimationCurve _curveForText = AnimationCurve.Linear(0f, 0f, 1f, 10f);

	[SerializeField]
	private float _curveMultiplier = 1f;

	private RectTransform NIKILPJFCBI;

	public AnimationCurve CINFAMOECFD
	{
		get
		{
			return _curveForText;
		}
		set
		{
			_curveForText = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public float NEEAOMPNINF
	{
		get
		{
			return _curveMultiplier;
		}
		set
		{
			_curveMultiplier = value;
			base.graphic.SetVerticesDirty();
		}
	}

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
		int currentVertCount = MDEPPJOMAOE.currentVertCount;
		if (IsActive() && currentVertCount != 0)
		{
			for (int i = 0; i < MDEPPJOMAOE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				MDEPPJOMAOE.PopulateUIVertex(ref vertex, i);
				vertex.position.y += _curveForText.Evaluate(NIKILPJFCBI.rect.width * NIKILPJFCBI.pivot.x + vertex.position.x) * _curveMultiplier;
				MDEPPJOMAOE.SetUIVertex(vertex, i);
			}
		}
	}

	protected override void OnRectTransformDimensionsChange()
	{
		if ((bool)NIKILPJFCBI)
		{
			Keyframe key = _curveForText[_curveForText.length - 1];
			key.time = NIKILPJFCBI.rect.width;
			_curveForText.MoveKey(_curveForText.length - 1, key);
		}
	}
}
