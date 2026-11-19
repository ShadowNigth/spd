namespace Sabresaurus.SabreCSG.Importers.Quake1
{
	public class MapVector3
	{
		public float X;

		public float Y;

		public float Z;

		public MapVector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString()
		{
			return "Quake 1 Vector3 (X=" + X + ", Y=" + Y + ", Z=" + Z + ")";
		}
	}
}
