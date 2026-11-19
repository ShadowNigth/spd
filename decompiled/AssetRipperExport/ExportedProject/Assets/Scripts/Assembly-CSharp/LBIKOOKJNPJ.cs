using System.Collections.Generic;
using UnityEngine;

public class LBIKOOKJNPJ : MonoBehaviour
{
	private class LDABBPAACBN
	{
		public int GLNHGIPOIDP = 1;

		public LogType EJBGEPJBLEN;

		public string HDNPMPFDPFL;

		public string HIHKLHBNOEN;
	}

	private List<LDABBPAACBN> DGGDFCOAMNF = new List<LDABBPAACBN>();

	private List<LDABBPAACBN> NLICNGMLKIB = new List<LDABBPAACBN>();

	private List<LDABBPAACBN> MGIAOAOJLBL = new List<LDABBPAACBN>();

	private Dictionary<string, LDABBPAACBN> IKCKBGLAKGB = new Dictionary<string, LDABBPAACBN>();

	private bool AABOBMOPBFF;

	private bool AELEKOJFEIM;

	private bool EDBDCBFEFFH = true;

	private bool LKOCLDNFHKG = true;

	private bool GBOIDKEEMBI = true;

	private int KNEHJPLKIHF;

	private int CHJLHBNDDKO;

	private int KPDOECIJHOA;

	private int AOIPCIBOIMK;

	private int CEKAPCPIGBD;

	private int JHMNOFDGKFC;

	public int JKOOBBPKFKB = 1000;

	private int NDEFDFEDKFL;

	private bool CEMIPEDHPHO;

	private static bool JLDACKDAAGA;

	private Texture2D IMBBIOFLACK;

	private Texture2D LDLNPFFDIDF;

	private Texture2D PFDHONHLICE;

	private GUIContent OKAFCIJIKHO;

	private GUIContent AMFPDCHDHFB;

	private GUIContent CCEHENAGIHL;

	private GUIStyle GFCEEACJLBJ;

	private GUIStyle NIBFNHMNDIN;

	private GUIStyle INFFDDFLBDO;

	private GUIStyle DCEFNCDOMHH;

	private GUIStyle NDEEPACKGCG;

	private GUIStyle OFJLGGHFOMC;

	private GUIStyle CDBCIEMJNJN;

	private GUIStyle EBFFNNCFFPD;

	private GUIStyle AJCGNLHOIGJ;

	private GUISkin DEANKNHCKNG;

	private Rect HKMIDHCHNAO;

	private Rect AEFAFEOKAHK;

	private Vector2 ELPOKFBMEEL;

	private Vector2 PJLACIPLMBC;

	private int GLNFDPAHGMH = -1;

	private LDABBPAACBN MNANGPCBAIH;

	private float AIHHKNDNPOG;

	private float KICMLMEEOCA;

	private int MLJLPCDEJGD;

	private Vector2 MPGNEHBHEKE;

	private float PBBOLPMFJAN;

	private int LECDCKBMKBN;

	[HideInInspector]
	private bool IBPMLCAGBFG
	{
		get
		{
			return base.enabled;
		}
		set
		{
			base.enabled = value;
		}
	}

