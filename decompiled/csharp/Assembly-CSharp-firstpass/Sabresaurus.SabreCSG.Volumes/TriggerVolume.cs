using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Volumes;

[Serializable]
public class TriggerVolume : Volume
{
	[SerializeField]
	public TriggerVolumeTriggerType triggerType;

	[SerializeField]
	public bool useFilterTag;

	[SerializeField]
	public string filterTag = "Untagged";

	[SerializeField]
	public LayerMask layer = -1;

	[SerializeField]
	public bool triggerOnceOnly;

	[SerializeField]
	public TriggerVolumeEvent onEnterEvent;

	[SerializeField]
	public TriggerVolumeEvent onStayEvent;

	[SerializeField]
	public TriggerVolumeEvent onExitEvent;

	public override void OnCreateVolume(GameObject volume)
	{
		TriggerVolumeComponent triggerVolumeComponent = volume.AddComponent<TriggerVolumeComponent>();
		triggerVolumeComponent.triggerType = triggerType;
		triggerVolumeComponent.useFilterTag = useFilterTag;
		triggerVolumeComponent.filterTag = filterTag;
		triggerVolumeComponent.layer = layer;
		triggerVolumeComponent.triggerOnceOnly = triggerOnceOnly;
		triggerVolumeComponent.onEnterEvent = onEnterEvent;
		triggerVolumeComponent.onStayEvent = onStayEvent;
		triggerVolumeComponent.onExitEvent = onExitEvent;
	}
}
