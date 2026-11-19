namespace Sabresaurus.SabreCSG.Importers.Quake1;

public class MapPlane
{
	public MapVector3 P1;

	public MapVector3 P2;

	public MapVector3 P3;

	public MapPlane(MapVector3 p1, MapVector3 p2, MapVector3 p3)
	{
		P1 = p1;
		P2 = p2;
		P3 = p3;
	}

	public override string ToString()
	{
		return string.Concat("Quake 1 Plane (P1=", P1, ", P2=", P2, ", P3=", P3, ")");
	}
}
