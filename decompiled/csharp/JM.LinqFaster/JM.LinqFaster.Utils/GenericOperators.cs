using System;
using System.Runtime.CompilerServices;

namespace JM.LinqFaster.Utils;

internal static class GenericOperators
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Add<T>(T a, T b)
	{
		if (typeof(T) == typeof(byte))
		{
			return (T)(object)((byte)(object)a + (byte)(object)b);
		}
		if (typeof(T) == typeof(sbyte))
		{
			return (T)(object)((sbyte)(object)a + (sbyte)(object)b);
		}
		if (typeof(T) == typeof(ushort))
		{
			return (T)(object)((ushort)(object)a + (ushort)(object)b);
		}
		if (typeof(T) == typeof(short))
		{
			return (T)(object)((short)(object)a + (short)(object)b);
		}
		if (typeof(T) == typeof(uint))
		{
			return (T)(object)((uint)(object)a + (uint)(object)b);
		}
		if (typeof(T) == typeof(int))
		{
			return (T)(object)((int)(object)a + (int)(object)b);
		}
		if (typeof(T) == typeof(ulong))
		{
			return (T)(object)((ulong)(object)a + (ulong)(object)b);
		}
		if (typeof(T) == typeof(long))
		{
			return (T)(object)((long)(object)a + (long)(object)b);
		}
		if (typeof(T) == typeof(float))
		{
			return (T)(object)((float)(object)a + (float)(object)b);
		}
		if (typeof(T) == typeof(double))
		{
			return (T)(object)((double)(object)a + (double)(object)b);
		}
		throw new NotSupportedException("Nope");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool GreaterThan<T>(T a, T b)
	{
		if (typeof(T) == typeof(byte))
		{
			return (byte)(object)a > (byte)(object)b;
		}
		if (typeof(T) == typeof(sbyte))
		{
			return (sbyte)(object)a > (sbyte)(object)b;
		}
		if (typeof(T) == typeof(ushort))
		{
			return (ushort)(object)a > (ushort)(object)b;
		}
		if (typeof(T) == typeof(short))
		{
			return (short)(object)a > (short)(object)b;
		}
		if (typeof(T) == typeof(uint))
		{
			return (uint)(object)a > (uint)(object)b;
		}
		if (typeof(T) == typeof(int))
		{
			return (int)(object)a > (int)(object)b;
		}
		if (typeof(T) == typeof(ulong))
		{
			return (ulong)(object)a > (ulong)(object)b;
		}
		if (typeof(T) == typeof(long))
		{
			return (long)(object)a > (long)(object)b;
		}
		if (typeof(T) == typeof(float))
		{
			return (float)(object)a > (float)(object)b;
		}
		if (typeof(T) == typeof(double))
		{
			return (double)(object)a > (double)(object)b;
		}
		throw new NotSupportedException("Nope");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Equals<T>(T a, T b)
	{
		if (typeof(T) == typeof(byte))
		{
			return (byte)(object)a == (byte)(object)b;
		}
		if (typeof(T) == typeof(sbyte))
		{
			return (sbyte)(object)a == (sbyte)(object)b;
		}
		if (typeof(T) == typeof(ushort))
		{
			return (ushort)(object)a == (ushort)(object)b;
		}
		if (typeof(T) == typeof(short))
		{
			return (short)(object)a == (short)(object)b;
		}
		if (typeof(T) == typeof(uint))
		{
			return (uint)(object)a == (uint)(object)b;
		}
		if (typeof(T) == typeof(int))
		{
			return (int)(object)a == (int)(object)b;
		}
		if (typeof(T) == typeof(ulong))
		{
			return (ulong)(object)a == (ulong)(object)b;
		}
		if (typeof(T) == typeof(long))
		{
			return (long)(object)a == (long)(object)b;
		}
		if (typeof(T) == typeof(float))
		{
			return (float)(object)a == (float)(object)b;
		}
		if (typeof(T) == typeof(double))
		{
			return (double)(object)a == (double)(object)b;
		}
		throw new NotSupportedException("Nope");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool LessThan<T>(T a, T b)
	{
		if (typeof(T) == typeof(byte))
		{
			return (byte)(object)a < (byte)(object)b;
		}
		if (typeof(T) == typeof(sbyte))
		{
			return (sbyte)(object)a < (sbyte)(object)b;
		}
		if (typeof(T) == typeof(ushort))
		{
			return (ushort)(object)a < (ushort)(object)b;
		}
		if (typeof(T) == typeof(short))
		{
			return (short)(object)a < (short)(object)b;
		}
		if (typeof(T) == typeof(uint))
		{
			return (uint)(object)a < (uint)(object)b;
		}
		if (typeof(T) == typeof(int))
		{
			return (int)(object)a < (int)(object)b;
		}
		if (typeof(T) == typeof(ulong))
		{
			return (ulong)(object)a < (ulong)(object)b;
		}
		if (typeof(T) == typeof(long))
		{
			return (long)(object)a < (long)(object)b;
		}
		if (typeof(T) == typeof(float))
		{
			return (float)(object)a < (float)(object)b;
		}
		if (typeof(T) == typeof(double))
		{
			return (double)(object)a < (double)(object)b;
		}
		throw new NotSupportedException("Nope");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Divide<T>(T a, double b)
	{
		if (typeof(T) == typeof(byte))
		{
			return (double)(object)((double)(int)(byte)(object)a / b);
		}
		if (typeof(T) == typeof(sbyte))
		{
			return (double)(object)((double)(sbyte)(object)a / b);
		}
		if (typeof(T) == typeof(ushort))
		{
			return (double)(object)((double)(int)(ushort)(object)a / b);
		}
		if (typeof(T) == typeof(short))
		{
			return (double)(object)((double)(short)(object)a / b);
		}
		if (typeof(T) == typeof(uint))
		{
			return (double)(object)((double)(uint)(object)a / b);
		}
		if (typeof(T) == typeof(int))
		{
			return (double)(object)((double)(int)(object)a / b);
		}
		if (typeof(T) == typeof(ulong))
		{
			return (double)(object)((double)(ulong)(object)a / b);
		}
		if (typeof(T) == typeof(long))
		{
			return (double)(object)((double)(long)(object)a / b);
		}
		if (typeof(T) == typeof(float))
		{
			return (double)(object)((double)(float)(object)a / b);
		}
		if (typeof(T) == typeof(double))
		{
			return (double)(object)((double)(object)a / b);
		}
		throw new NotSupportedException("Nope");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float DivideFloat<T>(T a, float b)
	{
		if (typeof(T) == typeof(byte))
		{
			return (float)(object)((float)(int)(byte)(object)a / b);
		}
		if (typeof(T) == typeof(sbyte))
		{
			return (float)(object)((float)(sbyte)(object)a / b);
		}
		if (typeof(T) == typeof(ushort))
		{
			return (float)(object)((float)(int)(ushort)(object)a / b);
		}
		if (typeof(T) == typeof(short))
		{
			return (float)(object)((float)(short)(object)a / b);
		}
		if (typeof(T) == typeof(uint))
		{
			return (float)(object)((float)(uint)(object)a / b);
		}
		if (typeof(T) == typeof(int))
		{
			return (float)(object)((float)(int)(object)a / b);
		}
		if (typeof(T) == typeof(ulong))
		{
			return (float)(object)((float)(ulong)(object)a / b);
		}
		if (typeof(T) == typeof(long))
		{
			return (float)(object)((float)(long)(object)a / b);
		}
		if (typeof(T) == typeof(float))
		{
			return (float)(object)((float)(object)a / b);
		}
		if (typeof(T) == typeof(double))
		{
			return (float)(object)((double)(object)a / (double)b);
		}
		throw new NotSupportedException("Nope");
	}
}
