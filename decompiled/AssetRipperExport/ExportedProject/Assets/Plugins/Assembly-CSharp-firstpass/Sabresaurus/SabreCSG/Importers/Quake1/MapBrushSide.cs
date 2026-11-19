namespace Sabresaurus.SabreCSG.Importers.Quake1
{
	public class MapBrushSide
	{
		public MapPlane Plane;

		public string Material;

		public MapVector2 Offset;

		public float Rotation;

		public MapVector2 Scale;

		public override string ToString()
		{
			return "Quake 1 Brush Side  '" + Material + "'  " + Plane;
		}
	}
}
