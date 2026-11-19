using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/UILinearDodgeEffect")]
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
public class NMCKMDLEODM : MonoBehaviour
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
				BPFHILFOAJK.material = new Material(Shader.Find("UI Extensions/UILinearDodge"));
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
