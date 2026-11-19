using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

[Serializable]
public class TransformData
{
	public Vector3 LocalPosition = Vector3.zero;

	public Quaternion LocalRotation = Quaternion.identity;

	public Vector3 LocalScale = Vector3.one;

	public Transform Parent;

	public int SiblingIndex;

	public TransformData(Transform sourceTransform)
	{
		LocalPosition = sourceTransform.localPosition;
		LocalRotation = sourceTransform.localRotation;
		LocalScale = sourceTransform.localScale;
		Parent = sourceTransform.parent;
		SiblingIndex = sourceTransform.GetSiblingIndex();
	}

	public bool SetFromTransform(Transform sourceTransform, bool ignoreSiblingChange = false)
	{
		bool result = false;
		if (LocalPosition != sourceTransform.localPosition)
		{
			LocalPosition = sourceTransform.localPosition;
			result = true;
		}
		if (LocalRotation != sourceTransform.localRotation)
		{
			LocalRotation = sourceTransform.localRotation;
			result = true;
		}
		if (LocalScale != sourceTransform.localScale)
		{
			LocalScale = sourceTransform.localScale;
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
