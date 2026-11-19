using System;

namespace Better.StreamingAssets.ZipArchive
{
	public class ZipArchiveException : Exception
	{
		public ZipArchiveException(string msg)
			: base(msg)
		{
		}

		public ZipArchiveException(string msg, Exception inner)
			: base(msg, inner)
		{
		}
	}
}
