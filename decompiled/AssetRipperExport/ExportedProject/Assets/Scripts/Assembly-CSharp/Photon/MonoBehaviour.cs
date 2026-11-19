using UnityEngine;

namespace Photon
{
	public class MonoBehaviour : UnityEngine.MonoBehaviour
	{
		protected PhotonView photonView
		{
			get
			{
				return PhotonView.Get(this);
			}
		}
	}
}
