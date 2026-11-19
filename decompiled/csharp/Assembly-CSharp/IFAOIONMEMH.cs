using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/Input Field Submit")]
[RequireComponent(typeof(InputField))]
public class IFAOIONMEMH : MonoBehaviour
{
	[Serializable]
	public class EnterSubmitEvent : UnityEvent<string>
	{
	}

	public EnterSubmitEvent MJNNGAAMNJP;

	private InputField CFMLOJGLLPP;

	private void Awake()
	{
		CFMLOJGLLPP = GetComponent<InputField>();
		CFMLOJGLLPP.onEndEdit.AddListener(INNFOHJJJMM);
	}

	public void INNFOHJJJMM(string NFFPPKLIPBC)
	{
		if (UnityEngine.Input.GetKeyDown(KeyCode.Return) || UnityEngine.Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			MJNNGAAMNJP.Invoke(NFFPPKLIPBC);
		}
	}
}
