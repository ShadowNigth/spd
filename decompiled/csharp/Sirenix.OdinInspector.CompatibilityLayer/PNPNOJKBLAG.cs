using Sirenix.Serialization;
using UnityEngine;

public class PNPNOJKBLAG : MinimalBaseFormatter<Vector2Int>
{
	private static readonly Serializer<int> CBLOCJIFLHG = Serializer.Get<int>();

	protected override void Read(ref Vector2Int EHAPKEKPMOE, IDataReader KEAHPPEIJFH)
	{
		EHAPKEKPMOE.x = CBLOCJIFLHG.ReadValue(KEAHPPEIJFH);
		EHAPKEKPMOE.y = CBLOCJIFLHG.ReadValue(KEAHPPEIJFH);
	}

	protected override void Write(ref Vector2Int EHAPKEKPMOE, IDataWriter ACALPNFLMEP)
	{
		CBLOCJIFLHG.WriteValue(EHAPKEKPMOE.x, ACALPNFLMEP);
		CBLOCJIFLHG.WriteValue(EHAPKEKPMOE.y, ACALPNFLMEP);
	}
}
