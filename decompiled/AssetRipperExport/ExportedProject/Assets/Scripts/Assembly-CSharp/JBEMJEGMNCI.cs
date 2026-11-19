using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class JBEMJEGMNCI
{
	private sealed class JKFIGHCDAKI : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal Transform PLNPFEFLKFM;

		internal Quaternion LEDBLHBHFHC;

		internal Vector3 HCAAOMABEKF;

		internal Quaternion IEFDDAGPMPK;

		internal float HLOAPHLPNJG;

		internal float FDIFCLMCDNE;

		internal float CHFMDANPNGD;

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
		public JKFIGHCDAKI()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				LEDBLHBHFHC = PLNPFEFLKFM.localRotation;
				IEFDDAGPMPK = PLNPFEFLKFM.localRotation * Quaternion.Euler(HCAAOMABEKF);
				FDIFCLMCDNE = 1f / HLOAPHLPNJG;
				CHFMDANPNGD = 0f;
				goto case 1u;
			case 1u:
				if (CHFMDANPNGD < 1f)
				{
					CHFMDANPNGD += Time.deltaTime * FDIFCLMCDNE;
					PLNPFEFLKFM.localRotation = Quaternion.Slerp(LEDBLHBHFHC, IEFDDAGPMPK, CHFMDANPNGD);
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
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

	private sealed class MOHOJDNJPEG : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal GameObject PLNPFEFLKFM;

		internal GameObject MBJIIFHAMML;

		internal float FEIKMNBLLKK;

		internal float IANLFMCDFKF;

		internal Vector3 HHMIPAOLFBE;

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
		public MOHOJDNJPEG()
		{
		}

		public bool MoveNext()
		{
			uint gNNOELAJGPI = (uint)GNNOELAJGPI;
			GNNOELAJGPI = -1;
			switch (gNNOELAJGPI)
			{
			case 0u:
				if (PLNPFEFLKFM == null || MBJIIFHAMML == null)
				{
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 1;
					}
					break;
				}
				goto case 1u;
			case 2u:
				HLJEEFIJCOF = null;
				if (!JMOBJHKGFMH)
				{
					GNNOELAJGPI = 3;
				}
				break;
			case 1u:
			case 3u:
				if (FEIKMNBLLKK > 0f)
				{
					FEIKMNBLLKK -= Time.deltaTime * 1f;
					HHMIPAOLFBE = UnityEngine.Random.insideUnitSphere * IANLFMCDFKF;
					if (FEIKMNBLLKK > 0f && (PLNPFEFLKFM != null || MBJIIFHAMML != null))
					{
						PLNPFEFLKFM.transform.localRotation = Quaternion.Lerp(PLNPFEFLKFM.transform.localRotation, Quaternion.Euler(HHMIPAOLFBE), FEIKMNBLLKK);
						MBJIIFHAMML.transform.localRotation = Quaternion.Slerp(MBJIIFHAMML.transform.localRotation, Quaternion.Euler(HHMIPAOLFBE), FEIKMNBLLKK);
						goto case 2u;
					}
					HLJEEFIJCOF = null;
					if (!JMOBJHKGFMH)
					{
						GNNOELAJGPI = 2;
					}
					break;
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

	[DebuggerHidden]
	public IEnumerator BHNCPOFPBPC(Transform PLNPFEFLKFM, Vector3 HCAAOMABEKF, float HLOAPHLPNJG)
	{
		JKFIGHCDAKI jKFIGHCDAKI = new JKFIGHCDAKI();
		jKFIGHCDAKI.PLNPFEFLKFM = PLNPFEFLKFM;
		jKFIGHCDAKI.HCAAOMABEKF = HCAAOMABEKF;
		jKFIGHCDAKI.HLOAPHLPNJG = HLOAPHLPNJG;
		return jKFIGHCDAKI;
	}

	[DebuggerHidden]
	public IEnumerator EBOIFEMDKAI(GameObject PLNPFEFLKFM, GameObject MBJIIFHAMML, float FEIKMNBLLKK, float IANLFMCDFKF)
	{
		MOHOJDNJPEG mOHOJDNJPEG = new MOHOJDNJPEG();
		mOHOJDNJPEG.PLNPFEFLKFM = PLNPFEFLKFM;
		mOHOJDNJPEG.MBJIIFHAMML = MBJIIFHAMML;
		mOHOJDNJPEG.FEIKMNBLLKK = FEIKMNBLLKK;
		mOHOJDNJPEG.IANLFMCDFKF = IANLFMCDFKF;
		return mOHOJDNJPEG;
	}
}