	private void Awake()
	{
		IMBBIOFLACK = LJELJMLCEHH("log_icon", 32, 32);
		LDLNPFFDIDF = LJELJMLCEHH("warning_icon", 32, 32);
		PFDHONHLICE = LJELJMLCEHH("error_icon", 32, 32);
		OKAFCIJIKHO = new GUIContent(string.Empty, IMBBIOFLACK, "show or hide logs");
		AMFPDCHDHFB = new GUIContent(string.Empty, LDLNPFFDIDF, "show or hide warnings");
		CCEHENAGIHL = new GUIContent(string.Empty, PFDHONHLICE, "show or hide errors");
		GFCEEACJLBJ = new GUIStyle();
		GFCEEACJLBJ.border = new RectOffset(1, 1, 1, 1);
		GFCEEACJLBJ.normal.background = Resources.Load("bar", typeof(Texture2D)) as Texture2D;
		GFCEEACJLBJ.active.background = Resources.Load("button_active", typeof(Texture2D)) as Texture2D;
		GFCEEACJLBJ.alignment = TextAnchor.MiddleCenter;
		GFCEEACJLBJ.margin = new RectOffset(1, 1, 1, 1);
		GFCEEACJLBJ.padding = new RectOffset(4, 4, 4, 4);
		GFCEEACJLBJ.wordWrap = true;
		GFCEEACJLBJ.clipping = TextClipping.Clip;
		NIBFNHMNDIN = new GUIStyle();
		NIBFNHMNDIN.border = new RectOffset(1, 1, 1, 1);
		NIBFNHMNDIN.normal.background = LJELJMLCEHH("button_active", 32, 32);
		NIBFNHMNDIN.alignment = TextAnchor.MiddleCenter;
		NIBFNHMNDIN.margin = new RectOffset(1, 1, 1, 1);
		NIBFNHMNDIN.padding = new RectOffset(4, 4, 4, 4);
		INFFDDFLBDO = new GUIStyle();
		INFFDDFLBDO.normal.background = LJELJMLCEHH("even_log", 16, 16);
		DCEFNCDOMHH = new GUIStyle();
		DCEFNCDOMHH.wordWrap = true;
		NDEEPACKGCG = new GUIStyle();
		NDEEPACKGCG.normal.background = LJELJMLCEHH("odd_log", 16, 16);
		NDEEPACKGCG.wordWrap = true;
		OFJLGGHFOMC = new GUIStyle();
		OFJLGGHFOMC.wordWrap = true;
		CDBCIEMJNJN = new GUIStyle();
		CDBCIEMJNJN.normal.background = LJELJMLCEHH("selected", 16, 16);
		CDBCIEMJNJN.normal.textColor = Color.white;
		CDBCIEMJNJN.wordWrap = true;
		EBFFNNCFFPD = new GUIStyle();
		EBFFNNCFFPD.wordWrap = true;
		AJCGNLHOIGJ = new GUIStyle();
		AJCGNLHOIGJ.normal.background = LJELJMLCEHH("bar", 32, 32);
		DEANKNHCKNG = Resources.Load("InGameLogsScrollerSkin", typeof(GUISkin)) as GUISkin;
		if (!JLDACKDAAGA)
		{
			Object.DontDestroyOnLoad(base.gameObject);
			JLDACKDAAGA = true;
		}
		else
		{
			Debug.LogWarning("tow manager is exists delete the second");
			Object.DestroyImmediate(base.gameObject);
		}
		IBPMLCAGBFG = JKPOJMOFFMF.GMOOMLGMADD("InGameLogs_show") == 1;
	}

	private void OnEnable()
	{
		if (DGGDFCOAMNF.Count == 0)
		{
			JPENCCDNBEA();
		}
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
		AABOBMOPBFF = JKPOJMOFFMF.GMOOMLGMADD("InGameLogs_collapse") == 1;
		AELEKOJFEIM = JKPOJMOFFMF.GMOOMLGMADD("InGameLogs_clearOnNewSceneLoaded") == 1;
		EDBDCBFEFFH = JKPOJMOFFMF.GMOOMLGMADD("InGameLogs_showLog", 1) == 1;
		LKOCLDNFHKG = JKPOJMOFFMF.GMOOMLGMADD("InGameLogs_showWarning", 1) == 1;
		GBOIDKEEMBI = JKPOJMOFFMF.GMOOMLGMADD("InGameLogs_showError", 1) == 1;
		CEMIPEDHPHO = JKPOJMOFFMF.GMOOMLGMADD("InGameLogs_alwaysShowFps") == 1;
	}

