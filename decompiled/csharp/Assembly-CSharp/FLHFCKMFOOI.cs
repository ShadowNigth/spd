using UnityEngine;

public class FLHFCKMFOOI : MonoBehaviour
{
	public bool JGGENAOHAKE;

	private int AENHNIMMHFH;

	private int AFMMHGKDKLG;

	[HideInInspector]
	public Rect CILDHMEBIFP;

	[HideInInspector]
	public Rect DEPKBDEFMLE;

	[HideInInspector]
	public Rect DGAJLCJFGEF;

	[HideInInspector]
	public Rect NNMDMJMANAL;

	private bool NNPLDHGIPLL = true;

	private void Update()
	{
		if (AENHNIMMHFH != Screen.width || AFMMHGKDKLG != Screen.height)
		{
			AENHNIMMHFH = Screen.width;
			AFMMHGKDKLG = Screen.height;
			DEPKBDEFMLE.x = (float)AENHNIMMHFH - (float)AENHNIMMHFH / 100f * 57.5f;
			DEPKBDEFMLE.y = 5f;
			DEPKBDEFMLE.width = (float)AENHNIMMHFH / 100f * 15.25f;
			DEPKBDEFMLE.height = (float)AFMMHGKDKLG / 14f;
			CILDHMEBIFP.x = (float)AENHNIMMHFH - (float)AENHNIMMHFH / 100f * 57.5f;
			CILDHMEBIFP.y = DEPKBDEFMLE.height + 12f;
			CILDHMEBIFP.width = (float)AENHNIMMHFH / 100f * 15.25f;
			CILDHMEBIFP.height = (float)AFMMHGKDKLG / 14f;
			DGAJLCJFGEF.x = 5f;
			NNMDMJMANAL.x = (float)AENHNIMMHFH - (float)AENHNIMMHFH / 2.45f;
			ref Rect nNMDMJMANAL = ref NNMDMJMANAL;
			float y = 5f;
			DGAJLCJFGEF.y = y;
			nNMDMJMANAL.y = y;
			ref Rect nNMDMJMANAL2 = ref NNMDMJMANAL;
			y = (float)AENHNIMMHFH / 2.5f;
			DGAJLCJFGEF.width = y;
			nNMDMJMANAL2.width = y;
			ref Rect nNMDMJMANAL3 = ref NNMDMJMANAL;
			y = (float)AFMMHGKDKLG / 2f;
			DGAJLCJFGEF.height = y;
			nNMDMJMANAL3.height = y;
		}
	}

	private void OnGUI()
	{
		if (GUI.Button(DEPKBDEFMLE, "Enable / Disable \nControllers"))
		{
			LJIBBKOGAGL.FJDJDEEEDAH(!LJIBBKOGAGL.FPGBBDJIHMG);
		}
		if (LJIBBKOGAGL.FPGBBDJIHMG)
		{
			if (GUI.Button(CILDHMEBIFP, "Show / Hide \nTouch Zones"))
			{
				NNPLDHGIPLL = !NNPLDHGIPLL;
				LJIBBKOGAGL.FKKNAFDPBOC(NNPLDHGIPLL);
			}
			if (JGGENAOHAKE)
			{
				GUILayout.BeginArea(DGAJLCJFGEF);
				GUILayout.BeginVertical("Box");
				EBEJPFLHJDG("<b>Joystick</b>");
				LNALDFBAPKK("Joystick");
				GUILayout.EndVertical();
				GUILayout.EndArea();
			}
			if (JGGENAOHAKE)
			{
				GUILayout.BeginArea(NNMDMJMANAL);
				GUILayout.BeginVertical("Box");
				EBEJPFLHJDG("<b>Touchpad</b>");
				LNALDFBAPKK("Touchpad");
				PCNOLNFJGEJ("Touchpad");
				GUILayout.EndVertical();
				GUILayout.EndArea();
			}
		}
	}

