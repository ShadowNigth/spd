using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Extensions/Primitives/UILineRenderer")]
public class AANBJFHLONM : JEADEBLLCGO
{
	private enum ODJFPKGLFEL
	{
		JMLAEOGOGDP = 0,
		MMJHDGCOIID = 1,
		OPKPJNINJNH = 2,
		KMIHCDNNONL = 3
	}

	public enum ANLCMAAEPOJ
	{
		FGGFHKJMOPC = 0,
		NMOCDBBEFAE = 1
	}

	public enum HKIFPABOGKE
	{
		BLBOPPEBDFH = 0,
		MNCLAIGJJCG = 1,
		CAMCKAOJDMG = 2,
		JIJBKEBKMCH = 3,
		FNFACFBJEAD = 4
	}

	private const float CPABLNOGNJB = (float)Math.PI / 12f;

	private const float NNDGCBFGEEP = (float)Math.PI / 6f;

	private static Vector2 OFOLGPJACME;

	private static Vector2 MGOIILJDNIB;

	private static Vector2 JCJFDMBGCAL;

	private static Vector2 PBFCFIOGKCF;

	private static Vector2 KEKGHIMJKLB;

	private static Vector2 NGOGKPHBALM;

	private static Vector2 FCDNNPAKBEC;

	private static Vector2 HDCNHKECDND;

	private static Vector2[] NBHMJAJMCKB;

	private static Vector2[] GBMAHLOAMFE;

	private static Vector2[] HAOOBAABPFL;

	private static Vector2[] IGNBCEFHGNA;

	[SerializeField]
	[Tooltip("Points to draw lines between\n Can be improved using the Resolution Option")]
	internal Vector2[] m_points;

	[Tooltip("Thickness of the line")]
	[SerializeField]
	internal float lineThickness = 2f;

	[SerializeField]
	[Tooltip("Use the relative bounds of the Rect Transform (0,0 -> 0,1) or screen space coordinates")]
	internal bool relativeSize;

	[Tooltip("Do the points identify a single line or split pairs of lines")]
	[SerializeField]
	internal bool lineList;

	[Tooltip("Add end caps to each line\nMultiple caps when used with Line List")]
	[SerializeField]
	internal bool lineCaps;

	[SerializeField]
	[Tooltip("Resolution of the Bezier curve, different to line Resolution")]
	internal int bezierSegmentsPerCurve = 10;

	[Tooltip("The type of Join used between lines, Square/Mitre or Curved/Bevel")]
	public ANLCMAAEPOJ EBJCHDKDDHA;

	[Tooltip("Bezier method to apply to line, see docs for options\nCan't be used in conjunction with Resolution as Bezier already changes the resolution")]
	public HKIFPABOGKE EHKPFCKJLHM;

	[HideInInspector]
	public bool HLIECFOLDHO;

	public float LPMLBOMMJBL
	{
		get
		{
			return lineThickness;
		}
		set
		{
			lineThickness = value;
			SetAllDirty();
		}
	}

	public bool FMPBJFCIFHF
	{
		get
		{
			return relativeSize;
		}
		set
		{
			relativeSize = value;
			SetAllDirty();
		}
	}

	public bool GOCJEIHEKBD
	{
		get
		{
			return lineList;
		}
		set
		{
			lineList = value;
			SetAllDirty();
		}
	}

	public bool PEAAOIELJMJ
	{
		get
		{
			return lineCaps;
		}
		set
		{
			lineCaps = value;
			SetAllDirty();
		}
	}

	public int MJDJIHEMAFJ
	{
		get
		{
			return bezierSegmentsPerCurve;
		}
		set
		{
			bezierSegmentsPerCurve = value;
		}
	}

