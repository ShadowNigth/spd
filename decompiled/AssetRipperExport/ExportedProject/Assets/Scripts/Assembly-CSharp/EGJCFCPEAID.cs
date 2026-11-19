using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using UnityEngine;

public class EGJCFCPEAID
{
	private class JFKJKFBLGHJ
	{
		public string DAJGJBCJKEI;

		public string BFDKLIPADEE;

		public bool DEMDMBKNONK;

		public Matrix4x4 KBNFHAGPIMA;

		public Quaternion FMNJPJMEGPD;

		public List<NDGBHOIDHMD> HDJMJCGIJNM;

		public JFKJKFBLGHJ()
		{
			HDJMJCGIJNM = new List<NDGBHOIDHMD>();
		}
	}

	private class NDGBHOIDHMD
	{
		public string JFLBOOBFAEF;

		public string CDJEPFAMNLF;
	}

	public class PELJCFMBKIG
	{
		public string LBKJBLPJPBC;

		public Vector3 ELGIKGAIIOD;

		public Quaternion KHGAOLHJCMO;

		public Vector3 PFOFPDDMMKA;

		public bool DCMHKMLHNFG;

		public string DAJGJBCJKEI;

		public string IMAJDOIBBLK;
	}

	private class FNPNCMHPBAK
	{
		public string IAFKGHCCHIG;

		public string IFMDCGLFHOM;
	}

	private class CFGPAKOCHHJ
	{
		public string JFLBOOBFAEF;

		public string NGIHJKGIKNA;
	}

	private class ICAPCLEDDLL
	{
		public string IAFKGHCCHIG;

		public string ALLLIGGPLMK;

		public Color OLGLLNJFGJJ;

		public Color BPNKJHEDAPP;

		public Color GNFKLBBCDGD = new Color(0f, 0f, 0f, 1f);

		public Color CNGBEKDDPIG;

		public Color CEICFBDBFAJ = new Color(1f, 1f, 1f, 1f);

		public float IMFEDNDHMNM = 2f;

		public float KKEJOJDFLFN = 1f;

		public string FJMJOFOIOBL;

		public string HCKKDACJPAD;

		public string DHNKIPPOHEM;

		public string IDFDCGHNIBK;

		public Texture2D KFHILAEFMNG;

		public string PBKPINAHBHK;
	}

	private sealed class CPNMIIHHGOP
	{
		internal JFKJKFBLGHJ EINKGBPHLLE;

		internal bool BEKJDJFLJJC(JFKJKFBLGHJ JLOFICCFAPA)
		{
			return JLOFICCFAPA.BFDKLIPADEE == EINKGBPHLLE.BFDKLIPADEE;
		}
	}

	private sealed class GFCEOGLODIP
	{
		internal GameObject JNAJLLGPHFB;

		internal bool BEKJDJFLJJC(JFKJKFBLGHJ JLOFICCFAPA)
		{
			return JLOFICCFAPA.BFDKLIPADEE == JNAJLLGPHFB.name;
		}
	}

	private sealed class IEGJIDBGIBG
	{
		internal GameObject BIMHAGOKNME;

		internal bool BEKJDJFLJJC(PELJCFMBKIG JLOFICCFAPA)
		{
			return JLOFICCFAPA.LBKJBLPJPBC == BIMHAGOKNME.name;
		}
	}

	public bool PAKMHHLILHG;

	public bool GANMHBCOOPI;

	public GameObject ICIEDCMDJFO;

	private bool PMGDCOLPLNE;

	private float BANENAOAMCH = 0.03f;

	private float AFDBPPKKGFO;

	private float DMOLOABDJPC;

	private float IIAKMEMOMDG;

	private float PEAMJFBCLJD;

	private float BPGIABMDNNH;

	private float NDPKMBKBOLM;

	private float COKOFFOMPND;

	private float PPIMKLECPLL;

	private float FBHFHLLMBAB;

	private float NEDCJHPLJPN;

	private float DJBNOGHFGPF;

	private Vector3 JCBDEOJHLCB = default(Vector3);

	private LMLDOPCJALE JPIKLMIEMPL = new LMLDOPCJALE();

	private XmlDocument JHLBCBBILKI;

	private int EEPCEKKEFFI;

	private int BKMEKJNLELM;

	private int JJODOPGLPGA;

	private int JGFEOBODCBK;

	private int BHPMMMEDAHN;

	private int GNNGLJCIJEF;

	private int FOFMGIBILEP = 1;

	private bool ONIKHHEDCFE;

	private bool LNPLJAGJMPD;

	private bool PEBOEKFIAPG = true;

	private bool JMKNPPLJEGJ;

	private string KOMGKIKAAGJ = string.Empty;

	private int HENDAGGIEDP;

	private List<JFKJKFBLGHJ> IBJIIKKCHNO = new List<JFKJKFBLGHJ>();

	private List<PELJCFMBKIG> EHNDFDJAPCN = new List<PELJCFMBKIG>();

	public Dictionary<string, string> MHJJBFCHHHN = new Dictionary<string, string>();

	private List<CFGPAKOCHHJ> BCIFNDHHBHP;

	private List<ICAPCLEDDLL> EKBIEIMIEOH;

	private CultureInfo BEMLCJNJEPC = new CultureInfo("en-US");

	[CompilerGenerated]
	private static Dictionary<string, int> LAJJJFEJCLD;

	public void DHBGHDFFOLN(string BLEMMFHFJID)
	{
		FINNFIAGEBD(BLEMMFHFJID);
		if (JPIKLMIEMPL.NHDIJIMCOJK(true, false))
		{
			if (JMKNPPLJEGJ)
			{
				CNDPDFENJLL();
			}
			ALPEFFCGFNM();
			JPNAJAPICDM();
		}
		else
		{
			Debug.Log("Too many poly's");
		}
	}

	private void LMJHNCLCJAG()
	{
		if ((XmlElement)JHLBCBBILKI.GetElementsByTagName("up_axis")[0] != null)
		{
			XmlElement xmlElement = (XmlElement)JHLBCBBILKI.GetElementsByTagName("up_axis")[0];
			switch (xmlElement.InnerXml)
			{
			case "X_UP":
				FOFMGIBILEP = 0;
				break;
			case "Y_UP":
				FOFMGIBILEP = 1;
				break;
			case "Z_UP":
				FOFMGIBILEP = 2;
				break;
			}
		}
		else
		{
			FOFMGIBILEP = 1;
		}
	}

	private void FINNFIAGEBD(string AOALLDHHNPK)
	{
		JPIKLMIEMPL = new LMLDOPCJALE();
		JHLBCBBILKI = new XmlDocument();
		JHLBCBBILKI.LoadXml(AOALLDHHNPK);
		LMJHNCLCJAG();
		HFPDBGNKDDN();
		if (JDDHCIPBFMO())
		{
			foreach (XmlNode item in JHLBCBBILKI.GetElementsByTagName("geometry"))
			{
				KOMGKIKAAGJ = string.Empty;
				EEPCEKKEFFI = ((JPIKLMIEMPL.KOGKFEMKGBB.Count > 0) ? JPIKLMIEMPL.KOGKFEMKGBB.Count : 0);
				JJODOPGLPGA = ((JPIKLMIEMPL.LIAPFPOHECF.Count > 0) ? JPIKLMIEMPL.LIAPFPOHECF.Count : 0);
				BKMEKJNLELM = ((JPIKLMIEMPL.FCKMEAFJCJN.Count > 0) ? JPIKLMIEMPL.FCKMEAFJCJN.Count : 0);
				XmlElement xmlElement = item as XmlElement;
				string text = JHGNJGEGANG(xmlElement);
				if (text != "false")
				{
					KOMGKIKAAGJ = xmlElement.Attributes["id"].Value;
					bool flag = false;
					foreach (JFKJKFBLGHJ item2 in IBJIIKKCHNO)
					{
						if (KOMGKIKAAGJ == item2.BFDKLIPADEE)
						{
							flag = true;
						}
					}
					if (flag)
					{
						if (HLKADJBONPE(xmlElement))
						{
							if (!FCGGKFCCEOG(xmlElement, text))
							{
								Debug.Log("Geometry " + xmlElement.Attributes["id"].Value + "has no readable face data");
							}
						}
						else
						{
							Debug.Log("Geometry " + xmlElement.Attributes["id"].Value + " has no readable source data");
						}
					}
				}
			}
			return;
		}
		Debug.Log("Cannot get scene data matching geometry to materials");
	}

