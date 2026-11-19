using System;
using System.Collections;
using System.IO;
using System.Text;

namespace ExitGames.Client.Photon;

public class SupportClass
{
	public class ThreadSafeRandom
	{
		private static Random _r = new Random();

		public static int Next()
		{
			lock (_r)
			{
				return _r.Next();
			}
		}
	}

	public static void WriteStackTrace(Exception throwable, TextWriter stream)
	{
		stream.WriteLine(throwable.ToString());
		stream.WriteLine(throwable.StackTrace);
		stream.Flush();
	}

	public static string DictionaryToString(IDictionary dictionary)
	{
		if (dictionary == null)
		{
			return "null";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("{");
		foreach (object key in dictionary.Keys)
		{
			if (stringBuilder.Length > 1)
			{
				stringBuilder.Append(", ");
			}
			Type type;
			string text;
			if (dictionary[key] == null)
			{
				type = typeof(object);
				text = "null";
			}
			else
			{
				type = dictionary[key].GetType();
				text = dictionary[key].ToString();
			}
			if (typeof(IDictionary).Equals(type) || typeof(Hashtable).Equals(type))
			{
				text = DictionaryToString((IDictionary)dictionary[key]);
			}
			stringBuilder.AppendFormat("({0}){1}=({2}){3}", key.GetType().Name, key, type.Name, text);
		}
		stringBuilder.Append("}");
		return stringBuilder.ToString();
	}

	[Obsolete("Use DictionaryToString() instead.")]
	public static string HashtableToString(Hashtable hash)
	{
		return DictionaryToString(hash);
	}

	public static void NumberToByteArray(byte[] buffer, int index, short number)
	{
		byte[] bytes = BitConverter.GetBytes(number);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		Array.Copy(bytes, 0, buffer, index, bytes.Length);
	}

	public static void NumberToByteArray(byte[] buffer, int index, int number)
	{
		byte[] bytes = BitConverter.GetBytes(number);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		Array.Copy(bytes, 0, buffer, index, bytes.Length);
	}

	public static void NumberToByteArray(byte[] buffer, int index, long number)
	{
		byte[] bytes = BitConverter.GetBytes(number);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		Array.Copy(bytes, 0, buffer, index, bytes.Length);
	}

	public static string ByteArrayToString(byte[] list)
	{
		if (list == null)
		{
			return string.Empty;
		}
		return BitConverter.ToString(list);
	}

	public static Hashtable DeserializeData(byte[] dataBytes)
	{
		if (dataBytes == null)
		{
			return null;
		}
		Hashtable hashtable = null;
		try
		{
			hashtable = Protocol.deserializeHashTable(new BinaryReader(new MemoryStream(dataBytes)));
		}
		catch (ArgumentException throwable)
		{
			WriteStackTrace(throwable, Console.Error);
			hashtable = null;
		}
		catch (IOException throwable2)
		{
			WriteStackTrace(throwable2, Console.Error);
			hashtable = null;
		}
		catch (ObjectDisposedException throwable3)
		{
			WriteStackTrace(throwable3, Console.Error);
			hashtable = null;
		}
		catch (Exception throwable4)
		{
			WriteStackTrace(throwable4, Console.Error);
			hashtable = null;
		}
		return hashtable;
	}

	public static byte[] SerializeData(Hashtable data)
	{
		if (data == null)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		Protocol.serializeHashTable(binaryWriter, data, setType: false, protocolOneFive: true);
		binaryWriter.Close();
		memoryStream.Close();
		return memoryStream.ToArray();
	}
}
