using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(VerticalLayoutGroup), typeof(ContentSizeFitter), typeof(ToggleGroup))]
[AddComponentMenu("UI/Extensions/Accordion/Accordion Group")]
public class KGBBAHHKIBP : MonoBehaviour
{
	public enum LKFDAJDBFAI
	{
		KNNLGDOIGAK,
		NLIPACMELFO
	}

	[SerializeField]
	private LKFDAJDBFAI m_Transition;

	[SerializeField]
	private float m_TransitionDuration = 0.3f;

	public LKFDAJDBFAI CJPKPIDEDMF
	{
		get
		{
			return m_Transition;
		}
		set
		{
			m_Transition = value;
		}
	}

	public float JIJEMBGFLNO
	{
		get
		{
			return m_TransitionDuration;
		}
		set
		{
			m_TransitionDuration = value;
		}
	}
}
