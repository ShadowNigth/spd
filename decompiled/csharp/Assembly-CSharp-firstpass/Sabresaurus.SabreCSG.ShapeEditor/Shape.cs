using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG.ShapeEditor;

[Serializable]
public class Shape
{
	[SerializeField]
	public List<Segment> segments = new List<Segment>
	{
		new Segment(-8, -8),
		new Segment(8, -8),
		new Segment(8, 8),
		new Segment(-8, 8)
	};

	public Pivot pivot = new Pivot();

	public void CalculatePivotPosition()
	{
		Vector2Int vector2Int = default(Vector2Int);
		foreach (Segment segment in segments)
		{
			vector2Int += segment.position;
		}
		pivot.position = new Vector2Int(vector2Int.x / segments.Count, vector2Int.y / segments.Count);
	}

	public Shape Clone()
	{
		return JsonUtility.FromJson<Shape>(JsonUtility.ToJson(this));
	}
}
