using System.Collections;
using ExitGames.Client.Photon;
using UnityEngine;

public class RoomInfo
{
	public float rank;

	public float sortAdd;

	private bool? m_android;

	private bool? m_Noobs;

	private string m_mapName;

	public bool mapNotFound;

	public float played;

	private string[] m_sets;

	public int groupCount;

	private bool? m_custom;

	private byte maxPlayersSetting;

	public string format;

	public HostData hostdata;

	private bool? m_lowPingNeeded;

	internal Hashtable properties = new Hashtable();

	public string name;

	private bool isOpen = true;

	private bool isVisible = true;

	internal bool mRemoved;

	public int playerCount;

	public float sortRank
	{
		get
		{
			return (rank != 0f) ? rank : 100f;
		}
	}

	public bool android
	{
		get
		{
			bool? flag = m_android;
			bool value;
			if (flag.HasValue)
			{
				value = flag.Value;
			}
			else
			{
				bool? flag2 = (m_android = sets[3].Contains("Android"));
				value = flag2.Value;
			}
			return value;
		}
	}

	public bool Noobs
	{
		get
		{
			bool? noobs = m_Noobs;
			bool value;
			if (noobs.HasValue)
			{
				value = noobs.Value;
			}
			else
			{
				bool? flag = (m_Noobs = sets[3].Contains("Noobs"));
				value = flag.Value;
			}
			return value;
		}
	}

	public string mapName
	{
		get
		{
			return m_mapName ?? (m_mapName = FOGIOGKLNIP.GIGJFCBMKMO(sets[0]));
		}
	}

	public bool cantJoin
	{
		get
		{
			return (!FOGIOGKLNIP.DGMBIMMABNO && android && !FOGIOGKLNIP.OMMLFOEPEEK) || mapNotFound || LowPingNeeded() || playerCount == maxPlayers || (Noobs && FOGIOGKLNIP.BEHFNEAKDAL.IBPALGFPAKO.JDDGBFOOCHE > 1f);
		}
	}

	public string password
	{
		get
		{
			return (sets.Length <= 4) ? string.Empty : sets[5];
		}
	}

	public string[] sets
	{
		get
		{
			return m_sets ?? (m_sets = name.Split("|"));
		}
	}

	public bool isDae
	{
		get
		{
			return NOMMEFIICHO.HKIKLNKHPEP(sets[0]);
		}
	}

	public string version
	{
		get
		{
			return sets[1];
		}
	}

	public bool custom
	{
		get
		{
			bool? flag = m_custom;
			bool value;
			if (flag.HasValue)
			{
				value = flag.Value;
			}
			else
			{
				bool? flag2 = (m_custom = sets[3].Contains("Custom"));
				value = flag2.Value;
			}
			return value;
		}
	}

	internal bool IsLocalClientInside { get; set; }

	public byte maxPlayers
	{
		get
		{
			return maxPlayersSetting;
		}
		set
		{
			if (!Equals(PhotonNetwork.room))
			{
				PhotonNetwork.networkingPeer.DebugReturn(DebugLevel.WARNING, "Can't set room properties when not in that room.");
			}
			if (value != maxPlayersSetting && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.networkingPeer.OpSetPropertiesOfGame(new Hashtable { 
				{
					byte.MaxValue,
					value
				} }, true, 0);
			}
			maxPlayersSetting = value;
		}
	}

	public bool open
	{
		get
		{
			return isOpen;
		}
		set
		{
			if (!Equals(PhotonNetwork.room))
			{
				PhotonNetwork.networkingPeer.DebugReturn(DebugLevel.WARNING, "Can't set room properties when not in that room.");
			}
			if (value != isOpen && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.networkingPeer.OpSetPropertiesOfGame(new Hashtable { 
				{
					(byte)253,
					value
				} }, true, 0);
			}
			isOpen = value;
		}
	}

	public bool visible
	{
		get
		{
			return isVisible;
		}
		set
		{
			if (!Equals(PhotonNetwork.room))
			{
				PhotonNetwork.networkingPeer.DebugReturn(DebugLevel.WARNING, "Can't set room properties when not in that room.");
			}
			if (value != isVisible && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.networkingPeer.OpSetPropertiesOfGame(new Hashtable { 
				{
					(byte)254,
					value
				} }, true, 0);
			}
			isVisible = value;
		}
	}

	internal RoomInfo(string roomName, Hashtable properties)
	{
		name = roomName;
		CacheProperties(properties);
	}

	internal RoomInfo(string roomName, Hashtable properties, bool isVisible, bool isOpen, byte maxPlayers)
	{
		name = roomName;
		CacheProperties(properties);
		this.isVisible = isVisible;
		this.isOpen = isOpen;
		maxPlayersSetting = maxPlayers;
	}

	public bool LowPingNeeded()
	{
		return false;
	}

	public override string ToString()
	{
		return string.Format("Room: '{0}' visible: {1} open: {2} max: {3} count: {4}\ncustomProps: {5}", name, isVisible, isOpen, maxPlayersSetting, playerCount, SupportClass.DictionaryToString(properties));
	}

	internal Hashtable GetAllGameProperties()
	{
		Hashtable hashtable = new Hashtable();
		if (isOpen)
		{
			hashtable[(byte)253] = isOpen;
		}
		if (isVisible)
		{
			hashtable[(byte)254] = isVisible;
		}
		if (maxPlayersSetting != 0)
		{
			hashtable[byte.MaxValue] = maxPlayersSetting;
		}
		hashtable.Merge(properties);
		return hashtable;
	}

	internal void CacheProperties(Hashtable properties)
	{
		if (properties == null || properties.Count == 0)
		{
			return;
		}
		if (properties.ContainsKey((byte)251))
		{
			mRemoved = (bool)properties[(byte)251];
			if (mRemoved)
			{
				return;
			}
		}
		if (properties.ContainsKey(byte.MaxValue))
		{
			maxPlayersSetting = (byte)properties[byte.MaxValue];
		}
		if (properties.ContainsKey((byte)253))
		{
			isOpen = (bool)properties[(byte)253];
		}
		if (properties.ContainsKey((byte)254))
		{
			isVisible = (bool)properties[(byte)254];
		}
		if (properties.ContainsKey((byte)252))
		{
			playerCount = (byte)properties[(byte)252];
		}
		this.properties.MergeStringKeys(properties);
	}
}
