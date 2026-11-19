using UnityEngine;

internal class LFHFAFOPFIO
{
	public static string AIFFINGHGMF(int JMBJALGFMPA)
	{
		char[] array = new char[JMBJALGFMPA];
		DCDNEAFHFKB(array);
		return new string(array);
	}

	internal static byte LEKELLEGIPE()
	{
		return (byte)IEELPBLNLNP.ELLEHDLDFEB(100, 255);
	}

	internal static sbyte LPOJDDINHAN()
	{
		return (sbyte)IEELPBLNLNP.ELLEHDLDFEB(100, 127);
	}

	internal static char FJKMPNOHNBN()
	{
		return (char)IEELPBLNLNP.ELLEHDLDFEB(10000, 60000);
	}

	internal static short BDCLEDLADKM()
	{
		return (short)IEELPBLNLNP.ELLEHDLDFEB(10000, 32767);
	}

	internal static ushort HNMOBICLMCM()
	{
		return (ushort)IEELPBLNLNP.ELLEHDLDFEB(10000, 65535);
	}

	internal static int LDCFDMADKJP()
	{
		return IEELPBLNLNP.ELLEHDLDFEB(1000000000, int.MaxValue);
	}

	internal static uint IBDHCIJCBLM()
	{
		return (uint)LDCFDMADKJP();
	}

	internal static long JDMIDOCOJPL()
	{
		return LDCFDMADKJP();
	}

	internal static ulong GMBLKBCBBMJ()
	{
		return (ulong)JDMIDOCOJPL();
	}

	internal static char[] DCDNEAFHFKB(char[] EONBHJFLNBJ = null)
	{
		if (EONBHJFLNBJ == null)
		{
			EONBHJFLNBJ = new char[7];
		}
		else if (EONBHJFLNBJ.Length < 7)
		{
			Debug.LogWarning("[ACTk] Passed arrayToFill length is less than minimum required 7 chars. Allocating new array instead.");
			EONBHJFLNBJ = new char[7];
		}
		IEELPBLNLNP.KALDONPEEKM(EONBHJFLNBJ);
		return EONBHJFLNBJ;
	}
}
