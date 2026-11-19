using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class DestroyRubble : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024Start_002455 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_002456;

			internal DestroyRubble _0024self__002457;

			public _0024(DestroyRubble self_)
			{
				_0024self__002457 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(_0024self__002457.time)) ? 1 : 0);
					break;
				case 2:
					_0024i_002456 = 0;
					goto IL_0095;
				case 3:
					UnityEngine.Object.Destroy(_0024self__002457.gameObject);
					_0024i_002456++;
					goto IL_0095;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0095:
					if (_0024i_002456 < Extensions.get_length((System.Array)_0024self__002457.particleEmitters))
					{
						_0024self__002457.particleEmitters[_0024i_002456].emit = false;
						result = (Yield(3, new WaitForSeconds(_0024self__002457.maxTime)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal DestroyRubble _0024self__002458;

		public _0024Start_002455(DestroyRubble self_)
		{
			_0024self__002458 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002458);
		}
	}

	public float maxTime;

	public ParticleEmitter[] particleEmitters;

	public float time;

	public DestroyRubble()
	{
		maxTime = 3f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_002455(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
