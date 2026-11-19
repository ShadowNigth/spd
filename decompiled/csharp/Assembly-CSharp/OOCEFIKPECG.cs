using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

public class OOCEFIKPECG
{
	public struct GIEOPJLAGNG
	{
		public byte[] BKOEGJJBGBC;

		public int ELGIKGAIIOD;

		public GIEOPJLAGNG(byte[] BKOEGJJBGBC, int ELGIKGAIIOD)
		{
			this.ELGIKGAIIOD = ELGIKGAIIOD;
			this.BKOEGJJBGBC = BKOEGJJBGBC;
		}
	}

	[CompilerGenerated]
	private sealed class IHHFJBFJKHI
	{
		internal List<byte[]> NLIELJKPBAI;

		internal OOCEFIKPECG KPHCHDHEKGH;

		internal void BEKJDJFLJJC()
		{
			if (KPHCHDHEKGH.NHPHEOHKACM[0] != 10)
			{
				KPHCHDHEKGH.IOELOKNDNDG(SocketError.MessageSize);
				Debug.LogError("Streaming error");
			}
			KPHCHDHEKGH.NHPHEOHKACM = new byte[4];
			KPHCHDHEKGH.MEMMCMIHGKP = 1;
		}

		internal void PMBKBKJIIPO()
		{
			int num = BitConverter.ToInt32(KPHCHDHEKGH.NHPHEOHKACM, 0);
			KIEPAHADFFJ.BGNMJEJMGJK = Math.Max(KIEPAHADFFJ.BGNMJEJMGJK, num);
			KPHCHDHEKGH.NHPHEOHKACM = new byte[num];
			KPHCHDHEKGH.MEMMCMIHGKP = 2;
		}

		internal void MBNLIBIAFEF()
		{
			NLIELJKPBAI.Add(KPHCHDHEKGH.NHPHEOHKACM);
			KPHCHDHEKGH.NHPHEOHKACM = new byte[1];
			KPHCHDHEKGH.MEMMCMIHGKP = 0;
		}
	}

	[CompilerGenerated]
	private sealed class NFFEKDIKJAK
	{
		internal OHMGCMOBAGN NKMIHFIEOHD;

		internal object[] KEHPPPLGADG;

		internal void BEKJDJFLJJC(BinaryWriter AEMBPMJMOAB)
		{
			AEMBPMJMOAB.Write(ILDJBFMFMIA[(int)NKMIHFIEOHD]);
			object[] kEHPPPLGADG = KEHPPPLGADG;
			foreach (object obj in kEHPPPLGADG)
			{
				if (obj is string)
				{
					AEMBPMJMOAB.Write((string)obj);
				}
				else if (obj is int)
				{
					AEMBPMJMOAB.Write((int)obj);
				}
				else if (obj is bool)
				{
					AEMBPMJMOAB.Write((bool)obj);
				}
				else if (obj is byte[])
				{
					AEMBPMJMOAB.Write((byte[])obj);
				}
				else
				{
					AEMBPMJMOAB.KLPPJEDJOAI(obj);
				}
			}
		}
	}

	public Socket HJIGBBJIIMJ;

	private string KFOCEMMFACC;

	private string DPNDLAKNJII;

	private bool MIMGPJANEDE;

	public string ECPLKFHCHEB;

	public HJDCCPPLGEP MHPEFIINPHJ;

	private int MEMMCMIHGKP;

	public Action JCFECCHPOJN;

	public Action PECHEKLIDBI;

	public bool OEDJLBLICFF;

	public SocketError JBBAPHBEMJH;

	private byte[] NHPHEOHKACM = new byte[1];

	private int PDPDBHDDILC;

	private Queue<GIEOPJLAGNG> GPOOBDJJKMO = new Queue<GIEOPJLAGNG>();

	private static string[] ILDJBFMFMIA;

	public string DIKCJLJDJPD
	{
		get
		{
			if (KFOCEMMFACC != null)
			{
				return KFOCEMMFACC;
			}
			if (HJIGBBJIIMJ == null || !HJIGBBJIIMJ.Connected)
			{
				return string.Empty;
			}
			IPEndPoint iPEndPoint = (IPEndPoint)HJIGBBJIIMJ.LocalEndPoint;
			return KFOCEMMFACC = iPEndPoint.Address.ToString();
		}
	}

	public string DMOPBDCODGL => ((IPEndPoint)HJIGBBJIIMJ.RemoteEndPoint).Address.ToString();

	public string HEDBHNLHPHN => DPNDLAKNJII ?? (DPNDLAKNJII = ((IPEndPoint)HJIGBBJIIMJ.RemoteEndPoint).Address.ToString() + ((IPEndPoint)HJIGBBJIIMJ.RemoteEndPoint).Port);

	public bool IHCCAJJIBEL => HJIGBBJIIMJ != null && HJIGBBJIIMJ.Connected;

	private string KIOIFJNJAMC => "logs/" + HEDBHNLHPHN + ".txt";

