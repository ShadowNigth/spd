using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public class CSGBuildContext : MonoBehaviour
{
	[Serializable]
	public class BrushPolygonMapping
	{
		[SerializeField]
		public Brush Brush;

		[SerializeField]
		public List<Polygon> Polygons;
	}

	[Serializable]
	public class BuildContext
	{
		[SerializeField]
		public BuildMetrics buildMetrics = new BuildMetrics();

		[SerializeField]
		private List<Polygon> visualPolygons;

		[SerializeField]
		private List<BrushPolygonMapping> visualPolygonMappings = new List<BrushPolygonMapping>();

		[SerializeField]
		public PolygonEntry[] VisualPolygonIndex = new PolygonEntry[0];

		[SerializeField]
		public PolygonEntry[] CollisionPolygonIndex = new PolygonEntry[0];

		public List<Polygon> VisualPolygons => visualPolygons;

		public void SetVisualMapping(Brush brush, List<Polygon> polygons)
		{
			for (int i = 0; i < visualPolygonMappings.Count; i++)
			{
				if (visualPolygonMappings[i].Brush == brush)
				{
					visualPolygonMappings[i].Polygons = polygons;
					return;
				}
			}
			visualPolygonMappings.Add(new BrushPolygonMapping
			{
				Brush = brush,
				Polygons = polygons
			});
		}

		public void WriteVisualMappings()
		{
			if (visualPolygons != null)
			{
				visualPolygons.Clear();
			}
			else
			{
				visualPolygons = new List<Polygon>();
			}
			for (int i = 0; i < visualPolygonMappings.Count; i++)
			{
				if (Brush.IsInvalidForBuild(visualPolygonMappings[i].Brush))
				{
					visualPolygonMappings.RemoveAt(i);
					i--;
				}
				else
				{
					visualPolygons.AddRange(visualPolygonMappings[i].Polygons);
				}
			}
		}

		public void ClearAll()
		{
			VisualPolygonIndex = new PolygonEntry[0];
			CollisionPolygonIndex = new PolygonEntry[0];
			visualPolygons = null;
			visualPolygonMappings = new List<BrushPolygonMapping>();
		}
	}

	[SerializeField]
	private BuildContext buildContext = new BuildContext();

	public BuildContext GetBuildContext()
	{
		return buildContext;
	}
}
