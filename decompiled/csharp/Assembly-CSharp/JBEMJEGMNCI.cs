using System.Collections;
using UnityEngine;

public class JBEMJEGMNCI
{
	public IEnumerator BHNCPOFPBPC(Transform PLNPFEFLKFM, Vector3 HCAAOMABEKF, float HLOAPHLPNJG)
	{
		Quaternion localRotation = PLNPFEFLKFM.localRotation;
		Quaternion b = PLNPFEFLKFM.localRotation * Quaternion.Euler(HCAAOMABEKF);
		float num = 1f / HLOAPHLPNJG;
		float num2 = 0f;
		while (num2 < 1f)
		{
			num2 += Time.deltaTime * num;
			PLNPFEFLKFM.localRotation = Quaternion.Slerp(localRotation, b, num2);
			yield return null;
		}
	}

	public IEnumerator EBOIFEMDKAI(GameObject PLNPFEFLKFM, GameObject MBJIIFHAMML, float FEIKMNBLLKK, float IANLFMCDFKF)
	{
		if (PLNPFEFLKFM == null || MBJIIFHAMML == null)
		{
			yield return null;
		}
		while (FEIKMNBLLKK > 0f)
		{
			FEIKMNBLLKK -= Time.deltaTime * 1f;
			Vector3 euler = Random.insideUnitSphere * IANLFMCDFKF;
			if (FEIKMNBLLKK > 0f && (PLNPFEFLKFM != null || MBJIIFHAMML != null))
			{
				PLNPFEFLKFM.transform.localRotation = Quaternion.Lerp(PLNPFEFLKFM.transform.localRotation, Quaternion.Euler(euler), FEIKMNBLLKK);
				MBJIIFHAMML.transform.localRotation = Quaternion.Slerp(MBJIIFHAMML.transform.localRotation, Quaternion.Euler(euler), FEIKMNBLLKK);
			}
			else
			{
				yield return null;
			}
			yield return null;
		}
	}
}
