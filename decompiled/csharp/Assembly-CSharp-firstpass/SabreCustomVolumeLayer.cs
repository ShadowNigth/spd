using Sabresaurus.SabreCSG;
using UnityEngine;

public class SabreCustomVolumeLayer : Volume
{
	public enum Layer
	{
		Default,
		TransparentFX,
		IgnoreRaycast,
		None3,
		Water,
		UI,
		None6,
		None7,
		IgnoreColl,
		C4,
		Level,
		Player,
		Dead,
		MiniMap,
		PlayerClip,
		Effect,
		Cull,
		Ladder,
		Glass,
		Weapon,
		IgnoreColl2,
		Grenade,
		hands,
		BombClip,
		Physics,
		GrenadeClip,
		Destroyable,
		PlayerMine,
		Door,
		Hitbox,
		Clip,
		Entity
	}

	public Layer layer;

	public override void OnCreateVolume(GameObject volume)
	{
		volume.layer = (int)layer;
	}
}
