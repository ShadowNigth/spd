using System;
using System.Collections.Generic;
using JM.LinqFaster.Utils;

namespace JM.LinqFaster;

public static class LinqFaster
{
	public static TSource AggregateF<TSource>(this TSource[] source, Func<TSource, TSource, TSource> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		TSource val = source[0];
		for (int i = 1; i < source.Length; i++)
		{
			val = func(val, source[i]);
		}
		return val;
	}

	public static TAccumulate AggregateF<TSource, TAccumulate>(this TSource[] source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		TAccumulate val = seed;
		foreach (TSource arg in source)
		{
			val = func(val, arg);
		}
		return val;
	}

	public static TResult AggregateF<TSource, TAccumulate, TResult>(this TSource[] source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		TAccumulate val = seed;
		foreach (TSource arg in source)
		{
			val = func(val, arg);
		}
		return resultSelector(val);
	}

	public static TSource AggregateF<TSource>(this List<TSource> source, Func<TSource, TSource, TSource> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		TSource val = source[0];
		for (int i = 1; i < source.Count; i++)
		{
			val = func(val, source[i]);
		}
		return val;
	}

	public static TAccumulate AggregateF<TSource, TAccumulate>(this List<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		TAccumulate val = seed;
		for (int i = 0; i < source.Count; i++)
		{
			val = func(val, source[i]);
		}
		return val;
	}

	public static TResult AggregateF<TSource, TAccumulate, TResult>(this List<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		TAccumulate val = seed;
		for (int i = 0; i < source.Count; i++)
		{
			val = func(val, source[i]);
		}
		return resultSelector(val);
	}

