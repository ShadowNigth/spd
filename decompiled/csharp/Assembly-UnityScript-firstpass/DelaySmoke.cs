using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class DelaySmoke : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Main_002443 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal DelaySmoke _0024self__002444;

			public _0024(DelaySmoke self_)
			{
				_0024self__002444 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002444.GetComponent<ParticleEmitter>().emit = false;
					result = (Yield(2, new WaitForSeconds(1.05f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002444.GetComponent<ParticleEmitter>().emit = true;
					result = (Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 3:
					_0024self__002444.GetComponent<ParticleEmitter>().emit = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal DelaySmoke _0024self__002445;

		public _0024Main_002443(DelaySmoke self_)
		{
			_0024self__002445 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002445);
		}
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator Main()
	{
		return new _0024Main_002443(this).GetEnumerator();
	}
}
