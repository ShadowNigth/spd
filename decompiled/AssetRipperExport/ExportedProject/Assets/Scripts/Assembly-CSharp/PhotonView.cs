using System.Collections;
using Photon;
using UnityEngine;

[AddComponentMenu("Miscellaneous/Photon View")]
public class PhotonView : Photon.MonoBehaviour
{
	[SerializeField]
	private int sceneViewID;

	[SerializeField]
	private PhotonViewID ID = new PhotonViewID(0, null);

	public Component observed;

	public ViewSynchronization synchronization;

	public int group;

	public int prefix = -1;

	public object[] instantiationData;

	public Hashtable lastOnSerializeDataSent;

	public OnSerializeTransform onSerializeTransformOption = OnSerializeTransform.PositionAndRotation;

	public OnSerializeRigidBody onSerializeRigidBodyOption = OnSerializeRigidBody.All;

	private bool registeredPhotonView;

	public PhotonViewID viewID
	{
		get
		{
			if (ID.ID < 1 && sceneViewID > 0)
			{
				ID = new PhotonViewID(sceneViewID, null);
			}
			return ID;
		}
		set
		{
			if (registeredPhotonView && PhotonNetwork.networkingPeer != null)
			{
				PhotonNetwork.networkingPeer.RemovePhotonView(this);
			}
			ID = value;
			if (PhotonNetwork.networkingPeer != null)
			{
				PhotonNetwork.networkingPeer.RegisterPhotonView(this);
				registeredPhotonView = true;
			}
		}
	}

	public bool isSceneView
	{
		get
		{
			return sceneViewID > 0;
		}
	}

	public PhotonPlayer owner
	{
		get
		{
			return viewID.owner;
		}
	}

	public bool isMine
	{
		get
		{
			return owner == PhotonNetwork.player || (isSceneView && PhotonNetwork.isMasterClient);
		}
	}

	public override string ToString()
	{
		return string.Format("View {0} on {1} {2}", ID.ID, base.gameObject.name, (!isSceneView) ? string.Empty : "(scene)");
	}

	public void SetSceneID(int newID)
	{
		sceneViewID = newID;
	}

	public int GetSceneID()
	{
		return sceneViewID;
	}

	private void Awake()
	{
		if (isSceneView)
		{
			if (sceneViewID < 1)
			{
				Debug.LogError("SceneView " + sceneViewID);
			}
			ID = new PhotonViewID(sceneViewID, null);
			registeredPhotonView = true;
			PhotonNetwork.networkingPeer.RegisterPhotonView(this);
		}
		else
		{
			ID = new PhotonViewID(0, null);
		}
	}

	private void OnDestroy()
	{
		PhotonNetwork.networkingPeer.RemovePhotonView(this);
	}

	public void RPC(string methodName, PhotonTargets target, params object[] parameters)
	{
		LAOFKFBJDGJ.JAPPMNIGMOG++;
		PhotonNetwork.RPC(this, methodName, target, parameters);
	}

	public void RPC(string methodName, PhotonPlayer targetPlayer, params object[] parameters)
	{
		LAOFKFBJDGJ.JAPPMNIGMOG++;
		PhotonNetwork.RPC(this, methodName, targetPlayer, parameters);
	}

	public static PhotonView Get(Component component)
	{
		return component.GetComponent<PhotonView>();
	}

	public static PhotonView Get(GameObject gameObj)
	{
		return gameObj.GetComponent<PhotonView>();
	}

	public static PhotonView Find(int viewID)
	{
		return PhotonNetwork.networkingPeer.GetPhotonView(viewID);
	}
}
