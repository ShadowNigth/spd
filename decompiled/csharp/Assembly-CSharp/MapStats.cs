using System;

[Serializable]
public class MapStats
{
	public string mapName;

	public int Version = 1;

	public bool IsDev;

	public bool local;

	private bool? m_featured;

	public int botPlays;

	public int plays;

	public int date;

	public bool featured
	{
		get
		{
			bool? flag = m_featured;
			int result;
			if (flag.HasValue)
			{
				result = (flag.Value ? 1 : 0);
			}
			else
			{
				bool? flag2 = (m_featured = FOGIOGKLNIP.LMMFHEODOPM.MGKDMDLBCOE.Contains(mapName));
				result = ((flag2.Value && (FOGIOGKLNIP.DGMBIMMABNO || FOGIOGKLNIP.OMMLFOEPEEK)) ? 1 : 0);
			}
			return (byte)result != 0;
		}
	}
}
