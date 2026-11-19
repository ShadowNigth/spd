using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

public class EHIHAKKDHPO : FOGIOGKLNIP
{
	[CompilerGenerated]
	private sealed class BPLCJIKLJJK
	{
		internal string LGNIFJCEECH;

		internal void BEKJDJFLJJC(BinaryWriter ACALPNFLMEP)
		{
			ACALPNFLMEP.Write(OHMGCMOBAGN.FNJENJEIMJA.ToString());
			ACALPNFLMEP.Write(LGNIFJCEECH);
		}
	}

	[CompilerGenerated]
	private sealed class CMLLCFPOCPE
	{
		internal string OAIFDCCEGMN;

		internal bool BEKJDJFLJJC(KMLFAFFNIHM AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.JGAFDKGALIP == OAIFDCCEGMN;
		}
	}

	[CompilerGenerated]
	private sealed class LHOGIKNDLEC
	{
		internal string OAIFDCCEGMN;

		internal bool BEKJDJFLJJC(KMLFAFFNIHM AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.JGAFDKGALIP == OAIFDCCEGMN;
		}
	}

	[CompilerGenerated]
	private sealed class INMJPDCLKJI
	{
		internal string AMNKEEKGELD;

		internal bool BEKJDJFLJJC(KMLFAFFNIHM AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.JGAFDKGALIP == AMNKEEKGELD;
		}
	}

	[CompilerGenerated]
	private sealed class DCBOBEJGGOL
	{
		internal string JGAFDKGALIP;

		internal void BEKJDJFLJJC(BinaryWriter ACALPNFLMEP)
		{
			ACALPNFLMEP.Write(OHMGCMOBAGN.GEGHFPHHHMH.ToString());
			ACALPNFLMEP.Write(JGAFDKGALIP);
		}
	}

	[CompilerGenerated]
	private sealed class KGDAKOIANBI
	{
		internal string JGAFDKGALIP;

		internal string AGEALAOCFKM;

		internal void BEKJDJFLJJC(BinaryWriter ACALPNFLMEP)
		{
			ACALPNFLMEP.Write(OHMGCMOBAGN.BPBHMHNBHJB.ToString());
			ACALPNFLMEP.Write(JGAFDKGALIP);
			ACALPNFLMEP.Write(AGEALAOCFKM);
		}
	}

	[CompilerGenerated]
	private sealed class MPPIFPCGBEG
	{
		internal bool LCBKHLLPIGM;

		internal void BEKJDJFLJJC(BinaryWriter GDIFBJBOCJM)
		{
			GDIFBJBOCJM.Write(OHMGCMOBAGN.DJDFDKAKJJA.ToString());
			GDIFBJBOCJM.Write(LCBKHLLPIGM);
		}
	}

	private BEJHFGDPDLI JDFKPOMKMNJ = new BEJHFGDPDLI();

	public OOCEFIKPECG HGOFJOBHDGG = new OOCEFIKPECG();

	[CompilerGenerated]
	private static Func<DILMJNOCKMA, int> ACJNADIPOMC;

	[CompilerGenerated]
	private static Action<BinaryWriter> HJJBAKLDAEB;

	internal string PKPJEFHKPFN => FOGIOGKLNIP.LPLJMLGKCLK.GPJONKKMEKD;

	public string ECPLKFHCHEB => FOGIOGKLNIP.CHDJHJFGMNA("ircserver");

	public bool IHCCAJJIBEL => HGOFJOBHDGG.IHCCAJJIBEL;

	public void JFBMPGBNBCF(Action<BinaryWriter> AEMBPMJMOAB)
	{
		HGOFJOBHDGG.JFBMPGBNBCF(OOCEFIKPECG.DMEAJPICMNP(AEMBPMJMOAB));
	}

	public void JFBMPGBNBCF(OHMGCMOBAGN NKMIHFIEOHD, params object[] KEHPPPLGADG)
	{
		HGOFJOBHDGG.JFBMPGBNBCF(OOCEFIKPECG.DMEAJPICMNP(NKMIHFIEOHD, KEHPPPLGADG));
	}

	public void JFBMPGBNBCF(OHMGCMOBAGN NKMIHFIEOHD, Action<BinaryReader> OMBCDMOHJOK, params object[] KEHPPPLGADG)
	{
		HGOFJOBHDGG.JFBMPGBNBCF(OOCEFIKPECG.DMEAJPICMNP(NKMIHFIEOHD, OMBCDMOHJOK, KEHPPPLGADG));
	}

