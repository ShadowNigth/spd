using System.Collections;
using System.Collections.Generic;

public class FOPOGLDICCK<T> : IEnumerable<T>, IEnumerable
{
	private SortedList<T, object> IKHNNOLFBMP = new SortedList<T, object>();

	public int KKKLPHAPBBD
	{
		get
		{
			return IKHNNOLFBMP.Count;
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		return IKHNNOLFBMP.Keys.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void JNOEPLIAGIE(T BOJGPCBPMFH)
	{
		IKHNNOLFBMP.Remove(BOJGPCBPMFH);
	}

	public void IPDNNOIOAIO(T BOJGPCBPMFH)
	{
		IKHNNOLFBMP.Add(BOJGPCBPMFH, null);
	}
}
