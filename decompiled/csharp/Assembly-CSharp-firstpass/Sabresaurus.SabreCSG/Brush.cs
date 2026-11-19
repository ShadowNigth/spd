using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public abstract class Brush : BrushBase
{
	public class BrushOrderComparer : IComparer<Brush>
	{
		public int Compare(Brush x, Brush y)
		{
			return x.GetBrushOrder().CompareTo(y.GetBrushOrder());
		}
	}

	protected bool isBrushConvex = true;

	[SerializeField]
	protected BrushCache brushCache;

	public bool IsBrushConvex => isBrushConvex;

	public BrushCache BrushCache => brushCache;

	public abstract Polygon[] GenerateTransformedPolygons();

	public abstract void RecalculateBrushCache();

	public abstract void RecachePolygons(bool markUnbuilt);

	public abstract void RecalculateIntersections();

	public abstract void RecalculateIntersections(List<Brush> brushes, bool isRootChange);

	public abstract int AssignUniqueIDs(int startingIndex);

	public abstract int[] GetPolygonIDs();

	public abstract Polygon[] GetPolygons();

	public abstract void PrepareToBuild(List<Brush> brushes, bool forceRebuild);

	protected static List<Brush> CalculateIntersectingBrushes(Brush sourceBrush, List<Brush> brushes, bool isCollisionPass)
	{
		if (sourceBrush.IsNoCSG || sourceBrush.Mode == CSGMode.Volume)
		{
			return new List<Brush>();
		}
		if (isCollisionPass)
		{
			if (!sourceBrush.hasCollision)
			{
				return new List<Brush>();
			}
		}
		else if (!sourceBrush.isVisible)
		{
			return new List<Brush>();
		}
		BrushCache brushCache = sourceBrush.BrushCache;
		List<Brush> list = new List<Brush>();
		Bounds bounds = brushCache.Bounds;
		Polygon[] polygons = brushCache.Polygons;
		int num = -1;
		for (int i = 0; i < brushes.Count; i++)
		{
			if (brushes[i] != null)
			{
				BrushCache brushCache2 = brushes[i].BrushCache;
				if (brushCache2 == brushCache)
				{
					num = i;
					break;
				}
			}
		}
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			if (!IsInvalidForBuild(brushes[num2]) && !brushes[num2].isNoCSG && brushes[num2].mode != CSGMode.Volume && (!isCollisionPass || brushes[num2].HasCollision) && (isCollisionPass || brushes[num2].IsVisible))
			{
				BrushCache brushCache3 = brushes[num2].BrushCache;
				if (brushCache3.Bounds.IntersectsApproximate(bounds) && GeometryHelper.PolyhedraIntersect(brushCache3.Polygons, polygons))
				{
					list.Add(brushes[num2]);
					if (brushCache3.Mode == CSGMode.Subtract && GeometryHelper.PolyhedronContainsPolyhedron(brushCache3.Polygons, polygons))
					{
						break;
					}
				}
			}
		}
		list.Reverse();
		List<BrushCache> list2 = new List<BrushCache>();
		for (int j = num + 1; j < brushes.Count; j++)
		{
			if (IsInvalidForBuild(brushes[j]) || brushes[j].isNoCSG || brushes[j].mode == CSGMode.Volume || (isCollisionPass && !brushes[j].HasCollision) || (!isCollisionPass && !brushes[j].IsVisible))
			{
				continue;
			}
			BrushCache brushCache4 = brushes[j].BrushCache;
			if (!brushCache4.Bounds.IntersectsApproximate(bounds) || !GeometryHelper.PolyhedraIntersect(brushCache4.Polygons, polygons))
			{
				continue;
			}
			bool flag = false;
			for (int k = 0; k < list2.Count; k++)
			{
				BrushCache brushCache5 = list2[k];
				if (brushCache5.Bounds.IntersectsApproximate(brushCache4.Bounds) && GeometryHelper.PolyhedronContainsPolyhedron(brushCache5.Polygons, brushCache4.Polygons))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(brushes[j]);
				if (brushCache4.Mode == CSGMode.Subtract)
				{
					list2.Add(brushCache4);
				}
			}
		}
		return list;
	}

	public static bool IsInvalidForBuild(Brush brush)
	{
		if (brush == null || brush.Destroyed || !brush.gameObject.activeInHierarchy)
		{
			return true;
		}
		return false;
	}

	public abstract BrushOrder GetBrushOrder();

	public abstract void UpdateCachedBrushOrder();
}
