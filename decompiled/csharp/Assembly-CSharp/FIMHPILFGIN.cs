using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

public class FIMHPILFGIN
{
	[CompilerGenerated]
	private sealed class DKDHGIENJEA<T>
	{
		internal global::NCHMGLDLHDP<T> MDDBAIEBIJN;

		internal void BEKJDJFLJJC(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			MDDBAIEBIJN((T)FFBEPGEKANM, ACALPNFLMEP);
		}
	}

	[CompilerGenerated]
	private sealed class BNEBEAPNCHC<TJson, TValue>
	{
		internal global::AGKLBOCNPGP<TJson, TValue> LGJEBFPOIMH;

		internal object BEKJDJFLJJC(object MMKMICOONDG)
		{
			return LGJEBFPOIMH((TJson)MMKMICOONDG);
		}
	}

	private static readonly int NDPILNBAFME;

	private static readonly IFormatProvider CONMOIEENOO;

	private static readonly IDictionary<Type, MNCGHLAIDCA> FNCGELLDELC;

	private static readonly IDictionary<Type, MNCGHLAIDCA> EEIBIGICOFF;

	private static readonly IDictionary<Type, IDictionary<Type, NBGNJGAGFJH>> EEPMFDJHNFK;

	private static readonly IDictionary<Type, IDictionary<Type, NBGNJGAGFJH>> BHAPEHPAGJA;

	private static readonly IDictionary<Type, NPAIGILPBMJ> BKGHKPEFCJF;

	private static readonly object EBHAIKJMELF;

	private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> APMCBLBEOMF;

	private static readonly object HCNIMELJIED;

	private static readonly IDictionary<Type, NCKBEBLECML> AIAHLNLEJHP;

	private static readonly object LALMPDFBKCO;

	private static readonly IDictionary<Type, IList<PGOCJGCKGNH>> GMOIELJCAHA;

	private static readonly object NMACJMILGJI;

	private static readonly OGDMCPOJKLP DGEDKAIAPIL;

	private static readonly object FNJGBGLEPNA;

	[CompilerGenerated]
	private static NBEMBPIHGMI ACJNADIPOMC;

	[CompilerGenerated]
	private static MNCGHLAIDCA HJJBAKLDAEB;

	[CompilerGenerated]
	private static MNCGHLAIDCA MPCENNEMFPB;

	[CompilerGenerated]
	private static MNCGHLAIDCA AGJHOJDNCOI;

	[CompilerGenerated]
	private static MNCGHLAIDCA GOKLDIBAPEA;

	[CompilerGenerated]
	private static MNCGHLAIDCA FDEPMKHNIID;

	[CompilerGenerated]
	private static MNCGHLAIDCA JEJGIANFAJE;

	[CompilerGenerated]
	private static MNCGHLAIDCA CAGBNPPEAFL;

	[CompilerGenerated]
	private static MNCGHLAIDCA IOIHBOPJMHO;

	[CompilerGenerated]
	private static MNCGHLAIDCA MIHBLNGEMJB;

	[CompilerGenerated]
	private static NBGNJGAGFJH MBDEKCIDOHG;

	[CompilerGenerated]
	private static NBGNJGAGFJH INPFPBONNKM;

	[CompilerGenerated]
	private static NBGNJGAGFJH DCNJCLEOEHG;

	[CompilerGenerated]
	private static NBGNJGAGFJH AFIEDPFMAGJ;

	[CompilerGenerated]
	private static NBGNJGAGFJH CEOLLBPDPIB;

	[CompilerGenerated]
	private static NBGNJGAGFJH GGPHECIEGDB;

	[CompilerGenerated]
	private static NBGNJGAGFJH MLIEIDFEICI;

	[CompilerGenerated]
	private static NBGNJGAGFJH OFOPMFOMIBE;

	[CompilerGenerated]
	private static NBGNJGAGFJH DFNLGGNOAFC;

	[CompilerGenerated]
	private static NBGNJGAGFJH LIJNNCCHNBN;

	[CompilerGenerated]
	private static NBGNJGAGFJH HIGIJMJOLJH;

	[CompilerGenerated]
	private static NBGNJGAGFJH BJLEFEJDDBA;

	[CompilerGenerated]
	private static NBGNJGAGFJH JPKHLMPCIHO;

	[CompilerGenerated]
	private static NBGNJGAGFJH HADDHHPAEJI;

	[CompilerGenerated]
	private static NBEMBPIHGMI IFMMEDHDOML;

