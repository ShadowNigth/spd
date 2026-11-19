using System;
using UnityEngine;

[Serializable]
public class ControlSettingsMapper
{
	public string NameButton;

	public bool Hide;

	public float ButtonX;

	public float ButtonY;

	public Vector3 Scale;

	public ControlSettingsMapper(string NameButton, bool Hide, float ButtonX, float ButtonY, Vector3 Scale)
	{
		this.NameButton = NameButton;
		this.Hide = Hide;
		this.ButtonX = ButtonX;
		this.ButtonY = ButtonY;
		this.Scale = Scale;
	}
}
