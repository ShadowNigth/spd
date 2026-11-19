using System.Collections.Generic;
using UnityEngine;

public class INIHEEHAALK
{
	public int LBCIDJEGHJF = 10;

	public float CHJBCBCCOHA = 0.01f;

	public float OAAPNOOKJCD = -0.99f;

	private List<Vector2> IEHPNDJKNEC;

	private int AHJIMJECJCO;

	public INIHEEHAALK()
	{
		IEHPNDJKNEC = new List<Vector2>();
	}

	public void BCPLMOOEIIE(List<Vector2> NBHJGOKOGKA)
	{
		IEHPNDJKNEC.Clear();
		IEHPNDJKNEC.AddRange(NBHJGOKOGKA);
		AHJIMJECJCO = (IEHPNDJKNEC.Count - 1) / 3;
	}

	public void BCPLMOOEIIE(Vector2[] NBHJGOKOGKA)
	{
		IEHPNDJKNEC.Clear();
		IEHPNDJKNEC.AddRange(NBHJGOKOGKA);
		AHJIMJECJCO = (IEHPNDJKNEC.Count - 1) / 3;
	}

	public List<Vector2> OCJKFABPKGH()
	{
		return IEHPNDJKNEC;
	}

	public void OKOIJKHLBPC(List<Vector2> NJDCAKKMDKF, float ALIEGLIAJOI)
	{
		IEHPNDJKNEC.Clear();
		if (NJDCAKKMDKF.Count < 2)
		{
			return;
		}
		for (int i = 0; i < NJDCAKKMDKF.Count; i++)
		{
			if (i == 0)
			{
				Vector2 vector = NJDCAKKMDKF[i];
				Vector2 vector2 = NJDCAKKMDKF[i + 1];
				Vector2 vector3 = vector2 - vector;
				Vector2 item = vector + ALIEGLIAJOI * vector3;
				IEHPNDJKNEC.Add(vector);
				IEHPNDJKNEC.Add(item);
			}
			else if (i == NJDCAKKMDKF.Count - 1)
			{
				Vector2 vector4 = NJDCAKKMDKF[i - 1];
				Vector2 vector5 = NJDCAKKMDKF[i];
				Vector2 vector6 = vector5 - vector4;
				Vector2 item2 = vector5 - ALIEGLIAJOI * vector6;
				IEHPNDJKNEC.Add(item2);
				IEHPNDJKNEC.Add(vector5);
			}
			else
			{
				Vector2 vector7 = NJDCAKKMDKF[i - 1];
				Vector2 vector8 = NJDCAKKMDKF[i];
				Vector2 vector9 = NJDCAKKMDKF[i + 1];
				Vector2 normalized = (vector9 - vector7).normalized;
				Vector2 item3 = vector8 - ALIEGLIAJOI * normalized * (vector8 - vector7).magnitude;
				Vector2 item4 = vector8 + ALIEGLIAJOI * normalized * (vector9 - vector8).magnitude;
				IEHPNDJKNEC.Add(item3);
				IEHPNDJKNEC.Add(vector8);
				IEHPNDJKNEC.Add(item4);
			}
		}
		AHJIMJECJCO = (IEHPNDJKNEC.Count - 1) / 3;
	}

	public void JMEAEIFLODI(List<Vector2> DPMDICGIICC, float GGFDEJFFCAN, float DMOAGEOICJC, float ALIEGLIAJOI)
	{
		if (DPMDICGIICC.Count < 2)
		{
			return;
		}
		Stack<Vector2> stack = new Stack<Vector2>();
		stack.Push(DPMDICGIICC[0]);
		Vector2 vector = DPMDICGIICC[1];
		int num = 2;
		for (num = 2; num < DPMDICGIICC.Count; num++)
		{
			if ((vector - DPMDICGIICC[num]).sqrMagnitude > GGFDEJFFCAN && (stack.Peek() - DPMDICGIICC[num]).sqrMagnitude > DMOAGEOICJC)
			{
				stack.Push(vector);
			}
			vector = DPMDICGIICC[num];
		}
		Vector2 vector2 = stack.Pop();
		Vector2 vector3 = stack.Peek();
		Vector2 normalized = (vector3 - vector).normalized;
		float magnitude = (vector - vector2).magnitude;
		float magnitude2 = (vector2 - vector3).magnitude;
		vector2 += normalized * ((magnitude2 - magnitude) / 2f);
		stack.Push(vector2);
		stack.Push(vector);
		OKOIJKHLBPC(new List<Vector2>(stack), ALIEGLIAJOI);
	}

	public Vector2 DHDECPIBIKB(int CHCLKOHEHCJ, float GDKFLGBMPBB)
	{
		int num = CHCLKOHEHCJ * 3;
		Vector2 mDEOPAACAPB = IEHPNDJKNEC[num];
		Vector2 pACCJGELENC = IEHPNDJKNEC[num + 1];
		Vector2 pLPIOMGGMJH = IEHPNDJKNEC[num + 2];
		Vector2 lFGFNKJJDAO = IEHPNDJKNEC[num + 3];
		return DHDECPIBIKB(GDKFLGBMPBB, mDEOPAACAPB, pACCJGELENC, pLPIOMGGMJH, lFGFNKJJDAO);
	}

