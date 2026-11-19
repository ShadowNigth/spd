using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ExitGames.Client.Photon;
using UnityEngine;

public static class PhotonNetwork
{
	public static readonly PhotonHandler photonMono;

	public static readonly NetworkingPeer networkingPeer;

	public static readonly int MAX_VIEW_IDS;

	public static ServerSettings PhotonServerSettings;

	public static NetworkLogLevel logLevel;

	private static bool isOfflineMode;

	private static bool offlineMode_inRoom;

	public static bool autoCleanUpPlayerObjects;

	private static int sendInterval;

	private static int sendIntervalOnSerialize;

	private static bool m_isMessageQueueRunning;

	public static int unreliableCommandsLimit;

	public static bool connected
	{
		get
		{
			if (offlineMode)
			{
				return true;
			}
			return connectionState == ConnectionState.Connected;
		}
	}

	public static ConnectionState connectionState
	{
		get
		{
			if (offlineMode)
			{
				return ConnectionState.Connected;
			}
			if (networkingPeer == null)
			{
				return ConnectionState.Disconnected;
			}
			return networkingPeer.PeerState switch
			{
				PeerStateValue.Disconnected => ConnectionState.Disconnected, 
				PeerStateValue.Connecting => ConnectionState.Connecting, 
				PeerStateValue.Connected => ConnectionState.Connected, 
				PeerStateValue.Disconnecting => ConnectionState.Disconnecting, 
				PeerStateValue.InitializingApplication => ConnectionState.InitializingApplication, 
				_ => ConnectionState.Disconnected, 
			};
		}
	}

	public static PeerState connectionStateDetailed
	{
		get
		{
			if (offlineMode)
			{
				return PeerState.Connected;
			}
			if (networkingPeer == null)
			{
				return PeerState.Disconnected;
			}
			return networkingPeer.State;
		}
	}

	public static RoomInfo room
	{
		get
		{
			if (isOfflineMode)
			{
				if (offlineMode_inRoom)
				{
					return new RoomInfo("OfflineRoom", new Hashtable());
				}
				return null;
			}
			return networkingPeer.mCurrentGame;
		}
	}

	public static PhotonPlayer player
	{
		get
		{
			if (networkingPeer == null)
			{
				return null;
			}
			return networkingPeer.mLocalActor;
		}
	}

	public static PhotonPlayer masterClient
	{
		get
		{
			if (networkingPeer == null)
			{
				return null;
			}
			return networkingPeer.mMasterClient;
		}
	}

	public static string playerName
	{
		get
		{
			return networkingPeer.PlayerName;
		}
		set
		{
			networkingPeer.PlayerName = value;
		}
	}

	public static List<PhotonPlayer> playerList
	{
		get
		{
			if (networkingPeer == null)
			{
				return new List<PhotonPlayer>();
			}
			return networkingPeer.mPlayerList;
		}
	}

	public static List<PhotonPlayer> otherPlayers => networkingPeer.mOtherPlayerList;

