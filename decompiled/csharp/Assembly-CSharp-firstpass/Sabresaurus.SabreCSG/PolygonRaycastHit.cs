using UnityEngine;

namespace Sabresaurus.SabreCSG;

public struct PolygonRaycastHit
{
	public Vector3 Point;

	public Vector3 Normal;

	public float Distance;

	public GameObject GameObject;

	public Polygon Polygon;
}
