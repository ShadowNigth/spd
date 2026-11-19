using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

internal class BrushChunk
{
	private Vector3 centerPoint;

	private Bounds bounds;

	private List<Polygon> polygons;

	private List<Polygon> polyhedronPolygons;

	private List<Plane> splitPlanes = new List<Plane>();

	private static int NEXT_ID;

	private int uniqueID;

	internal List<Polygon> Polygons => polygons;

	internal List<Polygon> PolyhedronPolygons => polyhedronPolygons;

	internal List<Plane> SplitPlanes => splitPlanes;

	internal int UniqueID => uniqueID;

	internal BrushChunk(List<Polygon> polygons, List<Plane> splitPlanes = null)
	{
		uniqueID = NEXT_ID;
		NEXT_ID++;
		this.polygons = polygons;
		polyhedronPolygons = new List<Polygon>(polygons);
		if (splitPlanes != null)
		{
			this.splitPlanes = splitPlanes;
		}
		else
		{
			this.splitPlanes = new List<Plane>();
		}
		int num = 1;
		centerPoint = polygons[0].Vertices[0].Position;
		for (int i = 0; i < polygons.Count; i++)
		{
			for (int j = 0; j < polygons[i].Vertices.Length; j++)
			{
				if (i != 0 || j != 0)
				{
					centerPoint += polygons[i].Vertices[j].Position;
					num++;
				}
			}
		}
		centerPoint *= 1f / (float)num;
		CalculateBounds();
	}

	internal static void ResetNextID()
	{
		NEXT_ID = 0;
	}

	private void CalculateBounds()
	{
		if (polygons.Count > 0)
		{
			bounds = new Bounds(polygons[0].Vertices[0].Position, Vector3.zero);
			for (int i = 0; i < polygons.Count; i++)
			{
				for (int j = 0; j < polygons[i].Vertices.Length; j++)
				{
					bounds.Encapsulate(polygons[i].Vertices[j].Position);
				}
			}
		}
		else
		{
			bounds = new Bounds(Vector3.zero, Vector3.zero);
		}
	}

	private void ProvideSplitPlane(Plane splitPlane)
	{
		splitPlanes.Add(splitPlane);
	}

	internal Bounds GetBounds()
	{
		return bounds;
	}

	internal List<Polygon> ProvideSubtractChunks(List<BrushChunk> subtractChunks)
	{
		List<Polygon> list = new List<Polygon>();
		List<Polygon> list2 = new List<Polygon>();
		int count = subtractChunks.Count;
		for (int i = 0; i < count; i++)
		{
			int count2 = subtractChunks[i].Polygons.Count;
			for (int j = 0; j < count2; j++)
			{
				Polygon polygon = subtractChunks[i].Polygons[j];
				if (polygon.ExcludeFromFinal)
				{
					continue;
				}
				Plane plane = polygon.Plane;
				bool flag = false;
				int count3 = polygons.Count;
				for (int k = 0; k < count3; k++)
				{
					if (polygons[k].ExcludeFromFinal)
					{
						Plane plane2 = polygons[k].Plane;
						if (MathHelper.PlaneEqualsLooserWithFlip(plane, plane2))
						{
							flag = true;
							break;
						}
					}
				}
				bool flag2 = false;
				if (flag)
				{
					Vector3 point = polygon.GetCenterPoint();
					if (GeometryHelper.PolyhedronContainsPointEpsilon3(polygons, point))
					{
						flag2 = true;
						polygon = polygon.DeepCopy();
						polygon.Flip();
						for (int l = 0; l < polygons.Count; l++)
						{
							if (!polygons[l].ExcludeFromFinal && MathHelper.PlaneEqualsLooser(polygons[l].Plane, polygon.Plane) && !list2.Contains(polygons[l]))
							{
								polygons[l].ExcludeFromFinal = true;
							}
						}
						polygons.Add(polygon);
						list2.Add(polygon);
					}
				}
				if (!flag2)
				{
					list.Add(polygon);
				}
			}
		}
		return list;
	}

	internal Vector3 GetCenterPoint()
	{
		return centerPoint;
	}

	internal bool SplitByPlane(Plane splitPlane, out BrushChunk chunkFront, out BrushChunk chunkBack)
	{
		if (PolygonFactory.SplitPolygonsByPlane(polygons, splitPlane, excludeNewPolygons: true, out var polygonsFront, out var polygonsBack))
		{
			if (polygonsFront.Count > 0)
			{
				chunkFront = new BrushChunk(polygonsFront, splitPlanes);
				if (polygonsBack.Count > 0)
				{
					chunkBack = new BrushChunk(polygonsBack, splitPlanes);
					return true;
				}
				Debug.LogError("SplitPolygonsByPlane said it succeeded but returned an empty list");
				chunkFront = null;
				chunkBack = null;
				return false;
			}
			Debug.LogError("SplitPolygonsByPlane said it succeeded but returned an empty list");
			chunkFront = null;
			chunkBack = null;
			return false;
		}
		chunkFront = null;
		chunkBack = null;
		return false;
	}

	internal static List<BrushChunk> SplitChunk(Polygon[] brushToSplit, Polygon[][] brushSplitters)
	{
		List<BrushChunk> list = new List<BrushChunk>();
		list.Add(new BrushChunk(new List<Polygon>(brushToSplit)));
		for (int i = 0; i < brushSplitters.Length; i++)
		{
			List<BrushChunk> list2 = new List<BrushChunk>();
			List<BrushChunk> list3 = new List<BrushChunk>();
			list2.AddRange(list);
			Polygon[] array = brushSplitters[i];
			for (int j = 0; j < array.Length; j++)
			{
				Plane plane = array[j].Plane;
				for (int k = 0; k < list2.Count; k++)
				{
					if (list2[k].SplitByPlane(plane, out var chunkFront, out var chunkBack))
					{
						chunkBack.ProvideSplitPlane(plane);
						list2[k] = chunkFront;
						list3.Add(chunkBack);
					}
				}
			}
			list.Clear();
			list.AddRange(list2);
			list.AddRange(list3);
		}
		return list;
	}
}
