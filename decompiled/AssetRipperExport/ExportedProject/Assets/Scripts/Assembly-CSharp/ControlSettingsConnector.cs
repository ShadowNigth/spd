using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ControlSettingsConnector
{
	[SerializeField]
	public ControlSettingsValuesMapper ControlSettingsValuesMapper;

	[SerializeField]
	public List<ControlSettingsMapper> ControlSettingsMapper;
}
