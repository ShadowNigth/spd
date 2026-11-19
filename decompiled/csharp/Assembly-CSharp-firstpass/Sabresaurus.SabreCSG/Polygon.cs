using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

[Serializable]
public class Polygon : IDeepCopyable<Polygon>
{
	public class Vector3ComparerEpsilon : IEqualityComparer<Vector3>
	{
		public bool Equals(Vector3 a, Vector3 b)
		{
			return Mathf.Abs(a.x - b.x) < 0.001f && Mathf.Abs(a.y - b.y) < 0.001f && Mathf.Abs(a.z - b.z) < 0.001f;
		}

		public int GetHashCode(Vector3 obj)
		{
			return 1;
		}
	}

	public class VertexComparerEpsilon : IEqualityComparer<Vertex>
	{
		public bool Equals(Vertex a, Vertex b)
		{
			return a.Position.EqualsWithEpsilon(b.Position);
		}

		public int GetHashCode(Vertex obj)
		{
			return 1;
		}
	}

	public class PolygonUIDComparer : IEqualityComparer<Polygon>
	{
		public bool Equals(Polygon a, Polygon b)
		{
			return a.UniqueIndex == b.UniqueIndex;
		}

		public int GetHashCode(Polygon obj)
		{
			return base.GetHashCode();
		}
	}

	public enum PolygonPlaneRelation
	{
		InFront,
		Behind,
		Spanning,
		Coplanar
	}

	public enum PointPlaneRelation
	{
		InFront,
		Behind,
		On
	}

	[SerializeField]
	private Vertex[] vertices;

	[SerializeField]
	private Material material;

	[SerializeField]
	private bool userExcludeFromFinal;

	[SerializeField]
	private int uniqueIndex = -1;

	private bool excludeFromFinal;

	private Plane? cachedPlane;

	public Vertex[] Vertices
	{
		get
		{
			return vertices;
		}
		set
		{
			vertices = value;
			CalculatePlane();
		}
	}

	public Material Material
	{
		get
		{
			return material;
		}
		set
		{
			material = value;
		}
	}

	public bool UserExcludeFromFinal
	{
		get
		{
			return userExcludeFromFinal;
		}
		set
		{
			userExcludeFromFinal = value;
		}
	}

	public int UniqueIndex
	{
		get
		{
			return uniqueIndex;
		}
		set
		{
			uniqueIndex = value;
		}
	}

	public bool ExcludeFromFinal
	{
		get
		{
			return excludeFromFinal;
		}
		set
		{
			excludeFromFinal = value;
		}
	}

	public Plane Plane
	{
		get
		{
			if (!cachedPlane.HasValue)
			{
				CalculatePlane();
			}
			return cachedPlane.Value;
		}
	}

	public Polygon Flipped
	{
		get
		{
			Polygon polygon = DeepCopy();
			polygon.Flip();
			return polygon;
		}
	}

	public Polygon(Vertex[] vertices, Material material, bool isTemporary, bool userExcludeFromFinal, int uniqueIndex = -1)
	{
		this.vertices = vertices;
		this.material = material;
		this.uniqueIndex = uniqueIndex;
		excludeFromFinal = isTemporary;
		this.userExcludeFromFinal = userExcludeFromFinal;
		CalculatePlane();
	}

	public Polygon(Vector3[] vertices, Material material, bool isTemporary, bool userExcludeFromFinal, int uniqueIndex = -1)
	{
		this.vertices = new Vertex[vertices.Length];
		for (int i = 0; i < vertices.Length; i++)
		{
			this.vertices[i] = new Vertex(vertices[i], Vector3.zero, Vector2.zero);
		}
		this.material = material;
		this.uniqueIndex = uniqueIndex;
		excludeFromFinal = isTemporary;
		this.userExcludeFromFinal = userExcludeFromFinal;
		CalculatePlane();
	}

	public Polygon DeepCopy()
	{
		return new Polygon(vertices.DeepCopy(), material, excludeFromFinal, userExcludeFromFinal, uniqueIndex);
	}

	public void CalculatePlane()
	{
		cachedPlane = new Plane(vertices[0].Position, vertices[1].Position, vertices[2].Position);
		if (!(cachedPlane.Value.normal == Vector3.zero) || vertices.Length <= 3)
		{
			return;
		}
		Vector3 position = vertices[0].Position;
		Vector3 position2 = vertices[1].Position;
		for (int i = 3; i < vertices.Length; i++)
		{
			cachedPlane = new Plane(position, position2, vertices[i].Position);
			if (cachedPlane.Value.normal != Vector3.zero)
			{
				break;
			}
		}
	}

