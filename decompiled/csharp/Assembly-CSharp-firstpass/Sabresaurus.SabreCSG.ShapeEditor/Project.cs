using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG.ShapeEditor;

[Serializable]
public class Project
{
	[SerializeField]
	public int version = 1;

	[SerializeField]
	public List<Shape> shapes = new List<Shape>
	{
		new Shape()
	};

	[SerializeField]
	public Pivot globalPivot = new Pivot();

	[SerializeField]
	public bool flipHorizontally;

	[SerializeField]
	public bool flipVertically;

	[SerializeField]
	public float extrudeDepth = 1f;

	[SerializeField]
	public float extrudeClipDepth = 0.5f;

	[SerializeField]
	public Vector2 extrudeScale = Vector2.one;

	[SerializeField]
	public int revolve360 = 8;

	[SerializeField]
	public int revolveSteps = 4;

	[SerializeField]
	public int revolveDistance = 1;

	[SerializeField]
	public int revolveRadius = 1;

	[SerializeField]
	public bool revolveDirection = true;

	[SerializeField]
	public bool revolveSpiralSloped;

	[SerializeField]
	public bool convexBrushes = true;

	public Project Clone()
	{
		return JsonUtility.FromJson<Project>(JsonUtility.ToJson(this));
	}
}
