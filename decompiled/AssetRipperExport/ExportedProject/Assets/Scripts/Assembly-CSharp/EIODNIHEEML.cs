using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform), typeof(Graphic))]
[DisallowMultipleComponent]
[AddComponentMenu("UI/Effects/Extensions/Flippable")]
public class EIODNIHEEML : BaseMeshEffect
{
	[SerializeField]
	private bool m_Horizontal;

	[SerializeField]
	private bool m_Veritical;

	public bool PNGFLJGPKCN
	{
		get
		{
			return m_Horizontal;
		}
		set
		{
			m_Horizontal = value;
		}
	}

	public bool EBLKKJNKBNG
	{
		get
		{
			return m_Veritical;
		}
		set
		{
			m_Veritical = value;
		}
	}

	public override void ModifyMesh(VertexHelper AOBHAPDKDDC)
	{
		RectTransform rectTransform = base.transform as RectTransform;
		for (int i = 0; i < AOBHAPDKDDC.currentVertCount; i++)
		{
			UIVertex vertex = default(UIVertex);
			AOBHAPDKDDC.PopulateUIVertex(ref vertex, i);
			vertex.position = new Vector3((!m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 2f), (!m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 2f), vertex.position.z);
			AOBHAPDKDDC.SetUIVertex(vertex, i);
		}
	}
}
