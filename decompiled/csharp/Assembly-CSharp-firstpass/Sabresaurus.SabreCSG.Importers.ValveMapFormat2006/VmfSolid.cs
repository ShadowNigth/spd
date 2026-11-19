using System.Collections.Generic;

namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006;

public class VmfSolid
{
	public int Id = -1;

	public List<VmfSolidSide> Sides = new List<VmfSolidSide>();

	public override string ToString()
	{
		return "VMF Solid " + Id + " (" + Sides.Count + " Sides)";
	}
}
