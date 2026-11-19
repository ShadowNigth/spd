using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

[ExecuteInEditMode]
public class TrimBrush : CompoundBrush
{
	[SerializeField]
	private float trimSize = 0.25f;

	public float TrimSize
	{
		get
		{
			return trimSize;
		}
		set
		{
			trimSize = value;
		}
	}

	public override string BeautifulBrushName => "Trim Brush";

	public override int BrushCount => (!(localBounds.size.x > trimSize * 2f) || !(localBounds.size.z > trimSize * 2f)) ? 1 : 5;

	public override void UpdateVisibility()
	{
	}

	private Polygon[] GeneratePolys(int index)
	{
		Polygon[] polygons = generatedBrushes[index].GetPolygons();
		float num = Mathf.Cos((float)index * (float)Math.PI * 0.5f);
		float num2 = 0f - Mathf.Sin((float)index * (float)Math.PI * 0.5f);
		Vector3 vector = new Vector3(localBounds.center.x + localBounds.size.x * 0.5f * num + localBounds.size.x * 0.5f * num2, localBounds.max.y, localBounds.center.z + localBounds.size.z * 0.5f * num + localBounds.size.z * 0.5f * num2);
		Vector3 position = vector;
		position.y = localBounds.min.y;
		Vector3 vector2 = new Vector3(localBounds.center.x + localBounds.size.x * 0.5f * num + localBounds.size.x * 0.5f * (0f - num2), localBounds.max.y, localBounds.center.z + localBounds.size.z * 0.5f * (0f - num) + localBounds.size.z * 0.5f * num2);
		Vector3 position2 = vector2;
		position2.y = localBounds.min.y;
		Vector3 vector3 = new Vector3(localBounds.center.x + (localBounds.size.x - trimSize * 2f) * 0.5f * num + (localBounds.size.x - trimSize * 2f) * 0.5f * num2, localBounds.max.y, localBounds.center.z + (localBounds.size.z - trimSize * 2f) * 0.5f * num + (localBounds.size.z - trimSize * 2f) * 0.5f * num2);
		Vector3 position3 = vector3;
		position3.y = localBounds.min.y;
		Vector3 vector4 = new Vector3(localBounds.center.x + (localBounds.size.x - trimSize * 2f) * 0.5f * num + (localBounds.size.x - trimSize * 2f) * 0.5f * (0f - num2), localBounds.max.y, localBounds.center.z + (localBounds.size.z - trimSize * 2f) * 0.5f * (0f - num) + (localBounds.size.z - trimSize * 2f) * 0.5f * num2);
		Vector3 position4 = vector4;
		position4.y = localBounds.min.y;
		polygons[0].Vertices[0].Position = vector;
		polygons[0].Vertices[1].Position = position;
		polygons[0].Vertices[2].Position = position2;
		polygons[0].Vertices[3].Position = vector2;
		polygons[1].Vertices[0].Position = vector3;
		polygons[1].Vertices[1].Position = vector4;
		polygons[1].Vertices[2].Position = position4;
		polygons[1].Vertices[3].Position = position3;
		polygons[2].Vertices[0].Position = vector3;
		polygons[2].Vertices[1].Position = vector;
		polygons[2].Vertices[2].Position = vector2;
		polygons[2].Vertices[3].Position = vector4;
		polygons[3].Vertices[0].Position = position;
		polygons[3].Vertices[1].Position = position3;
		polygons[3].Vertices[2].Position = position4;
		polygons[3].Vertices[3].Position = position2;
		polygons[4].Vertices[0].Position = vector3;
		polygons[4].Vertices[1].Position = position3;
		polygons[4].Vertices[2].Position = position;
		polygons[4].Vertices[3].Position = vector;
		polygons[5].Vertices[0].Position = position4;
		polygons[5].Vertices[1].Position = vector4;
		polygons[5].Vertices[2].Position = vector2;
		polygons[5].Vertices[3].Position = position2;
		for (int i = 0; i < 6; i++)
		{
			if (index % 2 == 1)
			{
				Array.Reverse(polygons[i].Vertices);
			}
			GenerateNormals(polygons[i]);
			GenerateUvCoordinates(polygons[i]);
		}
		return polygons;
	}

	private void GenerateUvCoordinates(Polygon polygon)
	{
		Vector3 normal = polygon.Plane.normal;
		Quaternion quaternion = Quaternion.Inverse(Quaternion.LookRotation(-normal));
		for (int i = 0; i < polygon.Vertices.Length; i++)
		{
			Vector3 position = polygon.Vertices[i].Position;
			Vector2 uV = quaternion * position * 0.5f;
			polygon.Vertices[i].UV = uV;
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
		Vector3 resizeValue;
		if (localBounds.size.x > trimSize * 2f && localBounds.size.z > trimSize * 2f)
		{
			float x = localBounds.size.x - trimSize * 2f;
			float z = localBounds.size.z - trimSize * 2f;
			resizeValue = new Vector3(x, localBounds.size.y, z);
			for (int j = 1; j < BrushCount; j++)
			{
				Vector3 resizeValue2 = default(Vector3);
				if (j % 2 == 0)
				{
					resizeValue2.x = x;
					resizeValue2.z = trimSize;
				}
				else
				{
					resizeValue2.x = trimSize;
					resizeValue2.z = z;
				}
				resizeValue2.y = localBounds.size.y;
				BrushUtility.Resize(generatedBrushes[j], resizeValue2);
				generatedBrushes[j].SetPolygons(GeneratePolys(j));
				generatedBrushes[j].Invalidate(polygonsChanged: true);
			}
		}
		else
		{
			resizeValue = localBounds.size;
		}
		generatedBrushes[0].transform.localPosition = localBounds.center;
		BrushUtility.Resize(generatedBrushes[0], resizeValue);
	}
}
