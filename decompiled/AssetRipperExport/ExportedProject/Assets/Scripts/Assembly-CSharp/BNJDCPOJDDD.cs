using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AANBJFHLONM))]
public class BNJDCPOJDDD : MonoBehaviour
{
	private AANBJFHLONM NKFOKCDNPPN;

	private OEMDPHCFKKJ FOBEDELPBMH;

	public GameObject JBJMPAOHGMJ;

	private RectTransform OLBLIIMHDOA;

	private float MMNIBHEEIHL;

	[SerializeField]
	private float _xAxis = 3f;

	[SerializeField]
	private float _yAxis = 3f;

	[SerializeField]
	private int _steps = 10;

	public float HHNFAHAHAKD
	{
		get
		{
			return _xAxis;
		}
		set
		{
			_xAxis = value;
			KJDJPIPONCK();
		}
	}

	public float BICBMIDJNEL
	{
		get
		{
			return _yAxis;
		}
		set
		{
			_yAxis = value;
			KJDJPIPONCK();
		}
	}

	public int GFJHOLCEFHI
	{
		get
		{
			return _steps;
		}
		set
		{
			_steps = value;
			KJDJPIPONCK();
		}
	}

	private void Awake()
	{
		NKFOKCDNPPN = GetComponent<AANBJFHLONM>();
		OLBLIIMHDOA = JBJMPAOHGMJ.GetComponent<RectTransform>();
		KJDJPIPONCK();
	}

	private void Update()
	{
		MMNIBHEEIHL = ((!(MMNIBHEEIHL > (float)_steps)) ? (MMNIBHEEIHL + Time.deltaTime) : (MMNIBHEEIHL = 0f));
		OLBLIIMHDOA.localPosition = FOBEDELPBMH.EHFBCALDAAL(MMNIBHEEIHL);
	}

	private void KJDJPIPONCK()
	{
		FOBEDELPBMH = new OEMDPHCFKKJ(_xAxis, _yAxis, _steps);
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < _steps; i++)
		{
			list.Add(FOBEDELPBMH.EHFBCALDAAL(i));
		}
		list.Add(FOBEDELPBMH.EHFBCALDAAL(0f));
		NKFOKCDNPPN.EDEEPJMIFBD = list.ToArray();
	}

	private void OnValidate()
	{
		if (NKFOKCDNPPN != null)
		{
			KJDJPIPONCK();
		}
	}
}
