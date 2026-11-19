using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class ANCGOFOIADD : FOGIOGKLNIP
{
	private struct KNAOLJFCHEF
	{
		public JDILMODHLOJ IKFDPNOCMMB;

		public int MJDPKGGDLME;
	}

	[CompilerGenerated]
	private sealed class HAPAJEEOGFI
	{
		internal KKJBDENNKGF NJEPMOIDJKH;

		internal bool BEKJDJFLJJC(KNAOLJFCHEF AEMBPMJMOAB)
		{
			return AEMBPMJMOAB.IKFDPNOCMMB == NJEPMOIDJKH.BJDCCKHBENA;
		}
	}

	[CompilerGenerated]
	private sealed class POOFGGLGILL
	{
		internal GameObject GIPIKICBHKA;

		internal void BEKJDJFLJJC()
		{
			GIPIKICBHKA.GIBDBKPJOKJ();
		}
	}

	private float BJMDNELMNND;

	[Field(name = "Range", min = 1f, max = 10f)]
	public ObscuredFloat AAFLGILMEKL = ObscuredFloat.FNIPJFGEFFD(10f);

	[Field(name = "Time", min = 0.1f, max = 4f)]
	public ObscuredFloat HLOAPHLPNJG = ObscuredFloat.FNIPJFGEFFD(2f);

	[Field(name = "Damage", min = 1f, max = 1000f)]
	public ObscuredInt BKENMJFCFJI = ObscuredInt.FNIPJFGEFFD(70);

	public int OPEKBPCMBPH;

	public int PDNKHCIIDKJ;

	public JDILMODHLOJ BJDCCKHBENA;

	private Vector3 IAFIDJLHGLC;

	internal bool OPKDMODBFGA;

	public string PFOOKKOIPLM;

	public string LJFCKMMEJKN;

	public MeshFilter GAJGBAGAJLA;

	public MeshRenderer LNMHOBPJCGJ;

	public virtual void Start()
	{
		BJMDNELMNND = Time.time;
		JPBIAJIBLCG(PFOOKKOIPLM, LJFCKMMEJKN, GAJGBAGAJLA, LNMHOBPJCGJ);
	}

	public virtual void Update()
	{
		if (!(BJDCCKHBENA != null) || !KAMAMHFJDGG)
		{
			return;
		}
		if (!(this is BOCEBMKIGAP))
		{
			if (Time.time - BJMDNELMNND > ObscuredFloat.FNIPJFGEFFD(HLOAPHLPNJG) && BJMDNELMNND != 0f)
			{
				KIKEOPPIKNP();
				BJMDNELMNND = 0f;
			}
			return;
		}
		float maxDistance = 0.086f;
		Vector3 down = Vector3.down;
		if (!OPKDMODBFGA && Physics.Raycast(EHOEFMPLIFB.position, down, out var _, maxDistance, 1024) && FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.NFMIBMIGJMH(500))
		{
			KIKEOPPIKNP();
			OPKDMODBFGA = true;
		}
	}

	public void OnCollisionEnter(Collision HOLADPMJBJO)
	{
		FOGIOGKLNIP.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.GrenadeHit[OPEKBPCMBPH], base.ELGIKGAIIOD, AACEDKHGOAA: true, 0.5f, 1f, 1f);
	}

	[RPC]
	public virtual void FAHNKLMLPDA(Vector3 OGJIDBEODPM, Vector3 PDAKFGKELOC, NetworkViewID JDKLJHNJNLG)
	{
		FAHNKLMLPDA(OGJIDBEODPM, PDAKFGKELOC, (object)JDKLJHNJNLG);
	}

	[RPC]
	public virtual void FAHNKLMLPDA(Vector3 OGJIDBEODPM, Vector3 PDAKFGKELOC, PhotonViewID JDKLJHNJNLG)
	{
		FAHNKLMLPDA(OGJIDBEODPM, PDAKFGKELOC, (object)JDKLJHNJNLG);
	}

	public void FAHNKLMLPDA(Vector3 OGJIDBEODPM, Vector3 PDAKFGKELOC, object JDKLJHNJNLG)
	{
		BJDCCKHBENA = FOGIOGKLNIP.AAPLAPBIFMD<JDILMODHLOJ>(JDKLJHNJNLG);
		BJDCCKHBENA = BJDCCKHBENA;
		EHOEFMPLIFB.position = OGJIDBEODPM;
		GetComponent<Rigidbody>().velocity = PDAKFGKELOC;
	}

	public virtual void KIKEOPPIKNP()
	{
		Vector3 position = ICIEDCMDJFO.transform.position;
		Collider[] array = Physics.OverlapSphere(base.ELGIKGAIIOD, ObscuredFloat.FNIPJFGEFFD(AAFLGILMEKL));
		List<KNAOLJFCHEF> list = new List<KNAOLJFCHEF>();
		int layerMask = 335813888;
		for (int i = 0; i < array.Length; i++)
		{
			if (Physics.Linecast(position, array[i].transform.position, out var hitInfo, layerMask))
			{
				PMDPIINLPHK component = hitInfo.transform.GetComponent<PMDPIINLPHK>();
				if (component != null)
				{
					component.NCHOPAEKPBK(component.PLEKGNIKPEH, component.BHFDJDDGHKA - 100, position);
				}
				KKJBDENNKGF NJEPMOIDJKH = hitInfo.transform.GetComponent<KKJBDENNKGF>();
				if (NJEPMOIDJKH != null && !list.Exists((KNAOLJFCHEF AEMBPMJMOAB) => AEMBPMJMOAB.IKFDPNOCMMB == NJEPMOIDJKH.BJDCCKHBENA) && (NJEPMOIDJKH.BJDCCKHBENA.JGECOECAJLK != BJDCCKHBENA.JGECOECAJLK || NJEPMOIDJKH.BJDCCKHBENA == FOGIOGKLNIP.PIOANBBCFFP.BDHHGHOGGIJ || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.LPLJMLGKCLK.DIKFFLBGJDE) || ObscuredBool.FNIPJFGEFFD(FOGIOGKLNIP.PIOANBBCFFP.MGDGJKCGHII)))
				{
					Vector3 position2 = NJEPMOIDJKH.ICIEDCMDJFO.transform.position;
					list.Add(new KNAOLJFCHEF
					{
						MJDPKGGDLME = IFHGMCKAKEC((int)((float)ObscuredInt.FNIPJFGEFFD(BKENMJFCFJI) * (((!IIGANLCMBGC(position2, position + Vector3.up)) ? 1f : 0.5f) * (1f - (position2 - position).magnitude / ObscuredFloat.FNIPJFGEFFD(AAFLGILMEKL)))), NJEPMOIDJKH, FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.DLHLKPMGHOO.FBGNKPPMENN, BJDCCKHBENA),
						IKFDPNOCMMB = NJEPMOIDJKH.BJDCCKHBENA
					});
				}
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			if (list[j].IKFDPNOCMMB.NJEPMOIDJKH != null)
			{
				list[j].IKFDPNOCMMB.NJEPMOIDJKH.GGNFHJCPCBK(-Mathf.Abs(list[j].MJDPKGGDLME), BJDCCKHBENA, (byte)FOGIOGKLNIP.LPLJMLGKCLK.IFLCIAMAFAL.DLHLKPMGHOO.FBGNKPPMENN);
			}
		}
		NCHOPAEKPBK(CHDLHLJEAKP, position);
		APAMPKPNIPC();
	}

	[RPC]
	public virtual void CHDLHLJEAKP(Vector3 ELGIKGAIIOD)
	{
		EHOEFMPLIFB.position = ELGIKGAIIOD;
		FOGIOGKLNIP.PIOANBBCFFP.IAKGALFPPJL(ELGIKGAIIOD, 5000f);
		JMJLEDGJIJK("SmallExplode", "Particles/", BAFJCPENDPG: true, null, null, ELGIKGAIIOD, Quaternion.identity);
		FOGIOGKLNIP.LEDCIPHCLEB(FOGIOGKLNIP.LPLJMLGKCLK.HLEOCDKAKMJ.GrenadeExplosion[PDNKHCIIDKJ], ELGIKGAIIOD, AACEDKHGOAA: true, 0.5f, 1f, 1f);
		if (Physics.Raycast(ELGIKGAIIOD, Vector3.down, out var hitInfo, 1f, 1024))
		{
			GameObject GIPIKICBHKA = JMJLEDGJIJK("DecalExp", null, BAFJCPENDPG: false, null, null, hitInfo.point + Vector3.up * 0.001f, Quaternion.LookRotation(hitInfo.normal));
			FOGIOGKLNIP.PIOANBBCFFP.JDFKPOMKMNJ.IPBKDPKONHH((!FOGIOGKLNIP.DGMBIMMABNO) ? 20000 : 10000, delegate
			{
				GIPIKICBHKA.GIBDBKPJOKJ();
			});
		}
	}
}
