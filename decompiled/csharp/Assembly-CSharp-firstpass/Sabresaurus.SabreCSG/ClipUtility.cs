using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public static class ClipUtility
{
	public static void InsertEdgeLoop(PrimitiveBrush brush, Plane localPlane)
	{
		if (!PolygonFactory.SplitPolygonsByPlane(new List<Polygon>(brush.GetPolygons()), localPlane, excludeNewPolygons: true, out var polygonsFront, out var polygonsBack))
		{
			return;
		}
		List<Polygon> list = new List<Polygon>();
		list.AddRange(polygonsFront);
		list.AddRange(polygonsBack);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].ExcludeFromFinal)
			{
				list.RemoveAt(i);
				i--;
			}
		}
		brush.SetPolygons(list.ToArray());
	}

	public static GameObject ApplyClipPlane(PrimitiveBrush brush, Plane localPlane, bool keepBothSides, bool resetPivots = true)
	{
		List<Polygon> polygons = new List<Polygon>(brush.GetPolygons());
		if (PolygonFactory.SplitPolygonsByPlane(polygons, localPlane, excludeNewPolygons: false, out var polygonsFront, out var polygonsBack))
		{
			brush.SetPolygons(polygonsFront.ToArray());
			GameObject gameObject = null;
			if (keepBothSides)
			{
				gameObject = brush.Duplicate();
				gameObject.GetComponent<PrimitiveBrush>().SetPolygons(polygonsBack.ToArray());
				gameObject.transform.SetSiblingIndex(brush.transform.GetSiblingIndex());
				if (resetPivots)
				{
					gameObject.GetComponent<PrimitiveBrush>().ResetPivot();
				}
			}
			if (resetPivots)
			{
				brush.ResetPivot();
			}
			return gameObject;
		}
		return null;
	}
}
