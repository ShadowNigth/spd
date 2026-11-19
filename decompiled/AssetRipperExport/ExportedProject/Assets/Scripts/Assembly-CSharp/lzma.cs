using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

public class lzma
{
	public static string persitentDataPath = string.Empty;

	internal static int[] props = new int[7];

	internal static bool defaultsSet = false;

	private const string libname = "lzma";

	public static int trueTotalFiles = 0;

	public static List<string> ninfo = new List<string>();

	public static List<long> sinfo = new List<long>();

	public static void setProps(int level = 5, int dictSize = 16777216, int lc = 3, int lp = 0, int pb = 2, int fb = 32, int numThreads = 2)
	{
		defaultsSet = true;
		props[0] = level;
		props[1] = dictSize;
		props[2] = lc;
		props[3] = lp;
		props[4] = pb;
		props[5] = fb;
		props[6] = numThreads;
	}

	[DllImport("lzma")]
	internal static extern int lsetPermissions(string filePath, string _user, string _group, string _other);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int decompress7zip(string filePath, string exctractionPath, bool fullPaths, string entry, IntPtr progress, IntPtr FileBuffer, int FileBufferLength);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int decompress7zip2(string filePath, string exctractionPath, bool fullPaths, string entry, IntPtr progress, IntPtr FileBuffer, int FileBufferLength);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int _getSize(string filePath, string tempPath, IntPtr FileBuffer, int FileBufferLength);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int lzmaUtil(bool encode, string inPath, string outPath, IntPtr Props);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int decode2Buf(string filePath, string entry, IntPtr buffer, IntPtr FileBuffer, int FileBufferLength);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void _releaseBuffer(IntPtr buffer);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr Lzma_Compress(IntPtr buffer, int bufferLength, bool makeHeader, ref int v, IntPtr Props);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int Lzma_Uncompress(IntPtr buffer, int bufferLength, int uncompressedSize, IntPtr outbuffer, bool useHeader);

