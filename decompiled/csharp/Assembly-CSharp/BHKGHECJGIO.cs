using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
[ExecuteInEditMode]
public class BHKGHECJGIO : MonoBehaviour
{
	public KFANEHLIPBI MBFJEBHOFCC;

	public OBFKGLEJBII EBMKGCIKJCA;

	public Slider.Direction BADIHIKMKJF;

	private RawImage GBCLDBHACGH;

	private RectTransform DEPMLKMBMFP => base.transform as RectTransform;

	private void Awake()
	{
		GBCLDBHACGH = GetComponent<RawImage>();
		if ((bool)GBCLDBHACGH)
		{
			BDMPBBNHLOF();
		}
		else
		{
			Debug.LogWarning("Missing RawImage on object [" + base.name + "]");
		}
	}

	private void OnEnable()
	{
		if (MBFJEBHOFCC != null && Application.isPlaying)
		{
			MBFJEBHOFCC.DNMFLMKBGAP.AddListener(JKPBFDAAKFK);
			MBFJEBHOFCC.HAKHGCCNIAJ.AddListener(JKPBFDAAKFK);
		}
	}

	private void OnDisable()
	{
		if (MBFJEBHOFCC != null)
		{
			MBFJEBHOFCC.DNMFLMKBGAP.RemoveListener(JKPBFDAAKFK);
			MBFJEBHOFCC.HAKHGCCNIAJ.RemoveListener(JKPBFDAAKFK);
		}
	}

	private void OnDestroy()
	{
		if (GBCLDBHACGH.texture != null)
		{
			UnityEngine.Object.DestroyImmediate(GBCLDBHACGH.texture);
		}
	}

	private void JKPBFDAAKFK(Color GNKGIKCFKMF)
	{
		switch (EBMKGCIKJCA)
		{
		case OBFKGLEJBII.ADGHIINBKLJ:
		case OBFKGLEJBII.KECBPPLFKDA:
		case OBFKGLEJBII.EDGDMFJAFEM:
		case OBFKGLEJBII.GFMADABILAD:
		case OBFKGLEJBII.JFLFLCDEEEI:
			BDMPBBNHLOF();
			break;
		case OBFKGLEJBII.PLLNCPNCAHN:
		case OBFKGLEJBII.NMGHODPCLGP:
			break;
		}
	}

	private void JKPBFDAAKFK(float OEHMBFPIKBP, float CDDPBGMABAJ, float EHAPKEKPMOE)
	{
		switch (EBMKGCIKJCA)
		{
		case OBFKGLEJBII.ADGHIINBKLJ:
		case OBFKGLEJBII.KECBPPLFKDA:
		case OBFKGLEJBII.EDGDMFJAFEM:
		case OBFKGLEJBII.GFMADABILAD:
		case OBFKGLEJBII.JFLFLCDEEEI:
			BDMPBBNHLOF();
			break;
		case OBFKGLEJBII.PLLNCPNCAHN:
		case OBFKGLEJBII.NMGHODPCLGP:
			break;
		}
	}

