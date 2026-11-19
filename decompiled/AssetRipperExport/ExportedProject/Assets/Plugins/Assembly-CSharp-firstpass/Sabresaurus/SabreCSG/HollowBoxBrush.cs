using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	[ExecuteInEditMode]
	public class HollowBoxBrush : CompoundBrush
	{
		[SerializeField]
		private float wallThickness = 0.25f;

		public float WallThickness
		{
			get
			{
				return wallThickness;
			}
			set
			{
				wallThickness = value;
			}
		}

		public override string BeautifulBrushName
		{
			get
			{
				return "Hollow Box Brush";
			}
		}

		public override int BrushCount
		{
			get
			{
				return (!IsBrushXYZTooSmall) ? 1 : 2;
			}
		}

		public bool IsBrushXYZTooSmall
		{
			get
			{
				return localBounds.size.x > wallThickness * 2f && localBounds.size.z > wallThickness * 2f && localBounds.size.y > wallThickness * 2f;
			}
		}

		public override void UpdateVisibility()
		{
		}

		public override void Invalidate(bool polygonsChanged)
		{
			base.Invalidate(polygonsChanged);
			for (int i = 0; i < BrushCount; i++)
			{
				generatedBrushes[i].Mode = base.Mode;
				generatedBrushes[i].IsNoCSG = base.IsNoCSG;
				generatedBrushes[i].IsVisible = base.IsVisible;
				generatedBrushes[i].HasCollision = base.HasCollision;
			}
			if (IsBrushXYZTooSmall)
			{
				generatedBrushes[0].Mode = CSGMode.Add;
				BrushUtility.Resize(generatedBrushes[0], localBounds.size);
				generatedBrushes[1].Mode = CSGMode.Subtract;
				BrushUtility.Resize(generatedBrushes[1], localBounds.size - new Vector3(wallThickness * 2f, wallThickness * 2f, wallThickness * 2f));
				for (int j = 0; j < BrushCount; j++)
				{
					generatedBrushes[j].SetPolygons(GeneratePolys(j));
					generatedBrushes[j].Invalidate(true);
				}
			}
			else
			{
				BrushUtility.Resize(generatedBrushes[0], localBounds.size);
			}
		}

		private Polygon[] GeneratePolys(int index)
		{
			Polygon[] polygons = generatedBrushes[index].GetPolygons();
			for (int i = 0; i < 6; i++)
			{
				polygons[i].ResetVertexNormals();
				polygons[i].GenerateUvCoordinates();
			}
			return polygons;
		}
	}
}
