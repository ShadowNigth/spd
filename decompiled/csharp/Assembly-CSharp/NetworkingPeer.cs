using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.Lite;
using UnityEngine;

public class NetworkingPeer : LoadbalancingPeer, IPhotonPeerListener
{
	private enum ReflectionMethods
	{
		OnPhotonSerializeView,
		OnPhotonInstantiate
	}

	public static string serverSettingsAssetPath = "Assets/Photon Unity Networking/Resources/PhotonServerSettings.asset";

	private string mAppVersion;

	private string mAppId;

	private byte nodeId;

	private string masterServerAddress;

	private string playername;

	private IPhotonPeerListener externalListener;

	private JoinType mLastJoinType;

	private bool mPlayernameHasToBeUpdated;

	public Dictionary<int, PhotonPlayer> mActors = new Dictionary<int, PhotonPlayer>();

	public List<PhotonPlayer> mPlayerList = new List<PhotonPlayer>();

	public List<PhotonPlayer> mOtherPlayerList = new List<PhotonPlayer>();

	public PhotonPlayer mMasterClient;

	public bool requestSecurity;

	private Dictionary<Type, List<MethodInfo>> monoRPCMethodsCache = new Dictionary<Type, List<MethodInfo>>();

	private ushort cacheInstantiationCount;

	public Dictionary<string, RoomInfo> mGameList = new Dictionary<string, RoomInfo>();

	public Dictionary<int, GameObject> instantiatedObjects = new Dictionary<int, GameObject>();

	private List<int> blockReceivingGroups = new List<int>();

	private List<int> blockSendingGroups = new List<int>();

	private Dictionary<int, PhotonView> photonViewList = new Dictionary<int, PhotonView>();

	private int currentLevelPrefix = -1;

	public Dictionary<int, PhotonViewID> allocatedIDs = new Dictionary<int, PhotonViewID>();

	private Dictionary<Type, Dictionary<ReflectionMethods, MethodInfo>> cachedMethods = new Dictionary<Type, Dictionary<ReflectionMethods, MethodInfo>>();

	public string PlayerName
	{
		get
		{
			return playername;
		}
		set
		{
			if (!string.IsNullOrEmpty(value) && !value.Equals(playername))
			{
				if (mLocalActor != null)
				{
					mLocalActor.name = value;
				}
				playername = value;
				if (mCurrentGame != null)
				{
					SendPlayerName();
				}
			}
		}
	}

	public PeerState State { get; internal set; }

	public RoomInfo mCurrentGame
	{
		get
		{
			if (mRoomToGetInto != null && mRoomToGetInto.IsLocalClientInside)
			{
				return mRoomToGetInto;
			}
			return null;
		}
	}

	internal RoomInfo mRoomToGetInto { get; set; }

	public PhotonPlayer mLocalActor { get; internal set; }

	public string mGameserver { get; internal set; }

	public int mQueuePosition { get; internal set; }

	public int mMasterCount { get; internal set; }

	public int mGameCount { get; internal set; }

	public int mPeerCount { get; internal set; }

	public NetworkingPeer(IPhotonPeerListener listener, string playername, string appversion, ConnectionProtocol connectionProtocol)
		: base(listener, connectionProtocol)
	{
		base.Listener = this;
		externalListener = listener;
		PlayerName = playername;
		mLocalActor = new PhotonPlayer(isLocal: true, -1, this.playername);
		AddNewPlayer(mLocalActor.ID, mLocalActor);
		State = global::PeerState.PeerCreated;
		mAppVersion = appversion;
	}

	public override bool Connect(string serverAddress, string appID, byte nodeId)
	{
		if (PhotonNetwork.connectionStateDetailed == global::PeerState.Disconnecting)
		{
			Debug.LogError("ERROR: Cannot connect to Photon while Disconnecting. Connection failed.");
			return false;
		}
		if (string.IsNullOrEmpty(masterServerAddress))
		{
			masterServerAddress = serverAddress;
		}
		mAppId = appID;
		State = global::PeerState.Connecting;
		return base.Connect(serverAddress, appID, nodeId);
	}

	public override void Disconnect()
	{
		if (base.PeerState == PeerStateValue.Disconnected)
		{
			if ((int)base.DebugOut >= 2)
			{
				DebugReturn(DebugLevel.WARNING, $"Can't execute Disconnect() while not connected. Nothing changed. State: {State}");
			}
		}
		else
		{
			base.Disconnect();
			State = global::PeerState.Disconnecting;
			LeftRoomCleanup();
		}
	}

	private void DisconnectFromMaster()
	{
		base.Disconnect();
		State = global::PeerState.DisconnectingFromMasterserver;
	}

