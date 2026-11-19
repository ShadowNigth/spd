using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

[Serializable]
public class MaterialMeshDictionary
{
	[Serializable]
	public class MeshObjectMapping
	{
		[SerializeField]
		public Mesh Mesh;

		[SerializeField]
		public GameObject GameObject;
	}

	[Serializable]
	public class Mapping
	{
		[SerializeField]
		public Material Key;

		[SerializeField]
		public List<MeshObjectMapping> MeshObjectMappings;

		public Mapping(Material key, Mesh firstMesh, GameObject firstObject)
		{
			Key = key;
			MeshObjectMappings = new List<MeshObjectMapping>
			{
				new MeshObjectMapping
				{
					Mesh = firstMesh,
					GameObject = firstObject
				}
			};
		}
	}

	[SerializeField]
	private List<Mapping> mappings = new List<Mapping>();

	public int MeshCount
	{
		get
		{
			int num = 0;
			for (int i = 0; i < mappings.Count; i++)
			{
				num += mappings[i].MeshObjectMappings.Count;
			}
			return num;
		}
	}

	public List<MeshObjectMapping> this[Material key]
	{
		get
		{
			for (int i = 0; i < mappings.Count; i++)
			{
				if (mappings[i].Key == key)
				{
					return mappings[i].MeshObjectMappings;
				}
			}
			return new List<MeshObjectMapping>();
		}
	}

	public void Clear()
	{
		mappings.Clear();
	}

	public void Add(Material key, Mesh newMesh, GameObject newObject)
	{
		for (int i = 0; i < mappings.Count; i++)
		{
			if (mappings[i].Key == key)
			{
				mappings[i].MeshObjectMappings.Add(new MeshObjectMapping
				{
					Mesh = newMesh,
					GameObject = newObject
				});
				return;
			}
		}
		mappings.Add(new Mapping(key, newMesh, newObject));
	}

	public bool Contains(Material key)
	{
		for (int i = 0; i < mappings.Count; i++)
		{
			if (mappings[i].Key == key)
			{
				return true;
			}
		}
		return false;
	}
}
