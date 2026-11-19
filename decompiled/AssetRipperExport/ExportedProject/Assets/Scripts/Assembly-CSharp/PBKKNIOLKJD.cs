using UnityEngine;

[RequireComponent(typeof(Camera))]
public sealed class PBKKNIOLKJD : MonoBehaviour
{
	public static Camera EAIHIHFONIN { get; private set; }

	public static Transform NNHEMBFKBLC { get; private set; }

	private void Awake()
	{
		NNHEMBFKBLC = base.transform;
		EAIHIHFONIN = GetComponent<Camera>();
	}

	public static Vector2 CFFEKDAOCDE(Vector2 GIDEOJGAFJH)
	{
		return EAIHIHFONIN.ScreenToWorldPoint(GIDEOJGAFJH);
	}
}
