using UnityEngine;

public class ABONJOGMENG : MonoBehaviour
{
	private bool AGFMLIPEINM;

	private Transform CIEDFCKKEEO;

	private Transform FJOOJCJEEMB;

	private CharacterController OFKMCBJGALN;

	private float JPINOKOACLM;

	private bool OOPFJPMIBPO;

	private bool NDKOODKFCPF;

	private bool GPBJLLCCLEO;

	private float LPKGEOAJIDP;

	private bool FGLKHOAJAMM = true;

	private void Awake()
	{
		CIEDFCKKEEO = base.transform;
		FJOOJCJEEMB = Camera.main.transform;
		OFKMCBJGALN = GetComponent<CharacterController>();
	}

	private void Update()
	{
		if (!FGLKHOAJAMM)
		{
			LPKGEOAJIDP += Time.deltaTime;
			if (LPKGEOAJIDP > 0.15f)
			{
				FGLKHOAJAMM = true;
				LPKGEOAJIDP = 0f;
			}
		}
		if (LJIBBKOGAGL.KJFHJOHBBOJ("jumpBtn", BEONOIBCNBC.JNODLNLEMNM))
		{
			KOFBDBONPIF();
		}
		if (LJIBBKOGAGL.KJFHJOHBBOJ("fireBtn", BEONOIBCNBC.MLAHIBNJKDJ))
		{
			BBDKOGAKPLO();
		}
		Vector2 vector = LJIBBKOGAGL.PPECHIJCLHO("Touchpad");
		EAKPPHPHGEP(vector.x, vector.y);
	}

	private void FixedUpdate()
	{
		Vector2 vector = LJIBBKOGAGL.PPECHIJCLHO("Joystick");
		DLFBLJNGCLJ(vector.x, vector.y);
	}

	private void KOFBDBONPIF()
	{
		if (OFKMCBJGALN.isGrounded)
		{
			OOPFJPMIBPO = true;
		}
	}

	private void DLFBLJNGCLJ(float PNGFLJGPKCN, float EBLKKJNKBNG)
	{
		bool isGrounded = OFKMCBJGALN.isGrounded;
		Vector3 vector = CIEDFCKKEEO.forward * EBLKKJNKBNG;
		vector += CIEDFCKKEEO.right * PNGFLJGPKCN;
		vector.y = -10f;
		if (OOPFJPMIBPO)
		{
			OOPFJPMIBPO = false;
			vector.y = 25f;
			GPBJLLCCLEO = !GPBJLLCCLEO;
		}
		if (isGrounded)
		{
			vector *= 7f;
		}
		OFKMCBJGALN.Move(vector * Time.fixedDeltaTime);
		if (!NDKOODKFCPF && isGrounded)
		{
			vector.y = 0f;
		}
		NDKOODKFCPF = isGrounded;
	}

	public void EAKPPHPHGEP(float PNGFLJGPKCN, float EBLKKJNKBNG)
	{
		CIEDFCKKEEO.Rotate(0f, PNGFLJGPKCN * 12f, 0f);
		JPINOKOACLM += EBLKKJNKBNG * 12f;
		JPINOKOACLM = Mathf.Clamp(JPINOKOACLM, -60f, 60f);
		FJOOJCJEEMB.localEulerAngles = new Vector3(0f - JPINOKOACLM, FJOOJCJEEMB.localEulerAngles.y, 0f);
	}

	public void BBDKOGAKPLO()
	{
		if (FGLKHOAJAMM)
		{
			FGLKHOAJAMM = false;
			GameObject gameObject = GameObject.CreatePrimitive(GPBJLLCCLEO ? PrimitiveType.Cube : PrimitiveType.Sphere);
			gameObject.transform.position = CIEDFCKKEEO.position + CIEDFCKKEEO.right;
			gameObject.transform.localScale = Vector3.one * 0.2f;
			Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
			Transform transform = Camera.main.transform;
			rigidbody.AddForce(transform.forward * Random.Range(25f, 35f) + transform.right * Random.Range(-2f, 2f) + transform.up * Random.Range(-2f, 2f), ForceMode.Impulse);
			Object.Destroy(gameObject, 3.5f);
		}
	}

	public void IAOBNLEGPGN()
	{
	}
}
