using System;

public static class OCBOMAMKMND
{
	private static readonly uint BMGPDECKBMN = 14u;

	private static readonly uint KCGJKOAELCB = 16384u;

	private static readonly uint BCCEDABCJEG = 32u;

	private static readonly uint MEJCNLEHKEK = 8192u;

	private static readonly uint MGFHEBNIBMK = 264u;

	private static readonly long[] LNALCMNOKIG = new long[KCGJKOAELCB];

	public static byte[] CKAGFJPGBOL(byte[] ONLEIECDMDN)
	{
		int num = ONLEIECDMDN.Length * 2;
		byte[] OMBANDMFDLD = new byte[num];
		int num2;
		for (num2 = GDEGGPBHGEC(ONLEIECDMDN, ref OMBANDMFDLD); num2 == 0; num2 = GDEGGPBHGEC(ONLEIECDMDN, ref OMBANDMFDLD))
		{
			num *= 2;
			OMBANDMFDLD = new byte[num];
		}
		byte[] array = new byte[num2];
		Buffer.BlockCopy(OMBANDMFDLD, 0, array, 0, num2);
		return array;
	}

	public static byte[] HJHDAPCECGB(byte[] ONLEIECDMDN)
	{
		int num = ONLEIECDMDN.Length * 2;
		byte[] OMBANDMFDLD = new byte[num];
		int num2;
		for (num2 = JMADEBEBMFF(ONLEIECDMDN, ref OMBANDMFDLD); num2 == 0; num2 = JMADEBEBMFF(ONLEIECDMDN, ref OMBANDMFDLD))
		{
			num *= 2;
			OMBANDMFDLD = new byte[num];
		}
		byte[] array = new byte[num2];
		Buffer.BlockCopy(OMBANDMFDLD, 0, array, 0, num2);
		return array;
	}

	public static int GDEGGPBHGEC(byte[] MMKMICOONDG, ref byte[] OMBANDMFDLD)
	{
		int num = MMKMICOONDG.Length;
		int num2 = OMBANDMFDLD.Length;
		Array.Clear(LNALCMNOKIG, 0, (int)KCGJKOAELCB);
		uint num3 = 0u;
		uint num4 = 0u;
		uint num5 = (uint)((MMKMICOONDG[num3] << 8) | MMKMICOONDG[num3 + 1]);
		int num6 = 0;
		while (true)
		{
			if (num3 < num - 2)
			{
				num5 = (num5 << 8) | MMKMICOONDG[num3 + 2];
				long num7 = ((num5 ^ (num5 << 5)) >> (int)(24 - BMGPDECKBMN - num5 * 5)) & (KCGJKOAELCB - 1);
				long num8 = LNALCMNOKIG[num7];
				LNALCMNOKIG[num7] = num3;
				long num9;
				if ((num9 = num3 - num8 - 1) < MEJCNLEHKEK && num3 + 4 < num && num8 > 0 && MMKMICOONDG[num8] == MMKMICOONDG[num3] && MMKMICOONDG[num8 + 1] == MMKMICOONDG[num3 + 1] && MMKMICOONDG[num8 + 2] == MMKMICOONDG[num3 + 2])
				{
					uint num10 = 2u;
					uint num11 = (uint)(num - (int)num3) - num10;
					num11 = ((num11 <= MGFHEBNIBMK) ? num11 : MGFHEBNIBMK);
					if (num4 + num6 + 1 + 3 >= num2)
					{
						return 0;
					}
					do
					{
						num10++;
					}
					while (num10 < num11 && MMKMICOONDG[num8 + num10] == MMKMICOONDG[num3 + num10]);
					if (num6 != 0)
					{
						OMBANDMFDLD[num4++] = (byte)(num6 - 1);
						num6 = -num6;
						do
						{
							OMBANDMFDLD[num4++] = MMKMICOONDG[num3 + num6];
						}
						while (++num6 != 0);
					}
					num10 -= 2;
					num3++;
					if (num10 < 7)
					{
						OMBANDMFDLD[num4++] = (byte)((num9 >> 8) + (num10 << 5));
					}
					else
					{
						OMBANDMFDLD[num4++] = (byte)((num9 >> 8) + 224);
						OMBANDMFDLD[num4++] = (byte)(num10 - 7);
					}
					OMBANDMFDLD[num4++] = (byte)num9;
					num3 += num10 - 1;
					num5 = (uint)((MMKMICOONDG[num3] << 8) | MMKMICOONDG[num3 + 1]);
					num5 = (num5 << 8) | MMKMICOONDG[num3 + 2];
					LNALCMNOKIG[((num5 ^ (num5 << 5)) >> (int)(24 - BMGPDECKBMN - num5 * 5)) & (KCGJKOAELCB - 1)] = num3;
					num3++;
					num5 = (num5 << 8) | MMKMICOONDG[num3 + 2];
					LNALCMNOKIG[((num5 ^ (num5 << 5)) >> (int)(24 - BMGPDECKBMN - num5 * 5)) & (KCGJKOAELCB - 1)] = num3;
					num3++;
					continue;
				}
			}
			else if (num3 == num)
			{
				break;
			}
			num6++;
			num3++;
			if (num6 == BCCEDABCJEG)
			{
				if (num4 + 1 + BCCEDABCJEG >= num2)
				{
					return 0;
				}
				OMBANDMFDLD[num4++] = (byte)(BCCEDABCJEG - 1);
				num6 = -num6;
				do
				{
					OMBANDMFDLD[num4++] = MMKMICOONDG[num3 + num6];
				}
				while (++num6 != 0);
			}
		}
		if (num6 != 0)
		{
			if (num4 + num6 + 1 >= num2)
			{
				return 0;
			}
			OMBANDMFDLD[num4++] = (byte)(num6 - 1);
			num6 = -num6;
			do
			{
				OMBANDMFDLD[num4++] = MMKMICOONDG[num3 + num6];
			}
			while (++num6 != 0);
		}
		return (int)num4;
	}

	public static int JMADEBEBMFF(byte[] MMKMICOONDG, ref byte[] OMBANDMFDLD)
	{
		int num = MMKMICOONDG.Length;
		int num2 = OMBANDMFDLD.Length;
		uint num3 = 0u;
		uint num4 = 0u;
		do
		{
			uint num5 = MMKMICOONDG[num3++];
			if (num5 < 32)
			{
				num5++;
				if (num4 + num5 > num2)
				{
					return 0;
				}
				do
				{
					OMBANDMFDLD[num4++] = MMKMICOONDG[num3++];
				}
				while (--num5 != 0);
				continue;
			}
			uint num6 = num5 >> 5;
			int num7 = (int)(num4 - ((num5 & 0x1F) << 8) - 1);
			if (num6 == 7)
			{
				num6 += MMKMICOONDG[num3++];
			}
			num7 -= MMKMICOONDG[num3++];
			if (num4 + num6 + 2 > num2)
			{
				return 0;
			}
			if (num7 < 0)
			{
				return 0;
			}
			OMBANDMFDLD[num4++] = OMBANDMFDLD[num7++];
			OMBANDMFDLD[num4++] = OMBANDMFDLD[num7++];
			do
			{
				OMBANDMFDLD[num4++] = OMBANDMFDLD[num7++];
			}
			while (--num6 != 0);
		}
		while (num3 < num);
		return (int)num4;
	}
}
