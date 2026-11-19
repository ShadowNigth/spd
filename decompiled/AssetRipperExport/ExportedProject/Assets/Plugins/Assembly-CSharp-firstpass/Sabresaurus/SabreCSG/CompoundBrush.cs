using System;
using System.Collections.Generic;
using System.Reflection;
using Sabresaurus.SabreCSG.ShapeEditor;
using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public abstract class CompoundBrush : BrushBase
	{
		[SerializeField]
		protected Bounds localBounds = new Bounds(Vector3.zero, new Vector3(2f, 2f, 2f));

		protected List<PrimitiveBrush> generatedBrushes = new List<PrimitiveBrush>();

		private CSGModelBase parentCsgModel;

		public abstract int BrushCount { get; }

		public override string BeautifulBrushName
		{
			get
			{
				return GetType().Name;
			}
		}

		public CSGModelBase GetCSGModel()
		{
			if (parentCsgModel == null)
			{
				CSGModelBase[] componentsInParent = base.transform.GetComponentsInParent<CSGModelBase>(true);
				if (componentsInParent.Length > 0)
				{
					parentCsgModel = componentsInParent[0];
				}
			}
			return parentCsgModel;
		}

		protected virtual void Start()
		{
			generatedBrushes = new List<PrimitiveBrush>(GetComponentsInChildren<PrimitiveBrush>());
			for (int i = 0; i < generatedBrushes.Count; i++)
			{
				generatedBrushes[i].SetBrushController(this);
			}
		}

		public override void Invalidate(bool polygonsChanged)
		{
			base.Invalidate(polygonsChanged);
			generatedBrushes.RemoveAll((PrimitiveBrush item) => item == null);
			if (generatedBrushes.Count > BrushCount)
			{
				for (int num = BrushCount; num < generatedBrushes.Count; num++)
				{
					if (generatedBrushes[num] != null)
					{
						UnityEngine.Object.DestroyImmediate(generatedBrushes[num].gameObject);
					}
				}
				generatedBrushes.RemoveRange(BrushCount, generatedBrushes.Count - BrushCount);
			}
			else if (generatedBrushes.Count < BrushCount)
			{
				while (generatedBrushes.Count < BrushCount)
				{
					PrimitiveBrush primitiveBrush = CreateBrush();
					primitiveBrush.transform.SetParent(base.transform, false);
					primitiveBrush.SetBrushController(this);
					generatedBrushes.Add(primitiveBrush);
				}
			}
		}

		public override Bounds GetBounds()
		{
			return localBounds;
		}

		public override void SetBounds(Bounds newBounds)
		{
			localBounds.center = Vector3.zero;
			localBounds.extents = newBounds.extents;
			base.transform.Translate(newBounds.center);
		}

		public override Bounds GetBoundsTransformed()
		{
			Vector3[] array = new Vector3[8];
			for (int i = 0; i < 8; i++)
			{
				Vector3 center = localBounds.center;
				Vector3 extents = localBounds.extents;
				if (i % 2 == 0)
				{
					extents.x = 0f - extents.x;
				}
				if (i % 4 < 2)
				{
					extents.y = 0f - extents.y;
				}
				if (i % 8 < 4)
				{
					extents.z = 0f - extents.z;
				}
				center += extents;
				center = base.transform.TransformPoint(center);
				array[i] = center;
			}
			Bounds result = new Bounds(array[0], Vector3.zero);
			for (int j = 1; j < 8; j++)
			{
				result.Encapsulate(array[j]);
			}
			return result;
		}

		public override Bounds GetBoundsLocalTo(Transform otherTransform)
		{
			Vector3[] array = new Vector3[8];
			for (int i = 0; i < 8; i++)
			{
				Vector3 center = localBounds.center;
				Vector3 extents = localBounds.extents;
				if (i % 2 == 0)
				{
					extents.x = 0f - extents.x;
				}
				if (i % 4 < 2)
				{
					extents.y = 0f - extents.y;
				}
				if (i % 8 < 4)
				{
					extents.z = 0f - extents.z;
				}
				center += extents;
				center = otherTransform.InverseTransformPoint(base.transform.TransformPoint(center));
				array[i] = center;
			}
			Bounds result = new Bounds(array[0], Vector3.zero);
			for (int j = 1; j < 8; j++)
			{
				result.Encapsulate(array[j]);
			}
			return result;
		}

		public Polygon[] GetPolygons()
		{
			List<Polygon> list = new List<Polygon>();
			Brush[] componentsInChildren = GetComponentsInChildren<Brush>();
			foreach (Brush brush in componentsInChildren)
			{
				list.AddRange(GenerateTransformedPolygons(brush.transform, brush.GetPolygons()));
			}
			return list.ToArray();
		}

		private Polygon[] GenerateTransformedPolygons(Transform t, Polygon[] polygons)
		{
			Polygon[] array = polygons.DeepCopy();
			Vector3 localPosition = t.localPosition;
			Quaternion localRotation = t.localRotation;
			Vector3 lossyScale = t.lossyScale;
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Vertices.Length; j++)
				{
					array[i].Vertices[j].Position = localRotation * array[i].Vertices[j].Position.Multiply(lossyScale) + localPosition;
					array[i].Vertices[j].Normal = localRotation * array[i].Vertices[j].Normal;
				}
				array[i].CalculatePlane();
			}
			return array;
		}

		public virtual PrimitiveBrush CreateBrush()
		{
			return GetCSGModel().CreateBrush(PrimitiveBrushType.Cube, Vector3.zero, Vector3.one).GetComponent<PrimitiveBrush>();
		}

		public override void OnUndoRedoPerformed()
		{
			generatedBrushes = new List<PrimitiveBrush>(GetComponentsInChildren<PrimitiveBrush>());
			for (int i = 0; i < generatedBrushes.Count; i++)
			{
				generatedBrushes[i].SetBrushController(this);
			}
			Invalidate(true);
		}

		public static List<Type> FindAllInAssembly()
		{
			List<Type> list = new List<Type>();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			Assembly[] array = assemblies;
			foreach (Assembly assembly in array)
			{
				if (!assembly.FullName.StartsWith("Assembly-CSharp"))
				{
					continue;
				}
				Type[] types = assembly.GetTypes();
				for (int j = 0; j < types.Length; j++)
				{
					if (!types[j].IsAbstract && types[j].IsSubclassOf(typeof(CompoundBrush)) && !(types[j] == typeof(StairBrush)) && !(types[j] == typeof(CurvedStairBrush)) && !(types[j] == typeof(ShapeEditorBrush)))
					{
						list.Add(types[j]);
					}
				}
			}
			return list;
		}
	}
}
