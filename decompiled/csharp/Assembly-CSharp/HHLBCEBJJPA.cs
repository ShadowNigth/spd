using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HHLBCEBJJPA : FOGIOGKLNIP
{
	public string AOBAIFHNEPL;

	private IEnumerator Start()
	{
		EGJCFCPEAID eGJCFCPEAID = new EGJCFCPEAID
		{
			ICIEDCMDJFO = ICIEDCMDJFO
		};
		FOGIOGKLNIP.LPLJMLGKCLK.IMHMMKJKCBK = FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ.text.Length;
		try
		{
			eGJCFCPEAID.DHBGHDFFOLN(FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ.text);
		}
		catch (Exception)
		{
			FOGIOGKLNIP.GLNAMCPCICH.MFEPFODPFHA(200, 400, "Error", NBOGOKNEBGI.IPBFPHDFNNH, delegate
			{
				FOGIOGKLNIP.IAOONCAPLGK("Map broken, Make sure you did next steps when you created map: \r\nExport Settings-> Export Two-Side Faces\r\nGroupped objects-> right click on object->Explode\r\nMap Scale is big enought\r\nStandart textures can be only used\r\n");
				if (FOGIOGKLNIP.MHFCLILDBCM("Disconnect"))
				{
					PhotonNetwork.Disconnect();
					SceneManager.LoadScene("0");
				}
			});
			yield break;
		}
		FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ = null;
		ICIEDCMDJFO.SetLayer(10);
		Renderer[] componentsInChildren = ICIEDCMDJFO.GetComponentsInChildren<Renderer>();
		foreach (Renderer renderer in componentsInChildren)
		{
			renderer.gameObject.AddComponent<MeshCollider>();
		}
		Light light = new GameObject("dlight").AddComponent<Light>();
		light.type = LightType.Directional;
		light.transform.forward = Vector3.one + Vector3.down * 2f;
		light.shadows = LightShadows.Soft;
		UnityEngine.Object.Destroy(this);
		SceneManager.LoadScene("1", LoadSceneMode.Additive);
		RenderSettings.fog = true;
		RenderSettings.fogDensity = 0.03f;
		yield return null;
	}
}
