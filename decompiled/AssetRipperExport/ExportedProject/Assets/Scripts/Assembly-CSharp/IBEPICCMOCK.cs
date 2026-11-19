using System.Collections.Generic;
using UnityEngine;

public class IBEPICCMOCK : FOGIOGKLNIP
{
	public new DownloadObjects BHCIEFHBOPB;

	public new GUIStringObject FKICDOGJIFN;

	public new PrefsObjs EKPLFFMMPEA;

	public new BPADKFMBHBE IOCECFNAKJM;

	public bool IHBFPOOLCFD;

	public string BJAFFONCOGA;

	[EnumFlags]
	public CILHLJOJKKF EHJJEHCPHEP;

	public bool LDIIPMIIBMA;

	public bool FMFLMEBHEPN;

	public bool MCENKACBEHI;

	public bool MHOHCMOOGCC;

	public bool FMFBOFDMIOG;

	public bool JOKJANPLMHI;

	public bool ICOMKPIKMDK;

	public bool JCEDGFEJCBH;

	internal bool AJMMAEFHFNL;

	internal bool IKODMMOKAIO;

	public bool PEMANKHDNGO;

	internal bool PBECBICNHPK;

	internal bool FIMLGLIGGDP = true;

	public bool PPNJAEOCJKP;

	public bool CPJKMDCJANM = true;

	public bool BHHJDJCILHC;

	public bool AJJPBLBJNFB = true;

	public bool IDNIJGEJJKH;

	internal bool DEMKLLPLDBO;

	public string AMKPFEHOHJD;

	public string DKPGCEABLDP;

	public string HKAGPIIOKEP;

	public string[] MMHLHLOBIMI;

	public int GJPOFKBMIEE;

	public string NJAGHCNHJAO;

	public bool ICFJPFPPMBP;

	public Dictionary<string, float> FFKOEOKPAMF;

	public float[] OFEHJLELLAN = new float[0];

	public string[] DJBDDPKLKDP = new string[0];

	public bool KKKONAPJJKO;

	public bool KLMENBBCDJC;

	public bool ECPNABNEGAN;

	public string[] LMPHJCDENFF;

	public string[] IDHMKKBEBCG;

	public string[] MGKDMDLBCOE;

	public float EIFADHFAGJO = 0.03f;

	public Dictionary<string, float> IGMBMPMHMOJ
	{
		get
		{
			if (FFKOEOKPAMF == null)
			{
				FFKOEOKPAMF = new Dictionary<string, float>();
				for (int i = 0; i < DJBDDPKLKDP.Length; i++)
				{
					FFKOEOKPAMF[DJBDDPKLKDP[i]] = OFEHJLELLAN[i];
				}
			}
			return FFKOEOKPAMF;
		}
	}

	public void MBOGPAHFGMF()
	{
		if (!Debug.isDebugBuild)
		{
			FMFLMEBHEPN = (FOGIOGKLNIP.OMMLFOEPEEK = (FOGIOGKLNIP.LPLJMLGKCLK.PBPPMJLAODE = (FIMLGLIGGDP = (PBECBICNHPK = (PEMANKHDNGO = (FOGIOGKLNIP.LPLJMLGKCLK.FDFIHADJLAO = (IDNIJGEJJKH = (DEMKLLPLDBO = (AJMMAEFHFNL = (JCEDGFEJCBH = (IKODMMOKAIO = (JOKJANPLMHI = (MHOHCMOOGCC = (MCENKACBEHI = (FMFBOFDMIOG = false)))))))))))))));
		}
		if (base.MJEAIGGPIKN)
		{
			KKKONAPJJKO = false;
			ICOMKPIKMDK = true;
		}
		FOGIOGKLNIP.OMMLFOEPEEK = FMFBOFDMIOG;
	}

	public void EJGMBJBMACO(CILHLJOJKKF JOIJIECIMOH, bool EHAPKEKPMOE)
	{
		if (EHAPKEKPMOE)
		{
			EHJJEHCPHEP |= JOIJIECIMOH;
		}
		else
		{
			EHJJEHCPHEP &= ~JOIJIECIMOH;
		}
	}

	public bool FOIAAEMIIMM(CILHLJOJKKF JOIJIECIMOH)
	{
		return (EHJJEHCPHEP & JOIJIECIMOH) != 0;
	}

	public float OGAIBIOLFCN(AudioClip LGNIFJCEECH)
	{
		if (LGNIFJCEECH == null)
		{
			return 1f;
		}
		float value;
		return (!IGMBMPMHMOJ.TryGetValue(LGNIFJCEECH.name, out value)) ? 1f : value;
	}
}
