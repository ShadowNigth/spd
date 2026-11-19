using UnityEngine;

namespace Sabresaurus.SabreCSG;

public struct Matrix3x2
{
	public float m00;

	public float m10;

	public float m01;

	public float m11;

	public float m02;

	public float m12;

	public Matrix3x2 Multiply(Matrix2x2 o)
	{
		Matrix3x2 result = default(Matrix3x2);
		result.m00 = m00 * o.m00 + m10 * o.m01;
		result.m10 = m00 * o.m10 + m10 * o.m11;
		result.m01 = m01 * o.m00 + m11 * o.m01;
		result.m11 = m01 * o.m10 + m11 * o.m11;
		result.m02 = m02 * o.m00 + m12 * o.m01;
		result.m12 = m02 * o.m10 + m12 * o.m11;
		return result;
	}

	public Vector2 Multiply(Vector3 o)
	{
		Vector2 result = default(Vector2);
		result.x = m00 * o.x + m01 * o.y + m02 * o.z;
		result.y = m10 * o.x + m11 * o.y + m12 * o.z;
		return result;
	}

	public override string ToString()
	{
		return m00 + "\t" + m10 + "\t" + m01 + "\t" + m11 + "\t" + m02 + "\t" + m12;
	}
}
