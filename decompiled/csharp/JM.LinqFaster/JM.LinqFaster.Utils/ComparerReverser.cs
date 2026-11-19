using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JM.LinqFaster.Utils;

internal sealed class ComparerReverser<T> : IComparer<T>
{
	private readonly IComparer<T> wrappedComparer;

	public ComparerReverser(IComparer<T> wrappedComparer)
	{
		this.wrappedComparer = wrappedComparer;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int Compare(T x, T y)
	{
		return wrappedComparer.Compare(y, x);
	}
}
