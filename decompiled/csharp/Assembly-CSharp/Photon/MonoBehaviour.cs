using UnityEngine;

namespace Photon;

public class MonoBehaviour : UnityEngine.MonoBehaviour
{
	protected PhotonView photonView => PhotonView.Get(this);
}
