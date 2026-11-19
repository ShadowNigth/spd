namespace ExitGames.Client.Photon;

public class TrafficStatsGameLevel
{
	public int OperationByteCount { get; internal set; }

	public int OperationCount { get; internal set; }

	public int ResultByteCount { get; internal set; }

	public int ResultCount { get; internal set; }

	public int EventByteCount { get; internal set; }

	public int EventCount { get; internal set; }

	public int TotalByteCount => OperationByteCount + ResultByteCount + EventByteCount;

	public int TotalMessageCount => OperationCount + ResultCount + EventCount;

	public int TotalIncomingByteCount => ResultByteCount + EventByteCount;

	public int TotalIncomingMessageCount => ResultCount + EventCount;

	public int TotalOutgoingByteCount => OperationByteCount;

	public int TotalOutgoingMessageCount => OperationCount;

	public int TotalCount => OperationByteCount + ResultByteCount + EventByteCount;

	internal void CountOperation(int operationBytes)
	{
		OperationByteCount += operationBytes;
		OperationCount++;
	}

	internal void CountResult(int resultBytes)
	{
		ResultByteCount += resultBytes;
		ResultCount++;
	}

	internal void CountEvent(int eventBytes)
	{
		EventByteCount += eventBytes;
		EventCount++;
	}

	public override string ToString()
	{
		return $"OperationByteCount: {OperationByteCount} ResultByteCount: {ResultByteCount} EventByteCount: {EventByteCount}";
	}
}
