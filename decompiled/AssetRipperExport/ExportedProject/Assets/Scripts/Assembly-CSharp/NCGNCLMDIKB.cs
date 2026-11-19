using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class NCGNCLMDIKB : FOGIOGKLNIP
{
	public class GBPEHKNJJAB
	{
		public Vector2 NPNEIIGJJGO;

		public List<string> OIKEGAKPBIJ = new List<string>();
	}

	public class MPEDAMLGFLD
	{
		public string JCCLHHAKFLJ;

		public string PPDLGGIDCOM;

		public List<string> CFHPBDILJGH = new List<string>();

		public List<string> DGNBCAFOLCB = new List<string>();
	}

	public enum COAMMJIMMBP
	{
		OOABOFLFLBD = -6,
		NNDHDMBFLJF = -5,
		DIBHMMFGANA = -4,
		HCDPPHGEHCF = -3,
		CKEEFKIBJMO = -2,
		HIGMMEFKDCE = -1,
		BBHHBGIIHPH = 0
	}

	public enum Menu
	{
		Chat = 0,
		AccountInfo = 1,
		ClanInfo = 2,
		SelectChar = 3
	}

	private sealed class EOBANCCLDCG
	{
		internal string FLHJDFCNDPJ;

		internal bool BEKJDJFLJJC(KMLFAFFNIHM AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.JGAFDKGALIP == FLHJDFCNDPJ;
		}
	}

	private sealed class KNMPFJJBNCH : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal NCGNCLMDIKB KPHCHDHEKGH;

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
		public KNMPFJJBNCH()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				KPHCHDHEKGH.PBGPHHCLBOM = FOGIOGKLNIP.MPLIECCKLCO(KPHCHDHEKGH.BHCIEFHBOPB.Login, BEKJDJFLJJC, KPHCHDHEKGH.BHCIEFHBOPB.LoginDevice, (!FOGIOGKLNIP.DGMBIMMABNO) ? Application.platform.ToString() : SystemInfo.deviceModel);
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

		internal void BEKJDJFLJJC(string KLLKONMADKA)
		{
			FOGIOGKLNIP.MACJBMALKEB = true;
			if (KLLKONMADKA.Contains(','))
			{
				string[] array = new string[2];
				KLLKONMADKA = KLLKONMADKA.Trim();
				array = KLLKONMADKA.Split(',');
				KLLKONMADKA = array[0];
				KPHCHDHEKGH.EIMHFDKMHCK = array[1];
				UnityEngine.Debug.Log(KPHCHDHEKGH.EIMHFDKMHCK);
			}
			UnityEngine.Debug.Log(KLLKONMADKA);
			if (KLLKONMADKA.Trim() != KPHCHDHEKGH.BHCIEFHBOPB.LoginStatusSuccess)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = KLLKONMADKA;
				if (!KLLKONMADKA.Contains(KPHCHDHEKGH.BHCIEFHBOPB.LoginStatusFailed))
				{
					FOGIOGKLNIP.LPLJMLGKCLK.HJMJAHOBJND = true;
				}
			}
			else
			{
				KPHCHDHEKGH.StartCoroutine(KPHCHDHEKGH.CBGPIHEKNFG());
			}
		}
	}

	private sealed class IDFKJGGJGNJ : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal NCGNCLMDIKB KPHCHDHEKGH;

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
		public IDFKJGGJGNJ()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				KPHCHDHEKGH.EPMOFPNGEAG = true;
				KPHCHDHEKGH.IDCHONNBBDL(FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD);
				KPHCHDHEKGH.KFFNKEHOBOI = FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD;
				KPHCHDHEKGH.IMDNCJODAEN = Menu.Chat;
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

	private sealed class BAIBHELECNL
	{
		internal string FCCPLGMNKOK;

		internal bool BEKJDJFLJJC(KMLFAFFNIHM AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.JGAFDKGALIP == FCCPLGMNKOK;
		}

		internal bool PMBKBKJIIPO(KMLFAFFNIHM AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.JGAFDKGALIP == FCCPLGMNKOK;
		}
	}

	private sealed class LMEEABKNGGB : IEnumerator, IDisposable, IEnumerator<object>
	{
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
		public LMEEABKNGGB()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
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

	private sealed class KLAIAMKJBNL : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal DILMJNOCKMA FNGDDCGFCGO;

		internal string OPFAOPKGJPB;

		internal WWW DJAEFPBPLBO;

		internal NCGNCLMDIKB KPHCHDHEKGH;

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
		public KLAIAMKJBNL()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				FNGDDCGFCGO.FJBKIMDHMFO = false;
				DJAEFPBPLBO = new WWW(OPFAOPKGJPB);
				HLJEEFIJCOF = DJAEFPBPLBO;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				if (string.IsNullOrEmpty(DJAEFPBPLBO.error) && DJAEFPBPLBO.textureNonReadable != null)
				{
					FNGDDCGFCGO.FJBKIMDHMFO = true;
					KPHCHDHEKGH.MAOHDMEKLGB = DJAEFPBPLBO.textureNonReadable;
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

	private sealed class KCKPOPLIBNK
	{
		internal string AMCFAKFFBEJ;

		internal NCGNCLMDIKB KPHCHDHEKGH;

		internal void BEKJDJFLJJC(string GDKFLGBMPBB)
		{
			string[] array = GDKFLGBMPBB.Split('#');
			try
			{
				KPHCHDHEKGH.JFJNJCGDILH = new DILMJNOCKMA();
				KPHCHDHEKGH.JFJNJCGDILH.NIGOGFAMFIB = AMCFAKFFBEJ;
				KPHCHDHEKGH.JFJNJCGDILH.CIACMOBHCLJ = array[1].Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				KPHCHDHEKGH.JFJNJCGDILH.ECKDHMKHHJJ = ObscuredInt.FNIPJFGEFFD(int.Parse(array[2]));
				KPHCHDHEKGH.JFJNJCGDILH.LIEKABKEJOG = array[3];
				KPHCHDHEKGH.JFJNJCGDILH.EAMIANGGPBI = array[4];
				KPHCHDHEKGH.JFJNJCGDILH.KFPIDMCIADK = (KMEAKNOINAG)int.Parse(array[5]);
				MonoBehaviour.print(KPHCHDHEKGH.JFJNJCGDILH.KFPIDMCIADK);
				KPHCHDHEKGH.JFJNJCGDILH.JCMCPIPHDHB = ObscuredInt.FNIPJFGEFFD(int.Parse(array[6]));
				KPHCHDHEKGH.JFJNJCGDILH.FJBKIMDHMFO = false;
				KPHCHDHEKGH.JFJNJCGDILH.LBKOHPIDKFH = ObscuredInt.FNIPJFGEFFD(int.Parse(array[8]));
				KPHCHDHEKGH.JFJNJCGDILH.KIDFODCBGNA = ObscuredInt.FNIPJFGEFFD(int.Parse(array[9]));
				if (KPHCHDHEKGH.JGBMNNMMPOO)
				{
					AHDMBKHBJII.CMDHJDEOCPM = array[7].Split2("\n");
					KPHCHDHEKGH.IBPALGFPAKO = KPHCHDHEKGH.JFJNJCGDILH;
					KPHCHDHEKGH.IBPALGFPAKO.CHMIJHGICBL = SystemInfo.deviceUniqueIdentifier;
					KPHCHDHEKGH.IPNFBBEHBJK();
				}
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
			}
		}

		internal void PMBKBKJIIPO(string GDKFLGBMPBB)
		{
			string[] array = GDKFLGBMPBB.Split('#');
			KPHCHDHEKGH.IBPALGFPAKO.JHCMKKNEHEL.Clear();
			KPHCHDHEKGH.IBPALGFPAKO.ILKOCIGJJGC.Clear();
			KPHCHDHEKGH.IBPALGFPAKO.FJAJMKDGCNN.Clear();
			try
			{
				KPHCHDHEKGH.EBDOMNIOENP.JCCLHHAKFLJ = array[0];
				KPHCHDHEKGH.BOHDNPDMKIP = true;
				KPHCHDHEKGH.IBPALGFPAKO.OKGHAOKEAMI = array[1] == "1";
				KPHCHDHEKGH.IBPALGFPAKO.PEBKNIGPDJH = array[2] == "1";
				string[] array2 = array[3].Split('|');
				foreach (string text in array2)
				{
					if (text != string.Empty)
					{
						KPHCHDHEKGH.IBPALGFPAKO.JHCMKKNEHEL.Add(text);
					}
				}
				KPHCHDHEKGH.IBPALGFPAKO.JHCMKKNEHEL.Reverse();
				KPHCHDHEKGH.GBFIICJKLAN[0].OIKEGAKPBIJ = KPHCHDHEKGH.IBPALGFPAKO.JHCMKKNEHEL;
				string[] array3 = array[4].Split('|');
				foreach (string text2 in array3)
				{
					if (text2 != string.Empty)
					{
						KPHCHDHEKGH.IBPALGFPAKO.ILKOCIGJJGC.Add(text2);
					}
				}
				KPHCHDHEKGH.IBPALGFPAKO.ILKOCIGJJGC.Reverse();
				KPHCHDHEKGH.GBFIICJKLAN[1].OIKEGAKPBIJ = KPHCHDHEKGH.IBPALGFPAKO.ILKOCIGJJGC;
				string[] array4 = array[5].Split('|');
				foreach (string text3 in array4)
				{
					if (text3 != string.Empty)
					{
						KPHCHDHEKGH.IBPALGFPAKO.FJAJMKDGCNN.Add(text3);
					}
				}
				KPHCHDHEKGH.IBPALGFPAKO.FJAJMKDGCNN.Reverse();
				KPHCHDHEKGH.GBFIICJKLAN[2].OIKEGAKPBIJ = KPHCHDHEKGH.IBPALGFPAKO.FJAJMKDGCNN;
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
			}
		}

		internal void MBNLIBIAFEF(string GDKFLGBMPBB)
		{
			string[] array = GDKFLGBMPBB.Split('#');
			KPHCHDHEKGH.EBDOMNIOENP.DGNBCAFOLCB.Clear();
			KPHCHDHEKGH.EBDOMNIOENP.CFHPBDILJGH.Clear();
			try
			{
				KPHCHDHEKGH.EBDOMNIOENP.JCCLHHAKFLJ = array[0];
				KPHCHDHEKGH.BOHDNPDMKIP = ((KPHCHDHEKGH.IBPALGFPAKO.EAMIANGGPBI == KPHCHDHEKGH.EBDOMNIOENP.JCCLHHAKFLJ) ? true : false);
				KPHCHDHEKGH.EBDOMNIOENP.PPDLGGIDCOM = array[1];
				string[] array2 = array[2].Split('|');
				foreach (string text in array2)
				{
					if (text != string.Empty)
					{
						KPHCHDHEKGH.EBDOMNIOENP.DGNBCAFOLCB.Add(text);
					}
				}
				KPHCHDHEKGH.EBDOMNIOENP.DGNBCAFOLCB.Reverse();
				KPHCHDHEKGH.GBFIICJKLAN[0].OIKEGAKPBIJ = KPHCHDHEKGH.EBDOMNIOENP.DGNBCAFOLCB;
				string[] array3 = array[3].Split('|');
				foreach (string text2 in array3)
				{
					if (text2 != string.Empty)
					{
						KPHCHDHEKGH.EBDOMNIOENP.CFHPBDILJGH.Add(text2);
					}
				}
				KPHCHDHEKGH.EBDOMNIOENP.CFHPBDILJGH.Reverse();
				KPHCHDHEKGH.GBFIICJKLAN[1].OIKEGAKPBIJ = KPHCHDHEKGH.EBDOMNIOENP.CFHPBDILJGH;
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
			}
		}
	}

	private sealed class MPJLOLDCOFG : IEnumerator, IDisposable, IEnumerator<object>
	{
		private sealed class DMIEOFNENPM
		{
			internal string FMIPENKKGGM;

			internal bool BEKJDJFLJJC(MapStats AEMBPMJMOAB)
			{
				return AEMBPMJMOAB.mapName == FMIPENKKGGM;
			}
		}

		internal string[] AGAKCKNEKBK;

		internal string[] DKOBKNHODMO;

		internal int HGPJDOEGCEC;

		internal string EDJMLDPFNAF;

		internal WWW MFKLGEHMJIC;

		internal bool IBPMLCAGBFG;

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
		public MPJLOLDCOFG()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				DKOBKNHODMO = AGAKCKNEKBK;
				HGPJDOEGCEC = 0;
				goto IL_01f7;
			case 1u:
				if (string.IsNullOrEmpty(MFKLGEHMJIC.error))
				{
					MatchCollection matchCollection = Regex.Matches(MFKLGEHMJIC.text, "(?i)href.{1,10}?([a-z0-9\\-._~%!$&'()*+,;=:@/]*\\.unity3d\\w+)");
					MonoBehaviour.print("hosting Maps found:" + matchCollection.Count);
					foreach (Match item in matchCollection)
					{
						DMIEOFNENPM dMIEOFNENPM = new DMIEOFNENPM();
						dMIEOFNENPM.FMIPENKKGGM = Path.GetFileName(item.Groups[1].Value);
						if (!FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF.Any(dMIEOFNENPM.BEKJDJFLJJC) && NOMMEFIICHO.GJMABEBFKHG(dMIEOFNENPM.FMIPENKKGGM))
						{
							FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF.Add(new MapStats
							{
								mapName = dMIEOFNENPM.FMIPENKKGGM,
								local = false
							});
						}
					}
					if (IBPMLCAGBFG)
					{
						FOGIOGKLNIP.PBADCKNDABE("Maps found " + matchCollection.Count);
					}
				}
				else
				{
					if (IBPMLCAGBFG)
					{
						FOGIOGKLNIP.PBADCKNDABE(MFKLGEHMJIC.error);
					}
					MonoBehaviour.print(MFKLGEHMJIC.error + MFKLGEHMJIC.text);
				}
				HGPJDOEGCEC++;
				goto IL_01f7;
			default:
				{
					return false;
				}
				IL_01f7:
				if (HGPJDOEGCEC < DKOBKNHODMO.Length)
				{
					EDJMLDPFNAF = DKOBKNHODMO[HGPJDOEGCEC];
					MFKLGEHMJIC = new WWW(EDJMLDPFNAF);
					HLJEEFIJCOF = MFKLGEHMJIC;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				GNNOELAJGPI = -1;
				goto default;
			}
			return true;
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

	public bool EPMOFPNGEAG;

	public bool NIJGLPOAILC;

	private bool DMLDPBMEEPG;

	private bool NCKPOAKCANB;

	public float GGLKLKONAHF;

	public int BGAPGKLEAEO;

	public int HDDCHPEIGGO;

	internal static int[] BBGICAHLLID = new int[1] { 13838 };

	public string COEIPPFAEDA;

	public string AGEALAOCFKM;

	public string HBPAJOJGPOB;

	public string GIEHLENKHEC;

	public string JHCPGLBENDG;

	public string NAHEOIEEACO;

	public string EIMHFDKMHCK;

	private string KFFNKEHOBOI = string.Empty;

	private string NBHBKLAMCFF = "search";

	public KMLFAFFNIHM JBINCAPMEBD;

	public EHIHAKKDHPO MAODHFCONKO;

	public Menu IMDNCJODAEN;

	public DILMJNOCKMA JFJNJCGDILH = new DILMJNOCKMA();

	public DILMJNOCKMA IBPALGFPAKO = new DILMJNOCKMA();

	public Texture2D MAOHDMEKLGB;

	private Vector2 LOADKHHJCDK;

	private Vector2 NHDNHLPCLDL;

	private Vector2 JJDKNFAFEAG;

	private Vector2 NHNKBEAFBDN;

	private Vector2 ECFDGJAKPFJ;

	private Vector3 KJEMPJDODAE;

	private Vector2 CAJAIKEHIMP;

	private Vector2 MCFNCEMDNPF;

	private Vector2 OOCBGHPOKGF;

	public MPEDAMLGFLD EBDOMNIOENP = new MPEDAMLGFLD();

	public GBPEHKNJJAB[] GBFIICJKLAN = new GBPEHKNJJAB[3]
	{
		new GBPEHKNJJAB(),
		new GBPEHKNJJAB(),
		new GBPEHKNJJAB()
	};

	private bool BOHDNPDMKIP;

	private GNMHJEPNHDL JGECOECAJLK;

	private WWW KGEFJGEPFJD;

	internal WWW PBGPHHCLBOM;

	private BEJHFGDPDLI JDFKPOMKMNJ = new BEJHFGDPDLI();

	private StreamWriter BDMINIADHME;

	public List<KMLFAFFNIHM> IJBOGIPFLOF = new List<KMLFAFFNIHM>();

	public static string HJAAHJGBEHB = "/sdcard/csmaps/";

	[CompilerGenerated]
	private static Action<string> ACJNADIPOMC;

	[CompilerGenerated]
	private static Action<string> HJJBAKLDAEB;

	[CompilerGenerated]
	private static Action<string> MPCENNEMFPB;

	[CompilerGenerated]
	private static Action<string> AGJHOJDNCOI;

	[CompilerGenerated]
	private static Action<string> GOKLDIBAPEA;

	[CompilerGenerated]
	private static Action<string> FDEPMKHNIID;

	[CompilerGenerated]
	private static Action<string> JEJGIANFAJE;

	[CompilerGenerated]
	private static Action<string> CAGBNPPEAFL;

	[CompilerGenerated]
	private static Action<string> IOIHBOPJMHO;

	public string BIJHBGLFDAP
	{
		get
		{
			return FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP;
		}
	}

	public int FFDODCPJDJC
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("CT2" + IBPALGFPAKO.NIGOGFAMFIB, new System.Random().Next(0, 3));
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("CT2" + IBPALGFPAKO.NIGOGFAMFIB, value);
		}
	}

	public int BPHIKPNKJAN
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("T2" + IBPALGFPAKO.NIGOGFAMFIB, new System.Random().Next(0, 3));
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("T2" + IBPALGFPAKO.NIGOGFAMFIB, value);
		}
	}

	public string BDJMLDOPHAN
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("Email", string.Empty);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("Email", value);
		}
	}

	private bool JGBMNNMMPOO
	{
		get
		{
			return JFJNJCGDILH.NIGOGFAMFIB == IBPALGFPAKO.NIGOGFAMFIB && EPMOFPNGEAG;
		}
	}

	public override void Awake()
	{
		base.Awake();
		IBPALGFPAKO.NIGOGFAMFIB = FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD;
		base.enabled = false;
	}

	public void Update()
	{
		JDFKPOMKMNJ.OJFAJPLDPPK();
	}

	public void DGHNJLMEHLC()
	{
		if (PBGPHHCLBOM != null && !string.IsNullOrEmpty(PBGPHHCLBOM.error))
		{
			UnityEngine.Debug.LogWarning(PBGPHHCLBOM.error);
			FOGIOGKLNIP.PBADCKNDABE(base.FKICDOGJIFN.ErrorText, PBGPHHCLBOM.error);
			PBGPHHCLBOM = null;
		}
	}

	public void OnGUI()
	{
		if (!FOGIOGKLNIP.LPLJMLGKCLK.GIOACCEINCF)
		{
			GUI.skin = FOGIOGKLNIP.LPLJMLGKCLK.EPDKDICMOHH;
			FOGIOGKLNIP.NGLMHFOKCHK(600, 600, string.Empty, HEKJLNDHNIC, FGJCEHCCEEO.NCGNCLMDIKB);
		}
	}

	public void AKFEDLCCGCF()
	{
		NIJGLPOAILC = true;
		FOGIOGKLNIP.KFEIIDMFOLF(BIJHBGLFDAP + base.BHCIEFHBOPB.Country, delegate(string KLLKONMADKA)
		{
			if (KLLKONMADKA.Length < 3)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.ALOMJBBEPNK = KLLKONMADKA;
			}
		});
		FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.BEHFNEAKDAL.BIJHBGLFDAP + base.BHCIEFHBOPB.MapList + 0 + ((!FOGIOGKLNIP.OMMLFOEPEEK) ? string.Empty : (base.BHCIEFHBOPB.MapListRandom + UnityEngine.Random.value)), delegate(string KLLKONMADKA)
		{
			LKJDGPGKCOD(KLLKONMADKA);
		});
		FOGIOGKLNIP.KFEIIDMFOLF(BIJHBGLFDAP + base.BHCIEFHBOPB.IP, delegate(string KLLKONMADKA)
		{
			if (!string.IsNullOrEmpty(KLLKONMADKA) && string.IsNullOrEmpty(FOGIOGKLNIP.LPLJMLGKCLK.LMPOJOBJNJO) && KLLKONMADKA.Length < 30)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.LMPOJOBJNJO = KLLKONMADKA;
			}
		});
		FOGIOGKLNIP.KFEIIDMFOLF(BIJHBGLFDAP + base.BHCIEFHBOPB.ServerList, delegate(string KLLKONMADKA)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.JANKNNJPOCL = KLLKONMADKA.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		});
		GGLKLKONAHF = Time.time;
		string empty = string.Empty;
		FOGIOGKLNIP.KFEIIDMFOLF(BIJHBGLFDAP + base.BHCIEFHBOPB.Count, delegate
		{
		}, base.BHCIEFHBOPB.CountDevice, Application.platform.ToString(), base.BHCIEFHBOPB.CountIP, SystemInfo.deviceUniqueIdentifier, base.BHCIEFHBOPB.CountReferer, empty);
		if (ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.HAAKPBDMIDN) && FOGIOGKLNIP.LPLJMLGKCLK.IIKAFLBAEML.Length > 0 && FOGIOGKLNIP.INJKJFIDKJM != null)
		{
			KCCDHFHBMMO();
		}
		FOGIOGKLNIP.KFEIIDMFOLF(BIJHBGLFDAP + base.BHCIEFHBOPB.ScoreBoard, delegate(string KLLKONMADKA)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.NEKEPCHBFPL = KLLKONMADKA.Split(",");
		});
	}

	public void JDKLABMJIPB(DILMJNOCKMA CMDFJBOALAO)
	{
		JFJNJCGDILH = CMDFJBOALAO;
		if (JGBMNNMMPOO)
		{
			IPNFBBEHBJK();
		}
	}

	public void KEIGOIECILO(string FLHJDFCNDPJ, string HDGELEFBNAJ, string LGNIFJCEECH)
	{
		EOBANCCLDCG eOBANCCLDCG = new EOBANCCLDCG();
		eOBANCCLDCG.FLHJDFCNDPJ = FLHJDFCNDPJ;
		KMLFAFFNIHM kMLFAFFNIHM = IJBOGIPFLOF.FirstOrDefault(eOBANCCLDCG.BEKJDJFLJJC);
		if (kMLFAFFNIHM != null)
		{
			kMLFAFFNIHM.IBAAPDEFEAB++;
			string text = HDGELEFBNAJ + ": " + LGNIFJCEECH + "\r\n";
			if (text == kMLFAFFNIHM.GFEOOIIHEOH)
			{
				kMLFAFFNIHM.IBAAPDEFEAB = 0;
			}
			kMLFAFFNIHM.OGFPGGOPHII = text;
			kMLFAFFNIHM.JKOFJJALJKP += FOGIOGKLNIP.LPLJMLGKCLK.PCHICPPDHKI(text);
			int num = ((!FOGIOGKLNIP.OMMLFOEPEEK) ? 1000 : 10000);
			if (kMLFAFFNIHM.JKOFJJALJKP.Length > num)
			{
				kMLFAFFNIHM.JKOFJJALJKP = kMLFAFFNIHM.JKOFJJALJKP.Substring(kMLFAFFNIHM.JKOFJJALJKP.Length - num);
			}
			NHDNHLPCLDL = new Vector2(0f, 10000f);
		}
	}

	public void CDJCDEDFLMM(string CMDFJBOALAO, string BCMIEDNPHMN)
	{
	}

	public void KPJMHHGEEBH()
	{
		string text = FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP;
		PBGPHHCLBOM = FOGIOGKLNIP.KFEIIDMFOLF(text + base.BHCIEFHBOPB.Register, delegate(string KLLKONMADKA)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = KLLKONMADKA;
		}, base.BHCIEFHBOPB.RegisterName, FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD, base.BHCIEFHBOPB.RegisterPassword, FOGIOGKLNIP.LPLJMLGKCLK.IIKAFLBAEML, base.BHCIEFHBOPB.RegisterEmail, FOGIOGKLNIP.LPLJMLGKCLK.PGCILJPMKFB, base.BHCIEFHBOPB.RegisterUid, NAHEOIEEACO);
	}

	[DebuggerHidden]
	public IEnumerator LBIKHAKOIFJ()
	{
		KNMPFJJBNCH kNMPFJJBNCH = new KNMPFJJBNCH();
		kNMPFJJBNCH.KPHCHDHEKGH = this;
		return kNMPFJJBNCH;
	}

	public void KCCDHFHBMMO()
	{
		FOGIOGKLNIP.IKJHNNLICBA = delegate
		{
			FOGIOGKLNIP.LPLJMLGKCLK.HJMJAHOBJND = true;
		};
		StartCoroutine(LBIKHAKOIFJ());
	}

	private void IPNFBBEHBJK()
	{
		if (!ObscuredBool.FNIPJFGEFFD(IBPALGFPAKO.EPMOFPNGEAG))
		{
			MAODHFCONKO.BIJIEONMGOL();
		}
	}

	[DebuggerHidden]
	public IEnumerator CBGPIHEKNFG()
	{
		IDFKJGGJGNJ iDFKJGGJGNJ = new IDFKJGGJGNJ();
		iDFKJGGJGNJ.KPHCHDHEKGH = this;
		return iDFKJGGJGNJ;
	}

	public void DOBKBBPHDPF()
	{
		IBPALGFPAKO = new DILMJNOCKMA();
		EBDOMNIOENP.JCCLHHAKFLJ = string.Empty;
		EPMOFPNGEAG = false;
		FOGIOGKLNIP.LPLJMLGKCLK.HAAKPBDMIDN = ObscuredBool.FNIPJFGEFFD(false);
		MAODHFCONKO.HGOFJOBHDGG.IOELOKNDNDG();
	}

	public void PLBEGIIGLMJ()
	{
		if (BIJHBGLFDAP == null)
		{
			return;
		}
		if (EPMOFPNGEAG)
		{
			GUILayout.BeginHorizontal();
			GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AccountLoggedAs) + FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD);
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountAccountPanel))
			{
				IMDNCJODAEN = Menu.AccountInfo;
				base.enabled = true;
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountLogout))
			{
				DOBKBBPHDPF();
			}
			GUILayout.EndHorizontal();
			if (NCKPOAKCANB)
			{
				GUILayout.BeginHorizontal();
				FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.AccountNewPassword, GUILayout.ExpandWidth(false));
				HBPAJOJGPOB = GUILayout.TextField(HBPAJOJGPOB, 20);
				if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountChange) && HBPAJOJGPOB.Length > 3)
				{
					NCKPOAKCANB = false;
					FOGIOGKLNIP.MPLIECCKLCO(base.BHCIEFHBOPB.ChangePassword, delegate(string GDKFLGBMPBB)
					{
						FOGIOGKLNIP.PBADCKNDABE(string.Empty, GDKFLGBMPBB);
					}, base.BHCIEFHBOPB.NewPassword, HBPAJOJGPOB);
				}
				GUILayout.EndHorizontal();
			}
			else if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountChangePassword))
			{
				NCKPOAKCANB = true;
			}
		}
		else if (PBGPHHCLBOM == null || PBGPHHCLBOM.isDone)
		{
			GUILayout.BeginHorizontal();
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.AccountNick, GUILayout.ExpandWidth(false));
			FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD = GUILayout.TextField(FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD, 20);
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.AccountPassword, GUILayout.ExpandWidth(false));
			FOGIOGKLNIP.LPLJMLGKCLK.IIKAFLBAEML = GUILayout.PasswordField(FOGIOGKLNIP.LPLJMLGKCLK.IIKAFLBAEML, '*', 20, GUILayout.ExpandWidth(true));
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.AccountEmail, GUILayout.ExpandWidth(false));
			FOGIOGKLNIP.LPLJMLGKCLK.PGCILJPMKFB = GUILayout.TextField(FOGIOGKLNIP.LPLJMLGKCLK.PGCILJPMKFB, 50);
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountLogin, GUILayout.ExpandWidth(false)))
			{
				KCCDHFHBMMO();
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountRegister, GUILayout.ExpandWidth(false)))
			{
				KPJMHHGEEBH();
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountForgotPassword, GUILayout.ExpandWidth(false)))
			{
				FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(400, 300, base.FKICDOGJIFN.AccountForgotPassword, NBOGOKNEBGI.IPBFPHDFNNH, delegate
				{
					GUILayout.Label(base.FKICDOGJIFN.AccountEnteryourValUserName);
					GIEHLENKHEC = GUILayout.TextField(GIEHLENKHEC);
					JHCPGLBENDG = GUILayout.TextField(JHCPGLBENDG);
					if (GUILayout.Button(base.FKICDOGJIFN.AccountSendpasswordonemail))
					{
						FOGIOGKLNIP.KFEIIDMFOLF(BIJHBGLFDAP + base.BHCIEFHBOPB.Email, delegate(string KLLKONMADKA)
						{
							FOGIOGKLNIP.PBADCKNDABE(KLLKONMADKA);
						}, base.BHCIEFHBOPB.EmailNick, GIEHLENKHEC, base.BHCIEFHBOPB.EmailEmail, JHCPGLBENDG);
						FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
					}
				});
			}
			GUILayout.EndHorizontal();
		}
		else
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.AccountLoggingIn);
		}
		FOGIOGKLNIP.LPLJMLGKCLK.HAAKPBDMIDN = ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.HGHFNJMFLHM(ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.HAAKPBDMIDN), "Auto Login"));
	}

	public void KHHMJPJAGBO()
	{
		IJBOGIPFLOF.Clear();
	}

	public void EFJFPONHEND()
	{
		MAODHFCONKO.IKFLDKJOPAG(FOGIOGKLNIP.LPLJMLGKCLK.IIKAFLBAEML);
		IJBOGIPFLOF.Clear();
		FNJENJEIMJA(base.BHCIEFHBOPB.IRCChannelCSPort);
		FNJENJEIMJA(base.BHCIEFHBOPB.IRCChannelSupport);
		FNJENJEIMJA(base.BHCIEFHBOPB.IRCChannelCSPort2 + FOGIOGKLNIP.LPLJMLGKCLK.ALOMJBBEPNK);
		if (FOGIOGKLNIP.DGMBIMMABNO)
		{
			FNJENJEIMJA(base.BHCIEFHBOPB.IRCChannelCSPortAndroid);
		}
		if (IBPALGFPAKO.EAMIANGGPBI != string.Empty)
		{
			FNJENJEIMJA(IBPALGFPAKO.EAMIANGGPBI);
		}
		if (FOGIOGKLNIP.BEHFNEAKDAL.EPMOFPNGEAG)
		{
			FNJENJEIMJA(FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD);
			JBINCAPMEBD = IJBOGIPFLOF[BGAPGKLEAEO];
			foreach (string item in IBPALGFPAKO.CIACMOBHCLJ)
			{
				FNJENJEIMJA(item);
			}
		}
		BGAPGKLEAEO = 0;
	}

	private void FNJENJEIMJA(string FCCPLGMNKOK)
	{
		BAIBHELECNL bAIBHELECNL = new BAIBHELECNL();
		bAIBHELECNL.FCCPLGMNKOK = FCCPLGMNKOK;
		if (!IJBOGIPFLOF.Any(bAIBHELECNL.BEKJDJFLJJC))
		{
			IJBOGIPFLOF.Add(new KMLFAFFNIHM
			{
				JGAFDKGALIP = bAIBHELECNL.FCCPLGMNKOK
			});
			BGAPGKLEAEO = IJBOGIPFLOF.Count - 1;
			MAODHFCONKO.NKMONJIIOJH(bAIBHELECNL.FCCPLGMNKOK);
		}
		else
		{
			BGAPGKLEAEO = IJBOGIPFLOF.FindIndex(0, bAIBHELECNL.PMBKBKJIIPO);
		}
	}

	public void HEKJLNDHNIC(int FAGMOBEKJND)
	{
		if (IMDNCJODAEN == Menu.AccountInfo)
		{
			KDMGIOCBDDA();
		}
		else if (IMDNCJODAEN == Menu.ClanInfo)
		{
			FLDAJEKHCAC();
		}
		else if (IMDNCJODAEN == Menu.Chat)
		{
			OGOJKJDJEOG();
		}
		else if (IMDNCJODAEN == Menu.SelectChar)
		{
			CFCHDPANADN();
		}
	}

	private void CFCHDPANADN()
	{
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.BackText))
		{
			IMDNCJODAEN = Menu.AccountInfo;
		}
		FDGPLHOFOEN iFLCIAMAFAL = FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL;
		string[] array = ((JGECOECAJLK != GNMHJEPNHDL.CounterTerrorists) ? iFLCIAMAFAL.LAJKNGCOABD : iFLCIAMAFAL.JBOAGLNOHLL);
		int num = array.Length;
		string[] array2 = FOGIOGKLNIP.CHDJHJFGMNA("skins").Split2("|");
		int num2 = 0;
		int[] array3 = new int[array2.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			num2 = (array3[i] = num2 + int.Parse(array2[i]));
		}
		ECFDGJAKPFJ = GUILayout.BeginScrollView(ECFDGJAKPFJ);
		for (int j = 0; j < num; j++)
		{
			if (j < array.Length && GUILayout.Button(array[j], GUILayout.ExpandWidth(true)))
			{
				if (JGECOECAJLK == GNMHJEPNHDL.CounterTerrorists)
				{
					FFDODCPJDJC = j;
				}
				else
				{
					BPHIKPNKJAN = j;
				}
				IMDNCJODAEN = Menu.AccountInfo;
			}
		}
		GUILayout.EndScrollView();
	}

	private void FLDAJEKHCAC()
	{
		GUILayout.BeginHorizontal();
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.BackText, GUILayout.ExpandWidth(false)))
		{
			IMDNCJODAEN = Menu.AccountInfo;
		}
		GUILayout.EndHorizontal();
		if (!FOGIOGKLNIP.OMMLFOEPEEK && !KGEFJGEPFJD.isDone)
		{
			FOGIOGKLNIP.IAOONCAPLGK("Loading...");
			return;
		}
		KJEMPJDODAE = GUILayout.BeginScrollView(KJEMPJDODAE);
		GUILayout.BeginHorizontal();
		if (EBDOMNIOENP.JCCLHHAKFLJ != string.Empty)
		{
			GUILayout.Label(string.Format("{0}: {1}", FOGIOGKLNIP.FHHPMGJCHJL("Clan"), (!BOHDNPDMKIP) ? EBDOMNIOENP.JCCLHHAKFLJ : IBPALGFPAKO.EAMIANGGPBI));
			if (!BOHDNPDMKIP)
			{
				GUILayout.Label(string.Format("{0}: {1}", FOGIOGKLNIP.FHHPMGJCHJL("Creator"), EBDOMNIOENP.PPDLGGIDCOM));
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		if (IBPALGFPAKO.EAMIANGGPBI == string.Empty)
		{
			if (IBPALGFPAKO.CIACMOBHCLJ.Contains(EBDOMNIOENP.JCCLHHAKFLJ))
			{
				if (FOGIOGKLNIP.MHFCLILDBCM("Accept invite"))
				{
					FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
					{
						IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB, Menu.ClanInfo);
						FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
					}, "accept", 1, "clan", EBDOMNIOENP.JCCLHHAKFLJ);
					IBPALGFPAKO.CIACMOBHCLJ.Clear();
				}
				if (FOGIOGKLNIP.MHFCLILDBCM("Reject invite", GUILayout.ExpandWidth(false)))
				{
					FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
					{
						IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB);
						FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
					}, "remove", 1, "typeRemove", "R", "clan", EBDOMNIOENP.JCCLHHAKFLJ);
				}
			}
		}
		else if (IBPALGFPAKO.EAMIANGGPBI == EBDOMNIOENP.JCCLHHAKFLJ && ((!IBPALGFPAKO.OKGHAOKEAMI) ? FOGIOGKLNIP.MHFCLILDBCM("Leave clan") : FOGIOGKLNIP.MHFCLILDBCM("Remove Clan")))
		{
			FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
			{
				IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB);
				FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
			}, (!IBPALGFPAKO.OKGHAOKEAMI) ? "leave" : "remove", 1);
			COEIPPFAEDA = string.Empty;
		}
		GUILayout.EndHorizontal();
		CFNBDIAEOPA(0, "Clan Leaders");
		CFNBDIAEOPA(1, "Clan Members");
		if (IBPALGFPAKO.EAMIANGGPBI == EBDOMNIOENP.JCCLHHAKFLJ && (IBPALGFPAKO.OKGHAOKEAMI || IBPALGFPAKO.PEBKNIGPDJH))
		{
			CFNBDIAEOPA(2, "Clan Requests");
		}
		KJEMPJDODAE.y += OMIPNBBJLOD();
		GUILayout.EndScrollView();
	}

	private void KDMGIOCBDDA()
	{
		GUILayout.BeginHorizontal();
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.BackText, GUILayout.ExpandWidth(false)))
		{
			IMDNCJODAEN = Menu.Chat;
			if (FOGIOGKLNIP.PIOANBBCFFP != null)
			{
				base.enabled = false;
			}
		}
		GUILayout.EndHorizontal();
		if (!FOGIOGKLNIP.OMMLFOEPEEK && !KGEFJGEPFJD.isDone)
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.AccountLoading);
			return;
		}
		ECFDGJAKPFJ = GUILayout.BeginScrollView(ECFDGJAKPFJ);
		GUILayout.BeginHorizontal();
		GUILayout.Label(FOGIOGKLNIP.LPLJMLGKCLK.JNLFEKJBJKP(ObscuredInt.FNIPJFGEFFD(JFJNJCGDILH.ECKDHMKHHJJ)), GUILayout.Width(64f), GUILayout.Height(64f));
		GUILayout.Label(JFJNJCGDILH.NIGOGFAMFIB);
		if (JGBMNNMMPOO)
		{
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountSelectCounterT))
			{
				JGECOECAJLK = GNMHJEPNHDL.CounterTerrorists;
				IMDNCJODAEN = Menu.SelectChar;
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountSelectTerrorist))
			{
				JGECOECAJLK = GNMHJEPNHDL.Terrorists;
				IMDNCJODAEN = Menu.SelectChar;
			}
		}
		GUILayout.EndHorizontal();
		if (JGBMNNMMPOO)
		{
			if (IBPALGFPAKO.EAMIANGGPBI == string.Empty)
			{
				GUILayout.BeginHorizontal();
				COEIPPFAEDA = GUILayout.TextField(COEIPPFAEDA, 20, GUILayout.Width(150f));
				if (FOGIOGKLNIP.MHFCLILDBCM("Create Clan"))
				{
					FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
					{
						IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB);
						FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
					}, "create", 1, "clan", COEIPPFAEDA);
					COEIPPFAEDA = string.Empty;
				}
				GUILayout.EndHorizontal();
			}
			GUILayout.BeginHorizontal();
			if (JFJNJCGDILH.EAMIANGGPBI != null && FOGIOGKLNIP.MHFCLILDBCM("View Clan"))
			{
				IDCHONNBBDL((!(JFJNJCGDILH.NIGOGFAMFIB != IBPALGFPAKO.NIGOGFAMFIB)) ? IBPALGFPAKO.NIGOGFAMFIB : JFJNJCGDILH.NIGOGFAMFIB, Menu.ClanInfo);
				COEIPPFAEDA = string.Empty;
			}
			GUILayout.EndHorizontal();
		}
		else if (!JGBMNNMMPOO)
		{
			GUILayout.BeginHorizontal();
			if (JFJNJCGDILH.EAMIANGGPBI != string.Empty && FOGIOGKLNIP.MHFCLILDBCM("View Clan"))
			{
				IDCHONNBBDL((!(JFJNJCGDILH.NIGOGFAMFIB == IBPALGFPAKO.NIGOGFAMFIB)) ? JFJNJCGDILH.NIGOGFAMFIB : IBPALGFPAKO.NIGOGFAMFIB, Menu.ClanInfo, JFJNJCGDILH.EAMIANGGPBI);
				COEIPPFAEDA = string.Empty;
			}
			if (IBPALGFPAKO.EAMIANGGPBI != string.Empty)
			{
				if (IBPALGFPAKO.OKGHAOKEAMI && IBPALGFPAKO.JHCMKKNEHEL.Contains(JFJNJCGDILH.NIGOGFAMFIB) && !IBPALGFPAKO.JHCMKKNEHEL.Contains(IBPALGFPAKO.NIGOGFAMFIB) && FOGIOGKLNIP.MHFCLILDBCM("Remove from leaders", GUILayout.ExpandWidth(false)))
				{
					FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
					{
						IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
						FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
					}, "remove", 1, "typeRemove", "L", "nick", JFJNJCGDILH.NIGOGFAMFIB);
				}
				if (IBPALGFPAKO.ILKOCIGJJGC.Contains(JFJNJCGDILH.NIGOGFAMFIB))
				{
					if (!IBPALGFPAKO.JHCMKKNEHEL.Contains(JFJNJCGDILH.NIGOGFAMFIB))
					{
						if (IBPALGFPAKO.OKGHAOKEAMI && FOGIOGKLNIP.MHFCLILDBCM("Set as Leader", GUILayout.ExpandWidth(false)))
						{
							FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
							{
								IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
								FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
							}, "add", "L", "nick", JFJNJCGDILH.NIGOGFAMFIB);
						}
						if (FOGIOGKLNIP.MHFCLILDBCM("Remove from the clan", GUILayout.ExpandWidth(false)))
						{
							FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
							{
								IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
								FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
							}, "remove", 1, "typeRemove", "M", "nick", JFJNJCGDILH.NIGOGFAMFIB);
						}
					}
					else if (IBPALGFPAKO.OKGHAOKEAMI)
					{
						if (FOGIOGKLNIP.MHFCLILDBCM("Give clan to player", GUILayout.ExpandWidth(false)))
						{
							FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
							{
								IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
								FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
							}, "add", "C", "nick", JFJNJCGDILH.NIGOGFAMFIB);
						}
						if (FOGIOGKLNIP.MHFCLILDBCM("Remove from the leaders", GUILayout.ExpandWidth(false)))
						{
							FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
							{
								IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
								FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
							}, "remove", 1, "typeRemove", "L", "nick", JFJNJCGDILH.NIGOGFAMFIB);
						}
						if (FOGIOGKLNIP.MHFCLILDBCM("Remove from the clan", GUILayout.ExpandWidth(false)))
						{
							FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
							{
								IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
								FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
							}, "remove", 1, "typeRemove", "M", "nick", JFJNJCGDILH.NIGOGFAMFIB);
						}
					}
				}
				else if (IBPALGFPAKO.OKGHAOKEAMI || IBPALGFPAKO.PEBKNIGPDJH)
				{
					if (IBPALGFPAKO.FJAJMKDGCNN.Contains(JFJNJCGDILH.NIGOGFAMFIB))
					{
						if (FOGIOGKLNIP.MHFCLILDBCM("Remove request", GUILayout.ExpandWidth(false)))
						{
							FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
							{
								IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
								FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
							}, "remove", 1, "typeRemove", "R", "nick", JFJNJCGDILH.NIGOGFAMFIB);
						}
					}
					else if (JFJNJCGDILH.EAMIANGGPBI == string.Empty && FOGIOGKLNIP.MHFCLILDBCM("Invite to the clan", GUILayout.ExpandWidth(false)))
					{
						FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", delegate(string GDKFLGBMPBB)
						{
							IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
							FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
						}, "invite", 1, "nick", JFJNJCGDILH.NIGOGFAMFIB);
					}
				}
			}
			GUILayout.EndHorizontal();
		}
		NHNKBEAFBDN = GUILayout.BeginScrollView(NHNKBEAFBDN, GUILayout.Height((!FOGIOGKLNIP.DGMBIMMABNO) ? 90 : 100));
		GUILayout.BeginHorizontal();
		HKMEFABJOMJ(JFJNJCGDILH);
		GUILayout.EndHorizontal();
		GUILayout.EndScrollView();
		ECFDGJAKPFJ.y += OMIPNBBJLOD();
		if (JFJNJCGDILH.KFPIDMCIADK != KMEAKNOINAG.BLBOPPEBDFH)
		{
			GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AccountRole) + FOGIOGKLNIP.FHHPMGJCHJL(JFJNJCGDILH.KFPIDMCIADK.ToString()));
		}
		GUILayout.Box(JFJNJCGDILH.LIEKABKEJOG);
		GUILayout.EndScrollView();
	}

	[DebuggerHidden]
	private IEnumerator KOBGNPAKLHL()
	{
		return new LMEEABKNGGB();
	}

	private Texture2D IJAGHCIGGDM(Texture2D FCBABFMAPBI, int MGCPFCKGJHC, int PPAFPDGMKJG)
	{
		Texture2D texture2D = new Texture2D(MGCPFCKGJHC, PPAFPDGMKJG, FCBABFMAPBI.format, true);
		Color[] pixels = texture2D.GetPixels(0);
		float num = 1f / (float)FCBABFMAPBI.width * ((float)FCBABFMAPBI.width / (float)MGCPFCKGJHC);
		float num2 = 1f / (float)FCBABFMAPBI.height * ((float)FCBABFMAPBI.height / (float)PPAFPDGMKJG);
		for (int i = 0; i < pixels.Length; i++)
		{
			pixels[i] = FCBABFMAPBI.GetPixelBilinear(num * ((float)i % (float)MGCPFCKGJHC), num2 * Mathf.Floor((float)i / (float)MGCPFCKGJHC));
		}
		texture2D.SetPixels(pixels, 0);
		texture2D.Apply();
		return texture2D;
	}

	public override void AILPFINEAEK()
	{
		base.AILPFINEAEK();
	}

	private void CFNBDIAEOPA(int LBBHEBEOCIC, string MGDJNMNHMFM)
	{
		GBFIICJKLAN[LBBHEBEOCIC].NPNEIIGJJGO = GUILayout.BeginScrollView(GBFIICJKLAN[LBBHEBEOCIC].NPNEIIGJJGO, GUILayout.Height((!FOGIOGKLNIP.DGMBIMMABNO) ? 190 : 200));
		GUILayout.BeginVertical();
		bool wordWrap = GUI.skin.label.wordWrap;
		GUI.skin.label.wordWrap = false;
		GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL(MGDJNMNHMFM) + "(" + GBFIICJKLAN[LBBHEBEOCIC].OIKEGAKPBIJ.Count + ")", GUILayout.ExpandWidth(false));
		GUI.skin.label.wordWrap = wordWrap;
		foreach (string item in GBFIICJKLAN[LBBHEBEOCIC].OIKEGAKPBIJ)
		{
			FOGIOGKLNIP.PHINLFLBAOJ();
			if (GUILayout.Button(item, GUILayout.ExpandWidth(true)))
			{
				IDCHONNBBDL(item);
			}
			FOGIOGKLNIP.LKLLDMLLIML();
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void HKMEFABJOMJ(DILMJNOCKMA EIMBHGFPKIC)
	{
		bool wordWrap = GUI.skin.label.wordWrap;
		GUI.skin.label.wordWrap = false;
		GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL("Clan Requests") + "(" + EIMBHGFPKIC.CIACMOBHCLJ.Count + ")", GUILayout.ExpandWidth(false));
		GUI.skin.label.wordWrap = wordWrap;
		foreach (string item in EIMBHGFPKIC.CIACMOBHCLJ)
		{
			FOGIOGKLNIP.PHINLFLBAOJ();
			if (GUILayout.Button(item, GUILayout.ExpandWidth(true)))
			{
				IDCHONNBBDL(EIMBHGFPKIC.NIGOGFAMFIB, Menu.ClanInfo, item);
			}
			FOGIOGKLNIP.LKLLDMLLIML();
		}
	}

	private void OGOJKJDJEOG()
	{
		GUILayout.BeginHorizontal();
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.CloseText, GUILayout.ExpandWidth(false)))
		{
			base.enabled = false;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.AccountviewProfiles, GUILayout.ExpandWidth(false)) && !string.IsNullOrEmpty(KFFNKEHOBOI))
		{
			IDCHONNBBDL(KFFNKEHOBOI);
		}
		KFFNKEHOBOI = FOGIOGKLNIP.HJNJCLGIEIH(KFFNKEHOBOI, GUILayout.ExpandWidth(true), GUILayout.MaxWidth(100f));
		GUILayout.EndHorizontal();
	}

	private static bool CCMGCHAIHGO(KMLFAFFNIHM LCBKHLLPIGM)
	{
		return LCBKHLLPIGM.HPAGKBOOHMH.ContainsKey(LCBKHLLPIGM.JGAFDKGALIP);
	}

	[DebuggerHidden]
	public IEnumerator LJELJMLCEHH(string OPFAOPKGJPB, DILMJNOCKMA FNGDDCGFCGO)
	{
		KLAIAMKJBNL kLAIAMKJBNL = new KLAIAMKJBNL();
		kLAIAMKJBNL.FNGDDCGFCGO = FNGDDCGFCGO;
		kLAIAMKJBNL.OPFAOPKGJPB = OPFAOPKGJPB;
		kLAIAMKJBNL.KPHCHDHEKGH = this;
		return kLAIAMKJBNL;
	}

	public void LHNFCGFJOLJ(string AMCFAKFFBEJ)
	{
		MAODHFCONKO.JFBMPGBNBCF(OHMGCMOBAGN.POENMJCOBNP, AMCFAKFFBEJ, DDCEGGMMPDG(delegate(BinaryReader LKLIMHLBGMG)
		{
			LKLIMHLBGMG.BHCPIKOHHCC<DILMJNOCKMA>(out JFJNJCGDILH);
			if (JGBMNNMMPOO)
			{
				IBPALGFPAKO = JFJNJCGDILH;
			}
			IMDNCJODAEN = Menu.AccountInfo;
		}));
	}

	public void IDCHONNBBDL(string AMCFAKFFBEJ, Menu JFCCHDMBINI = Menu.AccountInfo, string JCCLHHAKFLJ = null)
	{
		KCKPOPLIBNK kCKPOPLIBNK = new KCKPOPLIBNK();
		kCKPOPLIBNK.AMCFAKFFBEJ = AMCFAKFFBEJ;
		kCKPOPLIBNK.KPHCHDHEKGH = this;
		KGEFJGEPFJD = FOGIOGKLNIP.MPLIECCKLCO(base.BHCIEFHBOPB.GetInfo, kCKPOPLIBNK.BEKJDJFLJJC, base.BHCIEFHBOPB.GetInfoNick, kCKPOPLIBNK.AMCFAKFFBEJ);
		if (JCCLHHAKFLJ == null)
		{
			if (IBPALGFPAKO.EAMIANGGPBI != string.Empty)
			{
				KGEFJGEPFJD = FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", kCKPOPLIBNK.PMBKBKJIIPO, "getInfo", 1);
			}
		}
		else if (EBDOMNIOENP.JCCLHHAKFLJ != JCCLHHAKFLJ)
		{
			KGEFJGEPFJD = FOGIOGKLNIP.MPLIECCKLCO("clanAPI.php", kCKPOPLIBNK.MBNLIBIAFEF, "getInfo", 1, "clan", JCCLHHAKFLJ);
		}
		IMDNCJODAEN = JFCCHDMBINI;
	}

	[DebuggerHidden]
	public IEnumerator LGFPGOBIJCA(string[] AGAKCKNEKBK, bool IBPMLCAGBFG = false)
	{
		MPJLOLDCOFG mPJLOLDCOFG = new MPJLOLDCOFG();
		mPJLOLDCOFG.AGAKCKNEKBK = AGAKCKNEKBK;
		mPJLOLDCOFG.IBPMLCAGBFG = IBPMLCAGBFG;
		return mPJLOLDCOFG;
	}

	public void LKJDGPGKCOD(string KLLKONMADKA)
	{
		string[] array = KLLKONMADKA.Split("\r\n");
		BKKHMNCDFLF("Load Maps:" + array.Length);
		if (array.Length > 3)
		{
			try
			{
				List<MapStats> list = new List<MapStats>();
				string[] array2 = array;
				foreach (string s in array2)
				{
					string[] array3 = s.Split(",");
					MapStats mapStats = new MapStats();
					if (NOMMEFIICHO.GJMABEBFKHG(mapStats.mapName = Path.GetFileName(array3[0])) && array3.Length > 2)
					{
						mapStats.date = (int)(DateTime.Parse(array3[1]).Ticks / 36000000000L);
						mapStats.plays = int.Parse(array3[2]);
						mapStats.botPlays = int.Parse(array3[3]);
						mapStats.IsDev = Convert.ToBoolean(int.Parse(array3[4]));
						mapStats.Version = int.Parse(array3[5]);
						list.Add(mapStats);
					}
				}
				FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF = list;
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogWarning(message);
			}
		}
		try
		{
			FCMPPIBMPGO();
		}
		catch (Exception message2)
		{
			MonoBehaviour.print(message2);
		}
		StartCoroutine(LGFPGOBIJCA(FOGIOGKLNIP.LMMFHEODOPM.IDHMKKBEBCG));
	}

	public void FCMPPIBMPGO(bool IBPMLCAGBFG = false)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer || platform == RuntimePlatform.WindowsPlayer || FOGIOGKLNIP.OMMLFOEPEEK)
		{
			string path = Directory.GetCurrentDirectory() + HJAAHJGBEHB;
			string[] files = Directory.GetFiles(path, "*.unity3d*");
			string[] array = files;
			foreach (string path2 in array)
			{
				FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF.Add(new MapStats
				{
					mapName = Path.GetFileName(path2),
					local = true
				});
			}
			MonoBehaviour.print("maps found " + files.Length);
			if (IBPMLCAGBFG)
			{
				FOGIOGKLNIP.PBADCKNDABE("maps found " + files.Length);
			}
			string[] files2 = Directory.GetFiles(path, "*.dae");
			foreach (string path3 in files2)
			{
				FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF.Add(new MapStats
				{
					mapName = Path.GetFileName(path3),
					local = true
				});
			}
		}
	}

	[CompilerGenerated]
	private static void CHCBPGJGOGE(string KLLKONMADKA)
	{
		if (KLLKONMADKA.Length < 3)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.ALOMJBBEPNK = KLLKONMADKA;
		}
	}

	[CompilerGenerated]
	private void FGLBKGLLAIO(string KLLKONMADKA)
	{
		LKJDGPGKCOD(KLLKONMADKA);
	}

	[CompilerGenerated]
	private static void NHMHEHNPNKF(string KLLKONMADKA)
	{
		if (!string.IsNullOrEmpty(KLLKONMADKA) && string.IsNullOrEmpty(FOGIOGKLNIP.LPLJMLGKCLK.LMPOJOBJNJO) && KLLKONMADKA.Length < 30)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.LMPOJOBJNJO = KLLKONMADKA;
		}
	}

	[CompilerGenerated]
	private static void GIDOCNFHMPA(string KLLKONMADKA)
	{
		FOGIOGKLNIP.LPLJMLGKCLK.JANKNNJPOCL = KLLKONMADKA.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	[CompilerGenerated]
	private static void JGJOAAHFBNH(string P_0)
	{
	}

	[CompilerGenerated]
	private static void AGDAJKDDIEC(string KLLKONMADKA)
	{
		FOGIOGKLNIP.LPLJMLGKCLK.NEKEPCHBFPL = KLLKONMADKA.Split(",");
	}

	[CompilerGenerated]
	private static void OBAJKKONOKO(string KLLKONMADKA)
	{
		FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = KLLKONMADKA;
	}

	[CompilerGenerated]
	private static void FLKHJNKKCNE(string P_0)
	{
		FOGIOGKLNIP.LPLJMLGKCLK.HJMJAHOBJND = true;
	}

	[CompilerGenerated]
	private static void BAMGANNGDJD(string GDKFLGBMPBB)
	{
		FOGIOGKLNIP.PBADCKNDABE(string.Empty, GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void JNOMOECBCAH()
	{
		GUILayout.Label(base.FKICDOGJIFN.AccountEnteryourValUserName);
		GIEHLENKHEC = GUILayout.TextField(GIEHLENKHEC);
		JHCPGLBENDG = GUILayout.TextField(JHCPGLBENDG);
		if (GUILayout.Button(base.FKICDOGJIFN.AccountSendpasswordonemail))
		{
			FOGIOGKLNIP.KFEIIDMFOLF(BIJHBGLFDAP + base.BHCIEFHBOPB.Email, delegate(string KLLKONMADKA)
			{
				FOGIOGKLNIP.PBADCKNDABE(KLLKONMADKA);
			}, base.BHCIEFHBOPB.EmailNick, GIEHLENKHEC, base.BHCIEFHBOPB.EmailEmail, JHCPGLBENDG);
			FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
		}
	}

	[CompilerGenerated]
	private void FFBAIKIPEMH(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB, Menu.ClanInfo);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void KJCLPHEOFID(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void DFNLABNFHJH(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void KDEMBMKPALG(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(IBPALGFPAKO.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void JEMKKFJNLNF(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void JDNECAEGGKK(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void NGJLIKBCMAF(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void LDIKHDMLINO(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void MJJFMACPMFG(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void FNNHHOINCEN(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void HJDLBJPELFC(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void BCCOOHGHBCO(string GDKFLGBMPBB)
	{
		IDCHONNBBDL(JFJNJCGDILH.NIGOGFAMFIB);
		FOGIOGKLNIP.PBADCKNDABE(GDKFLGBMPBB);
	}

	[CompilerGenerated]
	private void KEELIMKGBPE(BinaryReader LKLIMHLBGMG)
	{
		LKLIMHLBGMG.BHCPIKOHHCC<DILMJNOCKMA>(out JFJNJCGDILH);
		if (JGBMNNMMPOO)
		{
			IBPALGFPAKO = JFJNJCGDILH;
		}
		IMDNCJODAEN = Menu.AccountInfo;
	}

	[CompilerGenerated]
	private static void JJPDIJBAAJA(string KLLKONMADKA)
	{
		FOGIOGKLNIP.PBADCKNDABE(KLLKONMADKA);
	}
}
