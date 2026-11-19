using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sabresaurus.SabreCSG
{
	[Serializable]
	public class BrushCache
	{
		[SerializeField]
		private CSGMode mode;

		[SerializeField]
		private Polygon[] polygons;

		[SerializeField]
		private SerializablePlane[] splitPlanes;

		[SerializeField]
		private Bounds bounds;

		[SerializeField]
		private bool built;

		[SerializeField]
		[FormerlySerializedAs("intersectingBrushes")]
		private List<Brush> intersectingVisualBrushes = new List<Brush>();

		[NonSerialized]
		private List<BrushCache> intersectingVisualBrushCaches;

		[SerializeField]
		private List<Brush> intersectingCollisionBrushes = new List<Brush>();

		[NonSerialized]
		private List<BrushCache> intersectingCollisionBrushCaches;

		[SerializeField]
		[FormerlySerializedAs("builtPolygons")]
		internal List<Polygon> builtVisualPolygons = new List<Polygon>();

		[SerializeField]
		internal List<Polygon> builtCollisionPolygons = new List<Polygon>();

		[SerializeField]
		private bool collisionVisualEqual;

		internal List<KeyValuePair<Polygon, BrushCache>> stolenVisualPolygons = new List<KeyValuePair<Polygon, BrushCache>>();

		internal List<KeyValuePair<Polygon, BrushCache>> stolenCollisionPolygons = new List<KeyValuePair<Polygon, BrushCache>>();

		public CSGMode Mode
		{
			get
			{
				return mode;
			}
		}

		public bool Built
		{
			get
			{
				return built;
			}
		}

		public Polygon[] Polygons
		{
			get
			{
				return polygons;
			}
		}

		public Plane[] SplitPlanes
		{
			get
			{
				Plane[] array = new Plane[splitPlanes.Length];
				for (int i = 0; i < splitPlanes.Length; i++)
				{
					array[i] = splitPlanes[i].UnityPlane;
				}
				return array;
			}
		}

		public Bounds Bounds
		{
			get
			{
				return bounds;
			}
		}

		public List<Brush> IntersectingVisualBrushes
		{
			get
			{
				return intersectingVisualBrushes;
			}
		}

		public List<BrushCache> IntersectingVisualBrushCaches
		{
			get
			{
				if (intersectingVisualBrushCaches == null)
				{
					intersectingVisualBrushCaches = new List<BrushCache>(intersectingVisualBrushes.Count);
					for (int i = 0; i < intersectingVisualBrushes.Count; i++)
					{
						if (intersectingVisualBrushes[i] != null)
						{
							intersectingVisualBrushCaches.Add(intersectingVisualBrushes[i].BrushCache);
						}
						else
						{
							intersectingVisualBrushCaches.Add(null);
						}
					}
				}
				return intersectingVisualBrushCaches;
			}
		}

		public List<Brush> IntersectingCollisionBrushes
		{
			get
			{
				return intersectingCollisionBrushes;
			}
		}

		public List<BrushCache> IntersectingCollisionBrushCaches
		{
			get
			{
				if (intersectingCollisionBrushCaches == null)
				{
					intersectingCollisionBrushCaches = new List<BrushCache>(intersectingCollisionBrushes.Count);
					for (int i = 0; i < intersectingCollisionBrushes.Count; i++)
					{
						if (intersectingCollisionBrushes[i] != null)
						{
							intersectingCollisionBrushCaches.Add(intersectingCollisionBrushes[i].BrushCache);
						}
						else
						{
							intersectingCollisionBrushCaches.Add(null);
						}
					}
				}
				return intersectingCollisionBrushCaches;
			}
		}

		public List<Polygon> BuiltVisualPolygons
		{
			get
			{
				return builtVisualPolygons;
			}
		}

		public List<Polygon> BuiltCollisionPolygons
		{
			get
			{
				return builtCollisionPolygons;
			}
		}

		public bool CollisionVisualEqual
		{
			get
			{
				return collisionVisualEqual;
			}
		}

		public Dictionary<int, List<Polygon>> GetGroupedBuiltVisualPolygons()
		{
			Dictionary<int, List<Polygon>> dictionary = new Dictionary<int, List<Polygon>>();
			int uniqueIndex = polygons[0].UniqueIndex;
			int num = uniqueIndex + polygons.Length - 1;
			for (int i = 0; i < builtVisualPolygons.Count; i++)
			{
				Polygon polygon = builtVisualPolygons[i];
				if (polygon.UniqueIndex >= uniqueIndex && polygon.UniqueIndex <= num)
				{
					if (!dictionary.ContainsKey(polygon.UniqueIndex))
					{
						dictionary.Add(polygon.UniqueIndex, new List<Polygon> { polygon });
					}
					else
					{
						dictionary[polygon.UniqueIndex].Add(polygon);
					}
				}
			}
			return dictionary;
		}

		public Dictionary<int, List<Polygon>> GetGroupedBuiltCollisionPolygons()
		{
			Dictionary<int, List<Polygon>> dictionary = new Dictionary<int, List<Polygon>>();
			int uniqueIndex = polygons[0].UniqueIndex;
			int num = uniqueIndex + polygons.Length - 1;
			for (int i = 0; i < builtCollisionPolygons.Count; i++)
			{
				Polygon polygon = builtCollisionPolygons[i];
				int uniqueIndex2 = polygon.UniqueIndex;
				if (uniqueIndex2 >= uniqueIndex && uniqueIndex2 <= num)
				{
					if (!dictionary.ContainsKey(uniqueIndex2))
					{
						dictionary.Add(uniqueIndex2, new List<Polygon> { polygon });
					}
					else
					{
						dictionary[uniqueIndex2].Add(polygon);
					}
				}
			}
			return dictionary;
		}

		public void Set(CSGMode mode, Polygon[] polygons, Bounds bounds, bool markUnbuilt)
		{
			this.mode = mode;
			this.polygons = polygons;
			this.bounds = bounds;
			List<List<Polygon>> list = new List<List<Polygon>>();
			foreach (Polygon polygon in polygons)
			{
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					Polygon polygon2 = list[j][0];
					if (MathHelper.PlaneEqualsLooser(polygon2.Plane, polygon.Plane))
					{
						list[j].Add(polygon);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(new List<Polygon> { polygon });
				}
			}
			splitPlanes = new SerializablePlane[polygons.Length];
			int num = 0;
			for (int k = 0; k < list.Count; k++)
			{
				splitPlanes[num] = new SerializablePlane(list[k][0].Plane);
				num++;
				for (int l = 1; l < list[k].Count; l++)
				{
					for (int m = 0; m < list[k].Count; m++)
					{
						Plane plane;
						if (l == m || !PlaneBetweenPolygons(list[k][l], list[k][m], out plane))
						{
							continue;
						}
						bool flag2 = false;
						for (int n = 0; n < num; n++)
						{
							if (MathHelper.PlaneEqualsLooserWithFlip(plane, splitPlanes[n].UnityPlane))
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							splitPlanes[num] = new SerializablePlane(plane);
							num++;
							break;
						}
					}
				}
			}
			if (markUnbuilt)
			{
				built = false;
			}
		}

		private static bool PlaneBetweenPolygons(Polygon polygon1, Polygon polygon2, out Plane plane)
		{
			for (int i = 0; i < polygon1.Vertices.Length; i++)
			{
				Vertex vertex = polygon1.Vertices[i];
				Vertex vertex2 = polygon1.Vertices[(i + 1) % polygon1.Vertices.Length];
				for (int j = 0; j < polygon2.Vertices.Length; j++)
				{
					Vertex vertex3 = polygon2.Vertices[j];
					Vertex vertex4 = polygon2.Vertices[(j + 1) % polygon2.Vertices.Length];
					if ((vertex.Position.EqualsWithEpsilon(vertex3.Position) && vertex2.Position.EqualsWithEpsilon(vertex4.Position)) || (vertex.Position.EqualsWithEpsilon(vertex4.Position) && vertex2.Position.EqualsWithEpsilon(vertex3.Position)))
					{
						Vector3 c = vertex.Position + polygon1.Plane.normal;
						plane = new Plane(vertex.Position, vertex2.Position, c);
						return true;
					}
				}
			}
			plane = default(Plane);
			return false;
		}

		public void SetIntersection(List<Brush> intersectingVisualBrushes, List<Brush> intersectingCollisonBrushes)
		{
			this.intersectingVisualBrushes = intersectingVisualBrushes;
			intersectingVisualBrushCaches = new List<BrushCache>(intersectingVisualBrushes.Count);
			for (int i = 0; i < intersectingVisualBrushes.Count; i++)
			{
				intersectingVisualBrushCaches.Add(intersectingVisualBrushes[i].BrushCache);
			}
			intersectingCollisionBrushes = intersectingCollisonBrushes;
			if (intersectingCollisonBrushes.ContentsEquals(intersectingVisualBrushes))
			{
				collisionVisualEqual = true;
				intersectingCollisionBrushCaches = new List<BrushCache>(intersectingVisualBrushCaches);
				return;
			}
			collisionVisualEqual = false;
			intersectingCollisionBrushCaches = new List<BrushCache>(intersectingCollisionBrushes.Count);
			for (int j = 0; j < intersectingCollisionBrushes.Count; j++)
			{
				intersectingCollisionBrushCaches.Add(intersectingCollisionBrushes[j].BrushCache);
			}
		}

		public int AssignUniqueIDs(int startingIndex, bool isVisible, PolygonEntry[] oldVisualPolygonIndex, PolygonEntry[] newVisualPolygonIndex, bool hasCollision, PolygonEntry[] oldCollisionPolygonIndex, PolygonEntry[] newCollisionPolygonIndex)
		{
			int num = 0;
			for (int i = 0; i < polygons.Length; i++)
			{
				int uniqueIndex = polygons[i].UniqueIndex;
				int num2 = startingIndex + i;
				polygons[i].UniqueIndex = num2;
				if (built || mode == CSGMode.Add)
				{
					if (isVisible && uniqueIndex != -1 && oldVisualPolygonIndex.Length > uniqueIndex)
					{
						PolygonEntry polygonEntry = oldVisualPolygonIndex[uniqueIndex];
						newVisualPolygonIndex[num2] = polygonEntry;
					}
					if (hasCollision && uniqueIndex != -1 && oldCollisionPolygonIndex.Length > uniqueIndex)
					{
						PolygonEntry polygonEntry2 = oldCollisionPolygonIndex[uniqueIndex];
						newCollisionPolygonIndex[num2] = polygonEntry2;
					}
				}
			}
			return polygons.Length;
		}

		public void ResetForBuild(PolygonEntry[] newVisualPolygonIndex, PolygonEntry[] newCollisionPolygonIndex)
		{
			builtVisualPolygons.Clear();
			builtCollisionPolygons.Clear();
			for (int i = 0; i < polygons.Length; i++)
			{
				int uniqueIndex = polygons[i].UniqueIndex;
				newVisualPolygonIndex[uniqueIndex] = null;
				newCollisionPolygonIndex[uniqueIndex] = null;
			}
		}

		public void SetUnbuilt()
		{
			built = false;
		}

		public void SetBuilt()
		{
			built = true;
		}

		public void SetVisualBuiltPolygons(List<Polygon> builtVisualPolygons)
		{
			this.builtVisualPolygons = builtVisualPolygons;
		}

		public void SetCollisionBuiltPolygons(List<Polygon> builtCollisionPolygons)
		{
			this.builtCollisionPolygons = builtCollisionPolygons;
		}

		internal static void NotifyOfStolenVisualPolygon(BrushCache mainCache, BrushCache brushCacheSource, Polygon newPolygon)
		{
			mainCache.stolenVisualPolygons.Add(new KeyValuePair<Polygon, BrushCache>(newPolygon, brushCacheSource));
		}

		internal static void NotifyOfStolenCollisionPolygon(BrushCache mainCache, BrushCache brushCacheSource, Polygon newPolygon)
		{
			mainCache.stolenCollisionPolygons.Add(new KeyValuePair<Polygon, BrushCache>(newPolygon, brushCacheSource));
		}

		internal static void ReclaimStolenVisualPolygons(BrushCache mainCache)
		{
			List<KeyValuePair<Polygon, BrushCache>> list = mainCache.stolenVisualPolygons;
			int num;
			for (num = 0; num < list.Count; num++)
			{
				if (list[num].Value.builtVisualPolygons.Remove(list[num].Key))
				{
					mainCache.builtVisualPolygons.Add(list[num].Key);
				}
				list.RemoveAt(num);
				num--;
			}
		}

		internal static void ReclaimStolenCollisionPolygons(BrushCache mainCache)
		{
			List<KeyValuePair<Polygon, BrushCache>> list = mainCache.stolenCollisionPolygons;
			int num;
			for (num = 0; num < list.Count; num++)
			{
				if (list[num].Value.builtCollisionPolygons.Remove(list[num].Key))
				{
					mainCache.builtCollisionPolygons.Add(list[num].Key);
				}
				list.RemoveAt(num);
				num--;
			}
		}

		internal static Dictionary<int, List<Polygon>> OptimizeVisual(BrushCache mainCache)
		{
			Dictionary<int, List<Polygon>> groupedBuiltVisualPolygons = mainCache.GetGroupedBuiltVisualPolygons();
			List<Polygon> list = new List<Polygon>();
			foreach (KeyValuePair<int, List<Polygon>> item in groupedBuiltVisualPolygons)
			{
				List<Polygon> list2 = Optimizer.CalculateConvexHulls(item.Value);
				if (list2 != item.Value)
				{
					item.Value.Clear();
					item.Value.AddRange(list2);
				}
				list.AddRange(list2);
			}
			mainCache.SetVisualBuiltPolygons(list);
			return groupedBuiltVisualPolygons;
		}

		internal static Dictionary<int, List<Polygon>> OptimizeCollision(BrushCache mainCache)
		{
			Dictionary<int, List<Polygon>> groupedBuiltCollisionPolygons = mainCache.GetGroupedBuiltCollisionPolygons();
			List<Polygon> list = new List<Polygon>();
			foreach (KeyValuePair<int, List<Polygon>> item in groupedBuiltCollisionPolygons)
			{
				List<Polygon> list2 = Optimizer.CalculateConvexHulls(item.Value);
				if (list2 != item.Value)
				{
					item.Value.Clear();
					item.Value.AddRange(list2);
				}
				list.AddRange(list2);
			}
			mainCache.SetVisualBuiltPolygons(list);
			return groupedBuiltCollisionPolygons;
		}
	}
}
