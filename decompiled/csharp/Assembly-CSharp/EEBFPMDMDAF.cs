using UnityEngine;

[RequireComponent(typeof(Camera))]
public class EEBFPMDMDAF : MonoBehaviour
{
	private void Start()
	{
		PJCKFCICIJF();
	}

	private void PJCKFCICIJF()
	{
		if (GetComponent<Camera>().depthTextureMode == DepthTextureMode.None)
		{
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
		}
	}
}
