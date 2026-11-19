using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class MONLDPMKIFB : FOGIOGKLNIP
{
	private sealed class GCOOHJGKONG : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal string OIPLFIJLPJK;

		internal string AKMKNECKCAP;

		internal string[] IAKLBHKKNFM;

		internal WWW JMHINFPKDAO;

		internal Action<bool, string> AEMBPMJMOAB;

		internal MONLDPMKIFB KPHCHDHEKGH;

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
		public GCOOHJGKONG()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				OIPLFIJLPJK = KPHCHDHEKGH.BGPILDHIGCM();
				JMHINFPKDAO = KPHCHDHEKGH.KFEIIDMFOLF(AKMKNECKCAP, OIPLFIJLPJK, IAKLBHKKNFM);
				HLJEEFIJCOF = JMHINFPKDAO;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				if (string.IsNullOrEmpty(JMHINFPKDAO.error))
				{
					AEMBPMJMOAB(false, JMHINFPKDAO.error);
				}
				else
				{
					AEMBPMJMOAB(true, KPHCHDHEKGH.MMNLMLIIDBO(JMHINFPKDAO.text, OIPLFIJLPJK));
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

	[DebuggerHidden]
	public IEnumerator KFEIIDMFOLF(string AKMKNECKCAP, Action<bool, string> AEMBPMJMOAB, params string[] IAKLBHKKNFM)
	{
		GCOOHJGKONG gCOOHJGKONG = new GCOOHJGKONG();
		gCOOHJGKONG.AKMKNECKCAP = AKMKNECKCAP;
		gCOOHJGKONG.IAKLBHKKNFM = IAKLBHKKNFM;
		gCOOHJGKONG.AEMBPMJMOAB = AEMBPMJMOAB;
		gCOOHJGKONG.KPHCHDHEKGH = this;
		return gCOOHJGKONG;
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
