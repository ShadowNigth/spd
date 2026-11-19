using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[AddComponentMenu("UI/Effects/Extensions/Curly UI Image")]
[RequireComponent(typeof(RectTransform))]
public class LDBDLKGEFEN : IFLGDMKKLJD
{
	public static int CAHBLKAFBGK = 2;

	public static int PJHLACEJFMB;

	[SerializeField]
	[HideInInspector]
	[Tooltip("For changing the size of the corner for tiled or sliced Image")]
	public Vector2 cornerPosRatio = Vector2.one * -1f;

	[SerializeField]
	[HideInInspector]
	protected Vector2 oriCornerPosRatio = Vector2.one * -1f;

	public Vector2 MIOBMFIJKIP => oriCornerPosRatio;

	public Image ACCAOPMBCKF => (Image)uiGraphic;

	public static int IBGBMPJMCAC(Image.Type FAICJMBCDMD)
	{
		if (FAICJMBCDMD == Image.Type.Sliced)
		{
			return CAHBLKAFBGK;
		}
		return PJHLACEJFMB;
	}

	public override void ONKNMHJOJIL()
	{
		if (uiGraphic == null)
		{
			uiGraphic = GetComponent<Image>();
		}
		base.ONKNMHJOJIL();
	}

	protected override void CIAPLCOBLCO(List<UIVertex> MKGCMGECOLD)
	{
		if (!IsActive())
		{
			return;
		}
		if (ACCAOPMBCKF.type == Image.Type.Filled)
		{
			Debug.LogWarning("Might not work well Radial Filled at the moment!");
		}
		else if (ACCAOPMBCKF.type == Image.Type.Sliced || ACCAOPMBCKF.type == Image.Type.Tiled)
		{
			if (cornerPosRatio == Vector2.one * -1f)
			{
				cornerPosRatio = MKGCMGECOLD[IBGBMPJMCAC(ACCAOPMBCKF.type)].position;
				cornerPosRatio.x = (cornerPosRatio.x + NIKILPJFCBI.pivot.x * NIKILPJFCBI.rect.width) / NIKILPJFCBI.rect.width;
				cornerPosRatio.y = (cornerPosRatio.y + NIKILPJFCBI.pivot.y * NIKILPJFCBI.rect.height) / NIKILPJFCBI.rect.height;
				oriCornerPosRatio = cornerPosRatio;
			}
			if (cornerPosRatio.x < 0f)
			{
				cornerPosRatio.x = 0f;
			}
			if (cornerPosRatio.x >= 0.5f)
			{
				cornerPosRatio.x = 0.5f;
			}
			if (cornerPosRatio.y < 0f)
			{
				cornerPosRatio.y = 0f;
			}
			if (cornerPosRatio.y >= 0.5f)
			{
				cornerPosRatio.y = 0.5f;
			}
			for (int i = 0; i < MKGCMGECOLD.Count; i++)
			{
				UIVertex value = MKGCMGECOLD[i];
				float num = (value.position.x + NIKILPJFCBI.rect.width * NIKILPJFCBI.pivot.x) / NIKILPJFCBI.rect.width;
				float num2 = (value.position.y + NIKILPJFCBI.rect.height * NIKILPJFCBI.pivot.y) / NIKILPJFCBI.rect.height;
				num = ((!(num < oriCornerPosRatio.x)) ? ((!(num > 1f - oriCornerPosRatio.x)) ? Mathf.Lerp(cornerPosRatio.x, 1f - cornerPosRatio.x, (num - oriCornerPosRatio.x) / (1f - oriCornerPosRatio.x * 2f)) : Mathf.Lerp(1f - cornerPosRatio.x, 1f, (num - (1f - oriCornerPosRatio.x)) / oriCornerPosRatio.x)) : Mathf.Lerp(0f, cornerPosRatio.x, num / oriCornerPosRatio.x));
				num2 = ((!(num2 < oriCornerPosRatio.y)) ? ((!(num2 > 1f - oriCornerPosRatio.y)) ? Mathf.Lerp(cornerPosRatio.y, 1f - cornerPosRatio.y, (num2 - oriCornerPosRatio.y) / (1f - oriCornerPosRatio.y * 2f)) : Mathf.Lerp(1f - cornerPosRatio.y, 1f, (num2 - (1f - oriCornerPosRatio.y)) / oriCornerPosRatio.y)) : Mathf.Lerp(0f, cornerPosRatio.y, num2 / oriCornerPosRatio.y));
				value.position.x = num * NIKILPJFCBI.rect.width - NIKILPJFCBI.rect.width * NIKILPJFCBI.pivot.x;
				value.position.y = num2 * NIKILPJFCBI.rect.height - NIKILPJFCBI.rect.height * NIKILPJFCBI.pivot.y;
				MKGCMGECOLD[i] = value;
			}
		}
		base.CIAPLCOBLCO(MKGCMGECOLD);
	}
}
