using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Sirenix.Serialization;
using Sirenix.Utilities;
using UnityEngine;
using UnityEngine.Video;

[Serializable]
public class BetterEventEntry : ISerializationCallbackReceiver
{
	private struct OdinSerializedData
	{
		public Delegate Delegate;

		public object[] ParameterValues;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInvoke_003Ec__async0 : IAsyncStateMachine
	{
		internal BetterEventEntry _0024this;

		internal AsyncVoidMethodBuilder _0024builder;

		internal int _0024PC;

		private TaskAwaiter _0024awaiter0;

		public void MoveNext()
		{
			uint num = (uint)_0024PC;
			_0024PC = -1;
			try
			{
				switch (num)
				{
				default:
					return;
				case 0u:
					if ((object)_0024this.Delegate != null && _0024this.ParameterValues != null && !_0024this.OnceEnded)
					{
						_0024awaiter0 = Task.Delay(TimeSpan.FromSeconds(_0024this.DelayInvoke)).GetAwaiter();
						if (!_0024awaiter0.IsCompleted)
						{
							_0024PC = 1;
							_0024builder.AwaitUnsafeOnCompleted(ref _0024awaiter0, ref this);
							return;
						}
						break;
					}
					goto end_IL_000e;
				case 1u:
					break;
				}
				_0024awaiter0.GetResult();
				_0024this.Delegate.Method.Invoke(_0024this.Delegate.Target, _0024this.ParameterValues);
				if (_0024this.InvokeOnce)
				{
					_0024this.OnceEnded = true;
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_0024PC = -1;
				_0024builder.SetException(exception);
				return;
			}
			_0024PC = -1;
			_0024builder.SetResult();
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_0024builder.SetStateMachine(stateMachine);
		}
	}

	[NonSerialized]
	[HideInInspector]
	public Delegate Delegate;

	public float DelayInvoke;

	public bool InvokeOnce;

	public bool ResetEvent = true;

	[NonSerialized]
	[HideInInspector]
	public object[] ParameterValues;

	private Dictionary<string, object> _propertyValues = new Dictionary<string, object>();

	private IEnumerable<MemberInfo> members;

	internal bool OnceEnded;

	private bool ActiveState;

	private bool animation;

	private bool audio;

	private bool particle;

	private bool video;

	[HideInInspector]
	[SerializeField]
	private List<UnityEngine.Object> unityReferences;

	[SerializeField]
	[HideInInspector]
	private byte[] bytes;

	public BetterEventEntry(Delegate del)
	{
		if ((object)del != null && del.Method != null)
		{
			Delegate = del;
			ParameterValues = new object[del.Method.GetParameters().Length];
		}
	}

	public void Init()
	{
		if (!ResetEvent || (object)Delegate == null)
		{
			return;
		}
		if (OnceEnded)
		{
			OnceEnded = false;
		}
		ActiveState = Delegate.Target.GetType() == typeof(GameObject) && (Delegate.Target as GameObject).activeSelf;
		animation = ((Delegate.Target.GetType() == typeof(Animation)) ? true : false);
		audio = ((Delegate.Target.GetType() == typeof(AudioSource)) ? true : false);
		particle = ((Delegate.Target.GetType() == typeof(ParticleSystem)) ? true : false);
		video = ((Delegate.Target.GetType() == typeof(VideoPlayer)) ? true : false);
		if (Delegate.Target is Trigger2)
		{
			return;
		}
		_propertyValues = new Dictionary<string, object>();
		object obj = ((!particle) ? Delegate.Target : ((object)(Delegate.Target as ParticleSystem).main));
		members = (from p in obj.GetType().GetProperties()
			where p.CanRead && p.CanWrite
			select p).Cast<MemberInfo>().Concat(obj.GetType().GetFields());
		foreach (MemberInfo member in members)
		{
			if (!member.IsDefined(typeof(ObsoleteAttribute), true))
			{
				object obj2 = ((member is FieldInfo) ? ((FieldInfo)member).GetValue(obj) : (((object)member == null) ? ((PropertyInfo)member).GetValue(obj) : member.GetMemberValue(obj)));
				string arg = ((obj2 == null) ? string.Empty : obj2.ToString());
				UnityEngine.Debug.LogError(string.Format("{0} / {1}", member.Name, arg));
				_propertyValues.Add(member.Name, obj2);
			}
		}
	}

	public void Reset()
	{
		if (!ResetEvent || (object)Delegate == null)
		{
			return;
		}
		if (OnceEnded)
		{
			OnceEnded = false;
		}
		if (Delegate.Target.GetType() == typeof(GameObject))
		{
			(Delegate.Target as GameObject).SetActive(ActiveState);
		}
		if (members != null)
		{
			object obj = ((!particle) ? Delegate.Target : ((object)(Delegate.Target as ParticleSystem).main));
			foreach (MemberInfo member in members)
			{
				if (!member.IsDefined(typeof(ObsoleteAttribute), true) && member.Name != "wrapMode" && member.Name != "duration" && video && member.Name != "url")
				{
					object value = ((!_propertyValues.ContainsKey(member.Name)) ? null : _propertyValues[member.Name]);
					if (member is FieldInfo)
					{
						((FieldInfo)member).SetValue(obj, value);
					}
					else
					{
						((PropertyInfo)member).SetValue(obj, value);
					}
				}
			}
		}
		if (animation)
		{
			(Delegate.Target as Animation).ResetAnimationState(false);
		}
		if (audio && (Delegate.Target as AudioSource).isPlaying)
		{
			(Delegate.Target as AudioSource).Stop();
		}
		if (particle)
		{
			(Delegate.Target as ParticleSystem).Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
		}
		if (video && (Delegate.Target as VideoPlayer).isPlaying)
		{
			(Delegate.Target as VideoPlayer).Stop();
		}
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CInvoke_003Ec__async0))]
	public void Invoke()
	{
		_003CInvoke_003Ec__async0 stateMachine = default(_003CInvoke_003Ec__async0);
		stateMachine._0024this = this;
		stateMachine._0024builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024builder.Start(ref stateMachine);
	}

	public void OnAfterDeserialize()
	{
		OdinSerializedData odinSerializedData = SerializationUtility.DeserializeValue<OdinSerializedData>(bytes, DataFormat.Binary, unityReferences);
		Delegate = odinSerializedData.Delegate;
		ParameterValues = odinSerializedData.ParameterValues;
	}

	public void OnBeforeSerialize()
	{
		OdinSerializedData value = new OdinSerializedData
		{
			Delegate = Delegate,
			ParameterValues = ParameterValues
		};
		bytes = SerializationUtility.SerializeValue(value, DataFormat.Binary, out unityReferences);
	}
}
