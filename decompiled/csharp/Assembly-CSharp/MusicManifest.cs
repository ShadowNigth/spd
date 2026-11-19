using System;
using UnityEngine;

public class MusicManifest : ScriptableObject
{
	[Serializable]
	public class BaseAudioSettings
	{
		public int Index;

		public float Volume = 1f;

		public float Pitch = 1f;

		public float FadeIn;

		public float FadeOut;
	}

	[Serializable]
	public class MusicGameStartup
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;
	}

	[Serializable]
	public class MusicRoundStart
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;

		public MusicRoundAction Action;
	}

	[Serializable]
	public class MusicRoundAction
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;
	}

	[Serializable]
	public class MusicRoundTenSeconds
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;
	}

	[Serializable]
	public class MusicBombPlanted
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;
	}

	[Serializable]
	public class MusicBombTenSeconds
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;
	}

	[Serializable]
	public class MusicWonRound
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;
	}

	[Serializable]
	public class MusicLostRound
	{
		public AudioClip Wave;

		public BaseAudioSettings Parameters;
	}

	public MusicGameStartup[] GameStartup;

	public MusicRoundStart[] RoundStart;

	public MusicRoundTenSeconds[] RoundTenSeconds;

	public MusicBombPlanted[] BombPlanted;

	public MusicBombTenSeconds[] BombTenSeconds;

	public MusicWonRound[] WonRound;

	public MusicLostRound[] LostRound;
}