	private void JPENCCDNBEA()
	{
		DGGDFCOAMNF.Clear();
		NLICNGMLKIB.Clear();
		MGIAOAOJLBL.Clear();
		IKCKBGLAKGB.Clear();
		GLNFDPAHGMH = -1;
		KNEHJPLKIHF = 0;
		CHJLHBNDDKO = 0;
		KPDOECIJHOA = 0;
		AOIPCIBOIMK = 0;
		CEKAPCPIGBD = 0;
		JHMNOFDGKFC = 0;
	}

	private Texture2D LJELJMLCEHH(string NGIHJKGIKNA, int KAPGDBCIGHP, int GAGNFGOGPHH)
	{
		return (Texture2D)Resources.Load(NGIHJKGIKNA, typeof(Texture2D));
	}

	private void LLOBICNGMDK()
	{
		MGIAOAOJLBL.Clear();
		if (AABOBMOPBFF)
		{
			for (int i = 0; i < NLICNGMLKIB.Count; i++)
			{
				LDABBPAACBN lDABBPAACBN = NLICNGMLKIB[i];
				if ((lDABBPAACBN.EJBGEPJBLEN != LogType.Log || EDBDCBFEFFH) && (lDABBPAACBN.EJBGEPJBLEN != LogType.Warning || LKOCLDNFHKG) && (lDABBPAACBN.EJBGEPJBLEN != LogType.Error || GBOIDKEEMBI) && (lDABBPAACBN.EJBGEPJBLEN != LogType.Exception || GBOIDKEEMBI))
				{
					MGIAOAOJLBL.Add(lDABBPAACBN);
				}
			}
			return;
		}
		for (int j = 0; j < DGGDFCOAMNF.Count; j++)
		{
			LDABBPAACBN lDABBPAACBN2 = DGGDFCOAMNF[j];
			if ((lDABBPAACBN2.EJBGEPJBLEN != LogType.Log || EDBDCBFEFFH) && (lDABBPAACBN2.EJBGEPJBLEN != LogType.Warning || LKOCLDNFHKG) && (lDABBPAACBN2.EJBGEPJBLEN != LogType.Error || GBOIDKEEMBI) && (lDABBPAACBN2.EJBGEPJBLEN != LogType.Exception || GBOIDKEEMBI))
			{
				MGIAOAOJLBL.Add(lDABBPAACBN2);
			}
		}
	}