	public Vector2[] EDEEPJMIFBD
	{
		get
		{
			return m_points;
		}
		set
		{
			if (m_points != value)
			{
				m_points = value;
				SetAllDirty();
			}
		}
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		if (m_points == null)
		{
			return;
		}
		MJKMNMCBIJG();
		Vector2[] array = m_points;
		if (EHKPFCKJLHM != HKIFPABOGKE.BLBOPPEBDFH && EHKPFCKJLHM != HKIFPABOGKE.FNFACFBJEAD && m_points.Length > 3)
		{
			INIHEEHAALK iNIHEEHAALK = new INIHEEHAALK();
			iNIHEEHAALK.BCPLMOOEIIE(array);
			iNIHEEHAALK.LBCIDJEGHJF = bezierSegmentsPerCurve;
			List<Vector2> list;
			switch (EHKPFCKJLHM)
			{
			case HKIFPABOGKE.CAMCKAOJDMG:
				list = iNIHEEHAALK.PFGOBBHIMJF();
				break;
			case HKIFPABOGKE.JIJBKEBKMCH:
				list = iNIHEEHAALK.CMDMCHFKLCE();
				break;
			default:
				list = iNIHEEHAALK.FKMECDLGGBM();
				break;
			}
			array = list.ToArray();
		}
		if (EHKPFCKJLHM == HKIFPABOGKE.FNFACFBJEAD && m_points.Length == 2)
		{
			CableCurve cableCurve = new CableCurve(array);
			cableCurve.slack = base.AEFDGHFEKLJ;
			cableCurve.steps = MJDJIHEMAFJ;
			array = cableCurve.EDEEPJMIFBD();
		}
		if (base.GOLBFNKNDMN != GKOFMHEFHDN.BLBOPPEBDFH)
		{
			array = HOLIHOCHFHN(array);
		}
		float num = (relativeSize ? base.rectTransform.rect.width : 1f);
		float num2 = (relativeSize ? base.rectTransform.rect.height : 1f);
		float num3 = (0f - base.rectTransform.pivot.x) * num;
		float num4 = (0f - base.rectTransform.pivot.y) * num2;
		MDEPPJOMAOE.Clear();
		List<UIVertex[]> list2 = new List<UIVertex[]>();
		if (lineList)
		{
			for (int i = 1; i < array.Length; i += 2)
			{
				Vector2 vector = array[i - 1];
				Vector2 vector2 = array[i];
				vector = new Vector2(vector.x * num + num3, vector.y * num2 + num4);
				vector2 = new Vector2(vector2.x * num + num3, vector2.y * num2 + num4);
				if (lineCaps)
				{
					list2.Add(IKMAFEEBKFK(vector, vector2, ODJFPKGLFEL.JMLAEOGOGDP));
				}
				list2.Add(MOEOGKEIGJF(vector, vector2, ODJFPKGLFEL.MMJHDGCOIID));
				if (lineCaps)
				{
					list2.Add(IKMAFEEBKFK(vector, vector2, ODJFPKGLFEL.OPKPJNINJNH));
				}
			}
		}
		else
		{
			for (int j = 1; j < array.Length; j++)
			{
				Vector2 vector3 = array[j - 1];
				Vector2 vector4 = array[j];
				vector3 = new Vector2(vector3.x * num + num3, vector3.y * num2 + num4);
				vector4 = new Vector2(vector4.x * num + num3, vector4.y * num2 + num4);
				if (lineCaps && j == 1)
				{
					list2.Add(IKMAFEEBKFK(vector3, vector4, ODJFPKGLFEL.JMLAEOGOGDP));
				}
				list2.Add(MOEOGKEIGJF(vector3, vector4, ODJFPKGLFEL.MMJHDGCOIID));
				if (lineCaps && j == array.Length - 1)
				{
					list2.Add(IKMAFEEBKFK(vector3, vector4, ODJFPKGLFEL.OPKPJNINJNH));
				}
			}
		}
		for (int k = 0; k < list2.Count; k++)
		{
			if (!lineList && k < list2.Count - 1)
			{
				Vector3 vector5 = list2[k][1].position - list2[k][2].position;
				Vector3 vector6 = list2[k + 1][2].position - list2[k + 1][1].position;
				float num5 = Vector2.Angle(vector5, vector6) * ((float)Math.PI / 180f);
				float num6 = Mathf.Sign(Vector3.Cross(vector5.normalized, vector6.normalized).z);
				float num7 = lineThickness / (2f * Mathf.Tan(num5 / 2f));
				Vector3 position = list2[k][2].position - vector5.normalized * num7 * num6;
				Vector3 position2 = list2[k][3].position + vector5.normalized * num7 * num6;
				ANLCMAAEPOJ aNLCMAAEPOJ = EBJCHDKDDHA;
				if (aNLCMAAEPOJ == ANLCMAAEPOJ.NMOCDBBEFAE)
				{
					if (num7 < vector5.magnitude / 2f && num7 < vector6.magnitude / 2f && num5 > (float)Math.PI / 12f)
					{
						list2[k][2].position = position;
						list2[k][3].position = position2;
						list2[k + 1][0].position = position2;
						list2[k + 1][1].position = position;
					}
					else
					{
						aNLCMAAEPOJ = ANLCMAAEPOJ.FGGFHKJMOPC;
					}
				}
				if (aNLCMAAEPOJ == ANLCMAAEPOJ.FGGFHKJMOPC)
				{
					if (num7 < vector5.magnitude / 2f && num7 < vector6.magnitude / 2f && num5 > (float)Math.PI / 6f)
					{
						if (num6 < 0f)
						{
							list2[k][2].position = position;
							list2[k + 1][1].position = position;
						}
						else
						{
							list2[k][3].position = position2;
							list2[k + 1][0].position = position2;
						}
					}
					UIVertex[] verts = new UIVertex[4]
					{
						list2[k][2],
						list2[k][3],
						list2[k + 1][0],
						list2[k + 1][1]
					};
					MDEPPJOMAOE.AddUIVertexQuad(verts);
				}
			}
			MDEPPJOMAOE.AddUIVertexQuad(list2[k]);
		}
		if (MDEPPJOMAOE.currentVertCount > 64000)
		{
			Debug.LogError("Max Verticies size is 64000, current mesh vertcies count is [" + MDEPPJOMAOE.currentVertCount + "] - Cannot Draw");
			MDEPPJOMAOE.Clear();
		}
	}

