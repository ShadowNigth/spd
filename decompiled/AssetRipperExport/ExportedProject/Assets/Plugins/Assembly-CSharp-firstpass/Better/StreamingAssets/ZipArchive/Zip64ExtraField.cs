using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal struct Zip64ExtraField
	{
		public const int OffsetToFirstField = 4;

		private const ushort TagConstant = 1;

		private ushort _size;

		private long? _uncompressedSize;

		private long? _compressedSize;

		private long? _localHeaderOffset;

		private int? _startDiskNumber;

		public long? UncompressedSize
		{
			get
			{
				return _uncompressedSize;
			}
			set
			{
				_uncompressedSize = value;
				UpdateSize();
			}
		}

		public long? CompressedSize
		{
			get
			{
				return _compressedSize;
			}
			set
			{
				_compressedSize = value;
				UpdateSize();
			}
		}

		public long? LocalHeaderOffset
		{
			get
			{
				return _localHeaderOffset;
			}
			set
			{
				_localHeaderOffset = value;
				UpdateSize();
			}
		}

		public int? StartDiskNumber
		{
			get
			{
				return _startDiskNumber;
			}
		}

		private void UpdateSize()
		{
			_size = 0;
			long? uncompressedSize = _uncompressedSize;
			if (uncompressedSize.HasValue)
			{
				_size += 8;
			}
			long? compressedSize = _compressedSize;
			if (compressedSize.HasValue)
			{
				_size += 8;
			}
			long? localHeaderOffset = _localHeaderOffset;
			if (localHeaderOffset.HasValue)
			{
				_size += 8;
			}
			int? startDiskNumber = _startDiskNumber;
			if (startDiskNumber.HasValue)
			{
				_size += 4;
			}
		}

		public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
		{
			using (BinaryReader reader = new BinaryReader(extraFieldStream))
			{
				ZipGenericExtraField field;
				while (ZipGenericExtraField.TryReadBlock(reader, extraFieldStream.Length, out field))
				{
					Zip64ExtraField zip64Block;
					if (TryGetZip64BlockFromGenericExtraField(field, readUncompressedSize, readCompressedSize, readLocalHeaderOffset, readStartDiskNumber, out zip64Block))
					{
						return zip64Block;
					}
				}
			}
			return new Zip64ExtraField
			{
				_compressedSize = null,
				_uncompressedSize = null,
				_localHeaderOffset = null,
				_startDiskNumber = null
			};
		}

		private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block)
		{
			zip64Block = default(Zip64ExtraField);
			zip64Block._compressedSize = null;
			zip64Block._uncompressedSize = null;
			zip64Block._localHeaderOffset = null;
			zip64Block._startDiskNumber = null;
			if (extraField.Tag != 1)
			{
				return false;
			}
			MemoryStream memoryStream = null;
			try
			{
				memoryStream = new MemoryStream(extraField.Data);
				using (BinaryReader binaryReader = new BinaryReader(memoryStream))
				{
					memoryStream = null;
					zip64Block._size = extraField.Size;
					ushort num = 0;
					if (readUncompressedSize)
					{
						num += 8;
					}
					if (readCompressedSize)
					{
						num += 8;
					}
					if (readLocalHeaderOffset)
					{
						num += 8;
					}
					if (readStartDiskNumber)
					{
						num += 4;
					}
					if (num != zip64Block._size)
					{
						return false;
					}
					if (readUncompressedSize)
					{
						zip64Block._uncompressedSize = binaryReader.ReadInt64();
					}
					if (readCompressedSize)
					{
						zip64Block._compressedSize = binaryReader.ReadInt64();
					}
					if (readLocalHeaderOffset)
					{
						zip64Block._localHeaderOffset = binaryReader.ReadInt64();
					}
					if (readStartDiskNumber)
					{
						zip64Block._startDiskNumber = binaryReader.ReadInt32();
					}
					long? uncompressedSize = zip64Block._uncompressedSize;
					if (uncompressedSize.HasValue && uncompressedSize.GetValueOrDefault() < 0)
					{
						throw new ZipArchiveException("FieldTooBigUncompressedSize");
					}
					long? compressedSize = zip64Block._compressedSize;
					if (compressedSize.HasValue && compressedSize.GetValueOrDefault() < 0)
					{
						throw new ZipArchiveException("FieldTooBigCompressedSize");
					}
					long? localHeaderOffset = zip64Block._localHeaderOffset;
					if (localHeaderOffset.HasValue && localHeaderOffset.GetValueOrDefault() < 0)
					{
						throw new ZipArchiveException("FieldTooBigLocalHeaderOffset");
					}
					int? startDiskNumber = zip64Block._startDiskNumber;
					if (startDiskNumber.HasValue && startDiskNumber.GetValueOrDefault() < 0)
					{
						throw new ZipArchiveException("FieldTooBigStartDiskNumber");
					}
					return true;
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					memoryStream.Dispose();
				}
			}
		}
	}
}
