using System;
using System.Threading;

namespace ExitGames.Client.Photon;

public class NetworkSimulationSet
{
	private bool isSimulationEnabled = false;

	private int outgoingLag = 100;

	private int outgoingJitter = 0;

	private int outgoingLossPercentage = 1;

	private int incomingLag = 100;

	private int incomingJitter = 0;

	private int incomingLossPercentage = 1;

	internal ThreadStart SimulationMethod { get; set; }

	public bool IsSimulationEnabled
	{
		get
		{
			return isSimulationEnabled;
		}
		set
		{
			isSimulationEnabled = value;
			if (isSimulationEnabled)
			{
				Thread thread = new Thread(SimulationMethod);
				thread.IsBackground = true;
				thread.Name = "netSim" + Environment.TickCount;
				thread.Start();
			}
		}
	}

	public int OutgoingLag
	{
		get
		{
			return outgoingLag;
		}
		set
		{
			outgoingLag = value;
			checkSimulationNeeded();
		}
	}

	public int OutgoingJitter
	{
		get
		{
			return outgoingJitter;
		}
		set
		{
			outgoingJitter = value;
			checkSimulationNeeded();
		}
	}

	public int OutgoingLossPercentage
	{
		get
		{
			return outgoingLossPercentage;
		}
		set
		{
			outgoingLossPercentage = value;
			checkSimulationNeeded();
		}
	}

	public int IncomingLag
	{
		get
		{
			return incomingLag;
		}
		set
		{
			incomingLag = value;
			checkSimulationNeeded();
		}
	}

	public int IncomingJitter
	{
		get
		{
			return incomingJitter;
		}
		set
		{
			incomingJitter = value;
			checkSimulationNeeded();
		}
	}

	public int IncomingLossPercentage
	{
		get
		{
			return incomingLossPercentage;
		}
		set
		{
			incomingLossPercentage = value;
			checkSimulationNeeded();
		}
	}

	public int LostPackagesOut { get; internal set; }

	public int LostPackagesIn { get; internal set; }

	private void checkSimulationNeeded()
	{
		if (outgoingLag + outgoingJitter + outgoingLossPercentage + incomingLag + incomingJitter + incomingLossPercentage <= 0)
		{
			IsSimulationEnabled = false;
		}
	}

	public override string ToString()
	{
		return string.Format("NetworkSimulationSet {6}.  Lag in={0} out={1}. Jitter in={2} out={3}. Loss in={4} out={5}.", incomingLag, outgoingLag, incomingJitter, outgoingJitter, incomingLossPercentage, outgoingLossPercentage, IsSimulationEnabled);
	}
}
