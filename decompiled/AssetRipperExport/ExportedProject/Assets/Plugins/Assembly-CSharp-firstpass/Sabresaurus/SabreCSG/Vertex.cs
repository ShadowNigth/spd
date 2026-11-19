using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	[Serializable]
	public class Vertex : IDeepCopyable<Vertex>, IEquatable<Vertex>
	{
		public Vector3 Position;

		public Vector2 UV;

		public Vector3 Normal;

		public Color32 Color = UnityEngine.Color.white;

		public Vertex()
		{
		}

		public Vertex(Vector3 position, Vector3 normal, Vector2 uv)
		{
			Position = position;
			UV = uv;
			Normal = normal;
		}

		public Vertex(Vector3 position, Vector3 normal, Vector2 uv, Color32 color)
		{
			Position = position;
			UV = uv;
			Normal = normal;
			Color = color;
		}

		public void FlipNormal()
		{
			Normal = -Normal;
		}

		public static Vertex Lerp(Vertex a, Vertex b, float t)
		{
			Vertex vertex = new Vertex();
			vertex.Position = Vector3.Lerp(a.Position, b.Position, t);
			vertex.UV = Vector2.Lerp(a.UV, b.UV, t);
			vertex.Normal = Vector3.Lerp(a.Normal, b.Normal, t);
			vertex.Color = Color32.Lerp(a.Color, b.Color, t);
			return vertex;
		}

		public Vertex DeepCopy()
		{
			return new Vertex(Position, Normal, UV, Color);
		}

		public override string ToString()
		{
			return string.Format(string.Format("[Vertex] Pos: {0},{1},{2}", Position.x, Position.y, Position.z));
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Vertex);
		}

		public bool Equals(Vertex other)
		{
			return other != null && EqualityComparer<Vector3>.Default.Equals(Position, other.Position) && EqualityComparer<Vector2>.Default.Equals(UV, other.UV) && EqualityComparer<Vector3>.Default.Equals(Normal, other.Normal) && EqualityComparer<Color32>.Default.Equals(Color, other.Color);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Vertex lhs, Vertex rhs)
		{
			if (object.ReferenceEquals(lhs, rhs))
			{
				return true;
			}
			if (object.ReferenceEquals(lhs, null) || object.ReferenceEquals(rhs, null))
			{
				return false;
			}
			return lhs.Position == rhs.Position && lhs.UV == rhs.UV && lhs.Normal == rhs.Normal && lhs.Color.Equals(rhs.Color);
		}

		public static bool operator !=(Vertex lhs, Vertex rhs)
		{
			return !(lhs == rhs);
		}
	}
}
