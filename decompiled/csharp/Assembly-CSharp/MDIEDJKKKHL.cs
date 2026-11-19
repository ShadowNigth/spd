using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public static class MDIEDJKKKHL
{
	public static void FBDHLDDJENH(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.AGHIGGCGBOF(FELGOOGHDPH, null);
	}

	public static void FENFBHEJMCE(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.AGHIGGCGBOF(FELGOOGHDPH, new WaitForEndOfFrame());
	}

	public static void EIGDJLBGNMP(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.AGHIGGCGBOF(FELGOOGHDPH, new WaitForFixedUpdate());
	}

	public static void GEDGGNFNMLL(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH, float KDHKJPAEFHF, float CBHEOEGGCKA)
	{
		IDGNMFBAEED.AGHIGGCGBOF(FELGOOGHDPH, UnityEngine.Random.Range(KDHKJPAEFHF, CBHEOEGGCKA));
	}

	public static void AGHIGGCGBOF(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH, float DGJBIAGPCEE)
	{
		IDGNMFBAEED.AGHIGGCGBOF(FELGOOGHDPH, new WaitForSeconds(DGJBIAGPCEE));
	}

	public static void AGHIGGCGBOF(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH, YieldInstruction ACLBNOGOILC)
	{
		IDGNMFBAEED.StartCoroutine(LBIHLNOMKEA(ACLBNOGOILC, FELGOOGHDPH));
	}

	public static IEnumerator LBIHLNOMKEA(YieldInstruction OMCBCLNFBGG, UnityAction FELGOOGHDPH)
	{
		yield return OMCBCLNFBGG;
		FELGOOGHDPH();
	}

	public static void PEEMDOMKAFN(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH, uint FFEMEOHJFHB)
	{
		IDGNMFBAEED.StartCoroutine(NPHFNPPNLGE(null, FELGOOGHDPH, FFEMEOHJFHB));
	}

	public static void CBCOJOMNKCD(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH, float PGPOCDOBMNP)
	{
		IDGNMFBAEED.StartCoroutine(MDGLNLDGHEC(new WaitForSeconds(PGPOCDOBMNP), FELGOOGHDPH));
	}

	public static IEnumerator NPHFNPPNLGE(YieldInstruction OMCBCLNFBGG, UnityAction FELGOOGHDPH, uint FFEMEOHJFHB)
	{
		for (uint num = 0u; num < FFEMEOHJFHB; num++)
		{
			yield return OMCBCLNFBGG;
			FELGOOGHDPH();
		}
	}

	public static void DCMOLMLJKEE(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.StartCoroutine(MDGLNLDGHEC(null, FELGOOGHDPH));
	}

	public static IEnumerator MDGLNLDGHEC(YieldInstruction OMCBCLNFBGG, UnityAction FELGOOGHDPH)
	{
		while (true)
		{
			yield return OMCBCLNFBGG;
			FELGOOGHDPH();
		}
	}

	public static void DNCMDOKDBGL<T>(this MonoBehaviour IDGNMFBAEED, T FCBABFMAPBI, Func<T, bool> EKLIPBFHPMC, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.StartCoroutine(KEGMMJNEPGB(null, FCBABFMAPBI, EKLIPBFHPMC, NKHPPECOAGE: true, null, FELGOOGHDPH));
	}

	public static void CGLDDGHBBAE<T>(this MonoBehaviour IDGNMFBAEED, T FCBABFMAPBI, Func<T, bool> EKLIPBFHPMC, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.StartCoroutine(KEGMMJNEPGB(null, FCBABFMAPBI, EKLIPBFHPMC, NKHPPECOAGE: false, null, FELGOOGHDPH));
	}

	public static IEnumerator KEGMMJNEPGB<T, K>(YieldInstruction HIDPDHDHNAD, T FCBABFMAPBI, Func<T, K> DFNDAMCLEMC, K NKHPPECOAGE, UnityAction AOIHMNJMDBF, UnityAction OIEDJPBELON) where K : IComparable
	{
		while (DFNDAMCLEMC(FCBABFMAPBI).CompareTo(NKHPPECOAGE) != 0)
		{
			yield return HIDPDHDHNAD;
			AOIHMNJMDBF?.Invoke();
		}
		OIEDJPBELON?.Invoke();
	}
}
