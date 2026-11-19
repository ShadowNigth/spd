using System;
using UnityEngine;

public static class EHGKBNLOBHE
{
	[Serializable]
	private class Wrapper<T>
	{
		public T[] Items;
	}

	public static T[] FEBLNMCIBHP<T>(string GMIHNCCACKM)
	{
		Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(GMIHNCCACKM);
		return wrapper.Items;
	}

	public static string GIBKHAGKJHE<T>(T[] ACDLFNJIKCO)
	{
		Wrapper<T> wrapper = new Wrapper<T>();
		wrapper.Items = ACDLFNJIKCO;
		return JsonUtility.ToJson(wrapper);
	}

	public static string GIBKHAGKJHE<T>(T[] ACDLFNJIKCO, bool IGNIHFALLGF)
	{
		Wrapper<T> wrapper = new Wrapper<T>();
		wrapper.Items = ACDLFNJIKCO;
		return JsonUtility.ToJson(wrapper, IGNIHFALLGF);
	}
}
