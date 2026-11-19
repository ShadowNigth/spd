using System.Collections.Generic;
using System.Linq;
using Sabresaurus.SabreCSG.ShapeEditor.Decomposition;
using UnityEngine;

namespace Sabresaurus.SabreCSG.ShapeEditor;

[ExecuteInEditMode]
public class ShapeEditorBrush : CompoundBrush
{
	public enum ExtrudeMode
	{
		CreatePolygon,
		RevolveShape,
		ExtrudeShape,
		ExtrudePoint,
		ExtrudeBevel
	}

	[SerializeField]
	private Project project = JsonUtility.FromJson<Project>("{\"version\":1,\"shapes\":[{\"segments\":[{\"_position\":{\"x\":-18,\"y\":-8},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-14,\"y\":-11},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-14,\"y\":-13},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-20,\"y\":-13},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-10,\"y\":-19},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-6,\"y\":-19},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-6,\"y\":-16},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-3,\"y\":-19},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":6,\"y\":-19},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":9,\"y\":-16},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":11,\"y\":-16},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":14,\"y\":-12},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":14,\"y\":-2},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":10,\"y\":-8},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":9,\"y\":-11},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":5,\"y\":-15},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-2,\"y\":-16},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-3,\"y\":-11},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":9,\"y\":-11},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":10,\"y\":-8},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":6,\"y\":-8},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-2,\"y\":-1},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-2,\"y\":3},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":5,\"y\":6},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":12,\"y\":6},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":10,\"y\":8},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-10,\"y\":8},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3},{\"_position\":{\"x\":-18,\"y\":0},\"type\":0,\"bezierPivot1\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierPivot2\":{\"_position\":{\"x\":-2,\"y\":-6}},\"bezierDetail\":3}],\"pivot\":{\"_position\":{\"x\":0,\"y\":-8}}}],\"globalPivot\":{\"_position\":{\"x\":0,\"y\":0}},\"flipHorizontally\":false,\"flipVertically\":false,\"extrudeDepth\":1.0,\"extrudeClipDepth\":0.5,\"extrudeScale\":{\"x\":1.0,\"y\":1.0},\"revolve360\":8,\"revolveSteps\":4,\"revolveDistance\":1,\"revolveRadius\":1,\"revolveDirection\":true}");

	[SerializeField]
	private ExtrudeMode extrudeMode = ExtrudeMode.ExtrudeShape;

	[SerializeField]
	private int desiredBrushCount;

	[SerializeField]
	private bool isDirty = true;

	private Vector3 m_LastKnownExtents;

	private Vector3 m_LastKnownPosition;

	private List<Polygon> m_LastBuiltPolygons;

	public override string BeautifulBrushName => "2D Shape Editor Brush";

