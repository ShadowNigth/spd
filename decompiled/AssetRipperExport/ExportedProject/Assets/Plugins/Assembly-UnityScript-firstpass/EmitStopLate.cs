using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EmitStopLate : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024Main_002449 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EmitStopLate _0024self__002450;

			public _0024(EmitStopLate self_)
			{
				_0024self__002450 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002450.GetComponent<ParticleEmitter>().emit = true;
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002450.GetComponent<ParticleEmitter>().emit = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EmitStopLate _0024self__002451;

		public _0024Main_002449(EmitStopLate self_)
		{
			_0024self__002451 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002451);
		}
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator Main()
	{
		return new _0024Main_002449(this).GetEnumerator();
	}
}
