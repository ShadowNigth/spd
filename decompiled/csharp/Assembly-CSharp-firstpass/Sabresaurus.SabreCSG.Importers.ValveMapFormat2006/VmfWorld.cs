using System.Collections.Generic;

namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006;

public class VmfWorld
{
	public int VersionInfoEditorVersion = -1;

	public int VersionInfoEditorBuild = -1;

	public int VersionInfoMapVersion = -1;

	public int VersionInfoFormatVersion = -1;

	public int VersionInfoPrefab = -1;

	public int ViewSettingsSnapToGrid = -1;

	public int ViewSettingsShowGrid = -1;

	public int ViewSettingsShowLogicalGrid = -1;

	public int ViewSettingsGridSpacing = -1;

	public int ViewSettingsShow3DGrid = -1;

	public int Id = -1;

	public int MapVersion = -1;

	public string ClassName = string.Empty;

	public string DetailMaterial = string.Empty;

	public string DetailVBsp = string.Empty;

	public int MaxPropScreenWidth = -1;

	public string SkyName = string.Empty;

	public List<VmfSolid> Solids = new List<VmfSolid>();

	public List<VmfEntity> Entities = new List<VmfEntity>();
}
