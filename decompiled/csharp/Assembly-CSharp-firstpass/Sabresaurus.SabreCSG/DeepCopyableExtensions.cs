using System.Collections.Generic;

namespace Sabresaurus.SabreCSG;

public static class DeepCopyableExtensions
{
	public static T[] DeepCopy<T>(this T[] sourceArray) where T : IDeepCopyable<T>
	{
		T[] array = new T[sourceArray.Length];
		for (int i = 0; i < sourceArray.Length; i++)
		{
			array[i] = sourceArray[i].DeepCopy();
		}
		return array;
	}

	public static List<T> DeepCopy<T>(this List<T> sourceList) where T : IDeepCopyable<T>
	{
		List<T> list = new List<T>(sourceList.Count);
		for (int i = 0; i < sourceList.Count; i++)
		{
			list.Add(sourceList[i].DeepCopy());
		}
		return list;
	}

	public static IEnumerable<T> Clone<T>(this IEnumerable<T> sourceItems) where T : IDeepCopyable<T>
	{
		foreach (T sourceItem in sourceItems)
		{
			yield return sourceItem.DeepCopy();
		}
	}
}
