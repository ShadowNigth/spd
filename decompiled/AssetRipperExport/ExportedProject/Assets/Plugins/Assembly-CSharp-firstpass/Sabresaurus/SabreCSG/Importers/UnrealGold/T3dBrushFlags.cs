using System;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold
{
	[Flags]
	public enum T3dBrushFlags
	{
		Invisible = 1,
		Masked = 2,
		Transparent = 4,
		NonSolid = 8,
		SemiSolid = 0x20,
		ZonePortal = 0x4000000,
		TwoSided = 0x100
	}
}
