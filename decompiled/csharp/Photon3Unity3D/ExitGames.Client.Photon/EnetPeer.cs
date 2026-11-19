using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExitGames.Client.Photon;

internal class EnetPeer : PeerBase
{
	internal static readonly byte[] udpHeader0xF3 = new byte[2] { 243, 2 };

	private Dictionary<byte, EnetChannel> channels = new Dictionary<byte, EnetChannel>();

	private List<NCommand> sentReliableCommands = new List<NCommand>();

	private List<NCommand> outgoingAcknowledgementsList = new List<NCommand>();

	internal readonly int windowSize = 128;

	internal int[] unsequencedWindow;

	internal int outgoingUnsequencedGroupNumber;

	internal int incomingUnsequencedGroupNumber;

	internal byte udpCommandCount;

	internal byte[] udpBuffer;

	internal int udpBufferIndex;

	internal int commandSize = 12;

	internal int challenge;

	internal NConnect rt;

	internal int ReliableCommandsRepeated;

	internal int packetLoss;

	internal int ReliableCommandsSent;

	internal int packetLossEpoch;

	internal int packetLossVariance;

	internal int packetThrottleEpoch;

	internal int serverSentTime;

	internal static readonly byte[] messageHeader = udpHeader0xF3;

	internal override int QueuedIncomingCommandsCount
	{
		get
		{
			int num = 0;
			foreach (EnetChannel value in channels.Values)
			{
				num += value.incomingReliableCommandsList.Count;
				num += value.incomingUnreliableCommandsList.Count;
			}
			return num;
		}
	}

	internal override int QueuedOutgoingCommandsCount
	{
		get
		{
			int num = 0;
			foreach (EnetChannel value in channels.Values)
			{
				num += value.outgoingReliableCommandsList.Count;
				num += value.outgoingUnreliableCommandsList.Count;
			}
			return num;
		}
	}

	public EnetPeer(IPhotonPeerListener listener)
	{
		if (listener == null)
		{
			throw new SystemException("listener cannot be null");
		}
		PeerBase.peerCount++;
		InitOnce();
		base.Listener = listener;
		TrafficPackageHeaderSize = 12;
	}