	private Vector3 FAFAANKAHNE(Vector3 PDAKFGKELOC)
	{
		Vector3 result = default(Vector3);
		switch (FOFMGIBILEP)
		{
		case 0:
			result = new Vector3(0f - PDAKFGKELOC.y, PDAKFGKELOC.x, 0f - PDAKFGKELOC.z);
			break;
		case 1:
			result = new Vector3(PDAKFGKELOC.x, PDAKFGKELOC.y, 0f - PDAKFGKELOC.z);
			break;
		case 2:
			result = new Vector3(PDAKFGKELOC.x, PDAKFGKELOC.z, PDAKFGKELOC.y);
			break;
		}
		return result;
	}

	private Vector3 MJDKNJJDGJD(Vector3 PDAKFGKELOC)
	{
		Vector3 result = default(Vector3);
		switch (FOFMGIBILEP)
		{
		case 0:
			result = new Vector3(PDAKFGKELOC.y, PDAKFGKELOC.x, PDAKFGKELOC.z);
			break;
		case 1:
			result = new Vector3(PDAKFGKELOC.x, PDAKFGKELOC.y, PDAKFGKELOC.z);
			break;
		case 2:
			result = new Vector3(PDAKFGKELOC.x, PDAKFGKELOC.z, PDAKFGKELOC.y);
			break;
		}
		return result;
	}

	private Vector3 GIKLJJDBJLM(Vector3 PDAKFGKELOC)
	{
		Vector3 result = default(Vector3);
		switch (FOFMGIBILEP)
		{
		case 0:
			result = new Vector3(PDAKFGKELOC.y, 0f - PDAKFGKELOC.x, PDAKFGKELOC.z);
			break;
		case 1:
			result = new Vector3(0f - PDAKFGKELOC.x, 0f - PDAKFGKELOC.y, PDAKFGKELOC.z);
			break;
		case 2:
			result = new Vector3(0f - PDAKFGKELOC.x, 0f - PDAKFGKELOC.z, 0f - PDAKFGKELOC.y);
			break;
		}
		return result;
	}

	private bool JDDHCIPBFMO()
	{
		bool flag = (XmlElement)JHLBCBBILKI.GetElementsByTagName("library_visual_scenes")[0] != null;
		if (flag)
		{
			XmlElement xmlElement = (XmlElement)JHLBCBBILKI.GetElementsByTagName("library_visual_scenes")[0];
			XmlElement xmlElement2 = (XmlElement)xmlElement.GetElementsByTagName("visual_scene")[0];
			XmlNode firstChild = xmlElement2.FirstChild;
			firstChild = xmlElement2.FirstChild;
			int num = 0;
			int num2 = 0;
			List<Vector3> list = new List<Vector3>();
			List<Vector3> list2 = new List<Vector3>();
			List<Quaternion> list3 = new List<Quaternion>();
			List<XmlNode> list4 = new List<XmlNode>();
			list4.Add(firstChild);
			while (num != -1 && firstChild is XmlElement)
			{
				XmlElement xmlElement3 = firstChild as XmlElement;
				if (firstChild.Name == "node")
				{
					PELJCFMBKIG pELJCFMBKIG = new PELJCFMBKIG();
					if (xmlElement3.HasAttribute("id"))
					{
						pELJCFMBKIG.LBKJBLPJPBC = xmlElement3.Attributes["id"].Value;
					}
					else if (xmlElement3.HasAttribute("name"))
					{
						pELJCFMBKIG.LBKJBLPJPBC = xmlElement3.Attributes["name"].Value;
					}
					else
					{
						pELJCFMBKIG.LBKJBLPJPBC = "_spc_offset_" + num2;
						xmlElement3.SetAttribute("id", pELJCFMBKIG.LBKJBLPJPBC);
						num2++;
					}
					Vector3 vector = new Vector3(0f, 0f, 0f);
					Vector3 vector2 = new Vector3(1f, 1f, 1f);
					Quaternion identity = Quaternion.identity;
					if (xmlElement3["translate"] != null || xmlElement3["scale"] != null || xmlElement3["rotate"] != null)
					{
						if (xmlElement3["translate"] != null)
						{
							string text = BHIFDGEDIIG(xmlElement3["translate"].InnerXml);
							string[] array = text.Split(" ".ToCharArray());
							vector = new Vector3(MMCCMMGCKNH(array[0]), MMCCMMGCKNH(array[1]), MMCCMMGCKNH(array[2]));
							vector = FAFAANKAHNE(vector);
						}
						if (xmlElement3["scale"] != null)
						{
							string text2 = BHIFDGEDIIG(xmlElement3["scale"].InnerXml);
							string[] array2 = text2.Split(" ".ToCharArray());
							vector2 = new Vector3(MMCCMMGCKNH(array2[0]), MMCCMMGCKNH(array2[1]), MMCCMMGCKNH(array2[2]));
							vector2 = MJDKNJJDGJD(vector2);
						}
						if (xmlElement3["rotate"] != null)
						{
							XmlNode xmlNode = xmlElement3.FirstChild;
							while (xmlNode != null && xmlNode is XmlElement)
							{
								if (xmlNode.Name == "rotate")
								{
									string text3 = BHIFDGEDIIG(xmlNode.InnerXml);
									string[] array3 = text3.Split(" ".ToCharArray());
									Vector3 pDAKFGKELOC = new Vector3(MMCCMMGCKNH(array3[0]), MMCCMMGCKNH(array3[1]), MMCCMMGCKNH(array3[2]));
									pDAKFGKELOC = GIKLJJDBJLM(pDAKFGKELOC);
									identity *= Quaternion.AngleAxis(MMCCMMGCKNH(array3[3]), pDAKFGKELOC);
								}
								xmlNode = xmlNode.NextSibling;
							}
						}
					}
					pELJCFMBKIG.ELGIKGAIIOD = vector;
					pELJCFMBKIG.PFOFPDDMMKA = vector2;
					pELJCFMBKIG.KHGAOLHJCMO = identity;
					list.Add(vector);
					list2.Add(vector2);
					list3.Add(identity);
					if (firstChild.ParentNode != null)
					{
						XmlElement xmlElement4 = firstChild.ParentNode as XmlElement;
						if (xmlElement4.Name == "node")
						{
							if (xmlElement4.HasAttribute("id"))
							{
								pELJCFMBKIG.DAJGJBCJKEI = xmlElement4.Attributes["id"].Value;
							}
							else if (xmlElement4.HasAttribute("name"))
							{
								pELJCFMBKIG.DAJGJBCJKEI = xmlElement4.Attributes["name"].Value;
							}
						}
					}
					if (xmlElement3["instance_geometry"] != null)
					{
						pELJCFMBKIG.DCMHKMLHNFG = true;
						XmlNode xmlNode2 = xmlElement3.FirstChild;
						while (xmlNode2 != null && xmlNode2 is XmlElement)
						{
							if (xmlNode2.Name == "instance_geometry")
							{
								CPNMIIHHGOP cPNMIIHHGOP = new CPNMIIHHGOP();
								cPNMIIHHGOP.EINKGBPHLLE = new JFKJKFBLGHJ();
								cPNMIIHHGOP.EINKGBPHLLE.BFDKLIPADEE = xmlNode2.Attributes["url"].Value.Replace("#", string.Empty);
								JFKJKFBLGHJ jFKJKFBLGHJ = IBJIIKKCHNO.Find(cPNMIIHHGOP.BEKJDJFLJJC);
								if (jFKJKFBLGHJ != null)
								{
									cPNMIIHHGOP.EINKGBPHLLE.DEMDMBKNONK = true;
								}
								cPNMIIHHGOP.EINKGBPHLLE.DAJGJBCJKEI = pELJCFMBKIG.LBKJBLPJPBC;
								XmlElement xmlElement5 = xmlNode2 as XmlElement;
								foreach (XmlNode item in xmlElement5.GetElementsByTagName("instance_material"))
								{
									XmlElement xmlElement6 = item as XmlElement;
									NDGBHOIDHMD nDGBHOIDHMD = new NDGBHOIDHMD();
									nDGBHOIDHMD.JFLBOOBFAEF = xmlElement6.Attributes["target"].Value.Replace("#", string.Empty);
									nDGBHOIDHMD.CDJEPFAMNLF = xmlElement6.Attributes["symbol"].Value;
									cPNMIIHHGOP.EINKGBPHLLE.HDJMJCGIJNM.Add(nDGBHOIDHMD);
								}
								Vector3 pos = new Vector3(0f, 0f, 0f);
								Vector3 vector3 = new Vector3(1f, 1f, 1f);
								Quaternion identity2 = Quaternion.identity;
								Matrix4x4 matrix4x = Matrix4x4.TRS(pos, identity2, vector3);
								for (int i = 0; i < list.Count; i++)
								{
									pos = matrix4x.MultiplyPoint3x4(list[i]);
									vector3 = Vector3.Scale(vector3, list2[i]);
									identity2 *= list3[i];
									matrix4x = Matrix4x4.TRS(pos, identity2, vector3);
								}
								Matrix4x4 kBNFHAGPIMA = matrix4x;
								cPNMIIHHGOP.EINKGBPHLLE.FMNJPJMEGPD = identity2;
								cPNMIIHHGOP.EINKGBPHLLE.KBNFHAGPIMA = kBNFHAGPIMA;
								IBJIIKKCHNO.Add(cPNMIIHHGOP.EINKGBPHLLE);
							}
							xmlNode2 = xmlNode2.NextSibling;
						}
					}
					else
					{
						pELJCFMBKIG.DCMHKMLHNFG = false;
					}
					if (xmlElement3["node"] != null || pELJCFMBKIG.DCMHKMLHNFG || pELJCFMBKIG.IMAJDOIBBLK != null)
					{
						EHNDFDJAPCN.Add(pELJCFMBKIG);
					}
				}
				if (xmlElement3["node"] != null)
				{
					firstChild = xmlElement3["node"];
					list4.Add(firstChild);
					num++;
					continue;
				}
				bool flag2 = false;
				while (!flag2)
				{
					firstChild = firstChild.NextSibling;
					if (firstChild == null)
					{
						list4.RemoveAt(list4.Count - 1);
						if (list.Count != 0)
						{
							list.RemoveAt(list.Count - 1);
							list2.RemoveAt(list2.Count - 1);
							list3.RemoveAt(list3.Count - 1);
						}
						if (list4.Count != 0)
						{
							firstChild = list4[list4.Count - 1];
						}
						num--;
						if (num == -1)
						{
							flag2 = true;
						}
					}
					else
					{
						list4.RemoveAt(list4.Count - 1);
						if (list.Count != 0)
						{
							list.RemoveAt(list.Count - 1);
							list2.RemoveAt(list2.Count - 1);
							list3.RemoveAt(list3.Count - 1);
						}
						list4.Add(firstChild);
						flag2 = true;
					}
				}
			}
		}
		LNPLJAGJMPD = false;
		int num3 = 0;
		HENDAGGIEDP = 0;
		foreach (PELJCFMBKIG item2 in EHNDFDJAPCN)
		{
			if (!item2.LBKJBLPJPBC.Contains("_spc_offset_"))
			{
				num3++;
			}
			if (!item2.DCMHKMLHNFG)
			{
				HENDAGGIEDP++;
			}
		}
		if (num3 == 1)
		{
			LNPLJAGJMPD = true;
		}
		if (GANMHBCOOPI)
		{
			LNPLJAGJMPD = true;
		}
		return flag;
	}

