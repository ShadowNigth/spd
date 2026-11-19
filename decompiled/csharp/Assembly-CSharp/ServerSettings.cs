using System;
using UnityEngine;

[Serializable]
public class ServerSettings : ScriptableObject
{
	public enum HostingOption
	{
		NotSet,
		PhotonCloud,
		SelfHosted
	}

	public static string DefaultCloudServerUrl = "app.exitgamescloud.com";

	public static string DefaultServerAddress = "app.exitgamescloud.com";

	public static int DefaultMasterPort = 5055;

	public static string DefaultAppID = "35d8975d-c46f-4f89-a5f2-d7f068d79079";

	public HostingOption HostType = HostingOption.PhotonCloud;

	public string ServerAddress = DefaultServerAddress;

	public int ServerPort = 5055;

	public string AppID = "35d8975d-c46f-4f89-a5f2-d7f068d79079";

	public override string ToString()
	{
		return string.Concat("ServerSettings: ", HostType, " ", ServerAddress);
	}

	public void UseCloud(string cloudAppid)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = cloudAppid;
		ServerAddress = DefaultCloudServerUrl;
		ServerPort = DefaultMasterPort;
	}

	public void UseMyServer(string serverAddress, int serverPort, string application)
	{
		HostType = HostingOption.SelfHosted;
		AppID = ((application == null) ? DefaultAppID : application);
		ServerAddress = serverAddress;
		ServerPort = serverPort;
	}
}
