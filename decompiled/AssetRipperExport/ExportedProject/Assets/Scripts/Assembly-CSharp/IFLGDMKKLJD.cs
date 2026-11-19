using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

[AddComponentMenu("UI/Effects/Extensions/Curly UI Graphic")]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Graphic))]
[DisallowMultipleComponent]
public class IFLGDMKKLJD : BaseMeshEffect
{
	public static readonly int NMGIDKGJKCM;

	public static readonly int KMCFNHDBNMO = 1;

	[SerializeField]
	[Tooltip("Set true to make the curve/morph to work. Set false to quickly see the original UI.")]
	protected bool isCurved = true;

	[SerializeField]
	[Tooltip("Set true to dynamically change the curve according to the dynamic change of the UI layout")]
	protected bool isLockWithRatio = true;

	[SerializeField]
	[Tooltip("Pick a higher resolution to improve the quality of the curved graphic.")]
	[Range(0.01f, 30f)]
	protected float resolution = 5f;

	protected RectTransform NIKILPJFCBI;

	[SerializeField]
	[Tooltip("Put in the Graphic you want to curve/morph here.")]
	protected Graphic uiGraphic;

	[Tooltip("Put in the reference Graphic that will be used to tune the bezier curves. Think button image and text.")]
	[SerializeField]
	protected IFLGDMKKLJD refCUIGraphic;

	[Tooltip("Do not touch this unless you are sure what you are doing. The curves are (re)generated automatically.")]
	[SerializeField]
	protected DDIJIMGJGMK[] refCurves;

	[HideInInspector]
	[SerializeField]
	protected Vector3_Array2D[] refCurvesControlRatioPoints;

	protected List<UIVertex> EJAFFCEPEOI = new List<UIVertex>();

	public bool CADKCILFAPM
	{
		get
		{
			return isCurved;
		}
	}

	public bool ALOJJGFDNMA
	{
		get
		{
			return isLockWithRatio;
		}
	}

	public RectTransform GAFNECPDALL
	{
		get
		{
			return NIKILPJFCBI;
		}
	}

	public Graphic INPKAEAEKIH
	{
		get
		{
			return uiGraphic;
		}
	}

	public IFLGDMKKLJD FLDHPIHELPL
	{
		get
		{
			return refCUIGraphic;
		}
	}

	public DDIJIMGJGMK[] NJGKNBMPJKK
	{
		get
		{
			return refCurves;
		}
	}

	public Vector3_Array2D[] GBCCAPLDHMP
	{
		get
		{
			return refCurvesControlRatioPoints;
		}
	}

	protected void OJOHJIPKMIJ(float FBODPHNMOIG, float FLNODNOGHNF, float JPFHJPEGGDM, float DLOAEFAIOGJ, Vector3 NBINFOBCHLD, Vector3 JDMLCEEDJLL, out Vector3 JHPECKIOIPK, out Vector3 OKAIKCDHMEP)
	{
		if (Mathf.Abs(FBODPHNMOIG) > Mathf.Abs(JPFHJPEGGDM))
		{
			Vector3 vector = NBINFOBCHLD * JPFHJPEGGDM / FBODPHNMOIG;
			float num = FLNODNOGHNF * JPFHJPEGGDM / FBODPHNMOIG;
			OKAIKCDHMEP = (JDMLCEEDJLL - vector) / (DLOAEFAIOGJ - num);
			if (JPFHJPEGGDM != 0f)
			{
				JHPECKIOIPK = (vector - num * OKAIKCDHMEP) / JPFHJPEGGDM;
			}
			else
			{
				JHPECKIOIPK = (NBINFOBCHLD - FLNODNOGHNF * OKAIKCDHMEP) / FBODPHNMOIG;
			}
		}
		else
		{
			Vector3 vector = JDMLCEEDJLL * FBODPHNMOIG / JPFHJPEGGDM;
			float num = DLOAEFAIOGJ * FBODPHNMOIG / JPFHJPEGGDM;
			JHPECKIOIPK = (NBINFOBCHLD - vector) / (FLNODNOGHNF - num);
			if (FBODPHNMOIG != 0f)
			{
				OKAIKCDHMEP = (vector - num * JHPECKIOIPK) / FBODPHNMOIG;
			}
			else
			{
				OKAIKCDHMEP = (JDMLCEEDJLL - DLOAEFAIOGJ * JHPECKIOIPK) / JPFHJPEGGDM;
			}
		}
	}

