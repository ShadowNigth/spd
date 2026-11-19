using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IMOHOPJDEGM : MonoBehaviour
{
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

	public bool BGFHCMAMHFE => Application.platform != RuntimePlatform.Android;

	public bool JFFAEOBJFIF => Application.version != AMOGJCGPOBA && !string.IsNullOrEmpty(AMOGJCGPOBA);

	public int GCPLACLAKKH => FOGIOGKLNIP.ICLCHCGKAPN("targetFrameRate", 60);

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

	public IEnumerator MIDHNNIKOJJ(Action<string> AEMBPMJMOAB, WWW GDIFBJBOCJM)
	{
		Action<string> iKJHNNLICBA = IKJHNNLICBA;
		IKJHNNLICBA = null;
		yield return GDIFBJBOCJM;
		if (string.IsNullOrEmpty(GDIFBJBOCJM.error) && !GDIFBJBOCJM.text.Trim().StartsWith("<") && !GDIFBJBOCJM.text.Trim().StartsWith("java.net"))
		{
			AEMBPMJMOAB(GDIFBJBOCJM.text);
			yield break;
		}
		iKJHNNLICBA?.Invoke(GDIFBJBOCJM.error);
		NCNIGAOHMJN.text = MEEAOBGGPLC(0);
		if (GDIFBJBOCJM.error == "Cannot resolve destination host" || GDIFBJBOCJM.error != string.Empty)
		{
			Debug.LogError(GDIFBJBOCJM.error);
		}
	}

	public string MEEAOBGGPLC(int JDILIPIDLOL = -1)
	{
		string empty = string.Empty;
		return JDILIPIDLOL switch
		{
			0 => "An error occurred while downloading the cache.", 
			1 => "An error occurred while extracting the cache.", 
			100 => "Cache verification completed. <color=red>Play Now!</color>", 
			200 => "Extracting completed. <color=red>Play Now!</color>", 
			300 => "Downloading cache...", 
			400 => "Extracting cache...", 
			_ => "Checking Game Cache Updates...", 
		};
	}

	private IEnumerator Start()
	{
		BetterStreamingAssets.Initialize();
		Application.targetFrameRate = GCPLACLAKKH;
		FKBJGHILEHN = $"{((!BGFHCMAMHFE) ? Application.persistentDataPath : Application.dataPath)}";
		NCEJJMBKNOG = File.Exists(FKBJGHILEHN + "/SPD_CACHE.DATA");
		KFEIIDMFOLF($"{GDCOFACHBNL}ver.txt", delegate(string KLLKONMADKA)
		{
			string[] array = KLLKONMADKA.Split(new char[1] { '\n' }, StringSplitOptions.None);
			AMOGJCGPOBA = array[0].Trim('\r');
			DPOCECJNDMP = array[(!BGFHCMAMHFE) ? 1 : 2].Trim('\r');
		});
		yield return new WaitForSeconds(5f);
		if (JFFAEOBJFIF)
		{
			EJBDIHPOJIG();
		}
		else if (NCEJJMBKNOG)
		{
			OIJLHDOBLEC(100);
		}
		else
		{
			NCNIGAOHMJN.text = MEEAOBGGPLC(400);
			yield return new WaitForSeconds(2f);
			EIOLBHNLLFG();
		}
		yield return null;
	}

	private void EIOLBHNLLFG()
	{
		try
		{
			lzma.doDecompress7zip(Application.streamingAssetsPath + "/GameCache.7z", $"{FKBJGHILEHN}/Content", largeFiles: true, fullPaths: true, null, (!BGFHCMAMHFE) ? BetterStreamingAssets.ReadAllBytes("/GameCache.7z") : null);
			File.WriteAllText(FKBJGHILEHN + "/SPD_CACHE.DATA", DFAEHPCALHM);
			OIJLHDOBLEC(200);
		}
		catch (Exception ex)
		{
			OIJLHDOBLEC(1);
			File.AppendAllText($"{FKBJGHILEHN}/UnpackCache_ErrorLog.txt", ex.Message);
			Debug.LogError($"lzma.unpack error detail: {ex}");
		}
	}

	private void EJBDIHPOJIG()
	{
		IHFIODKMKGC.SetActive(value: false);
		EPCACMKJFFP.SetActive(value: true);
		LDKAELFAHML.text = ((!DEOBDHEMFKE) ? $"New version <color=red>{AMOGJCGPOBA}</color> released!" : $"New version <color=red>{AMOGJCGPOBA}</color> released!\r\n\r\n\r\n\r\nPlease update the game via the Play store.");
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
