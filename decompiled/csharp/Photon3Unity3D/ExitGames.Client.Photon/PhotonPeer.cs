using System;
using System.Collections.Generic;

namespace ExitGames.Client.Photon;

public class PhotonPeer
{
	public delegate int GetLocalMsTimestampDelegate();

	public static readonly string PhotonPort = "5055";

	internal static short peerCount;

	internal PeerBase peerBase;

	public DebugLevel DebugOut
	{
		get
		{
			return peerBase.debugOut;
		}
		set
		{
			peerBase.debugOut = value;
		}
	}

	public IPhotonPeerListener Listener
	{
		get
		{
			return peerBase.Listener;
		}
		protected set
		{
			peerBase.Listener = value;
		}
	}

	public long BytesIn => peerBase.BytesIn;

	public long BytesOut => peerBase.BytesOut;

	public int ByteCountCurrentDispatch => peerBase.ByteCountCurrentDispatch;

	public int ByteCountLastOperation => peerBase.ByteCountLastOperation;

	public bool TrafficStatsEnabled
	{
		get
		{
			return peerBase.TrafficStatsEnabled;
		}
		set
		{
			peerBase.TrafficStatsEnabled = value;
		}
	}

	public TrafficStats TrafficStatsIncoming => peerBase.TrafficStatsIncoming;

	public TrafficStats TrafficStatsOutgoing => peerBase.TrafficStatsOutgoing;

	public TrafficStatsGameLevel TrafficStatsGameLevel => peerBase.TrafficStatsGameLevel;

	public PeerStateValue PeerState
	{
		get
		{
			if (peerBase.peerConnectionState == PeerBase.ConnectionStateValue.Connected && !peerBase.ApplicationIsInitialized)
			{
				return PeerStateValue.InitializingApplication;
			}
			return (PeerStateValue)peerBase.peerConnectionState;
		}
	}

	public string PeerID => peerBase.PeerID;

	public int CommandBufferSize
	{
		get
		{
			return peerBase.commandBufferSize;
		}
		set
		{
		}
	}

	public int LimitOfUnreliableCommands
	{
		get
		{
			return peerBase.limitOfUnreliableCommands;
		}
		set
		{
			peerBase.limitOfUnreliableCommands = value;
		}
	}

	public int QueuedIncomingCommands => peerBase.QueuedIncomingCommandsCount;

	public int QueuedOutgoingCommands => peerBase.QueuedOutgoingCommandsCount;

	public byte ChannelCount
	{
		get
		{
			return peerBase.ChannelCount;
		}
		set
		{
			if (value == 0 || PeerState != 0)
			{
				throw new Exception("ChannelCount can only be set while disconnected and must be > 0.");
			}
			peerBase.ChannelCount = value;
		}
	}

	public int WarningSize
	{
		get
		{
			return peerBase.warningSize;
		}
		set
		{
			peerBase.warningSize = value;
		}
	}

	public int SentCountAllowance
	{
		get
		{
			return peerBase.sentCountAllowance;
		}
		set
		{
			peerBase.sentCountAllowance = value;
		}
	}

	public int TimePingInterval
	{
		get
		{
			return peerBase.timePingInterval;
		}
		set
		{
			peerBase.timePingInterval = value;
		}
	}

	public int DisconnectTimeout
	{
		get
		{
			return peerBase.DisconnectTimeout;
		}
		set
		{
			peerBase.DisconnectTimeout = value;
		}
	}

	public int ServerTimeInMilliSeconds => peerBase.serverTimeOffsetIsAvailable ? (peerBase.serverTimeOffset + LocalTimeInMilliSeconds) : 0;

	public int LocalTimeInMilliSeconds => peerBase.GetLocalMsTimestamp();

	public GetLocalMsTimestampDelegate LocalMsTimestampDelegate
	{
		set
		{
			if (PeerState != 0)
			{
				throw new Exception("GetLocalMsTimestamp only settable while disconnected. State: " + PeerState);
			}
			peerBase.GetLocalMsTimestamp = value;
		}
	}

	public int RoundTripTime => peerBase.roundTripTime;

	public int RoundTripTimeVariance => peerBase.roundTripTimeVariance;

