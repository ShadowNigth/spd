using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SPD.UpdaterDownloader;

public class UpdaterDownloader : IDisposable
{
	private struct FileAndSaveURL
	{
		public string fileURL;

		public string savePath;

		public object userToken;
	}

	public delegate void DownloadProgressChangedEventHandler(object sender, DownloadProgress progress);

	public class DownloadProgress
	{
		public long downloadedBytes;

		public long totalBytes;

		public object UserState;

		public int progress
		{
			get
			{
				if (totalBytes > 0)
				{
					return (int)((double)downloadedBytes / (double)totalBytes * 100.0);
				}
				return 0;
			}
		}
	}

	private class CookieAwareWebClient : WebClient
	{
		private class CookieContainer
		{
			private readonly Dictionary<string, string> cookies = new Dictionary<string, string>();

			public string this[Uri address]
			{
				get
				{
					if (cookies.TryGetValue(address.Host, out var value))
					{
						return value;
					}
					return null;
				}
				set
				{
					cookies[address.Host] = value;
				}
			}
		}

		private readonly CookieContainer cookies = new CookieContainer();

		public DownloadProgress ContentRangeTarget;

		protected override WebRequest GetWebRequest(Uri address)
		{
			WebRequest webRequest = base.GetWebRequest(address);
			if (webRequest is HttpWebRequest)
			{
				string text = cookies[address];
				if (text != null)
				{
					((HttpWebRequest)webRequest).Headers.Set("cookie", text);
				}
				if (ContentRangeTarget != null)
				{
					((HttpWebRequest)webRequest).AddRange(0);
				}
			}
			return webRequest;
		}

		protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			return ProcessResponse(base.GetWebResponse(request, result));
		}

		protected override WebResponse GetWebResponse(WebRequest request)
		{
			return ProcessResponse(base.GetWebResponse(request));
		}

