using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
[AddComponentMenu("UI/Effects/Extensions/UIScreenEffect")]
public class MFPLANBFJJM : MonoBehaviour
{
	private MaskableGraphic BPFHILFOAJK;

	private void Start()
	{
		IDKFHLACDIF();
	}

	public void IDKFHLACDIF()
	{
		BPFHILFOAJK = GetComponent<MaskableGraphic>();
		if (BPFHILFOAJK != null)
		{
			if (BPFHILFOAJK.material == null || BPFHILFOAJK.material.name == "Default UI Material")
			{
				BPFHILFOAJK.material = new Material(Shader.Find("UI Extensions/UIScreen"));
			}
		}
		else
		{
			Debug.LogError("Please attach component to a Graphical UI component");
		}
	}

	public void OnValidate()
	{
		IDKFHLACDIF();
	}
}
