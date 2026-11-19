using System.Collections.Generic;

namespace JM.LinqFaster.Utils;

internal static class ComparerExtensions
{
	public static IComparer<T> Reverse<T>(this IComparer<T> comparer)
	{
		return new ComparerReverser<T>(comparer);
	}
}
