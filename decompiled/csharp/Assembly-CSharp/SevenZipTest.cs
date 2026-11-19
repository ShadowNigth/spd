using System;
using System.Collections;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;

public class SevenZipTest : MonoBehaviour
{
	private int lzres;

	private int lzres4;

	private int lzres2;

	private int lzres3;

	private bool pass1;

	private bool pass2;

	private float t1;

	private float t;

	private string myFile = "test.7z";

	private string uri = "http://telias.free.fr/tests/";

	private string ppath;

	private string saPath;

	private string log;

	private bool compressionStarted;

	private bool downloadDone;

	private long tsize;

	private byte[] buff;

	private byte[] fixedInBuffer = new byte[262144];

	private byte[] fixedOutBuffer = new byte[262144];

	private Thread th;

	private int[] progress = new int[1];

	private void Start()
	{
		ppath = Application.persistentDataPath;
		lzma.persitentDataPath = Application.persistentDataPath;
		saPath = "jar:file://" + Application.dataPath + "!/assets/";
		buff = new byte[0];
		Debug.Log(ppath);
		Screen.sleepTimeout = -1;
		if (!File.Exists(ppath + "/" + myFile))
		{
			StartCoroutine(Download7ZFile());
		}
		else
		{
			downloadDone = true;
		}
		StartCoroutine(buff2buffTest());
		getFromStreamingAssets("test2.7z", "t2.7z");
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	private void OnGUI()
	{
		if (downloadDone)
		{
			GUI.Label(new Rect(50f, 0f, 350f, 30f), "package downloaded, ready to extract");
			GUI.Label(new Rect(50f, 30f, 450f, 40f), ppath);
			if (th != null)
			{
				GUI.Label(new Rect(Screen.width - 90, 10f, 90f, 50f), progress[0].ToString());
			}
			GUI.Label(new Rect(50f, 70f, 400f, 30f), "decompress Buffer: " + pass1);
			GUI.TextArea(new Rect(50f, 290f, 640f, 140f), tsize + "\n" + log);
			GUI.Label(new Rect(50f, 100f, 400f, 30f), "compress Buffer  : " + pass2);
			if (GUI.Button(new Rect(50f, 150f, 250f, 50f), "start 7z test"))
			{
				if (File.Exists(ppath + "/1.txt"))
				{
					File.Delete(ppath + "/1.txt");
				}
				if (File.Exists(ppath + "/2.txt"))
				{
					File.Delete(ppath + "/2.txt");
				}
				log = string.Empty;
				compressionStarted = true;
				DoDecompression();
			}
			if (GUI.Button(new Rect(320f, 150f, 250f, 50f), "File Buffer test"))
			{
				doFileBufferTest();
			}
		}
		if (compressionStarted)
		{
			GUI.Label(new Rect(50f, 210f, 250f, 40f), "7z return code: " + lzres);
			GUI.Label(new Rect(50f, 250f, 250f, 50f), "time: " + t1);
			if (lzres2 != 0)
			{
				GUI.Label(new Rect(50f, 450f, 250f, 30f), "lzma encoded " + lzres2);
			}
			if (lzres3 != 0)
			{
				GUI.Label(new Rect(50f, 480f, 250f, 30f), "lzma decoded " + lzres3);
			}
			if (lzres4 > 0)
			{
				GUI.Label(new Rect(50f, 510f, 250f, 30f), "decoded to buffer: ok");
			}
		}
	}

	private void DoDecompression()
	{
		t = Time.realtimeSinceStartup;
		lzres = lzma.doDecompress7zip(ppath + "/" + myFile, ppath + "/", largeFiles: true);
		tsize = lzma.get7zInfo(ppath + "/" + myFile);
		Debug.Log("Total Size: " + tsize + "      trueTotalFiles: " + lzma.trueTotalFiles);
		if (lzma.ninfo != null)
		{
			for (int i = 0; i < lzma.ninfo.Count; i++)
			{
				string text = log;
				log = text + lzma.ninfo[i] + " - " + lzma.sinfo[i] + "\n";
			}
		}
		Debug.Log("--->" + lzma.get7zSize(ppath + "/" + myFile, "1.txt"));
		lzma.setProps(9);
		lzma.setProps(9, 65536);
		lzres2 = lzma.LzmaUtilEncode(ppath + "/1.txt", ppath + "/1.txt.lzma");
		lzres3 = lzma.LzmaUtilDecode(ppath + "/1.txt.lzma", ppath + "/1BCD.txt");
		byte[] array = lzma.decode2Buffer(ppath + "/" + myFile, "1.txt");
		if (array != null)
		{
			File.WriteAllBytes(ppath + "/1AAA.txt", array);
			if (array.Length > 0)
			{
				Debug.Log("Decode2Buffer: " + array.Length);
				lzres4 = 1;
			}
		}
		th = new Thread(Decompress);
		th.Start();
		t1 = Time.realtimeSinceStartup - t;
	}

	private void Decompress()
	{
		lzres = lzma.doDecompress7zip(ppath + "/" + myFile, ppath + "/", progress, largeFiles: true);
		compressionStarted = true;
	}

	private void getFromStreamingAssets(string file, string outFile)
	{
		string url = saPath + file;
		WWW wWW = new WWW(url);
		while (!wWW.isDone)
		{
		}
		if (wWW.error == null)
		{
			int num = lzma.doDecompress7zip(null, ppath + "/", largeFiles: false, fullPaths: true, "5.txt", wWW.bytes);
			log = log + "decompress from Streaming Assets: " + num + "\n";
			wWW.Dispose();
			wWW = null;
		}
		else
		{
			Debug.Log("error reading from Streaming Assets");
		}
	}

	private void doFileBufferTest()
	{
		if (!File.Exists(ppath + "/" + myFile))
		{
			return;
		}
		byte[] fileBuffer = File.ReadAllBytes(ppath + "/" + myFile);
		log = string.Empty;
		lzres = lzma.doDecompress7zip(null, ppath + "/", largeFiles: true, fullPaths: true, null, fileBuffer);
		log = log + lzres + " | ";
		lzres = lzma.doDecompress7zip(null, ppath + "/", progress, largeFiles: false, fullPaths: true, null, fileBuffer);
		string text = log;
		log = text + lzres + " - prg: " + progress[0].ToString() + " | ";
		tsize = lzma.get7zInfo(null, null, fileBuffer);
		text = log;
		log = text + "tsiz: " + tsize + " #files: " + lzma.trueTotalFiles + " | ";
		tsize = lzma.get7zSize(null, null, null, fileBuffer);
		log = log + "tsiz: " + tsize + " | ";
		byte[] array = lzma.decode2Buffer(null, "2.txt", null, fileBuffer);
		if (array != null)
		{
			log += "dec2buffer: ok\n";
			File.WriteAllBytes(ppath + "/2AAA_FILEBUFFER.txt", array);
			if (array.Length > 0)
			{
				Debug.Log("FileBuffer_Decode2Buffer: " + array.Length);
			}
		}
	}

	private IEnumerator Download7ZFile()
	{
		if (File.Exists(ppath + "/" + myFile))
		{
			File.Delete(ppath + "/" + myFile);
		}
		Debug.Log("starting download");
		using UnityWebRequest www = UnityWebRequest.Get(uri + myFile);
		yield return www.SendWebRequest();
		if (www.error != null)
		{
			Debug.Log(www.error);
			yield break;
		}
		downloadDone = true;
		log = string.Empty;
		File.WriteAllBytes(ppath + "/" + myFile, www.downloadHandler.data);
		Debug.Log("download done");
	}

	private IEnumerator buff2buffTest()
	{
		using (UnityWebRequest w = UnityWebRequest.Get("http://telias.free.fr/tests/google.jpg.lzma"))
		{
			yield return w.SendWebRequest();
			if (w.error == null)
			{
				if (lzma.decompressBuffer(w.downloadHandler.data, ref buff) == 0)
				{
					pass1 = true;
					File.WriteAllBytes(ppath + "/google.jpg", buff);
				}
				else
				{
					Debug.Log("Error decompressing www.bytes to buffer");
					pass1 = false;
				}
			}
			else
			{
				Debug.Log(w.error);
			}
		}
		if (!File.Exists(ppath + "/google.jpg"))
		{
			yield break;
		}
		byte[] inBuffer = File.ReadAllBytes(ppath + "/google.jpg");
		if (lzma.compressBuffer(inBuffer, ref buff))
		{
			pass2 = true;
			File.WriteAllBytes(ppath + "/google.jpg.lzma", buff);
			Debug.Log("uncompressed size in lzma: " + BitConverter.ToUInt64(buff, 5));
			Debug.Log("lzma size: " + buff.Length);
		}
		else
		{
			pass2 = false;
			Debug.Log("could not compress to buffer ...");
		}
		int num = lzma.compressBufferFixed(inBuffer, ref fixedInBuffer);
		Debug.Log(" #-> Compress Fixed size Buffer: " + num);
		if (num > 0)
		{
			int num2 = lzma.decompressBufferFixed(fixedInBuffer, ref fixedOutBuffer);
			if (num2 > 0)
			{
				Debug.Log(" #-> Decompress Fixed size Buffer: " + num2);
			}
		}
	}
}
