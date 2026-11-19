namespace Sabresaurus.SabreCSG.Importers.UnrealGold
{
	public class T3dVector3
	{
		public float X { get; set; }

		public float Y { get; set; }

		public float Z { get; set; }

		public T3dVector3()
		{
		}

		public T3dVector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString()
		{
			return "X: " + X + ", Y: " + Y + ", Z: " + Z;
		}
	}
}
