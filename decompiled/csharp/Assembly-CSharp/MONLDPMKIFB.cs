using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class MONLDPMKIFB : FOGIOGKLNIP
{
	public string NHLHMGOLEKC;

	private string NMECHCHCNOF;

	private string OCNEOFADEAG;

	public string AKMKNECKCAP;

	public string IBGOODJABCI;

	public string BKEIKJMHAAI;

	public void IDNJBEBODIP(string JPBEBBODCJJ, string AMCPHJLHELL)
	{
	}

	public override void Awake()
	{
		FOGIOGKLNIP.LGGHDMBKKCE = this;
	}

	public string ALMGKPDPDCH(string KLLKONMADKA, string OHBGGLGCLHC)
	{
		int keySize = NHLHMGOLEKC.Length * 8;
		int blockSize = OHBGGLGCLHC.Length * 8;
		byte[] bytes = Encoding.ASCII.GetBytes(NHLHMGOLEKC);
		byte[] bytes2 = Encoding.ASCII.GetBytes(OHBGGLGCLHC);
		if ((NHLHMGOLEKC.Length == 16 || NHLHMGOLEKC.Length == 32) && (OHBGGLGCLHC.Length == 16 || OHBGGLGCLHC.Length == 32))
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = keySize;
			rijndaelManaged.BlockSize = blockSize;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Key = bytes;
			rijndaelManaged.IV = bytes2;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			byte[] inArray = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					byte[] bytes3 = Encoding.UTF8.GetBytes(KLLKONMADKA);
					cryptoStream.Write(bytes3, 0, bytes3.Length);
				}
				inArray = memoryStream.ToArray();
			}
			return Convert.ToBase64String(inArray);
		}
		return "Key and Iv must be 16 or 32 character";
	}

	public string MMNLMLIIDBO(string KLLKONMADKA, string OHBGGLGCLHC)
	{
		int keySize = NHLHMGOLEKC.Length * 8;
		int blockSize = OHBGGLGCLHC.Length * 8;
		byte[] bytes = Encoding.ASCII.GetBytes(NHLHMGOLEKC);
		byte[] bytes2 = Encoding.ASCII.GetBytes(OHBGGLGCLHC);
		try
		{
			IDNJBEBODIP(NHLHMGOLEKC, OHBGGLGCLHC);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = keySize;
			rijndaelManaged.BlockSize = blockSize;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Key = bytes;
			rijndaelManaged.IV = bytes2;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] bytes3 = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					byte[] array = Convert.FromBase64String(KLLKONMADKA);
					cryptoStream.Write(array, 0, array.Length);
				}
				bytes3 = memoryStream.ToArray();
			}
			return Encoding.UTF8.GetString(bytes3);
		}
		catch (Exception)
		{
			MonoBehaviour.print("Encrypt failed");
			return KLLKONMADKA;
		}
	}

	public string BGPILDHIGCM(int IJDNFLAKFON = 32)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = "qwertyuiopasdfghjklzxcvbnm";
		for (int i = 0; i < IJDNFLAKFON; i++)
		{
			stringBuilder.Append(text[UnityEngine.Random.Range(0, text.Length)]);
		}
		return stringBuilder.ToString();
	}

	public IEnumerator KFEIIDMFOLF(string AKMKNECKCAP, Action<bool, string> AEMBPMJMOAB, params string[] IAKLBHKKNFM)
	{
		string oHBGGLGCLHC = BGPILDHIGCM();
		WWW wWW = KFEIIDMFOLF(AKMKNECKCAP, oHBGGLGCLHC, IAKLBHKKNFM);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			AEMBPMJMOAB(arg1: false, wWW.error);
		}
		else
		{
			AEMBPMJMOAB(arg1: true, MMNLMLIIDBO(wWW.text, oHBGGLGCLHC));
		}
	}

	public WWW KFEIIDMFOLF(string AKMKNECKCAP, string OHBGGLGCLHC, params string[] IAKLBHKKNFM)
	{
		if (string.IsNullOrEmpty(AKMKNECKCAP))
		{
			throw new Exception("url is null");
		}
		FLFCPGBMGHH fLFCPGBMGHH = new FLFCPGBMGHH();
		for (int i = 0; i < IAKLBHKKNFM.Length; i += 2)
		{
			fLFCPGBMGHH.JOMIJDFIIPG(IAKLBHKKNFM[i], FLFCPGBMGHH.FNIPJFGEFFD(IAKLBHKKNFM[i + 1]));
		}
		string value = ALMGKPDPDCH(fLFCPGBMGHH.GIBKHAGKJHE().PadRight(UnityEngine.Random.Range(0, 20)), OHBGGLGCLHC);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("aesIv", OHBGGLGCLHC);
		wWWForm.AddField("aesData", value);
		MonoBehaviour.print(AKMKNECKCAP);
		return new WWW(AKMKNECKCAP, wWWForm);
	}
}
