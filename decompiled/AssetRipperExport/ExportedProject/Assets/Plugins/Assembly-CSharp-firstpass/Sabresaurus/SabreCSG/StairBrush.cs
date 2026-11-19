using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	[ExecuteInEditMode]
	public class StairBrush : CompoundBrush
	{
		[SerializeField]
		private float stepDepth = 0.2f;

		[SerializeField]
		private float stepHeight = 0.1f;

		[SerializeField]
		private float stepDepthSpacing;

		[SerializeField]
		private float stepHeightSpacing;

		[SerializeField]
		private bool autoDepth;

		[SerializeField]
		private bool autoHeight;

		[SerializeField]
		private bool leadFromTop;

		[SerializeField]
		private bool fillToBottom;

		public float StepDepth
		{
			get
			{
				return stepDepth;
			}
			set
			{
				stepDepth = value;
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

		public float StepDepthSpacing
		{
			get
			{
				return stepDepthSpacing;
			}
			set
			{
				stepDepthSpacing = value;
			}
		}

		public float StepHeightSpacing
		{
			get
			{
				return stepHeightSpacing;
			}
			set
			{
				stepHeightSpacing = value;
			}
		}

		public bool AutomaticDepth
		{
			get
			{
				return autoDepth;
			}
			set
			{
				autoDepth = value;
			}
		}

		public bool AutomaticHeight
		{
			get
			{
				return autoDepth;
			}
			set
			{
				autoDepth = value;
			}
		}

		public bool LeadFromTop
		{
			get
			{
				return leadFromTop;
			}
			set
			{
				leadFromTop = value;
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

		public override string BeautifulBrushName
		{
			get
			{
				return "Linear Stairs Brush";
			}
		}

		public override int BrushCount
		{
			get
			{
				int a = 1 + Mathf.FloorToInt((localBounds.size.z - stepDepth + 0.001f) / (stepDepth + stepDepthSpacing));
				int b = 1 + Mathf.FloorToInt((localBounds.size.y - stepHeight + 0.001f) / (stepHeight + stepHeightSpacing));
				return Mathf.Min(a, b);
			}
		}

		public override void UpdateVisibility()
		{
		}

		public override void Invalidate(bool polygonsChanged)
		{
			base.Invalidate(polygonsChanged);
			int brushCount = BrushCount;
			float num = stepHeight;
			float num2 = stepDepth;
			if (autoHeight)
			{
				num = localBounds.size.y / (float)brushCount;
			}
			if (autoDepth)
			{
				num2 = localBounds.size.z / (float)brushCount;
			}
			Vector3 resizeValue = new Vector3(localBounds.size.x, num, num2);
			Vector3 center = localBounds.center;
			if (leadFromTop)
			{
				center.y += resizeValue.y / 2f + localBounds.size.y / 2f - resizeValue.y * (float)brushCount;
				center.z += resizeValue.z / 2f + localBounds.size.z / 2f - resizeValue.z * (float)brushCount;
			}
			else
			{
				center.y += resizeValue.y / 2f - localBounds.size.y / 2f;
				center.z += resizeValue.z / 2f - localBounds.size.z / 2f;
			}
			for (int i = 0; i < brushCount; i++)
			{
				Vector3 localPosition = center + Vector3.forward * i * (num2 + stepDepthSpacing) + Vector3.up * i * (num + stepHeightSpacing) * ((!fillToBottom) ? 1f : 0.5f);
				generatedBrushes[i].transform.localPosition = localPosition;
				generatedBrushes[i].Mode = base.Mode;
				generatedBrushes[i].IsNoCSG = base.IsNoCSG;
				generatedBrushes[i].IsVisible = base.IsVisible;
				generatedBrushes[i].HasCollision = base.HasCollision;
				BrushUtility.Resize(generatedBrushes[i], resizeValue);
				if (fillToBottom)
				{
					resizeValue.y += num + stepHeightSpacing;
				}
			}
		}
	}
}
