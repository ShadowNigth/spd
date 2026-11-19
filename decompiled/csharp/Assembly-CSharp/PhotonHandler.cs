using System;
using System.Threading;
using ExitGames.Client.Photon;
using Photon;
using UnityEngine;

public class PhotonHandler : Photon.MonoBehaviour, IPhotonPeerListener
{
	public static PhotonHandler SP;

	public int updateInterval;

	public int updateIntervalOnSerialize;

	private int nextSendTickCount = Environment.TickCount;

	private int nextSendTickCountOnSerialize = Environment.TickCount;

	private void Awake()
	{
		if (SP != null && SP != this)
		{
			Debug.LogError("Error: we already have an PhotonMono around!");
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DontDestroyOnLoad(this);
		SP = this;
		updateInterval = 1000 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = 1000 / PhotonNetwork.sendRateOnSerialize;
	}

	public static void StartThread()
	{
		Thread thread = new Thread(MyThread);
		thread.Start();
	}

	public static void MyThread()
	{
		while (PhotonNetwork.networkingPeer != null && PhotonNetwork.networkingPeer.IsSendingOnlyAcks)
		{
			while (PhotonNetwork.networkingPeer != null && PhotonNetwork.networkingPeer.IsSendingOnlyAcks && PhotonNetwork.networkingPeer.SendOutgoingCommands())
			{
			}
			Thread.Sleep(200);
		}
	}

	private void Update()
	{
		if (PhotonNetwork.networkingPeer == null)
		{
			Debug.LogError("NetworkPeer broke!");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == PeerState.PeerCreated || PhotonNetwork.connectionStateDetailed == PeerState.Disconnected || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			while (PhotonNetwork.isMessageQueueRunning && PhotonNetwork.networkingPeer.DispatchIncomingCommands())
			{
			}
			if (PhotonNetwork.isMessageQueueRunning)
			{
				if (Environment.TickCount > nextSendTickCountOnSerialize)
				{
					PhotonNetwork.networkingPeer.RunViewUpdate();
					nextSendTickCountOnSerialize = Environment.TickCount + updateIntervalOnSerialize;
				}
				if (Environment.TickCount > nextSendTickCount)
				{
					PhotonNetwork.networkingPeer.SendOutgoingCommands();
					nextSendTickCount = Environment.TickCount + updateInterval;
				}
			}
		}
	}

	private void OnLevelWasLoaded(int level)
	{
		PhotonNetwork.networkingPeer.NewSceneLoaded();
	}

	public void OnApplicationQuit()
	{
		PhotonNetwork.Disconnect();
	}

	public void DebugReturn(DebugLevel level, string message)
	{
		switch (level)
		{
		case DebugLevel.ERROR:
			Debug.LogError(message);
			return;
		case DebugLevel.WARNING:
			Debug.LogWarning(message);
			return;
		case DebugLevel.INFO:
			if (PhotonNetwork.logLevel >= NetworkLogLevel.Informational)
			{
				Debug.Log(message);
				return;
			}
			break;
		}
		if (level == DebugLevel.ALL && PhotonNetwork.logLevel == NetworkLogLevel.Full)
		{
			Debug.Log(message);
		}
	}

	public void OnOperationResponse(OperationResponse operationResponse)
	{
	}

	public void OnStatusChanged(StatusCode statusCode)
	{
	}

	public void OnEvent(EventData photonEvent)
	{
	}
}