	public override int BrushCount
	{
		get
		{
			if (!project.convexBrushes)
			{
				return 1;
			}
			if (!isDirty)
			{
				return desiredBrushCount;
			}
			if (m_LastBuiltPolygons == null)
			{
				m_LastBuiltPolygons = BuildConvexPolygons();
			}
			return desiredBrushCount;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		m_LastKnownExtents = localBounds.extents;
		m_LastKnownPosition = base.transform.localPosition;
	}

	public override void UpdateVisibility()
	{
	}

	public override void Invalidate(bool polygonsChanged)
	{
		if (m_LastKnownExtents != localBounds.extents)
		{
			base.transform.localPosition = m_LastKnownPosition;
		}
		Bounds bounds = default(Bounds);
		if (extrudeMode == ExtrudeMode.CreatePolygon)
		{
			base.IsNoCSG = true;
		}
		if (extrudeMode == ExtrudeMode.RevolveShape && project.revolveSpiralSloped && project.globalPivot.position.y != 0)
		{
			base.IsNoCSG = true;
		}
		if (!project.convexBrushes)
		{
			base.IsNoCSG = true;
		}
		if (!isDirty)
		{
			for (int i = 0; i < ((!project.convexBrushes) ? 1 : desiredBrushCount); i++)
			{
				generatedBrushes[i].Mode = base.Mode;
				generatedBrushes[i].IsNoCSG = base.IsNoCSG;
				generatedBrushes[i].IsVisible = base.IsVisible;
				generatedBrushes[i].HasCollision = base.HasCollision;
				generatedBrushes[i].Invalidate(polygonsChanged: true);
				bounds.Encapsulate(generatedBrushes[i].GetBounds());
			}
			localBounds = bounds;
			m_LastKnownExtents = localBounds.extents;
			m_LastKnownPosition = base.transform.localPosition;
			return;
		}
		base.Invalidate(polygonsChanged);
		isDirty = false;
		if (m_LastBuiltPolygons == null)
		{
			m_LastBuiltPolygons = BuildConvexPolygons();
		}
		List<Polygon> list = null;
		if (!project.convexBrushes)
		{
			list = new List<Polygon>();
		}
		int num = desiredBrushCount;
		for (int j = 0; j < num; j++)
		{
			generatedBrushes[project.convexBrushes ? j : 0].Mode = base.Mode;
			generatedBrushes[project.convexBrushes ? j : 0].IsNoCSG = base.IsNoCSG;
			generatedBrushes[project.convexBrushes ? j : 0].IsVisible = base.IsVisible;
			generatedBrushes[project.convexBrushes ? j : 0].HasCollision = base.HasCollision;
			Polygon[] outputPolygons;
			Quaternion rotation;
			switch (extrudeMode)
			{
			case ExtrudeMode.CreatePolygon:
			{
				GenerateNormals(m_LastBuiltPolygons[j]);
				GenerateUvCoordinates(m_LastBuiltPolygons[j], helper: false);
				Polygon polygon3 = m_LastBuiltPolygons[j].DeepCopy();
				polygon3.Flip();
				if (project.convexBrushes)
				{
					generatedBrushes[j].SetPolygons(new Polygon[1] { polygon3 });
				}
				else
				{
					list.Add(polygon3);
				}
				break;
			}
			case ExtrudeMode.RevolveShape:
			{
				float num2 = (float)project.globalPivot.position.y * project.extrudeScale.y / 8f * (float)(j / m_LastBuiltPolygons.Count) / (float)project.revolve360 * (float)(project.revolve360 / project.revolveSteps);
				float num3 = (float)project.globalPivot.position.y * project.extrudeScale.y / 8f / (float)project.revolve360 * (float)(project.revolve360 / project.revolveSteps);
				int index = j % m_LastBuiltPolygons.Count;
				Polygon polygon5 = m_LastBuiltPolygons[index].DeepCopy();
				polygon5.Flip();
				GenerateUvCoordinates(polygon5, helper: false);
				Vertex[] vertices = polygon5.Vertices;
				foreach (Vertex vertex in vertices)
				{
					float num4 = 360f / (float)project.revolve360;
					vertex.Position = new Vector3(0f, 0f - num2, 0f) + RotatePointAroundPivot(vertex.Position, new Vector3((float)project.revolveDistance / 8f * project.extrudeScale.x + (float)project.revolveRadius * project.extrudeScale.x / 8f, 0f, 0f), new Vector3(0f, (float)(j / m_LastBuiltPolygons.Count) * num4, 0f));
				}
				GenerateNormals(polygon5);
				Polygon polygon6 = m_LastBuiltPolygons[index].DeepCopy();
				polygon6.Flip();
				Vertex[] vertices2 = polygon6.Vertices;
				foreach (Vertex vertex2 in vertices2)
				{
					float num6 = 360f / (float)project.revolve360;
					vertex2.Position = new Vector3(0f, 0f - num2 - ((!project.revolveSpiralSloped) ? 0f : num3), 0f) + RotatePointAroundPivot(vertex2.Position, new Vector3((float)project.revolveDistance / 8f * project.extrudeScale.x + (float)project.revolveRadius * project.extrudeScale.x / 8f, 0f, 0f), new Vector3(0f, (float)(j / m_LastBuiltPolygons.Count) * num6 + num6, 0f));
				}
				List<Polygon> list2 = new List<Polygon>();
				list2.Add(polygon5);
				List<Polygon> list3 = list2;
				List<Vertex> list4 = new List<Vertex>();
				Edge[] edges = polygon5.GetEdges();
				Edge[] edges2 = polygon6.GetEdges();
				for (int num7 = 0; num7 < edges.Length; num7++)
				{
					Edge edge = edges[num7];
					Edge edge2 = edges2[num7];
					Polygon polygon7 = new Polygon(new Vertex[4]
					{
						new Vertex(edge.Vertex1.Position, Vector3.zero, Vector2.zero),
						new Vertex(edge2.Vertex1.Position, Vector3.zero, Vector2.zero),
						new Vertex(edge2.Vertex2.Position, Vector3.zero, Vector2.zero),
						new Vertex(edge.Vertex2.Position, Vector3.zero, Vector2.zero)
					}, null, isTemporary: false, userExcludeFromFinal: false);
					list4.Add(edge2.Vertex1);
					GenerateNormals(polygon7);
					if (!(polygon7.Plane.normal == Vector3.zero))
					{
						GenerateUvCoordinates(polygon7, helper: false);
						list3.Add(polygon7);
					}
				}
				Polygon polygon8 = new Polygon(list4.ToArray(), null, isTemporary: false, userExcludeFromFinal: false);
				polygon8.Flip();
				GenerateNormals(polygon8);
				GenerateUvCoordinates(polygon8, helper: false);
				list3.Add(polygon8);
				if (project.convexBrushes)
				{
					generatedBrushes[j].SetPolygons(list3.ToArray());
				}
				else
				{
					list.AddRange(list3);
				}
				break;
			}
			case ExtrudeMode.ExtrudeShape:
			{
				GenerateNormals(m_LastBuiltPolygons[j]);
				SurfaceUtility.ExtrudePolygon(m_LastBuiltPolygons[j], project.extrudeDepth, out outputPolygons, out rotation);
				Polygon[] array3 = outputPolygons;
				foreach (Polygon polygon4 in array3)
				{
					GenerateUvCoordinates(polygon4, helper: false);
				}
				if (project.convexBrushes)
				{
					generatedBrushes[j].SetPolygons(outputPolygons);
				}
				else
				{
					list.AddRange(outputPolygons);
				}
				break;
			}
			case ExtrudeMode.ExtrudePoint:
			{
				GenerateNormals(m_LastBuiltPolygons[j]);
				ExtrudePolygonToPoint(m_LastBuiltPolygons[j], project.extrudeDepth, new Vector2((float)project.globalPivot.position.x * project.extrudeScale.x / 8f, (0f - (float)project.globalPivot.position.y * project.extrudeScale.y) / 8f), out outputPolygons, out rotation);
				Polygon[] array2 = outputPolygons;
				foreach (Polygon polygon2 in array2)
				{
					GenerateUvCoordinates(polygon2, helper: false);
				}
				if (project.convexBrushes)
				{
					generatedBrushes[j].SetPolygons(outputPolygons);
				}
				else
				{
					list.AddRange(outputPolygons);
				}
				break;
			}
			case ExtrudeMode.ExtrudeBevel:
			{
				GenerateNormals(m_LastBuiltPolygons[j]);
				ExtrudePolygonBevel(m_LastBuiltPolygons[j], project.extrudeDepth, project.extrudeClipDepth / project.extrudeDepth, new Vector2((float)project.globalPivot.position.x * project.extrudeScale.x / 8f, (0f - (float)project.globalPivot.position.y * project.extrudeScale.y) / 8f), out outputPolygons, out rotation);
				Polygon[] array = outputPolygons;
				foreach (Polygon polygon in array)
				{
					GenerateUvCoordinates(polygon, helper: false);
				}
				if (project.convexBrushes)
				{
					generatedBrushes[j].SetPolygons(outputPolygons);
				}
				else
				{
					list.AddRange(outputPolygons);
				}
				break;
			}
			}
		}
		if (project.convexBrushes)
		{
			for (int num8 = 0; num8 < num; num8++)
			{
				for (int num9 = 0; num9 < num; num9++)
				{
					if (num8 == num9)
					{
						continue;
					}
					Polygon[] polygons = generatedBrushes[num8].GetPolygons();
					foreach (Polygon polygon9 in polygons)
					{
						Polygon[] polygons2 = generatedBrushes[num9].GetPolygons();
						foreach (Polygon polygon10 in polygons2)
						{
							bool flag = true;
							Vertex[] vertices3 = polygon9.Vertices;
							foreach (Vertex va2 in vertices3)
							{
								if (!polygon10.Vertices.Any((Vertex vb) => vb.Position == va2.Position))
								{
									flag = false;
									break;
								}
							}
							if (flag)
							{
								polygon9.UserExcludeFromFinal = true;
								polygon10.UserExcludeFromFinal = true;
							}
						}
					}
				}
				generatedBrushes[num8].Invalidate(polygonsChanged: true);
				bounds.Encapsulate(generatedBrushes[num8].GetBounds());
			}
		}
		else
		{
			List<Polygon> list5 = list.ToList();
			foreach (Polygon item in list5)
			{
				foreach (Polygon item2 in list5)
				{
					if (item == item2)
					{
						continue;
					}
					bool flag2 = true;
					Vertex[] vertices4 = item.Vertices;
					foreach (Vertex va in vertices4)
					{
						if (!item2.Vertices.Any((Vertex vb) => vb.Position == va.Position))
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						list.Remove(item);
						list.Remove(item2);
					}
				}
			}
			generatedBrushes[0].SetPolygons(list.ToArray());
			bounds.Encapsulate(generatedBrushes[0].GetBounds());
		}
		localBounds = bounds;
		m_LastKnownExtents = localBounds.extents;
		m_LastKnownPosition = base.transform.localPosition;
		UpdateGeneratedHierarchyName();
	}

	private Segment GetNextSegment(Shape parent, Segment segment)
	{
		int num = parent.segments.IndexOf(segment);
		if (num + 1 > parent.segments.Count - 1)
		{
			return parent.segments[0];
		}
		return parent.segments[num + 1];
	}

	private List<Polygon> BuildConvexPolygons()
	{
		List<Polygon> list = new List<Polygon>();
		foreach (Shape shape in project.shapes)
		{
			List<Vector2> list2 = new List<Vector2>();
			foreach (Segment segment in shape.segments)
			{
				if (segment.type == SegmentType.Linear)
				{
					list2.Add(new Vector2((float)segment.position.x * project.extrudeScale.x, (float)segment.position.y * -1f * project.extrudeScale.y) / 8f);
					continue;
				}
				foreach (Edge bezierEdge in GetBezierEdges(segment, GetNextSegment(shape, segment)))
				{
					list2.Add(new Vector2(bezierEdge.Vertex1.Position.x * project.extrudeScale.x, bezierEdge.Vertex1.Position.y * -1f * project.extrudeScale.y) / 8f);
				}
			}
			Vector2[] vertices = list2.ToArray();
			if (project.flipHorizontally && !project.flipVertically)
			{
				vertices = ReverseWindingOrder(vertices);
			}
			if (!project.flipHorizontally && project.flipVertically)
			{
				vertices = ReverseWindingOrder(vertices);
			}
			vertices = ReverseWindingOrder(vertices);
			List<Vector2[]> list3 = BayazitDecomposer.ConvexPartition(vertices);
			foreach (Vector2[] item in list3)
			{
				List<Vertex> list4 = new List<Vertex>();
				Vector2[] array = item;
				foreach (Vector2 vector in array)
				{
					list4.Add(new Vertex(vector, Vector3.zero, Vector2.zero));
				}
				list.Add(new Polygon(list4.ToArray(), null, isTemporary: false, userExcludeFromFinal: false));
			}
			switch (extrudeMode)
			{
			case ExtrudeMode.CreatePolygon:
				desiredBrushCount = list.Count;
				break;
			case ExtrudeMode.RevolveShape:
				desiredBrushCount = list.Count * project.revolveSteps;
				break;
			case ExtrudeMode.ExtrudeShape:
				desiredBrushCount = list.Count;
				break;
			case ExtrudeMode.ExtrudePoint:
				desiredBrushCount = list.Count;
				break;
			case ExtrudeMode.ExtrudeBevel:
				desiredBrushCount = list.Count;
				break;
			}
		}
		return list;
	}

	private void GenerateUvCoordinates(Polygon polygon, bool helper)
	{
		if (helper)
		{
			Vertex[] vertices = polygon.Vertices;
			foreach (Vertex vertex in vertices)
			{
				vertex.UV = GeometryHelper.GetUVForPosition(polygon, vertex.Position);
			}
			return;
		}
		Vector3 normal = polygon.Plane.normal;
		Quaternion quaternion = Quaternion.Inverse(Quaternion.LookRotation(-normal));
		for (int j = 0; j < polygon.Vertices.Length; j++)
		{
			Vector3 position = polygon.Vertices[j].Position;
			Vector2 uV = quaternion * position * 0.5f;
			polygon.Vertices[j].UV = uV;
		}
	}

	private void GenerateNormals(Polygon polygon)
	{
		Plane plane = new Plane(polygon.Vertices[0].Position, polygon.Vertices[1].Position, polygon.Vertices[2].Position);
		Vertex[] vertices = polygon.Vertices;
		foreach (Vertex vertex in vertices)
		{
			vertex.Normal = plane.normal;
		}
	}

	private static List<Edge> GetBezierEdges(Segment segment, Segment next)
	{
		List<Edge> list = new List<Edge>();
		Vector3 vector = Bezier.GetPoint(new Vector3(segment.position.x, segment.position.y), new Vector3(segment.bezierPivot1.position.x, segment.bezierPivot1.position.y), new Vector3(segment.bezierPivot2.position.x, segment.bezierPivot2.position.y), new Vector3(next.position.x, next.position.y), 0f);
		for (int i = 1; i <= segment.bezierDetail + 1; i++)
		{
			Vector3 point = Bezier.GetPoint(new Vector3(segment.position.x, segment.position.y), new Vector3(segment.bezierPivot1.position.x, segment.bezierPivot1.position.y), new Vector3(segment.bezierPivot2.position.x, segment.bezierPivot2.position.y), new Vector3(next.position.x, next.position.y), (float)i / (float)(segment.bezierDetail + 1));
			list.Add(new Edge(new Vertex(new Vector3(vector.x, vector.y), Vector3.zero, Vector2.zero), new Vertex(new Vector3(point.x, point.y), Vector3.zero, Vector2.zero)));
			vector = point;
		}
		return list;
	}

	private static Vector2[] ReverseWindingOrder(Vector2[] vertices)
	{
		Vector2[] array = new Vector2[vertices.Length];
		ref Vector2 reference = ref array[0];
		reference = vertices[0];
		for (int i = 1; i < array.Length; i++)
		{
			ref Vector2 reference2 = ref array[i];
			reference2 = vertices[vertices.Length - i];
		}
		return array;
	}

	private static void ExtrudePolygonToPoint(Polygon sourcePolygon, float extrusionDistance, Vector2 offset, out Polygon[] outputPolygons, out Quaternion rotation)
	{
		bool flag = false;
		if (extrusionDistance < 0f)
		{
			sourcePolygon.Flip();
			extrusionDistance = 0f - extrusionDistance;
			flag = true;
		}
		Polygon polygon = sourcePolygon.DeepCopy();
		polygon.UniqueIndex = -1;
		rotation = Quaternion.LookRotation(polygon.Plane.normal);
		Quaternion quaternion = Quaternion.Inverse(rotation);
		Vertex[] vertices = polygon.Vertices;
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].Position = quaternion * vertices[i].Position;
			vertices[i].Normal = quaternion * vertices[i].Normal;
		}
		polygon.Vertices = vertices;
		Vector3 normal = polygon.Plane.normal;
		polygon.Flip();
		Polygon[] array = new Polygon[sourcePolygon.Vertices.Length];
		for (int j = 0; j < polygon.Vertices.Length; j++)
		{
			Vertex vertex = polygon.Vertices[j].DeepCopy();
			Vertex vertex2 = polygon.Vertices[(j + 1) % polygon.Vertices.Length].DeepCopy();
			float num = Vector3.Distance(vertex.Position, vertex2.Position);
			float num2 = Vector2.Distance(vertex.UV, vertex2.UV);
			float num3 = num / num2;
			vertex.UV = Vector2.zero;
			if (flag)
			{
				vertex2.UV = new Vector2((0f - num) / num3, 0f);
			}
			else
			{
				vertex2.UV = new Vector2(num / num3, 0f);
			}
			Vector2 vector = vertex2.UV - vertex.UV;
			Vector2 vector2 = vector.Rotate(90f) * (extrusionDistance / num);
			Vertex vertex3 = vertex.DeepCopy();
			vertex3.Position += normal * extrusionDistance;
			vertex3.UV += vector2;
			Vertex vertex4 = vertex2.DeepCopy();
			vertex4.Position += normal * extrusionDistance;
			vertex4.UV += vector2;
			vertex3.Position.x = (normal * extrusionDistance).x * 0.5f + offset.x;
			vertex3.Position.y = (normal * extrusionDistance).y * 0.5f + offset.y;
			Vertex[] vertices2 = new Vertex[3] { vertex, vertex2, vertex3 };
			array[j] = new Polygon(vertices2, sourcePolygon.Material, isTemporary: false, userExcludeFromFinal: false);
			array[j].Flip();
			array[j].ResetVertexNormals();
		}
		List<Polygon> list = new List<Polygon>();
		list.Add(polygon);
		list.AddRange(array);
		outputPolygons = list.ToArray();
	}

	private static void ExtrudePolygonBevel(Polygon sourcePolygon, float extrusionDistance, float clip, Vector2 offset, out Polygon[] outputPolygons, out Quaternion rotation)
	{
		float num = extrusionDistance;
		extrusionDistance *= clip;
		bool flag = false;
		if (extrusionDistance < 0f)
		{
			sourcePolygon.Flip();
			extrusionDistance = 0f - extrusionDistance;
			flag = true;
		}
		Polygon polygon = sourcePolygon.DeepCopy();
		polygon.UniqueIndex = -1;
		rotation = Quaternion.LookRotation(polygon.Plane.normal);
		Quaternion quaternion = Quaternion.Inverse(rotation);
		Vertex[] vertices = polygon.Vertices;
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].Position = quaternion * vertices[i].Position;
			vertices[i].Normal = quaternion * vertices[i].Normal;
		}
		polygon.Vertices = vertices;
		Vector3 normal = polygon.Plane.normal;
		Polygon polygon2 = polygon.DeepCopy();
		polygon2.UniqueIndex = -1;
		polygon.Flip();
		vertices = polygon2.Vertices;
		for (int j = 0; j < vertices.Length; j++)
		{
			vertices[j].Position += normal * extrusionDistance;
			vertices[j].Position.x = Mathf.Lerp(vertices[j].Position.x, (normal * num).x * 0.5f + offset.x, clip);
			vertices[j].Position.y = Mathf.Lerp(vertices[j].Position.y, (normal * num).y * 0.5f + offset.y, clip);
		}
		polygon2.Vertices = vertices;
		Polygon[] array = new Polygon[sourcePolygon.Vertices.Length];
		for (int k = 0; k < polygon.Vertices.Length; k++)
		{
			Vertex vertex = polygon.Vertices[k].DeepCopy();
			Vertex vertex2 = polygon.Vertices[(k + 1) % polygon.Vertices.Length].DeepCopy();
			float num2 = Vector3.Distance(vertex.Position, vertex2.Position);
			float num3 = Vector2.Distance(vertex.UV, vertex2.UV);
			float num4 = num2 / num3;
			vertex.UV = Vector2.zero;
			if (flag)
			{
				vertex2.UV = new Vector2((0f - num2) / num4, 0f);
			}
			else
			{
				vertex2.UV = new Vector2(num2 / num4, 0f);
			}
			Vector2 vector = vertex2.UV - vertex.UV;
			Vector2 vector2 = vector.Rotate(90f) * (extrusionDistance / num2);
			Vertex vertex3 = vertex.DeepCopy();
			vertex3.Position += normal * extrusionDistance;
			vertex3.UV += vector2;
			Vertex vertex4 = vertex2.DeepCopy();
			vertex4.Position += normal * extrusionDistance;
			vertex4.UV += vector2;
			vertex3.Position.x = Mathf.Lerp(vertex3.Position.x, (normal * num).x * 0.5f + offset.x, clip);
			vertex3.Position.y = Mathf.Lerp(vertex3.Position.y, (normal * num).y * 0.5f + offset.y, clip);
			vertex4.Position.x = Mathf.Lerp(vertex4.Position.x, (normal * num).x * 0.5f + offset.x, clip);
			vertex4.Position.y = Mathf.Lerp(vertex4.Position.y, (normal * num).y * 0.5f + offset.y, clip);
			Vertex[] vertices2 = new Vertex[4] { vertex, vertex2, vertex4, vertex3 };
			array[k] = new Polygon(vertices2, sourcePolygon.Material, isTemporary: false, userExcludeFromFinal: false);
			array[k].Flip();
			array[k].ResetVertexNormals();
		}
		List<Polygon> list = new List<Polygon>();
		list.Add(polygon);
		list.Add(polygon2);
		list.AddRange(array);
		outputPolygons = list.ToArray();
	}

	private Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
	{
		return Quaternion.Euler(angles) * (point - pivot) + pivot;
	}

	private void FlipProjectHorizontally()
	{
		project.flipHorizontally = !project.flipHorizontally;
		foreach (Shape shape in project.shapes)
		{
			foreach (Segment segment in shape.segments)
			{
				segment.position = new Vector2Int(-segment.position.x + project.globalPivot.position.x * 2, segment.position.y);
				segment.bezierPivot1.position = new Vector2Int(-segment.bezierPivot1.position.x + project.globalPivot.position.x * 2, segment.bezierPivot1.position.y);
				segment.bezierPivot2.position = new Vector2Int(-segment.bezierPivot2.position.x + project.globalPivot.position.x * 2, segment.bezierPivot2.position.y);
			}
			shape.CalculatePivotPosition();
		}
	}

	public Project GetEmbeddedProject()
	{
		return project.Clone();
	}

	public void CreatePolygon(Project project)
	{
		this.project = project.Clone();
		extrudeMode = ExtrudeMode.CreatePolygon;
		m_LastBuiltPolygons = BuildConvexPolygons();
		isDirty = true;
		Invalidate(polygonsChanged: true);
	}

	public void RevolveShape(Project project)
	{
		this.project = project.Clone();
		if (!this.project.revolveDirection)
		{
			FlipProjectHorizontally();
		}
		extrudeMode = ExtrudeMode.RevolveShape;
		m_LastBuiltPolygons = BuildConvexPolygons();
		isDirty = true;
		Invalidate(polygonsChanged: true);
		if (!this.project.revolveDirection)
		{
			FlipProjectHorizontally();
		}
	}

	public void ExtrudeShape(Project project)
	{
		this.project = project.Clone();
		extrudeMode = ExtrudeMode.ExtrudeShape;
		m_LastBuiltPolygons = BuildConvexPolygons();
		isDirty = true;
		Invalidate(polygonsChanged: true);
	}

	public void ExtrudePoint(Project project)
	{
		this.project = project.Clone();
		extrudeMode = ExtrudeMode.ExtrudePoint;
		m_LastBuiltPolygons = BuildConvexPolygons();
		isDirty = true;
		Invalidate(polygonsChanged: true);
	}

	public void ExtrudeBevel(Project project)
	{
		if (project.extrudeDepth.EqualsWithEpsilon(project.extrudeClipDepth))
		{
			ExtrudePoint(project);
			return;
		}
		this.project = project.Clone();
		extrudeMode = ExtrudeMode.ExtrudeBevel;
		m_LastBuiltPolygons = BuildConvexPolygons();
		isDirty = true;
		Invalidate(polygonsChanged: true);
	}
}
