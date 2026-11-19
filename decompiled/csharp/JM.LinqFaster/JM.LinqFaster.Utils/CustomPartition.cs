using System;
using System.Collections.Concurrent;

namespace JM.LinqFaster.Utils;

internal static class CustomPartition
{
	public static OrderablePartitioner<Tuple<int, int>> MakePartition(int len, int? batchSize)
	{
		if (!batchSize.HasValue)
		{
			return Partitioner.Create(0, len);
		}
		return Partitioner.Create(0, len, batchSize.Value);
	}

	public static OrderablePartitioner<Tuple<int, int>> MakeSIMDPartition(int len, int chunkSize, int? batchSize)
	{
		int num = (len - len % chunkSize) / chunkSize;
		if (!batchSize.HasValue)
		{
			return Partitioner.Create(0, num, num / Environment.ProcessorCount);
		}
		return Partitioner.Create(0, num, batchSize.Value);
	}
}
