namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006
{
	public class VmfSolidSide
	{
		public int Id = -1;

		public VmfPlane Plane;

		public string Material;

		public float Rotation;

		public VmfAxis UAxis;

		public VmfAxis VAxis;

		public int LightmapScale;

		public int SmoothingGroups;

		public bool HasDisplacement;

		public override string ToString()
		{
			return "VMF Solid Side " + Id + " '" + Material + "'  " + Plane;
		}
	}
}
