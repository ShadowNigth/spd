using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Layout/Extensions/Table Layout Group")]
public class HHIKKLOKFLD : LayoutGroup
{
	public enum FNKIOMKEDOP
	{
		BLIACJDLMDH = 0,
		NKCANIEBMCM = 1,
		ALKFHLEPPJG = 2,
		CCDJCJDCKJB = 3
	}

	[SerializeField]
	protected FNKIOMKEDOP startCorner;

	[SerializeField]
	protected float[] columnWidths = new float[1] { 96f };

	[SerializeField]
	protected float minimumRowHeight = 32f;

	[SerializeField]
	protected bool flexibleRowHeight = true;

	[SerializeField]
	protected float columnSpacing;

	[SerializeField]
	protected float rowSpacing;

	private float[] NPINMCEKJPN;

	public FNKIOMKEDOP BHPAJDHCBNM
	{
		get
		{
			return startCorner;
		}
		set
		{
			SetProperty(ref startCorner, value);
		}
	}

	public float[] GJNDLDEAMJF
	{
		get
		{
			return columnWidths;
		}
		set
		{
			SetProperty(ref columnWidths, value);
		}
	}

	public float MMHIFPHGBDJ
	{
		get
		{
			return minimumRowHeight;
		}
		set
		{
			SetProperty(ref minimumRowHeight, value);
		}
	}

	public bool KMCAGBEANLN
	{
		get
		{
			return flexibleRowHeight;
		}
		set
		{
			SetProperty(ref flexibleRowHeight, value);
		}
	}

	public float FLDDIGJMHCN
	{
		get
		{
			return columnSpacing;
		}
		set
		{
			SetProperty(ref columnSpacing, value);
		}
	}

	public float KNJCJLKEEJN
	{
		get
		{
			return rowSpacing;
		}
		set
		{
			SetProperty(ref rowSpacing, value);
		}
	}

	public override void CalculateLayoutInputHorizontal()
	{
		base.CalculateLayoutInputHorizontal();
		float num = base.padding.horizontal;
		int num2 = Mathf.Min(base.rectChildren.Count, columnWidths.Length);
		for (int i = 0; i < num2; i++)
		{
			num += columnWidths[i];
			num += columnSpacing;
		}
		num -= columnSpacing;
		SetLayoutInputForAxis(num, num, 0f, 0);
	}

	public override void CalculateLayoutInputVertical()
	{
		int num = columnWidths.Length;
		int num2 = Mathf.CeilToInt((float)base.rectChildren.Count / (float)num);
		NPINMCEKJPN = new float[num2];
		float num3 = base.padding.vertical;
		float num4 = base.padding.vertical;
		if (num2 > 1)
		{
			float num5 = (float)(num2 - 1) * rowSpacing;
			num3 += num5;
			num4 += num5;
		}
		if (flexibleRowHeight)
		{
			float num6 = 0f;
			float num7 = 0f;
			for (int i = 0; i < num2; i++)
			{
				num6 = minimumRowHeight;
				num7 = minimumRowHeight;
				for (int j = 0; j < num; j++)
				{
					int num8 = i * num + j;
					if (num8 == base.rectChildren.Count)
					{
						break;
					}
					num7 = Mathf.Max(LayoutUtility.GetPreferredHeight(base.rectChildren[num8]), num7);
					num6 = Mathf.Max(LayoutUtility.GetMinHeight(base.rectChildren[num8]), num6);
				}
				num3 += num6;
				num4 += num7;
				NPINMCEKJPN[i] = num7;
			}
		}
		else
		{
			for (int k = 0; k < num2; k++)
			{
				NPINMCEKJPN[k] = minimumRowHeight;
			}
			num3 += (float)num2 * minimumRowHeight;
			num4 = num3;
		}
		num4 = Mathf.Max(num3, num4);
		SetLayoutInputForAxis(num3, num4, 1f, 1);
	}

	public override void SetLayoutHorizontal()
	{
		if (columnWidths.Length == 0)
		{
			columnWidths = new float[1];
		}
		int num = columnWidths.Length;
		int num2 = (int)startCorner % 2;
		float num3 = 0f;
		float num4 = 0f;
		int num5 = Mathf.Min(base.rectChildren.Count, columnWidths.Length);
		for (int i = 0; i < num5; i++)
		{
			num4 += columnWidths[i];
			num4 += columnSpacing;
		}
		num4 -= columnSpacing;
		num3 = GetStartOffset(0, num4);
		if (num2 == 1)
		{
			num3 += num4;
		}
		float num6 = num3;
		for (int j = 0; j < base.rectChildren.Count; j++)
		{
			int num7 = j % num;
			if (num7 == 0)
			{
				num6 = num3;
			}
			if (num2 == 1)
			{
				num6 -= columnWidths[num7];
			}
			SetChildAlongAxis(base.rectChildren[j], 0, num6, columnWidths[num7]);
			num6 = ((num2 != 1) ? (num6 + (columnWidths[num7] + columnSpacing)) : (num6 - columnSpacing));
		}
	}

	public override void SetLayoutVertical()
	{
		int num = columnWidths.Length;
		int num2 = NPINMCEKJPN.Length;
		int num3 = (int)startCorner / 2;
		float num4 = 0f;
		float num5 = 0f;
		for (int i = 0; i < num2; i++)
		{
			num5 += NPINMCEKJPN[i];
		}
		if (num2 > 1)
		{
			num5 += (float)(num2 - 1) * rowSpacing;
		}
		num4 = GetStartOffset(1, num5);
		if (num3 == 1)
		{
			num4 += num5;
		}
		float num6 = num4;
		for (int j = 0; j < num2; j++)
		{
			if (num3 == 1)
			{
				num6 -= NPINMCEKJPN[j];
			}
			for (int k = 0; k < num; k++)
			{
				int num7 = j * num + k;
				if (num7 == base.rectChildren.Count)
				{
					break;
				}
				SetChildAlongAxis(base.rectChildren[num7], 1, num6, NPINMCEKJPN[j]);
			}
			num6 = ((num3 != 1) ? (num6 + (NPINMCEKJPN[j] + rowSpacing)) : (num6 - rowSpacing));
		}
		NPINMCEKJPN = null;
	}
}