	[CompilerGenerated]
	private static NBEMBPIHGMI OLAGFPHHHEP;

	[CompilerGenerated]
	private static NBEMBPIHGMI GIEPGOOJBEM;

	static FIMHPILFGIN()
	{
		EBHAIKJMELF = new object();
		HCNIMELJIED = new object();
		LALMPDFBKCO = new object();
		NMACJMILGJI = new object();
		FNJGBGLEPNA = new object();
		NDPILNBAFME = 100;
		BKGHKPEFCJF = new Dictionary<Type, NPAIGILPBMJ>();
		APMCBLBEOMF = new Dictionary<Type, IDictionary<Type, MethodInfo>>();
		AIAHLNLEJHP = new Dictionary<Type, NCKBEBLECML>();
		GMOIELJCAHA = new Dictionary<Type, IList<PGOCJGCKGNH>>();
		DGEDKAIAPIL = new OGDMCPOJKLP();
		CONMOIEENOO = DateTimeFormatInfo.InvariantInfo;
		FNCGELLDELC = new Dictionary<Type, MNCGHLAIDCA>();
		EEIBIGICOFF = new Dictionary<Type, MNCGHLAIDCA>();
		EEPMFDJHNFK = new Dictionary<Type, IDictionary<Type, NBGNJGAGFJH>>();
		BHAPEHPAGJA = new Dictionary<Type, IDictionary<Type, NBGNJGAGFJH>>();
		JBPEPHJCAIG();
		GPLIAIEKDLM();
	}

