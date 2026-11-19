using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using JM.LinqFaster;
using SPD.Triggers;
using UnityEngine;

public class OLILBNAJMLF : IAPJEBKJEHC
{
	private bool EAECNIFNBKC;

	private float GCDGMACGMKE;

	public GameObject ICHPLCGLAIO;

	public override ObscuredBool FEAMJAKLLLO
	{
		get
		{
			return base.CGGHOLCLFDG;
		}
		set
		{
			EABMOMPIMOF = value;
			if (!ObscuredBool.FNIPJFGEFFD(value))
			{
				base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(0);
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public override void Start()
	{
		base.Start();
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
		{
			GCDGMACGMKE = Time.time;
		}
	}

	public override void Update()
	{
		base.Update();
		if ((KAMAMHFJDGG && ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) <= 0) || FOGIOGKLNIP.PIOANBBCFFP.JLFMGNFDGCK.Count > 0)
		{
			OOKLHOCJKAG = false;
		}
		if (KAMAMHFJDGG && EAECNIFNBKC != OOKLHOCJKAG)
		{
			NJEPMOIDJKH.NCHOPAEKPBK(NJEPMOIDJKH.CHEOEJNGLFP, OOKLHOCJKAG);
		}
		EAECNIFNBKC = OOKLHOCJKAG;
		if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK) || ObscuredInt.FNIPJFGEFFD(base.CNMKGNNGPDD) <= 0 || !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) || FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.IsPlaying("draw"))
		{
			return;
		}
		FOGIOGKLNIP.CIEBMCOJGCC.HKPPAEMPIJD.color = Color.green;
		if (FOGIOGKLNIP.PIOANBBCFFP.GGEMEHNHFCG.AnyF((BombPlace AEMBPMJMOAB) => (AEMBPMJMOAB.GetComponent<Collider>() == null && (AEMBPMJMOAB.transform.position - base.ELGIKGAIIOD).magnitude < 5f) || (AEMBPMJMOAB.GetComponent<Collider>() != null && AEMBPMJMOAB.GetComponent<Collider>().bounds.Contains(base.ELGIKGAIIOD))))
		{
			FOGIOGKLNIP.CIEBMCOJGCC.HKPPAEMPIJD.color = ((!((double)Time.time % 0.4 < 0.20000000298023224) || !FOGIOGKLNIP.PIOANBBCFFP.GGEMEHNHFCG.AnyF((BombPlace AEMBPMJMOAB) => (AEMBPMJMOAB.transform.position - NJEPMOIDJKH.ELGIKGAIIOD).magnitude < 5f)) ? Color.green : Color.red);
			if (FHPNFKMCACF)
			{
				if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && NJEPMOIDJKH.yvel == 0f)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play("pressbutton");
					NJEPMOIDJKH.CBOOLAKHHHG = Vector3.zero;
				}
				else if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA) && NJEPMOIDJKH.yvel > 0f && NJEPMOIDJKH.KPKNIABCJOC != Vector3.zero)
				{
					FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play("idle");
					FOGIOGKLNIP.PIOANBBCFFP.HAFCMAMMPIJ("You must be on the ground to plant a bomb");
				}
			}
			else if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.IIPDOGECCPA))
			{
				FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play("idle");
			}
		}
		else
		{
			FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM.Play("idle");
		}
		if (FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["pressbutton"].time > 0f && FHPNFKMCACF && !ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.HIBLODEGHAK))
		{
			float num = FOGIOGKLNIP.NGFDFPGNDCJ.JDFOMNBKFHM["pressbutton"].time / ObscuredFloat.FNIPJFGEFFD(IFFHNOJMPMB.Time);
			if (num < 1f)
			{
				FOGIOGKLNIP.CIEBMCOJGCC.OECIDJJPPBC(num);
			}
			else if (ObscuredBool.FNIPJFGEFFD(NJEPMOIDJKH.LKGMKGCNHMA) && KAMAMHFJDGG)
			{
				FOGIOGKLNIP.PIOANBBCFFP.MOAOGLECILB();
				ICONFJBEJPN(ICHPLCGLAIO, NJEPMOIDJKH.ELGIKGAIIOD, Quaternion.Euler(-90f, -90f, NJEPMOIDJKH.MPCGHDNMNKN.KHGAOLHJCMO.y), 2);
				FOGIOGKLNIP.EIIMBNKHJJA.HPCHODAEOPK();
				base.CNMKGNNGPDD = ObscuredInt.FNIPJFGEFFD(0);
				NJEPMOIDJKH.CFINPAOKCDB();
			}
		}
	}

	[CompilerGenerated]
	private bool CGOJPCBLPOI(BombPlace AEMBPMJMOAB)
	{
		return (AEMBPMJMOAB.GetComponent<Collider>() == null && (AEMBPMJMOAB.transform.position - base.ELGIKGAIIOD).magnitude < 5f) || (AEMBPMJMOAB.GetComponent<Collider>() != null && AEMBPMJMOAB.GetComponent<Collider>().bounds.Contains(base.ELGIKGAIIOD));
	}

	[CompilerGenerated]
	private bool NBECBCLALHF(BombPlace AEMBPMJMOAB)
	{
		return (AEMBPMJMOAB.transform.position - NJEPMOIDJKH.ELGIKGAIIOD).magnitude < 5f;
	}
}
