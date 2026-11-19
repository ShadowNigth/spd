using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Screen Space Motion Blur")]
[RequireComponent(typeof(Camera))]
public class ScreenSpaceMotionBlur : MonoBehaviour
{
	public float Strength = 200f;

	public Shader compositeShader;

	private Material compositeMaterial;

	private Material GetCompositeMaterial()
	{
		if (compositeMaterial == null)
		{
			compositeMaterial = new Material(compositeShader);
			compositeMaterial.hideFlags = HideFlags.HideAndDontSave;
		}
		return compositeMaterial;
	}

	private void OnDisable()
	{
		Object.DestroyImmediate(compositeMaterial);
	}

	private void OnPreCull()
	{
		Shader.SetGlobalMatrix("_Myview", (GetComponent<Camera>().worldToCameraMatrix.inverse * GetComponent<Camera>().projectionMatrix).inverse);
	}

	private void OnRenderImage(RenderTexture source, RenderTexture dest)
	{
		Material material = GetCompositeMaterial();
		material.SetFloat("_Strength", Strength);
		Graphics.Blit(source, dest, material);
	}

	private void OnPostRender()
	{
		StartCoroutine(renderlate());
	}

	private IEnumerator renderlate()
	{
		yield return new WaitForEndOfFrame();
		Matrix4x4 Iviewprev = GetComponent<Camera>().worldToCameraMatrix.inverse * GetComponent<Camera>().projectionMatrix;
		Shader.SetGlobalMatrix("_Myviewprev", Iviewprev);
	}
}