	public void BIJIEONMGOL()
	{
		FOGIOGKLNIP.LIJNLAAEENC("Irc - Reconnect()");
		HGOFJOBHDGG = new OOCEFIKPECG().EFMFNHMEKAG(DNBLCHCALCB.LKCFBEGAGCM, HFODCIPAAFJ, ECPLKFHCHEB);
		HGOFJOBHDGG.JCFECCHPOJN = delegate
		{
			BKKHMNCDFLF("Connceted to irc " + HGOFJOBHDGG.IHCCAJJIBEL);
			JFBMPGBNBCF(OHMGCMOBAGN.IFNKGJDHGDD, PKPJEFHKPFN);
			JFBMPGBNBCF(delegate(BinaryWriter GDIFBJBOCJM)
			{
				GDIFBJBOCJM.Write(OHMGCMOBAGN.PAECJMCHEOC.ToString());
				FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.NLAHGEODPAF(GDIFBJBOCJM);
			});
			FOGIOGKLNIP.BEHFNEAKDAL.EFJFPONHEND();
		};
		HGOFJOBHDGG.PECHEKLIDBI = FOGIOGKLNIP.BEHFNEAKDAL.KHHMJPJAGBO;
	}

	private void HFODCIPAAFJ(IAsyncResult ECAGONEFPCC)
	{
	}

	public void NKMONJIIOJH(string LGNIFJCEECH)
	{
		JFBMPGBNBCF(delegate(BinaryWriter ACALPNFLMEP)
		{
			ACALPNFLMEP.Write(OHMGCMOBAGN.FNJENJEIMJA.ToString());
			ACALPNFLMEP.Write(LGNIFJCEECH);
		});
	}

