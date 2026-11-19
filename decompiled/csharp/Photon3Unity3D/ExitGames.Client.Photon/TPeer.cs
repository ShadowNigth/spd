using System;
using System.Collections.Generic;
using System.IO;

namespace ExitGames.Client.Photon;

internal class TPeer : PeerBase
{
	internal static readonly byte[] tcpHead = new byte[9] { 251, 0, 0, 0, 0, 0, 0, 243, 2 };

	internal TConnect rt;

	private List<byte[]> outgoingOpList = new List<byte[]>();

	private List<byte[]> incomingList = new List<byte[]>();

	private int lastPingResult;

	private byte[] pingRequest = new byte[5] { 240, 0, 0, 0, 0 };

	private byte proxyNodeId = 0;

	internal static readonly byte[] messageHeader = tcpHead;

	internal override int QueuedIncomingCommandsCount => incomingList.Count;

	internal override int QueuedOutgoingCommandsCount => outgoingOpList.Count;

	internal byte ProxyNodeId => proxyNodeId;

	public TPeer(IPhotonPeerListener listener)
	{
		if (listener == null)
		{
			throw new SystemException("listener cannot be null");
		}
		PeerBase.peerCount++;
		InitOnce();
		base.Listener = listener;
	}

	internal override bool Connect(string serverAddress, string appID, byte nodeId)
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
		base.ServerAddress = serverAddress;
		proxyNodeId = nodeId;
		InitPeerBase();
		if (appID == null)
		{
			appID = "Lite";
		}
		for (int i = 0; i < 32; i++)
		{
			INIT_BYTES[i + 9] = (byte)((i < appID.Length) ? ((byte)appID[i]) : 0);
		}
		rt = new TConnect(this, base.ServerAddress);
		if (rt.StartConnection())
		{
			peerConnectionState = ConnectionStateValue.Connecting;
			if (proxyNodeId > 0)
			{
				SendProxyInit();
			}
			EnqueueInit();
			SendOutgoingCommands();
			return true;
		}
		return false;
	}

	private void SendProxyInit()
	{
		if (proxyNodeId != 0)
		{
			byte[] array = new byte[2] { 241, proxyNodeId };
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsOutgoing.TotalPacketCount++;
				TrafficStatsOutgoing.TotalCommandsInPackets++;
				TrafficStatsOutgoing.CountControlCommand(array.Length);
			}
			rt.sendTcp(array);
		}
	}

	private void EnqueueInit()
	{
		MemoryStream memoryStream = new MemoryStream(0);
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		byte[] array = new byte[7] { 251, 0, 0, 0, 0, 0, 1 };
		SupportClass.NumberToByteArray(array, 1, INIT_BYTES.Length + array.Length);
		binaryWriter.Write(array);
		binaryWriter.Write(INIT_BYTES);
		byte[] array2 = memoryStream.ToArray();
		if (base.TrafficStatsEnabled)
		{
			TrafficStatsOutgoing.TotalPacketCount++;
			TrafficStatsOutgoing.TotalCommandsInPackets++;
			TrafficStatsOutgoing.CountControlCommand(array2.Length);
		}
		EnqueueMessageAsPayload(sendReliable: true, array2, 0);
	}

	internal override void Disconnect()
	{
		if (peerConnectionState != 0 && peerConnectionState != ConnectionStateValue.Disconnecting)
		{
			if ((int)debugOut >= 5)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "Disconnect()");
			}
			peerConnectionState = ConnectionStateValue.Disconnecting;
			outgoingOpList.Clear();
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

	internal bool EnqueueMessageAsPayload(bool sendReliable, byte[] opMessage, byte channelId)
	{
		if (opMessage == null)
		{
			return false;
		}
		opMessage[5] = channelId;
		opMessage[6] = (byte)(sendReliable ? 1 : 0);
		outgoingOpList.Add(opMessage);
		if (outgoingOpList.Count % warningSize == 0)
		{
			base.Listener.OnStatusChanged(StatusCode.QueueOutgoingReliableWarning);
		}
		ByteCountLastOperation = opMessage.Length;
		if (base.TrafficStatsEnabled)
		{
			if (sendReliable)
			{
				TrafficStatsOutgoing.CountReliableOpCommand(opMessage.Length);
			}
			else
			{
				TrafficStatsOutgoing.CountUnreliableOpCommand(opMessage.Length);
			}
			TrafficStatsGameLevel.CountOperation(opMessage.Length);
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
		byte[] opMessage = SerializeOperationToMessage(parameters, opCode, encrypt, messageType);
		return EnqueueMessageAsPayload(sendReliable, opMessage, channelId);
	}

	internal override void InitPeerBase()
	{
		base.InitPeerBase();
		outgoingOpList = new List<byte[]>();
		incomingList = new List<byte[]>();
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
		if (peerConnectionState == ConnectionStateValue.Connected && GetLocalMsTimestamp() - lastPingResult > timePingInterval)
		{
			SendPing();
		}
		if (outgoingOpList.Count > 0)
		{
			List<byte[]> list = outgoingOpList;
			outgoingOpList = new List<byte[]>();
			for (int i = 0; i < list.Count; i++)
			{
				sendData(list[i]);
			}
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
			SendPing();
			serverTimeOffsetIsAvailable = false;
		}
	}

	private void SendPing()
	{
		SupportClass.NumberToByteArray(pingRequest, 1, GetLocalMsTimestamp());
		lastPingResult = GetLocalMsTimestamp();
		if (base.TrafficStatsEnabled)
		{
			TrafficStatsOutgoing.CountControlCommand(pingRequest.Length);
		}
		sendData(pingRequest);
	}

	internal void sendData(byte[] data)
	{
		try
		{
			bytesOut += data.Length;
			if (base.TrafficStatsEnabled)
			{
				TrafficStatsOutgoing.TotalPacketCount++;
				TrafficStatsOutgoing.TotalCommandsInPackets++;
			}
			if (base.NetworkSimulationSettings.IsSimulationEnabled)
			{
				SendNetworkSimulated(delegate
				{
					rt.sendTcp(data);
				});
			}
			else
			{
				rt.sendTcp(data);
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
		byte[] array;
		lock (incomingList)
		{
			if (incomingList.Count <= 0)
			{
				return false;
			}
			array = incomingList[0];
			incomingList.RemoveAt(0);
		}
		ByteCountCurrentDispatch = array.Length + 3;
		return DeserializeMessageAndCallback(array);
	}

	internal override void receiveIncomingCommands(byte[] inbuff)
	{
		if (inbuff == null)
		{
			if ((int)debugOut >= 1)
			{
				EnqueueDebugReturn(DebugLevel.ERROR, "checkAndQueueIncomingCommands() inBuff: null");
			}
			return;
		}
		timestampOfLastReceive = GetLocalMsTimestamp();
		bytesIn += inbuff.Length + 7;
		if (base.TrafficStatsEnabled)
		{
			TrafficStatsIncoming.TotalPacketCount++;
			TrafficStatsIncoming.TotalCommandsInPackets++;
		}
		if (inbuff[0] == 243 || inbuff[0] == 244)
		{
			lock (incomingList)
			{
				incomingList.Add(inbuff);
				if (incomingList.Count % warningSize == 0)
				{
					EnqueueStatusCallback(StatusCode.QueueIncomingReliableWarning);
				}
				return;
			}
		}
		if (inbuff[0] == 240)
		{
			ReadPingResult(inbuff);
		}
		else if ((int)debugOut >= 1)
		{
			EnqueueDebugReturn(DebugLevel.ERROR, "receiveIncomingCommands() MagicNumber should be 0xF0, 0xF3 or 0xF4. Is: " + inbuff[0]);
		}
	}

	internal void ReceiveProxyResponse(byte proxyResponseByte)
	{
		switch (proxyResponseByte)
		{
		case 0:
			base.Listener.OnStatusChanged(StatusCode.TcpRouterResponseOk);
			break;
		case 1:
			base.Listener.OnStatusChanged(StatusCode.TcpRouterResponseNodeIdUnknown);
			Disconnected();
			break;
		case 2:
			base.Listener.OnStatusChanged(StatusCode.TcpRouterResponseEndpointUnknown);
			Disconnected();
			break;
		case 16:
			base.Listener.OnStatusChanged(StatusCode.TcpRouterResponseNodeNotReady);
			Disconnected();
			break;
		default:
			base.Listener.DebugReturn(DebugLevel.ERROR, string.Format("ERROR: Unknown Proxy-Response: {0}" + proxyResponseByte));
			Disconnected();
			break;
		}
	}

	private void ReadPingResult(byte[] inbuff)
	{
		BinaryReader din = new BinaryReader(new MemoryStream(inbuff, 1, 8));
		int num = Protocol.deserializeInteger(din);
		int num2 = Protocol.deserializeInteger(din);
		lastRoundTripTime = GetLocalMsTimestamp() - num2;
		if (!serverTimeOffsetIsAvailable)
		{
			roundTripTime = lastRoundTripTime;
		}
		UpdateRoundTripTimeAndVariance(lastRoundTripTime);
		if (!serverTimeOffsetIsAvailable)
		{
			serverTimeOffset = num + (lastRoundTripTime >> 1) - GetLocalMsTimestamp();
			serverTimeOffsetIsAvailable = true;
		}
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
			SupportClass.NumberToByteArray(array2, 1, array2.Length);
		}
		else
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, $"Error serializing operation! OpCode: {opc} Parameters: {SupportClass.DictionaryToString(parameters)}");
		}
		return array2;
	}
}
