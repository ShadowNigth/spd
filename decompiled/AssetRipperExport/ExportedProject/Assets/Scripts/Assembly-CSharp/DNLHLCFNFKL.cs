using UnityEngine;

[AddComponentMenu("UI/Extensions/UI Line Connector")]
[RequireComponent(typeof(AANBJFHLONM))]
[ExecuteInEditMode]
public class DNLHLCFNFKL : MonoBehaviour
{
	public RectTransform[] DDGKMMJGGEG;

	private Vector2[] AIEKHJNPJIL;

	private RectTransform GLEFEIONOLH;

	private RectTransform AABJBHGEFPE;

	private AANBJFHLONM NKFOKCDNPPN;

	private void Awake()
	{
		GLEFEIONOLH = GetComponentInParent<RectTransform>().PEGDBOBCHNE().GetComponent<RectTransform>();
		AABJBHGEFPE = GetComponent<RectTransform>();
		NKFOKCDNPPN = GetComponent<AANBJFHLONM>();
	}

	private void Update()
	{
		if (DDGKMMJGGEG == null || DDGKMMJGGEG.Length < 1)
		{
			return;
		}
		if (AIEKHJNPJIL != null && AIEKHJNPJIL.Length == DDGKMMJGGEG.Length)
		{
			bool flag = false;
			for (int i = 0; i < DDGKMMJGGEG.Length; i++)
			{
				if (!flag && AIEKHJNPJIL[i] != DDGKMMJGGEG[i].anchoredPosition)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
		}
		Vector2 pivot = AABJBHGEFPE.pivot;
		Vector2 pivot2 = GLEFEIONOLH.pivot;
		Vector3[] array = new Vector3[DDGKMMJGGEG.Length];
		Vector3[] array2 = new Vector3[DDGKMMJGGEG.Length];
		Vector2[] array3 = new Vector2[DDGKMMJGGEG.Length];
		for (int j = 0; j < DDGKMMJGGEG.Length; j++)
		{
			array[j] = DDGKMMJGGEG[j].TransformPoint(pivot);
		}
		for (int k = 0; k < DDGKMMJGGEG.Length; k++)
		{
			array2[k] = GLEFEIONOLH.InverseTransformPoint(array[k]);
		}
		for (int l = 0; l < DDGKMMJGGEG.Length; l++)
		{
			array3[l] = new Vector2(array2[l].x, array2[l].y);
		}
		NKFOKCDNPPN.EDEEPJMIFBD = array3;
		NKFOKCDNPPN.FMPBJFCIFHF = false;
		NKFOKCDNPPN.HLIECFOLDHO = true;
		AIEKHJNPJIL = new Vector2[DDGKMMJGGEG.Length];
		for (int m = 0; m < DDGKMMJGGEG.Length; m++)
		{
			AIEKHJNPJIL[m] = DDGKMMJGGEG[m].anchoredPosition;
		}
	}
}
