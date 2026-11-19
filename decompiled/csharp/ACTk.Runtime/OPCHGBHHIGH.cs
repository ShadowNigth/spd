using System.Text;

internal static class OPCHGBHHIGH
{
	private static readonly char[] MGBEECGKHLI = new char[16]
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		'A', 'B', 'C', 'D', 'E', 'F'
	};

	public static byte[] FFDJCGDMOIJ(char[] MMKMICOONDG)
	{
		return Encoding.UTF8.GetBytes(MMKMICOONDG);
	}

	public static byte[] AEHGEAHFNOP(string MMKMICOONDG)
	{
		return Encoding.UTF8.GetBytes(MMKMICOONDG);
	}

	public static char[] PMJEPFHJNPM(byte[] MMKMICOONDG)
	{
		return Encoding.UTF8.GetChars(MMKMICOONDG);
	}

	public static string JMHHPCDPPAF(byte[] MMKMICOONDG)
	{
		return Encoding.UTF8.GetString(MMKMICOONDG);
	}

	public static string JMHHPCDPPAF(byte[] MMKMICOONDG, int JNDABHCJHHD, int GLNHGIPOIDP)
	{
		return Encoding.UTF8.GetString(MMKMICOONDG, JNDABHCJHHD, GLNHGIPOIDP);
	}

	public static string IODPFAOLGKO(byte[] MMKMICOONDG)
	{
		char[] array = new char[MMKMICOONDG.Length * 2];
		for (int i = 0; i < MMKMICOONDG.Length; i++)
		{
			int num = (MMKMICOONDG[i] ^ 0x90) & 0xFF;
			array[i * 2] = MGBEECGKHLI[num >>> 4];
			array[i * 2 + 1] = MGBEECGKHLI[num & 0xF];
		}
		return new string(array);
	}
}