	public List<Vector2> PFGOBBHIMJF()
	{
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < AHJIMJECJCO; i++)
		{
			if (i == 0)
			{
				list.Add(DHDECPIBIKB(i, 0f));
			}
			for (int j = 1; j <= LBCIDJEGHJF; j++)
			{
				float gDKFLGBMPBB = (float)j / (float)LBCIDJEGHJF;
				list.Add(DHDECPIBIKB(i, gDKFLGBMPBB));
			}
		}
		return list;
	}

	public List<Vector2> CMDMCHFKLCE()
	{
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < IEHPNDJKNEC.Count - 3; i += 3)
		{
			Vector2 mDEOPAACAPB = IEHPNDJKNEC[i];
			Vector2 pACCJGELENC = IEHPNDJKNEC[i + 1];
			Vector2 pLPIOMGGMJH = IEHPNDJKNEC[i + 2];
			Vector2 lFGFNKJJDAO = IEHPNDJKNEC[i + 3];
			if (i == 0)
			{
				list.Add(DHDECPIBIKB(0f, mDEOPAACAPB, pACCJGELENC, pLPIOMGGMJH, lFGFNKJJDAO));
			}
			for (int j = 1; j <= LBCIDJEGHJF; j++)
			{
				float gDKFLGBMPBB = (float)j / (float)LBCIDJEGHJF;
				list.Add(DHDECPIBIKB(gDKFLGBMPBB, mDEOPAACAPB, pACCJGELENC, pLPIOMGGMJH, lFGFNKJJDAO));
			}
		}
		return list;
	}

	public List<Vector2> FKMECDLGGBM()
	{
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < AHJIMJECJCO; i++)
		{
			List<Vector2> list2 = JDIPMJFPDGA(i);
			if (i != 0)
			{
				list2.RemoveAt(0);
			}
			list.AddRange(list2);
		}
		return list;
	}

	private List<Vector2> JDIPMJFPDGA(int CHCLKOHEHCJ)
	{
		List<Vector2> list = new List<Vector2>();
		Vector2 item = DHDECPIBIKB(CHCLKOHEHCJ, 0f);
		Vector2 item2 = DHDECPIBIKB(CHCLKOHEHCJ, 1f);
		list.Add(item);
		list.Add(item2);
		JDIPMJFPDGA(CHCLKOHEHCJ, 0f, 1f, list, 1);
		return list;
	}

	private int JDIPMJFPDGA(int CHCLKOHEHCJ, float PFMBIPCIGNC, float PHELBJLAHPB, List<Vector2> JBCMJGABECH, int BLJKEOCOCOC)
	{
		Vector2 vector = DHDECPIBIKB(CHCLKOHEHCJ, PFMBIPCIGNC);
		Vector2 vector2 = DHDECPIBIKB(CHCLKOHEHCJ, PHELBJLAHPB);
		if ((vector - vector2).sqrMagnitude < CHJBCBCCOHA)
		{
			return 0;
		}
		float num = (PFMBIPCIGNC + PHELBJLAHPB) / 2f;
		Vector2 vector3 = DHDECPIBIKB(CHCLKOHEHCJ, num);
		Vector2 normalized = (vector - vector3).normalized;
		Vector2 normalized2 = (vector2 - vector3).normalized;
		if (Vector2.Dot(normalized, normalized2) > OAAPNOOKJCD || Mathf.Abs(num - 0.5f) < 0.0001f)
		{
			int num2 = 0;
			num2 += JDIPMJFPDGA(CHCLKOHEHCJ, PFMBIPCIGNC, num, JBCMJGABECH, BLJKEOCOCOC);
			JBCMJGABECH.Insert(BLJKEOCOCOC + num2, vector3);
			num2++;
			return num2 + JDIPMJFPDGA(CHCLKOHEHCJ, num, PHELBJLAHPB, JBCMJGABECH, BLJKEOCOCOC + num2);
		}
		return 0;
	}

	private Vector2 DHDECPIBIKB(float GDKFLGBMPBB, Vector2 MDEOPAACAPB, Vector2 PACCJGELENC, Vector2 PLPIOMGGMJH, Vector2 LFGFNKJJDAO)
	{
		float num = 1f - GDKFLGBMPBB;
		float num2 = GDKFLGBMPBB * GDKFLGBMPBB;
		float num3 = num * num;
		float num4 = num3 * num;
		float num5 = num2 * GDKFLGBMPBB;
		Vector2 vector = num4 * MDEOPAACAPB;
		vector += 3f * num3 * GDKFLGBMPBB * PACCJGELENC;
		vector += 3f * num * num2 * PLPIOMGGMJH;
		return vector + num5 * LFGFNKJJDAO;
	}
}
