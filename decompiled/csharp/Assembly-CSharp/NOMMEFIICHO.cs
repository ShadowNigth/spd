using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NOMMEFIICHO : FOGIOGKLNIP
{
	private enum HNDJBFNAIHN
	{
		HJEAMMANNHM,
		MAJHJGIICED,
		NFDLEHOMJBC,
		IBEPICCMOCK,
		KNFOHBBPPJB,
		LJJAAIDPKIM,
		OMAHPOHDKJH,
		EKGBDKEDIKK,
		FPIHDMECCEO,
		DFMPLJLAGFM,
		JNDEHPJAMJB
	}

	[Serializable]
	public class Posts
	{
		public string title;

		public string msg;

		public DateTime date;

		public int comments;

		public string imageUrl;

		public Texture2D image;

		public string id;

		public string link;

		public IEnumerator DHBGHDFFOLN()
		{
			if (!string.IsNullOrEmpty(imageUrl))
			{
				WWW wWW = new WWW(imageUrl);
				yield return wWW;
				image = wWW.texture;
			}
		}
	}

	[CompilerGenerated]
	private sealed class EPIPBJBBEON
	{
		internal RoomInfo LECNOMGBOAK;

		internal bool BEKJDJFLJJC(RoomInfo AEMBPMJMOAB)
		{
			return FOGIOGKLNIP.GIGJFCBMKMO(AEMBPMJMOAB.mapName) == LECNOMGBOAK.mapName && AEMBPMJMOAB.sets[5] == LECNOMGBOAK.sets[5];
		}
	}

	[CompilerGenerated]
	private sealed class FCGCKEJLGFK
	{
		internal Action OMBCDMOHJOK;

		internal NOMMEFIICHO KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			FOGIOGKLNIP.IAOONCAPLGK(KPHCHDHEKGH.FKICDOGJIFN.AreYouSureText);
			GUILayout.BeginHorizontal();
			if (FOGIOGKLNIP.MHFCLILDBCM(KPHCHDHEKGH.FKICDOGJIFN.YesText))
			{
				FOGIOGKLNIP.GLNAMCPCICH.enabled = false;
				OMBCDMOHJOK();
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(KPHCHDHEKGH.FKICDOGJIFN.NoText))
			{
				FOGIOGKLNIP.GLNAMCPCICH.enabled = false;
			}
			GUILayout.EndHorizontal();
		}
	}

	[CompilerGenerated]
	private sealed class PGMAIAHLKIP
	{
		internal List<string> MCKBPMNFNAD;

		internal NOMMEFIICHO KPHCHDHEKGH;
	}

	[CompilerGenerated]
	private sealed class BFPKMPAALMA
	{
		internal int CHACLIGMINP;

		internal PGMAIAHLKIP KKGGDDMMIMP;

		internal void BEKJDJFLJJC()
		{
			for (int i = 0; i < FOGIOGKLNIP.LMMFHEODOPM.MMHLHLOBIMI.Length; i++)
			{
				if (GUILayout.Button(string.Format("{0} #{1}", FOGIOGKLNIP.FHHPMGJCHJL("Server"), i + 1)))
				{
					FOGIOGKLNIP.LPLJMLGKCLK.JAIHLALJHHO = KKGGDDMMIMP.MCKBPMNFNAD[CHACLIGMINP];
					FOGIOGKLNIP.LPLJMLGKCLK.PDDELHFGPNK = KKGGDDMMIMP.MCKBPMNFNAD[CHACLIGMINP + 1];
					KKGGDDMMIMP.KPHCHDHEKGH.LOMDLDMGGOD(KKGGDDMMIMP.MCKBPMNFNAD[CHACLIGMINP + 1], FOGIOGKLNIP.LMMFHEODOPM.MMHLHLOBIMI[i]);
					FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class ABOPEOAEMFC
	{
		internal string FKMDIOFFBCF;

		internal string IDHBHCHJCON;

		internal void BEKJDJFLJJC()
		{
			PhotonNetwork.Connect(FKMDIOFFBCF, 5055, IDHBHCHJCON);
		}
	}

	[CompilerGenerated]
	private sealed class IMHNIGOMCNH
	{
		internal IMCJHBIFEAK JLNAJMKHJOK;

		internal int BEKJDJFLJJC(MapStats AEMBPMJMOAB)
		{
			return ((JLNAJMKHJOK != IMCJHBIFEAK.Survival && JLNAJMKHJOK != IMCJHBIFEAK.ECACNDFNADN) ? AEMBPMJMOAB.plays : AEMBPMJMOAB.botPlays) + ((AEMBPMJMOAB.local || AEMBPMJMOAB.featured) ? 100000 : 0);
		}
	}

	[CompilerGenerated]
	private sealed class AECDDKODODD
	{
		internal string DACLIJPONJK;

		internal bool BEKJDJFLJJC(MapStats AEMBPMJMOAB)
		{
			return FOGIOGKLNIP.GIGJFCBMKMO(AEMBPMJMOAB.mapName) == FOGIOGKLNIP.GIGJFCBMKMO(DACLIJPONJK);
		}
	}

	[CompilerGenerated]
	private sealed class KPLKMPMIPME
	{
		internal RoomInfo LECNOMGBOAK;

		internal void BEKJDJFLJJC()
		{
			try
			{
				string name = LECNOMGBOAK.name;
				string[] array = name.Split(new char[1] { '|' }, 2);
				FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO = LECNOMGBOAK.mapName + " " + array[1] + UnityEngine.Random.Range(10, 99);
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
				FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO = LECNOMGBOAK.name;
			}
			if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
			{
				Network.Connect(LECNOMGBOAK.hostdata);
			}
			else
			{
				PhotonNetwork.JoinRoom(LECNOMGBOAK.name);
			}
		}
	}

	[CompilerGenerated]
	private sealed class LJCBMJKPPBI<T> : IEnumerable, IEnumerable<T>, IEnumerator, IDisposable, IEnumerator<T>
	{
		internal IEnumerable<T> DFLMIFIEJBF;

		internal IEnumerator<T> IKOHCEMLPFJ;

		internal IEnumerable<T> EOMIHAJEFKN;

		internal IEnumerator<T> LIGOLGDDLBF;

		internal bool EPIGBIFHMBD;

		internal bool IDMBMNANPIO;

		internal T HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		T IEnumerator<T>.Current
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
		public LJCBMJKPPBI()
		{
		}

		public bool MoveNext()
		{
			uint num = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				IKOHCEMLPFJ = DFLMIFIEJBF.GetEnumerator();
				num = 4294967293u;
				goto case 1u;
			case 1u:
			case 2u:
				try
				{
					switch (num)
					{
					default:
						LIGOLGDDLBF = EOMIHAJEFKN.GetEnumerator();
						num = 4294967293u;
						break;
					case 1u:
					case 2u:
						break;
					}
					try
					{
						switch (num)
						{
						case 1u:
							if (IDMBMNANPIO)
							{
								HLJEEFIJCOF = LIGOLGDDLBF.Current;
								if (!JMOBJHKGFMH)
								{
									GNNOELAJGPI = 2;
								}
								flag = true;
								break;
							}
							goto default;
						default:
							if ((EPIGBIFHMBD = IKOHCEMLPFJ.MoveNext()) | (IDMBMNANPIO = LIGOLGDDLBF.MoveNext()))
							{
								if (EPIGBIFHMBD)
								{
									HLJEEFIJCOF = IKOHCEMLPFJ.Current;
									if (!JMOBJHKGFMH)
									{
										GNNOELAJGPI = 1;
									}
									flag = true;
									break;
								}
								goto case 1u;
							}
							goto end_IL_005f;
						}
						break;
						end_IL_005f:;
					}
					finally
					{
						if (!flag)
						{
							OKOKNFKILLM();
						}
					}
				}
				finally
				{
					if (!flag)
					{
						OHAOFHKBECL();
					}
				}
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 1u:
			case 2u:
				try
				{
					try
					{
						break;
					}
					finally
					{
						OKOKNFKILLM();
					}
				}
				finally
				{
					OHAOFHKBECL();
				}
			case 0u:
				break;
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			if (Interlocked.CompareExchange(ref GNNOELAJGPI, 0, -2) == -2)
			{
				return this;
			}
			return new LJCBMJKPPBI<T>
			{
				DFLMIFIEJBF = DFLMIFIEJBF,
				EOMIHAJEFKN = EOMIHAJEFKN
			};
		}

		private void OKOKNFKILLM()
		{
			if (LIGOLGDDLBF != null)
			{
				LIGOLGDDLBF.Dispose();
			}
		}

		private void OHAOFHKBECL()
		{
			if (IKOHCEMLPFJ != null)
			{
				IKOHCEMLPFJ.Dispose();
			}
		}
	}

	private BEJHFGDPDLI JDFKPOMKMNJ = new BEJHFGDPDLI();

	private BEJHFGDPDLI CMEFDJLJODE = new BEJHFGDPDLI();

	public GUIText FIPNNJPILOH;

	public Camera NFJFMIKKOKB;

	public Rect ACOIPCFEBNB;

	private RoomInfo[] ALHLOOCKMBE = new RoomInfo[0];

	private string HOFFKNDCDJI = string.Empty;

	public GUITexture GBCLDBHACGH;

	public GUIStyle BPBNIDGLLFE;

	private Vector2 ELPOKFBMEEL;

	private bool FJFHFCFMAAP;

	private string BAGOHDCADPO = string.Empty;

	private string OAFFADBPLEG = string.Empty;

	private string FAMACNPNDML = string.Empty;

	public string[][] APDMKEBLACL = new string[0][];

	private string[] ONDALMMFFOH;

	private string NPANBBPIPIF = string.Empty;

	private int ANBALHLHHMH;

	private int MMEJJFFIDLL = 1;

	private string HBENFHGKHMA;

	private Vector2 OEPMFBIFGLA;

	private bool MIDICHHDLAD;

	private bool NBBEANAHFNE;

	private int EONGFBGLNLN;

	private int? ABENLDGIKOI;

	public Texture2D LJMGKPBJIEC;

	public string[] EKKEMBPFKGM;

	public static bool NHCDBOAIJBD = true;

	private RoomInfo[] MPEKGCMDCPK = new RoomInfo[0];

	public string EAPNAIEKKNO = string.Empty;

	internal bool GPFEHBMCMML;

	public string HKKNFCKBODF = string.Empty;

	public bool HELPHMFAEOE;

	public string BLEMEMGHOOL;

	private int DHHNBKIFDDO;

	private MapStats[] EIHLGEJBNJI;

	private bool LMJDAEDENKN;

	private const int EBDODPEPDLK = 850;

	public bool OIMPNBHLHGB;

	private string EMDOLODPFAJ;

	private string FPPKONKNAHD;

	private Dictionary<string, string> CPNIJJCPJPI = new Dictionary<string, string>();

	private static float HIHHLPFKIDL = 700f;

	private static float GEMKDDHOGLE = 500f;

	public static Vector3 JDDEBAANKEA;

	private Dictionary<string, int> HNKKAOBIJGN = new Dictionary<string, int>();

	private static Dictionary<string, bool> EHANJAPCFDA = new Dictionary<string, bool>();

	internal bool INDHPOGAJEK;

	public bool MODHLLKJAGK;

	public float BAMLFGJNJHH;

	private HNDJBFNAIHN OKNCIGOCHJI;

	public static List<Posts> EINANNDCPED = new List<Posts>();

	private Vector2 LOADKHHJCDK;

	[CompilerGenerated]
	private static Action<string> ACJNADIPOMC;

	[CompilerGenerated]
	private static Func<Dictionary, bool> HJJBAKLDAEB;

	[CompilerGenerated]
	private static Action<string> MPCENNEMFPB;

	[CompilerGenerated]
	private static Func<RoomInfo, string> AGJHOJDNCOI;

	[CompilerGenerated]
	private static Func<RoomInfo, float> GOKLDIBAPEA;

	[CompilerGenerated]
	private static Func<RoomInfo, int> FDEPMKHNIID;

	[CompilerGenerated]
	private static Func<RoomInfo, int> JEJGIANFAJE;

	[CompilerGenerated]
	private static Func<RoomInfo, int> CAGBNPPEAFL;

	[CompilerGenerated]
	private static Func<RoomInfo, bool> IOIHBOPJMHO;

	[CompilerGenerated]
	private static Func<IGrouping<string, RoomInfo>, int> PLPLKIHGGOE;

	[CompilerGenerated]
	private static Func<RoomInfo, string> MIHBLNGEMJB;

	[CompilerGenerated]
	private static Action<string> MBDEKCIDOHG;

	[CompilerGenerated]
	private static Func<bool> INPFPBONNKM;

	[CompilerGenerated]
	private static Func<string, bool> HNLFEMCPMHM;

	[CompilerGenerated]
	private static Func<MapStats, int> DCNJCLEOEHG;

	[CompilerGenerated]
	private static Func<MapStats, int> AFIEDPFMAGJ;

	[CompilerGenerated]
	private static Func<MapStats, bool> CEOLLBPDPIB;

	[CompilerGenerated]
	private static Action GGPHECIEGDB;

	[CompilerGenerated]
	private static Func<MapStats, bool> MLIEIDFEICI;

	[CompilerGenerated]
	private static Func<MapStats, bool> OFOPMFOMIBE;

	[CompilerGenerated]
	private static Action DFNLGGNOAFC;

	private HNDJBFNAIHN IMDNCJODAEN
	{
		get
		{
			return OKNCIGOCHJI;
		}
		set
		{
			OKNCIGOCHJI = value;
			UnityEngine.Debug.Log(IMDNCJODAEN);
		}
	}

	public bool PMCOPBCMLIJ
	{
		get
		{
			return FOGIOGKLNIP.AEIBIFEDBFB("showdl", PDDIANLEPOC: true);
		}
		set
		{
			FOGIOGKLNIP.EDFAGIMHLFA("showdl", value);
		}
	}

	public bool LHAOFNHHJEN => Application.CanStreamedLevelBeLoaded(FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF)) || (HKIKLNKHPEP(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF) && ILJOBCIBPBJ != null && string.IsNullOrEmpty(ILJOBCIBPBJ.error) && ILJOBCIBPBJ.isDone);

	public WWW ILJOBCIBPBJ
	{
		get
		{
			return FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ;
		}
		set
		{
			FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ = value;
		}
	}

	public float BOFMJFANLDN
	{
		get
		{
			return FOGIOGKLNIP.CMBFGIGIDIP("maxPlayers5", 32f);
		}
		set
		{
			FOGIOGKLNIP.DEJNFKMKPKN("maxPlayers5", value);
		}
	}

	public override void Awake()
	{
		FOGIOGKLNIP.INJKJFIDKJM = this;
		base.Awake();
	}

	public IEnumerator Start()
	{
		OIMPNBHLHGB = false;
		FOGIOGKLNIP.LPLJMLGKCLK.HHHPAGPAPPF = false;
		MonoBehaviour.print("LoaderGui Start");
		FOGIOGKLNIP.LPLJMLGKCLK.GEIGNOAKBEP = false;
		EMDOLODPFAJ = string.Format("{0}                     {1}                      {2}       {3} {4}", FOGIOGKLNIP.FNOCDPLPAIJ("Map"), FOGIOGKLNIP.FNOCDPLPAIJ("GameName"), FOGIOGKLNIP.FNOCDPLPAIJ("Type"), FOGIOGKLNIP.FNOCDPLPAIJ("Players"), FOGIOGKLNIP.FNOCDPLPAIJ("Flags"));
		FPPKONKNAHD = FOGIOGKLNIP.JJHNFGLOCBC(EMDOLODPFAJ);
		MODHLLKJAGK = false;
		if (base.MDBAFPKAKKK)
		{
			base.MDBAFPKAKKK = false;
		}
		BIHOCPAKHNF("GUI Start");
		if (FOGIOGKLNIP.LPLJMLGKCLK.IGPPHPINEOI)
		{
			IMDNCJODAEN = ((!base.JNPCOJFBJGP) ? HNDJBFNAIHN.MAJHJGIICED : HNDJBFNAIHN.HJEAMMANNHM);
			if (FOGIOGKLNIP.LPLJMLGKCLK.IGPPHPINEOI)
			{
				JDFKPOMKMNJ.IPBKDPKONHH(2000, GOEPNIAIKAF);
			}
		}
		if (!FOGIOGKLNIP.LPLJMLGKCLK.IGPPHPINEOI)
		{
			string text = FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP + "txt/mainsite.txt";
			MonoBehaviour.print(text);
			WWW GDIFBJBOCJM = new WWW(text);
			StartCoroutine(FOGIOGKLNIP.IPBKDPKONHH(GDIFBJBOCJM, delegate
			{
				if (string.IsNullOrEmpty(GDIFBJBOCJM.error))
				{
					MonoBehaviour.print("Get Serve " + GDIFBJBOCJM.text);
					FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP = GDIFBJBOCJM.text;
				}
				AKFEDLCCGCF();
			}));
			FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP + "txt/backup.txt", delegate(string KLLKONMADKA)
			{
				MonoBehaviour.print("Backup " + KLLKONMADKA);
				FOGIOGKLNIP.LMMFHEODOPM.LMPHJCDENFF = KLLKONMADKA.Split2();
			});
		}
		FOGIOGKLNIP.LPLJMLGKCLK.IGPPHPINEOI = true;
		Resources.UnloadUnusedAssets();
		if (FOGIOGKLNIP.INJKJFIDKJM.ILJOBCIBPBJ != null)
		{
			FOGIOGKLNIP.INJKJFIDKJM.ILJOBCIBPBJ.Dispose();
		}
		FOGIOGKLNIP.INJKJFIDKJM.ILJOBCIBPBJ = null;
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			Network.Disconnect();
		}
		FOGIOGKLNIP.HJLAMDIBCDO.HAPPCOBHMHM();
		yield return null;
	}

	private void BAOKBJKIFON()
	{
		FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP + base.BHCIEFHBOPB.LoaderGuiAppId, delegate(string KLLKONMADKA)
		{
			string[] array = KLLKONMADKA.Split(new char[1] { '\n' }, StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].StartsWith("APPID:"))
				{
					UnityEngine.Debug.LogWarning("GetID");
					FOGIOGKLNIP.LMMFHEODOPM.MMHLHLOBIMI[i] = array[i].Replace("APPID:", string.Empty).Trim('\r');
				}
				else
				{
					UnityEngine.Debug.LogWarning("NotFoundID");
				}
			}
		});
	}

	public IEnumerator FIDPFKBPFCH(string KLLKONMADKA)
	{
		FOGIOGKLNIP.LPLJMLGKCLK.HAGGFHKMNJG.Clear();
		string[] array = KLLKONMADKA.Split2();
		for (int i = 0; i < array.Length; i++)
		{
			string url = string.Concat(str2: array[i], str0: FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP, str1: base.BHCIEFHBOPB.LoaderGuiDicts);
			WWW wWW = new WWW(url);
			yield return wWW;
			if (string.IsNullOrEmpty(wWW.error))
			{
				MOHMCMAMDAL(CILHLJOJKKF.NMJPIBHOJLM, wWW.text);
				FOGIOGKLNIP.LPLJMLGKCLK.HAGGFHKMNJG.Add(wWW.text);
			}
		}
		EJMJABLFNHP();
	}

	private void EJMJABLFNHP()
	{
		FOGIOGKLNIP.ICNGEHGPIFM.Clear();
		foreach (string item in FOGIOGKLNIP.LPLJMLGKCLK.HAGGFHKMNJG)
		{
			try
			{
				string[] array = item.Split2(";");
				Dictionary dictionary = new Dictionary();
				string[] array2 = array[0].Split(':');
				dictionary.name = array2[0];
				if (array2.Length > 1)
				{
					dictionary.code = array2[1];
				}
				string[] array3 = array[1].Split2("\n");
				foreach (string s in array3)
				{
					string[] array4 = s.Split2("=");
					if (array4.Length > 1)
					{
						dictionary.dict[array4[0]] = array4[1];
					}
					if (array4.Length > 2)
					{
						dictionary.tips[array4[0]] = array4[2];
					}
				}
				Dictionary dictionary2 = FOGIOGKLNIP.ICNGEHGPIFM.FirstOrDefault();
				if (dictionary2 != null)
				{
					foreach (KeyValuePair<string, string> item2 in dictionary2.dict)
					{
						if (!dictionary.dict.ContainsKey(item2.Key))
						{
							dictionary.dict.Add(item2.Key, item2.Value);
						}
					}
				}
				FOGIOGKLNIP.ICNGEHGPIFM.Add(dictionary);
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
			}
		}
		FOGIOGKLNIP.EFPKGAAFKFG = FOGIOGKLNIP.ICNGEHGPIFM.FirstOrDefault((Dictionary AEMBPMJMOAB) => AEMBPMJMOAB.code == FOGIOGKLNIP.LPLJMLGKCLK.IIGIKNBFIKL.ToUpper()) ?? FOGIOGKLNIP.ICNGEHGPIFM.FirstOrDefault();
	}

	private void AKFEDLCCGCF()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.HAGGFHKMNJG.Count > 0)
		{
			EJMJABLFNHP();
		}
		if (FOGIOGKLNIP.LMMFHEODOPM.MCENKACBEHI)
		{
			return;
		}
		FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP + base.BHCIEFHBOPB.LoaderGuiDicts2, delegate(string KLLKONMADKA)
		{
			StartCoroutine(FIDPFKBPFCH(KLLKONMADKA));
		});
		FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP + base.BHCIEFHBOPB.LoaderGuiVersion, delegate(string KLLKONMADKA)
		{
			string[] array = KLLKONMADKA.Split(',');
			int num = ((Application.platform == RuntimePlatform.WebGLPlayer || Application.platform == RuntimePlatform.WindowsPlayer) ? 1 : ((Application.platform == RuntimePlatform.Android) ? 2 : ((Application.platform != RuntimePlatform.IPhonePlayer) ? 4 : 3)));
			FOGIOGKLNIP.LPLJMLGKCLK.MHCPDOOKBCM = array[num];
			if (string.Compare(FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP, FOGIOGKLNIP.LPLJMLGKCLK.MHCPDOOKBCM, StringComparison.OrdinalIgnoreCase) < 0)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.LoaderGuiNewVersionAvailable) + array[num] + base.FKICDOGJIFN.LoaderGuiYourVersion + FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP;
			}
		});
		FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.LPLJMLGKCLK.BIJHBGLFDAP + base.BHCIEFHBOPB.LoaderGuiFilterErrors, delegate(string KLLKONMADKA)
		{
			FOGIOGKLNIP.HJLAMDIBCDO.NFLLOBGKLLO = KLLKONMADKA.Split2();
		});
		BAOKBJKIFON();
		try
		{
			if (Application.platform == RuntimePlatform.Android && !Directory.Exists(NCGNCLMDIKB.HJAAHJGBEHB))
			{
				Directory.CreateDirectory(NCGNCLMDIKB.HJAAHJGBEHB);
			}
		}
		catch (Exception message)
		{
			MonoBehaviour.print(message);
		}
		FOGIOGKLNIP.BEHFNEAKDAL.AKFEDLCCGCF();
	}

	public static string IBEINKOFJNI()
	{
		return DateTime.Now.ToString("u");
	}

	public void GOEPNIAIKAF()
	{
		CJEEMFGNNOH();
	}

	public void CJEEMFGNNOH()
	{
		RoomInfo[] array = ((!FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO) ? PhotonNetwork.GetRoomList() : IMELJGDELMF());
		if (array.Length <= 0)
		{
			return;
		}
		ALHLOOCKMBE = array;
		IEnumerable<RoomInfo> enumerable = HEDLJMAJJPN().ToArray();
		HNKKAOBIJGN.Clear();
		foreach (RoomInfo LECNOMGBOAK in enumerable)
		{
			if (!HNKKAOBIJGN.ContainsKey(LECNOMGBOAK.mapName))
			{
				HNKKAOBIJGN[LECNOMGBOAK.mapName] = enumerable.Count((RoomInfo AEMBPMJMOAB) => FOGIOGKLNIP.GIGJFCBMKMO(AEMBPMJMOAB.mapName) == LECNOMGBOAK.mapName && AEMBPMJMOAB.sets[5] == LECNOMGBOAK.sets[5]);
			}
			LECNOMGBOAK.groupCount = HNKKAOBIJGN[LECNOMGBOAK.mapName] + (LECNOMGBOAK.isDae ? 2 : 0);
		}
		IOrderedEnumerable<RoomInfo> source = from AEMBPMJMOAB in enumerable
			orderby AEMBPMJMOAB.version descending, AEMBPMJMOAB.sortAdd
			select AEMBPMJMOAB;
		if (FOGIOGKLNIP.LFENOGAECJD)
		{
			MPEKGCMDCPK = source.ToArray();
			return;
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.DNNNAGAOKJC)
		{
			MPEKGCMDCPK = source.ThenByDescending((RoomInfo AEMBPMJMOAB) => AEMBPMJMOAB.playerCount).ToArray();
			return;
		}
		MPEKGCMDCPK = source.ThenBy((RoomInfo AEMBPMJMOAB) => AEMBPMJMOAB.groupCount).ThenBy((RoomInfo AEMBPMJMOAB) => AEMBPMJMOAB.playerCount).ToArray();
	}

	public void NIBHEKFOPPE()
	{
		EAPNAIEKKNO = string.Empty;
		CJEEMFGNNOH();
		RoomInfo lECNOMGBOAK = MPEKGCMDCPK.FirstOrDefault((RoomInfo AEMBPMJMOAB) => AEMBPMJMOAB.maxPlayers - AEMBPMJMOAB.playerCount > 1 && AEMBPMJMOAB.sets[5] == IMCJHBIFEAK.Classic.ToString());
		IKPDNPCAPOC(lECNOMGBOAK);
	}

	public void Update()
	{
		BAMLFGJNJHH = BOFMJFANLDN;
		if (HOFFKNDCDJI != EAPNAIEKKNO)
		{
			CJEEMFGNNOH();
		}
		HOFFKNDCDJI = EAPNAIEKKNO;
		if (ILJOBCIBPBJ != null && ILJOBCIBPBJ.progress != 1f)
		{
			FOGIOGKLNIP.PBADCKNDABE(string.Empty, FOGIOGKLNIP.FHHPMGJCHJL("Loading Map ") + (int)(ILJOBCIBPBJ.progress * 100f) + "% " + FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF), "Cancel", MMJNLLMFOCD: true);
		}
		if (FIPNNJPILOH != null)
		{
			FIPNNJPILOH.text = string.Concat(ObscuredInt.FNIPJFGEFFD(FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.JCMCPIPHDHB), "$\r\n", FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.LBKOHPIDKFH, "\r\n", FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.KIDFODCBGNA);
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
	}

	public void OnGUI()
	{
		ONENCGHKFNI();
		if (!FOGIOGKLNIP.BEHFNEAKDAL.enabled && !FOGIOGKLNIP.LPLJMLGKCLK.GIOACCEINCF)
		{
			GUI.skin = FOGIOGKLNIP.LPLJMLGKCLK.EPDKDICMOHH;
			Vector2 vector = ((IMDNCJODAEN == HNDJBFNAIHN.KNFOHBBPPJB) ? new Vector2(400f, 600f) : ((IMDNCJODAEN == HNDJBFNAIHN.HJEAMMANNHM) ? new Vector2(300f, 550f) : ((IMDNCJODAEN == HNDJBFNAIHN.NFDLEHOMJBC) ? new Vector2(400f, 1000f) : ((IMDNCJODAEN == HNDJBFNAIHN.MAJHJGIICED) ? new Vector2(850f, 1000f) : ((IMDNCJODAEN == HNDJBFNAIHN.OMAHPOHDKJH) ? new Vector2(800f, 1000f) : ((IMDNCJODAEN == HNDJBFNAIHN.LJJAAIDPKIM) ? new Vector2(800f, 1000f) : ((IMDNCJODAEN == HNDJBFNAIHN.DFMPLJLAGFM) ? new Vector2(800f, 1000f) : ((IMDNCJODAEN != HNDJBFNAIHN.IBEPICCMOCK) ? new Vector2(300f, 400f) : new Vector2(500f, 1000f)))))))));
			FOGIOGKLNIP.NGLMHFOKCHK((int)vector.x, (int)vector.y, string.Empty, HEKJLNDHNIC, FGJCEHCCEEO.FHPONDBOGNC, (IMDNCJODAEN != HNDJBFNAIHN.OMAHPOHDKJH && IMDNCJODAEN != HNDJBFNAIHN.DFMPLJLAGFM && IMDNCJODAEN != HNDJBFNAIHN.MAJHJGIICED) ? NBOGOKNEBGI.GDGBPJODALD : NBOGOKNEBGI.IPBFPHDFNNH, (IMDNCJODAEN != 0 && IMDNCJODAEN != HNDJBFNAIHN.MAJHJGIICED && IMDNCJODAEN != HNDJBFNAIHN.KNFOHBBPPJB && IMDNCJODAEN != HNDJBFNAIHN.NFDLEHOMJBC && IMDNCJODAEN != HNDJBFNAIHN.EKGBDKEDIKK) ? GUI.skin.window : BPBNIDGLLFE);
			CMEFDJLJODE.OJFAJPLDPPK();
		}
	}

	private void HEKJLNDHNIC(int JFLBOOBFAEF)
	{
		ELPOKFBMEEL = GUILayout.BeginScrollView(ELPOKFBMEEL);
		ELPOKFBMEEL.y += OMIPNBBJLOD();
		if (IMDNCJODAEN == HNDJBFNAIHN.KNFOHBBPPJB)
		{
			KNFOHBBPPJB();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.IBEPICCMOCK)
		{
			if (KMDDIKDANBF())
			{
				IMDNCJODAEN = HNDJBFNAIHN.HJEAMMANNHM;
			}
			FOGIOGKLNIP.LPLJMLGKCLK.IBEPICCMOCK();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.EKGBDKEDIKK)
		{
			EAACOKBAOFO();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.NFDLEHOMJBC)
		{
			NFDLEHOMJBC();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.MAJHJGIICED)
		{
			KMAEFOAOMLC();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.HJEAMMANNHM)
		{
			HJEAMMANNHM();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.JNDEHPJAMJB)
		{
			JNDEHPJAMJB();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.OMAHPOHDKJH)
		{
			if (KMDDIKDANBF())
			{
				IMDNCJODAEN = HNDJBFNAIHN.HJEAMMANNHM;
			}
			OMAHPOHDKJH();
		}
		else if (IMDNCJODAEN == HNDJBFNAIHN.DFMPLJLAGFM)
		{
			DFMPLJLAGFM();
		}
		GUILayout.EndScrollView();
	}

	private void GIPGFIILFEK()
	{
		ELPOKFBMEEL = GUILayout.BeginScrollView(ELPOKFBMEEL);
		EAPNAIEKKNO = FOGIOGKLNIP.ODCONJOFBPD(EAPNAIEKKNO);
		RoomInfo[] array = ((!FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO) ? PhotonNetwork.GetRoomList() : IMELJGDELMF());
		StringBuilder stringBuilder = new StringBuilder();
		foreach (IGrouping<string, RoomInfo> item in array.GroupBy(delegate(RoomInfo AEMBPMJMOAB)
		{
			string[] array3 = AEMBPMJMOAB.name.Split('|');
			if (array3.Length < 2)
			{
				array3 = AEMBPMJMOAB.name.Split('/');
			}
			return (array3.Length < 2) ? "unknown" : array3[1];
		}).OrderByDescending(Enumerable.Count))
		{
			stringBuilder.AppendLine(item.Key + ":" + item.Count());
		}
		RoomInfo[] array2 = array;
		foreach (RoomInfo roomInfo in array2)
		{
			if (EAPNAIEKKNO.Length == 0 || roomInfo.name.ToLower().Contains(EAPNAIEKKNO.ToLower()))
			{
				stringBuilder.AppendLine(roomInfo.playerCount + "/" + roomInfo.maxPlayers + " " + roomInfo.name + "\r\n");
			}
		}
		GUILayout.Box(stringBuilder.ToString());
		GUILayout.EndScrollView();
	}

	private void DFMPLJLAGFM()
	{
	}

	private void OFFPKLGDFGF(string AEMBPMJMOAB)
	{
	}

	private void NJPKCAMEKCH(Action OMBCDMOHJOK)
	{
		FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(400, 200, base.FKICDOGJIFN.LoaderGuiConfirmAction, NBOGOKNEBGI.IPBFPHDFNNH, delegate
		{
			FOGIOGKLNIP.IAOONCAPLGK(base.FKICDOGJIFN.AreYouSureText);
			GUILayout.BeginHorizontal();
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.YesText))
			{
				FOGIOGKLNIP.GLNAMCPCICH.enabled = false;
				OMBCDMOHJOK();
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.NoText))
			{
				FOGIOGKLNIP.GLNAMCPCICH.enabled = false;
			}
			GUILayout.EndHorizontal();
		});
	}

	private void JEIGIDLOCPH(int FJOEKACIPDI, string HDGELEFBNAJ = "")
	{
	}

	private bool KMDDIKDANBF()
	{
		return FOGIOGKLNIP.MHFCLILDBCM("<<Back") || Input.GetKeyDown(KeyCode.Escape) || FOGIOGKLNIP.EPBMIIPELPO.MAJOLNADCFG(KeyCode.Space);
	}

	private void EAACOKBAOFO()
	{
		if (KMDDIKDANBF())
		{
			IMDNCJODAEN = HNDJBFNAIHN.HJEAMMANNHM;
		}
		FOGIOGKLNIP.IAOONCAPLGK("Select Game Type");
		if (FOGIOGKLNIP.MHFCLILDBCM("Classic", GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = IMCJHBIFEAK.Classic;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Team DeatMatch", GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = IMCJHBIFEAK.TDM;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("DeathMatch", GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = IMCJHBIFEAK.DeathMatch;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Juggernaut Mode", GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = IMCJHBIFEAK.Juggernaut;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Zombie Mode", GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = IMCJHBIFEAK.ZombieMode;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Zombie Survival", GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = IMCJHBIFEAK.Survival;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Bot Match", GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD = IMCJHBIFEAK.ECACNDFNADN;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
	}

	public void OMAHPOHDKJH()
	{
		if (FOGIOGKLNIP.BEHFNEAKDAL.EPMOFPNGEAG && FOGIOGKLNIP.OMMLFOEPEEK)
		{
			GUILayout.BeginHorizontal();
			bool flag = FOGIOGKLNIP.HGHFNJMFLHM(MIDICHHDLAD, base.FKICDOGJIFN.LoaderGuiRegisteredSameDay);
			if (flag != MIDICHHDLAD)
			{
				NBBEANAHFNE = false;
				MIDICHHDLAD = flag;
				GDBJHJEDCDJ(EONGFBGLNLN);
			}
			bool flag2 = FOGIOGKLNIP.HGHFNJMFLHM(NBBEANAHFNE, base.FKICDOGJIFN.LoaderGuiFriendsOnly);
			if (NBBEANAHFNE != flag2)
			{
				MIDICHHDLAD = false;
				NBBEANAHFNE = flag2;
				GDBJHJEDCDJ(EONGFBGLNLN);
			}
			GUILayout.EndHorizontal();
		}
		GUILayout.BeginHorizontal();
		for (int i = 0; i < FOGIOGKLNIP.LPLJMLGKCLK.NEKEPCHBFPL.Length; i++)
		{
			if (i % 4 == 0)
			{
				GUILayout.EndHorizontal();
				GUILayout.BeginHorizontal();
			}
			if (FOGIOGKLNIP.MHFCLILDBCM(FOGIOGKLNIP.LPLJMLGKCLK.NEKEPCHBFPL[i], GUILayout.ExpandWidth(expand: true)))
			{
				GDBJHJEDCDJ(i);
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.Label(FOGIOGKLNIP.LPLJMLGKCLK.KKECGAFLPLJ, MBKHABKMDLJ("ScoreBoard"));
	}

	public void GDBJHJEDCDJ(int FAGMOBEKJND)
	{
		EONGFBGLNLN = FAGMOBEKJND;
		if (FOGIOGKLNIP.LPLJMLGKCLK.NEKEPCHBFPL.Length > FAGMOBEKJND)
		{
			FOGIOGKLNIP.KFEIIDMFOLF(FOGIOGKLNIP.BEHFNEAKDAL.BIJHBGLFDAP + base.BHCIEFHBOPB.ScoreBoard, delegate(string GDKFLGBMPBB)
			{
				FOGIOGKLNIP.LPLJMLGKCLK.KKECGAFLPLJ = GDKFLGBMPBB;
			}, base.BHCIEFHBOPB.ScoreBoardBoard, FOGIOGKLNIP.LPLJMLGKCLK.NEKEPCHBFPL[FAGMOBEKJND], base.BHCIEFHBOPB.ScoreBoardNick, (!FOGIOGKLNIP.BEHFNEAKDAL.EPMOFPNGEAG || (!MIDICHHDLAD && !NBBEANAHFNE)) ? string.Empty : FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.NIGOGFAMFIB, base.BHCIEFHBOPB.ScoreBoardFriends, NBBEANAHFNE ? 1 : 0, base.BHCIEFHBOPB.ScoreBoardSameDay, MIDICHHDLAD ? 1 : 0);
		}
	}

	public void INCNLGKBBBP(string KLLKONMADKA)
	{
		UnityEngine.Debug.Log("scoreboard received");
		FOGIOGKLNIP.LPLJMLGKCLK.KKECGAFLPLJ = KLLKONMADKA;
	}

	private void JNDEHPJAMJB()
	{
	}

	private void BHEKMFBCDJJ()
	{
	}

	private void HJEAMMANNHM()
	{
		FOGIOGKLNIP.IAOONCAPLGK(FOGIOGKLNIP.LPLJMLGKCLK.MHCPAFPDMGO);
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.LoaderGuiSinglePlayer, GUILayout.ExpandWidth(expand: true)))
		{
			ICNGKJFHJOC();
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.LoaderGuiMultiPlayer, GUILayout.ExpandWidth(expand: true)))
		{
			IMDNCJODAEN = HNDJBFNAIHN.KNFOHBBPPJB;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.LoaderGuiScoreBoard, GUILayout.ExpandWidth(expand: true)))
		{
			GDBJHJEDCDJ(0);
			IMDNCJODAEN = HNDJBFNAIHN.OMAHPOHDKJH;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.LoaderGuiSettings, GUILayout.ExpandWidth(expand: true)))
		{
			IMDNCJODAEN = HNDJBFNAIHN.IBEPICCMOCK;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.LoaderGuiQuit, GUILayout.ExpandWidth(expand: true)))
		{
			Application.Quit();
		}
	}

	private void OnApplicationPause(bool BGDGPJAENDF)
	{
	}

	public void ICNGKJFHJOC()
	{
		PhotonNetwork.Disconnect();
		base.JNPCOJFBJGP = true;
		FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO = false;
		FOGIOGKLNIP.LPLJMLGKCLK.JAIHLALJHHO = base.FKICDOGJIFN.LoaderGuiSinglePlayer;
		IMDNCJODAEN = HNDJBFNAIHN.EKGBDKEDIKK;
	}

	private void KNFOHBBPPJB()
	{
		if (KMDDIKDANBF())
		{
			IMDNCJODAEN = HNDJBFNAIHN.HJEAMMANNHM;
		}
		FOGIOGKLNIP.BEHFNEAKDAL.PLBEGIIGLMJ();
		if (FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD.Length != 0 && NHCDBOAIJBD)
		{
			FOGIOGKLNIP.IAOONCAPLGK("Select Region (select nearest location)");
			JBLEGBFMGDH(FOGIOGKLNIP.LPLJMLGKCLK.MCKBPMNFNAD);
			GUILayout.Space(20f);
			if (FOGIOGKLNIP.MHFCLILDBCM("Lan", GUILayout.ExpandWidth(expand: true)))
			{
				IFAMHCGKOLL();
			}
			FOGIOGKLNIP.IAOONCAPLGK("User hosted Servers");
			JBLEGBFMGDH(FOGIOGKLNIP.LPLJMLGKCLK.JANKNNJPOCL);
		}
	}

	internal void IFAMHCGKOLL()
	{
		PhotonNetwork.Disconnect();
		MasterServer.RequestHostList("csport");
		JDFKPOMKMNJ.IPBKDPKONHH(1000, GOEPNIAIKAF);
		FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO = true;
		base.JNPCOJFBJGP = false;
		FOGIOGKLNIP.LPLJMLGKCLK.JAIHLALJHHO = "Lan/Direct Connect";
		IMDNCJODAEN = HNDJBFNAIHN.MAJHJGIICED;
	}

	private void JBLEGBFMGDH(List<string> MCKBPMNFNAD)
	{
		for (int i = 0; i < MCKBPMNFNAD.Count; i += 2)
		{
			if (MCKBPMNFNAD.Count == i + 1 || !FOGIOGKLNIP.MHFCLILDBCM(MCKBPMNFNAD[i].Trim(), GUILayout.ExpandWidth(expand: true)))
			{
				continue;
			}
			int CHACLIGMINP = i;
			FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(200 * (Screen.width / Screen.height), 400 * (Screen.width / Screen.height), "Select Server", NBOGOKNEBGI.IPBFPHDFNNH, delegate
			{
				for (int j = 0; j < FOGIOGKLNIP.LMMFHEODOPM.MMHLHLOBIMI.Length; j++)
				{
					if (GUILayout.Button(string.Format("{0} #{1}", FOGIOGKLNIP.FHHPMGJCHJL("Server"), j + 1)))
					{
						FOGIOGKLNIP.LPLJMLGKCLK.JAIHLALJHHO = MCKBPMNFNAD[CHACLIGMINP];
						FOGIOGKLNIP.LPLJMLGKCLK.PDDELHFGPNK = MCKBPMNFNAD[CHACLIGMINP + 1];
						LOMDLDMGGOD(MCKBPMNFNAD[CHACLIGMINP + 1], FOGIOGKLNIP.LMMFHEODOPM.MMHLHLOBIMI[j]);
						FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
					}
				}
			}, null, DMHLBFCJLJG: true);
		}
	}

	internal void LOMDLDMGGOD(string FKMDIOFFBCF, string IDHBHCHJCON)
	{
		FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO = false;
		base.JNPCOJFBJGP = false;
		CLEIHBGGHMD("Conencting to " + FKMDIOFFBCF + "  " + PhotonNetwork.connectionState);
		PhotonNetwork.Disconnect();
		JDFKPOMKMNJ.IPBKDPKONHH(() => !PhotonNetwork.connected, delegate
		{
			PhotonNetwork.Connect(FKMDIOFFBCF, 5055, IDHBHCHJCON);
		});
	}

	public void OnMasterServerEvent(MasterServerEvent FHAIFLDCHLC)
	{
		BIHOCPAKHNF(FHAIFLDCHLC.ToString());
	}

	public RoomInfo[] IMELJGDELMF()
	{
		List<RoomInfo> list = new List<RoomInfo>();
		HostData[] array = MasterServer.PollHostList();
		if (array.Length != 0)
		{
			HostData[] array2 = array;
			foreach (HostData hostData in array2)
			{
				RoomInfo roomInfo = new RoomInfo(hostData.gameName, new Hashtable(), isVisible: true, isOpen: true, (byte)hostData.playerLimit);
				roomInfo.playerCount = (byte)hostData.connectedPlayers;
				roomInfo.hostdata = hostData;
				list.Add(roomInfo);
			}
			return list.ToArray();
		}
		return new RoomInfo[0];
	}

	private void NFDLEHOMJBC()
	{
		if (KMDDIKDANBF())
		{
			IMDNCJODAEN = ((!base.JNPCOJFBJGP) ? HNDJBFNAIHN.MAJHJGIICED : HNDJBFNAIHN.HJEAMMANNHM);
		}
		if (!base.JNPCOJFBJGP)
		{
			GUILayout.BeginHorizontal();
			FOGIOGKLNIP.IAOONCAPLGK("Game Name:", GUILayout.ExpandWidth(expand: false));
			FOGIOGKLNIP.LPLJMLGKCLK.NDFPLDPNNMG = GUILayout.TextField(FOGIOGKLNIP.LPLJMLGKCLK.NDFPLDPNNMG.Replace(" ", "_"), 20);
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL("Max Players:") + (int)BOFMJFANLDN, GUILayout.ExpandWidth(expand: false));
			BOFMJFANLDN = GUILayout.HorizontalSlider(BOFMJFANLDN, 1f, 32f);
			GUILayout.EndHorizontal();
			if (!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.FHEIEHKHDHL))
			{
				FOGIOGKLNIP.LPLJMLGKCLK.LIMCHPFAJHC = ObscuredFloat.FNIPJFGEFFD(JJCCBMNJNEF("Game Time", ObscuredFloat.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.LIMCHPFAJHC), 1f, 9f, 1f));
			}
			INDHPOGAJEK = FOGIOGKLNIP.HGHFNJMFLHM(INDHPOGAJEK, "Private Room");
		}
		FOGIOGKLNIP.LMMFHEODOPM.DEMKLLPLDBO = FOGIOGKLNIP.HGHFNJMFLHM(FOGIOGKLNIP.LMMFHEODOPM.DEMKLLPLDBO, "Custom (enable custom server settings)");
		if (FOGIOGKLNIP.LPLJMLGKCLK.FOOCGCIEOIO < 100f && !FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO && !base.JNPCOJFBJGP)
		{
			GPFEHBMCMML = FOGIOGKLNIP.HGHFNJMFLHM(GPFEHBMCMML, "Low Ping (filter laggers)");
		}
		IMCJHBIFEAK JLNAJMKHJOK = FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD;
		IEnumerable<MapStats> aPLCCBLHMIF = FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF;
		if (EIHLGEJBNJI == null || CMEFDJLJODE.NFMIBMIGJMH(1000))
		{
			if (DHHNBKIFDDO == 2)
			{
				EIHLGEJBNJI = aPLCCBLHMIF.OrderByDescending((MapStats AEMBPMJMOAB) => (AEMBPMJMOAB.local || AEMBPMJMOAB.featured) ? 1 : 0).ToArray();
			}
			else if (DHHNBKIFDDO == 1)
			{
				EIHLGEJBNJI = aPLCCBLHMIF.OrderByDescending((MapStats AEMBPMJMOAB) => ((JLNAJMKHJOK != IMCJHBIFEAK.Survival && JLNAJMKHJOK != IMCJHBIFEAK.ECACNDFNADN) ? AEMBPMJMOAB.plays : AEMBPMJMOAB.botPlays) + ((AEMBPMJMOAB.local || AEMBPMJMOAB.featured) ? 100000 : 0)).ToArray();
			}
			else if (DHHNBKIFDDO == 0)
			{
				EIHLGEJBNJI = aPLCCBLHMIF.OrderByDescending((MapStats AEMBPMJMOAB) => (!AEMBPMJMOAB.local && !AEMBPMJMOAB.featured) ? AEMBPMJMOAB.date : FOGIOGKLNIP.ICLENOJCEGB).ToArray();
			}
		}
		GUILayout.Space(40f);
		GUILayout.BeginHorizontal();
		FOGIOGKLNIP.IAOONCAPLGK("Search", GUILayout.ExpandWidth(expand: false));
		HKKNFCKBODF = GUILayout.TextField(HKKNFCKBODF, 30);
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		DHHNBKIFDDO = ((!FOGIOGKLNIP.HGHFNJMFLHM(DHHNBKIFDDO == 0, "Newest")) ? DHHNBKIFDDO : 0);
		DHHNBKIFDDO = (FOGIOGKLNIP.HGHFNJMFLHM(DHHNBKIFDDO == 1, "Popular") ? 1 : DHHNBKIFDDO);
		DHHNBKIFDDO = ((!FOGIOGKLNIP.HGHFNJMFLHM(DHHNBKIFDDO == 2, "Alphabet")) ? DHHNBKIFDDO : 2);
		GUILayout.EndHorizontal();
		GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL("Built-In maps:"), GUILayout.ExpandWidth(expand: true));
		foreach (string item in FOGIOGKLNIP.LPLJMLGKCLK.HFFHMPJFIAE.Where(Application.CanStreamedLevelBeLoaded))
		{
			if (item.ToLower().Contains(HKKNFCKBODF))
			{
				HOABMLNJBOL(item);
			}
		}
		GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL("Official maps:"), GUILayout.ExpandWidth(expand: true));
		foreach (MapStats item2 in EIHLGEJBNJI.Where((MapStats AEMBPMJMOAB) => AEMBPMJMOAB.IsDev))
		{
			if (FOGIOGKLNIP.GIGJFCBMKMO(item2.mapName).ToLower().Contains(HKKNFCKBODF))
			{
				HOABMLNJBOL(item2.mapName);
			}
		}
		PMCOPBCMLIJ = FOGIOGKLNIP.HGHFNJMFLHM(PMCOPBCMLIJ, "Show downloaded maps");
		if (PMCOPBCMLIJ)
		{
			FOGIOGKLNIP.IAOONCAPLGK("Downloaded maps:");
			for (int num = FOGIOGKLNIP.LPLJMLGKCLK.PKLNHOEOKBH.Count - 1; num >= 0; num--)
			{
				if (FOGIOGKLNIP.LPLJMLGKCLK.PKLNHOEOKBH[num].ToLower().Contains(HKKNFCKBODF))
				{
					HOABMLNJBOL(FOGIOGKLNIP.LPLJMLGKCLK.PKLNHOEOKBH[num]);
				}
			}
		}
		GUILayout.Space(30f);
		GUILayout.BeginHorizontal();
		if (FOGIOGKLNIP.MHFCLILDBCM("Add Map"))
		{
			FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(700, 600, "Add map", NBOGOKNEBGI.IPBFPHDFNNH, GHOPNDANLMA);
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Set default map folder"))
		{
			FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(700, 600, "Default Map folder", NBOGOKNEBGI.IPBFPHDFNNH, delegate
			{
				GUILayout.Label("Enter maps location directory with .unity3d files types");
				NCGNCLMDIKB.HJAAHJGBEHB = GUILayout.TextField(NCGNCLMDIKB.HJAAHJGBEHB);
				if (FOGIOGKLNIP.MHFCLILDBCM("Setup"))
				{
					try
					{
						Directory.CreateDirectory(NCGNCLMDIKB.HJAAHJGBEHB);
						FOGIOGKLNIP.BEHFNEAKDAL.FCMPPIBMPGO(IBPMLCAGBFG: true);
					}
					catch (Exception ex)
					{
						FOGIOGKLNIP.PBADCKNDABE(ex.ToString());
					}
					FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
				}
			});
		}
		GUILayout.EndHorizontal();
		GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL("Downloadable community maps (") + EIHLGEJBNJI.Count((MapStats AEMBPMJMOAB) => !AEMBPMJMOAB.IsDev) + "):", GUILayout.ExpandWidth(expand: true));
		foreach (MapStats item3 in EIHLGEJBNJI.Where((MapStats AEMBPMJMOAB) => !AEMBPMJMOAB.IsDev))
		{
			if (HKKNFCKBODF == string.Empty || FOGIOGKLNIP.GIGJFCBMKMO(item3.mapName).ToLower().Contains(HKKNFCKBODF))
			{
				HOABMLNJBOL(item3.mapName);
			}
		}
	}

	private void GHOPNDANLMA()
	{
		GUILayout.Label(base.FKICDOGJIFN.LoaderGuiEnterMapsLocationURL);
		BLEMEMGHOOL = GUILayout.TextField(BLEMEMGHOOL);
		if (FOGIOGKLNIP.MHFCLILDBCM(base.FKICDOGJIFN.LoaderGuiAddMap) && BLEMEMGHOOL.Length > 0)
		{
			if (Path.GetExtension(BLEMEMGHOOL).ToLower().StartsWith(".unity3d"))
			{
				FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF.Add(new MapStats
				{
					local = true,
					mapName = WWW.UnEscapeURL(BLEMEMGHOOL)
				});
			}
			else
			{
				StartCoroutine(FOGIOGKLNIP.BEHFNEAKDAL.LGFPGOBIJCA(new string[1] { BLEMEMGHOOL }, IBPMLCAGBFG: true));
			}
			FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
		}
	}

	private void HOABMLNJBOL(string DACLIJPONJK)
	{
		if (FOGIOGKLNIP.MHFCLILDBCM(FOGIOGKLNIP.FHHPMGJCHJL(HAFKGGPPBOG(FOGIOGKLNIP.GIGJFCBMKMO(DACLIJPONJK))), GUILayout.ExpandWidth(expand: true)))
		{
			FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF = DACLIJPONJK;
			if (LMJDAEDENKN)
			{
				LMJDAEDENKN = false;
				FOGIOGKLNIP.PBADCKNDABE(string.Empty, FOGIOGKLNIP.FHHPMGJCHJL("Connecting to ") + EAPNAIEKKNO + ":unityPort udp map:" + FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF, "Cancel", MMJNLLMFOCD: true);
				IMDNCJODAEN = HNDJBFNAIHN.MAJHJGIICED;
				Network.Connect(EAPNAIEKKNO, 53003);
			}
			else
			{
				HKEJOCEBBPH();
			}
		}
	}

	private static string HAFKGGPPBOG(string DACLIJPONJK)
	{
		return (DACLIJPONJK.IndexOf('_') != 2) ? DACLIJPONJK : DACLIJPONJK.Substring(3);
	}

	public void CBGCPBJDDIL(bool IBPMLCAGBFG)
	{
	}

	private void KMAEFOAOMLC()
	{
		if (KMDDIKDANBF())
		{
			MPEKGCMDCPK = new RoomInfo[0];
			IMDNCJODAEN = HNDJBFNAIHN.KNFOHBBPPJB;
			PhotonNetwork.Disconnect();
		}
		string text = string.Empty;
		if (PhotonNetwork.connected)
		{
			text = text + FOGIOGKLNIP.FHHPMGJCHJL("Server:") + FOGIOGKLNIP.FHHPMGJCHJL(FOGIOGKLNIP.LPLJMLGKCLK.JAIHLALJHHO) + "\r\n";
		}
		string text2 = text;
		text = text2 + ((!FOGIOGKLNIP.OMMLFOEPEEK) ? string.Empty : (FOGIOGKLNIP.FHHPMGJCHJL(" Users:") + PhotonNetwork.networkingPeer.mPeerCount)) + FOGIOGKLNIP.FHHPMGJCHJL(" Games:") + ALHLOOCKMBE.Length + FOGIOGKLNIP.FHHPMGJCHJL(" Ping:") + (int)FOGIOGKLNIP.LPLJMLGKCLK.FOOCGCIEOIO + "|" + PhotonNetwork.GetPing();
		GUILayout.Label(text, GUILayout.ExpandWidth(expand: true));
		GUILayout.BeginHorizontal();
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		if (FOGIOGKLNIP.MHFCLILDBCM("Host Game"))
		{
			IMDNCJODAEN = HNDJBFNAIHN.EKGBDKEDIKK;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("view all versions", GUILayout.ExpandWidth(expand: false)))
		{
			EAPNAIEKKNO = string.Empty;
			FOGIOGKLNIP.LPLJMLGKCLK.DFDEMPKPIMK.MFEPFODPFHA(1000, 800, "CustomVersions", NBOGOKNEBGI.IPBFPHDFNNH, GIPGFIILFEK);
		}
		GUILayout.Label(FOGIOGKLNIP.FHHPMGJCHJL("Your Rank: ") + FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.ECKDHMKHHJJ);
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		if (FOGIOGKLNIP.MHFCLILDBCM("All", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = string.Empty;
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Custom", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "Custom";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Classic", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "classic";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("TDM", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "TDM";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("ZombieMode", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "ZombieMode";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Jg", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "Juggernaut";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("CTF", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "CTF";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Bots", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "ZombieMatch";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("Survival", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "survival";
		}
		if (FOGIOGKLNIP.MHFCLILDBCM("DeathMatch", GUILayout.ExpandWidth(expand: true)))
		{
			EAPNAIEKKNO = "DeathMatch";
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		EAPNAIEKKNO = FOGIOGKLNIP.ODCONJOFBPD(EAPNAIEKKNO);
		if (FOGIOGKLNIP.MHFCLILDBCM("Refresh", GUILayout.ExpandWidth(expand: false)) || CMEFDJLJODE.NFMIBMIGJMH(7000))
		{
			CJEEMFGNNOH();
		}
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO && FOGIOGKLNIP.MHFCLILDBCM("Connect To Ip", GUILayout.ExpandWidth(expand: false)) && EAPNAIEKKNO != string.Empty)
		{
			LMJDAEDENKN = true;
			IMDNCJODAEN = HNDJBFNAIHN.NFDLEHOMJBC;
		}
		GUILayout.EndHorizontal();
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			FOGIOGKLNIP.IAOONCAPLGK("Your IP Lan:" + Network.player.ipAddress + " Inet:" + ((Network.player.externalIP.Length <= 16) ? Network.player.externalIP : string.Empty) + " udp port:unityPort");
		}
		GUILayout.Label(EMDOLODPFAJ, MBKHABKMDLJ("server"), GUILayout.Width(785f));
		if (ALHLOOCKMBE.Length == 0)
		{
			FOGIOGKLNIP.IAOONCAPLGK("..no games available..");
			return;
		}
		foreach (RoomInfo item in (!FOGIOGKLNIP.DGMBIMMABNO) ? MPEKGCMDCPK : MPEKGCMDCPK.Take(100))
		{
			string text3 = item.format;
			if (item.version != FOGIOGKLNIP.LMMFHEODOPM.DKPGCEABLDP || FOGIOGKLNIP.OMMLFOEPEEK)
			{
				text3 += ((!FOGIOGKLNIP.OMMLFOEPEEK) ? "oldV" : item.version);
			}
			if (item.cantJoin)
			{
				GUILayout.Label(text3, MBKHABKMDLJ("scoreboard"), GUILayout.Width(785f));
			}
			else if (FOGIOGKLNIP.MHFCLILDBCM(text3, MBKHABKMDLJ("server"), GUILayout.Width(785f)))
			{
				IKPDNPCAPOC(item);
			}
		}
	}

	private string PDHIMKOJHBI(string DACLIJPONJK)
	{
		if (CPNIJJCPJPI.TryGetValue(DACLIJPONJK, out var value))
		{
			return value;
		}
		string text = GAPJLIOKIEI(DACLIJPONJK);
		CPNIJJCPJPI[DACLIJPONJK] = text;
		return text;
	}

	private string GAPJLIOKIEI(string DACLIJPONJK)
	{
		MapStats mapStats = FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF.FirstOrDefault((MapStats AEMBPMJMOAB) => FOGIOGKLNIP.GIGJFCBMKMO(AEMBPMJMOAB.mapName) == FOGIOGKLNIP.GIGJFCBMKMO(DACLIJPONJK));
		if (mapStats != null)
		{
			return mapStats.mapName;
		}
		if (Application.CanStreamedLevelBeLoaded(FOGIOGKLNIP.GIGJFCBMKMO(DACLIJPONJK)))
		{
			return DACLIJPONJK;
		}
		return null;
	}

	public static Vector3 ONENCGHKFNI(float NMJFJGHICPH = 1f)
	{
		GUI.enabled = FOGIOGKLNIP.MACJBMALKEB;
		if (Input.GetMouseButtonUp(0) && FOGIOGKLNIP.LPLJMLGKCLK.IBBEADDNCGF > 1f && Event.current.isMouse)
		{
			Event.current.Use();
			FOGIOGKLNIP.BCKENJMGBIJ("Suspend Event");
		}
		float num = (float)Screen.height / (float)Screen.width / (GEMKDDHOGLE / HIHHLPFKIDL);
		JDDEBAANKEA = ((!FOGIOGKLNIP.DGMBIMMABNO) ? Vector3.one : (new Vector3((float)Screen.width / HIHHLPFKIDL * num, (float)Screen.height / GEMKDDHOGLE, 1f) * NMJFJGHICPH));
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, JDDEBAANKEA);
		return JDDEBAANKEA;
	}

	public static bool GJMABEBFKHG(string CFMBOEELBKL)
	{
		RuntimePlatform platform = Application.platform;
		string text = CFMBOEELBKL.ToLower();
		return (!FOGIOGKLNIP.DGMBIMMABNO) ? text.EndsWith("standalonewindowsu4") : text.EndsWith("androidu4");
	}

	internal void IKPDNPCAPOC(RoomInfo LECNOMGBOAK)
	{
		if (LECNOMGBOAK == null)
		{
			return;
		}
		string[] sets = LECNOMGBOAK.sets;
		if (LECNOMGBOAK.LowPingNeeded() || LECNOMGBOAK.playerCount == LECNOMGBOAK.maxPlayers)
		{
			return;
		}
		JDFKPOMKMNJ.GFJGDEKLFNB();
		BIHOCPAKHNF("Trying Connect to " + LECNOMGBOAK.name);
		CBGCPBJDDIL(IBPMLCAGBFG: true);
		FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF = PDHIMKOJHBI(sets[0]) ?? sets[0];
		FOGIOGKLNIP.PBADCKNDABE(string.Empty, FOGIOGKLNIP.FHHPMGJCHJL("Connecting"), "Cancel", MMJNLLMFOCD: true);
		StartCoroutine(HOOPCODDBGJ(delegate
		{
			try
			{
				string text = LECNOMGBOAK.name;
				string[] array = text.Split(new char[1] { '|' }, 2);
				FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO = LECNOMGBOAK.mapName + " " + array[1] + UnityEngine.Random.Range(10, 99);
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
				FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO = LECNOMGBOAK.name;
			}
			if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
			{
				Network.Connect(LECNOMGBOAK.hostdata);
			}
			else
			{
				PhotonNetwork.JoinRoom(LECNOMGBOAK.name);
			}
		}));
	}

	public IEnumerable<RoomInfo> HEDLJMAJJPN()
	{
		string[] array = EAPNAIEKKNO.Split(new char[2] { ' ', '*' }, StringSplitOptions.RemoveEmptyEntries);
		RoomInfo[] aLHLOOCKMBE = ALHLOOCKMBE;
		foreach (RoomInfo LECNOMGBOAK in aLHLOOCKMBE)
		{
			LECNOMGBOAK.sortAdd = 0f;
			try
			{
				if (array.Length != 0 && !array.All((string LCBKHLLPIGM) => LECNOMGBOAK.name.ToLower().Contains(LCBKHLLPIGM.ToLower())))
				{
					continue;
				}
				string[] sets = LECNOMGBOAK.sets;
				if (sets.Length < 4 || FOGIOGKLNIP.LPLJMLGKCLK.MLCAJKEMIIB.Contains(sets[0]) || sets[1].CompareTo(FOGIOGKLNIP.LMMFHEODOPM.DKPGCEABLDP) > 0 || sets[1].CompareTo(FOGIOGKLNIP.LMMFHEODOPM.HKAGPIIOKEP) < 0)
				{
					continue;
				}
				bool flag = string.IsNullOrEmpty(EAPNAIEKKNO) || !sets[2].ToLower().StartsWith(EAPNAIEKKNO.ToLower());
				if (sets[3].Contains("HideRoom") && flag)
				{
					continue;
				}
				if (LECNOMGBOAK.Noobs)
				{
					LECNOMGBOAK.sortAdd -= 20f;
					if (FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.JDDGBFOOCHE > 1f)
					{
						LECNOMGBOAK.sortAdd += 1000f;
					}
				}
				if (PDHIMKOJHBI(sets[0]) == null)
				{
					LECNOMGBOAK.sortAdd += 9999f;
					LECNOMGBOAK.mapNotFound = true;
				}
				if (LECNOMGBOAK.custom)
				{
					LECNOMGBOAK.sortAdd += 200f;
				}
				if (HKIKLNKHPEP(sets[0]) && (sets[5].Contains("Survival") || sets[5].Contains("ZombieMatch")))
				{
					continue;
				}
				if (sets[3].Contains("LowPing") && !FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
				{
					LECNOMGBOAK.sortAdd -= ((!(FOGIOGKLNIP.LPLJMLGKCLK.FOOCGCIEOIO < 100f)) ? (-50) : 10);
				}
				if (LECNOMGBOAK.android)
				{
					LECNOMGBOAK.sortAdd -= ((!FOGIOGKLNIP.DGMBIMMABNO) ? (-1000) : 1000);
				}
				LECNOMGBOAK.rank = float.Parse(sets[4]);
				LECNOMGBOAK.format = string.Format(FPPKONKNAHD, FOGIOGKLNIP.FHHPMGJCHJL(FOGIOGKLNIP.GIGJFCBMKMO(sets[0])), sets[2], sets[5], LECNOMGBOAK.playerCount + "/" + LECNOMGBOAK.maxPlayers, sets[3]);
				goto IL_03f5;
			}
			catch (Exception message)
			{
				UnityEngine.Debug.LogError(message);
			}
			continue;
			IL_03f5:
			yield return LECNOMGBOAK;
		}
	}

	public static IEnumerable<T> OECOCEJFIBK<T>(IEnumerable<T> DFLMIFIEJBF, IEnumerable<T> EOMIHAJEFKN)
	{
		IEnumerator<T> enumerator = DFLMIFIEJBF.GetEnumerator();
		try
		{
			IEnumerator<T> enumerator2 = EOMIHAJEFKN.GetEnumerator();
			try
			{
				while (true)
				{
					bool flag;
					bool flag2 = (flag = enumerator.MoveNext());
					bool num = flag;
					bool flag3 = (flag = enumerator2.MoveNext());
					if (num || flag)
					{
						if (flag2)
						{
							yield return enumerator.Current;
						}
						if (flag3)
						{
							yield return enumerator2.Current;
						}
						continue;
					}
					break;
				}
			}
			finally
			{
				((LJCBMJKPPBI<T>)(object)this).OKOKNFKILLM();
			}
		}
		finally
		{
			((LJCBMJKPPBI<T>)(object)this).OHAOFHKBECL();
		}
	}

	private IEnumerator HOOPCODDBGJ(Action GLBBNCPKGOL)
	{
		if (!LHAOFNHHJEN)
		{
			Queue<string> queue = new Queue<string>();
			if (Application.platform != RuntimePlatform.WebGLPlayer || Application.isEditor)
			{
				queue.Enqueue("file:///" + Directory.GetCurrentDirectory() + NCGNCLMDIKB.HJAAHJGBEHB + FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF);
			}
			string JFAJOKLCJND = FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF.Replace(" ", "%20");
			queue.Enqueue(JFAJOKLCJND);
			JFAJOKLCJND = Path.GetFileName(JFAJOKLCJND);
			foreach (string item in OECOCEJFIBK(FOGIOGKLNIP.LMMFHEODOPM.LMPHJCDENFF, FOGIOGKLNIP.LMMFHEODOPM.IDHMKKBEBCG))
			{
				queue.Enqueue(item + JFAJOKLCJND);
			}
			FOGIOGKLNIP.LPLJMLGKCLK.HHHPAGPAPPF = true;
			{
				foreach (string item2 in queue)
				{
					if (HKIKLNKHPEP(JFAJOKLCJND))
					{
						ILJOBCIBPBJ = new WWW(item2);
					}
					else
					{
						ILJOBCIBPBJ = WWW.LoadFromCacheOrDownload(item2, (from AEMBPMJMOAB in FOGIOGKLNIP.HJLAMDIBCDO.APLCCBLHMIF
							where AEMBPMJMOAB.mapName == JFAJOKLCJND
							select AEMBPMJMOAB.Version).FirstOrDefault());
					}
					FOGIOGKLNIP.LPLJMLGKCLK.NEJPKFAKOGO = item2;
					MonoBehaviour.print(item2);
					yield return ILJOBCIBPBJ;
					if (string.IsNullOrEmpty(ILJOBCIBPBJ.error))
					{
						ILJOBCIBPBJ.assetBundle.GetAllScenePaths();
						if (LHAOFNHHJEN)
						{
							FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = base.FKICDOGJIFN.LoaderGuiMapLoadedConnecting;
							GLBBNCPKGOL();
							break;
						}
						FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = base.FKICDOGJIFN.LoaderGuiMapLoadingFailed;
					}
					else
					{
						MonoBehaviour.print(ILJOBCIBPBJ.error);
						FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = base.FKICDOGJIFN.ErrorText + ":" + ILJOBCIBPBJ.error;
					}
				}
				yield break;
			}
		}
		GLBBNCPKGOL();
	}

	public static bool HKIKLNKHPEP(string JFAJOKLCJND)
	{
		if (EHANJAPCFDA.TryGetValue(JFAJOKLCJND, out var value))
		{
			return value;
		}
		bool flag = JFAJOKLCJND.EndsWith("dae", StringComparison.CurrentCultureIgnoreCase);
		EHANJAPCFDA[JFAJOKLCJND] = flag;
		return flag;
	}

	internal void HKEJOCEBBPH()
	{
		CBGCPBJDDIL(IBPMLCAGBFG: true);
		MODHLLKJAGK = false;
		string text = string.Empty;
		if (FOGIOGKLNIP.LPLJMLGKCLK.GEIGNOAKBEP)
		{
			text += "Noobs ";
		}
		if (FOGIOGKLNIP.LMMFHEODOPM.DEMKLLPLDBO)
		{
			text += "Custom ";
		}
		text += (INDHPOGAJEK ? "HideRoom" : (MODHLLKJAGK ? "Android" : ((FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO || !GPFEHBMCMML || !(FOGIOGKLNIP.LPLJMLGKCLK.FOOCGCIEOIO < 100f)) ? " " : "LowPing")));
		string text2 = FOGIOGKLNIP.LPLJMLGKCLK.NDFPLDPNNMG + "(" + FOGIOGKLNIP.LPLJMLGKCLK.ALOMJBBEPNK + ")";
		JDFKPOMKMNJ.GFJGDEKLFNB();
		FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO = string.Concat(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF, "|", FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP, "|", text2, "|", text, "|", FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.ECKDHMKHHJJ, "|", FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD, "|", UnityEngine.Random.Range(10, 99));
		FOGIOGKLNIP.PBADCKNDABE(string.Empty, "Initializing server", "Cancel");
		StartCoroutine(HOOPCODDBGJ(delegate
		{
			BIHOCPAKHNF(FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO);
			UnityEngine.Debug.Log(FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO);
			if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
			{
				Network.InitializeServer((int)BOFMJFANLDN - 1, 53003, useNat: true);
				if (!base.JNPCOJFBJGP)
				{
					MasterServer.RegisterHost("csport", FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO);
				}
			}
			else
			{
				PhotonNetwork.CreateRoom(FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO, isVisible: true, isOpen: true, (byte)Mathf.Min(64f, BOFMJFANLDN));
			}
		}));
	}

	public void OnServerInitialized()
	{
		MPJGBJBIKGK();
	}

	public void OnConnectedToServer()
	{
		MPJGBJBIKGK();
	}

	public void OnCreatedRoom()
	{
		MPJGBJBIKGK();
	}

	public void OnJoinedRoom()
	{
		MPJGBJBIKGK();
	}

	private static void MPJGBJBIKGK()
	{
		bool isMessageQueueRunning = (PhotonNetwork.isMessageQueueRunning = false);
		Network.isMessageQueueRunning = isMessageQueueRunning;
		FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = "Connected, Starting";
		if (HKIKLNKHPEP(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF))
		{
			SceneManager.LoadScene("2");
			return;
		}
		FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ = null;
		FOGIOGKLNIP.LPLJMLGKCLK.JDFKPOMKMNJ.IPBKDPKONHH(delegate
		{
			if (FOGIOGKLNIP.PIOANBBCFFP == null)
			{
				Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
				foreach (Camera camera in array)
				{
					UnityEngine.Object.Destroy(camera.gameObject);
				}
				SceneManager.LoadScene("1", LoadSceneMode.Additive);
			}
		});
		SceneManager.LoadScene(FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF));
	}

	public void OnPhotonCreateRoomFailed()
	{
		BIHOCPAKHNF("Same Room Already Exists");
		CBGCPBJDDIL(IBPMLCAGBFG: false);
	}

	public void OnConnectedToPhoton()
	{
		CLEIHBGGHMD("Connected To Photon");
		MPEKGCMDCPK = new RoomInfo[0];
		IMDNCJODAEN = HNDJBFNAIHN.MAJHJGIICED;
	}

	public void OnDisconnectedFromPhoton()
	{
		UnityEngine.Debug.Log("OnDisconnectedFromPhoton");
		if (!FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			ALHLOOCKMBE = (MPEKGCMDCPK = new RoomInfo[0]);
			IMDNCJODAEN = HNDJBFNAIHN.KNFOHBBPPJB;
		}
	}

	public void OnPhotonRandomJoinFailed()
	{
		BIHOCPAKHNF("Failled to connect to room");
		CBGCPBJDDIL(IBPMLCAGBFG: false);
	}

	public void KLBEKGMLPBF()
	{
		BIHOCPAKHNF("Failled to connect to room");
		FOGIOGKLNIP.PBADCKNDABE("Error", "Failed to connect room is full");
		CBGCPBJDDIL(IBPMLCAGBFG: false);
	}

	public void OnPhotonJoinRoomFailed()
	{
		BIHOCPAKHNF("Failled to connect to room");
		FOGIOGKLNIP.PBADCKNDABE("Error", "Failed to connect room is full");
		CBGCPBJDDIL(IBPMLCAGBFG: false);
	}

	public void OnFailedToConnect(NetworkConnectionError JBBAPHBEMJH)
	{
		IMDNCJODAEN = HNDJBFNAIHN.MAJHJGIICED;
	}

	public void OnFailedToConnectToPhoton()
	{
		FOGIOGKLNIP.PBADCKNDABE("Error", "Failed connect to server");
		if (PhotonNetwork.connectionState != ConnectionState.Connected)
		{
			IMDNCJODAEN = HNDJBFNAIHN.KNFOHBBPPJB;
		}
	}

	public Rect BHFCKHGDILG(Rect PHKEAHANGAM)
	{
		return new Rect(PHKEAHANGAM.x * (float)Screen.width, PHKEAHANGAM.y * (float)Screen.height, PHKEAHANGAM.width * (float)Screen.width, PHKEAHANGAM.height * (float)Screen.height);
	}

	public IEnumerator JKNEGIJLLBL()
	{
		if (!FOGIOGKLNIP.DGMBIMMABNO)
		{
			yield break;
		}
		if (Application.platform == RuntimePlatform.WebGLPlayer)
		{
			yield return new WaitForSeconds(1f);
		}
		WWW wWW = new WWW("https://www.facebook.com/feeds/page.php?id=353139408102161&format=json");
		yield return wWW;
		EINANNDCPED.Clear();
		MonoBehaviour.print(wWW.url);
		if (FOGIOGKLNIP.LMMFHEODOPM.ICOMKPIKMDK)
		{
			yield break;
		}
		IEnumerable enumerable = FIMHPILFGIN.AAPLAPBIFMD(wWW.text).HJAHPOJLNAA("entries");
		foreach (FLFCPGBMGHH item in enumerable)
		{
			FLFCPGBMGHH fLFCPGBMGHH2 = item.HJAHPOJLNAA("title");
			if (fLFCPGBMGHH2 != null)
			{
				Posts posts = new Posts();
				EINANNDCPED.Add(posts);
				posts.id = item.HJAHPOJLNAA("id").ToString();
				posts.link = item.HJAHPOJLNAA("alternate").ToString();
				posts.date = DateTime.Parse(item.HJAHPOJLNAA("updated").ToString());
				posts.msg = string.Concat(fLFCPGBMGHH2, string.Empty);
				StartCoroutine(posts.DHBGHDFFOLN());
			}
		}
	}

	private void JKNLEFFAMOD()
	{
		if (!FOGIOGKLNIP.DGMBIMMABNO)
		{
			return;
		}
		LOADKHHJCDK.x = 10f;
		LOADKHHJCDK = GUILayout.BeginScrollView(LOADKHHJCDK);
		foreach (Posts item in EINANNDCPED)
		{
			GUILayout.Space(10f);
			GUILayout.BeginVertical(item.date.ToShortDateString() + " " + item.title, FOGIOGKLNIP.LPLJMLGKCLK.EPDKDICMOHH.box);
			GUILayout.Label(new GUIContent(item.image));
			GUILayout.Label(new GUIContent(item.msg));
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			if (FOGIOGKLNIP.MHFCLILDBCM("Comment"))
			{
				string text = string.Format(item.link, item.id);
				if (Application.platform == RuntimePlatform.WebGLPlayer)
				{
					Application.ExternalEval($"window.top.location = '{text}';");
				}
				else
				{
					Application.OpenURL(text);
				}
			}
			GUILayout.EndHorizontal();
			GUILayout.EndVertical();
		}
		GUILayout.EndArea();
	}

	[CompilerGenerated]
	private static void OLGHFPJMJPC(string KLLKONMADKA)
	{
		string[] array = KLLKONMADKA.Split(new char[1] { '\n' }, StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].StartsWith("APPID:"))
			{
				UnityEngine.Debug.LogWarning("GetID");
				FOGIOGKLNIP.LMMFHEODOPM.MMHLHLOBIMI[i] = array[i].Replace("APPID:", string.Empty).Trim('\r');
			}
			else
			{
				UnityEngine.Debug.LogWarning("NotFoundID");
			}
		}
	}

	[CompilerGenerated]
	private static bool OFDNCJFPFDI(Dictionary AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.code == FOGIOGKLNIP.LPLJMLGKCLK.IIGIKNBFIKL.ToUpper();
	}

	[CompilerGenerated]
	private void NHMHEHNPNKF(string KLLKONMADKA)
	{
		StartCoroutine(FIDPFKBPFCH(KLLKONMADKA));
	}

	[CompilerGenerated]
	private void GIDOCNFHMPA(string KLLKONMADKA)
	{
		string[] array = KLLKONMADKA.Split(',');
		int num = ((Application.platform == RuntimePlatform.WebGLPlayer || Application.platform == RuntimePlatform.WindowsPlayer) ? 1 : ((Application.platform == RuntimePlatform.Android) ? 2 : ((Application.platform != RuntimePlatform.IPhonePlayer) ? 4 : 3)));
		FOGIOGKLNIP.LPLJMLGKCLK.MHCPDOOKBCM = array[num];
		if (string.Compare(FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP, FOGIOGKLNIP.LPLJMLGKCLK.MHCPDOOKBCM, StringComparison.OrdinalIgnoreCase) < 0)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.LoaderGuiNewVersionAvailable) + array[num] + base.FKICDOGJIFN.LoaderGuiYourVersion + FOGIOGKLNIP.LPLJMLGKCLK.DKPGCEABLDP;
		}
	}

	[CompilerGenerated]
	private static void JGJOAAHFBNH(string KLLKONMADKA)
	{
		FOGIOGKLNIP.HJLAMDIBCDO.NFLLOBGKLLO = KLLKONMADKA.Split2();
	}

	[CompilerGenerated]
	private static string INBPLMFJMHC(RoomInfo AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.version;
	}

	[CompilerGenerated]
	private static float LEBJLBMPMAD(RoomInfo AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.sortAdd;
	}

	[CompilerGenerated]
	private static int EKFPOAKPNHH(RoomInfo AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.playerCount;
	}

	[CompilerGenerated]
	private static int KLOPHJGHPCI(RoomInfo AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.groupCount;
	}

	[CompilerGenerated]
	private static int GAGBOPCLBMO(RoomInfo AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.playerCount;
	}

	[CompilerGenerated]
	private static bool FCJKIOGCABH(RoomInfo AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.maxPlayers - AEMBPMJMOAB.playerCount > 1 && AEMBPMJMOAB.sets[5] == IMCJHBIFEAK.Classic.ToString();
	}

	[CompilerGenerated]
	private static string JMEPOENLGII(RoomInfo AEMBPMJMOAB)
	{
		string[] array = AEMBPMJMOAB.name.Split('|');
		if (array.Length < 2)
		{
			array = AEMBPMJMOAB.name.Split('/');
		}
		if (array.Length < 2)
		{
			return "unknown";
		}
		return array[1];
	}

	[CompilerGenerated]
	private static void BHLJKBACDIC(string GDKFLGBMPBB)
	{
		FOGIOGKLNIP.LPLJMLGKCLK.KKECGAFLPLJ = GDKFLGBMPBB;
	}

	[CompilerGenerated]
	private static bool EKFOCHKMOFC()
	{
		return !PhotonNetwork.connected;
	}

	[CompilerGenerated]
	private static int DIMGKNFCDPI(MapStats AEMBPMJMOAB)
	{
		return (AEMBPMJMOAB.local || AEMBPMJMOAB.featured) ? 1 : 0;
	}

	[CompilerGenerated]
	private static int ONBNJFLGLKA(MapStats AEMBPMJMOAB)
	{
		return (!AEMBPMJMOAB.local && !AEMBPMJMOAB.featured) ? AEMBPMJMOAB.date : FOGIOGKLNIP.ICLENOJCEGB;
	}

	[CompilerGenerated]
	private static bool DHMODCHJKLD(MapStats AEMBPMJMOAB)
	{
		return AEMBPMJMOAB.IsDev;
	}

	[CompilerGenerated]
	private static void CDNKBDEAKLF()
	{
		GUILayout.Label("Enter maps location directory with .unity3d files types");
		NCGNCLMDIKB.HJAAHJGBEHB = GUILayout.TextField(NCGNCLMDIKB.HJAAHJGBEHB);
		if (FOGIOGKLNIP.MHFCLILDBCM("Setup"))
		{
			try
			{
				Directory.CreateDirectory(NCGNCLMDIKB.HJAAHJGBEHB);
				FOGIOGKLNIP.BEHFNEAKDAL.FCMPPIBMPGO(IBPMLCAGBFG: true);
			}
			catch (Exception ex)
			{
				FOGIOGKLNIP.PBADCKNDABE(ex.ToString());
			}
			FOGIOGKLNIP.GLNAMCPCICH.DLILAHLOKKC();
		}
	}

	[CompilerGenerated]
	private static bool LKGDHMCLMNO(MapStats AEMBPMJMOAB)
	{
		return !AEMBPMJMOAB.IsDev;
	}

	[CompilerGenerated]
	private static bool CKCEJNFFGLK(MapStats AEMBPMJMOAB)
	{
		return !AEMBPMJMOAB.IsDev;
	}

	[CompilerGenerated]
	private void IHMNODCFKJO()
	{
		BIHOCPAKHNF(FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO);
		UnityEngine.Debug.Log(FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO);
		if (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO)
		{
			Network.InitializeServer((int)BOFMJFANLDN - 1, 53003, useNat: true);
			if (!base.JNPCOJFBJGP)
			{
				MasterServer.RegisterHost("csport", FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO);
			}
		}
		else
		{
			PhotonNetwork.CreateRoom(FOGIOGKLNIP.LPLJMLGKCLK.NHFIJHBHCGO, isVisible: true, isOpen: true, (byte)Mathf.Min(64f, BOFMJFANLDN));
		}
	}

	[CompilerGenerated]
	private static void ILCAPHDHGLC()
	{
		if (FOGIOGKLNIP.PIOANBBCFFP == null)
		{
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			foreach (Camera camera in array)
			{
				UnityEngine.Object.Destroy(camera.gameObject);
			}
			SceneManager.LoadScene("1", LoadSceneMode.Additive);
		}
	}
}
