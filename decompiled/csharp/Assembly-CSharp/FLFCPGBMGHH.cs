using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class FLFCPGBMGHH : OJIPMPCNDHB, IEquatable<FLFCPGBMGHH>, IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
{
	private IList<FLFCPGBMGHH> APFFJOKIBLE;

	private bool IGLLPMEIPBL;

	private double LGNFPJJMKEM;

	private int FIBBKBMNAKA;

	private long CILCFJLLGAO;

	private IDictionary<string, FLFCPGBMGHH> HMIHLDJOHNG;

	private string CKNCFJJJDPA;

	private string GMIHNCCACKM;

	private JNJKIPFENMC EBMKGCIKJCA;

	private IList<KeyValuePair<string, FLFCPGBMGHH>> FHNAAJKHCOF;

	int ICollection.HPENIOKGOPM => KKKLPHAPBBD;

	bool ICollection.LEMGHBAKMKO => LEGDEIPDAEA().IsSynchronized;

	object ICollection.DPHPHJDPOCG => LEGDEIPDAEA().SyncRoot;

	bool IDictionary.MMLBKMFEKMN => FAFGIBKGIPE().IsFixedSize;

	bool IDictionary.PHPJACDKMFM => FAFGIBKGIPE().IsReadOnly;

	ICollection IDictionary.MEEJLPNBICA
	{
		get
		{
			FAFGIBKGIPE();
			IList<string> list = new List<string>();
			foreach (KeyValuePair<string, FLFCPGBMGHH> item in FHNAAJKHCOF)
			{
				list.Add(item.Key);
			}
			return (ICollection)list;
		}
	}

	ICollection IDictionary.JJBNDECKFFG
	{
		get
		{
			FAFGIBKGIPE();
			IList<FLFCPGBMGHH> list = new List<FLFCPGBMGHH>();
			foreach (KeyValuePair<string, FLFCPGBMGHH> item in FHNAAJKHCOF)
			{
				list.Add(item.Value);
			}
			return (ICollection)list;
		}
	}

	bool OJIPMPCNDHB.EBNMIIDJEBH => OPEHJBFMKHC;

	bool OJIPMPCNDHB.JBCIDMCCMLJ => MHLAIFPDMCE;

	bool OJIPMPCNDHB.GMEHPIABPLO => CPNKINLBOHK;

	bool OJIPMPCNDHB.FHFJPFFPFFN => OMCOFFFFMJM;

	bool OJIPMPCNDHB.GALGHGCFKKO => NDJMHKDAGLP;

	bool OJIPMPCNDHB.OMLDHNGKBFM => GJPHBDAOBPG;

	bool OJIPMPCNDHB.MGDIHHMEOFG => NLOOFPLLBJC;

	bool IList.NIBJOCLOLAI => GJEKNJOFCOK().IsFixedSize;

	bool IList.NPBKFGIDLEB => GJEKNJOFCOK().IsReadOnly;

	object IDictionary.FEMEECBBBFI
	{
		get
		{
			return FAFGIBKGIPE()[JPBEBBODCJJ];
		}
		set
		{
			if (!(JPBEBBODCJJ is string))
			{
				throw new ArgumentException("The key has to be a string");
			}
			FLFCPGBMGHH eHAPKEKPMOE = DFAIOBKNINA(value);
			this.JOMIJDFIIPG((string)JPBEBBODCJJ, eHAPKEKPMOE);
		}
	}

	object IOrderedDictionary.IJFKLLLAJHP
	{
		get
		{
			FAFGIBKGIPE();
			return FHNAAJKHCOF[PCEKCBNKAKD].Value;
		}
		set
		{
			FAFGIBKGIPE();
			FLFCPGBMGHH value2 = DFAIOBKNINA(value);
			KeyValuePair<string, FLFCPGBMGHH> keyValuePair = FHNAAJKHCOF[PCEKCBNKAKD];
			HMIHLDJOHNG[keyValuePair.Key] = value2;
			KeyValuePair<string, FLFCPGBMGHH> value3 = new KeyValuePair<string, FLFCPGBMGHH>(keyValuePair.Key, value2);
			FHNAAJKHCOF[PCEKCBNKAKD] = value3;
		}
	}

	object IList.OPKFFAIALLM
	{
		get
		{
			return GJEKNJOFCOK()[JNDABHCJHHD];
		}
		set
		{
			GJEKNJOFCOK();
			FLFCPGBMGHH eHAPKEKPMOE = DFAIOBKNINA(value);
			this.JOMIJDFIIPG(JNDABHCJHHD, eHAPKEKPMOE);
		}
	}

	public int KKKLPHAPBBD => LEGDEIPDAEA().Count;

	public bool OPEHJBFMKHC => EBMKGCIKJCA == JNJKIPFENMC.ICNPMMKBFMA;

	public bool MHLAIFPDMCE => EBMKGCIKJCA == JNJKIPFENMC.KENBGHBDLCI;

	public bool CPNKINLBOHK => EBMKGCIKJCA == JNJKIPFENMC.OBGAGJIJNJE;

	public bool OMCOFFFFMJM => EBMKGCIKJCA == JNJKIPFENMC.CKFFAMAGBFB;

	public bool NDJMHKDAGLP => EBMKGCIKJCA == JNJKIPFENMC.FALOGJGDGMK;

	public bool GJPHBDAOBPG => EBMKGCIKJCA == JNJKIPFENMC.MDONKBLCDIP;

	public bool NLOOFPLLBJC => EBMKGCIKJCA == JNJKIPFENMC.IEOBEKAGFOM;

	public FLFCPGBMGHH DCNNOFJHEMD
	{
		get
		{
			FAFGIBKGIPE();
			if (!HMIHLDJOHNG.ContainsKey(PNGHIADOJCL))
			{
				return null;
			}
			return HMIHLDJOHNG[PNGHIADOJCL];
		}
		set
		{
			FAFGIBKGIPE();
			KeyValuePair<string, FLFCPGBMGHH> keyValuePair = new KeyValuePair<string, FLFCPGBMGHH>(PNGHIADOJCL, value);
			if (HMIHLDJOHNG.ContainsKey(PNGHIADOJCL))
			{
				for (int i = 0; i < FHNAAJKHCOF.Count; i++)
				{
					if (FHNAAJKHCOF[i].Key == PNGHIADOJCL)
					{
						FHNAAJKHCOF[i] = keyValuePair;
						break;
					}
				}
			}
			else
			{
				FHNAAJKHCOF.Add(keyValuePair);
			}
			HMIHLDJOHNG[PNGHIADOJCL] = value;
			GMIHNCCACKM = null;
		}
	}

	public FLFCPGBMGHH DCNNOFJHEMD
	{
		get
		{
			LEGDEIPDAEA();
			if (EBMKGCIKJCA == JNJKIPFENMC.ICNPMMKBFMA)
			{
				return APFFJOKIBLE[JNDABHCJHHD];
			}
			return FHNAAJKHCOF[JNDABHCJHHD].Value;
		}
		set
		{
			LEGDEIPDAEA();
			if (EBMKGCIKJCA == JNJKIPFENMC.ICNPMMKBFMA)
			{
				APFFJOKIBLE[JNDABHCJHHD] = value;
			}
			else
			{
				KeyValuePair<string, FLFCPGBMGHH> keyValuePair = FHNAAJKHCOF[JNDABHCJHHD];
				KeyValuePair<string, FLFCPGBMGHH> value2 = new KeyValuePair<string, FLFCPGBMGHH>(keyValuePair.Key, value);
				FHNAAJKHCOF[JNDABHCJHHD] = value2;
				HMIHLDJOHNG[keyValuePair.Key] = value;
			}
			GMIHNCCACKM = null;
		}
	}

	public FLFCPGBMGHH()
	{
	}

	public FLFCPGBMGHH(bool BJMGDOOIMMD)
	{
		EBMKGCIKJCA = JNJKIPFENMC.KENBGHBDLCI;
		IGLLPMEIPBL = BJMGDOOIMMD;
	}

	public FLFCPGBMGHH(double LGEJNPHANPP)
	{
		EBMKGCIKJCA = JNJKIPFENMC.OBGAGJIJNJE;
		LGNFPJJMKEM = LGEJNPHANPP;
	}

	public FLFCPGBMGHH(int LGEJNPHANPP)
	{
		EBMKGCIKJCA = JNJKIPFENMC.CKFFAMAGBFB;
		FIBBKBMNAKA = LGEJNPHANPP;
	}

	public FLFCPGBMGHH(long LGEJNPHANPP)
	{
		EBMKGCIKJCA = JNJKIPFENMC.FALOGJGDGMK;
		CILCFJLLGAO = LGEJNPHANPP;
	}

	public FLFCPGBMGHH(object FFBEPGEKANM)
	{
		if (FFBEPGEKANM is bool)
		{
			EBMKGCIKJCA = JNJKIPFENMC.KENBGHBDLCI;
			IGLLPMEIPBL = (bool)FFBEPGEKANM;
			return;
		}
		if (FFBEPGEKANM is double)
		{
			EBMKGCIKJCA = JNJKIPFENMC.OBGAGJIJNJE;
			LGNFPJJMKEM = (double)FFBEPGEKANM;
			return;
		}
		if (FFBEPGEKANM is int)
		{
			EBMKGCIKJCA = JNJKIPFENMC.CKFFAMAGBFB;
			FIBBKBMNAKA = (int)FFBEPGEKANM;
			return;
		}
		if (FFBEPGEKANM is long)
		{
			EBMKGCIKJCA = JNJKIPFENMC.FALOGJGDGMK;
			CILCFJLLGAO = (long)FFBEPGEKANM;
			return;
		}
		if (FFBEPGEKANM is string)
		{
			EBMKGCIKJCA = JNJKIPFENMC.IEOBEKAGFOM;
			CKNCFJJJDPA = (string)FFBEPGEKANM;
			return;
		}
		throw new ArgumentException("Unable to wrap the given object with JsonData");
	}

	public FLFCPGBMGHH(string DGPOLNOFCMB)
	{
		EBMKGCIKJCA = JNJKIPFENMC.IEOBEKAGFOM;
		CKNCFJJJDPA = DGPOLNOFCMB;
	}

	[SpecialName]
	public static FLFCPGBMGHH FNIPJFGEFFD(bool PMPJLBPPCMF)
	{
		return new FLFCPGBMGHH(PMPJLBPPCMF);
	}

	[SpecialName]
	public static FLFCPGBMGHH FNIPJFGEFFD(double PMPJLBPPCMF)
	{
		return new FLFCPGBMGHH(PMPJLBPPCMF);
	}

	[SpecialName]
	public static FLFCPGBMGHH FNIPJFGEFFD(int PMPJLBPPCMF)
	{
		return new FLFCPGBMGHH(PMPJLBPPCMF);
	}

	[SpecialName]
	public static FLFCPGBMGHH FNIPJFGEFFD(long PMPJLBPPCMF)
	{
		return new FLFCPGBMGHH(PMPJLBPPCMF);
	}

	[SpecialName]
	public static FLFCPGBMGHH FNIPJFGEFFD(string PMPJLBPPCMF)
	{
		return new FLFCPGBMGHH(PMPJLBPPCMF);
	}

	[SpecialName]
	public static bool JDBGCLLOGHJ(FLFCPGBMGHH PMPJLBPPCMF)
	{
		if (PMPJLBPPCMF.EBMKGCIKJCA != JNJKIPFENMC.KENBGHBDLCI)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a double");
		}
		return PMPJLBPPCMF.IGLLPMEIPBL;
	}

	[SpecialName]
	public static double JDBGCLLOGHJ(FLFCPGBMGHH PMPJLBPPCMF)
	{
		if (PMPJLBPPCMF.EBMKGCIKJCA != JNJKIPFENMC.OBGAGJIJNJE)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a double");
		}
		return PMPJLBPPCMF.LGNFPJJMKEM;
	}

	[SpecialName]
	public static int JDBGCLLOGHJ(FLFCPGBMGHH PMPJLBPPCMF)
	{
		if (PMPJLBPPCMF.EBMKGCIKJCA != JNJKIPFENMC.CKFFAMAGBFB)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold an int");
		}
		return PMPJLBPPCMF.FIBBKBMNAKA;
	}

	[SpecialName]
	public static long JDBGCLLOGHJ(FLFCPGBMGHH PMPJLBPPCMF)
	{
		if (PMPJLBPPCMF.EBMKGCIKJCA != JNJKIPFENMC.FALOGJGDGMK)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold an int");
		}
		return PMPJLBPPCMF.CILCFJLLGAO;
	}

	[SpecialName]
	public static string JDBGCLLOGHJ(FLFCPGBMGHH PMPJLBPPCMF)
	{
		if (PMPJLBPPCMF.EBMKGCIKJCA != JNJKIPFENMC.IEOBEKAGFOM)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a string");
		}
		return PMPJLBPPCMF.CKNCFJJJDPA;
	}

	void ICollection.CopyTo(Array ACDLFNJIKCO, int JNDABHCJHHD)
	{
		LEGDEIPDAEA().CopyTo(ACDLFNJIKCO, JNDABHCJHHD);
	}

	void IDictionary.Add(object JPBEBBODCJJ, object EHAPKEKPMOE)
	{
		FLFCPGBMGHH value = DFAIOBKNINA(EHAPKEKPMOE);
		FAFGIBKGIPE().Add(JPBEBBODCJJ, value);
		KeyValuePair<string, FLFCPGBMGHH> item = new KeyValuePair<string, FLFCPGBMGHH>((string)JPBEBBODCJJ, value);
		FHNAAJKHCOF.Add(item);
		GMIHNCCACKM = null;
	}

	void IDictionary.Clear()
	{
		FAFGIBKGIPE().Clear();
		FHNAAJKHCOF.Clear();
		GMIHNCCACKM = null;
	}

	bool IDictionary.Contains(object JPBEBBODCJJ)
	{
		return FAFGIBKGIPE().Contains(JPBEBBODCJJ);
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return ((IOrderedDictionary)this).GetEnumerator();
	}

	void IDictionary.Remove(object JPBEBBODCJJ)
	{
		FAFGIBKGIPE().Remove(JPBEBBODCJJ);
		for (int i = 0; i < FHNAAJKHCOF.Count; i++)
		{
			if (FHNAAJKHCOF[i].Key == (string)JPBEBBODCJJ)
			{
				FHNAAJKHCOF.RemoveAt(i);
				break;
			}
		}
		GMIHNCCACKM = null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return LEGDEIPDAEA().GetEnumerator();
	}

	bool OJIPMPCNDHB.GetBoolean()
	{
		if (EBMKGCIKJCA != JNJKIPFENMC.KENBGHBDLCI)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a boolean");
		}
		return IGLLPMEIPBL;
	}

	double OJIPMPCNDHB.GetDouble()
	{
		if (EBMKGCIKJCA != JNJKIPFENMC.OBGAGJIJNJE)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a double");
		}
		return LGNFPJJMKEM;
	}

	int OJIPMPCNDHB.GetInt()
	{
		if (EBMKGCIKJCA != JNJKIPFENMC.CKFFAMAGBFB)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold an int");
		}
		return FIBBKBMNAKA;
	}

	long OJIPMPCNDHB.GetLong()
	{
		if (EBMKGCIKJCA != JNJKIPFENMC.FALOGJGDGMK)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a long");
		}
		return CILCFJLLGAO;
	}

	string OJIPMPCNDHB.GetString()
	{
		if (EBMKGCIKJCA != JNJKIPFENMC.IEOBEKAGFOM)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a string");
		}
		return CKNCFJJJDPA;
	}

	void OJIPMPCNDHB.SetBoolean(bool IFKMKLFPKGG)
	{
		EBMKGCIKJCA = JNJKIPFENMC.KENBGHBDLCI;
		IGLLPMEIPBL = IFKMKLFPKGG;
		GMIHNCCACKM = null;
	}

	void OJIPMPCNDHB.SetDouble(double IFKMKLFPKGG)
	{
		EBMKGCIKJCA = JNJKIPFENMC.OBGAGJIJNJE;
		LGNFPJJMKEM = IFKMKLFPKGG;
		GMIHNCCACKM = null;
	}

	void OJIPMPCNDHB.SetInt(int IFKMKLFPKGG)
	{
		EBMKGCIKJCA = JNJKIPFENMC.CKFFAMAGBFB;
		FIBBKBMNAKA = IFKMKLFPKGG;
		GMIHNCCACKM = null;
	}

	void OJIPMPCNDHB.SetLong(long IFKMKLFPKGG)
	{
		EBMKGCIKJCA = JNJKIPFENMC.FALOGJGDGMK;
		CILCFJLLGAO = IFKMKLFPKGG;
		GMIHNCCACKM = null;
	}

	void OJIPMPCNDHB.SetString(string IFKMKLFPKGG)
	{
		EBMKGCIKJCA = JNJKIPFENMC.IEOBEKAGFOM;
		CKNCFJJJDPA = IFKMKLFPKGG;
		GMIHNCCACKM = null;
	}

	string OJIPMPCNDHB.ToJson()
	{
		return GIBKHAGKJHE();
	}

	void OJIPMPCNDHB.ToJson(OGDMCPOJKLP ACALPNFLMEP)
	{
		GIBKHAGKJHE(ACALPNFLMEP);
	}

	int IList.Add(object EHAPKEKPMOE)
	{
		return IPDNNOIOAIO(EHAPKEKPMOE);
	}

	void IList.Clear()
	{
		GJEKNJOFCOK().Clear();
		GMIHNCCACKM = null;
	}

	bool IList.Contains(object EHAPKEKPMOE)
	{
		return GJEKNJOFCOK().Contains(EHAPKEKPMOE);
	}

	int IList.IndexOf(object EHAPKEKPMOE)
	{
		return GJEKNJOFCOK().IndexOf(EHAPKEKPMOE);
	}

	void IList.Insert(int JNDABHCJHHD, object EHAPKEKPMOE)
	{
		GJEKNJOFCOK().Insert(JNDABHCJHHD, EHAPKEKPMOE);
		GMIHNCCACKM = null;
	}

	void IList.Remove(object EHAPKEKPMOE)
	{
		GJEKNJOFCOK().Remove(EHAPKEKPMOE);
		GMIHNCCACKM = null;
	}

	void IList.RemoveAt(int JNDABHCJHHD)
	{
		GJEKNJOFCOK().RemoveAt(JNDABHCJHHD);
		GMIHNCCACKM = null;
	}

	IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
	{
		FAFGIBKGIPE();
		return new DLONDPANGNC(FHNAAJKHCOF.GetEnumerator());
	}

	void IOrderedDictionary.Insert(int PCEKCBNKAKD, object JPBEBBODCJJ, object EHAPKEKPMOE)
	{
		string text = (string)JPBEBBODCJJ;
		FLFCPGBMGHH fLFCPGBMGHH = DFAIOBKNINA(EHAPKEKPMOE);
		this.JOMIJDFIIPG(text, fLFCPGBMGHH);
		KeyValuePair<string, FLFCPGBMGHH> item = new KeyValuePair<string, FLFCPGBMGHH>(text, fLFCPGBMGHH);
		FHNAAJKHCOF.Insert(PCEKCBNKAKD, item);
	}

	void IOrderedDictionary.RemoveAt(int PCEKCBNKAKD)
	{
		FAFGIBKGIPE();
		HMIHLDJOHNG.Remove(FHNAAJKHCOF[PCEKCBNKAKD].Key);
		FHNAAJKHCOF.RemoveAt(PCEKCBNKAKD);
	}

	private ICollection LEGDEIPDAEA()
	{
		if (EBMKGCIKJCA == JNJKIPFENMC.ICNPMMKBFMA)
		{
			return (ICollection)APFFJOKIBLE;
		}
		if (EBMKGCIKJCA == JNJKIPFENMC.MDONKBLCDIP)
		{
			return (ICollection)HMIHLDJOHNG;
		}
		throw new InvalidOperationException("The JsonData instance has to be initialized first");
	}

	private IDictionary FAFGIBKGIPE()
	{
		if (EBMKGCIKJCA == JNJKIPFENMC.MDONKBLCDIP)
		{
			return (IDictionary)HMIHLDJOHNG;
		}
		if (EBMKGCIKJCA != 0)
		{
			throw new InvalidOperationException("Instance of JsonData is not a dictionary");
		}
		EBMKGCIKJCA = JNJKIPFENMC.MDONKBLCDIP;
		HMIHLDJOHNG = new Dictionary<string, FLFCPGBMGHH>();
		FHNAAJKHCOF = new List<KeyValuePair<string, FLFCPGBMGHH>>();
		return (IDictionary)HMIHLDJOHNG;
	}

	private IList GJEKNJOFCOK()
	{
		if (EBMKGCIKJCA == JNJKIPFENMC.ICNPMMKBFMA)
		{
			return (IList)APFFJOKIBLE;
		}
		if (EBMKGCIKJCA != 0)
		{
			throw new InvalidOperationException("Instance of JsonData is not a list");
		}
		EBMKGCIKJCA = JNJKIPFENMC.ICNPMMKBFMA;
		APFFJOKIBLE = new List<FLFCPGBMGHH>();
		return (IList)APFFJOKIBLE;
	}

	private FLFCPGBMGHH DFAIOBKNINA(object FFBEPGEKANM)
	{
		if (FFBEPGEKANM == null)
		{
			return null;
		}
		if (FFBEPGEKANM is FLFCPGBMGHH)
		{
			return (FLFCPGBMGHH)FFBEPGEKANM;
		}
		return new FLFCPGBMGHH(FFBEPGEKANM);
	}

	private static void BOAFOCBOPOM(OJIPMPCNDHB FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		if (FFBEPGEKANM == null)
		{
			ACALPNFLMEP.KLPPJEDJOAI(null);
		}
		else if (FFBEPGEKANM.NLOOFPLLBJC)
		{
			ACALPNFLMEP.KLPPJEDJOAI(FFBEPGEKANM.KKNHDKLDCHI());
		}
		else if (FFBEPGEKANM.MHLAIFPDMCE)
		{
			ACALPNFLMEP.KLPPJEDJOAI(FFBEPGEKANM.PELMIPGJICH());
		}
		else if (FFBEPGEKANM.CPNKINLBOHK)
		{
			ACALPNFLMEP.KLPPJEDJOAI(FFBEPGEKANM.DGMIJFDFHEC());
		}
		else if (FFBEPGEKANM.OMCOFFFFMJM)
		{
			ACALPNFLMEP.KLPPJEDJOAI(FFBEPGEKANM.GMOOMLGMADD());
		}
		else if (FFBEPGEKANM.NDJMHKDAGLP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(FFBEPGEKANM.AOBMLGGGOOP());
		}
		else if (FFBEPGEKANM.OPEHJBFMKHC)
		{
			ACALPNFLMEP.PJNKLJEGOGE();
			foreach (object item in (IEnumerable)FFBEPGEKANM)
			{
				BOAFOCBOPOM((FLFCPGBMGHH)item, ACALPNFLMEP);
			}
			ACALPNFLMEP.KACAGCKFEMI();
		}
		else
		{
			if (!FFBEPGEKANM.GJPHBDAOBPG)
			{
				return;
			}
			ACALPNFLMEP.LICPKOJEGEN();
			foreach (DictionaryEntry item2 in (IDictionary)FFBEPGEKANM)
			{
				ACALPNFLMEP.PPHOCDMCEGM((string)item2.Key);
				BOAFOCBOPOM((FLFCPGBMGHH)item2.Value, ACALPNFLMEP);
			}
			ACALPNFLMEP.CKMGOMNNFGN();
		}
	}

	public int IPDNNOIOAIO(object EHAPKEKPMOE)
	{
		FLFCPGBMGHH value = DFAIOBKNINA(EHAPKEKPMOE);
		GMIHNCCACKM = null;
		return GJEKNJOFCOK().Add(value);
	}

	public void GFJGDEKLFNB()
	{
		if (GJPHBDAOBPG)
		{
			((IDictionary)this).Clear();
		}
		else if (OPEHJBFMKHC)
		{
			((IList)this).Clear();
		}
	}

	public bool Equals(FLFCPGBMGHH HKCJBFIKALL)
	{
		if (HKCJBFIKALL == null)
		{
			return false;
		}
		if (HKCJBFIKALL.EBMKGCIKJCA != EBMKGCIKJCA)
		{
			return false;
		}
		return EBMKGCIKJCA switch
		{
			JNJKIPFENMC.BLBOPPEBDFH => true, 
			JNJKIPFENMC.MDONKBLCDIP => HMIHLDJOHNG.Equals(HKCJBFIKALL.HMIHLDJOHNG), 
			JNJKIPFENMC.ICNPMMKBFMA => APFFJOKIBLE.Equals(HKCJBFIKALL.APFFJOKIBLE), 
			JNJKIPFENMC.IEOBEKAGFOM => CKNCFJJJDPA.Equals(HKCJBFIKALL.CKNCFJJJDPA), 
			JNJKIPFENMC.CKFFAMAGBFB => FIBBKBMNAKA.Equals(HKCJBFIKALL.FIBBKBMNAKA), 
			JNJKIPFENMC.FALOGJGDGMK => CILCFJLLGAO.Equals(HKCJBFIKALL.CILCFJLLGAO), 
			JNJKIPFENMC.OBGAGJIJNJE => LGNFPJJMKEM.Equals(HKCJBFIKALL.LGNFPJJMKEM), 
			JNJKIPFENMC.KENBGHBDLCI => IGLLPMEIPBL.Equals(HKCJBFIKALL.IGLLPMEIPBL), 
			_ => false, 
		};
	}

	public JNJKIPFENMC BGMMHIHGJJH()
	{
		return EBMKGCIKJCA;
	}

	public void KPJPMGPGDJG(JNJKIPFENMC EBMKGCIKJCA)
	{
		if (this.EBMKGCIKJCA != EBMKGCIKJCA)
		{
			switch (EBMKGCIKJCA)
			{
			case JNJKIPFENMC.MDONKBLCDIP:
				HMIHLDJOHNG = new Dictionary<string, FLFCPGBMGHH>();
				FHNAAJKHCOF = new List<KeyValuePair<string, FLFCPGBMGHH>>();
				break;
			case JNJKIPFENMC.ICNPMMKBFMA:
				APFFJOKIBLE = new List<FLFCPGBMGHH>();
				break;
			case JNJKIPFENMC.IEOBEKAGFOM:
				CKNCFJJJDPA = null;
				break;
			case JNJKIPFENMC.CKFFAMAGBFB:
				FIBBKBMNAKA = 0;
				break;
			case JNJKIPFENMC.FALOGJGDGMK:
				CILCFJLLGAO = 0L;
				break;
			case JNJKIPFENMC.OBGAGJIJNJE:
				LGNFPJJMKEM = 0.0;
				break;
			case JNJKIPFENMC.KENBGHBDLCI:
				IGLLPMEIPBL = false;
				break;
			}
			this.EBMKGCIKJCA = EBMKGCIKJCA;
		}
	}

	public string GIBKHAGKJHE()
	{
		if (GMIHNCCACKM != null)
		{
			return GMIHNCCACKM;
		}
		StringWriter stringWriter = new StringWriter();
		OGDMCPOJKLP oGDMCPOJKLP = new OGDMCPOJKLP(stringWriter);
		oGDMCPOJKLP.EEIBEOCKEEA = false;
		BOAFOCBOPOM(this, oGDMCPOJKLP);
		GMIHNCCACKM = stringWriter.ToString();
		return GMIHNCCACKM;
	}

	public void GIBKHAGKJHE(OGDMCPOJKLP ACALPNFLMEP)
	{
		bool eHAPKEKPMOE = ACALPNFLMEP.EEIBEOCKEEA;
		ACALPNFLMEP.EEIBEOCKEEA = false;
		BOAFOCBOPOM(this, ACALPNFLMEP);
		ACALPNFLMEP.EEIBEOCKEEA = eHAPKEKPMOE;
	}

	public override string ToString()
	{
		return EBMKGCIKJCA switch
		{
			JNJKIPFENMC.ICNPMMKBFMA => "JsonData array", 
			JNJKIPFENMC.KENBGHBDLCI => IGLLPMEIPBL.ToString(), 
			JNJKIPFENMC.OBGAGJIJNJE => LGNFPJJMKEM.ToString(), 
			JNJKIPFENMC.CKFFAMAGBFB => FIBBKBMNAKA.ToString(), 
			JNJKIPFENMC.FALOGJGDGMK => CILCFJLLGAO.ToString(), 
			JNJKIPFENMC.MDONKBLCDIP => "JsonData object", 
			JNJKIPFENMC.IEOBEKAGFOM => CKNCFJJJDPA, 
			_ => "Uninitialized JsonData", 
		};
	}
}
