using UnityEngine;

public class OPDOFDEMLDK : MonoBehaviour
{
	public int LLEHNAOKDHL = 1000;

	private int IKNOOLDGHLJ;

	private GUIStyle CKMCOIMLNPJ;

	private void Start()
	{
		Debug.Log("test long text sdf asdfg asdfg sdfgsdfg sdfg sfg sdfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfg asdf asdf asdf asdf adsf ");
		CKMCOIMLNPJ = new GUIStyle();
		CKMCOIMLNPJ.alignment = TextAnchor.MiddleCenter;
		CKMCOIMLNPJ.normal.textColor = Color.white;
		CKMCOIMLNPJ.wordWrap = true;
		for (int i = 0; i < 10; i++)
		{
			Debug.Log("Test Collapsed log");
			Debug.LogWarning("Test Collapsed Warning");
			Debug.LogError("Test Collapsed Error");
		}
	}

	private void Update()
	{
		int num = 0;
		while (IKNOOLDGHLJ < LLEHNAOKDHL && num < 10)
		{
			Debug.Log("Test Log " + IKNOOLDGHLJ);
			Debug.LogError("Test LogError " + IKNOOLDGHLJ);
			Debug.LogWarning("Test LogWarning " + IKNOOLDGHLJ);
			num++;
			IKNOOLDGHLJ++;
		}
	}

	private void OnGUI()
	{
		GUI.Label(new Rect(Screen.width / 2 - 120, Screen.height / 2 - 25, 240f, 50f), "Draw circle on screen to show logs", CKMCOIMLNPJ);
		GUI.Label(new Rect(Screen.width / 2 - 120, Screen.height / 2 + 25, 240f, 100f), "To use InGameLogs just create empty game object in first scene your game start at ,then add InGameLogs component to this object", CKMCOIMLNPJ);
	}
}
