using System;
using UnityEngine;

public static class KOLKGOKNADN
{
	public static DMMANHIMDDM GEAMHPELNEO(Color JPLPPELPDKF)
	{
		return GEAMHPELNEO((int)(JPLPPELPDKF.r * 255f), (int)(JPLPPELPDKF.g * 255f), (int)(JPLPPELPDKF.b * 255f));
	}

	public static DMMANHIMDDM GEAMHPELNEO(double PHKEAHANGAM, double LCBKHLLPIGM, double GIPIKICBHKA)
	{
		double num = 0.0;
		double num2 = Math.Min(Math.Min(PHKEAHANGAM, GIPIKICBHKA), LCBKHLLPIGM);
		double num3 = Math.Max(Math.Max(PHKEAHANGAM, GIPIKICBHKA), LCBKHLLPIGM);
		double num4 = num3 - num2;
		double num5 = ((num3 != 0.0) ? (num4 / num3) : 0.0);
		if (num5 == 0.0)
		{
			num = 360.0;
		}
		else
		{
			if (PHKEAHANGAM == num3)
			{
				num = (GIPIKICBHKA - LCBKHLLPIGM) / num4;
			}
			else if (GIPIKICBHKA == num3)
			{
				num = 2.0 + (LCBKHLLPIGM - PHKEAHANGAM) / num4;
			}
			else if (LCBKHLLPIGM == num3)
			{
				num = 4.0 + (PHKEAHANGAM - GIPIKICBHKA) / num4;
			}
			num *= 60.0;
			if (num <= 0.0)
			{
				num += 360.0;
			}
		}
		DMMANHIMDDM result = default(DMMANHIMDDM);
		result.POELOAELGLA = 360.0 - num;
		result.KLJJEMDJPCC = num5;
		result.PLPAGOMEGEN = num3 / 255.0;
		return result;
	}

	public static Color NAHEPBDDFPJ(double MBIEHEGKCMN, double LGNIFJCEECH, double PDAKFGKELOC, float KKEJOJDFLFN)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		if (LGNIFJCEECH == 0.0)
		{
			num = PDAKFGKELOC;
			num2 = PDAKFGKELOC;
			num3 = PDAKFGKELOC;
		}
		else
		{
			MBIEHEGKCMN = ((MBIEHEGKCMN != 360.0) ? (MBIEHEGKCMN / 60.0) : 0.0);
			int num4 = (int)MBIEHEGKCMN;
			double num5 = MBIEHEGKCMN - (double)num4;
			double num6 = PDAKFGKELOC * (1.0 - LGNIFJCEECH);
			double num7 = PDAKFGKELOC * (1.0 - LGNIFJCEECH * num5);
			double num8 = PDAKFGKELOC * (1.0 - LGNIFJCEECH * (1.0 - num5));
			switch (num4)
			{
			case 0:
				num = PDAKFGKELOC;
				num2 = num8;
				num3 = num6;
				break;
			case 1:
				num = num7;
				num2 = PDAKFGKELOC;
				num3 = num6;
				break;
			case 2:
				num = num6;
				num2 = PDAKFGKELOC;
				num3 = num8;
				break;
			case 3:
				num = num6;
				num2 = num7;
				num3 = PDAKFGKELOC;
				break;
			case 4:
				num = num8;
				num2 = num6;
				num3 = PDAKFGKELOC;
				break;
			default:
				num = PDAKFGKELOC;
				num2 = num6;
				num3 = num7;
				break;
			}
		}
		return new Color((float)num, (float)num2, (float)num3, KKEJOJDFLFN);
	}
}
