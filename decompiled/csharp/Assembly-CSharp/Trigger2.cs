using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using SPD.EditorAttributes;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Trigger2 : FOGIOGKLNIP, CJMKGJPLOPM
{
	[CustomToggle("Listing Events OnTriggerEnter")]
	public bool ListingOnTriggerEnter = true;

	[CustomToggle("OnTriggerEnter Once (Globally)")]
	public bool TriggerEnterOnce;

	public BetterEvent OnTriggerEnterEvents;

	[CustomToggle("Listing Events OnTriggerExit")]
	public bool ListingOnTriggerExit;

	[CustomToggle("OnTriggerExit Once (Globally)")]
	public bool TriggerExitOnce;

	public BetterEvent OnTriggerExitEvents;

	internal bool TriggerEnterDone;

	internal bool TriggerExitDone;

	internal int Index;

	internal KKJBDENNKGF player_trigger;

	private HashSet<GameObject> GOPool = new HashSet<GameObject>();

	internal List<int> IDEventInvokeEnter = new List<int>();

	internal List<int> IDEventInvokeExit = new List<int>();

	private List<JDILMODHLOJ> bots = new List<JDILMODHLOJ>();

	public override void Awake()
	{
		base.Awake();
		if (ICIEDCMDJFO.layer != 31)
		{
			ICIEDCMDJFO.layer = 31;
		}
	}

	public void Start()
	{
		for (int i = 0; i < OnTriggerEnterEvents.Events.Count; i++)
		{
			OnTriggerEnterEvents.Events[i].Init();
			if (OnTriggerEnterEvents.Events[i].InvokeOnce)
			{
				IDEventInvokeEnter.Add(i);
			}
		}
		for (int j = 0; j < OnTriggerExitEvents.Events.Count; j++)
		{
			OnTriggerExitEvents.Events[j].Init();
			if (OnTriggerExitEvents.Events[j].InvokeOnce)
			{
				IDEventInvokeExit.Add(j);
			}
		}
	}

	public void OnTriggerEnter(Collider other)
	{
		if (!ListingOnTriggerEnter || TriggerEnterDone)
		{
			return;
		}
		Transform root = other.transform.root;
		if (root.tag == "Player")
		{
			KKJBDENNKGF component = root.GetComponent<KKJBDENNKGF>();
			if (component.KAMAMHFJDGG && !ObscuredBool.FNIPJFGEFFD(component.BJDCCKHBENA.HIBLODEGHAK))
			{
				FOGIOGKLNIP.PIOANBBCFFP.NCHOPAEKPBK(FOGIOGKLNIP.PIOANBBCFFP.HPHAGGECKKM, Index, component.MFAGKFPCJFG);
			}
		}
	}

	public void OnTriggerExit(Collider other)
	{
		if (!ListingOnTriggerExit || TriggerExitDone)
		{
			return;
		}
		Transform root = other.transform.root;
		if (root.tag == "Player")
		{
			KKJBDENNKGF component = root.GetComponent<KKJBDENNKGF>();
			if (component.KAMAMHFJDGG && !ObscuredBool.FNIPJFGEFFD(component.BJDCCKHBENA.HIBLODEGHAK))
			{
				FOGIOGKLNIP.PIOANBBCFFP.NCHOPAEKPBK(FOGIOGKLNIP.PIOANBBCFFP.NAECMNPOFGL, Index, component.MFAGKFPCJFG);
			}
		}
	}

	public void CreateObject(GameObject obj, Transform to, bool scaleByTransform)
	{
		CreateObject(obj, to.position, to.eulerAngles, (!scaleByTransform) ? obj.transform.localScale : to.localScale);
	}

	public void CreateObject(GameObject obj, Transform to, Vector3 scale)
	{
		CreateObject(obj, to.position, to.eulerAngles, scale);
	}

	public void CreateObject(GameObject obj, Vector3 Position, Vector3 Rotation)
	{
		CreateObject(obj, Position, Rotation, obj.transform.localScale);
	}

	public void CreateObject(GameObject obj, Vector3 Position, Vector3 Rotation, Vector3 scale)
	{
		GameObject gameObject = JMJLEDGJIJK("TRIGGER_" + obj.name, "/", BAFJCPENDPG: false, obj, null, Position, Quaternion.Euler(Rotation));
		GOPool.Add(gameObject);
		gameObject.transform.localScale = scale;
	}

	public void CreateNPC(int TeamType, int PlayerType, string[] Weapons, Transform to)
	{
		if (!base.NENPALDENAL)
		{
			return;
		}
		KKJBDENNKGF kKJBDENNKGF = FOGIOGKLNIP.PIOANBBCFFP.DMAILAJDJLD(PlayerType, TeamType, to.position);
		if (kKJBDENNKGF != null)
		{
			bots.Add(kKJBDENNKGF.BJDCCKHBENA);
		}
		if (!(kKJBDENNKGF is FDGPLHOFOEN))
		{
			return;
		}
		FDGPLHOFOEN plcon = kKJBDENNKGF as FDGPLHOFOEN;
		FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.IPBKDPKONHH(100, delegate
		{
			for (int i = 0; i < Weapons.Length; i++)
			{
				IAPJEBKJEHC iAPJEBKJEHC = plcon.OKDFHJJNFCC.WhereF((IAPJEBKJEHC a) => a.LKECMBJJLPJ == Weapons[i] && !(a is FFGDOHNIMON)).FirstOrDefaultF();
				plcon.NCHOPAEKPBK(plcon.DKPJJKBJJOA, iAPJEBKJEHC.FBGNKPPMENN);
			}
		});
	}

	public void CreateNPC(int count, int TeamType, int PlayerType, string[] Weapons, Transform to)
	{
		if (base.NENPALDENAL)
		{
			for (int i = 0; i < count; i++)
			{
				CreateNPC(TeamType, PlayerType, Weapons, to);
			}
		}
	}

	public void CreateNPC_RandomSpawn(int count, int TeamType, int PlayerType, string[] Weapons, Transform[] to)
	{
		if (base.NENPALDENAL)
		{
			for (int i = 0; i < count; i++)
			{
				CreateNPC(TeamType, PlayerType, Weapons, to[Random.Range(0, to.Length)]);
			}
		}
	}

	public void RemoveNPC()
	{
		RemoveNPC(with: true);
	}

	private void RemoveNPC(bool with)
	{
		if (base.NENPALDENAL)
		{
			FOGIOGKLNIP.PIOANBBCFFP.FBBOBGFEBJE(bots.ToArray(), with);
		}
	}

	public void Notification_Text(string Text, bool OnlyPlayerOnTrigger, bool Special)
	{
		if ((OnlyPlayerOnTrigger && player_trigger != null && player_trigger.KAMAMHFJDGG) || !OnlyPlayerOnTrigger)
		{
			FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ(Text, Special);
		}
	}

	public void Chat_Global(string Text, bool OnlyPlayerOnTrigger)
	{
		if ((OnlyPlayerOnTrigger && player_trigger != null && player_trigger.KAMAMHFJDGG) || !OnlyPlayerOnTrigger)
		{
			FOGIOGKLNIP.PIOANBBCFFP.FNFKLBLIJAF(Text);
		}
	}

	public void Chat_OnPlayerTrigger(string Text, bool OnlyPlayerOnTrigger)
	{
		if (player_trigger != null && ((OnlyPlayerOnTrigger && player_trigger.KAMAMHFJDGG) || !OnlyPlayerOnTrigger))
		{
			FOGIOGKLNIP.PIOANBBCFFP.FNFKLBLIJAF(string.Concat(player_trigger.BJDCCKHBENA, ": ", Text));
		}
	}

	public void Player_SetHP(int Value)
	{
		if (player_trigger != null && player_trigger.KAMAMHFJDGG)
		{
			player_trigger.NCHOPAEKPBK(player_trigger.DFJGLGGOKKN, Value);
		}
	}

	public void Player_Die()
	{
		if (player_trigger != null)
		{
			player_trigger.KNOEPICGNLK(default(byte));
		}
	}

	public void Player_Explode()
	{
		if (player_trigger != null && player_trigger is FDGPLHOFOEN)
		{
			(player_trigger as FDGPLHOFOEN).KIKEOPPIKNP();
		}
	}

	public void Player_SetArmour(int Value, bool isArmour)
	{
		if (player_trigger != null && player_trigger.KAMAMHFJDGG)
		{
			player_trigger.NCHOPAEKPBK(player_trigger.IGJOGMEONLP, Value, isArmour);
		}
	}

	public void Player_Teleport(Transform to, bool withSounds)
	{
		if (player_trigger != null && player_trigger.KAMAMHFJDGG)
		{
			player_trigger.NCHOPAEKPBK(player_trigger.FAEDGHBACGA, to.position, withSounds);
		}
	}

	public void Player_TeleportAll(Transform to)
	{
		FOGIOGKLNIP.GMPBCIEDMCD.NCHOPAEKPBK(player_trigger.FAEDGHBACGA, to.position, PLPIOMGGMJH: false);
	}

	public void Player_MakeZombie()
	{
		if (player_trigger != null && player_trigger.KAMAMHFJDGG)
		{
			player_trigger.NCHOPAEKPBK(player_trigger.MBKMMAAMIIK);
		}
	}

	public void Player_GiveMoney(int Value)
	{
		if (player_trigger != null && player_trigger.KAMAMHFJDGG)
		{
			player_trigger.BJDCCKHBENA.NCHOPAEKPBK(player_trigger.BJDCCKHBENA.FBBDIENBDGM, Value);
		}
	}

	public void Player_GiveWeapon(string WeaponName, bool Replace)
	{
		if (!(player_trigger != null) || !player_trigger.KAMAMHFJDGG || !(player_trigger is FDGPLHOFOEN))
		{
			return;
		}
		FDGPLHOFOEN fDGPLHOFOEN = player_trigger as FDGPLHOFOEN;
		IAPJEBKJEHC GUN = fDGPLHOFOEN.OKDFHJJNFCC.WhereF((IAPJEBKJEHC a) => a.LKECMBJJLPJ == WeaponName && (!ObscuredBool.FNIPJFGEFFD(a.FEAMJAKLLLO) || Replace) && !(a is FFGDOHNIMON)).FirstOrDefaultF();
		if (!(GUN != null))
		{
			return;
		}
		if (Replace)
		{
			IAPJEBKJEHC[] array = fDGPLHOFOEN.OKDFHJJNFCC.WhereF((IAPJEBKJEHC a) => a.KOPFHECCACK == GUN.KOPFHECCACK && ObscuredBool.FNIPJFGEFFD(a.FEAMJAKLLLO) && !(a is FFGDOHNIMON));
			foreach (IAPJEBKJEHC iAPJEBKJEHC in array)
			{
				iAPJEBKJEHC.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: false);
				iAPJEBKJEHC.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: false);
			}
		}
		GUN.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: true);
		fDGPLHOFOEN.NCHOPAEKPBK(fDGPLHOFOEN.DKPJJKBJJOA, GUN.FBGNKPPMENN);
		GUN.CNMKGNNGPDD = GUN.ABHFBECBPBA;
		GUN.LMJDOOEODJK.NKOHBFHAELH(GUN.NNBDEKBINFP, GUN.LMJDOOEODJK.DJEALLIOJEO(GUN.NNBDEKBINFP, LALOMAPCKBH: true), KOOEEAICKBH: true);
	}

	public void Player_GiveWeapon(string WeaponName, bool Replace, int Ammo, int Clips, bool inSilencer)
	{
		if (!(player_trigger != null) || !(player_trigger is FDGPLHOFOEN) || !player_trigger.KAMAMHFJDGG || !(player_trigger is FDGPLHOFOEN))
		{
			return;
		}
		FDGPLHOFOEN fDGPLHOFOEN = player_trigger as FDGPLHOFOEN;
		IAPJEBKJEHC GUN = fDGPLHOFOEN.OKDFHJJNFCC.WhereF((IAPJEBKJEHC a) => a.LKECMBJJLPJ == WeaponName && (!ObscuredBool.FNIPJFGEFFD(a.FEAMJAKLLLO) || Replace) && !(a is FFGDOHNIMON)).FirstOrDefaultF();
		if (!(GUN != null))
		{
			return;
		}
		if (Replace)
		{
			IAPJEBKJEHC[] array = fDGPLHOFOEN.OKDFHJJNFCC.WhereF((IAPJEBKJEHC a) => a.KOPFHECCACK == GUN.KOPFHECCACK && ObscuredBool.FNIPJFGEFFD(a.FEAMJAKLLLO) && !(a is FFGDOHNIMON));
			foreach (IAPJEBKJEHC iAPJEBKJEHC in array)
			{
				iAPJEBKJEHC.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: false);
				iAPJEBKJEHC.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: false);
			}
		}
		GUN.ABHFBECBPBA = ObscuredInt.FNIPJFGEFFD(Ammo);
		GUN.CNMKGNNGPDD = GUN.ABHFBECBPBA;
		GUN.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: true);
		fDGPLHOFOEN.NCHOPAEKPBK(fDGPLHOFOEN.DKPJJKBJJOA, GUN.FBGNKPPMENN);
		FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.IPBKDPKONHH(100, delegate
		{
			GUN.LMJDOOEODJK.NKOHBFHAELH(GUN.NNBDEKBINFP, Clips, KOOEEAICKBH: true);
		});
		if ((GUN is OENJLELADOM || GUN is MELEBCPOMHB) && inSilencer)
		{
			fDGPLHOFOEN.NCHOPAEKPBK(fDGPLHOFOEN.ELNKLGHNLEP, inSilencer, GUN.FBGNKPPMENN);
		}
	}

	public void Player_RemoveWeapons()
	{
		if (!(player_trigger != null) || !(player_trigger is FDGPLHOFOEN) || !player_trigger.KAMAMHFJDGG)
		{
			return;
		}
		FDGPLHOFOEN fDGPLHOFOEN = player_trigger as FDGPLHOFOEN;
		IAPJEBKJEHC[] oKDFHJJNFCC = fDGPLHOFOEN.OKDFHJJNFCC;
		foreach (IAPJEBKJEHC iAPJEBKJEHC in oKDFHJJNFCC)
		{
			if (!(iAPJEBKJEHC is FFGDOHNIMON))
			{
				iAPJEBKJEHC.JJJGDHGBPHJ = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: false);
				iAPJEBKJEHC.FEAMJAKLLLO = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: false);
			}
		}
	}

	public void Player_DropWeapon()
	{
		if (player_trigger != null && player_trigger.KAMAMHFJDGG && player_trigger is FDGPLHOFOEN)
		{
			FDGPLHOFOEN fDGPLHOFOEN = player_trigger as FDGPLHOFOEN;
			if (!(fDGPLHOFOEN.JEPMMPCNEHO is FFGDOHNIMON))
			{
				fDGPLHOFOEN.NCHOPAEKPBK(fDGPLHOFOEN.HGMACHLNNOK, fDGPLHOFOEN.JEPMMPCNEHO.FBGNKPPMENN, fDGPLHOFOEN.JEPMMPCNEHO.JJHIFNAJIBK, ObscuredInt.FNIPJFGEFFD(fDGPLHOFOEN.JEPMMPCNEHO.CNMKGNNGPDD), fDGPLHOFOEN.JEPMMPCNEHO.LMJDOOEODJK.DJEALLIOJEO(fDGPLHOFOEN.JEPMMPCNEHO.NNBDEKBINFP), PJEBMLPJGPM: false);
			}
		}
	}

	public void Reset()
	{
		player_trigger = null;
		foreach (BetterEventEntry @event in OnTriggerEnterEvents.Events)
		{
			@event.Reset();
		}
		foreach (BetterEventEntry event2 in OnTriggerExitEvents.Events)
		{
			event2.Reset();
		}
		TriggerEnterDone = false;
		TriggerExitDone = false;
		if (base.NENPALDENAL && bots != null)
		{
			RemoveNPC(with: false);
		}
		foreach (GameObject item in GOPool)
		{
			item.GIBDBKPJOKJ();
		}
		GOPool.Clear();
	}
}