	public void Update()
	{
		List<byte[]> list = null;
		if (JDFKPOMKMNJ.ELKBOHAOPDL(10))
		{
			list = HGOFJOBHDGG.GCHPMCEIEMK();
		}
		if (list != null)
		{
			foreach (byte[] item in list)
			{
				using BinaryReader binaryReader = new BinaryReader(new MemoryStream(item));
				string value = binaryReader.ReadString();
				switch ((OHMGCMOBAGN)Enum.Parse(typeof(OHMGCMOBAGN), value))
				{
				case OHMGCMOBAGN.BPBHMHNBHJB:
				{
					string fLHJDFCNDPJ = binaryReader.ReadString();
					string hDGELEFBNAJ = binaryReader.ReadString();
					string lGNIFJCEECH = binaryReader.ReadString();
					FOGIOGKLNIP.BEHFNEAKDAL.KEIGOIECILO(fLHJDFCNDPJ, hDGELEFBNAJ, lGNIFJCEECH);
					break;
				}
				case OHMGCMOBAGN.LNGKBDIANKJ:
				{
					string OAIFDCCEGMN2 = binaryReader.ReadString();
					int num2 = binaryReader.ReadInt32();
					KMLFAFFNIHM kMLFAFFNIHM = FOGIOGKLNIP.BEHFNEAKDAL.IJBOGIPFLOF.FirstOrDefault((KMLFAFFNIHM AEMBPMJMOAB) => AEMBPMJMOAB.JGAFDKGALIP == OAIFDCCEGMN2);
					List<DILMJNOCKMA> list2 = new List<DILMJNOCKMA>();
					for (int i = 0; i < num2; i++)
					{
						list2.Add(new DILMJNOCKMA().DHBGHDFFOLN(binaryReader));
					}
					foreach (DILMJNOCKMA item2 in list2.OrderBy((DILMJNOCKMA AEMBPMJMOAB) => ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.ECKDHMKHHJJ) + (ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.POPPLIPEOGF) ? (-100) : 0)))
					{
						if (!kMLFAFFNIHM.HPAGKBOOHMH.ContainsKey(item2.NIGOGFAMFIB))
						{
							kMLFAFFNIHM.HPAGKBOOHMH.Add(item2.NIGOGFAMFIB, item2);
						}
					}
					BKKHMNCDFLF("UserList received " + OAIFDCCEGMN2 + " user count " + kMLFAFFNIHM.HPAGKBOOHMH.Count);
					break;
				}
				case OHMGCMOBAGN.POENMJCOBNP:
					FOGIOGKLNIP.BEHFNEAKDAL.JDKLABMJIPB(DILMJNOCKMA.DEJLKMOPAJP(binaryReader));
					break;
				case OHMGCMOBAGN.HBLKMEEMOLI:
				{
					string OAIFDCCEGMN = binaryReader.ReadString();
					string key2 = binaryReader.ReadString();
					KMLFAFFNIHM kMLFAFFNIHM2 = FOGIOGKLNIP.BEHFNEAKDAL.IJBOGIPFLOF.FirstOrDefault((KMLFAFFNIHM AEMBPMJMOAB) => AEMBPMJMOAB.JGAFDKGALIP == OAIFDCCEGMN);
					kMLFAFFNIHM2.HPAGKBOOHMH.Remove(key2);
					break;
				}
				case OHMGCMOBAGN.HAJNPHIHPOK:
				{
					string AMNKEEKGELD = binaryReader.ReadString();
					DILMJNOCKMA dILMJNOCKMA = new DILMJNOCKMA().DHBGHDFFOLN(binaryReader);
					Dictionary<string, DILMJNOCKMA> hPAGKBOOHMH = FOGIOGKLNIP.BEHFNEAKDAL.IJBOGIPFLOF.FirstOrDefault((KMLFAFFNIHM AEMBPMJMOAB) => AEMBPMJMOAB.JGAFDKGALIP == AMNKEEKGELD).HPAGKBOOHMH;
					if (!hPAGKBOOHMH.ContainsKey(dILMJNOCKMA.NIGOGFAMFIB))
					{
						hPAGKBOOHMH.Add(dILMJNOCKMA.NIGOGFAMFIB, dILMJNOCKMA);
					}
					BKKHMNCDFLF(dILMJNOCKMA.NIGOGFAMFIB + " joined channel " + AMNKEEKGELD);
					break;
				}
				case OHMGCMOBAGN.OGNANBOCPPO:
				{
					int num = binaryReader.ReadInt32();
					JFBMPGBNBCF(OHMGCMOBAGN.FMFBJCAJGGI, num);
					break;
				}
				case OHMGCMOBAGN.FMFBJCAJGGI:
					FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.MHEOBOMBCFM = Environment.TickCount - binaryReader.ReadInt32();
					break;
				case OHMGCMOBAGN.JLFPKAHPHKI:
				{
					int key = binaryReader.ReadInt32();
					Action<BinaryReader> action = FOGIOGKLNIP.BGMIEGBKLFD[key];
					FOGIOGKLNIP.BGMIEGBKLFD.Remove(key);
					action(binaryReader);
					break;
				}
				case OHMGCMOBAGN.GEGHFPHHHMH:
				case OHMGCMOBAGN.PAECJMCHEOC:
				case OHMGCMOBAGN.MDAGMEKENHO:
				case OHMGCMOBAGN.DJDFDKAKJJA:
				case OHMGCMOBAGN.KJJMEBGCMKK:
					break;
				}
			}
		}
		if (JDFKPOMKMNJ.NFMIBMIGJMH(5000))
		{
			JFBMPGBNBCF(OHMGCMOBAGN.OGNANBOCPPO, Environment.TickCount);
		}
		JDFKPOMKMNJ.OJFAJPLDPPK();
	}

	public void OnApplicationQuit()
	{
		HGOFJOBHDGG.IOELOKNDNDG();
	}

	public void EHHENICIPCE(string JGAFDKGALIP)
	{
		JFBMPGBNBCF(delegate(BinaryWriter ACALPNFLMEP)
		{
			ACALPNFLMEP.Write(OHMGCMOBAGN.GEGHFPHHHMH.ToString());
			ACALPNFLMEP.Write(JGAFDKGALIP);
		});
	}

	public void BADNDCNACDF(string JGAFDKGALIP, string AGEALAOCFKM, bool LCBKHLLPIGM)
	{
		FOGIOGKLNIP.LIJNLAAEENC("IRC - SendIrcMessage");
		FOGIOGKLNIP.LIJNLAAEENC("chan: " + JGAFDKGALIP);
		FOGIOGKLNIP.LIJNLAAEENC("input: " + AGEALAOCFKM);
		JFBMPGBNBCF(delegate(BinaryWriter ACALPNFLMEP)
		{
			ACALPNFLMEP.Write(OHMGCMOBAGN.BPBHMHNBHJB.ToString());
			ACALPNFLMEP.Write(JGAFDKGALIP);
			ACALPNFLMEP.Write(AGEALAOCFKM);
		});
	}

	public void IKFLDKJOPAG(string IIKAFLBAEML)
	{
	}

	public void DJDFDKAKJJA(bool LCBKHLLPIGM)
	{
		JFBMPGBNBCF(delegate(BinaryWriter GDIFBJBOCJM)
		{
			GDIFBJBOCJM.Write(OHMGCMOBAGN.DJDFDKAKJJA.ToString());
			GDIFBJBOCJM.Write(LCBKHLLPIGM);
		});
	}

	[CompilerGenerated]
	private void KCEKDGKICIG()
	{
		BKKHMNCDFLF("Connceted to irc " + HGOFJOBHDGG.IHCCAJJIBEL);
		JFBMPGBNBCF(OHMGCMOBAGN.IFNKGJDHGDD, PKPJEFHKPFN);
		JFBMPGBNBCF(delegate(BinaryWriter GDIFBJBOCJM)
		{
			GDIFBJBOCJM.Write(OHMGCMOBAGN.PAECJMCHEOC.ToString());
			FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.NLAHGEODPAF(GDIFBJBOCJM);
		});
		FOGIOGKLNIP.BEHFNEAKDAL.EFJFPONHEND();
	}

	[CompilerGenerated]
	private static int NBECBCLALHF(DILMJNOCKMA AEMBPMJMOAB)
	{
		return ObscuredInt.FNIPJFGEFFD(AEMBPMJMOAB.ECKDHMKHHJJ) + (ObscuredBool.FNIPJFGEFFD(AEMBPMJMOAB.POPPLIPEOGF) ? (-100) : 0);
	}

	[CompilerGenerated]
	private static void MEPPEKNKJMF(BinaryWriter GDIFBJBOCJM)
	{
		GDIFBJBOCJM.Write(OHMGCMOBAGN.PAECJMCHEOC.ToString());
		FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.NLAHGEODPAF(GDIFBJBOCJM);
	}
}
