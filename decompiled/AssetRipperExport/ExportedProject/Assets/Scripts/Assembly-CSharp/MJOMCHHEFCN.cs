using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

[RequireComponent(typeof(GUIText))]
public class MJOMCHHEFCN : MonoBehaviour
{
	public SecureInt HKFKNNFBCBM = SecureInt.FNIPJFGEFFD(123123);

	public SecureInt BLFKEILGCCE = SecureInt.FNIPJFGEFFD(0);

	private SecureInt ECICPJFGPOO = new SecureInt();

	public ObscuredInt NLIKPLNDAID = ObscuredInt.FNIPJFGEFFD(12341234);

	[CompilerGenerated]
	private static Func<SecureInt, SecureInt> ACJNADIPOMC;

	public void Awake()
	{
		SecureInt.started = true;
	}

	public void Start()
	{
		List<SecureInt> list = new List<SecureInt>();
		list.Add(SecureInt.FNIPJFGEFFD(1));
		list.Add(SecureInt.FNIPJFGEFFD(1));
		ECICPJFGPOO = SecureInt.FNIPJFGEFFD(3);
		BLFKEILGCCE = SecureInt.GAIIFHAAPIJ(BLFKEILGCCE, 1);
		IOrderedEnumerable<SecureInt> lGNIFJCEECH = list.OrderBy((SecureInt AEMBPMJMOAB) => AEMBPMJMOAB);
		MOHMCMAMDAL(lGNIFJCEECH);
	}

	public void Update()
	{
		GetComponent<GUIText>().text = SecureInt.detected + string.Empty;
		if (Input.GetKeyDown(KeyCode.A))
		{
			HKFKNNFBCBM = SecureInt.HGADPBHCGCI(HKFKNNFBCBM, 1);
			NLIKPLNDAID = ObscuredInt.FNIPJFGEFFD(ObscuredInt.FNIPJFGEFFD(NLIKPLNDAID) + 2);
		}
		MOHMCMAMDAL(HKFKNNFBCBM);
		MOHMCMAMDAL(BLFKEILGCCE);
		MOHMCMAMDAL(ECICPJFGPOO);
	}

	public void MOHMCMAMDAL(object LGNIFJCEECH)
	{
		GUIText component = GetComponent<GUIText>();
		component.text = component.text + "\n" + LGNIFJCEECH;
	}

	[CompilerGenerated]
	private static SecureInt JDGOKBJLEBB(SecureInt AEMBPMJMOAB)
	{
		return AEMBPMJMOAB;
	}
}
