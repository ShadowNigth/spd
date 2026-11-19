using UnityEngine;

namespace Sabresaurus.SabreCSG
{
	public interface IPostBuildListener
	{
		void OnBuildFinished(Transform meshGroupTransform);
	}
}
