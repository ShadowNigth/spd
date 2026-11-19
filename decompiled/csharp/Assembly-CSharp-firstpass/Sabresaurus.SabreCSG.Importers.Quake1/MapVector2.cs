namespace Sabresaurus.SabreCSG.Importers.Quake1;

public class MapVector2
{
	public float X;

	public float Y;

	public MapVector2(float x, float y)
	{
		X = x;
		Y = y;
	}

	public override string ToString()
	{
		return "Quake 1 Vector3 (X=" + X + ", Y=" + Y + ")";
	}
}
