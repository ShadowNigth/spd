using System;
using System.IO;

namespace ExitGames.Client.Photon;

internal class NCommand : IComparable<NCommand>
{
	internal const int FLAG_RELIABLE = 1;

	internal const int FLAG_UNSEQUENCED = 2;

	internal const byte FV_UNRELIABLE = 0;

	internal const byte FV_RELIABLE = 1;

	internal const byte FV_UNRELIBALE_UNSEQUENCED = 2;

	internal const byte CT_NONE = 0;

	internal const byte CT_ACK = 1;

	internal const byte CT_CONNECT = 2;

	internal const byte CT_VERIFYCONNECT = 3;

	internal const byte CT_DISCONNECT = 4;

	internal const byte CT_PING = 5;

	internal const byte CT_SENDRELIABLE = 6;

	internal const byte CT_SENDUNRELIABLE = 7;

	internal const byte CT_SENDFRAGMENT = 8;

	internal const byte CT_EG_SERVERTIME = 12;

	internal const int HEADER_UDP_PACK_LENGTH = 12;

	internal const int HEADER_LENGTH = 12;

	internal const int HEADER_FRAGMENT_LENGTH = 32;

	internal const int CmdSizeMinimum = 12;

	internal const int CmdSizeAck = 20;

	internal const int CmdSizeConnect = 44;

	internal const int CmdSizeVerifyConnect = 44;

	internal const int CmdSizeDisconnect = 12;

	internal const int CmdSizePing = 12;

	internal const int CmdSizeReliableHeader = 12;

	internal const int CmdSizeUnreliableHeader = 16;

	internal const int CmdSizeFragmentHeader = 32;

	internal byte commandFlags;

	internal byte commandType;

	internal byte commandChannelID;

	internal int reliableSequenceNumber;

	internal int unreliableSequenceNumber;

	internal int unsequencedGroupNumber;

	internal byte reservedByte;

	internal int startSequenceNumber;

	internal int fragmentCount;

	internal int fragmentNumber;

	internal int totalLength;

	internal int fragmentOffset;

	internal int fragmentsRemaining;

	internal byte[] Payload;

	internal int commandSentTime;

	internal byte commandSentCount;

	internal int roundTripTimeout;

	internal int timeoutTime;

	internal int ackReceivedReliableSequenceNumber;

	internal int ackReceivedSentTime;

	private byte[] completeCommand;

	internal int Size;

	internal NCommand(EnetPeer peer, byte commandType, byte[] payload, byte channel)
	{
		this.commandType = commandType;
		commandFlags = 1;
		commandChannelID = channel;
		Payload = payload;
		Size = 12;
		switch (this.commandType)
		{
		case 2:
			Size = 44;
			Payload = new byte[32];
			Payload[0] = 0;
			Payload[1] = 0;
			SupportClass.NumberToByteArray(Payload, 2, (short)peer.mtu);
			Payload[4] = 0;
			Payload[5] = 0;
			Payload[6] = 128;
			Payload[7] = 0;
			Payload[11] = peer.ChannelCount;
			Payload[15] = 0;
			Payload[19] = 0;
			Payload[22] = 19;
			Payload[23] = 136;
			Payload[27] = 2;
			Payload[31] = 2;
			break;
		case 4:
			Size = 12;
			if (peer.peerConnectionState != PeerBase.ConnectionStateValue.Connected)
			{
				commandFlags = 2;
			}
			break;
		case 6:
			Size = 12 + payload.Length;
			break;
		case 7:
			Size = 16 + payload.Length;
			commandFlags = 0;
			break;
		case 8:
			Size = 32 + payload.Length;
			break;
		case 1:
			Size = 20;
			commandFlags = 0;
			break;
		case 3:
		case 5:
			break;
		}
	}

	internal static NCommand CreateAck(EnetPeer peer, NCommand commandToAck, int sentTime)
	{
		byte[] array = new byte[8];
		SupportClass.NumberToByteArray(array, 0, commandToAck.reliableSequenceNumber);
		SupportClass.NumberToByteArray(array, 4, sentTime);
		return new NCommand(peer, 1, array, commandToAck.commandChannelID);
	}

