using System;
using UnityEngine;

public class KONNIOEAGAK : MonoBehaviour
{
	private float DOILAPLBDKP = 0.25f;

	public float CIDCJNPHMGM = 0.05f;

	public float GDGHOEIKLBH = 0.6f;

	private float JDFKPOMKMNJ;

	private void Update()
	{
		float num = 0f;
		float axis = Input.GetAxis("Horizontal");
		float axis2 = Input.GetAxis("Vertical");
		if (Mathf.Abs(axis) == 0f && Mathf.Abs(axis2) == 0f)
		{
			JDFKPOMKMNJ = 0f;
		}
		else
		{
			num = Mathf.Sin(JDFKPOMKMNJ);
			JDFKPOMKMNJ += DOILAPLBDKP;
			if (JDFKPOMKMNJ > (float)Math.PI * 2f)
			{
				JDFKPOMKMNJ -= (float)Math.PI * 2f;
			}
		}
		if (num != 0f)
		{
			float num2 = num * CIDCJNPHMGM;
			float value = Mathf.Abs(axis) + Mathf.Abs(axis2);
			value = Mathf.Clamp(value, 0f, 1f);
			num2 = value * num2;
			Vector3 localPosition = base.transform.localPosition;
			localPosition.y = GDGHOEIKLBH + num2 * Time.timeScale;
			base.transform.localPosition = localPosition;
		}
		else
		{
			Vector3 localPosition2 = base.transform.localPosition;
			localPosition2.y = GDGHOEIKLBH;
			base.transform.localPosition = localPosition2;
		}
	}
}
