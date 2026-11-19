using System;
using UnityEngine;

namespace SPD.Audio
{
	[Serializable]
	public class BankEntry : ScriptableObject
	{
		public float Volume = 1f;

		public float Pitch = 1f;

		public bool RandomClip;

		public AudioClip Clip;

		public AudioClip[] Clips;

		public AudioClip GetClip()
		{
			return (!RandomClip) ? Clip : Clips.Random();
		}

		public AudioClip GetClipByIndex(int i)
		{
			return (!RandomClip) ? Clip : Clips[i];
		}
	}
}
