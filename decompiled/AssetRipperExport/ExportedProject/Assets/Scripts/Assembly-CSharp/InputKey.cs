using System;
using UnityEngine;

[Serializable]
public class InputKey
{
	public string name = string.Empty;

	public KeyCode key;

	public KeyCode keySet;

	public string axisName = string.Empty;

	public float axis;

	internal float oldAxis;
}
