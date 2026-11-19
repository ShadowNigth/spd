using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[DisallowMultipleComponent]
public abstract class JNEFNLEGJMM : MonoBehaviour
{
	public PAEEOJFACBD FDICPOLBAEN;

	internal IJCCPIAIFDJ MNAANMAOECP = IJCCPIAIFDJ.HHFPPPILFBP;

	public RectTransform NIOPLLHNIJJ;

	public Image OFBMBFLODCF;

	public string KGLOKPGOGLD = "NONAME_Controller";

	[SerializeField]
	protected Color32 baseImageColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 165);

	protected int EMDIGKNNNNK = -1;

	protected bool BHCMDCLOFGL;

	[SerializeField]
	protected bool enable = true;

	[SerializeField]
	protected bool active = true;

	[SerializeField]
	protected bool visible = true;

	private float KIFGGEHKBJF;

	private float GDPEDECHPEE;

	public bool IOLDKGFCIJG
	{
		get
		{
			return enable;
		}
		set
		{
			if (enable != value)
			{
				enable = value;
				PKJFEPHGBFI();
			}
		}
	}

	public bool FPGBBDJIHMG
	{
		get
		{
			return active;
		}
		set
		{
			if (active != value)
			{
				active = value;
				NDDGONDDBNJ();
			}
		}
	}

	public bool NPMNHJLHLKP
	{
		get
		{
			return visible;
		}
		set
		{
			if (visible != value)
			{
				visible = value;
				NIECBKIMFNO();
			}
		}
	}

	protected Color MOKPACHAJFE(Color JPLPPELPDKF)
	{
		return (!active) ? (JPLPPELPDKF * 0.5f) : JPLPPELPDKF;
	}

	[POPCJHCKEFF]
	protected virtual void PKJFEPHGBFI()
	{
		base.enabled = enable && active;
		OFBMBFLODCF.enabled = enable;
	}

	[POPCJHCKEFF]
	protected virtual void NDDGONDDBNJ()
	{
		base.enabled = enable && active;
		if (visible)
		{
			IPPGADPLAJM();
		}
	}

	protected virtual void IPPGADPLAJM()
	{
		OFBMBFLODCF.color = MOKPACHAJFE(baseImageColor);
	}

	[POPCJHCKEFF]
	protected virtual void NIECBKIMFNO()
	{
		OFBMBFLODCF.color = ((!visible) ? Color.clear : MOKPACHAJFE(baseImageColor));
	}

	public virtual void HCCGEPOLPHB()
	{
		OFBMBFLODCF = GetComponent<Image>();
		NIOPLLHNIJJ = OFBMBFLODCF.rectTransform;
		NDDGONDDBNJ();
	}

	protected virtual void Update()
	{
		if (FDICPOLBAEN == PAEEOJFACBD.MJCGPCIAHEM)
		{
			LGHLKBFKLKP();
		}
	}

	protected virtual void LateUpdate()
	{
		if (FDICPOLBAEN == PAEEOJFACBD.NLKJEKIFNCO)
		{
			LGHLKBFKLKP();
		}
	}

	protected virtual void FixedUpdate()
	{
		if (FDICPOLBAEN == PAEEOJFACBD.JKKBKAEPOPL)
		{
			LGHLKBFKLKP();
		}
	}

	private void OnDisable()
	{
		if (Application.isPlaying && BHCMDCLOFGL)
		{
			NGCCFMHBKIO();
		}
	}

	private void LGHLKBFKLKP()
	{
		if (BHCMDCLOFGL)
		{
			if (KIFGGEHKBJF == GDPEDECHPEE)
			{
				MNAANMAOECP = IJCCPIAIFDJ.PGADNLCNHPO;
			}
			else
			{
				MNAANMAOECP = IJCCPIAIFDJ.JGOIFEHFAPI;
			}
		}
		else
		{
			MNAANMAOECP = IJCCPIAIFDJ.HHFPPPILFBP;
		}
		GDPEDECHPEE = KIFGGEHKBJF;
	}

	protected virtual void DBFCKHHDNAN(Vector2 FHIGFGMCPPK)
	{
		KIFGGEHKBJF = FHIGFGMCPPK.magnitude;
	}

	protected virtual void NGCCFMHBKIO()
	{
		MNAANMAOECP = IJCCPIAIFDJ.NADMJNCNMFE;
		EMDIGKNNNNK = -1;
		BHCMDCLOFGL = false;
	}
}
