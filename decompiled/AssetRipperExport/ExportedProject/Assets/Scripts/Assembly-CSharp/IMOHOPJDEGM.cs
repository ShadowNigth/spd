using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IMOHOPJDEGM : MonoBehaviour
{
	private sealed class DMJAIBHDGFO : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal Action<string> IAKBPPHEELD;

		internal WWW GDIFBJBOCJM;

		internal Action<string> AEMBPMJMOAB;

		internal IMOHOPJDEGM KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

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
		public DMJAIBHDGFO()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				IAKBPPHEELD = IKJHNNLICBA;
				IKJHNNLICBA = null;
				HLJEEFIJCOF = GDIFBJBOCJM;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				if (string.IsNullOrEmpty(GDIFBJBOCJM.error) && !GDIFBJBOCJM.text.Trim().StartsWith("<") && !GDIFBJBOCJM.text.Trim().StartsWith("java.net"))
				{
					AEMBPMJMOAB(GDIFBJBOCJM.text);
				}
				else
				{
					if (IAKBPPHEELD != null)
					{
						IAKBPPHEELD(GDIFBJBOCJM.error);
					}
					KPHCHDHEKGH.NCNIGAOHMJN.text = KPHCHDHEKGH.MEEAOBGGPLC(0);
					if (GDIFBJBOCJM.error == "Cannot resolve destination host" || GDIFBJBOCJM.error != string.Empty)
					{
						UnityEngine.Debug.LogError(GDIFBJBOCJM.error);
					}
				}
				GNNOELAJGPI = -1;
				break;
			}
			return false;
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
	}

	private sealed class JICPMDEMGGP : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal IMOHOPJDEGM KPHCHDHEKGH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

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
		public JICPMDEMGGP()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				BetterStreamingAssets.Initialize();
				Application.targetFrameRate = KPHCHDHEKGH.GCPLACLAKKH;
				KPHCHDHEKGH.FKBJGHILEHN = string.Format("{0}", (!KPHCHDHEKGH.BGFHCMAMHFE) ? Application.persistentDataPath : Application.dataPath);
				KPHCHDHEKGH.NCEJJMBKNOG = File.Exists(KPHCHDHEKGH.FKBJGHILEHN + "/SPD_CACHE.DATA");
				KPHCHDHEKGH.KFEIIDMFOLF(string.Format("{0}ver.txt", KPHCHDHEKGH.GDCOFACHBNL), BEKJDJFLJJC);
				HLJEEFIJCOF = new WaitForSeconds(5f);
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				break;
			case 1u:
				if (KPHCHDHEKGH.JFFAEOBJFIF)
				{
					KPHCHDHEKGH.EJBDIHPOJIG();
				}
				else
				{
					if (!KPHCHDHEKGH.NCEJJMBKNOG)
					{
						KPHCHDHEKGH.NCNIGAOHMJN.text = KPHCHDHEKGH.MEEAOBGGPLC(400);
						HLJEEFIJCOF = new WaitForSeconds(2f);
						if (!JMOBJHKGFMH)
						{
							GNNOELAJGPI = 2;
						}
						break;
					}
					KPHCHDHEKGH.OIJLHDOBLEC(100);
				}
				goto IL_017e;
			case 2u:
				KPHCHDHEKGH.EIOLBHNLLFG();
				goto IL_017e;
			case 3u:
				GNNOELAJGPI = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_017e:
				HLJEEFIJCOF = null;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 3;
				}
				break;
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

		internal void BEKJDJFLJJC(string KLLKONMADKA)
		{
			string[] array = KLLKONMADKA.Split(new char[1] { '\n' }, StringSplitOptions.None);
			KPHCHDHEKGH.AMOGJCGPOBA = array[0].Trim('\r');
			KPHCHDHEKGH.DPOCECJNDMP = array[(!KPHCHDHEKGH.BGFHCMAMHFE) ? 1 : 2].Trim('\r');
		}
	}

	public string AMOGJCGPOBA;

	public string DPOCECJNDMP;

	public bool DEOBDHEMFKE;

	public string GDCOFACHBNL;

	public GameObject IHFIODKMKGC;

	public GameObject EPCACMKJFFP;

	public Text PFEEMNMPIDL;

	public Text LDKAELFAHML;

	public Text NCNIGAOHMJN;

	public Button KGBEJEGFHDM;

	public Button LFGLPILCAME;

	private string FKBJGHILEHN;

	public string DFAEHPCALHM;

	private bool NCEJJMBKNOG;

	public static bool EKGNDFOPKLC;

	public static Action<string> IKJHNNLICBA;

	[CompilerGenerated]
	private static UnityAction ACJNADIPOMC;

	public bool BGFHCMAMHFE
	{
		get
		{
			return Application.platform != RuntimePlatform.Android;
		}
	}

	public bool JFFAEOBJFIF
	{
		get
		{
			return Application.version != AMOGJCGPOBA && !string.IsNullOrEmpty(AMOGJCGPOBA);
		}
	}

	public int GCPLACLAKKH
	{
		get
		{
			return FOGIOGKLNIP.ICLCHCGKAPN("targetFrameRate", 60);
		}
	}

	public WWW KFEIIDMFOLF(string LGNIFJCEECH, params object[] IAKLBHKKNFM)
	{
		return KFEIIDMFOLF(LGNIFJCEECH, KEPLDHKBEJG, IAKLBHKKNFM);
	}

	private void KEPLDHKBEJG(string KLLKONMADKA)
	{
	}

	public WWW KFEIIDMFOLF(string LGNIFJCEECH, Action<string> AEMBPMJMOAB, params object[] IAKLBHKKNFM)
	{
		WWW wWW;
		if (IAKLBHKKNFM.Length > 0)
		{
			StringBuilder stringBuilder = new StringBuilder(LGNIFJCEECH);
			WWWForm wWWForm = new WWWForm();
			for (int i = 0; i < IAKLBHKKNFM.Length; i += 2)
			{
				if (EKGNDFOPKLC)
				{
					if (IAKLBHKKNFM[i + 1] is byte[])
					{
						wWWForm.AddBinaryData(IAKLBHKKNFM[i].ToString(), (byte[])IAKLBHKKNFM[i + 1]);
					}
					else
					{
						wWWForm.AddField(IAKLBHKKNFM[i].ToString(), IAKLBHKKNFM[i + 1].ToString());
					}
				}
				else
				{
					stringBuilder.Append((i == 0) ? '?' : '&');
					stringBuilder.Append(string.Concat(IAKLBHKKNFM[i], "=", WWW.EscapeURL(IAKLBHKKNFM[i + 1].ToString())));
				}
			}
			wWW = ((!EKGNDFOPKLC) ? new WWW(stringBuilder.ToString()) : new WWW(stringBuilder.ToString(), wWWForm));
		}
		else
		{
			wWW = new WWW(LGNIFJCEECH);
		}
		StartCoroutine(MIDHNNIKOJJ(AEMBPMJMOAB, wWW));
		EKGNDFOPKLC = false;
		return wWW;
	}

	[DebuggerHidden]
	public IEnumerator MIDHNNIKOJJ(Action<string> AEMBPMJMOAB, WWW GDIFBJBOCJM)
	{
		DMJAIBHDGFO dMJAIBHDGFO = new DMJAIBHDGFO();
		dMJAIBHDGFO.GDIFBJBOCJM = GDIFBJBOCJM;
		dMJAIBHDGFO.AEMBPMJMOAB = AEMBPMJMOAB;
		dMJAIBHDGFO.KPHCHDHEKGH = this;
		return dMJAIBHDGFO;
	}

	public string MEEAOBGGPLC(int JDILIPIDLOL = -1)
	{
		string empty = string.Empty;
		switch (JDILIPIDLOL)
		{
		case 0:
			return "An error occurred while downloading the cache.";
		case 1:
			return "An error occurred while extracting the cache.";
		case 100:
			return "Cache verification completed. <color=red>Play Now!</color>";
		case 200:
			return "Extracting completed. <color=red>Play Now!</color>";
		case 300:
			return "Downloading cache...";
		case 400:
			return "Extracting cache...";
		default:
			return "Checking Game Cache Updates...";
		}
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		JICPMDEMGGP jICPMDEMGGP = new JICPMDEMGGP();
		jICPMDEMGGP.KPHCHDHEKGH = this;
		return jICPMDEMGGP;
	}

	private void EIOLBHNLLFG()
	{
		try
		{
			lzma.doDecompress7zip(Application.streamingAssetsPath + "/GameCache.7z", string.Format("{0}/Content", FKBJGHILEHN), true, true, null, (!BGFHCMAMHFE) ? BetterStreamingAssets.ReadAllBytes("/GameCache.7z") : null);
			File.WriteAllText(FKBJGHILEHN + "/SPD_CACHE.DATA", DFAEHPCALHM);
			OIJLHDOBLEC(200);
		}
		catch (Exception ex)
		{
			OIJLHDOBLEC(1);
			File.AppendAllText(string.Format("{0}/UnpackCache_ErrorLog.txt", FKBJGHILEHN), ex.Message);
			UnityEngine.Debug.LogError(string.Format("lzma.unpack error detail: {0}", ex));
		}
	}

	private void EJBDIHPOJIG()
	{
		IHFIODKMKGC.SetActive(false);
		EPCACMKJFFP.SetActive(true);
		LDKAELFAHML.text = ((!DEOBDHEMFKE) ? string.Format("New version <color=red>{0}</color> released!", AMOGJCGPOBA) : string.Format("New version <color=red>{0}</color> released!\r\n\r\n\r\n\r\nPlease update the game via the Play store.", AMOGJCGPOBA));
		LFGLPILCAME.SetActive(!DEOBDHEMFKE);
		LFGLPILCAME.interactable = true;
		LFGLPILCAME.onClick.AddListener(delegate
		{
			Application.OpenURL(DPOCECJNDMP);
		});
	}

	private void OIJLHDOBLEC(int JDILIPIDLOL)
	{
		NCNIGAOHMJN.text = MEEAOBGGPLC(JDILIPIDLOL);
		KGBEJEGFHDM.interactable = true;
		KGBEJEGFHDM.onClick.AddListener(delegate
		{
			SceneManager.LoadSceneAsync("0");
		});
	}

	[CompilerGenerated]
	private void EJOLPBDDEII()
	{
		Application.OpenURL(DPOCECJNDMP);
	}

	[CompilerGenerated]
	private static void GIAKHDKIEKL()
	{
		SceneManager.LoadSceneAsync("0");
	}
}
