using System.Collections.Generic;
using System.Linq;

namespace Sabresaurus.SabreCSG.Importers.Quake1
{
	public class MapWorld
	{
		public List<MapEntity> Entities = new List<MapEntity>();

		public List<MapBrush> Brushes
		{
			get
			{
				return (from e in Entities
					where e.ClassName == "worldspawn"
					select e.Brushes).FirstOrDefault();
			}
		}
	}
}
