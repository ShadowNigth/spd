using System;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Math;

[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
public class GOPEDBHCLMF
{
	private static byte[] KAIPIMNIHCB = new byte[148]
	{
		6, 2, 0, 0, 0, 164, 0, 0, 82, 83,
		65, 49, 0, 4, 0, 0, 1, 0, 1, 0,
		93, 97, 67, 254, 168, 74, 45, 222, 229, 18,
		52, 116, 229, 74, 98, 217, 216, 139, 216, 16,
		179, 99, 18, 124, 103, 58, 1, 146, 28, 46,
		36, 70, 237, 140, 92, 180, 145, 233, 208, 253,
		211, 136, 60, 129, 4, 140, 142, 120, 121, 195,
		239, 175, 18, 144, 235, 66, 160, 91, 194, 182,
		111, 42, 185, 107, 206, 214, 234, 2, 48, 141,
		2, 222, 176, 224, 19, 238, 81, 122, 90, 72,
		15, 93, 203, 155, 21, 164, 37, 45, 83, 202,
		60, 87, 194, 86, 158, 171, 106, 215, 189, 119,
		251, 4, 164, 153, 245, 238, 180, 39, 199, 45,
		84, 171, 143, 166, 175, 222, 208, 245, 40, 48,
		200, 197, 76, 28, 93, 96, 121, 164
	};

	private static int HDEEAPDAEAH = 128;

	private static int KHDKCJPPPJD = KAIPIMNIHCB[16] | (KAIPIMNIHCB[17] << 8) | (KAIPIMNIHCB[18] << 16);

	private static BigInteger ONIIKHKFMOE;

	static GOPEDBHCLMF()
	{
		byte[] array = new byte[HDEEAPDAEAH];
		Buffer.BlockCopy(KAIPIMNIHCB, 20, array, 0, HDEEAPDAEAH);
		Array.Reverse(array);
		ONIIKHKFMOE = new BigInteger(array);
	}

	private static string AAFBHBMPNCP(byte[] LCBKHLLPIGM)
	{
		int i;
		for (i = 0; i < LCBKHLLPIGM.Length && LCBKHLLPIGM[i] == 0; i++)
		{
		}
		if (i != LCBKHLLPIGM.Length)
		{
			byte[] array = new byte[LCBKHLLPIGM.Length - i];
			Buffer.BlockCopy(LCBKHLLPIGM, i, array, 0, LCBKHLLPIGM.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	public static string HBNEHFDNPFO(byte[] BKOEGJJBGBC, bool JFCMLIBFOLG)
	{
		if (BKOEGJJBGBC.Length == HDEEAPDAEAH)
		{
			BigInteger bigInteger = new BigInteger(BKOEGJJBGBC);
			byte[] bytes = bigInteger.ModPow(KHDKCJPPPJD, ONIIKHKFMOE).GetBytes();
			string text = AAFBHBMPNCP(bytes);
			if (JFCMLIBFOLG)
			{
				return text.Substring(1, text.Length - 2);
			}
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < BKOEGJJBGBC.Length / HDEEAPDAEAH; i++)
		{
			byte[] array = new byte[HDEEAPDAEAH];
			Buffer.BlockCopy(BKOEGJJBGBC, i * HDEEAPDAEAH, array, 0, HDEEAPDAEAH);
			BigInteger bigInteger2 = new BigInteger(array);
			byte[] bytes2 = bigInteger2.ModPow(KHDKCJPPPJD, ONIIKHKFMOE).GetBytes();
			stringBuilder.Append(AAFBHBMPNCP(bytes2));
		}
		if (JFCMLIBFOLG)
		{
			string text2 = stringBuilder.ToString();
			return text2.Substring(1, text2.Length - 2);
		}
		return stringBuilder.ToString();
	}
}
