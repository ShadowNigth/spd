using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Extensions/InputFocus")]
[RequireComponent(typeof(InputField))]
public class PIBDLALBNFC : MonoBehaviour
{
	protected InputField AEMKIPAGHML;

	public bool GOPDCPFCBNA;

	private void Start()
	{
		AEMKIPAGHML = GetComponent<InputField>();
	}

	private void Update()
	{
		if (UnityEngine.Input.GetKeyUp(KeyCode.Return) && !AEMKIPAGHML.isFocused)
		{
			if (GOPDCPFCBNA)
			{
				GOPDCPFCBNA = false;
				return;
			}
			AEMKIPAGHML.Select();
			AEMKIPAGHML.ActivateInputField();
		}
	}

	public void FDIELMBPJBG()
	{
		bool flag = AEMKIPAGHML.text == string.Empty;
		AEMKIPAGHML.text = string.Empty;
		if (!flag)
		{
			AEMKIPAGHML.Select();
			AEMKIPAGHML.ActivateInputField();
		}
	}

	public void INNFOHJJJMM(string DBPJNPKEKFF)
	{
		if (UnityEngine.Input.GetKeyDown(KeyCode.Return))
		{
			bool flag = AEMKIPAGHML.text == string.Empty;
			AEMKIPAGHML.text = string.Empty;
			if (flag)
			{
				GOPDCPFCBNA = true;
			}
		}
	}
}