	protected UIVertex NMJLAOANHJG(UIVertex GONKOMBMBNH, UIVertex GCALMFOEMML, float IBBNGFPAKHJ)
	{
		return new UIVertex
		{
			position = Vector3.Lerp(GONKOMBMBNH.position, GCALMFOEMML.position, IBBNGFPAKHJ),
			normal = Vector3.Lerp(GONKOMBMBNH.normal, GCALMFOEMML.normal, IBBNGFPAKHJ),
			tangent = Vector3.Lerp(GONKOMBMBNH.tangent, GCALMFOEMML.tangent, IBBNGFPAKHJ),
			uv0 = Vector2.Lerp(GONKOMBMBNH.uv0, GCALMFOEMML.uv0, IBBNGFPAKHJ),
			uv1 = Vector2.Lerp(GONKOMBMBNH.uv1, GCALMFOEMML.uv1, IBBNGFPAKHJ),
			color = Color.Lerp(GONKOMBMBNH.color, GCALMFOEMML.color, IBBNGFPAKHJ)
		};
	}

	protected UIVertex DHHCOPBBMIG(UIVertex GGGNPEIKOLK, UIVertex FJMMEFAMAJE, UIVertex EOBNLEJEHIO, UIVertex DNGGIOIDGAD, float OMFCFAOAAJL, float GIJODLFONKF)
	{
		UIVertex gCALMFOEMML = NMJLAOANHJG(FJMMEFAMAJE, EOBNLEJEHIO, OMFCFAOAAJL);
		UIVertex gONKOMBMBNH = NMJLAOANHJG(GGGNPEIKOLK, DNGGIOIDGAD, OMFCFAOAAJL);
		return NMJLAOANHJG(gONKOMBMBNH, gCALMFOEMML, GIJODLFONKF);
	}

	protected void IMHDPHLKBOA(List<UIVertex> CLBKDPLDKMM, int OIINIHAPACL)
	{
		UIVertex gGGNPEIKOLK = CLBKDPLDKMM[OIINIHAPACL];
		UIVertex fJMMEFAMAJE = CLBKDPLDKMM[OIINIHAPACL + 1];
		UIVertex eOBNLEJEHIO = CLBKDPLDKMM[OIINIHAPACL + 2];
		UIVertex dNGGIOIDGAD = CLBKDPLDKMM[OIINIHAPACL + 3];
		float num = 100f / resolution;
		int num2 = Mathf.Max(1, Mathf.CeilToInt((fJMMEFAMAJE.position - gGGNPEIKOLK.position).magnitude / num));
		int num3 = Mathf.Max(1, Mathf.CeilToInt((eOBNLEJEHIO.position - fJMMEFAMAJE.position).magnitude / num));
		int num4 = 0;
		for (int i = 0; i < num3; i++)
		{
			int num5 = 0;
			while (num5 < num2)
			{
				CLBKDPLDKMM.Add(default(UIVertex));
				CLBKDPLDKMM.Add(default(UIVertex));
				CLBKDPLDKMM.Add(default(UIVertex));
				CLBKDPLDKMM.Add(default(UIVertex));
				float oMFCFAOAAJL = (float)i / (float)num3;
				float gIJODLFONKF = (float)num5 / (float)num2;
				float oMFCFAOAAJL2 = (float)(i + 1) / (float)num3;
				float gIJODLFONKF2 = (float)(num5 + 1) / (float)num2;
				CLBKDPLDKMM[CLBKDPLDKMM.Count - 4] = DHHCOPBBMIG(gGGNPEIKOLK, fJMMEFAMAJE, eOBNLEJEHIO, dNGGIOIDGAD, oMFCFAOAAJL, gIJODLFONKF);
				CLBKDPLDKMM[CLBKDPLDKMM.Count - 3] = DHHCOPBBMIG(gGGNPEIKOLK, fJMMEFAMAJE, eOBNLEJEHIO, dNGGIOIDGAD, oMFCFAOAAJL, gIJODLFONKF2);
				CLBKDPLDKMM[CLBKDPLDKMM.Count - 2] = DHHCOPBBMIG(gGGNPEIKOLK, fJMMEFAMAJE, eOBNLEJEHIO, dNGGIOIDGAD, oMFCFAOAAJL2, gIJODLFONKF2);
				CLBKDPLDKMM[CLBKDPLDKMM.Count - 1] = DHHCOPBBMIG(gGGNPEIKOLK, fJMMEFAMAJE, eOBNLEJEHIO, dNGGIOIDGAD, oMFCFAOAAJL2, gIJODLFONKF);
				num5++;
				num4++;
			}
		}
	}

