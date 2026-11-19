using System.Text;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public static class StringHelper
{
	public static bool TryParseScale(string inputString, out Vector3 outputScale)
	{
		string[] array = inputString.Split(',');
		Vector3 one = Vector3.one;
		if (array.Length == 3)
		{
			int num = 0;
			for (int i = 0; i < 3; i++)
			{
				if (float.TryParse(array[i].Trim(), out var result))
				{
					one[i] = result;
					num++;
				}
			}
			if (num == 3)
			{
				outputScale = one;
				return true;
			}
		}
		if (array.Length > 1)
		{
			outputScale = Vector3.one;
			return false;
		}
		if (float.TryParse(inputString, out var result2) && result2 != 0f)
		{
			outputScale = new Vector3(result2, result2, result2);
			return true;
		}
		outputScale = Vector3.one;
		return false;
	}

	public static bool TryParseScale(string inputString, out Vector2 outputScale)
	{
		string[] array = inputString.Split(',');
		Vector2 one = Vector2.one;
		if (array.Length == 2)
		{
			int num = 0;
			for (int i = 0; i < 2; i++)
			{
				if (float.TryParse(array[i].Trim(), out var result))
				{
					one[i] = result;
					num++;
				}
			}
			if (num == 2)
			{
				outputScale = one;
				return true;
			}
		}
		if (array.Length > 1)
		{
			outputScale = Vector3.one;
			return false;
		}
		if (float.TryParse(inputString, out var result2) && result2 != 0f)
		{
			outputScale = new Vector2(result2, result2);
			return true;
		}
		outputScale = Vector2.one;
		return false;
	}

	public static string ParseDisplayString(string input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < input.Length; i++)
		{
			if (i > 0 && char.IsUpper(input[i]) && !char.IsUpper(input[i - 1]))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append(input[i]);
		}
		return stringBuilder.ToString();
	}
}
