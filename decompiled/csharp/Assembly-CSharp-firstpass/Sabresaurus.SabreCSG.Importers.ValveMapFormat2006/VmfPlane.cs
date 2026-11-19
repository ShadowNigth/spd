namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006;

public class VmfPlane
{
	public VmfVector3 P1;

	public VmfVector3 P2;

	public VmfVector3 P3;

	public VmfPlane(VmfVector3 p1, VmfVector3 p2, VmfVector3 p3)
	{
		P1 = p1;
		P2 = p2;
		P3 = p3;
	}

	public override string ToString()
	{
		return string.Concat("VmfPlane (P1=", P1, ", P2=", P2, ", P3=", P3, ")");
	}
}
