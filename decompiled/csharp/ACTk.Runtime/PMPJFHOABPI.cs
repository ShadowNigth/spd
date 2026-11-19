using System;
using UnityEngine;

internal class PMPJFHOABPI
{
	public const long BNEOPMDAHFH = 10000000L;

	private const string GBNLMOJNJMC = "net.codestage.actk.androidnative.ACTkAndroidRoutines";

	private static AndroidJavaClass LLOMKEGAHOD;

	private static bool MJMFHCMFAOJ;

	public static long DPIIFADDFNL()
	{
		long num = 0L;
		num = MMLJAEANBDF();
		if (num == 0)
		{
			num = DateTime.UtcNow.Ticks;
		}
		return num;
	}

	public static long KEKPMLAMCCO()
	{
		return (long)Environment.TickCount * 10000L;
	}

	public static long LAJHPDKCDOO()
	{
		return (long)(Time.realtimeSinceStartup * 10000000f);
	}

	private static long MMLJAEANBDF()
	{
		long num = 0L;
		if (!MJMFHCMFAOJ)
		{
			MJMFHCMFAOJ = true;
			try
			{
				LLOMKEGAHOD = new AndroidJavaClass("net.codestage.actk.androidnative.ACTkAndroidRoutines");
			}
			catch (Exception ex)
			{
				Debug.LogError("[ACTk] Couldn't create instance of the AndroidJavaClass: net.codestage.actk.androidnative.ACTkAndroidRoutines !\n" + ex);
			}
		}
		if (LLOMKEGAHOD == null)
		{
			return num;
		}
		try
		{
			num = LLOMKEGAHOD.CallStatic<long>("GetSystemNanoTime", Array.Empty<object>());
			num /= 100;
		}
		catch (Exception ex2)
		{
			Debug.LogError("[ACTk] Couldn't call static method from the Android Routines Class!\n" + ex2);
		}
		return num;
	}

	~PMPJFHOABPI()
	{
		if (LLOMKEGAHOD != null)
		{
			LLOMKEGAHOD.Dispose();
		}
	}
}
