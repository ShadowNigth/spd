using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using UnityEngine;

public class LMJDOOEODJK : FOGIOGKLNIP
{
	private sealed class DICOKNPHMCE
	{
		internal string IFNKGJDHGDD;

		internal bool BEKJDJFLJJC(ClipClass LCGOBLBBDPH)
		{
			return ObscuredString.JHLIPNMGNGC(LCGOBLBBDPH.Name, ObscuredString.FNIPJFGEFFD(IFNKGJDHGDD));
		}
	}

	private sealed class BEIPMNNLGPP
	{
		internal string IFNKGJDHGDD;

		internal bool BEKJDJFLJJC(ClipClass LCGOBLBBDPH)
		{
			return ObscuredString.JHLIPNMGNGC(LCGOBLBBDPH.Name, ObscuredString.FNIPJFGEFFD(IFNKGJDHGDD));
		}
	}

	private sealed class GDBKAOLAKOG
	{
		internal string IFNKGJDHGDD;

		internal bool BEKJDJFLJJC(ClipClass LCGOBLBBDPH)
		{
			return ObscuredString.JHLIPNMGNGC(LCGOBLBBDPH.Name, ObscuredString.FNIPJFGEFFD(IFNKGJDHGDD));
		}
	}

	[SerializeField]
	public ClipClass[] AmmoClass;

	private void Start()
	{
		for (int i = 0; i < AmmoClass.Length; i++)
		{
			AmmoClass[i].Index = ObscuredInt.FNIPJFGEFFD(i);
		}
	}

	public int FOEACCEIBME(string IFNKGJDHGDD, bool LALOMAPCKBH = false)
	{
		DICOKNPHMCE dICOKNPHMCE = new DICOKNPHMCE();
		dICOKNPHMCE.IFNKGJDHGDD = IFNKGJDHGDD;
		ClipClass clipClass = AmmoClass.WhereF(dICOKNPHMCE.BEKJDJFLJJC).SingleOrDefaultF();
		if (!LALOMAPCKBH)
		{
			return ObscuredInt.FNIPJFGEFFD(clipClass.Clip);
		}
		return ObscuredInt.FNIPJFGEFFD(clipClass.MaxClip);
	}

	public int OEPFDDDGLIG(string IFNKGJDHGDD)
	{
		BEIPMNNLGPP bEIPMNNLGPP = new BEIPMNNLGPP();
		bEIPMNNLGPP.IFNKGJDHGDD = IFNKGJDHGDD;
		ClipClass clipClass = AmmoClass.WhereF(bEIPMNNLGPP.BEKJDJFLJJC).SingleOrDefaultF();
		return ObscuredInt.FNIPJFGEFFD(clipClass.Index);
	}

	public int DJEALLIOJEO(int MKBNKANDCDB, bool LALOMAPCKBH = false)
	{
		if (!LALOMAPCKBH)
		{
			return ObscuredInt.FNIPJFGEFFD(AmmoClass[MKBNKANDCDB].Clip);
		}
		return ObscuredInt.FNIPJFGEFFD(AmmoClass[MKBNKANDCDB].MaxClip);
	}

	public int COAEAALHHGL(string IFNKGJDHGDD, int JFLFLCDEEEI, bool KOOEEAICKBH = false)
	{
		GDBKAOLAKOG gDBKAOLAKOG = new GDBKAOLAKOG();
		gDBKAOLAKOG.IFNKGJDHGDD = IFNKGJDHGDD;
		ClipClass clipClass = AmmoClass.WhereF(gDBKAOLAKOG.BEKJDJFLJJC).SingleOrDefaultF();
		if (!KOOEEAICKBH)
		{
			return ObscuredInt.FNIPJFGEFFD(clipClass.Clip = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(clipClass.Clip) + JFLFLCDEEEI));
		}
		return ObscuredInt.FNIPJFGEFFD(clipClass.Clip = ObscuredInt.FNIPJFGEFFD(JFLFLCDEEEI));
	}

	public int NKOHBFHAELH(int MKBNKANDCDB, int JFLFLCDEEEI, bool KOOEEAICKBH = false)
	{
		if (!KOOEEAICKBH)
		{
			ClipClass obj = AmmoClass[MKBNKANDCDB];
			return ObscuredInt.FNIPJFGEFFD(obj.Clip = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(obj.Clip) + JFLFLCDEEEI));
		}
		return ObscuredInt.FNIPJFGEFFD(AmmoClass[MKBNKANDCDB].Clip = ObscuredInt.FNIPJFGEFFD(JFLFLCDEEEI));
	}
}
