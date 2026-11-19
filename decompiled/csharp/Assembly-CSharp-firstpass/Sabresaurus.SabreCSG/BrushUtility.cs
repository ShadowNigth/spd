using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public static class BrushUtility
{
	[Obsolete("Rescale method has been renamed to Scale")]
	public static void Rescale(PrimitiveBrush brush, Vector3 rescaleValue)
	{
		Scale(brush, rescaleValue);
	}

	public static void Scale(PrimitiveBrush brush, Vector3 scaleValue)
	{
		Polygon[] polygons = brush.GetPolygons();
		for (int i = 0; i < polygons.Length; i++)
		{
			Polygon polygon = polygons[i];
			polygons[i].CalculatePlane();
			Vector3 normal = polygons[i].Plane.normal;
			int num = polygon.Vertices.Length;
			Vector3[] array = new Vector3[num];
			Vector2[] array2 = new Vector2[num];
			for (int j = 0; j < num; j++)
			{
				ref Vector3 reference = ref array[j];
				reference = polygon.Vertices[j].Position;
				ref Vector2 reference2 = ref array2[j];
				reference2 = polygon.Vertices[j].UV;
			}
			for (int k = 0; k < num; k++)
			{
				Vertex vertex = polygon.Vertices[k];
				Vector3 vector = vertex.Position.Multiply(scaleValue);
				array[k] = vector;
				ref Vector2 reference3 = ref array2[k];
				reference3 = GeometryHelper.GetUVForPosition(polygon, vector);
			}
			for (int l = 0; l < num; l++)
			{
				Vertex vertex2 = polygon.Vertices[l];
				vertex2.Position = array[l];
				vertex2.UV = array2[l];
			}
			polygons[i].CalculatePlane();
			Vector3 normal2 = polygons[i].Plane.normal;
			Quaternion quaternion = Quaternion.FromToRotation(normal, normal2);
			for (int m = 0; m < num; m++)
			{
				Vertex vertex3 = polygon.Vertices[m];
				vertex3.Normal = quaternion * vertex3.Normal;
			}
		}
		brush.Invalidate(polygonsChanged: true);
	}

	public static void Resize(PrimitiveBrush brush, Vector3 resizeValue)
	{
		Vector3 scaleValue = resizeValue.Divide(brush.GetBounds().size);
		Scale(brush, scaleValue);
	}

	public static void Flip(BrushBase primaryTargetBrush, BrushBase[] targetBrushes, int axisIndex, bool localToPrimaryBrush, Vector3 flipCenter)
	{
		for (int i = 0; i < targetBrushes.Length; i++)
		{
			Brush brush = (Brush)targetBrushes[i];
			Polygon[] polygons = brush.GetPolygons();
			for (int j = 0; j < polygons.Length; j++)
			{
				for (int k = 0; k < polygons[j].Vertices.Length; k++)
				{
					Vertex vertex = polygons[j].Vertices[k];
					Vector3 position = vertex.Position;
					Vector3 normal = vertex.Normal;
					if (localToPrimaryBrush)
					{
						position = primaryTargetBrush.transform.InverseTransformDirection(brush.transform.TransformDirection(position));
						normal = primaryTargetBrush.transform.InverseTransformDirection(brush.transform.TransformDirection(normal));
					}
					else
					{
						position = brush.transform.TransformDirection(position);
						normal = brush.transform.TransformDirection(normal);
					}
					position[axisIndex] = 0f - position[axisIndex];
					normal[axisIndex] = 0f - normal[axisIndex];
					if (localToPrimaryBrush)
					{
						position = brush.transform.InverseTransformDirection(primaryTargetBrush.transform.TransformDirection(position));
						normal = brush.transform.InverseTransformDirection(primaryTargetBrush.transform.TransformDirection(normal));
					}
					else
					{
						position = brush.transform.InverseTransformDirection(position);
						normal = brush.transform.InverseTransformDirection(normal);
					}
					vertex.Position = position;
					vertex.Normal = normal;
				}
				Array.Reverse(polygons[j].Vertices);
				polygons[j].CalculatePlane();
			}
			if (targetBrushes.Length > 0)
			{
				Vector3 vector = brush.transform.position - flipCenter;
				if (localToPrimaryBrush)
				{
					vector = primaryTargetBrush.transform.InverseTransformDirection(vector);
				}
				vector[axisIndex] = 0f - vector[axisIndex];
				if (localToPrimaryBrush)
				{
					vector = primaryTargetBrush.transform.TransformDirection(vector);
				}
				brush.transform.position = flipCenter + vector;
			}
			brush.Invalidate(polygonsChanged: true);
		}
	}

	public static void SplitIntersecting(PrimitiveBrush[] brushes)
	{
		List<Brush> list = new List<Brush>();
		foreach (PrimitiveBrush primitiveBrush in brushes)
		{
			list.AddRange(primitiveBrush.BrushCache.IntersectingVisualBrushes);
		}
		foreach (PrimitiveBrush primitiveBrush2 in brushes)
		{
			List<PrimitiveBrush> list2 = new List<PrimitiveBrush>();
			foreach (Brush item in list)
			{
				PrimitiveBrush primitiveBrush3 = (PrimitiveBrush)item;
				Polygon[] polygons = primitiveBrush2.GetPolygons();
				List<Plane> list3 = new List<Plane>();
				foreach (Polygon polygon in polygons)
				{
					SurfaceUtility.GetPrimaryPolygonDescribers(polygon, out var vertex, out var vertex2, out var vertex3);
					Vector3 position = vertex.Position;
					Vector3 position2 = vertex2.Position;
					Vector3 position3 = vertex3.Position;
					position = item.transform.InverseTransformPoint(primitiveBrush2.transform.TransformPoint(position));
					position2 = item.transform.InverseTransformPoint(primitiveBrush2.transform.TransformPoint(position2));
					position3 = item.transform.InverseTransformPoint(primitiveBrush2.transform.TransformPoint(position3));
					Plane plane = new Plane(position, position2, position3);
					bool flag = false;
					for (int l = 0; l < list3.Count; l++)
					{
						if (MathHelper.PlaneEqualsLooser(list3[l], plane))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list3.Add(plane);
					}
				}
				foreach (Plane item2 in list3)
				{
					GameObject gameObject = ClipUtility.ApplyClipPlane(primitiveBrush3, item2, keepBothSides: true, resetPivots: false);
					if (gameObject != null)
					{
						list2.Add(gameObject.GetComponent<PrimitiveBrush>());
					}
				}
				primitiveBrush3.ResetPivot();
			}
			foreach (PrimitiveBrush item3 in list2)
			{
				item3.ResetPivot();
			}
			list.AddRange(list2.ConvertAll((Converter<PrimitiveBrush, Brush>)((PrimitiveBrush item) => item)));
		}
	}
}
