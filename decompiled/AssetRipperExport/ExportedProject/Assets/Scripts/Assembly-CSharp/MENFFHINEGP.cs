using UnityEngine;

public static class MENFFHINEGP
{
	public static Vector2 DOICKGNACBI(this RectTransform HPPAAHDIPDE, RectTransform GCLNIFACGLM)
	{
		Vector2 vector = new Vector2(HPPAAHDIPDE.rect.width * HPPAAHDIPDE.pivot.x + HPPAAHDIPDE.rect.xMin, HPPAAHDIPDE.rect.height * HPPAAHDIPDE.pivot.y + HPPAAHDIPDE.rect.yMin);
		Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(null, HPPAAHDIPDE.position);
		screenPoint += vector;
		Vector2 localPoint;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(GCLNIFACGLM, screenPoint, null, out localPoint);
		Vector2 vector2 = new Vector2(GCLNIFACGLM.rect.width * GCLNIFACGLM.pivot.x + GCLNIFACGLM.rect.xMin, GCLNIFACGLM.rect.height * GCLNIFACGLM.pivot.y + GCLNIFACGLM.rect.yMin);
		return GCLNIFACGLM.anchoredPosition + localPoint - vector2;
	}
}
