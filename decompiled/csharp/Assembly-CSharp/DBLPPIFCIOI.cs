using System.Runtime.CompilerServices;
using UnityEngine;

public class DBLPPIFCIOI : MonoBehaviour
{
	public Renderer GBCHCBAMNDJ;

	public KFANEHLIPBI MBFJEBHOFCC;

	private void Awake()
	{
		GBCHCBAMNDJ = GetComponent<Renderer>();
	}

	private void Start()
	{
		MBFJEBHOFCC.DNMFLMKBGAP.AddListener(delegate(Color JPLPPELPDKF)
		{
			GBCHCBAMNDJ.material.color = JPLPPELPDKF;
		});
	}

	[CompilerGenerated]
	private void JDGOKBJLEBB(Color JPLPPELPDKF)
	{
		GBCHCBAMNDJ.material.color = JPLPPELPDKF;
	}
}
