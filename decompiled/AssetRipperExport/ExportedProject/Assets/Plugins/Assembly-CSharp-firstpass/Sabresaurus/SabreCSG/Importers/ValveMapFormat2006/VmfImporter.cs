using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006
{
	public class VmfImporter
	{
		[CompilerGenerated]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map0;

		[CompilerGenerated]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map1;

		[CompilerGenerated]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map2;

		public VmfWorld Import(string path)
		{
			VmfWorld vmfWorld = new VmfWorld();
			using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
			{
				using (StreamReader streamReader = new StreamReader(stream))
				{
					string[] array = new string[64];
					int num = 0;
					string text = string.Empty;
					bool flag = false;
					VmfSolid vmfSolid = null;
					VmfSolidSide vmfSolidSide = null;
					VmfEntity vmfEntity = null;
					while (!streamReader.EndOfStream)
					{
						string text2 = streamReader.ReadLine().Trim();
						if (text2.Length == 0)
						{
							continue;
						}
						if (text2[0] == '{')
						{
							array[num] = text;
							num++;
							flag = true;
							continue;
						}
						if (text2[0] == '}')
						{
							num--;
							array[num] = null;
							continue;
						}
						string key;
						object value;
						if (array[0] == "versioninfo" && TryParsekeyValue(text2, out key, out value))
						{
							switch (key)
							{
							case "editorversion":
								vmfWorld.VersionInfoEditorVersion = (int)value;
								break;
							case "editorbuild":
								vmfWorld.VersionInfoEditorBuild = (int)value;
								break;
							case "mapversion":
								vmfWorld.VersionInfoMapVersion = (int)value;
								break;
							case "formatversion":
								vmfWorld.VersionInfoFormatVersion = (int)value;
								break;
							case "prefab":
								vmfWorld.VersionInfoPrefab = (int)value;
								break;
							}
						}
						if (array[0] == "viewsettings" && TryParsekeyValue(text2, out key, out value))
						{
							switch (key)
							{
							case "bSnapToGrid":
								vmfWorld.ViewSettingsSnapToGrid = (int)value;
								break;
							case "bShowGrid":
								vmfWorld.ViewSettingsShowGrid = (int)value;
								break;
							case "bShowLogicalGrid":
								vmfWorld.ViewSettingsShowLogicalGrid = (int)value;
								break;
							case "nGridSpacing":
								vmfWorld.ViewSettingsGridSpacing = (int)value;
								break;
							case "bShow3DGrid":
								vmfWorld.ViewSettingsShow3DGrid = (int)value;
								break;
							}
						}
						int value2;
						if (array[0] == "world" && array[1] == null && TryParsekeyValue(text2, out key, out value) && key != null)
						{
							if (_003C_003Ef__switch_0024map0 == null)
							{
								Dictionary<string, int> dictionary = new Dictionary<string, int>(7);
								dictionary.Add("id", 0);
								dictionary.Add("mapversion", 1);
								dictionary.Add("classname", 2);
								dictionary.Add("detailmaterial", 3);
								dictionary.Add("detailvbsp", 4);
								dictionary.Add("maxpropscreenwidth", 5);
								dictionary.Add("skyname", 6);
								_003C_003Ef__switch_0024map0 = dictionary;
							}
							if (_003C_003Ef__switch_0024map0.TryGetValue(key, out value2))
							{
								switch (value2)
								{
								case 0:
									vmfWorld.Id = (int)value;
									break;
								case 1:
									vmfWorld.MapVersion = (int)value;
									break;
								case 2:
									vmfWorld.ClassName = (string)value;
									break;
								case 3:
									vmfWorld.DetailMaterial = (string)value;
									break;
								case 4:
									vmfWorld.DetailVBsp = (string)value;
									break;
								case 5:
									vmfWorld.MaxPropScreenWidth = (int)value;
									break;
								case 6:
									vmfWorld.SkyName = (string)value;
									break;
								}
							}
						}
						if (array[0] == "world" && array[1] == "solid" && array[2] == null)
						{
							if (flag)
							{
								vmfSolid = new VmfSolid();
								vmfWorld.Solids.Add(vmfSolid);
							}
							if (TryParsekeyValue(text2, out key, out value) && key != null && key == "id")
							{
								vmfSolid.Id = (int)value;
							}
						}
						if (array[0] == "world" && array[1] == "solid" && array[2] == "side" && array[3] == null)
						{
							if (flag)
							{
								vmfSolidSide = new VmfSolidSide();
								vmfSolid.Sides.Add(vmfSolidSide);
							}
							if (TryParsekeyValue(text2, out key, out value) && key != null)
							{
								if (_003C_003Ef__switch_0024map1 == null)
								{
									Dictionary<string, int> dictionary = new Dictionary<string, int>(7);
									dictionary.Add("id", 0);
									dictionary.Add("plane", 1);
									dictionary.Add("material", 2);
									dictionary.Add("uaxis", 3);
									dictionary.Add("vaxis", 4);
									dictionary.Add("lightmapscale", 5);
									dictionary.Add("smoothing_groups", 6);
									_003C_003Ef__switch_0024map1 = dictionary;
								}
								if (_003C_003Ef__switch_0024map1.TryGetValue(key, out value2))
								{
									switch (value2)
									{
									case 0:
										vmfSolidSide.Id = (int)value;
										break;
									case 1:
										vmfSolidSide.Plane = (VmfPlane)value;
										break;
									case 2:
										vmfSolidSide.Material = (string)value;
										break;
									case 3:
										vmfSolidSide.UAxis = (VmfAxis)value;
										break;
									case 4:
										vmfSolidSide.VAxis = (VmfAxis)value;
										break;
									case 5:
										vmfSolidSide.LightmapScale = (int)value;
										break;
									case 6:
										vmfSolidSide.SmoothingGroups = (int)value;
										break;
									}
								}
							}
						}
						if (array[0] == "world" && array[1] == "solid" && array[2] == "side" && array[3] == "dispinfo")
						{
							vmfSolidSide.HasDisplacement = true;
						}
						if (array[0] == "entity" && array[1] == null)
						{
							if (flag)
							{
								vmfEntity = new VmfEntity();
								vmfWorld.Entities.Add(vmfEntity);
							}
							if (TryParsekeyValue(text2, out key, out value))
							{
								switch (key)
								{
								case "id":
									vmfEntity.Id = (int)value;
									break;
								case "origin":
									vmfEntity.Origin = vmfEntity.GetVector((string)value, true);
									break;
								case "angles":
									vmfEntity.Angles = vmfEntity.GetVector((string)value, true);
									break;
								case "classname":
									vmfEntity.ClassName = (string)value;
									break;
								}
							}
						}
						if (array[0] == "entity" && array[1] == "solid" && array[2] == null)
						{
							if (flag)
							{
								vmfSolid = new VmfSolid();
								vmfEntity.Solids.Add(vmfSolid);
							}
							if (TryParsekeyValue(text2, out key, out value) && key != null && key == "id")
							{
								vmfSolid.Id = (int)value;
							}
						}
						if (array[0] == "entity" && array[1] == "solid" && array[2] == "side" && array[3] == null)
						{
							if (flag)
							{
								vmfSolidSide = new VmfSolidSide();
								vmfSolid.Sides.Add(vmfSolidSide);
							}
							if (TryParsekeyValue(text2, out key, out value) && key != null)
							{
								if (_003C_003Ef__switch_0024map2 == null)
								{
									Dictionary<string, int> dictionary = new Dictionary<string, int>(7);
									dictionary.Add("id", 0);
									dictionary.Add("plane", 1);
									dictionary.Add("material", 2);
									dictionary.Add("uaxis", 3);
									dictionary.Add("vaxis", 4);
									dictionary.Add("lightmapscale", 5);
									dictionary.Add("smoothing_groups", 6);
									_003C_003Ef__switch_0024map2 = dictionary;
								}
								if (_003C_003Ef__switch_0024map2.TryGetValue(key, out value2))
								{
									switch (value2)
									{
									case 0:
										vmfSolidSide.Id = (int)value;
										break;
									case 1:
										vmfSolidSide.Plane = (VmfPlane)value;
										break;
									case 2:
										vmfSolidSide.Material = (string)value;
										break;
									case 3:
										vmfSolidSide.UAxis = (VmfAxis)value;
										break;
									case 4:
										vmfSolidSide.VAxis = (VmfAxis)value;
										break;
									case 5:
										vmfSolidSide.LightmapScale = (int)value;
										break;
									case 6:
										vmfSolidSide.SmoothingGroups = (int)value;
										break;
									}
								}
							}
						}
						text = text2;
						flag = false;
					}
					return vmfWorld;
				}
			}
		}

		private bool TryParsekeyValue(string line, out string key, out object value)
		{
			key = string.Empty;
			value = null;
			if (!line.Contains('"'))
			{
				return false;
			}
			int num = line.IndexOf('"', 1);
			key = line.Substring(1, num - 1);
			string text = line.Substring(num + 3, line.Length - num - 4);
			if (text.Length == 0)
			{
				return false;
			}
			if (text[0] == '(')
			{
				string[] array = text.Replace("(", string.Empty).Replace(")", string.Empty).Split(' ');
				VmfVector3 p = new VmfVector3(float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[1], CultureInfo.InvariantCulture), float.Parse(array[2], CultureInfo.InvariantCulture));
				VmfVector3 p2 = new VmfVector3(float.Parse(array[3], CultureInfo.InvariantCulture), float.Parse(array[4], CultureInfo.InvariantCulture), float.Parse(array[5], CultureInfo.InvariantCulture));
				VmfVector3 p3 = new VmfVector3(float.Parse(array[6], CultureInfo.InvariantCulture), float.Parse(array[7], CultureInfo.InvariantCulture), float.Parse(array[8], CultureInfo.InvariantCulture));
				value = new VmfPlane(p, p2, p3);
				return true;
			}
			if (text[0] == '[')
			{
				string[] array2 = text.Replace("[", string.Empty).Replace("]", string.Empty).Split(' ');
				value = new VmfAxis(new VmfVector3(float.Parse(array2[0], CultureInfo.InvariantCulture), float.Parse(array2[1], CultureInfo.InvariantCulture), float.Parse(array2[2], CultureInfo.InvariantCulture)), float.Parse(array2[3], CultureInfo.InvariantCulture), float.Parse(array2[4], CultureInfo.InvariantCulture));
				return true;
			}
			float result;
			if (text.Contains('.') && float.TryParse(text, out result))
			{
				value = result;
				return true;
			}
			int result2;
			if (int.TryParse(text, out result2))
			{
				value = result2;
				return true;
			}
			value = text;
			return true;
		}
	}
}
