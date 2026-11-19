using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold;

public class T3dImporter
{
	public T3dMap Import(string path)
	{
		T3dMap t3dMap = new T3dMap();
		using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
		using StreamReader streamReader = new StreamReader(stream);
		bool flag = false;
		T3dActor t3dActor = null;
		bool flag2 = false;
		T3dBrush t3dBrush = null;
		bool flag3 = false;
		T3dPolygon t3dPolygon = null;
		while (!streamReader.EndOfStream)
		{
			string text = streamReader.ReadLine().Trim();
			if (flag)
			{
				if (!flag2)
				{
					if (text == "End Actor")
					{
						flag = false;
						continue;
					}
					if (TryParseProperty(text, out var key, out var value))
					{
						t3dActor.Properties.Add(key, value);
					}
					if (text.StartsWith("Begin Brush"))
					{
						Dictionary<string, string> dictionary = ParseKeyValuePairs(text);
						if (dictionary.ContainsKey("Name"))
						{
							flag2 = true;
							t3dBrush = new T3dBrush(dictionary["Name"]);
							t3dMap.BrushModels.Add(t3dBrush);
						}
					}
					continue;
				}
				if (text == "End Brush")
				{
					flag2 = false;
					continue;
				}
				if (!flag3)
				{
					if (text.StartsWith("Begin Polygon"))
					{
						flag3 = true;
						t3dPolygon = new T3dPolygon();
						t3dBrush.Polygons.Add(t3dPolygon);
						Dictionary<string, string> dictionary2 = ParseKeyValuePairs(text);
						if (dictionary2.ContainsKey("Item"))
						{
							t3dPolygon.Item = dictionary2["Item"];
						}
						if (dictionary2.ContainsKey("Texture"))
						{
							t3dPolygon.Texture = dictionary2["Texture"];
						}
						if (dictionary2.ContainsKey("Flags"))
						{
							t3dPolygon.Flags = (T3dPolygonFlags)int.Parse(dictionary2["Flags"]);
						}
					}
					continue;
				}
				if (text == "End Polygon")
				{
					flag3 = false;
					continue;
				}
				if (text.StartsWith("Origin"))
				{
					t3dPolygon.Origin = ParsePolygonVector(text);
				}
				if (text.StartsWith("Normal"))
				{
					t3dPolygon.Normal = ParsePolygonVector(text);
				}
				if (text.StartsWith("TextureU"))
				{
					t3dPolygon.TextureU = ParsePolygonVector(text);
				}
				if (text.StartsWith("TextureV"))
				{
					t3dPolygon.TextureV = ParsePolygonVector(text);
				}
				if (text.StartsWith("Pan"))
				{
					ParsePolygonUV(text, out var u, out var v);
					t3dPolygon.PanU = u;
					t3dPolygon.PanV = v;
				}
				if (text.StartsWith("Vertex"))
				{
					t3dPolygon.Vertices.Add(ParsePolygonVector(text));
				}
			}
			else if (text.StartsWith("Begin Actor"))
			{
				Dictionary<string, string> dictionary3 = ParseKeyValuePairs(text);
				if (dictionary3.ContainsKey("Class") && dictionary3.ContainsKey("Name"))
				{
					flag = true;
					t3dActor = new T3dActor(t3dMap, dictionary3["Class"], dictionary3["Name"]);
					t3dMap.Actors.Add(t3dActor);
				}
			}
		}
		return t3dMap;
	}

