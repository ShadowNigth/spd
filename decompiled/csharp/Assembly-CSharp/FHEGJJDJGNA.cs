using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class FHEGJJDJGNA : MonoBehaviour
{
	public InputField FKJADFJKADI;

	public string BOLCJDBKMCA;

	private string LKDGCBOBNHK
	{
		get
		{
			return GUIUtility.systemCopyBuffer;
		}
		set
		{
			Regex regex = new Regex("<[^>]*>");
			GUIUtility.systemCopyBuffer = regex.Replace(GUIUtility.systemCopyBuffer, string.Empty);
		}
	}

	public string IMPKMAEGMMF(string LGNIFJCEECH)
	{
		int num = LGNIFJCEECH.IndexOf("\r\n", StringComparison.Ordinal) + 2;
		return LGNIFJCEECH.Substring(num, LGNIFJCEECH.Length - num);
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (Input.anyKeyDown)
		{
			FNFKLBLIJAF(BOLCJDBKMCA);
		}
	}

	public void FNFKLBLIJAF(string LGNIFJCEECH)
	{
		InputField fKJADFJKADI = FKJADFJKADI;
		fKJADFJKADI.text = fKJADFJKADI.text + LGNIFJCEECH + "\r\n";
		if (FKJADFJKADI.text.Split2().Length > 30)
		{
			FKJADFJKADI.text = IMPKMAEGMMF(FKJADFJKADI.text);
		}
	}
}