	protected void JJPNBOLNGLD(List<UIVertex> MKGCMGECOLD)
	{
		for (int i = 0; i < MKGCMGECOLD.Count; i += 6)
		{
			EJAFFCEPEOI.Add(MKGCMGECOLD[i]);
			EJAFFCEPEOI.Add(MKGCMGECOLD[i + 1]);
			EJAFFCEPEOI.Add(MKGCMGECOLD[i + 2]);
			EJAFFCEPEOI.Add(MKGCMGECOLD[i + 4]);
		}
		int num = EJAFFCEPEOI.Count / 4;
		for (int j = 0; j < num; j++)
		{
			IMHDPHLKBOA(EJAFFCEPEOI, j * 4);
		}
		EJAFFCEPEOI.RemoveRange(0, num * 4);
		MKGCMGECOLD.Clear();
		for (int k = 0; k < EJAFFCEPEOI.Count; k += 4)
		{
			MKGCMGECOLD.Add(EJAFFCEPEOI[k]);
			MKGCMGECOLD.Add(EJAFFCEPEOI[k + 1]);
			MKGCMGECOLD.Add(EJAFFCEPEOI[k + 2]);
			MKGCMGECOLD.Add(EJAFFCEPEOI[k + 2]);
			MKGCMGECOLD.Add(EJAFFCEPEOI[k + 3]);
			MKGCMGECOLD.Add(EJAFFCEPEOI[k]);
		}
		EJAFFCEPEOI.Clear();
	}

	protected override void OnRectTransformDimensionsChange()
	{
		if (isLockWithRatio)
		{
			AGJKJPBLMIE();
		}
	}

	public void CLANABPJJJA()
	{
		ONKNMHJOJIL();
		for (int i = 0; i < refCurves.Length; i++)
		{
			DDIJIMGJGMK dDIJIMGJGMK = refCurves[i];
			if (dDIJIMGJGMK.CBLOMNNONOC != null)
			{
				Vector3[] array = dDIJIMGJGMK.CBLOMNNONOC;
				for (int j = 0; j < DDIJIMGJGMK.OJOBPALIPDN; j++)
				{
					Vector3 eHAPKEKPMOE = array[j];
					eHAPKEKPMOE.x = (eHAPKEKPMOE.x + NIKILPJFCBI.rect.width * NIKILPJFCBI.pivot.x) / NIKILPJFCBI.rect.width;
					eHAPKEKPMOE.y = (eHAPKEKPMOE.y + NIKILPJFCBI.rect.height * NIKILPJFCBI.pivot.y) / NIKILPJFCBI.rect.height;
					refCurvesControlRatioPoints[i][j] = eHAPKEKPMOE;
				}
			}
		}
		if (uiGraphic != null)
		{
			uiGraphic.enabled = false;
			uiGraphic.enabled = true;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		OnRectTransformDimensionsChange();
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		OnRectTransformDimensionsChange();
	}

	public virtual void ONKNMHJOJIL()
	{
		if (NIKILPJFCBI == null)
		{
			NIKILPJFCBI = GetComponent<RectTransform>();
		}
		if (refCurves == null)
		{
			refCurves = new DDIJIMGJGMK[2];
		}
		bool flag = true;
		for (int i = 0; i < 2; i++)
		{
			flag &= refCurves[i] != null;
		}
		if (!(flag & (refCurves.Length == 2)))
		{
			DDIJIMGJGMK[] array = refCurves;
			for (int j = 0; j < 2; j++)
			{
				if (refCurves[j] == null)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.SetParent(base.transform);
					gameObject.transform.localPosition = Vector3.zero;
					gameObject.transform.localEulerAngles = Vector3.zero;
					if (j == 0)
					{
						gameObject.name = "BottomRefCurve";
					}
					else
					{
						gameObject.name = "TopRefCurve";
					}
					array[j] = gameObject.AddComponent<DDIJIMGJGMK>();
				}
				else
				{
					array[j] = refCurves[j];
				}
				array[j].ONKNMHJOJIL();
			}
			refCurves = array;
		}
		if (refCurvesControlRatioPoints == null)
		{
			refCurvesControlRatioPoints = new Vector3_Array2D[refCurves.Length];
			for (int k = 0; k < refCurves.Length; k++)
			{
				refCurvesControlRatioPoints[k].array = new Vector3[refCurves[k].CBLOMNNONOC.Length];
			}
			NNINDMFLHAC();
			CLANABPJJJA();
		}
		for (int l = 0; l < 2; l++)
		{
			refCurves[l].NLPJCKPCAHJ = CLANABPJJJA;
		}
	}

