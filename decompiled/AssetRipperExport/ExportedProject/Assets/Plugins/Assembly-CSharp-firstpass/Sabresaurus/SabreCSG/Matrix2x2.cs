namespace Sabresaurus.SabreCSG
{
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
				return new Matrix2x2
				{
					m00 = 1f,
					m10 = 0f,
					m01 = 0f,
					m11 = 1f
				};
			}
		}

		public static Matrix2x2 Zero
		{
			get
			{
				return new Matrix2x2
				{
					m00 = 0f,
					m10 = 0f,
					m01 = 0f,
					m11 = 0f
				};
			}
		}

		public Matrix2x2 Inverse
		{
			get
			{
				float num = 1f / Determinant;
				return new Matrix2x2
				{
					m00 = m11 * num,
					m10 = (0f - m10) * num,
					m01 = (0f - m01) * num,
					m11 = m00 * num
				};
			}
		}

		public float Determinant
		{
			get
			{
				return m00 * m11 - m01 * m10;
			}
		}

		public override string ToString()
		{
			return m00 + "\t" + m10 + "\t" + m01 + "\t" + m11;
		}
	}
}