	private void OnGUI()
	{
		if (!IBPMLCAGBFG)
		{
			if (CEMIPEDHPHO)
			{
				GUILayout.Label("fps = " + NDEFDFEDKFL);
			}
			return;
		}
		HKMIDHCHNAO.x = 0f;
		HKMIDHCHNAO.y = 0f;
		HKMIDHCHNAO.width = Screen.width;
		HKMIDHCHNAO.height = (float)Screen.height * 0.75f;
		AEFAFEOKAHK.x = 0f;
		AEFAFEOKAHK.y = (float)Screen.height * 0.75f;
		AEFAFEOKAHK.width = Screen.width;
		AEFAFEOKAHK.height = (float)Screen.height * 0.25f;
		GUI.skin = DEANKNHCKNG;
		GUILayout.Space(10f);
		GUILayout.BeginArea(HKMIDHCHNAO, INFFDDFLBDO);
		GUILayout.BeginHorizontal(GFCEEACJLBJ);
		if (GUILayout.Button("Clear", GFCEEACJLBJ, GUILayout.Height(50f)))
		{
			JPENCCDNBEA();
		}
		if (GUILayout.Button("Collapse", (!AABOBMOPBFF) ? GFCEEACJLBJ : NIBFNHMNDIN, GUILayout.Height(50f)))
		{
			AABOBMOPBFF = !AABOBMOPBFF;
			LLOBICNGMDK();
		}
		if (GUILayout.Button("Clear On New\nScene Loaded", (!AELEKOJFEIM) ? GFCEEACJLBJ : NIBFNHMNDIN, GUILayout.Height(50f)))
		{
			AELEKOJFEIM = !AELEKOJFEIM;
		}
		if (GUILayout.Button("Always\nShow Fps", (!CEMIPEDHPHO) ? GFCEEACJLBJ : NIBFNHMNDIN, GUILayout.Height(50f)))
		{
			CEMIPEDHPHO = !CEMIPEDHPHO;
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label(NDEFDFEDKFL.ToString(), GFCEEACJLBJ);
		string text = " ";
		if (AABOBMOPBFF)
		{
			if (AOIPCIBOIMK >= JKOOBBPKFKB)
			{
				text += "+";
			}
			text += AOIPCIBOIMK;
		}
		else
		{
			if (KNEHJPLKIHF >= JKOOBBPKFKB)
			{
				text += "+";
			}
			text += KNEHJPLKIHF;
		}
		string text2 = " ";
		if (AABOBMOPBFF)
		{
			if (CEKAPCPIGBD >= JKOOBBPKFKB)
			{
				text2 += "+";
			}
			text2 += CEKAPCPIGBD;
		}
		else
		{
			if (CHJLHBNDDKO >= JKOOBBPKFKB)
			{
				text2 += "+";
			}
			text2 += CHJLHBNDDKO;
		}
		string text3 = " ";
		if (AABOBMOPBFF)
		{
			if (JHMNOFDGKFC >= JKOOBBPKFKB)
			{
				text3 += "+";
			}
			text3 += JHMNOFDGKFC;
		}
		else
		{
			if (KPDOECIJHOA >= JKOOBBPKFKB)
			{
				text3 += "+";
			}
			text3 += KPDOECIJHOA;
		}
		OKAFCIJIKHO.text = text;
		if (GUILayout.Button(OKAFCIJIKHO, (!EDBDCBFEFFH) ? GFCEEACJLBJ : NIBFNHMNDIN, GUILayout.Height(50f)))
		{
			EDBDCBFEFFH = !EDBDCBFEFFH;
			LLOBICNGMDK();
		}
		AMFPDCHDHFB.text = text2;
		if (GUILayout.Button(AMFPDCHDHFB, (!LKOCLDNFHKG) ? GFCEEACJLBJ : NIBFNHMNDIN, GUILayout.Height(50f)))
		{
			LKOCLDNFHKG = !LKOCLDNFHKG;
			LLOBICNGMDK();
		}
		CCEHENAGIHL.text = text3;
		if (GUILayout.Button(CCEHENAGIHL, (!GBOIDKEEMBI) ? GFCEEACJLBJ : NIBFNHMNDIN, GUILayout.Height(50f)))
		{
			GBOIDKEEMBI = !GBOIDKEEMBI;
			LLOBICNGMDK();
		}
		if (GUILayout.Button("  Hide  ", GFCEEACJLBJ, GUILayout.Height(50f)))
		{
			IBPMLCAGBFG = false;
		}
		GUILayout.EndHorizontal();
		LPPEFIJMHHP();
		float num = ICGDDLEAELP();
		if (num != 0f && HKMIDHCHNAO.Contains(new Vector2(MPGNEHBHEKE.x, (float)Screen.height - MPGNEHBHEKE.y)))
		{
			ELPOKFBMEEL.y += num - AIHHKNDNPOG;
		}
		ELPOKFBMEEL = GUILayout.BeginScrollView(ELPOKFBMEEL);
		AIHHKNDNPOG = num;
		int a = (int)((float)Screen.height * 0.75f / 30f);
		int num2 = ONNJFMHLDDL();
		a = Mathf.Min(a, num2 - MLJLPCDEJGD);
		int num3 = 0;
		int num4 = MLJLPCDEJGD * 30;
		GLNFDPAHGMH = Mathf.Clamp(GLNFDPAHGMH, -1, num2 - 1);
		if (num4 > 0)
		{
			GUILayout.BeginHorizontal(GUILayout.Height(num4));
			GUILayout.Label(" ");
			GUILayout.EndHorizontal();
		}
		int value = MLJLPCDEJGD + a;
		value = Mathf.Clamp(value, 0, num2);
		int num5 = MLJLPCDEJGD;
		while (MLJLPCDEJGD + num3 < value && num5 < MGIAOAOJLBL.Count)
		{
			LDABBPAACBN lDABBPAACBN = MGIAOAOJLBL[num5];
			if ((lDABBPAACBN.EJBGEPJBLEN != LogType.Log || EDBDCBFEFFH) && (lDABBPAACBN.EJBGEPJBLEN != LogType.Warning || LKOCLDNFHKG) && (lDABBPAACBN.EJBGEPJBLEN != LogType.Error || GBOIDKEEMBI) && (lDABBPAACBN.EJBGEPJBLEN != LogType.Exception || GBOIDKEEMBI))
			{
				if (num3 >= a)
				{
					break;
				}
				GUIContent gUIContent = null;
				gUIContent = ((lDABBPAACBN.EJBGEPJBLEN == LogType.Log) ? OKAFCIJIKHO : ((lDABBPAACBN.EJBGEPJBLEN != LogType.Warning) ? CCEHENAGIHL : AMFPDCHDHFB));
				gUIContent.text = lDABBPAACBN.HDNPMPFDPFL;
				if (GLNFDPAHGMH == MLJLPCDEJGD + num3)
				{
					MNANGPCBAIH = lDABBPAACBN;
					GUILayout.BeginHorizontal(CDBCIEMJNJN);
					GUILayout.Label(gUIContent, CDBCIEMJNJN);
					if (AABOBMOPBFF)
					{
						GUILayout.Label(lDABBPAACBN.GLNHGIPOIDP.ToString(), GFCEEACJLBJ, GUILayout.Width(50f));
					}
					GUILayout.EndHorizontal();
				}
				else
				{
					GUILayout.BeginHorizontal(((MLJLPCDEJGD + num3) % 2 != 0) ? NDEEPACKGCG : DCEFNCDOMHH, GUILayout.Height(30f));
					if (GUILayout.Button(gUIContent, OFJLGGHFOMC))
					{
						GLNFDPAHGMH = MLJLPCDEJGD + num3;
					}
					if (AABOBMOPBFF)
					{
						GUILayout.Label(lDABBPAACBN.GLNHGIPOIDP.ToString(), GFCEEACJLBJ, GUILayout.Width(50f));
					}
					GUILayout.EndHorizontal();
				}
				num3++;
			}
			num5++;
		}
		int num6 = (num2 - (MLJLPCDEJGD + a)) * 30;
		if (num6 > 0)
		{
			GUILayout.BeginHorizontal(GUILayout.Height(num6));
			GUILayout.Label(" ");
			GUILayout.EndHorizontal();
		}
		GUILayout.EndScrollView();
		GUILayout.EndArea();
		GUILayout.BeginArea(AEFAFEOKAHK, INFFDDFLBDO);
		if (GLNFDPAHGMH != -1)
		{
			float num7 = ICGDDLEAELP();
			if (num7 != 0f && AEFAFEOKAHK.Contains(new Vector2(MPGNEHBHEKE.x, (float)Screen.height - MPGNEHBHEKE.y)))
			{
				PJLACIPLMBC.y += num7 - KICMLMEEOCA;
			}
			KICMLMEEOCA = num7;
			PJLACIPLMBC = GUILayout.BeginScrollView(PJLACIPLMBC);
			GUILayout.BeginHorizontal();
			if (MNANGPCBAIH != null)
			{
				string text4 = ((!string.IsNullOrEmpty(MNANGPCBAIH.HIHKLHBNOEN)) ? MNANGPCBAIH.HIHKLHBNOEN : "stacktrace is empty");
				GUILayout.Label(text4, EBFFNNCFFPD);
			}
			GUILayout.EndHorizontal();
			GUILayout.EndScrollView();
		}
		GUILayout.EndArea();
	}

	private int ONNJFMHLDDL()
	{
		int num = 0;
		if (AABOBMOPBFF)
		{
			if (EDBDCBFEFFH)
			{
				num += AOIPCIBOIMK;
			}
			if (LKOCLDNFHKG)
			{
				num += CEKAPCPIGBD;
			}
			if (GBOIDKEEMBI)
			{
				num += JHMNOFDGKFC;
			}
		}
		else
		{
			if (EDBDCBFEFFH)
			{
				num += KNEHJPLKIHF;
			}
			if (LKOCLDNFHKG)
			{
				num += CHJLHBNDDKO;
			}
			if (GBOIDKEEMBI)
			{
				num += KPDOECIJHOA;
			}
		}
		return num;
	}

	private void LPPEFIJMHHP()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
		{
			if (Input.touches.Length == 1 && Input.touches[0].phase == TouchPhase.Began)
			{
				MPGNEHBHEKE = Input.touches[0].position;
			}
		}
		else if (Input.GetMouseButtonDown(0))
		{
			MPGNEHBHEKE = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		}
	}

