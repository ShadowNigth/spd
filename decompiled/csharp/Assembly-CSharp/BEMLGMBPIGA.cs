using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
[AddComponentMenu("UI/Extensions/ScrollRectLinker")]
public class BEMLGMBPIGA : MonoBehaviour
{
	public bool KMFJAPIGONH = true;

	[SerializeField]
	private ScrollRect controllingScrollRect;

	private ScrollRect CODNNIKNIHB;

	private void Awake()
	{
		CODNNIKNIHB = GetComponent<ScrollRect>();
		if (controllingScrollRect != null)
		{
			controllingScrollRect.onValueChanged.AddListener(HKICJMOPIFA);
		}
	}

	private void HKICJMOPIFA(Vector2 EABFFDFOHCN)
	{
		if (KMFJAPIGONH)
		{
			CODNNIKNIHB.normalizedPosition = new Vector2(Mathf.Clamp01(EABFFDFOHCN.x), Mathf.Clamp01(EABFFDFOHCN.y));
		}
		else
		{
			CODNNIKNIHB.normalizedPosition = EABFFDFOHCN;
		}
	}
}
