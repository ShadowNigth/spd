using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class AHDMBKHBJII : FOGIOGKLNIP
{
	public int KIDFODCBGNA;

	private int LBKOHPIDKFH;

	private float IDDAJCBFBEA;

	public static string[] CMDHJDEOCPM = new string[0];

	private string HINDBLMPIOP;

	private Dictionary<string, int> KGFKJJCEEHM = new Dictionary<string, int>();

	private Dictionary<string, int> PJBFAGDNMNA = new Dictionary<string, int>();

	private Dictionary<string, int> NOHHODIGAAA = new Dictionary<string, int>();

	public HashSet<string> ADFEGJPNDEI = new HashSet<string>();

	private string OMJMCAINHJP
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("headShotsTotalStr", string.Empty);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("headShotsTotalStr", value);
		}
	}

	private string KBDJAGFPJLK
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("ShotsTotalStr", string.Empty);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("ShotsTotalStr", value);
		}
	}

	private string BCEHKLGAPOH
	{
		get
		{
			return FOGIOGKLNIP.CEKCOJEJPAN("ShotsMapStr", string.Empty);
		}
		set
		{
			FOGIOGKLNIP.GKKEPIMNFBB("ShotsMapStr", value);
		}
	}

	public int LEGANDNAMHK
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("bombPlants");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("bombPlants", value);
		}
	}

	public int NJGHNFIDDBM
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("flagCaptures");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("flagCaptures", value);
		}
	}

	public int MHHPDHLIBMO
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("hostageCaptures");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("hostageCaptures", value);
		}
	}

	public int BNBGEGKILHM
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("bombDefuse");
		}
		set
		{
			FOGIOGKLNIP.BBKFOHCEOCK("bombDefuse", value);
		}
	}

	private string DNHLBGLJBBD => base.JNPCOJFBJGP ? "SinglePlayer" : ((!ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.DJBGAOOAGEO)) ? string.Concat(FOGIOGKLNIP.LPLJMLGKCLK.DNHLBGLJBBD, string.Empty) : "Custom");

	public override void Awake()
	{
		FOGIOGKLNIP.EIIMBNKHJJA = this;
		base.Awake();
		KGFKJJCEEHM = BNCEEBLCFPC(OMJMCAINHJP);
		PJBFAGDNMNA = BNCEEBLCFPC(KBDJAGFPJLK);
		NOHHODIGAAA = BNCEEBLCFPC(BCEHKLGAPOH);
	}

	public void Start()
	{
		if (base.NENPALDENAL && !base.JNPCOJFBJGP)
		{
			HKOJBJNCIAP(base.FKICDOGJIFN.AwardsHostownserver);
		}
		if (base.JNPCOJFBJGP)
		{
			HKOJBJNCIAP(base.FKICDOGJIFN.AwardsPlaySinglePlayer);
		}
	}

	public int KLMDPDIJJMD()
	{
		return LBKOHPIDKFH;
	}

	public string[] JNHEHGAKOIL()
	{
		OMJMCAINHJP = HAPOOCLLNEA(KGFKJJCEEHM);
		KBDJAGFPJLK = HAPOOCLLNEA(PJBFAGDNMNA);
		BCEHKLGAPOH = HAPOOCLLNEA(NOHHODIGAAA);
		string[] array = ADFEGJPNDEI.Except(CMDHJDEOCPM).ToArray();
		CMDHJDEOCPM = array.Union(CMDHJDEOCPM).ToArray();
		return array;
	}

	public string HAPOOCLLNEA(Dictionary<string, int> CCHMDKPJECN)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, int> item in CCHMDKPJECN)
		{
			stringBuilder.AppendLine(item.Key + "#" + item.Value);
		}
		return stringBuilder.ToString();
	}

	public Dictionary<string, int> BNCEEBLCFPC(string LGNIFJCEECH)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		string[] array = LGNIFJCEECH.Split("\r\n");
		foreach (string text in array)
		{
			if (!string.IsNullOrEmpty(text))
			{
				string[] array2 = text.Split('#');
				dictionary.Add(array2[0], int.Parse(array2[1]));
			}
		}
		return dictionary;
	}

	public void ONHMHNKCHEK()
	{
		if (++MHHPDHLIBMO == 20)
		{
			ADFEGJPNDEI.Add(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AwardsSaved20Hostages));
		}
	}

	public void MPJCKINAGNC()
	{
		if (++BNBGEGKILHM == 20)
		{
			ADFEGJPNDEI.Add(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AwardsDiffused20Bombs));
		}
	}

	public void BHDNBJJNNGG()
	{
		if (++NJGHNFIDDBM == 20)
		{
			ADFEGJPNDEI.Add(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AwardsCaptured20Flags));
		}
	}

	public void HPCHODAEOPK()
	{
		ADFEGJPNDEI.Add(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AwardsPlanted20Bombs));
	}

	public void DMFHMHNAOOP(string JEPMMPCNEHO, bool DNEKPHKNMEJ)
	{
		KIDFODCBGNA = 0;
		if (HINDBLMPIOP == JEPMMPCNEHO && Time.time - IDDAJCBFBEA < 3f)
		{
			LBKOHPIDKFH++;
		}
		else
		{
			LBKOHPIDKFH = 1;
		}
		if (LBKOHPIDKFH == 4)
		{
			HKOJBJNCIAP(string.Format(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.Awards4killsstreakwith), JEPMMPCNEHO, DNHLBGLJBBD));
		}
		if (LBKOHPIDKFH == 20)
		{
			HKOJBJNCIAP(string.Format(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.Awards20killsstreakwith), JEPMMPCNEHO, DNHLBGLJBBD));
		}
		IDDAJCBFBEA = Time.time;
		HINDBLMPIOP = JEPMMPCNEHO;
		string text = FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AwardsWith) + JEPMMPCNEHO + FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AwardsIn) + DNHLBGLJBBD;
		if (DNEKPHKNMEJ)
		{
			if (!KGFKJJCEEHM.ContainsKey(text))
			{
				KGFKJJCEEHM[text] = 0;
			}
			KGFKJJCEEHM[text]++;
		}
		if (!PJBFAGDNMNA.ContainsKey(text))
		{
			PJBFAGDNMNA[text] = 0;
		}
		PJBFAGDNMNA[text]++;
		if (!NOHHODIGAAA.ContainsKey(FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF)))
		{
			NOHHODIGAAA[FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF)] = 0;
		}
		NOHHODIGAAA[FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF)]++;
		if (PJBFAGDNMNA.TryGet(text) == 100)
		{
			HKOJBJNCIAP(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.Awards100kills) + text);
		}
		if (KGFKJJCEEHM.TryGet(text) == 50)
		{
			HKOJBJNCIAP(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.Awards50headshots) + text);
		}
		if (NOHHODIGAAA.TryGet(FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF)) == 100)
		{
			HKOJBJNCIAP(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.Awards100killson) + FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.GIGJFCBMKMO(FOGIOGKLNIP.LPLJMLGKCLK.PBKOADAIOGF)));
		}
	}

	public void HKOJBJNCIAP(string LGNIFJCEECH)
	{
		if (!CMDHJDEOCPM.Contains(LGNIFJCEECH) && ADFEGJPNDEI.Add(LGNIFJCEECH))
		{
			FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ(base.FKICDOGJIFN.AwardsAchievement + " " + LGNIFJCEECH);
		}
	}

	public override void AILPFINEAEK()
	{
		base.AILPFINEAEK();
	}

	public void ABMGCEBCICJ()
	{
		if (++KIDFODCBGNA == 15)
		{
			ADFEGJPNDEI.Add(FOGIOGKLNIP.FHHPMGJCHJL(base.FKICDOGJIFN.AwardsA15deathsstreak));
		}
	}
}
