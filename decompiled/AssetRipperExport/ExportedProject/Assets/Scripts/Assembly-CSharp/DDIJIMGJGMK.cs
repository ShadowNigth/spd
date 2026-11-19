using System;
using UnityEngine;

public class DDIJIMGJGMK : MonoBehaviour
{
	public static readonly int OJOBPALIPDN = 4;

	[SerializeField]
	protected Vector3[] controlPoints;

	public Action NLPJCKPCAHJ;

	public Vector3[] CBLOMNNONOC
	{
		get
		{
			return controlPoints;
		}
	}

	public void CLANABPJJJA()
	{
		if (NLPJCKPCAHJ != null)
		{
			NLPJCKPCAHJ();
		}
	}

	public Vector3 KCPJFPFEPJP(float IBBNGFPAKHJ)
	{
		float num = 1f - IBBNGFPAKHJ;
		return num * num * num * controlPoints[0] + 3f * num * num * IBBNGFPAKHJ * controlPoints[1] + 3f * num * IBBNGFPAKHJ * IBBNGFPAKHJ * controlPoints[2] + IBBNGFPAKHJ * IBBNGFPAKHJ * IBBNGFPAKHJ * controlPoints[3];
	}

	public Vector3 OHHONFKNPDF(float IBBNGFPAKHJ)
	{
		float num = 1f - IBBNGFPAKHJ;
		return 3f * num * num * (controlPoints[1] - controlPoints[0]) + 6f * num * IBBNGFPAKHJ * (controlPoints[2] - controlPoints[1]) + 3f * IBBNGFPAKHJ * IBBNGFPAKHJ * (controlPoints[3] - controlPoints[2]);
	}

	public void ONKNMHJOJIL()
	{
		if (controlPoints == null)
		{
			controlPoints = new Vector3[OJOBPALIPDN];
			controlPoints[0] = new Vector3(0f, 0f, 0f);
			controlPoints[1] = new Vector3(0f, 1f, 0f);
			controlPoints[2] = new Vector3(1f, 1f, 0f);
			controlPoints[3] = new Vector3(1f, 0f, 0f);
		}
		bool flag = true;
		flag &= controlPoints.Length == OJOBPALIPDN;
	}
}
