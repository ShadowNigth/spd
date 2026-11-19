using System;

public class OBKEGAPIMKL : ApplicationException
{
	public OBKEGAPIMKL()
	{
	}

	internal OBKEGAPIMKL(JFNGOBBICJL BGCOPCEBGIP)
		: base($"Invalid token '{BGCOPCEBGIP}' in input string")
	{
	}

	internal OBKEGAPIMKL(JFNGOBBICJL BGCOPCEBGIP, Exception PCFAGOLCFGE)
		: base($"Invalid token '{BGCOPCEBGIP}' in input string", PCFAGOLCFGE)
	{
	}

	internal OBKEGAPIMKL(int FCCPLGMNKOK)
		: base($"Invalid character '{(char)FCCPLGMNKOK}' in input string")
	{
	}

	internal OBKEGAPIMKL(int FCCPLGMNKOK, Exception PCFAGOLCFGE)
		: base($"Invalid character '{(char)FCCPLGMNKOK}' in input string", PCFAGOLCFGE)
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
