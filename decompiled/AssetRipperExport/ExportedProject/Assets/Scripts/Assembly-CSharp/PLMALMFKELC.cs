using UnityEngine;

public class PLMALMFKELC : MonoBehaviour
{
	public Vector2 AAFLGILMEKL = new Vector2(5f, 3f);

	private Transform MDFDMEENKMH;

	private Quaternion OAGCCFOFPJD;

	private Vector2 LMAHADEJFKP = Vector2.zero;

	private void Start()
	{
		MDFDMEENKMH = base.transform;
		OAGCCFOFPJD = MDFDMEENKMH.localRotation;
	}

	private void Update()
	{
		Vector3 mousePosition = UnityEngine.Input.mousePosition;
		float num = (float)Screen.width * 0.5f;
		float num2 = (float)Screen.height * 0.5f;
		float x = Mathf.Clamp((mousePosition.x - num) / num, -1f, 1f);
		float y = Mathf.Clamp((mousePosition.y - num2) / num2, -1f, 1f);
		LMAHADEJFKP = Vector2.Lerp(LMAHADEJFKP, new Vector2(x, y), Time.deltaTime * 5f);
		MDFDMEENKMH.localRotation = OAGCCFOFPJD * Quaternion.Euler((0f - LMAHADEJFKP.y) * AAFLGILMEKL.y, LMAHADEJFKP.x * AAFLGILMEKL.x, 0f);
	}
}