	private string JHGNJGEGANG(XmlElement MGDLJPMBNHJ)
	{
		string text = "false";
		if ((XmlElement)MGDLJPMBNHJ.GetElementsByTagName("mesh")[0] != null)
		{
			if ((XmlElement)MGDLJPMBNHJ.GetElementsByTagName("lines")[0] == null)
			{
				if ((XmlElement)MGDLJPMBNHJ.GetElementsByTagName("triangles")[0] != null)
				{
					return "triangles";
				}
				if ((XmlElement)MGDLJPMBNHJ.GetElementsByTagName("polygons")[0] != null)
				{
					return "polygons";
				}
				if ((XmlElement)MGDLJPMBNHJ.GetElementsByTagName("polylist")[0] != null)
				{
					return "polylist";
				}
				return "false";
			}
			return "false";
		}
		return "false";
	}

	private void DMLDHMADOPL(Vector3 PDAKFGKELOC)
	{
		if (!PMGDCOLPLNE)
		{
			IIAKMEMOMDG = PDAKFGKELOC.x;
			PEAMJFBCLJD = PDAKFGKELOC.x;
			BPGIABMDNNH = PDAKFGKELOC.y;
			NDPKMBKBOLM = PDAKFGKELOC.y;
			COKOFFOMPND = PDAKFGKELOC.z;
			PPIMKLECPLL = PDAKFGKELOC.z;
			PMGDCOLPLNE = true;
		}
		else
		{
			IIAKMEMOMDG = ((!(PDAKFGKELOC.x < IIAKMEMOMDG)) ? IIAKMEMOMDG : PDAKFGKELOC.x);
			PEAMJFBCLJD = ((!(PDAKFGKELOC.x > PEAMJFBCLJD)) ? PEAMJFBCLJD : PDAKFGKELOC.x);
			BPGIABMDNNH = ((!(PDAKFGKELOC.y < BPGIABMDNNH)) ? BPGIABMDNNH : PDAKFGKELOC.y);
			NDPKMBKBOLM = ((!(PDAKFGKELOC.y > NDPKMBKBOLM)) ? NDPKMBKBOLM : PDAKFGKELOC.y);
			COKOFFOMPND = ((!(PDAKFGKELOC.z < COKOFFOMPND)) ? COKOFFOMPND : PDAKFGKELOC.z);
			PPIMKLECPLL = ((!(PDAKFGKELOC.z > PPIMKLECPLL)) ? PPIMKLECPLL : PDAKFGKELOC.z);
		}
	}

