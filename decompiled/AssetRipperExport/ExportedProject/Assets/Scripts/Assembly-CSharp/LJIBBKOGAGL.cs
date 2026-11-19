using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public sealed class LJIBBKOGAGL : MonoBehaviour
{
	private sealed class CAEHNGGCIJC
	{
		internal bool EHAPKEKPMOE;

		internal void BEKJDJFLJJC(JKHKOEPGCPO FCCPLGMNKOK)
		{
			FCCPLGMNKOK.DDICNHNKBHL = EHAPKEKPMOE;
		}
	}

	private static LJIBBKOGAGL LENBADIHBIK;

	private static bool DOBJEKBDGCE;

	private static JNEFNLEGJMM[] AFKPHBEFGEN;

	private static JKHKOEPGCPO[] GONMDIFBGFJ;

	private static BACLJEFBAMJ[] OBCFNCBIIPP;

	private static bool EJGBOPFGEOJ;

	[CompilerGenerated]
	private static Action<JNEFNLEGJMM> ACJNADIPOMC;

	private static LJIBBKOGAGL KAGNKODNFOC
	{
		get
		{
			if (LENBADIHBIK == null)
			{
				LENBADIHBIK = UnityEngine.Object.FindObjectOfType<LJIBBKOGAGL>();
			}
			return LENBADIHBIK;
		}
	}

	public static bool FPGBBDJIHMG
	{
		get
		{
			return DOBJEKBDGCE;
		}
	}

	private static JNEFNLEGJMM[] MAKMADPNBGO
	{
		get
		{
			if (!EJGBOPFGEOJ)
			{
				MDENPOMGLNO();
			}
			return AFKPHBEFGEN;
		}
	}

	private static JKHKOEPGCPO[] HOPMDBJBEMJ
	{
		get
		{
			if (!EJGBOPFGEOJ)
			{
				MDENPOMGLNO();
			}
			return GONMDIFBGFJ;
		}
	}

	private static BACLJEFBAMJ[] BHCLKELKCKC
	{
		get
		{
			if (!EJGBOPFGEOJ)
			{
				MDENPOMGLNO();
			}
			return OBCFNCBIIPP;
		}
	}

	public static void PHPMKJHMBDL()
	{
		if (!(UnityEngine.Object.FindObjectOfType<EventSystem>() != null))
		{
			Type typeFromHandle = typeof(EventSystem);
			new GameObject(typeFromHandle.Name, typeFromHandle, typeof(StandaloneInputModule));
		}
	}

	private void Awake()
	{
		PHPMKJHMBDL();
		LENBADIHBIK = this;
		FJDJDEEEDAH(true);
		MDENPOMGLNO();
		Array.ForEach(AFKPHBEFGEN, delegate(JNEFNLEGJMM FCCPLGMNKOK)
		{
			FCCPLGMNKOK.HCCGEPOLPHB();
		});
	}

	private void OnDisable()
	{
		MAOFKOJOLEK();
	}

	private void OnDestroy()
	{
		MAOFKOJOLEK();
	}

	private static void MAOFKOJOLEK()
	{
		EJGBOPFGEOJ = false;
		LENBADIHBIK = null;
	}

	private static void MDENPOMGLNO()
	{
		EJGBOPFGEOJ = true;
		AFKPHBEFGEN = KAGNKODNFOC.GetComponentsInChildren<JNEFNLEGJMM>(true);
		GONMDIFBGFJ = BIPEEAABINN<JKHKOEPGCPO>();
		OBCFNCBIIPP = BIPEEAABINN<BACLJEFBAMJ>();
	}

	private static T[] BIPEEAABINN<T>() where T : JNEFNLEGJMM
	{
		return MAKMADPNBGO.Where((JNEFNLEGJMM FFBEPGEKANM) => FFBEPGEKANM is T).Cast<T>().ToArray();
	}

	public static void FJDJDEEEDAH(bool EHAPKEKPMOE)
	{
		DOBJEKBDGCE = EHAPKEKPMOE;
		KAGNKODNFOC.enabled = EHAPKEKPMOE;
		KAGNKODNFOC.gameObject.SetActive(EHAPKEKPMOE);
	}

	public static bool FGCCFJPOKOJ(string GDPAGOAAJGG)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return true;
			}
		}
		return false;
	}

	public static bool IIFGAOGKFNE(string GDPAGOAAJGG)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return jNEFNLEGJMM.IOLDKGFCIJG;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return false;
	}

	public static void EMFFAFKJHEP(string GDPAGOAAJGG, bool EHAPKEKPMOE)
	{
		if (!DOBJEKBDGCE)
		{
			return;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				jNEFNLEGJMM.IOLDKGFCIJG = EHAPKEKPMOE;
				return;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
	}

	public static bool DPNGADFFFNP(string GDPAGOAAJGG)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return jNEFNLEGJMM.FPGBBDJIHMG;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return false;
	}

	public static void NPCGKCFJMIJ(string GDPAGOAAJGG, bool EHAPKEKPMOE)
	{
		if (!DOBJEKBDGCE)
		{
			return;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				jNEFNLEGJMM.FPGBBDJIHMG = EHAPKEKPMOE;
				return;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
	}

	public static bool FAGBFBIIJAN(string GDPAGOAAJGG)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return jNEFNLEGJMM.NPMNHJLHLKP;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return false;
	}

	public static void KLECEOIPMCJ(string GDPAGOAAJGG, bool EHAPKEKPMOE)
	{
		if (!DOBJEKBDGCE)
		{
			return;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				jNEFNLEGJMM.NPMNHJLHLKP = EHAPKEKPMOE;
				return;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
	}

	public static float PPECHIJCLHO(string GDPAGOAAJGG, GNMDFPDBPEI ONDLLKAPKFJ)
	{
		if (!DOBJEKBDGCE)
		{
			return 0f;
		}
		for (int i = 0; i < HOPMDBJBEMJ.Length; i++)
		{
			if (HOPMDBJBEMJ[i].KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return (ONDLLKAPKFJ != GNMDFPDBPEI.CKGPDOGEHBB) ? HOPMDBJBEMJ[i].EKCJABJKODG.value : HOPMDBJBEMJ[i].EFMADDOCBDN.value;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return 0f;
	}

	public static Vector2 PPECHIJCLHO(string GDPAGOAAJGG)
	{
		for (int i = 0; i < HOPMDBJBEMJ.Length; i++)
		{
			if (HOPMDBJBEMJ[i].KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return new Vector2(HOPMDBJBEMJ[i].EFMADDOCBDN.value, HOPMDBJBEMJ[i].EKCJABJKODG.value);
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return Vector2.zero;
	}

	public static bool PJOIHNMKCBB(string GDPAGOAAJGG, GNMDFPDBPEI ONDLLKAPKFJ)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		JKHKOEPGCPO[] array = HOPMDBJBEMJ;
		foreach (JKHKOEPGCPO jKHKOEPGCPO in array)
		{
			if (jKHKOEPGCPO.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return (ONDLLKAPKFJ != GNMDFPDBPEI.CKGPDOGEHBB) ? jKHKOEPGCPO.EKCJABJKODG.enabled : jKHKOEPGCPO.EFMADDOCBDN.enabled;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return false;
	}

	public static void KKDMBCCGKBJ(string GDPAGOAAJGG, GNMDFPDBPEI ONDLLKAPKFJ, bool EHAPKEKPMOE)
	{
		if (!DOBJEKBDGCE)
		{
			return;
		}
		JKHKOEPGCPO[] array = HOPMDBJBEMJ;
		foreach (JKHKOEPGCPO jKHKOEPGCPO in array)
		{
			if (jKHKOEPGCPO.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				switch (ONDLLKAPKFJ)
				{
				case GNMDFPDBPEI.CKGPDOGEHBB:
					jKHKOEPGCPO.EFMADDOCBDN.enabled = EHAPKEKPMOE;
					break;
				case GNMDFPDBPEI.IOKNFMCJIHM:
					jKHKOEPGCPO.EKCJABJKODG.enabled = EHAPKEKPMOE;
					break;
				default:
					Debug.LogError(string.Concat("Axis: ", ONDLLKAPKFJ, " not found!"));
					break;
				}
				return;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
	}

	public static bool DDJLHCCMLAC(string GDPAGOAAJGG, GNMDFPDBPEI ONDLLKAPKFJ)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		JKHKOEPGCPO[] array = HOPMDBJBEMJ;
		foreach (JKHKOEPGCPO jKHKOEPGCPO in array)
		{
			if (jKHKOEPGCPO.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return (ONDLLKAPKFJ != GNMDFPDBPEI.CKGPDOGEHBB) ? jKHKOEPGCPO.EKCJABJKODG.inverse : jKHKOEPGCPO.EFMADDOCBDN.inverse;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return false;
	}

	public static void GELGKMJMHPP(string GDPAGOAAJGG, GNMDFPDBPEI ONDLLKAPKFJ, bool EHAPKEKPMOE)
	{
		if (!DOBJEKBDGCE)
		{
			return;
		}
		JKHKOEPGCPO[] array = HOPMDBJBEMJ;
		foreach (JKHKOEPGCPO jKHKOEPGCPO in array)
		{
			if (jKHKOEPGCPO.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				switch (ONDLLKAPKFJ)
				{
				case GNMDFPDBPEI.CKGPDOGEHBB:
					jKHKOEPGCPO.EFMADDOCBDN.inverse = EHAPKEKPMOE;
					break;
				case GNMDFPDBPEI.IOKNFMCJIHM:
					jKHKOEPGCPO.EKCJABJKODG.inverse = EHAPKEKPMOE;
					break;
				default:
					Debug.LogError(string.Concat("Axis: ", ONDLLKAPKFJ, " not found!"));
					break;
				}
				return;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
	}

	public static float IEEKKHDFDDC(string GDPAGOAAJGG)
	{
		if (!DOBJEKBDGCE)
		{
			return 0f;
		}
		JKHKOEPGCPO[] array = HOPMDBJBEMJ;
		foreach (JKHKOEPGCPO jKHKOEPGCPO in array)
		{
			if (jKHKOEPGCPO.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return jKHKOEPGCPO.ICKMBHMOHNC;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return 0f;
	}

	public static void KOGJJHBHIOA(string GDPAGOAAJGG, float EHAPKEKPMOE)
	{
		if (!DOBJEKBDGCE)
		{
			return;
		}
		JKHKOEPGCPO[] array = HOPMDBJBEMJ;
		foreach (JKHKOEPGCPO jKHKOEPGCPO in array)
		{
			if (jKHKOEPGCPO.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				jKHKOEPGCPO.ICKMBHMOHNC = EHAPKEKPMOE;
				return;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
	}

	public static void FKKNAFDPBOC(bool EHAPKEKPMOE)
	{
		CAEHNGGCIJC cAEHNGGCIJC = new CAEHNGGCIJC();
		cAEHNGGCIJC.EHAPKEKPMOE = EHAPKEKPMOE;
		if (DOBJEKBDGCE)
		{
			Array.ForEach(HOPMDBJBEMJ, cAEHNGGCIJC.BEKJDJFLJJC);
		}
	}

	public static bool KJFHJOHBBOJ(string NPNKAKNAGMI, BEONOIBCNBC DGKJKNLKOFH)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		for (int i = 0; i < BHCLKELKCKC.Length; i++)
		{
			if (BHCLKELKCKC[i].KGLOKPGOGLD == NPNKAKNAGMI)
			{
				switch (DGKJKNLKOFH)
				{
				case BEONOIBCNBC.JNODLNLEMNM:
					return BHCLKELKCKC[i].MCFEOMAEBCK;
				case BEONOIBCNBC.MLAHIBNJKDJ:
					return BHCLKELKCKC[i].CPNHAENAHHJ;
				case BEONOIBCNBC.BCIHMPMMBBP:
					return BHCLKELKCKC[i].GDKHEJOFEAA;
				case BEONOIBCNBC.JJHMBCMFBCG:
					return BHCLKELKCKC[i].PCGHPBKGPLB;
				}
			}
		}
		Debug.LogError("Button: " + NPNKAKNAGMI + " not found!");
		return false;
	}

	[Obsolete("Please use 'GetAction' instead.")]
	public static bool MPIHIMAGIDO(string NPNKAKNAGMI)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		BACLJEFBAMJ[] array = BHCLKELKCKC;
		foreach (BACLJEFBAMJ bACLJEFBAMJ in array)
		{
			if (bACLJEFBAMJ.KGLOKPGOGLD == NPNKAKNAGMI)
			{
				return bACLJEFBAMJ.MCFEOMAEBCK;
			}
		}
		Debug.LogError("Button: " + NPNKAKNAGMI + " not found!");
		return false;
	}

	[Obsolete("Please use 'GetAction' instead.")]
	public static bool FLNBDFGIEDG(string NPNKAKNAGMI)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		BACLJEFBAMJ[] array = BHCLKELKCKC;
		foreach (BACLJEFBAMJ bACLJEFBAMJ in array)
		{
			if (bACLJEFBAMJ.KGLOKPGOGLD == NPNKAKNAGMI)
			{
				return bACLJEFBAMJ.CPNHAENAHHJ;
			}
		}
		Debug.LogError("Button: " + NPNKAKNAGMI + " not found!");
		return false;
	}

	[Obsolete("Please use 'GetAction' instead.")]
	public static bool KMOBNLIGHDL(string NPNKAKNAGMI)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		BACLJEFBAMJ[] array = BHCLKELKCKC;
		foreach (BACLJEFBAMJ bACLJEFBAMJ in array)
		{
			if (bACLJEFBAMJ.KGLOKPGOGLD == NPNKAKNAGMI)
			{
				return bACLJEFBAMJ.GDKHEJOFEAA;
			}
		}
		Debug.LogError("Button: " + NPNKAKNAGMI + " not found!");
		return false;
	}

	[Obsolete("Please use 'GetAction' instead.")]
	public static bool KALPCOJPJNE(string NPNKAKNAGMI)
	{
		if (!DOBJEKBDGCE)
		{
			return false;
		}
		BACLJEFBAMJ[] array = BHCLKELKCKC;
		foreach (BACLJEFBAMJ bACLJEFBAMJ in array)
		{
			if (bACLJEFBAMJ.KGLOKPGOGLD == NPNKAKNAGMI)
			{
				return bACLJEFBAMJ.PCGHPBKGPLB;
			}
		}
		Debug.LogError("Button: " + NPNKAKNAGMI + " not found!");
		return false;
	}

	public static PAEEOJFACBD ECOIOMKCNAF(string GDPAGOAAJGG)
	{
		if (!DOBJEKBDGCE)
		{
			return PAEEOJFACBD.NNEJHHNCBJF;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return jNEFNLEGJMM.FDICPOLBAEN;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return PAEEOJFACBD.NNEJHHNCBJF;
	}

	public static void BJOEKAEEOMA(string GDPAGOAAJGG, PAEEOJFACBD BJIIFPFIHHG)
	{
		if (!DOBJEKBDGCE)
		{
			return;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				jNEFNLEGJMM.FDICPOLBAEN = BJIIFPFIHHG;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
	}

	public static IJCCPIAIFDJ GKDAMDIPPJI(string GDPAGOAAJGG)
	{
		if (!DOBJEKBDGCE)
		{
			return IJCCPIAIFDJ.HHFPPPILFBP;
		}
		JNEFNLEGJMM[] array = MAKMADPNBGO;
		foreach (JNEFNLEGJMM jNEFNLEGJMM in array)
		{
			if (jNEFNLEGJMM.KGLOKPGOGLD == GDPAGOAAJGG)
			{
				return jNEFNLEGJMM.MNAANMAOECP;
			}
		}
		Debug.LogError("Controller: " + GDPAGOAAJGG + " not found!");
		return IJCCPIAIFDJ.HHFPPPILFBP;
	}

	[CompilerGenerated]
	private static void CODPAIAOGEL(JNEFNLEGJMM FCCPLGMNKOK)
	{
		FCCPLGMNKOK.HCCGEPOLPHB();
	}

	[CompilerGenerated]
	private static bool HJGFPEOFICN<T>(JNEFNLEGJMM FFBEPGEKANM) where T : JNEFNLEGJMM
	{
		return FFBEPGEKANM is T;
	}
}
