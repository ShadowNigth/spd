using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

[ExecuteInEditMode]
public class GroupBrush : BrushBase
{
	[SerializeField]
	protected Bounds localBounds = new Bounds(Vector3.zero, new Vector3(2f, 2f, 2f));

	private Vector3 m_LastKnownExtents;

	private Vector3 m_LastKnownPosition;

	public override bool SupportsCsgOperations => false;

	public override string BeautifulBrushName => "Group";

	protected override void Awake()
	{
		base.Awake();
		m_LastKnownExtents = localBounds.extents;
		m_LastKnownPosition = base.transform.localPosition;
	}

	public override Bounds GetBounds()
	{
		return localBounds;
	}

	public override Bounds GetBoundsLocalTo(Transform otherTransform)
	{
		Vector3[] array = new Vector3[8];
		for (int i = 0; i < 8; i++)
		{
			Vector3 center = localBounds.center;
			Vector3 extents = localBounds.extents;
			if (i % 2 == 0)
			{
				extents.x = 0f - extents.x;
			}
			if (i % 4 < 2)
			{
				extents.y = 0f - extents.y;
			}
			if (i % 8 < 4)
			{
				extents.z = 0f - extents.z;
			}
			center += extents;
			center = otherTransform.InverseTransformPoint(base.transform.TransformPoint(center));
			array[i] = center;
		}
		Bounds result = new Bounds(array[0], Vector3.zero);
		for (int j = 1; j < 8; j++)
		{
			result.Encapsulate(array[j]);
		}
		return result;
	}

	public override Bounds GetBoundsTransformed()
	{
		Vector3[] array = new Vector3[8];
		for (int i = 0; i < 8; i++)
		{
			Vector3 center = localBounds.center;
			Vector3 extents = localBounds.extents;
			if (i % 2 == 0)
			{
				extents.x = 0f - extents.x;
			}
			if (i % 4 < 2)
			{
				extents.y = 0f - extents.y;
			}
			if (i % 8 < 4)
			{
				extents.z = 0f - extents.z;
			}
			center += extents;
			center = base.transform.TransformPoint(center);
			array[i] = center;
		}
		Bounds result = new Bounds(array[0], Vector3.zero);
		for (int j = 1; j < 8; j++)
		{
			result.Encapsulate(array[j]);
		}
		return result;
	}

	public override void OnUndoRedoPerformed()
	{
	}

	public override void SetBounds(Bounds newBounds)
	{
		localBounds.center = Vector3.zero;
		localBounds.extents = newBounds.extents;
		base.transform.Translate(newBounds.center);
	}

	public override void UpdateVisibility()
	{
	}

	public override void Invalidate(bool polygonsChanged)
	{
		if (m_LastKnownExtents != localBounds.extents && m_LastKnownPosition != Vector3.zero)
		{
			base.transform.localPosition = m_LastKnownPosition;
		}
		Bounds bounds = default(Bounds);
		foreach (Transform item in base.transform)
		{
			BrushBase component = item.GetComponent<BrushBase>();
			if (!(component == null))
			{
				component.Invalidate(polygonsChanged);
				bounds.Encapsulate(component.GetBoundsLocalTo(base.transform));
			}
		}
		localBounds = bounds;
		m_LastKnownExtents = localBounds.extents;
		m_LastKnownPosition = base.transform.localPosition;
		base.Invalidate(polygonsChanged);
	}

	protected override void Update()
	{
		base.Update();
		Bounds bounds = default(Bounds);
		foreach (Transform item in base.transform)
		{
			BrushBase component = item.GetComponent<BrushBase>();
			if (!(component == null))
			{
				bounds.Encapsulate(component.GetBoundsLocalTo(base.transform));
			}
		}
		localBounds = bounds;
		UpdateGeneratedHierarchyName();
	}

	public Polygon[] GetPolygons()
	{
		List<Polygon> list = new List<Polygon>();
		foreach (BrushBase item in from c in GetComponentsInChildren<BrushBase>()
			where c.transform != base.transform
			select c)
		{
			Polygon[] polygons;
			if (item is PrimitiveBrush)
			{
				polygons = ((PrimitiveBrush)item).GetPolygons();
			}
			else if (item is CompoundBrush)
			{
				polygons = ((CompoundBrush)item).GetPolygons();
			}
			else
			{
				if (!(item is GroupBrush))
				{
					continue;
				}
				polygons = ((GroupBrush)item).GetPolygons();
			}
			list.AddRange(GenerateTransformedPolygons(item.transform, polygons));
		}
		return list.ToArray();
	}

	private Polygon[] GenerateTransformedPolygons(Transform t, Polygon[] polygons)
	{
		Polygon[] array = polygons.DeepCopy();
		Vector3 localPosition = t.localPosition;
		Quaternion localRotation = t.localRotation;
		Vector3 lossyScale = t.lossyScale;
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array[i].Vertices.Length; j++)
			{
				array[i].Vertices[j].Position = localRotation * array[i].Vertices[j].Position.Multiply(lossyScale) + localPosition;
				array[i].Vertices[j].Normal = localRotation * array[i].Vertices[j].Normal;
			}
			array[i].CalculatePlane();
		}
		return array;
	}
}
