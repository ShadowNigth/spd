using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Importers.Quake1
{
	public static class MapWorldConverter
	{
		private static int s_Scale = 32;

		public static void Import(CSGModelBase model, MapWorld world)
		{
			try
			{
				model.BeginUpdate();
				MaterialSearcher materialSearcher = new MaterialSearcher();
				GroupBrush groupBrush = new GameObject("Quake 1 Map").AddComponent<GroupBrush>();
				groupBrush.transform.SetParent(model.transform);
				for (int i = 0; i < world.Entities.Count; i++)
				{
					MapEntity mapEntity = world.Entities[i];
					for (int j = 0; j < mapEntity.Brushes.Count; j++)
					{
						MapBrush mapBrush = mapEntity.Brushes[j];
						if (mapBrush.Sides.Count > 0 && IsSpecialMaterial(mapBrush.Sides[0].Material))
						{
							continue;
						}
						GameObject gameObject = model.CreateBrush(PrimitiveBrushType.Cube, Vector3.zero);
						PrimitiveBrush component = gameObject.GetComponent<PrimitiveBrush>();
						BrushUtility.Resize(component, new Vector3(8192f, 8192f, 8192f));
						int count = mapBrush.Sides.Count;
						while (count-- > 0)
						{
							MapBrushSide mapBrushSide = mapBrush.Sides[count];
							Plane clip = new Plane(component.transform.InverseTransformPoint(new Vector3(mapBrushSide.Plane.P1.X, mapBrushSide.Plane.P1.Z, mapBrushSide.Plane.P1.Y) / s_Scale), component.transform.InverseTransformPoint(new Vector3(mapBrushSide.Plane.P2.X, mapBrushSide.Plane.P2.Z, mapBrushSide.Plane.P2.Y) / s_Scale), component.transform.InverseTransformPoint(new Vector3(mapBrushSide.Plane.P3.X, mapBrushSide.Plane.P3.Z, mapBrushSide.Plane.P3.Y) / s_Scale));
							ClipUtility.ApplyClipPlane(component, clip, false);
							IEnumerable<Polygon> enumerable = from p in component.GetPolygons()
								where p.Plane.normal.EqualsWithEpsilonLower3(clip.normal)
								select p;
							foreach (Polygon item in enumerable)
							{
								if (IsExcludedMaterial(mapBrushSide.Material))
								{
									item.UserExcludeFromFinal = true;
								}
								if (IsInvisibleMaterial(mapBrushSide.Material))
								{
									component.IsVisible = false;
								}
								string text = mapBrushSide.Material.Replace("*", "#");
								Material material = materialSearcher.FindMaterial(new string[1] { text });
								if (material == null)
								{
									Debug.Log("SabreCSG: Tried to find material '" + text + "' but it couldn't be found in the project.");
								}
								item.Material = material;
								int textureWidth = 256;
								int textureHeight = 256;
								if (item.Material != null && item.Material.mainTexture != null)
								{
									textureWidth = item.Material.mainTexture.width;
									textureHeight = item.Material.mainTexture.height;
								}
								CalculateTextureCoordinates(component, item, textureWidth, textureHeight, new Vector2(mapBrushSide.Offset.X, 0f - mapBrushSide.Offset.Y), new Vector2(mapBrushSide.Scale.X, mapBrushSide.Scale.Y), mapBrushSide.Rotation);
							}
						}
						component.transform.SetParent(groupBrush.transform);
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				model.EndUpdate();
			}
		}

		private static void CalculateTextureCoordinates(PrimitiveBrush pr, Polygon polygon, int textureWidth, int textureHeight, Vector2 offset, Vector2 scale, float rotation)
		{
			for (int i = 0; i < polygon.Vertices.Length; i++)
			{
				Vector3 vector = (pr.transform.position + polygon.Vertices[i].Position) * s_Scale;
				Vector2 vector2 = new Vector2(0f, 0f);
				int num = 0;
				float[] array = new float[3]
				{
					Mathf.Abs(polygon.Plane.normal.x),
					Mathf.Abs(polygon.Plane.normal.z),
					Mathf.Abs(polygon.Plane.normal.y)
				};
				num = 0;
				if (array[1] > array[num])
				{
					num = 1;
				}
				if (array[2] >= array[num])
				{
					num = 2;
				}
				if (num == 0)
				{
					vector2.x = vector.z;
					vector2.y = vector.y;
				}
				if (num == 1)
				{
					vector2.x = vector.x;
					vector2.y = vector.y;
				}
				if (num == 2)
				{
					vector2.x = vector.x;
					vector2.y = vector.z;
				}
				vector2 = vector2.Rotate(0f - rotation);
				vector2 = vector2.Divide(scale);
				vector2 += offset;
				vector2 = vector2.Divide(new Vector2(textureWidth, textureHeight));
				polygon.Vertices[i].UV = vector2;
			}
		}

		private static bool IsExcludedMaterial(string name)
		{
			if (name.StartsWith("sky"))
			{
				return true;
			}
			return false;
		}

		private static bool IsInvisibleMaterial(string name)
		{
			if (name != null && name == "clip")
			{
				return true;
			}
			return false;
		}

		private static bool IsSpecialMaterial(string name)
		{
			switch (name)
			{
			case "skip":
			case "waterskip":
				return true;
			default:
				return false;
			}
		}
	}
}
