using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

[AddComponentMenu("UI/Extensions/UI_Knob")]
[RequireComponent(typeof(Image))]
public class KOLKNGPCKNA : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEventSystemHandler
{
	public enum KHCEHFJKDEF
	{
		KKBFJMJBNNH,
		HBMIBJFOKGF
	}

	[Tooltip("Direction of rotation CW - clockwise, CCW - counterClockwise")]
	public KHCEHFJKDEF BADIHIKMKJF;

	[HideInInspector]
	public float MNILJHBHBMF;

	[Tooltip("Max value of the knob, maximum RAW output value knob can reach, overrides snap step, IF set to 0 or higher than loops, max value will be set by loops")]
	public float OBFNPJEKFLL;

	[Tooltip("How many rotations knob can do, if higher than max value, the latter will limit max value")]
	public int NKBGCGGBJHI = 1;

	[Tooltip("Clamp output value between 0 and 1, usefull with loops > 1")]
	public bool CANFBMKOCML;

	[Tooltip("snap to position?")]
	public bool PMBECKBLGBE;

	[Tooltip("Number of positions to snap")]
	public int PAMJDBOJFFA = 10;

	[Space(30f)]
	public KnobFloatValueEvent ICOHIIJIPHE;

	private float AJKKDBGKIEI;

	private float AENHNEGFJHO;

	private float CGKEGDCJJLB;

	private float EMEFLHNKEBM;

	private Vector2 GAJHIKMBCLJ;

	private Quaternion KJPMGPIPHOJ;

	private bool BAKIEBLAPEN;

	public void OnPointerDown(PointerEventData GBOFEMOALII)
	{
		BAKIEBLAPEN = true;
	}

	public void OnPointerUp(PointerEventData GBOFEMOALII)
	{
		BAKIEBLAPEN = false;
	}

	public void OnPointerEnter(PointerEventData GBOFEMOALII)
	{
		BAKIEBLAPEN = true;
	}

	public void OnPointerExit(PointerEventData GBOFEMOALII)
	{
		BAKIEBLAPEN = false;
	}

	public void OnBeginDrag(PointerEventData GBOFEMOALII)
	{
		FKFLKAJGNHP(GBOFEMOALII);
	}

	private void FKFLKAJGNHP(PointerEventData GBOFEMOALII)
	{
		KJPMGPIPHOJ = base.transform.rotation;
		GAJHIKMBCLJ = GBOFEMOALII.position - (Vector2)base.transform.position;
		CGKEGDCJJLB = Mathf.Atan2(GAJHIKMBCLJ.y, GAJHIKMBCLJ.x) * 57.29578f;
	}

	public void OnDrag(PointerEventData GBOFEMOALII)
	{
		if (!BAKIEBLAPEN)
		{
			FKFLKAJGNHP(GBOFEMOALII);
			return;
		}
		GAJHIKMBCLJ = GBOFEMOALII.position - (Vector2)base.transform.position;
		EMEFLHNKEBM = Mathf.Atan2(GAJHIKMBCLJ.y, GAJHIKMBCLJ.x) * 57.29578f;
		Quaternion quaternion = Quaternion.AngleAxis(EMEFLHNKEBM - CGKEGDCJJLB, base.transform.forward);
		quaternion.eulerAngles = new Vector3(0f, 0f, quaternion.eulerAngles.z);
		Quaternion rotation = KJPMGPIPHOJ * quaternion;
		if (BADIHIKMKJF == KHCEHFJKDEF.KKBFJMJBNNH)
		{
			MNILJHBHBMF = 1f - rotation.eulerAngles.z / 360f;
			if (PMBECKBLGBE)
			{
				FOOCPHJCBAL(ref MNILJHBHBMF);
				rotation.eulerAngles = new Vector3(0f, 0f, 360f - 360f * MNILJHBHBMF);
			}
		}
		else
		{
			MNILJHBHBMF = rotation.eulerAngles.z / 360f;
			if (PMBECKBLGBE)
			{
				FOOCPHJCBAL(ref MNILJHBHBMF);
				rotation.eulerAngles = new Vector3(0f, 0f, 360f * MNILJHBHBMF);
			}
		}
		if (Mathf.Abs(MNILJHBHBMF - AENHNEGFJHO) > 0.5f)
		{
			if (MNILJHBHBMF < 0.5f && NKBGCGGBJHI > 1 && AJKKDBGKIEI < (float)(NKBGCGGBJHI - 1))
			{
				AJKKDBGKIEI += 1f;
			}
			else if (MNILJHBHBMF > 0.5f && AJKKDBGKIEI >= 1f)
			{
				AJKKDBGKIEI -= 1f;
			}
			else
			{
				if (MNILJHBHBMF > 0.5f && AJKKDBGKIEI == 0f)
				{
					MNILJHBHBMF = 0f;
					base.transform.localEulerAngles = Vector3.zero;
					FKFLKAJGNHP(GBOFEMOALII);
					PMAKHJFBLMH(MNILJHBHBMF + AJKKDBGKIEI);
					return;
				}
				if (MNILJHBHBMF < 0.5f && AJKKDBGKIEI == (float)(NKBGCGGBJHI - 1))
				{
					MNILJHBHBMF = 1f;
					base.transform.localEulerAngles = Vector3.zero;
					FKFLKAJGNHP(GBOFEMOALII);
					PMAKHJFBLMH(MNILJHBHBMF + AJKKDBGKIEI);
					return;
				}
			}
		}
		if (OBFNPJEKFLL > 0f && MNILJHBHBMF + AJKKDBGKIEI > OBFNPJEKFLL)
		{
			MNILJHBHBMF = OBFNPJEKFLL;
			float z = ((BADIHIKMKJF != 0) ? (360f * OBFNPJEKFLL) : (360f - 360f * OBFNPJEKFLL));
			base.transform.localEulerAngles = new Vector3(0f, 0f, z);
			FKFLKAJGNHP(GBOFEMOALII);
			PMAKHJFBLMH(MNILJHBHBMF);
		}
		else
		{
			base.transform.rotation = rotation;
			PMAKHJFBLMH(MNILJHBHBMF + AJKKDBGKIEI);
			AENHNEGFJHO = MNILJHBHBMF;
		}
	}

	private void FOOCPHJCBAL(ref float MNILJHBHBMF)
	{
		float num = 1f / (float)PAMJDBOJFFA;
		float num2 = Mathf.Round(MNILJHBHBMF / num) * num;
		MNILJHBHBMF = num2;
	}

	private void PMAKHJFBLMH(float EHAPKEKPMOE)
	{
		if (CANFBMKOCML)
		{
			EHAPKEKPMOE /= (float)NKBGCGGBJHI;
		}
		ICOHIIJIPHE.Invoke(EHAPKEKPMOE);
	}
}