	public void NNINDMFLHAC()
	{
		for (int i = 0; i < refCurves.Length; i++)
		{
			DDIJIMGJGMK dDIJIMGJGMK = refCurves[i];
			for (int j = 0; j < DDIJIMGJGMK.OJOBPALIPDN; j++)
			{
				if (dDIJIMGJGMK.CBLOMNNONOC != null)
				{
					Vector3[] array = dDIJIMGJGMK.CBLOMNNONOC;
					if (i == 0)
					{
						array[j].y = (0f - NIKILPJFCBI.rect.height) * NIKILPJFCBI.pivot.y;
					}
					else
					{
						array[j].y = NIKILPJFCBI.rect.height - NIKILPJFCBI.rect.height * NIKILPJFCBI.pivot.y;
					}
					array[j].x = NIKILPJFCBI.rect.width * (float)j / (float)(DDIJIMGJGMK.OJOBPALIPDN - 1);
					array[j].x -= NIKILPJFCBI.rect.width * NIKILPJFCBI.pivot.x;
					array[j].z = 0f;
				}
			}
		}
	}

	public void PNGPNDHCHDJ()
	{
		Vector3 localPosition = NIKILPJFCBI.localPosition;
		localPosition.x += (0f - NIKILPJFCBI.rect.width) * NIKILPJFCBI.pivot.x + refCUIGraphic.NIKILPJFCBI.rect.width * refCUIGraphic.NIKILPJFCBI.pivot.x;
		localPosition.y += (0f - NIKILPJFCBI.rect.height) * NIKILPJFCBI.pivot.y + refCUIGraphic.NIKILPJFCBI.rect.height * refCUIGraphic.NIKILPJFCBI.pivot.y;
		Vector3 vector = new Vector3(localPosition.x / refCUIGraphic.GAFNECPDALL.rect.width, localPosition.y / refCUIGraphic.GAFNECPDALL.rect.height, localPosition.z);
		Vector3 vector2 = new Vector3((localPosition.x + NIKILPJFCBI.rect.width) / refCUIGraphic.GAFNECPDALL.rect.width, (localPosition.y + NIKILPJFCBI.rect.height) / refCUIGraphic.GAFNECPDALL.rect.height, localPosition.z);
		refCurves[0].CBLOMNNONOC[0] = refCUIGraphic.LMBLAIAFEPA(vector.x, vector.y) - NIKILPJFCBI.localPosition;
		refCurves[0].CBLOMNNONOC[3] = refCUIGraphic.LMBLAIAFEPA(vector2.x, vector.y) - NIKILPJFCBI.localPosition;
		refCurves[1].CBLOMNNONOC[0] = refCUIGraphic.LMBLAIAFEPA(vector.x, vector2.y) - NIKILPJFCBI.localPosition;
		refCurves[1].CBLOMNNONOC[3] = refCUIGraphic.LMBLAIAFEPA(vector2.x, vector2.y) - NIKILPJFCBI.localPosition;
		for (int i = 0; i < refCurves.Length; i++)
		{
			DDIJIMGJGMK dDIJIMGJGMK = refCurves[i];
			float gIJODLFONKF = ((i != 0) ? vector2.y : vector.y);
			Vector3 vector3 = refCUIGraphic.LMBLAIAFEPA(vector.x, gIJODLFONKF);
			Vector3 vector4 = refCUIGraphic.LMBLAIAFEPA(vector2.x, gIJODLFONKF);
			float num = 0.25f;
			float num2 = 0.75f;
			Vector3 vector5 = refCUIGraphic.LMBLAIAFEPA((vector.x * 0.75f + vector2.x * 0.25f) / 1f, gIJODLFONKF);
			Vector3 vector6 = refCUIGraphic.LMBLAIAFEPA((vector.x * 0.25f + vector2.x * 0.75f) / 1f, gIJODLFONKF);
			float fBODPHNMOIG = 3f * num2 * num2 * num;
			float fLNODNOGHNF = 3f * num2 * num * num;
			float jPFHJPEGGDM = 3f * num * num * num2;
			float dLOAEFAIOGJ = 3f * num * num2 * num2;
			Vector3 nBINFOBCHLD = vector5 - Mathf.Pow(num2, 3f) * vector3 - Mathf.Pow(num, 3f) * vector4;
			Vector3 jDMLCEEDJLL = vector6 - Mathf.Pow(num, 3f) * vector3 - Mathf.Pow(num2, 3f) * vector4;
			Vector3 JHPECKIOIPK;
			Vector3 OKAIKCDHMEP;
			OJOHJIPKMIJ(fBODPHNMOIG, fLNODNOGHNF, jPFHJPEGGDM, dLOAEFAIOGJ, nBINFOBCHLD, jDMLCEEDJLL, out JHPECKIOIPK, out OKAIKCDHMEP);
			dDIJIMGJGMK.CBLOMNNONOC[1] = JHPECKIOIPK - NIKILPJFCBI.localPosition;
			dDIJIMGJGMK.CBLOMNNONOC[2] = OKAIKCDHMEP - NIKILPJFCBI.localPosition;
		}
	}

