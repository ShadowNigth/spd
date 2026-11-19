using System.Collections.Generic;

namespace Sabresaurus.SabreCSG.Importers.Quake1;

public class MapBrush
{
	public List<MapBrushSide> Sides = new List<MapBrushSide>();

	public override string ToString()
	{
		return "Quake 1 Brush  (" + Sides.Count + " Sides)";
	}
}
