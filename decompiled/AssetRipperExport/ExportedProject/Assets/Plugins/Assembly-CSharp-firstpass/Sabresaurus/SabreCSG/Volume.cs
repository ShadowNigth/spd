using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	[Serializable]
	public class Volume : ScriptableObject
	{
		public virtual void OnCreateVolume(GameObject volume)
		{
		}
	}
}
