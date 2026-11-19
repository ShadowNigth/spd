namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006;

public class VmfAxis
{
	public VmfVector3 Vector;

	public float Translation;

	public float Scale;

	public VmfAxis(VmfVector3 vector, float translation, float scale)
	{
		Vector = vector;
		Translation = translation;
		Scale = scale;
	}

	public override string ToString()
	{
		return string.Concat("VmfAxis ", Vector, ", T=", Translation, ", S=", Scale);
	}
}
