using System;
using System.Text;

namespace Sabresaurus.SabreCSG;

[Serializable]
public class BrushOrder : IComparable
{
	public int[] Position;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < Position.Length; i++)
		{
			stringBuilder.Append(Position[i]);
			if (i < Position.Length - 1)
			{
				stringBuilder.Append(", ");
			}
		}
		return stringBuilder.ToString();
	}

	public int CompareTo(object other)
	{
		BrushOrder brushOrder = (BrushOrder)other;
		int num = Position.Length;
		if (brushOrder.Position.Length > num)
		{
			num = brushOrder.Position.Length;
		}
		for (int i = 0; i < num; i++)
		{
			if (i > Position.Length - 1)
			{
				return -1;
			}
			if (i > brushOrder.Position.Length - 1)
			{
				return 1;
			}
			if (Position[i] > brushOrder.Position[i])
			{
				return 1;
			}
			if (Position[i] < brushOrder.Position[i])
			{
				return -1;
			}
		}
		return 0;
	}
}