	private bool HLKADJBONPE(XmlElement MGDLJPMBNHJ)
	{
		bool result = false;
		List<FNPNCMHPBAK> list = new List<FNPNCMHPBAK>();
		XmlNodeList elementsByTagName = MGDLJPMBNHJ.GetElementsByTagName("input");
		foreach (XmlNode item in elementsByTagName)
		{
			XmlElement xmlElement = item as XmlElement;
			FNPNCMHPBAK fNPNCMHPBAK = new FNPNCMHPBAK();
			fNPNCMHPBAK.IAFKGHCCHIG = xmlElement.Attributes["source"].Value.Replace("#", string.Empty);
			fNPNCMHPBAK.IFMDCGLFHOM = xmlElement.Attributes["semantic"].Value;
			if (fNPNCMHPBAK.IFMDCGLFHOM == "NORMAL" && xmlElement.ParentNode.Name == "vertices")
			{
				ONIKHHEDCFE = true;
			}
			list.Add(fNPNCMHPBAK);
		}
		List<JFKJKFBLGHJ> list2 = new List<JFKJKFBLGHJ>();
		JFKJKFBLGHJ jFKJKFBLGHJ = new JFKJKFBLGHJ();
		foreach (JFKJKFBLGHJ item2 in IBJIIKKCHNO)
		{
			if (item2.BFDKLIPADEE == KOMGKIKAAGJ)
			{
				JFKJKFBLGHJ jFKJKFBLGHJ2 = new JFKJKFBLGHJ();
				jFKJKFBLGHJ2 = item2;
				list2.Add(jFKJKFBLGHJ2);
			}
		}
		int num = 1;
		if (LNPLJAGJMPD)
		{
			num = list2.Count;
		}
		for (int i = 0; i < num; i++)
		{
			jFKJKFBLGHJ = list2[i];
			foreach (XmlNode item3 in MGDLJPMBNHJ.GetElementsByTagName("source"))
			{
				XmlElement xmlElement2 = item3 as XmlElement;
				foreach (FNPNCMHPBAK item4 in list)
				{
					if (!(item3.Attributes["id"].Value == item4.IAFKGHCCHIG))
					{
						continue;
					}
					XmlElement xmlElement3 = (XmlElement)xmlElement2.GetElementsByTagName("float_array")[0];
					XmlElement xmlElement4 = (XmlElement)xmlElement2.GetElementsByTagName("accessor")[0];
					int num2 = int.Parse(xmlElement4.Attributes["stride"].Value);
					int num3 = int.Parse(xmlElement4.Attributes["count"].Value);
					int num4 = int.Parse(xmlElement3.Attributes["count"].Value);
					string text = BHIFDGEDIIG(xmlElement3.InnerXml);
					string[] array = text.Split(" ".ToCharArray());
					if (array.Length == num4)
					{
						Vector3 vector = default(Vector3);
						for (int j = 0; j < array.Length; j += num2)
						{
							if (item4.IFMDCGLFHOM == "POSITION")
							{
								JGFEOBODCBK = num3;
								Vector3 pDAKFGKELOC = new Vector3(MMCCMMGCKNH(array[j]), MMCCMMGCKNH(array[j + 1]), MMCCMMGCKNH(array[j + 2]));
								pDAKFGKELOC = FAFAANKAHNE(pDAKFGKELOC);
								if (LNPLJAGJMPD)
								{
									pDAKFGKELOC = jFKJKFBLGHJ.KBNFHAGPIMA.MultiplyPoint3x4(pDAKFGKELOC);
									JPIKLMIEMPL.JONEIMMKBEJ(pDAKFGKELOC);
									DMLDHMADOPL(pDAKFGKELOC);
								}
								else
								{
									JPIKLMIEMPL.JONEIMMKBEJ(pDAKFGKELOC);
									foreach (JFKJKFBLGHJ item5 in list2)
									{
										vector = item5.KBNFHAGPIMA.MultiplyPoint3x4(pDAKFGKELOC);
										DMLDHMADOPL(vector);
									}
								}
								result = true;
							}
							if (item4.IFMDCGLFHOM == "NORMAL")
							{
								BHPMMMEDAHN = num3;
								Vector3 pDAKFGKELOC = new Vector3(MMCCMMGCKNH(array[j]), MMCCMMGCKNH(array[j + 1]), MMCCMMGCKNH(array[j + 2]));
								pDAKFGKELOC = FAFAANKAHNE(pDAKFGKELOC);
								if (LNPLJAGJMPD)
								{
									pDAKFGKELOC = jFKJKFBLGHJ.FMNJPJMEGPD * pDAKFGKELOC;
								}
								JPIKLMIEMPL.LCLMMAEKKHI(pDAKFGKELOC);
								result = true;
							}
							if (item4.IFMDCGLFHOM == "TEXCOORD")
							{
								GNNGLJCIJEF = num3;
								JPIKLMIEMPL.EJLEOCHIPJC(new Vector2(MMCCMMGCKNH(array[j]), MMCCMMGCKNH(array[j + 1])));
								result = true;
							}
						}
					}
					else
					{
						Debug.Log("In Geometry " + MGDLJPMBNHJ.Attributes["id"].Value + " have problem parsing xml @ " + item4.IFMDCGLFHOM);
					}
				}
			}
		}
		return result;
	}

