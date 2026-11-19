using UnityEngine;

namespace Sabresaurus.SabreCSG.Volumes
{
	public class TriggerVolumeComponent : MonoBehaviour
	{
		public TriggerVolumeTriggerType triggerType;

		public bool useFilterTag;

		public string filterTag = "Untagged";

		public LayerMask layer = -1;

		public bool triggerOnceOnly;

		public TriggerVolumeEvent onEnterEvent;

		public TriggerVolumeEvent onStayEvent;

		public TriggerVolumeEvent onExitEvent;

		private bool canTrigger = true;

		private void OnTriggerEnter(Collider other)
		{
			if (onEnterEvent.GetPersistentEventCount() == 0 || (useFilterTag && other.tag != filterTag) || !layer.Contains(other.gameObject.layer))
			{
				return;
			}
			if (!triggerOnceOnly)
			{
				canTrigger = true;
			}
			if (canTrigger)
			{
				if (triggerOnceOnly)
				{
					canTrigger = false;
				}
				if (triggerType == TriggerVolumeTriggerType.UnityEvent)
				{
					onEnterEvent.Invoke();
				}
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (onExitEvent.GetPersistentEventCount() == 0 || (useFilterTag && other.tag != filterTag) || !layer.Contains(other.gameObject.layer))
			{
				return;
			}
			if (!triggerOnceOnly)
			{
				canTrigger = true;
			}
			if (canTrigger)
			{
				if (triggerOnceOnly)
				{
					canTrigger = false;
				}
				if (triggerType == TriggerVolumeTriggerType.UnityEvent)
				{
					onExitEvent.Invoke();
				}
			}
		}

		private void OnTriggerStay(Collider other)
		{
			if (onStayEvent.GetPersistentEventCount() == 0 || (useFilterTag && other.tag != filterTag) || !layer.Contains(other.gameObject.layer))
			{
				return;
			}
			if (!triggerOnceOnly)
			{
				canTrigger = true;
			}
			if (canTrigger)
			{
				if (triggerOnceOnly)
				{
					canTrigger = false;
				}
				if (triggerType == TriggerVolumeTriggerType.UnityEvent)
				{
					onStayEvent.Invoke();
				}
			}
		}
	}
}
