using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

public class OGDMCPOJKLP
{
	private static NumberFormatInfo PJCKAIHENDK;

	private MHKBDLEDJEA KPFOIKPELPI;

	private Stack<MHKBDLEDJEA> BBFMNBILJOE;

	private bool FFOIPJJNIPD;

	private char[] GBGCKBCAEHH;

	private int LFKEFNBBPLB;

	private int BMIMJJGECFO;

	private StringBuilder FCDEOGHKHPD;

	private bool FKIGLCGOJOM;

	private bool NCMBLKCBJOH;

	private TextWriter ACALPNFLMEP;

	public int JBAPDAPNPOE
	{
		get
		{
			return BMIMJJGECFO;
		}
		set
		{
			LFKEFNBBPLB = LFKEFNBBPLB / BMIMJJGECFO * value;
			BMIMJJGECFO = value;
		}
	}

	public bool JLJMBPEJBPP
	{
		get
		{
			return FKIGLCGOJOM;
		}
		set
		{
			FKIGLCGOJOM = value;
		}
	}

	public TextWriter NLMHMGKLLNJ => ACALPNFLMEP;

	public bool EEIBEOCKEEA
	{
		get
		{
			return NCMBLKCBJOH;
		}
		set
		{
			NCMBLKCBJOH = value;
		}
	}

	static OGDMCPOJKLP()
	{
		PJCKAIHENDK = NumberFormatInfo.InvariantInfo;
	}

	public OGDMCPOJKLP()
	{
		FCDEOGHKHPD = new StringBuilder();
		ACALPNFLMEP = new StringWriter(FCDEOGHKHPD);
		HIBHJDCMMAJ();
	}

	public OGDMCPOJKLP(StringBuilder OCCOEHJFDKM)
		: this(new StringWriter(OCCOEHJFDKM))
	{
	}

	public OGDMCPOJKLP(TextWriter ACALPNFLMEP)
	{
		if (ACALPNFLMEP == null)
		{
			throw new ArgumentNullException("writer");
		}
		this.ACALPNFLMEP = ACALPNFLMEP;
		HIBHJDCMMAJ();
	}

	private void LBCIBKHBMKM(LLDMIMCKFEB EFNAIOBLIBH)
	{
		if (!KPFOIKPELPI.EGOHKHHMFFO)
		{
			KPFOIKPELPI.KKKLPHAPBBD++;
		}
		if (!NCMBLKCBJOH)
		{
			return;
		}
		if (FFOIPJJNIPD)
		{
			throw new OBKEGAPIMKL("A complete JSON symbol has already been written");
		}
		switch (EFNAIOBLIBH)
		{
		case LLDMIMCKFEB.MLAMJHCODDC:
			if (!KPFOIKPELPI.MLAMJHCODDC)
			{
				throw new OBKEGAPIMKL("Can't close an array here");
			}
			break;
		case LLDMIMCKFEB.MMLLHMLOGEL:
			if (!KPFOIKPELPI.MMLLHMLOGEL || KPFOIKPELPI.EGOHKHHMFFO)
			{
				throw new OBKEGAPIMKL("Can't close an object here");
			}
			break;
		case LLDMIMCKFEB.LOEMLOPDNPC:
			if (KPFOIKPELPI.MMLLHMLOGEL && !KPFOIKPELPI.EGOHKHHMFFO)
			{
				throw new OBKEGAPIMKL("Expected a property");
			}
			break;
		case LLDMIMCKFEB.GJEFDBBJKKB:
			if (!KPFOIKPELPI.MMLLHMLOGEL || KPFOIKPELPI.EGOHKHHMFFO)
			{
				throw new OBKEGAPIMKL("Can't add a property here");
			}
			break;
		case LLDMIMCKFEB.JFLFLCDEEEI:
			if (!KPFOIKPELPI.MLAMJHCODDC && (!KPFOIKPELPI.MMLLHMLOGEL || !KPFOIKPELPI.EGOHKHHMFFO))
			{
				throw new OBKEGAPIMKL("Can't add a value here");
			}
			break;
		}
	}

	private void HIBHJDCMMAJ()
	{
		FFOIPJJNIPD = false;
		GBGCKBCAEHH = new char[4];
		LFKEFNBBPLB = 0;
		BMIMJJGECFO = 4;
		FKIGLCGOJOM = false;
		NCMBLKCBJOH = true;
		BBFMNBILJOE = new Stack<MHKBDLEDJEA>();
		KPFOIKPELPI = new MHKBDLEDJEA();
		BBFMNBILJOE.Push(KPFOIKPELPI);
	}

