using System.Collections.Generic;
using System.Linq;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold;

public class T3dActor
{
	public string Class;

	public string Name;

	public Dictionary<string, object> Properties = new Dictionary<string, object>();

	private T3dMap m_T3dMap;

	public T3dVector3 Location
	{
		get
		{
			if (Properties.TryGetValue("Location", out var value))
			{
				return value as T3dVector3;
			}
			return new T3dVector3();
		}
	}

	public T3dRotator Rotation
	{
		get
		{
			if (Properties.TryGetValue("Rotation", out var value))
			{
				return value as T3dRotator;
			}
			return new T3dRotator();
		}
	}

	public T3dVector3 MainScale
	{
		get
		{
			if (Properties.TryGetValue("MainScale", out var value))
			{
				return value as T3dVector3;
			}
			return new T3dVector3(1f, 1f, 1f);
		}
	}

	public T3dVector3 PostScale
	{
		get
		{
			if (Properties.TryGetValue("PostScale", out var value))
			{
				return value as T3dVector3;
			}
			return new T3dVector3(1f, 1f, 1f);
		}
	}

	public T3dVector3 PrePivot
	{
		get
		{
			if (Properties.TryGetValue("PrePivot", out var value))
			{
				return value as T3dVector3;
			}
			return new T3dVector3(0f, 0f, 0f);
		}
	}

	public string BrushName
	{
		get
		{
			if (Properties.TryGetValue("Brush", out var value))
			{
				string text = (string)value;
				int num = text.IndexOf('.');
				return text.Substring(num + 1, text.Length - num - 2);
			}
			return null;
		}
	}

	public T3dBrush Brush => m_T3dMap.BrushModels.FirstOrDefault((T3dBrush b) => b.Name == BrushName);

	public T3dActor(T3dMap map, string @class, string name)
	{
		m_T3dMap = map;
		Class = @class;
		Name = name;
	}

	public override string ToString()
	{
		return "Unreal Engine 1 " + Class + " \"" + Name + "\"";
	}
}
