using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Volumes;

[Serializable]
public class PhysicsVolume : Volume
{
	[SerializeField]
	public PhysicsVolumeForceMode forceMode;

	[SerializeField]
	public PhysicsVolumeForceSpace forceSpace;

	[SerializeField]
	public Vector3 force = new Vector3(0f, 0f, 0f);

	[SerializeField]
	public PhysicsVolumeForceMode relativeForceMode;

	[SerializeField]
	public PhysicsVolumeForceSpace relativeForceSpace;

	[SerializeField]
	public Vector3 relativeForce = new Vector3(0f, 0f, 0f);

	[SerializeField]
	public PhysicsVolumeForceMode torqueForceMode;

	[SerializeField]
	public PhysicsVolumeForceSpace torqueSpace;

	[SerializeField]
	public Vector3 torque = new Vector3(0f, 0f, 0f);

	[SerializeField]
	public PhysicsVolumeForceMode relativeTorqueForceMode;

	[SerializeField]
	public PhysicsVolumeForceSpace relativeTorqueSpace;

	[SerializeField]
	public Vector3 relativeTorque = new Vector3(0f, 0f, 0f);

	[SerializeField]
	public PhysicsVolumeGravityMode gravity;

	[SerializeField]
	public LayerMask layer = -1;

	[SerializeField]
	public bool useFilterTag;

	[SerializeField]
	public string filterTag = "Untagged";

	public override void OnCreateVolume(GameObject volume)
	{
		PhysicsVolumeComponent physicsVolumeComponent = volume.AddComponent<PhysicsVolumeComponent>();
		physicsVolumeComponent.forceMode = forceMode;
		physicsVolumeComponent.forceSpace = forceSpace;
		physicsVolumeComponent.force = force;
		physicsVolumeComponent.relativeForceMode = relativeForceMode;
		physicsVolumeComponent.relativeForceSpace = relativeForceSpace;
		physicsVolumeComponent.relativeForce = relativeForce;
		physicsVolumeComponent.torqueForceMode = torqueForceMode;
		physicsVolumeComponent.torqueSpace = torqueSpace;
		physicsVolumeComponent.torque = torque;
		physicsVolumeComponent.relativeTorqueForceMode = relativeTorqueForceMode;
		physicsVolumeComponent.relativeTorqueSpace = relativeTorqueSpace;
		physicsVolumeComponent.relativeTorque = relativeTorque;
		physicsVolumeComponent.gravity = gravity;
		physicsVolumeComponent.layer = layer;
		physicsVolumeComponent.useFilterTag = useFilterTag;
		physicsVolumeComponent.filterTag = filterTag;
	}
}
