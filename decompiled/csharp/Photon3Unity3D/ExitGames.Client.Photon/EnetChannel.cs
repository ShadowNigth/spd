using System.Collections.Generic;

namespace ExitGames.Client.Photon;

internal class EnetChannel
{
	internal byte ChannelNumber;

	internal List<NCommand> incomingReliableCommandsList;

	internal List<NCommand> incomingUnreliableCommandsList;

	internal List<NCommand> outgoingReliableCommandsList;

	internal List<NCommand> outgoingUnreliableCommandsList;

	internal int incomingReliableSequenceNumber;

	internal int incomingUnreliableSequenceNumber;

	internal int outgoingReliableSequenceNumber;

	internal int outgoingUnreliableSequenceNumber;

	public bool incomingReliableCommandsListNeedsSort;

	public bool incomingUnreliableCommandsListNeedSort;

	public EnetChannel(byte channelNumber, int commandBufferSize)
	{
		ChannelNumber = channelNumber;
		incomingReliableCommandsList = new List<NCommand>(commandBufferSize);
		incomingUnreliableCommandsList = new List<NCommand>(commandBufferSize);
		outgoingReliableCommandsList = new List<NCommand>(commandBufferSize);
		outgoingUnreliableCommandsList = new List<NCommand>(commandBufferSize);
	}

	public void SortIfNeeded(int numberOfUnreliableCommandsToKeep)
	{
		if (incomingReliableCommandsListNeedsSort)
		{
			incomingReliableCommandsListNeedsSort = false;
			if (incomingReliableCommandsList.Count > 1)
			{
				incomingReliableCommandsList.Sort();
			}
		}
		if (!incomingUnreliableCommandsListNeedSort)
		{
			return;
		}
		incomingUnreliableCommandsListNeedSort = false;
		if (incomingUnreliableCommandsList.Count <= 1)
		{
			return;
		}
		if (numberOfUnreliableCommandsToKeep > 0)
		{
			int num = incomingUnreliableCommandsList.Count - numberOfUnreliableCommandsToKeep;
			if (num > 0)
			{
				incomingUnreliableCommandsList.RemoveRange(0, num);
			}
		}
		incomingUnreliableCommandsList.Sort();
	}

	public bool ContainsUnreliableSequenceNumber(int unreliableSequenceNumber)
	{
		if (!incomingReliableCommandsListNeedsSort)
		{
			foreach (NCommand incomingUnreliableCommands in incomingUnreliableCommandsList)
			{
				if (incomingUnreliableCommands.unreliableSequenceNumber == unreliableSequenceNumber)
				{
					return true;
				}
				if (incomingUnreliableCommands.unreliableSequenceNumber > unreliableSequenceNumber)
				{
					return false;
				}
			}
		}
		else
		{
			foreach (NCommand incomingUnreliableCommands2 in incomingUnreliableCommandsList)
			{
				if (incomingUnreliableCommands2.unreliableSequenceNumber == unreliableSequenceNumber)
				{
					return true;
				}
			}
		}
		return false;
	}

	public NCommand FetchUnreliableSequenceNumber(int unreliableSequenceNumber)
	{
		foreach (NCommand incomingUnreliableCommands in incomingUnreliableCommandsList)
		{
			if (incomingUnreliableCommands.unreliableSequenceNumber == unreliableSequenceNumber)
			{
				return incomingUnreliableCommands;
			}
		}
		return null;
	}

	public bool ContainsReliableSequenceNumber(int reliableSequenceNumber)
	{
		if (!incomingReliableCommandsListNeedsSort)
		{
			foreach (NCommand incomingReliableCommands in incomingReliableCommandsList)
			{
				if (incomingReliableCommands.reliableSequenceNumber == reliableSequenceNumber)
				{
					return true;
				}
				if (incomingReliableCommands.reliableSequenceNumber > reliableSequenceNumber)
				{
					return false;
				}
			}
		}
		else
		{
			foreach (NCommand incomingReliableCommands2 in incomingReliableCommandsList)
			{
				if (incomingReliableCommands2.reliableSequenceNumber == reliableSequenceNumber)
				{
					return true;
				}
			}
		}
		return false;
	}

	public NCommand FetchReliableSequenceNumber(int reliableSequenceNumber)
	{
		foreach (NCommand incomingReliableCommands in incomingReliableCommandsList)
		{
			if (incomingReliableCommands.reliableSequenceNumber == reliableSequenceNumber)
			{
				return incomingReliableCommands;
			}
		}
		return null;
	}

	public void clearAll()
	{
		incomingReliableCommandsList.Clear();
		incomingUnreliableCommandsList.Clear();
		outgoingReliableCommandsList.Clear();
		outgoingUnreliableCommandsList.Clear();
	}
}
