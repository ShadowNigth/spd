using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GLBMELGGDNN : FOGIOGKLNIP
{
	private string NGIHJKGIKNA;

	private static Dictionary<byte[], AssetBundle> GOKHHNGMFJF = new Dictionary<byte[], AssetBundle>();

	public override void Awake()
	{
		FOGIOGKLNIP.OKJJJBOEGBJ = this;
		base.Awake();
	}

	private void Start()
	{
		NGIHJKGIKNA = string.Format("{0}", (Application.platform == RuntimePlatform.Android) ? Application.persistentDataPath : Application.dataPath);
	}

	public AssetBundle ICKGAFPAEEI(string OFOGBNEPILL, string INBGHLMKOKL = "")
	{
		string text = string.Format("{0}/Content/{1}", NGIHJKGIKNA, INBGHLMKOKL + OFOGBNEPILL);
		string text2 = string.Format("{0}/Custom/{1}", NGIHJKGIKNA, INBGHLMKOKL + OFOGBNEPILL);
		bool flag = File.Exists(text2);
		AssetBundle value = null;
		byte[] array = File.ReadAllBytes((!flag) ? text : text2);
		if (!GOKHHNGMFJF.TryGetValue(array, out value))
		{
			value = AssetBundle.LoadFromMemory(array);
			GOKHHNGMFJF[array] = value;
		}
		if (value != null)
		{
			Debug.Log(string.Format("BundleLoaded: {0}", value.name));
		}
		else
		{
			FOGIOGKLNIP.LPLJMLGKCLK.KPBILNDCOPL = string.Format("{0} '{1}'. {2} | {3} assetBytes.Length: {4}", FOGIOGKLNIP.FHHPMGJCHJL("Failed to load content:"), OFOGBNEPILL, flag ? FOGIOGKLNIP.FHHPMGJCHJL("Contact the author of this content to resolve this issue.") : FOGIOGKLNIP.FHHPMGJCHJL("Contact the developer to resolve this issue."), FOGIOGKLNIP.FHHPMGJCHJL("Debug Info:"), array.Length);
			Debug.LogError(string.Format(">>Failed to read '{0}' bundle! | Bytes bundle length: '{1}'", OFOGBNEPILL, array.Length));
		}
		return value;
	}
}
