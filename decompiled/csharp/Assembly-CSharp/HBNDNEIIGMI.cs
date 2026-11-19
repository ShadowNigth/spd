using System.Collections;
using UnityEngine;

internal class HBNDNEIIGMI<T> where T : struct, KEDIOCMEKPK
{
	protected MonoBehaviour NEBHGFIAJBK;

	protected IEnumerator ILIDLFEILNB;

	private static IEnumerator JMLAEOGOGDP(T JNCDBDFDJCP)
	{
		if (JNCDBDFDJCP.EDGKDFKMFDL())
		{
			float num = 0f;
			while (num < JNCDBDFDJCP.PJBGGDBFEEP)
			{
				num += ((!JNCDBDFDJCP.ADDDPKEAFFD) ? Time.deltaTime : Time.unscaledDeltaTime);
				float iHDFAOBLIJG = Mathf.Clamp01(num / JNCDBDFDJCP.PJBGGDBFEEP);
				JNCDBDFDJCP.NAPEJNEJBMM(iHDFAOBLIJG);
				yield return null;
			}
			JNCDBDFDJCP.NAPEJNEJBMM(1f);
			JNCDBDFDJCP.PKEPNLCEPDP();
		}
	}

	public void HIBHJDCMMAJ(MonoBehaviour FBNIEBCLOHG)
	{
		NEBHGFIAJBK = FBNIEBCLOHG;
	}

	public void CLAHIBCEFPC(T LIEKABKEJOG)
	{
		if (NEBHGFIAJBK == null)
		{
			Debug.LogWarning("Coroutine container not configured... did you forget to call Init?");
			return;
		}
		if (ILIDLFEILNB != null)
		{
			NEBHGFIAJBK.StopCoroutine(ILIDLFEILNB);
			ILIDLFEILNB = null;
		}
		if (!NEBHGFIAJBK.gameObject.activeInHierarchy)
		{
			LIEKABKEJOG.NAPEJNEJBMM(1f);
			return;
		}
		ILIDLFEILNB = JMLAEOGOGDP(LIEKABKEJOG);
		NEBHGFIAJBK.StartCoroutine(ILIDLFEILNB);
	}
}
