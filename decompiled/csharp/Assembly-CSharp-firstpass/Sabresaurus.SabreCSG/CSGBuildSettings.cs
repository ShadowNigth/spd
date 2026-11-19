using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sabresaurus.SabreCSG;

[Serializable]
public class CSGBuildSettings
{
	public bool GenerateCollisionMeshes = true;

	public bool GenerateTangents = true;

	public bool OptimizeGeometry;

	public bool SaveMeshesAsAssets;

	[Tooltip("Note that when enabled this will have a non-trivial increase in build times")]
	public bool GenerateLightmapUVs;

	[Range(0f, 1f)]
	public float UnwrapAngleError = 0.08f;

	[Range(0f, 1f)]
	public float UnwrapAreaError = 0.15f;

	[Range(0f, 180f)]
	public float UnwrapHardAngle = 88f;

	public float UnwrapPackMargin = 0.00390625f;

	public ShadowCastingMode ShadowCastingMode = ShadowCastingMode.TwoSided;

	public ReflectionProbeUsage ReflectionProbeUsage = ReflectionProbeUsage.BlendProbes;

	public PhysicMaterial DefaultPhysicsMaterial;

	public Material DefaultVisualMaterial;

	[HideInInspector]
	public bool IsBuilt;

	public CSGBuildSettings ShallowCopy()
	{
		return (CSGBuildSettings)MemberwiseClone();
	}

	public static bool AreDifferent(CSGBuildSettings settings1, CSGBuildSettings settings2)
	{
		if (settings1.GenerateCollisionMeshes != settings2.GenerateCollisionMeshes)
		{
			return true;
		}
		if (settings1.GenerateTangents != settings2.GenerateTangents)
		{
			return true;
		}
		if (settings1.OptimizeGeometry != settings2.OptimizeGeometry)
		{
			return true;
		}
		if (settings1.GenerateLightmapUVs != settings2.GenerateLightmapUVs)
		{
			return true;
		}
		if (settings1.GenerateLightmapUVs && settings1.GenerateLightmapUVs)
		{
			if (settings1.UnwrapAngleError != settings2.UnwrapAngleError)
			{
				return true;
			}
			if (settings1.UnwrapAreaError != settings2.UnwrapAreaError)
			{
				return true;
			}
			if (settings1.UnwrapHardAngle != settings2.UnwrapHardAngle)
			{
				return true;
			}
			if (settings1.UnwrapPackMargin != settings2.UnwrapPackMargin)
			{
				return true;
			}
		}
		if (settings1.DefaultPhysicsMaterial != settings2.DefaultPhysicsMaterial)
		{
			return true;
		}
		if (settings1.DefaultVisualMaterial != settings2.DefaultVisualMaterial)
		{
			return true;
		}
		if (settings1.ShadowCastingMode != settings2.ShadowCastingMode)
		{
			return true;
		}
		if (settings1.ReflectionProbeUsage != settings2.ReflectionProbeUsage)
		{
			return true;
		}
		return false;
	}
}
