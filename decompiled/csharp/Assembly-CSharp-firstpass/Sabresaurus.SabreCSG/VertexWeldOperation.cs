using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public abstract class VertexWeldOperation
{
	private Polygon[] sourcePolygons;

	protected List<Vertex> sourceVertices;

	protected List<Polygon> polygons;

	protected Vector3[] previousPlaneNormals;

	protected Dictionary<Vertex, Polygon> vertexPolygonMappings;

	public VertexWeldOperation(Polygon[] sourcePolygons, List<Vertex> sourceVertices)
	{
		this.sourcePolygons = sourcePolygons;
		this.sourceVertices = sourceVertices;
	}

	public List<Polygon> Execute()
	{
		BeginWeld();
		PerformWeld();
		EndWeld();
		return polygons;
	}

	protected void BeginWeld()
	{
		polygons = new List<Polygon>(sourcePolygons);
		previousPlaneNormals = new Vector3[polygons.Count];
		for (int i = 0; i < polygons.Count; i++)
		{
			ref Vector3 reference = ref previousPlaneNormals[i];
			reference = polygons[i].Plane.normal;
		}
		vertexPolygonMappings = GetPolygonMappings(sourcePolygons, sourceVertices);
	}

	public abstract void PerformWeld();

	protected void EndWeld()
	{
		for (int i = 0; i < polygons.Count; i++)
		{
			polygons[i].TryRemoveExtraneousVertices();
			if (polygons[i].Vertices.Length >= 3)
			{
				Vector3 fromDirection = previousPlaneNormals[i];
				polygons[i].CalculatePlane();
				Vector3 normal = polygons[i].Plane.normal;
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, normal);
				int num = polygons[i].Vertices.Length;
				for (int j = 0; j < num; j++)
				{
					Vertex vertex = polygons[i].Vertices[j];
					vertex.Normal = quaternion * vertex.Normal;
				}
			}
		}
		for (int k = 0; k < polygons.Count; k++)
		{
			if (polygons[k].Vertices.Length < 3)
			{
				polygons.RemoveAt(k);
				k--;
			}
		}
	}

	private static Dictionary<Vertex, Polygon> GetPolygonMappings(Polygon[] sourcePolygons, List<Vertex> sourceVertices)
	{
		Dictionary<Vertex, Polygon> dictionary = new Dictionary<Vertex, Polygon>(sourceVertices.Count);
		for (int i = 0; i < sourceVertices.Count; i++)
		{
			Vertex vertex = sourceVertices[i];
			Polygon value = null;
			for (int j = 0; j < sourcePolygons.Length; j++)
			{
				if (sourcePolygons[j].Vertices.Contains(vertex))
				{
					value = sourcePolygons[j];
					break;
				}
			}
			dictionary.Add(vertex, value);
		}
		return dictionary;
	}
}
