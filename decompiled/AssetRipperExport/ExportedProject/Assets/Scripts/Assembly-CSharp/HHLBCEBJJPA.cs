using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HHLBCEBJJPA : FOGIOGKLNIP
{
	private sealed class MIEPKOLPGLH : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal EGJCFCPEAID CJCBNFDKHIC;

		internal Renderer[] DKOBKNHODMO;

		internal int HGPJDOEGCEC;

		internal Light NKGFPECDIGM;

		internal HHLBCEBJJPA KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		private static Action ACJNADIPOMC;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public MIEPKOLPGLH()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				CJCBNFDKHIC = new EGJCFCPEAID();
				CJCBNFDKHIC.ICIEDCMDJFO = KPHCHDHEKGH.ICIEDCMDJFO;
				FOGIOGKLNIP.LPLJMLGKCLK.IMHMMKJKCBK = FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ.text.Length;
				try
				{
					CJCBNFDKHIC.DHBGHDFFOLN(FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ.text);
				}
				catch (Exception)
				{
					PKOGMCMAHON pKOGMCMAHON = FOGIOGKLNIP.GLNAMCPCICH;
					if (ACJNADIPOMC == null)
					{
						ACJNADIPOMC = BEKJDJFLJJC;
					}
					pKOGMCMAHON.MFEPFODPFHA(200, 400, "Error", NBOGOKNEBGI.IPBFPHDFNNH, ACJNADIPOMC);
					goto default;
				}
				FOGIOGKLNIP.LPLJMLGKCLK.ILJOBCIBPBJ = null;
				KPHCHDHEKGH.ICIEDCMDJFO.SetLayer(10);
				DKOBKNHODMO = KPHCHDHEKGH.ICIEDCMDJFO.GetComponentsInChildren<Renderer>();
				for (HGPJDOEGCEC = 0; HGPJDOEGCEC < DKOBKNHODMO.Length; HGPJDOEGCEC++)
				{
					Renderer renderer = DKOBKNHODMO[HGPJDOEGCEC];
					renderer.gameObject.AddComponent<MeshCollider>();
				}
				NKGFPECDIGM = new GameObject("dlight").AddComponent<Light>();
				NKGFPECDIGM.type = LightType.Directional;
				NKGFPECDIGM.transform.forward = Vector3.one + Vector3.down * 2f;
				NKGFPECDIGM.shadows = LightShadows.Soft;
				UnityEngine.Object.Destroy(KPHCHDHEKGH);
				SceneManager.LoadScene("1", LoadSceneMode.Additive);
				RenderSettings.fog = true;
				RenderSettings.fogDensity = 0.03f;
				HLJEEFIJCOF = null;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				break;
			case 1u:
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		private static void BEKJDJFLJJC()
		{
			FOGIOGKLNIP.IAOONCAPLGK("Map broken, Make sure you did next steps when you created map: \r\nExport Settings-> Export Two-Side Faces\r\nGroupped objects-> right click on object->Explode\r\nMap Scale is big enought\r\nStandart textures can be only used\r\n");
			if (FOGIOGKLNIP.MHFCLILDBCM("Disconnect"))
			{
				PhotonNetwork.Disconnect();
				SceneManager.LoadScene("0");
			}
		}
	}

	public string AOBAIFHNEPL;

	[DebuggerHidden]
	private IEnumerator Start()
	{
		MIEPKOLPGLH mIEPKOLPGLH = new MIEPKOLPGLH();
		mIEPKOLPGLH.KPHCHDHEKGH = this;
		return mIEPKOLPGLH;
	}
}
