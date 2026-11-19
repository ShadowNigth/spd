namespace Sabresaurus.SabreCSG;

public struct Matrix2x2
{
	public float m00;

	public float m10;

	public float m01;

	public float m11;

	public static Matrix2x2 Identity
	{
		get
		{
			Matrix2x2 result = default(Matrix2x2);
			result.m00 = 1f;
			result.m10 = 0f;
			result.m01 = 0f;
			result.m11 = 1f;
			return result;
		}
	}

	public static Matrix2x2 Zero
	{
		get
		{
			Matrix2x2 result = default(Matrix2x2);
			result.m00 = 0f;
			result.m10 = 0f;
			result.m01 = 0f;
			result.m11 = 0f;
			return result;
		}
	}

	public Matrix2x2 Inverse
	{
		get
		{
			float num = 1f / Determinant;
			Matrix2x2 result = default(Matrix2x2);
			result.m00 = m11 * num;
			result.m10 = (0f - m10) * num;
			result.m01 = (0f - m01) * num;
			result.m11 = m00 * num;
			return result;
		}
	}

	public float Determinant => m00 * m11 - m01 * m10;

	public override string ToString()
	{
		return m00 + "\t" + m10 + "\t" + m01 + "\t" + m11;
	}
}
