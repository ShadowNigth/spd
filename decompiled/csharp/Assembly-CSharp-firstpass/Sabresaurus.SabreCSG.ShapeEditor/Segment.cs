using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG.ShapeEditor;

[Serializable]
public class Segment : ISelectable
{
	[SerializeField]
	private Vector2Int _position;

	[SerializeField]
	public SegmentType type;

	[SerializeField]
	public Pivot bezierPivot1 = new Pivot();

	[SerializeField]
	public Pivot bezierPivot2 = new Pivot();

	[SerializeField]
	public int bezierDetail = 3;

	public Vector2Int position
	{
		get
		{
			return _position;
		}
		set
		{
			_position = value;
		}
	}

	public Segment(int x, int y)
	{
		position = new Vector2Int(x, y);
	}
}
