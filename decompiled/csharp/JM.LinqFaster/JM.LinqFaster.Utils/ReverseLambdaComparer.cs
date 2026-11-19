using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JM.LinqFaster.Utils;

internal sealed class ReverseLambdaComparer<T, U> : IComparer<T>
{
	private IComparer<U> comparer;

	private Func<T, U> selector;

	public ReverseLambdaComparer(Func<T, U> selector, IComparer<U> comparer)
	{
		this.comparer = comparer;
		this.selector = selector;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int Compare(T x, T y)
	{
		return comparer.Compare(selector(y), selector(x));
	}
}
