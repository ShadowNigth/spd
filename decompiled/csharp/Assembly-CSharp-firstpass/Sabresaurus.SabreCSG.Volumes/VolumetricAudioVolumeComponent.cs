using System.Linq;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Volumes;

public class VolumetricAudioVolumeComponent : MonoBehaviour
{
	public float spatialDistance2D = 2f;

	public float spatialDistance3D = 4f;

	[HideInInspector]
	public int assetStoreVersion = 1;

	public string uniqueIdentifier = string.Empty;

	public string parentIdentifier = string.Empty;

	private AudioSource audioSource;

	private MeshCollider meshCollider;

	private AudioListener audioListener;

	private VolumetricAudioVolumeComponent[] childVolumes;

	private float desiredAudioVolume;

	private float audioVolumeFadeInTime;

	private bool initializedAudioVolume;

	private bool initializedGame;

	private bool IsChildVolume => !string.IsNullOrEmpty(parentIdentifier);

	private void OnEnable()
	{
		if (!audioSource)
		{
			audioSource = GetComponentInChildren<AudioSource>();
		}
		if (!meshCollider)
		{
			meshCollider = GetComponent<MeshCollider>();
		}
		if (Application.isPlaying && (bool)audioSource)
		{
			initializedAudioVolume = false;
			initializedGame = false;
			desiredAudioVolume = audioSource.volume;
			audioSource.volume = 0f;
		}
		if (!IsChildVolume)
		{
			childVolumes = FindChildVolumetricAudioVolumeComponents();
		}
	}

	private void LateUpdate()
	{
		if (IsChildVolume || !audioSource || !TryGetAudioListener())
		{
			return;
		}
		Vector3 audioListenerPosition = GetAudioListenerPosition();
		Vector3 vector = meshCollider.ClosestPoint(audioListenerPosition);
		float num = Vector3.Distance(audioListenerPosition, vector);
		if (base.transform.InverseTransformPoint(vector) == Vector3.zero)
		{
			return;
		}
		for (int i = 0; i < childVolumes.Length; i++)
		{
			if ((bool)childVolumes[i])
			{
				Vector3 vector2 = childVolumes[i].GetComponent<MeshCollider>().ClosestPoint(audioListenerPosition);
				float num2 = Vector3.Distance(audioListenerPosition, vector2);
				if (base.transform.InverseTransformPoint(vector2) == Vector3.zero)
				{
					return;
				}
				if (num2 < num)
				{
					num = num2;
					vector = vector2;
				}
			}
		}
		if (base.transform.InverseTransformPoint(vector) == Vector3.zero)
		{
			return;
		}
		audioSource.transform.position = vector;
		audioSource.spatialBlend = LerpInnerOuterRadius(spatialDistance2D, spatialDistance3D, num);
		if (Application.isPlaying && !initializedAudioVolume)
		{
			if (!initializedGame)
			{
				initializedGame = true;
				audioVolumeFadeInTime = Time.time;
			}
			audioSource.volume = Mathf.Lerp(audioSource.volume, desiredAudioVolume, Time.time - audioVolumeFadeInTime);
			if (Mathf.Approximately(audioSource.volume, desiredAudioVolume))
			{
				audioSource.volume = desiredAudioVolume;
				initializedAudioVolume = true;
			}
		}
	}

	private float LerpInnerOuterRadius(float inner, float outer, float value)
	{
		float num = value - inner;
		if (num < 0f)
		{
			num = 0f;
		}
		if (num > 0f)
		{
			float num2 = outer - inner;
			num = ((num2 != 0f) ? (num / num2) : 1f);
		}
		return Mathf.Lerp(0f, 1f, num);
	}

	private Vector3 GetAudioListenerPosition()
	{
		return audioListener.transform.position;
	}

	private bool TryGetAudioListener()
	{
		if (!IsBehaviourEnabled(audioListener))
		{
			audioListener = (from e in Object.FindObjectsOfType<AudioListener>()
				where IsBehaviourEnabled(e)
				select e).FirstOrDefault();
			return audioListener != null;
		}
		return true;
	}

	private bool IsBehaviourEnabled(Behaviour behaviour)
	{
		return behaviour != null && behaviour.enabled && behaviour.gameObject.activeInHierarchy;
	}

	private VolumetricAudioVolumeComponent FindParentVolumetricAudioVolumeComponent()
	{
		return Object.FindObjectsOfType<VolumetricAudioVolumeComponent>().FirstOrDefault((VolumetricAudioVolumeComponent volume) => volume.uniqueIdentifier == parentIdentifier);
	}

	private VolumetricAudioVolumeComponent[] FindChildVolumetricAudioVolumeComponents()
	{
		return (from volume in Object.FindObjectsOfType<VolumetricAudioVolumeComponent>()
			where volume.parentIdentifier == uniqueIdentifier
			select volume).ToArray();
	}
}