	private UIVertex[] IKMAFEEBKFK(Vector2 EHHGNIOBMDN, Vector2 HDMCLHKMFNO, ODJFPKGLFEL EBMKGCIKJCA)
	{
		switch (EBMKGCIKJCA)
		{
		case ODJFPKGLFEL.JMLAEOGOGDP:
		{
			Vector2 eHHGNIOBMDN = EHHGNIOBMDN - (HDMCLHKMFNO - EHHGNIOBMDN).normalized * lineThickness / 2f;
			return MOEOGKEIGJF(eHHGNIOBMDN, EHHGNIOBMDN, ODJFPKGLFEL.JMLAEOGOGDP);
		}
		case ODJFPKGLFEL.OPKPJNINJNH:
		{
			Vector2 hDMCLHKMFNO = HDMCLHKMFNO + (HDMCLHKMFNO - EHHGNIOBMDN).normalized * lineThickness / 2f;
			return MOEOGKEIGJF(HDMCLHKMFNO, hDMCLHKMFNO, ODJFPKGLFEL.OPKPJNINJNH);
		}
		default:
			Debug.LogError("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End");
			return null;
		}
	}

	private UIVertex[] MOEOGKEIGJF(Vector2 EHHGNIOBMDN, Vector2 HDMCLHKMFNO, ODJFPKGLFEL EBMKGCIKJCA)
	{
		Vector2 vector = new Vector2(EHHGNIOBMDN.y - HDMCLHKMFNO.y, HDMCLHKMFNO.x - EHHGNIOBMDN.x).normalized * lineThickness / 2f;
		Vector2 vector2 = EHHGNIOBMDN - vector;
		Vector2 vector3 = EHHGNIOBMDN + vector;
		Vector2 vector4 = HDMCLHKMFNO + vector;
		Vector2 vector5 = HDMCLHKMFNO - vector;
		switch (EBMKGCIKJCA)
		{
		case ODJFPKGLFEL.JMLAEOGOGDP:
			return COBPHKPBIAF(new Vector2[4] { vector2, vector3, vector4, vector5 }, NBHMJAJMCKB);
		case ODJFPKGLFEL.OPKPJNINJNH:
			return COBPHKPBIAF(new Vector2[4] { vector2, vector3, vector4, vector5 }, HAOOBAABPFL);
		case ODJFPKGLFEL.KMIHCDNNONL:
			return COBPHKPBIAF(new Vector2[4] { vector2, vector3, vector4, vector5 }, IGNBCEFHGNA);
		default:
			return COBPHKPBIAF(new Vector2[4] { vector2, vector3, vector4, vector5 }, GBMAHLOAMFE);
		}
	}

	protected override void MJKMNMCBIJG()
	{
		if (base.GGCJMOJEIGI != null)
		{
			Vector4 outerUV = DataUtility.GetOuterUV(base.GGCJMOJEIGI);
			Vector4 innerUV = DataUtility.GetInnerUV(base.GGCJMOJEIGI);
			OFOLGPJACME = new Vector2(outerUV.x, outerUV.y);
			MGOIILJDNIB = new Vector2(outerUV.x, outerUV.w);
			JCJFDMBGCAL = new Vector2(innerUV.x, innerUV.y);
			PBFCFIOGKCF = new Vector2(innerUV.z, innerUV.y);
			KEKGHIMJKLB = new Vector2(innerUV.x, innerUV.w);
			NGOGKPHBALM = new Vector2(innerUV.z, innerUV.w);
			FCDNNPAKBEC = new Vector2(outerUV.z, outerUV.y);
			HDCNHKECDND = new Vector2(outerUV.z, outerUV.w);
		}
		else
		{
			OFOLGPJACME = Vector2.zero;
			MGOIILJDNIB = new Vector2(0f, 1f);
			JCJFDMBGCAL = new Vector2(0.5f, 0f);
			PBFCFIOGKCF = new Vector2(0.5f, 0f);
			KEKGHIMJKLB = new Vector2(0.5f, 1f);
			NGOGKPHBALM = new Vector2(0.5f, 1f);
			FCDNNPAKBEC = new Vector2(1f, 0f);
			HDCNHKECDND = Vector2.one;
		}
		NBHMJAJMCKB = new Vector2[4] { OFOLGPJACME, MGOIILJDNIB, KEKGHIMJKLB, JCJFDMBGCAL };
		GBMAHLOAMFE = new Vector2[4] { JCJFDMBGCAL, KEKGHIMJKLB, NGOGKPHBALM, PBFCFIOGKCF };
		HAOOBAABPFL = new Vector2[4] { PBFCFIOGKCF, NGOGKPHBALM, HDCNHKECDND, FCDNNPAKBEC };
		IGNBCEFHGNA = new Vector2[4] { OFOLGPJACME, MGOIILJDNIB, HDCNHKECDND, FCDNNPAKBEC };
	}

	protected override void ILMCHGCPMNE(float IBKGHLIGCBN)
	{
		if (base.GKJPIBDFADG)
		{
			m_Resolution = IBKGHLIGCBN / (base.GGCJMOJEIGI.rect.width / base.HBABEIIIBLC);
			lineThickness = base.GGCJMOJEIGI.rect.height / base.HBABEIIIBLC;
		}
	}
}
