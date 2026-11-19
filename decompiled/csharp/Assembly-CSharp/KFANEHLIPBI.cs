using System;
using UnityEngine;

public class KFANEHLIPBI : MonoBehaviour
{
	private float AGHJPCGNDKK;

	private float OMHIOCMHJFH;

	private float EKIAFNKGJFP;

	private float LBADMJBOLHG;

	private float CEELGPFMAOM;

	private float HIHKOONFJPI;

	private float HMJGGCCMNHI = 1f;

	public ColorChangedEvent DNMFLMKBGAP = new ColorChangedEvent();

	public ADBBIIGGDHN HAKHGCCNIAJ = new ADBBIIGGDHN();

	public Color MHGKIBFILBG
	{
		get
		{
			return new Color(LBADMJBOLHG, CEELGPFMAOM, HIHKOONFJPI, HMJGGCCMNHI);
		}
		set
		{
			if (!(MHGKIBFILBG == value))
			{
				LBADMJBOLHG = value.r;
				CEELGPFMAOM = value.g;
				HIHKOONFJPI = value.b;
				HMJGGCCMNHI = value.a;
				ABALBAIFBKG();
				AMECDJBLLJE();
			}
		}
	}

	public float POELOAELGLA
	{
		get
		{
			return AGHJPCGNDKK;
		}
		set
		{
			if (AGHJPCGNDKK != value)
			{
				AGHJPCGNDKK = value;
				EDFOHOLLKJO();
				AMECDJBLLJE();
			}
		}
	}

	public float KLJJEMDJPCC
	{
		get
		{
			return OMHIOCMHJFH;
		}
		set
		{
			if (OMHIOCMHJFH != value)
			{
				OMHIOCMHJFH = value;
				EDFOHOLLKJO();
				AMECDJBLLJE();
			}
		}
	}

	public float PLPAGOMEGEN
	{
		get
		{
			return EKIAFNKGJFP;
		}
		set
		{
			if (EKIAFNKGJFP != value)
			{
				EKIAFNKGJFP = value;
				EDFOHOLLKJO();
				AMECDJBLLJE();
			}
		}
	}

	public float ADGHIINBKLJ
	{
		get
		{
			return LBADMJBOLHG;
		}
		set
		{
			if (LBADMJBOLHG != value)
			{
				LBADMJBOLHG = value;
				ABALBAIFBKG();
				AMECDJBLLJE();
			}
		}
	}

	public float KECBPPLFKDA
	{
		get
		{
			return CEELGPFMAOM;
		}
		set
		{
			if (CEELGPFMAOM != value)
			{
				CEELGPFMAOM = value;
				ABALBAIFBKG();
				AMECDJBLLJE();
			}
		}
	}

	public float EDGDMFJAFEM
	{
		get
		{
			return HIHKOONFJPI;
		}
		set
		{
			if (HIHKOONFJPI != value)
			{
				HIHKOONFJPI = value;
				ABALBAIFBKG();
				AMECDJBLLJE();
			}
		}
	}

	private float PLLNCPNCAHN
	{
		get
		{
			return HMJGGCCMNHI;
		}
		set
		{
			if (HMJGGCCMNHI != value)
			{
				HMJGGCCMNHI = value;
				AMECDJBLLJE();
			}
		}
	}

	private void Start()
	{
		AMECDJBLLJE();
	}

	private void ABALBAIFBKG()
	{
		DMMANHIMDDM dMMANHIMDDM = KOLKGOKNADN.GEAMHPELNEO(MHGKIBFILBG);
		AGHJPCGNDKK = dMMANHIMDDM.LLONIMBBIBE;
		OMHIOCMHJFH = dMMANHIMDDM.KPFAMPOPMCL;
		EKIAFNKGJFP = dMMANHIMDDM.INHGDJACPHM;
	}

	private void EDFOHOLLKJO()
	{
		Color color = KOLKGOKNADN.NAHEPBDDFPJ(AGHJPCGNDKK * 360f, OMHIOCMHJFH, EKIAFNKGJFP, HMJGGCCMNHI);
		LBADMJBOLHG = color.r;
		CEELGPFMAOM = color.g;
		HIHKOONFJPI = color.b;
	}

	private void AMECDJBLLJE()
	{
		DNMFLMKBGAP.Invoke(MHGKIBFILBG);
		HAKHGCCNIAJ.Invoke(AGHJPCGNDKK, OMHIOCMHJFH, EKIAFNKGJFP);
	}

	public void JLJKHPPCGLH(OBFKGLEJBII EBMKGCIKJCA, float EHAPKEKPMOE)
	{
		switch (EBMKGCIKJCA)
		{
		case OBFKGLEJBII.ADGHIINBKLJ:
			ADGHIINBKLJ = EHAPKEKPMOE;
			break;
		case OBFKGLEJBII.KECBPPLFKDA:
			KECBPPLFKDA = EHAPKEKPMOE;
			break;
		case OBFKGLEJBII.EDGDMFJAFEM:
			EDGDMFJAFEM = EHAPKEKPMOE;
			break;
		case OBFKGLEJBII.PLLNCPNCAHN:
			PLLNCPNCAHN = EHAPKEKPMOE;
			break;
		case OBFKGLEJBII.NMGHODPCLGP:
			POELOAELGLA = EHAPKEKPMOE;
			break;
		case OBFKGLEJBII.GFMADABILAD:
			KLJJEMDJPCC = EHAPKEKPMOE;
			break;
		case OBFKGLEJBII.JFLFLCDEEEI:
			PLPAGOMEGEN = EHAPKEKPMOE;
			break;
		}
	}

	public float IBDCGCNGOCL(OBFKGLEJBII EBMKGCIKJCA)
	{
		return EBMKGCIKJCA switch
		{
			OBFKGLEJBII.ADGHIINBKLJ => ADGHIINBKLJ, 
			OBFKGLEJBII.KECBPPLFKDA => KECBPPLFKDA, 
			OBFKGLEJBII.EDGDMFJAFEM => EDGDMFJAFEM, 
			OBFKGLEJBII.PLLNCPNCAHN => PLLNCPNCAHN, 
			OBFKGLEJBII.NMGHODPCLGP => POELOAELGLA, 
			OBFKGLEJBII.GFMADABILAD => KLJJEMDJPCC, 
			OBFKGLEJBII.JFLFLCDEEEI => PLPAGOMEGEN, 
			_ => throw new NotImplementedException(string.Empty), 
		};
	}
}
