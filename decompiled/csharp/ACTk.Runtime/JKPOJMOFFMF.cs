using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public static class JKPOJMOFFMF
{
	internal enum CJOCHMMKGJD : byte
	{
		PEDDDHJCFHL = 0,
		CKFFAMAGBFB = 5,
		DGMKDJKEBPP = 10,
		IEOBEKAGFOM = 15,
		HICNDFBOMEE = 20,
		OBGAGJIJNJE = 25,
		IHFMNELILIL = 27,
		FALOGJGDGMK = 30,
		MNANCEBFKFC = 32,
		IDCFHIHCPDM = 35,
		GIFLGPMPEGH = 40,
		OMFDCJOJJJF = 45,
		CEHADPOGPOI = 50,
		ADLHMFOLMBI = 55,
		KEMNJHJMECE = 60,
		LACLEAPHNGF = 65
	}

	public enum CPFFLLELHCF : byte
	{
		BLBOPPEBDFH,
		CGGHEPNNCIL,
		OCMPNMPDACG
	}

	internal const string HNEGFGLIHEC = "9978e9f39c218d674463dab9dc728bd6";

	private const string JJOGMGHIBEF = "{not_found}";

	private const string ECHFMJKEMLH = "[ACTk] ObscuredPrefs: ";

	private const byte OHHJOJCOFMK = 3;

	private static bool DCPPENDEMKD;

	private static bool HIHHBEACCKC;

	private static string CHMIJHGICBL;

	private static string MMNNIMHKNAH = "e806f6";

	private static string MOODPOELGFB;

	internal static uint FEIJJGEODAA;

	public static bool LDOMCMAKBFN;

	public static CPFFLLELHCF GNLIPCJFMEM;

	public static bool MDACPNMDPDJ;

	public static bool JLAEAPPNLDL;

	private static readonly Type HCJDCBEABDG = typeof(int);

	private static readonly Type LLBLLBOOJKJ = typeof(uint);

	private static readonly Type PNOIILFPGDI = typeof(string);

	private static readonly Type IKOOLJCHICE = typeof(float);

	private static readonly Type JCPOKLCIDEG = typeof(double);

	private static readonly Type KAMFOLCGOIH = typeof(decimal);

	private static readonly Type JPFAGOPFNGM = typeof(long);

	private static readonly Type FIGELPJLKJH = typeof(ulong);

	private static readonly Type KBICFHMILFC = typeof(bool);

	private static char[] AOFCONBAPLL;

	private static bool AECDGJCMGHC;

	[Obsolete("Custom crypto key is now obsolete, use only for data recovery from prefs saved with previous version. This property will be removed in future versions.")]
	public static string GMNENDEABMH
	{
		get
		{
			return MMNNIMHKNAH;
		}
		set
		{
			MMNNIMHKNAH = value;
		}
	}

	public static string NNJGDBIEMCH
	{
		get
		{
			if (string.IsNullOrEmpty(CHMIJHGICBL))
			{
				CHMIJHGICBL = CBKGFKIHHIM();
			}
			return CHMIJHGICBL;
		}
		set
		{
			CHMIJHGICBL = value;
		}
	}

	internal static uint JOAGIOLKOBC
	{
		get
		{
			if (FEIJJGEODAA == 0)
			{
				FEIJJGEODAA = OCEMAOPDEDK(NNJGDBIEMCH);
			}
			return FEIJJGEODAA;
		}
	}

	public static event Action INFNILAJCFN;

	public static event Action CMCNHIADLAM;

	public static void FEGODEMKPNL()
	{
		if (FEIJJGEODAA == 0)
		{
			CHMIJHGICBL = CBKGFKIHHIM();
			FEIJJGEODAA = OCEMAOPDEDK(CHMIJHGICBL);
		}
		else
		{
			Debug.LogWarning("[ACTk] ObscuredPrefs: ForceLockToDeviceInit() is called, but device ID is already obtained!");
		}
	}

	public static void LKDAPEPGMHB(string MBNMHOLKJPG, string NOEHPGOEOMM)
	{
		PlayerPrefs.SetString(MBNMHOLKJPG, NOEHPGOEOMM);
	}

	public static bool NIACFMFPAKM(string JPBEBBODCJJ, out string MBNMHOLKJPG, out string NOEHPGOEOMM)
	{
		NOEHPGOEOMM = null;
		MBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		if (!PlayerPrefs.HasKey(MBNMHOLKJPG))
		{
			return false;
		}
		NOEHPGOEOMM = PlayerPrefs.GetString(MBNMHOLKJPG);
		return true;
	}

	public static bool BCHKAKOPNKB(string JPBEBBODCJJ)
	{
		return PlayerPrefs.HasKey(JPBEBBODCJJ) || PlayerPrefs.HasKey(LMAAHMOIGOK(JPBEBBODCJJ));
	}

	public static void NIFDLJCPHIN(string JPBEBBODCJJ)
	{
		PlayerPrefs.DeleteKey(LMAAHMOIGOK(JPBEBBODCJJ));
		if (!LDOMCMAKBFN)
		{
			PlayerPrefs.DeleteKey(JPBEBBODCJJ);
		}
	}

	public static void HPGENNDEEEB()
	{
		PlayerPrefs.DeleteKey("9978e9f39c218d674463dab9dc728bd6");
		AOFCONBAPLL = null;
		FEIJJGEODAA = 0u;
	}

	public static void FBEPNCOCNBF()
	{
		PlayerPrefs.DeleteAll();
		AOFCONBAPLL = null;
		FEIJJGEODAA = 0u;
	}

	public static void OBKMIHILMLH()
	{
		PlayerPrefs.Save();
	}

	public static void OLEHBAMBPDE(string JPBEBBODCJJ, int EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static int GMOOMLGMADD(string JPBEBBODCJJ, int DKCOCMAHPCN = 0)
	{
		string text = LMAAHMOIGOK(JPBEBBODCJJ);
		if (!PlayerPrefs.HasKey(text))
		{
			if (PlayerPrefs.HasKey(JPBEBBODCJJ))
			{
				int @int = PlayerPrefs.GetInt(JPBEBBODCJJ, DKCOCMAHPCN);
				if (!LDOMCMAKBFN)
				{
					OLEHBAMBPDE(JPBEBBODCJJ, @int);
					PlayerPrefs.DeleteKey(JPBEBBODCJJ);
				}
				return @int;
			}
			APFBMIHKGAA(JPBEBBODCJJ, MMNNIMHKNAH);
		}
		return CHHHPOHOCJG(JPBEBBODCJJ, text, DKCOCMAHPCN);
	}

	public static void JKKBGGENIDA(string JPBEBBODCJJ, uint EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static uint HHFPOKNICOB(string JPBEBBODCJJ, uint DKCOCMAHPCN = 0u)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		return CHHHPOHOCJG(JPBEBBODCJJ, mBNMHOLKJPG, DKCOCMAHPCN);
	}

	public static void DCGOPJDMEEG(string JPBEBBODCJJ, string EHAPKEKPMOE)
	{
		if (JPBEBBODCJJ == null)
		{
			throw new ArgumentNullException("key");
		}
		if (EHAPKEKPMOE == null)
		{
			EHAPKEKPMOE = string.Empty;
		}
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static string KKNHDKLDCHI(string JPBEBBODCJJ, string DKCOCMAHPCN = "")
	{
		string text = LMAAHMOIGOK(JPBEBBODCJJ);
		if (!PlayerPrefs.HasKey(text))
		{
			if (PlayerPrefs.HasKey(JPBEBBODCJJ))
			{
				string @string = PlayerPrefs.GetString(JPBEBBODCJJ, DKCOCMAHPCN);
				if (!LDOMCMAKBFN)
				{
					DCGOPJDMEEG(JPBEBBODCJJ, @string);
					PlayerPrefs.DeleteKey(JPBEBBODCJJ);
				}
				return @string;
			}
			APFBMIHKGAA(JPBEBBODCJJ, MMNNIMHKNAH);
		}
		return CHHHPOHOCJG(JPBEBBODCJJ, text, DKCOCMAHPCN);
	}

	public static void FOFEDEEKMNC(string JPBEBBODCJJ, float EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static float OKJLGPNLEIG(string JPBEBBODCJJ, float DKCOCMAHPCN = 0f)
	{
		string text = LMAAHMOIGOK(JPBEBBODCJJ);
		if (!PlayerPrefs.HasKey(text))
		{
			if (PlayerPrefs.HasKey(JPBEBBODCJJ))
			{
				float @float = PlayerPrefs.GetFloat(JPBEBBODCJJ, DKCOCMAHPCN);
				if (!LDOMCMAKBFN)
				{
					FOFEDEEKMNC(JPBEBBODCJJ, @float);
					PlayerPrefs.DeleteKey(JPBEBBODCJJ);
				}
				return @float;
			}
			APFBMIHKGAA(JPBEBBODCJJ, MMNNIMHKNAH);
		}
		return CHHHPOHOCJG(JPBEBBODCJJ, text, DKCOCMAHPCN);
	}

	public static void COIMAHJLGIP(string JPBEBBODCJJ, double EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static double DGMIJFDFHEC(string JPBEBBODCJJ, double DKCOCMAHPCN = 0.0)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		return CHHHPOHOCJG(JPBEBBODCJJ, mBNMHOLKJPG, DKCOCMAHPCN);
	}

	public static void NOEHJHHHEEA(string JPBEBBODCJJ, decimal EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static decimal HGLAFLIEAOD(string JPBEBBODCJJ, decimal DKCOCMAHPCN = 0m)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		return CHHHPOHOCJG(JPBEBBODCJJ, mBNMHOLKJPG, DKCOCMAHPCN);
	}

	public static void CMKKKMFFFFL(string JPBEBBODCJJ, long EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static long AOBMLGGGOOP(string JPBEBBODCJJ, long DKCOCMAHPCN = 0L)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		return CHHHPOHOCJG(JPBEBBODCJJ, mBNMHOLKJPG, DKCOCMAHPCN);
	}

	public static void ILMHPJCACLJ(string JPBEBBODCJJ, ulong EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static ulong PEGHKBBDNHC(string JPBEBBODCJJ, ulong DKCOCMAHPCN = 0uL)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		return CHHHPOHOCJG(JPBEBBODCJJ, mBNMHOLKJPG, DKCOCMAHPCN);
	}

	public static void IEPDFENGEBI(string JPBEBBODCJJ, bool EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BMJEKEBHBDP(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static bool CICOFEMMELG(string JPBEBBODCJJ, bool DKCOCMAHPCN = false)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		return CHHHPOHOCJG(JPBEBBODCJJ, mBNMHOLKJPG, DKCOCMAHPCN);
	}

	public static void MDNGAFKCMEK(string JPBEBBODCJJ, byte[] EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), KDLFFBMKPNB(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static byte[] OJGDNPINPDA(string JPBEBBODCJJ, byte DKCOCMAHPCN = 0, int ADHKBHEOEOF = 0)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		string text = OMAKEMBDAIG(JPBEBBODCJJ, mBNMHOLKJPG);
		if (text == "{not_found}")
		{
			return CJOJDLGGEFH(DKCOCMAHPCN, ADHKBHEOEOF);
		}
		return HJLHPBFJFML(JPBEBBODCJJ, text, DKCOCMAHPCN, ADHKBHEOEOF);
	}

	private static string KDLFFBMKPNB(string JPBEBBODCJJ, byte[] EHAPKEKPMOE)
	{
		return OHCLAAHNMOH(JPBEBBODCJJ, EHAPKEKPMOE, CJOCHMMKGJD.GIFLGPMPEGH);
	}

	private static byte[] HJLHPBFJFML(string JPBEBBODCJJ, string JOAEIGCNHDK, byte DKCOCMAHPCN, int ADHKBHEOEOF)
	{
		byte[] array = IGGIDHDNGLO(JPBEBBODCJJ, JOAEIGCNHDK);
		return array ?? CJOJDLGGEFH(DKCOCMAHPCN, ADHKBHEOEOF);
	}

	private static byte[] CJOJDLGGEFH(byte EHAPKEKPMOE, int JMBJALGFMPA)
	{
		byte[] array = new byte[JMBJALGFMPA];
		for (int i = 0; i < JMBJALGFMPA; i++)
		{
			array[i] = EHAPKEKPMOE;
		}
		return array;
	}

	public static void FJIDNFIONIH(string JPBEBBODCJJ, Vector2 EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), NBNIAIFKPDN(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static Vector2 BPJAELCHAAH(string JPBEBBODCJJ)
	{
		return BPJAELCHAAH(JPBEBBODCJJ, Vector2.zero);
	}

	public static Vector2 BPJAELCHAAH(string JPBEBBODCJJ, Vector2 DKCOCMAHPCN)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		string text = OMAKEMBDAIG(JPBEBBODCJJ, mBNMHOLKJPG);
		return (!(text == "{not_found}")) ? NNHFJDAEAAK(JPBEBBODCJJ, text, DKCOCMAHPCN) : DKCOCMAHPCN;
	}

	private static string NBNIAIFKPDN(string JPBEBBODCJJ, Vector2 EHAPKEKPMOE)
	{
		byte[] array = new byte[8];
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.y), 0, array, 4, 4);
		return OHCLAAHNMOH(JPBEBBODCJJ, array, CJOCHMMKGJD.OMFDCJOJJJF);
	}

	private static Vector2 NNHFJDAEAAK(string JPBEBBODCJJ, string JOAEIGCNHDK, Vector2 DKCOCMAHPCN)
	{
		byte[] array = IGGIDHDNGLO(JPBEBBODCJJ, JOAEIGCNHDK);
		if (array == null)
		{
			return DKCOCMAHPCN;
		}
		Vector2 result = default(Vector2);
		result.x = BitConverter.ToSingle(array, 0);
		result.y = BitConverter.ToSingle(array, 4);
		return result;
	}

	public static void PCLHLBLCNCP(string JPBEBBODCJJ, Vector3 EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), CIDIPJHPCOC(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static Vector3 FLKFPOGOJCH(string JPBEBBODCJJ)
	{
		return FLKFPOGOJCH(JPBEBBODCJJ, Vector3.zero);
	}

	public static Vector3 FLKFPOGOJCH(string JPBEBBODCJJ, Vector3 DKCOCMAHPCN)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		string text = OMAKEMBDAIG(JPBEBBODCJJ, mBNMHOLKJPG);
		return (!(text == "{not_found}")) ? COMEIMOIHAM(JPBEBBODCJJ, text, DKCOCMAHPCN) : DKCOCMAHPCN;
	}

	private static string CIDIPJHPCOC(string JPBEBBODCJJ, Vector3 EHAPKEKPMOE)
	{
		byte[] array = new byte[12];
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.y), 0, array, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.z), 0, array, 8, 4);
		return OHCLAAHNMOH(JPBEBBODCJJ, array, CJOCHMMKGJD.CEHADPOGPOI);
	}

	private static Vector3 COMEIMOIHAM(string JPBEBBODCJJ, string JOAEIGCNHDK, Vector3 DKCOCMAHPCN)
	{
		byte[] array = IGGIDHDNGLO(JPBEBBODCJJ, JOAEIGCNHDK);
		if (array == null)
		{
			return DKCOCMAHPCN;
		}
		Vector3 result = default(Vector3);
		result.x = BitConverter.ToSingle(array, 0);
		result.y = BitConverter.ToSingle(array, 4);
		result.z = BitConverter.ToSingle(array, 8);
		return result;
	}

	public static void NBBNGHFJGML(string JPBEBBODCJJ, Quaternion EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), BACIDCNOLKJ(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static Quaternion NEHACAOECHC(string JPBEBBODCJJ)
	{
		return NEHACAOECHC(JPBEBBODCJJ, Quaternion.identity);
	}

	public static Quaternion NEHACAOECHC(string JPBEBBODCJJ, Quaternion DKCOCMAHPCN)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		string text = OMAKEMBDAIG(JPBEBBODCJJ, mBNMHOLKJPG);
		return (!(text == "{not_found}")) ? ANHDELDBAMN(JPBEBBODCJJ, text, DKCOCMAHPCN) : DKCOCMAHPCN;
	}

	private static string BACIDCNOLKJ(string JPBEBBODCJJ, Quaternion EHAPKEKPMOE)
	{
		byte[] array = new byte[16];
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.y), 0, array, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.z), 0, array, 8, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.w), 0, array, 12, 4);
		return OHCLAAHNMOH(JPBEBBODCJJ, array, CJOCHMMKGJD.ADLHMFOLMBI);
	}

	private static Quaternion ANHDELDBAMN(string JPBEBBODCJJ, string JOAEIGCNHDK, Quaternion DKCOCMAHPCN)
	{
		byte[] array = IGGIDHDNGLO(JPBEBBODCJJ, JOAEIGCNHDK);
		if (array == null)
		{
			return DKCOCMAHPCN;
		}
		Quaternion result = default(Quaternion);
		result.x = BitConverter.ToSingle(array, 0);
		result.y = BitConverter.ToSingle(array, 4);
		result.z = BitConverter.ToSingle(array, 8);
		result.w = BitConverter.ToSingle(array, 12);
		return result;
	}

	public static void COGIBGGPEGJ(string JPBEBBODCJJ, Color32 EHAPKEKPMOE)
	{
		uint eHAPKEKPMOE = (uint)((EHAPKEKPMOE.a << 24) | (EHAPKEKPMOE.r << 16) | (EHAPKEKPMOE.g << 8) | EHAPKEKPMOE.b);
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), FNGHNPMNDFA(JPBEBBODCJJ, eHAPKEKPMOE));
	}

	public static Color32 LJBBDDAGGHC(string JPBEBBODCJJ)
	{
		return LJBBDDAGGHC(JPBEBBODCJJ, new Color32(0, 0, 0, 1));
	}

	public static Color32 LJBBDDAGGHC(string JPBEBBODCJJ, Color32 DKCOCMAHPCN)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		string text = OMAKEMBDAIG(JPBEBBODCJJ, mBNMHOLKJPG);
		if (text == "{not_found}")
		{
			return DKCOCMAHPCN;
		}
		uint kPCNCJLEGPE = CHHHPOHOCJG(JPBEBBODCJJ, mBNMHOLKJPG, 16777216u, text);
		return ANOEMPBIHLM(kPCNCJLEGPE);
	}

	private static string FNGHNPMNDFA(string JPBEBBODCJJ, uint EHAPKEKPMOE)
	{
		byte[] bytes = BitConverter.GetBytes(EHAPKEKPMOE);
		return OHCLAAHNMOH(JPBEBBODCJJ, bytes, CJOCHMMKGJD.KEMNJHJMECE);
	}

	public static void LBKPDHNIEGK(string JPBEBBODCJJ, Rect EHAPKEKPMOE)
	{
		PlayerPrefs.SetString(LMAAHMOIGOK(JPBEBBODCJJ), CNHLFCOPDPE(JPBEBBODCJJ, EHAPKEKPMOE));
	}

	public static Rect HAEGDJIDLJI(string JPBEBBODCJJ)
	{
		return HAEGDJIDLJI(JPBEBBODCJJ, new Rect(0f, 0f, 0f, 0f));
	}

	public static Rect HAEGDJIDLJI(string JPBEBBODCJJ, Rect DKCOCMAHPCN)
	{
		string mBNMHOLKJPG = LMAAHMOIGOK(JPBEBBODCJJ);
		string text = OMAKEMBDAIG(JPBEBBODCJJ, mBNMHOLKJPG);
		return (!(text == "{not_found}")) ? KDHKFBLLPAC(JPBEBBODCJJ, text, DKCOCMAHPCN) : DKCOCMAHPCN;
	}

	private static string CNHLFCOPDPE(string JPBEBBODCJJ, Rect EHAPKEKPMOE)
	{
		byte[] array = new byte[16];
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.y), 0, array, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.width), 0, array, 8, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(EHAPKEKPMOE.height), 0, array, 12, 4);
		return OHCLAAHNMOH(JPBEBBODCJJ, array, CJOCHMMKGJD.LACLEAPHNGF);
	}

	private static Rect KDHKFBLLPAC(string JPBEBBODCJJ, string JOAEIGCNHDK, Rect DKCOCMAHPCN)
	{
		byte[] array = IGGIDHDNGLO(JPBEBBODCJJ, JOAEIGCNHDK);
		if (array == null)
		{
			return DKCOCMAHPCN;
		}
		Rect result = default(Rect);
		result.x = BitConverter.ToSingle(array, 0);
		result.y = BitConverter.ToSingle(array, 4);
		result.width = BitConverter.ToSingle(array, 8);
		result.height = BitConverter.ToSingle(array, 12);
		return result;
	}

	public static bool LLCCLIBFIPG(string JPBEBBODCJJ, string JPCAMKFCCLH = "e806f6")
	{
		return APFBMIHKGAA(JPBEBBODCJJ, JPCAMKFCCLH);
	}

	public static string MDCDPMGBNON(string JPBEBBODCJJ, string JPCAMKFCCLH = "e806f6")
	{
		return CAICFBNFPHL.KFDHCOPFDGP(ObscuredString.FOPCCIAILGE(JPBEBBODCJJ, JPCAMKFCCLH));
	}

	private static void HDICFAFNPPF()
	{
		if (JKPOJMOFFMF.INFNILAJCFN != null && !DCPPENDEMKD)
		{
			DCPPENDEMKD = true;
			JKPOJMOFFMF.INFNILAJCFN();
		}
	}

	private static void KLKPLKDDAAD()
	{
		if (JKPOJMOFFMF.CMCNHIADLAM != null && !HIHHBEACCKC)
		{
			HIHHBEACCKC = true;
			JKPOJMOFFMF.CMCNHIADLAM();
		}
	}

	private static string CBKGFKIHHIM()
	{
		string text = string.Empty;
		if (string.IsNullOrEmpty(text))
		{
			text = SystemInfo.deviceUniqueIdentifier;
		}
		return text;
	}

	internal static char[] GIOFKPNHNGJ(string NJBICMFMBKE = null)
	{
		if (AOFCONBAPLL == null)
		{
			string @string = PlayerPrefs.GetString("9978e9f39c218d674463dab9dc728bd6");
			if (!string.IsNullOrEmpty(@string))
			{
				AOFCONBAPLL = CAICFBNFPHL.IEFKEGJJABB(@string);
			}
			else
			{
				AOFCONBAPLL = ObscuredString.GPLMLGBLJHH();
				string value = CAICFBNFPHL.KFDHCOPFDGP(AOFCONBAPLL);
				PlayerPrefs.SetString("9978e9f39c218d674463dab9dc728bd6", value);
				PlayerPrefs.Save();
			}
		}
		if (string.IsNullOrEmpty(NJBICMFMBKE))
		{
			return AOFCONBAPLL;
		}
		char[] array = NJBICMFMBKE.ToCharArray();
		char[] array2 = new char[AOFCONBAPLL.Length + array.Length];
		Buffer.BlockCopy(AOFCONBAPLL, 0, array2, 0, AOFCONBAPLL.Length);
		Buffer.BlockCopy(array, 0, array2, AOFCONBAPLL.Length + 1, array.Length);
		return array2;
	}

	internal static string LMAAHMOIGOK(string JPBEBBODCJJ)
	{
		char[] eHAPKEKPMOE = ObscuredString.ALMGKPDPDCH(JPBEBBODCJJ.ToCharArray(), GIOFKPNHNGJ());
		JPBEBBODCJJ = CAICFBNFPHL.KFDHCOPFDGP(eHAPKEKPMOE);
		return JPBEBBODCJJ;
	}

	internal static string OHCLAAHNMOH(string JPBEBBODCJJ, byte[] GEPLDAEHBOM, CJOCHMMKGJD EBMKGCIKJCA)
	{
		int num = GEPLDAEHBOM.Length;
		byte[] src = EIJGKECAGMI(GEPLDAEHBOM, num, GIOFKPNHNGJ(JPBEBBODCJJ));
		uint num2 = ANNNEPLPHKA.PMCBMBOPNCJ(GEPLDAEHBOM, num, 0u);
		byte[] src2 = new byte[4]
		{
			(byte)(num2 & 0xFFu),
			(byte)((num2 >> 8) & 0xFFu),
			(byte)((num2 >> 16) & 0xFFu),
			(byte)((num2 >> 24) & 0xFFu)
		};
		byte[] array = null;
		int num3;
		if (GNLIPCJFMEM != 0)
		{
			num3 = num + 11;
			uint num4 = JOAGIOLKOBC;
			array = new byte[4]
			{
				(byte)(num4 & 0xFFu),
				(byte)((num4 >> 8) & 0xFFu),
				(byte)((num4 >> 16) & 0xFFu),
				(byte)((num4 >> 24) & 0xFFu)
			};
		}
		else
		{
			num3 = num + 7;
		}
		byte[] array2 = new byte[num3];
		Buffer.BlockCopy(src, 0, array2, 0, num);
		if (array != null)
		{
			Buffer.BlockCopy(array, 0, array2, num, 4);
		}
		array2[num3 - 7] = (byte)EBMKGCIKJCA;
		array2[num3 - 6] = 3;
		array2[num3 - 5] = (byte)GNLIPCJFMEM;
		Buffer.BlockCopy(src2, 0, array2, num3 - 4, 4);
		return Convert.ToBase64String(array2);
	}

	internal static byte[] IGGIDHDNGLO(string JPBEBBODCJJ, string JOAEIGCNHDK)
	{
		byte[] array;
		try
		{
			array = Convert.FromBase64String(JOAEIGCNHDK);
		}
		catch (Exception)
		{
			HDICFAFNPPF();
			return null;
		}
		if (array.Length <= 0)
		{
			HDICFAFNPPF();
			return null;
		}
		int num = array.Length;
		byte b = array[num - 6];
		if (b != 3 && b != 2)
		{
			HDICFAFNPPF();
			return null;
		}
		CPFFLLELHCF cPFFLLELHCF = (CPFFLLELHCF)array[num - 5];
		byte[] array2 = new byte[4];
		Buffer.BlockCopy(array, num - 4, array2, 0, 4);
		uint num2 = (uint)(array2[0] | (array2[1] << 8) | (array2[2] << 16) | (array2[3] << 24));
		uint num3 = 0u;
		int num4;
		if (cPFFLLELHCF != 0)
		{
			num4 = num - 11;
			if (GNLIPCJFMEM != 0)
			{
				byte[] array3 = new byte[4];
				Buffer.BlockCopy(array, num4, array3, 0, 4);
				num3 = (uint)(array3[0] | (array3[1] << 8) | (array3[2] << 16) | (array3[3] << 24));
			}
		}
		else
		{
			num4 = num - 7;
		}
		byte[] array4 = new byte[num4];
		Buffer.BlockCopy(array, 0, array4, 0, num4);
		byte[] array5 = (AECDGJCMGHC ? PHNIODBDIBO(array4, num4, JPBEBBODCJJ + MOODPOELGFB) : EIJGKECAGMI(array4, num4, GIOFKPNHNGJ(JPBEBBODCJJ)));
		uint num5 = ANNNEPLPHKA.PMCBMBOPNCJ(array5, num4, 0u);
		if (num5 != num2)
		{
			HDICFAFNPPF();
			return null;
		}
		if (GNLIPCJFMEM == CPFFLLELHCF.OCMPNMPDACG && num3 == 0 && !JLAEAPPNLDL && !MDACPNMDPDJ)
		{
			return null;
		}
		if (num3 != 0 && !JLAEAPPNLDL)
		{
			uint num6 = JOAGIOLKOBC;
			if (num3 != num6)
			{
				KLKPLKDDAAD();
				if (!MDACPNMDPDJ)
				{
					return null;
				}
			}
		}
		return array5;
	}

	internal static CJOCHMMKGJD NLBDDAIMGKI(string EHAPKEKPMOE)
	{
		CJOCHMMKGJD result = CJOCHMMKGJD.PEDDDHJCFHL;
		byte[] array;
		try
		{
			array = Convert.FromBase64String(EHAPKEKPMOE);
		}
		catch (Exception)
		{
			return result;
		}
		if (array.Length < 7)
		{
			return result;
		}
		int num = array.Length;
		result = (CJOCHMMKGJD)array[num - 7];
		byte b = array[num - 6];
		if (b > 10)
		{
			result = CJOCHMMKGJD.PEDDDHJCFHL;
		}
		return result;
	}

	internal static string BMJEKEBHBDP<T>(string JPBEBBODCJJ, T EHAPKEKPMOE) where T : IConvertible
	{
		byte[] gEPLDAEHBOM = null;
		CJOCHMMKGJD eBMKGCIKJCA = CJOCHMMKGJD.PEDDDHJCFHL;
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == HCJDCBEABDG)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.CKFFAMAGBFB;
			gEPLDAEHBOM = BitConverter.GetBytes(EHAPKEKPMOE.ToInt32(null));
		}
		else if (typeFromHandle == LLBLLBOOJKJ)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.DGMKDJKEBPP;
			gEPLDAEHBOM = BitConverter.GetBytes(EHAPKEKPMOE.ToUInt32(null));
		}
		else if (typeFromHandle == PNOIILFPGDI)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.IEOBEKAGFOM;
			gEPLDAEHBOM = OPCHGBHHIGH.AEHGEAHFNOP(EHAPKEKPMOE.ToString());
		}
		else if (typeFromHandle == IKOOLJCHICE)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.HICNDFBOMEE;
			gEPLDAEHBOM = BitConverter.GetBytes(EHAPKEKPMOE.ToSingle(null));
		}
		else if (typeFromHandle == JCPOKLCIDEG)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.OBGAGJIJNJE;
			gEPLDAEHBOM = BitConverter.GetBytes(EHAPKEKPMOE.ToDouble(null));
		}
		else if (typeFromHandle == KAMFOLCGOIH)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.IHFMNELILIL;
			gEPLDAEHBOM = POJECKANKJD(EHAPKEKPMOE.ToDecimal(null));
		}
		else if (typeFromHandle == JPFAGOPFNGM)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.FALOGJGDGMK;
			gEPLDAEHBOM = BitConverter.GetBytes(EHAPKEKPMOE.ToInt64(null));
		}
		else if (typeFromHandle == FIGELPJLKJH)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.MNANCEBFKFC;
			gEPLDAEHBOM = BitConverter.GetBytes(EHAPKEKPMOE.ToUInt64(null));
		}
		else if (typeFromHandle == KBICFHMILFC)
		{
			eBMKGCIKJCA = CJOCHMMKGJD.IDCFHIHCPDM;
			gEPLDAEHBOM = BitConverter.GetBytes(EHAPKEKPMOE.ToBoolean(null));
		}
		return OHCLAAHNMOH(JPBEBBODCJJ, gEPLDAEHBOM, eBMKGCIKJCA);
	}

	internal static T CHHHPOHOCJG<T>(string JPBEBBODCJJ, string MBNMHOLKJPG, T DKCOCMAHPCN, string JOAEIGCNHDK = null)
	{
		if (JOAEIGCNHDK == null)
		{
			JOAEIGCNHDK = OMAKEMBDAIG(JPBEBBODCJJ, MBNMHOLKJPG);
		}
		if (JOAEIGCNHDK == "{not_found}")
		{
			return DKCOCMAHPCN;
		}
		byte[] array = IGGIDHDNGLO(JPBEBBODCJJ, JOAEIGCNHDK);
		if (array == null)
		{
			return DKCOCMAHPCN;
		}
		T result = default(T);
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == HCJDCBEABDG)
		{
			result = (T)(object)BitConverter.ToInt32(array, 0);
		}
		else if (typeFromHandle == LLBLLBOOJKJ)
		{
			result = (T)(object)BitConverter.ToUInt32(array, 0);
		}
		else if (typeFromHandle == PNOIILFPGDI)
		{
			result = (T)(object)OPCHGBHHIGH.JMHHPCDPPAF(array, 0, array.Length);
		}
		else if (typeFromHandle == IKOOLJCHICE)
		{
			result = (T)(object)BitConverter.ToSingle(array, 0);
		}
		else if (typeFromHandle == JCPOKLCIDEG)
		{
			result = (T)(object)BitConverter.ToDouble(array, 0);
		}
		else if (typeFromHandle == KAMFOLCGOIH)
		{
			result = (T)(object)HMGOACCGKBI(array);
		}
		else if (typeFromHandle == JPFAGOPFNGM)
		{
			result = (T)(object)BitConverter.ToInt64(array, 0);
		}
		else if (typeFromHandle == FIGELPJLKJH)
		{
			result = (T)(object)BitConverter.ToUInt64(array, 0);
		}
		else if (typeFromHandle == KBICFHMILFC)
		{
			result = (T)(object)BitConverter.ToBoolean(array, 0);
		}
		return result;
	}

	private static byte[] EIJGKECAGMI(byte[] BKOEGJJBGBC, int HCIOEFCFELN, char[] JPBEBBODCJJ)
	{
		int num = JPBEBBODCJJ.Length;
		byte[] array = new byte[HCIOEFCFELN];
		for (int i = 0; i < HCIOEFCFELN; i++)
		{
			array[i] = (byte)(BKOEGJJBGBC[i] ^ JPBEBBODCJJ[i % num]);
		}
		return array;
	}

	private static byte[] POJECKANKJD(decimal KJFNAACLKLO)
	{
		int[] bits = decimal.GetBits(KJFNAACLKLO);
		List<byte> list = new List<byte>();
		int[] array = bits;
		foreach (int value in array)
		{
			list.AddRange(BitConverter.GetBytes(value));
		}
		return list.ToArray();
	}

	private static decimal HMGOACCGKBI(byte[] BKOEGJJBGBC)
	{
		if (BKOEGJJBGBC.Length != 16)
		{
			throw new Exception("[ACTk] A decimal must be created from exactly 16 bytes");
		}
		int[] array = new int[4];
		for (int i = 0; i <= 15; i += 4)
		{
			array[i / 4] = BitConverter.ToInt32(BKOEGJJBGBC, i);
		}
		return new decimal(array);
	}

	private static string OMAKEMBDAIG(string JPBEBBODCJJ, string MBNMHOLKJPG)
	{
		string @string = PlayerPrefs.GetString(MBNMHOLKJPG, "{not_found}");
		if (@string == "{not_found}")
		{
			if (PlayerPrefs.HasKey(JPBEBBODCJJ))
			{
				Debug.LogWarning("[ACTk] ObscuredPrefs: Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = " + JPBEBBODCJJ + ")?");
			}
			else
			{
				APFBMIHKGAA(JPBEBBODCJJ, MMNNIMHKNAH);
				@string = PlayerPrefs.GetString(MBNMHOLKJPG, "{not_found}");
			}
		}
		return @string;
	}

	private static uint OCEMAOPDEDK(string MMKMICOONDG)
	{
		byte[] array = (AECDGJCMGHC ? OPCHGBHHIGH.AEHGEAHFNOP(MMKMICOONDG + MOODPOELGFB) : OPCHGBHHIGH.FFDJCGDMOIJ(GIOFKPNHNGJ(MMKMICOONDG)));
		return ANNNEPLPHKA.PMCBMBOPNCJ(array, array.Length, 0u);
	}

	private static Color32 ANOEMPBIHLM(uint KPCNCJLEGPE)
	{
		byte a = (byte)(KPCNCJLEGPE >> 24);
		byte r = (byte)(KPCNCJLEGPE >> 16);
		byte g = (byte)(KPCNCJLEGPE >> 8);
		byte b = (byte)(KPCNCJLEGPE >> 0);
		return new Color32(r, g, b, a);
	}

	private static bool APFBMIHKGAA(string JPBEBBODCJJ, string JPCAMKFCCLH)
	{
		string text = CAICFBNFPHL.KFDHCOPFDGP(ObscuredString.FOPCCIAILGE(JPBEBBODCJJ, JPCAMKFCCLH));
		if (!PlayerPrefs.HasKey(text))
		{
			return false;
		}
		FHHKGBNJABB(HDLFIOIPMOJ: true);
		MOODPOELGFB = JPCAMKFCCLH;
		string @string = PlayerPrefs.GetString(text);
		switch (NLBDDAIMGKI(@string))
		{
		case CJOCHMMKGJD.CKFFAMAGBFB:
		{
			int eHAPKEKPMOE15 = CHHHPOHOCJG(JPBEBBODCJJ, text, 0, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			OLEHBAMBPDE(JPBEBBODCJJ, eHAPKEKPMOE15);
			break;
		}
		case CJOCHMMKGJD.DGMKDJKEBPP:
		{
			uint eHAPKEKPMOE14 = CHHHPOHOCJG(JPBEBBODCJJ, text, 0u, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			JKKBGGENIDA(JPBEBBODCJJ, eHAPKEKPMOE14);
			break;
		}
		case CJOCHMMKGJD.IEOBEKAGFOM:
		{
			string eHAPKEKPMOE13 = CHHHPOHOCJG(JPBEBBODCJJ, text, string.Empty, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			DCGOPJDMEEG(JPBEBBODCJJ, eHAPKEKPMOE13);
			break;
		}
		case CJOCHMMKGJD.HICNDFBOMEE:
		{
			float eHAPKEKPMOE12 = CHHHPOHOCJG(JPBEBBODCJJ, text, 0f, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			FOFEDEEKMNC(JPBEBBODCJJ, eHAPKEKPMOE12);
			break;
		}
		case CJOCHMMKGJD.OBGAGJIJNJE:
		{
			double eHAPKEKPMOE11 = CHHHPOHOCJG(JPBEBBODCJJ, text, 0.0, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			COIMAHJLGIP(JPBEBBODCJJ, eHAPKEKPMOE11);
			break;
		}
		case CJOCHMMKGJD.IHFMNELILIL:
		{
			decimal eHAPKEKPMOE10 = CHHHPOHOCJG(JPBEBBODCJJ, text, 0m, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			NOEHJHHHEEA(JPBEBBODCJJ, eHAPKEKPMOE10);
			break;
		}
		case CJOCHMMKGJD.FALOGJGDGMK:
		{
			long eHAPKEKPMOE9 = CHHHPOHOCJG(JPBEBBODCJJ, text, 0L, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			CMKKKMFFFFL(JPBEBBODCJJ, eHAPKEKPMOE9);
			break;
		}
		case CJOCHMMKGJD.MNANCEBFKFC:
		{
			ulong eHAPKEKPMOE8 = CHHHPOHOCJG(JPBEBBODCJJ, text, 0uL, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			ILMHPJCACLJ(JPBEBBODCJJ, eHAPKEKPMOE8);
			break;
		}
		case CJOCHMMKGJD.IDCFHIHCPDM:
		{
			bool eHAPKEKPMOE7 = CHHHPOHOCJG(JPBEBBODCJJ, text, DKCOCMAHPCN: false, @string);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			IEPDFENGEBI(JPBEBBODCJJ, eHAPKEKPMOE7);
			break;
		}
		case CJOCHMMKGJD.GIFLGPMPEGH:
		{
			byte[] eHAPKEKPMOE6 = HJLHPBFJFML(JPBEBBODCJJ, @string, 0, 0);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			MDNGAFKCMEK(JPBEBBODCJJ, eHAPKEKPMOE6);
			break;
		}
		case CJOCHMMKGJD.OMFDCJOJJJF:
		{
			Vector2 eHAPKEKPMOE5 = NNHFJDAEAAK(JPBEBBODCJJ, @string, Vector2.zero);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			FJIDNFIONIH(JPBEBBODCJJ, eHAPKEKPMOE5);
			break;
		}
		case CJOCHMMKGJD.CEHADPOGPOI:
		{
			Vector3 eHAPKEKPMOE4 = COMEIMOIHAM(JPBEBBODCJJ, @string, Vector3.zero);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			PCLHLBLCNCP(JPBEBBODCJJ, eHAPKEKPMOE4);
			break;
		}
		case CJOCHMMKGJD.ADLHMFOLMBI:
		{
			Quaternion eHAPKEKPMOE3 = ANHDELDBAMN(JPBEBBODCJJ, @string, Quaternion.identity);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			NBBNGHFJGML(JPBEBBODCJJ, eHAPKEKPMOE3);
			break;
		}
		case CJOCHMMKGJD.KEMNJHJMECE:
		{
			uint kPCNCJLEGPE = CHHHPOHOCJG(JPBEBBODCJJ, text, 16777216u, @string);
			Color32 eHAPKEKPMOE2 = ANOEMPBIHLM(kPCNCJLEGPE);
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			COGIBGGPEGJ(JPBEBBODCJJ, eHAPKEKPMOE2);
			break;
		}
		case CJOCHMMKGJD.LACLEAPHNGF:
		{
			Rect eHAPKEKPMOE = KDHKFBLLPAC(JPBEBBODCJJ, @string, new Rect(0f, 0f, 0f, 0f));
			FHHKGBNJABB(HDLFIOIPMOJ: false);
			LBKPDHNIEGK(JPBEBBODCJJ, eHAPKEKPMOE);
			break;
		}
		default:
			Debug.LogWarning("[ACTk] ObscuredPrefs: Couldn't migrate " + JPBEBBODCJJ + " key from ACTk v1 prefs since its type is unknown!");
			return false;
		}
		Debug.Log("[ACTk] ObscuredPrefs: Obscured pref " + JPBEBBODCJJ + " successfully migrated to the newer format.");
		MOODPOELGFB = null;
		PlayerPrefs.DeleteKey(text);
		return true;
	}

	private static void FHHKGBNJABB(bool HDLFIOIPMOJ)
	{
		AECDGJCMGHC = HDLFIOIPMOJ;
		FEIJJGEODAA = 0u;
	}

	private static byte[] PHNIODBDIBO(byte[] BKOEGJJBGBC, int HCIOEFCFELN, string JPBEBBODCJJ)
	{
		int length = JPBEBBODCJJ.Length;
		byte[] array = new byte[HCIOEFCFELN];
		for (int i = 0; i < HCIOEFCFELN; i++)
		{
			array[i] = (byte)(BKOEGJJBGBC[i] ^ JPBEBBODCJJ[i % length]);
		}
		return array;
	}
}
