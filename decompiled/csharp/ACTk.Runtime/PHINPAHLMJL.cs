using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

[DisallowMultipleComponent]
[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_wall_hack_detector.html")]
public class PHINPAHLMJL : global::OKIEDJFCLOA<PHINPAHLMJL>
{
	public const string DKKPFCBJAAO = "WallHack Detector";

	internal const string ECHFMJKEMLH = "[ACTk] WallHack Detector: ";

	internal const string HAJGKLCCKKD = "Hidden/ACTk/WallHackTexture";

	private const string CIIGCFMBHJM = "[WH Detector Service]";

	private const int GHBMOLFOLHG = 4;

	private const int DMPBBHAPIOD = 4;

	private const int ACCLNONJPCE = 5;

	private readonly Vector3 OKHDNNFKILE = new Vector3(0f, 0f, 1f);

	private readonly WaitForEndOfFrame FAJBDFGINIO = new WaitForEndOfFrame();

	[SerializeField]
	[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
	private bool checkRigidbody = true;

	[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
	[SerializeField]
	private bool checkController = true;

	[Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
	[SerializeField]
	private bool checkWireframe = true;

	[Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
	[SerializeField]
	private bool checkRaycast = true;

	[Range(1f, 60f)]
	[Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
	public int BJCPEGBGHPH = 10;

	[Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
	[Range(1f, 60f)]
	public int ODEPOLDLHMF = 10;

	[Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
	public Vector3 DMOKLHJELOF;

	[Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
	public byte JFDACACAECG = 3;

	private GameObject CCEBMLDFLFF;

	private GameObject BMECDGKBELJ;

	private GameObject IDDJDOBBNDA;

	private Camera CPNBOCBEONJ;

	private MeshRenderer BEPKECLFIDJ;

	private MeshRenderer MMMPEOBFGPN;

	private Color KBEPHLHKCEK = Color.black;

	private Color AELMGFKMCFA = Color.black;

	private Shader PKOLJHGDKLB;

	private Material MDHNGOCOILD;

	private Texture2D MIIBCJJHFPI;

	private Texture2D IFJENBAFEKL;

	private RenderTexture FMBIMIAEOHH;

	private int MGGPINHFAMH = -1;

	private int IPGIENBNMOP = -1;

	private Rigidbody KKNEAEPGKFF;

	private CharacterController FEFLPKPENGK;

	private float HMIJHPBOMKN;

	private byte BOCNMNNGPOD;

	private byte ONCFNCAIJPB;

	private byte MPIHGDCDJIJ;

	private byte GLAIOGJANGG;

	private bool NAHJALPEEAJ;

	private readonly RaycastHit[] OJHLIELOKIN = new RaycastHit[10];

	public bool OIOLDHHBJAP
	{
		get
		{
			return checkRigidbody;
		}
		set
		{
			if (checkRigidbody == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			checkRigidbody = value;
			if (BFDIKKENINF)
			{
				CMCDECNJCFP();
				if (checkRigidbody)
				{
					APCHMMNGKBI();
				}
				else
				{
					GFHLMJPPPJF();
				}
			}
		}
	}

	public bool FGCCFJPOKOJ
	{
		get
		{
			return checkController;
		}
		set
		{
			if (checkController == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			checkController = value;
			if (BFDIKKENINF)
			{
				CMCDECNJCFP();
				if (checkController)
				{
					AANAFNAAKCK();
				}
				else
				{
					FHAFCCMHHDJ();
				}
			}
		}
	}

	public bool EPKENJMGGLJ
	{
		get
		{
			return checkWireframe;
		}
		set
		{
			if (checkWireframe == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			checkWireframe = value;
			if (BFDIKKENINF)
			{
				CMCDECNJCFP();
				if (checkWireframe)
				{
					KCDGMIGADHG();
				}
				else
				{
					GNFJJBGDCGO();
				}
			}
		}
	}

	public bool CDBPNLIMEGD
	{
		get
		{
			return checkRaycast;
		}
		set
		{
			if (checkRaycast == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			checkRaycast = value;
			if (BFDIKKENINF)
			{
				CMCDECNJCFP();
				if (checkRaycast)
				{
					JNBNMOFIDKC();
				}
				else
				{
					JHMCFGAONIJ();
				}
			}
		}
	}

	private PHINPAHLMJL()
	{
	}

	public static PHINPAHLMJL GFMJMLPFMCH()
	{
		return global::FOKPNHICOOH<PHINPAHLMJL>.AAANLLGDCHM;
	}

	public static PHINPAHLMJL DEEHLMMJMLA()
	{
		if (global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA != null)
		{
			return global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA.APJJFPIOGKN(null, global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA.DMOKLHJELOF, global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA.JFDACACAECG);
		}
		Debug.LogError("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		return null;
	}

	public static PHINPAHLMJL DEEHLMMJMLA(Action JLNCPFNPKMM)
	{
		return DEEHLMMJMLA(JLNCPFNPKMM, global::FOKPNHICOOH<PHINPAHLMJL>.AAANLLGDCHM.DMOKLHJELOF);
	}

	public static PHINPAHLMJL DEEHLMMJMLA(Action JLNCPFNPKMM, Vector3 DMOKLHJELOF)
	{
		return DEEHLMMJMLA(JLNCPFNPKMM, DMOKLHJELOF, global::FOKPNHICOOH<PHINPAHLMJL>.AAANLLGDCHM.JFDACACAECG);
	}

	public static PHINPAHLMJL DEEHLMMJMLA(Action JLNCPFNPKMM, Vector3 DMOKLHJELOF, byte JFDACACAECG)
	{
		return global::FOKPNHICOOH<PHINPAHLMJL>.AAANLLGDCHM.APJJFPIOGKN(JLNCPFNPKMM, DMOKLHJELOF, JFDACACAECG);
	}

	public static void PNAGMICMAKL()
	{
		if (global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA.CNIPMALICAE();
		}
	}

	public static void MABNJHGIDLH()
	{
		if (global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA != null)
		{
			global::FOKPNHICOOH<PHINPAHLMJL>.KHGDLGJPCCA.CBPNHEBFOFH();
		}
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		StopAllCoroutines();
		if (CCEBMLDFLFF != null)
		{
			UnityEngine.Object.Destroy(CCEBMLDFLFF);
		}
		if (MDHNGOCOILD != null)
		{
			MDHNGOCOILD.mainTexture = null;
			MDHNGOCOILD.shader = null;
			MDHNGOCOILD = null;
			PKOLJHGDKLB = null;
			MIIBCJJHFPI = null;
			IFJENBAFEKL = null;
			FMBIMIAEOHH.DiscardContents();
			FMBIMIAEOHH.Release();
			FMBIMIAEOHH = null;
		}
		HKLKGKLDJAM--;
	}

	private void FixedUpdate()
	{
		if (CDOJMHCPDCB && checkRigidbody && !(KKNEAEPGKFF == null) && KKNEAEPGKFF.transform.localPosition.z > 1f)
		{
			BOCNMNNGPOD++;
			if (!IHBJLLLFJEL())
			{
				GFHLMJPPPJF();
				APCHMMNGKBI();
			}
		}
	}

	private void Update()
	{
		if (!CDOJMHCPDCB || !checkController || FEFLPKPENGK == null || !(HMIJHPBOMKN > 0f))
		{
			return;
		}
		FEFLPKPENGK.Move(new Vector3(UnityEngine.Random.Range(-0.002f, 0.002f), 0f, HMIJHPBOMKN));
		if (FEFLPKPENGK.transform.localPosition.z > 1f)
		{
			ONCFNCAIJPB++;
			if (!IHBJLLLFJEL())
			{
				FHAFCCMHHDJ();
				AANAFNAAKCK();
			}
		}
	}

	private PHINPAHLMJL APJJFPIOGKN(Action JLNCPFNPKMM, Vector3 CFLEJCLEDCB, byte DIAEDEOJJII)
	{
		if (CDOJMHCPDCB)
		{
			Debug.LogWarning("[ACTk] WallHack Detector: already running!", this);
			return this;
		}
		if (!base.enabled)
		{
			Debug.LogWarning("[ACTk] WallHack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
			return this;
		}
		if (JLNCPFNPKMM != null && detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] WallHack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
		}
		if (JLNCPFNPKMM == null && !detectionEventHasListener)
		{
			Debug.LogWarning("[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
			base.enabled = false;
			return this;
		}
		base.BJAAEHCDEFB += JLNCPFNPKMM;
		DMOKLHJELOF = CFLEJCLEDCB;
		JFDACACAECG = DIAEDEOJJII;
		BOCNMNNGPOD = 0;
		ONCFNCAIJPB = 0;
		MPIHGDCDJIJ = 0;
		GLAIOGJANGG = 0;
		StartCoroutine(PECONNFBGMM());
		BFDIKKENINF = true;
		CDOJMHCPDCB = true;
		return this;
	}

	protected override void IHNNAFKGGMO()
	{
		APJJFPIOGKN(null, DMOKLHJELOF, JFDACACAECG);
	}

	protected override void MNGJCENJLOC()
	{
		if (CDOJMHCPDCB)
		{
			base.MNGJCENJLOC();
			GFHLMJPPPJF();
			FHAFCCMHHDJ();
			GNFJJBGDCGO();
			JHMCFGAONIJ();
		}
	}

	protected override bool INJJKIJPBBG()
	{
		if (!base.INJJKIJPBBG())
		{
			return false;
		}
		if (checkRigidbody)
		{
			APCHMMNGKBI();
		}
		if (checkController)
		{
			AANAFNAAKCK();
		}
		if (checkWireframe)
		{
			KCDGMIGADHG();
		}
		if (checkRaycast)
		{
			JNBNMOFIDKC();
		}
		return true;
	}

	protected override void CNIPMALICAE()
	{
		if (BFDIKKENINF)
		{
			MNGJCENJLOC();
		}
		base.CNIPMALICAE();
	}

	protected override string NBJPADKALNN()
	{
		return "WallHack Detector";
	}

	private void CMCDECNJCFP()
	{
		if (base.enabled && base.gameObject.activeSelf)
		{
			if (MGGPINHFAMH == -1)
			{
				MGGPINHFAMH = LayerMask.NameToLayer("Ignore Raycast");
			}
			if (IPGIENBNMOP == -1)
			{
				IPGIENBNMOP = LayerMask.GetMask("Ignore Raycast");
			}
			if (CCEBMLDFLFF == null)
			{
				CCEBMLDFLFF = new GameObject("[WH Detector Service]");
				CCEBMLDFLFF.layer = MGGPINHFAMH;
				CCEBMLDFLFF.transform.position = DMOKLHJELOF;
				UnityEngine.Object.DontDestroyOnLoad(CCEBMLDFLFF);
			}
			if ((checkRigidbody || checkController) && BMECDGKBELJ == null)
			{
				BMECDGKBELJ = new GameObject("SolidWall");
				BMECDGKBELJ.AddComponent<BoxCollider>();
				BMECDGKBELJ.layer = MGGPINHFAMH;
				BMECDGKBELJ.transform.parent = CCEBMLDFLFF.transform;
				BMECDGKBELJ.transform.localScale = new Vector3(3f, 3f, 0.5f);
				BMECDGKBELJ.transform.localPosition = Vector3.zero;
			}
			else if (!checkRigidbody && !checkController && BMECDGKBELJ != null)
			{
				UnityEngine.Object.Destroy(BMECDGKBELJ);
			}
			if (checkWireframe && CPNBOCBEONJ == null)
			{
				if (PKOLJHGDKLB == null)
				{
					PKOLJHGDKLB = Shader.Find("Hidden/ACTk/WallHackTexture");
				}
				if (PKOLJHGDKLB == null)
				{
					Debug.LogError("[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Anti-Cheat Toolkit Settings.", this);
					checkWireframe = false;
				}
				else if (!PKOLJHGDKLB.isSupported)
				{
					Debug.LogWarning("[ACTk] WallHack Detector: can't detect wireframe cheats on this platform due to lack of needed shader support!", this);
					checkWireframe = false;
				}
				else
				{
					if (KBEPHLHKCEK == Color.black)
					{
						KBEPHLHKCEK = BABAEIMBFKG();
						do
						{
							AELMGFKMCFA = BABAEIMBFKG();
						}
						while (PKMKIHEAKKG(KBEPHLHKCEK, AELMGFKMCFA, 10));
					}
					if (MIIBCJJHFPI == null)
					{
						MIIBCJJHFPI = new Texture2D(4, 4, TextureFormat.RGB24, mipmap: false, linear: false);
						MIIBCJJHFPI.filterMode = FilterMode.Point;
						Color[] array = new Color[16];
						for (int i = 0; i < 16; i++)
						{
							if (i < 8)
							{
								ref Color reference = ref array[i];
								reference = KBEPHLHKCEK;
							}
							else
							{
								ref Color reference2 = ref array[i];
								reference2 = AELMGFKMCFA;
							}
						}
						MIIBCJJHFPI.SetPixels(array, 0);
						MIIBCJJHFPI.Apply();
					}
					if (FMBIMIAEOHH == null)
					{
						FMBIMIAEOHH = new RenderTexture(4, 4, 24, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
						FMBIMIAEOHH.autoGenerateMips = false;
						FMBIMIAEOHH.filterMode = FilterMode.Point;
						FMBIMIAEOHH.Create();
					}
					if (IFJENBAFEKL == null)
					{
						IFJENBAFEKL = new Texture2D(4, 4, TextureFormat.RGB24, mipmap: false, linear: false);
						IFJENBAFEKL.filterMode = FilterMode.Point;
					}
					if (MDHNGOCOILD == null)
					{
						MDHNGOCOILD = new Material(PKOLJHGDKLB);
						MDHNGOCOILD.mainTexture = MIIBCJJHFPI;
					}
					if (BEPKECLFIDJ == null)
					{
						GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
						UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
						gameObject.name = "WireframeFore";
						gameObject.layer = MGGPINHFAMH;
						gameObject.transform.parent = CCEBMLDFLFF.transform;
						gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
						BEPKECLFIDJ = gameObject.GetComponent<MeshRenderer>();
						BEPKECLFIDJ.sharedMaterial = MDHNGOCOILD;
						BEPKECLFIDJ.shadowCastingMode = ShadowCastingMode.Off;
						BEPKECLFIDJ.receiveShadows = false;
						BEPKECLFIDJ.enabled = false;
					}
					if (MMMPEOBFGPN == null)
					{
						GameObject gameObject2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
						UnityEngine.Object.Destroy(gameObject2.GetComponent<MeshCollider>());
						gameObject2.name = "WireframeBack";
						gameObject2.layer = MGGPINHFAMH;
						gameObject2.transform.parent = CCEBMLDFLFF.transform;
						gameObject2.transform.localPosition = new Vector3(0f, 0f, 1f);
						gameObject2.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
						MMMPEOBFGPN = gameObject2.GetComponent<MeshRenderer>();
						MMMPEOBFGPN.sharedMaterial = MDHNGOCOILD;
						MMMPEOBFGPN.shadowCastingMode = ShadowCastingMode.Off;
						MMMPEOBFGPN.receiveShadows = false;
						MMMPEOBFGPN.enabled = false;
					}
					CPNBOCBEONJ = new GameObject("WireframeCamera").AddComponent<Camera>();
					CPNBOCBEONJ.cameraType = CameraType.Preview;
					CPNBOCBEONJ.gameObject.layer = MGGPINHFAMH;
					CPNBOCBEONJ.transform.parent = CCEBMLDFLFF.transform;
					CPNBOCBEONJ.transform.localPosition = new Vector3(0f, 0f, -1f);
					CPNBOCBEONJ.clearFlags = CameraClearFlags.Color;
					CPNBOCBEONJ.backgroundColor = Color.black;
					CPNBOCBEONJ.orthographic = true;
					CPNBOCBEONJ.orthographicSize = 0.5f;
					CPNBOCBEONJ.nearClipPlane = 0.01f;
					CPNBOCBEONJ.farClipPlane = 2.1f;
					CPNBOCBEONJ.depth = 0f;
					CPNBOCBEONJ.renderingPath = RenderingPath.Forward;
					CPNBOCBEONJ.useOcclusionCulling = false;
					CPNBOCBEONJ.allowHDR = false;
					CPNBOCBEONJ.allowMSAA = false;
					CPNBOCBEONJ.targetTexture = FMBIMIAEOHH;
					CPNBOCBEONJ.enabled = false;
				}
			}
			else if (!checkWireframe && CPNBOCBEONJ != null)
			{
				UnityEngine.Object.Destroy(BEPKECLFIDJ.gameObject);
				UnityEngine.Object.Destroy(MMMPEOBFGPN.gameObject);
				CPNBOCBEONJ.targetTexture = null;
				UnityEngine.Object.Destroy(CPNBOCBEONJ.gameObject);
			}
			if (checkRaycast && IDDJDOBBNDA == null)
			{
				IDDJDOBBNDA = GameObject.CreatePrimitive(PrimitiveType.Plane);
				IDDJDOBBNDA.name = "ThinWall";
				IDDJDOBBNDA.layer = MGGPINHFAMH;
				IDDJDOBBNDA.transform.parent = CCEBMLDFLFF.transform;
				IDDJDOBBNDA.transform.localScale = new Vector3(0.2f, 1f, 0.2f);
				IDDJDOBBNDA.transform.localRotation = Quaternion.Euler(270f, 0f, 0f);
				IDDJDOBBNDA.transform.localPosition = new Vector3(0f, 0f, 1.4f);
				UnityEngine.Object.Destroy(IDDJDOBBNDA.GetComponent<Renderer>());
				UnityEngine.Object.Destroy(IDDJDOBBNDA.GetComponent<MeshFilter>());
			}
			else if (!checkRaycast && IDDJDOBBNDA != null)
			{
				UnityEngine.Object.Destroy(IDDJDOBBNDA);
			}
		}
		else if (CCEBMLDFLFF != null)
		{
			UnityEngine.Object.Destroy(CCEBMLDFLFF);
		}
	}

	private IEnumerator PECONNFBGMM()
	{
		yield return FAJBDFGINIO;
		CMCDECNJCFP();
		if (checkRigidbody)
		{
			APCHMMNGKBI();
		}
		if (checkController)
		{
			AANAFNAAKCK();
		}
		if (checkWireframe)
		{
			KCDGMIGADHG();
		}
		if (checkRaycast)
		{
			JNBNMOFIDKC();
		}
	}

	private void APCHMMNGKBI()
	{
		if (!checkRigidbody)
		{
			GFHLMJPPPJF();
			KHFENJJMNCE();
			CMCDECNJCFP();
			return;
		}
		if (!KKNEAEPGKFF)
		{
			CGKLAIJFIDI();
		}
		if (KKNEAEPGKFF.transform.localPosition.z <= 1f && BOCNMNNGPOD > 0)
		{
			BOCNMNNGPOD = 0;
		}
		KKNEAEPGKFF.rotation = Quaternion.identity;
		KKNEAEPGKFF.angularVelocity = Vector3.zero;
		KKNEAEPGKFF.transform.localPosition = new Vector3(0.75f, 0f, -1f);
		KKNEAEPGKFF.velocity = OKHDNNFKILE;
		Invoke("APCHMMNGKBI", 4f);
	}

	private void AANAFNAAKCK()
	{
		if (!checkController)
		{
			FHAFCCMHHDJ();
			IBHJAGIKCNO();
			CMCDECNJCFP();
			return;
		}
		if (!FEFLPKPENGK)
		{
			IJGBCEANNCL();
		}
		if (FEFLPKPENGK.transform.localPosition.z <= 1f && ONCFNCAIJPB > 0)
		{
			ONCFNCAIJPB = 0;
		}
		FEFLPKPENGK.transform.localPosition = new Vector3(-0.75f, 0f, -1f);
		HMIJHPBOMKN = 0.01f;
		Invoke("AANAFNAAKCK", 4f);
	}

	private void KCDGMIGADHG()
	{
		if (!checkWireframe)
		{
			GNFJJBGDCGO();
			CMCDECNJCFP();
		}
		else if (!NAHJALPEEAJ)
		{
			Invoke("NLILPHGHBKE", BJCPEGBGHPH);
		}
	}

	private void NLILPHGHBKE()
	{
		StartCoroutine(DLJPNIONNHE());
		Invoke("NLILPHGHBKE", BJCPEGBGHPH);
	}

	private IEnumerator DLJPNIONNHE()
	{
		CPNBOCBEONJ.enabled = true;
		yield return FAJBDFGINIO;
		BEPKECLFIDJ.enabled = true;
		MMMPEOBFGPN.enabled = true;
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = FMBIMIAEOHH;
		CPNBOCBEONJ.Render();
		BEPKECLFIDJ.enabled = false;
		MMMPEOBFGPN.enabled = false;
		while (!FMBIMIAEOHH.IsCreated())
		{
			yield return FAJBDFGINIO;
		}
		IFJENBAFEKL.ReadPixels(new Rect(0f, 0f, 4f, 4f), 0, 0, recalculateMipMaps: false);
		IFJENBAFEKL.Apply();
		RenderTexture.active = active;
		if (CPNBOCBEONJ == null)
		{
			yield break;
		}
		CPNBOCBEONJ.enabled = false;
		Color pixel = IFJENBAFEKL.GetPixel(0, 3);
		Color pixel2 = IFJENBAFEKL.GetPixel(0, 1);
		Color pixel3 = IFJENBAFEKL.GetPixel(3, 3);
		Color pixel4 = IFJENBAFEKL.GetPixel(3, 1);
		Color pixel5 = IFJENBAFEKL.GetPixel(1, 3);
		Color pixel6 = IFJENBAFEKL.GetPixel(2, 3);
		Color pixel7 = IFJENBAFEKL.GetPixel(1, 1);
		Color pixel8 = IFJENBAFEKL.GetPixel(2, 1);
		bool flag = KAEKACLPAPJ(pixel, KBEPHLHKCEK);
		bool flag2 = KAEKACLPAPJ(pixel2, AELMGFKMCFA);
		bool flag3 = KAEKACLPAPJ(pixel3, KBEPHLHKCEK);
		bool flag4 = KAEKACLPAPJ(pixel4, AELMGFKMCFA);
		bool flag5 = KAEKACLPAPJ(pixel5, KBEPHLHKCEK);
		bool flag6 = KAEKACLPAPJ(pixel6, KBEPHLHKCEK);
		bool flag7 = KAEKACLPAPJ(pixel7, AELMGFKMCFA);
		bool flag8 = KAEKACLPAPJ(pixel8, AELMGFKMCFA);
		if (!flag && !flag2 && !flag3 && !flag4 && !flag5 && !flag6 && !flag7 && !flag8)
		{
			if (MPIHGDCDJIJ > 0)
			{
				MPIHGDCDJIJ = 0;
			}
		}
		else
		{
			MPIHGDCDJIJ++;
			NAHJALPEEAJ = IHBJLLLFJEL();
		}
		yield return null;
	}

	private bool KAEKACLPAPJ(Color AEMBPMJMOAB, Color LCBKHLLPIGM)
	{
		return Math.Abs(AEMBPMJMOAB.r - LCBKHLLPIGM.r) > 5f || Math.Abs(AEMBPMJMOAB.g - LCBKHLLPIGM.g) > 5f || Math.Abs(AEMBPMJMOAB.b - LCBKHLLPIGM.b) > 5f;
	}

	private void JNBNMOFIDKC()
	{
		if (!checkRaycast)
		{
			JHMCFGAONIJ();
			CMCDECNJCFP();
		}
		else
		{
			Invoke("EJJHPJLLOLB", ODEPOLDLHMF);
		}
	}

	private void EJJHPJLLOLB()
	{
		if (Physics.RaycastNonAlloc(CCEBMLDFLFF.transform.position, CCEBMLDFLFF.transform.TransformDirection(Vector3.forward), OJHLIELOKIN, 1.5f, IPGIENBNMOP) > 0)
		{
			if (GLAIOGJANGG > 0)
			{
				GLAIOGJANGG = 0;
			}
		}
		else
		{
			GLAIOGJANGG++;
			if (IHBJLLLFJEL())
			{
				return;
			}
		}
		Invoke("EJJHPJLLOLB", ODEPOLDLHMF);
	}

	private void GFHLMJPPPJF()
	{
		if ((bool)KKNEAEPGKFF)
		{
			KKNEAEPGKFF.velocity = Vector3.zero;
		}
		CancelInvoke("APCHMMNGKBI");
	}

	private void FHAFCCMHHDJ()
	{
		if ((bool)FEFLPKPENGK)
		{
			HMIJHPBOMKN = 0f;
		}
		CancelInvoke("AANAFNAAKCK");
	}

	private void GNFJJBGDCGO()
	{
		CancelInvoke("NLILPHGHBKE");
	}

	private void JHMCFGAONIJ()
	{
		CancelInvoke("EJJHPJLLOLB");
	}

	private void CGKLAIJFIDI()
	{
		GameObject gameObject = new GameObject("RigidPlayer");
		gameObject.AddComponent<CapsuleCollider>().height = 2f;
		gameObject.layer = MGGPINHFAMH;
		gameObject.transform.parent = CCEBMLDFLFF.transform;
		gameObject.transform.localPosition = new Vector3(0.75f, 0f, -1f);
		KKNEAEPGKFF = gameObject.AddComponent<Rigidbody>();
		KKNEAEPGKFF.useGravity = false;
	}

	private void IJGBCEANNCL()
	{
		GameObject gameObject = new GameObject("ControlledPlayer");
		gameObject.AddComponent<CapsuleCollider>().height = 2f;
		gameObject.layer = MGGPINHFAMH;
		gameObject.transform.parent = CCEBMLDFLFF.transform;
		gameObject.transform.localPosition = new Vector3(-0.75f, 0f, -1f);
		FEFLPKPENGK = gameObject.AddComponent<CharacterController>();
	}

	private void KHFENJJMNCE()
	{
		if ((bool)KKNEAEPGKFF)
		{
			UnityEngine.Object.Destroy(KKNEAEPGKFF.gameObject);
			KKNEAEPGKFF = null;
		}
	}

	private void IBHJAGIKCNO()
	{
		if ((bool)FEFLPKPENGK)
		{
			UnityEngine.Object.Destroy(FEFLPKPENGK.gameObject);
			FEFLPKPENGK = null;
		}
	}

	private bool IHBJLLLFJEL()
	{
		bool result = false;
		if (ONCFNCAIJPB > JFDACACAECG || BOCNMNNGPOD > JFDACACAECG || MPIHGDCDJIJ > JFDACACAECG || GLAIOGJANGG > JFDACACAECG)
		{
			HENEPAOMHDA();
			result = true;
		}
		return result;
	}

	private static Color32 BABAEIMBFKG()
	{
		return new Color32((byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), byte.MaxValue);
	}

	private static bool PKMKIHEAKKG(Color32 CFHAAHIGEJF, Color32 GHNOBCNIECP, int LGIJFADIMHA)
	{
		return Math.Abs(CFHAAHIGEJF.r - GHNOBCNIECP.r) < LGIJFADIMHA && Math.Abs(CFHAAHIGEJF.g - GHNOBCNIECP.g) < LGIJFADIMHA && Math.Abs(CFHAAHIGEJF.b - GHNOBCNIECP.b) < LGIJFADIMHA;
	}
}
