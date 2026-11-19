using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/PPIViewer")]
[RequireComponent(typeof(Text))]
public class CPKFMBHFCJG : MonoBehaviour
{
	private Text MGDJNMNHMFM;

	private void Awake()
	{
		MGDJNMNHMFM = GetComponent<Text>();
	}

	private void Start()
	{
		if (MGDJNMNHMFM != null)
		{
			MGDJNMNHMFM.text = "PPI: " + Screen.dpi;
		}
	}
}
