using UnityEngine;

internal static class CBONCPDADKB
{
	public static bool COGIBGGPEGJ(ref Color MIEPDOFPFKD, Color AAHPIGOGNEJ)
	{
		if (MIEPDOFPFKD.r == AAHPIGOGNEJ.r && MIEPDOFPFKD.g == AAHPIGOGNEJ.g && MIEPDOFPFKD.b == AAHPIGOGNEJ.b && MIEPDOFPFKD.a == AAHPIGOGNEJ.a)
		{
			return false;
		}
		MIEPDOFPFKD = AAHPIGOGNEJ;
		return true;
	}

	public static bool NOINEEJPMBG<T>(ref T MIEPDOFPFKD, T AAHPIGOGNEJ) where T : struct
	{
		if (MIEPDOFPFKD.Equals(AAHPIGOGNEJ))
		{
			return false;
		}
		MIEPDOFPFKD = AAHPIGOGNEJ;
		return true;
	}

	public static bool KDINNNBJOID<T>(ref T MIEPDOFPFKD, T AAHPIGOGNEJ) where T : class
	{
		if ((MIEPDOFPFKD == null && AAHPIGOGNEJ == null) || (MIEPDOFPFKD != null && MIEPDOFPFKD.Equals(AAHPIGOGNEJ)))
		{
			return false;
		}
		MIEPDOFPFKD = AAHPIGOGNEJ;
		return true;
	}
}