	public string CCNNKLHAGMA
	{
		get
		{
			if (!File.Exists(KIOIFJNJAMC))
			{
				return null;
			}
			using StreamReader streamReader = new StreamReader(File.OpenRead(KIOIFJNJAMC));
			return streamReader.ReadToEnd();
		}
	}

	public OOCEFIKPECG()
	{
		ILDJBFMFMIA = Enum.GetNames(typeof(OHMGCMOBAGN));
		KIEPAHADFFJ.BLIAFECFMEI++;
	}

	public override string ToString()
	{
		return (HJIGBBJIIMJ == null || !HJIGBBJIIMJ.Connected) ? "offline" : DMOPBDCODGL;
	}

	public void JMLAEOGOGDP()
	{
		HJIGBBJIIMJ.Blocking = false;
		if (MIMGPJANEDE)
		{
			throw new Exception("Reconnect not supported!");
		}
		MIMGPJANEDE = true;
	}

	public OOCEFIKPECG EFMFNHMEKAG(int LKCFBEGAGCM, string NBIDLIGPBCK)
	{
		return EFMFNHMEKAG(LKCFBEGAGCM, null, NBIDLIGPBCK);
	}

	public OOCEFIKPECG EFMFNHMEKAG(int LKCFBEGAGCM, AsyncCallback HFODCIPAAFJ, string NBIDLIGPBCK)
	{
		FOGIOGKLNIP.LIJNLAAEENC("MySender3 - Connect()");
		IOELOKNDNDG();
		TcpClient tcpClient = new TcpClient();
		HJIGBBJIIMJ = tcpClient.Client;
		ECPLKFHCHEB = NBIDLIGPBCK;
		tcpClient.BeginConnect(NBIDLIGPBCK, LKCFBEGAGCM, HFODCIPAAFJ ?? new AsyncCallback(GAOGNOFLIIL), this);
		JMLAEOGOGDP();
		MHPEFIINPHJ = HJDCCPPLGEP.EAOOBJCIKBN;
		return this;
	}

	private void GAOGNOFLIIL(IAsyncResult ECAGONEFPCC)
	{
		try
		{
			HJIGBBJIIMJ.EndConnect(ECAGONEFPCC);
		}
		catch (Exception lGNIFJCEECH)
		{
			MOHMCMAMDAL(lGNIFJCEECH);
		}
	}

	public static void MOHMCMAMDAL(object LGNIFJCEECH)
	{
	}

	public List<byte[]> GCHPMCEIEMK()
	{
		if (MHPEFIINPHJ != HJDCCPPLGEP.IHCCAJJIBEL && IHCCAJJIBEL)
		{
			MHPEFIINPHJ = HJDCCPPLGEP.IHCCAJJIBEL;
			if (JCFECCHPOJN != null)
			{
				JCFECCHPOJN();
			}
		}
		if (MHPEFIINPHJ == HJDCCPPLGEP.IHCCAJJIBEL && !IHCCAJJIBEL)
		{
			MHPEFIINPHJ = HJDCCPPLGEP.ADMKOFIIJHN;
			if (PECHEKLIDBI != null)
			{
				PECHEKLIDBI();
			}
		}
		MLPPEPCOCHJ();
		if (!IHCCAJJIBEL || HJIGBBJIIMJ.Available == 0)
		{
			return null;
		}
		List<byte[]> NLIELJKPBAI = new List<byte[]>();
		while (HJIGBBJIIMJ.Connected && HJIGBBJIIMJ.Available != 0)
		{
			if (MEMMCMIHGKP == 0)
			{
				LNLEOBEBCLD(delegate
				{
					if (NHPHEOHKACM[0] != 10)
					{
						IOELOKNDNDG(SocketError.MessageSize);
						Debug.LogError("Streaming error");
					}
					NHPHEOHKACM = new byte[4];
					MEMMCMIHGKP = 1;
				});
			}
			if (MEMMCMIHGKP == 1 && HJIGBBJIIMJ.Connected)
			{
				LNLEOBEBCLD(delegate
				{
					int num = BitConverter.ToInt32(NHPHEOHKACM, 0);
					KIEPAHADFFJ.BGNMJEJMGJK = Math.Max(KIEPAHADFFJ.BGNMJEJMGJK, num);
					NHPHEOHKACM = new byte[num];
					MEMMCMIHGKP = 2;
				});
			}
			if (MEMMCMIHGKP == 2 && HJIGBBJIIMJ.Connected)
			{
				LNLEOBEBCLD(delegate
				{
					NLIELJKPBAI.Add(NHPHEOHKACM);
					NHPHEOHKACM = new byte[1];
					MEMMCMIHGKP = 0;
				});
			}
		}
		if (OEDJLBLICFF)
		{
			foreach (byte[] item in NLIELJKPBAI)
			{
				AMIIEKMGODF(">>>" + NLIJBAPHOBH(item));
			}
		}
		return (!HJIGBBJIIMJ.Connected) ? null : NLIELJKPBAI;
	}

