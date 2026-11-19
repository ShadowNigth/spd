using UnityEngine;
using UnityEngine.UI;

public static class EJONJMEGEKJ
{
	public static Vector3 FHNGLMOJDIN(Vector3 LBEIKBOPGPK, RectTransform IJGPCIOAFMP)
	{
		LBEIKBOPGPK = new Vector2(LBEIKBOPGPK.x * IJGPCIOAFMP.sizeDelta.x - IJGPCIOAFMP.sizeDelta.x * 0.5f, LBEIKBOPGPK.y * IJGPCIOAFMP.sizeDelta.y - IJGPCIOAFMP.sizeDelta.y * 0.5f);
		return LBEIKBOPGPK;
	}

	public static Vector3 HCADDIDOAID(Vector3 LBEIKBOPGPK, Image FHALEDFDGMJ)
	{
		LBEIKBOPGPK = new Vector2(LBEIKBOPGPK.x * FHALEDFDGMJ.GetPixelAdjustedRect().x - FHALEDFDGMJ.GetPixelAdjustedRect().x * 0.5f, LBEIKBOPGPK.y * FHALEDFDGMJ.GetPixelAdjustedRect().y - FHALEDFDGMJ.GetPixelAdjustedRect().y * 0.5f);
		return LBEIKBOPGPK;
	}

	public static HFEIGOBNJHD HJBIHDIGPKG(int JFLBOOBFAEF = 0)
	{
		HFEIGOBNJHD[] array = Object.FindObjectsOfType<HFEIGOBNJHD>();
		return array[JFLBOOBFAEF];
	}
}
