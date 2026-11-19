using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
[AddComponentMenu("UI/Effects/Extensions/UIImageCrop")]
public class ICKJGEKMKKK : MonoBehaviour
{
	private MaskableGraphic BPFHILFOAJK;

	private Material GCKMPEGMGJO;

	private int POPOLOICBIJ;

	private int IAOIBIECEAG;

	public float HDFGLIGNBBN;

	public float GNMOCBKADLK;

	private void Start()
	{
		IDKFHLACDIF();
	}

	public void IDKFHLACDIF()
	{
		BPFHILFOAJK = GetComponent<MaskableGraphic>();
		POPOLOICBIJ = Shader.PropertyToID("_XCrop");
		IAOIBIECEAG = Shader.PropertyToID("_YCrop");
		if (BPFHILFOAJK != null)
		{
			if (BPFHILFOAJK.material == null || BPFHILFOAJK.material.name == "Default UI Material")
			{
				BPFHILFOAJK.material = new Material(Shader.Find("UI Extensions/UI Image Crop"));
			}
			GCKMPEGMGJO = BPFHILFOAJK.material;
		}
		else
		{
			Debug.LogError("Please attach component to a Graphical UI component");
		}
	}

	public void OnValidate()
	{
		IDKFHLACDIF();
		NLENBMDAAMF(HDFGLIGNBBN);
		PMPNHCEAKCM(GNMOCBKADLK);
	}

	public void NLENBMDAAMF(float DNGJAMLPBPI)
	{
		HDFGLIGNBBN = Mathf.Clamp01(DNGJAMLPBPI);
		GCKMPEGMGJO.SetFloat(POPOLOICBIJ, HDFGLIGNBBN);
	}

	public void PMPNHCEAKCM(float JHHLILBGNDH)
	{
		GNMOCBKADLK = Mathf.Clamp01(JHHLILBGNDH);
		GCKMPEGMGJO.SetFloat(IAOIBIECEAG, GNMOCBKADLK);
	}
}
