using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MJACBBKHDDH : JKHKOEPGCPO, IPointerUpHandler, IPointerDownHandler, IDragHandler, IEventSystemHandler
{
	public Image DFGIJLHDBLB;

	public Image IFIIFNAALAF;

	public RectTransform IHODJPDIMLA;

	public RectTransform AMADDGEICCM;

	[SerializeField]
	[PNAJLEIJOKM("Mode")]
	private bool isStatic = true;

	[Range(1f, 9f)]
	public float EFEDGNFHOLI = 5.85f;

	[NKDLLFEHNLN("isStatic", "Smooth Return", "Fadeout")]
	public bool OBEAHGGOGCD;

	[Range(1f, 20f)]
	public float NDNFABBPADK = 7f;

	[SerializeField]
	private Color32 joystickImageColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 165);

	[SerializeField]
	private Color32 backgroundImageColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 165);

	public bool ICLMKJKGFBJ
	{
		get
		{
			return isStatic;
		}
		set
		{
			if (isStatic != value)
			{
				isStatic = value;
			}
		}
	}

	public override void HCCGEPOLPHB()
	{
		AMADDGEICCM = base.transform.GetChild(0) as RectTransform;
		IHODJPDIMLA = AMADDGEICCM.GetChild(0) as RectTransform;
		IFIIFNAALAF = AMADDGEICCM.GetComponent<Image>();
		DFGIJLHDBLB = IHODJPDIMLA.GetComponent<Image>();
		if (Application.isPlaying)
		{
			Image dFGIJLHDBLB = DFGIJLHDBLB;
			bool flag = isStatic;
			IFIIFNAALAF.enabled = flag;
			dFGIJLHDBLB.enabled = flag;
		}
		base.HCCGEPOLPHB();
	}

	protected override void PKJFEPHGBFI()
	{
		base.PKJFEPHGBFI();
		Image iFIIFNAALAF = IFIIFNAALAF;
		bool flag = enable;
		DFGIJLHDBLB.enabled = flag;
		iFIIFNAALAF.enabled = flag;
	}

	protected override void IPPGADPLAJM()
	{
		base.IPPGADPLAJM();
		DFGIJLHDBLB.color = MOKPACHAJFE(joystickImageColor);
		IFIIFNAALAF.color = MOKPACHAJFE(backgroundImageColor);
	}

	protected override void NIECBKIMFNO()
	{
		base.NIECBKIMFNO();
		DFGIJLHDBLB.color = ((!visible) ? Color.clear : MOKPACHAJFE(joystickImageColor));
		IFIIFNAALAF.color = ((!visible) ? Color.clear : MOKPACHAJFE(backgroundImageColor));
	}

	protected override void DBFCKHHDNAN(Vector2 FHIGFGMCPPK)
	{
		if (!EFMADDOCBDN.enabled && !EKCJABJKODG.enabled)
		{
			return;
		}
		base.DBFCKHHDNAN(FHIGFGMCPPK);
		if (BHCMDCLOFGL)
		{
			BBOCPOKNJGA(FHIGFGMCPPK);
			AEHOJDAMBCN = GJEBMIFOOBJ - PDHBDFKLGNH;
			float num = Vector2.Distance(PDHBDFKLGNH, GJEBMIFOOBJ);
			float num2 = 100f;
			float num3 = AMADDGEICCM.sizeDelta.magnitude / 2f * EFEDGNFHOLI / 16f;
			if (num > num3)
			{
				GJEBMIFOOBJ = PDHBDFKLGNH + AEHOJDAMBCN.normalized * num3;
			}
			else
			{
				num2 = num / num3 * 100f;
			}
			FOOCMNOLMND();
			AIACCBOBNIN(AEHOJDAMBCN.normalized * num2 / 100f * ICKMBHMOHNC);
		}
		else
		{
			BHCMDCLOFGL = true;
			MNAANMAOECP = IJCCPIAIFDJ.PDNIPNGGDGC;
			if (!isStatic)
			{
				MPENPPKOHOC(FHIGFGMCPPK);
			}
			BBOCPOKNJGA(FHIGFGMCPPK);
			DBFCKHHDNAN(FHIGFGMCPPK);
			JLHLDODBIJG();
		}
	}

	private void BBOCPOKNJGA(Vector2 FHIGFGMCPPK)
	{
		PDHBDFKLGNH = (GJEBMIFOOBJ = AMADDGEICCM.position);
		Vector2 vector = PBKKNIOLKJD.CFFEKDAOCDE(FHIGFGMCPPK);
		if (EFMADDOCBDN.enabled)
		{
			GJEBMIFOOBJ.x = vector.x;
		}
		if (EKCJABJKODG.enabled)
		{
			GJEBMIFOOBJ.y = vector.y;
		}
	}

	private void FOOCMNOLMND()
	{
		IHODJPDIMLA.position = GJEBMIFOOBJ;
	}

	private void MPENPPKOHOC(Vector2 FHIGFGMCPPK)
	{
		NIECBKIMFNO();
		Image dFGIJLHDBLB = DFGIJLHDBLB;
		bool flag = true;
		IFIIFNAALAF.enabled = flag;
		dFGIJLHDBLB.enabled = flag;
		RectTransform iHODJPDIMLA = IHODJPDIMLA;
		Vector3 position = PBKKNIOLKJD.CFFEKDAOCDE(FHIGFGMCPPK);
		AMADDGEICCM.position = position;
		iHODJPDIMLA.position = position;
	}

	private IEnumerator FABKMPHBJKE()
	{
		bool flag = true;
		int num = Mathf.RoundToInt(PDHBDFKLGNH.sqrMagnitude);
		while (flag && !BHCMDCLOFGL)
		{
			float t = NDNFABBPADK * Time.smoothDeltaTime;
			GJEBMIFOOBJ = Vector2.Lerp(GJEBMIFOOBJ, PDHBDFKLGNH, t);
			if (!isStatic)
			{
				DFGIJLHDBLB.color = Color.Lerp(DFGIJLHDBLB.color, Color.clear, t);
				IFIIFNAALAF.color = Color.Lerp(IFIIFNAALAF.color, Color.clear, t);
			}
			if (Mathf.RoundToInt(GJEBMIFOOBJ.sqrMagnitude) == num)
			{
				GJEBMIFOOBJ = PDHBDFKLGNH;
				flag = false;
				if (!isStatic)
				{
					Image dFGIJLHDBLB = DFGIJLHDBLB;
					bool flag2 = false;
					IFIIFNAALAF.enabled = flag2;
					dFGIJLHDBLB.enabled = flag2;
				}
			}
			FOOCMNOLMND();
			yield return null;
		}
	}

	protected override void NGCCFMHBKIO()
	{
		base.NGCCFMHBKIO();
		if (OBEAHGGOGCD)
		{
			StopCoroutine("FABKMPHBJKE");
			StartCoroutine("FABKMPHBJKE");
			return;
		}
		Image dFGIJLHDBLB = DFGIJLHDBLB;
		bool flag = isStatic;
		IFIIFNAALAF.enabled = flag;
		dFGIJLHDBLB.enabled = flag;
		GJEBMIFOOBJ = PDHBDFKLGNH;
		FOOCMNOLMND();
	}

	public void OnPointerDown(PointerEventData MOCIGEGKFHL)
	{
		if (!BHCMDCLOFGL)
		{
			EMDIGKNNNNK = MOCIGEGKFHL.pointerId;
			DBFCKHHDNAN(MOCIGEGKFHL.position);
		}
	}

	public void OnDrag(PointerEventData MOCIGEGKFHL)
	{
		if (Input.touchCount >= EMDIGKNNNNK && BHCMDCLOFGL)
		{
			DBFCKHHDNAN(MOCIGEGKFHL.position);
		}
	}

	public void OnPointerUp(PointerEventData MOCIGEGKFHL)
	{
		DBFCKHHDNAN(MOCIGEGKFHL.position);
		NGCCFMHBKIO();
	}
}
