using System;
using System.Runtime.CompilerServices;

[Serializable]
public class SecureInt : IComparable<int>, IEquatable<int>
{
	public static bool started;

	public static string detected;

	public int unEnc;

	private int enc;

	private int? rand;

	private int time;

	public static Random Random = new Random();

	public SecureInt PJCKFCICIJF(int EHAPKEKPMOE)
	{
		unEnc = EHAPKEKPMOE;
		rand = Random.Next(0, 9999);
		time = Environment.TickCount;
		enc = EHAPKEKPMOE ^ rand.Value ^ time;
		return this;
	}

	public int CJELHLLGJLG()
	{
		if (!rand.HasValue)
		{
			PJCKFCICIJF(unEnc);
			return unEnc;
		}
		int num = enc ^ rand.Value ^ time;
		if (num != unEnc)
		{
			detected = string.Format("Value changed from {0} to {1}", num, unEnc);
		}
		return num;
	}

	[SpecialName]
	public static SecureInt HGADPBHCGCI(SecureInt LCKFGBGDEIK, int IJDCDDHFJDG)
	{
		return LCKFGBGDEIK.PJCKFCICIJF(LCKFGBGDEIK.CJELHLLGJLG() + IJDCDDHFJDG);
	}

	[SpecialName]
	public static SecureInt GAIIFHAAPIJ(SecureInt LCKFGBGDEIK, int IJDCDDHFJDG)
	{
		return LCKFGBGDEIK.PJCKFCICIJF(LCKFGBGDEIK.CJELHLLGJLG() - IJDCDDHFJDG);
	}

	[SpecialName]
	public static SecureInt FNIPJFGEFFD(int EHAPKEKPMOE)
	{
		SecureInt secureInt = new SecureInt();
		if (started)
		{
			secureInt.PJCKFCICIJF(EHAPKEKPMOE);
		}
		else
		{
			secureInt.unEnc = EHAPKEKPMOE;
		}
		return secureInt;
	}

	[SpecialName]
	public static int FNIPJFGEFFD(SecureInt LGNIFJCEECH)
	{
		return LGNIFJCEECH.CJELHLLGJLG();
	}

	public int CompareTo(int OBKENFAPMCF)
	{
		return CJELHLLGJLG().CompareTo(OBKENFAPMCF);
	}

	public bool Equals(int OBKENFAPMCF)
	{
		return CJELHLLGJLG().Equals(OBKENFAPMCF);
	}

	public override string ToString()
	{
		return CJELHLLGJLG().ToString();
	}

	public override int GetHashCode()
	{
		return CJELHLLGJLG().GetHashCode();
	}
}