	internal override bool Connect(string ipport, string appID, byte nodeId)
	{
		if (peerConnectionState != 0)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "Connect() can't be called if peer is not Disconnected. Not connecting.");
			return false;
		}
		if ((int)debugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "Connect()");
		}
		base.ServerAddress = ipport;
		InitPeerBase();
		if (appID == null)
		{
			appID = "Lite";
		}
		for (int i = 0; i < 32; i++)
		{
			INIT_BYTES[i + 9] = (byte)((i < appID.Length) ? ((byte)appID[i]) : 0);
		}
		rt = new NConnect(this, base.ServerAddress);
		if (rt.StartConnection())
		{
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsOutgoing.ControlCommandBytes += 44;
				TrafficStatsOutgoing.ControlCommandCount++;
			}
			peerConnectionState = ConnectionStateValue.Connecting;
			return true;
		}
		return false;
	}

	internal override void FetchServerTimestamp()
	{
		if (peerConnectionState != ConnectionStateValue.Connected)
		{
			if ((int)debugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "FetchServerTimestamp() was skipped, as the client is not connected. Current ConnectionState: " + peerConnectionState);
			}
			base.Listener.OnStatusChanged(StatusCode.SendError);
		}
		else
		{
			CreateAndEnqueueCommand(12, new byte[0], byte.MaxValue);
		}
	}

	internal override void Disconnect()
	{
		if (peerConnectionState == ConnectionStateValue.Disconnected || peerConnectionState == ConnectionStateValue.Disconnecting)
		{
			return;
		}
		if ((int)debugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "Disconnect()");
		}
		if (outgoingAcknowledgementsList != null)
		{
			lock (outgoingAcknowledgementsList)
			{
				outgoingAcknowledgementsList.Clear();
			}
		}
		if (sentReliableCommands != null)
		{
			lock (sentReliableCommands)
			{
				sentReliableCommands.Clear();
			}
		}
		if (channels != null)
		{
			foreach (EnetChannel value in channels.Values)
			{
				value.clearAll();
			}
		}
		if (peerConnectionState == ConnectionStateValue.Connected)
		{
			NCommand nCommand = new NCommand(this, 4, null, byte.MaxValue);
			queueOutgoingReliableCommand(nCommand);
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsOutgoing.CountControlCommand(nCommand.Size);
			}
			SendOutgoingCommands();
			peerConnectionState = ConnectionStateValue.Disconnecting;
		}
		else
		{
			rt.StopConnection();
		}
	}

	internal void Disconnected()
	{
		InitPeerBase();
		base.Listener.OnStatusChanged(StatusCode.Disconnect);
	}

	internal override void StopConnection()
	{
		rt.StopConnection();
	}

	internal bool CreateAndEnqueueCommand(byte commandType, byte[] payload, byte channelNumber)
	{
		if (payload == null)
		{
			return false;
		}
		EnetChannel enetChannel = channels[channelNumber];
		ByteCountLastOperation = 0;
		int num = mtu - 12 - 32;
		if (payload.Length > num)
		{
			int fragmentCount = (payload.Length + num - 1) / num;
			int startSequenceNumber = enetChannel.outgoingReliableSequenceNumber + 1;
			int num2 = 0;
			for (int i = 0; i < payload.Length; i += num)
			{
				if (payload.Length - i < num)
				{
					num = payload.Length - i;
				}
				byte[] array = new byte[num];
				Array.Copy(payload, i, array, 0, num);
				NCommand nCommand = new NCommand(this, 8, array, enetChannel.ChannelNumber);
				nCommand.fragmentNumber = num2;
				nCommand.startSequenceNumber = startSequenceNumber;
				nCommand.fragmentCount = fragmentCount;
				nCommand.totalLength = payload.Length;
				nCommand.fragmentOffset = i;
				queueOutgoingReliableCommand(nCommand);
				if (base.TrafficStatsEnabled)
				{
					ByteCountLastOperation += nCommand.Size;
					TrafficStatsOutgoing.CountFragmentOpCommand(nCommand.Size);
					TrafficStatsGameLevel.CountOperation(nCommand.Size);
				}
				num2++;
			}
		}
		else
		{
			NCommand nCommand = new NCommand(this, commandType, payload, enetChannel.ChannelNumber);
			if (nCommand.commandFlags == 1)
			{
				queueOutgoingReliableCommand(nCommand);
				if (base.TrafficStatsEnabled)
				{
					ByteCountLastOperation = nCommand.Size;
					TrafficStatsOutgoing.CountReliableOpCommand(nCommand.Size);
					TrafficStatsGameLevel.CountOperation(nCommand.Size);
				}
			}
			else
			{
				queueOutgoingUnreliableCommand(nCommand);
				if (base.TrafficStatsEnabled)
				{
					ByteCountLastOperation = nCommand.Size;
					TrafficStatsOutgoing.CountUnreliableOpCommand(nCommand.Size);
					TrafficStatsGameLevel.CountOperation(nCommand.Size);
				}
			}
		}
		return true;
	}

	internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypt, EgMessageType messageType)
	{
		if (peerConnectionState != ConnectionStateValue.Connected)
		{
			if ((int)debugOut >= 1)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "Cannot send op: Not connected. PeerState: " + peerConnectionState);
			}
			base.Listener.OnStatusChanged(StatusCode.SendError);
			return false;
		}
		if (channelId >= ChannelCount)
		{
			if ((int)debugOut >= 1)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "Cannot send op: Selected channel (" + channelId + ")>= channelCount (" + ChannelCount + ").");
			}
			base.Listener.OnStatusChanged(StatusCode.SendError);
			return false;
		}
		byte[] payload = SerializeOperationToMessage(parameters, opCode, encrypt, messageType);
		return CreateAndEnqueueCommand((byte)(sendReliable ? 6 : 7), payload, channelId);
	}

	internal override void InitPeerBase()
	{
		base.InitPeerBase();
		peerID = -1;
		challenge = SupportClass.ThreadSafeRandom.Next();
		ReliableCommandsSent = 0;
		ReliableCommandsRepeated = 0;
		packetLoss = 0;
		channels = new Dictionary<byte, EnetChannel>();
		channels[byte.MaxValue] = new EnetChannel(byte.MaxValue, commandBufferSize);
		for (byte b = 0; b < ChannelCount; b++)
		{
			channels[b] = new EnetChannel(b, commandBufferSize);
		}
		lock (sentReliableCommands)
		{
			sentReliableCommands = new List<NCommand>(commandBufferSize);
		}
		lock (outgoingAcknowledgementsList)
		{
			outgoingAcknowledgementsList = new List<NCommand>(commandBufferSize);
		}
	}

	internal override bool SendOutgoingCommands()
	{
		if (peerConnectionState == ConnectionStateValue.Disconnected)
		{
			return false;
		}
		if (!rt.isRunning)
		{
			return false;
		}
		int num = 0;
		lock (SendOutgoingLockObject)
		{
			udpBuffer = new byte[mtu];
			udpBufferIndex = 12;
			udpCommandCount = 0;
			timeInt = GetLocalMsTimestamp() - timeBase;
			lock (outgoingAcknowledgementsList)
			{
				if (outgoingAcknowledgementsList.Count > 0)
				{
					num = serializeToBuffer(outgoingAcknowledgementsList);
				}
			}
			if (!isSendingOnlyAcks && timeInt > timeoutInt && sentReliableCommands.Count > 0)
			{
				lock (sentReliableCommands)
				{
					NCommand[] array = new NCommand[sentReliableCommands.Count];
					sentReliableCommands.CopyTo(array);
					NCommand[] array2 = array;
					foreach (NCommand nCommand in array2)
					{
						if (nCommand == null || timeInt - nCommand.commandSentTime <= nCommand.roundTripTimeout)
						{
							continue;
						}
						if (nCommand.commandSentCount > sentCountAllowance || timeInt > nCommand.timeoutTime)
						{
							if ((int)debugOut >= 3)
							{
								base.Listener.DebugReturn(DebugLevel.INFO, string.Concat("Timeout-disconnect! Command: ", nCommand, " now: ", timeInt, " challenge: ", Convert.ToString(challenge, 16)));
							}
							base.Listener.OnStatusChanged(StatusCode.TimeoutDisconnect);
							Disconnected();
							return false;
						}
						queueOutgoingReliableCommand(nCommand);
						sentReliableCommands.Remove(nCommand);
						ReliableCommandsRepeated++;
						if ((int)debugOut >= 3)
						{
							base.Listener.DebugReturn(DebugLevel.INFO, string.Concat("resending command! ", nCommand, " Now=", timeInt, " Rtt/RttV=", roundTripTime, "/", roundTripTimeVariance, "  command.roundTriptimeOut = ", nCommand.roundTripTimeout, "  lastRoundTripTime=", lastRoundTripTime));
						}
					}
				}
			}
			if (!isSendingOnlyAcks && peerConnectionState == ConnectionStateValue.Connected && sentReliableCommands.Count == 0 && timePingInterval > 0 && timeInt - timeLastReceive > timePingInterval && udpBufferIndex + 12 < udpBuffer.Length)
			{
				NCommand nCommand = new NCommand(this, 5, null, byte.MaxValue);
				queueOutgoingReliableCommand(nCommand);
				if (base.TrafficStatsEnabled)
				{
					TrafficStatsOutgoing.CountControlCommand(nCommand.Size);
				}
			}
			if (!isSendingOnlyAcks)
			{
				foreach (EnetChannel value in channels.Values)
				{
					num += serializeToBuffer(value.outgoingReliableCommandsList);
					num += serializeToBuffer(value.outgoingUnreliableCommandsList);
				}
			}
			if (udpCommandCount <= 0)
			{
				return false;
			}
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsOutgoing.TotalPacketCount++;
				TrafficStatsOutgoing.TotalCommandsInPackets += udpCommandCount;
			}
			Array.Resize(ref udpBuffer, udpBufferIndex);
			sendData(udpBuffer);
		}
		return num > 0;
	}

	internal void sendData(byte[] data)
	{
		try
		{
			SupportClass.NumberToByteArray(data, 0, peerID);
			data[2] = 0;
			data[3] = udpCommandCount;
			SupportClass.NumberToByteArray(data, 4, timeInt);
			SupportClass.NumberToByteArray(data, 8, challenge);
			int length = data.Length;
			bytesOut += length;
			if (base.NetworkSimulationSettings.IsSimulationEnabled)
			{
				SendNetworkSimulated(delegate
				{
					rt.SendUdpPackage(data, length);
				});
			}
			else
			{
				rt.SendUdpPackage(data, length);
			}
		}
		catch (Exception ex)
		{
			if ((int)debugOut >= 1)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, ex.ToString());
			}
			SupportClass.WriteStackTrace(ex, Console.Error);
		}
	}

	internal int serializeToBuffer(IList commandList)
	{
		while (commandList.Count > 0)
		{
			if (commandList[0] == null)
			{
				commandList.RemoveAt(0);
				continue;
			}
			NCommand nCommand = (NCommand)commandList[0];
			if (udpBufferIndex + nCommand.Size > udpBuffer.Length)
			{
				if ((int)debugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, "UDP package is full. Commands in Package: " + udpCommandCount + ". Commands left in queue: " + commandList.Count);
				}
				break;
			}
			Array.Copy(nCommand.Serialize(), 0, udpBuffer, udpBufferIndex, nCommand.Size);
			udpBufferIndex += nCommand.Size;
			udpCommandCount++;
			if ((nCommand.commandFlags & 1) > 0)
			{
				queueSentCommand(nCommand);
			}
			commandList.RemoveAt(0);
		}
		return commandList.Count;
	}

	internal void queueSentCommand(NCommand command)
	{
		command.commandSentTime = timeInt;
		command.commandSentCount++;
		if (command.roundTripTimeout == 0)
		{
			command.roundTripTimeout = roundTripTime + 4 * roundTripTimeVariance;
			command.timeoutTime = timeInt + DisconnectTimeout;
		}
		else
		{
			command.roundTripTimeout *= 2;
		}
		lock (sentReliableCommands)
		{
			if (sentReliableCommands.Count == 0)
			{
				timeoutInt = command.commandSentTime + command.roundTripTimeout;
			}
			ReliableCommandsSent++;
			sentReliableCommands.Add(command);
		}
		if (sentReliableCommands.Count >= warningSize && sentReliableCommands.Count % warningSize == 0)
		{
			base.Listener.OnStatusChanged(StatusCode.QueueSentWarning);
		}
	}

	internal void queueOutgoingReliableCommand(NCommand command)
	{
		IList outgoingReliableCommandsList = channels[command.commandChannelID].outgoingReliableCommandsList;
		if (outgoingReliableCommandsList.Count >= warningSize && outgoingReliableCommandsList.Count % warningSize == 0)
		{
			base.Listener.OnStatusChanged(StatusCode.QueueOutgoingReliableWarning);
		}
		if (command.reliableSequenceNumber == 0)
		{
			EnetChannel enetChannel = channels[command.commandChannelID];
			command.reliableSequenceNumber = ++enetChannel.outgoingReliableSequenceNumber;
		}
		outgoingReliableCommandsList.Add(command);
	}

	internal void queueOutgoingUnreliableCommand(NCommand command)
	{
		IList outgoingUnreliableCommandsList = channels[command.commandChannelID].outgoingUnreliableCommandsList;
		if (outgoingUnreliableCommandsList.Count >= warningSize && outgoingUnreliableCommandsList.Count % warningSize == 0)
		{
			base.Listener.OnStatusChanged(StatusCode.QueueOutgoingUnreliableWarning);
		}
		EnetChannel enetChannel = channels[command.commandChannelID];
		command.reliableSequenceNumber = enetChannel.outgoingReliableSequenceNumber;
		command.unreliableSequenceNumber = ++enetChannel.outgoingUnreliableSequenceNumber;
		outgoingUnreliableCommandsList.Add(command);
	}

	internal void queueOutgoingAcknowledgement(NCommand command)
	{
		lock (outgoingAcknowledgementsList)
		{
			if (outgoingAcknowledgementsList.Count >= warningSize && outgoingAcknowledgementsList.Count % warningSize == 0)
			{
				base.Listener.OnStatusChanged(StatusCode.QueueOutgoingAcksWarning);
			}
			outgoingAcknowledgementsList.Add(command);
		}
	}

	internal override bool DispatchIncomingCommands()
	{
		lock (ActionQueue)
		{
			if (ActionQueue.Count > 0)
			{
				foreach (MyAction item in ActionQueue)
				{
					item();
				}
			}
			ActionQueue.Clear();
		}
		NCommand nCommand = null;
		foreach (EnetChannel value in channels.Values)
		{
			value.SortIfNeeded(limitOfUnreliableCommands);
			if (value.incomingUnreliableCommandsList.Count > 0)
			{
				nCommand = value.incomingUnreliableCommandsList[0];
				if (nCommand != null && nCommand.unreliableSequenceNumber > 0)
				{
					if (nCommand.reliableSequenceNumber <= value.incomingReliableSequenceNumber)
					{
						value.incomingUnreliableSequenceNumber = nCommand.unreliableSequenceNumber;
						value.incomingUnreliableCommandsList.RemoveAt(0);
						break;
					}
					nCommand = null;
				}
			}
			if (nCommand != null || value.incomingReliableCommandsList.Count <= 0)
			{
				continue;
			}
			do
			{
				nCommand = value.incomingReliableCommandsList[0];
				if (nCommand == null)
				{
					break;
				}
				if (nCommand.reliableSequenceNumber > value.incomingReliableSequenceNumber + 1)
				{
					nCommand = null;
					break;
				}
				if (nCommand.reliableSequenceNumber <= value.incomingReliableSequenceNumber)
				{
					value.incomingReliableCommandsList.RemoveAt(0);
					if ((int)debugOut >= 3)
					{
						base.Listener.DebugReturn(DebugLevel.INFO, string.Concat("Info: skipped Dispatch of old command ", nCommand, ". IncomingReliableSeqNr: ", value.incomingReliableSequenceNumber));
					}
					nCommand = null;
				}
			}
			while (nCommand == null && value.incomingReliableCommandsList.Count > 0);
			if (nCommand == null)
			{
				continue;
			}
			if (nCommand.commandType != 8)
			{
				value.incomingReliableSequenceNumber = nCommand.reliableSequenceNumber;
				value.incomingReliableCommandsList.RemoveAt(0);
				break;
			}
			if (nCommand.fragmentsRemaining > 0)
			{
				nCommand = null;
				break;
			}
			byte[] array = new byte[nCommand.totalLength];
			for (int i = nCommand.startSequenceNumber; i < nCommand.startSequenceNumber + nCommand.fragmentCount; i++)
			{
				if (value.ContainsReliableSequenceNumber(i))
				{
					NCommand nCommand2 = value.FetchReliableSequenceNumber(i);
					Array.Copy(nCommand2.Payload, 0, array, nCommand2.fragmentOffset, nCommand2.Payload.Length);
					value.incomingReliableCommandsList.Remove(nCommand2);
					continue;
				}
				throw new Exception("command.fragmentsRemaining was 0, but not all fragments are found to be combined!");
			}
			if ((int)debugOut >= 5)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "assembled fragmented payload from " + nCommand.fragmentCount + " parts. Dispatching now.");
			}
			nCommand.Payload = array;
			value.incomingReliableSequenceNumber = nCommand.reliableSequenceNumber + nCommand.fragmentCount - 1;
			break;
		}
		if (nCommand != null && nCommand.Payload != null)
		{
			ByteCountCurrentDispatch = nCommand.Size;
			if (DeserializeMessageAndCallback(nCommand.Payload))
			{
				return true;
			}
		}
		return false;
	}

	internal override void receiveIncomingCommands(byte[] inBuff)
	{
		timestampOfLastReceive = GetLocalMsTimestamp();
		using MemoryStream input = new MemoryStream(inBuff);
		using BinaryReader binaryReader = new BinaryReader(input);
		try
		{
			short num = Protocol.deserializeShort(binaryReader);
			byte b = binaryReader.ReadByte();
			byte b2 = binaryReader.ReadByte();
			int sentTime = Protocol.deserializeInteger(binaryReader);
			int num2 = Protocol.deserializeInteger(binaryReader);
			bytesIn += 12L;
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.TotalPacketCount++;
				TrafficStatsIncoming.TotalCommandsInPackets += b2;
			}
			serverSentTime = sentTime;
			if (b2 > commandBufferSize)
			{
				EnqueueDebugReturn(DebugLevel.ALL, "too many incoming commands in packet: " + b2 + " > " + commandBufferSize);
			}
			if (num2 != challenge)
			{
				if (peerConnectionState != 0 && (int)debugOut >= 5)
				{
					EnqueueDebugReturn(DebugLevel.ALL, "Info: received package with wrong challenge. challenge in/out:" + num2 + "!=" + challenge + " Commands in it: " + b2);
				}
				return;
			}
			timeInt = GetLocalMsTimestamp() - timeBase;
			for (int i = 0; i < b2; i++)
			{
				NCommand readCommand = new NCommand(this, binaryReader);
				if (readCommand.commandType != 1)
				{
					EnqueueActionForDispatch(delegate
					{
						executeCommand(readCommand);
					});
				}
				else
				{
					executeCommand(readCommand);
				}
				if ((readCommand.commandFlags & 1) > 0)
				{
					NCommand nCommand = NCommand.CreateAck(this, readCommand, sentTime);
					queueOutgoingAcknowledgement(nCommand);
					if (base.TrafficStatsEnabled)
					{
						TrafficStatsOutgoing.CountControlCommand(nCommand.Size);
					}
				}
			}
		}
		catch (Exception ex)
		{
			if ((int)debugOut >= 1)
			{
				EnqueueDebugReturn(DebugLevel.ERROR, $"Exception while reading commands from incoming data: {ex}");
			}
			SupportClass.WriteStackTrace(ex, Console.Error);
		}
	}

	internal bool executeCommand(NCommand command)
	{
		bool flag = true;
		switch (command.commandType)
		{
		case 2:
		case 5:
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.CountControlCommand(command.Size);
			}
			break;
		case 4:
		{
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.CountControlCommand(command.Size);
			}
			StatusCode statusCode = StatusCode.DisconnectByServer;
			if (command.reservedByte == 1)
			{
				statusCode = StatusCode.DisconnectByServerLogic;
			}
			else if (command.reservedByte == 3)
			{
				statusCode = StatusCode.DisconnectByServerUserLimit;
			}
			if ((int)debugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "Server sent disconnect. PeerId: " + peerID + " RTT/Variance:" + roundTripTime + "/" + roundTripTimeVariance);
			}
			base.Listener.OnStatusChanged(statusCode);
			rt.StopConnection();
			break;
		}
		case 1:
		{
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.CountControlCommand(command.Size);
			}
			timeLastReceive = timeInt;
			lastRoundTripTime = timeInt - command.ackReceivedSentTime;
			NCommand nCommand = removeSentReliableCommand(command.ackReceivedReliableSequenceNumber, command.commandChannelID);
			if (nCommand == null)
			{
				break;
			}
			if (nCommand.commandType == 12)
			{
				if (lastRoundTripTime <= roundTripTime)
				{
					serverTimeOffset = serverSentTime + (lastRoundTripTime >> 1) - GetLocalMsTimestamp();
					serverTimeOffsetIsAvailable = true;
				}
				else
				{
					FetchServerTimestamp();
				}
				break;
			}
			UpdateRoundTripTimeAndVariance(lastRoundTripTime);
			if (nCommand.commandType == 4 && peerConnectionState == ConnectionStateValue.Disconnecting)
			{
				if ((int)debugOut >= 3)
				{
					EnqueueDebugReturn(DebugLevel.INFO, "Received disconnect ACK by server");
				}
				EnqueueActionForDispatch(delegate
				{
					rt.StopConnection();
				});
			}
			else if (nCommand.commandType == 2)
			{
				roundTripTime = lastRoundTripTime;
			}
			break;
		}
		case 6:
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.CountReliableOpCommand(command.Size);
			}
			if (peerConnectionState == ConnectionStateValue.Connected)
			{
				flag = queueIncomingCommand(command);
			}
			break;
		case 7:
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.CountUnreliableOpCommand(command.Size);
			}
			if (peerConnectionState == ConnectionStateValue.Connected)
			{
				flag = queueIncomingCommand(command);
			}
			break;
		case 8:
		{
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.CountFragmentOpCommand(command.Size);
			}
			if (peerConnectionState != ConnectionStateValue.Connected)
			{
				break;
			}
			if (command.fragmentNumber > command.fragmentCount || command.fragmentOffset >= command.totalLength || command.fragmentOffset + command.Payload.Length > command.totalLength)
			{
				if ((int)debugOut >= 1)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "Received fragment has bad size: " + command);
				}
				break;
			}
			flag = queueIncomingCommand(command);
			if (!flag)
			{
				break;
			}
			EnetChannel enetChannel = channels[command.commandChannelID];
			if (command.reliableSequenceNumber == command.startSequenceNumber)
			{
				command.fragmentsRemaining--;
				int num = command.startSequenceNumber + 1;
				while (command.fragmentsRemaining > 0 && num < command.startSequenceNumber + command.fragmentCount)
				{
					if (enetChannel.ContainsReliableSequenceNumber(num++))
					{
						command.fragmentsRemaining--;
					}
				}
			}
			else if (enetChannel.ContainsReliableSequenceNumber(command.startSequenceNumber))
			{
				NCommand nCommand2 = enetChannel.FetchReliableSequenceNumber(command.startSequenceNumber);
				nCommand2.fragmentsRemaining--;
			}
			break;
		}
		case 3:
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsIncoming.CountControlCommand(command.Size);
			}
			if (peerConnectionState == ConnectionStateValue.Connecting)
			{
				command = new NCommand(this, 6, INIT_BYTES, 0);
				queueOutgoingReliableCommand(command);
				if (base.TrafficStatsEnabled)
				{
					TrafficStatsOutgoing.CountControlCommand(command.Size);
				}
				peerConnectionState = ConnectionStateValue.Connected;
			}
			break;
		}
		return flag;
	}

	internal bool queueIncomingCommand(NCommand command)
	{
		EnetChannel value = null;
		channels.TryGetValue(command.commandChannelID, out value);
		if (value == null)
		{
			if ((int)debugOut >= 1)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "Received command for non-existing channel: " + command.commandChannelID);
			}
			return false;
		}
		if ((int)debugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, string.Concat("queueIncomingCommand( ", command, " )  -  incomingReliableSequenceNumber: ", value.incomingReliableSequenceNumber));
		}
		if (command.commandFlags == 1)
		{
			if (command.reliableSequenceNumber <= value.incomingReliableSequenceNumber)
			{
				if ((int)debugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, "incoming command " + command.ToString() + " is old (not saving it). Dispatched incomingReliableSequenceNumber: " + value.incomingReliableSequenceNumber);
				}
				return false;
			}
			if (value.ContainsReliableSequenceNumber(command.reliableSequenceNumber))
			{
				if ((int)debugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, string.Concat("Info: command was received before! Old/New: ", value.FetchReliableSequenceNumber(command.reliableSequenceNumber), "/", command, " inReliableSeq#: ", value.incomingReliableSequenceNumber, " first in queue: ", value.incomingReliableCommandsList[0]));
				}
				return false;
			}
			if (value.incomingReliableCommandsList.Count >= warningSize && value.incomingReliableCommandsList.Count % warningSize == 0)
			{
				base.Listener.OnStatusChanged(StatusCode.QueueIncomingReliableWarning);
			}
			value.incomingReliableCommandsList.Add(command);
			value.incomingReliableCommandsListNeedsSort = true;
			return true;
		}
		if (command.commandFlags == 0)
		{
			if ((int)debugOut >= 5)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "unreliable. local: " + value.incomingReliableSequenceNumber + "/" + value.incomingUnreliableSequenceNumber + " incoming: " + command.reliableSequenceNumber + "/" + command.unreliableSequenceNumber);
			}
			if (command.reliableSequenceNumber < value.incomingReliableSequenceNumber)
			{
				if ((int)debugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, "incoming reliable-seq# < Dispatched-rel-seq#. not saved.");
				}
				return true;
			}
			if (command.unreliableSequenceNumber <= value.incomingUnreliableSequenceNumber)
			{
				if ((int)debugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, "incoming unreliable-seq# < Dispatched-unrel-seq#. not saved.");
				}
				return true;
			}
			if (value.ContainsUnreliableSequenceNumber(command.unreliableSequenceNumber))
			{
				if ((int)debugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, string.Concat("command was received before! Old/New: ", value.incomingUnreliableCommandsList[command.unreliableSequenceNumber], "/", command));
				}
				return false;
			}
			if (value.incomingUnreliableCommandsList.Count >= warningSize && value.incomingUnreliableCommandsList.Count % warningSize == 0)
			{
				base.Listener.OnStatusChanged(StatusCode.QueueIncomingUnreliableWarning);
			}
			value.incomingUnreliableCommandsList.Add(command);
			value.incomingUnreliableCommandsListNeedSort = true;
			return true;
		}
		return false;
	}

	internal NCommand removeSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel)
	{
		NCommand nCommand = null;
		lock (sentReliableCommands)
		{
			foreach (NCommand sentReliableCommand in sentReliableCommands)
			{
				if (sentReliableCommand != null && sentReliableCommand.reliableSequenceNumber == ackReceivedReliableSequenceNumber && sentReliableCommand.commandChannelID == ackReceivedChannel)
				{
					nCommand = sentReliableCommand;
					break;
				}
			}
			if (nCommand != null)
			{
				sentReliableCommands.Remove(nCommand);
				if (sentReliableCommands.Count > 0)
				{
					timeoutInt = sentReliableCommands[0].commandSentTime + sentReliableCommands[0].roundTripTimeout;
				}
			}
			else if ((int)debugOut >= 5 && peerConnectionState != ConnectionStateValue.Connected && peerConnectionState != ConnectionStateValue.Disconnecting)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, $"No sent command for ACK (Ch: {ackReceivedReliableSequenceNumber} Sq#: {ackReceivedChannel}). PeerState: {peerConnectionState}.");
			}
		}
		return nCommand;
	}

	internal override byte[] SerializeOperationToMessage(Dictionary<byte, object> parameters, byte opc, bool encrypt, EgMessageType messageType)
	{
		byte[] array = Protocol.SerializeOperationRequest(parameters, opc);
		byte[] array2 = null;
		if (array != null)
		{
			if (encrypt)
			{
				array = CryptoProvider.Encrypt(array);
			}
			array2 = new byte[messageHeader.Length + array.Length];
			Buffer.BlockCopy(messageHeader, 0, array2, 0, messageHeader.Length);
			Buffer.BlockCopy(array, 0, array2, messageHeader.Length, array.Length);
			if (messageType != EgMessageType.Operation)
			{
				array2[messageHeader.Length - 1] = (byte)messageType;
			}
			if (encrypt)
			{
				array2[messageHeader.Length - 1] = (byte)(array2[messageHeader.Length - 1] | 0x80u);
			}
		}
		else
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, $"Error serializing operation! OpCode: {opc} Parameters: {SupportClass.DictionaryToString(parameters)}");
		}
		return array2;
	}

	internal string commandListToString(NCommand[] list)
	{
		if ((int)debugOut < 5)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < list.Length; i++)
		{
			stringBuilder.Append(i + "=");
			stringBuilder.Append(list[i]);
			stringBuilder.Append(" # ");
		}
		return stringBuilder.ToString();
	}
}
