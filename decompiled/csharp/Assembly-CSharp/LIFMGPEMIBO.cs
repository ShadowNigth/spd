using System.Collections.Generic;
using UnityEngine;

public class LIFMGPEMIBO : FOGIOGKLNIP
{
	public enum AKNJHOLPACP
	{
		AKEJOGNGAEL,
		JNODLNLEMNM,
		BCIHMPMMBBP
	}

	internal string[] PACNBCMEJOB = new string[10] { "Horizontal", "Vertical", "1 axis", "2 axis", "3 axis", "4 axis", "5 axis", "6 axis", "7 axis", "8 axis" };

	public Dictionary<KeyCode, InputKey> CCHMDKPJECN = new Dictionary<KeyCode, InputKey>();

	public float COHMLDCHPAI = 0.11f;

	public List<InputKey> EGGINBCAIHG = new List<InputKey>();

	public bool KJEDAPMICGD;

	public bool LKLNCHHHMBI;

	public bool JKLDEFENPKI;

	public bool DBHAMMBFAEL;

	public void Start()
	{
		if (FOGIOGKLNIP.LPLJMLGKCLK.CDKNILAFIKI == null)
		{
			FOGIOGKLNIP.LPLJMLGKCLK.CDKNILAFIKI = this;
		}
		foreach (InputKey item in EGGINBCAIHG)
		{
			CCHMDKPJECN.Add(item.key, item);
		}
		DHBGHDFFOLN();
	}

	public override void AILPFINEAEK()
	{
		if (GUILayout.Button("Clear"))
		{
			InputKey[] array = EGGINBCAIHG.ToArray();
			foreach (InputKey inputKey in array)
			{
				if (inputKey.name == inputKey.key.ToString())
				{
					EGGINBCAIHG.Remove(inputKey);
				}
			}
		}
		base.AILPFINEAEK();
	}

	public bool DFKJBNPCEIJ(KeyCode HINLOMMOGKI)
	{
		return DFKJBNPCEIJ(HINLOMMOGKI, AKNJHOLPACP.AKEJOGNGAEL);
	}

	public bool MAJOLNADCFG(KeyCode HINLOMMOGKI)
	{
		return DFKJBNPCEIJ(HINLOMMOGKI, AKNJHOLPACP.JNODLNLEMNM);
	}

	public bool DPNEFNPNBCD(KeyCode HINLOMMOGKI)
	{
		return DFKJBNPCEIJ(HINLOMMOGKI, AKNJHOLPACP.BCIHMPMMBBP);
	}

	public float PPECHIJCLHO(KeyCode HINLOMMOGKI)
	{
		if (CCHMDKPJECN.TryGetValue(HINLOMMOGKI, out var value))
		{
			if (value.axisName != string.Empty)
			{
				float axisRaw = Input.GetAxisRaw(value.axisName);
				if (Mathf.Abs(axisRaw) > COHMLDCHPAI && ((value.axis > 0f && axisRaw > 0f) || (value.axis < 0f && axisRaw < 0f)))
				{
					return axisRaw;
				}
			}
			return Input.GetKey(value.keySet) ? ((!(value.axis < 0f)) ? 1 : (-1)) : 0;
		}
		return 0f;
	}

	public bool DFKJBNPCEIJ(KeyCode HINLOMMOGKI, AKNJHOLPACP JCMELGFLGCD)
	{
		KeyCode keyCode = HINLOMMOGKI;
		if (CCHMDKPJECN.TryGetValue(HINLOMMOGKI, out var value))
		{
			if (FOGIOGKLNIP.PIOANBBCFFP != null && FOGIOGKLNIP.PIOANBBCFFP.IGJKLHOGPHL && (value.key != KeyCode.Return || value.key != KeyCode.Escape))
			{
				return false;
			}
			if (value.axisName != string.Empty)
			{
				float num = Input.GetAxisRaw(value.axisName);
				if (num != 0f && ((value.axis > 0f && num > 0f) || (value.axis < 0f && num < 0f)))
				{
					num = Mathf.Abs(num);
					if (JCMELGFLGCD == AKNJHOLPACP.AKEJOGNGAEL && num > COHMLDCHPAI)
					{
						value.oldAxis = num;
						return true;
					}
					if (JCMELGFLGCD == AKNJHOLPACP.JNODLNLEMNM && value.oldAxis < COHMLDCHPAI && num > COHMLDCHPAI)
					{
						MonoBehaviour.print(value.axisName + " " + value.name);
						value.oldAxis = num;
						return true;
					}
				}
				value.oldAxis = num;
			}
			keyCode = value.keySet;
		}
		bool flag = keyCode > KeyCode.Numlock;
		return JCMELGFLGCD switch
		{
			AKNJHOLPACP.AKEJOGNGAEL => (flag && Input.GetKey(HINLOMMOGKI)) || Input.GetKey(keyCode), 
			AKNJHOLPACP.JNODLNLEMNM => (flag && Input.GetKeyDown(HINLOMMOGKI)) || Input.GetKeyDown(keyCode), 
			_ => (flag && Input.GetKeyUp(HINLOMMOGKI)) || Input.GetKeyUp(keyCode), 
		};
	}

	public void ACFFCBCMAKO()
	{
	}

	public void Update()
	{
		LKLNCHHHMBI = MAJOLNADCFG(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);
		KJEDAPMICGD = MAJOLNADCFG(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow);
		JKLDEFENPKI = MAJOLNADCFG(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
		DBHAMMBFAEL = MAJOLNADCFG(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
	}

	public void OBKMIHILMLH()
	{
		foreach (InputKey value in CCHMDKPJECN.Values)
		{
			FOGIOGKLNIP.BBKFOHCEOCK("Keys_" + value.key, (int)value.keySet);
			FOGIOGKLNIP.GKKEPIMNFBB("AxisName_" + value.key, value.axisName);
			FOGIOGKLNIP.DEJNFKMKPKN("Axis_" + value.key, value.axis);
		}
		JKPOJMOFFMF.OBKMIHILMLH();
	}

	public bool JLIBFOMLOGD(int FAGMOBEKJND = 0)
	{
		return DFKJBNPCEIJ((KeyCode)(323 + FAGMOBEKJND), AKNJHOLPACP.AKEJOGNGAEL);
	}

	public bool JEMHJCCILMN(int FAGMOBEKJND = 0)
	{
		return DFKJBNPCEIJ((KeyCode)(323 + FAGMOBEKJND), AKNJHOLPACP.JNODLNLEMNM);
	}

	private void DHBGHDFFOLN()
	{
		foreach (InputKey value in CCHMDKPJECN.Values)
		{
			if (JKPOJMOFFMF.BCHKAKOPNKB("Keys_" + value.key))
			{
				value.keySet = (KeyCode)FOGIOGKLNIP.ICLCHCGKAPN("Keys_" + value.key);
			}
			if (JKPOJMOFFMF.BCHKAKOPNKB("AxisName_" + value.key))
			{
				value.axisName = FOGIOGKLNIP.CEKCOJEJPAN("AxisName_" + value.key, string.Empty);
				value.axis = FOGIOGKLNIP.CMBFGIGIDIP("Axis_" + value.key);
			}
		}
	}
}
