using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;

namespace ExitGames.Client.Photon;

internal class HttpBase : PeerBase
{
	private class AsyncRequestState
	{
		private Stopwatch Watch;

		public HttpBase Base { get; set; }

		public WWW Request { get; set; }

		public byte[] OutgoingData { get; set; }

		public int ElapsedTime => (int)Watch.ElapsedMilliseconds;

		public bool Aborted { get; set; }

		public AsyncRequestState()
		{
			Watch = new Stopwatch();
			Watch.Start();
		}
	}

	private string HttpPeerID;

	private string UrlParameters;

	private List<WWW> webRequests = new List<WWW>();

	internal static readonly byte[] messageHeader = new byte[2] { 243, 2 };

	private static int DefaultTimeout = 10000;

	public override string PeerID => HttpPeerID;

	internal override int QueuedIncomingCommandsCount => 0;

	internal override int QueuedOutgoingCommandsCount => 0;

	public HttpBase(IPhotonPeerListener listener)
	{
		PeerBase.peerCount++;
		base.Listener = listener;
		usedProtocol = ConnectionProtocol.Http;
	}

	private string GetRequestUri()
	{
		return base.ServerAddress + UrlParameters;
	}

	internal void Request(byte[] data)
	{
		if ((int)debugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "Request() " + GetRequestUri() + ". data.Length: " + ((data != null) ? data.Length : 0));
		}
		try
		{
			WWW item = new WWW(GetRequestUri(), data);
			webRequests.Add(item);
		}
		catch (Exception throwable)
		{
			EnqueueDebugReturn(DebugLevel.ERROR, "Exception Url: " + GetRequestUri());
			SupportClass.WriteStackTrace(throwable, Console.Out);
			EnqueueStatusCallback(StatusCode.Exception);
			EnqueueActionForDispatch(delegate
			{
				Disconnected();
			});
		}
	}

	internal bool CheckResult()
	{
		if (webRequests == null || webRequests.Count == 0 || !webRequests[0].isDone)
		{
			return false;
		}
		WWW wWW = webRequests[0];
		webRequests.RemoveAt(0);
		if (wWW.error != null)
		{
			EnqueueDebugReturn(DebugLevel.ERROR, "WWW request error: " + wWW.error);
			EnqueueStatusCallback(StatusCode.Exception);
			EnqueueActionForDispatch(delegate
			{
				Disconnected();
			});
		}
		else
		{
			receiveIncomingCommands(wWW.bytes);
		}
		return true;
	}

	internal override bool Connect(string serverAddress, string appID, byte nodeId)
	{
		if (peerConnectionState != 0)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "Connect() called while peerConnectionState != Disconnected. Nothing done.");
			return false;
		}
		peerConnectionState = ConnectionStateValue.Connecting;
		base.ServerAddress = serverAddress;
		HttpPeerID = Guid.Empty.ToString();
		UrlParameters = "?init";
		Request(null);
		return true;
	}

	internal override void Disconnect()
	{
		throw new NotImplementedException();
	}

	internal override void StopConnection()
	{
		throw new NotImplementedException();
	}

	internal void Disconnected()
	{
		InitPeerBase();
		base.Listener.OnStatusChanged(StatusCode.Disconnect);
	}

	internal override void FetchServerTimestamp()
	{
	}

	internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypted, EgMessageType messageType)
	{
		byte[] array = SerializeOperationToMessage(parameters, opCode, encrypt: false, messageType);
		if (array == null)
		{
			return false;
		}
		Request(array);
		return true;
	}

	internal override bool DispatchIncomingCommands()
	{
		while (CheckResult())
		{
		}
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
		return false;
	}

	internal override bool SendOutgoingCommands()
	{
		return false;
	}

	internal override byte[] SerializeOperationToMessage(Dictionary<byte, object> parameters, byte opCode, bool encrypt, EgMessageType messageType)
	{
		byte[] array = Protocol.SerializeOperationRequest(parameters, opCode);
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
			base.Listener.DebugReturn(DebugLevel.ERROR, $"Error serializing operation! OpCode: {opCode} Parameters: {SupportClass.DictionaryToString(parameters)}");
		}
		return array2;
	}

	internal override void receiveIncomingCommands(byte[] inBuff)
	{
		if (peerConnectionState == ConnectionStateValue.Connecting)
		{
			HttpPeerID = Encoding.UTF8.GetString(inBuff, 0, inBuff.Length);
			UrlParameters = "?pid=" + HttpPeerID;
			peerConnectionState = ConnectionStateValue.Connected;
			EnqueueActionForDispatch(delegate
			{
				InitCallback();
			});
		}
		else
		{
			EnqueueActionForDispatch(delegate
			{
				DeserializeMessageAndCallback(inBuff);
			});
		}
	}
}
