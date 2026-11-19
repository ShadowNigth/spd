using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EmitStopSoon : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Main_002452 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EmitStopSoon _0024self__002453;

			public _0024(EmitStopSoon self_)
			{
				_0024self__002453 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002453.GetComponent<ParticleEmitter>().emit = true;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002453.GetComponent<ParticleEmitter>().emit = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EmitStopSoon _0024self__002454;

		public _0024Main_002452(EmitStopSoon self_)
		{
			_0024self__002454 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002454);
		}
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator Main()
	{
		return new _0024Main_002452(this).GetEnumerator();
	}
}
