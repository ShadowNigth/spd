using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;

[Serializable]
public class EffectSequencer : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00249 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal ExplosionPart _0024go_002410;

			internal float _0024maxTime_002411;

			internal IEnumerator _0024_0024iterator_00245_002412;

			internal IEnumerator _0024_0024iterator_00246_002413;

			internal IEnumerator _0024_0024iterator_00247_002414;

			internal IEnumerator _0024_0024iterator_00248_002415;

			internal EffectSequencer _0024self__002416;

			public _0024(EffectSequencer HDMIEAJBHLJ)
			{
				_0024self__002416 = HDMIEAJBHLJ;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024go_002410 = null;
					_0024maxTime_002411 = 0f;
					_0024_0024iterator_00245_002412 = _0024self__002416.ambientEmitters.GetEnumerator();
					while (_0024_0024iterator_00245_002412.MoveNext())
					{
						object obj2 = _0024_0024iterator_00245_002412.Current;
						if (!(obj2 is ExplosionPart))
						{
							obj2 = RuntimeServices.Coerce(obj2, typeof(ExplosionPart));
						}
						_0024go_002410 = (ExplosionPart)obj2;
						_0024self__002416.StartCoroutine(_0024self__002416.InstantiateDelayed(_0024go_002410));
						if ((bool)_0024go_002410.gameObject.GetComponent<ParticleEmitter>())
						{
							_0024maxTime_002411 = Mathf.Max(_0024maxTime_002411, _0024go_002410.delay + _0024go_002410.gameObject.GetComponent<ParticleEmitter>().maxEnergy);
						}
					}
					_0024_0024iterator_00246_002413 = _0024self__002416.explosionEmitters.GetEnumerator();
					while (_0024_0024iterator_00246_002413.MoveNext())
					{
						object obj3 = _0024_0024iterator_00246_002413.Current;
						if (!(obj3 is ExplosionPart))
						{
							obj3 = RuntimeServices.Coerce(obj3, typeof(ExplosionPart));
						}
						_0024go_002410 = (ExplosionPart)obj3;
						_0024self__002416.StartCoroutine(_0024self__002416.InstantiateDelayed(_0024go_002410));
						if ((bool)_0024go_002410.gameObject.GetComponent<ParticleEmitter>())
						{
							_0024maxTime_002411 = Mathf.Max(_0024maxTime_002411, _0024go_002410.delay + _0024go_002410.gameObject.GetComponent<ParticleEmitter>().maxEnergy);
						}
					}
					_0024_0024iterator_00247_002414 = _0024self__002416.smokeEmitters.GetEnumerator();
					while (_0024_0024iterator_00247_002414.MoveNext())
					{
						object obj4 = _0024_0024iterator_00247_002414.Current;
						if (!(obj4 is ExplosionPart))
						{
							obj4 = RuntimeServices.Coerce(obj4, typeof(ExplosionPart));
						}
						_0024go_002410 = (ExplosionPart)obj4;
						_0024self__002416.StartCoroutine(_0024self__002416.InstantiateDelayed(_0024go_002410));
						if ((bool)_0024go_002410.gameObject.GetComponent<ParticleEmitter>())
						{
							_0024maxTime_002411 = Mathf.Max(_0024maxTime_002411, _0024go_002410.delay + _0024go_002410.gameObject.GetComponent<ParticleEmitter>().maxEnergy);
						}
					}
					if ((bool)_0024self__002416.GetComponent<AudioSource>() && (bool)_0024self__002416.GetComponent<AudioSource>().clip)
					{
						_0024maxTime_002411 = Mathf.Max(_0024maxTime_002411, _0024self__002416.GetComponent<AudioSource>().clip.length);
					}
					result = (YieldDefault(2) ? 1 : 0);
					break;
				case 2:
					_0024_0024iterator_00248_002415 = _0024self__002416.miscSpecialEffects.GetEnumerator();
					while (_0024_0024iterator_00248_002415.MoveNext())
					{
						object obj = _0024_0024iterator_00248_002415.Current;
						if (!(obj is ExplosionPart))
						{
							obj = RuntimeServices.Coerce(obj, typeof(ExplosionPart));
						}
						_0024go_002410 = (ExplosionPart)obj;
						_0024self__002416.StartCoroutine(_0024self__002416.InstantiateDelayed(_0024go_002410));
						if ((bool)_0024go_002410.gameObject.GetComponent<ParticleEmitter>())
						{
							_0024maxTime_002411 = Mathf.Max(_0024maxTime_002411, _0024go_002410.delay + _0024go_002410.gameObject.GetComponent<ParticleEmitter>().maxEnergy);
						}
					}
					UnityEngine.Object.Destroy(_0024self__002416.gameObject, _0024maxTime_002411 + 0.5f);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EffectSequencer _0024self__002417;

		public _0024Start_00249(EffectSequencer HDMIEAJBHLJ)
		{
			_0024self__002417 = HDMIEAJBHLJ;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new _0024(_0024self__002417);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024InstantiateDelayed_002418 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ExplosionPart _0024go_002419;

			internal EffectSequencer _0024self__002420;

			public _0024(ExplosionPart BIMHAGOKNME, EffectSequencer HDMIEAJBHLJ)
			{
				_0024go_002419 = BIMHAGOKNME;
				_0024self__002420 = HDMIEAJBHLJ;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(_0024go_002419.delay)) ? 1 : 0);
					break;
				case 2:
					UnityEngine.Object.Instantiate(_0024go_002419.gameObject, _0024self__002420.transform.position + Vector3.up * _0024go_002419.yOffset, _0024self__002420.transform.rotation);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ExplosionPart _0024go_002421;

		internal EffectSequencer _0024self__002422;

		public _0024InstantiateDelayed_002418(ExplosionPart BIMHAGOKNME, EffectSequencer HDMIEAJBHLJ)
		{
			_0024go_002421 = BIMHAGOKNME;
			_0024self__002422 = HDMIEAJBHLJ;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024go_002421, _0024self__002422);
		}
	}

	public ExplosionPart[] ambientEmitters;

	public ExplosionPart[] explosionEmitters;

	public ExplosionPart[] smokeEmitters;

	public ExplosionPart[] miscSpecialEffects;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00249(this).GetEnumerator();
	}

	public virtual IEnumerator InstantiateDelayed(ExplosionPart BIMHAGOKNME)
	{
		return new _0024InstantiateDelayed_002418(BIMHAGOKNME, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
