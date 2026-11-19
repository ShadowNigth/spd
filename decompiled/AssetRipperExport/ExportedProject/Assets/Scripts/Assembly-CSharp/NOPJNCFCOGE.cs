using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

[XmlRoot("dictionary")]
public class NOPJNCFCOGE<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
{
	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader KEAHPPEIJFH)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(TKey));
		XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(TValue));
		bool isEmptyElement = KEAHPPEIJFH.IsEmptyElement;
		KEAHPPEIJFH.Read();
		if (!isEmptyElement)
		{
			while (KEAHPPEIJFH.NodeType != XmlNodeType.EndElement)
			{
				KEAHPPEIJFH.ReadStartElement("item");
				KEAHPPEIJFH.ReadStartElement("key");
				TKey key = (TKey)xmlSerializer.Deserialize(KEAHPPEIJFH);
				KEAHPPEIJFH.ReadEndElement();
				KEAHPPEIJFH.ReadStartElement("value");
				TValue value = (TValue)xmlSerializer2.Deserialize(KEAHPPEIJFH);
				KEAHPPEIJFH.ReadEndElement();
				Add(key, value);
				KEAHPPEIJFH.ReadEndElement();
				KEAHPPEIJFH.MoveToContent();
			}
			KEAHPPEIJFH.ReadEndElement();
		}
	}

	public void WriteXml(XmlWriter ACALPNFLMEP)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(TKey));
		XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(TValue));
		foreach (TKey key in base.Keys)
		{
			ACALPNFLMEP.WriteStartElement("item");
			ACALPNFLMEP.WriteStartElement("key");
			xmlSerializer.Serialize(ACALPNFLMEP, key);
			ACALPNFLMEP.WriteEndElement();
			ACALPNFLMEP.WriteStartElement("value");
			TValue val = base[key];
			xmlSerializer2.Serialize(ACALPNFLMEP, val);
			ACALPNFLMEP.WriteEndElement();
			ACALPNFLMEP.WriteEndElement();
		}
	}
}
