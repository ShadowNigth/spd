using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Raycast Mask")]
[RequireComponent(typeof(Image))]
[RequireComponent(typeof(RectTransform))]
public class KBMDGPLAPIP : MonoBehaviour, ICanvasRaycastFilter
{
	private Image MCLIMJDIACE;

	private Sprite DMNOHIOHNBN;

	private void Start()
	{
		MCLIMJDIACE = GetComponent<Image>();
	}

	public bool IsRaycastLocationValid(Vector2 ENKIAJDNMHN, Camera FECAPMFFGFI)
	{
		DMNOHIOHNBN = MCLIMJDIACE.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 localPoint;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, ENKIAJDNMHN, FECAPMFFGFI, out localPoint);
		Vector2 vector = new Vector2(localPoint.x + rectTransform.pivot.x * rectTransform.rect.width, localPoint.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = DMNOHIOHNBN.textureRect;
		Rect rect = rectTransform.rect;
		int num = 0;
		int num2 = 0;
		switch (MCLIMJDIACE.type)
		{
		case Image.Type.Sliced:
		{
			Vector4 border = DMNOHIOHNBN.border;
			num = ((vector.x < border.x) ? Mathf.FloorToInt(textureRect.x + vector.x) : ((!(vector.x > rect.width - border.z)) ? Mathf.FloorToInt(textureRect.x + border.x + (vector.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z)) : Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector.x))));
			num2 = ((!(vector.y < border.y)) ? ((!(vector.y > rect.height - border.w)) ? Mathf.FloorToInt(textureRect.y + border.y + (vector.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w)) : Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector.y))) : Mathf.FloorToInt(textureRect.y + vector.y));
			break;
		}
		default:
			num = Mathf.FloorToInt(textureRect.x + textureRect.width * vector.x / rect.width);
			num2 = Mathf.FloorToInt(textureRect.y + textureRect.height * vector.y / rect.height);
			break;
		}
		try
		{
			return DMNOHIOHNBN.texture.GetPixel(num, num2).a > 0f;
		}
		catch (UnityException)
		{
			Debug.LogWarning("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'");
			Object.Destroy(this);
			return false;
		}
	}
}
