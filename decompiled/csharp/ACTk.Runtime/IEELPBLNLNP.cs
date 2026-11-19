using System;

internal class IEELPBLNLNP
{
	private static readonly Random BJFBKNMLIBD = new Random();

	[ThreadStatic]
	private static Random KOMIKFHDCMM;

	public static int ELLEHDLDFEB(int HEDLEPHOMEN, int CAKCHEBMFML)
	{
		Random kOMIKFHDCMM = KOMIKFHDCMM;
		if (kOMIKFHDCMM != null)
		{
			return kOMIKFHDCMM.Next(HEDLEPHOMEN, CAKCHEBMFML);
		}
		int seed;
		lock (BJFBKNMLIBD)
		{
			seed = BJFBKNMLIBD.Next();
		}
		return (KOMIKFHDCMM = new Random(seed)).Next(HEDLEPHOMEN, CAKCHEBMFML);
	}

	public static long PAJLIOAMCEI(long HEDLEPHOMEN, long CAKCHEBMFML)
	{
		Random kOMIKFHDCMM = KOMIKFHDCMM;
		if (kOMIKFHDCMM != null)
		{
			return PAJLIOAMCEI(kOMIKFHDCMM, HEDLEPHOMEN, CAKCHEBMFML);
		}
		int seed;
		lock (BJFBKNMLIBD)
		{
			seed = BJFBKNMLIBD.Next();
		}
		return PAJLIOAMCEI(KOMIKFHDCMM = new Random(seed), HEDLEPHOMEN, CAKCHEBMFML);
	}

	public static void OAGDGHMHAHL(byte[] JPIKLMIEMPL)
	{
		Random kOMIKFHDCMM = KOMIKFHDCMM;
		if (kOMIKFHDCMM != null)
		{
			kOMIKFHDCMM.NextBytes(JPIKLMIEMPL);
			return;
		}
		int seed;
		lock (BJFBKNMLIBD)
		{
			seed = BJFBKNMLIBD.Next();
		}
		(KOMIKFHDCMM = new Random(seed)).NextBytes(JPIKLMIEMPL);
	}

	public static void KALDONPEEKM(char[] JPIKLMIEMPL)
	{
		Random kOMIKFHDCMM = KOMIKFHDCMM;
		if (kOMIKFHDCMM != null)
		{
			KALDONPEEKM(kOMIKFHDCMM, JPIKLMIEMPL);
			return;
		}
		int seed;
		lock (BJFBKNMLIBD)
		{
			seed = BJFBKNMLIBD.Next();
		}
		KALDONPEEKM(KOMIKFHDCMM = new Random(seed), JPIKLMIEMPL);
	}

	public static int ELLEHDLDFEB()
	{
		return ELLEHDLDFEB(1, int.MaxValue);
	}

	public static int ELLEHDLDFEB(int CAKCHEBMFML)
	{
		return ELLEHDLDFEB(1, CAKCHEBMFML);
	}

	private static long PAJLIOAMCEI(Random OOMBOCHLIJG, long HEDLEPHOMEN, long CAKCHEBMFML)
	{
		long num = OOMBOCHLIJG.Next((int)(HEDLEPHOMEN >> 32), (int)(CAKCHEBMFML >> 32));
		num <<= 32;
		return num | (uint)OOMBOCHLIJG.Next((int)HEDLEPHOMEN, (int)CAKCHEBMFML);
	}

	private static void KALDONPEEKM(Random OOMBOCHLIJG, char[] JPIKLMIEMPL)
	{
		for (int i = 0; i < JPIKLMIEMPL.Length; i++)
		{
			JPIKLMIEMPL[i] = (char)(OOMBOCHLIJG.Next() % 256);
		}
	}
}
