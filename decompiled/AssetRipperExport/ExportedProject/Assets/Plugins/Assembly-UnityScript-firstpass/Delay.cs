using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Delay : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024Main_002440 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Delay _0024self__002441;

			public _0024(Delay self_)
			{
				_0024self__002441 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002441.GetComponent<ParticleEmitter>().emit = false;
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002441.GetComponent<ParticleEmitter>().emit = true;
					result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__002441.GetComponent<ParticleEmitter>().emit = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Delay _0024self__002442;

		public _0024Main_002440(Delay self_)
		{
			_0024self__002442 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002442);
		}
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator Main()
	{
		return new _0024Main_002440(this).GetEnumerator();
	}
}
