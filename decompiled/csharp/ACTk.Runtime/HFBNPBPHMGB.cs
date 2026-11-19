using System;
using System.IO;

internal class HFBNPBPHMGB
{
	public bool OAHLIKHNKCG;

	public bool EEKPCEDFEAF;

	public bool JKJIBLIEJGA;

	public bool JMNEFJJGMEC;

	public string LGKLCKFOCOG;

	public string HEPFJPFBCBK;

	public string AGCNDODGFEC;

	public bool KPLHALNJBAD(string GKEBBPEIGPL, string IHKDEKAAJOO = null)
	{
		if (HEPFJPFBCBK != null)
		{
			string extension = Path.GetExtension(GKEBBPEIGPL);
			if (string.IsNullOrEmpty(extension) || extension == ".")
			{
				return false;
			}
			extension = extension.Remove(0, 1);
			if (!HEPFJPFBCBK.Equals(extension, (!OAHLIKHNKCG) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
			{
				return false;
			}
		}
		if (AGCNDODGFEC != null)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(GKEBBPEIGPL);
			if (string.IsNullOrEmpty(fileNameWithoutExtension))
			{
				return false;
			}
			if (JKJIBLIEJGA)
			{
				if (!AGCNDODGFEC.Equals(fileNameWithoutExtension, (!OAHLIKHNKCG) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
				{
					return false;
				}
			}
			else if (fileNameWithoutExtension.IndexOf(AGCNDODGFEC, (!OAHLIKHNKCG) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) == -1)
			{
				return false;
			}
		}
		if (LGKLCKFOCOG != null && GKEBBPEIGPL.IndexOf(LGKLCKFOCOG, (!OAHLIKHNKCG) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) == -1)
		{
			return false;
		}
		return true;
	}

	public override string ToString()
	{
		return OAHLIKHNKCG + "|" + EEKPCEDFEAF + "|" + JKJIBLIEJGA + "|" + JMNEFJJGMEC + "|" + LGKLCKFOCOG + "|" + HEPFJPFBCBK + "|" + AGCNDODGFEC;
	}
}
