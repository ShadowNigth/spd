using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AHPAOFFCJIA : MonoBehaviour
{
	public AANBJFHLONM FFJFFLCJDHB;

	public Text IHBAJPLGCNH;

	public Text BMGEACLNELP;

	public void HOMPAKHBBFN()
	{
		Vector2 item = new Vector2
		{
			x = float.Parse(IHBAJPLGCNH.text),
			y = float.Parse(BMGEACLNELP.text)
		};
		List<Vector2> list = new List<Vector2>(FFJFFLCJDHB.EDEEPJMIFBD);
		list.Add(item);
		FFJFFLCJDHB.EDEEPJMIFBD = list.ToArray();
	}

	public void CPNLPKCAGFE()
	{
		FFJFFLCJDHB.EDEEPJMIFBD = new Vector2[0];
	}
}