	private static void GCEDFEGFJMK(Type EBMKGCIKJCA)
	{
		if (BKGHKPEFCJF.ContainsKey(EBMKGCIKJCA))
		{
			return;
		}
		NPAIGILPBMJ value = default(NPAIGILPBMJ);
		value.OPEHJBFMKHC = EBMKGCIKJCA.IsArray;
		if (EBMKGCIKJCA.GetInterface("System.Collections.IList") != null)
		{
			value.PBKJDDMIECE = true;
		}
		PropertyInfo[] properties = EBMKGCIKJCA.GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (!(propertyInfo.Name != "Item"))
			{
				ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
				if (indexParameters.Length == 1 && indexParameters[0].ParameterType == typeof(int))
				{
					value.KFJKJGDAEFM = propertyInfo.PropertyType;
				}
			}
		}
		lock (EBHAIKJMELF)
		{
			try
			{
				BKGHKPEFCJF.Add(EBMKGCIKJCA, value);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static void JOILONAGNOA(Type EBMKGCIKJCA)
	{
		if (AIAHLNLEJHP.ContainsKey(EBMKGCIKJCA))
		{
			return;
		}
		NCKBEBLECML value = default(NCKBEBLECML);
		if (EBMKGCIKJCA.GetInterface("System.Collections.IDictionary") != null)
		{
			value.EOFHILDCGME = true;
		}
		value.BKHIOGHNDBB = new Dictionary<string, PGOCJGCKGNH>();
		PropertyInfo[] properties = EBMKGCIKJCA.GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (propertyInfo.Name == "Item")
			{
				ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
				if (indexParameters.Length == 1 && indexParameters[0].ParameterType == typeof(string))
				{
					value.KFJKJGDAEFM = propertyInfo.PropertyType;
				}
			}
			else
			{
				PGOCJGCKGNH value2 = default(PGOCJGCKGNH);
				value2.PAECJMCHEOC = propertyInfo;
				value2.JCPEOOKNNFN = propertyInfo.PropertyType;
				value.BKHIOGHNDBB.Add(propertyInfo.Name, value2);
			}
		}
		FieldInfo[] fields = EBMKGCIKJCA.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			PGOCJGCKGNH value3 = default(PGOCJGCKGNH);
			value3.PAECJMCHEOC = fieldInfo;
			value3.BDOLAOAODGK = true;
			value3.JCPEOOKNNFN = fieldInfo.FieldType;
			value.BKHIOGHNDBB.Add(fieldInfo.Name, value3);
		}
		lock (LALMPDFBKCO)
		{
			try
			{
				AIAHLNLEJHP.Add(EBMKGCIKJCA, value);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static void AGPBMEOAFAI(Type EBMKGCIKJCA)
	{
		if (GMOIELJCAHA.ContainsKey(EBMKGCIKJCA))
		{
			return;
		}
		IList<PGOCJGCKGNH> list = new List<PGOCJGCKGNH>();
		PropertyInfo[] properties = EBMKGCIKJCA.GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (!(propertyInfo.Name == "Item"))
			{
				PGOCJGCKGNH item = default(PGOCJGCKGNH);
				item.PAECJMCHEOC = propertyInfo;
				item.BDOLAOAODGK = false;
				list.Add(item);
			}
		}
		FieldInfo[] fields = EBMKGCIKJCA.GetFields();
		foreach (FieldInfo pAECJMCHEOC in fields)
		{
			PGOCJGCKGNH item2 = default(PGOCJGCKGNH);
			item2.PAECJMCHEOC = pAECJMCHEOC;
			item2.BDOLAOAODGK = true;
			list.Add(item2);
		}
		lock (NMACJMILGJI)
		{
			try
			{
				GMOIELJCAHA.Add(EBMKGCIKJCA, list);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static MethodInfo MEIJEMPGELK(Type PHELBJLAHPB, Type KAOJBICNACP)
	{
		lock (HCNIMELJIED)
		{
			if (!APMCBLBEOMF.ContainsKey(PHELBJLAHPB))
			{
				APMCBLBEOMF.Add(PHELBJLAHPB, new Dictionary<Type, MethodInfo>());
			}
		}
		if (APMCBLBEOMF[PHELBJLAHPB].ContainsKey(KAOJBICNACP))
		{
			return APMCBLBEOMF[PHELBJLAHPB][KAOJBICNACP];
		}
		MethodInfo method = PHELBJLAHPB.GetMethod("op_Implicit", new Type[1] { KAOJBICNACP });
		lock (HCNIMELJIED)
		{
			try
			{
				APMCBLBEOMF[PHELBJLAHPB].Add(KAOJBICNACP, method);
				return method;
			}
			catch (ArgumentException)
			{
				return APMCBLBEOMF[PHELBJLAHPB][KAOJBICNACP];
			}
		}
	}

	private static object CAKLGDEIEAL(Type MINOENCKFDF, IDHLOFNGDHH KEAHPPEIJFH)
	{
		KEAHPPEIJFH.BHCPIKOHHCC();
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.GJEANIKMDEB)
		{
			return null;
		}
		Type underlyingType = Nullable.GetUnderlyingType(MINOENCKFDF);
		Type type = underlyingType ?? MINOENCKFDF;
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.DAEHCFGPDGK)
		{
			if (MINOENCKFDF.IsClass || underlyingType != null)
			{
				return null;
			}
			throw new OBKEGAPIMKL($"Can't assign null to an instance of type {MINOENCKFDF}");
		}
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.OBGAGJIJNJE || KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.CKFFAMAGBFB || KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.FALOGJGDGMK || KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.IEOBEKAGFOM || KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.KENBGHBDLCI)
		{
			Type type2 = KEAHPPEIJFH.JFLFLCDEEEI.GetType();
			if (type.IsAssignableFrom(type2))
			{
				return KEAHPPEIJFH.JFLFLCDEEEI;
			}
			if (BHAPEHPAGJA.ContainsKey(type2) && BHAPEHPAGJA[type2].ContainsKey(type))
			{
				NBGNJGAGFJH nBGNJGAGFJH = BHAPEHPAGJA[type2][type];
				return nBGNJGAGFJH(KEAHPPEIJFH.JFLFLCDEEEI);
			}
			if (EEPMFDJHNFK.ContainsKey(type2) && EEPMFDJHNFK[type2].ContainsKey(type))
			{
				NBGNJGAGFJH nBGNJGAGFJH2 = EEPMFDJHNFK[type2][type];
				return nBGNJGAGFJH2(KEAHPPEIJFH.JFLFLCDEEEI);
			}
			if (type.IsEnum)
			{
				return Enum.ToObject(type, KEAHPPEIJFH.JFLFLCDEEEI);
			}
			MethodInfo methodInfo = MEIJEMPGELK(type, type2);
			if (methodInfo != null)
			{
				return methodInfo.Invoke(null, new object[1] { KEAHPPEIJFH.JFLFLCDEEEI });
			}
			throw new OBKEGAPIMKL($"Can't assign value '{KEAHPPEIJFH.JFLFLCDEEEI}' (type {type2}) to type {MINOENCKFDF}");
		}
		object obj = null;
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.GNDGIGKHDME)
		{
			GCEDFEGFJMK(MINOENCKFDF);
			NPAIGILPBMJ nPAIGILPBMJ = BKGHKPEFCJF[MINOENCKFDF];
			if (!nPAIGILPBMJ.OPEHJBFMKHC && !nPAIGILPBMJ.PBKJDDMIECE)
			{
				throw new OBKEGAPIMKL($"Type {MINOENCKFDF} can't act as an array");
			}
			IList list;
			Type type3;
			if (!nPAIGILPBMJ.OPEHJBFMKHC)
			{
				list = (IList)Activator.CreateInstance(MINOENCKFDF);
				type3 = nPAIGILPBMJ.KFJKJGDAEFM;
			}
			else
			{
				list = new ArrayList();
				type3 = MINOENCKFDF.GetElementType();
			}
			while (true)
			{
				object obj2 = CAKLGDEIEAL(type3, KEAHPPEIJFH);
				if (obj2 == null && KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.GJEANIKMDEB)
				{
					break;
				}
				list.Add(obj2);
			}
			if (nPAIGILPBMJ.OPEHJBFMKHC)
			{
				int count = list.Count;
				obj = Array.CreateInstance(type3, count);
				for (int i = 0; i < count; i++)
				{
					((Array)obj).SetValue(list[i], i);
				}
			}
			else
			{
				obj = list;
			}
		}
		else if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.OAKBPBLFPDJ)
		{
			JOILONAGNOA(type);
			NCKBEBLECML nCKBEBLECML = AIAHLNLEJHP[type];
			obj = Activator.CreateInstance(type);
			while (true)
			{
				KEAHPPEIJFH.BHCPIKOHHCC();
				if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.DFHBACBHKEC)
				{
					break;
				}
				string text = (string)KEAHPPEIJFH.JFLFLCDEEEI;
				if (nCKBEBLECML.BKHIOGHNDBB.ContainsKey(text))
				{
					PGOCJGCKGNH pGOCJGCKGNH = nCKBEBLECML.BKHIOGHNDBB[text];
					if (pGOCJGCKGNH.BDOLAOAODGK)
					{
						((FieldInfo)pGOCJGCKGNH.PAECJMCHEOC).SetValue(obj, CAKLGDEIEAL(pGOCJGCKGNH.JCPEOOKNNFN, KEAHPPEIJFH));
						continue;
					}
					PropertyInfo propertyInfo = (PropertyInfo)pGOCJGCKGNH.PAECJMCHEOC;
					if (propertyInfo.CanWrite)
					{
						propertyInfo.SetValue(obj, CAKLGDEIEAL(pGOCJGCKGNH.JCPEOOKNNFN, KEAHPPEIJFH), null);
					}
					else
					{
						CAKLGDEIEAL(pGOCJGCKGNH.JCPEOOKNNFN, KEAHPPEIJFH);
					}
				}
				else if (!nCKBEBLECML.EOFHILDCGME)
				{
					if (!KEAHPPEIJFH.NOOPCIEIBNA)
					{
						throw new OBKEGAPIMKL($"The type {MINOENCKFDF} doesn't have the property '{text}'");
					}
					NOBLCJCLCHF(KEAHPPEIJFH);
				}
				else
				{
					((IDictionary)obj).Add(text, CAKLGDEIEAL(nCKBEBLECML.KFJKJGDAEFM, KEAHPPEIJFH));
				}
			}
		}
		return obj;
	}

	private static OJIPMPCNDHB CAKLGDEIEAL(NBEMBPIHGMI COLGBCKHGFL, IDHLOFNGDHH KEAHPPEIJFH)
	{
		KEAHPPEIJFH.BHCPIKOHHCC();
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.GJEANIKMDEB || KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.DAEHCFGPDGK)
		{
			return null;
		}
		OJIPMPCNDHB oJIPMPCNDHB = COLGBCKHGFL();
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.IEOBEKAGFOM)
		{
			oJIPMPCNDHB.DCGOPJDMEEG((string)KEAHPPEIJFH.JFLFLCDEEEI);
			return oJIPMPCNDHB;
		}
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.OBGAGJIJNJE)
		{
			oJIPMPCNDHB.COIMAHJLGIP((double)KEAHPPEIJFH.JFLFLCDEEEI);
			return oJIPMPCNDHB;
		}
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.CKFFAMAGBFB)
		{
			oJIPMPCNDHB.OLEHBAMBPDE((int)KEAHPPEIJFH.JFLFLCDEEEI);
			return oJIPMPCNDHB;
		}
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.FALOGJGDGMK)
		{
			oJIPMPCNDHB.CMKKKMFFFFL((long)KEAHPPEIJFH.JFLFLCDEEEI);
			return oJIPMPCNDHB;
		}
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.KENBGHBDLCI)
		{
			oJIPMPCNDHB.HBEDJAGMNKL((bool)KEAHPPEIJFH.JFLFLCDEEEI);
			return oJIPMPCNDHB;
		}
		if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.GNDGIGKHDME)
		{
			oJIPMPCNDHB.KPJPMGPGDJG(JNJKIPFENMC.ICNPMMKBFMA);
			while (true)
			{
				OJIPMPCNDHB oJIPMPCNDHB2 = CAKLGDEIEAL(COLGBCKHGFL, KEAHPPEIJFH);
				if (oJIPMPCNDHB2 == null && KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.GJEANIKMDEB)
				{
					break;
				}
				oJIPMPCNDHB.Add(oJIPMPCNDHB2);
			}
		}
		else if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.OAKBPBLFPDJ)
		{
			oJIPMPCNDHB.KPJPMGPGDJG(JNJKIPFENMC.MDONKBLCDIP);
			while (true)
			{
				KEAHPPEIJFH.BHCPIKOHHCC();
				if (KEAHPPEIJFH.OHIFCKIJHMC == MBNLAMLBJNM.DFHBACBHKEC)
				{
					break;
				}
				string key = (string)KEAHPPEIJFH.JFLFLCDEEEI;
				oJIPMPCNDHB[key] = CAKLGDEIEAL(COLGBCKHGFL, KEAHPPEIJFH);
			}
		}
		return oJIPMPCNDHB;
	}

	private static void NOBLCJCLCHF(IDHLOFNGDHH KEAHPPEIJFH)
	{
		NOPBGKNNMIO(() => new FJDPEFJNGPP(), KEAHPPEIJFH);
	}

	private static void JBPEPHJCAIG()
	{
		FNCGELLDELC[typeof(byte)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((byte)FFBEPGEKANM));
		};
		FNCGELLDELC[typeof(char)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(Convert.ToString((char)FFBEPGEKANM));
		};
		FNCGELLDELC[typeof(DateTime)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(Convert.ToString((DateTime)FFBEPGEKANM, CONMOIEENOO));
		};
		FNCGELLDELC[typeof(decimal)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI((decimal)FFBEPGEKANM);
		};
		FNCGELLDELC[typeof(sbyte)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((sbyte)FFBEPGEKANM));
		};
		FNCGELLDELC[typeof(short)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((short)FFBEPGEKANM));
		};
		FNCGELLDELC[typeof(ushort)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((ushort)FFBEPGEKANM));
		};
		FNCGELLDELC[typeof(uint)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI(Convert.ToUInt64((uint)FFBEPGEKANM));
		};
		FNCGELLDELC[typeof(ulong)] = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			ACALPNFLMEP.KLPPJEDJOAI((ulong)FFBEPGEKANM);
		};
	}

	private static void GPLIAIEKDLM()
	{
		NBGNJGAGFJH lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToByte((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(byte), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToUInt64((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(ulong), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToInt64((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(long), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToSByte((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(sbyte), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToInt16((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(short), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToUInt16((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(ushort), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToUInt32((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(uint), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToSingle((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(float), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToDouble((int)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(int), typeof(double), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToDecimal((double)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(double), typeof(decimal), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToUInt32((long)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(long), typeof(uint), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToChar((string)MMKMICOONDG);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(string), typeof(char), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => Convert.ToDateTime((string)MMKMICOONDG, CONMOIEENOO);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(string), typeof(DateTime), lGJEBFPOIMH);
		lGJEBFPOIMH = (object MMKMICOONDG) => DateTimeOffset.Parse((string)MMKMICOONDG, CONMOIEENOO);
		OHBLBGLPKMC(EEPMFDJHNFK, typeof(string), typeof(DateTimeOffset), lGJEBFPOIMH);
	}

	private static void OHBLBGLPKMC(IDictionary<Type, IDictionary<Type, NBGNJGAGFJH>> BOPPOMALCOL, Type GPILOANNOHC, Type BJNALIDLDPN, NBGNJGAGFJH LGJEBFPOIMH)
	{
		if (!BOPPOMALCOL.ContainsKey(GPILOANNOHC))
		{
			BOPPOMALCOL.Add(GPILOANNOHC, new Dictionary<Type, NBGNJGAGFJH>());
		}
		BOPPOMALCOL[GPILOANNOHC][BJNALIDLDPN] = LGJEBFPOIMH;
	}

	private static void GHHGMIECJCC(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP, bool PDEOAFNFKBP, int MODDPGGGCLN)
	{
		if (MODDPGGGCLN > NDPILNBAFME)
		{
			throw new OBKEGAPIMKL($"Max allowed object depth reached while trying to export from type {FFBEPGEKANM.GetType()}");
		}
		if (FFBEPGEKANM == null)
		{
			ACALPNFLMEP.KLPPJEDJOAI(null);
			return;
		}
		if (FFBEPGEKANM is OJIPMPCNDHB)
		{
			if (PDEOAFNFKBP)
			{
				ACALPNFLMEP.NLMHMGKLLNJ.Write(((OJIPMPCNDHB)FFBEPGEKANM).GIBKHAGKJHE());
			}
			else
			{
				((OJIPMPCNDHB)FFBEPGEKANM).GIBKHAGKJHE(ACALPNFLMEP);
			}
			return;
		}
		if (FFBEPGEKANM is string)
		{
			ACALPNFLMEP.KLPPJEDJOAI((string)FFBEPGEKANM);
			return;
		}
		if (FFBEPGEKANM is double)
		{
			ACALPNFLMEP.KLPPJEDJOAI((double)FFBEPGEKANM);
			return;
		}
		if (FFBEPGEKANM is int)
		{
			ACALPNFLMEP.KLPPJEDJOAI((int)FFBEPGEKANM);
			return;
		}
		if (FFBEPGEKANM is bool)
		{
			ACALPNFLMEP.KLPPJEDJOAI((bool)FFBEPGEKANM);
			return;
		}
		if (FFBEPGEKANM is long)
		{
			ACALPNFLMEP.KLPPJEDJOAI((long)FFBEPGEKANM);
			return;
		}
		if (FFBEPGEKANM is Array)
		{
			ACALPNFLMEP.PJNKLJEGOGE();
			foreach (object item in (Array)FFBEPGEKANM)
			{
				GHHGMIECJCC(item, ACALPNFLMEP, PDEOAFNFKBP, MODDPGGGCLN + 1);
			}
			ACALPNFLMEP.KACAGCKFEMI();
			return;
		}
		if (FFBEPGEKANM is IList)
		{
			ACALPNFLMEP.PJNKLJEGOGE();
			foreach (object item2 in (IList)FFBEPGEKANM)
			{
				GHHGMIECJCC(item2, ACALPNFLMEP, PDEOAFNFKBP, MODDPGGGCLN + 1);
			}
			ACALPNFLMEP.KACAGCKFEMI();
			return;
		}
		if (FFBEPGEKANM is IDictionary)
		{
			ACALPNFLMEP.LICPKOJEGEN();
			foreach (DictionaryEntry item3 in (IDictionary)FFBEPGEKANM)
			{
				ACALPNFLMEP.PPHOCDMCEGM((string)item3.Key);
				GHHGMIECJCC(item3.Value, ACALPNFLMEP, PDEOAFNFKBP, MODDPGGGCLN + 1);
			}
			ACALPNFLMEP.CKMGOMNNFGN();
			return;
		}
		Type type = FFBEPGEKANM.GetType();
		if (EEIBIGICOFF.ContainsKey(type))
		{
			MNCGHLAIDCA mNCGHLAIDCA = EEIBIGICOFF[type];
			mNCGHLAIDCA(FFBEPGEKANM, ACALPNFLMEP);
			return;
		}
		if (FNCGELLDELC.ContainsKey(type))
		{
			MNCGHLAIDCA mNCGHLAIDCA2 = FNCGELLDELC[type];
			mNCGHLAIDCA2(FFBEPGEKANM, ACALPNFLMEP);
			return;
		}
		if (FFBEPGEKANM is Enum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type);
			if (underlyingType == typeof(long) || underlyingType == typeof(uint) || underlyingType == typeof(ulong))
			{
				ACALPNFLMEP.KLPPJEDJOAI((ulong)FFBEPGEKANM);
			}
			else
			{
				ACALPNFLMEP.KLPPJEDJOAI((int)FFBEPGEKANM);
			}
			return;
		}
		AGPBMEOAFAI(type);
		IList<PGOCJGCKGNH> list = GMOIELJCAHA[type];
		ACALPNFLMEP.LICPKOJEGEN();
		foreach (PGOCJGCKGNH item4 in list)
		{
			if (item4.BDOLAOAODGK)
			{
				ACALPNFLMEP.PPHOCDMCEGM(item4.PAECJMCHEOC.Name);
				GHHGMIECJCC(((FieldInfo)item4.PAECJMCHEOC).GetValue(FFBEPGEKANM), ACALPNFLMEP, PDEOAFNFKBP, MODDPGGGCLN + 1);
				continue;
			}
			PropertyInfo propertyInfo = (PropertyInfo)item4.PAECJMCHEOC;
			if (propertyInfo.CanRead)
			{
				ACALPNFLMEP.PPHOCDMCEGM(item4.PAECJMCHEOC.Name);
				GHHGMIECJCC(propertyInfo.GetValue(FFBEPGEKANM, null), ACALPNFLMEP, PDEOAFNFKBP, MODDPGGGCLN + 1);
			}
		}
		ACALPNFLMEP.CKMGOMNNFGN();
	}

	public static string GIBKHAGKJHE(object FFBEPGEKANM)
	{
		lock (FNJGBGLEPNA)
		{
			DGEDKAIAPIL.PLPPLAIKDNA();
			GHHGMIECJCC(FFBEPGEKANM, DGEDKAIAPIL, PDEOAFNFKBP: true, 0);
			return DGEDKAIAPIL.ToString();
		}
	}

	public static void GIBKHAGKJHE(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		GHHGMIECJCC(FFBEPGEKANM, ACALPNFLMEP, PDEOAFNFKBP: false, 0);
	}

	public static FLFCPGBMGHH AAPLAPBIFMD(IDHLOFNGDHH KEAHPPEIJFH)
	{
		return (FLFCPGBMGHH)NOPBGKNNMIO(() => new FLFCPGBMGHH(), KEAHPPEIJFH);
	}

	public static FLFCPGBMGHH AAPLAPBIFMD(TextReader KEAHPPEIJFH)
	{
		IDHLOFNGDHH kEAHPPEIJFH = new IDHLOFNGDHH(KEAHPPEIJFH);
		return (FLFCPGBMGHH)NOPBGKNNMIO(() => new FLFCPGBMGHH(), kEAHPPEIJFH);
	}

	public static FLFCPGBMGHH AAPLAPBIFMD(string GMIHNCCACKM)
	{
		return (FLFCPGBMGHH)NOPBGKNNMIO(() => new FLFCPGBMGHH(), GMIHNCCACKM);
	}

	public static T AAPLAPBIFMD<T>(IDHLOFNGDHH KEAHPPEIJFH)
	{
		return (T)CAKLGDEIEAL(typeof(T), KEAHPPEIJFH);
	}

	public static T AAPLAPBIFMD<T>(TextReader KEAHPPEIJFH)
	{
		IDHLOFNGDHH kEAHPPEIJFH = new IDHLOFNGDHH(KEAHPPEIJFH);
		return (T)CAKLGDEIEAL(typeof(T), kEAHPPEIJFH);
	}

	public static T AAPLAPBIFMD<T>(string GMIHNCCACKM)
	{
		IDHLOFNGDHH kEAHPPEIJFH = new IDHLOFNGDHH(GMIHNCCACKM);
		return (T)CAKLGDEIEAL(typeof(T), kEAHPPEIJFH);
	}

	public static object AAPLAPBIFMD(string GMIHNCCACKM, Type MKAKHHEBKFB)
	{
		IDHLOFNGDHH kEAHPPEIJFH = new IDHLOFNGDHH(GMIHNCCACKM);
		return CAKLGDEIEAL(MKAKHHEBKFB, kEAHPPEIJFH);
	}

	public static OJIPMPCNDHB NOPBGKNNMIO(NBEMBPIHGMI COLGBCKHGFL, IDHLOFNGDHH KEAHPPEIJFH)
	{
		return CAKLGDEIEAL(COLGBCKHGFL, KEAHPPEIJFH);
	}

	public static OJIPMPCNDHB NOPBGKNNMIO(NBEMBPIHGMI COLGBCKHGFL, string GMIHNCCACKM)
	{
		IDHLOFNGDHH kEAHPPEIJFH = new IDHLOFNGDHH(GMIHNCCACKM);
		return CAKLGDEIEAL(COLGBCKHGFL, kEAHPPEIJFH);
	}

	public static void HJHDKNMALOO<T>(global::NCHMGLDLHDP<T> MDDBAIEBIJN)
	{
		MNCGHLAIDCA value = delegate(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
		{
			MDDBAIEBIJN((T)FFBEPGEKANM, ACALPNFLMEP);
		};
		EEIBIGICOFF[typeof(T)] = value;
	}

	public static void OHBLBGLPKMC<TJson, TValue>(global::AGKLBOCNPGP<TJson, TValue> LGJEBFPOIMH)
	{
		NBGNJGAGFJH lGJEBFPOIMH = (object MMKMICOONDG) => LGJEBFPOIMH((TJson)MMKMICOONDG);
		OHBLBGLPKMC(BHAPEHPAGJA, typeof(TJson), typeof(TValue), lGJEBFPOIMH);
	}

	public static void BOBAANCJHMK()
	{
		EEIBIGICOFF.Clear();
	}

	public static void PGFKECGBCPO()
	{
		BHAPEHPAGJA.Clear();
	}

	[CompilerGenerated]
	private static OJIPMPCNDHB BCEHGOBDBFE()
	{
		return new FJDPEFJNGPP();
	}

	[CompilerGenerated]
	private static void HBMENCEFEIF(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((byte)FFBEPGEKANM));
	}

	[CompilerGenerated]
	private static void IJJCPHPKKON(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI(Convert.ToString((char)FFBEPGEKANM));
	}

	[CompilerGenerated]
	private static void POLLJMNDKBE(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI(Convert.ToString((DateTime)FFBEPGEKANM, CONMOIEENOO));
	}

	[CompilerGenerated]
	private static void JNFGOANGKPN(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI((decimal)FFBEPGEKANM);
	}

	[CompilerGenerated]
	private static void HILKAHJHMJG(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((sbyte)FFBEPGEKANM));
	}

	[CompilerGenerated]
	private static void NEHBEEOHLFE(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((short)FFBEPGEKANM));
	}

	[CompilerGenerated]
	private static void BDKJJBKNFDN(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI(Convert.ToInt32((ushort)FFBEPGEKANM));
	}

	[CompilerGenerated]
	private static void KENODMGBNOG(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI(Convert.ToUInt64((uint)FFBEPGEKANM));
	}

	[CompilerGenerated]
	private static void JGCCCGIKHPI(object FFBEPGEKANM, OGDMCPOJKLP ACALPNFLMEP)
	{
		ACALPNFLMEP.KLPPJEDJOAI((ulong)FFBEPGEKANM);
	}

	[CompilerGenerated]
	private static object BDKNNHGCLAA(object MMKMICOONDG)
	{
		return Convert.ToByte((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object HIJPGOBNHAO(object MMKMICOONDG)
	{
		return Convert.ToUInt64((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object LHFLEHDBHJA(object MMKMICOONDG)
	{
		return Convert.ToInt64((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object BJLHANCMAMC(object MMKMICOONDG)
	{
		return Convert.ToSByte((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object AGPCJHJODLI(object MMKMICOONDG)
	{
		return Convert.ToInt16((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object EHJEJJDLPIA(object MMKMICOONDG)
	{
		return Convert.ToUInt16((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object NPCEBEPEOBI(object MMKMICOONDG)
	{
		return Convert.ToUInt32((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object GMNEHGHNDDO(object MMKMICOONDG)
	{
		return Convert.ToSingle((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object EBJLGEBFOLO(object MMKMICOONDG)
	{
		return Convert.ToDouble((int)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object MDIJNHOKMMM(object MMKMICOONDG)
	{
		return Convert.ToDecimal((double)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object AHJBAKGAFFL(object MMKMICOONDG)
	{
		return Convert.ToUInt32((long)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object EDBBKLBGLCH(object MMKMICOONDG)
	{
		return Convert.ToChar((string)MMKMICOONDG);
	}

	[CompilerGenerated]
	private static object PPOIDMKIBFP(object MMKMICOONDG)
	{
		return Convert.ToDateTime((string)MMKMICOONDG, CONMOIEENOO);
	}

	[CompilerGenerated]
	private static object CPBDLBBFNKB(object MMKMICOONDG)
	{
		return DateTimeOffset.Parse((string)MMKMICOONDG, CONMOIEENOO);
	}

	[CompilerGenerated]
	private static OJIPMPCNDHB MOJCKHLEEEL()
	{
		return new FLFCPGBMGHH();
	}

	[CompilerGenerated]
	private static OJIPMPCNDHB EIPMCIPAPPB()
	{
		return new FLFCPGBMGHH();
	}

	[CompilerGenerated]
	private static OJIPMPCNDHB HALMOHIEKFL()
	{
		return new FLFCPGBMGHH();
	}
}
