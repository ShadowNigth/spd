using UnityEngine;

namespace Sabresaurus.SabreCSG;

public static class MathHelper
{
	public const float EPSILON_5 = 1E-05f;

	public const float EPSILON_4 = 0.0001f;

	public const float EPSILON_3 = 0.001f;

	public const float EPSILON_2 = 0.01f;

	public const float EPSILON_1 = 0.1f;

	public const float EPSILON_3_3 = 0.003f;

	public static int GetSideThick(Plane plane, Vector3 point)
	{
		float num = Vector3.Dot(plane.normal, point) + plane.distance;
		if (num > 0.02f)
		{
			return 1;
		}
		if (num < -0.02f)
		{
			return -1;
		}
		return 0;
	}

	public static Vector2 Vector2Cross(Vector2 vector)
	{
		return new Vector2(vector.y, 0f - vector.x);
	}

	public static float InverseLerpNoClamp(float from, float to, float value)
	{
		if (from < to)
		{
			value -= from;
			value /= to - from;
			return value;
		}
		return 1f - (value - to) / (from - to);
	}

	public static Vector3 VectorInDirection(Vector3 sourceVector, Vector3 direction)
	{
		return direction * Vector3.Dot(sourceVector, direction);
	}

	public static Vector3 ClosestPointOnPlane(Vector3 point, Plane plane)
	{
		float distanceToPoint = plane.GetDistanceToPoint(point);
		return point - plane.normal * distanceToPoint;
	}

	public static float DistanceToRay(Vector3 X0, Ray ray)
	{
		Vector3 origin = ray.origin;
		Vector3 vector = ray.origin + ray.direction;
		Vector3 lhs = X0 - origin;
		Vector3 rhs = X0 - vector;
		return Vector3.Cross(lhs, rhs).magnitude / (origin - vector).magnitude;
	}