	private static void NOBMNJPAPOF(int DOIIKMIPLNH, char[] AEBJKBMFECA)
	{
		for (int i = 0; i < 4; i++)
		{
			int num = DOIIKMIPLNH % 16;
			if (num < 10)
			{
				AEBJKBMFECA[3 - i] = (char)(48 + num);
			}
			else
			{
				AEBJKBMFECA[3 - i] = (char)(65 + (num - 10));
			}
			DOIIKMIPLNH >>= 4;
		}
	}

	private void JIMGCBPHEOD()
	{
		if (FKIGLCGOJOM)
		{
			LFKEFNBBPLB += BMIMJJGECFO;
		}
	}

	private void HILHNEOPDJA(string DGPOLNOFCMB)
	{
		if (FKIGLCGOJOM && !KPFOIKPELPI.EGOHKHHMFFO)
		{
			for (int i = 0; i < LFKEFNBBPLB; i++)
			{
				ACALPNFLMEP.Write(' ');
			}
		}
		ACALPNFLMEP.Write(DGPOLNOFCMB);
	}

	private void OGKCMGLABCA()
	{
		OGKCMGLABCA(FKFEFONMFNL: true);
	}

	private void OGKCMGLABCA(bool FKFEFONMFNL)
	{
		if (FKFEFONMFNL && !KPFOIKPELPI.EGOHKHHMFFO && KPFOIKPELPI.KKKLPHAPBBD > 1)
		{
			ACALPNFLMEP.Write(',');
		}
		if (FKIGLCGOJOM && !KPFOIKPELPI.EGOHKHHMFFO)
		{
			ACALPNFLMEP.Write('\n');
		}
	}

	private void DKMCABFGOAH(string DGPOLNOFCMB)
	{
		HILHNEOPDJA(string.Empty);
		ACALPNFLMEP.Write('"');
		int length = DGPOLNOFCMB.Length;
		for (int i = 0; i < length; i++)
		{
			switch (DGPOLNOFCMB[i])
			{
			case '\n':
				ACALPNFLMEP.Write("\\n");
				continue;
			case '\r':
				ACALPNFLMEP.Write("\\r");
				continue;
			case '\t':
				ACALPNFLMEP.Write("\\t");
				continue;
			case '"':
			case '\\':
				ACALPNFLMEP.Write('\\');
				ACALPNFLMEP.Write(DGPOLNOFCMB[i]);
				continue;
			case '\f':
				ACALPNFLMEP.Write("\\f");
				continue;
			case '\b':
				ACALPNFLMEP.Write("\\b");
				continue;
			}
			if (DGPOLNOFCMB[i] >= ' ' && DGPOLNOFCMB[i] <= '~')
			{
				ACALPNFLMEP.Write(DGPOLNOFCMB[i]);
				continue;
			}
			NOBMNJPAPOF(DGPOLNOFCMB[i], GBGCKBCAEHH);
			ACALPNFLMEP.Write("\\u");
			ACALPNFLMEP.Write(GBGCKBCAEHH);
		}
		ACALPNFLMEP.Write('"');
	}

	private void IBHPHHHNLOJ()
	{
		if (FKIGLCGOJOM)
		{
			LFKEFNBBPLB -= BMIMJJGECFO;
		}
	}

	public override string ToString()
	{
		if (FCDEOGHKHPD == null)
		{
			return string.Empty;
		}
		return FCDEOGHKHPD.ToString();
	}

	public void PLPPLAIKDNA()
	{
		FFOIPJJNIPD = false;
		BBFMNBILJOE.Clear();
		KPFOIKPELPI = new MHKBDLEDJEA();
		BBFMNBILJOE.Push(KPFOIKPELPI);
		if (FCDEOGHKHPD != null)
		{
			FCDEOGHKHPD.Remove(0, FCDEOGHKHPD.Length);
		}
	}

