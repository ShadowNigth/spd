using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/Tooltip")]
public class HDCFOEEMDFC : MonoBehaviour
{
	private Text CEOCFBMNGLO;

	private RectTransform NGMNDPBFLAN;

	private bool DLMBHKMOIJB;

	private float KAPGDBCIGHP;

	private float GAGNFGOGPHH;

	private float IHKFCBGFOEI;

	private float IAEIDENDBFN;

	private RenderMode OAHKACKMKDA;

	private Camera LAKNJNPCFKF;

	public void Awake()
	{
		Canvas componentInParent = GetComponentInParent<Canvas>();
		LAKNJNPCFKF = componentInParent.worldCamera;
		OAHKACKMKDA = componentInParent.renderMode;
		NGMNDPBFLAN = GetComponent<RectTransform>();
		CEOCFBMNGLO = GetComponentInChildren<Text>();
		DLMBHKMOIJB = false;
		IAEIDENDBFN = 0f;
		IHKFCBGFOEI = -30f;
		base.gameObject.SetActive(value: false);
	}

	public void OBLLLKJOIPP(string IGCEPGOPLFK)
	{
		if (OAHKACKMKDA == RenderMode.ScreenSpaceCamera)
		{
			CEOCFBMNGLO.text = IGCEPGOPLFK;
			NGMNDPBFLAN.sizeDelta = new Vector2(CEOCFBMNGLO.preferredWidth + 40f, CEOCFBMNGLO.preferredHeight + 25f);
			OHNGALMGKEJ();
		}
	}

	public void MIJCNPJKAIG()
	{
		if (OAHKACKMKDA == RenderMode.ScreenSpaceCamera)
		{
			base.gameObject.SetActive(value: false);
			DLMBHKMOIJB = false;
		}
	}

	private void FixedUpdate()
	{
		if (DLMBHKMOIJB && OAHKACKMKDA == RenderMode.ScreenSpaceCamera)
		{
			OHNGALMGKEJ();
		}
	}

	public void OHNGALMGKEJ()
	{
		Vector3 position = LAKNJNPCFKF.ScreenToViewportPoint(UnityEngine.Input.mousePosition - new Vector3(IAEIDENDBFN, IHKFCBGFOEI, 0f));
		Vector3 vector = LAKNJNPCFKF.ViewportToWorldPoint(position);
		KAPGDBCIGHP = NGMNDPBFLAN.sizeDelta[0];
		GAGNFGOGPHH = NGMNDPBFLAN.sizeDelta[1];
		Vector3 vector2 = LAKNJNPCFKF.ViewportToWorldPoint(new Vector3(0f, 0f, 0f));
		Vector3 vector3 = LAKNJNPCFKF.ViewportToWorldPoint(new Vector3(1f, 1f, 0f));
		float num = vector.x + KAPGDBCIGHP / 2f;
		if (num > vector3.x)
		{
			Vector3 vector4 = new Vector3(num - vector3.x, 0f, 0f);
			Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 0f);
			position.x = LAKNJNPCFKF.WorldToViewportPoint(position2).x;
		}
		num = vector.x - KAPGDBCIGHP / 2f;
		if (num < vector2.x)
		{
			Vector3 vector5 = new Vector3(vector2.x - num, 0f, 0f);
			Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 0f);
			position.x = LAKNJNPCFKF.WorldToViewportPoint(position3).x;
		}
		num = vector.y + GAGNFGOGPHH / 2f;
		if (num > vector3.y)
		{
			Vector3 vector6 = new Vector3(0f, 35f + GAGNFGOGPHH / 2f, 0f);
			Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 0f);
			position.y = LAKNJNPCFKF.WorldToViewportPoint(position4).y;
		}
		num = vector.y - GAGNFGOGPHH / 2f;
		if (num < vector2.y)
		{
			Vector3 vector7 = new Vector3(0f, 35f + GAGNFGOGPHH / 2f, 0f);
			Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 0f);
			position.y = LAKNJNPCFKF.WorldToViewportPoint(position5).y;
		}
		base.transform.position = new Vector3(vector.x, vector.y, 0f);
		base.gameObject.SetActive(value: true);
		DLMBHKMOIJB = true;
	}
}
