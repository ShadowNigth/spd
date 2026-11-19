using UnityEngine;

namespace Sabresaurus.SabreCSG;

internal class SimpleEdge
{
	public Vector3 Position1;

	public Vector3 Position2;

	public Vector3 MidPoint;

	public Plane Plane = default(Plane);

	public int Count = 1;

	public SimpleEdge(Vector3 position1, Vector3 position2, Vector3 normal, int startingCount = 1)
	{
		Position1 = position1;
		Position2 = position2;
		Count = startingCount;
		MidPoint = (position1 + position2) * 0.5f;
		Plane = new Plane(position1, position2, position1 + normal);
	}

	public bool Matches(Vector3 otherPosition1, Vector3 otherPosition2)
	{
		if (Position1.EqualsWithEpsilonLower3(otherPosition1) && Position2.EqualsWithEpsilonLower3(otherPosition2))
		{
			return true;
		}
		if (Position1.EqualsWithEpsilonLower3(otherPosition2) && Position2.EqualsWithEpsilonLower3(otherPosition1))
		{
			return true;
		}
		return false;
	}

	public bool CollinearIntersects(Vector3 otherPosition1, Vector3 otherPosition2)
	{
		Vector3 normalized = (Position2 - Position1).normalized;
		Vector3 normalized2 = (otherPosition2 - otherPosition1).normalized;
		float num = Vector3.Dot(normalized, normalized2);
		if (num > 0.99f || num < -0.99f)
		{
			float f = Vector3.Dot(normalized, Vector3.up);
			Vector3 vector = ((!(Mathf.Abs(f) > 0.9f)) ? Vector3.Cross(Vector3.up, normalized).normalized : Vector3.Cross(Vector3.forward, normalized).normalized);
			Vector3 rhs = Vector3.Cross(vector, normalized);
			float num2 = Vector3.Dot(Position1, vector);
			float num3 = Vector3.Dot(Position1, rhs);
			float num4 = Vector3.Dot(otherPosition1, vector);
			float num5 = Vector3.Dot(otherPosition1, rhs);
			if (Mathf.Abs(num2 - num4) < 0.1f && Mathf.Abs(num3 - num5) < 0.1f)
			{
				float num6 = Vector3.Dot(normalized, Position1);
				float num7 = Vector3.Dot(normalized, Position2);
				float num8;
				float num9;
				if (num > 0f)
				{
					num8 = Vector3.Dot(normalized, otherPosition1);
					num9 = Vector3.Dot(normalized, otherPosition2);
				}
				else
				{
					num8 = Vector3.Dot(normalized, otherPosition2);
					num9 = Vector3.Dot(normalized, otherPosition1);
				}
				if (num8 < num7 - 0.01f && num9 > num6 + 0.01f)
				{
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}
}