		private WebResponse ProcessResponse(WebResponse response)
		{
			string[] values = response.Headers.GetValues("Set-Cookie");
			if (values != null && values.Length != 0)
			{
				int num = 0;
				for (int i = 0; i < values.Length; i++)
				{
					num += values[i].Length;
				}
				StringBuilder stringBuilder = new StringBuilder(num);
				for (int j = 0; j < values.Length; j++)
				{
					stringBuilder.Append(values[j]);
				}
				cookies[response.ResponseUri] = stringBuilder.ToString();
			}
			if (ContentRangeTarget != null)
			{
				string[] values2 = response.Headers.GetValues("Content-Range");
				if (values2 != null && values2.Length != 0)
				{
					int num2 = values2[0].LastIndexOf('/');
					if (num2 >= 0 && num2 < values2[0].Length - 1 && long.TryParse(values2[0].Substring(num2 + 1), out var result))
					{
						ContentRangeTarget.totalBytes = result;
					}
				}
			}
			return response;
		}
	}

	private const string GOOGLE_DRIVE_DOMAIN = "drive.google.com";

	private const string GOOGLE_DRIVE_DOMAIN2 = "https://drive.google.com";

	private List<FileAndSaveURL> downloadQueue = new List<FileAndSaveURL>();

	private const int GOOGLE_DRIVE_MAX_DOWNLOAD_ATTEMPT = 3;

	private readonly CookieAwareWebClient webClient;

	private readonly DownloadProgress downloadProgress;

	private Uri downloadAddress;

	private string downloadPath;

	private bool asyncDownload;

	private object userToken;

	private bool downloadingDriveFile;

	private int driveDownloadAttempt;

	public bool isBusy => webClient.IsBusy;

	public int ItemsInQueue
	{
		get
		{
			if (downloadQueue != null)
			{
				return downloadQueue.Count;
			}
			return 0;
		}
	}

	public event DownloadProgressChangedEventHandler onProgress;

	public event AsyncCompletedEventHandler onComplete;

	public UpdaterDownloader()
	{
		webClient = new CookieAwareWebClient();
		webClient.DownloadProgressChanged += OnDownloadProgress;
		webClient.DownloadFileCompleted += OnDownloadComplete;
		downloadProgress = new DownloadProgress();
		ServicePointManager.ServerCertificateValidationCallback = TrustCertificate;
	}

	private static bool TrustCertificate(object sender, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	public void DownloadFile(string address, string fileName)
	{
		DownloadFile(address, fileName, asyncDownload: false, null);
	}

	public void DownloadFileAsync(string address, string fileName, object userToken = null)
	{
		if (!downloadQueue.Any((FileAndSaveURL a) => a.fileURL == address))
		{
			downloadQueue.Add(new FileAndSaveURL
			{
				fileURL = address,
				savePath = fileName,
				userToken = userToken
			});
		}
		DownloadFile(address, fileName, asyncDownload: true, userToken);
	}

	private void DownloadFile(string address, string fileName, bool asyncDownload, object userToken)
	{
		if (!isBusy)
		{
			downloadingDriveFile = address.StartsWith("drive.google.com") || address.StartsWith("https://drive.google.com");
			if (downloadingDriveFile)
			{
				address = GetGoogleDriveDownloadAddress(address);
				driveDownloadAttempt = 1;
				webClient.ContentRangeTarget = downloadProgress;
			}
			else
			{
				webClient.ContentRangeTarget = null;
			}
			downloadAddress = new Uri(address);
			downloadPath = fileName;
			downloadProgress.totalBytes = -1L;
			downloadProgress.UserState = userToken;
			this.asyncDownload = asyncDownload;
			this.userToken = userToken;
			DownloadFileInternal();
		}
	}

	private void DownloadFileInternal()
	{
		if (!asyncDownload)
		{
			webClient.DownloadFile(downloadAddress, downloadPath);
			OnDownloadComplete(webClient, new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else if (userToken == null)
		{
			webClient.DownloadFileAsync(downloadAddress, downloadPath);
		}
		else
		{
			webClient.DownloadFileAsync(downloadAddress, downloadPath, userToken);
		}
	}

	private void OnDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
	{
		if (this.onProgress != null)
		{
			downloadProgress.downloadedBytes = e.BytesReceived;
			if (e.TotalBytesToReceive > 0)
			{
				downloadProgress.totalBytes = e.TotalBytesToReceive;
			}
			this.onProgress(this, downloadProgress);
		}
	}

	private void OnDownloadComplete(object sender, AsyncCompletedEventArgs e)
	{
		if (!downloadingDriveFile)
		{
			if (this.onComplete != null)
			{
				this.onComplete(this, e);
				if (downloadQueue.Count > 0)
				{
					downloadQueue.RemoveAt(0);
					downloadQueue.TrimExcess();
					if (downloadQueue.Count > 0)
					{
						DownloadFileAsync(downloadQueue[0].fileURL, downloadQueue[0].savePath);
					}
				}
			}
		}
		else if (driveDownloadAttempt < 3 && !ProcessDriveDownload())
		{
			driveDownloadAttempt++;
			DownloadFileInternal();
		}
		else if (this.onComplete != null)
		{
			this.onComplete(this, e);
			if (downloadQueue.Count > 0)
			{
				downloadQueue.RemoveAt(0);
				downloadQueue.TrimExcess();
				if (downloadQueue.Count > 0)
				{
					DownloadFileAsync(downloadQueue[0].fileURL, downloadQueue[0].savePath);
				}
			}
		}
		if (downloadQueue.Count <= 0)
		{
			Dispose();
		}
	}

	private bool ProcessDriveDownload()
	{
		FileInfo fileInfo = new FileInfo(downloadPath);
		if (fileInfo == null)
		{
			return true;
		}
		if (fileInfo.Length > 60000)
		{
			return true;
		}
		string text;
		using (StreamReader streamReader = fileInfo.OpenText())
		{
			char[] array = new char[20];
			int num = streamReader.ReadBlock(array, 0, 20);
			if (num < 20 || !new string(array).Contains("<!DOCTYPE html>"))
			{
				return true;
			}
			text = streamReader.ReadToEnd();
		}
		int num2 = text.LastIndexOf("href=\"/uc?");
		if (num2 < 0)
		{
			return true;
		}
		num2 += 6;
		int num3 = text.IndexOf('"', num2);
		if (num3 < 0)
		{
			return true;
		}
		downloadAddress = new Uri("https://drive.google.com" + text.Substring(num2, num3 - num2).Replace("&amp;", "&"));
		return false;
	}

	private string GetGoogleDriveDownloadAddress(string address)
	{
		int num = address.IndexOf("id=");
		int num2;
		if (num > 0)
		{
			num += 3;
			num2 = address.IndexOf('&', num);
			if (num2 < 0)
			{
				num2 = address.Length;
			}
		}
		else
		{
			num = address.IndexOf("file/d/");
			if (num < 0)
			{
				return string.Empty;
			}
			num += 7;
			num2 = address.IndexOf('/', num);
			if (num2 < 0)
			{
				num2 = address.IndexOf('?', num);
				if (num2 < 0)
				{
					num2 = address.Length;
				}
			}
		}
		return "https://drive.google.com/uc?id=" + address.Substring(num, num2 - num) + "&authUser=0&export=download";
	}

	public void Dispose()
	{
		webClient.Dispose();
		downloadQueue = null;
	}
}
