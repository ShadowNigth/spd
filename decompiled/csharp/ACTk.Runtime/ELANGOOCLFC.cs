using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class ELANGOOCLFC
{
	[CompilerGenerated]
	private static Comparison<FEFLJHGGEOJ> ACJNADIPOMC;

	public string FAABMGHNAIB { get; }

	public FEFLJHGGEOJ[] MIBEKBPHPMA { get; }

	public string GJFCOAAKGEC { get; }

	internal ELANGOOCLFC(string PAAGAKNKKCF, List<FEFLJHGGEOJ> IMHGJBBEIDE, SHA1Managed MOJPFLHGEIL)
	{
		IMHGJBBEIDE.Sort((FEFLJHGGEOJ HKCJBFIKALL, FEFLJHGGEOJ PIFPICMFHAD) => string.Compare(HKCJBFIKALL.FCJHBIIIEIL, PIFPICMFHAD.FCJHBIIIEIL, StringComparison.Ordinal));
		_003CLKACCEFMDDL_003Ek__BackingField = PAAGAKNKKCF;
		_003CFNOCFPBPPOI_003Ek__BackingField = GKIGLHDJJKJ(IMHGJBBEIDE, MOJPFLHGEIL);
		_003CIMKOAKLIJPB_003Ek__BackingField = IMHGJBBEIDE.ToArray();
	}

	internal ELANGOOCLFC(string PAAGAKNKKCF, FEFLJHGGEOJ[] IMHGJBBEIDE, string KLFEMGOGJJC)
	{
		_003CLKACCEFMDDL_003Ek__BackingField = PAAGAKNKKCF;
		_003CFNOCFPBPPOI_003Ek__BackingField = KLFEMGOGJJC;
		_003CIMKOAKLIJPB_003Ek__BackingField = IMHGJBBEIDE;
	}

	public bool DAAFOGBAMIC(string HJODEKEOFKG)
	{
		FEFLJHGGEOJ[] array = MIBEKBPHPMA;
		foreach (FEFLJHGGEOJ fEFLJHGGEOJ in array)
		{
			if (fEFLJHGGEOJ.FCJHBIIIEIL == HJODEKEOFKG)
			{
				return true;
			}
		}
		return false;
	}

	public void MDAJHAPJBIF()
	{
		string text = "[ACTk] Build hashed: " + FAABMGHNAIB + "\nSummary hash: " + GJFCOAAKGEC + "\nFiles:";
		FEFLJHGGEOJ[] array = MIBEKBPHPMA;
		foreach (FEFLJHGGEOJ fEFLJHGGEOJ in array)
		{
			string text2 = text;
			text = text2 + "\n" + fEFLJHGGEOJ.BMDALMJLFMH + " : " + fEFLJHGGEOJ.FCJHBIIIEIL;
		}
		Debug.Log(text);
	}

	private string GKIGLHDJJKJ(List<FEFLJHGGEOJ> IMHGJBBEIDE, SHA1Managed MOJPFLHGEIL)
	{
		string text = string.Empty;
		foreach (FEFLJHGGEOJ item in IMHGJBBEIDE)
		{
			text += item.FCJHBIIIEIL;
		}
		byte[] buffer = OPCHGBHHIGH.AEHGEAHFNOP(text);
		byte[] mMKMICOONDG = MOJPFLHGEIL.ComputeHash(buffer);
		return OPCHGBHHIGH.IODPFAOLGKO(mMKMICOONDG);
	}

	[CompilerGenerated]
	private static int OPJJMLCEFIJ(FEFLJHGGEOJ HKCJBFIKALL, FEFLJHGGEOJ PIFPICMFHAD)
	{
		return string.Compare(HKCJBFIKALL.FCJHBIIIEIL, PIFPICMFHAD.FCJHBIIIEIL, StringComparison.Ordinal);
	}
}
