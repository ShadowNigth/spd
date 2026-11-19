using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Layout/Extensions/Flow Layout Group")]
public class JCGONFAKPDN : LayoutGroup
{
	public float FEAFNFAHLOI;

	public float CJDLJPAHBGD;

	public bool APCCCCOLOKD;

	public bool ODDHOIHMICD;

	public bool PMHAPOBGFPG;

	private float GEBPBNPEFFC;

	private readonly IList<RectTransform> IIGMFGEADKP = new List<RectTransform>();

	protected bool NOBAKPFHNLP => base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.MiddleCenter || base.childAlignment == TextAnchor.UpperCenter;

	protected bool DANEPNEOPEH => base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.UpperRight;

	protected bool KBLKHODPADA => base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.MiddleCenter;

	protected bool ODOCJIMGNJA => base.childAlignment == TextAnchor.LowerLeft || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerCenter;

	public override void CalculateLayoutInputHorizontal()
	{
		base.CalculateLayoutInputHorizontal();
		float totalMin = BHFAEHIHKHA() + (float)base.padding.left + (float)base.padding.right;
		SetLayoutInputForAxis(totalMin, -1f, -1f, 0);
	}

	public override void SetLayoutHorizontal()
	{
		GOFLNIGDEKL(base.rectTransform.rect.width, 0, GPBAALJOOEB: false);
	}

	public override void SetLayoutVertical()
	{
		GOFLNIGDEKL(base.rectTransform.rect.width, 1, GPBAALJOOEB: false);
	}

	public override void CalculateLayoutInputVertical()
	{
		GEBPBNPEFFC = GOFLNIGDEKL(base.rectTransform.rect.width, 1, GPBAALJOOEB: true);
	}

	public float GOFLNIGDEKL(float KAPGDBCIGHP, int PJMGCBCCJPD, bool GPBAALJOOEB)
	{
		float height = base.rectTransform.rect.height;
		float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
		float num2 = ((!ODOCJIMGNJA) ? ((float)base.padding.top) : ((float)base.padding.bottom));
		float num3 = 0f;
		float num4 = 0f;
		for (int i = 0; i < base.rectChildren.Count; i++)
		{
			int index = ((!ODOCJIMGNJA) ? i : (base.rectChildren.Count - 1 - i));
			RectTransform rectTransform = base.rectChildren[index];
			float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 0);
			float preferredSize2 = LayoutUtility.GetPreferredSize(rectTransform, 1);
			preferredSize = Mathf.Min(preferredSize, num);
			if (num3 + preferredSize > num)
			{
				num3 -= FEAFNFAHLOI;
				if (!GPBAALJOOEB)
				{
					float lBMGNFLAJNM = LNMCIKNJLNE(height, num2, num4);
					OIDPFBGOCNG(IIGMFGEADKP, num3, num4, num, base.padding.left, lBMGNFLAJNM, PJMGCBCCJPD);
				}
				IIGMFGEADKP.Clear();
				num2 += num4;
				num2 += CJDLJPAHBGD;
				num4 = 0f;
				num3 = 0f;
			}
			num3 += preferredSize;
			IIGMFGEADKP.Add(rectTransform);
			if (preferredSize2 > num4)
			{
				num4 = preferredSize2;
			}
			if (i < base.rectChildren.Count - 1)
			{
				num3 += FEAFNFAHLOI;
			}
		}
		if (!GPBAALJOOEB)
		{
			float lBMGNFLAJNM2 = LNMCIKNJLNE(height, num2, num4);
			num3 -= FEAFNFAHLOI;
			OIDPFBGOCNG(IIGMFGEADKP, num3, num4, num - ((IIGMFGEADKP.Count <= 1) ? 0f : FEAFNFAHLOI), base.padding.left, lBMGNFLAJNM2, PJMGCBCCJPD);
		}
		IIGMFGEADKP.Clear();
		num2 += num4;
		num2 += (float)((!ODOCJIMGNJA) ? base.padding.bottom : base.padding.top);
		if (GPBAALJOOEB && PJMGCBCCJPD == 1)
		{
			SetLayoutInputForAxis(num2, num2, -1f, PJMGCBCCJPD);
		}
		return num2;
	}

	private float LNMCIKNJLNE(float KIKDDANOBLD, float LBMGNFLAJNM, float GMIGADFNMKP)
	{
		if (ODOCJIMGNJA)
		{
			return KIKDDANOBLD - LBMGNFLAJNM - GMIGADFNMKP;
		}
		if (KBLKHODPADA)
		{
			return KIKDDANOBLD * 0.5f - GEBPBNPEFFC * 0.5f + LBMGNFLAJNM;
		}
		return LBMGNFLAJNM;
	}

	protected void OIDPFBGOCNG(IList<RectTransform> GOGDPKLAHDN, float DOLMNGIHPCJ, float DANLEDINIHH, float IJBNMOOPBON, float KDJIMGFJFOO, float LBMGNFLAJNM, int PJMGCBCCJPD)
	{
		float num = KDJIMGFJFOO;
		if (!ODDHOIHMICD && NOBAKPFHNLP)
		{
			num += (IJBNMOOPBON - DOLMNGIHPCJ) * 0.5f;
		}
		else if (!ODDHOIHMICD && DANEPNEOPEH)
		{
			num += IJBNMOOPBON - DOLMNGIHPCJ;
		}
		float num2 = 0f;
		float num3 = 0f;
		if (ODDHOIHMICD)
		{
			num2 = (IJBNMOOPBON - DOLMNGIHPCJ) / (float)IIGMFGEADKP.Count;
		}
		else if (APCCCCOLOKD)
		{
			num3 = (IJBNMOOPBON - DOLMNGIHPCJ) / (float)(IIGMFGEADKP.Count - 1);
			if (IIGMFGEADKP.Count > 1)
			{
				if (NOBAKPFHNLP)
				{
					num -= num3 * 0.5f * (float)(IIGMFGEADKP.Count - 1);
				}
				else if (DANEPNEOPEH)
				{
					num -= num3 * (float)(IIGMFGEADKP.Count - 1);
				}
			}
		}
		for (int i = 0; i < IIGMFGEADKP.Count; i++)
		{
			int index = ((!ODOCJIMGNJA) ? i : (IIGMFGEADKP.Count - 1 - i));
			RectTransform rect = IIGMFGEADKP[index];
			float a = LayoutUtility.GetPreferredSize(rect, 0) + num2;
			float num4 = LayoutUtility.GetPreferredSize(rect, 1);
			if (PMHAPOBGFPG)
			{
				num4 = DANLEDINIHH;
			}
			a = Mathf.Min(a, IJBNMOOPBON);
			float num5 = LBMGNFLAJNM;
			if (KBLKHODPADA)
			{
				num5 += (DANLEDINIHH - num4) * 0.5f;
			}
			else if (ODOCJIMGNJA)
			{
				num5 += DANLEDINIHH - num4;
			}
			if (APCCCCOLOKD && i > 0)
			{
				num += num3;
			}
			if (PJMGCBCCJPD == 0)
			{
				SetChildAlongAxis(rect, 0, num, a);
			}
			else
			{
				SetChildAlongAxis(rect, 1, num5, num4);
			}
			if (i < IIGMFGEADKP.Count - 1)
			{
				num += a + FEAFNFAHLOI;
			}
		}
	}

	public float BHFAEHIHKHA()
	{
		float num = 0f;
		for (int i = 0; i < base.rectChildren.Count; i++)
		{
			float a = LayoutUtility.GetMinWidth(base.rectChildren[i]);
			num = Mathf.Max(a, num);
		}
		return num;
	}
}
