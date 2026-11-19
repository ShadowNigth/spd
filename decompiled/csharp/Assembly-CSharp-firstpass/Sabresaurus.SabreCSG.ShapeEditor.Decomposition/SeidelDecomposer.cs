using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG.ShapeEditor.Decomposition;

public static class SeidelDecomposer
{
	public static List<Vector2[]> ConvexPartition(Vector2[] vertices, float sheer)
	{
		List<Point> list = new List<Point>(vertices.Length);
		for (int i = 0; i < vertices.Length; i++)
		{
			Vector2 vector = vertices[i];
			list.Add(new Point(vector.x, vector.y));
		}
		Triangulator triangulator = new Triangulator(list, sheer);
		List<Vector2[]> list2 = new List<Vector2[]>();
		foreach (List<Point> triangle in triangulator.Triangles)
		{
			List<Vector2> list3 = new List<Vector2>(triangle.Count);
			foreach (Point item in triangle)
			{
				list3.Add(new Vector2(item.X, item.Y));
			}
			list2.Add(list3.ToArray());
		}
		return list2;
	}

	public static List<Vector2[]> ConvexPartitionTrapezoid(Vector2[] vertices, float sheer)
	{
		List<Point> list = new List<Point>(vertices.Length);
		for (int i = 0; i < vertices.Length; i++)
		{
			Vector2 vector = vertices[i];
			list.Add(new Point(vector.x, vector.y));
		}
		Triangulator triangulator = new Triangulator(list, sheer);
		List<Vector2[]> list2 = new List<Vector2[]>();
		foreach (Trapezoid trapezoid in triangulator.Trapezoids)
		{
			List<Vector2> list3 = new List<Vector2>();
			List<Point> list4 = trapezoid.Vertices();
			foreach (Point item in list4)
			{
				list3.Add(new Vector2(item.X, item.Y));
			}
			list2.Add(list3.ToArray());
		}
		return list2;
	}
}
