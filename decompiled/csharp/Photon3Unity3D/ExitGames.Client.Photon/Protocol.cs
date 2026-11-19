using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExitGames.Client.Photon;

public class Protocol
{
	internal static readonly Dictionary<Type, CustomType> TypeDict = new Dictionary<Type, CustomType>();

	internal static readonly Dictionary<byte, CustomType> CodeDict = new Dictionary<byte, CustomType>();

	internal static bool TryRegisterType(Type type, byte typeCode, SerializeMethod serializeFunction, DeserializeMethod deserializeFunction)
	{
		if (CodeDict.ContainsKey(typeCode) || TypeDict.ContainsKey(type))
		{
			return false;
		}
		CustomType value = new CustomType(type, typeCode, serializeFunction, deserializeFunction);
		CodeDict.Add(typeCode, value);
		TypeDict.Add(type, value);
		return true;
	}

	private static bool SerializeCustom(BinaryWriter dout, object serObject)
	{
		if (TypeDict.TryGetValue(serObject.GetType(), out var value))
		{
			byte[] array = value.SerializeFunction(serObject);
			dout.Write((byte)99);
			dout.Write(value.Code);
			serializeShort(dout, (short)array.Length, setType: false);
			dout.Write(array);
			return true;
		}
		return false;
	}

	private static object DeserializeCustom(BinaryReader din, byte customTypeCode)
	{
		short count = deserializeShort(din);
		byte[] serializedCustomObject = din.ReadBytes(count);
		if (CodeDict.TryGetValue(customTypeCode, out var value))
		{
			return value.DeserializeFunction(serializedCustomObject);
		}
		return null;
	}

