namespace Sabresaurus.SabreCSG.Importers.UnrealGold;

public class T3dRotator
{
	public int Pitch { get; set; }

	public int Yaw { get; set; }

	public int Roll { get; set; }

	public T3dRotator()
	{
	}

	public T3dRotator(int pitch, int yaw, int roll)
	{
		Pitch = pitch;
		Yaw = yaw;
		Roll = roll;
	}

	public override string ToString()
	{
		return "Pitch: " + Pitch + ", Yaw: " + Yaw + ", Roll: " + Roll;
	}
}