	public override void ModifyMesh(Mesh ECIDJKLBDGH)
	{
		if (!IsActive())
		{
			return;
		}
		using (VertexHelper vertexHelper = new VertexHelper(ECIDJKLBDGH))
		{
			ModifyMesh(vertexHelper);
			vertexHelper.FillMesh(ECIDJKLBDGH);
		}
	}

	public override void ModifyMesh(VertexHelper GJLGOKNCKPB)
	{
		if (IsActive())
		{
			List<UIVertex> list = new List<UIVertex>();
			GJLGOKNCKPB.GetUIVertexStream(list);
			CIAPLCOBLCO(list);
			GJLGOKNCKPB.Clear();
			GJLGOKNCKPB.AddUIVertexTriangleStream(list);
		}
	}

	protected virtual void CIAPLCOBLCO(List<UIVertex> MKGCMGECOLD)
	{
		if (!IsActive())
		{
			return;
		}
		JJPNBOLNGLD(MKGCMGECOLD);
		if (isCurved)
		{
			for (int i = 0; i < MKGCMGECOLD.Count; i++)
			{
				UIVertex value = MKGCMGECOLD[i];
				float oMFCFAOAAJL = (value.position.x + NIKILPJFCBI.rect.width * NIKILPJFCBI.pivot.x) / NIKILPJFCBI.rect.width;
				float gIJODLFONKF = (value.position.y + NIKILPJFCBI.rect.height * NIKILPJFCBI.pivot.y) / NIKILPJFCBI.rect.height;
				Vector3 vector = LMBLAIAFEPA(oMFCFAOAAJL, gIJODLFONKF);
				value.position.x = vector.x;
				value.position.y = vector.y;
				value.position.z = vector.z;
				MKGCMGECOLD[i] = value;
			}
		}
	}

	public void AGJKJPBLMIE()
	{
		ONKNMHJOJIL();
		for (int i = 0; i < refCurves.Length; i++)
		{
			DDIJIMGJGMK dDIJIMGJGMK = refCurves[i];
			for (int j = 0; j < refCurves[i].CBLOMNNONOC.Length; j++)
			{
				Vector3 vector = refCurvesControlRatioPoints[i][j];
				vector.x = vector.x * NIKILPJFCBI.rect.width - NIKILPJFCBI.rect.width * NIKILPJFCBI.pivot.x;
				vector.y = vector.y * NIKILPJFCBI.rect.height - NIKILPJFCBI.rect.height * NIKILPJFCBI.pivot.y;
				dDIJIMGJGMK.CBLOMNNONOC[j] = vector;
			}
		}
	}

	public Vector3 LMBLAIAFEPA(float OMFCFAOAAJL, float GIJODLFONKF)
	{
		return refCurves[0].KCPJFPFEPJP(OMFCFAOAAJL) * (1f - GIJODLFONKF) + refCurves[1].KCPJFPFEPJP(OMFCFAOAAJL) * GIJODLFONKF;
	}

	public Vector3 OLMNAKLBEBL(float OMFCFAOAAJL, float GIJODLFONKF)
	{
		return refCurves[0].OHHONFKNPDF(OMFCFAOAAJL) * (1f - GIJODLFONKF) + refCurves[1].OHHONFKNPDF(OMFCFAOAAJL) * GIJODLFONKF;
	}
}
