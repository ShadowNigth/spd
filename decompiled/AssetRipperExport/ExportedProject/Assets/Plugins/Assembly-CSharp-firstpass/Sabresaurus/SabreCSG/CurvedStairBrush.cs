using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	[ExecuteInEditMode]
	public class CurvedStairBrush : CompoundBrush
	{
		[SerializeField]
		private float innerRadius = 1f;

		[SerializeField]
		private float stepHeight = 0.0625f;

		[SerializeField]
		private float stepWidth = 1f;

		[SerializeField]
		private float angleOfCurve = 90f;

		[SerializeField]
		private int numSteps = 4;

		[SerializeField]
		private float addToFirstStep;

		[SerializeField]
		private bool counterClockwise;

		[SerializeField]
		private bool fillToBottom = true;

		[SerializeField]
		private bool curvedWall;

		[SerializeField]
		private bool slopedFloor;

		[SerializeField]
		private bool slopedCeiling;

		private Vector3 m_LastKnownExtents;

		private Vector3 m_LastKnownPosition;

		public float InnerRadius
		{
			get
			{
				return innerRadius;
			}
			set
			{
				innerRadius = value;
			}
		}

		public float StepHeight
		{
			get
			{
				return stepHeight;
			}
			set
			{
				stepHeight = value;
			}
		}

		public float StepWidth
		{
			get
			{
				return stepWidth;
			}
			set
			{
				stepWidth = value;
			}
		}

		public float AngleOfCurve
		{
			get
			{
				return angleOfCurve;
			}
			set
			{
				angleOfCurve = value;
			}
		}

		public int NumberOfSteps
		{
			get
			{
				return numSteps;
			}
			set
			{
				numSteps = value;
			}
		}

		public float AddToFirstStep
		{
			get
			{
				return addToFirstStep;
			}
			set
			{
				addToFirstStep = value;
			}
		}

		public bool CounterClockwise
		{
			get
			{
				return counterClockwise;
			}
			set
			{
				counterClockwise = value;
			}
		}

		public bool FillToBottom
		{
			get
			{
				return fillToBottom;
			}
			set
			{
				fillToBottom = value;
			}
		}

		public bool CurvedWall
		{
			get
			{
				return curvedWall;
			}
			set
			{
				curvedWall = value;
			}
		}

		public bool SlopedFloor
		{
			get
			{
				return slopedFloor;
			}
			set
			{
				slopedFloor = value;
			}
		}

		public bool SlopedCeiling
		{
			get
			{
				return slopedCeiling;
			}
			set
			{
				slopedCeiling = value;
			}
		}

		public override string BeautifulBrushName
		{
			get
			{
				return "Curved Stairs Brush";
			}
		}

		public override int BrushCount
		{
			get
			{
				return numSteps;
			}
		}

		protected override void Awake()
		{
			base.Awake();
			m_LastKnownExtents = localBounds.extents;
			m_LastKnownPosition = base.transform.localPosition;
		}

		public override void UpdateVisibility()
		{
		}

		public override void Invalidate(bool polygonsChanged)
		{
			base.Invalidate(polygonsChanged);
			if (m_LastKnownExtents != localBounds.extents)
			{
				base.transform.localPosition = m_LastKnownPosition;
				if (localBounds.extents.y > m_LastKnownExtents.y)
				{
					numSteps++;
					m_LastKnownExtents = localBounds.extents;
					Invalidate(true);
					return;
				}
				if (localBounds.extents.y < m_LastKnownExtents.y)
				{
					numSteps--;
					if (numSteps < 1)
					{
						numSteps = 1;
					}
					m_LastKnownExtents = localBounds.extents;
					Invalidate(true);
					return;
				}
			}
			List<Vector3> list = new List<Vector3>();
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			vector.z = angleOfCurve / (float)numSteps;
			if (counterClockwise)
			{
				vector.z *= -1f;
			}
			int count = list.Count;
			vector2.x = innerRadius;
			for (int i = 0; i < numSteps + 1; i++)
			{
				float num = ((i != 0) ? 0f : addToFirstStep);
				vector3 = Quaternion.Euler(vector * i) * vector2;
				list.Add(new Vector3(vector3.x, vector2.z - num, vector3.y));
				if (curvedWall)
				{
					vector2.z = stepHeight * (float)numSteps;
				}
				else
				{
					vector2.z += stepHeight;
				}
				list.Add(new Vector3(vector3.x, vector2.z, vector3.y));
			}
			int count2 = list.Count;
			vector2.x = innerRadius + stepWidth;
			vector2.z = 0f;
			for (int j = 0; j < numSteps + 1; j++)
			{
				float num = ((j != 0) ? 0f : addToFirstStep);
				vector3 = Quaternion.Euler(vector * j) * vector2;
				list.Add(new Vector3(vector3.x, vector2.z - num, vector3.y));
				if (curvedWall)
				{
					vector2.z = stepHeight * (float)numSteps;
				}
				else
				{
					vector2.z += stepHeight;
				}
				list.Add(new Vector3(vector3.x, vector2.z, vector3.y));
			}
			int count3 = list.Count;
			vector2.x = innerRadius;
			vector2.z = 0f;
			for (int k = 0; k < numSteps + 1; k++)
			{
				vector3 = Quaternion.Euler(vector * k) * vector2;
				list.Add(new Vector3(vector3.x, vector2.z - addToFirstStep, vector3.y));
			}
			int count4 = list.Count;
			vector2.x = innerRadius + stepWidth;
			for (int l = 0; l < numSteps + 1; l++)
			{
				vector3 = Quaternion.Euler(vector * l) * vector2;
				list.Add(new Vector3(vector3.x, vector2.z - addToFirstStep, vector3.y));
			}
			int num2 = 0;
			int num3 = 1;
			int num4 = 2;
			int num5 = 3;
			if (counterClockwise)
			{
				num2 = 2;
				num3 = 1;
				num4 = 0;
				num5 = 3;
			}
			if (curvedWall)
			{
				slopedFloor = false;
				slopedCeiling = false;
			}
			if (fillToBottom)
			{
				slopedCeiling = false;
			}
			if (slopedFloor || slopedCeiling)
			{
				base.IsNoCSG = true;
			}
			Bounds bounds = default(Bounds);
			int brushCount = BrushCount;
			for (int m = 0; m < brushCount; m++)
			{
				generatedBrushes[m].Mode = base.Mode;
				generatedBrushes[m].IsNoCSG = base.IsNoCSG;
				generatedBrushes[m].IsVisible = base.IsVisible;
				generatedBrushes[m].HasCollision = base.HasCollision;
				Polygon[] polygons = generatedBrushes[m].GetPolygons();
				Vertex[] vertices = polygons[5].Vertices;
				if (slopedFloor)
				{
					vertices[num2].Position = list[count2 + m * 2 + 2 + 1];
					vertices[num3].Position = list[count2 + m * 2 + 1];
					vertices[num4].Position = list[count + m * 2 + 1];
					vertices[num5].Position = list[count + m * 2 + 2 + 1];
				}
				else
				{
					vertices[num2].Position = list[count2 + m * 2 + 2];
					vertices[num3].Position = list[count2 + m * 2 + 1];
					vertices[num4].Position = list[count + m * 2 + 1];
					vertices[num5].Position = list[count + m * 2 + 2];
				}
				GenerateNormals(polygons[5]);
				GenerateUvCoordinates(polygons[5]);
				vertices = polygons[3].Vertices;
				if (fillToBottom)
				{
					vertices[num2].Position = list[count2 + m * 2 + 1];
					vertices[num3].Position = list[count4 + m];
					vertices[num4].Position = list[count3 + m];
					vertices[num5].Position = list[count + m * 2 + 1];
				}
				else
				{
					vertices[num2].Position = list[count2 + m * 2 + 1];
					vertices[num3].Position = list[count2 + m * 2 + 1] - new Vector3(0f, stepHeight, 0f);
					vertices[num4].Position = list[count + m * 2 + 1] - new Vector3(0f, stepHeight, 0f);
					vertices[num5].Position = list[count + m * 2 + 1];
				}
				if (slopedCeiling)
				{
					vertices[num3].Position -= new Vector3(0f, stepHeight, 0f);
					vertices[num4].Position -= new Vector3(0f, stepHeight, 0f);
				}
				GenerateNormals(polygons[3]);
				GenerateUvCoordinates(polygons[3]);
				vertices = polygons[1].Vertices;
				if (fillToBottom)
				{
					vertices[num2].Position = list[count3 + m + 1];
					vertices[num3].Position = list[count + m * 2 + 2];
					vertices[num4].Position = list[count + m * 2 + 1];
					vertices[num5].Position = list[count3 + m];
				}
				else
				{
					vertices[num2].Position = list[count + m * 2 + 2] - new Vector3(0f, stepHeight, 0f);
					vertices[num3].Position = list[count + m * 2 + 2];
					vertices[num4].Position = list[count + m * 2 + 1];
					vertices[num5].Position = list[count + m * 2 + 1] - new Vector3(0f, stepHeight, 0f);
				}
				if (slopedFloor)
				{
					vertices[num3].Position = list[count + m * 2 + 2 + 1];
				}
				if (slopedCeiling)
				{
					vertices[num5].Position = list[count + m * 2 + 1] - new Vector3(0f, stepHeight * 2f, 0f);
				}
				GenerateNormals(polygons[1]);
				GenerateUvCoordinates(polygons[1]);
				vertices = polygons[2].Vertices;
				if (fillToBottom)
				{
					vertices[num2].Position = list[count2 + m * 2 + 2];
					vertices[num3].Position = list[count4 + m + 1];
					vertices[num4].Position = list[count4 + m];
					vertices[num5].Position = list[count2 + m * 2 + 1];
				}
				else
				{
					vertices[num2].Position = list[count2 + m * 2 + 2];
					vertices[num3].Position = list[count2 + m * 2 + 2] - new Vector3(0f, stepHeight, 0f);
					vertices[num4].Position = list[count2 + m * 2 + 1] - new Vector3(0f, stepHeight, 0f);
					vertices[num5].Position = list[count2 + m * 2 + 1];
				}
				if (slopedFloor)
				{
					vertices[num2].Position = list[count2 + m * 2 + 2 + 1];
				}
				if (slopedCeiling)
				{
					vertices[num4].Position = list[count2 + m * 2 + 1] - new Vector3(0f, stepHeight * 2f, 0f);
				}
				GenerateNormals(polygons[2]);
				GenerateUvCoordinates(polygons[2]);
				vertices = polygons[4].Vertices;
				if (fillToBottom)
				{
					vertices[num2].Position = list[count4 + m];
					vertices[num3].Position = list[count4 + m + 1];
					vertices[num4].Position = list[count3 + m + 1];
					vertices[num5].Position = list[count3 + m];
				}
				else
				{
					vertices[num2].Position = list[count2 + m * 2 + 1] - new Vector3(0f, stepHeight, 0f);
					vertices[num3].Position = list[count2 + m * 2 + 2] - new Vector3(0f, stepHeight, 0f);
					vertices[num4].Position = list[count + m * 2 + 2] - new Vector3(0f, stepHeight, 0f);
					vertices[num5].Position = list[count + m * 2 + 1] - new Vector3(0f, stepHeight, 0f);
				}
				if (slopedCeiling)
				{
					vertices[num2].Position = list[count2 + m * 2 + 1] - new Vector3(0f, stepHeight * 2f, 0f);
					vertices[num5].Position = list[count + m * 2 + 1] - new Vector3(0f, stepHeight * 2f, 0f);
				}
				GenerateNormals(polygons[4]);
				GenerateUvCoordinates(polygons[4]);
				vertices = polygons[0].Vertices;
				if (fillToBottom)
				{
					vertices[num2].Position = list[count4 + m + 1];
					vertices[num3].Position = list[count2 + m * 2 + 2];
					vertices[num4].Position = list[count + m * 2 + 2];
					vertices[num5].Position = list[count3 + m + 1];
				}
				else
				{
					vertices[num2].Position = list[count2 + m * 2 + 2] - new Vector3(0f, stepHeight, 0f);
					vertices[num3].Position = list[count2 + m * 2 + 2];
					vertices[num4].Position = list[count + m * 2 + 2];
					vertices[num5].Position = list[count + m * 2 + 2] - new Vector3(0f, stepHeight, 0f);
				}
				if (slopedFloor)
				{
					vertices[num3].Position = list[count2 + m * 2 + 2 + 1];
					vertices[num4].Position = list[count + m * 2 + 2 + 1];
				}
				GenerateNormals(polygons[0]);
				GenerateUvCoordinates(polygons[0]);
				generatedBrushes[m].Invalidate(true);
				bounds.Encapsulate(generatedBrushes[m].GetBounds());
			}
			localBounds = bounds;
			m_LastKnownExtents = localBounds.extents;
			m_LastKnownPosition = base.transform.localPosition;
			UpdateGeneratedHierarchyName();
		}

		private void GenerateUvCoordinates(Polygon polygon)
		{
			Vertex[] vertices = polygon.Vertices;
			foreach (Vertex vertex in vertices)
			{
				vertex.UV = GeometryHelper.GetUVForPosition(polygon, vertex.Position);
			}
		}

		private void GenerateNormals(Polygon polygon)
		{
			Plane plane = new Plane(polygon.Vertices[1].Position, polygon.Vertices[2].Position, polygon.Vertices[3].Position);
			Vertex[] vertices = polygon.Vertices;
			foreach (Vertex vertex in vertices)
			{
				vertex.Normal = plane.normal;
			}
		}
	}
}