	private void BDMPBBNHLOF()
	{
		if (!MBFJEBHOFCC)
		{
			Debug.LogWarning("Missing Picker on object [" + base.name + "]");
		}
		Color32 color = ((!(MBFJEBHOFCC != null)) ? Color.black : MBFJEBHOFCC.MHGKIBFILBG);
		float num = ((!(MBFJEBHOFCC != null)) ? 0f : MBFJEBHOFCC.POELOAELGLA);
		float num2 = ((!(MBFJEBHOFCC != null)) ? 0f : MBFJEBHOFCC.KLJJEMDJPCC);
		float num3 = ((!(MBFJEBHOFCC != null)) ? 0f : MBFJEBHOFCC.PLPAGOMEGEN);
		bool flag = BADIHIKMKJF == Slider.Direction.BottomToTop || BADIHIKMKJF == Slider.Direction.TopToBottom;
		bool flag2 = BADIHIKMKJF == Slider.Direction.TopToBottom || BADIHIKMKJF == Slider.Direction.RightToLeft;
		int num4;
		switch (EBMKGCIKJCA)
		{
		case OBFKGLEJBII.ADGHIINBKLJ:
		case OBFKGLEJBII.KECBPPLFKDA:
		case OBFKGLEJBII.EDGDMFJAFEM:
		case OBFKGLEJBII.PLLNCPNCAHN:
			num4 = 255;
			break;
		case OBFKGLEJBII.NMGHODPCLGP:
			num4 = 360;
			break;
		case OBFKGLEJBII.GFMADABILAD:
		case OBFKGLEJBII.JFLFLCDEEEI:
			num4 = 100;
			break;
		default:
			throw new NotImplementedException(string.Empty);
		}
		Texture2D texture2D = ((!flag) ? new Texture2D(num4, 1) : new Texture2D(1, num4));
		texture2D.hideFlags = HideFlags.DontSave;
		Color32[] array = new Color32[num4];
		switch (EBMKGCIKJCA)
		{
		case OBFKGLEJBII.ADGHIINBKLJ:
		{
			for (byte b3 = 0; b3 < num4; b3++)
			{
				ref Color32 reference6 = ref array[(!flag2) ? b3 : (num4 - 1 - b3)];
				reference6 = new Color32(b3, color.g, color.b, byte.MaxValue);
			}
			break;
		}
		case OBFKGLEJBII.KECBPPLFKDA:
		{
			for (byte b = 0; b < num4; b++)
			{
				ref Color32 reference2 = ref array[(!flag2) ? b : (num4 - 1 - b)];
				reference2 = new Color32(color.r, b, color.b, byte.MaxValue);
			}
			break;
		}
		case OBFKGLEJBII.EDGDMFJAFEM:
		{
			for (byte b2 = 0; b2 < num4; b2++)
			{
				ref Color32 reference4 = ref array[(!flag2) ? b2 : (num4 - 1 - b2)];
				reference4 = new Color32(color.r, color.g, b2, byte.MaxValue);
			}
			break;
		}
		case OBFKGLEJBII.PLLNCPNCAHN:
		{
			for (byte b4 = 0; b4 < num4; b4++)
			{
				ref Color32 reference7 = ref array[(!flag2) ? b4 : (num4 - 1 - b4)];
				reference7 = new Color32(b4, b4, b4, byte.MaxValue);
			}
			break;
		}
		case OBFKGLEJBII.NMGHODPCLGP:
		{
			for (int k = 0; k < num4; k++)
			{
				ref Color32 reference5 = ref array[(!flag2) ? k : (num4 - 1 - k)];
				reference5 = KOLKGOKNADN.NAHEPBDDFPJ(k, 1.0, 1.0, 1f);
			}
			break;
		}
		case OBFKGLEJBII.GFMADABILAD:
		{
			for (int j = 0; j < num4; j++)
			{
				ref Color32 reference3 = ref array[(!flag2) ? j : (num4 - 1 - j)];
				reference3 = KOLKGOKNADN.NAHEPBDDFPJ(num * 360f, (float)j / (float)num4, num3, 1f);
			}
			break;
		}
		case OBFKGLEJBII.JFLFLCDEEEI:
		{
			for (int i = 0; i < num4; i++)
			{
				ref Color32 reference = ref array[(!flag2) ? i : (num4 - 1 - i)];
				reference = KOLKGOKNADN.NAHEPBDDFPJ(num * 360f, num2, (float)i / (float)num4, 1f);
			}
			break;
		}
		default:
			throw new NotImplementedException(string.Empty);
		}
		texture2D.SetPixels32(array);
		texture2D.Apply();
		if (GBCLDBHACGH.texture != null)
		{
			UnityEngine.Object.DestroyImmediate(GBCLDBHACGH.texture);
		}
		GBCLDBHACGH.texture = texture2D;
		switch (BADIHIKMKJF)
		{
		case Slider.Direction.BottomToTop:
		case Slider.Direction.TopToBottom:
			GBCLDBHACGH.uvRect = new Rect(0f, 0f, 2f, 1f);
			break;
		case Slider.Direction.LeftToRight:
		case Slider.Direction.RightToLeft:
			GBCLDBHACGH.uvRect = new Rect(0f, 0f, 1f, 2f);
			break;
		}
	}
}
