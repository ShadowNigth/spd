using System;

public class OBKEGAPIMKL : ApplicationException
{
	public OBKEGAPIMKL()
	{
	}

	internal OBKEGAPIMKL(JFNGOBBICJL BGCOPCEBGIP)
		: base(string.Format("Invalid token '{0}' in input string", BGCOPCEBGIP))
	{
	}

	internal OBKEGAPIMKL(JFNGOBBICJL BGCOPCEBGIP, Exception PCFAGOLCFGE)
		: base(string.Format("Invalid token '{0}' in input string", BGCOPCEBGIP), PCFAGOLCFGE)
	{
	}

	internal OBKEGAPIMKL(int FCCPLGMNKOK)
		: base(string.Format("Invalid character '{0}' in input string", (char)FCCPLGMNKOK))
	{
	}

	internal OBKEGAPIMKL(int FCCPLGMNKOK, Exception PCFAGOLCFGE)
		: base(string.Format("Invalid character '{0}' in input string", (char)FCCPLGMNKOK), PCFAGOLCFGE)
	{
	}

	public OBKEGAPIMKL(string LIPFHCDCKFG)
		: base(LIPFHCDCKFG)
	{
	}

	public OBKEGAPIMKL(string LIPFHCDCKFG, Exception PCFAGOLCFGE)
		: base(LIPFHCDCKFG, PCFAGOLCFGE)
	{
	}
}
