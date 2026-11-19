using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class GDCHNKKLCDA : UIBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
{
	[Serializable]
	public class UpdatePositionEvent : UnityEvent<float>
	{
	}

	[Serializable]
	public class ItemSelectedEvent : UnityEvent<int>
	{
	}

	[Serializable]
	private struct Snap
	{
		public bool Enable;

		public float VelocityThreshold;

		public float Duration;
	}

	private enum BFDEFMPOJPO
	{
		IOKNFMCJIHM,
		CKGPDOGEHBB
	}

	private enum BABNPFCBKGI
	{
		BIGEGGOMAOF,
		ACHNNMHFGEM,
		OCICAIGKHJE
	}

	[SerializeField]
	private RectTransform viewport;

	[SerializeField]
	private BFDEFMPOJPO directionOfRecognize;

	[SerializeField]
	private BABNPFCBKGI movementType = BABNPFCBKGI.ACHNNMHFGEM;

	[SerializeField]
	private float elasticity = 0.1f;

	[SerializeField]
	private float scrollSensitivity = 1f;

	[SerializeField]
	private bool inertia = true;

	[Tooltip("Only used when inertia is enabled")]
	[SerializeField]
	private float decelerationRate = 0.03f;

	[SerializeField]
	[Tooltip("Only used when inertia is enabled")]
	private Snap snap = new Snap
	{
		Enable = true,
		VelocityThreshold = 0.5f,
		Duration = 0.3f
	};

	[SerializeField]
	private int dataCount;

	[Tooltip("Event that fires when the position of an item changes")]
	public UpdatePositionEvent IEGIICJIICI;

	[Tooltip("Event that fires when an item is selected/focused")]
	public ItemSelectedEvent CIDMKCHGNOF;

	private Vector2 IJJIFECAIDL;

	private float KNDDHJPMDEP;

	private float FACFBKHKKDL;

	private bool EAHDLFEJDKN;

	private float KBPICMPEJDL;

	private float HPDLDLBINMM;

	private bool MHJBCFJGBEL;

	private float ILKGAEJHKHJ;

	private float NOIDPHEIMDC;

	private float ILIELNPJHEC;

	void IBeginDragHandler.OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		if (GBOFEMOALII.button == PointerEventData.InputButton.Left)
		{
			IJJIFECAIDL = Vector2.zero;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(viewport, GBOFEMOALII.position, GBOFEMOALII.pressEventCamera, out IJJIFECAIDL);
			KNDDHJPMDEP = FACFBKHKKDL;
			EAHDLFEJDKN = true;
		}
	}

	void IDragHandler.OnDrag(PointerEventData GBOFEMOALII)
	{
		if (GBOFEMOALII.button == PointerEventData.InputButton.Left && EAHDLFEJDKN && RectTransformUtility.ScreenPointToLocalPointInRectangle(viewport, GBOFEMOALII.position, GBOFEMOALII.pressEventCamera, out var localPoint))
		{
			Vector2 vector = localPoint - IJJIFECAIDL;
			float num = ((directionOfRecognize != BFDEFMPOJPO.CKGPDOGEHBB) ? vector.y : (0f - vector.x)) / OLCOFNBEFEO() * scrollSensitivity + KNDDHJPMDEP;
			float num2 = FLMANDLCJCN(num);
			num += num2;
			if (movementType == BABNPFCBKGI.ACHNNMHFGEM && num2 != 0f)
			{
				num -= MFPEFIKDPGL(num2, scrollSensitivity);
			}
			DBFCKHHDNAN(num);
		}
	}

	void IEndDragHandler.OnEndDrag(PointerEventData GBOFEMOALII)
	{
		if (GBOFEMOALII.button == PointerEventData.InputButton.Left)
		{
			EAHDLFEJDKN = false;
		}
	}

	private float OLCOFNBEFEO()
	{
		return (directionOfRecognize != BFDEFMPOJPO.CKGPDOGEHBB) ? viewport.rect.size.y : viewport.rect.size.x;
	}

	private float FLMANDLCJCN(float GIDEOJGAFJH)
	{
		if (movementType == BABNPFCBKGI.BIGEGGOMAOF)
		{
			return 0f;
		}
		if (GIDEOJGAFJH < 0f)
		{
			return 0f - GIDEOJGAFJH;
		}
		if (GIDEOJGAFJH > (float)(dataCount - 1))
		{
			return (float)(dataCount - 1) - GIDEOJGAFJH;
		}
		return 0f;
	}

	private void DBFCKHHDNAN(float GIDEOJGAFJH)
	{
		FACFBKHKKDL = GIDEOJGAFJH;
		if (IEGIICJIICI != null)
		{
			IEGIICJIICI.Invoke(FACFBKHKKDL);
		}
	}

	private float MFPEFIKDPGL(float HGJKGCDLALF, float IPBCKIBCBBE)
	{
		return (1f - 1f / (Mathf.Abs(HGJKGCDLALF) * 0.55f / IPBCKIBCBBE + 1f)) * IPBCKIBCBBE * Mathf.Sign(HGJKGCDLALF);
	}

	public void BKMNBJEHJMB(int PFMHOGCPEOI)
	{
		dataCount = PFMHOGCPEOI;
	}

	private void Update()
	{
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		float num = FLMANDLCJCN(FACFBKHKKDL);
		if (MHJBCFJGBEL)
		{
			float num2 = Mathf.Clamp01((Time.unscaledTime - NOIDPHEIMDC) / Mathf.Max(ILKGAEJHKHJ, float.Epsilon));
			float gIDEOJGAFJH = Mathf.Lerp(KNDDHJPMDEP, ILIELNPJHEC, EEKBEIODKKG(0f, 1f, num2));
			DBFCKHHDNAN(gIDEOJGAFJH);
			if (Mathf.Approximately(num2, 1f))
			{
				MHJBCFJGBEL = false;
				if (CIDMKCHGNOF != null)
				{
					CIDMKCHGNOF.Invoke(Mathf.RoundToInt(LOPIHAOAEHD(ILIELNPJHEC, dataCount)));
				}
			}
		}
		else if (!EAHDLFEJDKN && (num != 0f || KBPICMPEJDL != 0f))
		{
			float num3 = FACFBKHKKDL;
			if (movementType == BABNPFCBKGI.ACHNNMHFGEM && num != 0f)
			{
				float currentVelocity = KBPICMPEJDL;
				num3 = Mathf.SmoothDamp(FACFBKHKKDL, FACFBKHKKDL + num, ref currentVelocity, elasticity, float.PositiveInfinity, unscaledDeltaTime);
				KBPICMPEJDL = currentVelocity;
			}
			else if (inertia)
			{
				KBPICMPEJDL *= Mathf.Pow(decelerationRate, unscaledDeltaTime);
				if (Mathf.Abs(KBPICMPEJDL) < 0.001f)
				{
					KBPICMPEJDL = 0f;
				}
				num3 += KBPICMPEJDL * unscaledDeltaTime;
				if (snap.Enable && Mathf.Abs(KBPICMPEJDL) < snap.VelocityThreshold)
				{
					AHPCPBHKCOD(Mathf.RoundToInt(FACFBKHKKDL), snap.Duration);
				}
			}
			else
			{
				KBPICMPEJDL = 0f;
			}
			if (KBPICMPEJDL != 0f)
			{
				if (movementType == BABNPFCBKGI.OCICAIGKHJE)
				{
					num = FLMANDLCJCN(num3);
					num3 += num;
				}
				DBFCKHHDNAN(num3);
			}
		}
		if (!MHJBCFJGBEL && EAHDLFEJDKN && inertia)
		{
			float b = (FACFBKHKKDL - HPDLDLBINMM) / unscaledDeltaTime;
			KBPICMPEJDL = Mathf.Lerp(KBPICMPEJDL, b, unscaledDeltaTime * 10f);
		}
		if (FACFBKHKKDL != HPDLDLBINMM)
		{
			HPDLDLBINMM = FACFBKHKKDL;
		}
	}

	public void AHPCPBHKCOD(int JNDABHCJHHD, float PJBGGDBFEEP)
	{
		KBPICMPEJDL = 0f;
		MHJBCFJGBEL = true;
		ILKGAEJHKHJ = PJBGGDBFEEP;
		NOIDPHEIMDC = Time.unscaledTime;
		KNDDHJPMDEP = FACFBKHKKDL;
		ILIELNPJHEC = ((movementType != 0) ? ((float)JNDABHCJHHD) : GGCDBCGCFBF(JNDABHCJHHD));
	}

	private float GGCDBCGCFBF(int JNDABHCJHHD)
	{
		float num = LOPIHAOAEHD(JNDABHCJHHD, dataCount) - LOPIHAOAEHD(FACFBKHKKDL, dataCount);
		if (Mathf.Abs(num) > (float)dataCount * 0.5f)
		{
			num = Mathf.Sign(0f - num) * ((float)dataCount - Mathf.Abs(num));
		}
		return num + FACFBKHKKDL;
	}

	private float LOPIHAOAEHD(float GIDEOJGAFJH, int JMBJALGFMPA)
	{
		if (GIDEOJGAFJH < 0f)
		{
			GIDEOJGAFJH = (float)(JMBJALGFMPA - 1) + (GIDEOJGAFJH + 1f) % (float)JMBJALGFMPA;
		}
		else if (GIDEOJGAFJH > (float)(JMBJALGFMPA - 1))
		{
			GIDEOJGAFJH %= (float)JMBJALGFMPA;
		}
		return GIDEOJGAFJH;
	}

	private float EEKBEIODKKG(float EHHGNIOBMDN, float HDMCLHKMFNO, float EHAPKEKPMOE)
	{
		EHAPKEKPMOE /= 0.5f;
		HDMCLHKMFNO -= EHHGNIOBMDN;
		if (EHAPKEKPMOE < 1f)
		{
			return HDMCLHKMFNO * 0.5f * EHAPKEKPMOE * EHAPKEKPMOE * EHAPKEKPMOE + EHHGNIOBMDN;
		}
		EHAPKEKPMOE -= 2f;
		return HDMCLHKMFNO * 0.5f * (EHAPKEKPMOE * EHAPKEKPMOE * EHAPKEKPMOE + 2f) + EHHGNIOBMDN;
	}
}
