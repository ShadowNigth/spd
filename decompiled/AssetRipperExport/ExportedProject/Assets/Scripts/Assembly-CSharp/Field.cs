using System;

public class Field : Attribute
{
	public Type[] ignore;

	public Type[] include;

	public string name;

	public float min;

	public float max = 100f;

	public bool customOnly;

	public bool cspOnly;

	public Action act;

	public bool androidOnly;

	public bool tdmOnly;

	public IMCJHBIFEAK[] gameType = new IMCJHBIFEAK[0];

	public string[] dependsOn = new string[0];
}
