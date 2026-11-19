using UnityEngine;
using UnityEngine.Serialization;

namespace Sabresaurus.SabreCSG
{
	[ExecuteInEditMode]
	public abstract class BrushBase : MonoBehaviour
	{
		[SerializeField]
		protected CSGMode mode;

		[SerializeField]
		[FormerlySerializedAs("isDetailBrush")]
		protected bool isNoCSG;

		[SerializeField]
		protected bool hasCollision = true;

		[SerializeField]
		protected bool isVisible = true;

		[SerializeField]
		protected Volume volume;

		protected bool destroyed;

		protected string previousHierarchyName = string.Empty;

		public CSGMode Mode
		{
			get
			{
				return mode;
			}
			set
			{
				if (mode != value && (value != CSGMode.Volume || (!(GetType() != typeof(PrimitiveBrush)) && !(((PrimitiveBrush)this).BrushController != null))))
				{
					mode = value;
					Invalidate(true);
				}
			}
		}

		public bool Destroyed
		{
			get
			{
				return destroyed;
			}
		}

		public bool IsNoCSG
		{
			get
			{
				return isNoCSG;
			}
			set
			{
				isNoCSG = value;
			}
		}

		public bool IsVisible
		{
			get
			{
				return isVisible;
			}
			set
			{
				isVisible = value;
			}
		}

		public bool HasCollision
		{
			get
			{
				return hasCollision;
			}
			set
			{
				hasCollision = value;
			}
		}

		public Volume Volume
		{
			get
			{
				return volume;
			}
			set
			{
				volume = value;
			}
		}

		public virtual string BeautifulBrushName
		{
			get
			{
				return "AppliedBrush";
			}
		}

		public string GeneratedHierarchyName
		{
			get
			{
				return BeautifulBrushName + " (" + GetBounds().ToGeneratedHierarchyString() + ")";
			}
		}

		public virtual bool SupportsCsgOperations
		{
			get
			{
				return true;
			}
		}

		public void UpdateGeneratedHierarchyName()
		{
			if (previousHierarchyName == string.Empty && GeneratedHierarchyName == base.transform.name)
			{
				previousHierarchyName = base.transform.name;
			}
			if (base.transform.name == previousHierarchyName || base.transform.name == string.Empty)
			{
				base.transform.name = (previousHierarchyName = GeneratedHierarchyName);
			}
		}

		internal void RebuildVolume()
		{
			if (GetType() != typeof(PrimitiveBrush))
			{
				return;
			}
			PrimitiveBrush primitiveBrush = (PrimitiveBrush)this;
			if (Mode != CSGMode.Volume && Volume != null)
			{
				Volume = null;
				Transform transform = base.transform.Find("SabreCSG: Volume Component (67173f4f-868c-4c70-ae40-335550c8354f)");
				if (transform != null)
				{
					Object.DestroyImmediate(transform.gameObject);
				}
			}
			if (Mode == CSGMode.Volume && Volume != null)
			{
				Transform transform2 = base.transform.Find("SabreCSG: Volume Component (67173f4f-868c-4c70-ae40-335550c8354f)");
				if (transform2 != null)
				{
					Object.DestroyImmediate(transform2.gameObject);
				}
				Mesh mesh = new Mesh();
				BrushFactory.GenerateMeshFromPolygonsFast(primitiveBrush.GetPolygons(), ref mesh, 0f);
				GameObject gameObject = CreateVolumeMeshCollider(mesh);
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
				Volume.OnCreateVolume(gameObject);
			}
		}

		internal GameObject CreateVolumeMeshCollider(Mesh mesh)
		{
			GameObject gameObject = new GameObject("SabreCSG: Volume Component (67173f4f-868c-4c70-ae40-335550c8354f)", typeof(MeshCollider));
			gameObject.transform.SetParent(base.transform, false);
			MeshCollider component = gameObject.GetComponent<MeshCollider>();
			component.sharedMesh = mesh;
			component.convex = true;
			component.isTrigger = true;
			return gameObject;
		}

		public virtual void Invalidate(bool polygonsChanged)
		{
			if (polygonsChanged)
			{
				UpdateGeneratedHierarchyName();
				RebuildVolume();
			}
		}

		public abstract void UpdateVisibility();

		public abstract Bounds GetBounds();

		public abstract void SetBounds(Bounds newBounds);

		public abstract Bounds GetBoundsTransformed();

		public abstract Bounds GetBoundsLocalTo(Transform otherTransform);

		public abstract void OnUndoRedoPerformed();

		protected virtual void OnDestroy()
		{
			destroyed = true;
		}

		protected virtual void Awake()
		{
			if (previousHierarchyName == string.Empty && GeneratedHierarchyName == base.transform.name)
			{
				previousHierarchyName = base.transform.name;
			}
		}

		protected virtual void Update()
		{
		}
	}
}
