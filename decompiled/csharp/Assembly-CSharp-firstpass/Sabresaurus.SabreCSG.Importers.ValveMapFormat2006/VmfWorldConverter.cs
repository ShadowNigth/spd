using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006;

public static class VmfWorldConverter
{
	private const float inchesInMeters = 0.0254f;

	public static void Import(CSGModelBase model, VmfWorld world)
	{
		try
		{
			model.BeginUpdate();
			MaterialSearcher materialSearcher = new MaterialSearcher();
			GroupBrush groupBrush = new GameObject("Source Engine Map").AddComponent<GroupBrush>();
			groupBrush.transform.SetParent(model.transform);
			for (int i = 0; i < world.Solids.Count; i++)
			{
				VmfSolid vmfSolid = world.Solids[i];
				if (vmfSolid.Sides.Count > 0 && IsSpecialMaterial(vmfSolid.Sides[0].Material))
				{
					continue;
				}
				GameObject gameObject = model.CreateBrush(PrimitiveBrushType.Cube, Vector3.zero);
				PrimitiveBrush component = gameObject.GetComponent<PrimitiveBrush>();
				BrushUtility.Resize(component, new Vector3(8192f, 8192f, 8192f));
				int count = vmfSolid.Sides.Count;
				while (count-- > 0)
				{
					VmfSolidSide vmfSolidSide = vmfSolid.Sides[count];
					Plane clip2 = new Plane(component.transform.InverseTransformPoint(new Vector3(vmfSolidSide.Plane.P1.X, vmfSolidSide.Plane.P1.Z, vmfSolidSide.Plane.P1.Y) * 0.0254f), component.transform.InverseTransformPoint(new Vector3(vmfSolidSide.Plane.P2.X, vmfSolidSide.Plane.P2.Z, vmfSolidSide.Plane.P2.Y) * 0.0254f), component.transform.InverseTransformPoint(new Vector3(vmfSolidSide.Plane.P3.X, vmfSolidSide.Plane.P3.Z, vmfSolidSide.Plane.P3.Y) * 0.0254f));
					ClipUtility.ApplyClipPlane(component, clip2, keepBothSides: false);
					IEnumerable<Polygon> enumerable = from p in component.GetPolygons()
						where p.Plane.normal.EqualsWithEpsilonLower3(clip2.normal)
						select p;
					foreach (Polygon item in enumerable)
					{
						if (IsExcludedMaterial(vmfSolidSide.Material))
						{
							item.UserExcludeFromFinal = true;
						}
						if (IsInvisibleMaterial(vmfSolidSide.Material))
						{
							component.IsVisible = false;
						}
						string text = vmfSolidSide.Material.Replace("/", ".");
						Material material;
						if (text.Contains('.'))
						{
							string text2 = text.Substring(text.LastIndexOf('.') + 1);
							material = materialSearcher.FindMaterial(new string[2] { text, text2 });
							if (material == null)
							{
								Debug.Log("SabreCSG: Tried to find material '" + text + "' and also as '" + text2 + "' but it couldn't be found in the project.");
							}
						}
						else
						{
							material = materialSearcher.FindMaterial(new string[1] { text });
							if (material == null)
							{
								Debug.Log("SabreCSG: Tried to find material '" + text + "' but it couldn't be found in the project.");
							}
						}
						item.Material = material;
						int textureWidth = 256;
						int textureHeight = 256;
						if (item.Material != null && item.Material.mainTexture != null)
						{
							textureWidth = item.Material.mainTexture.width;
							textureHeight = item.Material.mainTexture.height;
						}
						CalculateTextureCoordinates(component, item, textureWidth, textureHeight, vmfSolidSide.UAxis, vmfSolidSide.VAxis);
					}
				}
				component.transform.SetParent(groupBrush.transform);
			}
			for (int j = 0; j < world.Entities.Count; j++)
			{
				VmfEntity vmfEntity = world.Entities[j];
				switch (vmfEntity.ClassName)
				{
				case "func_areaportal":
				case "func_areaportalwindow":
				case "func_capturezone":
				case "func_changeclass":
				case "func_combine_ball_spawner":
				case "func_dustcloud":
				case "func_dustmotes":
				case "func_nobuild":
				case "func_nogrenades":
				case "func_occluder":
				case "func_precipitation":
				case "func_proprespawnzone":
				case "func_regenerate":
				case "func_respawnroom":
				case "func_smokevolume":
				case "func_viscluster":
					continue;
				}
				for (int k = 0; k < vmfEntity.Solids.Count; k++)
				{
					VmfSolid vmfSolid2 = vmfEntity.Solids[k];
					if (vmfSolid2.Sides.Count > 0 && IsSpecialMaterial(vmfSolid2.Sides[0].Material))
					{
						continue;
					}
					GameObject gameObject2 = model.CreateBrush(PrimitiveBrushType.Cube, Vector3.zero);
					PrimitiveBrush component2 = gameObject2.GetComponent<PrimitiveBrush>();
					BrushUtility.Resize(component2, new Vector3(8192f, 8192f, 8192f));
					int count2 = vmfSolid2.Sides.Count;
					while (count2-- > 0)
					{
						VmfSolidSide vmfSolidSide2 = vmfSolid2.Sides[count2];
						Plane clip = new Plane(component2.transform.InverseTransformPoint(new Vector3(vmfSolidSide2.Plane.P1.X, vmfSolidSide2.Plane.P1.Z, vmfSolidSide2.Plane.P1.Y) * 0.0254f), component2.transform.InverseTransformPoint(new Vector3(vmfSolidSide2.Plane.P2.X, vmfSolidSide2.Plane.P2.Z, vmfSolidSide2.Plane.P2.Y) * 0.0254f), component2.transform.InverseTransformPoint(new Vector3(vmfSolidSide2.Plane.P3.X, vmfSolidSide2.Plane.P3.Z, vmfSolidSide2.Plane.P3.Y) * 0.0254f));
						ClipUtility.ApplyClipPlane(component2, clip, keepBothSides: false);
						IEnumerable<Polygon> enumerable2 = from p in component2.GetPolygons()
							where p.Plane.normal.EqualsWithEpsilonLower3(clip.normal)
							select p;
						foreach (Polygon item2 in enumerable2)
						{
							if (IsExcludedMaterial(vmfSolidSide2.Material))
							{
								item2.UserExcludeFromFinal = true;
							}
							if (IsInvisibleMaterial(vmfSolidSide2.Material))
							{
								component2.IsVisible = false;
							}
							string text3 = vmfSolidSide2.Material.Replace("/", ".");
							Material material2;
							if (text3.Contains('.'))
							{
								string text4 = text3.Substring(text3.LastIndexOf('.') + 1);
								material2 = materialSearcher.FindMaterial(new string[2] { text3, text4 });
								if (material2 == null)
								{
									Debug.Log("SabreCSG: Tried to find material '" + text3 + "' and also as '" + text4 + "' but it couldn't be found in the project.");
								}
							}
							else
							{
								material2 = materialSearcher.FindMaterial(new string[1] { text3 });
								if (material2 == null)
								{
									Debug.Log("SabreCSG: Tried to find material '" + text3 + "' but it couldn't be found in the project.");
								}
							}
							item2.Material = material2;
							int textureWidth2 = 256;
							int textureHeight2 = 256;
							if (item2.Material != null && item2.Material.mainTexture != null)
							{
								textureWidth2 = item2.Material.mainTexture.width;
								textureHeight2 = item2.Material.mainTexture.height;
							}
							CalculateTextureCoordinates(component2, item2, textureWidth2, textureHeight2, vmfSolidSide2.UAxis, vmfSolidSide2.VAxis);
						}
					}
					if (vmfEntity.ClassName == "func_detail")
					{
						component2.IsNoCSG = true;
					}
					if (vmfEntity.ClassName == "func_vehicleclip")
					{
						component2.IsVisible = false;
					}
					component2.transform.SetParent(groupBrush.transform);
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

	private static void CalculateTextureCoordinates(PrimitiveBrush pr, Polygon polygon, int textureWidth, int textureHeight, VmfAxis UAxis, VmfAxis VAxis)
	{
		UAxis.Translation %= textureWidth;
		VAxis.Translation %= textureHeight;
		if (UAxis.Translation < (float)(-textureWidth) / 2f)
		{
			UAxis.Translation += textureWidth;
		}
		if (VAxis.Translation < (float)(-textureHeight) / 2f)
		{
			VAxis.Translation += textureHeight;
		}
		for (int i = 0; i < polygon.Vertices.Length; i++)
		{
			Vector3 lhs = pr.transform.position + polygon.Vertices[i].Position;
			Vector3 rhs = new Vector3(UAxis.Vector.X, UAxis.Vector.Z, UAxis.Vector.Y);
			Vector3 rhs2 = new Vector3(VAxis.Vector.X, VAxis.Vector.Z, VAxis.Vector.Y);
			float x = Vector3.Dot(lhs, rhs) / ((float)textureWidth * (UAxis.Scale * 0.0254f)) + UAxis.Translation / (float)textureWidth;
			float num = Vector3.Dot(lhs, rhs2) / ((float)textureHeight * (VAxis.Scale * 0.0254f)) + VAxis.Translation / (float)textureHeight;
			polygon.Vertices[i].UV.x = x;
			polygon.Vertices[i].UV.y = 0f - num;
		}
	}

	private static bool IsExcludedMaterial(string name)
	{
		if (name != null && name == "TOOLS/TOOLSNODRAW")
		{
			return true;
		}
		return false;
	}

	private static bool IsInvisibleMaterial(string name)
	{
		switch (name)
		{
		case "TOOLS/TOOLSCLIP":
		case "TOOLS/TOOLSNPCCLIP":
		case "TOOLS/TOOLSPLAYERCLIP":
		case "TOOLS/TOOLSGRENDADECLIP":
		case "TOOLS/TOOLSSTAIRS":
			return true;
		default:
			return false;
		}
	}

	private static bool IsSpecialMaterial(string name)
	{
		switch (name)
		{
		case "TOOLS/TOOLSTRIGGER":
		case "TOOLS/TOOLSBLOCK_LOS":
		case "TOOLS/TOOLSBLOCKBULLETS":
		case "TOOLS/TOOLSBLOCKBULLETS2":
		case "TOOLS/TOOLSBLOCKSBULLETSFORCEFIELD":
		case "TOOLS/TOOLSBLOCKLIGHT":
		case "TOOLS/TOOLSCLIMBVERSUS":
		case "TOOLS/TOOLSHINT":
		case "TOOLS/TOOLSINVISIBLE":
		case "TOOLS/TOOLSINVISIBLENONSOLID":
		case "TOOLS/TOOLSINVISIBLELADDER":
		case "TOOLS/TOOLSINVISMETAL":
		case "TOOLS/TOOLSNODRAWROOF":
		case "TOOLS/TOOLSNODRAWWOOD":
		case "TOOLS/TOOLSNODRAWPORTALABLE":
		case "TOOLS/TOOLSSKIP":
		case "TOOLS/TOOLSFOG":
		case "TOOLS/TOOLSSKYBOX":
		case "TOOLS/TOOLS2DSKYBOX":
		case "TOOLS/TOOLSSKYFOG":
		case "TOOLS/TOOLSFOGVOLUME":
			return true;
		default:
			return false;
		}
	}
}
