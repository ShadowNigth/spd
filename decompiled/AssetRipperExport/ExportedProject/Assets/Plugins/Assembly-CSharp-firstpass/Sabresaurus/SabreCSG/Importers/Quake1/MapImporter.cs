using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Sabresaurus.SabreCSG.Importers.Quake1
{
	public class MapImporter
	{
		public MapWorld Import(string path)
		{
			MapWorld mapWorld = new MapWorld();
			using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
			{
				using (StreamReader streamReader = new StreamReader(stream))
				{
					int num = 0;
					bool flag = false;
					MapBrush mapBrush = null;
					MapEntity mapEntity = null;
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine().Trim();
						if (text.Length == 0 || text[0] == '/')
						{
							continue;
						}
						if (text[0] == '{')
						{
							num++;
							flag = true;
							continue;
						}
						if (text[0] == '}')
						{
							num--;
							continue;
						}
						if (num == 1)
						{
							if (flag)
							{
								mapEntity = new MapEntity();
								mapWorld.Entities.Add(mapEntity);
							}
							string key;
							object value;
							if (TryParsekeyValue(text, out key, out value) && key != null && key == "classname")
							{
								mapEntity.ClassName = (string)value;
							}
						}
						if (num == 2)
						{
							if (flag)
							{
								mapBrush = new MapBrush();
								mapEntity.Brushes.Add(mapBrush);
							}
							MapBrushSide mapBrushSide;
							if (TryParseBrushSide(text, out mapBrushSide))
							{
								mapBrush.Sides.Add(mapBrushSide);
							}
						}
						flag = false;
					}
					return mapWorld;
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

		private bool TryParseBrushSide(string line, out MapBrushSide mapBrushSide)
		{
			mapBrushSide = new MapBrushSide();
			if (line[0] == '(')
			{
				string[] array = line.Replace("(", string.Empty).Replace(")", string.Empty).Replace("  ", " ")
					.Replace("  ", " ")
					.Trim()
					.Split(' ');
				if (array.Length != 15)
				{
					return false;
				}
				try
				{
					MapVector3 p = new MapVector3(float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[1], CultureInfo.InvariantCulture), float.Parse(array[2], CultureInfo.InvariantCulture));
					MapVector3 p2 = new MapVector3(float.Parse(array[3], CultureInfo.InvariantCulture), float.Parse(array[4], CultureInfo.InvariantCulture), float.Parse(array[5], CultureInfo.InvariantCulture));
					MapVector3 p3 = new MapVector3(float.Parse(array[6], CultureInfo.InvariantCulture), float.Parse(array[7], CultureInfo.InvariantCulture), float.Parse(array[8], CultureInfo.InvariantCulture));
					mapBrushSide.Plane = new MapPlane(p, p2, p3);
					mapBrushSide.Material = array[9];
					mapBrushSide.Offset = new MapVector2(float.Parse(array[10], CultureInfo.InvariantCulture), float.Parse(array[11], CultureInfo.InvariantCulture));
					mapBrushSide.Rotation = float.Parse(array[12], CultureInfo.InvariantCulture);
					mapBrushSide.Scale = new MapVector2(float.Parse(array[13], CultureInfo.InvariantCulture), float.Parse(array[14], CultureInfo.InvariantCulture));
				}
				catch (Exception)
				{
					throw new Exception("Encountered invalid brush side. The format of the map file must be slightly different, please open an issue on github if you think you did everything right.");
				}
				return true;
			}
			return false;
		}
	}
}