	internal static byte[] SerializeOperationRequest(Dictionary<byte, object> opParameters, byte opCode)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(opCode);
		if (opParameters == null)
		{
			opParameters = new Dictionary<byte, object>();
		}
		serializeShort(binaryWriter, (short)opParameters.Count, setType: false);
		foreach (KeyValuePair<byte, object> opParameter in opParameters)
		{
			binaryWriter.Write(opParameter.Key);
			serialize(binaryWriter, opParameter.Value, setType: true, protocolOneFive: true);
		}
		binaryWriter.Close();
		memoryStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] Serialize(object obj)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter dout = new BinaryWriter(memoryStream);
		serialize(dout, obj, setType: true, protocolOneFive: true);
		return memoryStream.ToArray();
	}

	public static object Deserialize(byte[] serializedData)
	{
		MemoryStream input = new MemoryStream(serializedData);
		BinaryReader binaryReader = new BinaryReader(input);
		return deserialize(binaryReader, binaryReader.ReadByte());
	}

	private static void serialize(BinaryWriter dout, object serObject, bool setType, bool protocolOneFive)
	{
		if (serObject == null)
		{
			if (!protocolOneFive)
			{
				throw new SystemException("cannot serialize(): null");
			}
			if (setType)
			{
				dout.Write((byte)42);
			}
			return;
		}
		Type type = serObject.GetType();
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Byte:
			serializeByte(dout, (byte)serObject, setType);
			return;
		case TypeCode.String:
			serializeString(dout, (string)serObject, setType);
			return;
		case TypeCode.Boolean:
			serializeBoolean(dout, (bool)serObject, setType);
			return;
		case TypeCode.Int16:
			serializeShort(dout, (short)serObject, setType);
			return;
		case TypeCode.Int32:
			serializeInteger(dout, (int)serObject, setType);
			return;
		case TypeCode.Int64:
			serializeLong(dout, (long)serObject, setType);
			return;
		}
		if (serObject is Hashtable)
		{
			serializeHashTable(dout, (Hashtable)serObject, setType, protocolOneFive);
		}
		else if (serObject is IDictionary)
		{
			SerializeDictionary(dout, (IDictionary)serObject, setType);
		}
		else if (serObject is EventData)
		{
			SerializeEventData(dout, (EventData)serObject, setType);
		}
		else if (serObject is OperationRequest)
		{
			SerializeOperationRequest(dout, (OperationRequest)serObject, setType);
		}
		else if (serObject is OperationResponse)
		{
			SerializeOperationResponse(dout, (OperationResponse)serObject, setType);
		}
		else if (protocolOneFive)
		{
			if (type.IsArray)
			{
				if (serObject is byte[])
				{
					serializeByteArray(dout, (byte[])serObject, setType);
				}
				else if ((object)type.GetElementType() == typeof(object))
				{
					SerializeObjectArray(dout, serObject as object[], setType);
				}
				else
				{
					serializeArray(dout, (Array)serObject, setType);
				}
			}
			else if (serObject is float)
			{
				serializeFloat(dout, (float)serObject, setType);
			}
			else if (serObject is double)
			{
				serializeDouble(dout, (double)serObject, setType);
			}
			else if (!SerializeCustom(dout, serObject))
			{
				throw new SystemException("cannot serialize(): " + serObject.GetType());
			}
		}
		else if (serObject is byte[])
		{
			serializeByteArray(dout, (byte[])serObject, setType);
		}
		else if (serObject is string[])
		{
			serializeStringArray(dout, (string[])serObject, setType);
		}
		else if (serObject is int[])
		{
			serializeIntArray(dout, (int[])serObject, setType);
		}
		else
		{
			if (!(serObject is ArrayList))
			{
				throw new SystemException("cannot serialize(): " + serObject.GetType());
			}
			serializeVector(dout, (ArrayList)serObject, setType);
		}
	}

	private static void SerializeObjectArray(BinaryWriter dout, object[] objects, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)122);
		}
		serializeShort(dout, (short)objects.Length, setType: false);
		foreach (object serObject in objects)
		{
			serialize(dout, serObject, setType: true, protocolOneFive: true);
		}
	}

	private static void serializeArray(BinaryWriter dout, Array serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)121);
		}
		serializeShort(dout, (short)serObject.Length, setType: false);
		Type elementType = serObject.GetType().GetElementType();
		byte codeOfType = GetCodeOfType(elementType);
		if (codeOfType != 0)
		{
			dout.Write(codeOfType);
			{
				foreach (object item in serObject)
				{
					serialize(dout, item, setType: false, protocolOneFive: true);
				}
				return;
			}
		}
		if (TypeDict.TryGetValue(elementType, out var value))
		{
			dout.Write((byte)99);
			dout.Write(value.Code);
			{
				foreach (object item2 in serObject)
				{
					byte[] array = value.SerializeFunction(item2);
					serializeShort(dout, (short)array.Length, setType: false);
					dout.Write(array);
				}
				return;
			}
		}
		throw new NotSupportedException("cannot serialize array of type " + elementType);
	}

	private static void serializeString(BinaryWriter dout, string serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)115);
		}
		byte[] bytes = Encoding.UTF8.GetBytes(serObject);
		serializeShort(dout, (short)bytes.Length, setType: false);
		dout.Write(bytes, 0, bytes.Length);
	}

	private static void serializeStringArray(BinaryWriter dout, string[] serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)97);
		}
		serializeShort(dout, (short)serObject.Length, setType: false);
		for (int i = 0; i < serObject.Length; i++)
		{
			serializeString(dout, serObject[i], setType: false);
		}
	}

	private static void serializeByteArray(BinaryWriter dout, byte[] serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)120);
		}
		serializeInteger(dout, serObject.Length, setType: false);
		dout.Write(serObject, 0, serObject.Length);
	}

	private static void serializeIntArray(BinaryWriter dout, int[] serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)110);
		}
		serializeInteger(dout, serObject.Length, setType: false);
		for (int i = 0; i < serObject.Length; i++)
		{
			serializeInteger(dout, serObject[i], setType: false);
		}
	}

	private static void serializeInteger(BinaryWriter dout, int serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)105);
		}
		byte[] bytes = BitConverter.GetBytes(serObject);
		if (BitConverter.IsLittleEndian)
		{
			byte b = bytes[0];
			byte b2 = bytes[1];
			bytes[0] = bytes[3];
			bytes[1] = bytes[2];
			bytes[2] = b2;
			bytes[3] = b;
		}
		dout.Write(bytes, 0, bytes.Length);
	}

	internal static void serializeHashTable(BinaryWriter dout, Hashtable serObject, bool setType, bool protocolOneFive)
	{
		if (setType)
		{
			dout.Write((byte)104);
		}
		serializeShort(dout, (short)serObject.Count, setType: false);
		IEnumerator enumerator = serObject.Keys.GetEnumerator();
		while (enumerator.MoveNext())
		{
			object current = enumerator.Current;
			serialize(dout, current, setType: true, protocolOneFive);
			serialize(dout, serObject[current], setType: true, protocolOneFive);
		}
	}

	internal static void SerializeOperationRequest(BinaryWriter dout, OperationRequest serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)113);
		}
		dout.Write(serObject.OperationCode);
		if (serObject.Parameters == null)
		{
			serObject.Parameters = new Dictionary<byte, object>(0);
		}
		serializeShort(dout, (short)serObject.Parameters.Count, setType: false);
		foreach (KeyValuePair<byte, object> parameter in serObject.Parameters)
		{
			dout.Write(parameter.Key);
			serialize(dout, parameter.Value, setType: true, protocolOneFive: true);
		}
	}

	internal static void SerializeOperationResponse(BinaryWriter dout, OperationResponse serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)112);
		}
		dout.Write(serObject.OperationCode);
		dout.Write(serObject.ReturnCode);
		if (string.IsNullOrEmpty(serObject.DebugMessage))
		{
			dout.Write((byte)42);
		}
		else
		{
			serializeString(dout, serObject.DebugMessage, setType: false);
		}
		if (serObject.Parameters == null)
		{
			serObject.Parameters = new Dictionary<byte, object>(0);
		}
		serializeShort(dout, (short)serObject.Parameters.Count, setType: false);
		foreach (KeyValuePair<byte, object> parameter in serObject.Parameters)
		{
			dout.Write(parameter.Key);
			serialize(dout, parameter.Value, setType: true, protocolOneFive: true);
		}
	}

	internal static void SerializeEventData(BinaryWriter dout, EventData serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)101);
		}
		dout.Write(serObject.Code);
		if (serObject.Parameters == null)
		{
			serObject.Parameters = new Dictionary<byte, object>(0);
		}
		serializeShort(dout, (short)serObject.Parameters.Count, setType: false);
		foreach (KeyValuePair<byte, object> parameter in serObject.Parameters)
		{
			dout.Write(parameter.Key);
			serialize(dout, parameter.Value, setType: true, protocolOneFive: true);
		}
	}

	internal static void SerializeDictionary(BinaryWriter dout, IDictionary serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)68);
		}
		Type[] genericArguments = serObject.GetType().GetGenericArguments();
		bool flag = (object)genericArguments[0] == typeof(object);
		bool flag2 = (object)genericArguments[1] == typeof(object);
		if (flag)
		{
			dout.Write((byte)0);
		}
		else
		{
			byte codeOfType = GetCodeOfType(genericArguments[0]);
			dout.Write(codeOfType);
		}
		if (flag2)
		{
			dout.Write((byte)0);
		}
		else
		{
			byte codeOfType2 = GetCodeOfType(genericArguments[1]);
			dout.Write(codeOfType2);
		}
		serializeShort(dout, (short)serObject.Count, setType: false);
		foreach (DictionaryEntry item in serObject)
		{
			serialize(dout, item.Key, flag, protocolOneFive: true);
			serialize(dout, item.Value, flag2, protocolOneFive: true);
		}
	}

	private static void serializeVector(BinaryWriter dout, ArrayList serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)118);
		}
		serializeShort(dout, (short)serObject.Count, setType: false);
		bool setType2 = true;
		IEnumerator enumerator = serObject.GetEnumerator();
		while (enumerator.MoveNext())
		{
			serialize(dout, enumerator.Current, setType2, protocolOneFive: false);
			setType2 = false;
		}
	}

	private static void serializeBoolean(BinaryWriter dout, bool serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)111);
		}
		dout.Write(serObject);
	}

	private static void serializeShort(BinaryWriter dout, short serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)107);
		}
		byte[] bytes = BitConverter.GetBytes(serObject);
		if (BitConverter.IsLittleEndian)
		{
			byte b = bytes[0];
			bytes[0] = bytes[1];
			bytes[1] = b;
		}
		dout.Write(bytes, 0, bytes.Length);
	}

	private static void serializeLong(BinaryWriter dout, long serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)108);
		}
		byte[] bytes = BitConverter.GetBytes(serObject);
		if (BitConverter.IsLittleEndian)
		{
			byte b = bytes[0];
			byte b2 = bytes[1];
			byte b3 = bytes[2];
			byte b4 = bytes[3];
			bytes[0] = bytes[7];
			bytes[1] = bytes[6];
			bytes[2] = bytes[5];
			bytes[3] = bytes[4];
			bytes[4] = b4;
			bytes[5] = b3;
			bytes[6] = b2;
			bytes[7] = b;
		}
		dout.Write(bytes, 0, 8);
	}

	private static void serializeFloat(BinaryWriter dout, float serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)102);
		}
		byte[] bytes = BitConverter.GetBytes(serObject);
		if (BitConverter.IsLittleEndian)
		{
			byte b = bytes[0];
			byte b2 = bytes[1];
			bytes[0] = bytes[3];
			bytes[1] = bytes[2];
			bytes[2] = b2;
			bytes[3] = b;
		}
		dout.Write(bytes, 0, 4);
	}

	private static void serializeDouble(BinaryWriter dout, double serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)100);
		}
		byte[] bytes = BitConverter.GetBytes(serObject);
		if (BitConverter.IsLittleEndian)
		{
			byte b = bytes[0];
			byte b2 = bytes[1];
			byte b3 = bytes[2];
			byte b4 = bytes[3];
			bytes[0] = bytes[7];
			bytes[1] = bytes[6];
			bytes[2] = bytes[5];
			bytes[3] = bytes[4];
			bytes[4] = b4;
			bytes[5] = b3;
			bytes[6] = b2;
			bytes[7] = b;
		}
		dout.Write(bytes, 0, 8);
	}

	private static void serializeByte(BinaryWriter dout, byte serObject, bool setType)
	{
		if (setType)
		{
			dout.Write((byte)98);
		}
		dout.Write(serObject);
	}

	internal static OperationRequest DeserializeOperationRequest(BinaryReader din)
	{
		OperationRequest operationRequest = new OperationRequest();
		operationRequest.OperationCode = deserializeByte(din);
		operationRequest.Parameters = DeserializeParameterTable(din);
		return operationRequest;
	}

	internal static OperationResponse DeserializeOperationResponse(BinaryReader din)
	{
		OperationResponse operationResponse = new OperationResponse();
		operationResponse.OperationCode = deserializeByte(din);
		operationResponse.ReturnCode = deserializeShort(din);
		operationResponse.DebugMessage = deserialize(din, deserializeByte(din)) as string;
		operationResponse.Parameters = DeserializeParameterTable(din);
		return operationResponse;
	}

	internal static EventData DeserializeEventData(BinaryReader din)
	{
		EventData eventData = new EventData();
		eventData.Code = deserializeByte(din);
		eventData.Parameters = DeserializeParameterTable(din);
		return eventData;
	}

	internal static Dictionary<byte, object> DeserializeParameterTable(BinaryReader binaryReader)
	{
		short num = deserializeShort(binaryReader);
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>(num);
		for (int i = 0; i < num; i++)
		{
			byte key = binaryReader.ReadByte();
			object value = deserialize(binaryReader, binaryReader.ReadByte());
			dictionary[key] = value;
		}
		return dictionary;
	}

	private static Type GetTypeOfCode(byte typeCode)
	{
		switch (typeCode)
		{
		case 105:
			return typeof(int);
		case 115:
			return typeof(string);
		case 97:
			return typeof(string[]);
		case 120:
			return typeof(byte[]);
		case 110:
			return typeof(int[]);
		case 104:
			return typeof(Hashtable);
		case 68:
			return typeof(IDictionary);
		case 111:
			return typeof(bool);
		case 107:
			return typeof(short);
		case 108:
			return typeof(long);
		case 98:
			return typeof(byte);
		case 102:
			return typeof(float);
		case 100:
			return typeof(double);
		case 121:
			return typeof(Array);
		case 99:
			return typeof(CustomType);
		case 122:
			return typeof(object[]);
		case 101:
			return typeof(EventData);
		case 113:
			return typeof(OperationRequest);
		case 112:
			return typeof(OperationResponse);
		case 0:
		case 42:
			return typeof(object);
		default:
			Console.WriteLine("missing type: " + typeCode);
			throw new SystemException("deserialize(): " + typeCode);
		}
	}

	private static byte GetCodeOfType(Type type)
	{
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Byte:
			return 98;
		case TypeCode.String:
			return 115;
		case TypeCode.Boolean:
			return 111;
		case TypeCode.Int16:
			return 107;
		case TypeCode.Int32:
			return 105;
		case TypeCode.Int64:
			return 108;
		case TypeCode.Single:
			return 102;
		case TypeCode.Double:
			return 100;
		default:
			if (type.IsArray)
			{
				if ((object)type == typeof(byte[]))
				{
					return 120;
				}
				return 121;
			}
			if ((object)type == typeof(Hashtable))
			{
				return 104;
			}
			if ((object)type == typeof(IDictionary))
			{
				return 68;
			}
			if ((object)type == typeof(EventData))
			{
				return 101;
			}
			if ((object)type == typeof(OperationRequest))
			{
				return 113;
			}
			if ((object)type == typeof(OperationResponse))
			{
				return 112;
			}
			return 0;
		}
	}

	private static object deserialize(BinaryReader din, byte type)
	{
		switch (type)
		{
		case 105:
			return deserializeInteger(din);
		case 115:
			return deserializeString(din);
		case 97:
			return deserializeStringArray(din);
		case 118:
			return deserializeVector(din);
		case 120:
			return deserializeByteArray(din);
		case 110:
			return deserializeIntArray(din);
		case 104:
			return deserializeHashTable(din);
		case 68:
			return DeserializeDictionary(din);
		case 111:
			return deserializeBoolean(din);
		case 107:
			return deserializeShort(din);
		case 108:
			return deserializeLong(din);
		case 98:
			return deserializeByte(din);
		case 102:
			return deserializeFloat(din);
		case 100:
			return deserializeDouble(din);
		case 121:
			return deserializeArray(din);
		case 99:
		{
			byte customTypeCode = din.ReadByte();
			return DeserializeCustom(din, customTypeCode);
		}
		case 122:
			return DeserializeObjectArray(din);
		case 101:
			return DeserializeEventData(din);
		case 113:
			return DeserializeOperationRequest(din);
		case 112:
			return DeserializeOperationResponse(din);
		case 0:
		case 42:
			return null;
		default:
			Console.WriteLine("missing type: " + type);
			throw new SystemException("deserialize(): " + type);
		}
	}

	private static object[] DeserializeObjectArray(BinaryReader din)
	{
		short num = deserializeShort(din);
		object[] array = new object[num];
		for (int i = 0; i < num; i++)
		{
			byte type = din.ReadByte();
			array.SetValue(deserialize(din, type), i);
		}
		return array;
	}

	private static Array createArrayByType(byte arrayType, short length)
	{
		return Array.CreateInstance(GetTypeOfCode(arrayType), length);
	}

	private static Array deserializeArray(BinaryReader din)
	{
		short num = deserializeShort(din);
		byte b = din.ReadByte();
		Array array;
		switch (b)
		{
		case 121:
		{
			Array array2 = deserializeArray(din);
			Type type = array2.GetType();
			array = Array.CreateInstance(type, num);
			array.SetValue(array2, 0);
			for (short num2 = 1; num2 < num; num2++)
			{
				array2 = deserializeArray(din);
				array.SetValue(array2, num2);
			}
			break;
		}
		case 120:
		{
			array = Array.CreateInstance(typeof(byte[]), num);
			for (short num2 = 0; num2 < num; num2++)
			{
				Array array2 = deserializeByteArray(din);
				array.SetValue(array2, num2);
			}
			break;
		}
		case 99:
		{
			byte b2 = din.ReadByte();
			if (CodeDict.TryGetValue(b2, out var value))
			{
				array = Array.CreateInstance(value.Type, num);
				for (int i = 0; i < num; i++)
				{
					short count = deserializeShort(din);
					byte[] serializedCustomObject = din.ReadBytes(count);
					array.SetValue(value.DeserializeFunction(serializedCustomObject), i);
				}
				break;
			}
			throw new SystemException("Cannot find deserializer for custom type: " + b2);
		}
		default:
		{
			array = createArrayByType(b, num);
			for (short num2 = 0; num2 < num; num2++)
			{
				array.SetValue(deserialize(din, b), num2);
			}
			break;
		}
		}
		return array;
	}

	internal static int deserializeInteger(BinaryReader din)
	{
		byte[] array = din.ReadBytes(4);
		if (BitConverter.IsLittleEndian)
		{
			return (array[0] << 24) | (array[1] << 16) | (array[2] << 8) | array[3];
		}
		return BitConverter.ToInt32(array, 0);
	}

	internal static float deserializeFloat(BinaryReader din)
	{
		byte[] array = din.ReadBytes(4);
		if (BitConverter.IsLittleEndian)
		{
			byte b = array[0];
			byte b2 = array[1];
			array[0] = array[3];
			array[1] = array[2];
			array[2] = b2;
			array[3] = b;
		}
		return BitConverter.ToSingle(array, 0);
	}

	internal static double deserializeDouble(BinaryReader din)
	{
		byte[] array = din.ReadBytes(8);
		if (BitConverter.IsLittleEndian)
		{
			byte b = array[0];
			byte b2 = array[1];
			byte b3 = array[2];
			byte b4 = array[3];
			array[0] = array[7];
			array[1] = array[6];
			array[2] = array[5];
			array[3] = array[4];
			array[4] = b4;
			array[5] = b3;
			array[6] = b2;
			array[7] = b;
		}
		return BitConverter.ToDouble(array, 0);
	}

	private static string deserializeString(BinaryReader din)
	{
		short num = deserializeShort(din);
		if (num == 0)
		{
			return "";
		}
		byte[] array = new byte[num];
		din.Read(array, 0, array.Length);
		return Encoding.UTF8.GetString(array, 0, array.Length);
	}

	private static string[] deserializeStringArray(BinaryReader din)
	{
		int num = deserializeShort(din);
		string[] array = new string[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = deserializeString(din);
		}
		return array;
	}

	private static byte[] deserializeByteArray(BinaryReader din)
	{
		int count = deserializeInteger(din);
		return din.ReadBytes(count);
	}

	private static int[] deserializeIntArray(BinaryReader din)
	{
		int num = deserializeInteger(din);
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = deserializeInteger(din);
		}
		return array;
	}

	internal static Hashtable deserializeHashTable(BinaryReader din)
	{
		int num = deserializeShort(din);
		Hashtable hashtable = new Hashtable(num);
		for (int i = 0; i < num; i++)
		{
			object key = deserialize(din, din.ReadByte());
			object value = deserialize(din, din.ReadByte());
			hashtable[key] = value;
		}
		return hashtable;
	}

	internal static IDictionary DeserializeDictionary(BinaryReader din)
	{
		byte b = din.ReadByte();
		byte b2 = din.ReadByte();
		int num = deserializeShort(din);
		bool flag = b == 0 || b == 42;
		bool flag2 = b2 == 0 || b2 == 42;
		Type typeOfCode = GetTypeOfCode(b);
		Type typeOfCode2 = GetTypeOfCode(b2);
		Type type = typeof(Dictionary<, >).MakeGenericType(typeOfCode, typeOfCode2);
		IDictionary dictionary = Activator.CreateInstance(type) as IDictionary;
		for (int i = 0; i < num; i++)
		{
			object key = deserialize(din, flag ? din.ReadByte() : b);
			object value = deserialize(din, flag2 ? din.ReadByte() : b2);
			dictionary.Add(key, value);
		}
		return dictionary;
	}

	private static ArrayList deserializeVector(BinaryReader din)
	{
		int num = deserializeShort(din);
		ArrayList arrayList = new ArrayList(num);
		if (num > 0)
		{
			byte type = din.ReadByte();
			for (int i = 0; i < num; i++)
			{
				arrayList.Add(deserialize(din, type));
			}
		}
		return arrayList;
	}

	private static bool deserializeBoolean(BinaryReader din)
	{
		return din.ReadBoolean();
	}

	internal static short deserializeShort(BinaryReader din)
	{
		byte[] array = din.ReadBytes(2);
		if (BitConverter.IsLittleEndian)
		{
			return (short)((array[0] << 8) | array[1]);
		}
		return BitConverter.ToInt16(array, 0);
	}

	private static long deserializeLong(BinaryReader din)
	{
		byte[] array = din.ReadBytes(8);
		if (BitConverter.IsLittleEndian)
		{
			return (long)(((ulong)array[0] << 56) | ((ulong)array[1] << 48) | ((ulong)array[2] << 40) | ((ulong)array[3] << 32) | ((ulong)array[4] << 24) | ((ulong)array[5] << 16) | ((ulong)array[6] << 8) | array[7]);
		}
		return BitConverter.ToInt64(array, 0);
	}

	private static byte deserializeByte(BinaryReader din)
	{
		return din.ReadByte();
	}
}
