using System;
using System.Collections.Generic;

[Serializable]
public struct BetterEvent
{
	public List<BetterEventEntry> Events;

	public void Invoke()
	{
		if (Events != null)
		{
			for (int i = 0; i < Events.Count; i++)
			{
				Events[i].Invoke();
			}
		}
	}
}
