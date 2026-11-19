using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Beebyte.Obfuscator;
using Better.StreamingAssets;
using Better.StreamingAssets.ZipArchive;
using UnityEngine;

[Skip]
public static class BetterStreamingAssets
{
	internal struct ReadInfo
	{
		public string readPath;

		public long size;

		public long offset;

		public uint crc32;
	}

	internal static class ApkImpl
	{
		private struct PartInfo
		{
			public long size;

			public long offset;

			public uint crc32;
		}

		private static string[] s_paths;

		private static PartInfo[] s_streamingAssets;

		public static string s_root;

		public static void Initialize(string dataPath, string streamingAssetsPath)
		{
			s_root = dataPath;
			List<string> list = new List<string>();
			List<PartInfo> list2 = new List<PartInfo>();
			GetStreamingAssetsInfoFromJar(s_root, list, list2);
			if (list.Count == 0 && !Application.isEditor && Path.GetFileName(dataPath) != "base.apk")
			{
				string text = Path.GetDirectoryName(dataPath) + "/base.apk";
				if (File.Exists(text))
				{
					s_root = text;
					GetStreamingAssetsInfoFromJar(text, list, list2);
				}
			}
			s_paths = list.ToArray();
			s_streamingAssets = list2.ToArray();
		}

		public static bool TryGetInfo(string path, out ReadInfo info)
		{
			path = PathUtil.NormalizeRelativePath(path);
			info = default(ReadInfo);
			int num = Array.BinarySearch(s_paths, path, StringComparer.OrdinalIgnoreCase);
			if (num < 0)
			{
				return false;
			}
			PartInfo partInfo = s_streamingAssets[num];
			info.crc32 = partInfo.crc32;
			info.offset = partInfo.offset;
			info.size = partInfo.size;
			info.readPath = s_root;
			return true;
		}

		public static bool DirectoryExists(string path)
		{
			string path2 = PathUtil.NormalizeRelativePath(path, true);
			int directoryIndex = GetDirectoryIndex(path2);
			return directoryIndex >= 0 && directoryIndex < s_paths.Length;
		}

		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			string text = PathUtil.NormalizeRelativePath(path, true);
			int directoryIndex = GetDirectoryIndex(text);
			if (directoryIndex < 0)
			{
				throw new IOException();
			}
			if (directoryIndex == s_paths.Length)
			{
				throw new DirectoryNotFoundException();
			}
			Predicate<string> predicate;
			if (string.IsNullOrEmpty(searchPattern) || searchPattern == "*")
			{
				predicate = null;
			}
			else if (searchPattern.IndexOf('*') >= 0 || searchPattern.IndexOf('?') >= 0)
			{
				Regex regex = PathUtil.WildcardToRegex(searchPattern);
				predicate = (string x) => regex.IsMatch(x);
			}
			else
			{
				predicate = (string x) => string.Compare(x, searchPattern, true) == 0;
			}
			List<string> list = new List<string>();
			string text2 = null;
			for (int num = directoryIndex; num < s_paths.Length; num++)
			{
				string text3 = s_paths[num];
				if (!text3.StartsWith(text))
				{
					break;
				}
				int num2 = text3.LastIndexOf('/', text3.Length - 1, text3.Length - text.Length);
				string obj;
				if (num2 >= 0)
				{
					if (searchOption == SearchOption.TopDirectoryOnly)
					{
						continue;
					}
					obj = text3.Substring(num2 + 1);
				}
				else
				{
					obj = text3.Substring(text.Length);
				}
				if (predicate != null && !predicate(obj))
				{
					continue;
				}
				string b = text3.Substring(text.Length);
				if (text2 == null)
				{
					text2 = PathUtil.FixTrailingDirectorySeparators(path);
					if (text2 == "/")
					{
						text2 = string.Empty;
					}
				}
				string item = PathUtil.CombineSlash(text2, b);
				list.Add(item);
			}
			return list.ToArray();
		}

		public static byte[] ReadAllBytes(string path)
		{
			ReadInfo info;
			if (!TryGetInfo(path, out info))
			{
				ThrowFileNotFound(path);
			}
			using (FileStream fileStream = File.OpenRead(info.readPath))
			{
				if (info.offset != 0 && fileStream.Seek(info.offset, SeekOrigin.Begin) != info.offset)
				{
					throw new IOException();
				}
				if (info.size > int.MaxValue)
				{
					throw new IOException();
				}
				int num = (int)info.size;
				int num2 = 0;
				byte[] array = new byte[num];
				while (num > 0)
				{
					int num3 = fileStream.Read(array, num2, num);
					if (num3 == 0)
					{
						throw new EndOfStreamException();
					}
					num2 += num3;
					num -= num3;
				}
				return array;
			}
		}

		public static Stream OpenRead(string path)
		{
			ReadInfo info;
			if (!TryGetInfo(path, out info))
			{
				ThrowFileNotFound(path);
			}
			Stream stream = File.OpenRead(info.readPath);
			try
			{
				return new SubReadOnlyStream(stream, info.offset, info.size);
			}
			catch (Exception)
			{
				stream.Dispose();
				throw;
			}
		}