	private string[] FDINIAJNIGG(XmlElement EOJMECHKILG, int FHBOGCOJPML, int MDIDEMDBKKP)
	{
		string[] array = new string[MDIDEMDBKKP];
		XmlNodeList elementsByTagName = EOJMECHKILG.GetElementsByTagName("p");
		if (elementsByTagName.Count > 0)
		{
			int num = 0;
			if (elementsByTagName.Count < 2)
			{
				XmlElement xmlElement = (XmlElement)EOJMECHKILG.GetElementsByTagName("vcount")[0];
				XmlElement xmlElement2 = (XmlElement)EOJMECHKILG.GetElementsByTagName("p")[0];
				if (xmlElement != null)
				{
					string[] array2 = xmlElement.InnerXml.Split(" ".ToCharArray());
					string text = BHIFDGEDIIG(xmlElement2.InnerXml);
					string[] array3 = text.Split(" "[0]);
					int num2 = 0;
					int num3 = 0;
					while (num2 < array3.Length)
					{
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 0; i < int.Parse(array2[num3]); i++)
						{
							for (int j = 0; j < FHBOGCOJPML; j++)
							{
								stringBuilder.Append(array3[num2 + i * FHBOGCOJPML + j]).Append("/");
							}
							stringBuilder.Remove(stringBuilder.Length - 1, 1);
							stringBuilder.Append(" ");
						}
						array[num] = stringBuilder.ToString();
						num++;
						num2 += int.Parse(array2[num3]) * FHBOGCOJPML;
						num3++;
					}
				}
				else
				{
					string text2 = BHIFDGEDIIG(xmlElement2.InnerXml);
					string[] array4 = text2.Split(" "[0]);
					for (int k = 0; k < array4.Length; k += 3 * FHBOGCOJPML)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						for (int l = 0; l < 3; l++)
						{
							for (int m = 0; m < FHBOGCOJPML; m++)
							{
								stringBuilder2.Append(array4[k + l * FHBOGCOJPML + m]).Append("/");
							}
							stringBuilder2.Remove(stringBuilder2.Length - 1, 1);
							stringBuilder2.Append(" ");
						}
						array[num] = stringBuilder2.ToString();
						num++;
					}
				}
			}
			else
			{
				foreach (XmlNode item in elementsByTagName)
				{
					string text3 = BHIFDGEDIIG(item.InnerXml);
					string[] array5 = text3.Split(" "[0]);
					StringBuilder stringBuilder3 = new StringBuilder();
					for (int n = 0; n < array5.Length; n += FHBOGCOJPML)
					{
						for (int num4 = 0; num4 < FHBOGCOJPML; num4++)
						{
							stringBuilder3.Append(array5[n + num4]).Append("/");
						}
						stringBuilder3.Remove(stringBuilder3.Length - 1, 1);
						stringBuilder3.Append(" ");
					}
					array[num] = stringBuilder3.ToString();
					num++;
				}
			}
		}
		else
		{
			Debug.Log("Cannot Find Any Face Data For this Geometry");
		}
		return array;
	}

	private bool FCGGKFCCEOG(XmlElement MGDLJPMBNHJ, string EFKHDEOKKLE)
	{
		bool result = false;
		if (PEBOEKFIAPG)
		{
			JPIKLMIEMPL.HMJGHMMBPBN(KOMGKIKAAGJ);
			if (LNPLJAGJMPD)
			{
				PEBOEKFIAPG = false;
			}
		}
		List<JFKJKFBLGHJ> list = new List<JFKJKFBLGHJ>();
		JFKJKFBLGHJ jFKJKFBLGHJ = new JFKJKFBLGHJ();
		foreach (JFKJKFBLGHJ item in IBJIIKKCHNO)
		{
			if (item.BFDKLIPADEE == KOMGKIKAAGJ)
			{
				JFKJKFBLGHJ jFKJKFBLGHJ2 = new JFKJKFBLGHJ();
				jFKJKFBLGHJ2 = item;
				list.Add(jFKJKFBLGHJ2);
			}
		}
		int num = 1;
		if (LNPLJAGJMPD)
		{
			num = list.Count;
		}
		for (int i = 0; i < num; i++)
		{
			jFKJKFBLGHJ = list[i];
			int num2 = JGFEOBODCBK * i;
			int num3 = BHPMMMEDAHN * i;
			int num4 = GNNGLJCIJEF * i;
			foreach (XmlNode item2 in MGDLJPMBNHJ.GetElementsByTagName(EFKHDEOKKLE))
			{
				XmlElement xmlElement = item2 as XmlElement;
				if (int.Parse(xmlElement.Attributes["count"].Value) == 0)
				{
					continue;
				}
				string aLLLIGGPLMK = "_spc_default";
				bool flag = false;
				foreach (NDGBHOIDHMD item3 in jFKJKFBLGHJ.HDJMJCGIJNM)
				{
					if (item3.CDJEPFAMNLF == xmlElement.Attributes["material"].Value)
					{
						aLLLIGGPLMK = item3.JFLBOOBFAEF;
						flag = true;
					}
				}
				if (!flag)
				{
					aLLLIGGPLMK = KOMGKIKAAGJ;
				}
				JPIKLMIEMPL.GHLHIMFPBHL(aLLLIGGPLMK);
				XmlNodeList elementsByTagName = xmlElement.GetElementsByTagName("input");
				string[] array = new string[elementsByTagName.Count];
				for (int j = 0; j < elementsByTagName.Count; j++)
				{
					array[j] = elementsByTagName[j].Attributes["semantic"].Value;
				}
				string[] array2 = FDINIAJNIGG(xmlElement, array.Length, int.Parse(xmlElement.Attributes["count"].Value));
				string[] array3 = array2;
				foreach (string oGJIDBEODPM in array3)
				{
					string text = BHIFDGEDIIG(oGJIDBEODPM);
					string[] array4 = text.Split(" ".ToCharArray());
					if (array4.Length <= 4)
					{
						for (int l = 0; l < array4.Length - 2; l++)
						{
							NNOLKJOJPEP gHJBEEBMOKB = default(NNOLKJOJPEP);
							string[] array5 = array4[0].Trim().Split("/".ToCharArray());
							for (int m = 0; m < array.Length; m++)
							{
								if (array[m] == "VERTEX")
								{
									gHJBEEBMOKB.HLIDCIJJNLC = NONPABEFNOK(array5[m]) + EEPCEKKEFFI + num2;
									if (ONIKHHEDCFE)
									{
										gHJBEEBMOKB.KMKKCKFLHNJ = NONPABEFNOK(array5[m]) + BKMEKJNLELM + num3;
									}
								}
								if (array[m] == "NORMAL")
								{
									gHJBEEBMOKB.KMKKCKFLHNJ = NONPABEFNOK(array5[m]) + BKMEKJNLELM + num3;
								}
								if (array[m] == "TEXCOORD")
								{
									gHJBEEBMOKB.CNNDMIEDIJB = NONPABEFNOK(array5[m]) + JJODOPGLPGA + num4;
								}
							}
							JPIKLMIEMPL.IOCHHBGENBN(gHJBEEBMOKB);
							for (int n = 0; n < 2; n++)
							{
								gHJBEEBMOKB = default(NNOLKJOJPEP);
								int num5 = 2 - n + l;
								array5 = array4[num5].Trim().Split("/".ToCharArray());
								for (int num6 = 0; num6 < array.Length; num6++)
								{
									if (array[num6] == "VERTEX")
									{
										gHJBEEBMOKB.HLIDCIJJNLC = NONPABEFNOK(array5[num6]) + EEPCEKKEFFI + num2;
										if (ONIKHHEDCFE)
										{
											gHJBEEBMOKB.KMKKCKFLHNJ = NONPABEFNOK(array5[num6]) + BKMEKJNLELM + num3;
										}
									}
									if (array[num6] == "NORMAL")
									{
										gHJBEEBMOKB.KMKKCKFLHNJ = NONPABEFNOK(array5[num6]) + BKMEKJNLELM + num3;
									}
									if (array[num6] == "TEXCOORD")
									{
										gHJBEEBMOKB.CNNDMIEDIJB = NONPABEFNOK(array5[num6]) + JJODOPGLPGA + num4;
									}
								}
								JPIKLMIEMPL.IOCHHBGENBN(gHJBEEBMOKB);
							}
						}
						continue;
					}
					EAOGCNNFCEP eAOGCNNFCEP = new EAOGCNNFCEP();
					Vector3[] array6 = new Vector3[array4.Length];
					for (int num7 = 0; num7 < array4.Length; num7++)
					{
						string[] array5 = array4[num7].Trim().Split("/".ToCharArray());
						for (int num8 = 0; num8 < array.Length; num8++)
						{
							if (array[num8] == "VERTEX")
							{
								array6[num7] = JPIKLMIEMPL.KOGKFEMKGBB[NONPABEFNOK(array5[num8]) + EEPCEKKEFFI + num2];
							}
						}
					}
					int[] array7 = eAOGCNNFCEP.FGJBKAFIGNI(array6);
					if (array7.Length <= 2)
					{
						continue;
					}
					for (int num9 = 0; num9 < array7.Length; num9++)
					{
						NNOLKJOJPEP gHJBEEBMOKB2 = default(NNOLKJOJPEP);
						string[] array5 = array4[array7[num9]].Trim().Split("/".ToCharArray());
						for (int num10 = 0; num10 < array.Length; num10++)
						{
							if (array[num10] == "VERTEX")
							{
								gHJBEEBMOKB2.HLIDCIJJNLC = NONPABEFNOK(array5[num10]) + EEPCEKKEFFI + num2;
								if (ONIKHHEDCFE)
								{
									gHJBEEBMOKB2.KMKKCKFLHNJ = NONPABEFNOK(array5[num10]) + BKMEKJNLELM + num3;
								}
							}
							if (array[num10] == "NORMAL")
							{
								gHJBEEBMOKB2.KMKKCKFLHNJ = NONPABEFNOK(array5[num10]) + BKMEKJNLELM + num3;
							}
							if (array[num10] == "TEXCOORD")
							{
								gHJBEEBMOKB2.CNNDMIEDIJB = NONPABEFNOK(array5[num10]) + JJODOPGLPGA + num4;
							}
						}
						JPIKLMIEMPL.IOCHHBGENBN(gHJBEEBMOKB2);
					}
				}
				result = true;
			}
		}
		return result;
	}

	private void ALPEFFCGFNM()
	{
		FBHFHLLMBAB = 0f - (PEAMJFBCLJD / 2f + IIAKMEMOMDG / 2f);
		NEDCJHPLJPN = 0f - (NDPKMBKBOLM / 2f + BPGIABMDNNH / 2f);
		DJBNOGHFGPF = 0f - (PPIMKLECPLL / 2f + COKOFFOMPND / 2f);
		JCBDEOJHLCB = new Vector3(FBHFHLLMBAB, NEDCJHPLJPN + (NDPKMBKBOLM - BPGIABMDNNH) / 2f, DJBNOGHFGPF);
		AFDBPPKKGFO = ((!(BPGIABMDNNH < IIAKMEMOMDG)) ? IIAKMEMOMDG : BPGIABMDNNH);
		AFDBPPKKGFO = ((!(COKOFFOMPND < AFDBPPKKGFO)) ? AFDBPPKKGFO : COKOFFOMPND);
		DMOLOABDJPC = ((!(NDPKMBKBOLM > PEAMJFBCLJD)) ? PEAMJFBCLJD : NDPKMBKBOLM);
		DMOLOABDJPC = ((!(PPIMKLECPLL > DMOLOABDJPC)) ? DMOLOABDJPC : PPIMKLECPLL);
		float num = 0f;
		num = ((!(0f - AFDBPPKKGFO > DMOLOABDJPC)) ? DMOLOABDJPC : (0f - AFDBPPKKGFO));
		if (num == 0f)
		{
			return;
		}
		if (LNPLJAGJMPD)
		{
			for (int i = 0; i < JPIKLMIEMPL.KOGKFEMKGBB.Count; i++)
			{
				JPIKLMIEMPL.KOGKFEMKGBB[i] = (JPIKLMIEMPL.KOGKFEMKGBB[i] + JCBDEOJHLCB) * BANENAOAMCH;
			}
		}
		else
		{
			for (int j = 0; j < JPIKLMIEMPL.KOGKFEMKGBB.Count; j++)
			{
				JPIKLMIEMPL.KOGKFEMKGBB[j] = JPIKLMIEMPL.KOGKFEMKGBB[j] * BANENAOAMCH;
			}
		}
	}

	private void HFPDBGNKDDN()
	{
		JMKNPPLJEGJ = true;
		BCIFNDHHBHP = new List<CFGPAKOCHHJ>();
		foreach (XmlNode item in JHLBCBBILKI.GetElementsByTagName("image"))
		{
			XmlElement xmlElement = item as XmlElement;
			CFGPAKOCHHJ cFGPAKOCHHJ = new CFGPAKOCHHJ();
			cFGPAKOCHHJ.JFLBOOBFAEF = xmlElement.Attributes["id"].Value;
			XmlElement xmlElement2 = (XmlElement)xmlElement.GetElementsByTagName("init_from")[0];
			cFGPAKOCHHJ.NGIHJKGIKNA = xmlElement2.InnerXml;
			BCIFNDHHBHP.Add(cFGPAKOCHHJ);
		}
		EKBIEIMIEOH = new List<ICAPCLEDDLL>();
		List<string> list = new List<string>();
		list.Add("emission");
		list.Add("ambient");
		list.Add("specular");
		list.Add("diffuse");
		list.Add("shininess");
		list.Add("transparent");
		list.Add("transparency");
		List<string> list2 = list;
		XmlElement xmlElement3 = (XmlElement)JHLBCBBILKI.GetElementsByTagName("library_materials")[0];
		XmlElement xmlElement4 = (XmlElement)JHLBCBBILKI.GetElementsByTagName("library_effects")[0];
		if ((XmlElement)JHLBCBBILKI.GetElementsByTagName("library_materials")[0] != null)
		{
			foreach (XmlNode item2 in xmlElement3.GetElementsByTagName("material"))
			{
				XmlElement xmlElement5 = item2 as XmlElement;
				ICAPCLEDDLL iCAPCLEDDLL = new ICAPCLEDDLL();
				iCAPCLEDDLL.IAFKGHCCHIG = xmlElement5.Attributes["id"].Value;
				if (xmlElement5.HasAttribute("name"))
				{
					iCAPCLEDDLL.ALLLIGGPLMK = xmlElement5.Attributes["name"].Value;
				}
				XmlElement xmlElement6 = (XmlElement)xmlElement5.GetElementsByTagName("instance_effect")[0];
				string text = xmlElement6.Attributes["url"].Value.Replace("#", string.Empty);
				foreach (XmlNode item3 in xmlElement4.GetElementsByTagName("effect"))
				{
					XmlElement xmlElement7 = item3 as XmlElement;
					if (xmlElement7.Attributes["id"].Value == text)
					{
						foreach (string item4 in list2)
						{
							XmlElement xmlElement8 = (XmlElement)xmlElement7.GetElementsByTagName(item4)[0];
							if (xmlElement8 != null)
							{
								XmlElement xmlElement9 = (XmlElement)xmlElement8.GetElementsByTagName("color")[0];
								XmlElement xmlElement10 = (XmlElement)xmlElement8.GetElementsByTagName("float")[0];
								XmlElement xmlElement11 = (XmlElement)xmlElement8.GetElementsByTagName("texture")[0];
								switch (item4)
								{
								case "diffuse":
									if (xmlElement9 != null)
									{
										iCAPCLEDDLL.BPNKJHEDAPP = ENEODCBOEJL(xmlElement9);
									}
									if (xmlElement11 != null)
									{
										iCAPCLEDDLL.FJMJOFOIOBL = NCGCICECDEH(xmlElement11.Attributes["texture"].Value, xmlElement7);
									}
									break;
								case "emission":
									if (xmlElement9 != null)
									{
										iCAPCLEDDLL.CNGBEKDDPIG = ENEODCBOEJL(xmlElement9);
									}
									if (xmlElement11 != null)
									{
										iCAPCLEDDLL.HCKKDACJPAD = NCGCICECDEH(xmlElement11.Attributes["texture"].Value, xmlElement7);
									}
									break;
								case "ambient":
									if (xmlElement9 != null)
									{
										iCAPCLEDDLL.OLGLLNJFGJJ = ENEODCBOEJL(xmlElement9);
									}
									break;
								case "specular":
									if (xmlElement9 != null)
									{
										iCAPCLEDDLL.GNFKLBBCDGD = ENEODCBOEJL(xmlElement9);
									}
									if (xmlElement11 != null)
									{
										iCAPCLEDDLL.DHNKIPPOHEM = NCGCICECDEH(xmlElement11.Attributes["texture"].Value, xmlElement7);
									}
									break;
								case "shininess":
									if (xmlElement10 != null)
									{
										iCAPCLEDDLL.IMFEDNDHMNM = MMCCMMGCKNH(xmlElement10.InnerXml);
									}
									break;
								case "transparent":
									if (xmlElement9 != null)
									{
										iCAPCLEDDLL.CEICFBDBFAJ = ENEODCBOEJL(xmlElement9);
									}
									if (xmlElement11 != null)
									{
										iCAPCLEDDLL.IDFDCGHNIBK = NCGCICECDEH(xmlElement11.Attributes["texture"].Value, xmlElement7);
									}
									break;
								case "transparency":
									if (xmlElement10 != null)
									{
										iCAPCLEDDLL.KKEJOJDFLFN = MMCCMMGCKNH(xmlElement10.InnerXml);
									}
									break;
								}
							}
						}
					}
				}
				EKBIEIMIEOH.Add(iCAPCLEDDLL);
			}
			return;
		}
		JMKNPPLJEGJ = false;
	}

	private Color ENEODCBOEJL(XmlElement KMJBCEKCMPJ)
	{
		string text = BHIFDGEDIIG(KMJBCEKCMPJ.InnerXml);
		string[] array = text.Split(" ".ToCharArray());
		return new Color(MMCCMMGCKNH(array[0]), MMCCMMGCKNH(array[1]), MMCCMMGCKNH(array[2]), MMCCMMGCKNH(array[3]));
	}

	private string NCGCICECDEH(string IAFKGHCCHIG, XmlElement DACFGECCCJL)
	{
		string text = string.Empty;
		foreach (CFGPAKOCHHJ item in BCIFNDHHBHP)
		{
			if (item.JFLBOOBFAEF == IAFKGHCCHIG)
			{
				text = item.NGIHJKGIKNA;
			}
		}
		if (text == string.Empty)
		{
			bool flag = false;
			XmlNodeList elementsByTagName = DACFGECCCJL.GetElementsByTagName("newparam");
			for (int i = 0; i < elementsByTagName.Count; i++)
			{
				foreach (XmlNode item2 in elementsByTagName)
				{
					XmlElement xmlElement = item2 as XmlElement;
					if (xmlElement.HasAttribute("sid"))
					{
						if (xmlElement.Attributes["sid"].Value == IAFKGHCCHIG)
						{
							if ((XmlElement)xmlElement.GetElementsByTagName("source")[0] != null)
							{
								XmlElement xmlElement2 = (XmlElement)xmlElement.GetElementsByTagName("source")[0];
								IAFKGHCCHIG = xmlElement2.InnerXml;
							}
							else if ((XmlElement)xmlElement.GetElementsByTagName("init_from")[0] != null)
							{
								XmlElement xmlElement3 = (XmlElement)xmlElement.GetElementsByTagName("init_from")[0];
								IAFKGHCCHIG = xmlElement3.InnerXml;
								flag = true;
							}
						}
					}
					else
					{
						Debug.Log("Problems accessing texture path: - no SID");
					}
				}
				if (flag)
				{
					break;
				}
			}
			if (flag)
			{
				foreach (CFGPAKOCHHJ item3 in BCIFNDHHBHP)
				{
					if (item3.JFLBOOBFAEF == IAFKGHCCHIG)
					{
						text = item3.NGIHJKGIKNA;
					}
				}
			}
		}
		return text;
	}

	private void CNDPDFENJLL()
	{
		foreach (ICAPCLEDDLL item in EKBIEIMIEOH)
		{
			if (item.BPNKJHEDAPP.grayscale == 0f)
			{
				if (item.OLGLLNJFGJJ.grayscale != 0f)
				{
					item.BPNKJHEDAPP = item.OLGLLNJFGJJ;
				}
				else if (item.CNGBEKDDPIG.grayscale != 0f)
				{
					item.BPNKJHEDAPP = item.CNGBEKDDPIG;
				}
				else
				{
					item.BPNKJHEDAPP = new Color(0.5f, 0.5f, 0.5f, 1f);
				}
			}
			if (item.KKEJOJDFLFN != 1f || item.CEICFBDBFAJ.a != 1f)
			{
				if (item.CEICFBDBFAJ.a != 1f)
				{
					item.KKEJOJDFLFN = item.CEICFBDBFAJ.a;
				}
				else
				{
					item.KKEJOJDFLFN = 1f - item.KKEJOJDFLFN;
				}
			}
			else if (item.CEICFBDBFAJ.grayscale < 1f)
			{
				item.KKEJOJDFLFN = 1f - item.CEICFBDBFAJ.grayscale;
			}
			if (item.GNFKLBBCDGD.grayscale > 0f)
			{
				item.GNFKLBBCDGD = new Color(1f - item.GNFKLBBCDGD.r, 1f - item.GNFKLBBCDGD.g, 1f - item.GNFKLBBCDGD.b, 1f);
				if (item.IMFEDNDHMNM == 2f)
				{
					item.IMFEDNDHMNM = 0.5f;
				}
				else if (item.IMFEDNDHMNM >= 2f)
				{
					item.GNFKLBBCDGD = new Color(1f - item.GNFKLBBCDGD.r, 1f - item.GNFKLBBCDGD.g, 1f - item.GNFKLBBCDGD.b, 1f);
					item.IMFEDNDHMNM = (Mathf.Clamp(item.IMFEDNDHMNM, 2f, 10f) - 2f) / 7f;
				}
				else if (item.IMFEDNDHMNM >= 1f)
				{
					item.IMFEDNDHMNM = Mathf.Clamp(item.IMFEDNDHMNM, 0f, 1f);
				}
			}
			else if (item.IMFEDNDHMNM >= 2f)
			{
				item.IMFEDNDHMNM = (Mathf.Clamp(item.IMFEDNDHMNM, 2f, 10f) - 2f) / 7f;
				item.GNFKLBBCDGD = new Color(item.IMFEDNDHMNM, item.IMFEDNDHMNM, item.IMFEDNDHMNM, 1f);
			}
			else if (item.IMFEDNDHMNM >= 1f)
			{
				item.IMFEDNDHMNM = Mathf.Clamp(item.IMFEDNDHMNM, 0f, 1f);
			}
			item.PBKPINAHBHK = string.Empty;
			if (item.KKEJOJDFLFN == 1f && item.IDFDCGHNIBK == null)
			{
				if (item.HCKKDACJPAD != null)
				{
					item.PBKPINAHBHK += "Self-Illumin/";
				}
				else if (item.CNGBEKDDPIG.grayscale > 0f)
				{
					item.PBKPINAHBHK += "Self-Illumin/";
				}
			}
			else if (item.KKEJOJDFLFN == 1f)
			{
				item.PBKPINAHBHK += "Transparent/Cutout/";
				if (item.IDFDCGHNIBK == null)
				{
				}
			}
			else
			{
				item.PBKPINAHBHK += "Transparent/";
				if (item.IDFDCGHNIBK == null)
				{
				}
			}
			if ((double)item.IMFEDNDHMNM > 0.01 || item.DHNKIPPOHEM != null)
			{
				item.PBKPINAHBHK += "Specular";
				if (item.DHNKIPPOHEM == null)
				{
				}
			}
			else
			{
				item.PBKPINAHBHK += "Diffuse";
			}
			if (item.FJMJOFOIOBL != null)
			{
				item.KFHILAEFMNG = EHDGDCFLFBE(item.FJMJOFOIOBL);
			}
		}
	}

	private static Texture2D EHDGDCFLFBE(string HCKKDACJPAD)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(HCKKDACJPAD);
		Debug.Log("TexturePath: " + fileNameWithoutExtension);
		return (Texture2D)Resources.Load("textures/" + fileNameWithoutExtension, typeof(Texture2D));
	}

	private Material FBCAMBLIOLJ(ICAPCLEDDLL HLEHPONHPOB)
	{
		Material material = new Material(Shader.Find(HLEHPONHPOB.PBKPINAHBHK));
		material.SetColor("_Color", HLEHPONHPOB.BPNKJHEDAPP);
		if (HLEHPONHPOB.PBKPINAHBHK.Contains("Self-Illumin") && HLEHPONHPOB.CNGBEKDDPIG.grayscale > 0f)
		{
			material.SetColor("_Color", HLEHPONHPOB.CNGBEKDDPIG);
		}
		if (HLEHPONHPOB.PBKPINAHBHK.Contains("Transparent"))
		{
			material.SetColor("_Color", new Color(HLEHPONHPOB.BPNKJHEDAPP.r, HLEHPONHPOB.BPNKJHEDAPP.g, HLEHPONHPOB.BPNKJHEDAPP.b, HLEHPONHPOB.KKEJOJDFLFN));
		}
		if (HLEHPONHPOB.PBKPINAHBHK.Contains("Cutout"))
		{
			material.SetFloat("_Cutoff", 0.5f);
		}
		if (HLEHPONHPOB.PBKPINAHBHK.Contains("Specular"))
		{
			material.SetColor("_SpecColor", HLEHPONHPOB.GNFKLBBCDGD);
			material.SetFloat("_Shininess", 0.01f + (HLEHPONHPOB.IMFEDNDHMNM - 0.01f * HLEHPONHPOB.IMFEDNDHMNM));
		}
		if (HLEHPONHPOB.KFHILAEFMNG != null)
		{
			material.SetTexture("_MainTex", HLEHPONHPOB.KFHILAEFMNG);
		}
		return material;
	}

	private void JPNAJAPICDM()
	{
		Dictionary<string, Material> dictionary = new Dictionary<string, Material>();
		if (JMKNPPLJEGJ)
		{
			foreach (ICAPCLEDDLL item in EKBIEIMIEOH)
			{
				if (!dictionary.ContainsKey(item.IAFKGHCCHIG))
				{
					dictionary.Add(item.IAFKGHCCHIG, FBCAMBLIOLJ(item));
				}
			}
		}
		GameObject[] array = new GameObject[JPIKLMIEMPL.GLAOOFIGOOK];
		if (JPIKLMIEMPL.GLAOOFIGOOK == 1)
		{
			if (!LNPLJAGJMPD)
			{
				GameObject gameObject = new GameObject();
				gameObject.transform.parent = ICIEDCMDJFO.transform;
				gameObject.AddComponent(typeof(MeshFilter));
				gameObject.AddComponent(typeof(MeshRenderer));
				gameObject.name = "_spc_rename_";
				array[0] = gameObject;
			}
			else
			{
				ICIEDCMDJFO.AddComponent(typeof(MeshFilter));
				ICIEDCMDJFO.AddComponent(typeof(MeshRenderer));
				array[0] = ICIEDCMDJFO;
			}
		}
		else if (JPIKLMIEMPL.GLAOOFIGOOK > 1)
		{
			for (int i = 0; i < JPIKLMIEMPL.GLAOOFIGOOK; i++)
			{
				GameObject gameObject2 = new GameObject();
				gameObject2.transform.parent = ICIEDCMDJFO.transform;
				gameObject2.AddComponent(typeof(MeshFilter));
				gameObject2.AddComponent(typeof(MeshRenderer));
				array[i] = gameObject2;
			}
		}
		JPIKLMIEMPL.GHNKMCGIMMP(array, dictionary);
		if (PAKMHHLILHG)
		{
			KAFPAJLOKNC.PGEAHMDMAFG(array, "progmesh");
		}
		if (LNPLJAGJMPD)
		{
			return;
		}
		GameObject[] array2 = new GameObject[EHNDFDJAPCN.Count];
		int num = 0;
		GameObject[] array3 = array;
		for (int j = 0; j < array3.Length; j++)
		{
			GFCEOGLODIP gFCEOGLODIP = new GFCEOGLODIP();
			gFCEOGLODIP.JNAJLLGPHFB = array3[j];
			List<JFKJKFBLGHJ> list = IBJIIKKCHNO.FindAll(gFCEOGLODIP.BEKJDJFLJJC);
			foreach (JFKJKFBLGHJ item2 in list)
			{
				if (item2.DEMDMBKNONK)
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate(gFCEOGLODIP.JNAJLLGPHFB);
					gameObject3.transform.parent = ICIEDCMDJFO.transform;
					gameObject3.name = item2.DAJGJBCJKEI;
					Material[] array4 = new Material[item2.HDJMJCGIJNM.Count];
					for (int k = 0; k < item2.HDJMJCGIJNM.Count; k++)
					{
						array4[k] = dictionary[item2.HDJMJCGIJNM[k].JFLBOOBFAEF];
						array4[k].name = item2.HDJMJCGIJNM[k].JFLBOOBFAEF;
					}
					gameObject3.GetComponent<Renderer>().materials = array4;
					array2[num] = gameObject3;
					num++;
				}
				else
				{
					gFCEOGLODIP.JNAJLLGPHFB.name = item2.DAJGJBCJKEI;
					array2[num] = gFCEOGLODIP.JNAJLLGPHFB;
					num++;
				}
			}
		}
		foreach (PELJCFMBKIG item3 in EHNDFDJAPCN)
		{
			if (!item3.DCMHKMLHNFG)
			{
				GameObject gameObject4 = new GameObject();
				gameObject4.name = item3.LBKJBLPJPBC;
				gameObject4.transform.parent = ICIEDCMDJFO.transform;
				array2[num] = gameObject4;
				num++;
			}
		}
		GameObject[] array5 = array2;
		for (int l = 0; l < array5.Length; l++)
		{
			IEGJIDBGIBG iEGJIDBGIBG = new IEGJIDBGIBG();
			iEGJIDBGIBG.BIMHAGOKNME = array5[l];
			bool flag = false;
			bool flag2 = false;
			PELJCFMBKIG pELJCFMBKIG = EHNDFDJAPCN.Find(iEGJIDBGIBG.BEKJDJFLJJC);
			if (pELJCFMBKIG.DAJGJBCJKEI != null)
			{
				GameObject[] array6 = array2;
				foreach (GameObject gameObject5 in array6)
				{
					if (pELJCFMBKIG.DAJGJBCJKEI == gameObject5.name)
					{
						iEGJIDBGIBG.BIMHAGOKNME.transform.parent = gameObject5.transform;
						flag = true;
					}
				}
				if (!flag)
				{
					iEGJIDBGIBG.BIMHAGOKNME.transform.parent = ICIEDCMDJFO.transform;
				}
			}
			else
			{
				flag2 = true;
			}
			iEGJIDBGIBG.BIMHAGOKNME.transform.localRotation = pELJCFMBKIG.KHGAOLHJCMO;
			if (flag2)
			{
				iEGJIDBGIBG.BIMHAGOKNME.transform.localPosition = pELJCFMBKIG.ELGIKGAIIOD * BANENAOAMCH + JCBDEOJHLCB * BANENAOAMCH;
			}
			else
			{
				iEGJIDBGIBG.BIMHAGOKNME.transform.localPosition = pELJCFMBKIG.ELGIKGAIIOD * BANENAOAMCH;
			}
			iEGJIDBGIBG.BIMHAGOKNME.transform.localScale = pELJCFMBKIG.PFOFPDDMMKA;
		}
	}

	private float MMCCMMGCKNH(string PDAKFGKELOC)
	{
		return Convert.ToSingle(PDAKFGKELOC.Trim(), BEMLCJNJEPC);
	}

	private int NONPABEFNOK(string PDAKFGKELOC)
	{
		return Convert.ToInt32(PDAKFGKELOC.Trim(), BEMLCJNJEPC);
	}

	private static string BHIFDGEDIIG(string OGJIDBEODPM)
	{
		StringBuilder stringBuilder = new StringBuilder(OGJIDBEODPM);
		stringBuilder.Replace("\r", " ");
		stringBuilder.Replace("\n", " ");
		string input = stringBuilder.ToString();
		input = Regex.Replace(input, "\\s+", " ");
		return input.Trim();
	}

	private Texture2D CKPIJLOAKKL(Texture2D FCBABFMAPBI, float FANKBBPOJMA)
	{
		FANKBBPOJMA = Mathf.Clamp(FANKBBPOJMA, 0f, 10f);
		Texture2D texture2D = new Texture2D(FCBABFMAPBI.width, FCBABFMAPBI.height, TextureFormat.ARGB32, true);
		for (int i = 0; i < texture2D.height; i++)
		{
			for (int j = 0; j < texture2D.width; j++)
			{
				float num = FCBABFMAPBI.GetPixel(j - 1, i).grayscale * FANKBBPOJMA;
				float num2 = FCBABFMAPBI.GetPixel(j + 1, i).grayscale * FANKBBPOJMA;
				float num3 = FCBABFMAPBI.GetPixel(j, i - 1).grayscale * FANKBBPOJMA;
				float num4 = FCBABFMAPBI.GetPixel(j, i + 1).grayscale * FANKBBPOJMA;
				float r = (num - num2 + 1f) * 0.5f;
				float num5 = (num3 - num4 + 1f) * 0.5f;
				texture2D.SetPixel(j, i, new Color(r, num5, 1f, num5));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	private Texture2D IJAGHCIGGDM(Texture2D FCBABFMAPBI, int MGCPFCKGJHC, int PPAFPDGMKJG)
	{
		Texture2D texture2D = new Texture2D(MGCPFCKGJHC, PPAFPDGMKJG, FCBABFMAPBI.format, true);
		Color[] pixels = texture2D.GetPixels(0);
		float num = 1f / (float)FCBABFMAPBI.width * ((float)FCBABFMAPBI.width / (float)MGCPFCKGJHC);
		float num2 = 1f / (float)FCBABFMAPBI.height * ((float)FCBABFMAPBI.height / (float)PPAFPDGMKJG);
		for (int i = 0; i < pixels.Length; i++)
		{
			pixels[i] = FCBABFMAPBI.GetPixelBilinear(num * ((float)i % (float)MGCPFCKGJHC), num2 * Mathf.Floor((float)i / (float)MGCPFCKGJHC));
		}
		texture2D.SetPixels(pixels, 0);
		texture2D.Apply();
		return texture2D;
	}
}
