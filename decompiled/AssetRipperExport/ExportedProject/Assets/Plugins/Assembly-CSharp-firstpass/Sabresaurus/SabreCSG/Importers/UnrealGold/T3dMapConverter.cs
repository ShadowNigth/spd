using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold
{
	public static class T3dMapConverter
	{
		public static void Import(CSGModelBase model, T3dMap map, int scale = 64)
		{
			try
			{
				model.BeginUpdate();
				MaterialSearcher materialSearcher = new MaterialSearcher();
				List<T3dActor> brushes = map.Brushes;
				Brush[] array = new Brush[brushes.Count];
				for (int i = 0; i < brushes.Count; i++)
				{
					T3dActor t3dActor = brushes[i];
					T3dBrush brush = t3dActor.Brush;
					Polygon[] array2 = new Polygon[brush.Polygons.Count];
					for (int j = 0; j < brush.Polygons.Count; j++)
					{
						T3dPolygon t3dPolygon = brush.Polygons[j];
						Material material;
						if (t3dPolygon.Texture.Contains('.'))
						{
							string text = t3dPolygon.Texture.Substring(t3dPolygon.Texture.LastIndexOf('.') + 1);
							material = materialSearcher.FindMaterial(new string[2] { t3dPolygon.Texture, text });
							if (material == null)
							{
								Debug.Log("SabreCSG: Tried to find material '" + t3dPolygon.Texture + "' and also as '" + text + "' but it couldn't be found in the project.");
							}
						}
						else
						{
							material = materialSearcher.FindMaterial(new string[1] { t3dPolygon.Texture });
							if (material == null)
							{
								Debug.Log("SabreCSG: Tried to find material '" + t3dPolygon.Texture + "' but it couldn't be found in the project.");
							}
						}
						Vertex[] array3 = new Vertex[t3dPolygon.Vertices.Count];
						for (int k = 0; k < t3dPolygon.Vertices.Count; k++)
						{
							Vector3 vector = ToVector3(t3dPolygon.Vertices[k]);
							Vector3 vector2 = ToVector3(t3dActor.PrePivot);
							Vector3 a = vector - vector2;
							vector = a.Multiply(ToVector3Raw(t3dActor.MainScale)) + vector2;
							array3[k] = new Vertex(vector.Multiply(ToVector3Raw(t3dActor.PostScale)) / scale, ToVector3(t3dPolygon.Normal), GenerateUV(t3dPolygon, k, material));
						}
						bool userExcludeFromFinal = false;
						if ((t3dPolygon.Flags & T3dPolygonFlags.Invisible) > (T3dPolygonFlags)0)
						{
							userExcludeFromFinal = true;
						}
						array2[j] = new Polygon(array3, material, false, userExcludeFromFinal);
					}
					Transform transform = model.CreateCustomBrush(array2).transform;
					transform.position = ToVector3(t3dActor.Location) / scale - ToVector3(t3dActor.PrePivot) / scale;
					float angle;
					Vector3 axis;
					T3dRotatorToQuaternion(t3dActor.Rotation).ToAngleAxis(out angle, out axis);
					transform.RotateAround(transform.position + ToVector3(t3dActor.PrePivot) / scale, axis, angle);
					PrimitiveBrush primitiveBrush = (PrimitiveBrush)(array[i] = transform.GetComponent<PrimitiveBrush>());
					object value;
					if (t3dActor.Properties.TryGetValue("CsgOper", out value))
					{
						primitiveBrush.Mode = ((!((string)value == "CSG_Add")) ? CSGMode.Subtract : CSGMode.Add);
					}
					if (t3dActor.Properties.TryGetValue("PolyFlags", out value))
					{
						T3dBrushFlags t3dBrushFlags = (T3dBrushFlags)value;
						if ((t3dBrushFlags & T3dBrushFlags.Invisible) > (T3dBrushFlags)0)
						{
							primitiveBrush.IsVisible = false;
						}
						if ((t3dBrushFlags & T3dBrushFlags.NonSolid) > (T3dBrushFlags)0)
						{
							primitiveBrush.HasCollision = false;
						}
						if ((t3dBrushFlags & T3dBrushFlags.SemiSolid) > (T3dBrushFlags)0)
						{
							primitiveBrush.IsNoCSG = true;
						}
					}
					if (array2.Length == 1)
					{
						primitiveBrush.IsNoCSG = true;
					}
				}
				string text2 = "Unreal Gold Map";
				if (map.Title != string.Empty)
				{
					text2 = text2 + " '" + map.Title + "'";
				}
				if (map.Author != string.Empty)
				{
					text2 = text2 + " (" + map.Author + ")";
				}
				GroupBrush groupBrush = new GameObject(text2).AddComponent<GroupBrush>();
				groupBrush.transform.SetParent(model.transform);
				for (int l = 0; l < array.Length; l++)
				{
					array[l].transform.SetParent(groupBrush.transform);
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

		private static Vector3 ToVector3(T3dVector3 vector3)
		{
			return new Vector3(0f - vector3.X, vector3.Z, vector3.Y);
		}

		private static Vector3 ToVector3Raw(T3dVector3 vector3)
		{
			return new Vector3(vector3.X, vector3.Z, vector3.Y);
		}

		private static float DotProduct(float ax, float ay, float az, float bx, float by, float bz)
		{
			return ax * bx + ay * by + az * bz;
		}

		private static Vector2 GenerateUV(T3dPolygon polygon, int vindex, Material material)
		{
			float num = DotProduct(polygon.Vertices[vindex].X - polygon.Origin.X, polygon.Vertices[vindex].Y - polygon.Origin.Y, polygon.Vertices[vindex].Z - polygon.Origin.Z, polygon.TextureU.X, polygon.TextureU.Y, polygon.TextureU.Z);
			float num2 = DotProduct(polygon.Vertices[vindex].X - polygon.Origin.X, polygon.Vertices[vindex].Y - polygon.Origin.Y, polygon.Vertices[vindex].Z - polygon.Origin.Z, polygon.TextureV.X, polygon.TextureV.Y, polygon.TextureV.Z);
			if (material == null || material.mainTexture == null)
			{
				return new Vector2(num * 0.00390625f, 1f - num2 * 0.00390625f);
			}
			return new Vector2((num + (float)polygon.PanU) * (1f / (float)material.mainTexture.width), 1f - (num2 + (float)polygon.PanV) * (1f / (float)material.mainTexture.height));
		}

		private static Quaternion T3dRotatorToQuaternion(T3dRotator rotator)
		{
			float num = Mathf.Cos((float)rotator.Pitch * 4.79369E-05f);
			float num2 = Mathf.Cos((float)rotator.Yaw * 4.79369E-05f);
			float num3 = Mathf.Cos((float)rotator.Roll * 4.79369E-05f);
			float num4 = Mathf.Sin((float)rotator.Pitch * 4.79369E-05f);
			float num5 = Mathf.Sin((float)rotator.Yaw * 4.79369E-05f);
			float num6 = Mathf.Sin((float)rotator.Roll * 4.79369E-05f);
			Quaternion result = default(Quaternion);
			result.w = num * num2 * num3 + num4 * num5 * num6;
			result.z = num4 * num2 * num3 + num * num5 * num6;
			result.y = num * num5 * num3 - num4 * num2 * num6;
			result.x = num * num2 * num6 - num4 * num5 * num3;
			float num7 = Mathf.Sqrt(Mathf.Pow(result.w, 2f) + Mathf.Pow(result.x, 2f) + Mathf.Pow(result.y, 2f) + Mathf.Pow(result.z, 2f));
			result.w /= num7;
			result.x /= num7;
			result.y /= num7;
			result.z /= num7;
			result.z = 0f - result.z;
			return result;
		}
	}
}
