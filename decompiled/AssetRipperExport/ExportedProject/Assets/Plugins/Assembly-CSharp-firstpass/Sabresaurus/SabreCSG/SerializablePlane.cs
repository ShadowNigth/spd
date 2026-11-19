using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	[Serializable]
	public struct SerializablePlane
	{
		[SerializeField]
		private Vector3 normal;

		[SerializeField]
		private float distance;

		public Vector3 Normal
		{
			get
			{
				return normal;
			}
			set
			{
				normal = value;
			}
		}

		public float Distance
		{
			get
			{
				return distance;
			}
			set
			{
				distance = value;
			}
		}

		public Plane UnityPlane
		{
			get
			{
				return new Plane
				{
					normal = normal,
					distance = distance
				};
			}
		}

		public SerializablePlane(Plane unityPlane)
		{
			normal = unityPlane.normal;
			distance = unityPlane.distance;
		}

		public SerializablePlane(Vector3 normal, float distance)
		{
			this.normal = normal;
			this.distance = distance;
		}
	}
}
