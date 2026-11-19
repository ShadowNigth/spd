using System.Globalization;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class CAAJNPFINME : MonoBehaviour
{
	public KFANEHLIPBI AJFCGCFFDLP;

	public bool LMCFINMKEFF;

	private InputField NEFJFNOJBLH;

	private const string PGGLOILMEFJ = "^#?(?:[0-9a-fA-F]{3,4}){1,2}$";

	private void Awake()
	{
		NEFJFNOJBLH = GetComponent<InputField>();
		NEFJFNOJBLH.onEndEdit.AddListener(GIPHGLIHLBB);
		AJFCGCFFDLP.DNMFLMKBGAP.AddListener(CPIHOBHFIHF);
	}

	private void OnDestroy()
	{
		NEFJFNOJBLH.onValueChanged.RemoveListener(GIPHGLIHLBB);
		AJFCGCFFDLP.DNMFLMKBGAP.RemoveListener(CPIHOBHFIHF);
	}

	private void CPIHOBHFIHF(Color GNKGIKCFKMF)
	{
		NEFJFNOJBLH.text = NHDALHLKAFF(GNKGIKCFKMF);
	}

	private void GIPHGLIHLBB(string KFJANDKHJJF)
	{
		Color32 JPLPPELPDKF;
		if (LEIBAHBJEJC(KFJANDKHJJF, out JPLPPELPDKF))
		{
			AJFCGCFFDLP.MHGKIBFILBG = JPLPPELPDKF;
		}
		else
		{
			Debug.Log("hex value is in the wrong format, valid formats are: #RGB, #RGBA, #RRGGBB and #RRGGBBAA (# is optional)");
		}
	}

	private string NHDALHLKAFF(Color32 JPLPPELPDKF)
	{
		if (LMCFINMKEFF)
		{
			return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", JPLPPELPDKF.r, JPLPPELPDKF.g, JPLPPELPDKF.b, JPLPPELPDKF.a);
		}
		return string.Format("#{0:X2}{1:X2}{2:X2}", JPLPPELPDKF.r, JPLPPELPDKF.g, JPLPPELPDKF.b);
	}

	public static bool LEIBAHBJEJC(string AEBJKBMFECA, out Color32 JPLPPELPDKF)
	{
		if (Regex.IsMatch(AEBJKBMFECA, "^#?(?:[0-9a-fA-F]{3,4}){1,2}$"))
		{
			int num = (AEBJKBMFECA.StartsWith("#") ? 1 : 0);
			if (AEBJKBMFECA.Length == num + 8)
			{
				JPLPPELPDKF = new Color32(byte.Parse(AEBJKBMFECA.Substring(num, 2), NumberStyles.AllowHexSpecifier), byte.Parse(AEBJKBMFECA.Substring(num + 2, 2), NumberStyles.AllowHexSpecifier), byte.Parse(AEBJKBMFECA.Substring(num + 4, 2), NumberStyles.AllowHexSpecifier), byte.Parse(AEBJKBMFECA.Substring(num + 6, 2), NumberStyles.AllowHexSpecifier));
			}
			else if (AEBJKBMFECA.Length == num + 6)
			{
				JPLPPELPDKF = new Color32(byte.Parse(AEBJKBMFECA.Substring(num, 2), NumberStyles.AllowHexSpecifier), byte.Parse(AEBJKBMFECA.Substring(num + 2, 2), NumberStyles.AllowHexSpecifier), byte.Parse(AEBJKBMFECA.Substring(num + 4, 2), NumberStyles.AllowHexSpecifier), byte.MaxValue);
			}
			else if (AEBJKBMFECA.Length == num + 4)
			{
				JPLPPELPDKF = new Color32(byte.Parse(string.Empty + AEBJKBMFECA[num] + AEBJKBMFECA[num], NumberStyles.AllowHexSpecifier), byte.Parse(string.Empty + AEBJKBMFECA[num + 1] + AEBJKBMFECA[num + 1], NumberStyles.AllowHexSpecifier), byte.Parse(string.Empty + AEBJKBMFECA[num + 2] + AEBJKBMFECA[num + 2], NumberStyles.AllowHexSpecifier), byte.Parse(string.Empty + AEBJKBMFECA[num + 3] + AEBJKBMFECA[num + 3], NumberStyles.AllowHexSpecifier));
			}
			else
			{
				JPLPPELPDKF = new Color32(byte.Parse(string.Empty + AEBJKBMFECA[num] + AEBJKBMFECA[num], NumberStyles.AllowHexSpecifier), byte.Parse(string.Empty + AEBJKBMFECA[num + 1] + AEBJKBMFECA[num + 1], NumberStyles.AllowHexSpecifier), byte.Parse(string.Empty + AEBJKBMFECA[num + 2] + AEBJKBMFECA[num + 2], NumberStyles.AllowHexSpecifier), byte.MaxValue);
			}
			return true;
		}
		JPLPPELPDKF = default(Color32);
		return false;
	}
}
