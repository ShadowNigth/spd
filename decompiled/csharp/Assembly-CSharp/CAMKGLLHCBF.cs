using System.IO;
using ProtoBuf;

public static class CAMKGLLHCBF
{
	public static T BHCPIKOHHCC<T>(this BinaryReader GDKFLGBMPBB)
	{
		return Serializer.DeserializeWithLengthPrefix<T>(GDKFLGBMPBB.BaseStream, PrefixStyle.Fixed32);
	}

	public static void BHCPIKOHHCC<T>(this BinaryReader GDKFLGBMPBB, out T JDKLJHNJNLG)
	{
		JDKLJHNJNLG = Serializer.DeserializeWithLengthPrefix<T>(GDKFLGBMPBB.BaseStream, PrefixStyle.Fixed32);
	}

	public static void KLPPJEDJOAI<T>(this BinaryWriter GDIFBJBOCJM, T GDKFLGBMPBB)
	{
		Serializer.SerializeWithLengthPrefix(GDIFBJBOCJM.BaseStream, GDKFLGBMPBB, PrefixStyle.Fixed32);
	}

	public static void KLPPJEDJOAI(this BinaryWriter GDKFLGBMPBB, OHMGCMOBAGN OGJIDBEODPM)
	{
		GDKFLGBMPBB.Write(OGJIDBEODPM.ToString());
	}
}
