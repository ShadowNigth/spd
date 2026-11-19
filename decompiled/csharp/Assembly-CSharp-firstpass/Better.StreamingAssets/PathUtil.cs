using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Better.StreamingAssets;

public static class PathUtil
{
	private enum NormalizeState
	{
		PrevSlash,
		PrevDot,
		PrevDoubleDot,
		NothingSpecial
	}

	public static bool IsDirectorySeparator(char c)
	{
		return c == '/' || c == '\\';
	}

	public static string FixTrailingDirectorySeparators(string path)
	{
		if (path.Length >= 2)
		{
			char c = path[path.Length - 1];
			char c2 = path[path.Length - 2];
			if (IsDirectorySeparator(c) && IsDirectorySeparator(c2))
			{
				return path.TrimEnd('\\', '/') + c;
			}
		}
		return path;
	}

	public static string CombineSlash(string a, string b)
	{
		if (a == null)
		{
			throw new ArgumentNullException("a");
		}
		if (b == null)
		{
			throw new ArgumentNullException("b");
		}
		if (string.IsNullOrEmpty(b))
		{
			return a;
		}
		if (string.IsNullOrEmpty(a))
		{
			return b;
		}
		if (b[0] == '/')
		{
			return b;
		}
		if (IsDirectorySeparator(a[a.Length - 1]))
		{
			return a + b;
		}
		return a + '/' + b;
	}

	public static string NormalizeRelativePath(string relative, bool forceTrailingSlash = false)
	{
		if (string.IsNullOrEmpty(relative))
		{
			throw new ArgumentException("Empty or null", "relative");
		}
		StringBuilder stringBuilder = new StringBuilder(relative.Length);
		NormalizeState normalizeState = NormalizeState.PrevSlash;
		stringBuilder.Append('/');
		int num = 0;
		int num2 = relative.Length;
		if (relative[0] == '"' && relative.Length > 2 && relative[relative.Length - 1] == '"')
		{
			num++;
			num2--;
		}
		for (int i = num; i <= num2; i++)
		{
			if (i == num2 || relative[i] == '/' || relative[i] == '\\')
			{
				switch (normalizeState)
				{
				case NormalizeState.PrevDoubleDot:
				{
					if (stringBuilder.Length == 1)
					{
						throw new IOException("Invalid path: double dot error (before " + i + ")");
					}
					int num3 = stringBuilder.Length - 2;
					while (num3 >= 0 && stringBuilder[num3] != '/')
					{
						num3--;
					}
					stringBuilder.Remove(num3 + 1, stringBuilder.Length - num3 - 1);
					break;
				}
				default:
					if (i < num2 || forceTrailingSlash)
					{
						stringBuilder.Append('/');
					}
					break;
				case NormalizeState.PrevSlash:
				case NormalizeState.PrevDot:
					break;
				}
				normalizeState = NormalizeState.PrevSlash;
			}
			else if (relative[i] == '.')
			{
				switch (normalizeState)
				{
				case NormalizeState.PrevSlash:
					normalizeState = NormalizeState.PrevDot;
					break;
				case NormalizeState.PrevDot:
					normalizeState = NormalizeState.PrevDoubleDot;
					break;
				case NormalizeState.PrevDoubleDot:
					normalizeState = NormalizeState.NothingSpecial;
					stringBuilder.Append("...");
					break;
				default:
					stringBuilder.Append('.');
					break;
				}
			}
			else
			{
				switch (normalizeState)
				{
				case NormalizeState.PrevDot:
					stringBuilder.Append('.');
					break;
				case NormalizeState.PrevDoubleDot:
					stringBuilder.Append("..");
					break;
				}
				if (!IsValidCharacter(relative[i]))
				{
					throw new IOException("Invalid characters");
				}
				stringBuilder.Append(relative[i]);
				normalizeState = NormalizeState.NothingSpecial;
			}
		}
		return stringBuilder.ToString();
	}

	public static bool IsValidCharacter(char c)
	{
		if (c == '"' || c == '<' || c == '>' || c == '|' || c < ' ' || c == ':' || c == '*' || c == '?')
		{
			return false;
		}
		return true;
	}

	public static Regex WildcardToRegex(string pattern)
	{
		return new Regex("^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$", RegexOptions.IgnoreCase);
	}
}
