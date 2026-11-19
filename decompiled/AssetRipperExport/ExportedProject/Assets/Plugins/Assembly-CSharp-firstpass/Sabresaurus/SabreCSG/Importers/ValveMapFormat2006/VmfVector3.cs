namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006
{
	public class VmfVector3
	{
		public float X;

		public float Y;

		public float Z;

		public VmfVector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString()
		{
			return "VmfVector3 (X=" + X + ", Y=" + Y + ", Z=" + Z + ")";
		}
	}
}
