using System.Collections.Generic;
using System.Linq;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold
{
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
				object value;
				if (Properties.TryGetValue("Location", out value))
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
				object value;
				if (Properties.TryGetValue("Rotation", out value))
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
				object value;
				if (Properties.TryGetValue("MainScale", out value))
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
				object value;
				if (Properties.TryGetValue("PostScale", out value))
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
				object value;
				if (Properties.TryGetValue("PrePivot", out value))
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
				object value;
				if (Properties.TryGetValue("Brush", out value))
				{
					string text = (string)value;
					int num = text.IndexOf('.');
					return text.Substring(num + 1, text.Length - num - 2);
				}
				return null;
			}
		}

		public T3dBrush Brush
		{
			get
			{
				return m_T3dMap.BrushModels.FirstOrDefault((T3dBrush b) => b.Name == BrushName);
			}
		}

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
}
