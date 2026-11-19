using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CKDCMPPJAKL), typeof(RawImage))]
[ExecuteInEditMode]
public class MBPEALGPJME : MonoBehaviour
{
	public KFANEHLIPBI MBFJEBHOFCC;

	private CKDCMPPJAKL PDPNNLBIHCG;

	private RawImage GBCLDBHACGH;

	private float LGCBPBONOCN = -1f;

	private bool ONMGFAMDBAN = true;

	public RectTransform DEPMLKMBMFP => base.transform as RectTransform;

	private void Awake()
	{
		PDPNNLBIHCG = GetComponent<CKDCMPPJAKL>();
		GBCLDBHACGH = GetComponent<RawImage>();
		KDPIGOHFEKM();
	}

	private void OnEnable()
	{
		if (Application.isPlaying && MBFJEBHOFCC != null)
		{
			PDPNNLBIHCG.ICOHIIJIPHE.AddListener(CFHIJPEBFHI);
			MBFJEBHOFCC.HAKHGCCNIAJ.AddListener(EDFOHOLLKJO);
		}
	}

	private void OnDisable()
	{
		if (MBFJEBHOFCC != null)
		{
			PDPNNLBIHCG.ICOHIIJIPHE.RemoveListener(CFHIJPEBFHI);
			MBFJEBHOFCC.HAKHGCCNIAJ.RemoveListener(EDFOHOLLKJO);
		}
	}

	private void OnDestroy()
	{
		if (GBCLDBHACGH.texture != null)
		{
			Object.DestroyImmediate(GBCLDBHACGH.texture);
		}
	}

	private void CFHIJPEBFHI(float CDDPBGMABAJ, float EHAPKEKPMOE)
	{
		if (ONMGFAMDBAN)
		{
			MBFJEBHOFCC.JLJKHPPCGLH(OBFKGLEJBII.GFMADABILAD, CDDPBGMABAJ);
			MBFJEBHOFCC.JLJKHPPCGLH(OBFKGLEJBII.JFLFLCDEEEI, EHAPKEKPMOE);
		}
		ONMGFAMDBAN = true;
	}

	private void EDFOHOLLKJO(float MBIEHEGKCMN, float LGNIFJCEECH, float PDAKFGKELOC)
	{
		if (LGCBPBONOCN != MBIEHEGKCMN)
		{
			LGCBPBONOCN = MBIEHEGKCMN;
			KDPIGOHFEKM();
		}
		if (LGNIFJCEECH != PDPNNLBIHCG.NHPABFOCMIA)
		{
			ONMGFAMDBAN = false;
			PDPNNLBIHCG.NHPABFOCMIA = LGNIFJCEECH;
		}
		if (PDAKFGKELOC != PDPNNLBIHCG.NGCBJCIOABB)
		{
			ONMGFAMDBAN = false;
			PDPNNLBIHCG.NGCBJCIOABB = PDAKFGKELOC;
		}
	}

	private void KDPIGOHFEKM()
	{
		double mBIEHEGKCMN = ((!(MBFJEBHOFCC != null)) ? 0f : (MBFJEBHOFCC.POELOAELGLA * 360f));
		if (GBCLDBHACGH.texture != null)
		{
			Object.DestroyImmediate(GBCLDBHACGH.texture);
		}
		Texture2D texture2D = new Texture2D(100, 100);
		texture2D.hideFlags = HideFlags.DontSave;
		Texture2D texture2D2 = texture2D;
		for (int i = 0; i < 100; i++)
		{
			Color32[] array = new Color32[100];
			for (int j = 0; j < 100; j++)
			{
				ref Color32 reference = ref array[j];
				reference = KOLKGOKNADN.NAHEPBDDFPJ(mBIEHEGKCMN, (float)i / 100f, (float)j / 100f, 1f);
			}
			texture2D2.SetPixels32(i, 0, 1, 100, array);
		}
		texture2D2.Apply();
		GBCLDBHACGH.texture = texture2D2;
	}
}