		private static int GetDirectoryIndex(string path)
		{
			int num = Array.BinarySearch(s_paths, path, StringComparer.OrdinalIgnoreCase);
			if (num >= 0)
			{
				return ~num;
			}
			num = ~num;
			if (num == s_paths.Length)
			{
				return num;
			}
			for (int i = num; i < s_paths.Length && s_paths[i].StartsWith(path); i++)
			{
				if (path[path.Length - 1] == '/')
				{
					return i;
				}
				if (s_paths[i][path.Length] == '/')
				{
					return i;
				}
			}
			return s_paths.Length;
		}

		private static void GetStreamingAssetsInfoFromJar(string apkPath, List<string> paths, List<PartInfo> parts)
		{
			using (FileStream fileStream = File.OpenRead(apkPath))
			{
				using (BinaryReader reader = new BinaryReader(fileStream))
				{
					if (!fileStream.CanRead)
					{
						throw new ArgumentException();
					}
					if (!fileStream.CanSeek)
					{
						throw new ArgumentException();
					}
					long expectedNumberOfEntries;
					long centralDirectoryStart;
					ZipArchiveUtils.ReadEndOfCentralDirectory(fileStream, reader, out expectedNumberOfEntries, out centralDirectoryStart);
					try
					{
						fileStream.Seek(centralDirectoryStart, SeekOrigin.Begin);
						long num = 0L;
						ZipCentralDirectoryFileHeader header;
						while (ZipCentralDirectoryFileHeader.TryReadBlock(reader, out header))
						{
							if (header.CompressedSize == header.UncompressedSize)
							{
								string text = Encoding.UTF8.GetString(header.Filename);
								if (!text.EndsWith("/") && text.StartsWith("assets/") && !text.StartsWith("assets/bin/"))
								{
									string item = text.Substring(6);
									PartInfo item2 = new PartInfo
									{
										crc32 = header.Crc32,
										offset = header.RelativeOffsetOfLocalHeader,
										size = header.UncompressedSize
									};
									int num2 = paths.BinarySearch(item, StringComparer.OrdinalIgnoreCase);
									if (num2 >= 0)
									{
										throw new InvalidOperationException("Paths duplicate! " + text);
									}
									paths.Insert(~num2, item);
									parts.Insert(~num2, item2);
								}
							}
							num++;
						}
						if (num != expectedNumberOfEntries)
						{
							throw new ZipArchiveException("Number of entries does not match");
						}
					}
					catch (EndOfStreamException inner)
					{
						throw new ZipArchiveException("CentralDirectoryInvalid", inner);
					}
					for (int i = 0; i < parts.Count; i++)
					{
						PartInfo value = parts[i];
						fileStream.Seek(value.offset, SeekOrigin.Begin);
						if (!ZipLocalFileHeader.TrySkipBlock(reader))
						{
							throw new ZipArchiveException("Local file header corrupt");
						}
						value.offset = fileStream.Position;
						parts[i] = value;
					}
				}
			}
		}
	}

	public static string Root
	{
		get
		{
			return ApkImpl.s_root;
		}
	}

	public static void Initialize()
	{
		ApkImpl.Initialize(Application.dataPath, Application.streamingAssetsPath);
	}

	public static bool FileExists(string path)
	{
		ReadInfo info;
		return ApkImpl.TryGetInfo(path, out info);
	}

	public static bool DirectoryExists(string path)
	{
		return ApkImpl.DirectoryExists(path);
	}

	public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, uint crc = 0u)
	{
		ReadInfo infoOrThrow = GetInfoOrThrow(path);
		return AssetBundle.LoadFromFileAsync(infoOrThrow.readPath, crc, (ulong)infoOrThrow.offset);
	}

	public static AssetBundle LoadAssetBundle(string path, uint crc = 0u)
	{
		ReadInfo infoOrThrow = GetInfoOrThrow(path);
		return AssetBundle.LoadFromFile(infoOrThrow.readPath, crc, (ulong)infoOrThrow.offset);
	}

	public static Stream OpenRead(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException("Empty path", "path");
		}
		return ApkImpl.OpenRead(path);
	}

	public static StreamReader OpenText(string path)
	{
		Stream stream = OpenRead(path);
		try
		{
			return new StreamReader(stream);
		}
		catch (Exception)
		{
			if (stream != null)
			{
				stream.Dispose();
			}
			throw;
		}
	}

	public static string ReadAllText(string path)
	{
		using (StreamReader streamReader = OpenText(path))
		{
			return streamReader.ReadToEnd();
		}
	}

	public static string[] ReadAllLines(string path)
	{
		List<string> list = new List<string>();
		using (StreamReader streamReader = OpenText(path))
		{
			string item;
			while ((item = streamReader.ReadLine()) != null)
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	public static byte[] ReadAllBytes(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException("Empty path", "path");
		}
		return ApkImpl.ReadAllBytes(path);
	}

	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return ApkImpl.GetFiles(path, searchPattern, searchOption);
	}

	public static string[] GetFiles(string path)
	{
		return GetFiles(path, null);
	}

	public static string[] GetFiles(string path, string searchPattern)
	{
		return GetFiles(path, searchPattern, SearchOption.TopDirectoryOnly);
	}

	private static ReadInfo GetInfoOrThrow(string path)
	{
		ReadInfo info;
		if (!ApkImpl.TryGetInfo(path, out info))
		{
			ThrowFileNotFound(path);
		}
		return info;
	}

	private static void ThrowFileNotFound(string path)
	{
		throw new FileNotFoundException("File not found", path);
	}
}
