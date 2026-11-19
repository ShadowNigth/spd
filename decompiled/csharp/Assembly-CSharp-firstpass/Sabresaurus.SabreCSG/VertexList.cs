using System.Collections.Generic;

namespace Sabresaurus.SabreCSG;

public class VertexList
{
	private List<Vertex> vertices = new List<Vertex>();

	public List<Vertex> Vertices => vertices;

	public void Clear()
	{
		vertices.Clear();
	}

	public int AddOrGet(Vertex vertex)
	{
		for (int i = 0; i < vertices.Count; i++)
		{
			if (vertices[i] == vertex)
			{
				return i;
			}
		}
		vertices.Add(vertex);
		return vertices.Count - 1;
	}

	public int Add(Vertex vertex)
	{
		vertices.Add(vertex);
		return vertices.Count - 1;
	}
}
