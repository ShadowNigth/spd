using System;

namespace Sabresaurus.SabreCSG;

[Serializable]
public class BuildMetrics
{
	public int TotalMeshes;

	public int TotalVertices;

	public int TotalTriangles;

	public float BuildTime;

	public string BuildMetaData = string.Empty;
}
