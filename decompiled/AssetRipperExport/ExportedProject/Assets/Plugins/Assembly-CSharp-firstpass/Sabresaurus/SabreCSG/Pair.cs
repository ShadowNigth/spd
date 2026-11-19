namespace Sabresaurus.SabreCSG
{
	public struct Pair<T, U>
	{
		private T first;

		private U second;

		public T First
		{
			get
			{
				return first;
			}
		}

		public U Second
		{
			get
			{
				return second;
			}
		}

		public Pair(T first, U second)
		{
			this.first = first;
			this.second = second;
		}
	}
}
