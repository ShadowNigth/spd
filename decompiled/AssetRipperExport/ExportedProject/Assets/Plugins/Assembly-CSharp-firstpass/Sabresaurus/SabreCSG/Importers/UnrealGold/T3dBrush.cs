using System.Collections.Generic;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold
{
	public class T3dBrush
	{
		public string Name;

		public List<T3dPolygon> Polygons = new List<T3dPolygon>();

		public T3dBrush(string name)
		{
			Name = name;
		}

		public override string ToString()
		{
			return "Unreal Engine 1 Brush Model \"" + Name + "\" (" + Polygons.Count + " Polygons)";
		}
	}
}
