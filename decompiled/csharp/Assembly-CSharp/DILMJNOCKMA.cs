using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CodeStage.AntiCheat.ObscuredTypes;
using ProtoBuf;

[ProtoContract(ImplicitFields = ImplicitFields.None)]
public class DILMJNOCKMA
{
	[ProtoMember(1)]
	public IFHFLAJCMJD DJEPHFMKCGJ = new IFHFLAJCMJD();

	public bool FJBKIMDHMFO;

	public bool DJEGJGKCKAJ;

	public string LIEKABKEJOG;

	public ObscuredInt LBKOHPIDKFH;

	public ObscuredInt KIDFODCBGNA;

	public string GJPOFKBMIEE = string.Empty;

	public ObscuredInt ECKDHMKHHJJ;

	public List<string> CIACMOBHCLJ = new List<string>();

	public KMEAKNOINAG KFPIDMCIADK = KMEAKNOINAG.JKALFGNBMEH;

	public ObscuredInt INEEKJECAKH = ObscuredInt.FNIPJFGEFFD(0);

	private static BinaryFormatter MHFMEIGOKOK = new BinaryFormatter();

	public string EAMIANGGPBI = string.Empty;

	public bool OKGHAOKEAMI;

	public bool PEBKNIGPDJH;

	public List<string> ILKOCIGJJGC = new List<string>();

	public List<string> JHCMKKNEHEL = new List<string>();

	public List<string> FJAJMKDGCNN = new List<string>();

	public int MHEOBOMBCFM;

	public string CHMIJHGICBL = string.Empty;

	public string NIGOGFAMFIB
	{
		get
		{
			return DJEPHFMKCGJ.ALLLIGGPLMK ?? string.Empty;
		}
		set
		{
			DJEPHFMKCGJ.ALLLIGGPLMK = value;
		}
	}

	public float JDDGBFOOCHE => (float)ObscuredInt.FNIPJFGEFFD(LBKOHPIDKFH) / (float)(ObscuredInt.FNIPJFGEFFD(KIDFODCBGNA) + 1);

	public ObscuredBool JGJGKDGFFAA => ObscuredBool.FNIPJFGEFFD(KFPIDMCIADK == KMEAKNOINAG.JPIHDIPKGNJ || KFPIDMCIADK == KMEAKNOINAG.DEGGKLCBPED);

	public ObscuredBool POPPLIPEOGF => ObscuredBool.FNIPJFGEFFD(KFPIDMCIADK != KMEAKNOINAG.JKALFGNBMEH && KFPIDMCIADK != KMEAKNOINAG.BLBOPPEBDFH);

	public ObscuredBool EPMOFPNGEAG => ObscuredBool.FNIPJFGEFFD(KFPIDMCIADK != KMEAKNOINAG.JKALFGNBMEH);

	public ObscuredBool CHBPHCAGPEO => ObscuredBool.FNIPJFGEFFD(KFPIDMCIADK == KMEAKNOINAG.DEGGKLCBPED);

	public ObscuredInt JCMCPIPHDHB
	{
		get
		{
			return INEEKJECAKH;
		}
		set
		{
			INEEKJECAKH = value;
		}
	}

	public DILMJNOCKMA DHBGHDFFOLN(BinaryReader LKLIMHLBGMG)
	{
		int num = LKLIMHLBGMG.ReadInt32();
		if (num-- > 0)
		{
			NIGOGFAMFIB = LKLIMHLBGMG.ReadString();
		}
		if (num-- > 0)
		{
			KFPIDMCIADK = (KMEAKNOINAG)LKLIMHLBGMG.ReadByte();
		}
		if (num-- > 0)
		{
			ECKDHMKHHJJ = ObscuredInt.FNIPJFGEFFD(LKLIMHLBGMG.ReadByte());
		}
		if (num-- > 0)
		{
			GJPOFKBMIEE = LKLIMHLBGMG.ReadString();
		}
		if (num-- > 0)
		{
			CHMIJHGICBL = LKLIMHLBGMG.ReadString();
		}
		return this;
	}

	public void NLAHGEODPAF(BinaryWriter OINHLEEFCKE)
	{
		OINHLEEFCKE.Write(5);
		OINHLEEFCKE.Write(NIGOGFAMFIB);
		OINHLEEFCKE.Write((byte)KFPIDMCIADK);
		OINHLEEFCKE.Write((byte)ObscuredInt.FNIPJFGEFFD(ECKDHMKHHJJ));
		OINHLEEFCKE.Write(GJPOFKBMIEE);
		OINHLEEFCKE.Write(CHMIJHGICBL);
	}

	public static void MOHMCMAMDAL(string LGNIFJCEECH)
	{
	}

	public override int GetHashCode()
	{
		return NIGOGFAMFIB.GetHashCode();
	}

	public override bool Equals(object FFBEPGEKANM)
	{
		return FFBEPGEKANM.GetHashCode() == GetHashCode();
	}

	public void OBKMIHILMLH(BinaryWriter OINHLEEFCKE)
	{
		MHFMEIGOKOK.Serialize(OINHLEEFCKE.BaseStream, this);
	}

	public static DILMJNOCKMA DEJLKMOPAJP(BinaryReader LKLIMHLBGMG)
	{
		return (DILMJNOCKMA)MHFMEIGOKOK.Deserialize(LKLIMHLBGMG.BaseStream);
	}
}