	[DllImport("lzma", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Lzma_Uncompress")]
	public static extern void sevenZcancel();

	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return lsetPermissions(filePath, _user, _group, _other);
	}

	public static int doDecompress7zip(string filePath, string exctractionPath, int[] progress, bool largeFiles = false, bool fullPaths = true, string entry = null, byte[] FileBuffer = null)
	{
		if (exctractionPath.Substring(exctractionPath.Length - 1, 1) != "/")
		{
			exctractionPath += "/";
		}
		if (!Directory.Exists(exctractionPath))
		{
			Directory.CreateDirectory(exctractionPath);
		}
		int num = 0;
		GCHandle gCHandle = GCHandle.Alloc(progress, GCHandleType.Pinned);
		if (FileBuffer != null)
		{
			GCHandle gCHandle2 = GCHandle.Alloc(FileBuffer, GCHandleType.Pinned);
			num = ((!largeFiles) ? decompress7zip2(null, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), FileBuffer.Length) : decompress7zip(null, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), FileBuffer.Length));
			gCHandle2.Free();
			gCHandle.Free();
			return num;
		}
		if (largeFiles)
		{
			num = decompress7zip(filePath, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), IntPtr.Zero, 0);
			gCHandle.Free();
			return num;
		}
		num = decompress7zip2(filePath, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), IntPtr.Zero, 0);
		gCHandle.Free();
		return num;
	}

	public static int doDecompress7zip(string filePath, string exctractionPath, bool largeFiles = false, bool fullPaths = true, string entry = null, byte[] FileBuffer = null)
	{
		if (exctractionPath.Substring(exctractionPath.Length - 1, 1) != "/")
		{
			exctractionPath += "/";
		}
		if (!Directory.Exists(exctractionPath))
		{
			Directory.CreateDirectory(exctractionPath);
		}
		int[] value = new int[1];
		GCHandle gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
		int num = 0;
		if (FileBuffer != null)
		{
			GCHandle gCHandle2 = GCHandle.Alloc(FileBuffer, GCHandleType.Pinned);
			num = ((!largeFiles) ? decompress7zip2(null, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), FileBuffer.Length) : decompress7zip(null, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), FileBuffer.Length));
			gCHandle2.Free();
			gCHandle.Free();
			return num;
		}
		if (largeFiles)
		{
			num = decompress7zip(filePath, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), IntPtr.Zero, 0);
			gCHandle.Free();
			return num;
		}
		num = decompress7zip2(filePath, exctractionPath, fullPaths, entry, gCHandle.AddrOfPinnedObject(), IntPtr.Zero, 0);
		gCHandle.Free();
		return num;
	}

	public static int LzmaUtilEncode(string inPath, string outPath)
	{
		if (!defaultsSet)
		{
			setProps();
		}
		GCHandle gCHandle = GCHandle.Alloc(props, GCHandleType.Pinned);
		int result = lzmaUtil(true, inPath, outPath, gCHandle.AddrOfPinnedObject());
		gCHandle.Free();
		return result;
	}

	public static int LzmaUtilDecode(string inPath, string outPath)
	{
		return lzmaUtil(false, inPath, outPath, IntPtr.Zero);
	}

	public static long get7zInfo(string filePath, string tempPath = null, byte[] FileBuffer = null)
	{
		ninfo.Clear();
		sinfo.Clear();
		trueTotalFiles = 0;
		int num = -1;
		string empty = string.Empty;
		empty = ((tempPath != null) ? tempPath : ((persitentDataPath.Length <= 0) ? (Application.persistentDataPath + "/sevenZip.log") : (persitentDataPath + "/sevenZip.log")));
		if (File.Exists(empty + ".txt"))
		{
			File.Delete(empty + ".txt");
		}
		if (FileBuffer != null)
		{
			GCHandle gCHandle = GCHandle.Alloc(FileBuffer, GCHandleType.Pinned);
			num = _getSize(null, empty, gCHandle.AddrOfPinnedObject(), FileBuffer.Length);
			gCHandle.Free();
		}
		else
		{
			num = _getSize(filePath, empty, IntPtr.Zero, 0);
		}
		if (num == -1)
		{
			return -1L;
		}
		if (!File.Exists(empty + ".txt"))
		{
			return -3L;
		}
		StreamReader streamReader = new StreamReader(empty + ".txt");
		long result = 0L;
		long num2 = 0L;
		string text;
		while ((text = streamReader.ReadLine()) != null)
		{
			string[] array = text.Split('|');
			ninfo.Add(array[0]);
			long.TryParse(array[1], out result);
			num2 += result;
			sinfo.Add(result);
			if (result > 0)
			{
				trueTotalFiles++;
			}
		}
		streamReader.Close();
		streamReader.Dispose();
		File.Delete(empty + ".txt");
		return num2;
	}

	public static long get7zSize(string filePath = null, string fileName = null, string tempPath = null, byte[] FileBuffer = null)
	{
		if (filePath != null && get7zInfo(filePath, tempPath, FileBuffer) < 0)
		{
			return -1L;
		}
		if (ninfo == null && ninfo.Count == 0)
		{
			return -1L;
		}
		long num = 0L;
		if (fileName != null)
		{
			for (int i = 0; i < ninfo.Count; i++)
			{
				if (ninfo[i].ToString() == fileName)
				{
					return sinfo[i];
				}
			}
			return -1L;
		}
		for (int j = 0; j < ninfo.Count; j++)
		{
			num += sinfo[j];
		}
		return num;
	}

	public static byte[] decode2Buffer(string filePath, string entry, string tempPath = null, byte[] FileBuffer = null)
	{
		int num = (int)get7zSize(filePath, entry, tempPath, FileBuffer);
		if (num <= 0)
		{
			return null;
		}
		byte[] array = new byte[num];
		int num2 = 0;
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		if (FileBuffer != null)
		{
			GCHandle gCHandle2 = GCHandle.Alloc(FileBuffer, GCHandleType.Pinned);
			num2 = decode2Buf(null, entry, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), FileBuffer.Length);
			gCHandle2.Free();
		}
		else
		{
			num2 = decode2Buf(filePath, entry, gCHandle.AddrOfPinnedObject(), IntPtr.Zero, 0);
		}
		gCHandle.Free();
		if (num2 == 1)
		{
			return array;
		}
		array = null;
		return null;
	}

	public static bool compressBuffer(byte[] inBuffer, ref byte[] outBuffer, bool makeHeader = true)
	{
		if (!defaultsSet)
		{
			setProps();
		}
		GCHandle gCHandle = GCHandle.Alloc(props, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		int v = 0;
		IntPtr intPtr = Lzma_Compress(gCHandle2.AddrOfPinnedObject(), inBuffer.Length, makeHeader, ref v, gCHandle.AddrOfPinnedObject());
		gCHandle2.Free();
		gCHandle.Free();
		if (v == 0 || intPtr == IntPtr.Zero)
		{
			_releaseBuffer(intPtr);
			return false;
		}
		Array.Resize(ref outBuffer, v);
		Marshal.Copy(intPtr, outBuffer, 0, v);
		_releaseBuffer(intPtr);
		return true;
	}

	public static bool compressBufferPartial(byte[] inBuffer, int inBufferPartialIndex, int inBufferPartialLength, ref byte[] outBuffer, bool makeHeader = true)
	{
		if (inBufferPartialIndex + inBufferPartialLength > inBuffer.Length)
		{
			return false;
		}
		if (!defaultsSet)
		{
			setProps();
		}
		GCHandle gCHandle = GCHandle.Alloc(props, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		int v = 0;
		IntPtr buffer = new IntPtr(gCHandle2.AddrOfPinnedObject().ToInt64() + inBufferPartialIndex);
		IntPtr intPtr = Lzma_Compress(buffer, inBufferPartialLength, makeHeader, ref v, gCHandle.AddrOfPinnedObject());
		gCHandle2.Free();
		if (v == 0 || intPtr == IntPtr.Zero)
		{
			_releaseBuffer(intPtr);
			return false;
		}
		Array.Resize(ref outBuffer, v);
		Marshal.Copy(intPtr, outBuffer, 0, v);
		_releaseBuffer(intPtr);
		return true;
	}

	public static int compressBufferPartialFixed(byte[] inBuffer, int inBufferPartialIndex, int inBufferPartialLength, ref byte[] outBuffer, bool safe = true, bool makeHeader = true)
	{
		if (inBufferPartialIndex + inBufferPartialLength > inBuffer.Length)
		{
			return 0;
		}
		if (!defaultsSet)
		{
			setProps();
		}
		GCHandle gCHandle = GCHandle.Alloc(props, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		int v = 0;
		IntPtr buffer = new IntPtr(gCHandle2.AddrOfPinnedObject().ToInt64() + inBufferPartialIndex);
		IntPtr intPtr = Lzma_Compress(buffer, inBufferPartialLength, makeHeader, ref v, gCHandle.AddrOfPinnedObject());
		gCHandle2.Free();
		if (v == 0 || intPtr == IntPtr.Zero)
		{
			_releaseBuffer(intPtr);
			return 0;
		}
		if (v > outBuffer.Length)
		{
			if (safe)
			{
				_releaseBuffer(intPtr);
				return 0;
			}
			v = outBuffer.Length;
		}
		Marshal.Copy(intPtr, outBuffer, 0, v);
		_releaseBuffer(intPtr);
		return v;
	}

	public static int compressBufferFixed(byte[] inBuffer, ref byte[] outBuffer, bool safe = true, bool makeHeader = true)
	{
		if (!defaultsSet)
		{
			setProps();
		}
		GCHandle gCHandle = GCHandle.Alloc(props, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		int v = 0;
		IntPtr intPtr = Lzma_Compress(gCHandle2.AddrOfPinnedObject(), inBuffer.Length, makeHeader, ref v, gCHandle.AddrOfPinnedObject());
		gCHandle2.Free();
		gCHandle.Free();
		if (v == 0 || intPtr == IntPtr.Zero)
		{
			_releaseBuffer(intPtr);
			return 0;
		}
		if (v > outBuffer.Length)
		{
			if (safe)
			{
				_releaseBuffer(intPtr);
				return 0;
			}
			v = outBuffer.Length;
		}
		Marshal.Copy(intPtr, outBuffer, 0, v);
		_releaseBuffer(intPtr);
		return v;
	}

	public static int decompressAssetBundle(byte[] inBuffer, ref byte[] outbuffer)
	{
		int num = 0;
		for (int i = 0; i < inBuffer.Length && i <= 1024; i++)
		{
			if (inBuffer[i] == 93 && inBuffer[i + 1] == 0 && inBuffer[i + 2] == 0 && inBuffer[i + 3] == 8)
			{
				num = i;
				break;
			}
		}
		if (num == 0 || num > 1024)
		{
			return 4;
		}
		GCHandle gCHandle = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		IntPtr buffer = new IntPtr(gCHandle.AddrOfPinnedObject().ToInt64() + num);
		int num2 = (int)BitConverter.ToUInt64(inBuffer, num + 5);
		if (num2 < 0)
		{
			gCHandle.Free();
			return 4;
		}
		Array.Resize(ref outbuffer, num2);
		GCHandle gCHandle2 = GCHandle.Alloc(outbuffer, GCHandleType.Pinned);
		int result = Lzma_Uncompress(buffer, inBuffer.Length - num, num2, gCHandle2.AddrOfPinnedObject(), true);
		gCHandle.Free();
		gCHandle2.Free();
		return result;
	}

	public static int decompressBuffer(byte[] inBuffer, ref byte[] outbuffer, bool useHeader = true, int customLength = 0)
	{
		GCHandle gCHandle = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		int num = 0;
		num = ((!useHeader) ? customLength : ((int)BitConverter.ToUInt64(inBuffer, 5)));
		Array.Resize(ref outbuffer, num);
		GCHandle gCHandle2 = GCHandle.Alloc(outbuffer, GCHandleType.Pinned);
		int result = Lzma_Uncompress(gCHandle.AddrOfPinnedObject(), inBuffer.Length, num, gCHandle2.AddrOfPinnedObject(), useHeader);
		gCHandle.Free();
		gCHandle2.Free();
		return result;
	}

	public static byte[] decompressBuffer(byte[] inBuffer, bool useHeader = true, int customLength = 0)
	{
		GCHandle gCHandle = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		int num = 0;
		num = ((!useHeader) ? customLength : ((int)BitConverter.ToUInt64(inBuffer, 5)));
		byte[] array = new byte[num];
		GCHandle gCHandle2 = GCHandle.Alloc(array, GCHandleType.Pinned);
		int num2 = Lzma_Uncompress(gCHandle.AddrOfPinnedObject(), inBuffer.Length, num, gCHandle2.AddrOfPinnedObject(), useHeader);
		gCHandle.Free();
		gCHandle2.Free();
		if (num2 != 0)
		{
			return null;
		}
		return array;
	}

	public static int decompressBufferFixed(byte[] inBuffer, ref byte[] outbuffer, bool safe = true, bool useHeader = true, int customLength = 0)
	{
		int num = 0;
		num = ((!useHeader) ? customLength : ((int)BitConverter.ToUInt64(inBuffer, 5)));
		if (num > outbuffer.Length)
		{
			if (safe)
			{
				return -101;
			}
			num = outbuffer.Length;
		}
		GCHandle gCHandle = GCHandle.Alloc(inBuffer, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(outbuffer, GCHandleType.Pinned);
		int num2 = Lzma_Uncompress(gCHandle.AddrOfPinnedObject(), inBuffer.Length, num, gCHandle2.AddrOfPinnedObject(), useHeader);
		gCHandle.Free();
		gCHandle2.Free();
		if (num2 != 0)
		{
			return -num2;
		}
		return num;
	}
}
