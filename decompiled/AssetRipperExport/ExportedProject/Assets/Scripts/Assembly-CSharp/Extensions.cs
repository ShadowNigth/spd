using System.Collections;
using UnityEngine;

public static class Extensions
{
	public static bool Contains(this int[] target, int nr)
	{
		if (target == null)
		{
			return false;
		}
		foreach (int num in target)
		{
			if (num == nr)
			{
				return true;
			}
		}
		return false;
	}

	public static bool AlmostEquals(this Vector3 target, Vector3 second, float sqrMagniturePrecision)
	{
		return (target - second).sqrMagnitude < sqrMagniturePrecision;
	}

	public static bool AlmostEquals(this Quaternion target, Quaternion second, float maxAngle)
	{
		return Quaternion.Dot(target, second) < maxAngle;
	}

	public static void Merge(this IDictionary target, IDictionary addHash)
	{
		if (addHash == null)
		{
			return;
		}
		foreach (object key in addHash.Keys)
		{
			target[key] = addHash[key];
		}
	}

	public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
	{
		if (addHash == null)
		{
			return;
		}
		foreach (object key in addHash.Keys)
		{
			if (key is string)
			{
				target[key] = addHash[key];
			}
		}
	}

	public static Hashtable StripToStringKeys(this IDictionary original)
	{
		Hashtable hashtable = new Hashtable();
		foreach (DictionaryEntry item in original)
		{
			if (item.Key is string)
			{
				hashtable[item.Key] = item.Value;
			}
		}
		return hashtable;
	}
}
