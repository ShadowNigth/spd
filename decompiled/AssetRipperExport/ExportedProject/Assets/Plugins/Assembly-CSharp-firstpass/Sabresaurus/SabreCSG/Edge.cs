using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public class Edge
	{
		private Vertex vertex1;

		private Vertex vertex2;

		public Vertex Vertex1
		{
			get
			{
				return vertex1;
			}
		}

		public Vertex Vertex2
		{
			get
			{
				return vertex2;
			}
		}

		public Vector3 CenterPoint
		{
			get
			{
				return (vertex1.Position + vertex2.Position) * 0.5f;
			}
		}

		public Edge(Vertex vertex1, Vertex vertex2)
		{
			this.vertex1 = vertex1;
			this.vertex2 = vertex2;
		}

		public bool Matches(Edge other)
		{
			if (vertex1.Position.EqualsWithEpsilon(other.vertex1.Position) && vertex2.Position.EqualsWithEpsilon(other.Vertex2.Position))
			{
				return true;
			}
			if (vertex1.Position.EqualsWithEpsilon(other.vertex2.Position) && vertex2.Position.EqualsWithEpsilon(other.Vertex1.Position))
			{
				return true;
			}
			return false;
		}

		public bool Parallel(Edge other)
		{
			Vector3 vector = vertex2.Position - vertex1.Position;
			Vector3 vector2 = other.Vertex2.Position - other.Vertex1.Position;
			float f = Vector3.Dot(vector.normalized, vector2.normalized);
			return Mathf.Abs(f) > 0.99999f;
		}

		public bool Intersects(Edge other)
		{
			if (!Parallel(other))
			{
				return false;
			}
			Vector3 lhs = Vector3.zero;
			Vector3 rhs = Vector3.zero;
			bool flag = false;
			if (vertex1.Position.EqualsWithEpsilon(other.Vertex1.Position))
			{
				flag = true;
				lhs = vertex2.Position - vertex1.Position;
				rhs = other.Vertex2.Position - other.Vertex1.Position;
			}
			else if (vertex2.Position.EqualsWithEpsilon(other.Vertex2.Position))
			{
				flag = true;
				lhs = vertex1.Position - vertex2.Position;
				rhs = other.Vertex1.Position - other.Vertex2.Position;
			}
			else if (vertex1.Position.EqualsWithEpsilon(other.Vertex2.Position))
			{
				flag = true;
				lhs = vertex2.Position - vertex1.Position;
				rhs = other.Vertex1.Position - other.Vertex2.Position;
			}
			else if (vertex2.Position.EqualsWithEpsilon(other.Vertex1.Position))
			{
				flag = true;
				lhs = vertex1.Position - vertex2.Position;
				rhs = other.Vertex2.Position - other.Vertex1.Position;
			}
			if (!flag)
			{
				return false;
			}
			return Vector3.Dot(lhs, rhs) > 0f;
		}

		public bool Collinear(Edge other)
		{
			return EdgeUtility.EdgeMatches(this, other);
		}

		public float GetPlaneIntersectionInterpolant(Plane plane)
		{
			return GetPlaneIntersectionInterpolant(plane, vertex1.Position, vertex2.Position);
		}

		public override string ToString()
		{
			return string.Format(string.Format("[Edge] V1: {0} V2: {1}", vertex1.Position, vertex2.Position));
		}

		public static float GetPlaneIntersectionInterpolant(Plane plane, Vector3 point1, Vector3 point2)
		{
			return ((0f - plane.normal.x) * point1.x - plane.normal.y * point1.y - plane.normal.z * point1.z - plane.distance) / ((0f - plane.normal.x) * (point1.x - point2.x) - plane.normal.y * (point1.y - point2.y) - plane.normal.z * (point1.z - point2.z));
		}
	}
}
