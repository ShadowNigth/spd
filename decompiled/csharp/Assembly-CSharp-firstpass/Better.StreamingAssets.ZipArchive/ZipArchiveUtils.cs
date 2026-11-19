using System.IO;

namespace Better.StreamingAssets.ZipArchive;

public static class ZipArchiveUtils
{
	public static void ReadEndOfCentralDirectory(Stream stream, BinaryReader reader, out long expectedNumberOfEntries, out long centralDirectoryStart)
	{
		try
		{
			stream.Seek(-18L, SeekOrigin.End);
			if (!ZipHelper.SeekBackwardsToSignature(stream, 101010256u))
			{
				throw new ZipArchiveException("SignatureConstant");
			}
			long position = stream.Position;
			ZipEndOfCentralDirectoryBlock eocdBlock;
			bool flag = ZipEndOfCentralDirectoryBlock.TryReadBlock(reader, out eocdBlock);
			if (eocdBlock.NumberOfThisDisk != eocdBlock.NumberOfTheDiskWithTheStartOfTheCentralDirectory)
			{
				throw new ZipArchiveException("SplitSpanned");
			}
			centralDirectoryStart = eocdBlock.OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;
			if (eocdBlock.NumberOfEntriesInTheCentralDirectory != eocdBlock.NumberOfEntriesInTheCentralDirectoryOnThisDisk)
			{
				throw new ZipArchiveException("SplitSpanned");
			}
			expectedNumberOfEntries = (int)eocdBlock.NumberOfEntriesInTheCentralDirectory;
			if (eocdBlock.NumberOfThisDisk == ushort.MaxValue || eocdBlock.OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber == uint.MaxValue || eocdBlock.NumberOfEntriesInTheCentralDirectory == ushort.MaxValue)
			{
				stream.Seek(position - 16, SeekOrigin.Begin);
				if (ZipHelper.SeekBackwardsToSignature(stream, 117853008u))
				{
					Zip64EndOfCentralDirectoryLocator zip64EOCDLocator;
					bool flag2 = Zip64EndOfCentralDirectoryLocator.TryReadBlock(reader, out zip64EOCDLocator);
					if (zip64EOCDLocator.OffsetOfZip64EOCD > long.MaxValue)
					{
						throw new ZipArchiveException("FieldTooBigOffsetToZip64EOCD");
					}
					long offsetOfZip64EOCD = (long)zip64EOCDLocator.OffsetOfZip64EOCD;
					stream.Seek(offsetOfZip64EOCD, SeekOrigin.Begin);
					if (!Zip64EndOfCentralDirectoryRecord.TryReadBlock(reader, out var zip64EOCDRecord))
					{
						throw new ZipArchiveException("Zip64EOCDNotWhereExpected");
					}
					if (zip64EOCDRecord.NumberOfEntriesTotal > long.MaxValue)
					{
						throw new ZipArchiveException("FieldTooBigNumEntries");
					}
					if (zip64EOCDRecord.OffsetOfCentralDirectory > long.MaxValue)
					{
						throw new ZipArchiveException("FieldTooBigOffsetToCD");
					}
					if (zip64EOCDRecord.NumberOfEntriesTotal != zip64EOCDRecord.NumberOfEntriesOnThisDisk)
					{
						throw new ZipArchiveException("SplitSpanned");
					}
					expectedNumberOfEntries = (long)zip64EOCDRecord.NumberOfEntriesTotal;
					centralDirectoryStart = (long)zip64EOCDRecord.OffsetOfCentralDirectory;
				}
			}
			if (centralDirectoryStart > stream.Length)
			{
				throw new ZipArchiveException("FieldTooBigOffsetToCD");
			}
		}
		catch (EndOfStreamException inner)
		{
			throw new ZipArchiveException("CDCorrupt", inner);
		}
		catch (IOException inner2)
		{
			throw new ZipArchiveException("CDCorrupt", inner2);
		}
	}
}
