using System.Collections.Generic;
using System.Linq;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold
{
	public class T3dMap
	{
		public List<T3dActor> Actors = new List<T3dActor>();

		public List<T3dBrush> BrushModels = new List<T3dBrush>();

		public List<T3dActor> Brushes
		{
			get
			{
				return Actors.Where((T3dActor a) => a.Class == "Brush" && a.BrushName != "Brush").ToList();
			}
		}

		public string Title
		{
			get
			{
				if (LevelInfo == null)
				{
					return string.Empty;
				}
				object value;
				if (LevelInfo.Properties.TryGetValue("Title", out value))
				{
					return value as string;
				}
				return string.Empty;
			}
		}

		public string Author
		{
			get
			{
				if (LevelInfo == null)
				{
					return string.Empty;
				}
				object value;
				if (LevelInfo.Properties.TryGetValue("Author", out value))
				{
					return value as string;
				}
				return string.Empty;
			}
		}

		public T3dActor LevelInfo
		{
			get
			{
				return Actors.FirstOrDefault((T3dActor a) => a.Class == "LevelInfo");
			}
		}

		public override string ToString()
		{
			return "Unreal Engine 1 Map \"" + Title + "\"";
		}
	}
}
