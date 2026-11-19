using System.Collections;
using System.Collections.Generic;

internal class DLONDPANGNC : IDictionaryEnumerator, IEnumerator
{
	private IEnumerator<KeyValuePair<string, FLFCPGBMGHH>> DHPNIFIAHMG;

	public object MKFPMJFNENL => GJOCGPCAEAP;

	public DictionaryEntry GJOCGPCAEAP
	{
		get
		{
			KeyValuePair<string, FLFCPGBMGHH> current = DHPNIFIAHMG.Current;
			return new DictionaryEntry(current.Key, current.Value);
		}
	}

	public object CJBHGPCJCNP => DHPNIFIAHMG.Current.Key;

	public object JFLFLCDEEEI => DHPNIFIAHMG.Current.Value;

	public DLONDPANGNC(IEnumerator<KeyValuePair<string, FLFCPGBMGHH>> EJFECBFKKEP)
	{
		DHPNIFIAHMG = EJFECBFKKEP;
	}

	public bool MoveNext()
	{
		return DHPNIFIAHMG.MoveNext();
	}

	public void Reset()
	{
		DHPNIFIAHMG.Reset();
	}
}
