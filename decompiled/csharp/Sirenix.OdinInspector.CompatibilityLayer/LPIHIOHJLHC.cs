using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.Networking;

public abstract class LPIHIOHJLHC : NetworkBehaviour, ISerializationCallbackReceiver, ISupportsPrefabSerialization
{
	[SerializeField]
	[HideInInspector]
	private SerializationData serializationData;

	SerializationData ISupportsPrefabSerialization.NFOHJKFCEIC
	{
		get
		{
			return serializationData;
		}
		set
		{
			serializationData = value;
		}
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
		UnitySerializationUtility.DeserializeUnityObject(this, ref serializationData);
		OnAfterDeserialize();
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
		UnitySerializationUtility.SerializeUnityObject(this, ref serializationData);
		OnBeforeSerialize();
	}

	protected virtual void OnAfterDeserialize()
	{
	}

	protected virtual void OnBeforeSerialize()
	{
	}

	private void KIJADGFJKOK()
	{
	}

	public override bool OnSerialize(NetworkWriter ACALPNFLMEP, bool COBFODGAMMM)
	{
		bool result = default(bool);
		return result;
	}

	public override void OnDeserialize(NetworkReader KEAHPPEIJFH, bool KALPBLOJBBK)
	{
	}
}
