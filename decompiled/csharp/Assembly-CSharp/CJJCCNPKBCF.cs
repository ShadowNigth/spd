using UnityEngine;
using UnityEngine.UI;

public class CJJCCNPKBCF : MonoBehaviour
{
	[Header("Mask")]
	public Sprite POAEKCNLLFP;

	public Sprite GNCKFMFJJKL;

	[SerializeField]
	[Header("References")]
	private Image Background;

	[SerializeField]
	private Sprite MiniMapBackGround;

	[SerializeField]
	private Sprite WorldMapBackGround;

	[SerializeField]
	private RectTransform MaskIconRoot;

	private Image MCLIMJDIACE;

	private Image DAPHIBGDIOM
	{
		get
		{
			if (MCLIMJDIACE == null)
			{
				MCLIMJDIACE = GetComponent<Image>();
			}
			return MCLIMJDIACE;
		}
	}

	private void Start()
	{
		DAPHIBGDIOM.sprite = POAEKCNLLFP;
	}

	public void DAOGCALLKAH(bool CPHFFMMFGOG = false)
	{
		if (CPHFFMMFGOG)
		{
			DAPHIBGDIOM.sprite = GNCKFMFJJKL;
			if (Background != null)
			{
				Background.sprite = WorldMapBackGround;
			}
		}
		else
		{
			DAPHIBGDIOM.sprite = POAEKCNLLFP;
			if (Background != null)
			{
				Background.sprite = MiniMapBackGround;
			}
		}
	}

	public void OPNDAKJODHA(RectTransform EHEBGBAFKPH)
	{
		EHEBGBAFKPH.SetParent(MaskIconRoot);
	}
}
