using System.Collections.Generic;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold
{
	public class T3dPolygon
	{
		public List<T3dVector3> Vertices = new List<T3dVector3>();

		public string Item { get; set; }

		public string Texture { get; set; }

		public T3dPolygonFlags Flags { get; set; }

		public T3dVector3 Origin { get; set; }

		public T3dVector3 Normal { get; set; }

		public T3dVector3 TextureU { get; set; }

		public T3dVector3 TextureV { get; set; }

		public int PanU { get; set; }

		public int PanV { get; set; }

		public override string ToString()
		{
			return "Unreal Engine 1 Brush Polygon \"" + Item + "\" (" + Vertices.Count + " Vertices)";
		}
	}
}
