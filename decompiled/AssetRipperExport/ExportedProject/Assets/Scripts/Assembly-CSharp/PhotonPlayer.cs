using System;
using System.Collections;
using UnityEngine;

public class PhotonPlayer
{
	private int actorID = -1;

	public string name = string.Empty;

	public readonly bool isLocal;

	internal Hashtable mCustomProperties = new Hashtable();

	public int ID
	{
		get
		{
			return actorID;
		}
	}

	public bool isMasterClient
	{
		get
		{
			return PhotonNetwork.networkingPeer.mMasterClient == this;
		}
	}

	[Obsolete("Used for compatibility with Unity networking only.")]
	public string guid
	{
		get
		{
			return ToString();
		}
	}

	[Obsolete("Used for compatibility with Unity networking only.")]
	public string ipAddress
	{
		get
		{
			return "NETW_ERROR";
		}
	}

	[Obsolete("Used for compatibility with Unity networking only.")]
	public string externalIP
	{
		get
		{
			return "NETW_ERROR";
		}
	}

	[Obsolete("Used for compatibility with Unity networking only.")]
	public int port
	{
		get
		{
			return -1;
		}
	}

	[Obsolete("Used for compatibility with Unity networking only.")]
	public int externalPort
	{
		get
		{
			return -1;
		}
	}

	public PhotonPlayer(bool isLocal, int actorID, string name)
	{
		this.isLocal = isLocal;
		this.actorID = actorID;
		this.name = name;
	}

	internal void CacheProperties(Hashtable properties)
	{
		if (properties != null && properties.Count != 0)
		{
			if (properties.ContainsKey(byte.MaxValue))
			{
				name = (string)properties[byte.MaxValue];
			}
			mCustomProperties.MergeStringKeys(properties);
		}
	}

	public override string ToString()
	{
		return name;
	}

	public override bool Equals(object p)
	{
		PhotonPlayer photonPlayer = p as PhotonPlayer;
		return photonPlayer != null && GetHashCode() == photonPlayer.GetHashCode();
	}

	public override int GetHashCode()
	{
		return ID;
	}

	internal void ChangeLocalID(int newID)
	{
		if (!isLocal)
		{
			Debug.LogError("ERROR You should never change PhotonPlayer IDs!");
		}
		else
		{
			actorID = newID;
		}
	}

	public static PhotonPlayer Find(int ID)
	{
		foreach (PhotonPlayer player in PhotonNetwork.playerList)
		{
			if (player.ID == ID)
			{
				return player;
			}
		}
		return null;
	}
}
