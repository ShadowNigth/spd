using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("UI/Effects/Extensions/SoftMaskScript")]
public class FLEACMFGOMO : MonoBehaviour
{
	private Material GCKMPEGMGJO;

	private Canvas NHHGJBAEGIO;

	private Transform LBPEHGANBNO;

	private readonly Vector3[] AOBAHLCIOLJ = new Vector3[4];

	private readonly Vector3[] DIOCLOHBLED = new Vector3[4];

	[Tooltip("The area that is to be used as the container.")]
	public RectTransform CMANBHMNAMA;

	[Tooltip("Texture to be used to do the soft alpha")]
	public Texture JLNKBDCCHPB;

	[Tooltip("At what point to apply the alpha min range 0-1")]
	[Range(0f, 1f)]
	public float DAAGIBKFPHK;

	[Tooltip("Implement a hard blend based on the Cutoff")]
	public bool BPJDEKNCDDP;

	[Tooltip("Flip the masks alpha value")]
	public bool JEMPHAPFCEG;

	[Tooltip("If a different Mask Scaling Rect is given, and this value is true, the area around the mask will not be clipped")]
	public bool HMKFEFMDGCD;

	private Vector2 PLAIFDDNEFB = Vector2.zero;

	private Vector2 GOIGCBNCIMG = Vector2.one;

	private void Start()
	{
		if (CMANBHMNAMA == null)
		{
			CMANBHMNAMA = GetComponent<RectTransform>();
		}
		Text component = GetComponent<Text>();
		if (component != null)
		{
			GCKMPEGMGJO = new Material(Shader.Find("UI Extensions/SoftMaskShader"));
			component.material = GCKMPEGMGJO;
			NHHGJBAEGIO = component.canvas;
			LBPEHGANBNO = NHHGJBAEGIO.transform;
			if (base.transform.parent.GetComponent<Mask>() == null)
			{
				base.transform.parent.gameObject.AddComponent<Mask>();
			}
			base.transform.parent.GetComponent<Mask>().enabled = false;
		}
		else
		{
			Graphic component2 = GetComponent<Graphic>();
			if (component2 != null)
			{
				GCKMPEGMGJO = new Material(Shader.Find("UI Extensions/SoftMaskShader"));
				component2.material = GCKMPEGMGJO;
				NHHGJBAEGIO = component2.canvas;
				LBPEHGANBNO = NHHGJBAEGIO.transform;
			}
		}
	}

	private void Update()
	{
		if (NHHGJBAEGIO != null)
		{
			KGGIGMMGJGA();
		}
	}

	private void KGGIGMMGJGA()
	{
		Rect rect = CEFFIOCKHPA();
		Vector2 size = rect.size;
		GOIGCBNCIMG.Set(1f / size.x, 1f / size.y);
		PLAIFDDNEFB = -rect.min;
		PLAIFDDNEFB.Scale(GOIGCBNCIMG);
		GCKMPEGMGJO.SetTextureOffset("_AlphaMask", PLAIFDDNEFB);
		GCKMPEGMGJO.SetTextureScale("_AlphaMask", GOIGCBNCIMG);
		GCKMPEGMGJO.SetTexture("_AlphaMask", JLNKBDCCHPB);
		GCKMPEGMGJO.SetFloat("_HardBlend", BPJDEKNCDDP ? 1 : 0);
		GCKMPEGMGJO.SetInt("_FlipAlphaMask", JEMPHAPFCEG ? 1 : 0);
		GCKMPEGMGJO.SetInt("_NoOuterClip", HMKFEFMDGCD ? 1 : 0);
		GCKMPEGMGJO.SetFloat("_CutOff", DAAGIBKFPHK);
	}

	public Rect CEFFIOCKHPA()
	{
		if (NHHGJBAEGIO == null)
		{
			return default(Rect);
		}
		CMANBHMNAMA.GetWorldCorners(AOBAHLCIOLJ);
		for (int i = 0; i < 4; i++)
		{
			ref Vector3 reference = ref DIOCLOHBLED[i];
			reference = LBPEHGANBNO.InverseTransformPoint(AOBAHLCIOLJ[i]);
		}
		return new Rect(DIOCLOHBLED[0].x, DIOCLOHBLED[0].y, DIOCLOHBLED[2].x - DIOCLOHBLED[0].x, DIOCLOHBLED[2].y - DIOCLOHBLED[0].y);
	}
}