	internal NCommand(EnetPeer peer, BinaryReader buffer)
	{
		commandType = buffer.ReadByte();
		commandChannelID = buffer.ReadByte();
		commandFlags = buffer.ReadByte();
		reservedByte = buffer.ReadByte();
		Size = Protocol.deserializeInteger(buffer);
		reliableSequenceNumber = Protocol.deserializeInteger(buffer);
		peer.bytesIn += Size;
		switch (commandType)
		{
		case 1:
			ackReceivedReliableSequenceNumber = Protocol.deserializeInteger(buffer);
			ackReceivedSentTime = Protocol.deserializeInteger(buffer);
			break;
		case 6:
			Payload = new byte[Size - 12];
			break;
		case 7:
			unreliableSequenceNumber = Protocol.deserializeInteger(buffer);
			Payload = new byte[Size - 16];
			break;
		case 8:
			startSequenceNumber = Protocol.deserializeInteger(buffer);
			fragmentCount = Protocol.deserializeInteger(buffer);
			fragmentNumber = Protocol.deserializeInteger(buffer);
			totalLength = Protocol.deserializeInteger(buffer);
			fragmentOffset = Protocol.deserializeInteger(buffer);
			Payload = new byte[Size - 32];
			fragmentsRemaining = fragmentCount;
			break;
		case 3:
		{
			short peerID = Protocol.deserializeShort(buffer);
			long position = buffer.BaseStream.Position;
			position = buffer.BaseStream.Seek(30L, SeekOrigin.Current) - position;
			int num = (int)position;
			if (peer.peerID == -1)
			{
				peer.peerID = peerID;
			}
			break;
		}
		}
		if (Payload != null)
		{
			buffer.Read(Payload, 0, Payload.Length);
		}
	}

	internal byte[] Serialize()
	{
		if (completeCommand != null)
		{
			return completeCommand;
		}
		int num = ((Payload != null) ? Payload.Length : 0);
		int num2 = 12;
		if (commandType == 7)
		{
			num2 = 16;
		}
		else if (commandType == 8)
		{
			num2 = 32;
		}
		completeCommand = new byte[num2 + num];
		completeCommand[0] = commandType;
		completeCommand[1] = commandChannelID;
		completeCommand[2] = commandFlags;
		completeCommand[3] = 4;
		SupportClass.NumberToByteArray(completeCommand, 4, completeCommand.Length);
		SupportClass.NumberToByteArray(completeCommand, 8, reliableSequenceNumber);
		if (commandType == 7)
		{
			SupportClass.NumberToByteArray(completeCommand, 12, unreliableSequenceNumber);
		}
		else if (commandType == 8)
		{
			SupportClass.NumberToByteArray(completeCommand, 12, startSequenceNumber);
			SupportClass.NumberToByteArray(completeCommand, 16, fragmentCount);
			SupportClass.NumberToByteArray(completeCommand, 20, fragmentNumber);
			SupportClass.NumberToByteArray(completeCommand, 24, totalLength);
			SupportClass.NumberToByteArray(completeCommand, 28, fragmentOffset);
		}
		if (num > 0)
		{
			Array.Copy(Payload, 0, completeCommand, num2, num);
		}
		Payload = null;
		return completeCommand;
	}

	public int CompareTo(NCommand other)
	{
		if (((uint)commandFlags & (true ? 1u : 0u)) != 0)
		{
			return reliableSequenceNumber - other.reliableSequenceNumber;
		}
		return unreliableSequenceNumber - other.unreliableSequenceNumber;
	}

	public override string ToString()
	{
		return $"NC({commandChannelID}|{commandType} r/u: {reliableSequenceNumber}/{unreliableSequenceNumber} st/r#/rt:{commandSentTime}/{commandSentCount}/{timeoutTime})";
	}
}
