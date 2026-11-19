using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/Gradient2")]
public class MENLCNEOKDN : BaseMeshEffect
{
	public enum CLIODJOGALB
	{
		CKGPDOGEHBB,
		IOKNFMCJIHM,
		MANFOMEGBIG,
		GOIPIABGLDO
	}

	public enum OHGJHHFDFNN
	{
		PHAOABENJFD,
		IPDNNOIOAIO,
		CEMBAKNBMAB
	}

	[SerializeField]
	private CLIODJOGALB _gradientType;

	[SerializeField]
	private OHGJHHFDFNN _blendMode = OHGJHHFDFNN.CEMBAKNBMAB;

	[SerializeField]
	[Range(-1f, 1f)]
	private float _offset;

	[SerializeField]
	private Gradient _effectGradient = new Gradient
	{
		colorKeys = new GradientColorKey[2]
		{
			new GradientColorKey(Color.black, 0f),
			new GradientColorKey(Color.white, 1f)
		}
	};

	public OHGJHHFDFNN PAPAOOAOCKG
	{
		get
		{
			return _blendMode;
		}
		set
		{
			_blendMode = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public Gradient NDAFEFCCMFC
	{
		get
		{
			return _effectGradient;
		}
		set
		{
			_effectGradient = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public CLIODJOGALB MGHLKELBLHH
	{
		get
		{
			return _gradientType;
		}
		set
		{
			_gradientType = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public float KFEKPJGEICF
	{
		get
		{
			return _offset;
		}
		set
		{
			_offset = value;
			base.graphic.SetVerticesDirty();
		}
	}

	public override void ModifyMesh(VertexHelper FCMFLHJNHCI)
	{
		if (!IsActive() || FCMFLHJNHCI.currentVertCount == 0)
		{
			return;
		}
		List<UIVertex> list = new List<UIVertex>();
		FCMFLHJNHCI.GetUIVertexStream(list);
		int count = list.Count;
		switch (MGHLKELBLHH)
		{
		case CLIODJOGALB.CKGPDOGEHBB:
		{
			float num30 = list[0].position.x;
			float num31 = list[0].position.x;
			float num32 = 0f;
			for (int num33 = count - 1; num33 >= 1; num33--)
			{
				num32 = list[num33].position.x;
				if (num32 > num31)
				{
					num31 = num32;
				}
				else if (num32 < num30)
				{
					num30 = num32;
				}
			}
			float num34 = 1f / (num31 - num30);
			UIVertex vertex4 = default(UIVertex);
			for (int num35 = 0; num35 < FCMFLHJNHCI.currentVertCount; num35++)
			{
				FCMFLHJNHCI.PopulateUIVertex(ref vertex4, num35);
				vertex4.color = JJPFILNCKHD(vertex4.color, NDAFEFCCMFC.Evaluate((vertex4.position.x - num30) * num34 - KFEKPJGEICF));
				FCMFLHJNHCI.SetUIVertex(vertex4, num35);
			}
			break;
		}
		case CLIODJOGALB.IOKNFMCJIHM:
		{
			float num18 = list[0].position.y;
			float num19 = list[0].position.y;
			float num20 = 0f;
			for (int num21 = count - 1; num21 >= 1; num21--)
			{
				num20 = list[num21].position.y;
				if (num20 > num19)
				{
					num19 = num20;
				}
				else if (num20 < num18)
				{
					num18 = num20;
				}
			}
			float num22 = 1f / (num19 - num18);
			UIVertex vertex2 = default(UIVertex);
			for (int l = 0; l < FCMFLHJNHCI.currentVertCount; l++)
			{
				FCMFLHJNHCI.PopulateUIVertex(ref vertex2, l);
				vertex2.color = JJPFILNCKHD(vertex2.color, NDAFEFCCMFC.Evaluate((vertex2.position.y - num18) * num22 - KFEKPJGEICF));
				FCMFLHJNHCI.SetUIVertex(vertex2, l);
			}
			break;
		}
		case CLIODJOGALB.GOIPIABGLDO:
		{
			float num23 = list[0].position.y;
			float num24 = list[0].position.y;
			float num25 = 0f;
			for (int num26 = count - 1; num26 >= 1; num26--)
			{
				num25 = list[num26].position.y;
				if (num25 > num24)
				{
					num24 = num25;
				}
				else if (num25 < num23)
				{
					num23 = num25;
				}
			}
			float num27 = 1f / (num24 - num23);
			FCMFLHJNHCI.Clear();
			for (int m = 0; m < count; m++)
			{
				FCMFLHJNHCI.AddVert(list[m]);
			}
			float num28 = (num23 + num24) / 2f;
			UIVertex v3 = default(UIVertex);
			v3.position = (Vector3.right + Vector3.up) * num28 + Vector3.forward * list[0].position.z;
			v3.normal = list[0].normal;
			v3.color = Color.white;
			FCMFLHJNHCI.AddVert(v3);
			for (int n = 1; n < count; n++)
			{
				FCMFLHJNHCI.AddTriangle(n - 1, n, count);
			}
			FCMFLHJNHCI.AddTriangle(0, count - 1, count);
			UIVertex vertex3 = default(UIVertex);
			for (int num29 = 0; num29 < FCMFLHJNHCI.currentVertCount; num29++)
			{
				FCMFLHJNHCI.PopulateUIVertex(ref vertex3, num29);
				vertex3.color = JJPFILNCKHD(vertex3.color, NDAFEFCCMFC.Evaluate(Vector3.Distance(vertex3.position, v3.position) * num27 - KFEKPJGEICF));
				FCMFLHJNHCI.SetUIVertex(vertex3, num29);
			}
			break;
		}
		case CLIODJOGALB.MANFOMEGBIG:
		{
			float num = list[0].position.x;
			float num2 = list[0].position.x;
			float num3 = list[0].position.y;
			float num4 = list[0].position.y;
			float num5 = 0f;
			float num6 = 0f;
			for (int num7 = count - 1; num7 >= 1; num7--)
			{
				num5 = list[num7].position.x;
				if (num5 > num2)
				{
					num2 = num5;
				}
				else if (num5 < num)
				{
					num = num5;
				}
				num6 = list[num7].position.y;
				if (num6 > num4)
				{
					num4 = num6;
				}
				else if (num6 < num3)
				{
					num3 = num6;
				}
			}
			float num8 = 1f / (num2 - num);
			float num9 = 1f / (num4 - num3);
			FCMFLHJNHCI.Clear();
			float num10 = (num2 + num) / 2f;
			float num11 = (num3 + num4) / 2f;
			float num12 = (num2 - num) / 2f;
			float num13 = (num4 - num3) / 2f;
			UIVertex v = default(UIVertex);
			v.position = Vector3.right * num10 + Vector3.up * num11 + Vector3.forward * list[0].position.z;
			v.normal = list[0].normal;
			v.color = Color.white;
			int num14 = 64;
			for (int i = 0; i < num14; i++)
			{
				UIVertex v2 = default(UIVertex);
				float num15 = (float)i * 360f / (float)num14;
				float num16 = Mathf.Cos((float)Math.PI / 180f * num15) * num12;
				float num17 = Mathf.Sin((float)Math.PI / 180f * num15) * num13;
				v2.position = Vector3.right * num16 + Vector3.up * num17 + Vector3.forward * list[0].position.z;
				v2.normal = list[0].normal;
				v2.color = Color.white;
				FCMFLHJNHCI.AddVert(v2);
			}
			FCMFLHJNHCI.AddVert(v);
			for (int j = 1; j < num14; j++)
			{
				FCMFLHJNHCI.AddTriangle(j - 1, j, num14);
			}
			FCMFLHJNHCI.AddTriangle(0, num14 - 1, num14);
			UIVertex vertex = default(UIVertex);
			for (int k = 0; k < FCMFLHJNHCI.currentVertCount; k++)
			{
				FCMFLHJNHCI.PopulateUIVertex(ref vertex, k);
				vertex.color = JJPFILNCKHD(vertex.color, NDAFEFCCMFC.Evaluate(Mathf.Sqrt(Mathf.Pow(Mathf.Abs(vertex.position.x - num10) * num8, 2f) + Mathf.Pow(Mathf.Abs(vertex.position.y - num11) * num9, 2f)) * 2f - KFEKPJGEICF));
				FCMFLHJNHCI.SetUIVertex(vertex, k);
			}
			break;
		}
		}
	}

	private Color JJPFILNCKHD(Color LIDKNOPFLIM, Color MPMFJMHKAEH)
	{
		return PAPAOOAOCKG switch
		{
			OHGJHHFDFNN.IPDNNOIOAIO => LIDKNOPFLIM + MPMFJMHKAEH, 
			OHGJHHFDFNN.CEMBAKNBMAB => LIDKNOPFLIM * MPMFJMHKAEH, 
			_ => MPMFJMHKAEH, 
		};
	}
}
