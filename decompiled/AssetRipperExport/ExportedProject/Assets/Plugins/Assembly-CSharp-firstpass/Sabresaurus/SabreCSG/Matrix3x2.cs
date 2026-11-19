using UnityEngine;

namespace Sabresaurus.SabreCSG
{
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
			return new Matrix3x2
			{
				m00 = m00 * o.m00 + m10 * o.m01,
				m10 = m00 * o.m10 + m10 * o.m11,
				m01 = m01 * o.m00 + m11 * o.m01,
				m11 = m01 * o.m10 + m11 * o.m11,
				m02 = m02 * o.m00 + m12 * o.m01,
				m12 = m02 * o.m10 + m12 * o.m11
			};
		}

		public Vector2 Multiply(Vector3 o)
		{
			return new Vector2
			{
				x = m00 * o.x + m01 * o.y + m02 * o.z,
				y = m10 * o.x + m11 * o.y + m12 * o.z
			};
		}

		public override string ToString()
		{
			return m00 + "\t" + m10 + "\t" + m01 + "\t" + m11 + "\t" + m02 + "\t" + m12;
		}
	}
}