	public static bool ClosestPointsOnTwoLines(out Vector3 closestPointLine1, out Vector3 closestPointLine2, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		closestPointLine1 = Vector3.zero;
		closestPointLine2 = Vector3.zero;
		float num = Vector3.Dot(lineVec1, lineVec1);
		float num2 = Vector3.Dot(lineVec1, lineVec2);
		float num3 = Vector3.Dot(lineVec2, lineVec2);
		float num4 = num * num3 - num2 * num2;
		if (num4 != 0f)
		{
			Vector3 rhs = linePoint1 - linePoint2;
			float num5 = Vector3.Dot(lineVec1, rhs);
			float num6 = Vector3.Dot(lineVec2, rhs);
			float value = (num2 * num6 - num5 * num3) / num4;
			float value2 = (num * num6 - num5 * num2) / num4;
			closestPointLine1 = linePoint1 + lineVec1 * Mathf.Clamp01(value);
			closestPointLine2 = linePoint2 + lineVec2 * Mathf.Clamp01(value2);
			return true;
		}
		return false;
	}

	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		Vector3 rhs = linePoint2 - linePoint1;
		Vector3 lhs = point - linePoint1;
		float num = Vector3.Dot(lhs, rhs);
		if (num > 0f)
		{
			if (lhs.magnitude <= rhs.magnitude)
			{
				return 0;
			}
			return 2;
		}
		return 1;
	}

	public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		Vector3 lhs = point - linePoint;
		float num = Vector3.Dot(lhs, lineVec);
		return linePoint + lineVec * num;
	}

	public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		Vector3 vector = ProjectPointOnLine(linePoint1, (linePoint2 - linePoint1).normalized, point);
		return PointOnWhichSideOfLineSegment(linePoint1, linePoint2, vector) switch
		{
			0 => vector, 
			1 => linePoint1, 
			2 => linePoint2, 
			_ => Vector3.zero, 
		};
	}

	public static Vector3 ClosestPointOnLine(Ray ray, Vector3 lineStart, Vector3 lineEnd)
	{
		Vector3 origin = ray.origin;
		Vector3 lineVec = ray.direction * 10000f;
		ClosestPointsOnTwoLines(out var closestPointLine, out var _, origin, lineVec, lineStart, lineEnd - lineStart);
		return closestPointLine;
	}

	public static float RoundFloat(float value, float gridScale)
	{
		float num = 1f / gridScale;
		return gridScale * Mathf.Round(num * value);
	}

	public static Vector3 RoundVector3(Vector3 vector)
	{
		vector.x = Mathf.Round(vector.x);
		vector.y = Mathf.Round(vector.y);
		vector.z = Mathf.Round(vector.z);
		return vector;
	}

	public static Vector3 RoundVector3(Vector3 vector, float gridScale)
	{
		float num = 1f / gridScale;
		vector.x = gridScale * Mathf.Round(num * vector.x);
		vector.y = gridScale * Mathf.Round(num * vector.y);
		vector.z = gridScale * Mathf.Round(num * vector.z);
		return vector;
	}

	public static Vector2 RoundVector2(Vector3 vector)
	{
		vector.x = Mathf.Round(vector.x);
		vector.y = Mathf.Round(vector.y);
		return vector;
	}

	public static Vector2 RoundVector2(Vector2 vector, float gridScale)
	{
		float num = 1f / gridScale;
		vector.x = gridScale * Mathf.Round(num * vector.x);
		vector.y = gridScale * Mathf.Round(num * vector.y);
		return vector;
	}

	public static Vector3 VectorAbs(Vector3 vector)
	{
		vector.x = Mathf.Abs(vector.x);
		vector.y = Mathf.Abs(vector.y);
		vector.z = Mathf.Abs(vector.z);
		return vector;
	}

	public static int Wrap(int i, int range)
	{
		if (i < 0)
		{
			i = range - 1;
		}
		if (i >= range)
		{
			i = 0;
		}
		return i;
	}

	public static float Wrap(float i, float range)
	{
		if (i < 0f)
		{
			i = range - 1f;
		}
		if (i >= range)
		{
			i = 0f;
		}
		return i;
	}

	public static float WrapAngle(float angle)
	{
		while (angle > 180f)
		{
			angle -= 360f;
		}
		while (angle <= -180f)
		{
			angle += 360f;
		}
		return angle;
	}

	public static bool PlaneEqualsLooser(Plane plane1, Plane plane2)
	{
		if (Mathf.Abs(plane1.distance - plane2.distance) < 0.0001f && Mathf.Abs(plane1.normal.x - plane2.normal.x) < 0.0001f && Mathf.Abs(plane1.normal.y - plane2.normal.y) < 0.0001f && Mathf.Abs(plane1.normal.z - plane2.normal.z) < 0.0001f)
		{
			return true;
		}
		return false;
	}

	public static bool PlaneEqualsLooserWithFlip(Plane plane1, Plane plane2)
	{
		if (Mathf.Abs(plane1.distance - plane2.distance) <= 0.08f && Mathf.Abs(plane1.normal.x - plane2.normal.x) < 0.006f && Mathf.Abs(plane1.normal.y - plane2.normal.y) < 0.006f && Mathf.Abs(plane1.normal.z - plane2.normal.z) < 0.006f)
		{
			return true;
		}
		if (Mathf.Abs(0f - plane1.distance - plane2.distance) <= 0.08f && Mathf.Abs(0f - plane1.normal.x - plane2.normal.x) < 0.006f && Mathf.Abs(0f - plane1.normal.y - plane2.normal.y) < 0.006f && Mathf.Abs(0f - plane1.normal.z - plane2.normal.z) < 0.006f)
		{
			return true;
		}
		return false;
	}

	public static bool PlaneEquals(Plane plane1, Plane plane2)
	{
		if (plane1.distance.EqualsWithEpsilon(plane2.distance) && plane1.normal.EqualsWithEpsilon(plane2.normal))
		{
			return true;
		}
		return false;
	}

	public static bool IsVectorInteger(Vector3 vector)
	{
		if (vector.x % 1f != 0f || vector.y % 1f != 0f || vector.z % 1f != 0f)
		{
			return false;
		}
		return true;
	}

	public static bool IsVectorOnGrid(Vector3 position, Vector3 mask, float gridScale)
	{
		if (mask.x != 0f && position.x % gridScale != 0f)
		{
			return false;
		}
		if (mask.y != 0f && position.y % gridScale != 0f)
		{
			return false;
		}
		if (mask.z != 0f && position.z % gridScale != 0f)
		{
			return false;
		}
		return true;
	}
}