	public void Flip()
	{
		Array.Reverse(vertices);
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].Normal *= -1f;
		}
		cachedPlane = cachedPlane.Value.flipped;
	}

	public void ResetVertexNormals()
	{
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].Normal = Plane.normal;
		}
	}

	public Bounds GetBounds()
	{
		Bounds result = new Bounds(vertices[0].Position, Vector3.zero);
		for (int i = 1; i < vertices.Length; i++)
		{
			result.Encapsulate(vertices[i].Position);
		}
		return result;
	}

	public Edge[] GetEdges()
	{
		Edge[] array = new Edge[vertices.Length];
		for (int i = 0; i < vertices.Length; i++)
		{
			int num = ((i + 1 < vertices.Length) ? (i + 1) : 0);
			array[i] = new Edge(vertices[i], vertices[num]);
		}
		return array;
	}

	public Vector3 GetCenterPoint()
	{
		Vector3 position = vertices[0].Position;
		for (int i = 1; i < vertices.Length; i++)
		{
			position += vertices[i].Position;
		}
		return position / vertices.Length;
	}

	public Vector3 GetCenterUV()
	{
		Vector2 uV = vertices[0].UV;
		for (int i = 1; i < vertices.Length; i++)
		{
			uV += vertices[i].UV;
		}
		uV *= 1f / (float)vertices.Length;
		return uV;
	}

	public float GetArea()
	{
		Vector3 forward = Vector3.Normalize(Vector3.Cross(vertices[1].Position - vertices[0].Position, vertices[2].Position - vertices[0].Position));
		Quaternion quaternion = Quaternion.Inverse(Quaternion.LookRotation(forward));
		float num = 0f;
		int num2 = vertices.Length - 1;
		for (int i = 0; i < vertices.Length; i++)
		{
			Vector3 vector = quaternion * vertices[i].Position;
			Vector3 vector2 = quaternion * vertices[num2].Position;
			num += (vector2.x + vector.x) * (vector2.y - vector.y);
			num2 = i;
		}
		return (0f - num) * 0.5f;
	}

	public void SetColor(Color32 newColor)
	{
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].Color = newColor;
		}
	}

	public Vector3 GetTangent()
	{
		return (vertices[1].Position - vertices[0].Position).normalized;
	}

	public bool TryRemoveExtraneousVertices()
	{
		if (vertices.Length == 3)
		{
			return true;
		}
		List<Vertex> list = new List<Vertex>(vertices.Length);
		list.Add(vertices[0]);
		List<Vertex> list2 = list;
		for (int i = 1; i < vertices.Length; i++)
		{
			bool flag = false;
			for (int j = 0; j < list2.Count; j++)
			{
				if (vertices[i].Position.EqualsWithEpsilonLower(list2[j].Position))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list2.Add(vertices[i]);
			}
		}
		if (list2.Count < 3)
		{
			return false;
		}
		vertices = list2.ToArray();
		CalculatePlane();
		return true;
	}

	public void GenerateUvCoordinates()
	{
		Quaternion quaternion = Quaternion.Inverse(Quaternion.LookRotation(-Plane.normal));
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].UV = quaternion * vertices[i].Position * 0.5f;
		}
	}

	public static PolygonPlaneRelation TestPolygonAgainstPlane(Polygon polygon, Plane testPlane)
	{
		if (polygon.Plane.normal == testPlane.normal && polygon.Plane.distance == testPlane.distance)
		{
			return PolygonPlaneRelation.Coplanar;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < polygon.Vertices.Length; i++)
		{
			float distanceToPoint = testPlane.GetDistanceToPoint(polygon.Vertices[i].Position);
			if (distanceToPoint < -0.001f)
			{
				num++;
			}
			else if (distanceToPoint > 0.001f)
			{
				num2++;
			}
		}
		if (num > 0 && num2 > 0)
		{
			return PolygonPlaneRelation.Spanning;
		}
		if (num > 0)
		{
			return PolygonPlaneRelation.InFront;
		}
		if (num2 > 0)
		{
			return PolygonPlaneRelation.Behind;
		}
		return PolygonPlaneRelation.Coplanar;
	}

	public static bool SplitPolygon(Polygon polygon, out Polygon frontPolygon, out Polygon backPolygon, out Vertex newVertex1, out Vertex newVertex2, Plane clipPlane)
	{
		newVertex1 = null;
		newVertex2 = null;
		List<Vertex> list = new List<Vertex>();
		List<Vertex> list2 = new List<Vertex>();
		for (int i = 0; i < polygon.vertices.Length; i++)
		{
			int num = i - 1;
			if (num < 0)
			{
				num = polygon.vertices.Length - 1;
			}
			Vertex vertex = polygon.vertices[i];
			Vertex vertex2 = polygon.vertices[num];
			PointPlaneRelation pointPlaneRelation = ComparePointToPlane(vertex.Position, clipPlane);
			PointPlaneRelation pointPlaneRelation2 = ComparePointToPlane(vertex2.Position, clipPlane);
			if (pointPlaneRelation2 == PointPlaneRelation.InFront && pointPlaneRelation == PointPlaneRelation.InFront)
			{
				list.Add(vertex);
				continue;
			}
			if (pointPlaneRelation2 == PointPlaneRelation.Behind && pointPlaneRelation == PointPlaneRelation.InFront)
			{
				float planeIntersectionInterpolant = Edge.GetPlaneIntersectionInterpolant(clipPlane, vertex2.Position, vertex.Position);
				Vertex vertex3 = Vertex.Lerp(vertex2, vertex, planeIntersectionInterpolant);
				list.Add(vertex3);
				list.Add(vertex);
				list2.Add(vertex3.DeepCopy());
				newVertex2 = vertex3;
				continue;
			}
			if (pointPlaneRelation2 == PointPlaneRelation.InFront && pointPlaneRelation == PointPlaneRelation.Behind)
			{
				float planeIntersectionInterpolant2 = Edge.GetPlaneIntersectionInterpolant(clipPlane, vertex.Position, vertex2.Position);
				Vertex vertex4 = Vertex.Lerp(vertex, vertex2, planeIntersectionInterpolant2);
				list.Add(vertex4);
				list2.Add(vertex4.DeepCopy());
				list2.Add(vertex);
				newVertex1 = vertex4;
				continue;
			}
			if (pointPlaneRelation2 == PointPlaneRelation.Behind && pointPlaneRelation == PointPlaneRelation.Behind)
			{
				list2.Add(vertex);
				continue;
			}
			switch (pointPlaneRelation)
			{
			case PointPlaneRelation.On:
				list.Add(vertex);
				list2.Add(vertex.DeepCopy());
				switch (pointPlaneRelation2)
				{
				case PointPlaneRelation.InFront:
					newVertex1 = vertex;
					break;
				case PointPlaneRelation.Behind:
					newVertex2 = vertex;
					break;
				}
				break;
			case PointPlaneRelation.Behind:
				list2.Add(vertex);
				break;
			case PointPlaneRelation.InFront:
				list.Add(vertex);
				break;
			default:
				throw new Exception("Unhandled polygon configuration");
			}
		}
		frontPolygon = new Polygon(list.ToArray(), polygon.Material, polygon.ExcludeFromFinal, polygon.UserExcludeFromFinal, polygon.uniqueIndex);
		backPolygon = new Polygon(list2.ToArray(), polygon.Material, polygon.ExcludeFromFinal, polygon.UserExcludeFromFinal, polygon.uniqueIndex);
		bool result = true;
		if (frontPolygon.vertices.Length < 3 || frontPolygon.Plane.normal == Vector3.zero)
		{
			frontPolygon = null;
			result = false;
		}
		if (backPolygon.vertices.Length < 3 || backPolygon.Plane.normal == Vector3.zero)
		{
			backPolygon = null;
			result = false;
		}
		return result;
	}

	public static bool PlanePolygonIntersection(Polygon polygon, out Vector3 position1, out Vector3 position2, Plane testPlane)
	{
		position1 = Vector3.zero;
		position2 = Vector3.zero;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < polygon.vertices.Length; i++)
		{
			int num = i - 1;
			if (num < 0)
			{
				num = polygon.vertices.Length - 1;
			}
			Vertex vertex = polygon.vertices[i];
			Vertex vertex2 = polygon.vertices[num];
			PointPlaneRelation pointPlaneRelation = ComparePointToPlane(vertex.Position, testPlane);
			PointPlaneRelation pointPlaneRelation2 = ComparePointToPlane(vertex2.Position, testPlane);
			if (pointPlaneRelation2 == PointPlaneRelation.InFront && pointPlaneRelation == PointPlaneRelation.InFront)
			{
				continue;
			}
			if (pointPlaneRelation2 == PointPlaneRelation.Behind && pointPlaneRelation == PointPlaneRelation.InFront)
			{
				float planeIntersectionInterpolant = Edge.GetPlaneIntersectionInterpolant(testPlane, vertex2.Position, vertex.Position);
				position2 = Vector3.Lerp(vertex2.Position, vertex.Position, planeIntersectionInterpolant);
				flag2 = true;
			}
			else if (pointPlaneRelation2 == PointPlaneRelation.InFront && pointPlaneRelation == PointPlaneRelation.Behind)
			{
				float planeIntersectionInterpolant2 = Edge.GetPlaneIntersectionInterpolant(testPlane, vertex.Position, vertex2.Position);
				position1 = Vector3.Lerp(vertex.Position, vertex2.Position, planeIntersectionInterpolant2);
				flag = true;
			}
			else
			{
				if (pointPlaneRelation2 == PointPlaneRelation.Behind && pointPlaneRelation == PointPlaneRelation.Behind)
				{
					continue;
				}
				switch (pointPlaneRelation)
				{
				case PointPlaneRelation.On:
					switch (pointPlaneRelation2)
					{
					case PointPlaneRelation.InFront:
						position1 = vertex.Position;
						flag = true;
						break;
					case PointPlaneRelation.Behind:
						position2 = vertex.Position;
						flag2 = true;
						break;
					}
					break;
				}
			}
		}
		return flag && flag2;
	}

	public static PointPlaneRelation ComparePointToPlane2(Vector3 point, Plane plane)
	{
		float distanceToPoint = plane.GetDistanceToPoint(point);
		if (distanceToPoint < -1E-05f)
		{
			return PointPlaneRelation.InFront;
		}
		if (distanceToPoint > 1E-05f)
		{
			return PointPlaneRelation.Behind;
		}
		return PointPlaneRelation.On;
	}

	public static PointPlaneRelation ComparePointToPlane(Vector3 point, Plane plane)
	{
		float distanceToPoint = plane.GetDistanceToPoint(point);
		if (distanceToPoint < -0.001f)
		{
			return PointPlaneRelation.InFront;
		}
		if (distanceToPoint > 0.001f)
		{
			return PointPlaneRelation.Behind;
		}
		return PointPlaneRelation.On;
	}

	public static bool ContainsEdge(Polygon polygon, Edge candidateEdge)
	{
		for (int i = 0; i < polygon.Vertices.Length; i++)
		{
			Vector3 position = polygon.Vertices[i].Position;
			Vector3 position2 = polygon.Vertices[(i + 1) % polygon.Vertices.Length].Position;
			if ((candidateEdge.Vertex1.Position == position && candidateEdge.Vertex2.Position == position2) || (candidateEdge.Vertex2.Position == position && candidateEdge.Vertex1.Position == position2))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool FindEdge(Polygon polygon, Edge candidateEdge, out Edge foundEdge)
	{
		for (int i = 0; i < polygon.Vertices.Length; i++)
		{
			Vector3 position = polygon.Vertices[i].Position;
			Vector3 position2 = polygon.Vertices[(i + 1) % polygon.Vertices.Length].Position;
			if ((candidateEdge.Vertex1.Position == position && candidateEdge.Vertex2.Position == position2) || (candidateEdge.Vertex2.Position == position && candidateEdge.Vertex1.Position == position2))
			{
				foundEdge = new Edge(polygon.Vertices[i], polygon.Vertices[(i + 1) % polygon.Vertices.Length]);
				return true;
			}
		}
		foundEdge = null;
		return false;
	}

	[Obsolete("Please use the new TryRemoveExtraneousVertices method as it prevents generating a polygon with less than 3 vertices.", false)]
	public void RemoveExtraneousVertices()
	{
		List<Vertex> list = new List<Vertex>();
		list.Add(vertices[0]);
		for (int i = 1; i < vertices.Length; i++)
		{
			bool flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (vertices[i].Position.EqualsWithEpsilonLower(list[j].Position))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(vertices[i]);
			}
		}
		vertices = list.ToArray();
		if (vertices.Length > 2)
		{
			CalculatePlane();
		}
	}

	[Obsolete("Please assign the Vertices property instead of calling this method.", false)]
	public void SetVertices(Vertex[] vertices)
	{
		this.vertices = vertices;
		CalculatePlane();
	}
}