	private float ICGDDLEAELP()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
		{
			if (Input.touches.Length != 1)
			{
				return 0f;
			}
			return Input.touches[0].position.y - MPGNEHBHEKE.y;
		}
		if (Input.GetMouseButton(0))
		{
			return Input.mousePosition.y - MPGNEHBHEKE.y;
		}
		return 0f;
	}

	private void MJECHKFLAEH()
	{
		MLJLPCDEJGD = (int)(ELPOKFBMEEL.y / 30f);
		MLJLPCDEJGD = Mathf.Clamp(MLJLPCDEJGD, 0, ONNJFMHLDDL());
	}

	private void Update()
	{
		PBBOLPMFJAN += Time.deltaTime;
		LECDCKBMKBN++;
		if (PBBOLPMFJAN >= 1f)
		{
			NDEFDFEDKFL = LECDCKBMKBN;
			LECDCKBMKBN = 0;
			PBBOLPMFJAN = 0f;
		}
		MJECHKFLAEH();
		PBBOLPMFJAN += Time.deltaTime;
		if (PBBOLPMFJAN > 1f)
		{
			PBBOLPMFJAN = 0f;
		}
	}

	public void JPHLNGJEFHF(string HDNPMPFDPFL, string HIHKLHBNOEN, LogType EBMKGCIKJCA)
	{
		bool flag = false;
		LDABBPAACBN lDABBPAACBN = null;
		bool flag2 = false;
		if (IKCKBGLAKGB.ContainsKey(HDNPMPFDPFL))
		{
			IKCKBGLAKGB[HDNPMPFDPFL].GLNHGIPOIDP++;
			lDABBPAACBN = IKCKBGLAKGB[HDNPMPFDPFL];
		}
		else
		{
			switch (EBMKGCIKJCA)
			{
			case LogType.Log:
				if (AOIPCIBOIMK >= JKOOBBPKFKB)
				{
					flag2 = true;
				}
				break;
			case LogType.Warning:
				if (CEKAPCPIGBD >= JKOOBBPKFKB)
				{
					flag2 = true;
				}
				break;
			default:
				if (JHMNOFDGKFC >= JKOOBBPKFKB)
				{
					flag2 = true;
				}
				break;
			}
			if (!flag2)
			{
				switch (EBMKGCIKJCA)
				{
				case LogType.Log:
					AOIPCIBOIMK++;
					break;
				case LogType.Warning:
					CEKAPCPIGBD++;
					break;
				default:
					JHMNOFDGKFC++;
					break;
				}
				LDABBPAACBN lDABBPAACBN2 = new LDABBPAACBN();
				lDABBPAACBN2.EJBGEPJBLEN = EBMKGCIKJCA;
				lDABBPAACBN2.HDNPMPFDPFL = HDNPMPFDPFL;
				lDABBPAACBN2.HIHKLHBNOEN = HIHKLHBNOEN;
				lDABBPAACBN = lDABBPAACBN2;
				NLICNGMLKIB.Add(lDABBPAACBN);
				IKCKBGLAKGB.Add(HDNPMPFDPFL, lDABBPAACBN);
				if (AABOBMOPBFF)
				{
					flag2 = false;
					if (lDABBPAACBN.EJBGEPJBLEN == LogType.Log && !EDBDCBFEFFH)
					{
						flag2 = true;
					}
					if (lDABBPAACBN.EJBGEPJBLEN == LogType.Warning && !LKOCLDNFHKG)
					{
						flag2 = true;
					}
					if (lDABBPAACBN.EJBGEPJBLEN == LogType.Error && !GBOIDKEEMBI)
					{
						flag2 = true;
					}
					if (lDABBPAACBN.EJBGEPJBLEN == LogType.Exception && !GBOIDKEEMBI)
					{
						flag2 = true;
					}
					if (!flag2)
					{
						MGIAOAOJLBL.Add(lDABBPAACBN);
						flag = true;
					}
				}
			}
		}
		flag2 = false;
		switch (EBMKGCIKJCA)
		{
		case LogType.Log:
			if (KNEHJPLKIHF >= JKOOBBPKFKB)
			{
				flag2 = true;
			}
			break;
		case LogType.Warning:
			if (CHJLHBNDDKO >= JKOOBBPKFKB)
			{
				flag2 = true;
			}
			break;
		default:
			if (KPDOECIJHOA >= JKOOBBPKFKB)
			{
				flag2 = true;
			}
			break;
		}
		if (!flag2)
		{
			switch (EBMKGCIKJCA)
			{
			case LogType.Log:
				KNEHJPLKIHF++;
				break;
			case LogType.Warning:
				CHJLHBNDDKO++;
				break;
			default:
				KPDOECIJHOA++;
				break;
			}
			DGGDFCOAMNF.Add(lDABBPAACBN);
			if (!AABOBMOPBFF)
			{
				flag2 = false;
				if (lDABBPAACBN.EJBGEPJBLEN == LogType.Log && !EDBDCBFEFFH)
				{
					flag2 = true;
				}
				if (lDABBPAACBN.EJBGEPJBLEN == LogType.Warning && !LKOCLDNFHKG)
				{
					flag2 = true;
				}
				if (lDABBPAACBN.EJBGEPJBLEN == LogType.Error && !GBOIDKEEMBI)
				{
					flag2 = true;
				}
				if (lDABBPAACBN.EJBGEPJBLEN == LogType.Exception && !GBOIDKEEMBI)
				{
					flag2 = true;
				}
				if (!flag2)
				{
					MGIAOAOJLBL.Add(lDABBPAACBN);
					flag = true;
				}
			}
		}
		if (flag)
		{
			MJECHKFLAEH();
			int num = ONNJFMHLDDL();
			int num2 = (int)((float)Screen.height * 0.75f / 30f);
			if (MLJLPCDEJGD >= num - num2)
			{
				ELPOKFBMEEL.y += 30f;
			}
		}
	}

	private void OnLevelWasLoaded()
	{
		Debug.Log("Loaded");
		if (AELEKOJFEIM)
		{
			JPENCCDNBEA();
		}
	}

	private void OnApplicationQuit()
	{
		JKPOJMOFFMF.OLEHBAMBPDE("InGameLogs_show", IBPMLCAGBFG ? 1 : 0);
		JKPOJMOFFMF.OLEHBAMBPDE("InGameLogs_collapse", AABOBMOPBFF ? 1 : 0);
		JKPOJMOFFMF.OLEHBAMBPDE("InGameLogs_clearOnNewSceneLoaded", AELEKOJFEIM ? 1 : 0);
		JKPOJMOFFMF.OLEHBAMBPDE("InGameLogs_showLog", EDBDCBFEFFH ? 1 : 0);
		JKPOJMOFFMF.OLEHBAMBPDE("InGameLogs_showWarning", LKOCLDNFHKG ? 1 : 0);
		JKPOJMOFFMF.OLEHBAMBPDE("InGameLogs_showError", GBOIDKEEMBI ? 1 : 0);
		JKPOJMOFFMF.OLEHBAMBPDE("InGameLogs_alwaysShowFps", CEMIPEDHPHO ? 1 : 0);
		JKPOJMOFFMF.OBKMIHILMLH();
	}
}
