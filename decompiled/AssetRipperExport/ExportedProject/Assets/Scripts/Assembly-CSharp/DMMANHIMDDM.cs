public struct DMMANHIMDDM
{
	public double POELOAELGLA;

	public double KLJJEMDJPCC;

	public double PLPAGOMEGEN;

	public float LLONIMBBIBE
	{
		get
		{
			return (float)POELOAELGLA / 360f;
		}
		set
		{
			POELOAELGLA = (double)value * 360.0;
		}
	}

	public float KPFAMPOPMCL
	{
		get
		{
			return (float)KLJJEMDJPCC;
		}
		set
		{
			KLJJEMDJPCC = value;
		}
	}

	public float INHGDJACPHM
	{
		get
		{
			return (float)PLPAGOMEGEN;
		}
		set
		{
			PLPAGOMEGEN = value;
		}
	}

	public DMMANHIMDDM(double MBIEHEGKCMN, double LGNIFJCEECH, double PDAKFGKELOC)
	{
		POELOAELGLA = MBIEHEGKCMN;
		KLJJEMDJPCC = LGNIFJCEECH;
		PLPAGOMEGEN = PDAKFGKELOC;
	}

	public override string ToString()
	{
		return "{" + POELOAELGLA.ToString("f2") + "," + KLJJEMDJPCC.ToString("f2") + "," + PLPAGOMEGEN.ToString("f2") + "}";
	}
}