	public int TimestampOfLastSocketReceive => peerBase.timestampOfLastReceive;

	public string ServerAddress => peerBase.ServerAddress;

	public ConnectionProtocol UsedProtocol => peerBase.usedProtocol;

	public NetworkSimulationSet NetworkSimulationSettings => peerBase.NetworkSimulationSettings;

	public int MaximumTransferUnit
	{
		get
		{
			return peerBase.mtu;
		}
		set
		{
			if (PeerState != 0)
			{
				throw new Exception("MaximumTransferUnit is only settable while disconnected. State: " + PeerState);
			}
			if (value < 520)
			{
				value = 520;
			}
			peerBase.mtu = value;
		}
	}

	public bool IsEncryptionAvailable => peerBase.isEncryptionAvailable;

	public bool IsSendingOnlyAcks
	{
		get
		{
			return peerBase.IsSendingOnlyAcks;
		}
		set
		{
			peerBase.IsSendingOnlyAcks = value;
		}
	}

	public PhotonPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
	{
		if (listener == null)
		{
			throw new SystemException("listener cannot be null");
		}
		switch (protocolType)
		{
		case ConnectionProtocol.Tcp:
			peerBase = new TPeer(listener);
			peerBase.usedProtocol = protocolType;
			break;
		case ConnectionProtocol.Udp:
			peerBase = new EnetPeer(listener);
			peerBase.usedProtocol = protocolType;
			break;
		case ConnectionProtocol.Http:
			peerBase = new HttpBase(listener);
			peerBase.usedProtocol = protocolType;
			break;
		}
	}

	public PhotonPeer(IPhotonPeerListener listener)
		: this(listener, ConnectionProtocol.Udp)
	{
	}

	public PhotonPeer(IPhotonPeerListener listener, bool useTcp)
		: this(listener, useTcp ? ConnectionProtocol.Tcp : ConnectionProtocol.Udp)
	{
	}

	public virtual bool Connect(string serverAddress, string applicationName)
	{
		return peerBase.Connect(serverAddress, applicationName, 0);
	}

	public virtual bool Connect(string serverAddress, string applicationName, byte node)
	{
		return peerBase.Connect(serverAddress, applicationName, node);
	}

	public virtual void Disconnect()
	{
		peerBase.Disconnect();
	}

	public virtual void StopThread()
	{
		peerBase.StopConnection();
	}

	public virtual void FetchServerTimestamp()
	{
		peerBase.FetchServerTimestamp();
	}

	public bool EstablishEncryption()
	{
		return peerBase.ExchangeKeysForEncryption();
	}

	public virtual void Service()
	{
		while (DispatchIncomingCommands())
		{
		}
		SendOutgoingCommands();
	}

	public virtual bool SendOutgoingCommands()
	{
		return peerBase.SendOutgoingCommands();
	}

	public virtual bool DispatchIncomingCommands()
	{
		peerBase.ByteCountCurrentDispatch = 0;
		return peerBase.DispatchIncomingCommands();
	}

	public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable)
	{
		return OpCustom(customOpCode, customOpParameters, sendReliable, 0);
	}

	public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId)
	{
		return peerBase.EnqueueOperation(customOpParameters, customOpCode, sendReliable, channelId, encrypted: false);
	}

	public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId, bool encrypt)
	{
		if (encrypt && !IsEncryptionAvailable)
		{
			throw new ArgumentException("Can't use encryption yet. Exchange keys first.");
		}
		return peerBase.EnqueueOperation(customOpParameters, customOpCode, sendReliable, channelId, encrypt);
	}

	public virtual bool OpCustom(OperationRequest operationRequest, bool sendReliable, byte channelId, bool encrypt)
	{
		if (encrypt && !IsEncryptionAvailable)
		{
			throw new ArgumentException("Can't use encryption yet. Exchange keys first.");
		}
		return peerBase.EnqueueOperation(operationRequest.Parameters, operationRequest.OperationCode, sendReliable, channelId, encrypt);
	}

	public static bool RegisterType(Type customType, byte code, SerializeMethod serializeMethod, DeserializeMethod constructor)
	{
		return Protocol.TryRegisterType(customType, code, serializeMethod, constructor);
	}
}
