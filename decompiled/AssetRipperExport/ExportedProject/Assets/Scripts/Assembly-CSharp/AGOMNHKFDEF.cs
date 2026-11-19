using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Beebyte.Obfuscator;
using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using SPD.Audio;
using SPD.Triggers;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

[DoNotFake]
public class AGOMNHKFDEF : FOGIOGKLNIP
{
	public enum CEDODJHAKAE
	{
		NMKCAJOKCGP = 0,
		GILDEHKBOFP = 1,
		BMDPCDNFOGN = 2
	}

	private sealed class FDLIMJFOCLE : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal SpawnPlayer[] NCFOKGJPDLA;

		internal int DJKGPDKHMFK;

		internal WeaponMap[] PKBOBPNPFJO;

		internal int OENFJDHMGCK;

		internal NavMeshPath EGAGBGMDNLJ;

		internal GameObject[] BNMKDCLIEKG;

		internal int PKKCECEFDCE;

		internal GameObject[] NOGEPIOBEGH;

		internal int DJECEBPPIIB;

		internal AGOMNHKFDEF KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public FDLIMJFOCLE()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (!FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ)
				{
					try
					{
						FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ = FOGIOGKLNIP.OKJJJBOEGBJ.ICKGAFPAEEI("soundsbank", string.Empty).LoadAsset<GameSoundsObject>("GameSoundsObject");
					}
					catch (Exception)
					{
						FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ = new GameSoundsObject
						{
							WeaponActionDistance = new BankEntry[35],
							WeaponAction = new BankEntry[35],
							WeaponActionSilencerDistance = new BankEntry[35],
							WeaponSilencerAction = new BankEntry[35],
							GrenadeExplosion = new BankEntry[35],
							GrenadeHit = new BankEntry[35]
						};
					}
				}
				KPHCHDHEKGH.CNOBPBGPHGJ = ObscuredFloat.FNIPJFGEFFD(Time.time);
				if (!FOGIOGKLNIP.OMMLFOEPEEK)
				{
					LAOFKFBJDGJ.NKPNJDBLBAI = 0;
				}
				if (!FOGIOGKLNIP.LPLJMLGKCLK.IGPPHPINEOI)
				{
					if (FOGIOGKLNIP.LPLJMLGKCLK.PBPPMJLAODE && !FOGIOGKLNIP.LPLJMLGKCLK.IGPPHPINEOI)
					{
						KPHCHDHEKGH.JNPCOJFBJGP = true;
					}
					if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
					{
						if (Network.InitializeServer(10, (!KPHCHDHEKGH.JNPCOJFBJGP) ? 53003 : UnityEngine.Random.Range(5600, 6000), false) != NetworkConnectionError.NoError)
						{
							Network.Connect("127.0.0.1", 53003);
						}
					}
					else if (FOGIOGKLNIP.LMMFHEODOPM.MHOHCMOOGCC)
					{
						PhotonNetwork.Connect("127.0.0.1", 5055, string.Empty);
					}
					else
					{
						PhotonNetwork.ConnectUsingSettings();
					}
				}
				if (FOGIOGKLNIP.DGMBIMMABNO)
				{
					KPHCHDHEKGH.HDOGJKGOEIG(KPHCHDHEKGH.OIEPGDHAPAF, 0.01f);
				}
				Time.fixedDeltaTime = ((!FOGIOGKLNIP.DGMBIMMABNO) ? 0.02f : 0.04f);
				KPHCHDHEKGH.DALNPKPJAJF = true;
				KPHCHDHEKGH.LAAEJKMCKOI = ObscuredFloat.FNIPJFGEFFD(Time.time);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.JGEBCFFCMOE);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.DPBNFCAFBJJ, IKGLMHJAOGB.FDGPLHOFOEN, IKGLMHJAOGB.OLILBNAJMLF, IKGLMHJAOGB.HAMELIKHGAD);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.NAPMLJEALGJ, IKGLMHJAOGB.FDGPLHOFOEN, IKGLMHJAOGB.OLILBNAJMLF, IKGLMHJAOGB.HAMELIKHGAD);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.GHJDANHHDGM, IKGLMHJAOGB.OLILBNAJMLF);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.KAHHJBGMHFJ);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.EJDKALEIBBG, IKGLMHJAOGB.JOIJIECIMOH, IKGLMHJAOGB.BEMALDLIIMN, IKGLMHJAOGB.DOBKBGBKAJA, IKGLMHJAOGB.PMDPIINLPHK, IKGLMHJAOGB.IJHPNPNGELB, IKGLMHJAOGB.IDMHMEJKMOD, IKGLMHJAOGB.KICDEDELOID);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.OLILBNAJMLF, IKGLMHJAOGB.JOIJIECIMOH, IKGLMHJAOGB.BEMALDLIIMN, IKGLMHJAOGB.DOBKBGBKAJA, IKGLMHJAOGB.PMDPIINLPHK, IKGLMHJAOGB.IJHPNPNGELB, IKGLMHJAOGB.IDMHMEJKMOD, IKGLMHJAOGB.KICDEDELOID, IKGLMHJAOGB.NAPMLJEALGJ, IKGLMHJAOGB.DPBNFCAFBJJ, IKGLMHJAOGB.GHJDANHHDGM);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.HAMELIKHGAD, IKGLMHJAOGB.FDGPLHOFOEN, IKGLMHJAOGB.BEMALDLIIMN, IKGLMHJAOGB.DOBKBGBKAJA, IKGLMHJAOGB.PMDPIINLPHK);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.LNMFDCDMLIH, IKGLMHJAOGB.JOIJIECIMOH, IKGLMHJAOGB.GKKILNGKDCO);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.FCCOEKPPJBM, IKGLMHJAOGB.JOIJIECIMOH, IKGLMHJAOGB.BEMALDLIIMN, IKGLMHJAOGB.GKKILNGKDCO);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.MIAFMOABFCA, IKGLMHJAOGB.JOIJIECIMOH, IKGLMHJAOGB.MIAFMOABFCA, IKGLMHJAOGB.GKKILNGKDCO, IKGLMHJAOGB.PMDPIINLPHK, IKGLMHJAOGB.BEMALDLIIMN);
				IGPGFFNKCFO.GOHMBNENIIK(IKGLMHJAOGB.JOCAFHIONFA, IKGLMHJAOGB.JOIJIECIMOH, IKGLMHJAOGB.BEMALDLIIMN, IKGLMHJAOGB.DOBKBGBKAJA, IKGLMHJAOGB.PMDPIINLPHK, IKGLMHJAOGB.KAHHJBGMHFJ);
				KPHCHDHEKGH.LFCAGNKGGII = ObscuredFloat.FNIPJFGEFFD(Time.time);
				if (!FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
				{
					if (KPHCHDHEKGH.JNPCOJFBJGP && PhotonNetwork.room == null)
					{
						PhotonNetwork.CreateRoom("Test" + FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP, false, true, 10);
					}
					if ((!PhotonNetwork.isMasterClient && PhotonNetwork.room != null) || KPHCHDHEKGH.JNPCOJFBJGP)
					{
						KPHCHDHEKGH.KDANBJBIGKL();
					}
				}
				else if (FOGIOGKLNIP.LPLJMLGKCLK.IGPPHPINEOI)
				{
					KPHCHDHEKGH.KDANBJBIGKL();
				}
				if (KPHCHDHEKGH.MFNKJMBHMGE.Length >= 1)
				{
					SpawnPlayer[] mFNKJMBHMGE = KPHCHDHEKGH.MFNKJMBHMGE;
					foreach (SpawnPlayer th in mFNKJMBHMGE)
					{
						th.SetActive(false);
					}
				}
				NCFOKGJPDLA = KPHCHDHEKGH.FFECBELHGGD;
				for (DJKGPDKHMFK = 0; DJKGPDKHMFK < NCFOKGJPDLA.Length; DJKGPDKHMFK++)
				{
					SpawnPlayer th2 = NCFOKGJPDLA[DJKGPDKHMFK];
					th2.SetActive(false);
				}
				PKBOBPNPFJO = KPHCHDHEKGH.MGFGBMCEDPK;
				for (OENFJDHMGCK = 0; OENFJDHMGCK < PKBOBPNPFJO.Length; OENFJDHMGCK++)
				{
					WeaponMap th3 = PKBOBPNPFJO[OENFJDHMGCK];
					th3.SetActive(false);
				}
				EGAGBGMDNLJ = new NavMeshPath();
				KPHCHDHEKGH.HJPPJJCHGJA = NavMesh.CalculatePath(KPHCHDHEKGH.LNPHCAOCEBD.position, KPHCHDHEKGH.LOCHJEFJLJG.position, 1, EGAGBGMDNLJ);
				BNMKDCLIEKG = GameObject.FindGameObjectsWithTag(KPHCHDHEKGH.IOCECFNAKJM.IHFNGBBCNLK);
				for (PKKCECEFDCE = 0; PKKCECEFDCE < BNMKDCLIEKG.Length; PKKCECEFDCE++)
				{
					GameObject gameObject = BNMKDCLIEKG[PKKCECEFDCE];
					gameObject.SetActive(false);
				}
				if (FOGIOGKLNIP.OMMLFOEPEEK)
				{
					NOGEPIOBEGH = GameObject.FindGameObjectsWithTag(KPHCHDHEKGH.IOCECFNAKJM.CDIBGPMNOMK);
					for (DJECEBPPIIB = 0; DJECEBPPIIB < NOGEPIOBEGH.Length; DJECEBPPIIB++)
					{
						GameObject gameObject2 = NOGEPIOBEGH[DJECEBPPIIB];
						gameObject2.SetActive(false);
					}
				}
				if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && Network.isServer)
				{
					Network.sendRate = 5f;
				}
				FOGIOGKLNIP.LPLJMLGKCLK.CODBKMAMEHL.enabled = false;
				KPHCHDHEKGH.HIEMIKLIBKC(FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD);
				if (KPHCHDHEKGH.NENPALDENAL)
				{
					KPHCHDHEKGH.EIFOECIOEAA((int)FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD);
				}
				if (KPHCHDHEKGH.NENPALDENAL && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI))
				{
					KPHCHDHEKGH.CKAJCPDFAGC = ObscuredBool.FNIPJFGEFFD(true);
				}
				if (!FOGIOGKLNIP.OMMLFOEPEEK)
				{
					KPHCHDHEKGH.JDFKPOMKMNJ.IPBKDPKONHH(10000, KPHCHDHEKGH.MPIPEKNIJAE);
					KPHCHDHEKGH.JDFKPOMKMNJ.IPBKDPKONHH(40000, KPHCHDHEKGH.MPIPEKNIJAE);
					KPHCHDHEKGH.JDFKPOMKMNJ.IPBKDPKONHH(80000, KPHCHDHEKGH.MPIPEKNIJAE);
				}
				if (FOGIOGKLNIP.BEHFNEAKDAL.MAODHFCONKO.IHCCAJJIBEL)
				{
					FOGIOGKLNIP.BEHFNEAKDAL.MAODHFCONKO.DJDFDKAKJJA(true);
				}
				if (FOGIOGKLNIP.LPLJMLGKCLK.NEJPKFAKOGO.StartsWith(KPHCHDHEKGH.BHCIEFHBOPB.http) && !FOGIOGKLNIP.LPLJMLGKCLK.PKLNHOEOKBH.ContainsF(FOGIOGKLNIP.LPLJMLGKCLK.NEJPKFAKOGO))
				{
					FOGIOGKLNIP.LPLJMLGKCLK.PKLNHOEOKBH.Add(FOGIOGKLNIP.LPLJMLGKCLK.NEJPKFAKOGO);
					FOGIOGKLNIP.GKKEPIMNFBB("mapsdled2", string.Join("|", FOGIOGKLNIP.LPLJMLGKCLK.PKLNHOEOKBH.ToArray()));
				}
				KPHCHDHEKGH.FNFKLBLIJAF(FOGIOGKLNIP.FHHPMGJCHJL(KPHCHDHEKGH.FKICDOGJIFN.PressF12ToFullScreen));
				KPHCHDHEKGH.MAMAPLADEGN.text = FOGIOGKLNIP.FHHPMGJCHJL("Server") + ": " + FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO.Split('|')[2];
				KPHCHDHEKGH.APPCFEMMMLD.text = FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD.ToString() + " | " + FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF);
				HLJEEFIJCOF = null;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				GNNOELAJGPI = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class GCIOFFGBEEE
	{
		internal JDILMODHLOJ CEOMHNKEIBA;

		internal AGOMNHKFDEF KPHCHDHEKGH;

		internal void BEKJDJFLJJC(GNMHJEPNHDL ANKEMNJGLPD)
		{
			IBOGNCENEHO iBOGNCENEHO = KPHCHDHEKGH.BMCNOHJAECG();
			if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO && CEOMHNKEIBA.AEOCLPGEFEP == 0)
			{
				KPHCHDHEKGH.DMAILAJDJLD((int)iBOGNCENEHO, (int)ANKEMNJGLPD);
				return;
			}
			KPHCHDHEKGH.PNIJFLNFOPM("DMAILAJDJLD", CEOMHNKEIBA.PDCFBMJNOBO, (int)iBOGNCENEHO, (int)ANKEMNJGLPD);
		}
	}

	private sealed class AEJIOHJLOGE
	{
		private sealed class INDKAHKPEKF
		{
			internal SpawnPlayer AEMBPMJMOAB;

			internal AEJIOHJLOGE AOMKLBLNPEJ;

			internal float BEKJDJFLJJC(KKJBDENNKGF LCBKHLLPIGM)
			{
				return (AEMBPMJMOAB.transform.position - LCBKHLLPIGM.EHOEFMPLIFB.position).magnitude;
			}
		}

		internal GNMHJEPNHDL JGECOECAJLK;

		internal List<KKJBDENNKGF> MMPHADBLLCL;

		internal bool BEKJDJFLJJC(KKJBDENNKGF LCBKHLLPIGM)
		{
			return (LCBKHLLPIGM != null && LCBKHLLPIGM.BJDCCKHBENA.JGECOECAJLK != JGECOECAJLK) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE);
		}

		internal float PMBKBKJIIPO(SpawnPlayer AEMBPMJMOAB)
		{
			INDKAHKPEKF iNDKAHKPEKF = new INDKAHKPEKF();
			iNDKAHKPEKF.AOMKLBLNPEJ = this;
			iNDKAHKPEKF.AEMBPMJMOAB = AEMBPMJMOAB;
			return MMPHADBLLCL.MinF((Func<KKJBDENNKGF, float>)iNDKAHKPEKF.BEKJDJFLJJC);
		}
	}

	private sealed class MHLLKMGDEIK
	{
		private sealed class EFFMFHOAEIC
		{
			internal GameObject AEMBPMJMOAB;

			internal MHLLKMGDEIK DNBMGNLNCGC;

			internal float BEKJDJFLJJC(KKJBDENNKGF LCBKHLLPIGM)
			{
				return (AEMBPMJMOAB.transform.position - LCBKHLLPIGM.EHOEFMPLIFB.position).magnitude;
			}
		}

		internal GNMHJEPNHDL JGECOECAJLK;

		internal List<KKJBDENNKGF> MMPHADBLLCL;

		internal bool BEKJDJFLJJC(KKJBDENNKGF LCBKHLLPIGM)
		{
			return (LCBKHLLPIGM != null && LCBKHLLPIGM.BJDCCKHBENA.JGECOECAJLK != JGECOECAJLK) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE);
		}

		internal float PMBKBKJIIPO(GameObject AEMBPMJMOAB)
		{
			EFFMFHOAEIC eFFMFHOAEIC = new EFFMFHOAEIC();
			eFFMFHOAEIC.DNBMGNLNCGC = this;
			eFFMFHOAEIC.AEMBPMJMOAB = AEMBPMJMOAB;
			return MMPHADBLLCL.MinF((Func<KKJBDENNKGF, float>)eFFMFHOAEIC.BEKJDJFLJJC);
		}
	}

	private sealed class NEEJKACNENE
	{
		internal GNMHJEPNHDL JGECOECAJLK;

		internal IBOGNCENEHO EBMKGCIKJCA;

		internal bool BEKJDJFLJJC(JDILMODHLOJ AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.JGECOECAJLK == JGECOECAJLK && AEMBPMJMOAB.GHKPKNMDMLH == EBMKGCIKJCA && ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK);
		}
	}

	private sealed class KEJDEGEGEAN
	{
		internal FOGIOGKLNIP JLOJONMILIC;

		internal bool BEKJDJFLJJC(UnityEngine.Object LCBKHLLPIGM)
		{
			return LCBKHLLPIGM.name == JLOJONMILIC.name;
		}
	}

	private sealed class DMMBEDDNICB : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal AGOMNHKFDEF KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public DMMBEDDNICB()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				HLJEEFIJCOF = new WaitForEndOfFrame();
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				if (KPHCHDHEKGH.OBEFEIJNPDC != null)
				{
					KPHCHDHEKGH.OBEFEIJNPDC.verticalNormalizedPosition = 0f;
				}
				GNNOELAJGPI = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class JJAKDKLFLBP
	{
		internal GameObject AIONOHFEACL;

		internal GameObject JLJDFJNDELM;

		internal bool BEKJDJFLJJC(GameObject AEMBPMJMOAB)
		{
			Transform transform = AIONOHFEACL.transform;
			AEMBPMJMOAB.transform.root.parent = transform;
			return transform;
		}

		internal bool PMBKBKJIIPO(GameObject AEMBPMJMOAB)
		{
			Transform transform = JLJDFJNDELM.transform;
			AEMBPMJMOAB.transform.root.parent = transform;
			return transform;
		}
	}

	private sealed class LBPBHBHEAPH
	{
		internal FOGIOGKLNIP AEMBPMJMOAB;

		internal bool BEKJDJFLJJC(string LCBKHLLPIGM)
		{
			return LCBKHLLPIGM != (AEMBPMJMOAB as IAPJEBKJEHC).LKECMBJJLPJ;
		}

		internal bool PMBKBKJIIPO(string LCBKHLLPIGM)
		{
			return LCBKHLLPIGM == (AEMBPMJMOAB as IAPJEBKJEHC).LKECMBJJLPJ;
		}
	}

	private sealed class LIECKMIAEPF
	{
		internal int FAGMOBEKJND;

		internal AGOMNHKFDEF KPHCHDHEKGH;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.LKECMBJJLPJ == KPHCHDHEKGH.MGFGBMCEDPK[FAGMOBEKJND].Name;
		}
	}

	private sealed class PPIEIFOCBNE
	{
		internal WeaponDropSpecial OHOOBEOCEGP;

		internal LIECKMIAEPF FIJHLFDMHJB;

		internal bool BEKJDJFLJJC(IAPJEBKJEHC AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.LKECMBJJLPJ == OHOOBEOCEGP.Name;
		}
	}

	public bool NBLJJDANCFG;

	public GameSciptObject NBPDCMKLKJM;

	[Field(name = "AutoShoot", dependsOn = new string[] { "Android" })]
	public ObscuredBool OPNFEFFBODL;

	[Field(name = "Enable Run", customOnly = true)]
	public ObscuredBool IJDOMLPACPA;

	[Field(name = "Enable tesla zombies", gameType = new IMCJHBIFEAK[]
	{
		IMCJHBIFEAK.Survival,
		IMCJHBIFEAK.ECACNDFNADN,
		IMCJHBIFEAK.ZombieMode
	})]
	public ObscuredBool KJHFLGPLMFF;

	[Field(name = "Enable Barricades", customOnly = true, gameType = new IMCJHBIFEAK[] { IMCJHBIFEAK.Survival })]
	public ObscuredBool DEOBCKBAIPA;

	[Field(name = "Next Round Remove Zombies", gameType = new IMCJHBIFEAK[] { IMCJHBIFEAK.Survival })]
	public ObscuredBool FCFAGFGCEOK;

	[Field(name = "SpaceModNoGravity (No Gravity)", customOnly = true)]
	private ObscuredBool LBMMMABCGDE;

	[Field(name = "Can Buy Weapons Any Time")]
	public ObscuredBool CFGAEDNCMJP;

	[Field(name = "Can spectate only own team")]
	public ObscuredBool DMAICBDPFKC;

	[Field(name = "Friendly Fire")]
	public ObscuredBool MGDGJKCGHII;

	[Field(name = "Slower bullet speed")]
	public ObscuredBool FGEGAEBIMID;

	[Field(name = "prepare 5 seconds", gameType = new IMCJHBIFEAK[] { IMCJHBIFEAK.Classic })]
	public ObscuredBool CGFPIMCKBNH = ObscuredBool.FNIPJFGEFFD(true);

	[Field(name = "Auto Shoot Starts In", dependsOn = new string[] { "Android", "AutoShoot" }, min = 0f, max = 1f)]
	public ObscuredFloat JHAAFBPEKNJ = ObscuredFloat.FNIPJFGEFFD(0.3f);

	[Field(name = "zombies fireball Speed", dependsOn = new string[] { "enableShootingZombies" }, gameType = new IMCJHBIFEAK[]
	{
		IMCJHBIFEAK.Survival,
		IMCJHBIFEAK.ECACNDFNADN,
		IMCJHBIFEAK.ZombieMode
	}, min = 3f, max = 20f)]
	public ObscuredFloat NGCBELPNJKJ = ObscuredFloat.FNIPJFGEFFD(10f);

	[Field(name = "Spawn Interval", tdmOnly = true, min = 1f, max = 20f)]
	public ObscuredFloat LJNIGMCOFGC = ObscuredFloat.FNIPJFGEFFD(8f);

	[Field(name = "bullet speed", min = 10f, max = 330f, customOnly = true, dependsOn = new string[] { "delayedBullets" })]
	public ObscuredFloat IIMBKIJMFNB = ObscuredFloat.FNIPJFGEFFD(100f);

	[Field(name = "Zombie Damage", gameType = new IMCJHBIFEAK[]
	{
		IMCJHBIFEAK.ZombieMode,
		IMCJHBIFEAK.Survival,
		IMCJHBIFEAK.ECACNDFNADN
	}, min = 50f, max = 800f)]
	public ObscuredFloat IHCDJPIJMGE = ObscuredFloat.FNIPJFGEFFD(100f);

	[Field(name = "zombies Shooting Interval", gameType = new IMCJHBIFEAK[]
	{
		IMCJHBIFEAK.Survival,
		IMCJHBIFEAK.ECACNDFNADN,
		IMCJHBIFEAK.ZombieMode
	}, min = 3f, max = 20f)]
	public ObscuredInt FNLJEMBMLHN = ObscuredInt.FNIPJFGEFFD(3);

	[Field(name = "BaricadeLife", min = 100f, max = 1000f, dependsOn = new string[] { "EnableBarricades" }, gameType = new IMCJHBIFEAK[] { IMCJHBIFEAK.Survival })]
	public ObscuredInt ECFKJNJEMBP = ObscuredInt.FNIPJFGEFFD(100);

	public ObscuredBool DPBKBFCMFLL = ObscuredBool.FNIPJFGEFFD(true);

	public ObscuredBool IHNHCNGJKIK;

	[Field(name = "Amount of guns in shop per round", customOnly = true)]
	public ObscuredBool DIMHBBEFMDK;

	[Field(name = "Disable Headshot", customOnly = true)]
	public ObscuredBool GOMHFBFGHBI;

	[Field(name = "Allow JumpShoot")]
	public ObscuredBool MKEIKODECEC = ObscuredBool.FNIPJFGEFFD(true);

	[Field(name = "Allow SpawnKill")]
	public ObscuredBool HBLCBDGCHGH;

	public bool DEPCHIFBFHJ = true;

	public ObscuredBool MDDBCIILKHG;

	public ObscuredBool IHCFILFBIJF;

	public bool BPHACLDHAOF;

	public ObscuredBool ANPPCHMLKNF = ObscuredBool.FNIPJFGEFFD(true);

	public ObscuredBool MALADAFMOBJ;

	public ObscuredBool JABHAJEEFNO;

	public ObscuredBool DELGJNBGMLD;

	public bool IHHLGEIECBI;

	public bool IDAPJDEGNLI;

	public bool CKAANIIJLDL;

	public bool KBABLNHMAFN;

	public bool HJPPJJCHGJA;

	public bool EGPJNAJIPLA;

	public ObscuredBool BOOJPIJMOEL;

	public ObscuredBool OPKDMODBFGA;

	public ObscuredBool DOMONNBOMNP = ObscuredBool.FNIPJFGEFFD(true);

	public ObscuredBool AHCKCNAPIMN;

	public bool AHINLBKLFHJ;

	public bool KLKOJNMNCJO;

	public bool FGOEMLGNICE;

	public bool CPPEBEEIOEG;

	public bool LOIKOIEOGPD;

	public bool JLODNBFNDEI;

	public bool HDOJLFGFDGH;

	public bool ELPJKAELPJA;

	public ObscuredBool DMLDHJMAJME;

	public ObscuredBool EMEKGPGIPOI;

	public ObscuredBool CKAJCPDFAGC;

	public bool KIJKOJNLFEN;

	private bool HDNIEDEPDGE;

	private bool CNIMDDMILFD;

	private bool NKPPCGPKDHB;

	private bool CHPFDDNCJPC;

	private bool MEJCNDKKNBP;

	internal ObscuredBool ANNMANFJHLF;

	internal ObscuredBool JFFHDKCBBEA;

	internal ObscuredBool LMCLODHEIGA;

	internal ObscuredBool OPAHEKILKNB;

	internal ObscuredBool LECIFFENJMA;

	internal ObscuredBool HBICGHPGGPH;

	internal ObscuredBool JPDEHJCDHHA;

	internal ObscuredBool DAGCHNCNBJH;

	private ObscuredBool KDGHINCHDFE;

	private bool GOGIHGDFMNL;

	public DBDCHDJAEEF BMFJLKHEFCE;

	public DBDCHDJAEEF MKBEEIBKJKK;

	public ObscuredFloat DEBNBJBLEDJ = ObscuredFloat.FNIPJFGEFFD(1f);

	public ObscuredFloat GJONENFFLCC = ObscuredFloat.FNIPJFGEFFD(100f);

	public ObscuredFloat MDPFPELMHGB = ObscuredFloat.FNIPJFGEFFD(10f);

	public ObscuredFloat FCHNCMCFGFC = ObscuredFloat.FNIPJFGEFFD(0.6f);

	public ObscuredFloat JDFKPCHDKIJ = ObscuredFloat.FNIPJFGEFFD(1f);

	public ObscuredFloat LBOCPHIENEP = ObscuredFloat.FNIPJFGEFFD(0.7f);

	public ObscuredFloat EBJHGFLAOAL = ObscuredFloat.FNIPJFGEFFD(1f);

	public ObscuredFloat HCCCNMBOMPH = ObscuredFloat.FNIPJFGEFFD(0.5f);

	public ObscuredFloat FAOBHMEHKIJ;

	public ObscuredFloat AJFFDIHCJNL = ObscuredFloat.FNIPJFGEFFD(5f);

	public ObscuredFloat OEIBNEGMCFE = ObscuredFloat.FNIPJFGEFFD(5f);

	public ObscuredFloat HDGCFPAMGKE = ObscuredFloat.FNIPJFGEFFD(1f);

	public ObscuredFloat CIAFEEDOBKN = ObscuredFloat.FNIPJFGEFFD(0.1f);

	public ObscuredFloat COGEDCIBHMA = ObscuredFloat.FNIPJFGEFFD(100f);

	public ObscuredFloat KODPOMPNLBE = ObscuredFloat.FNIPJFGEFFD(100f);

	public ObscuredFloat DCHKOIHONPN = ObscuredFloat.FNIPJFGEFFD(1f);

	public ObscuredFloat LFCAGNKGGII;

	public ObscuredFloat AGMKEFAIGOD;

	public ObscuredFloat NGNMLDCDOPC = ObscuredFloat.FNIPJFGEFFD(60f);

	public ObscuredFloat BEHBJPNPFCC = ObscuredFloat.FNIPJFGEFFD(60f);

	public ObscuredFloat ONGIFKIJNKM;

	public ObscuredFloat IEAJBGMCJDL;

	public ObscuredFloat HJNMHAGEEPC = ObscuredFloat.FNIPJFGEFFD(0.5f);

	public ObscuredFloat LGIOALGFFHP;

	public ObscuredFloat FPFAEOJAIBB;

	public ObscuredFloat JFLGCMGFGHF = ObscuredFloat.FNIPJFGEFFD(0.5f);

	public ObscuredFloat ICNGEPMDAOD;

	public ObscuredFloat BDGPJFCBNCL;

	public ObscuredFloat DDHJEHMOINN = ObscuredFloat.FNIPJFGEFFD(50f);

	public ObscuredFloat KAPKDAHAGLI = ObscuredFloat.FNIPJFGEFFD(0.2f);

	private float EDKILOHEDJM;

	private float PHLMCKBAGGG;

	private float EKIIGENHGKD;

	private float MGBCFMMBGGL = float.MinValue;

	internal ObscuredFloat JFMNIDEDNHG;

	internal ObscuredFloat LAAEJKMCKOI;

	internal ObscuredFloat MIGCKAPHANN = ObscuredFloat.FNIPJFGEFFD(0f);

	internal ObscuredFloat EMKLPBIJILF = ObscuredFloat.FNIPJFGEFFD(1f);

	internal ObscuredFloat OHGEMABOIBK = ObscuredFloat.FNIPJFGEFFD(100f);

	internal ObscuredFloat NBKGCKPKBOC = ObscuredFloat.FNIPJFGEFFD(100f);

	internal ObscuredFloat IJFJBIKHEDL = ObscuredFloat.FNIPJFGEFFD(1.3f);

	internal ObscuredFloat KCMEHLKGPJM;

	internal float IEHHBIPHNBE = -100f;

	internal ObscuredFloat CDHGIGNMPKD;

	internal ObscuredFloat CNOBPBGPHGJ;

	internal ObscuredFloat BMKALMOPDKI;

	[Field(name = "Buy Time Max", min = 0f, max = 30f, customOnly = true)]
	public ObscuredFloat FPIHOOAEDEN = ObscuredFloat.FNIPJFGEFFD(20f);

	public ObscuredInt MIDPJKEMHNI = ObscuredInt.FNIPJFGEFFD(0);

	public ObscuredInt IMHCIJAKKLC = ObscuredInt.FNIPJFGEFFD(100);

	public ObscuredInt GHHLIMCAHPL = ObscuredInt.FNIPJFGEFFD(500);

	public int DCEJABDJMLM;

	public int KLGAIEEIICF;

	public int JGAFAIDLHOP = 1;

	public int DFFLEKBAJKC;

	public int GIAONHLJAGE;

	public int OEIIKDFMDGJ;

	private ObscuredInt OKLHHGBBLGC;

	private int HKNCJGJLPPF;

	private int BJBAFFEPDLF = -1;

	internal ObscuredInt EKEMIEEFILP = ObscuredInt.FNIPJFGEFFD(200);

	public string GGKNEBMJMMA;

	public string GGJCGJBPMJB;

	public string FPKNMEGEMNB;

	public string ABPLLLNNMOG;

	public GameObject MOACANDGLKG;

	public GameObject BHDGMFACCHL;

	public string PGGBHOLFDIB = " suicide";

	public string DNEKPHKNMEJ = " headshot";

	public string[] BNDKCABKDDA = new string[20];

	public GameObject[] LFFLBOAFDBH = new GameObject[40];

	public GameObject IFLCIAMAFAL;

	public GameObject PCAJNOLGHIG;

	public GameObject CDMIBOLAEOP;

	public GameObject FAONFMJHBCD;

	public GameObject AOFDNABLIMA;

	public GameObject FFMBJIEHMEA;

	public GameObject AMKDLOAPGCB;

	public GameObject BIBFAENLDPA;

	public GameObject LDMMHJDNPED;

	public GameObject HLMDBACNBCD;

	public GameObject GPEMICEODNF;

	public GameObject FLAGKLELOFK;

	public GameObject CLMIPGCFELH;

	public GameObject LGKBNACNBLA;

	public GameObject GABDIDGBKJO;

	private GameObject EEGILNOAEHE;

	private GameObject NIBHAMDFKAI;

	private GameObject HLKKOIHFKAC;

	public GameObject[] LGGFAOBAFIP;

	public GameObject[] IOJCANCKPIL;

	public GameObject[] GDFPEGFIEIK;

	public GameObject[] JMAKHEHKDDL;

	public GameObject[] KINPMKAGPAK;

	public GameObject[] CLECKFKPMDC;

	public GameObject[] OLAMMALHNIA = new GameObject[0];

	public GameObject[] FLMHOJOIHGI = new GameObject[0];

	public GameObject[] OPBPNCKLKKN = new GameObject[0];

	public GameObject[] BDNIGCODOLN = new GameObject[0];

	public WeaponMap[] MGFGBMCEDPK = new WeaponMap[0];

	internal BombPlace[] GGEMEHNHFCG;

	internal BuyTrigger[] PDOHNFKMCAG;

	public SpawnPlayer[] FFECBELHGGD;

	public SpawnPlayer[] PAHMPFHNPLF;

	public SpawnPlayer[] FMEPHNJPJNF;

	public SpawnPlayer[] MFNKJMBHMGE;

	public ParticleSystem GEMPBPLEFAE;

	public ParticleSystem KNOPBFCKBNP;

	public ParticleSystem GKPGFLEBIIA;

	public ParticleSystem LEBFDFEOCND;

	public ParticleSystem GEPBLPODMNJ;

	public Transform CCLAGBBDGDI;

	public Transform MIMKAJOMAKG;

	public Transform LCAOIJJOELE;

	public Transform IFFPFBDDDGE;

	public Material JDHDGBDPELI;

	public Material GKAGCBOKIDD;

	public Material FNFEEJEAIGD;

	public Transform MAOFPKAJMGO;

	public Transform DOLHNPFJNNE;

	private Vector2 CFKCJLFCCDM;

	private Vector2 FOIHDIAMCGF;

	private Vector2 OMMPFIHGOKD;

	public Vector2 IMCFHFOJDDP;

	public Vector3 DHHNIGKHPLC;

	public Vector3 BLNEKFBHKJB;

	public CEDODJHAKAE PLMNDHNKGIN;

	public GUITexture MPMEGJNDDJG;

	public CanvasGroup HNAEGEKKMGD;

	public InputField PAPGHAPKIBJ;

	public Text NMEOIEFEKFM;

	public ScrollRect OBEFEIJNPDC;

	public Button OOJMFMAMAAK;

	public TouchPhase FCBCGKBOMAH;

	public FDLJKDJLMKK GNBPBJKCDME;

	public JDILMODHLOJ BDHHGHOGGIJ;

	public GameObject FNPIIJGOANH;

	public Color FBJCGLCJINI;

	public TextMesh DMFHMHNAOOP;

	public LightmapData[] JHHHHHOENKK;

	public FOGIOGKLNIP[] HPALAEHEPEK = new FOGIOGKLNIP[0];

	public Renderer[] FPEJFOHKDGM;

	private KKJBDENNKGF[] ALGCOODNDLI;

	private Touch[] MKGLALKPPGG = new Touch[20];

	internal Touch[] PNCFKKICDCE = new Touch[20];

	public BEJHFGDPDLI JDFKPOMKMNJ = new BEJHFGDPDLI();

	internal IBOGNCENEHO[] BGNPGBCKCHM = new IBOGNCENEHO[2]
	{
		IBOGNCENEHO.Monster,
		IBOGNCENEHO.Fatty
	};

	private TouchScreenKeyboard DPCLNDPEHKH;

	private Animation[] LAMFMFPKDFH = new Animation[0];

	private Animator[] KEEBNEJDEPA = new Animator[0];

	private AudioSource[] AIGIPLIIHCG = new AudioSource[0];

	private ParticleSystem[] CNGMDJEANHD = new ParticleSystem[0];

	private VideoPlayer[] ILDFLKOIIDN = new VideoPlayer[0];

	public List<AMKDLOAPGCB> HCIMPOGMHAK = new List<AMKDLOAPGCB>();

	public List<EJDKALEIBBG> GGPOLOMIGOI = new List<EJDKALEIBBG>();

	public List<JDILMODHLOJ> LDAKBEMPLEB = new List<JDILMODHLOJ>();

	public List<NFHGOIHFOBD> DHHENNKPELD = new List<NFHGOIHFOBD>();

	public List<ENFDKNAODIJ> IJMPPAPBMAJ = new List<ENFDKNAODIJ>();

	public List<Trigger2> JFBCNBMHENO = new List<Trigger2>();

	public List<KKJBDENNKGF> FBFOHOIFJGL = new List<KKJBDENNKGF>();

	public List<MKAFHPMKFEO> JLFMGNFDGCK = new List<MKAFHPMKFEO>();

	public List<CJMKGJPLOPM> BKFEGEAEIFB = new List<CJMKGJPLOPM>();

	public List<PMDPIINLPHK> HEGNCGKJMJF = new List<PMDPIINLPHK>();

	internal List<MeshRenderer> NNNDNKCHANB = new List<MeshRenderer>();

	public Dictionary<string, FOGIOGKLNIP> KBBEJPKKHIL = new Dictionary<string, FOGIOGKLNIP>();

	public Dictionary<KeyValuePair<string, string>, float> HNPEILDDGID = new Dictionary<KeyValuePair<string, string>, float>();

	public Dictionary<string, float> HKFPMOFOELF = new Dictionary<string, float>();

	private Dictionary<KeyValuePair<string, string>, float> HDELOLGNHNI = new Dictionary<KeyValuePair<string, string>, float>();

	public Stack<NetworkViewID> OHCHIHBJEGJ = new Stack<NetworkViewID>();

	private float OHJHDLCBJOE = 1f;

	private float LBIKJEIBAJM;

	private float NEGBINKNBCB = 4f;

	public GameObject PHBNDLFNKCJ;

	public Text OHEOOMNMFNF;

	public Text GPNCCKIBDMJ;

	public Text APPCFEMMMLD;

	public Text KCBKCAMJLIJ;

	public Text MAMAPLADEGN;

	public Text NILPEEFBMGG;

	public Text BMGBHOPHKHK;

	private Color32 PCCDLMPECKJ = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 51);

	private Color32 ADOHNEHMCLI = new Color32(181, 212, 240, 51);

	private Color32 LNEGOCJDMPB = new Color32(233, 213, 127, 51);

	private Color32 GNCOHGJDDGO = new Color32(181, 212, 240, byte.MaxValue);

	private Color32 FPEAAFEGOPF = new Color32(233, 213, 127, byte.MaxValue);

	internal WeaponManager OCNLLGCCFAG;

	internal PlayerLifeManager BBBCMOHPEIH;

	private HGGEPCICFGM OCCOEHJFDKM = new HGGEPCICFGM(255);

	private HGGEPCICFGM ALKHJOFJBNE = new HGGEPCICFGM(255);

	private bool BIDENNIODPM;

	internal static bool HLDLJFOALII;

	private KKJBDENNKGF FKHKEMFBBNE;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> ACJNADIPOMC;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> HJJBAKLDAEB;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> MPCENNEMFPB;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, JDILMODHLOJ> AGJHOJDNCOI;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> GOKLDIBAPEA;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> FDEPMKHNIID;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> JEJGIANFAJE;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> CAGBNPPEAFL;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> IOIHBOPJMHO;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, float> MIHBLNGEMJB;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> MBDEKCIDOHG;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> INPFPBONNKM;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> DCNJCLEOEHG;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> AFIEDPFMAGJ;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> CEOLLBPDPIB;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> GGPHECIEGDB;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, string> MLIEIDFEICI;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> OFOPMFOMIBE;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, ObscuredInt> DFNLGGNOAFC;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> LIJNNCCHNBN;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, ObscuredInt> HIGIJMJOLJH;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> BJLEFEJDDBA;

	[CompilerGenerated]
	private static Func<GameObject, Transform> JPKHLMPCIHO;

	[CompilerGenerated]
	private static Func<Transform, float> HADDHHPAEJI;

	[CompilerGenerated]
	private static Func<GameObject, Transform> IFMMEDHDOML;

	[CompilerGenerated]
	private static Func<Transform, float> OLAGFPHHHEP;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> GIEPGOOJBEM;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> EDBOALOEIBJ;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> LFLPCBPGFDK;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> PLHDCAJBOIP;

	[CompilerGenerated]
	private static Func<Match, string> OAPHNMEBMNJ;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> DABOOMCNKAM;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> FKLCPJAGPKP;

	[CompilerGenerated]
	private static Func<bool, bool> KPBBJFLEPCO;

	[CompilerGenerated]
	private static Func<bool, bool> GCJKENLPBJK;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> GJHAOLMMADK;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> AIDBMIDLEHL;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, ObscuredInt> PFCMKHBEHPI;

	[CompilerGenerated]
	private static Func<Renderer, IEnumerable<Material>> AOOAPBPJLKD;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> KPKIOCKCMCE;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> JENPEMLHKPG;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> ABHJEPJFLJK;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> EBMDAFIINCG;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> LKPOPMOPDHD;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> FBGLFJKDAJJ;

	[CompilerGenerated]
	private static Func<KKJBDENNKGF, bool> NLDLLEMDGCD;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> JFGFCHFDKIO;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> PMHPCIPHOPK;

	[CompilerGenerated]
	private static Func<JDILMODHLOJ, bool> DIELPEOLPCK;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> DPNOILNJKJI;

	[CompilerGenerated]
	private static Predicate<KKJBDENNKGF> AKHEIIJMNGN;

	[CompilerGenerated]
	private static Predicate<ENFDKNAODIJ> KEAKPPNEDLB;

	[CompilerGenerated]
	private static Predicate<ENFDKNAODIJ> MIOCOFFNDED;

	[CompilerGenerated]
	private static Func<ENFDKNAODIJ, bool> GEMHBAMHCID;

	[CompilerGenerated]
	private static Func<Collider, bool> CNMKAMFBEFJ;

	[CompilerGenerated]
	private static Func<Collider, float> NPCHNOKOAJB;

	[CompilerGenerated]
	private static Func<GameObject, bool> ILOJKKKIMKN;

	[CompilerGenerated]
	private static Func<GameObject, bool> IDILGOEKCNK;

	[CompilerGenerated]
	private static Func<Animation, bool> CDPLAPGBPBB;

	[CompilerGenerated]
	private static Func<AudioSource, bool> EJCCFJDHMHE;

	[CompilerGenerated]
	private static Func<ParticleSystem, bool> KGOIBGIOJBH;

	[CompilerGenerated]
	private static Func<VideoPlayer, bool> DEMCFDNFGGI;

	[CompilerGenerated]
	private static Func<BombPlace, string> POKBAMAJKIE;

	[CompilerGenerated]
	private static Func<SpawnPlayer, bool> EKPJHKNPANC;

	[CompilerGenerated]
	private static Func<SpawnPlayer, bool> CEDLEBLMOAJ;

	[CompilerGenerated]
	private static Func<SpawnPlayer, bool> IKHHHDPFPHC;

	[CompilerGenerated]
	private static Action<string> PPIJCDCCJAD;

	[CompilerGenerated]
	private static Action<string> IJIOIDABMFE;

	[CompilerGenerated]
	private static Predicate<Touch> NDMMACGFGIA;

	[CompilerGenerated]
	private static Func<Collider, Bounds> JOGONKOHDJN;

	[CompilerGenerated]
	private static Func<Bounds, float> LPILBNEAJKI;

	[CompilerGenerated]
	private static Func<Bounds, float> ACKELCFKCHB;

	[CompilerGenerated]
	private static Func<Bounds, float> IJGHCLKMCPF;

	[CompilerGenerated]
	private static Func<Bounds, float> NJJOAJGMECE;

	[CompilerGenerated]
	private static Func<Bounds, float> MALOGDINCIG;

	[CompilerGenerated]
	private static Func<Bounds, float> NHCDNAABKMB;

	[CompilerGenerated]
	private static Predicate<JDILMODHLOJ> JKBEPLLEJDG;

	public ObscuredBool GFPOMBMNDIO
	{
		get
		{
			return MALADAFMOBJ;
		}
		set
		{
			MALADAFMOBJ = value;
		}
	}

	internal ObscuredBool DJBGAOOAGEO
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(ObscuredBool.FNIPJFGEFFD(AHCKCNAPIMN) || FOGIOGKLNIP.OMMLFOEPEEK);
		}
		set
		{
			AHCKCNAPIMN = value;
		}
	}

	public bool IGJKLHOGPHL
	{
		get
		{
			return Convert.ToBoolean(HNAEGEKKMGD.alpha);
		}
		set
		{
			HNAEGEKKMGD.alpha = Convert.ToSingle(value);
			FOGIOGKLNIP.CIEBMCOJGCC.DIMJCGEFKKN.SetActive(value);
			FOGIOGKLNIP.PIOANBBCFFP.NMEOIEFEKFM.gameObject.SetActive(!value);
		}
	}

	public bool OCKHCJGLOEL
	{
		get
		{
			return FOGIOGKLNIP.NMGDHKIKCED == null;
		}
	}

	public FDGPLHOFOEN AKLFGPJPLKM
	{
		get
		{
			return IFLCIAMAFAL.GetComponent<FDGPLHOFOEN>();
		}
	}

	internal bool KFAKAMKOKKP
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(OPAHEKILKNB);
		}
		set
		{
			OPAHEKILKNB = ObscuredBool.FNIPJFGEFFD(value);
		}
	}

	public IEnumerable<FDGPLHOFOEN> NPKOJPJHMOK
	{
		get
		{
			return FBFOHOIFJGL.WhereF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB is FDGPLHOFOEN).Cast<FDGPLHOFOEN>();
		}
	}

	public int EBCPJJKFFHO
	{
		get
		{
			return UnityEngine.Random.Range(0, FMEPHNJPJNF.Length - 1);
		}
	}

	public int LLBBIJEHBIP
	{
		get
		{
			return UnityEngine.Random.Range(0, PAHMPFHNPLF.Length - 1);
		}
	}

	public Transform LOCHJEFJLJG
	{
		get
		{
			return FMEPHNJPJNF[Mathf.Min(EBCPJJKFFHO, FMEPHNJPJNF.Length - 1)].transform;
		}
	}

	public Transform LNPHCAOCEBD
	{
		get
		{
			return PAHMPFHNPLF[Mathf.Min(LLBBIJEHBIP, PAHMPFHNPLF.Length - 1)].transform;
		}
	}

	[Field(name = "Space Mod", customOnly = true)]
	public ObscuredBool IDHNLOELEDI
	{
		get
		{
			return LBMMMABCGDE;
		}
		set
		{
			LBMMMABCGDE = value;
			if (ObscuredBool.FNIPJFGEFFD(value))
			{
				Physics.gravity = Vector3.zero;
			}
			else
			{
				Physics.gravity = new Vector3(0f, -9.81f, 0f);
			}
		}
	}

	[Field(name = "Random Spawn", gameType = new IMCJHBIFEAK[] { IMCJHBIFEAK.Classic })]
	public ObscuredBool EKJHFLFIEFM
	{
		get
		{
			return KDGHINCHDFE;
		}
		set
		{
			KDGHINCHDFE = value;
			OLAMMALHNIA = ((!ObscuredBool.FNIPJFGEFFD(value)) ? KINPMKAGPAK : OPBPNCKLKKN);
			FLMHOJOIHGI = ((!ObscuredBool.FNIPJFGEFFD(value)) ? CLECKFKPMDC : OPBPNCKLKKN);
		}
	}

	[Field(name = "Disable Spawn Drop")]
	public ObscuredBool IEAAGNJEKKF
	{
		get
		{
			return HBICGHPGGPH;
		}
		set
		{
			HBICGHPGGPH = value;
		}
	}

	[Field(name = "Starting Money", min = 0f, max = 16000f, customOnly = true)]
	public ObscuredInt PKKGCLPEGJL
	{
		get
		{
			return OKLHHGBBLGC;
		}
		set
		{
			OKLHHGBBLGC = value;
			foreach (JDILMODHLOJ item in LDAKBEMPLEB)
			{
				item.JCMCPIPHDHB = value;
			}
		}
	}

	[Field(name = "Fog Destination", max = 1f, customOnly = true)]
	public ObscuredFloat GMGAIKFOCNH
	{
		get
		{
			return ObscuredFloat.FNIPJFGEFFD(RenderSettings.fogDensity);
		}
		set
		{
			RenderSettings.fogDensity = ObscuredFloat.FNIPJFGEFFD(value);
			RenderSettings.fog = ObscuredFloat.FNIPJFGEFFD(value) > 0f;
			RenderSettings.fogMode = FogMode.Exponential;
			EMEKGPGIPOI = ObscuredBool.FNIPJFGEFFD(true);
		}
	}

	public GameObject DBJKHPCJFEE
	{
		get
		{
			if (EEGILNOAEHE == null)
			{
				EEGILNOAEHE = (GameObject)Resources.Load(GGKNEBMJMMA);
			}
			return EEGILNOAEHE;
		}
	}

	public GameObject GCDMEBGCFAO
	{
		get
		{
			if (NIBHAMDFKAI == null)
			{
				NIBHAMDFKAI = (GameObject)Resources.Load(GGJCGJBPMJB);
			}
			return NIBHAMDFKAI;
		}
	}

	public GameObject OJPPDGGMHBB
	{
		get
		{
			if (HLKKOIHFKAC == null)
			{
				HLKKOIHFKAC = (GameObject)Resources.Load(FPKNMEGEMNB);
			}
			return HLKKOIHFKAC;
		}
	}

	public ObscuredFloat DEEPKELFLDC
	{
		get
		{
			return IEAJBGMCJDL;
		}
		set
		{
			IEAJBGMCJDL = value;
			KLKOJNMNCJO = true;
		}
	}

	public ObscuredBool IAFDEBFCAJI
	{
		get
		{
			return ObscuredBool.FNIPJFGEFFD(FGOEMLGNICE);
		}
		set
		{
			FGOEMLGNICE = ObscuredBool.FNIPJFGEFFD(value);
			KLKOJNMNCJO = false;
		}
	}

	public bool DALNPKPJAJF
	{
		get
		{
			return FOGIOGKLNIP.LBJBBGEDGJF.enabled;
		}
		set
		{
			FOGIOGKLNIP.LBJBBGEDGJF.enabled = value;
		}
	}

	private string LKDGCBOBNHK
	{
		get
		{
			return GUIUtility.systemCopyBuffer;
		}
		set
		{
			Regex regex = new Regex("<[^>]*>");
			GUIUtility.systemCopyBuffer = regex.Replace(value, string.Empty);
		}
	}

	public override void Awake()
	{
		Resources.UnloadUnusedAssets();
		NBLJJDANCFG = FOGIOGKLNIP.LPLJMLGKCLK.COKMEOGCMBJ;
		PKKGCLPEGJL = ObscuredInt.FNIPJFGEFFD(800);
		if (GPEMICEODNF != null && !GPEMICEODNF.activeInHierarchy)
		{
			GPEMICEODNF.SetActive(true);
		}
		FOGIOGKLNIP.LPLJMLGKCLK.JDFKPOMKMNJ.GFJGDEKLFNB();
		DJBGAOOAGEO = ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LMMFHEODOPM.DEMKLLPLDBO);
		FOGIOGKLNIP.PBDAOOIJGIA = new bool[256];
		FOGIOGKLNIP.PIOANBBCFFP = this;
		base.Awake();
		BKGBOHHDOLI();
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(PhotonView));
			for (int i = 0; i < array.Length; i++)
			{
				PhotonView photonView = (PhotonView)array[i];
				photonView.enabled = false;
			}
		}
		else
		{
			UnityEngine.Object[] array2 = UnityEngine.Object.FindObjectsOfType(typeof(NetworkView));
			for (int j = 0; j < array2.Length; j++)
			{
				NetworkView networkView = (NetworkView)array2[j];
				networkView.enabled = false;
			}
		}
		bool isMessageQueueRunning = (PhotonNetwork.isMessageQueueRunning = true);
		Network.isMessageQueueRunning = isMessageQueueRunning;
		FOGIOGKLNIP[] hPALAEHEPEK = HPALAEHEPEK;
		foreach (FOGIOGKLNIP fOGIOGKLNIP in hPALAEHEPEK)
		{
			if (fOGIOGKLNIP != null)
			{
				KBBEJPKKHIL.Add(fOGIOGKLNIP.name, fOGIOGKLNIP);
			}
		}
		FOGIOGKLNIP.NGFDFPGNDCJ = (FDLJKDJLMKK)UnityEngine.Object.FindObjectOfType(typeof(FDLJKDJLMKK));
		INBICCIHAIC();
		Screen.sleepTimeout = -1;
	}

	[DebuggerHidden]
	public IEnumerator Start()
	{
		FDLIMJFOCLE fDLIMJFOCLE = new FDLIMJFOCLE();
		fDLIMJFOCLE.KPHCHDHEKGH = this;
		return fDLIMJFOCLE;
	}

	public void Update()
	{
		if (FOGIOGKLNIP.DNJOLNHKJAA(KeyCode.R) && Input.GetKey(KeyCode.LeftControl))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		if (!ObscuredBool.FNIPJFGEFFD(CFGAEDNCMJP) && ObscuredFloat.FNIPJFGEFFD(BMKALMOPDKI) >= 0f)
		{
			BMKALMOPDKI = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(BMKALMOPDKI) - Time.deltaTime);
		}
		for (int num = FBFOHOIFJGL.Count - 1; num >= 0; num--)
		{
			if (FBFOHOIFJGL[num] == null)
			{
				FBFOHOIFJGL.RemoveAt(num);
			}
		}
		if (!FOGIOGKLNIP.LMMFHEODOPM.PBECBICNHPK && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && (ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.ECACNDFNADN)) && base.NENPALDENAL && JDFKPOMKMNJ.NFMIBMIGJMH((int)(1000f * ObscuredFloat.FNIPJFGEFFD(AJFFDIHCJNL))))
		{
			JDILMODHLOJ[] array = ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.ECACNDFNADN)) ? FBFOHOIFJGL.WhereF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA != null && !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.BJDCCKHBENA.HIBLODEGHAK) && (AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ))).SelectF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA).ToArray() : LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK)).ToArray());
			if (array.Length > 0)
			{
				for (int num2 = 0; num2 < Mathf.RoundToInt((float)JGAFAIDLHOP + (float)FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) && !AEMBPMJMOAB.KAMAMHFJDGG) * 0.3f); num2++)
				{
					GCIOFFGBEEE gCIOFFGBEEE = new GCIOFFGBEEE();
					gCIOFFGBEEE.KPHCHDHEKGH = this;
					HKNCJGJLPPF++;
					gCIOFFGBEEE.CEOMHNKEIBA = array[HKNCJGJLPPF % array.Length];
					Action<GNMHJEPNHDL> action = gCIOFFGBEEE.BEKJDJFLJJC;
					if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDFHLAHHCME))
					{
						action((gCIOFFGBEEE.CEOMHNKEIBA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) ? GNMHJEPNHDL.Terrorists : GNMHJEPNHDL.CounterTerrorists);
					}
					else if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.ECACNDFNADN))
					{
						if (FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) < FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists))
						{
							action(GNMHJEPNHDL.CounterTerrorists);
						}
						else
						{
							action(GNMHJEPNHDL.Terrorists);
						}
					}
				}
			}
		}
		if ((float)DHHENNKPELD.Count < ObscuredFloat.FNIPJFGEFFD(MIGCKAPHANN) && FOGIOGKLNIP.NMGDHKIKCED != null && JDFKPOMKMNJ.NFMIBMIGJMH(5000))
		{
			EABKALFFPCF(OKANFELAGDE());
		}
		if (FOGIOGKLNIP.EPBMIIPELPO.JEMHJCCILMN())
		{
			AHINLBKLFHJ = true;
		}
		FOGIOGKLNIP.CNIAIOJACDA = !base.MJEAIGGPIKN && base.MDBAFPKAKKK && FOGIOGKLNIP.EPBMIIPELPO.JLIBFOMLOGD() && AHINLBKLFHJ;
		FOGIOGKLNIP.CNIAIOJACDA = FOGIOGKLNIP.CNIAIOJACDA || FOGIOGKLNIP.EPBMIIPELPO.DFKJBNPCEIJ(KeyCode.RightShift) || DAJCDEAPINB() || Time.time - EKIIGENHGKD < 0.3f;
		if (FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.LPLJMLGKCLK.NGIPHFLPPCH)
		{
			LJKLBFKJEKD();
		}
		if (!FOGIOGKLNIP.CNIAIOJACDA || !FOGIOGKLNIP.DGMBIMMABNO || !FOGIOGKLNIP.LPLJMLGKCLK.FABPKKNPCBF)
		{
			FOGIOGKLNIP.DDGKNLHJEFD = ((!BPHACLDHAOF) ? (OEBNLFODLDB() + PHFPHLLPFDM()) : MGJOEFJBALC());
		}
		FOGIOGKLNIP.DDGKNLHJEFD += OCBEKDFIAIG();
		if (FOGIOGKLNIP.NGFDFPGNDCJ.AIBOANMOJJD && FOGIOGKLNIP.NGFDFPGNDCJ.CICDHCEOLLE.fieldOfView == 15f)
		{
			FOGIOGKLNIP.DDGKNLHJEFD *= FOGIOGKLNIP.LPLJMLGKCLK.LHPIFFJKBPL;
		}
		if (FOGIOGKLNIP.GMPBCIEDMCD != null && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.GMPBCIEDMCD.EFCLACBNGCL))
		{
			FOGIOGKLNIP.DDGKNLHJEFD *= 0.3f;
		}
		if (FOGIOGKLNIP.GMPBCIEDMCD != null)
		{
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.GMPBCIEDMCD.MGJPMGGABLN))
			{
				FOGIOGKLNIP.DDGKNLHJEFD *= 0.6f;
			}
			else if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.GMPBCIEDMCD.JEPMMPCNEHO.EMIEPBFBJBB))
			{
				FOGIOGKLNIP.DDGKNLHJEFD *= 0.3f;
			}
			else if (FOGIOGKLNIP.DGMBIMMABNO && (FOGIOGKLNIP.GMPBCIEDMCD.GEGAMONDEKC || FOGIOGKLNIP.CNIAIOJACDA))
			{
				FOGIOGKLNIP.DDGKNLHJEFD *= 0.6f;
			}
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.OPNFEFFBODL))
			{
				if (GOGIHGDFMNL)
				{
					FOGIOGKLNIP.CNIAIOJACDA = GOGIHGDFMNL;
				}
				if (JDFKPOMKMNJ.ELKBOHAOPDL(10) && FOGIOGKLNIP.DGMBIMMABNO && ((ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.OPNFEFFBODL) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.GMPBCIEDMCD.JEPMMPCNEHO.BCCOHOIIGPP)) || FOGIOGKLNIP.NGFDFPGNDCJ.AEBCFFNADHM))
				{
					GOGIHGDFMNL = false;
					if (FOGIOGKLNIP.NGFDFPGNDCJ.HDIMJIENKHH == null || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.GMPBCIEDMCD.PHLKCKKDLFF))
					{
						foreach (KKJBDENNKGF item in FBFOHOIFJGL)
						{
							if (!item.GCBBBFGBEFE(BDHHGHOGGIJ.JGECOECAJLK))
							{
								item.ICIEDCMDJFO.layer = 27;
							}
						}
						RaycastHit hitInfo;
						if (Physics.Raycast(FOGIOGKLNIP.GMPBCIEDMCD.MPCGHDNMNKN.ELGIKGAIIOD, FOGIOGKLNIP.GMPBCIEDMCD.MPCGHDNMNKN.EHOEFMPLIFB.forward, out hitInfo, 1000f, 3072))
						{
							KKJBDENNKGF component = hitInfo.transform.root.GetComponent<KKJBDENNKGF>();
							if (component != null && component.GCBBBFGBEFE(BDHHGHOGGIJ.JGECOECAJLK) && !(FOGIOGKLNIP.GMPBCIEDMCD.JEPMMPCNEHO is JOCAFHIONFA))
							{
								if (Time.time - ObscuredFloat.FNIPJFGEFFD(AGMKEFAIGOD) > ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.JHAAFBPEKNJ))
								{
									GOGIHGDFMNL = true;
								}
							}
							else
							{
								AGMKEFAIGOD = ObscuredFloat.FNIPJFGEFFD(Time.time);
							}
						}
						foreach (KKJBDENNKGF item2 in FBFOHOIFJGL)
						{
							item2.ICIEDCMDJFO.layer = 11;
						}
					}
				}
			}
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.EHAGHHJANMF)
		{
			FOGIOGKLNIP.DDGKNLHJEFD.x = 0f - FOGIOGKLNIP.DDGKNLHJEFD.x;
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.KIAPJFGPAME)
		{
			FOGIOGKLNIP.DDGKNLHJEFD.y = 0f - FOGIOGKLNIP.DDGKNLHJEFD.y;
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.AICIJPIMOLH)
		{
			Touch[] hJDAJDIIMPD = FOGIOGKLNIP.HJDAJDIIMPD;
			for (int num3 = 0; num3 < hJDAJDIIMPD.Length; num3++)
			{
				Touch touch = hJDAJDIIMPD[num3];
				MKGLALKPPGG[touch.fingerId % 20] = touch;
			}
		}
		FOGIOGKLNIP.FAFGMDJIOGN = CKEEJFMMOOG();
		if (FOGIOGKLNIP.CNIAIOJACDA && CHPFDDNCJPC != FOGIOGKLNIP.CNIAIOJACDA)
		{
			CPPEBEEIOEG = true;
		}
		else
		{
			CPPEBEEIOEG = false;
		}
		if (EGPJNAJIPLA)
		{
			GNHOMGMBHPB();
		}
		CHPFDDNCJPC = FOGIOGKLNIP.CNIAIOJACDA;
		OGOJKJDJEOG();
		if (base.NENPALDENAL && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.ECACNDFNADN) && Time.time - ObscuredFloat.FNIPJFGEFFD(CDHGIGNMPKD) > 2f)
		{
			GFJOLAKDKFP();
		}
		PPBLJMDIFKB();
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO && base.NENPALDENAL && JDFKPOMKMNJ.NFMIBMIGJMH(15000) && !FOGIOGKLNIP.OMMLFOEPEEK && !base.JNPCOJFBJGP)
		{
			MasterServer.RegisterHost("csport", FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO);
		}
		if (JDFKPOMKMNJ.NFMIBMIGJMH((!FOGIOGKLNIP.DGMBIMMABNO) ? 100 : 1000))
		{
			FOGIOGKLNIP.EDBEJGJJDDA = 0;
		}
		if (base.JNPCOJFBJGP && LDAKBEMPLEB.All((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == BDHHGHOGGIJ.JGECOECAJLK) && JDFKPOMKMNJ.NFMIBMIGJMH(10000) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && !FOGIOGKLNIP.OMMLFOEPEEK && DEPCHIFBFHJ)
		{
			FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("you can Add bots from menu");
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI) && LDAKBEMPLEB.Count == 1 && JDFKPOMKMNJ.NFMIBMIGJMH(5000))
		{
			FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("Waiting for players");
		}
		if (LAOFKFBJDGJ.NKPNJDBLBAI > 5000)
		{
			OENODCJHEOG();
		}
		if (base.NENPALDENAL && FOGIOGKLNIP.PIOANBBCFFP.LDAKBEMPLEB.AnyF((JDILMODHLOJ AEMBPMJMOAB) => ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.CMFHKELIOEA) > 49) && JDFKPOMKMNJ.NFMIBMIGJMH(5000))
		{
			NCHOPAEKPBK(JLJDIGNIEOL);
		}
		if (base.NENPALDENAL && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.NBFGNGGJDNB) && JDFKPOMKMNJ.NFMIBMIGJMH(1000) && Time.time - ObscuredFloat.FNIPJFGEFFD(KCMEHLKGPJM) > 10f && FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) == 0 && FBFOHOIFJGL.Count > 0)
		{
			KKJBDENNKGF kKJBDENNKGF = FBFOHOIFJGL.Random();
			kKJBDENNKGF.BJDCCKHBENA.NCHOPAEKPBK(kKJBDENNKGF.BJDCCKHBENA.NNGDFDLFDKL);
		}
		if (JDFKPOMKMNJ.NFMIBMIGJMH(300) && FOGIOGKLNIP.PIOANBBCFFP.DOLHNPFJNNE.childCount > ((!FOGIOGKLNIP.DGMBIMMABNO) ? 6 : 3))
		{
			UnityEngine.Object.Destroy(FOGIOGKLNIP.PIOANBBCFFP.DOLHNPFJNNE.GetChild(0).gameObject);
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.CODAPFIJMCK > 0 && !FOGIOGKLNIP.LPLJMLGKCLK.DKHCDLFJMPA)
		{
			int num4 = 0;
			if (ALGCOODNDLI == null || JDFKPOMKMNJ.NFMIBMIGJMH(500))
			{
				ALGCOODNDLI = FBFOHOIFJGL.OrderByF((KKJBDENNKGF AEMBPMJMOAB) => (FOGIOGKLNIP.NGFDFPGNDCJ.ELGIKGAIIOD - AEMBPMJMOAB.ELGIKGAIIOD).magnitude).ToArray();
			}
			KKJBDENNKGF[] aLGCOODNDLI = ALGCOODNDLI;
			foreach (KKJBDENNKGF kKJBDENNKGF2 in aLGCOODNDLI)
			{
				if (kKJBDENNKGF2 != null)
				{
					kKJBDENNKGF2.HILEAJFAFME(num4 >= FOGIOGKLNIP.LPLJMLGKCLK.CODAPFIJMCK);
					if (ObscuredBool.FNIPJFGEFFD(kKJBDENNKGF2.CGCEAEFHDIF))
					{
						num4++;
					}
				}
			}
		}
		if (!FOGIOGKLNIP.LBJBBGEDGJF.enabled)
		{
			FOGIOGKLNIP.EHBNELHGBHE = string.Empty;
		}
		if (FOGIOGKLNIP.CIEBMCOJGCC.MLHAKCNNICE != 0f)
		{
			FOGIOGKLNIP.CIEBMCOJGCC.FCAMAANKFHO.enabled = true;
			FOGIOGKLNIP.CIEBMCOJGCC.FCAMAANKFHO.color = new Color(255f, 255f, 255f, FOGIOGKLNIP.CIEBMCOJGCC.MLHAKCNNICE);
			FOGIOGKLNIP.CIEBMCOJGCC.MLHAKCNNICE = Mathf.Max(0f, FOGIOGKLNIP.CIEBMCOJGCC.MLHAKCNNICE - Time.deltaTime / 2f);
		}
		else
		{
			FOGIOGKLNIP.CIEBMCOJGCC.FCAMAANKFHO.enabled = false;
		}
		if (FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.ELKBOHAOPDL(30))
		{
			FOGIOGKLNIP.CIEBMCOJGCC.MEOCNPMBPKE.SetActive(false);
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
		if (FOGIOGKLNIP.LPLJMLGKCLK.MGIJCPBGLAM.OACFFKENAKG || FOGIOGKLNIP.LPLJMLGKCLK.FAPLGJOHDGD.OACFFKENAKG)
		{
			Application.Quit();
		}
	}

	public KKJBDENNKGF DMAILAJDJLD(Vector3 ELGIKGAIIOD)
	{
		JDILMODHLOJ component = ICONFJBEJPN(HLMDBACNBCD, Vector3.zero, Quaternion.identity, 0).GetComponent<JDILMODHLOJ>();
		component.NCHOPAEKPBK(component.GMBLKDCLAEH, true);
		component.GHKPKNMDMLH = IBOGNCENEHO.FDGPLHOFOEN;
		component.NCHOPAEKPBK(component.ONAEOFBDAML, (component.GHKPKNMDMLH != IBOGNCENEHO.FDGPLHOFOEN) ? component.GHKPKNMDMLH.ToString() : BEMOMLIBFAL.DAKAIOJHOMK.Random());
		component.NCHOPAEKPBK(component.ONAEOFBDAML, (component.GHKPKNMDMLH != IBOGNCENEHO.FDGPLHOFOEN) ? component.GHKPKNMDMLH.ToString() : BEMOMLIBFAL.DAKAIOJHOMK.Random());
		component.NCHOPAEKPBK(component.INKCDEBODNE, 2);
		return JNPIKJAGHFI(component, IFLCIAMAFAL, ELGIKGAIIOD, Vector3.zero);
	}

	public void HGHGHLHBAMA(GameObject KDGGJCAEKLJ, string KLLKONMADKA)
	{
		if (!NBLJJDANCFG)
		{
			KLFJFGMOPCG kLFJFGMOPCG = KDGGJCAEKLJ.AddComponent<KLFJFGMOPCG>();
			kLFJFGMOPCG.JBLHHCNLIAJ = KDGGJCAEKLJ.transform;
			kLFJFGMOPCG.OKMPLMOAMCL = FOGIOGKLNIP.PIOANBBCFFP.MKBEEIBKJKK.gameObject;
			kLFJFGMOPCG.MEKJFIOEDPI = KLLKONMADKA;
		}
	}

	public void DAIJNHOJGPD(GameObject LCBKHLLPIGM, Color FCCPLGMNKOK, bool MKBEEIBKJKK = false, string BOLCJDBKMCA = null)
	{
		if (!NBLJJDANCFG)
		{
			if ((!MKBEEIBKJKK && BDHHGHOGGIJ.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) || BDHHGHOGGIJ.JGECOECAJLK == GNMHJEPNHDL.Terrorists)
			{
				KLFJFGMOPCG kLFJFGMOPCG = LCBKHLLPIGM.AddComponent<KLFJFGMOPCG>();
				kLFJFGMOPCG.JBLHHCNLIAJ = LCBKHLLPIGM.transform;
				kLFJFGMOPCG.OKMPLMOAMCL = FOGIOGKLNIP.PIOANBBCFFP.BMFJLKHEFCE.gameObject;
				kLFJFGMOPCG.OKMPLMOAMCL.GetComponent<Image>().color = FCCPLGMNKOK;
			}
			if (MKBEEIBKJKK)
			{
				KLFJFGMOPCG kLFJFGMOPCG2 = LCBKHLLPIGM.AddComponent<KLFJFGMOPCG>();
				kLFJFGMOPCG2.JBLHHCNLIAJ = LCBKHLLPIGM.transform;
				kLFJFGMOPCG2.OKMPLMOAMCL = FOGIOGKLNIP.PIOANBBCFFP.MKBEEIBKJKK.gameObject;
				kLFJFGMOPCG2.MEKJFIOEDPI = BOLCJDBKMCA;
				kLFJFGMOPCG2.OKMPLMOAMCL.GetComponent<Text>().color = FCCPLGMNKOK;
			}
		}
	}

	public void MOAOGLECILB()
	{
		if (LDAKBEMPLEB.CountF((JDILMODHLOJ AEMBPMJMOAB) => !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK)) > 3)
		{
			JDILMODHLOJ bDHHGHOGGIJ = BDHHGHOGGIJ;
			bDHHGHOGGIJ.NOOIOCJIIKI = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(bDHHGHOGGIJ.NOOIOCJIIKI) + 1);
			BDHHGHOGGIJ.NCHOPAEKPBK(BDHHGHOGGIJ.FBBDIENBDGM, FOGIOGKLNIP.EELPLHEEEDB("capture", 2000));
		}
	}

	public void HAFCMAMMPIJ(string KLLKONMADKA, bool HAPECBFBAEJ = false)
	{
		FOGIOGKLNIP.CIEBMCOJGCC.MGDLCDBFHCG(FOGIOGKLNIP.FHHPMGJCHJL(KLLKONMADKA), HAPECBFBAEJ);
	}

	public void HEAILALIKJF()
	{
		NILPEEFBMGG.text = FOGIOGKLNIP.FHHPMGJCHJL("Alive: ") + LDAKBEMPLEB.CountF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) + "/" + FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists);
		BMGBHOPHKHK.text = FOGIOGKLNIP.FHHPMGJCHJL("Alive: ") + LDAKBEMPLEB.CountF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists) + "/" + FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists);
		KCBKCAMJLIJ.text = FOGIOGKLNIP.FHHPMGJCHJL("Spectators") + ": " + string.Join(", ", LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Spectators).SelectF((JDILMODHLOJ LCBKHLLPIGM) => LCBKHLLPIGM.name).ToArray());
		OHEOOMNMFNF.text = LHHAGHFGCNI(OCCOEHJFDKM, LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists || AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Zombies).OrderByDescendingF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.CMFHKELIOEA));
		GPNCCKIBDMJ.text = LHHAGHFGCNI(ALKHJOFJBNE, LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists).OrderByDescendingF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.CMFHKELIOEA));
	}

	private string LHHAGHFGCNI(HGGEPCICFGM OCCOEHJFDKM, IEnumerable<JDILMODHLOJ> NEBBPAIKHIG)
	{
		OCCOEHJFDKM.GFJGDEKLFNB();
		foreach (JDILMODHLOJ item in NEBBPAIKHIG)
		{
			OCCOEHJFDKM.EJJKCHAENEP(string.Format("{0,-4}{1,-42}{2,-7}{3,-4}{4,-2}\n", item.NKKOOOHPOOJ, item.JIAPBCDODBJ(false, true, false), item.JCMCPIPHDHB, item.CMFHKELIOEA, item.BLGILFLFHNI));
		}
		return OCCOEHJFDKM.ToString();
	}

	public void HGJDEFGPJCK()
	{
	}

	private void CGHFJBMDHCN(StringBuilder OCCOEHJFDKM, string HHFHHFMOIHP, IEnumerable<JDILMODHLOJ> NEBBPAIKHIG)
	{
		foreach (JDILMODHLOJ item in NEBBPAIKHIG)
		{
			string text = item.JIAPBCDODBJ(false, true, false);
			OCCOEHJFDKM.AppendLine(string.Format(HHFHHFMOIHP, text, string.Empty, item.CMFHKELIOEA, item.BLGILFLFHNI, item.NKKOOOHPOOJ, item.FJFGMFFDGFP, string.Empty, ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.JGJGKDGFFAA) ? item.DKECANJBEBG : 0, string.Empty));
		}
	}

	public void IAKGALFPPJL(Vector3 ELGIKGAIIOD, float JMOJLNOLIMC, bool GHJAKBPKAPD = false)
	{
		Collider[] array = Physics.OverlapSphere(ELGIKGAIIOD, 10f);
		if (FOGIOGKLNIP.LPLJMLGKCLK.LHLPDGMPKCG)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			Rigidbody component = array[i].GetComponent<Rigidbody>();
			if (component != null && !component.isKinematic && array[i].enabled)
			{
				component.AddExplosionForce(JMOJLNOLIMC * base.BILHMMNDCKA, ELGIKGAIIOD, 5f);
			}
		}
	}

	public void OIEPGDHAPAF()
	{
		CFKCJLFCCDM *= FOGIOGKLNIP.LPLJMLGKCLK.LMFBKPAKLAP;
	}

	public Vector3 OEBNLFODLDB()
	{
		if (DALNPKPJAJF || FOGIOGKLNIP.CIEBMCOJGCC.CDBHMBHFDGI)
		{
			return Vector3.zero;
		}
		float num = FOGIOGKLNIP.LPLJMLGKCLK.GHEIOMKADNN;
		float num2 = FOGIOGKLNIP.LPLJMLGKCLK.AMMJIPDNCPG;
		Touch[] hJDAJDIIMPD = FOGIOGKLNIP.HJDAJDIIMPD;
		for (int i = 0; i < hJDAJDIIMPD.Length; i++)
		{
			Touch fJBCDEPOGDF = hJDAJDIIMPD[i];
			Vector2 vector = ((!FOGIOGKLNIP.LPLJMLGKCLK.AICIJPIMOLH) ? fJBCDEPOGDF.deltaPosition : (fJBCDEPOGDF.position - MKGLALKPPGG[fJBCDEPOGDF.fingerId % 20].position));
			if (DADEBIFAPMF(fJBCDEPOGDF) || (FOGIOGKLNIP.LPLJMLGKCLK.CACDJKOKMKF && !(vector.magnitude - EDKILOHEDJM < FOGIOGKLNIP.LPLJMLGKCLK.MDJJENIIEIK)))
			{
				continue;
			}
			if ((!FOGIOGKLNIP.LPLJMLGKCLK.CACDJKOKMKF || FCBCGKBOMAH == TouchPhase.Moved) && (fJBCDEPOGDF.phase == TouchPhase.Moved || fJBCDEPOGDF.phase == TouchPhase.Stationary))
			{
				EDKILOHEDJM = vector.magnitude;
				if (!FOGIOGKLNIP.LPLJMLGKCLK.JDLEAJFAMMG)
				{
					return new Vector3((0f - vector.y) * num * 0.5f, vector.x * num2, 0f);
				}
				Vector2 vector2 = vector;
				vector2.y /= 2f;
				CFKCJLFCCDM += vector2 * 0.4f;
				break;
			}
			FCBCGKBOMAH = fJBCDEPOGDF.phase;
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.JDLEAJFAMMG)
		{
			return Vector3.zero;
		}
		return new Vector3((0f - CFKCJLFCCDM.y) * num, CFKCJLFCCDM.x * num2, 0f);
	}

	public Vector3 OCBEKDFIAIG()
	{
		Vector2 vector = new Vector2(FOGIOGKLNIP.EPBMIIPELPO.PPECHIJCLHO(KeyCode.J) + FOGIOGKLNIP.EPBMIIPELPO.PPECHIJCLHO(KeyCode.L), 0f - FOGIOGKLNIP.EPBMIIPELPO.PPECHIJCLHO(KeyCode.I) - FOGIOGKLNIP.EPBMIIPELPO.PPECHIJCLHO(KeyCode.K)) * 0.3f;
		if (!base.MJEAIGGPIKN)
		{
			vector += new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
		}
		Vector3 result = new Vector3((0f - vector.y) * FOGIOGKLNIP.LPLJMLGKCLK.GHEIOMKADNN * 8f, vector.x * FOGIOGKLNIP.LPLJMLGKCLK.AMMJIPDNCPG * 8f, 0f);
		result.x -= IMCFHFOJDDP.y;
		result.y += IMCFHFOJDDP.x;
		IMCFHFOJDDP = Vector2.zero;
		return result;
	}

	public Vector3 MGJOEFJBALC()
	{
		Vector3 vector = Vector3.zero;
		Touch[] hJDAJDIIMPD = FOGIOGKLNIP.HJDAJDIIMPD;
		for (int i = 0; i < hJDAJDIIMPD.Length; i++)
		{
			Touch touch = hJDAJDIIMPD[i];
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				Vector2 vector2 = FOGIOGKLNIP.CIEBMCOJGCC.JNMCNEKEAFH.transform.position;
				Vector2 position = touch.position;
				if (FOGIOGKLNIP.OMMLFOEPEEK)
				{
					position.y += 40f;
				}
				position.x /= Screen.width;
				position.y /= Screen.height;
				if ((position - vector2).magnitude < FOGIOGKLNIP.LPLJMLGKCLK.KEEOGKIBGCO * FOGIOGKLNIP.CIEBMCOJGCC.JNMCNEKEAFH.transform.localScale.x)
				{
					vector = position - vector2;
					vector.x = Mathf.Pow(Math.Abs(vector.x), 1.3f) * (float)((!(vector.x < 0f)) ? 1 : (-1));
					vector.y = Mathf.Pow(Math.Abs(vector.y), 1.3f) * (float)((!(vector.y < 0f)) ? 1 : (-1));
					vector.y *= 0.2f * FOGIOGKLNIP.LPLJMLGKCLK.GHEIOMKADNN * ObscuredFloat.FNIPJFGEFFD(DDHJEHMOINN) * Time.deltaTime * 100f;
					vector.x *= FOGIOGKLNIP.LPLJMLGKCLK.AMMJIPDNCPG * ObscuredFloat.FNIPJFGEFFD(DDHJEHMOINN) * Time.deltaTime * 100f;
				}
			}
		}
		return new Vector3(0f - vector.y, vector.x);
	}

	public GameObject ELKMMPDEDAK(IBOGNCENEHO EBMKGCIKJCA)
	{
		switch (EBMKGCIKJCA)
		{
		case IBOGNCENEHO.FDGPLHOFOEN:
		case IBOGNCENEHO.Kamikaze:
			return IFLCIAMAFAL;
		case IBOGNCENEHO.Monster:
			return GCDMEBGCFAO;
		case IBOGNCENEHO.Fatty:
			return OJPPDGGMHBB;
		default:
			return IFLCIAMAFAL;
		}
	}

	public Vector3 OKANFELAGDE()
	{
		UnityEngine.Debug.DrawLine(DHHNIGKHPLC, BLNEKFBHKJB, Color.yellow, 10f);
		for (int i = 0; i < 20; i++)
		{
			Vector3 origin = new Vector3(UnityEngine.Random.Range(DHHNIGKHPLC.x, BLNEKFBHKJB.x), BLNEKFBHKJB.y, UnityEngine.Random.Range(DHHNIGKHPLC.z, BLNEKFBHKJB.z));
			RaycastHit[] array = Physics.RaycastAll(origin, Vector3.down, 1000f, 1024);
			if (array.Length > 0)
			{
				return array.Random().point;
			}
		}
		return LOCHJEFJLJG.position;
	}

	public Transform MAMMBEFMKIP(GNMHJEPNHDL JGECOECAJLK, SpawnPlayer[] OPBPNCKLKKN)
	{
		AEJIOHJLOGE aEJIOHJLOGE = new AEJIOHJLOGE();
		aEJIOHJLOGE.JGECOECAJLK = JGECOECAJLK;
		aEJIOHJLOGE.MMPHADBLLCL = FBFOHOIFJGL.WhereF(aEJIOHJLOGE.BEKJDJFLJJC);
		if (!aEJIOHJLOGE.MMPHADBLLCL.AnyF())
		{
			return OPBPNCKLKKN.Random().transform;
		}
		SpawnPlayer[] source = OPBPNCKLKKN.OrderByDescendingF(aEJIOHJLOGE.PMBKBKJIIPO);
		return source.TakeF(4).Random().transform;
	}

	public Vector3 DKINKFKKMGH(GNMHJEPNHDL JGECOECAJLK, GameObject[] OPBPNCKLKKN)
	{
		MHLLKMGDEIK mHLLKMGDEIK = new MHLLKMGDEIK();
		mHLLKMGDEIK.JGECOECAJLK = JGECOECAJLK;
		mHLLKMGDEIK.MMPHADBLLCL = FBFOHOIFJGL.WhereF(mHLLKMGDEIK.BEKJDJFLJJC);
		if (!mHLLKMGDEIK.MMPHADBLLCL.AnyF())
		{
			return OPBPNCKLKKN.Random().transform.position;
		}
		GameObject[] source = OPBPNCKLKKN.OrderByDescendingF(mHLLKMGDEIK.PMBKBKJIIPO);
		return source.TakeF(4).Random().transform.position;
	}

	public void GLIKJPMJAMJ()
	{
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA))
		{
			JDILMODHLOJ jDILMODHLOJ = LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists && AEMBPMJMOAB.NJEPMOIDJKH != null).Random();
			if (jDILMODHLOJ != null && jDILMODHLOJ.NJEPMOIDJKH is FDGPLHOFOEN)
			{
				jDILMODHLOJ.NJEPMOIDJKH.NCHOPAEKPBK((jDILMODHLOJ.NJEPMOIDJKH as FDGPLHOFOEN).LPNELEDEPNF);
			}
		}
	}

	public void GGCHLNODFBJ(string KFOKMHAOMAD)
	{
	}

	public void MPDAHJDEDKG(string NFFPPKLIPBC)
	{
		FOGIOGKLNIP.PIOANBBCFFP.DMFHMHNAOOP.text = NFFPPKLIPBC;
		FOGIOGKLNIP.PIOANBBCFFP.DMFHMHNAOOP.GetComponent<Animation>().Stop();
		FOGIOGKLNIP.PIOANBBCFFP.DMFHMHNAOOP.GetComponent<Animation>().Rewind();
		FOGIOGKLNIP.PIOANBBCFFP.DMFHMHNAOOP.GetComponent<Animation>().Play();
	}

	public void EANJGEKHMPD(IBOGNCENEHO EBMKGCIKJCA, GNMHJEPNHDL JGECOECAJLK)
	{
		NEEJKACNENE nEEJKACNENE = new NEEJKACNENE();
		nEEJKACNENE.JGECOECAJLK = JGECOECAJLK;
		nEEJKACNENE.EBMKGCIKJCA = EBMKGCIKJCA;
		JDILMODHLOJ jDILMODHLOJ = LDAKBEMPLEB.FirstOrDefaultF(nEEJKACNENE.BEKJDJFLJJC);
		if (jDILMODHLOJ != null)
		{
			if (jDILMODHLOJ.NJEPMOIDJKH != null)
			{
				jDILMODHLOJ.NJEPMOIDJKH.APAMPKPNIPC();
			}
			jDILMODHLOJ.APAMPKPNIPC();
			MIDPJKEMHNI = ObscuredInt.LNCBKFJDIII(MIDPJKEMHNI);
		}
	}

	public void FBBOBGFEBJE(JDILMODHLOJ[] KJAJMAKINCK, bool MDLKNOJDEHG = false)
	{
		foreach (JDILMODHLOJ jDILMODHLOJ in KJAJMAKINCK)
		{
			if (jDILMODHLOJ.NJEPMOIDJKH != null && MDLKNOJDEHG)
			{
				jDILMODHLOJ.NJEPMOIDJKH.APAMPKPNIPC();
			}
			if (jDILMODHLOJ != null)
			{
				jDILMODHLOJ.APAMPKPNIPC();
			}
			MIDPJKEMHNI = ObscuredInt.LNCBKFJDIII(MIDPJKEMHNI);
		}
	}

	public Vector3 PHFPHLLPFDM()
	{
		if (!AndroidInput.secondaryTouchEnabled)
		{
			return Vector3.zero;
		}
		Vector2 vector = Vector3.zero;
		for (int i = 0; i < AndroidInput.touchCountSecondary; i++)
		{
			Touch secondaryTouch = AndroidInput.GetSecondaryTouch(i);
			if (secondaryTouch.phase == TouchPhase.Moved || secondaryTouch.phase == TouchPhase.Stationary)
			{
				vector += secondaryTouch.position - PNCFKKICDCE[secondaryTouch.fingerId % 20].position;
			}
			PNCFKKICDCE[secondaryTouch.fingerId % 20] = secondaryTouch;
		}
		Vector3 vector2 = new Vector3(vector.y * 0.5f * FOGIOGKLNIP.LPLJMLGKCLK.GHEIOMKADNN, vector.x * FOGIOGKLNIP.LPLJMLGKCLK.AMMJIPDNCPG);
		return vector2 / 4f;
	}

	public void OnDestroy()
	{
		KBABLNHMAFN = true;
		if (!FOGIOGKLNIP.CJOGLBBCDEC || FOGIOGKLNIP.OMMLFOEPEEK)
		{
			NGOAGFOGFEF();
		}
	}

	public void OnJoinedLobby()
	{
		if (PhotonNetwork.GetRoomList().Length == 0)
		{
			PhotonNetwork.CreateRoom("Test" + FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP, false, true, 10);
		}
	}

	public void OnPlayerDisconnected(NetworkPlayer NJEPMOIDJKH)
	{
		Network.RemoveRPCs(NJEPMOIDJKH);
		Network.DestroyPlayerObjects(NJEPMOIDJKH);
	}

	public void OnDisconnectedFromServer(NetworkDisconnection LIEKABKEJOG)
	{
		OnLeftRoom();
	}

	public void OnDisconnectedFromPhoton()
	{
		MonoBehaviour.print("OnDisconnectedFromPhoton");
		OnLeftRoom();
	}

	public void IHHIPFNKCIJ()
	{
		PhotonNetwork.JoinRoom("Test" + FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP);
	}

	public void OnPhotonCreateRoomFailed()
	{
		PhotonNetwork.JoinRoom("Test" + FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP);
	}

	public void HFDMPBMOFLC()
	{
		Network.Disconnect();
		MEJCNDKKNBP = true;
	}

	public void OnLeftRoom()
	{
		if (!MEJCNDKKNBP)
		{
			MEJCNDKKNBP = true;
			if (BDHHGHOGGIJ != null && !ObscuredBool.FNIPJFGEFFD(DJBGAOOAGEO))
			{
				CBNDGGBCGCH();
			}
			base.MDBAFPKAKKK = false;
			SceneManager.LoadScene("0");
		}
	}

	public void OnConnectedToServer()
	{
		KDANBJBIGKL();
	}

	public void OnJoinedRoom()
	{
		KDANBJBIGKL();
	}

	public void OnServerInitialized()
	{
		KDANBJBIGKL();
	}

	public override void BJGMKFIGEFA()
	{
		HBCEJOJNMNB(EIFOECIOEAA, (int)FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD);
		HBCEJOJNMNB(DFALJEHMLOP, OEIIKDFMDGJ, GIAONHLJAGE);
		HBCEJOJNMNB(EPKKLODNHMM, FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF), FOGIOGKLNIP.LPLJMLGKCLK.IMHMMKJKCBK);
		HBCEJOJNMNB(PNBBDANLPAD, ObscuredBool.FNIPJFGEFFD(DJBGAOOAGEO));
		HBCEJOJNMNB(BBAOFHPHGOA, ObscuredFloat.FNIPJFGEFFD(HDGCFPAMGKE));
		HBCEJOJNMNB(GHANHHOHGGJ, ObscuredFloat.FNIPJFGEFFD(COGEDCIBHMA));
		HBCEJOJNMNB(GEJBHJGINDP, ObscuredFloat.FNIPJFGEFFD(OHGEMABOIBK));
		HBCEJOJNMNB(HDDBKANKMLG, ObscuredFloat.FNIPJFGEFFD(NBKGCKPKBOC));
		HBCEJOJNMNB(COALDLJKKEF, ObscuredFloat.FNIPJFGEFFD(MIGCKAPHANN));
		HBCEJOJNMNB(DJGDLBMGMDI, ObscuredBool.FNIPJFGEFFD(LMCLODHEIGA));
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
		{
			HBCEJOJNMNB(GHGMNANNEIN, ObscuredFloat.FNIPJFGEFFD(NGNMLDCDOPC));
			HBCEJOJNMNB(FHJBCMDJDLP, DFFLEKBAJKC);
			HBCEJOJNMNB(FMDGJPGKLGN, ObscuredFloat.FNIPJFGEFFD(FPFAEOJAIBB));
			HBCEJOJNMNB(GHONKCAINHD, ObscuredFloat.FNIPJFGEFFD(HJNMHAGEEPC));
			HBCEJOJNMNB(CANDBHDGDLE, ObscuredFloat.FNIPJFGEFFD(JFLGCMGFGHF));
			HBCEJOJNMNB(AHODPOGMMMM, ObscuredFloat.FNIPJFGEFFD(LGIOALGFFHP));
			HBCEJOJNMNB(KOMBGAONLJB, ObscuredFloat.FNIPJFGEFFD(AJFFDIHCJNL));
			HBCEJOJNMNB(JFIHFFHFDCJ, ObscuredBool.FNIPJFGEFFD(DOMONNBOMNP));
			HBCEJOJNMNB(IKIBHKEEICI, JGAFAIDLHOP);
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.NBFGNGGJDNB))
		{
			HBCEJOJNMNB(PCJAHJELDJJ, ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IJFJBIKHEDL));
			HBCEJOJNMNB(IIKCMBEEKKP, ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.EKEMIEEFILP));
		}
		HBCEJOJNMNB(EOBGENFFMOJ, IHHLGEIECBI);
		HBCEJOJNMNB(BOHGAGGCMFB, ObscuredBool.FNIPJFGEFFD(JFFHDKCBBEA));
		HBCEJOJNMNB(AJBMECPCOMH, ObscuredBool.FNIPJFGEFFD(IHCFILFBIJF));
		HBCEJOJNMNB(NHMLKOPHKEK, ObscuredBool.FNIPJFGEFFD(MDDBCIILKHG));
		HBCEJOJNMNB(BBKJAMHFKCE, ObscuredFloat.FNIPJFGEFFD(EBJHGFLAOAL));
		HBCEJOJNMNB(MGNKJMMOJDO, ObscuredFloat.FNIPJFGEFFD(EMKLPBIJILF));
		HBCEJOJNMNB(CGIKHLOECDM, ObscuredFloat.FNIPJFGEFFD(JDFKPCHDKIJ));
		HBCEJOJNMNB(DEHLGLOKEMN, ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI));
		HBCEJOJNMNB(FFDJIPIGGPO, ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.LIMCHPFAJHC), ObscuredFloat.FNIPJFGEFFD(JFMNIDEDNHG), ObscuredFloat.FNIPJFGEFFD(DEBNBJBLEDJ));
		HBCEJOJNMNB(BDLBAKEHMHC, ObscuredFloat.FNIPJFGEFFD(BMKALMOPDKI));
		HBCEJOJNMNB(OEHKBODPIFO, ObscuredFloat.FNIPJFGEFFD(FPIHOOAEDEN));
		HBCEJOJNMNB(IAOIBLMFCGG, KLGAIEEIICF);
		HBCEJOJNMNB(NKDPOGLBBJG, DCEJABDJMLM);
		HBCEJOJNMNB(LKAFFMFPFMK, ObscuredBool.FNIPJFGEFFD(ANPPCHMLKNF));
		HBCEJOJNMNB(AHIMMAAKMAC, ObscuredFloat.FNIPJFGEFFD(DCHKOIHONPN));
		HBCEJOJNMNB(IALMCAFGHCE, ObscuredBool.FNIPJFGEFFD(CKAJCPDFAGC));
		HBCEJOJNMNB(LKLADDOHJHM, ObscuredBool.FNIPJFGEFFD(JABHAJEEFNO));
		HBCEJOJNMNB(NHOKJIGMDCF, ObscuredBool.FNIPJFGEFFD(GFPOMBMNDIO));
		if (ObscuredBool.FNIPJFGEFFD(LECIFFENJMA))
		{
			HBCEJOJNMNB(JKJJBGCMEMI, ObscuredBool.FNIPJFGEFFD(LECIFFENJMA));
		}
		KeyValuePair<KeyValuePair<string, string>, float>[] array = HNPEILDDGID.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			KeyValuePair<KeyValuePair<string, string>, float> keyValuePair = array[i];
			HBCEJOJNMNB(CKMBCMGMGCL, keyValuePair.Key.Key, keyValuePair.Key.Value, keyValuePair.Value);
		}
		for (int j = 0; j < GGPOLOMIGOI.Count; j++)
		{
			EJDKALEIBBG eJDKALEIBBG = GGPOLOMIGOI[j];
			HBCEJOJNMNB(IKCJHHMPALL, eJDKALEIBBG.MGFENAGABOE, eJDKALEIBBG.CMPKOEMBHDO, eJDKALEIBBG.JJHIFNAJIBK, eJDKALEIBBG.FPNFMBGAFDE, eJDKALEIBBG.PLDMNFCBFDD, eJDKALEIBBG.DECONHBIJAA, eJDKALEIBBG.EHOEFMPLIFB.position, eJDKALEIBBG.EHOEFMPLIFB.rotation, Vector3.zero);
		}
	}

	private void KDANBJBIGKL()
	{
		DALNPKPJAJF = true;
		BDHHGHOGGIJ = ICONFJBEJPN(HLMDBACNBCD, Vector3.zero, Quaternion.identity, 0).GetComponent<JDILMODHLOJ>();
		BDHHGHOGGIJ.NCHOPAEKPBK(BDHHGHOGGIJ.ONAEOFBDAML, FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD);
		if (base.NENPALDENAL && FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			for (int i = 0; i < 100; i++)
			{
				HCNJDLNHFIF("ENADPBHGCME", Network.AllocateViewID());
			}
			HCNJDLNHFIF("NHEHOODOEPL");
		}
		BPILKECDLJP();
		GGCHLNODFBJ(FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO);
	}

	public override void AILPFINEAEK()
	{
		base.AILPFINEAEK();
	}

	public void OnMasterClientSwitched(PhotonPlayer CNCIECEMCDC)
	{
		KLKOJNMNCJO = false;
		if (PhotonNetwork.isMasterClient)
		{
			FNFKLBLIJAF(CNCIECEMCDC.name + FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.Gameishostnow));
		}
	}

	public void INNBPKJCELB(RaycastHit MBIEHEGKCMN)
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.MOIFEJDLHOK && CNLHEJPILGH(MBIEHEGKCMN.point))
		{
			FOGIOGKLNIP.EDBEJGJJDDA++;
			if (GKPGFLEBIIA != null)
			{
				GKPGFLEBIIA.transform.position = MBIEHEGKCMN.point;
				GKPGFLEBIIA.transform.rotation = Quaternion.LookRotation(MBIEHEGKCMN.normal);
				GKPGFLEBIIA.Emit(10);
			}
			else
			{
				GKPGFLEBIIA = JMJLEDGJIJK("Blood", "Particles/", true, null, null, MBIEHEGKCMN.point, Quaternion.LookRotation(MBIEHEGKCMN.normal)).GetComponent<ParticleSystem>();
				GKPGFLEBIIA.Emit(10);
			}
		}
	}

	public void DDOFLINNNOB(RaycastHit MBIEHEGKCMN)
	{
		if (KNOPBFCKBNP != null)
		{
			KNOPBFCKBNP.transform.position = MBIEHEGKCMN.point;
			KNOPBFCKBNP.transform.rotation = Quaternion.LookRotation(MBIEHEGKCMN.normal);
			KNOPBFCKBNP.Emit(15);
		}
		else
		{
			KNOPBFCKBNP = JMJLEDGJIJK("ImpactDefault", "Particles/", true, null, null, MBIEHEGKCMN.point, Quaternion.LookRotation(MBIEHEGKCMN.normal)).GetComponent<ParticleSystem>();
			KNOPBFCKBNP.Emit(15);
		}
	}

	public void ILHECNMAKBN(string FHOJEDFGONO, bool EHAPKEKPMOE)
	{
		NCHOPAEKPBK((Action<string, string, float>)CKMBCMGMGCL, "!Game", FHOJEDFGONO, (float)(EHAPKEKPMOE ? 1 : 0));
	}

	[RPC]
	public void NHEHOODOEPL()
	{
		try
		{
			int num = 0;
			foreach (Transform item in from AEMBPMJMOAB in GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.JPKDBLPOCFE).Union(GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.AONMDPFGOIB))
				select AEMBPMJMOAB.transform into AEMBPMJMOAB
				orderby AEMBPMJMOAB.position.magnitude
				select AEMBPMJMOAB)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(FLAGKLELOFK);
				int result;
				if (int.TryParse(item.name, out result))
				{
					gameObject.GetComponent<PMDPIINLPHK>().BHFDJDDGHKA = result;
				}
				gameObject.transform.position = item.GetComponent<Collider>().bounds.center;
				Transform transform = UnityEngine.Object.Instantiate(item, item.position, item.rotation);
				transform.gameObject.isStatic = false;
				transform.parent = gameObject.transform;
				transform.gameObject.layer = 18;
				item.gameObject.SetActive(false);
				gameObject.transform.parent = null;
				FELHMNGDAPO(++num, gameObject);
			}
			Transform[] array = GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.IAAFAAKBOCC).SelectF((GameObject AEMBPMJMOAB) => AEMBPMJMOAB.transform).OrderByF((Transform AEMBPMJMOAB) => AEMBPMJMOAB.position.magnitude);
			foreach (Transform transform2 in array)
			{
				Collider component = transform2.GetComponent<Collider>();
				GameObject gameObject2 = UnityEngine.Object.Instantiate(CLMIPGCFELH);
				gameObject2.transform.position = component.GetComponent<Collider>().bounds.max;
				Transform transform3 = UnityEngine.Object.Instantiate(transform2, transform2.position, transform2.rotation);
				transform3.gameObject.isStatic = false;
				transform3.gameObject.layer = 28;
				transform3.parent = gameObject2.transform;
				gameObject2.transform.parent = null;
				transform2.gameObject.SetActive(false);
				FELHMNGDAPO(++num, gameObject2);
			}
			GameObject[] array2 = GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.IMDBABIFOIB);
			foreach (GameObject gameObject3 in array2)
			{
				GameObject gameObject4 = UnityEngine.Object.Instantiate(DBJKHPCJFEE, gameObject3.transform.position + Vector3.up * 0.2f, Quaternion.identity);
				gameObject4.transform.parent = CCLAGBBDGDI;
				FELHMNGDAPO(++num, gameObject4);
			}
			GameObject gameObject5 = UnityEngine.Object.Instantiate(AMKDLOAPGCB, LNPHCAOCEBD.position, Quaternion.identity);
			gameObject5.GetComponent<AMKDLOAPGCB>().INKCDEBODNE(true);
			FELHMNGDAPO(++num, gameObject5);
			gameObject5 = UnityEngine.Object.Instantiate(AMKDLOAPGCB, LOCHJEFJLJG.position, Quaternion.identity);
			gameObject5.GetComponent<AMKDLOAPGCB>().INKCDEBODNE(false);
			FELHMNGDAPO(++num, gameObject5);
			int num4 = -1;
			Trigger2[] array3 = UnityEngine.Object.FindObjectsOfType<Trigger2>();
			foreach (Trigger2 trigger in array3)
			{
				num4 = (trigger.Index = num4 + 1);
				JFBCNBMHENO.Add(trigger);
				BKFEGEAEIFB.Add(trigger);
			}
		}
		catch (Exception message)
		{
			UnityEngine.Debug.LogError(message);
		}
	}

	[RPC]
	public void HPHAGGECKKM(int JNDABHCJHHD, NetworkViewID JDKLJHNJNLG)
	{
		HPHAGGECKKM(JNDABHCJHHD, (object)JDKLJHNJNLG);
	}

	[RPC]
	public void HPHAGGECKKM(int JNDABHCJHHD, PhotonViewID JDKLJHNJNLG)
	{
		HPHAGGECKKM(JNDABHCJHHD, (object)JDKLJHNJNLG);
	}

	public void HPHAGGECKKM(int JNDABHCJHHD, object JDKLJHNJNLG)
	{
		if (!JFBCNBMHENO[JNDABHCJHHD].TriggerEnterDone)
		{
			JFBCNBMHENO[JNDABHCJHHD].player_trigger = FOGIOGKLNIP.AAPLAPBIFMD<KKJBDENNKGF>(JDKLJHNJNLG);
			JFBCNBMHENO[JNDABHCJHHD].OnTriggerEnterEvents.Invoke();
		}
		if (JFBCNBMHENO[JNDABHCJHHD].TriggerEnterOnce)
		{
			JFBCNBMHENO[JNDABHCJHHD].TriggerEnterDone = true;
		}
	}

	[RPC]
	public void NAECMNPOFGL(int JNDABHCJHHD, NetworkViewID JDKLJHNJNLG)
	{
		NAECMNPOFGL(JNDABHCJHHD, (object)JDKLJHNJNLG);
	}

	[RPC]
	public void NAECMNPOFGL(int JNDABHCJHHD, PhotonViewID JDKLJHNJNLG)
	{
		NAECMNPOFGL(JNDABHCJHHD, (object)JDKLJHNJNLG);
	}

	public void NAECMNPOFGL(int JNDABHCJHHD, object JDKLJHNJNLG)
	{
		if (!JFBCNBMHENO[JNDABHCJHHD].TriggerExitDone)
		{
			JFBCNBMHENO[JNDABHCJHHD].player_trigger = FOGIOGKLNIP.AAPLAPBIFMD<KKJBDENNKGF>(JDKLJHNJNLG);
			JFBCNBMHENO[JNDABHCJHHD].OnTriggerExitEvents.Invoke();
		}
		if (JFBCNBMHENO[JNDABHCJHHD].TriggerExitOnce)
		{
			JFBCNBMHENO[JNDABHCJHHD].TriggerExitDone = true;
		}
	}

	[RPC]
	public void KCDDIIFNHFN(bool EHOAOMCBGDP)
	{
	}

	[RPC]
	public void MIHDCCDBLMD()
	{
		NGOAGFOGFEF();
		HNPEILDDGID.Clear();
		HKFPMOFOELF.Clear();
		FNFKLBLIJAF(base.FKICDOGJIFN.GameWeaponsettingsReseted);
	}

	[RPC]
	public virtual void CKMBCMGMGCL(string LPDOKONMCCK, string FHOJEDFGONO, float EHAPKEKPMOE, NetworkMessageInfo LIEKABKEJOG)
	{
		if (base.NENPALDENAL)
		{
			if (!NBBHJJELPCP(LIEKABKEJOG.sender))
			{
				UnityEngine.Debug.LogError(string.Format("Detected changes by client(NON-SERVER): IP - {0}", LIEKABKEJOG.sender.ipAddress));
				Network.CloseConnection(LIEKABKEJOG.sender, true);
				{
					foreach (MemberInfo item in FOGIOGKLNIP.PIOANBBCFFP.GetType().GetProperties().Cast<MemberInfo>()
						.Concat(FOGIOGKLNIP.PIOANBBCFFP.GetType().GetFields()))
					{
						if (item.Name == FHOJEDFGONO)
						{
							Type type = ((!(item is FieldInfo)) ? ((PropertyInfo)item).PropertyType : ((FieldInfo)item).FieldType);
							object obj = ((!(item is FieldInfo)) ? ((PropertyInfo)item).GetValue(FOGIOGKLNIP.PIOANBBCFFP, null) : ((FieldInfo)item).GetValue(FOGIOGKLNIP.PIOANBBCFFP));
							UnityEngine.Debug.LogError(item.Name);
							if (type == typeof(bool))
							{
								bool flag = (bool)obj;
								NCHOPAEKPBK(CKMBCMGMGCL, ICIEDCMDJFO.name, FHOJEDFGONO, (!flag) ? 0f : 1f);
							}
							if (type == typeof(ObscuredBool))
							{
								ObscuredBool eHAPKEKPMOE = (ObscuredBool)obj;
								NCHOPAEKPBK(CKMBCMGMGCL, ICIEDCMDJFO.name, FHOJEDFGONO, (!ObscuredBool.FNIPJFGEFFD(eHAPKEKPMOE)) ? 0f : 1f);
							}
							if (type == typeof(int) || type == typeof(float))
							{
								float lFGFNKJJDAO = ((!(type == typeof(int))) ? ((float)obj) : ((float)(int)obj));
								NCHOPAEKPBK(CKMBCMGMGCL, ICIEDCMDJFO.name, FHOJEDFGONO, lFGFNKJJDAO);
							}
							if (type == typeof(ObscuredInt) || type == typeof(ObscuredFloat))
							{
								float lFGFNKJJDAO2 = ObscuredFloat.FNIPJFGEFFD((!(type == typeof(ObscuredInt))) ? ((ObscuredFloat)obj) : ObscuredInt.FNIPJFGEFFD((ObscuredInt)obj));
								NCHOPAEKPBK(CKMBCMGMGCL, ICIEDCMDJFO.name, FHOJEDFGONO, lFGFNKJJDAO2);
							}
						}
					}
					return;
				}
			}
			CKMBCMGMGCL(LPDOKONMCCK, FHOJEDFGONO, EHAPKEKPMOE);
		}
		else
		{
			CKMBCMGMGCL(LPDOKONMCCK, FHOJEDFGONO, EHAPKEKPMOE);
		}
	}

	[RPC]
	public virtual void CKMBCMGMGCL(string LPDOKONMCCK, string FHOJEDFGONO, float EHAPKEKPMOE, PhotonMessageInfo JDKLJHNJNLG)
	{
		if (!JDKLJHNJNLG.sender.isMasterClient)
		{
			if (base.NENPALDENAL)
			{
				PhotonNetwork.CloseConnection(JDKLJHNJNLG.sender);
			}
		}
		else
		{
			CKMBCMGMGCL(LPDOKONMCCK, FHOJEDFGONO, EHAPKEKPMOE);
		}
	}

	public void CKMBCMGMGCL(string LPDOKONMCCK, string FHOJEDFGONO, float EHAPKEKPMOE)
	{
		KEJDEGEGEAN kEJDEGEGEAN = new KEJDEGEGEAN();
		KeyValuePair<string, string> key = new KeyValuePair<string, string>(LPDOKONMCCK, FHOJEDFGONO);
		HNPEILDDGID[key] = EHAPKEKPMOE;
		if (!FOGIOGKLNIP.PIOANBBCFFP.KBBEJPKKHIL.ContainsKey(LPDOKONMCCK))
		{
			throw new Exception(base.FKICDOGJIFN.GameSetCustomValueObjkeynotexists + LPDOKONMCCK);
		}
		kEJDEGEGEAN.JLOJONMILIC = FOGIOGKLNIP.PIOANBBCFFP.KBBEJPKKHIL[LPDOKONMCCK];
		MemberInfo memberInfo = kEJDEGEGEAN.JLOJONMILIC.GetType().GetMember(FHOJEDFGONO).FirstOrDefaultF();
		if (memberInfo == null)
		{
			UnityEngine.Debug.LogError(base.FKICDOGJIFN.GameMembernotfound + LPDOKONMCCK + ":" + FHOJEDFGONO + ":" + EHAPKEKPMOE);
			return;
		}
		object obj = memberInfo.GetCustomAttributes(true).FirstOrDefaultF();
		string key2 = ((!(kEJDEGEGEAN.JLOJONMILIC.name != base.FKICDOGJIFN.GameGamePrefab)) ? string.Empty : (kEJDEGEGEAN.JLOJONMILIC.name + " ")) + ((Field)obj).name + ": ";
		HKFPMOFOELF[key2] = EHAPKEKPMOE;
		Type type = ((!(memberInfo is FieldInfo)) ? ((PropertyInfo)memberInfo).PropertyType : ((FieldInfo)memberInfo).FieldType);
		object obj2 = ((!(memberInfo is FieldInfo)) ? ((PropertyInfo)memberInfo).GetValue(kEJDEGEGEAN.JLOJONMILIC, null) : ((FieldInfo)memberInfo).GetValue(kEJDEGEGEAN.JLOJONMILIC));
		if (!HDELOLGNHNI.ContainsKey(key))
		{
			float value = 0f;
			if (type == typeof(bool))
			{
				value = (((bool)obj2) ? 1 : 0);
			}
			if (type == typeof(float))
			{
				value = (float)obj2;
			}
			if (type == typeof(int))
			{
				value = (int)obj2;
			}
			HDELOLGNHNI.Add(key, value);
		}
		UnityEngine.Object[] array = new FOGIOGKLNIP[1] { kEJDEGEGEAN.JLOJONMILIC }.Union(UnityEngine.Object.FindObjectsOfType(kEJDEGEGEAN.JLOJONMILIC.GetType()).WhereF(kEJDEGEGEAN.BEKJDJFLJJC)).ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			FOGIOGKLNIP obj3 = (FOGIOGKLNIP)array[i];
			try
			{
				if (type == typeof(bool))
				{
					if (memberInfo is FieldInfo)
					{
						((FieldInfo)memberInfo).SetValue(obj3, EHAPKEKPMOE == 1f);
					}
					else
					{
						((PropertyInfo)memberInfo).SetValue(obj3, EHAPKEKPMOE == 1f, null);
					}
				}
				else if (type == typeof(ObscuredBool))
				{
					if (memberInfo is FieldInfo)
					{
						((FieldInfo)memberInfo).SetValue(obj3, ObscuredBool.FNIPJFGEFFD(Convert.ToBoolean(EHAPKEKPMOE == 1f)));
					}
					else
					{
						((PropertyInfo)memberInfo).SetValue(obj3, ObscuredBool.FNIPJFGEFFD(Convert.ToBoolean(EHAPKEKPMOE == 1f)), null);
					}
				}
				else if (type == typeof(int))
				{
					if (memberInfo is FieldInfo)
					{
						((FieldInfo)memberInfo).SetValue(obj3, (int)EHAPKEKPMOE);
					}
					else
					{
						((PropertyInfo)memberInfo).SetValue(obj3, (int)EHAPKEKPMOE, null);
					}
				}
				else if (type == typeof(ObscuredInt))
				{
					if (memberInfo is FieldInfo)
					{
						((FieldInfo)memberInfo).SetValue(obj3, ObscuredInt.FNIPJFGEFFD((int)EHAPKEKPMOE));
					}
					else
					{
						((PropertyInfo)memberInfo).SetValue(obj3, ObscuredInt.FNIPJFGEFFD((int)EHAPKEKPMOE), null);
					}
				}
				else if (type == typeof(ObscuredFloat))
				{
					if (memberInfo is FieldInfo)
					{
						((FieldInfo)memberInfo).SetValue(obj3, ObscuredFloat.FNIPJFGEFFD(EHAPKEKPMOE));
					}
					else
					{
						((PropertyInfo)memberInfo).SetValue(obj3, ObscuredFloat.FNIPJFGEFFD(EHAPKEKPMOE), null);
					}
				}
				else if (memberInfo is FieldInfo)
				{
					((FieldInfo)memberInfo).SetValue(obj3, EHAPKEKPMOE);
				}
				else
				{
					((PropertyInfo)memberInfo).SetValue(obj3, EHAPKEKPMOE, null);
				}
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
			}
		}
	}

	[RPC]
	public void EBCOPJHOFPP(float GDKFLGBMPBB)
	{
	}

	public void HJNCMDLHKNE(int FAGMOBEKJND)
	{
		NCHOPAEKPBK(NLIIPKBIMDP, FAGMOBEKJND);
		if (base.NENPALDENAL)
		{
			if (ObscuredFloat.FNIPJFGEFFD(HDGCFPAMGKE) < 1f)
			{
				NCHOPAEKPBK(BBAOFHPHGOA, ObscuredFloat.FNIPJFGEFFD(HDGCFPAMGKE) + 0.01f);
			}
			if (ObscuredFloat.FNIPJFGEFFD(AJFFDIHCJNL) > 1f)
			{
				NCHOPAEKPBK(KOMBGAONLJB, ObscuredFloat.FNIPJFGEFFD(AJFFDIHCJNL) - 0.1f);
			}
			if (ObscuredFloat.FNIPJFGEFFD(NGNMLDCDOPC) < 360f)
			{
				NCHOPAEKPBK(GHGMNANNEIN, ObscuredFloat.FNIPJFGEFFD(NGNMLDCDOPC) + 8f);
			}
			if (ObscuredFloat.FNIPJFGEFFD(EBJHGFLAOAL) < 1.3f)
			{
				NCHOPAEKPBK(BBKJAMHFKCE, ObscuredFloat.FNIPJFGEFFD(EBJHGFLAOAL) + 0.01f);
			}
			if (ObscuredFloat.FNIPJFGEFFD(JDFKPCHDKIJ) < 5f)
			{
				NCHOPAEKPBK(CGIKHLOECDM, ObscuredFloat.FNIPJFGEFFD(JDFKPCHDKIJ) + 0.04f);
			}
			if (ObscuredFloat.FNIPJFGEFFD(COGEDCIBHMA) < 100f)
			{
				COGEDCIBHMA = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(COGEDCIBHMA) + 10f);
			}
		}
		if (!base.NENPALDENAL || !ObscuredBool.FNIPJFGEFFD(FCFAGFGCEOK))
		{
			return;
		}
		foreach (KKJBDENNKGF item in FBFOHOIFJGL.WhereF((KKJBDENNKGF AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.BJDCCKHBENA.HIBLODEGHAK)))
		{
			if (item != null)
			{
				item.BJDCCKHBENA.APAMPKPNIPC();
				item.APAMPKPNIPC();
			}
		}
	}

	[RPC]
	private void NLIIPKBIMDP(int FAGMOBEKJND)
	{
		foreach (Transform item in MAOFPKAJMGO)
		{
			UnityEngine.Object.Destroy(item.gameObject);
		}
		foreach (Transform item2 in DOLHNPFJNNE)
		{
			UnityEngine.Object.Destroy(item2.gameObject);
		}
		JFMNIDEDNHG = NGNMLDCDOPC;
		FHJBCMDJDLP(FAGMOBEKJND);
		JDFKPOMKMNJ.IPBKDPKONHH(delegate
		{
			if (FOGIOGKLNIP.NMGDHKIKCED == null && BDHHGHOGGIJ.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists)
			{
				FOGIOGKLNIP.PIOANBBCFFP.JNPIKJAGHFI(BDHHGHOGGIJ, FOGIOGKLNIP.PIOANBBCFFP.ELKMMPDEDAK(BDHHGHOGGIJ.GHKPKNMDMLH));
			}
		});
		foreach (KKJBDENNKGF item3 in FBFOHOIFJGL.WhereF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists && ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.BHFDJDDGHKA) < 100))
		{
			item3.BHFDJDDGHKA = ObscuredInt.FNIPJFGEFFD(100);
		}
		if (FOGIOGKLNIP.GMPBCIEDMCD != null)
		{
			FOGIOGKLNIP.GMPBCIEDMCD.DLHLKPMGHOO.CNMKGNNGPDD = FOGIOGKLNIP.GMPBCIEDMCD.DLHLKPMGHOO.ABHFBECBPBA;
			FOGIOGKLNIP.GMPBCIEDMCD.IMAAMLFMKOC();
			FOGIOGKLNIP.GMPBCIEDMCD.NEJKKMBEEIO = ObscuredBool.FNIPJFGEFFD(false);
			IAPJEBKJEHC[] oKDFHJJNFCC = FOGIOGKLNIP.GMPBCIEDMCD.OKDFHJJNFCC;
			foreach (IAPJEBKJEHC iAPJEBKJEHC in oKDFHJJNFCC)
			{
				iAPJEBKJEHC.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(false);
			}
		}
	}

	[RPC]
	public void FHJBCMDJDLP(int FAGMOBEKJND)
	{
		string kLLKONMADKA = FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameRound) + " " + FAGMOBEKJND;
		AFIAEDMAHLP(kLLKONMADKA);
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.SurvivalRound);
		if (!ObscuredBool.FNIPJFGEFFD(CFGAEDNCMJP))
		{
			BMKALMOPDKI = FPIHOOAEDEN;
			FOGIOGKLNIP.LBJBBGEDGJF.GLIDJHPEBLA = true;
		}
		DFFLEKBAJKC = FAGMOBEKJND;
	}

	public void DIHBNECKLBC(int FFCHEIFGPBN, int EDBIPBGEDEK)
	{
		if (ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI))
		{
			return;
		}
		foreach (KKJBDENNKGF item in FBFOHOIFJGL.WhereF((KKJBDENNKGF AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK)))
		{
			item.APAMPKPNIPC();
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
		{
			foreach (JDILMODHLOJ item2 in LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK)))
			{
				item2.APAMPKPNIPC();
			}
		}
		for (int num = FOGIOGKLNIP.PIOANBBCFFP.JLFMGNFDGCK.Count - 1; num >= 0; num--)
		{
			FOGIOGKLNIP.PIOANBBCFFP.JLFMGNFDGCK[num].APAMPKPNIPC();
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI))
		{
			foreach (JDILMODHLOJ item3 in LDAKBEMPLEB)
			{
				item3.NCHOPAEKPBK(item3.INKCDEBODNE, 2);
				item3.NCHOPAEKPBK(item3.DKJOIPMEMHM, 0);
				item3.JGECOECAJLK = GNMHJEPNHDL.CounterTerrorists;
			}
			for (int num2 = 0; num2 < Mathf.Max(1, LDAKBEMPLEB.Count / 6); num2++)
			{
				JDILMODHLOJ jDILMODHLOJ = LDAKBEMPLEB.Random();
				if (jDILMODHLOJ.GHKPKNMDMLH == IBOGNCENEHO.FDGPLHOFOEN)
				{
					jDILMODHLOJ.NCHOPAEKPBK(jDILMODHLOJ.INKCDEBODNE, 1);
					jDILMODHLOJ.NCHOPAEKPBK(jDILMODHLOJ.DKJOIPMEMHM, (!(UnityEngine.Random.value < 0.5f)) ? 1 : 2);
				}
			}
		}
		for (int num3 = DHHENNKPELD.Count - 1; num3 >= 0; num3--)
		{
			if (DHHENNKPELD[num3] != null)
			{
				UnityEngine.Object.Destroy(DHHENNKPELD[num3].ICIEDCMDJFO);
			}
		}
		JDFKPOMKMNJ.IPBKDPKONHH(delegate
		{
			foreach (JDILMODHLOJ item4 in LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) && AEMBPMJMOAB.NJEPMOIDJKH == null))
			{
				JNPIKJAGHFI(item4, ELKMMPDEDAK(item4.GHKPKNMDMLH));
			}
		});
		if (GGEMEHNHFCG.Length > 0 && ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA))
		{
			JDFKPOMKMNJ.IPBKDPKONHH(1000, GLIKJPMJAMJ);
		}
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(ANCGOFOIADD));
		for (int num4 = 0; num4 < array.Length; num4++)
		{
			ANCGOFOIADD aNCGOFOIADD = (ANCGOFOIADD)array[num4];
			aNCGOFOIADD.APAMPKPNIPC();
		}
		NCHOPAEKPBK(NAGALEFAGEJ, FFCHEIFGPBN, EDBIPBGEDEK);
		FOGIOGKLNIP.LBJBBGEDGJF.GLIDJHPEBLA = true;
	}

	[RPC]
	private void NAGALEFAGEJ(int FFCHEIFGPBN, int EDBIPBGEDEK)
	{
		if (ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI))
		{
			return;
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
		{
			DFFLEKBAJKC = 0;
			HDGCFPAMGKE = CIAFEEDOBKN;
			AJFFDIHCJNL = OEIBNEGMCFE;
			NGNMLDCDOPC = BEHBJPNPFCC;
			EBJHGFLAOAL = HCCCNMBOMPH;
			JDFKPCHDKIJ = LBOCPHIENEP;
			COGEDCIBHMA = KODPOMPNLBE;
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA))
		{
			JDFKPOMKMNJ.IPBKDPKONHH(ObscuredBool.FNIPJFGEFFD(CGFPIMCKBNH) ? 5000 : 0, delegate
			{
				LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Go);
			});
		}
		OEIIKDFMDGJ = EDBIPBGEDEK;
		GIAONHLJAGE = FFCHEIFGPBN;
		BOOJPIJMOEL = ObscuredBool.FNIPJFGEFFD(false);
		OPKDMODBFGA = ObscuredBool.FNIPJFGEFFD(false);
		EBCOPJHOFPP(1f);
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI))
		{
			JFMNIDEDNHG = ObscuredFloat.FNIPJFGEFFD(60f);
		}
		else
		{
			JFMNIDEDNHG = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.LIMCHPFAJHC) * 60f);
		}
		if (!ObscuredBool.FNIPJFGEFFD(CFGAEDNCMJP))
		{
			FOGIOGKLNIP.LBJBBGEDGJF.GLIDJHPEBLA = true;
			BMKALMOPDKI = FPIHOOAEDEN;
		}
		CDHGIGNMPKD = ObscuredFloat.FNIPJFGEFFD(Time.time);
		IAFDEBFCAJI = ObscuredBool.FNIPJFGEFFD(true);
		foreach (Transform item in MAOFPKAJMGO)
		{
			UnityEngine.Object.Destroy(item.gameObject);
		}
		foreach (Transform item2 in DOLHNPFJNNE)
		{
			UnityEngine.Object.Destroy(item2.gameObject);
		}
		foreach (CJMKGJPLOPM item3 in BKFEGEAEIFB)
		{
			item3.Reset();
		}
		for (int num = 0; num < LAMFMFPKDFH.Length; num++)
		{
			if (LAMFMFPKDFH[num].clip != null && LAMFMFPKDFH[num].playAutomatically)
			{
				LAMFMFPKDFH[num][LAMFMFPKDFH[num].clip.name].time = LAMFMFPKDFH[num].clip.length;
				LAMFMFPKDFH[num].Play();
			}
		}
		for (int num2 = 0; num2 < AIGIPLIIHCG.Length; num2++)
		{
			if (AIGIPLIIHCG[num2].clip != null)
			{
				AIGIPLIIHCG[num2].time = 0f;
				AIGIPLIIHCG[num2].Play();
			}
		}
		for (int num3 = 0; num3 < CNGMDJEANHD.Length; num3++)
		{
			CNGMDJEANHD[num3].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
			CNGMDJEANHD[num3].Play();
		}
		for (int num4 = 0; num4 < ILDFLKOIIDN.Length; num4++)
		{
			if (ILDFLKOIIDN[num4].url != null || ILDFLKOIIDN[num4].clip != null)
			{
				ILDFLKOIIDN[num4].Play();
			}
		}
		foreach (KKJBDENNKGF item4 in FBFOHOIFJGL)
		{
			item4.Reset();
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI) && FOGIOGKLNIP.NMGDHKIKCED != null && ((FOGIOGKLNIP.NMGDHKIKCED is MBFCGOPGCLP && BDHHGHOGGIJ.GHKPKNMDMLH == IBOGNCENEHO.FDGPLHOFOEN) || (FOGIOGKLNIP.NMGDHKIKCED is FDGPLHOFOEN && BDHHGHOGGIJ.GHKPKNMDMLH != IBOGNCENEHO.FDGPLHOFOEN)))
		{
			FOGIOGKLNIP.NMGDHKIKCED.APAMPKPNIPC();
		}
		if (BDHHGHOGGIJ.JGECOECAJLK != GNMHJEPNHDL.Spectators)
		{
			JDFKPOMKMNJ.IPBKDPKONHH(delegate
			{
				if (OCKHCJGLOEL)
				{
					JNPIKJAGHFI(BDHHGHOGGIJ, ELKMMPDEDAK(BDHHGHOGGIJ.GHKPKNMDMLH));
				}
			});
		}
		EJDKALEIBBG[] array = GGPOLOMIGOI.ToArray();
		foreach (EJDKALEIBBG eJDKALEIBBG in array)
		{
			eJDKALEIBBG.ICIEDCMDJFO.GIBDBKPJOKJ();
		}
		GGPOLOMIGOI.Clear();
		if (base.NENPALDENAL)
		{
			BPILKECDLJP();
			if (BBBCMOHPEIH != null)
			{
				for (int num6 = 0; num6 < LDAKBEMPLEB.Count; num6++)
				{
					if (LDAKBEMPLEB[num6].NJEPMOIDJKH != null)
					{
						KKJBDENNKGF nJEPMOIDJKH = LDAKBEMPLEB[num6].NJEPMOIDJKH;
						nJEPMOIDJKH.NCHOPAEKPBK(nJEPMOIDJKH.IGJOGMEONLP, BBBCMOHPEIH.Armour, true);
					}
				}
			}
		}
		INBICCIHAIC();
	}

	[RPC]
	public virtual void MHLKACLEHEH(string LKBIFFOHJMI, GameObject[] NLCGBLAGJKA, GameObject NKJGMALHFDA, string BHJDPNBAFDL, bool FGHFDJENHDD = false)
	{
		if (FOGIOGKLNIP.CIEBMCOJGCC != null && FOGIOGKLNIP.CIEBMCOJGCC.MPDMFKPJJAM != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(FOGIOGKLNIP.CIEBMCOJGCC.MPEBFNENKNL, FOGIOGKLNIP.CIEBMCOJGCC.MPDMFKPJJAM.transform.position, FOGIOGKLNIP.CIEBMCOJGCC.MPDMFKPJJAM.transform.rotation);
			gameObject.GetComponent<MPEBFNENKNL>().LKBIFFOHJMI.text = LKBIFFOHJMI;
			gameObject.GetComponent<MPEBFNENKNL>().BHJDPNBAFDL.text = BHJDPNBAFDL;
			if (!FGHFDJENHDD)
			{
				gameObject.GetComponent<MPEBFNENKNL>().EIJHBJMINJA(NLCGBLAGJKA);
			}
			else
			{
				gameObject.GetComponent<MPEBFNENKNL>().CACKNFCCFME(NKJGMALHFDA);
			}
			gameObject.transform.SetParent(FOGIOGKLNIP.CIEBMCOJGCC.MPDMFKPJJAM.transform);
			UnityEngine.Object.Destroy(gameObject, 5f);
		}
	}

	[RPC]
	public void KKNIBEKGFGH(PhotonViewID PACCJGELENC, PhotonViewID PLPIOMGGMJH, PhotonMessageInfo LIEKABKEJOG)
	{
		if (PACCJGELENC.owner == LIEKABKEJOG.sender)
		{
			KKNIBEKGFGH(PACCJGELENC, PLPIOMGGMJH);
		}
		else if (base.NENPALDENAL && !LIEKABKEJOG.sender.isMasterClient)
		{
			PhotonNetwork.CloseConnection(LIEKABKEJOG.sender);
			NCHOPAEKPBK(FNFKLBLIJAF, "A player who tried to vote instead of another player was kicked!");
		}
	}

	public void KKNIBEKGFGH(object PACCJGELENC, object PLPIOMGGMJH)
	{
		JDILMODHLOJ jDILMODHLOJ = FOGIOGKLNIP.AAPLAPBIFMD<JDILMODHLOJ>(PACCJGELENC);
		JDILMODHLOJ jDILMODHLOJ2 = FOGIOGKLNIP.AAPLAPBIFMD<JDILMODHLOJ>(PLPIOMGGMJH);
		FOGIOGKLNIP.PIOANBBCFFP.FNFKLBLIJAF(jDILMODHLOJ.JIAPBCDODBJ(true) + FOGIOGKLNIP.FHHPMGJCHJL(" has voted for kick ") + jDILMODHLOJ2.JIAPBCDODBJ(true));
		jDILMODHLOJ2.BOLDJCIBNLE = ObscuredInt.JKKOEENGPLM(jDILMODHLOJ2.BOLDJCIBNLE);
	}

	[RPC]
	public void FNFKLBLIJAF(string LGNIFJCEECH)
	{
		Text nMEOIEFEKFM = NMEOIEFEKFM;
		nMEOIEFEKFM.text = nMEOIEFEKFM.text + LGNIFJCEECH + "\r\n";
		BDGFCPNLLJB();
	}

	[RPC]
	public void FBFCEIFFNEO(string LGNIFJCEECH, NetworkViewID GDKFLGBMPBB, bool NKPPCGPKDHB)
	{
		FBFCEIFFNEO(LGNIFJCEECH, (object)GDKFLGBMPBB, NKPPCGPKDHB);
	}

	[RPC]
	public void FBFCEIFFNEO(string LGNIFJCEECH, PhotonViewID GDKFLGBMPBB, bool NKPPCGPKDHB)
	{
		FBFCEIFFNEO(LGNIFJCEECH, (object)GDKFLGBMPBB, NKPPCGPKDHB);
	}

	public void FBFCEIFFNEO(string LGNIFJCEECH, object GDKFLGBMPBB, bool NKPPCGPKDHB)
	{
		JDILMODHLOJ jDILMODHLOJ = FOGIOGKLNIP.AAPLAPBIFMD<JDILMODHLOJ>(GDKFLGBMPBB);
		jDILMODHLOJ.DIGHCOJPKNO = Time.time;
		if (jDILMODHLOJ.LCPJEIHHAMP || (jDILMODHLOJ.JGECOECAJLK != BDHHGHOGGIJ.JGECOECAJLK && NKPPCGPKDHB))
		{
			return;
		}
		if (FOGIOGKLNIP.DGMBIMMABNO)
		{
			LGNIFJCEECH = string.Join("\n", (from Match AEMBPMJMOAB in Regex.Matches(LGNIFJCEECH, ".{1,70}\\w*")
				select AEMBPMJMOAB.Value).ToArray());
		}
		BDGFCPNLLJB();
		Text nMEOIEFEKFM = NMEOIEFEKFM;
		nMEOIEFEKFM.text = nMEOIEFEKFM.text + ((!NKPPCGPKDHB) ? string.Empty : base.FKICDOGJIFN.GameChatTeam) + FOGIOGKLNIP.LPLJMLGKCLK.PCHICPPDHKI(LGNIFJCEECH) + "\r\n";
		GGCHLNODFBJ(LGNIFJCEECH);
	}

	[RPC]
	private void LGONGDPAMOB()
	{
		IAFDEBFCAJI = ObscuredBool.FNIPJFGEFFD(false);
		FOGIOGKLNIP.CIEBMCOJGCC.MCABNHIPCPK(GNMHJEPNHDL.Spectators);
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.RoundDraw);
	}

	[RPC]
	private void LABAIEPLJNN()
	{
		FOGIOGKLNIP.CIEBMCOJGCC.MCABNHIPCPK(GNMHJEPNHDL.Terrorists);
		if (!ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI))
		{
			return;
		}
		IAFDEBFCAJI = ObscuredBool.FNIPJFGEFFD(false);
		foreach (JDILMODHLOJ item in LDAKBEMPLEB)
		{
			if (item.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists)
			{
				item.FBBDIENBDGM(1900);
			}
			if (item.JGECOECAJLK == GNMHJEPNHDL.Terrorists)
			{
				item.FBBDIENBDGM(3250);
			}
		}
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.TerroristWin);
	}

	[RPC]
	private void CMFKBGLNPMN()
	{
		FOGIOGKLNIP.CIEBMCOJGCC.MCABNHIPCPK(GNMHJEPNHDL.CounterTerrorists);
		if (!ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI))
		{
			return;
		}
		IAFDEBFCAJI = ObscuredBool.FNIPJFGEFFD(false);
		foreach (JDILMODHLOJ item in LDAKBEMPLEB)
		{
			if (item.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists)
			{
				item.FBBDIENBDGM(3250);
			}
			if (item.JGECOECAJLK == GNMHJEPNHDL.Terrorists)
			{
				item.FBBDIENBDGM(1900);
			}
		}
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.CounterTerroristWin);
	}

	[RPC]
	public void BHIBNPLGJMC(NetworkViewID JELKHBGBHGE)
	{
		BHIBNPLGJMC((object)JELKHBGBHGE);
	}

	[RPC]
	public void BHIBNPLGJMC(PhotonViewID JELKHBGBHGE)
	{
		BHIBNPLGJMC((object)JELKHBGBHGE);
	}

	private void BHIBNPLGJMC(object JELKHBGBHGE)
	{
		if (ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI))
		{
			IAFDEBFCAJI = ObscuredBool.FNIPJFGEFFD(false);
			FOGIOGKLNIP.NGFDFPGNDCJ.AEBCFFNADHM = false;
			if (LDAKBEMPLEB.CountF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) > 1)
			{
				JDILMODHLOJ jDILMODHLOJ = FOGIOGKLNIP.AAPLAPBIFMD<JDILMODHLOJ>(JELKHBGBHGE);
				LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.ZombieWin);
				AFIAEDMAHLP(string.Concat(jDILMODHLOJ, FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameSurvived)));
			}
		}
	}

	[RPC]
	private void JDCADKCHDPD(string LGNIFJCEECH, bool HAPECBFBAEJ = false)
	{
		BIHOCPAKHNF(LGNIFJCEECH);
		FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ(LGNIFJCEECH, HAPECBFBAEJ);
	}

	[RPC]
	private void DEHLGLOKEMN(bool EHAPKEKPMOE)
	{
		IAFDEBFCAJI = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE);
	}

	[RPC]
	public void DMAILAJDJLD(int EBMKGCIKJCA, int JGECOECAJLK)
	{
		if (!FOGIOGKLNIP.PIOANBBCFFP.HJPPJJCHGJA)
		{
			return;
		}
		MIDPJKEMHNI = ObscuredInt.JKKOEENGPLM(MIDPJKEMHNI);
		if (FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) && AEMBPMJMOAB.KAMAMHFJDGG) < 200 && (FOGIOGKLNIP.PBDAOOIJGIA.CountF((bool AEMBPMJMOAB) => AEMBPMJMOAB) <= 28 || !FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO))
		{
			JDILMODHLOJ component = ICONFJBEJPN(HLMDBACNBCD, Vector3.zero, Quaternion.identity, 0).GetComponent<JDILMODHLOJ>();
			component.NCHOPAEKPBK(component.GMBLKDCLAEH, true);
			component.GHKPKNMDMLH = (IBOGNCENEHO)EBMKGCIKJCA;
			component.NCHOPAEKPBK(component.ONAEOFBDAML, base.FKICDOGJIFN.GameBotName + ((component.GHKPKNMDMLH != IBOGNCENEHO.FDGPLHOFOEN) ? component.GHKPKNMDMLH.ToString() : BEMOMLIBFAL.DAKAIOJHOMK.Random()));
			component.NCHOPAEKPBK(component.INKCDEBODNE, JGECOECAJLK);
			if (EBMKGCIKJCA == 3)
			{
				component.NCHOPAEKPBK(component.NFDLHKNANMI, true);
			}
			JNPIKJAGHFI(component, ELKMMPDEDAK((IBOGNCENEHO)EBMKGCIKJCA));
		}
	}

	public KKJBDENNKGF DMAILAJDJLD(int EBMKGCIKJCA, int JGECOECAJLK, Vector3 ELGIKGAIIOD)
	{
		KKJBDENNKGF kKJBDENNKGF = null;
		if (!FOGIOGKLNIP.PIOANBBCFFP.HJPPJJCHGJA)
		{
			return null;
		}
		MIDPJKEMHNI = ObscuredInt.JKKOEENGPLM(MIDPJKEMHNI);
		if (FOGIOGKLNIP.PBDAOOIJGIA.CountF((bool AEMBPMJMOAB) => AEMBPMJMOAB) > 28 && FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			return null;
		}
		JDILMODHLOJ component = ICONFJBEJPN(HLMDBACNBCD, ELGIKGAIIOD, Quaternion.identity, 0).GetComponent<JDILMODHLOJ>();
		component.NCHOPAEKPBK(component.GMBLKDCLAEH, true);
		component.NCHOPAEKPBK(component.DEICEBBEFNN, true);
		component.GHKPKNMDMLH = (IBOGNCENEHO)EBMKGCIKJCA;
		component.NCHOPAEKPBK(component.ONAEOFBDAML, base.FKICDOGJIFN.GameBotName + ((component.GHKPKNMDMLH != IBOGNCENEHO.FDGPLHOFOEN) ? component.GHKPKNMDMLH.ToString() : BEMOMLIBFAL.DAKAIOJHOMK.Random()));
		component.NCHOPAEKPBK(component.INKCDEBODNE, JGECOECAJLK);
		if (EBMKGCIKJCA == 3)
		{
			component.NCHOPAEKPBK(component.NFDLHKNANMI, true);
		}
		return JNPIKJAGHFI(component, ELKMMPDEDAK((IBOGNCENEHO)EBMKGCIKJCA), ELGIKGAIIOD, Vector3.zero);
	}

	[RPC]
	public void IAOIBLMFCGG(int LCJEBKEFKDN)
	{
		KLGAIEEIICF = LCJEBKEFKDN;
		if (LCJEBKEFKDN > ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ)) ? 10 : 100))
		{
			KLGAIEEIICF = (DCEJABDJMLM = 0);
		}
	}

	[RPC]
	public void NKDPOGLBBJG(int LCJEBKEFKDN)
	{
		DCEJABDJMLM = LCJEBKEFKDN;
		if (LCJEBKEFKDN > ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ)) ? 10 : 100))
		{
			KLGAIEEIICF = (DCEJABDJMLM = 0);
		}
	}

	[RPC]
	public void JLJDIGNIEOL()
	{
		if ((ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) || FOGIOGKLNIP.PIOANBBCFFP.LDAKBEMPLEB.CountF((JDILMODHLOJ AEMBPMJMOAB) => !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK)) > 3) && FOGIOGKLNIP.PIOANBBCFFP.LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.CMFHKELIOEA) >= 50).OrderByDescendingF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.CMFHKELIOEA).FirstOrDefaultF() == BDHHGHOGGIJ)
		{
			JDILMODHLOJ bDHHGHOGGIJ = BDHHGHOGGIJ;
			bDHHGHOGGIJ.IKAJFLANDKM = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(bDHHGHOGGIJ.IKAJFLANDKM) + 1);
			BDHHGHOGGIJ.FBBDIENBDGM(FOGIOGKLNIP.EELPLHEEEDB("medal", 4000));
			LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Excelent);
			FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ(base.FKICDOGJIFN.GameAchivementAwardedGoldMedal);
		}
		else
		{
			FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("You are tied for the lead!");
			LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.TieLead);
		}
		foreach (JDILMODHLOJ item in LDAKBEMPLEB)
		{
			item.CMFHKELIOEA = ObscuredInt.FNIPJFGEFFD(0);
			item.BLGILFLFHNI = ObscuredInt.FNIPJFGEFFD(0);
		}
	}

	[RPC]
	public void NHBBPJGKADP(float KFGFAHLMPOD)
	{
	}

	[RPC]
	public void OMKBPHAGPBJ(bool LKHPKBHOIPP)
	{
	}

	[RPC]
	public void OPMFGALEGBI(float JLNAJMKHJOK)
	{
	}

	[RPC]
	public void AJBMECPCOMH(bool LKHPKBHOIPP)
	{
		if (!LKHPKBHOIPP && FOGIOGKLNIP.NMGDHKIKCED != null)
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.APHNCCJIKPD = false;
		}
		IHCFILFBIJF = ObscuredBool.FNIPJFGEFFD(LKHPKBHOIPP);
	}

	[RPC]
	public void NHMLKOPHKEK(bool PDAKFGKELOC)
	{
		if (!PDAKFGKELOC)
		{
			FNFKLBLIJAF(base.FKICDOGJIFN.GameShootThroughWallsDisabled);
		}
		MDDBCIILKHG = ObscuredBool.FNIPJFGEFFD(PDAKFGKELOC);
	}

	[RPC]
	public void CGIKHLOECDM(float PDAKFGKELOC)
	{
		JDFKPCHDKIJ = ObscuredFloat.FNIPJFGEFFD(PDAKFGKELOC);
	}

	[RPC]
	public void BBKJAMHFKCE(float PDAKFGKELOC)
	{
		EBJHGFLAOAL = ObscuredFloat.FNIPJFGEFFD(PDAKFGKELOC);
	}

	[RPC]
	public void MGNKJMMOJDO(float PDAKFGKELOC)
	{
		EMKLPBIJILF = ObscuredFloat.FNIPJFGEFFD(PDAKFGKELOC);
	}

	[RPC]
	public void ENADPBHGCME(NetworkViewID JELKHBGBHGE)
	{
		OHCHIHBJEGJ.Push(JELKHBGBHGE);
	}

	[RPC]
	public void FFDJIPIGGPO(float GHKIMBMCPFA, float JFMNIDEDNHG, float DEBNBJBLEDJ)
	{
		this.DEBNBJBLEDJ = ObscuredFloat.FNIPJFGEFFD(DEBNBJBLEDJ);
		FOGIOGKLNIP.LPLJMLGKCLK.LIMCHPFAJHC = ObscuredFloat.FNIPJFGEFFD(GHKIMBMCPFA);
		this.JFMNIDEDNHG = ObscuredFloat.FNIPJFGEFFD(JFMNIDEDNHG);
	}

	[RPC]
	public void BDLBAKEHMHC(float KLKEFHMKODC)
	{
		BMKALMOPDKI = ObscuredFloat.FNIPJFGEFFD(KLKEFHMKODC);
	}

	[RPC]
	public void OEHKBODPIFO(float KLKEFHMKODC)
	{
		FPIHOOAEDEN = ObscuredFloat.FNIPJFGEFFD(KLKEFHMKODC);
	}

	[RPC]
	public void EPKKLODNHMM(string LGNIFJCEECH, int CCGOKLNECKM)
	{
		bool flag = NOMMEFIICHO.HKIKLNKHPEP(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF) && CCGOKLNECKM != FOGIOGKLNIP.LPLJMLGKCLK.IMHMMKJKCBK;
		if (FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF) != FOGIOGKLNIP.GIGJFCBMKMO(LGNIFJCEECH) || flag)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMapsnotequal + FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF) + "!= " + FOGIOGKLNIP.GIGJFCBMKMO(LGNIFJCEECH));
			OENODCJHEOG();
		}
	}

	[RPC]
	public void LKAFFMFPFMK(bool FFBEPGEKANM)
	{
		ANPPCHMLKNF = ObscuredBool.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void BBAOFHPHGOA(float FFBEPGEKANM)
	{
		HDGCFPAMGKE = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void GHANHHOHGGJ(float FFBEPGEKANM)
	{
		COGEDCIBHMA = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void GHGMNANNEIN(float FFBEPGEKANM)
	{
		NGNMLDCDOPC = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void PNBBDANLPAD(bool LCBKHLLPIGM)
	{
		DJBGAOOAGEO = ObscuredBool.FNIPJFGEFFD(LCBKHLLPIGM);
	}

	[RPC]
	public void KOMBGAONLJB(float FFBEPGEKANM)
	{
		AJFFDIHCJNL = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void COALDLJKKEF(float FFBEPGEKANM)
	{
		MIGCKAPHANN = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void JFIHFFHFDCJ(bool FFBEPGEKANM)
	{
		DOMONNBOMNP = ObscuredBool.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void AHODPOGMMMM(float FFBEPGEKANM)
	{
		LGIOALGFFHP = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void FMDGJPGKLGN(float FFBEPGEKANM)
	{
		FPFAEOJAIBB = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void GHONKCAINHD(float FFBEPGEKANM)
	{
		HJNMHAGEEPC = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void CANDBHDGDLE(float FFBEPGEKANM)
	{
		JFLGCMGFGHF = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void EABKALFFPCF(Vector3 ELGIKGAIIOD)
	{
		UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate(LGKBNACNBLA, ELGIKGAIIOD, LGKBNACNBLA.transform.rotation), 100f);
	}

	[RPC]
	public void BOHGAGGCMFB(bool AGIHJECLCJH)
	{
		JFFHDKCBBEA = ObscuredBool.FNIPJFGEFFD(AGIHJECLCJH);
	}

	[RPC]
	public void AHIMMAAKMAC(float FFBEPGEKANM)
	{
		if (FFBEPGEKANM == 1f)
		{
			return;
		}
		FNFKLBLIJAF(base.FKICDOGJIFN.GameMapScaleSetTo + FFBEPGEKANM);
		foreach (ENFDKNAODIJ item in IJMPPAPBMAJ)
		{
			item.ICIEDCMDJFO.SetActive(false);
		}
		CCLAGBBDGDI.localScale = FFBEPGEKANM * Vector3.one;
		DCHKOIHONPN = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
		JDFKPOMKMNJ.IPBKDPKONHH(100, IGBCOFFLIED);
		Camera.main.useOcclusionCulling = false;
		HJPPJJCHGJA = false;
	}

	[RPC]
	public void IALMCAFGHCE(bool FFBEPGEKANM)
	{
		CKAJCPDFAGC = ObscuredBool.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void LKLADDOHJHM(bool FFBEPGEKANM)
	{
		JABHAJEEFNO = ObscuredBool.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void GEJBHJGINDP(float FFBEPGEKANM)
	{
		OHGEMABOIBK = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void HDDBKANKMLG(float FFBEPGEKANM)
	{
		NBKGCKPKBOC = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void DFALJEHMLOP(int CPHOPKFMFJN, int GDKFLGBMPBB)
	{
		OEIIKDFMDGJ = CPHOPKFMFJN;
		GIAONHLJAGE = GDKFLGBMPBB;
	}

	[RPC]
	public void EIFOECIOEAA(int DNHLBGLJBBD)
	{
		DAGCHNCNBJH = ObscuredBool.FNIPJFGEFFD(true);
		FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = (IMCJHBIFEAK)DNHLBGLJBBD;
		if (FOGIOGKLNIP.LPLJMLGKCLK.FCFBGBPEPOL)
		{
			CLEIHBGGHMD(FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD);
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD != IMCJHBIFEAK.Classic)
		{
			BombPlace[] gGEMEHNHFCG = GGEMEHNHFCG;
			foreach (BombPlace th in gGEMEHNHFCG)
			{
				th.SetActive(false);
			}
			GGEMEHNHFCG = new BombPlace[0];
			foreach (ENFDKNAODIJ item in IJMPPAPBMAJ)
			{
				item.SetActive(false);
			}
			IJMPPAPBMAJ.Clear();
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD != IMCJHBIFEAK.CTF)
		{
			foreach (AMKDLOAPGCB item2 in HCIMPOGMHAK)
			{
				item2.SetActive(false);
			}
		}
		JDFKPOMKMNJ.IPBKDPKONHH(delegate
		{
			IHCFILFBIJF = ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.OMMLFOEPEEK);
		});
		EGPJNAJIPLA = false;
		ANPPCHMLKNF = ObscuredBool.FNIPJFGEFFD(true);
		FOGIOGKLNIP.PIOANBBCFFP.FPFAEOJAIBB = (FOGIOGKLNIP.PIOANBBCFFP.JFLGCMGFGHF = (FOGIOGKLNIP.PIOANBBCFFP.HJNMHAGEEPC = (FOGIOGKLNIP.PIOANBBCFFP.LGIOALGFFHP = ObscuredFloat.FNIPJFGEFFD(1f))));
		FOGIOGKLNIP.PIOANBBCFFP.HJNMHAGEEPC = ObscuredFloat.FNIPJFGEFFD(0f);
		FOGIOGKLNIP.PIOANBBCFFP.JFLGCMGFGHF = ObscuredFloat.FNIPJFGEFFD(0.2f);
		OPNFEFFBODL = ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.EELPLHEEEDB("AutoShoot", 0) == 1);
		IJDOMLPACPA = ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.EELPLHEEEDB("EnableRun", 0) == 1);
		KJHFLGPLMFF = ObscuredBool.FNIPJFGEFFD(ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDFHLAHHCME) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI));
		JABHAJEEFNO = ObscuredBool.FNIPJFGEFFD(ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI));
		DEOBCKBAIPA = FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL;
		DJGDLBMGMDI(ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL));
		FGEGAEBIMID = ObscuredBool.FNIPJFGEFFD(false);
		CFGAEDNCMJP = ObscuredBool.FNIPJFGEFFD(false);
		IHCFILFBIJF = ObscuredBool.FNIPJFGEFFD(ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI));
		ECFKJNJEMBP = ObscuredInt.FNIPJFGEFFD(200);
		if (base.JNPCOJFBJGP)
		{
			JFFHDKCBBEA = ObscuredBool.FNIPJFGEFFD(true);
			IHCFILFBIJF = ObscuredBool.FNIPJFGEFFD(true);
			HDGCFPAMGKE = ObscuredFloat.FNIPJFGEFFD(0.2f);
		}
		IHCDJPIJMGE = (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.ECACNDFNADN) ? ObscuredFloat.FNIPJFGEFFD(30f) : ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDFHLAHHCME)) ? IHCDJPIJMGE : ObscuredFloat.FNIPJFGEFFD(10f)));
		EBJHGFLAOAL = ObscuredFloat.FNIPJFGEFFD(0.8f);
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI))
		{
			FNLJEMBMLHN = ObscuredInt.FNIPJFGEFFD(3);
		}
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.ECACNDFNADN))
		{
			JFLGCMGFGHF = ObscuredFloat.FNIPJFGEFFD(0.5f);
			HJNMHAGEEPC = ObscuredFloat.FNIPJFGEFFD(1f);
			LGIOALGFFHP = ObscuredFloat.FNIPJFGEFFD(1f);
			FPFAEOJAIBB = ObscuredFloat.FNIPJFGEFFD(1f);
			BBAOFHPHGOA(1f);
			GHANHHOHGGJ(100f);
			if (FOGIOGKLNIP.OMMLFOEPEEK)
			{
				IKIBHKEEICI(4);
			}
		}
	}

	[RPC]
	public void AJAGJJKDNNP(bool FFBEPGEKANM)
	{
	}

	[RPC]
	public void JKJJBGCMEMI(bool FFBEPGEKANM)
	{
		LECIFFENJMA = ObscuredBool.FNIPJFGEFFD(FFBEPGEKANM);
		if (FOGIOGKLNIP.DGMBIMMABNO || !(CCLAGBBDGDI != null))
		{
			return;
		}
		foreach (Material item in CCLAGBBDGDI.GetComponentsInChildren<Renderer>().SelectMany((Renderer AEMBPMJMOAB) => AEMBPMJMOAB.GetComponent<Renderer>().materials))
		{
			if (FFBEPGEKANM)
			{
				if (item.shader.name == "Diffuse")
				{
					item.shader = Shader.Find("Diffuse2");
				}
			}
			else if (item.shader.name == "Diffuse2")
			{
				item.shader = Shader.Find("Diffuse");
			}
		}
	}

	[RPC]
	public void IKIBHKEEICI(int FFBEPGEKANM)
	{
		JGAFAIDLHOP = FFBEPGEKANM;
	}

	[RPC]
	public void NHOKJIGMDCF(bool FFBEPGEKANM)
	{
		GFPOMBMNDIO = ObscuredBool.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void IIKCMBEEKKP(int FFBEPGEKANM)
	{
		EKEMIEEFILP = ObscuredInt.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void PCJAHJELDJJ(float FFBEPGEKANM)
	{
		IJFJBIKHEDL = ObscuredFloat.FNIPJFGEFFD(FFBEPGEKANM);
	}

	[RPC]
	public void HJKFBJLHOGH(bool FFBEPGEKANM)
	{
	}

	[RPC]
	public void EOBGENFFMOJ(bool LCBKHLLPIGM)
	{
		IHHLGEIECBI = LCBKHLLPIGM;
	}

	[RPC]
	public void DJGDLBMGMDI(bool LCBKHLLPIGM)
	{
		LMCLODHEIGA = ObscuredBool.FNIPJFGEFFD(LCBKHLLPIGM);
		Physics.IgnoreLayerCollision(11, 11, LCBKHLLPIGM || FOGIOGKLNIP.DGMBIMMABNO);
	}

	private void GFJOLAKDKFP()
	{
		if (!ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI))
		{
			bool flag = LDAKBEMPLEB.AnyF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists) && LDAKBEMPLEB.AnyF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists);
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
			{
				flag = LDAKBEMPLEB.AnyF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists);
			}
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI))
			{
				flag = LDAKBEMPLEB.Count > 1;
			}
			if (flag && !KLKOJNMNCJO)
			{
				DEEPKELFLDC = ObscuredFloat.FNIPJFGEFFD(Time.time);
			}
			if (Time.time - ObscuredFloat.FNIPJFGEFFD(DEEPKELFLDC) > 3f && KLKOJNMNCJO)
			{
				DIHBNECKLBC(GIAONHLJAGE, OEIIKDFMDGJ);
			}
		}
		else
		{
			if (!ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI) || !(Time.time - ObscuredFloat.FNIPJFGEFFD(CDHGIGNMPKD) > 3f))
			{
				return;
			}
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
			{
				if (!LDAKBEMPLEB.AnyF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists))
				{
					NCHOPAEKPBK(DEHLGLOKEMN, false);
					return;
				}
				int num = LDAKBEMPLEB.CountF((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists);
				bool flag2 = num == 1 && !FBFOHOIFJGL.AnyF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists);
				bool flag3 = num > 1 && FBFOHOIFJGL.CountF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists) <= 1;
				JDILMODHLOJ jDILMODHLOJ = null;
				if (flag3)
				{
					jDILMODHLOJ = FBFOHOIFJGL.FirstOrDefaultF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists).BJDCCKHBENA;
				}
				if (flag2 || flag3)
				{
					NCHOPAEKPBK(BHIBNPLGJMC, (!(jDILMODHLOJ == null)) ? jDILMODHLOJ.MFAGKFPCJFG : BDHHGHOGGIJ.MFAGKFPCJFG);
				}
				return;
			}
			if (((LDAKBEMPLEB.All((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK != GNMHJEPNHDL.Terrorists) || LDAKBEMPLEB.All((JDILMODHLOJ AEMBPMJMOAB) => AEMBPMJMOAB.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists)) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI)) || LDAKBEMPLEB.Count == 1)
			{
				NCHOPAEKPBK(DEHLGLOKEMN, false);
				return;
			}
			bool flag4 = !FBFOHOIFJGL.AnyF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists);
			bool flag5 = !FBFOHOIFJGL.AnyF((KKJBDENNKGF AEMBPMJMOAB) => AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists);
			if (ObscuredFloat.FNIPJFGEFFD(JFMNIDEDNHG) <= 0f)
			{
				if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA))
				{
					if (IJMPPAPBMAJ.AnyF((ENFDKNAODIJ AEMBPMJMOAB) => AEMBPMJMOAB.JGDLDJLBKEF) || (JLFMGNFDGCK.Count <= 0 && !ObscuredBool.FNIPJFGEFFD(OPKDMODBFGA)))
					{
						NCHOPAEKPBK(IAOIBLMFCGG, KLGAIEEIICF + 1);
						NCHOPAEKPBK(CMFKBGLNPMN);
					}
					if ((IJMPPAPBMAJ.Count >= 1 && !IJMPPAPBMAJ.AnyF((ENFDKNAODIJ AEMBPMJMOAB) => AEMBPMJMOAB.JGDLDJLBKEF)) || ObscuredBool.FNIPJFGEFFD(OPKDMODBFGA))
					{
						NCHOPAEKPBK(NKDPOGLBBJG, DCEJABDJMLM + 1);
						NCHOPAEKPBK(LABAIEPLJNN);
					}
				}
				else
				{
					NCHOPAEKPBK(LGONGDPAMOB);
				}
			}
			else if (flag5 && flag4 && JLFMGNFDGCK.Count == 0)
			{
				NCHOPAEKPBK(LGONGDPAMOB);
			}
			else if (flag4 || ObscuredBool.FNIPJFGEFFD(OPKDMODBFGA))
			{
				NCHOPAEKPBK(NKDPOGLBBJG, DCEJABDJMLM + 1);
				NCHOPAEKPBK(LABAIEPLJNN);
			}
			else if ((flag5 && JLFMGNFDGCK.Count == 0 && !ObscuredBool.FNIPJFGEFFD(OPKDMODBFGA)) || ObscuredBool.FNIPJFGEFFD(BOOJPIJMOEL) || (JLFMGNFDGCK.Count == 0 && IJMPPAPBMAJ.Count > 0 && IJMPPAPBMAJ.All((ENFDKNAODIJ AEMBPMJMOAB) => AEMBPMJMOAB.JGDLDJLBKEF)))
			{
				NCHOPAEKPBK(IAOIBLMFCGG, KLGAIEEIICF + 1);
				NCHOPAEKPBK(CMFKBGLNPMN);
			}
		}
	}

	[DebuggerHidden]
	private IEnumerator EGMPEKLLEPC()
	{
		DMMBEDDNICB dMMBEDDNICB = new DMMBEDDNICB();
		dMMBEDDNICB.KPHCHDHEKGH = this;
		return dMMBEDDNICB;
	}

	private void BDGFCPNLLJB()
	{
		if (!HLDLJFOALII || !IGJKLHOGPHL)
		{
			NMEOIEFEKFM.gameObject.SetActive(true);
		}
		if (NMEOIEFEKFM.text.Split2().Length > 20)
		{
			NMEOIEFEKFM.text = IMPKMAEGMMF(NMEOIEFEKFM.text);
		}
		if (!HLDLJFOALII)
		{
			StartCoroutine(EGMPEKLLEPC());
		}
		if (IGJKLHOGPHL)
		{
			return;
		}
		JDFKPOMKMNJ.IPBKDPKONHH(10000, delegate
		{
			if (!IGJKLHOGPHL)
			{
				NMEOIEFEKFM.gameObject.SetActive(false);
			}
		});
	}

	private static int ABMFGNIFIOF(Color32 JPLPPELPDKF)
	{
		return (JPLPPELPDKF.r << 16) | (JPLPPELPDKF.g << 8) | (JPLPPELPDKF.b << 0);
	}

	private void CKNDGDOFNAA()
	{
		UnityEngine.Object[] array = Resources.FindObjectsOfTypeAll(typeof(Light));
		UnityEngine.Object[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			Light light = (Light)array2[i];
			if (light != null)
			{
				light.cullingMask = 0;
				light.range = 0f;
				light.intensity = 0f;
				light.enabled = false;
			}
		}
		Shader shader = FOGIOGKLNIP.LPLJMLGKCLK.EBFHOGEICPE.shader;
		UnityEngine.Object[] array3 = Resources.FindObjectsOfTypeAll(typeof(Material));
		for (int j = 0; j < array3.Length; j++)
		{
			Material material = (Material)array3[j];
			if (material.shader != null && material.shader.name == "Diffuse")
			{
				material.shader = shader;
			}
		}
		RenderSettings.ambientLight = Color.white;
	}

	private void BCLLJNAEMNP(int GLNHGIPOIDP, ref SpawnPlayer[] DHJLBBGLLBL, AKGFLNIDAHK AAONLOOGJJC)
	{
		if (DHJLBBGLLBL.Length <= 0)
		{
			UnityEngine.Debug.LogError(base.FKICDOGJIFN.GameWarningNotSpawnsFounded + AAONLOOGJJC);
			for (int i = 0; i < GLNHGIPOIDP; i++)
			{
				DHJLBBGLLBL[i] = new GameObject(string.Format("Spawn{0}", AAONLOOGJJC.ToString())).AddComponent<SpawnPlayer>();
				DHJLBBGLLBL[i].Team = AAONLOOGJJC;
				DHJLBBGLLBL[i].transform.position = OKANFELAGDE();
			}
		}
	}

	private Vector3 CKEEJFMMOOG()
	{
		LOIKOIEOGPD = false;
		JLODNBFNDEI = false;
		if ((!base.MDBAFPKAKKK && !FOGIOGKLNIP.DGMBIMMABNO) || DALNPKPJAJF)
		{
			return Vector3.zero;
		}
		Vector3 result = Vector3.zero;
		if (FOGIOGKLNIP.DGMBIMMABNO)
		{
			Touch[] hJDAJDIIMPD = FOGIOGKLNIP.HJDAJDIIMPD;
			for (int i = 0; i < hJDAJDIIMPD.Length; i++)
			{
				Touch touch = hJDAJDIIMPD[i];
				Vector2 vector = FOGIOGKLNIP.CIEBMCOJGCC.KMJJMNPHPKA.transform.position;
				Vector2 position = touch.position;
				if (FOGIOGKLNIP.OMMLFOEPEEK)
				{
					position.y += 40f;
				}
				position.x /= Screen.width;
				position.y /= Screen.height;
				if (!((position - vector).magnitude < FOGIOGKLNIP.LPLJMLGKCLK.KEEOGKIBGCO * FOGIOGKLNIP.CIEBMCOJGCC.KMJJMNPHPKA.transform.localScale.x))
				{
					continue;
				}
				if (touch.phase == TouchPhase.Began)
				{
					if ((position - vector).y > 0f)
					{
						if (Time.time - ObscuredFloat.FNIPJFGEFFD(ICNGEPMDAOD) < 0.3f)
						{
							ICNGEPMDAOD = ObscuredFloat.FNIPJFGEFFD(0f);
							if (FOGIOGKLNIP.LPLJMLGKCLK.NCJHLHGHGGI && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IJDOMLPACPA))
							{
								LOIKOIEOGPD = true;
							}
							HDOJLFGFDGH = true;
						}
						else
						{
							ICNGEPMDAOD = ObscuredFloat.FNIPJFGEFFD(Time.time);
						}
					}
					else if (Time.time - ObscuredFloat.FNIPJFGEFFD(BDGPJFCBNCL) < 0.3f)
					{
						BDGPJFCBNCL = ObscuredFloat.FNIPJFGEFFD(0f);
						if (FOGIOGKLNIP.LPLJMLGKCLK.NCJHLHGHGGI && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IJDOMLPACPA))
						{
							JLODNBFNDEI = true;
						}
						HDOJLFGFDGH = true;
					}
					else
					{
						BDGPJFCBNCL = ObscuredFloat.FNIPJFGEFFD(Time.time);
					}
				}
				if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began)
				{
					result = position - vector;
					result.z = result.y;
					result.y = 0f;
					result = result.normalized;
				}
			}
		}
		if (!FOGIOGKLNIP.DGMBIMMABNO)
		{
			Vector3 zero = Vector3.zero;
			if (base.HGCLIIOIAHM)
			{
				zero += Vector3.forward;
			}
			if (base.DFODLKHDLGG)
			{
				zero += Vector3.back;
			}
			if (base.BNMLPNBIJLN)
			{
				zero += Vector3.left;
			}
			if (base.MGLIGHIBNEH)
			{
				zero += Vector3.right;
			}
			result += zero.normalized;
		}
		return result;
	}

	private void BKGBOHHDOLI()
	{
		if (IDAPJDEGNLI)
		{
			UnityEngine.Object[] source = UnityEngine.Object.FindObjectsOfType(typeof(MeshCollider));
			CCLAGBBDGDI = (from Collider AEMBPMJMOAB in source
				where AEMBPMJMOAB.gameObject.layer == 10 || AEMBPMJMOAB.bounds.size.y > 3f
				orderby AEMBPMJMOAB.bounds.size.magnitude descending
				select AEMBPMJMOAB).FirstOrDefault().transform.root;
		}
		else
		{
			JJAKDKLFLBP jJAKDKLFLBP = new JJAKDKLFLBP();
			jJAKDKLFLBP.JLJDFJNDELM = new GameObject("WorldSpawn");
			jJAKDKLFLBP.AIONOHFEACL = new GameObject("Entities");
			GameObject[] rootGameObjects = SceneManager.GetSceneAt(0).GetRootGameObjects();
			rootGameObjects.WhereF((GameObject AEMBPMJMOAB) => AEMBPMJMOAB.layer == 31 || AEMBPMJMOAB.layer == 18 || AEMBPMJMOAB.layer == 17 || AEMBPMJMOAB.layer == 28).AllF(jJAKDKLFLBP.BEKJDJFLJJC);
			rootGameObjects.WhereF((GameObject AEMBPMJMOAB) => AEMBPMJMOAB.layer == 10 || AEMBPMJMOAB.layer == 8 || AEMBPMJMOAB.layer == 20).AllF(jJAKDKLFLBP.PMBKBKJIIPO);
			CCLAGBBDGDI = jJAKDKLFLBP.JLJDFJNDELM.transform;
			MIMKAJOMAKG = jJAKDKLFLBP.AIONOHFEACL.transform;
		}
		IGBCOFFLIED();
		FPEJFOHKDGM = FOGIOGKLNIP.PIOANBBCFFP.CCLAGBBDGDI.GetComponentsInChildren<Renderer>();
		try
		{
			RenderSettings.skybox.shader = FOGIOGKLNIP.LPLJMLGKCLK.GONADMGJENH.shader;
		}
		catch (Exception message)
		{
			MonoBehaviour.print(message);
		}
		bool flag = FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF.StartsWith(base.BHCIEFHBOPB.SniperDuel) || FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF.StartsWith(base.BHCIEFHBOPB.ParkourCity);
		Renderer[] fPEJFOHKDGM = FPEJFOHKDGM;
		foreach (Renderer renderer in fPEJFOHKDGM)
		{
			for (int num2 = 0; num2 < renderer.sharedMaterials.Length; num2++)
			{
				try
				{
					Material material = renderer.sharedMaterials[num2];
					if (material == null)
					{
						renderer.sharedMaterials[num2] = FOGIOGKLNIP.LPLJMLGKCLK.PKAMMNLNMJA;
						continue;
					}
					if (material.shader == null || string.IsNullOrEmpty(material.shader.name) || material.shader.name == base.BHCIEFHBOPB.InternalErrorShader || (!FOGIOGKLNIP.DGMBIMMABNO && FOGIOGKLNIP.LMMFHEODOPM.KKKONAPJJKO))
					{
						Texture2D texture2D = material.mainTexture as Texture2D;
						material.shader = ((flag || !(texture2D != null) || (texture2D.format != TextureFormat.DXT5 && texture2D.format != TextureFormat.RGBA32)) ? FOGIOGKLNIP.LPLJMLGKCLK.PKAMMNLNMJA.shader : FOGIOGKLNIP.LPLJMLGKCLK.KFLJHHCLICH.shader);
					}
					if (FOGIOGKLNIP.DGMBIMMABNO && material.shader.name.StartsWith(base.BHCIEFHBOPB.Self))
					{
						material.shader = FOGIOGKLNIP.LPLJMLGKCLK.PKAMMNLNMJA.shader;
					}
				}
				catch (Exception message2)
				{
					MonoBehaviour.print(message2);
				}
			}
		}
		Animation[] componentsInChildren = FOGIOGKLNIP.PIOANBBCFFP.CCLAGBBDGDI.GetComponentsInChildren<Animation>();
		foreach (Animation animation in componentsInChildren)
		{
			animation.cullingType = AnimationCullingType.BasedOnRenderers;
			animation.animatePhysics = false;
		}
		try
		{
			LAMFMFPKDFH = UnityEngine.Object.FindObjectsOfType<Animation>().WhereF((Animation AEMBPMJMOAB) => AEMBPMJMOAB.playAutomatically);
			AIGIPLIIHCG = UnityEngine.Object.FindObjectsOfType<AudioSource>().WhereF((AudioSource AEMBPMJMOAB) => AEMBPMJMOAB.playOnAwake);
			CNGMDJEANHD = UnityEngine.Object.FindObjectsOfType<ParticleSystem>().WhereF((ParticleSystem AEMBPMJMOAB) => AEMBPMJMOAB.main.playOnAwake);
			ILDFLKOIIDN = UnityEngine.Object.FindObjectsOfType<VideoPlayer>().WhereF((VideoPlayer AEMBPMJMOAB) => AEMBPMJMOAB.playOnAwake);
			LGGFAOBAFIP = GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.CEJKNEGOCNO);
			IOJCANCKPIL = GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.OHGLEPMEJKG);
			GDFPEGFIEIK = GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.JOLBKKEAJNL);
			JMAKHEHKDDL = GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.PPIOEHKHBMB);
			GGEMEHNHFCG = UnityEngine.Object.FindObjectsOfType<BombPlace>().OrderByF((BombPlace AEMBPMJMOAB) => AEMBPMJMOAB.name);
			PDOHNFKMCAG = UnityEngine.Object.FindObjectsOfType<BuyTrigger>();
			FFECBELHGGD = UnityEngine.Object.FindObjectsOfType<SpawnPlayer>();
			for (int num4 = 0; num4 < FFECBELHGGD.Length; num4++)
			{
				PAHMPFHNPLF = FFECBELHGGD.WhereF((SpawnPlayer AEMBPMJMOAB) => AEMBPMJMOAB.Team == AKGFLNIDAHK.FFDODCPJDJC);
				FMEPHNJPJNF = FFECBELHGGD.WhereF((SpawnPlayer AEMBPMJMOAB) => AEMBPMJMOAB.Team == AKGFLNIDAHK.BPHIKPNKJAN);
				MFNKJMBHMGE = FFECBELHGGD.WhereF((SpawnPlayer AEMBPMJMOAB) => AEMBPMJMOAB.Team == AKGFLNIDAHK.GJJOEKALDCH);
			}
			if (!FOGIOGKLNIP.PIOANBBCFFP.NBLJJDANCFG && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ))
			{
				int num5 = 0;
				BombPlace[] gGEMEHNHFCG = GGEMEHNHFCG;
				foreach (BombPlace bombPlace in gGEMEHNHFCG)
				{
					HGHGHLHBAMA(bombPlace.gameObject, "ABCD"[num5++].ToString());
				}
			}
			BombPlace[] gGEMEHNHFCG2 = GGEMEHNHFCG;
			foreach (BombPlace bombPlace2 in gGEMEHNHFCG2)
			{
				bombPlace2.transform.parent = CCLAGBBDGDI;
			}
			SpawnPlayer[] fFECBELHGGD = FFECBELHGGD;
			foreach (SpawnPlayer spawnPlayer in fFECBELHGGD)
			{
				spawnPlayer.transform.parent = CCLAGBBDGDI;
			}
			MGFGBMCEDPK = UnityEngine.Object.FindObjectsOfType<WeaponMap>();
			for (int num9 = 0; num9 < MGFGBMCEDPK.Length; num9++)
			{
				MGFGBMCEDPK[num9].enabled = false;
			}
			OCNLLGCCFAG = UnityEngine.Object.FindObjectOfType<WeaponManager>();
			BBBCMOHPEIH = UnityEngine.Object.FindObjectOfType<PlayerLifeManager>();
			JDFKPOMKMNJ.IPBKDPKONHH(100, delegate
			{
				if (base.NENPALDENAL && BBBCMOHPEIH != null)
				{
					NCHOPAEKPBK((Action<float>)GEJBHJGINDP, (float)BBBCMOHPEIH.Life);
					NCHOPAEKPBK((Action<float>)GHANHHOHGGJ, (float)BBBCMOHPEIH.Life);
					NCHOPAEKPBK((Action<float>)HDDBKANKMLG, (float)BBBCMOHPEIH.Armour);
					NCHOPAEKPBK(MGNKJMMOJDO, BBBCMOHPEIH.Speed);
				}
			});
			FOGIOGKLNIP[] hPALAEHEPEK = HPALAEHEPEK;
			for (int num10 = 0; num10 < hPALAEHEPEK.Length; num10++)
			{
				LBPBHBHEAPH lBPBHBHEAPH = new LBPBHBHEAPH();
				lBPBHBHEAPH.AEMBPMJMOAB = hPALAEHEPEK[num10];
				if (!(lBPBHBHEAPH.AEMBPMJMOAB is IAPJEBKJEHC))
				{
					continue;
				}
				if (OCNLLGCCFAG != null)
				{
					if (OCNLLGCCFAG.DisableWeapons)
					{
						if (!(lBPBHBHEAPH.AEMBPMJMOAB is FFGDOHNIMON) || OCNLLGCCFAG.ApprovedWeapons.WhereF(lBPBHBHEAPH.BEKJDJFLJJC).AnyF())
						{
							(lBPBHBHEAPH.AEMBPMJMOAB as IAPJEBKJEHC).HPFPFCNOKAM = ObscuredBool.FNIPJFGEFFD(OCNLLGCCFAG.DisableWeapons);
						}
						if (lBPBHBHEAPH.AEMBPMJMOAB is FFGDOHNIMON || OCNLLGCCFAG.ApprovedWeapons.WhereF(lBPBHBHEAPH.PMBKBKJIIPO).AnyF())
						{
							(lBPBHBHEAPH.AEMBPMJMOAB as IAPJEBKJEHC).HPFPFCNOKAM = ObscuredBool.FNIPJFGEFFD(false);
						}
					}
				}
				else if (!(lBPBHBHEAPH.AEMBPMJMOAB is OLILBNAJMLF) || !(lBPBHBHEAPH.AEMBPMJMOAB is FFGDOHNIMON))
				{
					(lBPBHBHEAPH.AEMBPMJMOAB as IAPJEBKJEHC).HPFPFCNOKAM = ObscuredBool.FNIPJFGEFFD(false);
					(lBPBHBHEAPH.AEMBPMJMOAB as IAPJEBKJEHC).LHBMNHLCJLA = ObscuredBool.FNIPJFGEFFD(true);
				}
				else
				{
					(lBPBHBHEAPH.AEMBPMJMOAB as IAPJEBKJEHC).HPFPFCNOKAM = ObscuredBool.FNIPJFGEFFD(false);
					(lBPBHBHEAPH.AEMBPMJMOAB as IAPJEBKJEHC).LHBMNHLCJLA = ObscuredBool.FNIPJFGEFFD(false);
				}
			}
			if (FOGIOGKLNIP.DGMBIMMABNO)
			{
				Light[] componentsInChildren2 = CCLAGBBDGDI.GetComponentsInChildren<Light>();
				foreach (Light light in componentsInChildren2)
				{
					if (light.type != LightType.Directional)
					{
						light.enabled = false;
					}
				}
				GameObject[] array = GameObject.FindGameObjectsWithTag(base.IOCECFNAKJM.NKICMNIEMBM);
				foreach (GameObject gameObject in array)
				{
					gameObject.SetActive(false);
				}
			}
		}
		catch (Exception message3)
		{
			UnityEngine.Debug.LogError(message3);
		}
		BCLLJNAEMNP(10, ref PAHMPFHNPLF, AKGFLNIDAHK.FFDODCPJDJC);
		BCLLJNAEMNP(10, ref FMEPHNJPJNF, AKGFLNIDAHK.BPHIKPNKJAN);
		BCLLJNAEMNP(10, ref FFECBELHGGD, AKGFLNIDAHK.DMELFHOKGBG);
		if (!FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			EBHOPCCNJAO.SetSceneID(999);
			NHEHOODOEPL();
		}
		BIHOCPAKHNF(CCLAGBBDGDI.name);
	}

	public void BPILKECDLJP()
	{
		if (ObscuredBool.FNIPJFGEFFD(HBICGHPGGPH))
		{
			return;
		}
		JDFKPOMKMNJ.IPBKDPKONHH(500, delegate
		{
			if (BDHHGHOGGIJ.NENPALDENAL && MGFGBMCEDPK.Length >= 1)
			{
				LIECKMIAEPF lIECKMIAEPF = new LIECKMIAEPF
				{
					KPHCHDHEKGH = this,
					FAGMOBEKJND = 0
				};
				while (lIECKMIAEPF.FAGMOBEKJND < MGFGBMCEDPK.Length)
				{
					if (MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].RandomDropSpecial || MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].RandomDrop.Length > 0)
					{
						PPIEIFOCBNE pPIEIFOCBNE = new PPIEIFOCBNE
						{
							FIJHLFDMHJB = lIECKMIAEPF,
							OHOOBEOCEGP = MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].RandomDrop.Random()
						};
						IAPJEBKJEHC iAPJEBKJEHC = FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.OKDFHJJNFCC.WhereF(pPIEIFOCBNE.BEKJDJFLJJC).FirstF();
						NCHOPAEKPBK(IKCJHHMPALL, iAPJEBKJEHC.FBGNKPPMENN, iAPJEBKJEHC.KOPFHECCACK, iAPJEBKJEHC.JJHIFNAJIBK, pPIEIFOCBNE.OHOOBEOCEGP.Ammo, pPIEIFOCBNE.OHOOBEOCEGP.Clips, pPIEIFOCBNE.OHOOBEOCEGP.Silencer, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.position, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.rotation, Vector3.zero);
					}
					else
					{
						IAPJEBKJEHC iAPJEBKJEHC2 = FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.OKDFHJJNFCC.WhereF(lIECKMIAEPF.BEKJDJFLJJC).FirstF();
						NCHOPAEKPBK(IKCJHHMPALL, iAPJEBKJEHC2.FBGNKPPMENN, iAPJEBKJEHC2.KOPFHECCACK, iAPJEBKJEHC2.JJHIFNAJIBK, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].Ammo, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].Clips, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].Silencer, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.position, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.rotation, Vector3.zero);
					}
					lIECKMIAEPF.FAGMOBEKJND++;
				}
			}
		});
	}

	private static Color32 LKJEHDNDEKF(int EHAPKEKPMOE)
	{
		byte r = (byte)(EHAPKEKPMOE >> 16);
		byte g = (byte)(EHAPKEKPMOE >> 8);
		byte b = (byte)(EHAPKEKPMOE >> 0);
		return new Color32(r, g, b, 1);
	}

	private static bool DADEBIFAPMF(Touch FJBCDEPOGDF)
	{
		return FOGIOGKLNIP.PBNCNLDIFIF(FJBCDEPOGDF, FOGIOGKLNIP.CIEBMCOJGCC.KMJJMNPHPKA, FOGIOGKLNIP.LPLJMLGKCLK.KEEOGKIBGCO * FOGIOGKLNIP.CIEBMCOJGCC.KMJJMNPHPKA.transform.localScale.x, TouchPhase.Moved, TouchPhase.Stationary, TouchPhase.Began);
	}

	private void HIEMIKLIBKC(IMCJHBIFEAK JLNAJMKHJOK)
	{
		FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.BEHFNEAKDAL.BIJHBGLFDAP + base.BHCIEFHBOPB.MapScore, delegate
		{
		}, base.BHCIEFHBOPB.MapScoreServer, FOGIOGKLNIP.LPLJMLGKCLK.PDDELHFGPNK, base.BHCIEFHBOPB.MapScoreMap, FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF), base.BHCIEFHBOPB.MapScorePlays, 1, base.BHCIEFHBOPB.MapScoreBotPlays, (base.JNPCOJFBJGP || JLNAJMKHJOK == IMCJHBIFEAK.ECACNDFNADN || JLNAJMKHJOK == IMCJHBIFEAK.Survival) ? 1 : 0, base.BHCIEFHBOPB.MapScoreNick, (!FOGIOGKLNIP.BEHFNEAKDAL.EPMOFPNGEAG) ? string.Empty : FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.NIGOGFAMFIB, base.BHCIEFHBOPB.MapScoreGameName, FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO.Substring(0, Math.Min(100, FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO.Length)));
	}

	private void CBNDGGBCGCH()
	{
		bool flag = base.JNPCOJFBJGP || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL);
		if ((ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDBJMGHGPBA) || FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD == IMCJHBIFEAK.TDM) && !base.JNPCOJFBJGP)
		{
			DILMJNOCKMA iBPALGFPAKO = FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO;
			iBPALGFPAKO.LBKOHPIDKFH = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(iBPALGFPAKO.LBKOHPIDKFH) + BDHHGHOGGIJ.PCLMLJHPJOH());
			DILMJNOCKMA iBPALGFPAKO2 = FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO;
			iBPALGFPAKO2.KIDFODCBGNA = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(iBPALGFPAKO2.KIDFODCBGNA) + ObscuredInt.FNIPJFGEFFD(BDHHGHOGGIJ.JODKOMPMKPE));
		}
		if (!ObscuredBool.FNIPJFGEFFD(JPDEHJCDHHA) || ObscuredBool.FNIPJFGEFFD(ANNMANFJHLF))
		{
			string[] array = FOGIOGKLNIP.EIIMBNKHJJA.JNHEHGAKOIL();
			string text = string.Join("\n", array);
			FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.JCMCPIPHDHB = ObscuredInt.FNIPJFGEFFD(Mathf.Max(0, ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.JCMCPIPHDHB) + ObscuredInt.FNIPJFGEFFD(BDHHGHOGGIJ.GDNILODEHEH)));
			if (FOGIOGKLNIP.BEHFNEAKDAL.EPMOFPNGEAG && !string.IsNullOrEmpty(FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO))
			{
				FOGIOGKLNIP.MPLIECCKLCO(base.BHCIEFHBOPB.Match, delegate
				{
				}, base.BHCIEFHBOPB.MatchKills, (!flag) ? BDHHGHOGGIJ.PCLMLJHPJOH() : 0, base.BHCIEFHBOPB.MatchDeaths, (!flag) ? ObscuredInt.FNIPJFGEFFD(BDHHGHOGGIJ.JODKOMPMKPE) : 0, base.BHCIEFHBOPB.MatchClan, FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ.COEIPPFAEDA, base.BHCIEFHBOPB.MatchAndroidKills, (FOGIOGKLNIP.DGMBIMMABNO && !flag) ? BDHHGHOGGIJ.PCLMLJHPJOH() : 0, base.BHCIEFHBOPB.MatchAndroidDeaths, (FOGIOGKLNIP.DGMBIMMABNO && !flag) ? ObscuredInt.FNIPJFGEFFD(BDHHGHOGGIJ.JODKOMPMKPE) : 0, base.BHCIEFHBOPB.MatchBotKills, flag ? BDHHGHOGGIJ.PCLMLJHPJOH() : 0, base.BHCIEFHBOPB.MatchGold, BDHHGHOGGIJ.IKAJFLANDKM, base.BHCIEFHBOPB.MatchMoney, ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.JCMCPIPHDHB), base.BHCIEFHBOPB.MatchCaptures, ObscuredInt.FNIPJFGEFFD(BDHHGHOGGIJ.NOOIOCJIIKI), base.BHCIEFHBOPB.MatchAwards, text, base.BHCIEFHBOPB.MatchAwardsCount, array.Length);
			}
			FOGIOGKLNIP.PBADCKNDABE(base.FKICDOGJIFN.GameMatchReport, string.Format(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchStats) + "\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}\n {10}: {11}\n {12}: {13}\n {14}\n" + string.Join("\n", FOGIOGKLNIP.EIIMBNKHJJA.ADFEGJPNDEI.ToArray()), FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchGameType), FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD, FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchKills), BDHHGHOGGIJ.PCLMLJHPJOH(), FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchDeaths), BDHHGHOGGIJ.JODKOMPMKPE, FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchHeadShots), BDHHGHOGGIJ.GCLAPAMJCHG, FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchCaptures), BDHHGHOGGIJ.NOOIOCJIIKI, FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchMedals), BDHHGHOGGIJ.IKAJFLANDKM, FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.GameMatchMoney), BDHHGHOGGIJ.GDNILODEHEH, base.FKICDOGJIFN.GameMatchAwards));
		}
		BIHOCPAKHNF(base.FKICDOGJIFN.GameDisconnected + base.name);
		base.MDBAFPKAKKK = false;
	}

	private void MPIPEKNIJAE()
	{
		if (!Application.isEditor && FOGIOGKLNIP.DGMBIMMABNO)
		{
			Shader shader = FOGIOGKLNIP.LPLJMLGKCLK.PKAMMNLNMJA.shader;
			UnityEngine.Object[] array = Resources.FindObjectsOfTypeAll(typeof(Material));
			for (int i = 0; i < array.Length; i++)
			{
				Material material = (Material)array[i];
				if (material.shader != null && (material.shader.name == "Bumped Specular" || material.shader.name == "Bumped Diffuse"))
				{
					material.shader = shader;
				}
			}
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.HNCIPILFFHF)
		{
			CKNDGDOFNAA();
		}
	}

	private static void HKPFHODBMKH(Material KEEMCOPCDAP)
	{
		Texture texture = (Texture)Resources.Load("textures/" + KEEMCOPCDAP.mainTexture.name);
		if (texture != null)
		{
			KEEMCOPCDAP.mainTexture = texture;
		}
	}

	private void NGOAGFOGFEF()
	{
		CLEIHBGGHMD(base.FKICDOGJIFN.GameResettingsSettings);
		KeyValuePair<KeyValuePair<string, string>, float>[] array = HDELOLGNHNI.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			KeyValuePair<KeyValuePair<string, string>, float> keyValuePair = array[i];
			NCHOPAEKPBK(CKMBCMGMGCL, keyValuePair.Key.Key, keyValuePair.Key.Value, keyValuePair.Value);
		}
	}

	private void INBICCIHAIC()
	{
		if (FOGIOGKLNIP.GMPBCIEDMCD != null)
		{
			JOCAFHIONFA[] array = FOGIOGKLNIP.GMPBCIEDMCD.ECEFCBMJPMD;
			foreach (JOCAFHIONFA jOCAFHIONFA in array)
			{
				if (ObscuredInt.FNIPJFGEFFD(jOCAFHIONFA.CNMKGNNGPDD) == 0 && jOCAFHIONFA.LMJDOOEODJK.DJEALLIOJEO(jOCAFHIONFA.NNBDEKBINFP) == 0)
				{
					jOCAFHIONFA.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(false);
				}
			}
		}
		IAPJEBKJEHC[] oKDFHJJNFCC = AKLFGPJPLKM.OKDFHJJNFCC;
		foreach (IAPJEBKJEHC iAPJEBKJEHC in oKDFHJJNFCC)
		{
			for (int k = 0; k < iAPJEBKJEHC.NMEGIDDBNGF.Length; k++)
			{
				iAPJEBKJEHC.NMEGIDDBNGF[k] = iAPJEBKJEHC.FPCJLIGOHOH;
			}
		}
	}

	private static void AFIAEDMAHLP(string KLLKONMADKA)
	{
		FOGIOGKLNIP.CIEBMCOJGCC.MGDLCDBFHCG(KLLKONMADKA, true);
	}

	public void FELHMNGDAPO(int FAGMOBEKJND, GameObject GIPIKICBHKA)
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			GIPIKICBHKA.GetComponent<NetworkView>().viewID = OHCHIHBJEGJ.Pop();
			return;
		}
		PhotonView component = GIPIKICBHKA.GetComponent<PhotonView>();
		component.viewID = new PhotonViewID(50 + FAGMOBEKJND, null);
		component.SetSceneID(50 + FAGMOBEKJND);
	}

	public void OEHIIPKIEFP(GameObject BIMHAGOKNME)
	{
		if (Network.isServer && BIMHAGOKNME != null)
		{
			Network.RemoveRPCs(BIMHAGOKNME.GetComponent<NetworkView>().viewID);
			Network.Destroy(BIMHAGOKNME);
		}
	}

	[RPC]
	public void EFCIHNCCHPO(int MKBNKANDCDB)
	{
		GGPOLOMIGOI.RemoveAt(MKBNKANDCDB);
		for (int i = 0; i < GGPOLOMIGOI.Count; i++)
		{
			GGPOLOMIGOI[i].MKBNKANDCDB = i;
		}
	}

	[RPC]
	public void IKCJHHMPALL(int ALEOHHMPCOC, int CIDGGHCLDKN, string JJHIFNAJIBK, int CNMKGNNGPDD, int PPLACOKDMDF, bool DECONHBIJAA, Vector3 GIDEOJGAFJH, Quaternion JPINOKOACLM, Vector3 KBPICMPEJDL)
	{
		EJDKALEIBBG component = JMJLEDGJIJK((FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.AKIMNDMGFMN.FBGNKPPMENN != ALEOHHMPCOC) ? "WeaponDrop" : "C4Drop", "game/", false, null, null, GIDEOJGAFJH, JPINOKOACLM).GetComponent<EJDKALEIBBG>();
		if (!component.enabled)
		{
			component.enabled = true;
		}
		component.AHBGGKFEHBF = false;
		component.JPBAFJFNCDO = 0f;
		UnityEngine.Object.Destroy(component.KKBFMBENBGF);
		WorldModel component2 = CFBOHBGDAGD("W_" + FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.OKDFHJJNFCC[ALEOHHMPCOC].MOLNOFIHKPP + "_dropped", "Weapons/", true).GetComponent<WorldModel>();
		if (component2 != null)
		{
			component.MLENJBJHECL.sharedMesh = component2.MeshFilter.sharedMesh;
			component.CFPLIEMIEOD.sharedMaterials = component2.MeshRenderer.sharedMaterials;
			if (component2.SilencerMeshFilter != null && component2.SilencerMeshRenderer != null)
			{
				component.POMDDJECBJA.sharedMesh = component2.SilencerMeshFilter.sharedMesh;
				component.HNHAAIICGHO.sharedMaterials = component2.SilencerMeshRenderer.sharedMaterials;
			}
		}
		component.KKBFMBENBGF = component.ICIEDCMDJFO.AddComponent<MeshCollider>();
		component.KKBFMBENBGF.convex = true;
		if (component.KCBGABFLFCL == null)
		{
			component.KCBGABFLFCL = component.ICIEDCMDJFO.AddComponent<Rigidbody>();
			component.KCBGABFLFCL.drag = 0f;
			component.KCBGABFLFCL.mass = 100f;
			component.KCBGABFLFCL.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		}
		component.KCBGABFLFCL.ResetCenterOfMass();
		component.EHOEFMPLIFB.localScale = new Vector3(1f, 1f, 1f);
		component.MKBNKANDCDB = GGPOLOMIGOI.Count - 1 + 1;
		GGPOLOMIGOI.Add(component);
		component.CMPKOEMBHDO = CIDGGHCLDKN;
		component.MGFENAGABOE = ALEOHHMPCOC;
		component.JJHIFNAJIBK = JJHIFNAJIBK;
		component.FPNFMBGAFDE = CNMKGNNGPDD;
		component.BCKOICGHJJJ(DECONHBIJAA);
		component.PLDMNFCBFDD = PPLACOKDMDF;
		component.KCBGABFLFCL.velocity = KBPICMPEJDL;
	}

	public void JNAPAOABFFC()
	{
		if (IGJKLHOGPHL)
		{
			if (!HLDLJFOALII)
			{
				NCHOPAEKPBK(FBFCEIFFNEO, string.Concat(BDHHGHOGGIJ, ": ", PAPGHAPKIBJ.text), BDHHGHOGGIJ.MFAGKFPCJFG, NKPPCGPKDHB);
			}
			IGJKLHOGPHL = false;
			base.MDBAFPKAKKK = true;
		}
	}

	private void OGOJKJDJEOG()
	{
		if (FOGIOGKLNIP.PIOANBBCFFP.DALNPKPJAJF)
		{
			return;
		}
		if (IGJKLHOGPHL)
		{
			if (FOGIOGKLNIP.EPBMIIPELPO.DPNEFNPNBCD(KeyCode.Escape))
			{
				base.MDBAFPKAKKK = true;
				IGJKLHOGPHL = false;
			}
			if (FOGIOGKLNIP.EPBMIIPELPO.DPNEFNPNBCD(KeyCode.Return))
			{
				if (!HLDLJFOALII)
				{
					NCHOPAEKPBK(FBFCEIFFNEO, string.Concat(BDHHGHOGGIJ, ": ", PAPGHAPKIBJ.text), BDHHGHOGGIJ.MFAGKFPCJFG, NKPPCGPKDHB);
				}
				base.MDBAFPKAKKK = true;
				IGJKLHOGPHL = false;
			}
		}
		else if (FOGIOGKLNIP.EPBMIIPELPO.DPNEFNPNBCD(KeyCode.U) || FOGIOGKLNIP.EPBMIIPELPO.DPNEFNPNBCD(KeyCode.Y) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.CLLBHGPOAOD, default(TouchPhase)))
		{
			base.MDBAFPKAKKK = false;
			NKPPCGPKDHB = FOGIOGKLNIP.EPBMIIPELPO.DPNEFNPNBCD(KeyCode.U);
			IGJKLHOGPHL = true;
			PAPGHAPKIBJ.ActivateInputField();
			PAPGHAPKIBJ.text = string.Empty;
		}
	}

	private void LJKLBFKJEKD()
	{
		if (FOGIOGKLNIP.HJDAJDIIMPD.AnyF((Touch FJBCDEPOGDF) => FJBCDEPOGDF.phase == TouchPhase.Began && !DADEBIFAPMF(FJBCDEPOGDF)))
		{
			if (Time.time - PHLMCKBAGGG < 0.3f)
			{
				EKIIGENHGKD = Time.time;
			}
			else
			{
				PHLMCKBAGGG = Time.time;
			}
		}
	}

	private void GNHOMGMBHPB()
	{
	}

	private void PPBLJMDIFKB()
	{
		if (ObscuredBool.FNIPJFGEFFD(IAFDEBFCAJI))
		{
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.GDFHLAHHCME))
			{
				if (base.NENPALDENAL && ObscuredFloat.FNIPJFGEFFD(JFMNIDEDNHG) < 0f)
				{
					HJNCMDLHKNE(++DFFLEKBAJKC);
				}
				JFMNIDEDNHG = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(JFMNIDEDNHG) - Time.deltaTime);
			}
			else
			{
				JFMNIDEDNHG = ObscuredFloat.FNIPJFGEFFD(ObscuredFloat.FNIPJFGEFFD(JFMNIDEDNHG) - Time.deltaTime);
			}
		}
		if (Input.anyKey)
		{
			LAAEJKMCKOI = ObscuredFloat.FNIPJFGEFFD(Time.time);
		}
		if (Time.time - ObscuredFloat.FNIPJFGEFFD(LAAEJKMCKOI) > 240f && !FOGIOGKLNIP.OMMLFOEPEEK && (!FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO || !Network.isServer))
		{
			OENODCJHEOG();
		}
		if (Input.GetKeyDown(KeyCode.Backslash))
		{
			base.MDBAFPKAKKK = !base.MDBAFPKAKKK;
		}
		if (!FOGIOGKLNIP.PIOANBBCFFP.IGJKLHOGPHL)
		{
			if (Input.GetKeyDown(KeyCode.Escape) || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.M) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.FKEGBLFHFJK, default(TouchPhase)))
			{
				DALNPKPJAJF = !DALNPKPJAJF;
				base.MDBAFPKAKKK = !DALNPKPJAJF;
				FOGIOGKLNIP.CIEBMCOJGCC.DLAFHHGPHFO.SetActive(false);
			}
			if (BDHHGHOGGIJ != null && BDHHGHOGGIJ.GHKPKNMDMLH == IBOGNCENEHO.FDGPLHOFOEN && (FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.B) || PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.FBBNLGKBEMN, default(TouchPhase))) && !DALNPKPJAJF)
			{
				FOGIOGKLNIP.LBJBBGEDGJF.PIEIJIHCDGC();
			}
		}
		if (FOGIOGKLNIP.EPBMIIPELPO.JEMHJCCILMN() && !FOGIOGKLNIP.DGMBIMMABNO && (!FOGIOGKLNIP.LBJBBGEDGJF.enabled || !FOGIOGKLNIP.IGBGDNLNDJM.Contains(Input.mousePosition)))
		{
			if (Time.time - MGBCFMMBGGL < 0.3f && !base.MDBAFPKAKKK)
			{
				base.MDBAFPKAKKK = true;
				FOGIOGKLNIP.PIOANBBCFFP.AHINLBKLFHJ = false;
			}
			MGBCFMMBGGL = Time.time;
		}
	}

	private void IGBCOFFLIED()
	{
		Bounds[] source = FOGIOGKLNIP.PIOANBBCFFP.CCLAGBBDGDI.GetComponentsInChildren<Collider>().SelectF((Collider AEMBPMJMOAB) => AEMBPMJMOAB.bounds);
		DHHNIGKHPLC = new Vector3(source.MinF((Bounds AEMBPMJMOAB) => AEMBPMJMOAB.min.x), source.MinF((Bounds AEMBPMJMOAB) => AEMBPMJMOAB.min.y), source.MinF((Bounds AEMBPMJMOAB) => AEMBPMJMOAB.min.z));
		BLNEKFBHKJB = new Vector3(source.MaxF((Bounds AEMBPMJMOAB) => AEMBPMJMOAB.max.x), source.MaxF((Bounds AEMBPMJMOAB) => AEMBPMJMOAB.max.y), source.MaxF((Bounds AEMBPMJMOAB) => AEMBPMJMOAB.max.z));
	}

	private bool DAJCDEAPINB()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.FABPKKNPCBF)
		{
			return PBNCNLDIFIF(FOGIOGKLNIP.CIEBMCOJGCC.JFFMCCDKBND, TouchPhase.Began, TouchPhase.Stationary, TouchPhase.Moved);
		}
		Touch[] hJDAJDIIMPD = FOGIOGKLNIP.HJDAJDIIMPD;
		for (int i = 0; i < hJDAJDIIMPD.Length; i++)
		{
			Touch fJBCDEPOGDF = hJDAJDIIMPD[i];
			if (FOGIOGKLNIP.PBNCNLDIFIF(fJBCDEPOGDF, FOGIOGKLNIP.CIEBMCOJGCC.JFFMCCDKBND, FOGIOGKLNIP.CIEBMCOJGCC.JFFMCCDKBND.transform.localScale.x * 1.3f) && fJBCDEPOGDF.phase == TouchPhase.Began)
			{
				BJBAFFEPDLF = fJBCDEPOGDF.fingerId;
			}
			if ((fJBCDEPOGDF.phase == TouchPhase.Ended || fJBCDEPOGDF.phase == TouchPhase.Canceled) && BJBAFFEPDLF == fJBCDEPOGDF.fingerId)
			{
				BJBAFFEPDLF = -1;
			}
		}
		return BJBAFFEPDLF != -1;
	}

	private IBOGNCENEHO BMCNOHJAECG()
	{
		float num = ObscuredFloat.FNIPJFGEFFD(FPFAEOJAIBB) + ObscuredFloat.FNIPJFGEFFD(LGIOALGFFHP) + ObscuredFloat.FNIPJFGEFFD(JFLGCMGFGHF) + ObscuredFloat.FNIPJFGEFFD(HJNMHAGEEPC);
		float value = UnityEngine.Random.value;
		if (value < ObscuredFloat.FNIPJFGEFFD(FPFAEOJAIBB) / num)
		{
			return IBOGNCENEHO.Fatty;
		}
		if (value > (ObscuredFloat.FNIPJFGEFFD(FPFAEOJAIBB) + ObscuredFloat.FNIPJFGEFFD(LGIOALGFFHP) + ObscuredFloat.FNIPJFGEFFD(JFLGCMGFGHF)) / num)
		{
			return IBOGNCENEHO.FDGPLHOFOEN;
		}
		if (value > (ObscuredFloat.FNIPJFGEFFD(FPFAEOJAIBB) + ObscuredFloat.FNIPJFGEFFD(LGIOALGFFHP)) / num && value < (ObscuredFloat.FNIPJFGEFFD(FPFAEOJAIBB) + ObscuredFloat.FNIPJFGEFFD(LGIOALGFFHP) + ObscuredFloat.FNIPJFGEFFD(JFLGCMGFGHF)) / num)
		{
			return IBOGNCENEHO.Kamikaze;
		}
		return IBOGNCENEHO.Monster;
	}

	internal KKJBDENNKGF JNPIKJAGHFI(JDILMODHLOJ BJDCCKHBENA, UnityEngine.Object MEEICNEEJOJ, Vector3 ELGIKGAIIOD, Vector3 MNINHIMEDCK)
	{
		FKHKEMFBBNE = ICONFJBEJPN(MEEICNEEJOJ, ELGIKGAIIOD, Quaternion.Euler(MNINHIMEDCK), 2).GetComponent<KKJBDENNKGF>();
		FKHKEMFBBNE.HCNJDLNHFIF("MCHAGMJPOIK", BJDCCKHBENA.MFAGKFPCJFG);
		if (!ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK))
		{
			FOGIOGKLNIP.NMGDHKIKCED = FKHKEMFBBNE;
			ELPJKAELPJA = true;
		}
		if (!ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK) && FKHKEMFBBNE is FDGPLHOFOEN)
		{
			FOGIOGKLNIP.GMPBCIEDMCD = (FDGPLHOFOEN)FKHKEMFBBNE;
		}
		return FKHKEMFBBNE;
	}

	internal void JNPIKJAGHFI(JDILMODHLOJ BJDCCKHBENA, UnityEngine.Object MEEICNEEJOJ)
	{
		Vector3 zero = Vector3.zero;
		Vector3 zero2 = Vector3.zero;
		Transform transform = null;
		transform = ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL)) ? ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FJAJABCHEMI)) ? ((BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) ? LOCHJEFJLJG : LNPHCAOCEBD) : MAMMBEFMKIP(BJDCCKHBENA.JGECOECAJLK, FFECBELHGGD)) : ((MFNKJMBHMGE.Length > 0 && ObscuredBool.FNIPJFGEFFD(BJDCCKHBENA.HIBLODEGHAK) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ)) ? MAMMBEFMKIP(BJDCCKHBENA.JGECOECAJLK, MFNKJMBHMGE) : ((BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) ? MAMMBEFMKIP(BJDCCKHBENA.JGECOECAJLK, FMEPHNJPJNF) : MAMMBEFMKIP(BJDCCKHBENA.JGECOECAJLK, PAHMPFHNPLF))));
		zero = transform.position;
		zero2 = transform.eulerAngles;
		JNPIKJAGHFI(BJDCCKHBENA, MEEICNEEJOJ, zero, zero2);
	}

	internal void IIFMJHEELBA()
	{
		if (FOGIOGKLNIP.NMGDHKIKCED != null && FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD != IMCJHBIFEAK.ZombieMode)
		{
			BDHHGHOGGIJ.AMDNHDLJAEP(ObscuredInt.FNIPJFGEFFD(BDHHGHOGGIJ.BLGILFLFHNI) + 1);
			FOGIOGKLNIP.NMGDHKIKCED.APAMPKPNIPC();
		}
		if (FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ.JGECOECAJLK != GNMHJEPNHDL.Spectators && (FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count == 0 || base.JNPCOJFBJGP || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ) || (!ELPJKAELPJA && ((float)FOGIOGKLNIP.PIOANBBCFFP.FBFOHOIFJGL.Count > (float)FOGIOGKLNIP.PIOANBBCFFP.LDAKBEMPLEB.Count / 2f || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL)))))
		{
			if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ) && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.NBFGNGGJDNB))
			{
				FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.IPBKDPKONHH((!FOGIOGKLNIP.OMMLFOEPEEK) ? ((int)ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.LJNIGMCOFGC) * 1000) : 100, delegate
				{
					if (FOGIOGKLNIP.NMGDHKIKCED == null && BDHHGHOGGIJ.JGECOECAJLK != GNMHJEPNHDL.Spectators)
					{
						FOGIOGKLNIP.PIOANBBCFFP.JNPIKJAGHFI(BDHHGHOGGIJ, FOGIOGKLNIP.PIOANBBCFFP.ELKMMPDEDAK(BDHHGHOGGIJ.GHKPKNMDMLH));
					}
				});
			}
			else
			{
				JNPIKJAGHFI(BDHHGHOGGIJ, ELKMMPDEDAK(BDHHGHOGGIJ.GHKPKNMDMLH));
				FOGIOGKLNIP.LPLJMLGKCLK.EGBIDFJOJJE = Time.time;
			}
		}
		if (FOGIOGKLNIP.NMGDHKIKCED != null && base.NENPALDENAL && FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD == IMCJHBIFEAK.Survival && !ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.IAFDEBFCAJI))
		{
			DIHBNECKLBC(GIAONHLJAGE, OEIIKDFMDGJ);
		}
		if (base.JNPCOJFBJGP && FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD == IMCJHBIFEAK.Classic && FBFOHOIFJGL.Count <= 1 && !FOGIOGKLNIP.OMMLFOEPEEK)
		{
			for (int num = 0; num < ((FOGIOGKLNIP.NMGDHKIKCED.BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) ? 3 : 2); num++)
			{
				DMAILAJDJLD(0, 2);
			}
			for (int num2 = 0; num2 < ((FOGIOGKLNIP.NMGDHKIKCED.BJDCCKHBENA.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) ? 2 : 3); num2++)
			{
				DMAILAJDJLD(0, 1);
			}
		}
	}

	[CompilerGenerated]
	private static bool HJENOGEGDJK(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB is FDGPLHOFOEN;
	}

	[CompilerGenerated]
	private static bool NBECBCLALHF(JDILMODHLOJ AEMBPMJMOAB)
	{
		return !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK);
	}

	[CompilerGenerated]
	private static bool JKLLLKFGKJP(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA != null && !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.BJDCCKHBENA.HIBLODEGHAK) && (AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.KBGDFEDOIJJ));
	}

	[CompilerGenerated]
	private static JDILMODHLOJ DHHHJAKNNEP(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA;
	}

	[CompilerGenerated]
	private static bool PAMDCLHIDCG(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool MCMKIGJNCOH(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists;
	}

	[CompilerGenerated]
	private static bool EICELAIKIIM(KKJBDENNKGF AEMBPMJMOAB)
	{
		return !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) && !AEMBPMJMOAB.KAMAMHFJDGG;
	}

	[CompilerGenerated]
	private bool DBPNFOHONFL(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == BDHHGHOGGIJ.JGECOECAJLK;
	}

	[CompilerGenerated]
	private static bool JAALCAHKAKJ(JDILMODHLOJ AEMBPMJMOAB)
	{
		return ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.CMFHKELIOEA) > 49;
	}

	[CompilerGenerated]
	private static bool MDKJBMJLOCF(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static float JOJAGLGKLLK(KKJBDENNKGF AEMBPMJMOAB)
	{
		return (FOGIOGKLNIP.NGFDFPGNDCJ.ELGIKGAIIOD - AEMBPMJMOAB.ELGIKGAIIOD).magnitude;
	}

	[CompilerGenerated]
	private static bool IKMBEIIOPNI(JDILMODHLOJ AEMBPMJMOAB)
	{
		return !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK);
	}

	[CompilerGenerated]
	private static bool JPPHIBHKIDE(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool EHHIDMELKMI(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool KCJMIOEFBNO(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists;
	}

	[CompilerGenerated]
	private static bool FODLAMOEJNB(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists;
	}

	[CompilerGenerated]
	private static bool BJAILOCNCJJ(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Spectators;
	}

	[CompilerGenerated]
	private static string PJGNNDJGNML(JDILMODHLOJ LCBKHLLPIGM)
	{
		return LCBKHLLPIGM.name;
	}

	[CompilerGenerated]
	private static bool GPIIHEEFJDN(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists || AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Zombies;
	}

	[CompilerGenerated]
	private static ObscuredInt MIMJPMICGAF(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.CMFHKELIOEA;
	}

	[CompilerGenerated]
	private static bool HLBGLMNEMGL(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static ObscuredInt BDFDAFOMPNC(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.CMFHKELIOEA;
	}

	[CompilerGenerated]
	private static bool JAPCHEFDAKO(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists && AEMBPMJMOAB.NJEPMOIDJKH != null;
	}

	[CompilerGenerated]
	private static Transform AJEAPEHJGGO(GameObject AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.transform;
	}

	[CompilerGenerated]
	private static float DKONLHLHILG(Transform AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.position.magnitude;
	}

	[CompilerGenerated]
	private static Transform LOIPKCLDGOJ(GameObject AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.transform;
	}

	[CompilerGenerated]
	private static float NBNCBPMNILH(Transform AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.position.magnitude;
	}

	[CompilerGenerated]
	private static bool OIJJLPPJEFH(KKJBDENNKGF AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.BJDCCKHBENA.HIBLODEGHAK);
	}

	[CompilerGenerated]
	private void GJGDMHEIMEA()
	{
		if (FOGIOGKLNIP.NMGDHKIKCED == null && BDHHGHOGGIJ.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists)
		{
			FOGIOGKLNIP.PIOANBBCFFP.JNPIKJAGHFI(BDHHGHOGGIJ, FOGIOGKLNIP.PIOANBBCFFP.ELKMMPDEDAK(BDHHGHOGGIJ.GHKPKNMDMLH));
		}
	}

	[CompilerGenerated]
	private static bool JCNOGJCOOEM(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists && ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.BHFDJDDGHKA) < 100;
	}

	[CompilerGenerated]
	private static bool LPELLGMPBCM(KKJBDENNKGF AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK);
	}

	[CompilerGenerated]
	private static bool FCFBEANENJK(JDILMODHLOJ AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK);
	}

	[CompilerGenerated]
	private void NODEMDDIIJC()
	{
		foreach (JDILMODHLOJ item in LDAKBEMPLEB.WhereF((JDILMODHLOJ AEMBPMJMOAB) => ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) && AEMBPMJMOAB.NJEPMOIDJKH == null))
		{
			JNPIKJAGHFI(item, ELKMMPDEDAK(item.GHKPKNMDMLH));
		}
	}

	[CompilerGenerated]
	private void HBICDMKFHFL()
	{
		LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.Go);
	}

	[CompilerGenerated]
	private void DDKOKLAFNBO()
	{
		if (OCKHCJGLOEL)
		{
			JNPIKJAGHFI(BDHHGHOGGIJ, ELKMMPDEDAK(BDHHGHOGGIJ.GHKPKNMDMLH));
		}
	}

	[CompilerGenerated]
	private static string JDMLGDLBKKL(Match AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.Value;
	}

	[CompilerGenerated]
	private static bool GHCBGJHEJAH(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool LNEOINEDENC(KKJBDENNKGF AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) && AEMBPMJMOAB.KAMAMHFJDGG;
	}

	[CompilerGenerated]
	private static bool GLHCLHMIDIC(bool AEMBPMJMOAB)
	{
		return AEMBPMJMOAB;
	}

	[CompilerGenerated]
	private static bool KFEFCCKLIOO(bool AEMBPMJMOAB)
	{
		return AEMBPMJMOAB;
	}

	[CompilerGenerated]
	private static bool DJOGLOFPOPN(JDILMODHLOJ AEMBPMJMOAB)
	{
		return !ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK);
	}

	[CompilerGenerated]
	private static bool OIFLLIBBECP(JDILMODHLOJ AEMBPMJMOAB)
	{
		return ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.CMFHKELIOEA) >= 50;
	}

	[CompilerGenerated]
	private static ObscuredInt KIEPLDGAPDG(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.CMFHKELIOEA;
	}

	[CompilerGenerated]
	private void HOBPBDKADLD()
	{
		IHCFILFBIJF = ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.OMMLFOEPEEK);
	}

	[CompilerGenerated]
	private static IEnumerable<Material> NCMIHBDBBIN(Renderer AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.GetComponent<Renderer>().materials;
	}

	[CompilerGenerated]
	private static bool LEDAINFJGKE(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.Terrorists;
	}

	[CompilerGenerated]
	private static bool GDCDAOMFNGC(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool FJALNFBKFIA(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool IKGLKPKLIOD(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool PGLPCFDGIFJ(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool HEFHLPKDFGO(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool CBLKJFGGJDO(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool HJNFGGBOPKP(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool OLJIHHBGLNA(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK != GNMHJEPNHDL.Terrorists;
	}

	[CompilerGenerated]
	private static bool NECIPNKCJGH(JDILMODHLOJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool MBOEIHBBBMJ(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists;
	}

	[CompilerGenerated]
	private static bool DINKLELGFFG(KKJBDENNKGF AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.BJDCCKHBENA.JGECOECAJLK == GNMHJEPNHDL.Terrorists;
	}

	[CompilerGenerated]
	private static bool AOAKIJAADCP(ENFDKNAODIJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGDLDJLBKEF;
	}

	[CompilerGenerated]
	private static bool AAOKDPAMKAF(ENFDKNAODIJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGDLDJLBKEF;
	}

	[CompilerGenerated]
	private static bool BNNKOPPKHAL(ENFDKNAODIJ AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.JGDLDJLBKEF;
	}

	[CompilerGenerated]
	private void HGBHDPGJNNG()
	{
		if (!IGJKLHOGPHL)
		{
			NMEOIEFEKFM.gameObject.SetActive(false);
		}
	}

	[CompilerGenerated]
	private static bool MGKOKLDJCOO(Collider AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.gameObject.layer == 10 || AEMBPMJMOAB.bounds.size.y > 3f;
	}

	[CompilerGenerated]
	private static float PICGLHLHOCF(Collider AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.bounds.size.magnitude;
	}

	[CompilerGenerated]
	private static bool DLEKGPBCFPG(GameObject AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.layer == 31 || AEMBPMJMOAB.layer == 18 || AEMBPMJMOAB.layer == 17 || AEMBPMJMOAB.layer == 28;
	}

	[CompilerGenerated]
	private static bool PPGJPNINKMA(GameObject AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.layer == 10 || AEMBPMJMOAB.layer == 8 || AEMBPMJMOAB.layer == 20;
	}

	[CompilerGenerated]
	private static bool JADOHIFKIGC(Animation AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.playAutomatically;
	}

	[CompilerGenerated]
	private static bool HMMBOKOCBJD(AudioSource AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.playOnAwake;
	}

	[CompilerGenerated]
	private static bool FENFEDKPBEB(ParticleSystem AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.main.playOnAwake;
	}

	[CompilerGenerated]
	private static bool NEEPKBCKKFM(VideoPlayer AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.playOnAwake;
	}

	[CompilerGenerated]
	private static string JPOEHCGDABE(BombPlace AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.name;
	}

	[CompilerGenerated]
	private static bool AAJHDKFEEKF(SpawnPlayer AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.Team == AKGFLNIDAHK.FFDODCPJDJC;
	}

	[CompilerGenerated]
	private static bool IJBKJEJOFEB(SpawnPlayer AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.Team == AKGFLNIDAHK.BPHIKPNKJAN;
	}

	[CompilerGenerated]
	private static bool AAKCGHBIDNB(SpawnPlayer AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.Team == AKGFLNIDAHK.GJJOEKALDCH;
	}

	[CompilerGenerated]
	private void OIAACKCFMEL()
	{
		if (base.NENPALDENAL && BBBCMOHPEIH != null)
		{
			NCHOPAEKPBK((Action<float>)GEJBHJGINDP, (float)BBBCMOHPEIH.Life);
			NCHOPAEKPBK((Action<float>)GHANHHOHGGJ, (float)BBBCMOHPEIH.Life);
			NCHOPAEKPBK((Action<float>)HDDBKANKMLG, (float)BBBCMOHPEIH.Armour);
			NCHOPAEKPBK(MGNKJMMOJDO, BBBCMOHPEIH.Speed);
		}
	}

	[CompilerGenerated]
	private void IFAIIOGADEE()
	{
		if (!BDHHGHOGGIJ.NENPALDENAL || MGFGBMCEDPK.Length < 1)
		{
			return;
		}
		LIECKMIAEPF lIECKMIAEPF = new LIECKMIAEPF
		{
			KPHCHDHEKGH = this,
			FAGMOBEKJND = 0
		};
		while (lIECKMIAEPF.FAGMOBEKJND < MGFGBMCEDPK.Length)
		{
			if (MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].RandomDropSpecial || MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].RandomDrop.Length > 0)
			{
				PPIEIFOCBNE pPIEIFOCBNE = new PPIEIFOCBNE
				{
					FIJHLFDMHJB = lIECKMIAEPF,
					OHOOBEOCEGP = MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].RandomDrop.Random()
				};
				IAPJEBKJEHC iAPJEBKJEHC = FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.OKDFHJJNFCC.WhereF(pPIEIFOCBNE.BEKJDJFLJJC).FirstF();
				NCHOPAEKPBK(IKCJHHMPALL, iAPJEBKJEHC.FBGNKPPMENN, iAPJEBKJEHC.KOPFHECCACK, iAPJEBKJEHC.JJHIFNAJIBK, pPIEIFOCBNE.OHOOBEOCEGP.Ammo, pPIEIFOCBNE.OHOOBEOCEGP.Clips, pPIEIFOCBNE.OHOOBEOCEGP.Silencer, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.position, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.rotation, Vector3.zero);
			}
			else
			{
				IAPJEBKJEHC iAPJEBKJEHC2 = FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.OKDFHJJNFCC.WhereF(lIECKMIAEPF.BEKJDJFLJJC).FirstF();
				NCHOPAEKPBK(IKCJHHMPALL, iAPJEBKJEHC2.FBGNKPPMENN, iAPJEBKJEHC2.KOPFHECCACK, iAPJEBKJEHC2.JJHIFNAJIBK, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].Ammo, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].Clips, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].Silencer, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.position, MGFGBMCEDPK[lIECKMIAEPF.FAGMOBEKJND].transform.rotation, Vector3.zero);
			}
			lIECKMIAEPF.FAGMOBEKJND++;
		}
	}

	[CompilerGenerated]
	private static void GOJJNBFMJPF(string P_0)
	{
	}

	[CompilerGenerated]
	private static void DEOEAHOCJJL(string P_0)
	{
	}

	[CompilerGenerated]
	private static bool NPAMCDEOJIN(Touch FJBCDEPOGDF)
	{
		return FJBCDEPOGDF.phase == TouchPhase.Began && !DADEBIFAPMF(FJBCDEPOGDF);
	}

	[CompilerGenerated]
	private static Bounds IPAABFGNDPF(Collider AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.bounds;
	}

	[CompilerGenerated]
	private static float LPAMLDDHGCN(Bounds AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.min.x;
	}

	[CompilerGenerated]
	private static float MDKGDBBINMH(Bounds AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.min.y;
	}

	[CompilerGenerated]
	private static float FJMIHKMJFKE(Bounds AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.min.z;
	}

	[CompilerGenerated]
	private static float GAPCNCLANGH(Bounds AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.max.x;
	}

	[CompilerGenerated]
	private static float LCDHBFPKKOM(Bounds AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.max.y;
	}

	[CompilerGenerated]
	private static float FKPCNDFBHCB(Bounds AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.max.z;
	}

	[CompilerGenerated]
	private void IFJDEKCPKEK()
	{
		if (FOGIOGKLNIP.NMGDHKIKCED == null && BDHHGHOGGIJ.JGECOECAJLK != GNMHJEPNHDL.Spectators)
		{
			FOGIOGKLNIP.PIOANBBCFFP.JNPIKJAGHFI(BDHHGHOGGIJ, FOGIOGKLNIP.PIOANBBCFFP.ELKMMPDEDAK(BDHHGHOGGIJ.GHKPKNMDMLH));
		}
	}

	[CompilerGenerated]
	private static bool EIJHGMLEGGG(JDILMODHLOJ AEMBPMJMOAB)
	{
		return ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.HIBLODEGHAK) && AEMBPMJMOAB.NJEPMOIDJKH == null;
	}
}
