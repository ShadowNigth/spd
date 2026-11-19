using System.Collections.Generic;
using System.IO;

namespace Better.StreamingAssets.ZipArchive;

internal struct ZipCentralDirectoryFileHeader
{
	public const uint SignatureConstant = 33639248u;

	public byte VersionMadeByCompatibility;

	public byte VersionMadeBySpecification;

	public ushort VersionNeededToExtract;

	public ushort GeneralPurposeBitFlag;

	public ushort CompressionMethod;

	public uint LastModified;

	public uint Crc32;

	public long CompressedSize;

	public long UncompressedSize;

	public ushort FilenameLength;

	public ushort ExtraFieldLength;

	public ushort FileCommentLength;

	public int DiskNumberStart;

	public ushort InternalFileAttributes;

	public uint ExternalFileAttributes;

	public long RelativeOffsetOfLocalHeader;

	public byte[] Filename;

	public byte[] FileComment;

	public List<ZipGenericExtraField> ExtraFields;

	public static bool TryReadBlock(BinaryReader reader, out ZipCentralDirectoryFileHeader header)
	{
		header = default(ZipCentralDirectoryFileHeader);
		if (reader.ReadUInt32() != 33639248)
		{
			return false;
		}
		header.VersionMadeBySpecification = reader.ReadByte();
		header.VersionMadeByCompatibility = reader.ReadByte();
		header.VersionNeededToExtract = reader.ReadUInt16();
		header.GeneralPurposeBitFlag = reader.ReadUInt16();
		header.CompressionMethod = reader.ReadUInt16();
		header.LastModified = reader.ReadUInt32();
		header.Crc32 = reader.ReadUInt32();
		uint num = reader.ReadUInt32();
		uint num2 = reader.ReadUInt32();
		header.FilenameLength = reader.ReadUInt16();
		header.ExtraFieldLength = reader.ReadUInt16();
		header.FileCommentLength = reader.ReadUInt16();
		ushort num3 = reader.ReadUInt16();
		header.InternalFileAttributes = reader.ReadUInt16();
		header.ExternalFileAttributes = reader.ReadUInt32();
		uint num4 = reader.ReadUInt32();
		header.Filename = reader.ReadBytes(header.FilenameLength);
		bool readUncompressedSize = num2 == uint.MaxValue;
		bool readCompressedSize = num == uint.MaxValue;
		bool readLocalHeaderOffset = num4 == uint.MaxValue;
		bool readStartDiskNumber = num3 == ushort.MaxValue;
		long position = reader.BaseStream.Position + (int)header.ExtraFieldLength;
		Zip64ExtraField justZip64Block;
		using (Stream extraFieldStream = new SubReadOnlyStream(reader.BaseStream, reader.BaseStream.Position, (int)header.ExtraFieldLength, leaveOpen: true))
		{
			header.ExtraFields = null;
			justZip64Block = Zip64ExtraField.GetJustZip64Block(extraFieldStream, readUncompressedSize, readCompressedSize, readLocalHeaderOffset, readStartDiskNumber);
		}
		reader.BaseStream.AdvanceToPosition(position);
		reader.BaseStream.Position += (int)header.FileCommentLength;
		header.FileComment = null;
		header.UncompressedSize = (justZip64Block.UncompressedSize.HasValue ? justZip64Block.UncompressedSize.Value : num2);
		header.CompressedSize = (justZip64Block.CompressedSize.HasValue ? justZip64Block.CompressedSize.Value : num);
		header.RelativeOffsetOfLocalHeader = (justZip64Block.LocalHeaderOffset.HasValue ? justZip64Block.LocalHeaderOffset.Value : num4);
		header.DiskNumberStart = (justZip64Block.StartDiskNumber.HasValue ? justZip64Block.StartDiskNumber.Value : num3);
		return true;
	}
}
