using UnityEngine;

public class ExternalLinks : MonoBehaviour
{
	public void OpenURL(string URL)
	{
		Application.OpenURL(URL);
	}
}
