using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public static class MDIEDJKKKHL
{
	private sealed class NNPCCFANNON : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal YieldInstruction OMCBCLNFBGG;

		internal UnityAction FELGOOGHDPH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public NNPCCFANNON()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				HLJEEFIJCOF = OMCBCLNFBGG;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				FELGOOGHDPH();
				GNNOELAJGPI = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class DPPKEFMJMFH : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal uint PGIKKINAPAK;

		internal uint FFEMEOHJFHB;

		internal YieldInstruction OMCBCLNFBGG;

		internal UnityAction FELGOOGHDPH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public DPPKEFMJMFH()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				PGIKKINAPAK = 0u;
				goto IL_0066;
			case 1u:
				FELGOOGHDPH();
				PGIKKINAPAK++;
				goto IL_0066;
			default:
				{
					return false;
				}
				IL_0066:
				if (PGIKKINAPAK < FFEMEOHJFHB)
				{
					HLJEEFIJCOF = OMCBCLNFBGG;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				GNNOELAJGPI = -1;
				goto default;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class DMKBCMCFMLL : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal YieldInstruction OMCBCLNFBGG;

		internal UnityAction FELGOOGHDPH;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public DMKBCMCFMLL()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				HLJEEFIJCOF = OMCBCLNFBGG;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 1;
				}
				return true;
			case 1u:
				FELGOOGHDPH();
				goto case 0u;
			default:
				return false;
			}
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class FMAEHAKCKLI<T, K> : IEnumerator, IDisposable, IEnumerator<object> where K : IComparable
	{
		internal Func<T, K> DFNDAMCLEMC;

		internal T FCBABFMAPBI;

		internal K NKHPPECOAGE;

		internal YieldInstruction HIDPDHDHNAD;

		internal UnityAction AOIHMNJMDBF;

		internal UnityAction OIEDJPBELON;

		internal object HLJEEFIJCOF;

		internal bool JMOBJHKGFMH;

		internal int GNNOELAJGPI;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return HLJEEFIJCOF;
			}
		}

		[DebuggerHidden]
		public FMAEHAKCKLI()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 1u:
				if (AOIHMNJMDBF != null)
				{
					AOIHMNJMDBF();
				}
				goto case 0u;
			case 0u:
				if (DFNDAMCLEMC(FCBABFMAPBI).CompareTo(NKHPPECOAGE) != 0)
				{
					HLJEEFIJCOF = HIDPDHDHNAD;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				if (OIEDJPBELON != null)
				{
					OIEDJPBELON();
				}
				GNNOELAJGPI = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			JMOBJHKGFMH = true;
			GNNOELAJGPI = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

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

	[DebuggerHidden]
	public static IEnumerator LBIHLNOMKEA(YieldInstruction OMCBCLNFBGG, UnityAction FELGOOGHDPH)
	{
		NNPCCFANNON nNPCCFANNON = new NNPCCFANNON();
		nNPCCFANNON.OMCBCLNFBGG = OMCBCLNFBGG;
		nNPCCFANNON.FELGOOGHDPH = FELGOOGHDPH;
		return nNPCCFANNON;
	}

	public static void PEEMDOMKAFN(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH, uint FFEMEOHJFHB)
	{
		IDGNMFBAEED.StartCoroutine(NPHFNPPNLGE(null, FELGOOGHDPH, FFEMEOHJFHB));
	}

	public static void CBCOJOMNKCD(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH, float PGPOCDOBMNP)
	{
		IDGNMFBAEED.StartCoroutine(MDGLNLDGHEC(new WaitForSeconds(PGPOCDOBMNP), FELGOOGHDPH));
	}

	[DebuggerHidden]
	public static IEnumerator NPHFNPPNLGE(YieldInstruction OMCBCLNFBGG, UnityAction FELGOOGHDPH, uint FFEMEOHJFHB)
	{
		DPPKEFMJMFH dPPKEFMJMFH = new DPPKEFMJMFH();
		dPPKEFMJMFH.FFEMEOHJFHB = FFEMEOHJFHB;
		dPPKEFMJMFH.OMCBCLNFBGG = OMCBCLNFBGG;
		dPPKEFMJMFH.FELGOOGHDPH = FELGOOGHDPH;
		return dPPKEFMJMFH;
	}

	public static void DCMOLMLJKEE(this MonoBehaviour IDGNMFBAEED, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.StartCoroutine(MDGLNLDGHEC(null, FELGOOGHDPH));
	}

	[DebuggerHidden]
	public static IEnumerator MDGLNLDGHEC(YieldInstruction OMCBCLNFBGG, UnityAction FELGOOGHDPH)
	{
		DMKBCMCFMLL dMKBCMCFMLL = new DMKBCMCFMLL();
		dMKBCMCFMLL.OMCBCLNFBGG = OMCBCLNFBGG;
		dMKBCMCFMLL.FELGOOGHDPH = FELGOOGHDPH;
		return dMKBCMCFMLL;
	}

	public static void DNCMDOKDBGL<T>(this MonoBehaviour IDGNMFBAEED, T FCBABFMAPBI, Func<T, bool> EKLIPBFHPMC, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.StartCoroutine(KEGMMJNEPGB(null, FCBABFMAPBI, EKLIPBFHPMC, true, null, FELGOOGHDPH));
	}

	public static void CGLDDGHBBAE<T>(this MonoBehaviour IDGNMFBAEED, T FCBABFMAPBI, Func<T, bool> EKLIPBFHPMC, UnityAction FELGOOGHDPH)
	{
		IDGNMFBAEED.StartCoroutine(KEGMMJNEPGB(null, FCBABFMAPBI, EKLIPBFHPMC, false, null, FELGOOGHDPH));
	}

	[DebuggerHidden]
	public static IEnumerator KEGMMJNEPGB<T, K>(YieldInstruction HIDPDHDHNAD, T FCBABFMAPBI, Func<T, K> DFNDAMCLEMC, K NKHPPECOAGE, UnityAction AOIHMNJMDBF, UnityAction OIEDJPBELON) where K : IComparable
	{
		FMAEHAKCKLI<T, K> fMAEHAKCKLI = new FMAEHAKCKLI<T, K>();
		fMAEHAKCKLI.DFNDAMCLEMC = DFNDAMCLEMC;
		fMAEHAKCKLI.FCBABFMAPBI = FCBABFMAPBI;
		fMAEHAKCKLI.NKHPPECOAGE = NKHPPECOAGE;
		fMAEHAKCKLI.HIDPDHDHNAD = HIDPDHDHNAD;
		fMAEHAKCKLI.AOIHMNJMDBF = AOIHMNJMDBF;
		fMAEHAKCKLI.OIEDJPBELON = OIEDJPBELON;
		return fMAEHAKCKLI;
	}
}
