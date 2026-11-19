using System.Collections.Generic;

namespace Sabresaurus.SabreCSG.Importers.Quake1;

public class MapEntity
{
	public string ClassName;

	public List<MapBrush> Brushes = new List<MapBrush>();

	public override string ToString()
	{
		return "Quake 1 Entity " + ClassName + " (" + Brushes.Count + " Brushes)";
	}
}
