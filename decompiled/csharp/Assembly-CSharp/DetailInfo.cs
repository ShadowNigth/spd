using UnityEngine;
using UnityEngine.UI;

public class DetailInfo : MonoBehaviour
{
	public Text Title;

	public Text Cost;

	public Text Info;

	public Text Patrons;

	public Text Award;

	public Text Damage;

	public Text FireRate;

	public Text RecoilControl;

	public Text Range;

	public Text ArmourDamage;

	public Text Penetrate;

	public Text KickBack;

	public void SetTitle(Text Obj)
	{
		Title.text = Obj.text;
	}

	public void SetCost(Text Obj)
	{
		Cost.text = Obj.text;
	}

	public void SetInfo(string Obj)
	{
		Info.text = Obj;
	}

	public void SetPatrons(string Obj)
	{
		Patrons.text = Obj;
	}

	public void SetAward(string Obj)
	{
		Award.text = Obj;
	}

	public void SetDamage(string Obj)
	{
		Damage.text = Obj;
	}

	public void SetFireRate(string Obj)
	{
		FireRate.text = Obj;
	}

	public void SetRecoilControl(string Obj)
	{
		RecoilControl.text = Obj;
	}

	public void SetRange(string Obj)
	{
		Range.text = Obj;
	}

	public void SetArmourDamage(string Obj)
	{
		ArmourDamage.text = Obj;
	}

	public void SetPenetrate(string Obj)
	{
		Penetrate.text = Obj;
	}

	public void SetKickBack(string Obj)
	{
		KickBack.text = Obj;
	}
}
