using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

[Serializable]
public class WorldTransformData
{
	public Vector3 Position = Vector3.zero;

	public Quaternion Rotation = Quaternion.identity;

	public Vector3 LossyScale = Vector3.one;

	public Transform Parent;

	public int SiblingIndex;

	public WorldTransformData(Transform sourceTransform)
	{
		Position = sourceTransform.position;
		Rotation = sourceTransform.rotation;
		LossyScale = sourceTransform.lossyScale;
		Parent = sourceTransform.parent;
		SiblingIndex = sourceTransform.GetSiblingIndex();
	}

	public bool SetFromTransform(Transform sourceTransform, bool ignoreSiblingChange = false)
	{
		bool result = false;
		if (Position != sourceTransform.position)
		{
			Position = sourceTransform.position;
			result = true;
		}
		if (Rotation != sourceTransform.rotation)
		{
			Rotation = sourceTransform.rotation;
			result = true;
		}
		if (LossyScale != sourceTransform.lossyScale)
		{
			LossyScale = sourceTransform.lossyScale;
			result = true;
		}
		if (Parent != sourceTransform.parent)
		{
			Parent = sourceTransform.parent;
			result = true;
		}
		if (SiblingIndex != sourceTransform.GetSiblingIndex() && !ignoreSiblingChange)
		{
			SiblingIndex = sourceTransform.GetSiblingIndex();
			result = true;
		}
		return result;
	}
}