	private void PCNOLNFJGEJ(string FMCIJOLEIMG)
	{
		float mIEPDOFPFKD = LJIBBKOGAGL.IEEKKHDFDDC(FMCIJOLEIMG);
		mIEPDOFPFKD = DBEPIKDJPFE("Sensitivity", mIEPDOFPFKD, 1f, 10f);
		LJIBBKOGAGL.KOGJJHBHIOA(FMCIJOLEIMG, mIEPDOFPFKD);
	}

	private void LNALDFBAPKK(string FMCIJOLEIMG)
	{
		GUILayout.BeginHorizontal();
		bool value = LJIBBKOGAGL.PJOIHNMKCBB(FMCIJOLEIMG, GNMDFPDBPEI.CKGPDOGEHBB);
		GUILayout.BeginHorizontal();
		GUILayout.Label("Enable X Axis", GUILayout.Width(115f));
		value = GUILayout.Toggle(value, string.Empty);
		GUILayout.EndHorizontal();
		LJIBBKOGAGL.KKDMBCCGKBJ(FMCIJOLEIMG, GNMDFPDBPEI.CKGPDOGEHBB, value);
		if (value)
		{
			bool value2 = LJIBBKOGAGL.DDJLHCCMLAC(FMCIJOLEIMG, GNMDFPDBPEI.CKGPDOGEHBB);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Inverse X", GUILayout.Width(60f));
			value2 = GUILayout.Toggle(value2, string.Empty);
			GUILayout.EndHorizontal();
			LJIBBKOGAGL.GELGKMJMHPP(FMCIJOLEIMG, GNMDFPDBPEI.CKGPDOGEHBB, value2);
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		bool value3 = LJIBBKOGAGL.PJOIHNMKCBB(FMCIJOLEIMG, GNMDFPDBPEI.IOKNFMCJIHM);
		GUILayout.BeginHorizontal();
		GUILayout.Label("Enable Y Axis", GUILayout.Width(115f));
		value3 = GUILayout.Toggle(value3, string.Empty);
		GUILayout.EndHorizontal();
		LJIBBKOGAGL.KKDMBCCGKBJ(FMCIJOLEIMG, GNMDFPDBPEI.IOKNFMCJIHM, value3);
		if (value3)
		{
			bool value4 = LJIBBKOGAGL.DDJLHCCMLAC(FMCIJOLEIMG, GNMDFPDBPEI.IOKNFMCJIHM);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Inverse Y", GUILayout.Width(60f));
			value4 = GUILayout.Toggle(value4, string.Empty);
			GUILayout.EndHorizontal();
			LJIBBKOGAGL.GELGKMJMHPP(FMCIJOLEIMG, GNMDFPDBPEI.IOKNFMCJIHM, value4);
		}
		GUILayout.EndHorizontal();
	}

	private void EBEJPFLHJDG(string EFMBGMNAMBP)
	{
		GUIStyle style = GUI.skin.GetStyle("Label");
		style.richText = true;
		style.alignment = TextAnchor.UpperCenter;
		style.normal.textColor = Color.red;
		GUILayout.Label(EFMBGMNAMBP, style);
		style.richText = false;
		style.alignment = TextAnchor.UpperLeft;
		style.normal.textColor = Color.white;
	}

	private float DBEPIKDJPFE(string MGDJNMNHMFM, float MIEPDOFPFKD, float ANOEFHMLOKL, float OBFNPJEKFLL)
	{
		GUILayout.BeginHorizontal();
		GUILayout.Label(MGDJNMNHMFM, GUILayout.Width(115f));
		MIEPDOFPFKD = GUILayout.HorizontalSlider(MIEPDOFPFKD, ANOEFHMLOKL, OBFNPJEKFLL);
		GUILayout.Space(10f);
		GUILayout.Label($"{MIEPDOFPFKD:F2}", GUILayout.MaxWidth(50f));
		GUILayout.EndHorizontal();
		return MIEPDOFPFKD;
	}
}
