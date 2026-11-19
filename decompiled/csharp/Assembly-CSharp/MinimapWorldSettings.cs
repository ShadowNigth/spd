using UnityEngine;

public class MinimapWorldSettings : MonoBehaviour
{
	[Header("Use UI editor Tool for scale the wordSpace")]
	public Color GizmoColor = new Color(1f, 1f, 1f, 0.75f);

	[Header("Texture Minimap")]
	public Texture MinimapTexture;

	public RectTransform Rect;
}
