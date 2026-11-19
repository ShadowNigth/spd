using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Volumes
{
	public class PhysicsVolumeComponent : MonoBehaviour
	{
		private class TrackedRigidbody
		{
			public Rigidbody rigidbody;

			public bool hadGravity;

			public TrackedRigidbody(Rigidbody rigidbody)
			{
				this.rigidbody = rigidbody;
				hadGravity = rigidbody.useGravity;
			}
		}

		public PhysicsVolumeForceMode forceMode;

		public PhysicsVolumeForceSpace forceSpace;

		public Vector3 force = new Vector3(0f, 0f, 0f);

		public PhysicsVolumeForceMode relativeForceMode;

		public PhysicsVolumeForceSpace relativeForceSpace;

		public Vector3 relativeForce = new Vector3(0f, 0f, 0f);

		public PhysicsVolumeForceMode torqueForceMode;

		public PhysicsVolumeForceSpace torqueSpace;

		public Vector3 torque = new Vector3(0f, 0f, 0f);

		public PhysicsVolumeForceMode relativeTorqueForceMode;

		public PhysicsVolumeForceSpace relativeTorqueSpace;

		public Vector3 relativeTorque = new Vector3(0f, 0f, 0f);

		public PhysicsVolumeGravityMode gravity;

		public LayerMask layer = -1;

		public bool useFilterTag;

		public string filterTag = "Untagged";

		private List<TrackedRigidbody> rigidBodies;

		private void OnEnable()
		{
			rigidBodies = new List<TrackedRigidbody>();
		}

		private void FixedUpdate()
		{
			for (int num = rigidBodies.Count - 1; num >= 0; num--)
			{
				TrackedRigidbody trackedRigidbody = rigidBodies[num];
				Rigidbody rigidbody = trackedRigidbody.rigidbody;
				if (!rigidbody)
				{
					rigidBodies.RemoveAt(num);
				}
				else
				{
					Vector3 vector = ((forceSpace != PhysicsVolumeForceSpace.Relative) ? force : (base.transform.rotation * force));
					switch (forceMode)
					{
					case PhysicsVolumeForceMode.Force:
						rigidbody.AddForce(vector, ForceMode.Force);
						break;
					case PhysicsVolumeForceMode.Impulse:
						rigidbody.AddForce(vector, ForceMode.Impulse);
						break;
					case PhysicsVolumeForceMode.VelocityChange:
						rigidbody.AddForce(vector, ForceMode.VelocityChange);
						break;
					case PhysicsVolumeForceMode.Acceleration:
						rigidbody.AddForce(vector, ForceMode.Acceleration);
						break;
					}
					Vector3 vector2 = ((relativeForceSpace != PhysicsVolumeForceSpace.Relative) ? relativeForce : (base.transform.rotation * relativeForce));
					switch (relativeForceMode)
					{
					case PhysicsVolumeForceMode.Force:
						rigidbody.AddRelativeForce(vector2, ForceMode.Force);
						break;
					case PhysicsVolumeForceMode.Impulse:
						rigidbody.AddRelativeForce(vector2, ForceMode.Impulse);
						break;
					case PhysicsVolumeForceMode.VelocityChange:
						rigidbody.AddRelativeForce(vector2, ForceMode.VelocityChange);
						break;
					case PhysicsVolumeForceMode.Acceleration:
						rigidbody.AddRelativeForce(vector2, ForceMode.Acceleration);
						break;
					}
					Vector3 vector3 = ((torqueSpace != PhysicsVolumeForceSpace.Relative) ? torque : (base.transform.rotation * torque));
					switch (torqueForceMode)
					{
					case PhysicsVolumeForceMode.Force:
						rigidbody.AddTorque(vector3, ForceMode.Force);
						break;
					case PhysicsVolumeForceMode.Impulse:
						rigidbody.AddTorque(vector3, ForceMode.Impulse);
						break;
					case PhysicsVolumeForceMode.VelocityChange:
						rigidbody.AddTorque(vector3, ForceMode.VelocityChange);
						break;
					case PhysicsVolumeForceMode.Acceleration:
						rigidbody.AddTorque(vector3, ForceMode.Acceleration);
						break;
					}
					Vector3 vector4 = ((relativeTorqueSpace != PhysicsVolumeForceSpace.Relative) ? relativeTorque : (base.transform.rotation * relativeTorque));
					switch (relativeTorqueForceMode)
					{
					case PhysicsVolumeForceMode.Force:
						rigidbody.AddRelativeTorque(vector4, ForceMode.Force);
						break;
					case PhysicsVolumeForceMode.Impulse:
						rigidbody.AddRelativeTorque(vector4, ForceMode.Impulse);
						break;
					case PhysicsVolumeForceMode.VelocityChange:
						rigidbody.AddRelativeTorque(vector4, ForceMode.VelocityChange);
						break;
					case PhysicsVolumeForceMode.Acceleration:
						rigidbody.AddRelativeTorque(vector4, ForceMode.Acceleration);
						break;
					}
				}
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (!other || !layer.Contains(other.gameObject.layer) || (useFilterTag && other.tag != filterTag))
			{
				return;
			}
			Rigidbody rigidbody = other.GetComponent<Rigidbody>();
			if ((bool)rigidbody)
			{
				if (rigidBodies.Find((TrackedRigidbody r) => r.rigidbody == rigidbody) == null)
				{
					rigidBodies.Add(new TrackedRigidbody(rigidbody));
				}
				switch (gravity)
				{
				case PhysicsVolumeGravityMode.Enable:
					rigidbody.useGravity = true;
					break;
				case PhysicsVolumeGravityMode.Disable:
				case PhysicsVolumeGravityMode.ZeroGravity:
				case PhysicsVolumeGravityMode.ZeroGravityRestore:
					rigidbody.useGravity = false;
					break;
				}
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (!other || !layer.Contains(other.gameObject.layer) || (useFilterTag && other.tag != filterTag))
			{
				return;
			}
			Rigidbody rigidbody = other.GetComponent<Rigidbody>();
			if ((bool)rigidbody)
			{
				int index = rigidBodies.FindIndex((TrackedRigidbody r) => r.rigidbody == rigidbody);
				TrackedRigidbody trackedRigidbody = rigidBodies[index];
				rigidBodies.RemoveAt(index);
				switch (gravity)
				{
				case PhysicsVolumeGravityMode.ZeroGravity:
					rigidbody.useGravity = true;
					break;
				case PhysicsVolumeGravityMode.ZeroGravityRestore:
					rigidbody.useGravity = trackedRigidbody.hadGravity;
					break;
				}
			}
		}
	}
}