	private static string NLIJBAPHOBH(byte[] JEAOIHGEOOF)
	{
		return Regex.Replace(Encoding.ASCII.GetString(JEAOIHGEOOF), "[^\\w]", "?") + "\r\n";
	}

	private void AMIIEKMGODF(string LGNIFJCEECH)
	{
	}

	private void LNLEOBEBCLD(Action PJGEOHMAFDH)
	{
		int num = HJIGBBJIIMJ.Receive(NHPHEOHKACM, PDPDBHDDILC, NHPHEOHKACM.Length - PDPDBHDDILC, SocketFlags.None, out JBBAPHBEMJH);
		if (IHCCAJJIBEL && JBBAPHBEMJH != 0 && JBBAPHBEMJH != SocketError.WouldBlock)
		{
			Debug.LogError("Receive error " + JBBAPHBEMJH);
		}
		PDPDBHDDILC += num;
		if (PDPDBHDDILC == NHPHEOHKACM.Length)
		{
			PDPDBHDDILC = 0;
			PJGEOHMAFDH();
		}
	}

	public void JFBMPGBNBCF(byte[] JEAOIHGEOOF)
	{
		if (IHCCAJJIBEL)
		{
			if (OEDJLBLICFF)
			{
				AMIIEKMGODF("<<<" + NLIJBAPHOBH(JEAOIHGEOOF));
			}
			GPOOBDJJKMO.Enqueue(new GIEOPJLAGNG(JEAOIHGEOOF, 0));
			KIEPAHADFFJ.MFBGAIGNJHD = Math.Max(KIEPAHADFFJ.MFBGAIGNJHD, GPOOBDJJKMO.Count);
			MLPPEPCOCHJ();
		}
	}

	public void MLPPEPCOCHJ()
	{
		if (!IHCCAJJIBEL)
		{
			return;
		}
		JBBAPHBEMJH = SocketError.Success;
		if (GPOOBDJJKMO.Count > 150)
		{
		}
		while (JBBAPHBEMJH == SocketError.Success && GPOOBDJJKMO.Count > 0)
		{
			GIEOPJLAGNG gIEOPJLAGNG = GPOOBDJJKMO.Peek();
			gIEOPJLAGNG.ELGIKGAIIOD += HJIGBBJIIMJ.Send(gIEOPJLAGNG.BKOEGJJBGBC, gIEOPJLAGNG.ELGIKGAIIOD, gIEOPJLAGNG.BKOEGJJBGBC.Length - gIEOPJLAGNG.ELGIKGAIIOD, SocketFlags.None, out JBBAPHBEMJH);
			if (gIEOPJLAGNG.ELGIKGAIIOD == gIEOPJLAGNG.BKOEGJJBGBC.Length)
			{
				GPOOBDJJKMO.Dequeue();
			}
			if (IHCCAJJIBEL && JBBAPHBEMJH != 0 && JBBAPHBEMJH != SocketError.WouldBlock)
			{
				Debug.LogError("send error " + JBBAPHBEMJH);
			}
		}
	}

	public static byte[] DMEAJPICMNP(Action<BinaryWriter> AEMBPMJMOAB)
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		AEMBPMJMOAB(binaryWriter);
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		byte[] array = new byte[5 + memoryStream.Length];
		array[0] = 10;
		Buffer.BlockCopy(BitConverter.GetBytes((int)memoryStream.Length), 0, array, 1, 4);
		memoryStream.Read(array, 5, (int)memoryStream.Length);
		return array;
	}

	public static byte[] DMEAJPICMNP(OHMGCMOBAGN NKMIHFIEOHD, params object[] KEHPPPLGADG)
	{
		return DMEAJPICMNP(delegate(BinaryWriter AEMBPMJMOAB)
		{
			AEMBPMJMOAB.Write(ILDJBFMFMIA[(int)NKMIHFIEOHD]);
			object[] array = KEHPPPLGADG;
			foreach (object obj in array)
			{
				if (obj is string)
				{
					AEMBPMJMOAB.Write((string)obj);
				}
				else if (obj is int)
				{
					AEMBPMJMOAB.Write((int)obj);
				}
				else if (obj is bool)
				{
					AEMBPMJMOAB.Write((bool)obj);
				}
				else if (obj is byte[])
				{
					AEMBPMJMOAB.Write((byte[])obj);
				}
				else
				{
					AEMBPMJMOAB.KLPPJEDJOAI(obj);
				}
			}
		});
	}

	public void IOELOKNDNDG(SocketError KEJDNJLHKAM = SocketError.Disconnecting)
	{
		if (HJIGBBJIIMJ != null)
		{
			HJIGBBJIIMJ.Close();
		}
		JBBAPHBEMJH = KEJDNJLHKAM;
		GPOOBDJJKMO.Clear();
	}

	~OOCEFIKPECG()
	{
		KIEPAHADFFJ.BLIAFECFMEI--;
	}
}
