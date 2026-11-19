using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public static class Ext
{
	public static GameObject CreateSubModel(this Transform source, SkinnedMeshRenderer skinnedMesh)
	{
		GameObject gameObject = new GameObject(skinnedMesh.gameObject.name);
		gameObject.transform.parent = source;
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
		Transform[] array = new Transform[skinnedMesh.bones.Length];
		for (int i = 0; i < skinnedMesh.bones.Length; i++)
		{
			array[i] = FindChildByName(skinnedMesh.bones[i].name, source);
		}
		skinnedMeshRenderer.bones = array;
		skinnedMeshRenderer.sharedMesh = skinnedMesh.sharedMesh;
		skinnedMeshRenderer.sharedMaterials = skinnedMesh.sharedMaterials;
		skinnedMeshRenderer.updateWhenOffscreen = true;
		return skinnedMeshRenderer.gameObject;
	}

	private static Transform FindChildByName(string Name, Transform GO)
	{
		if (GO.name == Name)
		{
			return GO.transform;
		}
		foreach (Transform item in GO)
		{
			Transform transform = FindChildByName(Name, item);
			if (transform != null)
			{
				return transform;
			}
		}
		return null;
	}

	public static void ResetAnimationState(this Animation animation, bool Play)
	{
		animation.Rewind();
		foreach (AnimationState item in animation)
		{
			if (item.wrapMode == WrapMode.Default || item.wrapMode == WrapMode.Once)
			{
				item.time = 0f;
				animation.Play(item.name);
				break;
			}
		}
		animation.Sample();
		animation.Stop();
	}

	public static void Print(this object o)
	{
		Debug.Log(o);
	}

	public static Transform FirstOrDefault(this Transform transform, Func<Transform, bool> query)
	{
		if (query(transform))
		{
			return transform;
		}
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform transform2 = transform.GetChild(i).FirstOrDefault(query);
			if (transform2 != null)
			{
				return transform2;
			}
		}
		return null;
	}

	public static Transform FindInChild(this Transform t, params string[] name)
	{
		return t.GetTransforms().FirstOrDefault((Transform a) => name.Contains(a.name));
	}

	public static Transform FindDeepChild(this Transform aParent, string aName)
	{
		foreach (Transform item in aParent)
		{
			if (item.name == aName)
			{
				return item;
			}
			Transform transform2 = item.FindDeepChild(aName);
			if (transform2 != null)
			{
				return transform2;
			}
		}
		return null;
	}

	public static T2 TryGet<T, T2>(this Dictionary<T, T2> dict, T key)
	{
		dict.TryGetValue(key, out var value);
		return value;
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		if (source is ICollection<TSource> collection)
		{
			return collection.Contains(value);
		}
		return source.Contains(value, null);
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<TSource>.Default;
		}
		if (source == null)
		{
			throw new ArgumentException("source");
		}
		foreach (TSource item in source)
		{
			if (comparer.Equals(item, value))
			{
				return true;
			}
		}
		return false;
	}

	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw new Exception("source is null");
		}
		if (source is IList<TSource> list)
		{
			if (list.Count > 0)
			{
				return list[0];
			}
		}
		else
		{
			using IEnumerator<TSource> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		return default(TSource);
	}

	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		if (source == null)
		{
			throw new ArgumentException("source");
		}
		return source.CreateOrderedEnumerable(keySelector, null, descending: false);
	}

	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		if (source == null)
		{
			throw new ArgumentException("source");
		}
		return source.CreateOrderedEnumerable(keySelector, null, descending: true);
	}

	public static float Max<T>(this IEnumerable<T> source, Func<T, float> selector)
	{
		float num = float.MinValue;
		foreach (T item in source)
		{
			float num2 = selector(item);
			if (num < num2)
			{
				num = num2;
			}
		}
		return num;
	}

	public static float Min<T>(this IEnumerable<T> source, Func<T, float> selector)
	{
		float num = float.MaxValue;
		foreach (T item in source)
		{
			float num2 = selector(item);
			if (num > num2)
			{
				num = num2;
			}
		}
		return num;
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				return true;
			}
		}
		return false;
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source)
	{
		if (source.GetEnumerator().MoveNext())
		{
			return true;
		}
		return false;
	}

	public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		foreach (TSource item in source)
		{
			if (!predicate(item))
			{
				return false;
			}
		}
		return true;
	}

	public static T Next<T>(this IEnumerable<T> ts, T t)
	{
		T val = default(T);
		bool flag = false;
		foreach (T t2 in ts)
		{
			if (flag && t.Equals(val))
			{
				return t2;
			}
			val = t2;
			flag = true;
		}
		return ts.First();
	}

	public static T Prev<T>(this IEnumerable<T> tt, T t) where T : class
	{
		T val = (T)null;
		foreach (T item in tt)
		{
			if (val != null && item == t)
			{
				return val;
			}
			val = item;
		}
		return val;
	}

	public static void SetActive(this Component th, bool to)
	{
		th.gameObject.SetActive(to);
	}

	public static void SetLayer(this Component th, int to)
	{
		foreach (Transform transform in th.transform.GetTransforms())
		{
			transform.gameObject.layer = to;
		}
	}

	public static void SetLayer(this Component th, int from, int to)
	{
		foreach (Transform transform in th.transform.GetTransforms())
		{
			if (transform.gameObject.layer == from)
			{
				transform.gameObject.layer = to;
			}
		}
	}

	public static string[] Split2(this string s)
	{
		return s.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
	}

	public static T GetValue<T>(this Component c, string str)
	{
		return (T)c.GetType().GetField(str).GetValue(c);
	}

	public static void SetValue<T>(this Component c, string str, T value)
	{
		c.GetType().GetField(str).SetValue(c, value);
	}

	public static string[] Split(this string s, string d)
	{
		return s.Split(new string[1] { d }, StringSplitOptions.None);
	}

	public static string[] Split2(this string s, string d)
	{
		return s.Split(new string[1] { d }, StringSplitOptions.RemoveEmptyEntries);
	}

	public static string[][] Split3(this string s, string d, string d2)
	{
		string[] array = s.Split(new string[1] { d }, StringSplitOptions.RemoveEmptyEntries);
		string[][] array2 = new string[array.Length][];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = array[i].Split(d2);
		}
		return array2;
	}

	public static string CalculateMD5(string input)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(input);
		byte[] array = MD5.Create().ComputeHash(bytes);
		return BitConverter.ToString(array).Replace("-", string.Empty).ToLower();
	}

	public static string CalculateMD5Hash(string input)
	{
		MD5 mD = MD5.Create();
		input += input;
		byte[] bytes = Encoding.ASCII.GetBytes(input);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString().ToLower();
	}

	public static void SetLayer(this Transform g, int l)
	{
		foreach (Transform transform in g.GetTransforms())
		{
			transform.gameObject.layer = l;
		}
	}

	public static int SelectIndex<T>(this IEnumerable<T> strs, T t) where T : class
	{
		int num = 0;
		foreach (T str in strs)
		{
			if (str == t)
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static IEnumerable<Transform> GetTransforms(this Transform ts)
	{
		yield return ts;
		IEnumerator enumerator = ts.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform t = (Transform)enumerator.Current;
				foreach (Transform transform in t.GetTransforms())
				{
					yield return transform;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			IDisposable disposable2 = (disposable = enumerator as IDisposable);
			if (disposable != null)
			{
				disposable2.Dispose();
			}
		}
	}

	public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> coll, int N)
	{
		return coll.Reverse().Take(N).Reverse();
	}

	public static T Random<T>(this IEnumerable<T> source)
	{
		return source.Skip(UnityEngine.Random.Range(0, source.Count())).FirstOrDefault();
	}

	public static T AddOrGet<T>(this GameObject g) where T : Component
	{
		T component = g.GetComponent<T>();
		if (component == null)
		{
			return g.AddComponent<T>();
		}
		return component;
	}

	public static void SetLayer(this GameObject g, int l)
	{
		foreach (Transform transform in g.transform.GetTransforms())
		{
			transform.gameObject.layer = l;
		}
	}

	public static T Parse<T>(this string s)
	{
		return (T)Enum.Parse(typeof(T), s);
	}

	public static IEnumerable<Transform> Parent(this Transform t)
	{
		while (t != null)
		{
			yield return t;
			t = t.parent;
		}
	}

	public static T GetComponentInParrent<T>(this Transform t) where T : Component
	{
		int num = 0;
		T component;
		while (true)
		{
			if (t == null || num > 4)
			{
				return (T)null;
			}
			component = t.GetComponent<T>();
			if (component != null)
			{
				break;
			}
			t = t.parent;
			num++;
		}
		return component;
	}

	public static MonoBehaviour GetMonoBehaviorInParrent(this Transform t)
	{
		int num = 0;
		MonoBehaviour component;
		while (true)
		{
			if (t == null || num > 4)
			{
				return null;
			}
			component = t.GetComponent<MonoBehaviour>();
			if (component != null)
			{
				break;
			}
			t = t.parent;
			num++;
		}
		return component;
	}

	public static int Max(this IEnumerable<int> source)
	{
		int num = 0;
		bool flag = false;
		foreach (int item in source)
		{
			if (flag)
			{
				if (item > num)
				{
					num = item;
				}
			}
			else
			{
				num = item;
				flag = true;
			}
		}
		if (!flag)
		{
			Debug.LogWarning("no elements");
		}
		return num;
	}
}
