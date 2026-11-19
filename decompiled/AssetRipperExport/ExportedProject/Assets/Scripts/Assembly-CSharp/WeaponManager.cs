using System;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
	[Serializable]
	public class WeaponSpawn
	{
		public string WeaponAliasName;

		public int Ammo;

		public bool Silencer;

		public int Clips;
	}

	public bool DisableWeapons;

	public string[] ApprovedWeapons;

	public WeaponSpawn[] SpawnWeapons;
}
