using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	internal static class BrushBuilder
	{
		private static int firstPolygonUID;

		internal static void Build(BrushCache brushCache, int brushIndex, BrushCache[] allBrushCaches, bool isCollisionPass)
		{
			firstPolygonUID = brushCache.Polygons[0].UniqueIndex;
			if (brushCache.Mode == CSGMode.Add)
			{
				int[] array = new int[brushCache.Polygons.Length];
				List<Polygon> list = new List<Polygon>();
				List<BrushCache> list2 = null;
				list2 = ((!isCollisionPass) ? brushCache.IntersectingVisualBrushCaches : brushCache.IntersectingCollisionBrushCaches);
				LinkedList<BrushChunk> linkedList = new LinkedList<BrushChunk>();
				linkedList.AddFirst(new BrushChunk(new List<Polygon>(brushCache.Polygons.DeepCopy())));
				for (int i = 0; i < list2.Count; i++)
				{
					if (list2[i] != null)
					{
						int num = Array.IndexOf(allBrushCaches, list2[i]);
						if (num <= brushIndex)
						{
							SplitBy(linkedList, list2[i]);
						}
						else
						{
							SplitAndRemove(linkedList, list2[i], array);
						}
					}
				}
				List<Polygon> excludedPolygons = new List<Polygon>();
				for (int j = 0; j < list2.Count; j++)
				{
					if (list2[j] == null)
					{
						continue;
					}
					int num2 = Array.IndexOf(allBrushCaches, list2[j]);
					if (num2 <= brushIndex)
					{
						if (list2[j].Mode == CSGMode.Add)
						{
							RemoveInteriorPolygons(linkedList, list2[j], excludedPolygons, array);
						}
						else if (list2[j].Mode == CSGMode.Subtract)
						{
							RestoreInteriorPolygons(linkedList, list2[j], excludedPolygons, array);
						}
					}
					else if (list2[j].Mode == CSGMode.Add)
					{
						RemoveInteriorPolygons(linkedList, list2[j], excludedPolygons, array);
					}
					else if (list2[j].Mode == CSGMode.Subtract)
					{
						ExtractSubtractionPolygons(brushCache, linkedList, list2[j], isCollisionPass);
					}
				}
				for (LinkedListNode<BrushChunk> linkedListNode = linkedList.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
				{
					list.AddRange(linkedListNode.Value.Polygons);
				}
				for (int k = 0; k < array.Length; k++)
				{
					if (array[k] != 0)
					{
						continue;
					}
					int num3 = firstPolygonUID + k;
					for (int l = 0; l < list.Count; l++)
					{
						if (list[l].UniqueIndex == num3)
						{
							list.RemoveAt(l);
							l--;
						}
					}
					list.Add(brushCache.Polygons[k].DeepCopy());
				}
				List<Polygon> list3 = new List<Polygon>(list.Count);
				for (int m = 0; m < list.Count; m++)
				{
					if (!list[m].ExcludeFromFinal)
					{
						list3.Add(list[m]);
					}
				}
				list3.TrimExcess();
				list = list3;
				if (isCollisionPass)
				{
					brushCache.SetCollisionBuiltPolygons(list);
				}
				else
				{
					brushCache.SetVisualBuiltPolygons(list);
				}
			}
			else if (brushCache.Mode == CSGMode.Subtract)
			{
				if (isCollisionPass)
				{
					brushCache.SetCollisionBuiltPolygons(brushCache.BuiltCollisionPolygons);
				}
				else
				{
					brushCache.SetVisualBuiltPolygons(brushCache.BuiltVisualPolygons);
				}
			}
		}

		private static void ExtractSubtractionPolygons(BrushCache brushCacheSource, LinkedList<BrushChunk> brushChunks, BrushCache removee, bool isCollisionPass)
		{
			Polygon[] polygons = removee.Polygons;
			for (LinkedListNode<BrushChunk> linkedListNode = brushChunks.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (linkedListNode.Value.GetBounds().IntersectsApproximate(removee.Bounds))
				{
					List<Polygon> polygons2 = linkedListNode.Value.Polygons;
					for (int i = 0; i < polygons2.Count; i++)
					{
						Polygon polygon = polygons2[i];
						if (!polygon.ExcludeFromFinal)
						{
							continue;
						}
						for (int j = 0; j < polygons.Length; j++)
						{
							if (GeometryHelper.PolygonContainsPolygon(polygons[j], polygon))
							{
								polygon = polygon.DeepCopy();
								polygon.UniqueIndex = polygons[j].UniqueIndex;
								polygon.Material = polygons[j].Material;
								polygon.ExcludeFromFinal = false;
								polygon.UserExcludeFromFinal = polygons[j].UserExcludeFromFinal;
								Vertex[] vertices = polygon.Vertices;
								Polygon[] triangles = PolygonFactory.Triangulate(polygons[j]);
								for (int k = 0; k < vertices.Length; k++)
								{
									Vertex vertex = CalculateInterpolated(triangles, vertices[k].Position);
									vertices[k].Normal = -vertex.Normal;
									vertices[k].Color = vertex.Color;
									vertices[k].UV = vertex.UV;
								}
								polygons2[i] = polygon;
								if (isCollisionPass)
								{
									BrushCache.NotifyOfStolenCollisionPolygon(removee, brushCacheSource, polygons2[i]);
								}
								else
								{
									BrushCache.NotifyOfStolenVisualPolygon(removee, brushCacheSource, polygons2[i]);
								}
							}
						}
					}
				}
			}
		}

		private static Vertex CalculateInterpolated(Polygon[] triangles, Vector3 worldPosition)
		{
			for (int i = 0; i < triangles.Length; i++)
			{
				if (TriangleContainsPoint(triangles[i], worldPosition))
				{
					return GetVertexForPosition(triangles[i].Vertices[0], triangles[i].Vertices[1], triangles[i].Vertices[2], worldPosition);
				}
			}
			Debug.LogError("Could not match point");
			return triangles[0].Vertices[0].DeepCopy();
		}

		private static bool TriangleContainsPoint(Polygon polygon, Vector3 point)
		{
			Vertex[] vertices = polygon.Vertices;
			Vector3 normal = polygon.Plane.normal;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 position = vertices[i].Position;
				Vector3 position2 = vertices[(i + 1) % vertices.Length].Position;
				Vector3 vector = position2 - position;
				Vector3 rhs = normal;
				Vector3 lhs = Vector3.Cross(vector.normalized, rhs);
				Vector3 vector2 = (position + position2) * 0.5f;
				Vector3 rhs2 = vector2 - point;
				float num = Vector3.Dot(lhs, rhs2);
				if (num < -0.1f)
				{
					return false;
				}
			}
			return true;
		}

		public static Vertex GetVertexForPosition(Vertex vertex1, Vertex vertex2, Vertex vertex3, Vector3 newPosition)
		{
			Vector3 position = vertex1.Position;
			Vector3 position2 = vertex2.Position;
			Vector3 position3 = vertex3.Position;
			Vector3 vector = position - newPosition;
			Vector3 vector2 = position2 - newPosition;
			Vector3 vector3 = position3 - newPosition;
			Vector3 lhs = Vector3.Cross(position - position2, position - position3);
			Vector3 rhs = Vector3.Cross(vector2, vector3);
			Vector3 rhs2 = Vector3.Cross(vector3, vector);
			Vector3 rhs3 = Vector3.Cross(vector, vector2);
			float magnitude = lhs.magnitude;
			float num = rhs.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs));
			float num2 = rhs2.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs2));
			float num3 = rhs3.magnitude / magnitude * Mathf.Sign(Vector3.Dot(lhs, rhs3));
			Vertex vertex4 = vertex1.DeepCopy();
			vertex4.Normal = vertex1.Normal * num + vertex2.Normal * num2 + vertex3.Normal * num3;
			vertex4.UV = vertex1.UV * num + vertex2.UV * num2 + vertex3.UV * num3;
			Color color = vertex1.Color;
			Color color2 = vertex1.Color;
			Color color3 = vertex1.Color;
			vertex4.Color = color * num + color2 * num2 + color3 * num3;
			return vertex4;
		}

		private static void RemoveInteriorPolygons(LinkedList<BrushChunk> brushChunks, BrushCache removee, List<Polygon> excludedPolygons, int[] polygonsRemoved)
		{
			Polygon[] polygons = removee.Polygons;
			Vector3 center = removee.Bounds.center;
			for (LinkedListNode<BrushChunk> linkedListNode = brushChunks.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (linkedListNode.Value.GetBounds().IntersectsApproximate(removee.Bounds))
				{
					List<Polygon> polygons2 = linkedListNode.Value.Polygons;
					for (int i = 0; i < polygons2.Count; i++)
					{
						if (!polygons2[i].ExcludeFromFinal)
						{
							Vector3 centerPoint = polygons2[i].GetCenterPoint();
							float num = GeometryHelper.PolyhedronContainsPointDistance(polygons, centerPoint);
							if ((double)num > 1E-05)
							{
								int relativeIndex = polygons2[i].UniqueIndex - firstPolygonUID;
								MarkPolygonRemoved(relativeIndex, polygonsRemoved);
								polygons2[i].ExcludeFromFinal = true;
								excludedPolygons.Add(polygons2[i]);
							}
							else if ((double)num >= -1E-05 && Vector3.Dot(center - centerPoint, polygons2[i].Plane.normal) > 0f)
							{
								int relativeIndex2 = polygons2[i].UniqueIndex - firstPolygonUID;
								MarkPolygonRemoved(relativeIndex2, polygonsRemoved);
								polygons2[i].ExcludeFromFinal = true;
								excludedPolygons.Add(polygons2[i]);
							}
						}
					}
				}
			}
		}

		private static void RestoreInteriorPolygons(LinkedList<BrushChunk> brushChunks, BrushCache removee, List<Polygon> excludedPolygons, int[] polygonsRemoved)
		{
			Polygon[] polygons = removee.Polygons;
			Vector3 center = removee.Bounds.center;
			for (int i = 0; i < excludedPolygons.Count; i++)
			{
				Vector3 centerPoint = excludedPolygons[i].GetCenterPoint();
				if (removee.Bounds.ContainsApproximate(centerPoint))
				{
					float num = GeometryHelper.PolyhedronContainsPointDistance(polygons, centerPoint);
					if ((double)num > 1E-05)
					{
						int relativeIndex = excludedPolygons[i].UniqueIndex - firstPolygonUID;
						MarkPolygonRestored(relativeIndex, polygonsRemoved);
						excludedPolygons[i].ExcludeFromFinal = false;
						excludedPolygons.Remove(excludedPolygons[i]);
						i--;
					}
					else if (num >= -1E-05f && Vector3.Dot(center - centerPoint, excludedPolygons[i].Plane.normal) > 0f)
					{
						int relativeIndex2 = excludedPolygons[i].UniqueIndex - firstPolygonUID;
						MarkPolygonRestored(relativeIndex2, polygonsRemoved);
						excludedPolygons[i].ExcludeFromFinal = false;
						excludedPolygons.Remove(excludedPolygons[i]);
						i--;
					}
				}
			}
		}

		private static void SplitBy(LinkedList<BrushChunk> brushChunks, BrushCache splitter)
		{
			Polygon[] polygons = splitter.Polygons;
			for (int i = 0; i < polygons.Length; i++)
			{
				Plane plane = polygons[i].Plane;
				for (LinkedListNode<BrushChunk> linkedListNode = brushChunks.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
				{
					BrushChunk chunkFront;
					BrushChunk chunkBack;
					if (linkedListNode.Value.GetBounds().IntersectsApproximate(splitter.Bounds) && linkedListNode.Value.SplitByPlane(plane, out chunkFront, out chunkBack))
					{
						linkedListNode.Value = chunkBack;
						linkedListNode = brushChunks.AddAfter(linkedListNode, chunkFront);
					}
				}
			}
		}

		private static void SplitAndRemove(LinkedList<BrushChunk> brushChunks, BrushCache removee, int[] polygonsRemoved)
		{
			Polygon[] polygons = removee.Polygons;
			Plane[] splitPlanes = removee.SplitPlanes;
			for (int i = 0; i < polygons.Length; i++)
			{
				Plane splitPlane = splitPlanes[i];
				LinkedListNode<BrushChunk> linkedListNode = brushChunks.First;
				while (linkedListNode != null)
				{
					if (!linkedListNode.Value.GetBounds().IntersectsApproximate(removee.Bounds))
					{
						linkedListNode = linkedListNode.Next;
						continue;
					}
					BrushChunk chunkFront;
					BrushChunk chunkBack;
					if (linkedListNode.Value.SplitByPlane(splitPlane, out chunkFront, out chunkBack))
					{
						linkedListNode.Value = chunkBack;
						if (!GeometryHelper.PolyhedronContainsPolyhedron(polygons, chunkFront.Polygons))
						{
							linkedListNode = brushChunks.AddAfter(linkedListNode, chunkFront);
						}
						else
						{
							for (int j = 0; j < chunkFront.Polygons.Count; j++)
							{
								if (chunkFront.Polygons[j].UniqueIndex != -1)
								{
									int relativeIndex = chunkFront.Polygons[j].UniqueIndex - firstPolygonUID;
									MarkPolygonRemoved(relativeIndex, polygonsRemoved);
								}
							}
						}
						linkedListNode = linkedListNode.Next;
						continue;
					}
					LinkedListNode<BrushChunk> next = linkedListNode.Next;
					BrushChunk value = linkedListNode.Value;
					if (GeometryHelper.PolyhedronContainsPolyhedron(polygons, value.Polygons))
					{
						for (int k = 0; k < value.Polygons.Count; k++)
						{
							if (value.Polygons[k].UniqueIndex != -1)
							{
								int relativeIndex2 = value.Polygons[k].UniqueIndex - firstPolygonUID;
								MarkPolygonRemoved(relativeIndex2, polygonsRemoved);
							}
						}
						brushChunks.Remove(linkedListNode);
					}
					linkedListNode = next;
				}
			}
		}

		private static void MarkPolygonRemoved(int relativeIndex, int[] polygonsRemoved)
		{
			if (relativeIndex >= 0 && relativeIndex < polygonsRemoved.Length)
			{
				polygonsRemoved[relativeIndex]++;
			}
		}

		private static void MarkPolygonRestored(int relativeIndex, int[] polygonsRemoved)
		{
			if (relativeIndex >= 0 && relativeIndex < polygonsRemoved.Length)
			{
				polygonsRemoved[relativeIndex]--;
			}
		}
	}
}