	public static bool AnyF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Length != 0;
	}

	public static bool AnyF<TSource>(this TSource[] source, Predicate<TSource> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return Array.Exists(source, predicate);
	}

	public static bool AllF<TSource>(this TSource[] source, Predicate<TSource> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return Array.TrueForAll(source, predicate);
	}

	public static bool AnyF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Count > 0;
	}

	public static bool AnyF<TSource>(this List<TSource> source, Predicate<TSource> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Exists(predicate);
	}

	public static bool AllF<TSource>(this List<TSource> source, Predicate<TSource> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.TrueForAll(predicate);
	}

	public static double AverageF(this int[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Length; i++)
			{
				num += source[i];
			}
			return (double)num / (double)source.Length;
		}
	}

	public static double AverageF<T>(this T[] source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Length; i++)
			{
				num += selector(source[i]);
			}
			return (double)num / (double)source.Length;
		}
	}

	public static double AverageF(this long[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Length; i++)
			{
				num += source[i];
			}
			return (double)num / (double)source.Length;
		}
	}

	public static double AverageF<T>(this T[] source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Length; i++)
			{
				num += selector(source[i]);
			}
			return (double)num / (double)source.Length;
		}
	}

	public static float AverageF(this float[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		double num = 0.0;
		for (int i = 0; i < source.Length; i++)
		{
			num += (double)source[i];
		}
		return (float)(num / (double)source.Length);
	}

	public static float AverageF<T>(this T[] source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Length; i++)
		{
			num += (double)selector(source[i]);
		}
		return (float)(num / (double)source.Length);
	}

	public static double AverageF(this double[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		double num = 0.0;
		for (int i = 0; i < source.Length; i++)
		{
			num += source[i];
		}
		return num / (double)source.Length;
	}

	public static double AverageF<T>(this T[] source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Length; i++)
		{
			num += selector(source[i]);
		}
		return num / (double)source.Length;
	}

	public static decimal AverageF(this decimal[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		decimal num = default(decimal);
		for (int i = 0; i < source.Length; i++)
		{
			num += source[i];
		}
		return num / (decimal)source.Length;
	}

	public static decimal AverageF<T>(this T[] source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal num = default(decimal);
		for (int i = 0; i < source.Length; i++)
		{
			num += selector(source[i]);
		}
		return num / (decimal)source.Length;
	}

	public static double AverageF(this List<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += source[i];
			}
			return (double)num / (double)source.Count;
		}
	}

	public static double AverageF<T>(this List<T> source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += selector(source[i]);
			}
			return (double)num / (double)source.Count;
		}
	}

	public static double AverageF(this List<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += source[i];
			}
			return (double)num / (double)source.Count;
		}
	}

	public static double AverageF<T>(this List<T> source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += selector(source[i]);
			}
			return (double)num / (double)source.Count;
		}
	}

	public static float AverageF(this List<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += (double)source[i];
		}
		return (float)(num / (double)source.Count);
	}

	public static float AverageF<T>(this List<T> source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += (double)selector(source[i]);
		}
		return (float)(num / (double)source.Count);
	}

	public static double AverageF(this List<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += source[i];
		}
		return num / (double)source.Count;
	}

	public static double AverageF<T>(this List<T> source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += selector(source[i]);
		}
		return num / (double)source.Count;
	}

	public static decimal AverageF(this List<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		decimal num = default(decimal);
		for (int i = 0; i < source.Count; i++)
		{
			num += source[i];
		}
		return num / (decimal)source.Count;
	}

	public static decimal AverageF<T>(this List<T> source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal num = default(decimal);
		for (int i = 0; i < source.Count; i++)
		{
			num += selector(source[i]);
		}
		return num / (decimal)source.Count;
	}

	public static bool ContainsF<TSource>(this TSource[] source, TSource value, IEqualityComparer<TSource> comparer = null)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (comparer == null)
		{
			return Array.IndexOf(source, value) != -1;
		}
		foreach (TSource x in source)
		{
			if (comparer.Equals(x, value))
			{
				return true;
			}
		}
		return false;
	}

	public static bool ContainsF<TSource>(this List<TSource> source, TSource value, IEqualityComparer<TSource> comparer = null)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (comparer == null)
		{
			return source.IndexOf(value) != -1;
		}
		for (int i = 0; i < source.Count; i++)
		{
			if (comparer.Equals(source[i], value))
			{
				return true;
			}
		}
		return false;
	}

	public static int CountF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public static int CountF<T>(this List<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = 0;
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public static void DistinctInPlaceF<TSource>(this List<TSource> source, IEqualityComparer<TSource> eqComparer = null, IComparer<TSource> comparer = null)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (comparer == null)
		{
			comparer = Comparer<TSource>.Default;
		}
		if (eqComparer == null)
		{
			eqComparer = EqualityComparer<TSource>.Default;
		}
		source.Sort(comparer);
		TSource y = source[0];
		int num = 1;
		for (int i = 1; i < source.Count; i++)
		{
			TSource val2 = (source[num] = source[i]);
			if (!eqComparer.Equals(val2, y))
			{
				num++;
			}
			y = val2;
		}
		source.RemoveRange(num, source.Count - num);
	}

	public static T FirstF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		return source[0];
	}

	public static T FirstF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				return source[i];
			}
		}
		throw Error.NoMatch();
	}

	public static T FirstOrDefaultF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			return default(T);
		}
		return source[0];
	}

	public static T FirstOrDefaultF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				return source[i];
			}
		}
		return default(T);
	}

	public static T FirstF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		return source[0];
	}

	public static T FirstF<T>(this List<T> source, Predicate<T> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = source.FindIndex(predicate);
		if (num == -1)
		{
			throw Error.NoMatch();
		}
		return source[num];
	}

	public static T FirstOrDefaultF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			return default(T);
		}
		return source[0];
	}

	public static T FirstOrDefaultF<T>(this List<T> source, Predicate<T> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = source.FindIndex(predicate);
		if (num == -1)
		{
			return default(T);
		}
		return source[num];
	}

	public static T LastF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		return source[source.Length - 1];
	}

	public static T LastF<T>(this T[] source, Predicate<T> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = Array.FindLastIndex(source, predicate);
		if (num == -1)
		{
			throw Error.NoMatch();
		}
		return source[num];
	}

	public static T LastOrDefaultF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			return default(T);
		}
		return source[source.Length - 1];
	}

	public static T LastOrDefaultF<T>(this T[] source, Predicate<T> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = Array.FindLastIndex(source, predicate);
		if (num == -1)
		{
			return default(T);
		}
		return source[num];
	}

	public static T LastF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		return source[source.Count - 1];
	}

	public static T LastF<T>(this List<T> source, Predicate<T> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = source.FindLastIndex(predicate);
		if (num == -1)
		{
			throw Error.NoMatch();
		}
		return source[num];
	}

	public static T LastOrDefaultF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			return default(T);
		}
		return source[source.Count - 1];
	}

	public static T LastOrDefaultF<T>(this List<T> source, Predicate<T> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = source.FindLastIndex(predicate);
		if (num == -1)
		{
			return default(T);
		}
		return source[num];
	}

	public static T MaxF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		Comparer<T> @default = Comparer<T>.Default;
		T val;
		if (default(T) == null)
		{
			val = source[0];
			for (int i = 1; i < source.Length; i++)
			{
				if (source[i] != null && @default.Compare(source[i], val) > 0)
				{
					val = source[i];
				}
			}
		}
		else
		{
			val = source[0];
			for (int j = 1; j < source.Length; j++)
			{
				if (@default.Compare(source[j], val) > 0)
				{
					val = source[j];
				}
			}
		}
		return val;
	}

	public static TResult MaxF<T, TResult>(this T[] source, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		Comparer<TResult> @default = Comparer<TResult>.Default;
		TResult val;
		if (default(TResult) == null)
		{
			val = selector(source[0]);
			for (int i = 1; i < source.Length; i++)
			{
				TResult val2 = selector(source[i]);
				if (val2 != null && @default.Compare(val2, val) > 0)
				{
					val = val2;
				}
			}
		}
		else
		{
			val = selector(source[0]);
			for (int j = 1; j < source.Length; j++)
			{
				TResult val3 = selector(source[j]);
				if (@default.Compare(val3, val) > 0)
				{
					val = val3;
				}
			}
		}
		return val;
	}

	public static int MaxF(this int[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		int num = int.MinValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] > num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static int MaxF<T>(this T[] source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = int.MinValue;
		for (int i = 0; i < source.Length; i++)
		{
			int num2 = selector(source[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static long MaxF(this long[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		long num = long.MinValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] > num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static long MaxF<T>(this T[] source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = long.MinValue;
		for (int i = 0; i < source.Length; i++)
		{
			long num2 = selector(source[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static float MaxF(this float[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		float num = source[0];
		int i;
		for (i = 0; i < source.Length; i++)
		{
			if (!float.IsNaN(source[i]))
			{
				num = source[i];
				break;
			}
		}
		for (int j = i; j < source.Length; j++)
		{
			if (source[j] > num)
			{
				num = source[j];
			}
		}
		return num;
	}

	public static float MaxF<T>(this T[] source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		float num = selector(source[0]);
		int i;
		for (i = 0; i < source.Length; i++)
		{
			float num2 = selector(source[i]);
			if (!float.IsNaN(num2))
			{
				num = num2;
				break;
			}
		}
		for (int j = i; j < source.Length; j++)
		{
			float num3 = selector(source[j]);
			if (num3 > num)
			{
				num = num3;
			}
		}
		return num;
	}

	public static double MaxF(this double[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		double num = source[0];
		int i;
		for (i = 0; i < source.Length; i++)
		{
			if (!double.IsNaN(source[i]))
			{
				num = source[i];
				break;
			}
		}
		for (int j = i; j < source.Length; j++)
		{
			if (source[j] > num)
			{
				num = source[j];
			}
		}
		return num;
	}

	public static double MaxF<T>(this T[] source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = selector(source[0]);
		int i;
		for (i = 0; i < source.Length; i++)
		{
			double num2 = selector(source[i]);
			if (!double.IsNaN(num2))
			{
				num = num2;
				break;
			}
		}
		for (int j = i; j < source.Length; j++)
		{
			double num3 = selector(source[j]);
			if (num3 > num)
			{
				num = num3;
			}
		}
		return num;
	}

	public static decimal MaxF(this decimal[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		decimal num = decimal.MinValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] > num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static decimal MaxF<T>(this T[] source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal num = decimal.MinValue;
		for (int i = 0; i < source.Length; i++)
		{
			decimal num2 = selector(source[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static T MaxF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		Comparer<T> @default = Comparer<T>.Default;
		T val;
		if (default(T) == null)
		{
			val = source[0];
			for (int i = 1; i < source.Count; i++)
			{
				if (source[i] != null && @default.Compare(source[i], val) > 0)
				{
					val = source[i];
				}
			}
		}
		else
		{
			val = source[0];
			for (int j = 1; j < source.Count; j++)
			{
				if (@default.Compare(source[j], val) > 0)
				{
					val = source[j];
				}
			}
		}
		return val;
	}

	public static TResult MaxF<T, TResult>(this List<T> source, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		Comparer<TResult> @default = Comparer<TResult>.Default;
		TResult val;
		if (default(TResult) == null)
		{
			val = selector(source[0]);
			for (int i = 1; i < source.Count; i++)
			{
				TResult val2 = selector(source[i]);
				if (val2 != null && @default.Compare(val2, val) > 0)
				{
					val = val2;
				}
			}
		}
		else
		{
			val = selector(source[0]);
			for (int j = 1; j < source.Count; j++)
			{
				TResult val3 = selector(source[j]);
				if (@default.Compare(val3, val) > 0)
				{
					val = val3;
				}
			}
		}
		return val;
	}

	public static int MaxF(this List<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		int num = int.MinValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] > num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static int MaxF<T>(this List<T> source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = int.MinValue;
		for (int i = 0; i < source.Count; i++)
		{
			int num2 = selector(source[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static long MaxF(this List<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		long num = long.MinValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] > num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static long MaxF<T>(this List<T> source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = long.MinValue;
		for (int i = 0; i < source.Count; i++)
		{
			long num2 = selector(source[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static float MaxF(this List<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		float num = source[0];
		int i;
		for (i = 0; i < source.Count; i++)
		{
			if (!float.IsNaN(source[i]))
			{
				num = source[i];
				break;
			}
		}
		for (int j = i; j < source.Count; j++)
		{
			if (source[j] > num)
			{
				num = source[j];
			}
		}
		return num;
	}

	public static float MaxF<T>(this List<T> source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		float num = selector(source[0]);
		int i;
		for (i = 0; i < source.Count; i++)
		{
			float num2 = selector(source[i]);
			if (!float.IsNaN(num2))
			{
				num = num2;
				break;
			}
		}
		for (int j = i; j < source.Count; j++)
		{
			float num3 = selector(source[j]);
			if (num3 > num)
			{
				num = num3;
			}
		}
		return num;
	}

	public static double MaxF(this List<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		double num = source[0];
		int i;
		for (i = 0; i < source.Count; i++)
		{
			if (!double.IsNaN(source[i]))
			{
				num = source[i];
				break;
			}
		}
		for (int j = i; j < source.Count; j++)
		{
			if (source[j] > num)
			{
				num = source[j];
			}
		}
		return num;
	}

	public static double MaxF<T>(this List<T> source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = selector(source[0]);
		int i;
		for (i = 0; i < source.Count; i++)
		{
			double num2 = selector(source[i]);
			if (!double.IsNaN(num2))
			{
				num = num2;
				break;
			}
		}
		for (int j = i; j < source.Count; j++)
		{
			double num3 = selector(source[j]);
			if (num3 > num)
			{
				num = num3;
			}
		}
		return num;
	}

	public static decimal MaxF(this List<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		decimal num = decimal.MinValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] > num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static decimal MaxF<T>(this List<T> source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		decimal num = decimal.MinValue;
		for (int i = 0; i < source.Count; i++)
		{
			decimal num2 = selector(source[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static T MinF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		Comparer<T> @default = Comparer<T>.Default;
		T val;
		if (default(T) == null)
		{
			val = source[0];
			for (int i = 1; i < source.Length; i++)
			{
				if (source[i] != null && @default.Compare(source[i], val) < 0)
				{
					val = source[i];
				}
			}
		}
		else
		{
			val = source[0];
			for (int j = 1; j < source.Length; j++)
			{
				if (@default.Compare(source[j], val) < 0)
				{
					val = source[j];
				}
			}
		}
		return val;
	}

	public static TResult MinF<T, TResult>(this T[] source, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		Comparer<TResult> @default = Comparer<TResult>.Default;
		TResult val;
		if (default(TResult) == null)
		{
			val = selector(source[0]);
			for (int i = 1; i < source.Length; i++)
			{
				TResult val2 = selector(source[i]);
				if (val2 != null && @default.Compare(val2, val) < 0)
				{
					val = val2;
				}
			}
		}
		else
		{
			val = selector(source[0]);
			for (int j = 1; j < source.Length; j++)
			{
				TResult val3 = selector(source[j]);
				if (@default.Compare(val3, val) < 0)
				{
					val = val3;
				}
			}
		}
		return val;
	}

	public static int MinF(this int[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		int num = int.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static int MinF<T>(this T[] source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = int.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			int num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static long MinF(this long[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		long num = long.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static long MinF<T>(this T[] source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = long.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			long num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static float MinF(this float[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		float num = float.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
			else if (float.IsNaN(source[i]))
			{
				return source[i];
			}
		}
		return num;
	}

	public static float MinF<T>(this T[] source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		float num = float.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			float num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
			else if (float.IsNaN(num2))
			{
				return num2;
			}
		}
		return num;
	}

	public static double MinF(this double[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		double num = double.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
			else if (double.IsNaN(source[i]))
			{
				return source[i];
			}
		}
		return num;
	}

	public static double MinF<T>(this T[] source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = double.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			double num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
			else if (double.IsNaN(num2))
			{
				return num2;
			}
		}
		return num;
	}

	public static decimal MinF(this decimal[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		decimal num = decimal.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static decimal MinF<T>(this T[] source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal num = decimal.MaxValue;
		for (int i = 0; i < source.Length; i++)
		{
			decimal num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static T MinF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		Comparer<T> @default = Comparer<T>.Default;
		T val;
		if (default(T) == null)
		{
			val = source[0];
			for (int i = 1; i < source.Count; i++)
			{
				if (source[i] != null && @default.Compare(source[i], val) < 0)
				{
					val = source[i];
				}
			}
		}
		else
		{
			val = source[0];
			for (int j = 1; j < source.Count; j++)
			{
				if (@default.Compare(source[j], val) < 0)
				{
					val = source[j];
				}
			}
		}
		return val;
	}

	public static int MinF(this List<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		int num = int.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static int MinF<T>(this List<T> source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = int.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			int num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static long MinF(this List<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		long num = long.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static long MinF<T>(this List<T> source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = long.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			long num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static float MinF(this List<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		float num = float.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
			else if (float.IsNaN(source[i]))
			{
				return source[i];
			}
		}
		return num;
	}

	public static float MinF<T>(this List<T> source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		float num = float.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			float num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
			else if (float.IsNaN(num2))
			{
				return num2;
			}
		}
		return num;
	}

	public static double MinF(this List<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		double num = double.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
			else if (double.IsNaN(source[i]))
			{
				return source[i];
			}
		}
		return num;
	}

	public static double MinF<T>(this List<T> source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = double.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			double num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
			else if (double.IsNaN(num2))
			{
				return num2;
			}
		}
		return num;
	}

	public static decimal MinF(this List<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		decimal num = decimal.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			if (source[i] < num)
			{
				num = source[i];
			}
		}
		return num;
	}

	public static decimal MinF<T>(this List<T> source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		decimal num = decimal.MaxValue;
		for (int i = 0; i < source.Count; i++)
		{
			decimal num2 = selector(source[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static TResult MinF<T, TResult>(this List<T> source, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		Comparer<TResult> @default = Comparer<TResult>.Default;
		TResult val;
		if (default(TResult) == null)
		{
			val = selector(source[0]);
			for (int i = 1; i < source.Count; i++)
			{
				TResult val2 = selector(source[i]);
				if (val2 != null && @default.Compare(val2, val) < 0)
				{
					val = val2;
				}
			}
		}
		else
		{
			val = selector(source[0]);
			for (int j = 1; j < source.Count; j++)
			{
				TResult val3 = selector(source[j]);
				if (@default.Compare(val3, val) < 0)
				{
					val = val3;
				}
			}
		}
		return val;
	}

	public static TSource[] OrderByF<TSource, TKey>(this TSource[] source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer = null)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (comparer == null)
		{
			comparer = Comparer<TKey>.Default;
		}
		TKey[] array = new TKey[source.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = keySelector(source[i]);
		}
		TSource[] array2 = (TSource[])source.Clone();
		Array.Sort(array, array2, comparer);
		return array2;
	}

	public static TSource[] OrderByDescendingF<TSource, TKey>(this TSource[] source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer = null)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (comparer == null)
		{
			comparer = Comparer<TKey>.Default;
		}
		TKey[] array = new TKey[source.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = keySelector(source[i]);
		}
		TSource[] array2 = (TSource[])source.Clone();
		Array.Sort(array, array2, comparer.Reverse());
		return array2;
	}

	public static List<TSource> OrderByF<TSource, TKey>(this List<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer = null)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (comparer == null)
		{
			comparer = Comparer<TKey>.Default;
		}
		List<TSource> list = new List<TSource>(source);
		LambdaComparer<TSource, TKey> comparer2 = new LambdaComparer<TSource, TKey>(keySelector, comparer);
		list.Sort(comparer2);
		return list;
	}

	public static List<TSource> OrderByDescendingF<TSource, TKey>(this List<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer = null)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (comparer == null)
		{
			comparer = Comparer<TKey>.Default;
		}
		List<TSource> list = new List<TSource>(source);
		ReverseLambdaComparer<TSource, TKey> comparer2 = new ReverseLambdaComparer<TSource, TKey>(keySelector, comparer);
		list.Sort(comparer2);
		return list;
	}

	public static int[] RangeArrayF(int start, int count)
	{
		long num = (long)start + (long)count - 1;
		if (count < 0 || num > int.MaxValue)
		{
			throw Error.ArgumentOutOfRange("count");
		}
		int[] array = new int[count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + start;
		}
		return array;
	}

	public static List<int> RangeListF(int start, int count)
	{
		long num = (long)start + (long)count - 1;
		if (count < 0 || num > int.MaxValue)
		{
			throw Error.ArgumentOutOfRange("count");
		}
		List<int> list = new List<int>(count);
		for (int i = 0; i < count; i++)
		{
			list.Add(i + start);
		}
		return list;
	}

	public static T[] RepeatArrayF<T>(T element, int count)
	{
		T[] array = new T[count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = element;
		}
		return array;
	}

	public static List<T> RepeatListF<T>(T element, int count)
	{
		List<T> list = new List<T>(count);
		for (int i = 0; i < count; i++)
		{
			list.Add(element);
		}
		return list;
	}

	public static T[] ReverseF<T>(this T[] source)
	{
		T[] array = new T[source.Length];
		long num = source.Length - 1;
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = source[num - i];
		}
		return array;
	}

	public static void ReverseInPlaceF<T>(this T[] source)
	{
		Array.Reverse(source);
	}

	public static List<T> ReverseF<T>(this List<T> source)
	{
		List<T> list = new List<T>(source.Count);
		for (int num = source.Count - 1; num >= 0; num--)
		{
			list.Add(source[num]);
		}
		return list;
	}

	public static void ReverseInPlaceF<T>(this List<T> source)
	{
		source.Reverse();
	}

	public static void SelectInPlaceF<T>(this T[] source, Func<T, T> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		for (int i = 0; i < source.Length; i++)
		{
			source[i] = selector(source[i]);
		}
	}

	public static void SelectInPlaceF<T>(this T[] source, Func<T, int, T> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		for (int i = 0; i < source.Length; i++)
		{
			source[i] = selector(source[i], i);
		}
	}

	public static TResult[] SelectF<T, TResult>(this T[] source, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		TResult[] array = new TResult[source.Length];
		for (int i = 0; i < source.Length; i++)
		{
			array[i] = selector(source[i]);
		}
		return array;
	}

	public static TResult[] SelectF<T, TResult>(this T[] source, Func<T, int, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		TResult[] array = new TResult[source.Length];
		for (int i = 0; i < source.Length; i++)
		{
			array[i] = selector(source[i], i);
		}
		return array;
	}

	public static void SelectInPlaceF<T>(this List<T> source, Func<T, T> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		for (int i = 0; i < source.Count; i++)
		{
			source[i] = selector(source[i]);
		}
	}

	public static void SelectInPlaceF<T>(this List<T> source, Func<T, int, T> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		for (int i = 0; i < source.Count; i++)
		{
			source[i] = selector(source[i], i);
		}
	}

	public static List<TResult> SelectF<T, TResult>(this List<T> source, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		List<TResult> list = new List<TResult>(source.Count);
		for (int i = 0; i < source.Count; i++)
		{
			list.Add(selector(source[i]));
		}
		return list;
	}

	public static List<TResult> SelectF<T, TResult>(this List<T> source, Func<T, int, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		List<TResult> list = new List<TResult>(source.Count);
		for (int i = 0; i < source.Count; i++)
		{
			list.Add(selector(source[i], i));
		}
		return list;
	}

	public static TResult[] SelectManyF<TSource, TResult>(this TSource[] source, Func<TSource, TResult[]> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		List<TResult> list = new List<TResult>(source.Length);
		for (int i = 0; i < source.Length; i++)
		{
			TResult[] array = selector(source[i]);
			for (int j = 0; j < array.Length; j++)
			{
				list.Add(array[j]);
			}
		}
		return list.ToArray();
	}

	public static TResult[] SelectManyF<TSource, TResult>(this TSource[] source, Func<TSource, int, TResult[]> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		List<TResult> list = new List<TResult>(source.Length);
		for (int i = 0; i < source.Length; i++)
		{
			TResult[] array = selector(source[i], i);
			for (int j = 0; j < array.Length; j++)
			{
				list.Add(array[j]);
			}
		}
		return list.ToArray();
	}

	public static List<TResult> SelectManyF<TSource, TResult>(this List<TSource> source, Func<TSource, List<TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		List<TResult> list = new List<TResult>(source.Count);
		for (int i = 0; i < source.Count; i++)
		{
			List<TResult> list2 = selector(source[i]);
			for (int j = 0; j < list2.Count; j++)
			{
				list.Add(list2[j]);
			}
		}
		return list;
	}

	public static List<TResult> SelectManyF<TSource, TResult>(this List<TSource> source, Func<TSource, int, List<TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		List<TResult> list = new List<TResult>(source.Count);
		for (int i = 0; i < source.Count; i++)
		{
			List<TResult> list2 = selector(source[i], i);
			for (int j = 0; j < list2.Count; j++)
			{
				list.Add(list2[j]);
			}
		}
		return list;
	}

	public static TResult[] SelectWhereF<T, TResult>(this T[] source, Func<T, TResult> selector, Func<TResult, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TResult[] array = new TResult[source.Length];
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			TResult val = selector(source[i]);
			if (predicate(val))
			{
				array[num] = val;
				num++;
			}
		}
		Array.Resize(ref array, num);
		return array;
	}

	public static TResult[] SelectWhereF<T, TResult>(this T[] source, Func<T, int, TResult> selector, Func<TResult, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TResult[] array = new TResult[source.Length];
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			TResult val = selector(source[i], i);
			if (predicate(val, i))
			{
				array[num] = val;
				num++;
			}
		}
		Array.Resize(ref array, num);
		return array;
	}

	public static List<TResult> SelectWhereF<T, TResult>(this List<T> source, Func<T, TResult> selector, Func<TResult, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<TResult> list = new List<TResult>();
		for (int i = 0; i < source.Count; i++)
		{
			TResult val = selector(source[i]);
			if (predicate(val))
			{
				list.Add(val);
			}
		}
		return list;
	}

	public static List<TResult> SelectWhereF<T, TResult>(this List<T> source, Func<T, int, TResult> selector, Func<TResult, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<TResult> list = new List<TResult>();
		for (int i = 0; i < source.Count; i++)
		{
			TResult val = selector(source[i], i);
			if (predicate(val, i))
			{
				list.Add(val);
			}
		}
		return list;
	}

	public static bool SequenceEqualF<T>(T[] first, T[] second, IEqualityComparer<T> comparer = null)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<T>.Default;
		}
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		if (first.Length != second.Length)
		{
			return false;
		}
		for (int i = 0; i < first.Length; i++)
		{
			if (!comparer.Equals(first[i], second[i]))
			{
				return false;
			}
		}
		return true;
	}

	public static bool SequenceEqualF<T>(List<T> first, List<T> second, IEqualityComparer<T> comparer = null)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<T>.Default;
		}
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		if (first.Count != second.Count)
		{
			return false;
		}
		for (int i = 0; i < first.Count; i++)
		{
			if (!comparer.Equals(first[i], second[i]))
			{
				return false;
			}
		}
		return true;
	}

	public static bool SequenceEqualF<T>(T[] first, List<T> second, IEqualityComparer<T> comparer = null)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<T>.Default;
		}
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		if (first.Length != second.Count)
		{
			return false;
		}
		for (int i = 0; i < first.Length; i++)
		{
			if (!comparer.Equals(first[i], second[i]))
			{
				return false;
			}
		}
		return true;
	}

	public static bool SequenceEqualF<T>(List<T> first, T[] second, IEqualityComparer<T> comparer = null)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<T>.Default;
		}
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		if (first.Count != second.Length)
		{
			return false;
		}
		for (int i = 0; i < first.Count; i++)
		{
			if (!comparer.Equals(first[i], second[i]))
			{
				return false;
			}
		}
		return true;
	}

	public static T SingleF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			throw Error.NoElements();
		}
		if (source.Length > 1)
		{
			throw Error.MoreThanOneElement();
		}
		return source[0];
	}

	public static T SingleOrDefaultF<T>(this T[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Length == 0)
		{
			return default(T);
		}
		if (source.Length > 1)
		{
			throw Error.MoreThanOneElement();
		}
		return source[0];
	}

	public static T SingleF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T result = default(T);
		bool flag = false;
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				if (flag)
				{
					throw Error.MoreThanOneMatch();
				}
				result = source[i];
				flag = true;
			}
		}
		if (flag)
		{
			return result;
		}
		throw Error.NoMatch();
	}

	public static T SingleOrDefaultF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T result = default(T);
		bool flag = false;
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				if (flag)
				{
					throw Error.MoreThanOneMatch();
				}
				result = source[i];
				flag = true;
			}
		}
		return result;
	}

	public static T SingleF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			throw Error.NoElements();
		}
		if (source.Count > 1)
		{
			throw Error.MoreThanOneElement();
		}
		return source[0];
	}

	public static T SingleOrDefaultF<T>(this List<T> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source.Count == 0)
		{
			return default(T);
		}
		if (source.Count > 1)
		{
			throw Error.MoreThanOneElement();
		}
		return source[0];
	}

	public static T SingleF<T>(this List<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T result = default(T);
		bool flag = false;
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				if (flag)
				{
					throw Error.MoreThanOneMatch();
				}
				result = source[i];
				flag = true;
			}
		}
		if (flag)
		{
			return result;
		}
		throw Error.NoMatch();
	}

	public static T SingleOrDefaultF<T>(this List<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T result = default(T);
		bool flag = false;
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				if (flag)
				{
					throw Error.MoreThanOneMatch();
				}
				result = source[i];
				flag = true;
			}
		}
		return result;
	}

	public static T[] SkipF<T>(this T[] source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (count < 0)
		{
			count = 0;
		}
		else if (count > source.Length)
		{
			return new T[0];
		}
		T[] array = new T[source.Length - count];
		Array.Copy(source, count, array, 0, array.Length);
		return array;
	}

	public static T[] SkipWhileF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int i;
		for (i = 0; i < source.Length && predicate(source[i]); i++)
		{
		}
		T[] array = new T[source.Length - i];
		Array.Copy(source, i, array, 0, array.Length);
		return array;
	}

	public static List<T> SkipF<T>(this List<T> source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (count < 0)
		{
			count = 0;
		}
		else if (count > source.Count)
		{
			return new List<T>();
		}
		List<T> list = new List<T>(source.Count - count);
		for (int i = count; i < source.Count; i++)
		{
			list.Add(source[i]);
		}
		return list;
	}

	public static List<T> SkipWhileF<T>(this List<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int i;
		for (i = 0; i < source.Count && predicate(source[i]); i++)
		{
		}
		List<T> list = new List<T>(source.Count - i);
		for (; i < source.Count; i++)
		{
			list.Add(source[i]);
		}
		return list;
	}

	public static int SumF(this int[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		foreach (int num2 in source)
		{
			num = checked(num + num2);
		}
		return num;
	}

	public static int SumF<T>(this T[] source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = 0;
		foreach (T arg in source)
		{
			num = checked(num + selector(arg));
		}
		return num;
	}

	public static long SumF(this long[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		foreach (long num2 in source)
		{
			num = checked(num + num2);
		}
		return num;
	}

	public static long SumF<T>(this T[] source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		foreach (T arg in source)
		{
			num = checked(num + selector(arg));
		}
		return num;
	}

	public static float SumF(this float[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (float num2 in source)
		{
			num += (double)num2;
		}
		return (float)num;
	}

	public static float SumF<T>(this T[] source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		foreach (T arg in source)
		{
			num += (double)selector(arg);
		}
		return (float)num;
	}

	public static double SumF(this double[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (double num2 in source)
		{
			num += num2;
		}
		return num;
	}

	public static double SumF<T>(this T[] source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		foreach (T arg in source)
		{
			num += selector(arg);
		}
		return num;
	}

	public static decimal SumF(this decimal[] source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal result = default(decimal);
		foreach (decimal num in source)
		{
			result += num;
		}
		return result;
	}

	public static decimal SumF<T>(this T[] source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal result = default(decimal);
		foreach (T arg in source)
		{
			result += selector(arg);
		}
		return result;
	}

	public static int SumF(this List<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += source[i];
			}
			return num;
		}
	}

	public static int SumF<T>(this List<T> source, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = 0;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += selector(source[i]);
			}
			return num;
		}
	}

	public static long SumF(this List<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += source[i];
			}
			return num;
		}
	}

	public static long SumF<T>(this List<T> source, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				num += selector(source[i]);
			}
			return num;
		}
	}

	public static float SumF(this List<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += (double)source[i];
		}
		return (float)num;
	}

	public static float SumF<T>(this List<T> source, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += (double)selector(source[i]);
		}
		return (float)num;
	}

	public static double SumF(this List<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += source[i];
		}
		return num;
	}

	public static double SumF<T>(this List<T> source, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			num += selector(source[i]);
		}
		return num;
	}

	public static decimal SumF(this List<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal result = default(decimal);
		for (int i = 0; i < source.Count; i++)
		{
			result += source[i];
		}
		return result;
	}

	public static decimal SumF<T>(this List<T> source, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal result = default(decimal);
		for (int i = 0; i < source.Count; i++)
		{
			result += selector(source[i]);
		}
		return result;
	}

	public static T[] TakeF<T>(this T[] source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (count < 0)
		{
			count = 0;
		}
		else if (count > source.Length)
		{
			count = source.Length;
		}
		T[] array = new T[count];
		Array.Copy(source, 0, array, 0, count);
		return array;
	}

	public static T[] TakeWhileF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<T> list = new List<T>();
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				list.Add(source[i]);
				continue;
			}
			return list.ToArray();
		}
		return list.ToArray();
	}

	public static T[] TakeWhileF<T>(this T[] source, Func<T, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<T> list = new List<T>();
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i], i))
			{
				list.Add(source[i]);
				continue;
			}
			return list.ToArray();
		}
		return list.ToArray();
	}

	public static List<T> TakeF<T>(this List<T> source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (count < 0)
		{
			count = 0;
		}
		else if (count > source.Count)
		{
			count = source.Count;
		}
		List<T> list = new List<T>(count);
		for (int i = 0; i < count; i++)
		{
			list.Add(source[i]);
		}
		return list;
	}

	public static List<T> TakeWhileF<T>(this List<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<T> list = new List<T>();
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				list.Add(source[i]);
				continue;
			}
			return list;
		}
		return list;
	}

	public static List<T> TakeWhileF<T>(this List<T> source, Func<T, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<T> list = new List<T>();
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i], i))
			{
				list.Add(source[i]);
				continue;
			}
			return list;
		}
		return list;
	}

	public static T[] WhereF<T>(this T[] source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T[] array = new T[source.Length];
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				array[num] = source[i];
				num++;
			}
		}
		Array.Resize(ref array, num);
		return array;
	}

	public static T[] WhereF<T>(this T[] source, Func<T, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T[] array = new T[source.Length];
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i], i))
			{
				array[num] = source[i];
				num++;
			}
		}
		Array.Resize(ref array, num);
		return array;
	}

	public static List<T> WhereF<T>(this List<T> source, Predicate<T> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.FindAll(predicate);
	}

	public static List<T> WhereF<T>(this List<T> source, Func<T, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<T> list = new List<T>();
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i], i))
			{
				list.Add(source[i]);
			}
		}
		return list;
	}

	public static T WhereAggregateF<T>(this T[] source, Func<T, bool> predicate, Func<T, T, T> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		T val = default(T);
		int i;
		for (i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				val = source[i];
				i++;
				break;
			}
		}
		for (; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				val = func(val, source[i]);
			}
		}
		return val;
	}

	public static T WhereAggregateF<T>(this T[] source, Func<T, int, bool> predicate, Func<T, T, T> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T val = default(T);
		int i;
		for (i = 0; i < source.Length; i++)
		{
			if (predicate(source[i], i))
			{
				val = source[i];
				i++;
				break;
			}
		}
		for (; i < source.Length; i++)
		{
			if (predicate(source[i], i))
			{
				val = func(val, source[i]);
			}
		}
		return val;
	}

	public static TAccumulate WhereAggregateF<TSource, TAccumulate>(this TSource[] source, Func<TSource, bool> predicate, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TAccumulate val = seed;
		foreach (TSource val2 in source)
		{
			if (predicate(val2))
			{
				val = func(val, val2);
			}
		}
		return val;
	}

	public static TResult WhereAggregateF<TSource, TAccumulate, TResult>(this TSource[] source, Func<TSource, bool> predicate, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		TAccumulate val = seed;
		int num = 0;
		foreach (TSource val2 in source)
		{
			if (predicate(val2))
			{
				val = func(val, val2);
				num++;
			}
		}
		return resultSelector(val);
	}

	public static T WhereAggregateF<T>(this List<T> source, Func<T, bool> predicate, Func<T, T, T> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		T val = default(T);
		int i;
		for (i = 0; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				val = source[i];
				i++;
				break;
			}
		}
		for (; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				val = func(val, source[i]);
			}
		}
		return val;
	}

	public static T WhereAggregateF<T>(this List<T> source, Func<T, int, bool> predicate, Func<T, T, T> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		T val = default(T);
		int i;
		for (i = 0; i < source.Count; i++)
		{
			if (predicate(source[i], i))
			{
				val = source[i];
				i++;
				break;
			}
		}
		for (; i < source.Count; i++)
		{
			if (predicate(source[i], i))
			{
				val = func(val, source[i]);
			}
		}
		return val;
	}

	public static TAccumulate WhereAggregateF<TSource, TAccumulate>(this List<TSource> source, Func<TSource, bool> predicate, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TAccumulate val = seed;
		for (int i = 0; i < source.Count; i++)
		{
			TSource val2 = source[i];
			if (predicate(val2))
			{
				val = func(val, val2);
			}
		}
		return val;
	}

	public static TResult WhereAggregateF<TSource, TAccumulate, TResult>(this List<TSource> source, Func<TSource, bool> predicate, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		TAccumulate val = seed;
		for (int i = 0; i < source.Count; i++)
		{
			TSource val2 = source[i];
			if (predicate(val2))
			{
				val = func(val, val2);
			}
		}
		return resultSelector(val);
	}

	public static TResult[] WhereSelectF<T, TResult>(this T[] source, Func<T, bool> predicate, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TResult[] array = new TResult[source.Length];
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i]))
			{
				array[num] = selector(source[i]);
				num++;
			}
		}
		Array.Resize(ref array, num);
		return array;
	}

	public static TResult[] WhereSelectF<T, TResult>(this T[] source, Func<T, int, bool> predicate, Func<T, int, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TResult[] array = new TResult[source.Length];
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			if (predicate(source[i], i))
			{
				array[num] = selector(source[i], num);
				num++;
			}
		}
		Array.Resize(ref array, num);
		return array;
	}

	public static List<TResult> WhereSelectF<T, TResult>(this List<T> source, Func<T, bool> predicate, Func<T, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<TResult> list = new List<TResult>();
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				list.Add(selector(source[i]));
			}
		}
		return list;
	}

	public static List<TResult> WhereSelectF<T, TResult>(this List<T> source, Func<T, int, bool> predicate, Func<T, int, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		List<TResult> list = new List<TResult>();
		int num = 0;
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i], i))
			{
				list.Add(selector(source[i], num));
				num++;
			}
		}
		return list;
	}

	public static int WhereSumF(this int[] source, Func<int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		foreach (int num2 in source)
		{
			if (predicate(num2))
			{
				num = checked(num + num2);
			}
		}
		return num;
	}

	public static int WhereSumF<T>(this T[] source, Func<T, bool> predicate, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = 0;
		foreach (T arg in source)
		{
			if (predicate(arg))
			{
				num = checked(num + selector(arg));
			}
		}
		return num;
	}

	public static long WhereSumF(this long[] source, Func<long, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		foreach (long num2 in source)
		{
			if (predicate(num2))
			{
				num = checked(num + num2);
			}
		}
		return num;
	}

	public static long WhereSumF<T>(this T[] source, Func<T, bool> predicate, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		foreach (T arg in source)
		{
			if (predicate(arg))
			{
				num = checked(num + selector(arg));
			}
		}
		return num;
	}

	public static float WhereSumF(this float[] source, Func<float, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (float num2 in source)
		{
			if (predicate(num2))
			{
				num += (double)num2;
			}
		}
		return (float)num;
	}

	public static float WhereSumF<T>(this T[] source, Func<T, bool> predicate, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		foreach (T arg in source)
		{
			if (predicate(arg))
			{
				num += (double)selector(arg);
			}
		}
		return (float)num;
	}

	public static double WhereSumF(this double[] source, Func<double, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (double num2 in source)
		{
			if (predicate(num2))
			{
				num += num2;
			}
		}
		return num;
	}

	public static double WhereSumF<T>(this T[] source, Func<T, bool> predicate, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		foreach (T arg in source)
		{
			if (predicate(arg))
			{
				num += selector(arg);
			}
		}
		return num;
	}

	public static decimal WhereSumF(this decimal[] source, Func<decimal, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal result = default(decimal);
		foreach (decimal num in source)
		{
			if (predicate(num))
			{
				result += num;
			}
		}
		return result;
	}

	public static decimal WhereSumF<T>(this T[] source, Func<T, bool> predicate, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal result = default(decimal);
		foreach (T arg in source)
		{
			if (predicate(arg))
			{
				result += selector(arg);
			}
		}
		return result;
	}

	public static int WhereSumF(this List<int> source, Func<int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				int num2 = source[i];
				if (predicate(num2))
				{
					num += num2;
				}
			}
			return num;
		}
	}

	public static int WhereSumF<T>(this List<T> source, Func<T, bool> predicate, Func<T, int> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		int num = 0;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				T arg = source[i];
				if (predicate(arg))
				{
					num += selector(arg);
				}
			}
			return num;
		}
	}

	public static long WhereSumF(this List<long> source, Func<long, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				long num2 = source[i];
				if (predicate(num2))
				{
					num += num2;
				}
			}
			return num;
		}
	}

	public static long WhereSumF<T>(this List<T> source, Func<T, bool> predicate, Func<T, long> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		long num = 0L;
		checked
		{
			for (int i = 0; i < source.Count; i++)
			{
				T arg = source[i];
				if (predicate(arg))
				{
					num += selector(arg);
				}
			}
			return num;
		}
	}

	public static float WhereSumF(this List<float> source, Func<float, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			float num2 = source[i];
			if (predicate(num2))
			{
				num += (double)num2;
			}
		}
		return (float)num;
	}

	public static float WhereSumF<T>(this List<T> source, Func<T, bool> predicate, Func<T, float> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			T arg = source[i];
			if (predicate(arg))
			{
				num += (double)selector(arg);
			}
		}
		return (float)num;
	}

	public static double WhereSumF(this List<double> source, Func<double, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			double num2 = source[i];
			if (predicate(num2))
			{
				num += num2;
			}
		}
		return num;
	}

	public static double WhereSumF<T>(this List<T> source, Func<T, bool> predicate, Func<T, double> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		double num = 0.0;
		for (int i = 0; i < source.Count; i++)
		{
			T arg = source[i];
			if (predicate(arg))
			{
				num += selector(arg);
			}
		}
		return num;
	}

	public static decimal WhereSumF(this List<decimal> source, Func<decimal, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal result = default(decimal);
		for (int i = 0; i < source.Count; i++)
		{
			decimal num = source[i];
			if (predicate(num))
			{
				result += num;
			}
		}
		return result;
	}

	public static decimal WhereSumF<T>(this List<T> source, Func<T, bool> predicate, Func<T, decimal> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		decimal result = default(decimal);
		for (int i = 0; i < source.Count; i++)
		{
			T arg = source[i];
			if (predicate(arg))
			{
				result += selector(arg);
			}
		}
		return result;
	}

	public static R[] ZipF<T, U, R>(this T[] first, U[] second, Func<T, U, R> selector)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		if (first.Length < second.Length)
		{
			R[] array = new R[first.Length];
			for (int i = 0; i < first.Length; i++)
			{
				array[i] = selector(first[i], second[i]);
			}
			return array;
		}
		R[] array2 = new R[second.Length];
		for (int j = 0; j < second.Length; j++)
		{
			array2[j] = selector(first[j], second[j]);
		}
		return array2;
	}

	public static List<R> ZipF<T, U, R>(this List<T> first, List<U> second, Func<T, U, R> selector)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		if (first.Count < second.Count)
		{
			List<R> list = new List<R>(first.Count);
			for (int i = 0; i < first.Count; i++)
			{
				list.Add(selector(first[i], second[i]));
			}
			return list;
		}
		List<R> list2 = new List<R>(second.Count);
		for (int j = 0; j < second.Count; j++)
		{
			list2.Add(selector(first[j], second[j]));
		}
		return list2;
	}
}
