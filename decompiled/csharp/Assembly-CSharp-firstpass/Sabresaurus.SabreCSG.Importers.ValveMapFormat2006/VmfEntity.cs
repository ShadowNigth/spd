using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Sabresaurus.SabreCSG.Importers.ValveMapFormat2006;

public class VmfEntity
{
	public int Id = -1;

	public string ClassName;

	public Vector3 Origin;

	public Vector3 Angles;

	public string Pitch;

	public List<VmfSolid> Solids = new List<VmfSolid>();

	public Vector4 GetVector(string Value, bool Reverse = false)
	{
		float[] array = new float[4];
		if (!string.IsNullOrEmpty(Value))
		{
			string[] array2 = Value.Split(' ');
			for (int i = 0; i < array.Length && i < array2.Length; i++)
			{
				try
				{
					array[i] = float.Parse(array2[i], CultureInfo.CreateSpecificCulture("en-US"));
				}
				catch
				{
					array[i] = 0f;
				}
			}
		}
		if (Reverse)
		{
			return new Vector4(0f - array[0], array[2], 0f - array[1], array[3]);
		}
		return new Vector4(array[0], array[1], array[2], array[3]);
	}

	public void SetupLightNormalFromProps(Quaternion angles, float angle, float pitch, ref Vector3 output)
	{
		if (angle == -1f)
		{
			float value = (output[1] = 0f);
			output[0] = value;
			output[2] = 1f;
		}
		else if (angle == -2f)
		{
			float value = (output[1] = 0f);
			output[0] = value;
			output[2] = -1f;
		}
		else
		{
			if (angle == 0f)
			{
				angle = angles[1];
			}
			output[2] = 0f;
			output[0] = (float)Math.Cos((double)(angle / 180f) * Math.PI);
			output[1] = (float)Math.Sin((double)(angle / 180f) * Math.PI);
		}
		if (pitch == 0f)
		{
			pitch = angles[0];
		}
		output[2] = (float)Math.Sin((double)(pitch / 180f) * Math.PI);
		output[0] *= (float)Math.Cos((double)(pitch / 180f) * Math.PI);
		output[1] *= (float)Math.Cos((double)(pitch / 180f) * Math.PI);
	}

	public float GetFloat(string key, float? failDefault = null)
	{
		try
		{
			return float.Parse(key, CultureInfo.CreateSpecificCulture("en-US"));
		}
		catch (Exception ex)
		{
			if (!failDefault.HasValue)
			{
				throw ex;
			}
			return failDefault.Value;
		}
	}

	public float RAD2DEG(double x)
	{
		return (float)x * 57.29578f;
	}

	public void VectorAngles(Vector3 forward, ref Quaternion angles)
	{
		float num;
		float num2;
		if (forward[1] == 0f && forward[0] == 0f)
		{
			num = 0f;
			num2 = ((!(forward[2] > 0f)) ? 90f : 270f);
		}
		else
		{
			num = Mathf.Atan2(forward[1], forward[0]) * 180f / (float)Math.PI;
			if (num < 0f)
			{
				num += 360f;
			}
			float x = Mathf.Sqrt(forward[0] * forward[0] + forward[1] * forward[1]);
			num2 = Mathf.Atan2(0f - forward[2], x) * 180f / (float)Math.PI;
			if (num2 < 0f)
			{
				num2 += 360f;
			}
		}
		angles[0] = num2;
		angles[1] = num;
		angles[2] = 0f;
	}

	public void VectorAngles(Vector3 forward, Vector3 pseudoup, ref Quaternion angles)
	{
		Vector3 value = Vector3.Cross(pseudoup, forward);
		value = Vector3.Normalize(value);
		float num = Mathf.Sqrt(forward[0] * forward[0] + forward[1] * forward[1]);
		if (num > 0.001f)
		{
			angles[1] = RAD2DEG(Mathf.Atan2(forward[1], forward[0]));
			angles[0] = RAD2DEG(Mathf.Atan2(0f - forward[2], num));
			float x = value[1] * forward[0] - value[0] * forward[1];
			angles[2] = RAD2DEG(Mathf.Atan2(value[2], x));
		}
		else
		{
			angles[1] = RAD2DEG(Mathf.Atan2(0f - value[0], value[1]));
			angles[0] = RAD2DEG(Mathf.Atan2(0f - forward[2], num));
			angles[2] = 0f;
		}
	}

	public override string ToString()
	{
		return "VmfEntity " + ClassName + " " + Id + " (" + Solids.Count + " Solids)";
	}
}