	public void KLPPJEDJOAI(bool BJMGDOOIMMD)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.JFLFLCDEEEI);
		OGKCMGLABCA();
		HILHNEOPDJA((!BJMGDOOIMMD) ? "false" : "true");
		KPFOIKPELPI.EGOHKHHMFFO = false;
	}

	public void KLPPJEDJOAI(decimal LGEJNPHANPP)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.JFLFLCDEEEI);
		OGKCMGLABCA();
		HILHNEOPDJA(Convert.ToString(LGEJNPHANPP, PJCKAIHENDK));
		KPFOIKPELPI.EGOHKHHMFFO = false;
	}

	public void KLPPJEDJOAI(double LGEJNPHANPP)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.JFLFLCDEEEI);
		OGKCMGLABCA();
		string text = Convert.ToString(LGEJNPHANPP, PJCKAIHENDK);
		HILHNEOPDJA(text);
		if (text.IndexOf('.') == -1 && text.IndexOf('E') == -1)
		{
			ACALPNFLMEP.Write(".0");
		}
		KPFOIKPELPI.EGOHKHHMFFO = false;
	}

	public void KLPPJEDJOAI(int LGEJNPHANPP)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.JFLFLCDEEEI);
		OGKCMGLABCA();
		HILHNEOPDJA(Convert.ToString(LGEJNPHANPP, PJCKAIHENDK));
		KPFOIKPELPI.EGOHKHHMFFO = false;
	}

	public void KLPPJEDJOAI(long LGEJNPHANPP)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.JFLFLCDEEEI);
		OGKCMGLABCA();
		HILHNEOPDJA(Convert.ToString(LGEJNPHANPP, PJCKAIHENDK));
		KPFOIKPELPI.EGOHKHHMFFO = false;
	}

	public void KLPPJEDJOAI(string DGPOLNOFCMB)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.JFLFLCDEEEI);
		OGKCMGLABCA();
		if (DGPOLNOFCMB == null)
		{
			HILHNEOPDJA("null");
		}
		else
		{
			DKMCABFGOAH(DGPOLNOFCMB);
		}
		KPFOIKPELPI.EGOHKHHMFFO = false;
	}

	public void KLPPJEDJOAI(ulong LGEJNPHANPP)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.JFLFLCDEEEI);
		OGKCMGLABCA();
		HILHNEOPDJA(Convert.ToString(LGEJNPHANPP, PJCKAIHENDK));
		KPFOIKPELPI.EGOHKHHMFFO = false;
	}

	public void KACAGCKFEMI()
	{
		LBCIBKHBMKM(LLDMIMCKFEB.MLAMJHCODDC);
		OGKCMGLABCA(FKFEFONMFNL: false);
		BBFMNBILJOE.Pop();
		if (BBFMNBILJOE.Count == 1)
		{
			FFOIPJJNIPD = true;
		}
		else
		{
			KPFOIKPELPI = BBFMNBILJOE.Peek();
			KPFOIKPELPI.EGOHKHHMFFO = false;
		}
		IBHPHHHNLOJ();
		HILHNEOPDJA("]");
	}

	public void PJNKLJEGOGE()
	{
		LBCIBKHBMKM(LLDMIMCKFEB.LOEMLOPDNPC);
		OGKCMGLABCA();
		HILHNEOPDJA("[");
		KPFOIKPELPI = new MHKBDLEDJEA();
		KPFOIKPELPI.MLAMJHCODDC = true;
		BBFMNBILJOE.Push(KPFOIKPELPI);
		JIMGCBPHEOD();
	}

	public void CKMGOMNNFGN()
	{
		LBCIBKHBMKM(LLDMIMCKFEB.MMLLHMLOGEL);
		OGKCMGLABCA(FKFEFONMFNL: false);
		BBFMNBILJOE.Pop();
		if (BBFMNBILJOE.Count == 1)
		{
			FFOIPJJNIPD = true;
		}
		else
		{
			KPFOIKPELPI = BBFMNBILJOE.Peek();
			KPFOIKPELPI.EGOHKHHMFFO = false;
		}
		IBHPHHHNLOJ();
		HILHNEOPDJA("}");
	}

	public void LICPKOJEGEN()
	{
		LBCIBKHBMKM(LLDMIMCKFEB.LOEMLOPDNPC);
		OGKCMGLABCA();
		HILHNEOPDJA("{");
		KPFOIKPELPI = new MHKBDLEDJEA();
		KPFOIKPELPI.MMLLHMLOGEL = true;
		BBFMNBILJOE.Push(KPFOIKPELPI);
		JIMGCBPHEOD();
	}

	public void PPHOCDMCEGM(string JMFLHLPEDJB)
	{
		LBCIBKHBMKM(LLDMIMCKFEB.GJEFDBBJKKB);
		OGKCMGLABCA();
		DKMCABFGOAH(JMFLHLPEDJB);
		if (FKIGLCGOJOM)
		{
			if (JMFLHLPEDJB.Length > KPFOIKPELPI.KEGNNDCFCHD)
			{
				KPFOIKPELPI.KEGNNDCFCHD = JMFLHLPEDJB.Length;
			}
			for (int num = KPFOIKPELPI.KEGNNDCFCHD - JMFLHLPEDJB.Length; num >= 0; num--)
			{
				ACALPNFLMEP.Write(' ');
			}
			ACALPNFLMEP.Write(": ");
		}
		else
		{
			ACALPNFLMEP.Write(':');
		}
		KPFOIKPELPI.EGOHKHHMFFO = true;
	}
}
