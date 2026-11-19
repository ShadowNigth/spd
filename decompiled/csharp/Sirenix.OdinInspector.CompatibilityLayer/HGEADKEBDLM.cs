using Sirenix.Serialization;
using UnityEngine;

public class HGEADKEBDLM : MinimalBaseFormatter<Vector3Int>
{
	private static readonly Serializer<int> CBLOCJIFLHG = Serializer.Get<int>();

	protected override void Read(ref Vector3Int EHAPKEKPMOE, IDataReader KEAHPPEIJFH)
	{
		EHAPKEKPMOE.x = CBLOCJIFLHG.ReadValue(KEAHPPEIJFH);
		EHAPKEKPMOE.y = CBLOCJIFLHG.ReadValue(KEAHPPEIJFH);
		EHAPKEKPMOE.z = CBLOCJIFLHG.ReadValue(KEAHPPEIJFH);
	}

	protected override void Write(ref Vector3Int EHAPKEKPMOE, IDataWriter ACALPNFLMEP)
	{
		CBLOCJIFLHG.WriteValue(EHAPKEKPMOE.x, ACALPNFLMEP);
		CBLOCJIFLHG.WriteValue(EHAPKEKPMOE.y, ACALPNFLMEP);
		CBLOCJIFLHG.WriteValue(EHAPKEKPMOE.z, ACALPNFLMEP);
	}
}