	private void DisconnectFromGameServer()
	{
		base.Disconnect();
		State = global::PeerState.DisconnectingFromGameserver;
		LeftRoomCleanup();
		SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom);
	}

	private void LeftRoomCleanup()
	{
		mRoomToGetInto = null;
		mActors = new Dictionary<int, PhotonPlayer>();
		mMasterClient = null;
		blockReceivingGroups = new List<int>();
		blockSendingGroups = new List<int>();
		mGameList = new Dictionary<string, RoomInfo>();
		cacheInstantiationCount = 0;
		mPlayerList = new List<PhotonPlayer>();
		mOtherPlayerList = new List<PhotonPlayer>();
		ChangeLocalID(-1);
		if (!PhotonNetwork.autoCleanUpPlayerObjects)
		{
			return;
		}
		foreach (GameObject value in instantiatedObjects.Values)
		{
			if (value != null)
			{
				if ((int)base.DebugOut >= 5)
				{
					DebugReturn(DebugLevel.ALL, "Network destroy(1) Instantiated GO: " + value.name);
				}
				UnityEngine.Object.Destroy(value);
			}
		}
		instantiatedObjects = new Dictionary<int, GameObject>();
		foreach (PhotonView value2 in photonViewList.Values)
		{
			if (value2 != null && !value2.isSceneView && value2.gameObject != null)
			{
				if ((int)base.DebugOut >= 5)
				{
					DebugReturn(DebugLevel.ALL, "Network destroy(2) Instantiated GO: " + value2.gameObject.name);
				}
				UnityEngine.Object.Destroy(value2.gameObject);
			}
		}
		allocatedIDs = new Dictionary<int, PhotonViewID>();
	}

	private void SwitchNode(byte masterNodeId)
	{
		Debug.Log("Switching node to " + masterNodeId);
		nodeId = masterNodeId;
		DisconnectFromGameServer();
	}

	private void readoutStandardProperties(Hashtable gameProperties, Hashtable pActorProperties, int targetActorNr)
	{
		if (mCurrentGame != null && gameProperties != null)
		{
			mCurrentGame.CacheProperties(gameProperties);
		}
		if (pActorProperties == null || pActorProperties.Count <= 0)
		{
			return;
		}
		if (targetActorNr > 0)
		{
			GetPlayerWithID(targetActorNr)?.CacheProperties(GetActorPropertiesForActorNr(pActorProperties, targetActorNr));
			return;
		}
		foreach (object key in pActorProperties.Keys)
		{
			int num = (int)key;
			Hashtable hashtable = (Hashtable)pActorProperties[key];
			string name = (string)hashtable[byte.MaxValue];
			PhotonPlayer photonPlayer = GetPlayerWithID(num);
			if (photonPlayer == null)
			{
				photonPlayer = new PhotonPlayer(isLocal: false, num, name);
				AddNewPlayer(num, photonPlayer);
			}
			photonPlayer.CacheProperties(hashtable);
		}
	}

	private void AddNewPlayer(int ID, PhotonPlayer player)
	{
		if (!mActors.ContainsKey(ID))
		{
			mActors[ID] = player;
			mPlayerList.Add(player);
			if (!player.isLocal)
			{
				mOtherPlayerList.Add(player);
			}
		}
		else
		{
			Debug.LogError("Adding player twice: " + ID);
		}
		if (!player.isLocal)
		{
			ResetPhotonViewsOnSerialize();
		}
	}

	private void ResetPhotonViewsOnSerialize()
	{
		foreach (KeyValuePair<int, PhotonView> photonView in photonViewList)
		{
			PhotonView value = photonView.Value;
			if (value.owner == mLocalActor)
			{
				value.lastOnSerializeDataSent = null;
			}
		}
	}

	private void HandleEventLeave(int actorID)
	{
		if (actorID < 0 || !mActors.ContainsKey(actorID))
		{
			if ((int)base.DebugOut >= 2)
			{
				DebugReturn(DebugLevel.WARNING, $"Received event Leave for unknown actorNumber: {actorID}");
			}
		}
		else
		{
			SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerDisconnected, mActors[actorID]);
		}
		if ((int)base.DebugOut >= 3)
		{
			DebugReturn(DebugLevel.INFO, "HandleEventLeave actorNr: " + actorID);
		}
		PhotonPlayer playerWithID = GetPlayerWithID(actorID);
		if (PhotonNetwork.autoCleanUpPlayerObjects)
		{
			DestroyPlayerObjects(playerWithID);
		}
		mPlayerList.Remove(playerWithID);
		if (!playerWithID.isLocal)
		{
			mOtherPlayerList.Remove(playerWithID);
		}
		mActors.Remove(actorID);
		if (mMasterClient != null && mMasterClient.ID == actorID)
		{
			mMasterClient = null;
		}
		CheckMasterClient();
		if (PhotonNetwork.isMasterClient && PhotonNetwork.autoCleanUpPlayerObjects)
		{
			RemoveCompleteCacheOfPlayer(actorID);
		}
	}

	private void CheckMasterClient()
	{
		int num = int.MaxValue;
		if (mMasterClient != null && mActors.ContainsKey(mMasterClient.ID))
		{
			return;
		}
		foreach (int key in mActors.Keys)
		{
			if (key < num)
			{
				num = key;
			}
		}
		if (mMasterClient == null || mMasterClient.ID != num)
		{
			mMasterClient = mActors[num];
			SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, mMasterClient);
		}
	}

	private Hashtable GetActorPropertiesForActorNr(Hashtable actorProperties, int actorNr)
	{
		if (actorProperties.ContainsKey(actorNr))
		{
			return (Hashtable)actorProperties[actorNr];
		}
		return actorProperties;
	}

	private PhotonPlayer GetPlayerWithID(int number)
	{
		if (mActors != null && mActors.ContainsKey(number))
		{
			return mActors[number];
		}
		return null;
	}

	private void SendPlayerName()
	{
		if (State == global::PeerState.Joining)
		{
			mPlayernameHasToBeUpdated = true;
		}
		else if (mLocalActor != null)
		{
			mLocalActor.name = PlayerName;
			Hashtable hashtable = new Hashtable();
			hashtable[byte.MaxValue] = PlayerName;
			OpSetPropertiesOfActor(mLocalActor.ID, hashtable, broadcast: true, 0);
			mPlayernameHasToBeUpdated = false;
		}
	}

	private void GameEnteredOnGameServer(OperationResponse operationResponse)
	{
		if (operationResponse.ReturnCode != 0)
		{
			switch (operationResponse.OperationCode)
			{
			case 227:
				DebugReturn(DebugLevel.ERROR, "Create failed on GameServer. Changing back to MasterServer.");
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateGameFailed);
				break;
			case 225:
			case 226:
				DebugReturn(DebugLevel.ERROR, "Join failed on GameServer. Changing back to MasterServer.");
				if (operationResponse.ReturnCode == 32758)
				{
					Debug.Log("Most likely the game became empty during the switch to GameServer.");
				}
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinGameFailed);
				break;
			}
			DisconnectFromGameServer();
			return;
		}
		State = global::PeerState.Joined;
		mRoomToGetInto.IsLocalClientInside = true;
		Hashtable pActorProperties = (Hashtable)operationResponse[249];
		Hashtable gameProperties = (Hashtable)operationResponse[248];
		readoutStandardProperties(gameProperties, pActorProperties, 0);
		int newID = (int)operationResponse[254];
		ChangeLocalID(newID);
		CheckMasterClient();
		if (mPlayernameHasToBeUpdated)
		{
			SendPlayerName();
		}
		switch (operationResponse.OperationCode)
		{
		case 227:
			SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom);
			break;
		}
	}

	private Hashtable GetLocalActorProperties()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[byte.MaxValue] = PlayerName;
		return hashtable;
	}

	public void ChangeLocalID(int newID)
	{
		if (mLocalActor == null)
		{
			Debug.LogWarning($"Local actor is null or not in mActors! mLocalActor: {mLocalActor} mActors==null: {mActors == null} newID: {newID}");
		}
		if (mActors.ContainsKey(mLocalActor.ID))
		{
			mActors.Remove(mLocalActor.ID);
		}
		mLocalActor.ChangeLocalID(newID);
		mActors[mLocalActor.ID] = mLocalActor;
		if (!mPlayerList.Contains(mLocalActor))
		{
			mPlayerList.Add(mLocalActor);
		}
	}

	public bool OpCreateGame(string gameID, bool isVisible, bool isOpen, byte maxPlayers, Hashtable customGameProperties)
	{
		mRoomToGetInto = new RoomInfo(gameID, customGameProperties, isVisible, isOpen, maxPlayers);
		return OpCreateGame(gameID, isVisible, isOpen, maxPlayers, customGameProperties, GetLocalActorProperties());
	}

	public bool OpJoin(string gameID)
	{
		mRoomToGetInto = new RoomInfo(gameID, null);
		return OpJoin(gameID, GetLocalActorProperties());
	}

	public override bool OpJoinRandom(Hashtable expectedGameProperties)
	{
		mRoomToGetInto = new RoomInfo(null, expectedGameProperties);
		return base.OpJoinRandom(expectedGameProperties);
	}

	public virtual bool OpLeave()
	{
		if (State != global::PeerState.Joined)
		{
			DebugReturn(DebugLevel.ERROR, "NetworkingPeer::leaveGame() - ERROR: no game is currently joined");
			return false;
		}
		mRoomToGetInto = null;
		mActors = new Dictionary<int, PhotonPlayer>();
		return OpCustom(254, null, sendReliable: true, 0);
	}

	public override bool OpRaiseEvent(byte eventCode, Hashtable evData, bool sendReliable, byte channelId, int[] targetActors, EventCaching cache)
	{
		if (PhotonNetwork.offlineMode)
		{
			return false;
		}
		return base.OpRaiseEvent(eventCode, evData, sendReliable, channelId, targetActors, cache);
	}

	public override bool OpRaiseEvent(byte eventCode, Hashtable evData, bool sendReliable, byte channelId, EventCaching cache, ReceiverGroup receivers)
	{
		if (PhotonNetwork.offlineMode)
		{
			return false;
		}
		return base.OpRaiseEvent(eventCode, evData, sendReliable, channelId, cache, receivers);
	}

	public void DebugReturn(DebugLevel level, string message)
	{
		externalListener.DebugReturn(level, message);
	}

	public void OnOperationResponse(OperationResponse operationResponse)
	{
		if (PhotonNetwork.networkingPeer.State == global::PeerState.Disconnecting)
		{
			if ((int)base.DebugOut >= 3)
			{
				DebugReturn(DebugLevel.INFO, "OperationResponse ignored while disconnecting: " + operationResponse.OperationCode);
			}
			return;
		}
		if (operationResponse.ReturnCode == 0)
		{
			if ((int)base.DebugOut >= 3)
			{
				DebugReturn(DebugLevel.INFO, operationResponse.ToString());
			}
		}
		else if ((int)base.DebugOut >= 2)
		{
			DebugReturn(DebugLevel.WARNING, operationResponse.ToStringFull());
		}
		switch (operationResponse.OperationCode)
		{
		case 230:
			if (operationResponse.ReturnCode != 0)
			{
				if ((int)base.DebugOut >= 1)
				{
					DebugReturn(DebugLevel.ERROR, $"Authentication failed. Check AppId.\n{operationResponse.ToStringFull()}");
				}
				Disconnect();
				State = global::PeerState.Disconnecting;
			}
			else if (State == global::PeerState.Connected || State == global::PeerState.ConnectedComingFromGameserver)
			{
				if (operationResponse.Parameters.ContainsKey(223))
				{
					mQueuePosition = (int)operationResponse[223];
					if (mQueuePosition > 0)
					{
						if (State == global::PeerState.ConnectedComingFromGameserver)
						{
							State = global::PeerState.QueuedComingFromGameserver;
						}
						else
						{
							State = global::PeerState.Queued;
						}
						break;
					}
				}
				OpJoinLobby();
				State = global::PeerState.Authenticated;
			}
			else if (State == global::PeerState.ConnectedToGameserver)
			{
				State = global::PeerState.Joining;
				if (mLastJoinType == JoinType.JoinGame || mLastJoinType == JoinType.JoinRandomGame)
				{
					OpJoin(mRoomToGetInto.name);
				}
				else if (mLastJoinType == JoinType.CreateGame)
				{
					OpCreateGame(mRoomToGetInto.name, mRoomToGetInto.visible, mRoomToGetInto.open, mRoomToGetInto.maxPlayers, mRoomToGetInto.properties);
				}
			}
			break;
		case 227:
			if (State != global::PeerState.Joining)
			{
				if (operationResponse.ReturnCode != 0)
				{
					if ((int)base.DebugOut >= 1)
					{
						DebugReturn(DebugLevel.ERROR, $"createGame failed, client stays on masterserver: {operationResponse.ToStringFull()}.");
					}
					SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateGameFailed);
					break;
				}
				string text = (string)operationResponse[byte.MaxValue];
				if (!string.IsNullOrEmpty(text))
				{
					mRoomToGetInto.name = text;
				}
				mGameserver = (string)operationResponse[230];
				DisconnectFromMaster();
				mLastJoinType = JoinType.CreateGame;
			}
			else
			{
				GameEnteredOnGameServer(operationResponse);
			}
			break;
		case 226:
			if (State != global::PeerState.Joining)
			{
				if (operationResponse.ReturnCode != 0)
				{
					SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinGameFailed);
					if ((int)base.DebugOut >= 1)
					{
						DebugReturn(DebugLevel.ERROR, $"joinGame failed, client stays on masterserver: {operationResponse.ToStringFull()}. State: {State}");
					}
				}
				else
				{
					mGameserver = (string)operationResponse[230];
					DisconnectFromMaster();
					mLastJoinType = JoinType.JoinGame;
				}
			}
			else
			{
				GameEnteredOnGameServer(operationResponse);
			}
			break;
		case 225:
			if (operationResponse.ReturnCode != 0)
			{
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonRandomJoinFailed);
				if ((int)base.DebugOut >= 1)
				{
					DebugReturn(DebugLevel.ERROR, $"joinrandom failed, client stays on masterserver: {operationResponse.ToStringFull()}.");
				}
			}
			else
			{
				string name = (string)operationResponse[byte.MaxValue];
				mRoomToGetInto.name = name;
				mGameserver = (string)operationResponse[230];
				DisconnectFromMaster();
				mLastJoinType = JoinType.JoinRandomGame;
			}
			break;
		case 229:
			State = global::PeerState.JoinedLobby;
			SendMonoMessage(PhotonNetworkingMessage.OnJoinedLobby);
			break;
		case 228:
			State = global::PeerState.Authenticated;
			SendMonoMessage(PhotonNetworkingMessage.OnLeftLobby);
			break;
		case 254:
			DisconnectFromGameServer();
			break;
		case 251:
		{
			Hashtable pActorProperties = (Hashtable)operationResponse[249];
			Hashtable gameProperties = (Hashtable)operationResponse[248];
			readoutStandardProperties(gameProperties, pActorProperties, 0);
			break;
		}
		default:
			if ((int)base.DebugOut >= 1)
			{
				DebugReturn(DebugLevel.ERROR, $"operationResponse unhandled: {operationResponse.ToString()}");
			}
			break;
		case 252:
		case 253:
			break;
		}
		externalListener.OnOperationResponse(operationResponse);
	}

	public void OnStatusChanged(StatusCode statusCode)
	{
		if ((int)base.DebugOut >= 3)
		{
			DebugReturn(DebugLevel.INFO, $"OnStatusChanged: {statusCode.ToString()}");
		}
		switch (statusCode)
		{
		case StatusCode.Connect:
			if (State == global::PeerState.ConnectingToGameserver)
			{
				if ((int)base.DebugOut >= 5)
				{
					DebugReturn(DebugLevel.ALL, "Connected to gameserver.");
				}
				State = global::PeerState.ConnectedToGameserver;
			}
			else
			{
				if ((int)base.DebugOut >= 5)
				{
					DebugReturn(DebugLevel.ALL, "Connected to masterserver.");
				}
				if (State == global::PeerState.Connecting)
				{
					SendMonoMessage(PhotonNetworkingMessage.OnConnectedToPhoton);
					State = global::PeerState.Connected;
				}
				else
				{
					State = global::PeerState.ConnectedComingFromGameserver;
				}
			}
			if (requestSecurity)
			{
				EstablishEncryption();
			}
			if (!OpAuthenticate(mAppId, mAppVersion))
			{
				externalListener.DebugReturn(DebugLevel.ERROR, "Error Authenticating! Did not work.");
			}
			break;
		case StatusCode.Disconnect:
			if (State == global::PeerState.DisconnectingFromMasterserver)
			{
				if (nodeId != 0)
				{
					Debug.Log("connecting to game on node " + nodeId);
				}
				Connect(mGameserver, mAppId, nodeId);
				State = global::PeerState.ConnectingToGameserver;
			}
			else if (State == global::PeerState.DisconnectingFromGameserver)
			{
				nodeId = 0;
				Connect(masterServerAddress, mAppId, 0);
				State = global::PeerState.ConnectingToMasterserver;
			}
			else
			{
				SendMonoMessage(PhotonNetworkingMessage.OnDisconnectedFromPhoton);
				LeftRoomCleanup();
				State = global::PeerState.PeerCreated;
			}
			break;
		case StatusCode.SecurityExceptionOnConnect:
		case StatusCode.ExceptionOnConnect:
		case StatusCode.Exception:
		case StatusCode.InternalReceiveException:
		case StatusCode.TimeoutDisconnect:
		case StatusCode.DisconnectByServer:
		case StatusCode.DisconnectByServerUserLimit:
		case StatusCode.DisconnectByServerLogic:
			SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, statusCode);
			State = global::PeerState.PeerCreated;
			break;
		case StatusCode.EncryptionEstablished:
		case StatusCode.EncryptionFailedToEstablish:
			externalListener.DebugReturn(DebugLevel.INFO, "Encryption: " + statusCode);
			break;
		case StatusCode.TcpRouterResponseNodeIdUnknown:
		case StatusCode.TcpRouterResponseEndpointUnknown:
		case StatusCode.TcpRouterResponseNodeNotReady:
			DebugReturn(DebugLevel.ERROR, "Unexpected router response: " + statusCode);
			break;
		default:
			DebugReturn(DebugLevel.ERROR, "Received unknown status code: " + statusCode);
			break;
		case StatusCode.QueueOutgoingReliableWarning:
		case StatusCode.QueueOutgoingUnreliableWarning:
		case StatusCode.SendError:
		case StatusCode.QueueOutgoingAcksWarning:
		case StatusCode.QueueSentWarning:
		case StatusCode.TcpRouterResponseOk:
			break;
		}
		externalListener.OnStatusChanged(statusCode);
	}

	public void OnEvent(EventData photonEvent)
	{
		if ((int)base.DebugOut >= 3)
		{
			DebugReturn(DebugLevel.INFO, $"OnEvent: {photonEvent.ToString()}");
		}
		int num = -1;
		PhotonPlayer photonPlayer = null;
		if (photonEvent.Parameters.ContainsKey(254))
		{
			num = (int)photonEvent[254];
			if (mActors.ContainsKey(num))
			{
				photonPlayer = mActors[num];
			}
		}
		switch (photonEvent.Code)
		{
		case 210:
		{
			byte b = (byte)photonEvent[209];
			byte b2 = (byte)photonEvent[208];
			if (b != b2)
			{
				SwitchNode(b2);
			}
			else
			{
				nodeId = b;
			}
			break;
		}
		case 230:
		{
			mGameList = new Dictionary<string, RoomInfo>();
			Hashtable hashtable4 = (Hashtable)photonEvent[222];
			foreach (DictionaryEntry item in hashtable4)
			{
				string text2 = (string)item.Key;
				mGameList[text2] = new RoomInfo(text2, (Hashtable)item.Value);
			}
			SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomList);
			break;
		}
		case 229:
		{
			Hashtable hashtable2 = (Hashtable)photonEvent[222];
			foreach (DictionaryEntry item2 in hashtable2)
			{
				string text = (string)item2.Key;
				RoomInfo roomInfo = new RoomInfo(text, (Hashtable)item2.Value);
				if (roomInfo.mRemoved)
				{
					mGameList.Remove(text);
				}
				else
				{
					mGameList[text] = roomInfo;
				}
			}
			SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate);
			break;
		}
		case 228:
			if (photonEvent.Parameters.ContainsKey(223))
			{
				mQueuePosition = (int)photonEvent[223];
			}
			else
			{
				DebugReturn(DebugLevel.ERROR, "Event QueueState must contain position!");
			}
			if (mQueuePosition == 0)
			{
				State = global::PeerState.Authenticated;
			}
			break;
		case 226:
			mPeerCount = (int)photonEvent[229];
			mGameCount = (int)photonEvent[228];
			mMasterCount = (int)photonEvent[227];
			break;
		case byte.MaxValue:
		{
			Hashtable hashtable3 = (Hashtable)photonEvent[249];
			string name = (string)hashtable3[byte.MaxValue];
			if (photonPlayer == null)
			{
				bool isLocal = mLocalActor.ID == num;
				AddNewPlayer(num, new PhotonPlayer(isLocal, num, name));
			}
			mRoomToGetInto.playerCount = mActors.Count;
			if (mActors[num] == mLocalActor)
			{
				SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom);
				break;
			}
			SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerConnected, mActors[num]);
			break;
		}
		case 254:
			HandleEventLeave(num);
			break;
		case 253:
		{
			int num2 = (int)photonEvent[253];
			Hashtable gameProperties = null;
			Hashtable pActorProperties = null;
			if (num2 == 0)
			{
				gameProperties = (Hashtable)photonEvent[251];
			}
			else
			{
				pActorProperties = (Hashtable)photonEvent[251];
			}
			readoutStandardProperties(gameProperties, pActorProperties, num2);
			break;
		}
		case 200:
			ExecuteRPC(photonEvent[245] as Hashtable, photonPlayer);
			break;
		case 201:
		{
			Hashtable data = (Hashtable)photonEvent[245];
			ReadOnSerialize(data, photonPlayer);
			break;
		}
		case 202:
			DoInstantiate((Hashtable)photonEvent[245], photonPlayer, null);
			break;
		case 203:
			if (photonPlayer == null || !photonPlayer.isMasterClient)
			{
				Debug.LogError(string.Concat("Error: Someone else(", photonPlayer, ") then the masterserver requests a disconnect!"));
			}
			else
			{
				PhotonNetwork.LeaveRoom();
			}
			break;
		case 204:
		{
			Hashtable hashtable = (Hashtable)photonEvent[245];
			int viewID = (int)hashtable[(byte)0];
			PhotonView photonView = GetPhotonView(viewID);
			if (!(photonView == null) && photonPlayer != null)
			{
				DoDestroyPhotonView(photonView);
			}
			break;
		}
		default:
			Debug.LogError("Error. Unhandled event: " + photonEvent);
			break;
		}
		externalListener.OnEvent(photonEvent);
	}

	public static void SendMonoMessage(PhotonNetworkingMessage methodString, params object[] parameters)
	{
		List<GameObject> list = new List<GameObject>();
		MonoBehaviour[] array = (MonoBehaviour[])UnityEngine.Object.FindObjectsOfType(typeof(MonoBehaviour));
		MonoBehaviour[] array2 = array;
		foreach (MonoBehaviour monoBehaviour in array2)
		{
			if (!list.Contains(monoBehaviour.gameObject))
			{
				list.Add(monoBehaviour.gameObject);
				if (parameters != null && parameters.Length == 1)
				{
					monoBehaviour.SendMessage(methodString.ToString(), parameters[0], SendMessageOptions.DontRequireReceiver);
				}
				else
				{
					monoBehaviour.SendMessage(methodString.ToString(), parameters, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}

	public void ExecuteRPC(Hashtable rpcData, PhotonPlayer sender)
	{
		if (rpcData == null || !rpcData.ContainsKey((byte)0))
		{
			DebugReturn(DebugLevel.ERROR, "Malformed RPC; this should never occur.");
			return;
		}
		int num = (int)rpcData[(byte)0];
		int num2 = -1;
		if (rpcData.ContainsKey((byte)1))
		{
			num2 = (int)rpcData[(byte)1];
		}
		string text;
		if (FOGIOGKLNIP.OEHPFFJHJEJ)
		{
			if (rpcData[(byte)3] is byte)
			{
				byte index = (byte)rpcData[(byte)3];
				text = FOGIOGKLNIP.LPLJMLGKCLK.DOPDNNMJMHO[index];
			}
			else
			{
				text = (string)rpcData[(byte)3];
				Debug.Log("Received String " + text);
			}
		}
		else
		{
			text = (string)rpcData[(byte)3];
		}
		object[] array = (object[])rpcData[(byte)4];
		if (array == null)
		{
			array = new object[0];
		}
		PhotonView photonView = GetPhotonView(num);
		if (photonView == null)
		{
			if (Application.isEditor && FOGIOGKLNIP.LPLJMLGKCLK.FCFBGBPEPOL)
			{
				Debug.LogError("Received RPC \"" + text + "\" for viewID " + num + " but this networkview does not exist!");
			}
			return;
		}
		if (photonView.prefix != num2)
		{
			Debug.LogError("Received RPC \"" + text + "\" on viewID " + num + " with a prefix of " + num2 + ", our prefix is " + photonView.prefix + ". The RPC has been ignored.");
			return;
		}
		if (text == string.Empty)
		{
			DebugReturn(DebugLevel.ERROR, "Malformed RPC; this should never occur.");
			return;
		}
		if ((int)base.DebugOut >= 5)
		{
			DebugReturn(DebugLevel.ALL, "Received RPC; " + text);
		}
		if (blockReceivingGroups.Contains(photonView.group))
		{
			return;
		}
		Type[] array2 = Type.EmptyTypes;
		if (array.Length > 0)
		{
			array2 = new Type[array.Length];
			int num3 = 0;
			object[] array3 = array;
			foreach (object obj in array3)
			{
				if (obj == null)
				{
					array2[num3] = null;
				}
				else
				{
					array2[num3] = obj.GetType();
				}
				num3++;
			}
		}
		int num4 = 0;
		int num5 = 0;
		MonoBehaviour[] components = photonView.GetComponents<MonoBehaviour>();
		foreach (MonoBehaviour monoBehaviour in components)
		{
			Type type = monoBehaviour.GetType();
			List<MethodInfo> list = null;
			if (monoRPCMethodsCache.ContainsKey(type))
			{
				list = monoRPCMethodsCache[type];
			}
			if (list == null)
			{
				List<MethodInfo> list2 = new List<MethodInfo>();
				MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				for (int k = 0; k < methods.Length; k++)
				{
					if (methods[k].IsDefined(typeof(RPC), inherit: false))
					{
						list2.Add(methods[k]);
					}
				}
				List<MethodInfo> list3 = list2;
				monoRPCMethodsCache[type] = list3;
				list = list3;
			}
			if (list == null)
			{
				continue;
			}
			foreach (MethodInfo item in list)
			{
				if (!(item.Name == text))
				{
					continue;
				}
				num5++;
				ParameterInfo[] parameters = item.GetParameters();
				if (parameters.Length == array2.Length)
				{
					if (CheckTypeMatch(parameters, array2))
					{
						num4++;
						object obj2 = item.Invoke(monoBehaviour, array);
						if (item.ReturnType == typeof(IEnumerator))
						{
							PhotonHandler.SP.StartCoroutine((IEnumerator)obj2);
						}
					}
				}
				else if (parameters.Length - 1 == array2.Length && CheckTypeMatch(parameters, array2) && parameters[parameters.Length - 1].ParameterType == typeof(PhotonMessageInfo))
				{
					num4++;
					int timestamp = (int)rpcData[(byte)2];
					object[] array4 = new object[array.Length + 1];
					array.CopyTo(array4, 0);
					array4[array4.Length - 1] = new PhotonMessageInfo(sender, timestamp, photonView);
					object obj3 = item.Invoke(monoBehaviour, array4);
					if (item.ReturnType == typeof(IEnumerator))
					{
						PhotonHandler.SP.StartCoroutine((IEnumerator)obj3);
					}
				}
			}
		}
		if (num4 == 1)
		{
			return;
		}
		string text2 = string.Empty;
		Type[] array5 = array2;
		foreach (Type type2 in array5)
		{
			if (text2 != string.Empty)
			{
				text2 += ", ";
			}
			text2 = ((!(type2 == null)) ? (text2 + type2.Name) : (text2 + "null"));
		}
		if (num4 == 0)
		{
			if (num5 == 0)
			{
				DebugReturn(DebugLevel.ERROR, "PhotonView with ID " + num + " has no method \"" + text + "\" marked with the [RPC](C#) or @RPC(JS) property!");
			}
			else
			{
				DebugReturn(DebugLevel.ERROR, "PhotonView with ID " + num + " has no method \"" + text + "\" that takes " + array2.Length + " argument(s): " + text2);
			}
		}
		else
		{
			DebugReturn(DebugLevel.ERROR, "PhotonView with ID " + num + " has " + num4 + " methods \"" + text + "\" that takes " + array2.Length + " argument(s): " + text2 + ". Should be just one?");
		}
	}

	private bool CheckTypeMatch(ParameterInfo[] parameters, Type[] types)
	{
		if (parameters.Length < types.Length)
		{
			return false;
		}
		int num = 0;
		foreach (Type type in types)
		{
			if (type != null && parameters[num].ParameterType != type)
			{
				return false;
			}
			num++;
		}
		return true;
	}

	private int AllocateInstantiationId()
	{
		int result = ++cacheInstantiationCount + (mLocalActor.ID << 16);
		if (cacheInstantiationCount == 32767)
		{
			Debug.LogError("Next Instantiation will create a overflow.");
		}
		return result;
	}

	internal Hashtable SendInstantiate(string prefabName, Vector3 position, Quaternion rotation, int group, PhotonViewID[] viewIDs, object[] data)
	{
		int num = AllocateInstantiationId();
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)0] = prefabName;
		if (position != Vector3.zero)
		{
			hashtable[(byte)1] = position;
		}
		hashtable[(byte)2] = rotation;
		if (group != 0)
		{
			hashtable[(byte)3] = group;
		}
		if (viewIDs != null && viewIDs.Length > 0)
		{
			hashtable[(byte)4] = viewIDs;
		}
		if (data != null)
		{
			hashtable[(byte)5] = data;
		}
		hashtable[(byte)6] = base.ServerTimeInMilliSeconds;
		hashtable[(byte)7] = num;
		OpRaiseEvent(202, hashtable, sendReliable: true, 0, EventCaching.AddToRoomCache, ReceiverGroup.Others);
		return hashtable;
	}

	internal GameObject DoInstantiate(Hashtable evData, PhotonPlayer photonPlayer, GameObject resourceGameObject)
	{
		string text = (string)evData[(byte)0];
		Vector3 position = ((!evData.ContainsKey((byte)1)) ? Vector3.zero : ((Vector3)evData[(byte)1]));
		Quaternion rotation = (Quaternion)evData[(byte)2];
		int num = 0;
		if (evData.ContainsKey((byte)3))
		{
			num = (int)evData[(byte)3];
		}
		PhotonViewID[] array = ((!evData.ContainsKey((byte)4)) ? new PhotonViewID[0] : ((PhotonViewID[])evData[(byte)4]));
		object[] instantiationData = ((!evData.ContainsKey((byte)5)) ? new object[0] : ((object[])evData[(byte)5]));
		int timestamp = (int)evData[(byte)6];
		int key = (int)evData[(byte)7];
		if (blockReceivingGroups.Contains(num))
		{
			return null;
		}
		if (resourceGameObject == null)
		{
			resourceGameObject = (GameObject)Resources.Load(text, typeof(GameObject));
			if (resourceGameObject == null)
			{
				Debug.LogError("PhotonNetwork error: Could not Instantiate the prefab [" + text + "]. Please verify you have this gameobject in a Resources folder.");
				return null;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(resourceGameObject, position, rotation);
		instantiatedObjects.Add(key, gameObject);
		PhotonView[] componentsInChildren = gameObject.GetComponentsInChildren<PhotonView>();
		int num2 = 0;
		PhotonView[] array2 = componentsInChildren;
		foreach (PhotonView photonView in array2)
		{
			photonView.viewID = array[num2];
			photonView.group = num;
			photonView.instantiationData = instantiationData;
			num2++;
		}
		object[] parameters = new object[1]
		{
			new PhotonMessageInfo(photonPlayer, timestamp, null)
		};
		MonoBehaviour[] componentsInChildren2 = gameObject.GetComponentsInChildren<MonoBehaviour>();
		MonoBehaviour[] array3 = componentsInChildren2;
		foreach (MonoBehaviour monoBehaviour in array3)
		{
			MethodInfo cachedMethod = GetCachedMethod(monoBehaviour, ReflectionMethods.OnPhotonInstantiate);
			if (cachedMethod != null)
			{
				object obj = cachedMethod.Invoke(monoBehaviour, parameters);
				if (cachedMethod.ReturnType == typeof(IEnumerator))
				{
					PhotonHandler.SP.StartCoroutine((IEnumerator)obj);
				}
			}
		}
		return gameObject;
	}

	public void RemoveAllInstantiatedObjects()
	{
		GameObject[] array = new GameObject[instantiatedObjects.Count];
		instantiatedObjects.Values.CopyTo(array, 0);
		GameObject[] array2 = array;
		foreach (GameObject gameObject in array2)
		{
			if (!(gameObject == null))
			{
				RemoveInstantiatedGO(gameObject);
			}
		}
		if (instantiatedObjects.Count > 0)
		{
			Debug.LogError("RemoveAllInstantiatedObjects() this.instantiatedObjects.Count should be 0 by now.");
		}
		instantiatedObjects = new Dictionary<int, GameObject>();
	}

	public void RemoveAllInstantiatedObjectsByPlayer(PhotonPlayer player)
	{
		GameObject[] array = new GameObject[instantiatedObjects.Count];
		instantiatedObjects.Values.CopyTo(array, 0);
		GameObject[] array2 = array;
		foreach (GameObject gameObject in array2)
		{
			if (gameObject == null)
			{
				continue;
			}
			PhotonView[] componentsInChildren = gameObject.GetComponentsInChildren<PhotonView>();
			for (int num = componentsInChildren.Length - 1; num >= 0; num--)
			{
				PhotonView photonView = componentsInChildren[num];
				if (photonView.owner == player)
				{
					RemoveInstantiatedGO(gameObject);
					break;
				}
			}
		}
	}

	public void RemoveInstantiatedGO(GameObject go)
	{
		if (go == null)
		{
			if (base.DebugOut == DebugLevel.ERROR)
			{
				DebugReturn(DebugLevel.ERROR, "Can't remove instantiated GO if it's null.");
			}
			return;
		}
		int instantiatedObjectsId = GetInstantiatedObjectsId(go);
		if (instantiatedObjectsId == -1)
		{
			if (base.DebugOut == DebugLevel.ERROR)
			{
				DebugReturn(DebugLevel.ERROR, "Can't find GO in instantiation list. Object: " + go);
			}
			return;
		}
		instantiatedObjects.Remove(instantiatedObjectsId);
		PhotonView[] componentsInChildren = go.GetComponentsInChildren<PhotonView>();
		bool flag = false;
		for (int num = componentsInChildren.Length - 1; num >= 0; num--)
		{
			PhotonView photonView = componentsInChildren[num];
			if (!(photonView == null))
			{
				if (!flag)
				{
					RemoveFromServerInstantiationCache(instantiatedObjectsId, photonView.owner.ID);
					flag = true;
				}
				PhotonNetwork.UnAllocateViewID(photonView.viewID.ID);
				DestroyPhotonView(photonView);
			}
		}
		if ((int)base.DebugOut >= 5)
		{
			DebugReturn(DebugLevel.ALL, "Network destroy Instantiated GO: " + go.name);
		}
		UnityEngine.Object.Destroy(go);
	}

	private int GetInstantiatedObjectsId(GameObject go)
	{
		int num = -1;
		if (go == null)
		{
			DebugReturn(DebugLevel.ERROR, "GetInstantiatedObjectsId() for GO == null.");
			return num;
		}
		foreach (KeyValuePair<int, GameObject> instantiatedObject in instantiatedObjects)
		{
			if (go == instantiatedObject.Value)
			{
				num = instantiatedObject.Key;
				break;
			}
		}
		if (num == -1 && base.DebugOut == DebugLevel.ALL)
		{
			DebugReturn(DebugLevel.ALL, "instantiatedObjects does not contain: " + go);
		}
		return num;
	}

	private void RemoveFromServerInstantiationCache(int instantiateId, int actorNr)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)7] = instantiateId;
		OpRaiseEvent(202, hashtable, sendReliable: true, 0, new int[1] { actorNr }, EventCaching.RemoveFromRoomCache);
	}

	private void RemoveFromServerInstantiationsOfPlayer(int actorNr)
	{
		OpRaiseEvent(202, null, sendReliable: true, 0, new int[1] { actorNr }, EventCaching.RemoveFromRoomCache);
	}

	public void DestroyPlayerObjects(PhotonPlayer player)
	{
		RemoveAllInstantiatedObjectsByPlayer(player);
		PhotonView[] array = (PhotonView[])UnityEngine.Object.FindObjectsOfType(typeof(PhotonView));
		for (int num = array.Length - 1; num >= 0; num--)
		{
			PhotonView photonView = array[num];
			if (photonView.owner == player)
			{
				DoDestroyPhotonView(photonView);
			}
		}
	}

	public void DestroyPhotonView(PhotonView view)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)0] = view.viewID.ID;
		OpRaiseEvent(204, hashtable, sendReliable: true, 0, EventCaching.DoNotCache, ReceiverGroup.Others);
		DoDestroyPhotonView(view);
	}

	private void DoDestroyPhotonView(PhotonView view)
	{
		if (view.isMine)
		{
			RemoveRPCs(view);
		}
		int instantiatedObjectsId = GetInstantiatedObjectsId(view.gameObject);
		if (instantiatedObjectsId != -1)
		{
			if (Application.isEditor && FOGIOGKLNIP.LPLJMLGKCLK.FCFBGBPEPOL)
			{
				Debug.Log("Found view in instantiatedObjects.");
			}
			instantiatedObjects.Remove(instantiatedObjectsId);
		}
		if ((int)base.DebugOut >= 5)
		{
			DebugReturn(DebugLevel.ALL, "Network destroy PhotonView GO: " + view.gameObject.name);
		}
		UnityEngine.Object.Destroy(view.gameObject);
	}

	public PhotonView GetPhotonView(int viewID)
	{
		PhotonView value = null;
		photonViewList.TryGetValue(viewID, out value);
		return value;
	}

	public void RegisterPhotonView(PhotonView netView)
	{
		if (!Application.isPlaying)
		{
			photonViewList = new Dictionary<int, PhotonView>();
			return;
		}
		netView.prefix = currentLevelPrefix;
		if (netView.owner != null)
		{
			int num = netView.viewID.ID / PhotonNetwork.MAX_VIEW_IDS;
			if (netView.owner.ID != num)
			{
				Debug.LogError(string.Concat("RegisterPhotonView: registered view ID ", netView.viewID, " with owner ", netView.owner.ID, " but it should be ", num));
			}
		}
		if (!photonViewList.ContainsKey(netView.viewID.ID))
		{
			photonViewList.Add(netView.viewID.ID, netView);
			if ((int)base.DebugOut >= 5)
			{
				DebugReturn(DebugLevel.ALL, "Registered PhotonView: " + netView.viewID);
			}
		}
	}

	public void RemovePhotonView(PhotonView netView)
	{
		if (!Application.isPlaying)
		{
			photonViewList = new Dictionary<int, PhotonView>();
		}
		else
		{
			if (!photonViewList.ContainsKey(netView.viewID.ID))
			{
				return;
			}
			if (photonViewList[netView.viewID.ID] != netView)
			{
				Debug.LogError("PHOTON ERROR: This should never be possible: Two PhotonViews with same ID registered? ID=" + netView.viewID.ID + " " + netView.name + "  and " + photonViewList[netView.viewID.ID].name);
			}
			else
			{
				photonViewList.Remove(netView.viewID.ID);
				if ((int)base.DebugOut >= 5)
				{
					DebugReturn(DebugLevel.ALL, "Removed PhotonView: " + netView.viewID);
				}
			}
		}
	}

	public void RemoveRPCsOfLocalPlayer()
	{
		OpRaiseEvent(200, null, sendReliable: true, 0, new int[1] { mLocalActor.ID }, EventCaching.RemoveFromRoomCache);
	}

	public void RemoveRPCs(int actorNumber)
	{
		OpRaiseEvent(200, null, sendReliable: true, 0, new int[1] { actorNumber }, EventCaching.RemoveFromRoomCache);
	}

	private void RemoveCompleteCacheOfPlayer(int actorNumber)
	{
		OpRaiseEvent(0, null, sendReliable: true, 0, new int[1] { actorNumber }, EventCaching.RemoveFromRoomCache);
	}

	public void RemoveRPCs(PhotonView view)
	{
		if (view.owner != mLocalActor)
		{
			Debug.LogError(string.Concat("Error, cannot remove cached RPCs on a networkview thats not ours! ", view.owner, " scene: ", view.isSceneView));
		}
		else
		{
			Hashtable hashtable = new Hashtable();
			hashtable[(byte)0] = view.viewID.ID;
			OpRaiseEvent(200, hashtable, sendReliable: true, 0, EventCaching.RemoveFromRoomCache, ReceiverGroup.Others);
		}
	}

	public void RemoveRPCsInGroup(int group)
	{
		foreach (KeyValuePair<int, PhotonView> photonView in photonViewList)
		{
			PhotonView value = photonView.Value;
			if (value.group == group)
			{
				RemoveRPCs(value);
			}
		}
	}

	public void SetLevelPrefix(int prefix)
	{
		currentLevelPrefix = prefix;
		foreach (KeyValuePair<int, PhotonView> photonView in photonViewList)
		{
			PhotonView value = photonView.Value;
			value.prefix = prefix;
		}
	}

	public void RPC(PhotonView view, string methodName, PhotonPlayer player, params object[] parameters)
	{
		if (!blockSendingGroups.Contains(view.group))
		{
			if (view.viewID.ID < 1)
			{
				Debug.LogError(string.Concat("Illegal view ID:", view.viewID, " method: ", methodName, " GO:", view.gameObject.name));
			}
			if ((int)base.DebugOut >= 3)
			{
				DebugReturn(DebugLevel.INFO, string.Concat("Sending RPC \"", methodName, "\" to player[", player, "]"));
			}
			Hashtable hashtable = new Hashtable();
			hashtable[(byte)0] = view.viewID.ID;
			if (view.prefix > 0)
			{
				hashtable[(byte)1] = view.prefix;
			}
			hashtable[(byte)2] = base.ServerTimeInMilliSeconds;
			SetMethodName(methodName, hashtable);
			hashtable[(byte)4] = parameters;
			if (mLocalActor == player)
			{
				ExecuteRPC(hashtable, player);
				return;
			}
			int[] targetActors = new int[1] { player.ID };
			OpRaiseEvent(200, hashtable, sendReliable: true, 0, targetActors);
		}
	}

	public void RPC(PhotonView view, string methodName, PhotonTargets target, params object[] parameters)
	{
		if (blockSendingGroups.Contains(view.group))
		{
			return;
		}
		if (view.viewID.ID < 1)
		{
			Debug.LogError(string.Concat("Illegal view ID:", view.viewID, " method: ", methodName, " GO:", view.gameObject.name));
		}
		if ((int)base.DebugOut >= 3)
		{
			DebugReturn(DebugLevel.INFO, "Sending RPC \"" + methodName + "\" to " + target);
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)0] = view.viewID.ID;
		if (view.prefix > 0)
		{
			hashtable[(byte)1] = view.prefix;
		}
		hashtable[(byte)2] = base.ServerTimeInMilliSeconds;
		SetMethodName(methodName, hashtable);
		hashtable[(byte)4] = parameters;
		switch (target)
		{
		case PhotonTargets.All:
			OpRaiseEvent(200, hashtable, sendReliable: true, 0);
			ExecuteRPC(hashtable, mLocalActor);
			break;
		case PhotonTargets.Others:
			OpRaiseEvent(200, hashtable, sendReliable: true, 0);
			break;
		case PhotonTargets.AllBuffered:
			OpRaiseEvent(200, hashtable, sendReliable: true, 0, EventCaching.AddToRoomCache, ReceiverGroup.Others);
			ExecuteRPC(hashtable, mLocalActor);
			break;
		case PhotonTargets.OthersBuffered:
			OpRaiseEvent(200, hashtable, sendReliable: true, 0, EventCaching.AddToRoomCache, ReceiverGroup.Others);
			break;
		case PhotonTargets.MasterClient:
			if (mMasterClient == mLocalActor)
			{
				ExecuteRPC(hashtable, mLocalActor);
			}
			else
			{
				OpRaiseEvent(200, hashtable, sendReliable: true, 0, EventCaching.DoNotCache, ReceiverGroup.MasterClient);
			}
			break;
		default:
			Debug.LogError("Unsupported target enum: " + target);
			break;
		}
	}

	private static void SetMethodName(string methodName, Hashtable rpcEvent)
	{
		if (FOGIOGKLNIP.OEHPFFJHJEJ)
		{
			int num = FOGIOGKLNIP.LPLJMLGKCLK.DOPDNNMJMHO.IndexOf(methodName);
			if (num == -1)
			{
				throw new Exception("Method not found " + methodName);
			}
			rpcEvent[(byte)3] = (byte)num;
		}
		else
		{
			rpcEvent[(byte)3] = methodName;
		}
	}

	public void SetReceivingEnabled(int group, bool enabled)
	{
		if (!enabled)
		{
			if (!blockReceivingGroups.Contains(group))
			{
				blockReceivingGroups.Add(group);
			}
		}
		else
		{
			blockReceivingGroups.Remove(group);
		}
	}

	public void SetSendingEnabled(int group, bool enabled)
	{
		if (!enabled)
		{
			if (!blockSendingGroups.Contains(group))
			{
				blockSendingGroups.Add(group);
			}
		}
		else
		{
			blockSendingGroups.Remove(group);
		}
	}

	public void NewSceneLoaded()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, PhotonView> photonView in photonViewList)
		{
			PhotonView value = photonView.Value;
			if (value == null)
			{
				list.Add(photonView.Key);
			}
		}
		foreach (int item in list)
		{
			photonViewList.Remove(item);
		}
		if (list.Count > 0 && (int)base.DebugOut >= 3)
		{
			DebugReturn(DebugLevel.INFO, "Removed " + list.Count + " scene view IDs from last scene.");
		}
	}

	public void RunViewUpdate()
	{
		if (!PhotonNetwork.connected || mActors == null || mActors.Count <= 1)
		{
			return;
		}
		foreach (KeyValuePair<int, PhotonView> photonView in photonViewList)
		{
			PhotonView value = photonView.Value;
			if (!(value.observed != null) || value.synchronization == ViewSynchronization.Off || (value.owner != mLocalActor && (!value.isSceneView || mMasterClient != mLocalActor)) || !value.gameObject.activeInHierarchy || blockSendingGroups.Contains(value.group))
			{
				continue;
			}
			Hashtable hashtable = WriteSerializeData(value);
			if (value.synchronization == ViewSynchronization.ReliableDeltaCompressed)
			{
				if (!CompareWriteSerializeData(hashtable, value.lastOnSerializeDataSent))
				{
					OpRaiseEvent(201, hashtable, sendReliable: true, 0);
					value.lastOnSerializeDataSent = hashtable;
				}
			}
			else
			{
				OpRaiseEvent(201, hashtable, sendReliable: false, 1);
				value.lastOnSerializeDataSent = hashtable;
			}
		}
	}

	private bool CompareWriteSerializeData(Hashtable one, Hashtable two)
	{
		if (two == null || one == null)
		{
			return one == null && two == null;
		}
		if (one[(byte)1] is object[] array)
		{
			if (!(two[(byte)1] is object[] array2) || array.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					if (!array[i].Equals(array2[i]))
					{
						return false;
					}
				}
				else if (array2[i] != null)
				{
					return false;
				}
			}
			return true;
		}
		Hashtable hashtable = one[(byte)1] as Hashtable;
		Hashtable hashtable2 = two[(byte)1] as Hashtable;
		if (hashtable == null || hashtable2 == null)
		{
			return hashtable == null && hashtable2 == null;
		}
		if (hashtable2.Count != hashtable.Count)
		{
			return false;
		}
		foreach (DictionaryEntry item in hashtable)
		{
			if (item.Key is byte)
			{
				object value = item.Value;
				object obj = hashtable2[item.Key];
				if ((value == null || obj == null) && (value != null || obj != null))
				{
					return false;
				}
				if (value is string && obj is string)
				{
					if (!((string)value).Equals((string)obj))
					{
						return false;
					}
					continue;
				}
				if (value is int && obj is int)
				{
					if (!((int)value).Equals((int)obj))
					{
						return false;
					}
					continue;
				}
				if (value is float && obj is float)
				{
					if (!((float)value).Equals((float)obj))
					{
						return false;
					}
					continue;
				}
				if (value is Quaternion && obj is Quaternion)
				{
					if (!((Quaternion)value).Equals((Quaternion)obj))
					{
						return false;
					}
					continue;
				}
				if (value is bool && obj is bool)
				{
					if (!((bool)value).Equals((bool)obj))
					{
						return false;
					}
					continue;
				}
				if (value is char && obj is char)
				{
					if (!((char)value).Equals((char)obj))
					{
						return false;
					}
					continue;
				}
				if (value is short && obj is short)
				{
					if (!((short)value).Equals((short)obj))
					{
						return false;
					}
					continue;
				}
				if (value is ushort && obj is ushort)
				{
					if (!((ushort)value).Equals((ushort)obj))
					{
						return false;
					}
					continue;
				}
				if (value is Vector3 && obj is Vector3)
				{
					if (!((Vector3)value).Equals((Vector3)obj))
					{
						return false;
					}
					continue;
				}
				if (value is Vector2 && obj is Vector2)
				{
					if (!((Vector2)value).Equals((Vector2)obj))
					{
						return false;
					}
					continue;
				}
				if (value is PhotonPlayer && obj is PhotonPlayer)
				{
					if (!((PhotonPlayer)value).Equals((PhotonPlayer)obj))
					{
						return false;
					}
					continue;
				}
				if (value is PhotonViewID && obj is PhotonViewID)
				{
					if (!((PhotonViewID)value).Equals((PhotonViewID)obj))
					{
						return false;
					}
					continue;
				}
				Debug.LogError(string.Concat("Unsupported OnSerializeType: ", value.GetType(), "  and: ", obj.GetType()));
				return false;
			}
			Debug.LogError(string.Concat("Invalid OnSerializeContent: type=", item.Key.GetType(), " str=", item.Key.ToString()));
			return false;
		}
		return true;
	}

	private Hashtable WriteSerializeData(PhotonView view)
	{
		Hashtable hashtable = new Hashtable();
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)0] = view.viewID.ID;
		if (view.prefix > 0)
		{
			hashtable2[(byte)1] = view.prefix;
		}
		hashtable2[(byte)2] = base.ServerTimeInMilliSeconds;
		hashtable[(byte)0] = hashtable2;
		Type type = view.observed.GetType();
		if (typeof(MonoBehaviour).IsInstanceOfType(view.observed))
		{
			MonoBehaviour monob = (MonoBehaviour)view.observed;
			PhotonStream photonStream = new PhotonStream(write: true, null);
			PhotonMessageInfo info = new PhotonMessageInfo(mLocalActor, base.ServerTimeInMilliSeconds, view);
			ExecuteOnSerialize(monob, photonStream, info);
			hashtable[(byte)1] = photonStream.ToArray();
		}
		else if (type == typeof(Transform))
		{
			Transform transform = (Transform)view.observed;
			Hashtable hashtable3 = new Hashtable();
			if (view.onSerializeTransformOption == OnSerializeTransform.OnlyPosition || view.onSerializeTransformOption == OnSerializeTransform.PositionAndRotation || view.onSerializeTransformOption == OnSerializeTransform.All)
			{
				hashtable3[(byte)0] = transform.localPosition;
			}
			if (view.onSerializeTransformOption == OnSerializeTransform.OnlyRotation || view.onSerializeTransformOption == OnSerializeTransform.PositionAndRotation || view.onSerializeTransformOption == OnSerializeTransform.All)
			{
				hashtable3[(byte)1] = transform.localRotation;
			}
			if (view.onSerializeTransformOption == OnSerializeTransform.OnlyScale || view.onSerializeTransformOption == OnSerializeTransform.All)
			{
				hashtable3[(byte)2] = transform.localScale;
			}
			hashtable[(byte)1] = hashtable3;
		}
		else if (type == typeof(Rigidbody))
		{
			Rigidbody rigidbody = (Rigidbody)view.observed;
			Hashtable hashtable4 = new Hashtable();
			if (view.onSerializeRigidBodyOption != OnSerializeRigidBody.OnlyAngularVelocity)
			{
				hashtable4[(byte)0] = rigidbody.velocity;
			}
			if (view.onSerializeRigidBodyOption == OnSerializeRigidBody.OnlyVelocity)
			{
				hashtable4[(byte)1] = rigidbody.angularVelocity;
			}
			hashtable[(byte)1] = hashtable4;
		}
		else
		{
			Debug.LogError(string.Concat("Type of observed is unknown! ", type, "  and ", type.BaseType));
		}
		return hashtable;
	}

	private void ReadOnSerialize(Hashtable data, PhotonPlayer sender)
	{
		Hashtable hashtable = (Hashtable)data[(byte)0];
		int num = (int)hashtable[(byte)0];
		int num2 = 0;
		if (hashtable.ContainsKey((byte)1))
		{
			num2 = (int)hashtable[(byte)1];
		}
		int timestamp = (int)hashtable[(byte)2];
		PhotonView photonView = GetPhotonView(num);
		if (photonView == null)
		{
			if (Application.isEditor && FOGIOGKLNIP.LPLJMLGKCLK.FCFBGBPEPOL)
			{
				Debug.LogWarning("Received OnSerialization for view ID " + num + ". We have no such PhotonView! Ignored this if you're leaving a room. State: " + State);
			}
		}
		else if (photonView.prefix > 0 && num2 != photonView.prefix)
		{
			Debug.LogError("Received OnSerialization for view ID " + num + " with prefix " + num2 + ". Our prefix is " + photonView.prefix);
		}
		else
		{
			if (blockReceivingGroups.Contains(photonView.group))
			{
				return;
			}
			Type type = photonView.observed.GetType();
			if (typeof(MonoBehaviour).IsInstanceOfType(photonView.observed))
			{
				object[] incomingData = data[(byte)1] as object[];
				MonoBehaviour monob = (MonoBehaviour)photonView.observed;
				PhotonStream pStream = new PhotonStream(write: false, incomingData);
				PhotonMessageInfo info = new PhotonMessageInfo(sender, timestamp, photonView);
				ExecuteOnSerialize(monob, pStream, info);
			}
			else if (type == typeof(Transform))
			{
				Hashtable hashtable2 = data[(byte)1] as Hashtable;
				Transform transform = (Transform)photonView.observed;
				if (hashtable2.ContainsKey((byte)0))
				{
					transform.localPosition = (Vector3)hashtable2[(byte)0];
				}
				if (hashtable2.ContainsKey((byte)1))
				{
					transform.localRotation = (Quaternion)hashtable2[(byte)1];
				}
				if (hashtable2.ContainsKey((byte)2))
				{
					transform.localScale = (Vector3)hashtable2[(byte)2];
				}
			}
			else if (type == typeof(Rigidbody))
			{
				Hashtable hashtable3 = data[(byte)1] as Hashtable;
				Rigidbody rigidbody = (Rigidbody)photonView.observed;
				if (hashtable3.ContainsKey((byte)0))
				{
					rigidbody.angularVelocity = (Vector3)hashtable3[(byte)0];
				}
				if (hashtable3.ContainsKey((byte)1))
				{
					rigidbody.velocity = (Vector3)hashtable3[(byte)1];
				}
			}
			else
			{
				Debug.LogError("Type of observed is unknown when receiving.");
			}
		}
	}

	private void ExecuteOnSerialize(MonoBehaviour monob, PhotonStream pStream, PhotonMessageInfo info)
	{
		object[] parameters = new object[2] { pStream, info };
		MethodInfo cachedMethod = GetCachedMethod(monob, ReflectionMethods.OnPhotonSerializeView);
		if (cachedMethod != null)
		{
			object obj = cachedMethod.Invoke(monob, parameters);
			if (cachedMethod.ReturnType == typeof(IEnumerator))
			{
				PhotonHandler.SP.StartCoroutine((IEnumerator)obj);
			}
		}
		else
		{
			Debug.LogError(string.Concat("Tried to run ", ReflectionMethods.OnPhotonSerializeView, ", but this method was missing on: ", monob));
		}
	}

	private MethodInfo GetCachedMethod(MonoBehaviour monob, ReflectionMethods methodType)
	{
		Type type = monob.GetType();
		if (!cachedMethods.ContainsKey(type))
		{
			Dictionary<ReflectionMethods, MethodInfo> value = new Dictionary<ReflectionMethods, MethodInfo>();
			cachedMethods.Add(type, value);
		}
		Dictionary<ReflectionMethods, MethodInfo> dictionary = cachedMethods[type];
		if (!dictionary.ContainsKey(methodType))
		{
			Type[] types;
			switch (methodType)
			{
			case ReflectionMethods.OnPhotonSerializeView:
				types = new Type[2]
				{
					typeof(PhotonStream),
					typeof(PhotonMessageInfo)
				};
				break;
			case ReflectionMethods.OnPhotonInstantiate:
				types = new Type[1] { typeof(PhotonMessageInfo) };
				break;
			default:
				Debug.LogError("Invalid ReflectionMethod!");
				return null;
			}
			MethodInfo method = monob.GetType().GetMethod(string.Concat(methodType, string.Empty), BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
			if (method != null)
			{
				dictionary.Add(methodType, method);
			}
		}
		if (dictionary.ContainsKey(methodType))
		{
			return dictionary[methodType];
		}
		return null;
	}
}
