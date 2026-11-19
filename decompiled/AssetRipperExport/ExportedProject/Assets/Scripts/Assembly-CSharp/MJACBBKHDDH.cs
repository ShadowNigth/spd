using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MJACBBKHDDH : JKHKOEPGCPO, IPointerUpHandler, IPointerDownHandler, IDragHandler, IEventSystemHandler
{
	private sealed class LLDJFEMMMDL : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal bool OOCBHCKJPOG;

		internal int ODIDEPHLLOB;

		internal float OLLMNOOOHAE;

		internal MJACBBKHDDH KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public LLDJFEMMMDL()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				OOCBHCKJPOG = true;
				ODIDEPHLLOB = Mathf.RoundToInt(KPHCHDHEKGH.PDHBDFKLGNH.sqrMagnitude);
				goto case 1u;
			case 1u:
				if (OOCBHCKJPOG && !KPHCHDHEKGH.BHCMDCLOFGL)
				{
					OLLMNOOOHAE = KPHCHDHEKGH.NDNFABBPADK * Time.smoothDeltaTime;
					KPHCHDHEKGH.GJEBMIFOOBJ = Vector2.Lerp(KPHCHDHEKGH.GJEBMIFOOBJ, KPHCHDHEKGH.PDHBDFKLGNH, OLLMNOOOHAE);
					if (!KPHCHDHEKGH.isStatic)
					{
						KPHCHDHEKGH.DFGIJLHDBLB.color = Color.Lerp(KPHCHDHEKGH.DFGIJLHDBLB.color, Color.clear, OLLMNOOOHAE);
						KPHCHDHEKGH.IFIIFNAALAF.color = Color.Lerp(KPHCHDHEKGH.IFIIFNAALAF.color, Color.clear, OLLMNOOOHAE);
					}
					if (Mathf.RoundToInt(KPHCHDHEKGH.GJEBMIFOOBJ.sqrMagnitude) == ODIDEPHLLOB)
					{
						KPHCHDHEKGH.GJEBMIFOOBJ = KPHCHDHEKGH.PDHBDFKLGNH;
						OOCBHCKJPOG = false;
						if (!KPHCHDHEKGH.isStatic)
						{
							Image dFGIJLHDBLB = KPHCHDHEKGH.DFGIJLHDBLB;
							bool enabled = false;
							KPHCHDHEKGH.IFIIFNAALAF.enabled = enabled;
							dFGIJLHDBLB.enabled = enabled;
						}
					}
					KPHCHDHEKGH.FOOCMNOLMND();
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

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

	[DebuggerHidden]
	private IEnumerator FABKMPHBJKE()
	{
		LLDJFEMMMDL lLDJFEMMMDL = new LLDJFEMMMDL();
		lLDJFEMMMDL.KPHCHDHEKGH = this;
		return lLDJFEMMMDL;
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