	public static bool offlineMode
	{
		get
		{
			return isOfflineMode;
		}
		set
		{
			if (value == isOfflineMode)
			{
				return;
			}
			if (value && connected)
			{
				Debug.LogError("Can't start OFFLINE mode while connected!");
				return;
			}
			networkingPeer.Disconnect();
			isOfflineMode = value;
			if (isOfflineMode)
			{
				NetworkingPeer.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToPhoton);
				networkingPeer.ChangeLocalID(1);
				networkingPeer.mMasterClient = player;
			}
		}
	}

	[Obsolete("Used for compatibility with Unity networking only.")]
	public static byte maxConnections
	{
		get
		{
			if (room == null)
			{
				return 0;
			}
			return room.maxPlayers;
		}
		set
		{
			room.maxPlayers = value;
		}
	}

	public static int sendRate
	{
		get
		{
			return 1000 / sendInterval;
		}
		set
		{
			sendInterval = 1000 / value;
			if (photonMono != null)
			{
				photonMono.updateInterval = sendInterval;
			}
			if (value < sendRateOnSerialize)
			{
				sendRateOnSerialize = value;
			}
		}
	}

	public static int sendRateOnSerialize
	{
		get
		{
			return 1000 / sendIntervalOnSerialize;
		}
		set
		{
			if (value > sendRate)
			{
				Debug.LogError("Error, can not set the OnSerialize SendRate more often then the overall SendRate");
				value = sendRate;
			}
			sendIntervalOnSerialize = 1000 / value;
			if (photonMono != null)
			{
				photonMono.updateIntervalOnSerialize = sendIntervalOnSerialize;
			}
		}
	}

	public static bool isMessageQueueRunning
	{
		get
		{
			return m_isMessageQueueRunning;
		}
		set
		{
			if (value != m_isMessageQueueRunning)
			{
				networkingPeer.IsSendingOnlyAcks = !value;
				m_isMessageQueueRunning = value;
				if (!value)
				{
					PhotonHandler.StartThread();
				}
			}
		}
	}

	public static double time
	{
		get
		{
			if (offlineMode)
			{
				return Time.time;
			}
			return (double)networkingPeer.ServerTimeInMilliSeconds / 1000.0;
		}
	}

	public static bool isMasterClient
	{
		get
		{
			if (offlineMode)
			{
				return true;
			}
			return networkingPeer.mMasterClient == networkingPeer.mLocalActor;
		}
	}

	public static bool isNonMasterClientInGame => !isMasterClient && room != null;

	static PhotonNetwork()
	{
		MAX_VIEW_IDS = 900000;
		PhotonServerSettings = (ServerSettings)Resources.Load(Path.GetFileNameWithoutExtension(NetworkingPeer.serverSettingsAssetPath), typeof(ServerSettings));
		logLevel = NetworkLogLevel.ErrorsOnly;
		isOfflineMode = false;
		offlineMode_inRoom = false;
		autoCleanUpPlayerObjects = true;
		sendInterval = 50;
		sendIntervalOnSerialize = 100;
		m_isMessageQueueRunning = true;
		unreliableCommandsLimit = 20;
		Application.runInBackground = true;
		GameObject gameObject = new GameObject();
		photonMono = gameObject.AddComponent<PhotonHandler>();
		gameObject.name = "PhotonMono";
		networkingPeer = new NetworkingPeer(photonMono, "Guest " + UnityEngine.Random.Range(1, 9999), "v1.0", ConnectionProtocol.Udp);
		networkingPeer.LimitOfUnreliableCommands = 20;
		CustomTypes.Register();
	}

	public static void ConnectUsingSettings()
	{
		if (PhotonServerSettings == null)
		{
			Debug.LogError("Loading the settings file failed. Check path: " + NetworkingPeer.serverSettingsAssetPath);
		}
		else
		{
			Connect(PhotonServerSettings.ServerAddress, PhotonServerSettings.ServerPort, PhotonServerSettings.AppID);
		}
	}

	public static void Connect(string serverAddress, int port, string uniqueGameID)
	{
		if (port <= 0)
		{
			Debug.LogError("Aborted Connect: invalid port: " + port);
			return;
		}
		if (serverAddress.Length <= 2)
		{
			Debug.LogError("Aborted Connect: invalid serverAddress: " + serverAddress);
			return;
		}
		if (networkingPeer.PeerState != 0)
		{
			Debug.LogWarning("Connect() only works when disconnected. Current state: " + networkingPeer.PeerState);
			return;
		}
		if (offlineMode)
		{
			offlineMode = false;
			Debug.LogWarning("Shut down offline mode due to a connect attempt");
		}
		if (!isMessageQueueRunning)
		{
			isMessageQueueRunning = true;
			Debug.LogWarning("Forced enabling of isMessageQueueRunning because of a Connect()");
		}
		serverAddress = serverAddress + ":" + port;
		networkingPeer.Connect(serverAddress, uniqueGameID, 0);
	}

	public static void Disconnect()
	{
		if (networkingPeer != null)
		{
			networkingPeer.Disconnect();
		}
	}

	public static void InitializeSecurity()
	{
		if (!offlineMode)
		{
			if (!connected)
			{
				Debug.LogError("Cannot InitializeSecurity when not connected!");
			}
			else
			{
				networkingPeer.EstablishEncryption();
			}
		}
	}

	public static void CreateRoom(string roomName)
	{
		if (room != null)
		{
			Debug.LogError("CreateRoom aborted: You are already in a room!");
		}
		else if (roomName == string.Empty)
		{
			Debug.LogError("CreateRoom aborted: You must specifiy a room name!");
		}
		else if (offlineMode)
		{
			offlineMode_inRoom = true;
			NetworkingPeer.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom);
		}
		else
		{
			networkingPeer.OpCreateGame(roomName, isVisible: true, isOpen: true, 0, null);
		}
	}

	public static void CreateRoom(string roomName, bool isVisible, bool isOpen, byte maxPlayers)
	{
		if (room != null)
		{
			Debug.LogError("CreateRoom aborted: You are already in a room!");
		}
		else if (offlineMode)
		{
			offlineMode_inRoom = true;
			NetworkingPeer.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom);
		}
		else
		{
			networkingPeer.OpCreateGame(roomName, isVisible, isOpen, maxPlayers, null);
		}
	}

	public static void JoinRoom(string roomName)
	{
		if (room != null)
		{
			Debug.LogError("JoinRoom aborted: You are already in a room!");
		}
		else if (roomName == string.Empty)
		{
			Debug.LogError("JoinRoom aborted: You must specifiy a room name!");
		}
		else if (offlineMode)
		{
			offlineMode_inRoom = true;
			NetworkingPeer.SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom);
		}
		else
		{
			networkingPeer.OpJoin(roomName);
		}
	}

	public static void JoinRandomRoom()
	{
		if (room != null)
		{
			Debug.LogError("JoinRandomRoom aborted: You are already in a room!");
		}
		else if (offlineMode)
		{
			offlineMode_inRoom = true;
			NetworkingPeer.SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom);
		}
		else
		{
			networkingPeer.OpJoinRandom(null);
		}
	}

	public static void LeaveRoom()
	{
		if (room == null)
		{
			Debug.LogError("PhotonNetwork: Error, you cannot leave a room if you're not in a room!");
		}
		else if (offlineMode)
		{
			offlineMode_inRoom = false;
			NetworkingPeer.SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom);
		}
		else
		{
			networkingPeer.OpLeave();
		}
	}

	public static RoomInfo[] GetRoomList()
	{
		if (offlineMode)
		{
			return new RoomInfo[0];
		}
		if (networkingPeer == null)
		{
			return new RoomInfo[0];
		}
		RoomInfo[] array = new RoomInfo[networkingPeer.mGameList.Count];
		networkingPeer.mGameList.Values.CopyTo(array, 0);
		return array;
	}

	public static PhotonViewID AllocateViewID()
	{
		int i;
		for (i = 0; networkingPeer.allocatedIDs.ContainsKey(i); i++)
		{
		}
		if (i > MAX_VIEW_IDS)
		{
			Debug.LogError("ERROR: Too many view IDs used!");
			i = 0;
		}
		int iD = i;
		PhotonViewID photonViewID = new PhotonViewID(iD, player);
		networkingPeer.allocatedIDs.Add(i, photonViewID);
		return photonViewID;
	}

	public static void UnAllocateViewID(PhotonViewID viewID)
	{
		UnAllocateViewID(viewID.ID);
	}

	public static void UnAllocateViewID(int ID)
	{
		networkingPeer.allocatedIDs.Remove(ID);
	}

	public static GameObject Instantiate(string prefabname, Vector3 position, Quaternion rotation, int group)
	{
		return Instantiate(prefabname, position, rotation, group, null);
	}

	public static GameObject Instantiate(string prefabname, Vector3 position, Quaternion rotation, int group, object[] data)
	{
		if (!VerifyCanUseNetwork())
		{
			return null;
		}
		GameObject gameObject = (GameObject)Resources.Load(prefabname, typeof(GameObject));
		if (gameObject == null)
		{
			Debug.LogError("PhotonNetwork error: Could not Instantiate the prefab [" + prefabname + "]. Please verify you have this gameobject in a Resources folder (and not in a subfolder)");
			return null;
		}
		Component[] componentsInChildren = gameObject.GetComponentsInChildren<PhotonView>(includeInactive: true);
		PhotonViewID[] array = new PhotonViewID[componentsInChildren.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = AllocateViewID();
		}
		Hashtable evData = networkingPeer.SendInstantiate(prefabname, position, rotation, group, array, data);
		return networkingPeer.DoInstantiate(evData, networkingPeer.mLocalActor, gameObject);
	}

	public static int GetPing()
	{
		return networkingPeer.RoundTripTime;
	}

	public static void SendOutgoingCommands()
	{
		if (VerifyCanUseNetwork())
		{
			while (networkingPeer.SendOutgoingCommands())
			{
			}
		}
	}

	public static void CloseConnection(PhotonPlayer kickPlayer)
	{
		if (VerifyCanUseNetwork())
		{
			if (!player.isMasterClient)
			{
				Debug.LogError("CloseConnection: Only the masterclient can kick another player.");
			}
			if (kickPlayer == null)
			{
				Debug.LogError("CloseConnection: No such player connected!");
				return;
			}
			int[] targetActors = new int[1] { kickPlayer.ID };
			networkingPeer.OpRaiseEvent(203, null, sendReliable: true, 0, targetActors);
		}
	}

	public static void Destroy(int viewID)
	{
		PhotonView view = PhotonView.Find(viewID);
		Destroy(view);
	}

	public static void Destroy(PhotonView view)
	{
		if (view != null && view.owner != null)
		{
			networkingPeer.DestroyPhotonView(view);
		}
		else
		{
			Debug.LogError(string.Concat("Destroy: Could not destroy view ID [", view, "]. Does not exist, or is not ours!"));
		}
	}

	public static void Destroy(GameObject go)
	{
		networkingPeer.RemoveInstantiatedGO(go);
	}

	public static void DestroyPlayerObjects(PhotonPlayer player)
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.DestroyPlayerObjects(player);
		}
	}

	public static void RemoveAllInstantiatedObjects()
	{
		networkingPeer.RemoveAllInstantiatedObjects();
	}

	public static void RemoveAllInstantiatedObjects(PhotonPlayer player)
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.RemoveAllInstantiatedObjectsByPlayer(player);
		}
	}

	internal static void RPC(PhotonView view, string methodName, PhotonTargets target, params object[] parameters)
	{
		if (VerifyCanUseNetwork())
		{
			if (room == null)
			{
				Debug.LogWarning("Cannot send RPCs in Lobby! RPC dropped.");
			}
			else if (networkingPeer != null)
			{
				networkingPeer.RPC(view, methodName, target, parameters);
			}
			else
			{
				Debug.LogWarning("Could not execute RPC " + methodName + ". Possible scene loading in progress?");
			}
		}
	}

	internal static void RPC(PhotonView view, string methodName, PhotonPlayer targetPlayer, params object[] parameters)
	{
		if (!VerifyCanUseNetwork())
		{
			return;
		}
		if (room == null)
		{
			Debug.LogWarning("Cannot send RPCs in Lobby, only processed locally");
			return;
		}
		if (player == null)
		{
			Debug.LogError("Error; Sending RPC to player null! Aborted \"" + methodName + "\"");
		}
		if (networkingPeer != null)
		{
			networkingPeer.RPC(view, methodName, targetPlayer, parameters);
		}
		else
		{
			Debug.LogWarning("Could not execute RPC " + methodName + ". Possible scene loading in progress?");
		}
	}

	public static void RemoveRPCs()
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.RemoveRPCsOfLocalPlayer();
		}
	}

	public static void RemoveRPCs(PhotonView view)
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.RemoveRPCs(view);
		}
	}

	public static void RemoveRPCsInGroup(int group)
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.RemoveRPCsInGroup(group);
		}
	}

	public static void SetReceivingEnabled(int group, bool enabled)
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.SetReceivingEnabled(group, enabled);
		}
	}

	public static void SetSendingEnabled(int group, bool enabled)
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.SetSendingEnabled(group, enabled);
		}
	}

	public static void SetLevelPrefix(int prefix)
	{
		if (VerifyCanUseNetwork())
		{
			networkingPeer.SetLevelPrefix(prefix);
		}
	}

	private static bool VerifyCanUseNetwork()
	{
		if (networkingPeer != null && (offlineMode || connected))
		{
			return true;
		}
		Debug.LogError("Cannot send messages when not connected; Either connect to Photon OR use offline mode!");
		return false;
	}
}
