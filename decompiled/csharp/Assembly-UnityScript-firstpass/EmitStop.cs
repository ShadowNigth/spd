using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EmitStop : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Main_002446 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EmitStop _0024self__002447;

			public _0024(EmitStop self_)
			{
				_0024self__002447 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002447.GetComponent<ParticleEmitter>().emit = true;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002447.GetComponent<ParticleEmitter>().emit = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EmitStop _0024self__002448;

		public _0024Main_002446(EmitStop self_)
		{
			_0024self__002448 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002448);
		}
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator Main()
	{
		return new _0024Main_002446(this).GetEnumerator();
	}
}