	private T3dVector3 ParsePolygonVector(string line)
	{
		string[] array = line.Substring(line.IndexOf(' ')).Replace("+", string.Empty).Trim()
			.Split(',');
		return new T3dVector3(float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[1], CultureInfo.InvariantCulture), float.Parse(array[2], CultureInfo.InvariantCulture));
	}

	private void ParsePolygonUV(string line, out int u, out int v)
	{
		int num = line.IndexOf("U=");
		int num2 = line.IndexOf("V=");
		string s = line.Substring(num + 2, line.IndexOf(' ', num) - num - 2);
		string s2 = line.Substring(num2 + 2);
		int.TryParse(s, out u);
		int.TryParse(s2, out v);
	}

	private bool TryParseProperty(string line, out string key, out object value)
	{
		key = null;
		value = null;
		int num = line.IndexOf('=');
		if (num == -1)
		{
			return false;
		}
		key = line.Substring(0, num);
		if (key.Contains(' '))
		{
			return false;
		}
		string text = line.Substring(num + 1);
		if (text[0] == '"')
		{
			value = text.Substring(1, text.Length - 2);
			return true;
		}
		if (text[0] == '(')
		{
			if (text[1] == 'P' || (text[1] == 'Y' && text[2] == 'a') || text[1] == 'R')
			{
				int num2 = text.IndexOf("Pitch=");
				int num3 = text.IndexOf("Yaw=");
				int num4 = text.IndexOf("Roll=");
				if (num2 == -1 && num3 == -1 && num4 == -1)
				{
					return false;
				}
				int result = 0;
				int result2 = 0;
				int result3 = 0;
				if (num2 != -1)
				{
					int num5 = text.IndexOf(',', num2);
					if (num5 == -1)
					{
						num5 = text.IndexOf(')', num2);
					}
					string s = text.Substring(num2 + 6, num5 - 1 - 6);
					int.TryParse(s, out result);
				}
				if (num3 != -1)
				{
					int num6 = text.IndexOf(',', num3);
					if (num6 == -1)
					{
						num6 = text.IndexOf(')', num3);
					}
					string s2 = text.Substring(num3 + 4, num6 - num3 - 4);
					int.TryParse(s2, out result2);
				}
				if (num4 != -1)
				{
					int num7 = text.IndexOf(',', num4);
					if (num7 == -1)
					{
						num7 = text.IndexOf(')', num4);
					}
					string s3 = text.Substring(num4 + 5, num7 - num4 - 5);
					int.TryParse(s3, out result3);
				}
				value = new T3dRotator(result, result2, result3);
				return true;
			}
			if (text[1] == 'X' || text[1] == 'Y' || text[1] == 'Z')
			{
				int num8 = text.IndexOf("X=");
				int num9 = text.IndexOf("Y=");
				int num10 = text.IndexOf("Z=");
				if (num8 == -1 && num9 == -1 && num10 == -1)
				{
					return false;
				}
				float result4 = 0f;
				float result5 = 0f;
				float result6 = 0f;
				if (num8 != -1)
				{
					int num11 = text.IndexOf(',', num8);
					if (num11 == -1)
					{
						num11 = text.IndexOf(')', num8);
					}
					string s4 = text.Substring(num8 + 2, num11 - 1 - 2);
					float.TryParse(s4, out result4);
				}
				if (num9 != -1)
				{
					int num12 = text.IndexOf(',', num9);
					if (num12 == -1)
					{
						num12 = text.IndexOf(')', num9);
					}
					string s5 = text.Substring(num9 + 2, num12 - num9 - 2);
					float.TryParse(s5, out result5);
				}
				if (num10 != -1)
				{
					int num13 = text.IndexOf(',', num10);
					if (num13 == -1)
					{
						num13 = text.IndexOf(')', num10);
					}
					string s6 = text.Substring(num10 + 2, num13 - num10 - 2);
					float.TryParse(s6, out result6);
				}
				value = new T3dVector3(result4, result5, result6);
				return true;
			}
			if (text[1] == 'S' && text[2] != 'h')
			{
				string line2 = text.Replace("(Scale=", "X=").Replace(",SheerAxis=SHEER_ZX)", string.Empty);
				if (TryParseProperty(line2, out var _, out var value2))
				{
					T3dVector3 t3dVector = (T3dVector3)value2;
					t3dVector.X = ((t3dVector.X != 0f) ? t3dVector.X : 1f);
					t3dVector.Y = ((t3dVector.Y != 0f) ? t3dVector.Y : 1f);
					t3dVector.Z = ((t3dVector.Z != 0f) ? t3dVector.Z : 1f);
					value = t3dVector;
					return true;
				}
			}
			return false;
		}
		if (text.Contains('.') && float.TryParse(text, out var result7))
		{
			value = result7;
			return true;
		}
		if (int.TryParse(text, out var result8))
		{
			value = result8;
			return true;
		}
		value = text;
		return true;
	}

	private Dictionary<string, string> ParseKeyValuePairs(string line)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string text = string.Empty;
		StringBuilder stringBuilder = new StringBuilder(128);
		foreach (char c in line)
		{
			switch (c)
			{
			case ' ':
				if (text != string.Empty)
				{
					dictionary.Add(text, stringBuilder.ToString());
					text = string.Empty;
				}
				stringBuilder.Remove(0, stringBuilder.Length);
				break;
			case '=':
				text = stringBuilder.ToString();
				stringBuilder.Remove(0, stringBuilder.Length);
				break;
			default:
				stringBuilder.Append(c);
				break;
			}
		}
		if (text != string.Empty)
		{
			dictionary.Add(text, stringBuilder.ToString());
		}
		return dictionary;
	}
}
