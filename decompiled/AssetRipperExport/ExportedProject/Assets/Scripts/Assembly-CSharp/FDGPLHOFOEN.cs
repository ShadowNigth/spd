using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using ProtoBuf;
using UnityEngine;
using UnityEngine.AI;

[ProtoContract]
public class FDGPLHOFOEN : KKJBDENNKGF
{
	private sealed class ENHFEJADMDB
	{
		internal IAPJEBKJEHC AEMBPMJMOAB;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC LCBKHLLPIGM)
		{
			return LCBKHLLPIGM.KOPFHECCACK == AEMBPMJMOAB.KOPFHECCACK && ObscuredBool.FNIPJFGEFFD(LCBKHLLPIGM.FEAMJAKLLLO);
		}
	}

	private sealed class ALPCBKANAFC
	{
		internal int ALEOHHMPCOC;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO) && AEMBPMJMOAB.FBGNKPPMENN == ALEOHHMPCOC && !(AEMBPMJMOAB is JOCAFHIONFA);
		}
	}

	private sealed class OHPBEMABIEM
	{
		internal int KOPFHECCACK;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.KOPFHECCACK == KOPFHECCACK && ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO);
		}
	}

	private sealed class ACBAOBPJJDH
	{
		internal IAPJEBKJEHC GIPIKICBHKA;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.KOPFHECCACK == GIPIKICBHKA.KOPFHECCACK && ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.JJJGDHGBPHJ);
		}

		internal bool PMBKBKJIIPO(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.FBGNKPPMENN == GIPIKICBHKA.FBGNKPPMENN && ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.JJJGDHGBPHJ);
		}
	}

	private sealed class KIEBDFLJCNB
	{
		internal int FAGMOBEKJND;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.KOPFHECCACK == FAGMOBEKJND && ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO);
		}
	}

	private sealed class KKGGFENDKKB
	{
		internal EJDKALEIBBG OGOEFNKMIPJ;

		internal FDGPLHOFOEN KPHCHDHEKGH;

		internal float BEKJDJFLJJC(EJDKALEIBBG AEMBPMJMOAB)
		{
			return (AEMBPMJMOAB.ELGIKGAIIOD - KPHCHDHEKGH.ELGIKGAIIOD).magnitude;
		}

		internal bool PMBKBKJIIPO(EJDKALEIBBG AEMBPMJMOAB)
		{
			return ((AEMBPMJMOAB.ELGIKGAIIOD - KPHCHDHEKGH.ELGIKGAIIOD).magnitude < 3f && KPHCHDHEKGH.CPINPFLEJFF(AEMBPMJMOAB.CMPKOEMBHDO)) || !KPHCHDHEKGH.KAMAMHFJDGG;
		}

		internal bool MBNLIBIAFEF(IAPJEBKJEHC DCNNOFJHEMD)
		{
			return DCNNOFJHEMD.JJHIFNAJIBK == OGOEFNKMIPJ.JJHIFNAJIBK;
		}

		internal bool BDCIKCEBMFB(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO) && OGOEFNKMIPJ.PLDMNFCBFDD > AEMBPMJMOAB.LMJDOOEODJK.FOEACCEIBME(OGOEFNKMIPJ.JJHIFNAJIBK);
		}
	}

	private sealed class HJDGKOKPOBP
	{
		internal string JJHIFNAJIBK;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC DCNNOFJHEMD)
		{
			return DCNNOFJHEMD.JJHIFNAJIBK == JJHIFNAJIBK && ObscuredBool.FNIPJFGEFFD(DCNNOFJHEMD.FEAMJAKLLLO);
		}
	}

	private sealed class PGFLBEPECEM
	{
		internal int FAGMOBEKJND;

		internal FDGPLHOFOEN KPHCHDHEKGH;

		internal bool BEKJDJFLJJC()
		{
			return ObscuredBool.FNIPJFGEFFD(KPHCHDHEKGH.JEFKKCFOHCE);
		}

		internal void PMBKBKJIIPO()
		{
			KPHCHDHEKGH.DKPJJKBJJOA(FAGMOBEKJND);
		}
	}

	private sealed class NANDGJBPJIA
	{
		internal Vector3 ELGIKGAIIOD;

		internal FDGPLHOFOEN KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			FOGIOGKLNIP.PIOANBBCFFP.IAKGALFPPJL(ELGIKGAIIOD, 1000f, true);
			KPHCHDHEKGH.JMJLEDGJIJK("BigExplode", "Particles/", true, null, null, ELGIKGAIIOD, Quaternion.identity);
		}
	}

	private sealed class BCDAEBOFDPG
	{
		internal int FAGMOBEKJND;

		internal FDGPLHOFOEN KPHCHDHEKGH;

		internal bool BEKJDJFLJJC(WeaponManager.WeaponSpawn LCBKHLLPIGM)
		{
			return LCBKHLLPIGM.WeaponAliasName == KPHCHDHEKGH.OKDFHJJNFCC[FAGMOBEKJND].LKECMBJJLPJ;
		}

		internal bool PMBKBKJIIPO(WeaponManager.WeaponSpawn LCBKHLLPIGM)
		{
			return LCBKHLLPIGM.WeaponAliasName == KPHCHDHEKGH.OKDFHJJNFCC[FAGMOBEKJND].LKECMBJJLPJ;
		}
	}

	public bool GEGAMONDEKC;

	public ObscuredBool AILHLEALEAI;

	private ObscuredBool PFLJOBDABPJ;

	private ObscuredBool DBDNFADIAPB;

	private ObscuredBool OPKDMODBFGA;

	internal ObscuredBool NEJKKMBEEIO;

	internal ObscuredBool GNMACPNCAFL;

	public ObscuredInt DBHBGABEKJH = ObscuredInt.FNIPJFGEFFD(-90);

	public ObscuredInt NBEMLIHDJLC = ObscuredInt.FNIPJFGEFFD(90);

	public int GOFPGIAIDNI;

	public ObscuredInt GEJCCBAOGAE = ObscuredInt.FNIPJFGEFFD(2);

	private int ICKMLJNOODA;

	private int IHMAHACABAJ;

	private int[] ECGNIEAODDJ = new int[20];

	public ObscuredFloat NMEBLDFOEMA = ObscuredFloat.FNIPJFGEFFD(5f);

	public ObscuredFloat KEOPJIFEMIC = ObscuredFloat.FNIPJFGEFFD(0.3f);

	public ObscuredFloat JOCNGKFAIHM = ObscuredFloat.FNIPJFGEFFD(0.62f);

	public ObscuredFloat NINJLPOLFEF = ObscuredFloat.FNIPJFGEFFD(0.9f);

	public ObscuredFloat IEPHAKCKAPP = ObscuredFloat.FNIPJFGEFFD(0.2f);

	public ObscuredFloat ONGOOKDMGCF;

	public ObscuredFloat EGBJOABGKPM = ObscuredFloat.FNIPJFGEFFD(-1000f);

	public ObscuredFloat IJNKDOJDHPP;

	private ObscuredFloat CKLJKFKKHEE;

	private ObscuredFloat GCDGMACGMKE;

	private ObscuredFloat OCJOMIDJHCJ = ObscuredFloat.FNIPJFGEFFD(1f);

	private float FEABHFMDFPE = float.MaxValue;

	private ObscuredFloat EMEDPOENPDA;

	public bool LJEHNGIGHEM;

	private const string OPGKHGAGNCD = "crouch_run";

	private const string DPFPDBOOGHP = "idle";

	private const string AGOPHLDNFPO = "crouch";

	private const string NDGJKBCPANC = "run";

	private const string EJHLKBLOFLI = "jump";

	private const string IMIAKBKJMMB = "playerCrouch";

	public string[] DDMENOBEPPC;

	public string[] EJCKAFPHCAK;

	private static string[] AIOGABFEOJB;

	private static string[] KKNIEIOGFAN;

	private static string[] DDODKBHGBFG;

	public GameObject DJOIFOBFCFN;

	public GameObject CFIEHJOHCAN;

	public Renderer IKHBOFEIDBE;

	public Renderer FNHDEBGNLNB;

	public LineRenderer FOBJLKMABPM;

	public Vector3 FHFGMEFLCAF;

	private Vector3 BJGFADNPLFG;

	private Vector3 MMBCBFBOPEP;

	private Vector3 MCDKIHGPCAL;

	private Vector3 EFGOFOCKHIB;

	public Transform LDFLDCLLEPN;

	public Transform HCALMEMBBJN;

	public Renderer NKHHFJLNLGG;

	public Light NIMEIBAGPMO;

	public Transform AOOMBPEJAOH;

	public Transform HGAMIBJFEOL;

	public Transform GJPJKPJOBGJ;

	public IAPJEBKJEHC[] OKDFHJJNFCC;

	public IAPJEBKJEHC HINDBLMPIOP;

	public OLILBNAJMLF AKIMNDMGFMN;

	public FFGDOHNIMON FFGDOHNIMON;

	public KCNCDAJBGFM KGKGIFJLPPD;

	public NGBCDAIIEFP GMJMMHIMOKL;

	public NGBCDAIIEFP PBDHPKFDHEO;

	public KICMMHDCNIK NKHJDNAHMPD;

	public MELEBCPOMHB HCLAICPNOCN;

	public JOCAFHIONFA DLHLKPMGHOO;

	public JOCAFHIONFA COHNIKDEGOC;

	public JOCAFHIONFA PPFBJBHKPPN;

	public FACHOPPILGM KAEKKAMFDBO;

	public Behaviour[] ONLNEOGEDPC;

	public Light GJMMADBFMCP;

	public Material[] EEDEIKENCIB;

	private KKJBDENNKGF EJHMDAMJHAF;

	internal HashSet<int> NCMECMGLFOI = new HashSet<int>();

	private float EONGLFIGPOG;

	public bool DLDFNGIJIMH = true;

	public bool PEEIEMGAJOA = true;

	internal float FKBCKBMJOKH;

	[CompilerGenerated]
	private static Func<Transform, bool> ACJNADIPOMC;

	[CompilerGenerated]
	private static Func<Transform, bool> HJJBAKLDAEB;

	[CompilerGenerated]
	private static Func<Transform, bool> MPCENNEMFPB;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, IEnumerable<string>> AGJHOJDNCOI;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, IEnumerable<string>> GOKLDIBAPEA;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, string> FDEPMKHNIID;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, string> JEJGIANFAJE;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, string> CAGBNPPEAFL;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> IOIHBOPJMHO;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> MIHBLNGEMJB;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, bool> MBDEKCIDOHG;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, bool> INPFPBONNKM;

	[CompilerGenerated]
	private static Func<IAPJEBKJEHC, bool> DCNJCLEOEHG;

	[CompilerGenerated]
	private static Predicate<IAPJEBKJEHC> AFIEDPFMAGJ;

	public string[] LAJKNGCOABD
	{
		get
		{
			return DDMENOBEPPC;
		}
	}

	public string[] JBOAGLNOHLL
	{
		get
		{
			return EJCKAFPHCAK;
		}
	}

	public JOCAFHIONFA[] ECEFCBMJPMD
	{
		get
		{
			return new JOCAFHIONFA[3] { DLHLKPMGHOO, COHNIKDEGOC, PPFBJBHKPPN };
		}
	}

	public ObscuredBool FEONAHKMPNE
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD((OFKMCBJGALN != null && Time.time - ObscuredFloat.FNIPJFGEFFD(BHHEOGIMOLJ) >= 0.4f && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.MKEIKODECEC)) ? (OFKMCBJGALN.velocity.magnitude < 4f || Time.time - ObscuredFloat.FNIPJFGEFFD(FDKEHBJBNCJ) > 0.04f) : (OFKMCBJGALN.velocity.magnitude < 4f && Time.time - ObscuredFloat.FNIPJFGEFFD(FDKEHBJBNCJ) < 0.04f));
		}
	}

	public override ObscuredBool MGJPMGGABLN
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(ObscuredBool.FNIPJFGEFFD(PHLKCKKDLFF) && ObscuredBool.FNIPJFGEFFD(NPCDJBMMJKA));
		}
	}

	public ObscuredBool NPCDJBMMJKA
	{
		get
		{
			bool cIHFBOLAMCO = JEPMMPCNEHO.CIHFBOLAMCO;
			return ObscuredBool.FNIPJFGEFFD(cIHFBOLAMCO);
		}
	}

	public event Action<EJDKALEIBBG> EMKHMKMJNFN;

	public event Action<EJDKALEIBBG> JGMODDAIJIP;

	public override void Awake()
	{
		base.Awake();
		JEFKKCFOHCE = ObscuredBool.FNIPJFGEFFD(false);
		for (int i = 0; i < OKDFHJJNFCC.Length; i++)
		{
			IAPJEBKJEHC iAPJEBKJEHC = OKDFHJJNFCC[i];
			iAPJEBKJEHC.FBGNKPPMENN = i;
			iAPJEBKJEHC.NJEPMOIDJKH = this;
		}
		JEPMMPCNEHO = OKDFHJJNFCC[0];
		if (FOGIOGKLNIP.DGMBIMMABNO)
		{
			UnityEngine.Object.Destroy(GetComponent<AudioReverbFilter>());
		}
	}

	public override void Start()
	{
		MEDGPMAAALA();
		base.Start();
		if (KAMAMHFJDGG)
		{
			base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD((int)ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.OHGEMABOIBK));
			base.OJMCPNOELPE = ObscuredInt.FNIPJFGEFFD((int)ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.NBKGCKPKBOC));
			if (ObscuredBool.FNIPJFGEFFD(base.NBFGNGGJDNB))
			{
				base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD((int)((float)ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.EKEMIEEFILP) * (1f + (float)FOGIOGKLNIP.PIOANBBCFFP.LDAKBEMPLEB.Count / 3f)));
			}
			if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
			{
				base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD((int)ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.COGEDCIBHMA));
			}
			NCHOPAEKPBK(DFJGLGGOKKN, ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA));
			if (FOGIOGKLNIP.PIOANBBCFFP.BBBCMOHPEIH != null && FOGIOGKLNIP.PIOANBBCFFP.BBBCMOHPEIH.Armour > 0)
			{
				NCHOPAEKPBK(IGJOGMEONLP, FOGIOGKLNIP.PIOANBBCFFP.BBBCMOHPEIH.Armour, true);
			}
			if (ObscuredBool.FNIPJFGEFFD(MIAIFPBNBDJ))
			{
				NCHOPAEKPBK(IGJOGMEONLP, ObscuredInt.FNIPJFGEFFD(base.OJMCPNOELPE), ObscuredBool.FNIPJFGEFFD(MIAIFPBNBDJ));
			}
		}
		HDOGJKGOEIG(MMFMIIEFEEG, 0.02f);
		BIHOCPAKHNF("player Start ");
		if (FOGIOGKLNIP.LPLJMLGKCLK.FJPCBLEEIOH)
		{
			CFIEHJOHCAN.GetComponent<AudioSource>().enabled = base.KEMLHMOIFIM;
		}
		JDFKPOMKMNJ.IPBKDPKONHH(() => BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.Spectators, delegate
		{
			bool flag = ObscuredInt.FNIPJFGEFFD(BJDCCKHBENA.JCMCPIPHDHB) >= 500 && ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK);
			if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK) && base.NENPALDENAL)
			{
				IAPJEBKJEHC[] oKDFHJJNFCC = OKDFHJJNFCC;
				foreach (IAPJEBKJEHC iAPJEBKJEHC in oKDFHJJNFCC)
				{
					iAPJEBKJEHC.LMJDOOEODJK.NKOHBFHAELH(iAPJEBKJEHC.NNBDEKBINFP, iAPJEBKJEHC.LMJDOOEODJK.DJEALLIOJEO(iAPJEBKJEHC.NNBDEKBINFP, true), true);
					iAPJEBKJEHC.CNMKGNNGPDD = iAPJEBKJEHC.ABHFBECBPBA;
				}
			}
			if (FOGIOGKLNIP.NMGDHKIKCED == this)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH = this;
			}
			KKNBDBLKNAN();
			if (KAMAMHFJDGG || (ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK) && base.NENPALDENAL && !BJDCCKHBENA.ALHNDNFFBIB))
			{
				if ((FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG != null && !FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.DisableWeapons) || FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG == null)
				{
					if (flag)
					{
						NLDNFOCDHMN(OKDFHJJNFCC.WhereF((IAPJEBKJEHC DCNNOFJHEMD) => DCNNOFJHEMD.KOPFHECCACK == 2 && ((DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.AEBKICLHBHG && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists) || (DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.HJFDEGMFGDP && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) || DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.DMELFHOKGBG)).Random().FBGNKPPMENN);
						NLDNFOCDHMN(OKDFHJJNFCC.WhereF((IAPJEBKJEHC DCNNOFJHEMD) => DCNNOFJHEMD.KOPFHECCACK == 1 && ((DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.AEBKICLHBHG && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists) || (DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.HJFDEGMFGDP && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) || DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.DMELFHOKGBG)).Random().FBGNKPPMENN);
					}
					if (!flag)
					{
						if (BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists)
						{
							if (!ObscuredBool.FNIPJFGEFFD(NKHJDNAHMPD.HPFPFCNOKAM))
							{
								NKHJDNAHMPD.LMJDOOEODJK.NKOHBFHAELH(NKHJDNAHMPD.NNBDEKBINFP, NKHJDNAHMPD.LMJDOOEODJK.DJEALLIOJEO(NKHJDNAHMPD.NNBDEKBINFP, true), true);
								NKHJDNAHMPD.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
								NKHJDNAHMPD.CNMKGNNGPDD = NKHJDNAHMPD.ABHFBECBPBA;
								LKLAEDIGMIB(NKHJDNAHMPD.FBGNKPPMENN);
								NKHJDNAHMPD.CNMKGNNGPDD = NKHJDNAHMPD.ABHFBECBPBA;
							}
							else
							{
								LIFLOGLLGIG();
							}
						}
						if (BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists)
						{
							if (!ObscuredBool.FNIPJFGEFFD(HCLAICPNOCN.HPFPFCNOKAM))
							{
								HCLAICPNOCN.LMJDOOEODJK.NKOHBFHAELH(HCLAICPNOCN.NNBDEKBINFP, HCLAICPNOCN.LMJDOOEODJK.DJEALLIOJEO(HCLAICPNOCN.NNBDEKBINFP, true), true);
								HCLAICPNOCN.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
								HCLAICPNOCN.CNMKGNNGPDD = HCLAICPNOCN.ABHFBECBPBA;
								LKLAEDIGMIB(HCLAICPNOCN.FBGNKPPMENN);
								HCLAICPNOCN.CNMKGNNGPDD = HCLAICPNOCN.ABHFBECBPBA;
							}
							else
							{
								LIFLOGLLGIG();
							}
						}
					}
				}
				else if (FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG != null && FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.DisableWeapons)
				{
					BCDAEBOFDPG bCDAEBOFDPG = new BCDAEBOFDPG
					{
						KPHCHDHEKGH = this,
						FAGMOBEKJND = 0
					};
					while (bCDAEBOFDPG.FAGMOBEKJND < OKDFHJJNFCC.Length)
					{
						if (FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.SpawnWeapons.AnyF(bCDAEBOFDPG.BEKJDJFLJJC))
						{
							WeaponManager.WeaponSpawn weaponSpawn = FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.SpawnWeapons.WhereF(bCDAEBOFDPG.PMBKBKJIIPO).FirstOrDefaultF();
							if (FOGIOGKLNIP.LMMFHEODOPM.FCFBGBPEPOL)
							{
								Debug.LogError(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].LKECMBJJLPJ);
							}
							if (ObscuredBool.FNIPJFGEFFD(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].HPFPFCNOKAM))
							{
								OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].HPFPFCNOKAM = ObscuredBool.FNIPJFGEFFD(false);
							}
							OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(weaponSpawn.Ammo);
							OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].LMJDOOEODJK.NKOHBFHAELH(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].NNBDEKBINFP, weaponSpawn.Clips, true);
							OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
							if (!ObscuredBool.FNIPJFGEFFD(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].HPFPFCNOKAM))
							{
								LKLAEDIGMIB(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].FBGNKPPMENN);
							}
						}
						bCDAEBOFDPG.FAGMOBEKJND++;
					}
				}
			}
			if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA) && FOGIOGKLNIP.NGFDFPGNDCJ.NMJOJEDEJBO != null)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play(JEPMMPCNEHO.DFMAGFMJGDH.name);
			}
			if (FOGIOGKLNIP.NMGDHKIKCED == this && FOGIOGKLNIP.LBJBBGEDGJF.CCLDHNLJLAC && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.DIMHBBEFMDK))
			{
				FOGIOGKLNIP.LBJBBGEDGJF.NCOPODKFALG();
			}
		});
		HINDBLMPIOP = NKHJDNAHMPD;
		if (FOGIOGKLNIP.NMGDHKIKCED == this)
		{
			FOGIOGKLNIP.DDGKNLHJEFD = new Vector3(0f, UnityEngine.Random.Range(-20, 20), 0f);
		}
	}

	public void NLDNFOCDHMN(int ALEOHHMPCOC)
	{
		if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
		{
			NCHOPAEKPBK(GOFMJLCKMDK, ALEOHHMPCOC);
		}
	}

	public void AJKIMHOICLI()
	{
		IMAAMLFMKOC();
		BJDCCKHBENA.FBBDIENBDGM(-100);
		NCHOPAEKPBK(MNAPCJGKLGE);
	}

	[RPC]
	public void GOFMJLCKMDK(int FBGNKPPMENN)
	{
		if (!ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
		{
			return;
		}
		ENHFEJADMDB eNHFEJADMDB = new ENHFEJADMDB();
		eNHFEJADMDB.AEMBPMJMOAB = OKDFHJJNFCC[FBGNKPPMENN];
		if ((ObscuredInt.FNIPJFGEFFD(BJDCCKHBENA.JCMCPIPHDHB) >= ObscuredInt.FNIPJFGEFFD(eNHFEJADMDB.AEMBPMJMOAB.BBCLFKDCOAJ) && KAMAMHFJDGG) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE))
		{
			if (!CPINPFLEJFF(eNHFEJADMDB.AEMBPMJMOAB.KOPFHECCACK) && !(eNHFEJADMDB.AEMBPMJMOAB is JOCAFHIONFA))
			{
				IAPJEBKJEHC iAPJEBKJEHC = OKDFHJJNFCC.FirstOrDefault(eNHFEJADMDB.BEKJDJFLJJC);
				iAPJEBKJEHC.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(false);
			}
			eNHFEJADMDB.AEMBPMJMOAB.CNMKGNNGPDD = eNHFEJADMDB.AEMBPMJMOAB.ABHFBECBPBA;
			if (!(eNHFEJADMDB.AEMBPMJMOAB is JOCAFHIONFA))
			{
				eNHFEJADMDB.AEMBPMJMOAB.LMJDOOEODJK.COAEAALHHGL(eNHFEJADMDB.AEMBPMJMOAB.JJHIFNAJIBK, eNHFEJADMDB.AEMBPMJMOAB.LMJDOOEODJK.FOEACCEIBME(eNHFEJADMDB.AEMBPMJMOAB.JJHIFNAJIBK, true), true);
			}
			eNHFEJADMDB.AEMBPMJMOAB.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
			eNHFEJADMDB.AEMBPMJMOAB.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(true);
			if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE))
			{
				BJDCCKHBENA.FBBDIENBDGM(-ObscuredInt.FNIPJFGEFFD(eNHFEJADMDB.AEMBPMJMOAB.BBCLFKDCOAJ));
			}
			LKLAEDIGMIB(eNHFEJADMDB.AEMBPMJMOAB.FBGNKPPMENN);
			NCHOPAEKPBK(MNAPCJGKLGE);
		}
	}

	public override void Reset()
	{
		IAPJEBKJEHC[] oKDFHJJNFCC = OKDFHJJNFCC;
		foreach (IAPJEBKJEHC iAPJEBKJEHC in oKDFHJJNFCC)
		{
			iAPJEBKJEHC.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(false);
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.DIMHBBEFMDK))
		{
			IAPJEBKJEHC[] oKDFHJJNFCC2 = OKDFHJJNFCC;
			foreach (IAPJEBKJEHC iAPJEBKJEHC2 in oKDFHJJNFCC2)
			{
				iAPJEBKJEHC2.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(false);
			}
			if (BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists && !ObscuredBool.FNIPJFGEFFD(NKHJDNAHMPD.HPFPFCNOKAM))
			{
				NKHJDNAHMPD.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
			}
			if (BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists && !ObscuredBool.FNIPJFGEFFD(HCLAICPNOCN.HPFPFCNOKAM))
			{
				HCLAICPNOCN.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
			}
			FFGDOHNIMON.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
		}
		if (this == FOGIOGKLNIP.NMGDHKIKCED)
		{
			if (!ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
			{
				AKIMNDMGFMN.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(false);
			}
			IMAAMLFMKOC(true);
			if ((bool)(JEPMMPCNEHO as FACHOPPILGM))
			{
				(JEPMMPCNEHO as FACHOPPILGM).StopAllCoroutines();
				(JEPMMPCNEHO as FACHOPPILGM).GMLKEKBDLAJ = false;
			}
		}
		NEJKKMBEEIO = ObscuredBool.FNIPJFGEFFD(false);
		if (BJDCCKHBENA.KAMAMHFJDGG)
		{
			base.MDBAFPKAKKK = !FOGIOGKLNIP.PIOANBBCFFP.DALNPKPJAJF;
			FOGIOGKLNIP.CIEBMCOJGCC.DLAFHHGPHFO.SetActive(false);
		}
		base.Reset();
	}

	public override void HIBHJDCMMAJ()
	{
		for (int i = 0; i < OKDFHJJNFCC.Length; i++)
		{
			IAPJEBKJEHC iAPJEBKJEHC = OKDFHJJNFCC[i];
			iAPJEBKJEHC.FBGNKPPMENN = i;
			iAPJEBKJEHC.NJEPMOIDJKH = this;
			iAPJEBKJEHC.HAPPCOBHMHM();
		}
	}

	public override void MEDGPMAAALA()
	{
		JEFKKCFOHCE = ObscuredBool.FNIPJFGEFFD(true);
		int num = ((BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.Terrorists) ? JBOAGLNOHLL.Length : LAJKNGCOABD.Length);
		BJDCCKHBENA.EPDKDICMOHH = ((!ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK)) ? Mathf.Min(num - 1, BJDCCKHBENA.EPDKDICMOHH) : UnityEngine.Random.Range(0, num - 1));
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK) && !FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			BJDCCKHBENA.EPDKDICMOHH = base.MPGJFDKDCPB % num;
		}
		string text = "Player_" + ((BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) ? LAJKNGCOABD : JBOAGLNOHLL)[BJDCCKHBENA.EPDKDICMOHH];
		BGJOMCIIFAK = JMJLEDGJIJK(text, "skins/", false, null, null, base.ELGIKGAIIOD, Quaternion.identity, true, true).GetComponent<FOGIOGKLNIP>();
		Vector3 position = BGJOMCIIFAK.EHOEFMPLIFB.position;
		if (BGJOMCIIFAK.AIAJBBMCIBK != null)
		{
			BGJOMCIIFAK.AIAJBBMCIBK.enabled = true;
		}
		BGJOMCIIFAK.EHOEFMPLIFB.parent = EHOEFMPLIFB;
		BGJOMCIIFAK.EHOEFMPLIFB.position = base.ELGIKGAIIOD + position;
		BGJOMCIIFAK.EHOEFMPLIFB.rotation = Quaternion.identity;
		OKNKADHMJAJ = ((base.FDAGHIAOOJF != NHBBNDBBHJH.PBFOOLLHFKM) ? BGJOMCIIFAK.EHOEFMPLIFB.GetTransforms().First((Transform AEMBPMJMOAB) => AEMBPMJMOAB.tag == "Head") : BGJOMCIIFAK.EHOEFMPLIFB.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Spine2/Bip01 Spine3/Bip01 Neck/Bip01 Head"));
		AOOMBPEJAOH = ((base.FDAGHIAOOJF != NHBBNDBBHJH.PBFOOLLHFKM) ? BGJOMCIIFAK.EHOEFMPLIFB.GetTransforms().First((Transform AEMBPMJMOAB) => AEMBPMJMOAB.tag == "Spine") : BGJOMCIIFAK.EHOEFMPLIFB.Find("Bip01/Bip01 Pelvis/Bip01 Spine"));
		LDFLDCLLEPN = ((base.FDAGHIAOOJF != NHBBNDBBHJH.PBFOOLLHFKM) ? BGJOMCIIFAK.EHOEFMPLIFB.GetTransforms().First((Transform AEMBPMJMOAB) => AEMBPMJMOAB.tag == "GunPlaceHolder") : BGJOMCIIFAK.EHOEFMPLIFB.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Spine2/Bip01 Spine3/Bip01 Neck/Bip01 R Clavicle/Bip01 R UpperArm/Bip01 R Forearm/Bip01 R Hand/guns"));
		NPDKFEEDEGM(text, "Players/", true, BGJOMCIIFAK.EHOEFMPLIFB);
		base.MEDGPMAAALA();
	}

	private void KKNBDBLKNAN()
	{
		if (!ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			return;
		}
		AnimationState animationState = base.GCNMEJLGIOE["crouch"];
		float speed = 0.5f;
		base.GCNMEJLGIOE["idle"].speed = speed;
		animationState.speed = speed;
		AnimationState animationState2 = base.GCNMEJLGIOE["crouch_run"];
		WrapMode wrapMode = WrapMode.Loop;
		base.GCNMEJLGIOE["run"].wrapMode = wrapMode;
		wrapMode = wrapMode;
		base.GCNMEJLGIOE["idle"].wrapMode = wrapMode;
		animationState2.wrapMode = wrapMode;
		base.GCNMEJLGIOE["jump"].wrapMode = WrapMode.Once;
		base.GCNMEJLGIOE["jump"].layer = 1;
		base.GCNMEJLGIOE[DCCGFOCHEIH].layer = 5;
		base.GCNMEJLGIOE[DCCGFOCHEIH].wrapMode = WrapMode.ClampForever;
		if (AIOGABFEOJB == null)
		{
			AIOGABFEOJB = OKDFHJJNFCC.SelectMany((IAPJEBKJEHC AEMBPMJMOAB) => AEMBPMJMOAB.AIOGABFEOJB).Union(OKDFHJJNFCC.SelectMany((IAPJEBKJEHC AEMBPMJMOAB) => AEMBPMJMOAB.BFFNBGNAEMI)).ToArray();
		}
		string[] aIOGABFEOJB = AIOGABFEOJB;
		foreach (string text in aIOGABFEOJB)
		{
			AnimationState animationState3 = GCNMEJLGIOE[text];
			animationState3.AddMixingTransform(AOOMBPEJAOH);
			animationState3.layer = 2;
			animationState3.wrapMode = WrapMode.Loop;
		}
		if (KKNIEIOGFAN == null)
		{
			KKNIEIOGFAN = OKDFHJJNFCC.Select((IAPJEBKJEHC AEMBPMJMOAB) => AEMBPMJMOAB.AIOGABFEOJB[5]).Union(OKDFHJJNFCC.Select((IAPJEBKJEHC AEMBPMJMOAB) => AEMBPMJMOAB.BFFNBGNAEMI[5])).ToArray();
		}
		string[] kKNIEIOGFAN = KKNIEIOGFAN;
		foreach (string text2 in kKNIEIOGFAN)
		{
			GCNMEJLGIOE[text2].layer = 1;
		}
		if (DDODKBHGBFG == null)
		{
			DDODKBHGBFG = OKDFHJJNFCC.Select((IAPJEBKJEHC AEMBPMJMOAB) => AEMBPMJMOAB.MEGEODGDDAH + "reload").Distinct().ToArray();
		}
		string[] dDODKBHGBFG = DDODKBHGBFG;
		foreach (string text3 in dDODKBHGBFG)
		{
			if (GCNMEJLGIOE[text3] != null)
			{
				GCNMEJLGIOE[text3].layer = 3;
				GCNMEJLGIOE[text3].AddMixingTransform(AOOMBPEJAOH);
				GCNMEJLGIOE[text3].wrapMode = WrapMode.Once;
			}
		}
	}

	public override void Update()
	{
		base.Update();
		if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA))
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.HHDMNFKCEML.localRotation = Quaternion.Slerp(FOGIOGKLNIP.NGFDFPGNDCJ.HHDMNFKCEML.localRotation, Quaternion.identity, Time.deltaTime * 5f / 4f);
		}
		if (base.IAALHLCLAOD)
		{
			if (ObscuredBool.FNIPJFGEFFD(CGCEAEFHDIF))
			{
				KNMNMADEGHG();
			}
			if (ObscuredBool.FNIPJFGEFFD(CGCEAEFHDIF))
			{
				NJKKHBBKMJO();
			}
			PPBLJMDIFKB();
			NHOGOKJGLJD();
		}
		if (KAMAMHFJDGG)
		{
			if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
			{
				if (base.KEMLHMOIFIM)
				{
					PMFOJPCOKGC();
				}
				else
				{
					CMGGAOANIIP();
				}
			}
			else if (!FOGIOGKLNIP.PIOANBBCFFP.DALNPKPJAJF && !FOGIOGKLNIP.CIEBMCOJGCC.DLAFHHGPHFO.activeSelf && !FOGIOGKLNIP.PIOANBBCFFP.IGJKLHOGPHL)
			{
				MFPLNEMIFMJ();
				CLAPCCOJNKN();
			}
		}
		DGHNJLMEHLC();
		if (KAMAMHFJDGG || ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK))
		{
			DJJMBCGHPCP();
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
		PMKOJMNEFOF = ObscuredBool.FNIPJFGEFFD(false);
	}

	public void MMFMIIEFEEG()
	{
		Renderer nKHHFJLNLGG = NKHHFJLNLGG;
		bool flag = (float)Time.renderedFrameCount - FKBCKBMJOKH < 3f;
		NIMEIBAGPMO.enabled = flag;
		nKHHFJLNLGG.enabled = flag;
		if (CBOOLAKHHHG.magnitude > 0f)
		{
			Vector3 vector = ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IDHNLOELEDI) || ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK)) ? FOGIOGKLNIP.KDCGBDNNCHM(MPCGHDNMNKN.KHGAOLHJCMO * CBOOLAKHHHG) : (MPCGHDNMNKN.KHGAOLHJCMO * CBOOLAKHHHG));
			KPKNIABCJOC += vector * (((!(Time.time - ObscuredFloat.FNIPJFGEFFD(BHHEOGIMOLJ) < 0.4f) || !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.ANPPCHMLKNF) || ObscuredBool.FNIPJFGEFFD(base.NBFGNGGJDNB)) && !ObscuredBool.FNIPJFGEFFD(EFCLACBNGCL)) ? ((GEGAMONDEKC || ObscuredBool.FNIPJFGEFFD(PHLKCKKDLFF)) ? ObscuredFloat.FNIPJFGEFFD(KEOPJIFEMIC) : ((!ObscuredBool.FNIPJFGEFFD(base.BJJCGMPNGDL)) ? 0.4f : ((!ObscuredBool.FNIPJFGEFFD(AILHLEALEAI)) ? ObscuredFloat.FNIPJFGEFFD(JOCNGKFAIHM) : (ObscuredFloat.FNIPJFGEFFD(JOCNGKFAIHM) * 1.5f)))) : (ObscuredFloat.FNIPJFGEFFD(JOCNGKFAIHM) / 4f));
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IDHNLOELEDI) && !ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
		{
			PGAEOIANOAP *= 0.96f;
			if (Physics.Raycast(base.ELGIKGAIIOD, Vector3.down, 1f, 1024))
			{
				PGAEOIANOAP += Vector3.down * 9.81f * base.EPOKGKJCOAF;
			}
		}
		if (KPKNIABCJOC.magnitude > 0.1f)
		{
			EFGOFOCKHIB = KPKNIABCJOC;
		}
		KPKNIABCJOC *= ObscuredFloat.FNIPJFGEFFD(NINJLPOLFEF);
		if (KPKNIABCJOC.magnitude < ObscuredFloat.FNIPJFGEFFD(IEPHAKCKAPP) && Time.time - ObscuredFloat.FNIPJFGEFFD(BHHEOGIMOLJ) > 0.2f)
		{
			KPKNIABCJOC = Vector3.zero;
		}
		RaycastHit hitInfo;
		if (FOGIOGKLNIP.NMGDHKIKCED == this && EFGOFOCKHIB != Vector3.zero && Physics.Raycast(base.PONALLDHFGB, EFGOFOCKHIB, out hitInfo, 0.7f, 1024))
		{
			RaycastHit hitInfo2 = default(RaycastHit);
			if (Physics.Raycast((base.ELGIKGAIIOD + base.PONALLDHFGB) / 2f, EFGOFOCKHIB, out hitInfo2, 0.7f, 1024) && FOGIOGKLNIP.KDCGBDNNCHM(hitInfo.point - hitInfo2.point).magnitude > FOGIOGKLNIP.LMMFHEODOPM.EIFADHFAGJO)
			{
				MCDKIHGPCAL += hitInfo.normal;
			}
		}
		MCDKIHGPCAL *= 0.9f;
		CBOOLAKHHHG *= 0.78f;
	}

	public void CLAPCCOJNKN()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (FOGIOGKLNIP.PIOANBBCFFP.GGPOLOMIGOI.Count > 0 && FOGIOGKLNIP.PIOANBBCFFP.GGPOLOMIGOI.FirstOrDefault((EJDKALEIBBG AEMBPMJMOAB) => CPINPFLEJFF(AEMBPMJMOAB.CMPKOEMBHDO) && (AEMBPMJMOAB.MGFENAGABOE != AKIMNDMGFMN.FBGNKPPMENN || BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) && (AEMBPMJMOAB.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 1f && Time.time - AEMBPMJMOAB.KMLPDIHOPNC > 0.5f) != null && Time.time - ObscuredFloat.FNIPJFGEFFD(CKLJKFKKHEE) > 0.1f)
		{
			NCHOPAEKPBK(ENGMJKMNCCO);
		}
		if (!ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK) && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists && FOGIOGKLNIP.PIOANBBCFFP.JLFMGNFDGCK.Count > 0 && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.BOOJPIJMOEL))
		{
			MKAFHPMKFEO mKAFHPMKFEO = FOGIOGKLNIP.PIOANBBCFFP.JLFMGNFDGCK.FirstOrDefault((MKAFHPMKFEO AEMBPMJMOAB) => (base.ELGIKGAIIOD - AEMBPMJMOAB.ELGIKGAIIOD).magnitude < 1f);
			if (mKAFHPMKFEO != null && !ObscuredBool.FNIPJFGEFFD(mKAFHPMKFEO.BJLFIDLJNAH))
			{
				if (FOGIOGKLNIP.EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.E) || (FOGIOGKLNIP.DGMBIMMABNO && PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.DKGIGGNDOIH, TouchPhase.Stationary, TouchPhase.Moved) && !PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.DKGIGGNDOIH, TouchPhase.Ended)))
				{
					float num = (Time.time - ObscuredFloat.FNIPJFGEFFD(GCDGMACGMKE)) / ((!ObscuredBool.FNIPJFGEFFD(KKDKMEFMDAN)) ? 10f : 5f);
					FOGIOGKLNIP.CIEBMCOJGCC.OECIDJJPPBC(num);
					if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA) && yvel == 0f && KAMAMHFJDGG)
					{
						CBOOLAKHHHG = Vector3.zero;
						if (num > 1f)
						{
							mKAFHPMKFEO.NNKNOMCFFAL();
							FOGIOGKLNIP.EIIMBNKHJJA.MPJCKINAGNC();
						}
					}
				}
				else
				{
					GCDGMACGMKE = ObscuredFloat.FNIPJFGEFFD(Time.time);
				}
			}
			else
			{
				GCDGMACGMKE = ObscuredFloat.FNIPJFGEFFD(Time.time);
			}
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	public void DOMADIHDNLK()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA) || ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) == 0f || !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CGFPIMCKBNH) || FOGIOGKLNIP.OMMLFOEPEEK || Time.time - ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) > 5f)
		{
			if (BLNPMMNGCAG)
			{
				base.ELGIKGAIIOD = base.LBAHIOEDPLP.currentOffMeshLinkData.endPos;
				base.LBAHIOEDPLP.CompleteOffMeshLink();
			}
			if (EFNGNBGDNPN)
			{
				if (GJPLPPKDDJF.Count > 1)
				{
					ICKMLJNOODA += ((!ObscuredBool.FNIPJFGEFFD(DBDNFADIAPB)) ? 1 : (-1));
					if (ICKMLJNOODA > GJPLPPKDDJF.Count - 1 || ICKMLJNOODA < 0)
					{
						DBDNFADIAPB = ObscuredBool.FNIPJFGEFFD(!ObscuredBool.FNIPJFGEFFD(DBDNFADIAPB));
						ICKMLJNOODA += ((!ObscuredBool.FNIPJFGEFFD(DBDNFADIAPB)) ? 2 : (-2));
					}
					base.DGKKHAKDOJG = GJPLPPKDDJF[ICKMLJNOODA];
				}
			}
			else
			{
				if ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) || !base.MMPHADBLLCL.Any()) && (UnityEngine.Random.value > 0.3f || !base.MMPHADBLLCL.Any()))
				{
					Vector3 position = FOGIOGKLNIP.PIOANBBCFFP.FFECBELHGGD.Random().transform.position;
					if (position != Vector3.zero)
					{
						base.DGKKHAKDOJG = position;
						return;
					}
				}
				if (base.MMPHADBLLCL.Any((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.KAMAMHFJDGG))
				{
					base.DGKKHAKDOJG = base.MMPHADBLLCL.Where((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.KAMAMHFJDGG).Random().ELGIKGAIIOD;
				}
			}
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	protected void PMFOJPCOKGC()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (!(ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) - Time.time > 0.2f))
		{
			OHJJOGICBJE();
			LAGKPBMDGEH();
			if ((CKBFMCAMMBD != null && Vector3.Distance(base.ELGIKGAIIOD, CKBFMCAMMBD.ELGIKGAIIOD) < ObscuredFloat.FNIPJFGEFFD(AAFLGILMEKL)) || Time.time - ObscuredFloat.FNIPJFGEFFD(OFCJCMGEGFB) < 1f)
			{
				KNOEPICGNLK();
			}
			HHNAKLKEFIP();
			if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
			{
			}
		}
	}

	protected void CMGGAOANIIP()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) - Time.time > 0.5f)
		{
			return;
		}
		BJKAFAGNPBI();
		if (BLNPMMNGCAG)
		{
			return;
		}
		if (FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.ELKBOHAOPDL(20))
		{
			CKBFMCAMMBD = MDCHFGCFBIE();
		}
		CBOOLAKHHHG = Vector3.zero;
		if (JCFJLNHJECM != null && FOGIOGKLNIP.LMMFHEODOPM.IKODMMOKAIO)
		{
			base.DGKKHAKDOJG = JCFJLNHJECM.transform.position;
		}
		else if (DLDFNGIJIMH && (base.LBAHIOEDPLP.pathEndPosition - base.ELGIKGAIIOD).magnitude < ObscuredFloat.FNIPJFGEFFD(AAFLGILMEKL) && JDFKPOMKMNJ.NFMIBMIGJMH(1000))
		{
			DOMADIHDNLK();
		}
		Vector3 vector = FOGIOGKLNIP.KDCGBDNNCHM(base.GBAENDOLFBB - base.ELGIKGAIIOD);
		if (vector.magnitude > 0.1f)
		{
			MMBCBFBOPEP = Quaternion.LookRotation(vector).eulerAngles;
		}
		if (CKBFMCAMMBD != null)
		{
			MMBCBFBOPEP = Quaternion.LookRotation(((!((CKBFMCAMMBD.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 5f)) ? CKBFMCAMMBD.PONALLDHFGB : CKBFMCAMMBD.LGIJCFNJGDA) - MPCGHDNMNKN.ELGIKGAIIOD).eulerAngles;
		}
		Vector3 eulerAngles = MPCGHDNMNKN.EHOEFMPLIFB.eulerAngles;
		Vector3 vector2 = new Vector3(Mathf.DeltaAngle(eulerAngles.x, MMBCBFBOPEP.x), Mathf.DeltaAngle(eulerAngles.y, MMBCBFBOPEP.y), 0f) * base.EPOKGKJCOAF * 10f;
		base.PGPEDGPEJHH = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(base.PGPEDGPEJHH) + vector2.x);
		AFFCELMDIDB(vector2.y);
		CBOOLAKHHHG = FOGIOGKLNIP.BMLFFBGLAFI(Quaternion.Inverse(MPCGHDNMNKN.EHOEFMPLIFB.rotation) * vector);
		if (DLDFNGIJIMH)
		{
			LAGKPBMDGEH();
		}
		if (JEPMMPCNEHO != AKIMNDMGFMN)
		{
			if (CKBFMCAMMBD != null && PEEIEMGAJOA)
			{
				FNFGLNHIEFA();
			}
			else
			{
				JEPMMPCNEHO.OOKLHOCJKAG = false;
			}
		}
		else
		{
			JEPMMPCNEHO.OOKLHOCJKAG = true;
		}
		HHNAKLKEFIP();
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	private void FNFGLNHIEFA()
	{
		if (Time.time > ObscuredFloat.FNIPJFGEFFD(DOEPJJGILAA))
		{
			if (Time.time > ObscuredFloat.FNIPJFGEFFD(DOEPJJGILAA) + 0.5f)
			{
				DOEPJJGILAA = ObscuredFloat.FNIPJFGEFFD(Time.time + UnityEngine.Random.Range(0f, 2f));
			}
			CBOOLAKHHHG = Vector3.zero;
			JEPMMPCNEHO.OOKLHOCJKAG = true;
		}
		else
		{
			JEPMMPCNEHO.OOKLHOCJKAG = false;
		}
	}

	private void NHOGOKJGLJD()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (ObscuredBool.FNIPJFGEFFD(PMKOJMNEFOF))
		{
			CBOOLAKHHHG = HMADAKBKEPJ;
		}
		if (!ObscuredBool.FNIPJFGEFFD(LKGMKGCNHMA) && (!ObscuredBool.FNIPJFGEFFD(OELALHMEEBM) || KAMAMHFJDGG))
		{
			PGAEOIANOAP += Physics.gravity * base.EPOKGKJCOAF;
		}
		else if (Time.time - ObscuredFloat.FNIPJFGEFFD(JOGBGBDCOEB) > 1f)
		{
			PGAEOIANOAP = Vector3.zero;
		}
		Vector3 vector = Vector3.zero;
		if (ObscuredBool.FNIPJFGEFFD(PFIFFLMAPOO))
		{
			vector = LCBBMGAPMFL(vector);
		}
		else
		{
			vector += (KPKNIABCJOC * ObscuredFloat.FNIPJFGEFFD((!ObscuredBool.FNIPJFGEFFD(base.NBFGNGGJDNB)) ? FOGIOGKLNIP.PIOANBBCFFP.EMKLPBIJILF : FOGIOGKLNIP.PIOANBBCFFP.IJFJBIKHEDL) * ObscuredFloat.FNIPJFGEFFD(JEPMMPCNEHO.FLGDGHPCNDK.RunSpeedFactor) + PGAEOIANOAP + MCDKIHGPCAL) * base.EPOKGKJCOAF;
			if (yvel > 0f)
			{
				vector += new Vector3(0f, yvel, 0f) * base.EPOKGKJCOAF / 0.02f;
			}
		}
		LCFNDAMNKGM(vector);
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	private void DGHNJLMEHLC()
	{
		if (IKHBOFEIDBE != null)
		{
			IKHBOFEIDBE.enabled = IMBFNLLBGGC;
		}
		if (ObscuredBool.FNIPJFGEFFD(base.NBFGNGGJDNB) && JDFKPOMKMNJ.NFMIBMIGJMH(3000) && FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count > 1)
		{
			base.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA) - 10);
			if (ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA) <= 0 && KAMAMHFJDGG)
			{
				KNOEPICGNLK();
			}
		}
	}

	private void PPBLJMDIFKB()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK) && JEPMMPCNEHO != AKIMNDMGFMN && base.KEMLHMOIFIM)
		{
			DKPJJKBJJOA(AKIMNDMGFMN.FBGNKPPMENN);
		}
		if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA))
		{
			GGBCAOAGPPM.transform.localRotation = Quaternion.Slerp(GGBCAOAGPPM.transform.localRotation, Quaternion.identity, Time.deltaTime * 2f);
			GGBCAOAGPPM.transform.localRotation = Quaternion.RotateTowards(GGBCAOAGPPM.transform.localRotation, Quaternion.identity, Time.deltaTime * 5f);
		}
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM) && ObscuredBool.FNIPJFGEFFD(base.BJJCGMPNGDL) && base.GCNMEJLGIOE["jump"].weight > 0f)
		{
			base.GCNMEJLGIOE["jump"].weight *= 0.86f;
		}
		if (ObscuredBool.FNIPJFGEFFD(EFCLACBNGCL) && ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA) && UnityEngine.Random.value < 0.1f)
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.GGOMJFMFLIO();
		}
		if (ObscuredBool.FNIPJFGEFFD(MGJPMGGABLN))
		{
			BOCKAJGNBOE = ObscuredFloat.FNIPJFGEFFD(Time.time);
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	private void NJKKHBBKMJO()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (!KAMAMHFJDGG)
		{
			base.PGPEDGPEJHH = ObscuredFloat.FNIPJFGEFFD(Mathf.LerpAngle(ObscuredFloat.FNIPJFGEFFD(base.PGPEDGPEJHH), ObscuredFloat.FNIPJFGEFFD(BMAKABMPOAC), base.EPOKGKJCOAF * 10f));
			float num = Mathf.LerpAngle(MPCGHDNMNKN.GMLOJKFBLBN, ObscuredFloat.FNIPJFGEFFD(IKMGNOFKJAF), base.EPOKGKJCOAF * 10f);
			float cPFJBOMGNBF = num - MPCGHDNMNKN.GMLOJKFBLBN;
			AFFCELMDIDB(cPFJBOMGNBF);
		}
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			Vector3 vector = DCBCHPFICFO(new Vector3(ObscuredFloat.FNIPJFGEFFD(base.PGPEDGPEJHH), CCKPOMBKIBB(BGJOMCIIFAK.GMLOJKFBLBN - MPCGHDNMNKN.GMLOJKFBLBN), 0f));
			if (FOGIOGKLNIP.LMMFHEODOPM.CPJKMDCJANM)
			{
				vector += FHFGMEFLCAF;
			}
			Vector3 a = new Vector3(Mathf.Clamp(vector.y / (float)(-ObscuredInt.FNIPJFGEFFD(DBHBGABEKJH)), -1f, 0f) + Mathf.Clamp(vector.y / (float)ObscuredInt.FNIPJFGEFFD(NBEMLIHDJLC), 0f, 1f), 0f - (Mathf.Clamp(vector.x / 45f, -1f, 0f) + Mathf.Clamp(vector.x / 45f, 0f, 1f)));
			string[] array = ((!GEGAMONDEKC) ? JEPMMPCNEHO.AIOGABFEOJB : JEPMMPCNEHO.BFFNBGNAEMI);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (JEPMMPCNEHO.MPELBBLOCFF)
				{
					base.GCNMEJLGIOE[text].speed = 1f;
					continue;
				}
				base.GCNMEJLGIOE[text].speed = 0f;
				base.GCNMEJLGIOE[text].time = 0f;
			}
			JAIEKCDHLAA(array[5], 1f);
			JAIEKCDHLAA(array[6], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.left)));
			JAIEKCDHLAA(array[4], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.right)));
			JAIEKCDHLAA(array[2], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.up)));
			JAIEKCDHLAA(array[8], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.down)));
			JAIEKCDHLAA(array[1], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.right + Vector3.up)));
			JAIEKCDHLAA(array[7], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.right + Vector3.down)));
			JAIEKCDHLAA(array[3], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.left + Vector3.up)));
			JAIEKCDHLAA(array[9], Mathf.Max(0f, 1f - Vector3.Distance(a, Vector3.left + Vector3.down)));
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	private void KNMNMADEGHG()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			Vector3 vector = FOGIOGKLNIP.KDCGBDNNCHM(GLAACBGDIPI);
			Vector3 forward = vector.normalized + FOGIOGKLNIP.KDCGBDNNCHM(MPCGHDNMNKN.EHOEFMPLIFB.forward) * 0.1f;
			float num = vector.magnitude / 6.65f;
			if (vector.magnitude > 0.7f)
			{
				float f = Mathf.DeltaAngle(Quaternion.LookRotation(vector).eulerAngles.y, MPCGHDNMNKN.GMLOJKFBLBN);
				if (Mathf.Abs(f) > 110f && (Time.frameCount - GOFPGIAIDNI > 5 || !FOGIOGKLNIP.DGMBIMMABNO || ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA) || FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL))
				{
					Quaternion quaternion = Quaternion.LookRotation(vector * -1f);
					if (Quaternion.Angle(BGJOMCIIFAK.KHGAOLHJCMO, quaternion) > 5f)
					{
						BGJOMCIIFAK.KHGAOLHJCMO = ((!FOGIOGKLNIP.DGMBIMMABNO || ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA)) ? Quaternion.Slerp(BGJOMCIIFAK.KHGAOLHJCMO, quaternion, Time.deltaTime * 10f) : quaternion);
						GOFPGIAIDNI = Time.frameCount;
					}
					AnimationState animationState = base.GCNMEJLGIOE["crouch_run"];
					float speed = -2f * num * (float)((Time.time - ObscuredFloat.FNIPJFGEFFD(FDKEHBJBNCJ) < 1f) ? 1 : 0);
					base.GCNMEJLGIOE["run"].speed = speed;
					animationState.speed = speed;
				}
				else
				{
					Quaternion quaternion2 = Quaternion.LookRotation(forward);
					if (Quaternion.Angle(BGJOMCIIFAK.KHGAOLHJCMO, quaternion2) > 5f && (Time.frameCount - GOFPGIAIDNI > 5 || !FOGIOGKLNIP.DGMBIMMABNO || ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA) || FOGIOGKLNIP.LPLJMLGKCLK.FDCJJPMBMDL))
					{
						BGJOMCIIFAK.KHGAOLHJCMO = ((!FOGIOGKLNIP.DGMBIMMABNO || ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA)) ? Quaternion.Slerp(BGJOMCIIFAK.KHGAOLHJCMO, quaternion2, Time.deltaTime * 10f) : quaternion2);
						GOFPGIAIDNI = Time.frameCount;
					}
					AnimationState animationState2 = base.GCNMEJLGIOE["crouch_run"];
					float speed = 2f * num * (float)((Time.time - ObscuredFloat.FNIPJFGEFFD(FDKEHBJBNCJ) < 1f) ? 1 : 0);
					base.GCNMEJLGIOE["run"].speed = speed;
					animationState2.speed = speed;
				}
				base.GCNMEJLGIOE.CrossFade((!GEGAMONDEKC) ? "run" : "crouch_run");
			}
			else
			{
				base.GCNMEJLGIOE.CrossFade((!GEGAMONDEKC) ? "idle" : "crouch");
			}
		}
		if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA))
		{
			string animation = ((KPKNIABCJOC.magnitude < 0.1f) ? "IdleAnimation" : ((!ObscuredBool.FNIPJFGEFFD(AILHLEALEAI)) ? "WalkAnimation" : "WalkAnimation"));
			float num2 = KPKNIABCJOC.magnitude / 5.55f;
			FOGIOGKLNIP.NGFDFPGNDCJ.EEMEJPLAPHG.CrossFade(animation);
			FOGIOGKLNIP.NGFDFPGNDCJ.EEMEJPLAPHG[animation].speed = ((KPKNIABCJOC.magnitude < 0.1f) ? 1f : ((!ObscuredBool.FNIPJFGEFFD(AILHLEALEAI)) ? num2 : num2));
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	private void MFPLNEMIFMJ()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && !ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK) && JDFKPOMKMNJ.NFMIBMIGJMH(1000))
		{
			NavMeshHit hit;
			if (NavMesh.SamplePosition(base.ELGIKGAIIOD, out hit, 0.5f, 1))
			{
				FEABHFMDFPE = Time.time;
			}
			if (Time.time - FEABHFMDFPE > 6f)
			{
				FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("Safe Place: -" + GEJCCBAOGAE);
				GGNFHJCPCBK(-ObscuredInt.FNIPJFGEFFD(GEJCCBAOGAE = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(GEJCCBAOGAE) + 2)), BJDCCKHBENA);
			}
		}
		NFHGOIHFOBD nFHGOIHFOBD = FOGIOGKLNIP.PIOANBBCFFP.DHHENNKPELD.FirstOrDefault((NFHGOIHFOBD AEMBPMJMOAB) => (AEMBPMJMOAB.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 1f);
		if (nFHGOIHFOBD != null && ((float)ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA) <= ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.OHGEMABOIBK) - 25f || !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.DOMONNBOMNP)))
		{
			UnityEngine.Object.Destroy(nFHGOIHFOBD.ICIEDCMDJFO);
			LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Medkit);
			if (KAMAMHFJDGG)
			{
				NCHOPAEKPBK(DFJGLGGOKKN, ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA) + 25);
			}
		}
		if (!FOGIOGKLNIP.PIOANBBCFFP.IGJKLHOGPHL)
		{
			for (int num = 1; num < 10; num++)
			{
				if (Input.GetKeyDown((KeyCode)(48 + num)))
				{
					PCOIDKLMEAD(num);
				}
			}
			if (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.Q))
			{
				CFINPAOKCDB();
			}
			if ((PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.ADONJOMILGL, default(TouchPhase)) || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.G)) && JEPMMPCNEHO != FFGDOHNIMON && !(JEPMMPCNEHO is JOCAFHIONFA))
			{
				NCHOPAEKPBK(HGMACHLNNOK, JEPMMPCNEHO.FBGNKPPMENN, JEPMMPCNEHO.JJHIFNAJIBK, ObscuredInt.FNIPJFGEFFD(JEPMMPCNEHO.CNMKGNNGPDD), JEPMMPCNEHO.LMJDOOEODJK.DJEALLIOJEO(JEPMMPCNEHO.NNBDEKBINFP), false);
			}
			if (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.BPBPPLDFLFK, default(TouchPhase)))
			{
				FOGIOGKLNIP.GMPBCIEDMCD.PCOIDKLMEAD(3);
			}
			if (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.JEPMMPCNEHO, default(TouchPhase)))
			{
				FOGIOGKLNIP.GMPBCIEDMCD.PCOIDKLMEAD(1);
			}
			if (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.DLHLKPMGHOO, default(TouchPhase)))
			{
				JOCAFHIONFA.GGEBNCCEOGD = true;
				FOGIOGKLNIP.GMPBCIEDMCD.PCOIDKLMEAD(4);
			}
			RaycastHit hitInfo;
			if (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.T) && !string.IsNullOrEmpty(BJDCCKHBENA.COEIPPFAEDA) && Time.time - ObscuredFloat.FNIPJFGEFFD(EGBJOABGKPM) > 10f && Physics.Raycast(MPCGHDNMNKN.ELGIKGAIIOD, MPCGHDNMNKN.EHOEFMPLIFB.forward, out hitInfo, 2f, 1024))
			{
				NCHOPAEKPBK(POCJJHFJIJB, hitInfo.point + hitInfo.normal * UnityEngine.Random.Range(0.02f, 0.03f), Quaternion.LookRotation(-hitInfo.normal), BJDCCKHBENA.COEIPPFAEDA);
			}
			if (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.NKLMAKGGLAH, default(TouchPhase)))
			{
				FOGIOGKLNIP.GMPBCIEDMCD.PCOIDKLMEAD(2);
			}
			if (!ObscuredBool.FNIPJFGEFFD(JEPMMPCNEHO.EMIEPBFBJBB))
			{
				if (Input.GetAxis("Mouse ScrollWheel") < 0f || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.FPNFOCPNIJH, default(TouchPhase)) || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.P))
				{
					LIFLOGLLGIG();
				}
				else if (Input.GetAxis("Mouse ScrollWheel") > 0f || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.O))
				{
					LJFEKOLKMPF();
				}
			}
			if (PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.BIPNKKBDLNA, default(TouchPhase)) || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.X) || FOGIOGKLNIP.PIOANBBCFFP.JLODNBFNDEI)
			{
				GNMACPNCAFL = ObscuredBool.FNIPJFGEFFD(!ObscuredBool.FNIPJFGEFFD(GNMACPNCAFL));
			}
			if (!AIAJBBMCIBK["playerCrouch"].enabled)
			{
				bool flag = (FOGIOGKLNIP.EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.LeftControl) || ObscuredBool.FNIPJFGEFFD(GNMACPNCAFL)) && !ObscuredBool.FNIPJFGEFFD(AILHLEALEAI);
				bool flag2 = (!FOGIOGKLNIP.DGMBIMMABNO && GEGAMONDEKC && (ECJJCGAEKAC(Vector3.forward) || ECJJCGAEKAC(Vector3.back) || ECJJCGAEKAC(Vector3.left) || ECJJCGAEKAC(Vector3.right))) || ECJJCGAEKAC(Vector3.zero);
				if (flag && !GEGAMONDEKC)
				{
					NCHOPAEKPBK(ONHAAOFOLAJ, true);
				}
				if (!flag && GEGAMONDEKC && !flag2)
				{
					NCHOPAEKPBK(ONHAAOFOLAJ, false);
				}
				NGBCDAIIEFP nGBCDAIIEFP = JEPMMPCNEHO as NGBCDAIIEFP;
				if (ObscuredBool.FNIPJFGEFFD(NPCDJBMMJKA) && !ObscuredBool.FNIPJFGEFFD(JEPMMPCNEHO.BCCOHOIIGPP) && ((Input.GetMouseButtonDown(1) && (!FOGIOGKLNIP.DGMBIMMABNO || FOGIOGKLNIP.OMMLFOEPEEK)) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.OJJLMNMBGJJ, default(TouchPhase))) && FOGIOGKLNIP.NGFDFPGNDCJ.HDIMJIENKHH != null)
				{
					MEKBDDDHJFO = ObscuredBool.FNIPJFGEFFD(!ObscuredBool.FNIPJFGEFFD(MEKBDDDHJFO));
				}
				if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IJDOMLPACPA))
				{
					if (ObscuredBool.FNIPJFGEFFD(AILHLEALEAI))
					{
						OCJOMIDJHCJ = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(OCJOMIDJHCJ) - Time.deltaTime * 2f);
					}
					else
					{
						OCJOMIDJHCJ = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(OCJOMIDJHCJ) + Time.deltaTime * ((CBOOLAKHHHG.magnitude != 0f) ? 0.5f : 0.8f));
					}
					OCJOMIDJHCJ = ObscuredFloat.FNIPJFGEFFD(Mathf.Min(5f, ObscuredFloat.FNIPJFGEFFD(OCJOMIDJHCJ)));
					bool flag3 = (nGBCDAIIEFP != null && nGBCDAIIEFP.OBPLDGGKLOJ) || !ObscuredBool.FNIPJFGEFFD(base.BJJCGMPNGDL);
					bool flag4 = ObscuredFloat.FNIPJFGEFFD(OCJOMIDJHCJ) > (float)((!ObscuredBool.FNIPJFGEFFD(AILHLEALEAI)) ? 1 : 0);
					if (!flag4 && ObscuredBool.FNIPJFGEFFD(AILHLEALEAI))
					{
						LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Exhaused);
					}
					bool flag5 = (FOGIOGKLNIP.EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.LeftShift) || FOGIOGKLNIP.PIOANBBCFFP.HDOJLFGFDGH || (ObscuredBool.FNIPJFGEFFD(AILHLEALEAI) && FOGIOGKLNIP.DGMBIMMABNO)) && !flag3 && flag4 && !ObscuredBool.FNIPJFGEFFD(MEKBDDDHJFO) && (CBOOLAKHHHG != Vector3.zero || FOGIOGKLNIP.PIOANBBCFFP.HDOJLFGFDGH);
					FOGIOGKLNIP.PIOANBBCFFP.HDOJLFGFDGH = false;
					if (flag5 && !ObscuredBool.FNIPJFGEFFD(AILHLEALEAI))
					{
						NCHOPAEKPBK(ECEENKMCMFM, true);
					}
					if (!flag5 && ObscuredBool.FNIPJFGEFFD(AILHLEALEAI))
					{
						NCHOPAEKPBK(ECEENKMCMFM, false);
					}
					if (flag3)
					{
						MEKBDDDHJFO = ObscuredBool.FNIPJFGEFFD(false);
					}
				}
				else if (!ObscuredBool.FNIPJFGEFFD(NPCDJBMMJKA))
				{
					MEKBDDDHJFO = ObscuredBool.FNIPJFGEFFD(Input.GetKey(KeyCode.LeftShift));
				}
				if (ObscuredBool.FNIPJFGEFFD(MEKBDDDHJFO) && !ObscuredBool.FNIPJFGEFFD(PHLKCKKDLFF))
				{
					NCHOPAEKPBK(PCLJKKIFHPP, true);
				}
				if (!ObscuredBool.FNIPJFGEFFD(MEKBDDDHJFO) && ObscuredBool.FNIPJFGEFFD(PHLKCKKDLFF))
				{
					NCHOPAEKPBK(PCLJKKIFHPP, false);
				}
				if (flag2 && !GEGAMONDEKC)
				{
					BIHOCPAKHNF("HeadHit");
					NCHOPAEKPBK(ONHAAOFOLAJ, true);
				}
			}
			if (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.H))
			{
				NCHOPAEKPBK(DDNIOKNIMBK, !ONLNEOGEDPC[0].enabled);
			}
			if (ObscuredBool.FNIPJFGEFFD(base.BJJCGMPNGDL) && (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.Space) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.HHLEMDPBFME, default(TouchPhase)) || FOGIOGKLNIP.PIOANBBCFFP.LOIKOIEOGPD))
			{
				if (!GEGAMONDEKC)
				{
					NCHOPAEKPBK(PINBKNKFBJC);
				}
				else
				{
					GNMACPNCAFL = ObscuredBool.FNIPJFGEFFD(false);
				}
			}
			if (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.R) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.ODMGBBKGLOD, default(TouchPhase)))
			{
				JEPMMPCNEHO.PIALCLIEKDB();
			}
		}
		if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA) || ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) == 0f || !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CGFPIMCKBNH) || FOGIOGKLNIP.OMMLFOEPEEK || Time.time - ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CDHGIGNMPKD) > 5f)
		{
			JEPMMPCNEHO.OOKLHOCJKAG = FOGIOGKLNIP.CNIAIOJACDA;
			CBOOLAKHHHG = FOGIOGKLNIP.FAFGMDJIOGN;
		}
		else
		{
			CBOOLAKHHHG = Vector3.zero;
			JEPMMPCNEHO.OOKLHOCJKAG = false;
		}
		if (ObscuredBool.FNIPJFGEFFD(AILHLEALEAI))
		{
			JEPMMPCNEHO.OOKLHOCJKAG = false;
		}
		if (FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD)
		{
			RaycastHit hitInfo2 = new RaycastHit
			{
				point = FOGIOGKLNIP.NGFDFPGNDCJ.HDLMCABHEIC.position
			};
			if (FOGIOGKLNIP.NGFDFPGNDCJ.AEBCFFNADHM && Physics.Raycast(Camera.main.ScreenPointToRay(Camera.main.WorldToScreenPoint(FOGIOGKLNIP.NGFDFPGNDCJ.HDLMCABHEIC.position)), out hitInfo2, 1000f, 1024))
			{
				hitInfo2.point += Vector3.up * FOGIOGKLNIP.NGFDFPGNDCJ.BDENDOMDMLF;
				Debug.DrawRay(hitInfo2.point, Vector3.up, Color.black);
			}
			Vector3 eulerAngles = Quaternion.LookRotation(hitInfo2.point - MPCGHDNMNKN.ELGIKGAIIOD).eulerAngles;
			base.PGPEDGPEJHH = ObscuredFloat.FNIPJFGEFFD(eulerAngles.x);
			AFFCELMDIDB(Mathf.DeltaAngle(MPCGHDNMNKN.GMLOJKFBLBN, eulerAngles.y));
		}
		else
		{
			base.PGPEDGPEJHH = ObscuredFloat.FNIPJFGEFFD(Mathf.Clamp(CCKPOMBKIBB(ObscuredFloat.FNIPJFGEFFD(base.PGPEDGPEJHH)) + FOGIOGKLNIP.DDGKNLHJEFD.x, -85f, 85f));
			AFFCELMDIDB(FOGIOGKLNIP.DDGKNLHJEFD.y);
		}
		if (FOGIOGKLNIP.NGFDFPGNDCJ.AEBCFFNADHM)
		{
			CBOOLAKHHHG = Quaternion.Inverse(MPCGHDNMNKN.KHGAOLHJCMO) * CBOOLAKHHHG;
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	[RPC]
	public void APPBJCKAKMH()
	{
		KKDKMEFMDAN = ObscuredBool.FNIPJFGEFFD(true);
	}

	public void IMAAMLFMKOC(bool DLFDBAIDGFB = false)
	{
		IAPJEBKJEHC[] array = OKDFHJJNFCC.WhereF((IAPJEBKJEHC AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO) && !(AEMBPMJMOAB is JOCAFHIONFA));
		foreach (IAPJEBKJEHC iAPJEBKJEHC in array)
		{
			iAPJEBKJEHC.LMJDOOEODJK.NKOHBFHAELH(iAPJEBKJEHC.NNBDEKBINFP, iAPJEBKJEHC.LMJDOOEODJK.DJEALLIOJEO(iAPJEBKJEHC.NNBDEKBINFP, true), true);
			if (DLFDBAIDGFB)
			{
				iAPJEBKJEHC.CNMKGNNGPDD = iAPJEBKJEHC.ABHFBECBPBA;
			}
			iAPJEBKJEHC.Reset();
		}
	}

	public void EPOOIFLHPFO(int ALEOHHMPCOC, bool DLFDBAIDGFB = false)
	{
		ALPCBKANAFC aLPCBKANAFC = new ALPCBKANAFC();
		aLPCBKANAFC.ALEOHHMPCOC = ALEOHHMPCOC;
		IAPJEBKJEHC[] array = OKDFHJJNFCC.WhereF(aLPCBKANAFC.BEKJDJFLJJC);
		foreach (IAPJEBKJEHC iAPJEBKJEHC in array)
		{
			iAPJEBKJEHC.LMJDOOEODJK.NKOHBFHAELH(iAPJEBKJEHC.NNBDEKBINFP, iAPJEBKJEHC.LMJDOOEODJK.DJEALLIOJEO(iAPJEBKJEHC.NNBDEKBINFP, true), true);
			if (DLFDBAIDGFB)
			{
				iAPJEBKJEHC.CNMKGNNGPDD = iAPJEBKJEHC.ABHFBECBPBA;
			}
			iAPJEBKJEHC.Reset();
		}
	}

	public void IBKJODHOAGN()
	{
		GameObject gameObject = ICONFJBEJPN("game/barrier", base.ELGIKGAIIOD + FOGIOGKLNIP.KDCGBDNNCHM(FOGIOGKLNIP.NGFDFPGNDCJ.EHOEFMPLIFB.forward), Quaternion.LookRotation(FOGIOGKLNIP.KDCGBDNNCHM(FOGIOGKLNIP.NGFDFPGNDCJ.EHOEFMPLIFB.forward)), 2);
		PMDPIINLPHK component = gameObject.GetComponent<PMDPIINLPHK>();
		component.NCHOPAEKPBK(component.INKCDEBODNE, (int)BJDCCKHBENA.JGECOECAJLK);
	}

	private bool ECJJCGAEKAC(Vector3 DFHHDIMKIAN)
	{
		return Physics.Raycast(base.PONALLDHFGB, Vector3.up + DFHHDIMKIAN * 0.5f, 1.2f, 1025);
	}

	protected void AFFCELMDIDB(float CPFJBOMGNBF)
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
		{
			MPCGHDNMNKN.EHOEFMPLIFB.Rotate(0f, CPFJBOMGNBF, 0f, Space.World);
			if (ObscuredBool.FNIPJFGEFFD(CGCEAEFHDIF))
			{
				float num = BGJOMCIIFAK.GMLOJKFBLBN;
				float num2 = MPCGHDNMNKN.GMLOJKFBLBN;
				float num3 = CCKPOMBKIBB(num - num2);
				if (num3 < (float)ObscuredInt.FNIPJFGEFFD(DBHBGABEKJH))
				{
					BGJOMCIIFAK.GMLOJKFBLBN = Mathf.MoveTowardsAngle(num, num2, (float)ObscuredInt.FNIPJFGEFFD(DBHBGABEKJH) - num3);
				}
				if (num3 > (float)ObscuredInt.FNIPJFGEFFD(NBEMLIHDJLC))
				{
					BGJOMCIIFAK.GMLOJKFBLBN = Mathf.MoveTowardsAngle(num, num2, num3 - (float)ObscuredInt.FNIPJFGEFFD(NBEMLIHDJLC));
				}
			}
		}
		else
		{
			EHOEFMPLIFB.Rotate(0f, CPFJBOMGNBF, 0f, Space.World);
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.KDOPJMADIAL)
		{
		}
	}

	public bool CPINPFLEJFF(int KOPFHECCACK)
	{
		OHPBEMABIEM oHPBEMABIEM = new OHPBEMABIEM();
		oHPBEMABIEM.KOPFHECCACK = KOPFHECCACK;
		return !OKDFHJJNFCC.Any(oHPBEMABIEM.BEKJDJFLJJC);
	}

	public bool KGGLJOBGOND(IAPJEBKJEHC GIPIKICBHKA)
	{
		ACBAOBPJJDH aCBAOBPJJDH = new ACBAOBPJJDH();
		aCBAOBPJJDH.GIPIKICBHKA = GIPIKICBHKA;
		if (aCBAOBPJJDH.GIPIKICBHKA == COHNIKDEGOC && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.GFPOMBMNDIO))
		{
			return false;
		}
		bool flag = ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.CFGAEDNCMJP);
		bool flag2 = !OKDFHJJNFCC.Any(aCBAOBPJJDH.BEKJDJFLJJC);
		bool flag3 = aCBAOBPJJDH.GIPIKICBHKA is JOCAFHIONFA && !OKDFHJJNFCC.Any(aCBAOBPJJDH.PMBKBKJIIPO);
		return flag || flag2 || flag3;
	}

	public void CFINPAOKCDB()
	{
		LKLAEDIGMIB(HINDBLMPIOP.FBGNKPPMENN);
	}

	public void PCOIDKLMEAD(int FAGMOBEKJND)
	{
		KIEBDFLJCNB kIEBDFLJCNB = new KIEBDFLJCNB();
		kIEBDFLJCNB.FAGMOBEKJND = FAGMOBEKJND;
		IAPJEBKJEHC[] array = OKDFHJJNFCC.WhereF(kIEBDFLJCNB.BEKJDJFLJJC);
		if (array.Length > 0)
		{
			if (kIEBDFLJCNB.FAGMOBEKJND == IHMAHACABAJ)
			{
				ECGNIEAODDJ[kIEBDFLJCNB.FAGMOBEKJND] = (ECGNIEAODDJ[kIEBDFLJCNB.FAGMOBEKJND] + 1) % array.Length;
			}
			IHMAHACABAJ = kIEBDFLJCNB.FAGMOBEKJND;
			LKLAEDIGMIB(array[ECGNIEAODDJ[kIEBDFLJCNB.FAGMOBEKJND]].FBGNKPPMENN);
		}
	}

	public void LJFEKOLKMPF()
	{
		IAPJEBKJEHC[] array = OKDFHJJNFCC.ReverseF();
		IAPJEBKJEHC iAPJEBKJEHC = array.SkipWhile((IAPJEBKJEHC AEMBPMJMOAB) => AEMBPMJMOAB != JEPMMPCNEHO).Skip(1).Union(array)
			.FirstOrDefault((IAPJEBKJEHC AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO));
		LKLAEDIGMIB(iAPJEBKJEHC.FBGNKPPMENN);
	}

	public void LIFLOGLLGIG()
	{
		IAPJEBKJEHC iAPJEBKJEHC = OKDFHJJNFCC.SkipWhile((IAPJEBKJEHC AEMBPMJMOAB) => AEMBPMJMOAB != JEPMMPCNEHO).Skip(1).Union(OKDFHJJNFCC)
			.FirstOrDefault((IAPJEBKJEHC AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO));
		LKLAEDIGMIB(iAPJEBKJEHC.FBGNKPPMENN);
	}

	public bool LKLAEDIGMIB(int FAGMOBEKJND)
	{
		if ((BJDCCKHBENA.KAMAMHFJDGG && KAMAMHFJDGG && ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA)) || ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK))
		{
			if (this == FOGIOGKLNIP.NMGDHKIKCED)
			{
				FOGIOGKLNIP.PIOANBBCFFP.AHINLBKLFHJ = false;
			}
			if (ObscuredBool.FNIPJFGEFFD(OKDFHJJNFCC[FAGMOBEKJND].FEAMJAKLLLO) && (JEPMMPCNEHO == null || JEPMMPCNEHO.FBGNKPPMENN != FAGMOBEKJND || !ObscuredBool.FNIPJFGEFFD(PFLJOBDABPJ)))
			{
				NCHOPAEKPBK(DKPJJKBJJOA, FAGMOBEKJND);
				if ((bool)(OKDFHJJNFCC[FAGMOBEKJND] as OENJLELADOM) || (bool)(OKDFHJJNFCC[FAGMOBEKJND] as MELEBCPOMHB))
				{
					NCHOPAEKPBK(LKDPJIEAPIF, false);
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public override void BJGMKFIGEFA()
	{
		base.BJGMKFIGEFA();
		HBCEJOJNMNB(DFJGLGGOKKN, ObscuredInt.FNIPJFGEFFD(base.BHFDJDDGHKA));
		HBCEJOJNMNB(IGJOGMEONLP, ObscuredInt.FNIPJFGEFFD(base.OJMCPNOELPE), ObscuredBool.FNIPJFGEFFD(MIAIFPBNBDJ));
		HBCEJOJNMNB(DKPJJKBJJOA, JEPMMPCNEHO.FBGNKPPMENN);
		foreach (int item in NCMECMGLFOI)
		{
			HBCEJOJNMNB(ELNKLGHNLEP, OKDFHJJNFCC[item].KNAEGLBCLDL, item);
		}
	}

	public override void AILPFINEAEK()
	{
	}

	public override void OnControllerColliderHit(ControllerColliderHit CLLGNMDMPJH)
	{
		base.OnControllerColliderHit(CLLGNMDMPJH);
	}

	public override void OnPhotonSerializeView(PhotonStream IILDKLHJIDE, PhotonMessageInfo LIEKABKEJOG)
	{
		base.OnPhotonSerializeView(IILDKLHJIDE, LIEKABKEJOG);
	}

	public override void OnDestroy()
	{
		base.OnDestroy();
		GGDLLKDCJJJ();
	}

	private void GGDLLKDCJJJ()
	{
		if (!(this == FOGIOGKLNIP.NMGDHKIKCED))
		{
			return;
		}
		IAPJEBKJEHC[] oKDFHJJNFCC = FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.OKDFHJJNFCC;
		foreach (IAPJEBKJEHC iAPJEBKJEHC in oKDFHJJNFCC)
		{
			if (iAPJEBKJEHC != NKHJDNAHMPD)
			{
				iAPJEBKJEHC.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(false);
			}
			iAPJEBKJEHC.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(false);
		}
		FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.FFGDOHNIMON.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
	}

	private void IMCKIAHNAKK()
	{
		foreach (Transform item in LDFLDCLLEPN.transform)
		{
			UnityEngine.Object.Destroy(item.gameObject);
		}
		if (FOGIOGKLNIP.NMGDHKIKCED == this)
		{
			FOGIOGKLNIP.BCKENJMGBIJ(JEPMMPCNEHO.MOLNOFIHKPP);
		}
		string text = "W_" + JEPMMPCNEHO.MOLNOFIHKPP;
		BIHOCPAKHNF(text);
		Transform transform2 = JMJLEDGJIJK(text, "Weapons/", true, null, base.JNEBJLMLOLM, Vector3.zero, Quaternion.identity, true, true).transform;
		Vector3 position = transform2.position;
		Quaternion rotation = transform2.rotation;
		Vector3 localScale = transform2.localScale;
		transform2.position = LDFLDCLLEPN.position;
		transform2.rotation = LDFLDCLLEPN.rotation;
		transform2.parent = LDFLDCLLEPN;
		transform2.localPosition = position;
		transform2.localRotation = rotation;
		transform2.localScale = localScale;
		IKHBOFEIDBE = transform2.GetComponentInChildren<Renderer>();
		IKHBOFEIDBE.enabled = true;
		GJPJKPJOBGJ = transform2.transform.Find("muzzleFlash");
		MEKBDDDHJFO = ObscuredBool.FNIPJFGEFFD(false);
		if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA) || this == FOGIOGKLNIP.NMGDHKIKCED)
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.IMCKIAHNAKK(JEPMMPCNEHO);
			if (FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM[JEPMMPCNEHO.DFMAGFMJGDH.name] != null)
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Stop();
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Rewind();
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play(JEPMMPCNEHO.DFMAGFMJGDH.name);
			}
		}
	}

	public void JAIEKCDHLAA(string LGNIFJCEECH, float GHJBEEBMOKB)
	{
		base.GCNMEJLGIOE.Blend(LGNIFJCEECH, GHJBEEBMOKB, 0f);
	}

	[RPC]
	public void DDNIOKNIMBK(bool EHAPKEKPMOE)
	{
		BIHOCPAKHNF("FLashLight" + EHAPKEKPMOE);
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Flashlight);
		Behaviour[] oNLNEOGEDPC = ONLNEOGEDPC;
		foreach (Behaviour behaviour in oNLNEOGEDPC)
		{
			behaviour.enabled = EHAPKEKPMOE;
		}
	}

	[RPC]
	public override void KKLDMBHEHCE(bool PDAKFGKELOC)
	{
		base.KKLDMBHEHCE(PDAKFGKELOC);
	}

	[RPC]
	public void ENGMJKMNCCO()
	{
		KKGGFENDKKB kKGGFENDKKB = new KKGGFENDKKB();
		kKGGFENDKKB.KPHCHDHEKGH = this;
		kKGGFENDKKB.OGOEFNKMIPJ = FOGIOGKLNIP.PIOANBBCFFP.GGPOLOMIGOI.OrderBy(kKGGFENDKKB.BEKJDJFLJJC).FirstOrDefault(kKGGFENDKKB.PMBKBKJIIPO);
		if (!(kKGGFENDKKB.OGOEFNKMIPJ != null))
		{
			return;
		}
		IAPJEBKJEHC iAPJEBKJEHC = OKDFHJJNFCC[kKGGFENDKKB.OGOEFNKMIPJ.MGFENAGABOE];
		if (iAPJEBKJEHC == AKIMNDMGFMN)
		{
			if (BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.Terrorists)
			{
				return;
			}
			foreach (FDGPLHOFOEN item in FOGIOGKLNIP.PIOANBBCFFP.NPKOJPJHMOK)
			{
				item.AKIMNDMGFMN.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(false);
				item.AKIMNDMGFMN.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(false);
				item.AKIMNDMGFMN.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(0);
			}
		}
		MNAPCJGKLGE();
		if (iAPJEBKJEHC.FBGNKPPMENN != AKIMNDMGFMN.FBGNKPPMENN)
		{
			iAPJEBKJEHC.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(kKGGFENDKKB.OGOEFNKMIPJ.FPNFMBGAFDE);
		}
		else
		{
			iAPJEBKJEHC.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(1);
		}
		iAPJEBKJEHC.KNAEGLBCLDL = kKGGFENDKKB.OGOEFNKMIPJ.DECONHBIJAA;
		if (iAPJEBKJEHC.FBGNKPPMENN != AKIMNDMGFMN.FBGNKPPMENN)
		{
			IAPJEBKJEHC[] array = OKDFHJJNFCC.WhereF(kKGGFENDKKB.MBNLIBIAFEF);
			if (array.Length > 0)
			{
				if (array.AllF((IAPJEBKJEHC AEMBPMJMOAB) => !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO)))
				{
					iAPJEBKJEHC.LMJDOOEODJK.COAEAALHHGL(iAPJEBKJEHC.JJHIFNAJIBK, kKGGFENDKKB.OGOEFNKMIPJ.PLDMNFCBFDD, true);
				}
				if (array.AnyF(kKGGFENDKKB.BDCIKCEBMFB))
				{
					iAPJEBKJEHC.LMJDOOEODJK.COAEAALHHGL(iAPJEBKJEHC.JJHIFNAJIBK, kKGGFENDKKB.OGOEFNKMIPJ.PLDMNFCBFDD, true);
				}
			}
		}
		else
		{
			iAPJEBKJEHC.LMJDOOEODJK.COAEAALHHGL(iAPJEBKJEHC.JJHIFNAJIBK, kKGGFENDKKB.OGOEFNKMIPJ.PLDMNFCBFDD, true);
		}
		iAPJEBKJEHC.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
		if (FOGIOGKLNIP.LPLJMLGKCLK.DLELCCHDHCF && iAPJEBKJEHC.KOPFHECCACK == 1 && KAMAMHFJDGG)
		{
			LKLAEDIGMIB(kKGGFENDKKB.OGOEFNKMIPJ.MGFENAGABOE);
		}
		if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA))
		{
			if (iAPJEBKJEHC != AKIMNDMGFMN)
			{
				FOGIOGKLNIP.CIEBMCOJGCC.MGDLCDBFHCG(FOGIOGKLNIP.FHHPMGJCHJL("You picked up ") + iAPJEBKJEHC.name);
			}
			else
			{
				FOGIOGKLNIP.CIEBMCOJGCC.MGDLCDBFHCG(FOGIOGKLNIP.FHHPMGJCHJL("You picked up ") + iAPJEBKJEHC.name, true);
			}
		}
		FOGIOGKLNIP.PIOANBBCFFP.EFCIHNCCHPO(kKGGFENDKKB.OGOEFNKMIPJ.MKBNKANDCDB);
		kKGGFENDKKB.OGOEFNKMIPJ.ICIEDCMDJFO.GIBDBKPJOKJ();
	}

	[RPC]
	public void HGMACHLNNOK(int ALEOHHMPCOC, string JJHIFNAJIBK, int CNMKGNNGPDD, int PPLACOKDMDF, bool EEEKBBONOAJ)
	{
		HJDGKOKPOBP hJDGKOKPOBP = new HJDGKOKPOBP();
		hJDGKOKPOBP.JJHIFNAJIBK = JJHIFNAJIBK;
		IAPJEBKJEHC iAPJEBKJEHC = OKDFHJJNFCC[ALEOHHMPCOC];
		CKLJKFKKHEE = ObscuredFloat.FNIPJFGEFFD(Time.time);
		Renderer iKHBOFEIDBE = IKHBOFEIDBE;
		bool flag = false;
		int pJEBMLPJGPM = 0;
		if (EEEKBBONOAJ && KAMAMHFJDGG && !ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
		{
			if (ECEFCBMJPMD.Length > 0)
			{
				JOCAFHIONFA[] array = ECEFCBMJPMD;
				foreach (JOCAFHIONFA jOCAFHIONFA in array)
				{
					if (ObscuredBool.FNIPJFGEFFD(jOCAFHIONFA.FEAMJAKLLLO))
					{
						FOGIOGKLNIP.PIOANBBCFFP.NCHOPAEKPBK(FOGIOGKLNIP.PIOANBBCFFP.IKCJHHMPALL, jOCAFHIONFA.FBGNKPPMENN, jOCAFHIONFA.KOPFHECCACK, jOCAFHIONFA.JJHIFNAJIBK, ObscuredInt.FNIPJFGEFFD(jOCAFHIONFA.CNMKGNNGPDD), jOCAFHIONFA.LMJDOOEODJK.DJEALLIOJEO(jOCAFHIONFA.NNBDEKBINFP), false, MPCGHDNMNKN.EHOEFMPLIFB.position, MPCGHDNMNKN.EHOEFMPLIFB.rotation, MPCGHDNMNKN.EHOEFMPLIFB.TransformDirection(Vector3.forward * 5f));
					}
				}
			}
			if (ObscuredBool.FNIPJFGEFFD(AKIMNDMGFMN.FEAMJAKLLLO) && iAPJEBKJEHC != AKIMNDMGFMN)
			{
				FOGIOGKLNIP.PIOANBBCFFP.NCHOPAEKPBK(FOGIOGKLNIP.PIOANBBCFFP.IKCJHHMPALL, AKIMNDMGFMN.FBGNKPPMENN, AKIMNDMGFMN.KOPFHECCACK, hJDGKOKPOBP.JJHIFNAJIBK, 1, 0, false, MPCGHDNMNKN.EHOEFMPLIFB.position, MPCGHDNMNKN.EHOEFMPLIFB.rotation, MPCGHDNMNKN.EHOEFMPLIFB.TransformDirection(Vector3.forward * 5f));
			}
		}
		if (iKHBOFEIDBE != null && ObscuredBool.FNIPJFGEFFD(CGCEAEFHDIF))
		{
			IKHBOFEIDBE = null;
			iKHBOFEIDBE.enabled = true;
			UnityEngine.Object.Destroy(iKHBOFEIDBE);
		}
		if (!KAMAMHFJDGG || !ObscuredBool.FNIPJFGEFFD(iAPJEBKJEHC.FEAMJAKLLLO) || iAPJEBKJEHC is FFGDOHNIMON)
		{
			return;
		}
		flag = iAPJEBKJEHC.KNAEGLBCLDL;
		iAPJEBKJEHC.KNAEGLBCLDL = false;
		if (!ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK))
		{
			FOGIOGKLNIP.CIEBMCOJGCC.MGDLCDBFHCG(FOGIOGKLNIP.FHHPMGJCHJL("You dropped your ") + iAPJEBKJEHC.name);
		}
		if (!EEEKBBONOAJ)
		{
			if (OKDFHJJNFCC.CountF(hJDGKOKPOBP.BEKJDJFLJJC) == 1)
			{
				pJEBMLPJGPM = iAPJEBKJEHC.LMJDOOEODJK.DJEALLIOJEO(iAPJEBKJEHC.NNBDEKBINFP);
				iAPJEBKJEHC.LMJDOOEODJK.NKOHBFHAELH(iAPJEBKJEHC.NNBDEKBINFP, 0, true);
			}
		}
		else
		{
			pJEBMLPJGPM = iAPJEBKJEHC.LMJDOOEODJK.DJEALLIOJEO(iAPJEBKJEHC.NNBDEKBINFP);
		}
		FOGIOGKLNIP.PIOANBBCFFP.NCHOPAEKPBK(FOGIOGKLNIP.PIOANBBCFFP.IKCJHHMPALL, iAPJEBKJEHC.FBGNKPPMENN, iAPJEBKJEHC.KOPFHECCACK, iAPJEBKJEHC.JJHIFNAJIBK, ObscuredInt.FNIPJFGEFFD(iAPJEBKJEHC.CNMKGNNGPDD), pJEBMLPJGPM, flag, MPCGHDNMNKN.EHOEFMPLIFB.position, FADLGEFIJLJ.rotation, MPCGHDNMNKN.EHOEFMPLIFB.TransformDirection(Vector3.forward * 5f));
		iAPJEBKJEHC.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(false);
	}

	[RPC]
	public void POCJJHFJIJB(Vector3 ELGIKGAIIOD, Quaternion KHGAOLHJCMO, string IHBIHNDALOE)
	{
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Spray);
		if (!FOGIOGKLNIP.DGMBIMMABNO)
		{
			EGBJOABGKPM = ObscuredFloat.FNIPJFGEFFD(Time.time);
			GameObject gameObject = UnityEngine.Object.Instantiate(FOGIOGKLNIP.PIOANBBCFFP.PCAJNOLGHIG, ELGIKGAIIOD, KHGAOLHJCMO);
			gameObject.transform.parent = FOGIOGKLNIP.PIOANBBCFFP.MAOFPKAJMGO;
			gameObject.GetComponent<TextMesh>().text = IHBIHNDALOE;
			UnityEngine.Object.Destroy(gameObject, 30f);
		}
	}

	[RPC]
	public override void NLFAGMBGHII(Vector3 JOHJJGPKAON)
	{
		if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM) && BGJOMCIIFAK != null)
		{
			CGPKGIPGDLP("jump");
		}
		base.NLFAGMBGHII(JOHJJGPKAON);
	}

	[RPC]
	private void PCLJKKIFHPP(bool EHAPKEKPMOE)
	{
		ONGOOKDMGCF = ObscuredFloat.FNIPJFGEFFD(Time.time);
		PHLKCKKDLFF = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE);
	}

	[RPC]
	private void ECEENKMCMFM(bool EHAPKEKPMOE)
	{
		AILHLEALEAI = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE);
	}

	[RPC]
	internal void ONHAAOFOLAJ(bool EHAPKEKPMOE)
	{
		ONGOOKDMGCF = ObscuredFloat.FNIPJFGEFFD(Time.time);
		GEGAMONDEKC = EHAPKEKPMOE;
		AIAJBBMCIBK.Play("playerCrouch");
		if (EHAPKEKPMOE)
		{
			AIAJBBMCIBK["playerCrouch"].speed = 1f;
			AIAJBBMCIBK["playerCrouch"].time = 0f;
		}
		else
		{
			AIAJBBMCIBK["playerCrouch"].time = AIAJBBMCIBK["playerCrouch"].length;
			AIAJBBMCIBK["playerCrouch"].speed = -1f;
		}
		if (!ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM) || !ObscuredBool.FNIPJFGEFFD(JEFKKCFOHCE))
		{
			return;
		}
		foreach (string item in JEPMMPCNEHO.AIOGABFEOJB.Union(JEPMMPCNEHO.BFFNBGNAEMI))
		{
			base.GCNMEJLGIOE.Stop(item);
		}
	}

	[RPC]
	public void DKPJJKBJJOA(int FAGMOBEKJND)
	{
		PGFLBEPECEM pGFLBEPECEM = new PGFLBEPECEM();
		pGFLBEPECEM.FAGMOBEKJND = FAGMOBEKJND;
		pGFLBEPECEM.KPHCHDHEKGH = this;
		if (!ObscuredBool.FNIPJFGEFFD(JEFKKCFOHCE))
		{
			JDFKPOMKMNJ.IPBKDPKONHH(pGFLBEPECEM.BEKJDJFLJJC, pGFLBEPECEM.PMBKBKJIIPO);
		}
		else
		{
			if (!(JEPMMPCNEHO == null) && JEPMMPCNEHO.FBGNKPPMENN == pGFLBEPECEM.FAGMOBEKJND && ObscuredBool.FNIPJFGEFFD(PFLJOBDABPJ))
			{
				return;
			}
			HINDBLMPIOP = JEPMMPCNEHO;
			PFLJOBDABPJ = ObscuredBool.FNIPJFGEFFD(true);
			IAPJEBKJEHC iAPJEBKJEHC = OKDFHJJNFCC[pGFLBEPECEM.FAGMOBEKJND];
			BIHOCPAKHNF("SelectGun" + pGFLBEPECEM.FAGMOBEKJND + iAPJEBKJEHC.name);
			if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM) && base.GCNMEJLGIOE != null)
			{
				base.GCNMEJLGIOE.Stop();
			}
			IAPJEBKJEHC[] oKDFHJJNFCC = OKDFHJJNFCC;
			foreach (IAPJEBKJEHC iAPJEBKJEHC2 in oKDFHJJNFCC)
			{
				if (iAPJEBKJEHC2 != null)
				{
					iAPJEBKJEHC2.enabled = false;
				}
			}
			iAPJEBKJEHC.enabled = true;
			JEPMMPCNEHO = iAPJEBKJEHC;
			iAPJEBKJEHC.ELPILFMDIKG();
			IMCKIAHNAKK();
		}
	}

	[RPC]
	public override void PLEKGNIKPEH(int BHFDJDDGHKA, NetworkViewID JFLBOOBFAEF)
	{
		PLEKGNIKPEH(BHFDJDDGHKA, (object)JFLBOOBFAEF);
	}

	[RPC]
	public override void PLEKGNIKPEH(int BHFDJDDGHKA, PhotonViewID JFLBOOBFAEF)
	{
		PLEKGNIKPEH(BHFDJDDGHKA, (object)JFLBOOBFAEF);
	}

	protected override void PLEKGNIKPEH(int BHFDJDDGHKA, object FIOKJLLBGDI)
	{
		if ((bool)FOGIOGKLNIP.PIOANBBCFFP)
		{
			if (this == FOGIOGKLNIP.NMGDHKIKCED)
			{
				FOGIOGKLNIP.PIOANBBCFFP.IMCFHFOJDDP = UnityEngine.Random.insideUnitCircle.normalized * 1f;
			}
			base.PLEKGNIKPEH(BHFDJDDGHKA, FIOKJLLBGDI);
		}
	}

	[RPC]
	public override void DFJGLGGOKKN(int BHFDJDDGHKA)
	{
		base.DFJGLGGOKKN(BHFDJDDGHKA);
	}

	[RPC]
	public override void GBPPDCMPJBF(int BHFDJDDGHKA, NetworkViewID JFLBOOBFAEF)
	{
		GBPPDCMPJBF(BHFDJDDGHKA, (object)JFLBOOBFAEF);
	}

	[RPC]
	public override void GBPPDCMPJBF(int BHFDJDDGHKA, PhotonViewID JFLBOOBFAEF)
	{
		GBPPDCMPJBF(BHFDJDDGHKA, (object)JFLBOOBFAEF);
	}

	protected override void GBPPDCMPJBF(int BHFDJDDGHKA, object FIOKJLLBGDI)
	{
		if ((bool)FOGIOGKLNIP.PIOANBBCFFP)
		{
			if (this == FOGIOGKLNIP.NMGDHKIKCED)
			{
				FOGIOGKLNIP.PIOANBBCFFP.IMCFHFOJDDP = UnityEngine.Random.insideUnitCircle.normalized * 1f;
			}
			base.GBPPDCMPJBF(BHFDJDDGHKA, FIOKJLLBGDI);
		}
	}

	[RPC]
	public override void IGJOGMEONLP(int BHFDJDDGHKA, bool OBPBOOIPKMD)
	{
		base.IGJOGMEONLP(BHFDJDDGHKA, OBPBOOIPKMD);
	}

	public override void KNOEPICGNLK(params byte[] JPJGKBJGHOE)
	{
		if (base.KEMLHMOIFIM && JPJGKBJGHOE.Length < 2)
		{
			KIKEOPPIKNP();
		}
		base.KNOEPICGNLK(JPJGKBJGHOE);
	}

	[RPC]
	private void PINBKNKFBJC()
	{
		if (ObscuredBool.FNIPJFGEFFD(JEFKKCFOHCE))
		{
			EONGLFIGPOG = Time.time;
			AIAJBBMCIBK["jumpCustom"].layer = 2;
			AIAJBBMCIBK.Play("jumpCustom");
			LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Footsteps);
			if (ObscuredBool.FNIPJFGEFFD(base.CBBMOOPHDHM))
			{
				base.GCNMEJLGIOE["jump"].time = 0f;
				CGPKGIPGDLP("jump");
			}
			JDFKPOMKMNJ.IPBKDPKONHH(delegate
			{
				FDKEHBJBNCJ = ObscuredFloat.FNIPJFGEFFD(0f);
			});
			KPKNIABCJOC *= 1.5f;
			MEKBDDDHJFO = ObscuredBool.FNIPJFGEFFD(false);
		}
	}

	[RPC]
	protected override void ABMGCEBCICJ(byte[] JPJGKBJGHOE)
	{
		if (base.enabled)
		{
			if (JEPMMPCNEHO != FFGDOHNIMON)
			{
				HGMACHLNNOK(JEPMMPCNEHO.FBGNKPPMENN, JEPMMPCNEHO.JJHIFNAJIBK, ObscuredInt.FNIPJFGEFFD(JEPMMPCNEHO.ABHFBECBPBA), JEPMMPCNEHO.LMJDOOEODJK.DJEALLIOJEO(JEPMMPCNEHO.NNBDEKBINFP), true);
			}
			base.ABMGCEBCICJ(JPJGKBJGHOE);
		}
	}

	[RPC]
	public override void MCHAGMJPOIK(NetworkViewID BJDCCKHBENA)
	{
		base.MCHAGMJPOIK(BJDCCKHBENA);
	}

	[RPC]
	public override void MCHAGMJPOIK(PhotonViewID BJDCCKHBENA)
	{
		base.MCHAGMJPOIK(BJDCCKHBENA);
	}

	[RPC]
	public void LPNELEDEPNF()
	{
		if (KAMAMHFJDGG)
		{
			FOGIOGKLNIP.CIEBMCOJGCC.HKPPAEMPIJD.enabled = true;
		}
		if (BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists)
		{
			AKIMNDMGFMN.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(1);
		}
		FOGIOGKLNIP.PIOANBBCFFP.FNFKLBLIJAF(string.Concat(BJDCCKHBENA, FOGIOGKLNIP.FHHPMGJCHJL(" Get Bomb")));
	}

	[RPC]
	public override void KICNBMAHIEK()
	{
		base.KICNBMAHIEK();
	}

	public void KIKEOPPIKNP()
	{
		if (ObscuredBool.FNIPJFGEFFD(OPKDMODBFGA))
		{
			return;
		}
		OPKDMODBFGA = ObscuredBool.FNIPJFGEFFD(true);
		foreach (KKJBDENNKGF item in FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL)
		{
			if ((item.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 3f && item != this && !item.KEMLHMOIFIM)
			{
				item.GGNFHJCPCBK((!ObscuredBool.FNIPJFGEFFD(item.HIBLODEGHAK)) ? ((int)(-200f * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.HDGCFPAMGKE))) : (-200), BJDCCKHBENA);
			}
		}
		foreach (PMDPIINLPHK item2 in FOGIOGKLNIP.PIOANBBCFFP.HEGNCGKJMJF)
		{
			if (item2 != null && (item2.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 4f)
			{
				item2.NCHOPAEKPBK(item2.DFJGLGGOKKN, item2.BHFDJDDGHKA + (int)(-200f * ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.HDGCFPAMGKE)));
				break;
			}
		}
		NCHOPAEKPBK(CHDLHLJEAKP);
	}

	[RPC]
	private void CHDLHLJEAKP()
	{
		NANDGJBPJIA nANDGJBPJIA = new NANDGJBPJIA();
		nANDGJBPJIA.KPHCHDHEKGH = this;
		NILJAPPBFNA = BJDCCKHBENA;
		INNBPKJCELB();
		nANDGJBPJIA.ELGIKGAIIOD = base.ELGIKGAIIOD;
		FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.IPBKDPKONHH(nANDGJBPJIA.BEKJDJFLJJC);
		FOGIOGKLNIP.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Explode, nANDGJBPJIA.ELGIKGAIIOD);
	}

	[RPC]
	public override void AGKCCJFMFFO(int NDEFDFEDKFL, int MHEOBOMBCFM, int KAPIOMFEAHB)
	{
		base.AGKCCJFMFFO(NDEFDFEDKFL, MHEOBOMBCFM, KAPIOMFEAHB);
	}

	[RPC]
	public override void CDBPCIPAJHF()
	{
		base.CDBPCIPAJHF();
	}

	[RPC]
	public override void FEJDDCGBLBD(Vector3 ELGIKGAIIOD)
	{
		base.FEJDDCGBLBD(ELGIKGAIIOD);
	}

	[RPC]
	public void MNAPCJGKLGE()
	{
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Buy);
	}

	[RPC]
	public void CFFLCEEFIMJ()
	{
		NCHOPAEKPBK(IGJOGMEONLP, 100, true);
		NCHOPAEKPBK(MNAPCJGKLGE);
	}

	[RPC]
	public override void MBKMMAAMIIK()
	{
		base.MBKMMAAMIIK();
	}

	[RPC]
	public override void FAEDGHBACGA(Vector3 ELGIKGAIIOD, bool GHPHAJGLGGL)
	{
		base.FAEDGHBACGA(ELGIKGAIIOD, GHPHAJGLGGL);
	}

	[RPC]
	public void CHEOEJNGLFP(bool EHAPKEKPMOE)
	{
		JEPMMPCNEHO.CHEOEJNGLFP(EHAPKEKPMOE);
	}

	[RPC]
	public void KPMFMBAMFCF(NetworkMessageInfo LIEKABKEJOG)
	{
		KPMFMBAMFCF();
	}

	[RPC]
	public void KPMFMBAMFCF(PhotonMessageInfo LIEKABKEJOG)
	{
		if (LIEKABKEJOG.sender == EBHOPCCNJAO.owner)
		{
			KPMFMBAMFCF();
		}
	}

	public void KPMFMBAMFCF()
	{
		JEPMMPCNEHO.KPMFMBAMFCF();
	}

	[RPC]
	public void GOPIBMLFMBC(int EHAPKEKPMOE, NetworkMessageInfo LIEKABKEJOG)
	{
		GOPIBMLFMBC(EHAPKEKPMOE);
	}

	[RPC]
	public void GOPIBMLFMBC(int EHAPKEKPMOE, PhotonMessageInfo LIEKABKEJOG)
	{
		if (LIEKABKEJOG.sender == EBHOPCCNJAO.owner)
		{
			GOPIBMLFMBC(EHAPKEKPMOE);
		}
	}

	public void GOPIBMLFMBC(int EHAPKEKPMOE)
	{
		JEPMMPCNEHO.GOPIBMLFMBC(EHAPKEKPMOE);
	}

	[RPC]
	public void ELNKLGHNLEP(bool JFLFLCDEEEI, int MKBNKANDCDB, NetworkMessageInfo LIEKABKEJOG)
	{
		ELNKLGHNLEP(JFLFLCDEEEI, MKBNKANDCDB);
	}

	[RPC]
	public void ELNKLGHNLEP(bool JFLFLCDEEEI, int MKBNKANDCDB, PhotonMessageInfo LIEKABKEJOG)
	{
		if (LIEKABKEJOG.sender == EBHOPCCNJAO.owner)
		{
			ELNKLGHNLEP(JFLFLCDEEEI, MKBNKANDCDB);
		}
	}

	public void ELNKLGHNLEP(bool JFLFLCDEEEI, int MKBNKANDCDB)
	{
		OKDFHJJNFCC[MKBNKANDCDB].ELNKLGHNLEP(JFLFLCDEEEI);
		NKHHFJLNLGG.enabled = !JFLFLCDEEEI;
		NIMEIBAGPMO.enabled = !JFLFLCDEEEI;
		if (!NCMECMGLFOI.Contains(OKDFHJJNFCC[MKBNKANDCDB].FBGNKPPMENN))
		{
			NCMECMGLFOI.Add(OKDFHJJNFCC[MKBNKANDCDB].FBGNKPPMENN);
		}
	}

	[RPC]
	public void EPADPNIJNNJ(NetworkMessageInfo LIEKABKEJOG)
	{
		EPADPNIJNNJ();
	}

	[RPC]
	public void EPADPNIJNNJ(PhotonMessageInfo LIEKABKEJOG)
	{
		if (LIEKABKEJOG.sender == EBHOPCCNJAO.owner)
		{
			EPADPNIJNNJ();
		}
	}

	public void EPADPNIJNNJ()
	{
		JEPMMPCNEHO.EPADPNIJNNJ();
	}

	[RPC]
	public void LKDPJIEAPIF(bool FFBEPGEKANM, NetworkMessageInfo LIEKABKEJOG)
	{
		LKDPJIEAPIF(FFBEPGEKANM);
	}

	[RPC]
	public void LKDPJIEAPIF(bool FFBEPGEKANM, PhotonMessageInfo LIEKABKEJOG)
	{
		if (LIEKABKEJOG.sender == EBHOPCCNJAO.owner)
		{
			LKDPJIEAPIF(FFBEPGEKANM);
		}
	}

	public void LKDPJIEAPIF(bool FFBEPGEKANM)
	{
		JEPMMPCNEHO.LKDPJIEAPIF(FFBEPGEKANM);
	}

	[RPC]
	public void DONIMNAJJIB()
	{
		JEPMMPCNEHO.DONIMNAJJIB();
	}

	[RPC]
	public void PCLEFKOPNCJ()
	{
		JEPMMPCNEHO.PCLEFKOPNCJ();
	}

	[RPC]
	public void ODMGBBKGLOD()
	{
		JEPMMPCNEHO.ODMGBBKGLOD();
	}

	[CompilerGenerated]
	private bool JDGOKBJLEBB()
	{
		return BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.Spectators;
	}

	[CompilerGenerated]
	private void CGHOOLFHOMD()
	{
		bool flag = ObscuredInt.FNIPJFGEFFD(BJDCCKHBENA.JCMCPIPHDHB) >= 500 && ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK);
		if (ObscuredBool.FNIPJFGEFFD(base.HIBLODEGHAK) && base.NENPALDENAL)
		{
			IAPJEBKJEHC[] oKDFHJJNFCC = OKDFHJJNFCC;
			foreach (IAPJEBKJEHC iAPJEBKJEHC in oKDFHJJNFCC)
			{
				iAPJEBKJEHC.LMJDOOEODJK.NKOHBFHAELH(iAPJEBKJEHC.NNBDEKBINFP, iAPJEBKJEHC.LMJDOOEODJK.DJEALLIOJEO(iAPJEBKJEHC.NNBDEKBINFP, true), true);
				iAPJEBKJEHC.CNMKGNNGPDD = iAPJEBKJEHC.ABHFBECBPBA;
			}
		}
		if (FOGIOGKLNIP.NMGDHKIKCED == this)
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.NJEPMOIDJKH = this;
		}
		KKNBDBLKNAN();
		if (KAMAMHFJDGG || (ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK) && base.NENPALDENAL && !BJDCCKHBENA.ALHNDNFFBIB))
		{
			if ((FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG != null && !FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.DisableWeapons) || FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG == null)
			{
				if (flag)
				{
					NLDNFOCDHMN(OKDFHJJNFCC.WhereF((IAPJEBKJEHC DCNNOFJHEMD) => DCNNOFJHEMD.KOPFHECCACK == 2 && ((DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.AEBKICLHBHG && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists) || (DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.HJFDEGMFGDP && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) || DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.DMELFHOKGBG)).Random().FBGNKPPMENN);
					NLDNFOCDHMN(OKDFHJJNFCC.WhereF((IAPJEBKJEHC DCNNOFJHEMD) => DCNNOFJHEMD.KOPFHECCACK == 1 && ((DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.AEBKICLHBHG && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists) || (DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.HJFDEGMFGDP && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) || DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.DMELFHOKGBG)).Random().FBGNKPPMENN);
				}
				if (!flag)
				{
					if (BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists)
					{
						if (!ObscuredBool.FNIPJFGEFFD(NKHJDNAHMPD.HPFPFCNOKAM))
						{
							NKHJDNAHMPD.LMJDOOEODJK.NKOHBFHAELH(NKHJDNAHMPD.NNBDEKBINFP, NKHJDNAHMPD.LMJDOOEODJK.DJEALLIOJEO(NKHJDNAHMPD.NNBDEKBINFP, true), true);
							NKHJDNAHMPD.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
							NKHJDNAHMPD.CNMKGNNGPDD = NKHJDNAHMPD.ABHFBECBPBA;
							LKLAEDIGMIB(NKHJDNAHMPD.FBGNKPPMENN);
							NKHJDNAHMPD.CNMKGNNGPDD = NKHJDNAHMPD.ABHFBECBPBA;
						}
						else
						{
							LIFLOGLLGIG();
						}
					}
					if (BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists)
					{
						if (!ObscuredBool.FNIPJFGEFFD(HCLAICPNOCN.HPFPFCNOKAM))
						{
							HCLAICPNOCN.LMJDOOEODJK.NKOHBFHAELH(HCLAICPNOCN.NNBDEKBINFP, HCLAICPNOCN.LMJDOOEODJK.DJEALLIOJEO(HCLAICPNOCN.NNBDEKBINFP, true), true);
							HCLAICPNOCN.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
							HCLAICPNOCN.CNMKGNNGPDD = HCLAICPNOCN.ABHFBECBPBA;
							LKLAEDIGMIB(HCLAICPNOCN.FBGNKPPMENN);
							HCLAICPNOCN.CNMKGNNGPDD = HCLAICPNOCN.ABHFBECBPBA;
						}
						else
						{
							LIFLOGLLGIG();
						}
					}
				}
			}
			else if (FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG != null && FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.DisableWeapons)
			{
				BCDAEBOFDPG bCDAEBOFDPG = new BCDAEBOFDPG
				{
					KPHCHDHEKGH = this,
					FAGMOBEKJND = 0
				};
				while (bCDAEBOFDPG.FAGMOBEKJND < OKDFHJJNFCC.Length)
				{
					if (FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.SpawnWeapons.AnyF(bCDAEBOFDPG.BEKJDJFLJJC))
					{
						WeaponManager.WeaponSpawn weaponSpawn = FOGIOGKLNIP.PIOANBBCFFP.OCNLLGCCFAG.SpawnWeapons.WhereF(bCDAEBOFDPG.PMBKBKJIIPO).FirstOrDefaultF();
						if (FOGIOGKLNIP.LMMFHEODOPM.FCFBGBPEPOL)
						{
							Debug.LogError(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].LKECMBJJLPJ);
						}
						if (ObscuredBool.FNIPJFGEFFD(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].HPFPFCNOKAM))
						{
							OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].HPFPFCNOKAM = ObscuredBool.FNIPJFGEFFD(false);
						}
						OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(weaponSpawn.Ammo);
						OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].LMJDOOEODJK.NKOHBFHAELH(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].NNBDEKBINFP, weaponSpawn.Clips, true);
						OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(true);
						if (!ObscuredBool.FNIPJFGEFFD(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].HPFPFCNOKAM))
						{
							LKLAEDIGMIB(OKDFHJJNFCC[bCDAEBOFDPG.FAGMOBEKJND].FBGNKPPMENN);
						}
					}
					bCDAEBOFDPG.FAGMOBEKJND++;
				}
			}
		}
		if (ObscuredBool.FNIPJFGEFFD(IIPDOGECCPA) && FOGIOGKLNIP.NGFDFPGNDCJ.NMJOJEDEJBO != null)
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play(JEPMMPCNEHO.DFMAGFMJGDH.name);
		}
		if (FOGIOGKLNIP.NMGDHKIKCED == this && FOGIOGKLNIP.LBJBBGEDGJF.CCLDHNLJLAC && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.DIMHBBEFMDK))
		{
			FOGIOGKLNIP.LBJBBGEDGJF.NCOPODKFALG();
		}
	}

	[CompilerGenerated]
	private static bool MBLBBKNIDKC(Transform AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.tag == "Head";
	}

	[CompilerGenerated]
	private static bool BBIPEACAAIE(Transform AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.tag == "Spine";
	}

	[CompilerGenerated]
	private static bool FBGDMDNNHBC(Transform AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.tag == "GunPlaceHolder";
	}

	[CompilerGenerated]
	private static IEnumerable<string> JJGOOGFCCOK(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.AIOGABFEOJB;
	}

	[CompilerGenerated]
	private static IEnumerable<string> DEIJKMPGJEM(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BFFNBGNAEMI;
	}

	[CompilerGenerated]
	private static string PEICJCNEONE(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.AIOGABFEOJB[5];
	}

	[CompilerGenerated]
	private static string OKCGNMDIBBK(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BFFNBGNAEMI[5];
	}

	[CompilerGenerated]
	private static string JLDPJHEGMGI(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.MEGEODGDDAH + "reload";
	}

	[CompilerGenerated]
	private bool BGONPBFDGGF(EJDKALEIBBG AEMBPMJMOAB)
	{
		return CPINPFLEJFF(AEMBPMJMOAB.CMPKOEMBHDO) && (AEMBPMJMOAB.MGFENAGABOE != AKIMNDMGFMN.FBGNKPPMENN || BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) && (AEMBPMJMOAB.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 1f && Time.time - AEMBPMJMOAB.KMLPDIHOPNC > 0.5f;
	}

	[CompilerGenerated]
	private bool EFHFAIADHBO(MKAFHPMKFEO AEMBPMJMOAB)
	{
		return (base.ELGIKGAIIOD - AEMBPMJMOAB.ELGIKGAIIOD).magnitude < 1f;
	}

	[CompilerGenerated]
	private static bool KHEJNABJOJO(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.KAMAMHFJDGG;
	}

	[CompilerGenerated]
	private static bool MOFJDEBJFFM(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.KAMAMHFJDGG;
	}

	[CompilerGenerated]
	private bool NMNDFIOCBNH(NFHGOIHFOBD AEMBPMJMOAB)
	{
		return (AEMBPMJMOAB.ELGIKGAIIOD - base.ELGIKGAIIOD).magnitude < 1f;
	}

	[CompilerGenerated]
	private static bool IFLAHJBCOPE(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO) && !(AEMBPMJMOAB is JOCAFHIONFA);
	}

	[CompilerGenerated]
	private bool MLBBFGLFDCI(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return AEMBPMJMOAB != JEPMMPCNEHO;
	}

	[CompilerGenerated]
	private static bool OKAKKCLBEHP(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO);
	}

	[CompilerGenerated]
	private bool KJMBGIKPPOI(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return AEMBPMJMOAB != JEPMMPCNEHO;
	}

	[CompilerGenerated]
	private static bool NGKMELCLGLL(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO);
	}

	[CompilerGenerated]
	private static bool FKDBNADFIHK(IAPJEBKJEHC AEMBPMJMOAB)
	{
		return !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.FEAMJAKLLLO);
	}

	[CompilerGenerated]
	private void CBOAKEMBLKD()
	{
		FDKEHBJBNCJ = ObscuredFloat.FNIPJFGEFFD(0f);
	}

	[CompilerGenerated]
	private bool HIKCBJEMDCE(IAPJEBKJEHC DCNNOFJHEMD)
	{
		return DCNNOFJHEMD.KOPFHECCACK == 2 && ((DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.AEBKICLHBHG && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists) || (DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.HJFDEGMFGDP && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) || DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.DMELFHOKGBG);
	}

	[CompilerGenerated]
	private bool KFHCOGJABJE(IAPJEBKJEHC DCNNOFJHEMD)
	{
		return DCNNOFJHEMD.KOPFHECCACK == 1 && ((DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.AEBKICLHBHG && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists) || (DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.HJFDEGMFGDP && BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) || DCNNOFJHEMD.KJPPJJDLFJH == FBKBAJFPLNK.DMELFHOKGBG);
	}
}
