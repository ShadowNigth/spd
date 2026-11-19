using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sabresaurus.SabreCSG;

public static class BrushFactory
{
	public static Polygon[] GenerateCube()
	{
		return new Polygon[6]
		{
			new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(-1f, -1f, 1f), new Vector3(0f, 0f, 1f), new Vector2(1f, 0f)),
				new Vertex(new Vector3(1f, -1f, 1f), new Vector3(0f, 0f, 1f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 1f), new Vector2(0f, 1f)),
				new Vertex(new Vector3(-1f, 1f, 1f), new Vector3(0f, 0f, 1f), new Vector2(1f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(-1f, -1f, -1f), new Vector3(-1f, 0f, 0f), new Vector2(1f, 0f)),
				new Vertex(new Vector3(-1f, -1f, 1f), new Vector3(-1f, 0f, 0f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(-1f, 1f, 1f), new Vector3(-1f, 0f, 0f), new Vector2(0f, 1f)),
				new Vertex(new Vector3(-1f, 1f, -1f), new Vector3(-1f, 0f, 0f), new Vector2(1f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(1f, -1f, 1f), new Vector3(1f, 0f, 0f), new Vector2(1f, 0f)),
				new Vertex(new Vector3(1f, -1f, -1f), new Vector3(1f, 0f, 0f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(1f, 1f, -1f), new Vector3(1f, 0f, 0f), new Vector2(0f, 1f)),
				new Vertex(new Vector3(1f, 1f, 1f), new Vector3(1f, 0f, 0f), new Vector2(1f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(1f, -1f, -1f), new Vector3(0f, 0f, -1f), new Vector2(1f, 0f)),
				new Vertex(new Vector3(-1f, -1f, -1f), new Vector3(0f, 0f, -1f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(-1f, 1f, -1f), new Vector3(0f, 0f, -1f), new Vector2(0f, 1f)),
				new Vertex(new Vector3(1f, 1f, -1f), new Vector3(0f, 0f, -1f), new Vector2(1f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(-1f, -1f, -1f), new Vector3(0f, -1f, 0f), new Vector2(1f, 0f)),
				new Vertex(new Vector3(1f, -1f, -1f), new Vector3(0f, -1f, 0f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(1f, -1f, 1f), new Vector3(0f, -1f, 0f), new Vector2(0f, 1f)),
				new Vertex(new Vector3(-1f, -1f, 1f), new Vector3(0f, -1f, 0f), new Vector2(1f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(-1f, 1f, -1f), new Vector3(0f, 1f, 0f), new Vector2(1f, 0f)),
				new Vertex(new Vector3(-1f, 1f, 1f), new Vector3(0f, 1f, 0f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(1f, 1f, 1f), new Vector3(0f, 1f, 0f), new Vector2(0f, 1f)),
				new Vertex(new Vector3(1f, 1f, -1f), new Vector3(0f, 1f, 0f), new Vector2(1f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false)
		};
	}

	public static Polygon[] GenerateCylinder(int sideCount = 20)
	{
		Polygon[] array = new Polygon[sideCount * 3];
		float num = (float)Math.PI * 2f / (float)sideCount;
		for (int i = 0; i < sideCount; i++)
		{
			array[i] = new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(Mathf.Sin((float)i * num), -1f, Mathf.Cos((float)i * num)), new Vector3(Mathf.Sin((float)i * num), 0f, Mathf.Cos((float)i * num)), new Vector2((float)i * (1f / (float)sideCount), 0f)),
				new Vertex(new Vector3(Mathf.Sin((float)(i + 1) * num), -1f, Mathf.Cos((float)(i + 1) * num)), new Vector3(Mathf.Sin((float)(i + 1) * num), 0f, Mathf.Cos((float)(i + 1) * num)), new Vector2((float)(i + 1) * (1f / (float)sideCount), 0f)),
				new Vertex(new Vector3(Mathf.Sin((float)(i + 1) * num), 1f, Mathf.Cos((float)(i + 1) * num)), new Vector3(Mathf.Sin((float)(i + 1) * num), 0f, Mathf.Cos((float)(i + 1) * num)), new Vector2((float)(i + 1) * (1f / (float)sideCount), 1f)),
				new Vertex(new Vector3(Mathf.Sin((float)i * num), 1f, Mathf.Cos((float)i * num)), new Vector3(Mathf.Sin((float)i * num), 0f, Mathf.Cos((float)i * num)), new Vector2((float)i * (1f / (float)sideCount), 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false);
		}
		Vertex vertex = new Vertex(new Vector3(0f, 1f, 0f), Vector3.up, new Vector2(0f, 0f));
		for (int j = 0; j < sideCount; j++)
		{
			Vertex vertex2 = new Vertex(new Vector3(Mathf.Sin((float)j * num), 1f, Mathf.Cos((float)j * num)), Vector3.up, new Vector2(Mathf.Sin((float)j * num), Mathf.Cos((float)j * num)));
			Vertex vertex3 = new Vertex(new Vector3(Mathf.Sin((float)(j + 1) * num), 1f, Mathf.Cos((float)(j + 1) * num)), Vector3.up, new Vector2(Mathf.Sin((float)(j + 1) * num), Mathf.Cos((float)(j + 1) * num)));
			Vertex[] vertices = new Vertex[3]
			{
				vertex2,
				vertex3,
				vertex.DeepCopy()
			};
			array[sideCount + j] = new Polygon(vertices, null, isTemporary: false, userExcludeFromFinal: false);
		}
		vertex = new Vertex(new Vector3(0f, -1f, 0f), Vector3.down, new Vector2(0f, 0f));
		for (int k = 0; k < sideCount; k++)
		{
			Vertex vertex4 = new Vertex(new Vector3(Mathf.Sin((float)k * (0f - num)), -1f, Mathf.Cos((float)k * (0f - num))), Vector3.down, new Vector2(Mathf.Sin((float)k * num), Mathf.Cos((float)k * num)));
			Vertex vertex5 = new Vertex(new Vector3(Mathf.Sin((float)(k + 1) * (0f - num)), -1f, Mathf.Cos((float)(k + 1) * (0f - num))), Vector3.down, new Vector2(Mathf.Sin((float)(k + 1) * num), Mathf.Cos((float)(k + 1) * num)));
			Vertex[] vertices2 = new Vertex[3]
			{
				vertex4,
				vertex5,
				vertex.DeepCopy()
			};
			array[sideCount * 2 + k] = new Polygon(vertices2, null, isTemporary: false, userExcludeFromFinal: false);
		}
		return array;
	}

	public static Polygon[] GeneratePrism(int sideCount)
	{
		Polygon[] array = new Polygon[sideCount * 3];
		float num = (float)Math.PI * 2f / (float)sideCount;
		for (int i = 0; i < sideCount; i++)
		{
			Vector3 normal = new Vector3(Mathf.Sin(((float)i + 0.5f) * num), 0f, Mathf.Cos(((float)i + 0.5f) * num));
			array[i] = new Polygon(new Vertex[4]
			{
				new Vertex(new Vector3(Mathf.Sin((float)i * num), -1f, Mathf.Cos((float)i * num)), normal, new Vector2(0f, 0f)),
				new Vertex(new Vector3(Mathf.Sin((float)(i + 1) * num), -1f, Mathf.Cos((float)(i + 1) * num)), normal, new Vector2(1f, 0f)),
				new Vertex(new Vector3(Mathf.Sin((float)(i + 1) * num), 1f, Mathf.Cos((float)(i + 1) * num)), normal, new Vector2(1f, 1f)),
				new Vertex(new Vector3(Mathf.Sin((float)i * num), 1f, Mathf.Cos((float)i * num)), normal, new Vector2(0f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false);
		}
		Vertex vertex = new Vertex(new Vector3(0f, 1f, 0f), Vector3.up, new Vector2(0f, 0f));
		for (int j = 0; j < sideCount; j++)
		{
			Vertex vertex2 = new Vertex(new Vector3(Mathf.Sin((float)j * num), 1f, Mathf.Cos((float)j * num)), Vector3.up, new Vector2(Mathf.Sin((float)j * num), Mathf.Cos((float)j * num)));
			Vertex vertex3 = new Vertex(new Vector3(Mathf.Sin((float)(j + 1) * num), 1f, Mathf.Cos((float)(j + 1) * num)), Vector3.up, new Vector2(Mathf.Sin((float)(j + 1) * num), Mathf.Cos((float)(j + 1) * num)));
			Vertex[] vertices = new Vertex[3]
			{
				vertex2,
				vertex3,
				vertex.DeepCopy()
			};
			array[sideCount + j] = new Polygon(vertices, null, isTemporary: false, userExcludeFromFinal: false);
		}
		vertex = new Vertex(new Vector3(0f, -1f, 0f), Vector3.down, new Vector2(0f, 0f));
		for (int k = 0; k < sideCount; k++)
		{
			Vertex vertex4 = new Vertex(new Vector3(Mathf.Sin((float)k * (0f - num)), -1f, Mathf.Cos((float)k * (0f - num))), Vector3.down, new Vector2(Mathf.Sin((float)k * num), Mathf.Cos((float)k * num)));
			Vertex vertex5 = new Vertex(new Vector3(Mathf.Sin((float)(k + 1) * (0f - num)), -1f, Mathf.Cos((float)(k + 1) * (0f - num))), Vector3.down, new Vector2(Mathf.Sin((float)(k + 1) * num), Mathf.Cos((float)(k + 1) * num)));
			Vertex[] vertices2 = new Vertex[3]
			{
				vertex4,
				vertex5,
				vertex.DeepCopy()
			};
			array[sideCount * 2 + k] = new Polygon(vertices2, null, isTemporary: false, userExcludeFromFinal: false);
		}
		return array;
	}

	[Obsolete("Use GeneratePolarSphere instead, or for a more isotropic geometry use GenerateIcoSphere")]
	public static Polygon[] GenerateSphere(int lateralCount = 6, int longitudinalCount = 12)
	{
		return GeneratePolarSphere(lateralCount, longitudinalCount);
	}

	public static Polygon[] GenerateIcoSphere(int iterationCount)
	{
		float z = (1f + Mathf.Sqrt(5f)) / 2f;
		Vector3 vector = new Vector3(0f, 1f, z);
		vector.Normalize();
		Vertex[] array = new Vertex[12]
		{
			new Vertex(new Vector3(0f - vector.y, vector.z, vector.x), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.y, vector.z, vector.x), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(0f - vector.y, 0f - vector.z, vector.x), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.y, 0f - vector.z, vector.x), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.x, 0f - vector.y, vector.z), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.x, vector.y, vector.z), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.x, 0f - vector.y, 0f - vector.z), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.x, vector.y, 0f - vector.z), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.z, vector.x, 0f - vector.y), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(vector.z, vector.x, vector.y), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(0f - vector.z, vector.x, 0f - vector.y), Vector3.zero, Vector2.zero),
			new Vertex(new Vector3(0f - vector.z, vector.x, vector.y), Vector3.zero, Vector2.zero)
		};
		Polygon[] array2 = new Polygon[20]
		{
			new Polygon(new Vertex[3]
			{
				array[0].DeepCopy(),
				array[1].DeepCopy(),
				array[7].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[0].DeepCopy(),
				array[5].DeepCopy(),
				array[1].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[0].DeepCopy(),
				array[7].DeepCopy(),
				array[10].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[0].DeepCopy(),
				array[10].DeepCopy(),
				array[11].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[0].DeepCopy(),
				array[11].DeepCopy(),
				array[5].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[7].DeepCopy(),
				array[1].DeepCopy(),
				array[8].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[1].DeepCopy(),
				array[5].DeepCopy(),
				array[9].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[10].DeepCopy(),
				array[7].DeepCopy(),
				array[6].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[11].DeepCopy(),
				array[10].DeepCopy(),
				array[2].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[5].DeepCopy(),
				array[11].DeepCopy(),
				array[4].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[3].DeepCopy(),
				array[2].DeepCopy(),
				array[6].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[3].DeepCopy(),
				array[4].DeepCopy(),
				array[2].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[3].DeepCopy(),
				array[6].DeepCopy(),
				array[8].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[3].DeepCopy(),
				array[8].DeepCopy(),
				array[9].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[3].DeepCopy(),
				array[9].DeepCopy(),
				array[4].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[6].DeepCopy(),
				array[2].DeepCopy(),
				array[10].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[2].DeepCopy(),
				array[4].DeepCopy(),
				array[11].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[8].DeepCopy(),
				array[6].DeepCopy(),
				array[7].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[9].DeepCopy(),
				array[8].DeepCopy(),
				array[1].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false),
			new Polygon(new Vertex[3]
			{
				array[4].DeepCopy(),
				array[9].DeepCopy(),
				array[5].DeepCopy()
			}, null, isTemporary: false, userExcludeFromFinal: false)
		};
		for (int i = 0; i < iterationCount; i++)
		{
			Polygon[] array3 = new Polygon[array2.Length * 4];
			for (int j = 0; j < array2.Length; j++)
			{
				Vertex vertex = Vertex.Lerp(array2[j].Vertices[0], array2[j].Vertices[1], 0.5f);
				Vertex vertex2 = Vertex.Lerp(array2[j].Vertices[1], array2[j].Vertices[2], 0.5f);
				Vertex vertex3 = Vertex.Lerp(array2[j].Vertices[2], array2[j].Vertices[0], 0.5f);
				vertex.Position = vertex.Position.normalized;
				vertex2.Position = vertex2.Position.normalized;
				vertex3.Position = vertex3.Position.normalized;
				array3[j * 4] = new Polygon(new Vertex[3]
				{
					array2[j].Vertices[0].DeepCopy(),
					vertex.DeepCopy(),
					vertex3.DeepCopy()
				}, null, isTemporary: false, userExcludeFromFinal: false);
				array3[j * 4 + 1] = new Polygon(new Vertex[3]
				{
					array2[j].Vertices[1].DeepCopy(),
					vertex2.DeepCopy(),
					vertex.DeepCopy()
				}, null, isTemporary: false, userExcludeFromFinal: false);
				array3[j * 4 + 2] = new Polygon(new Vertex[3]
				{
					array2[j].Vertices[2].DeepCopy(),
					vertex3.DeepCopy(),
					vertex2.DeepCopy()
				}, null, isTemporary: false, userExcludeFromFinal: false);
				array3[j * 4 + 3] = new Polygon(new Vertex[3]
				{
					vertex.DeepCopy(),
					vertex2.DeepCopy(),
					vertex3.DeepCopy()
				}, null, isTemporary: false, userExcludeFromFinal: false);
			}
			array2 = array3;
		}
		for (int k = 0; k < array2.Length; k++)
		{
			bool flag = false;
			for (int l = 0; l < array2[k].Vertices.Length; l++)
			{
				Vector3 normalized = array2[k].Vertices[l].Position.normalized;
				array2[k].Vertices[l].Normal = normalized;
				float num = 1f / (float)Math.PI;
				float num2 = 0.5f - 0.5f * Mathf.Atan2(normalized.x, 0f - normalized.z) * num;
				float y = 1f - Mathf.Acos(normalized.y) * num;
				if (Mathf.Abs(num2) < 0.01f || Mathf.Abs(1f - Mathf.Abs(num2)) < 0.01f)
				{
					num2 = ((!(array2[k].Plane.normal.x > 0f)) ? 1f : 0f);
				}
				if (num2 > 0.75f)
				{
					flag = true;
				}
				array2[k].Vertices[l].UV = new Vector2(num2, y);
			}
			if (!flag)
			{
				continue;
			}
			for (int m = 0; m < array2[k].Vertices.Length; m++)
			{
				Vector2 uV = array2[k].Vertices[m].UV;
				if (uV.x < 0.5f)
				{
					uV.x += 1f;
				}
				array2[k].Vertices[m].UV = uV;
			}
		}
		return array2;
	}

	public static Polygon[] GeneratePolarSphere(int lateralCount = 6, int longitudinalCount = 12)
	{
		Polygon[] array = new Polygon[lateralCount * longitudinalCount];
		float num = 1f / (float)lateralCount;
		float num2 = 1f / (float)longitudinalCount;
		for (int i = 0; i < lateralCount; i++)
		{
			for (int j = 0; j < longitudinalCount; j++)
			{
				Vertex[] array2 = ((i == lateralCount - 1) ? new Vertex[3]
				{
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector2((float)i * (1f / (float)lateralCount), (float)(j + 1) * (1f / (float)longitudinalCount))),
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector2((float)(i + 1) * (1f / (float)lateralCount), (float)(j + 1) * (1f / (float)longitudinalCount))),
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector2((float)i * (1f / (float)lateralCount), (float)j * (1f / (float)longitudinalCount)))
				} : ((i <= 0) ? new Vertex[3]
				{
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector2((float)i * (1f / (float)lateralCount), (float)(j + 1) * (1f / (float)longitudinalCount))),
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector2((float)(i + 1) * (1f / (float)lateralCount), (float)(j + 1) * (1f / (float)longitudinalCount))),
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector2((float)(i + 1) * (1f / (float)lateralCount), (float)j * (1f / (float)longitudinalCount)))
				} : new Vertex[4]
				{
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector2((float)i * (1f / (float)lateralCount), (float)(j + 1) * (1f / (float)longitudinalCount))),
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)(j + 1) * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)(j + 1) * num2)), new Vector2((float)(i + 1) * (1f / (float)lateralCount), (float)(j + 1) * (1f / (float)longitudinalCount))),
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)(i + 1) * num), Mathf.Sin((float)Math.PI * (float)(i + 1) * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector2((float)(i + 1) * (1f / (float)lateralCount), (float)j * (1f / (float)longitudinalCount))),
					new Vertex(new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector3(Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Cos((float)Math.PI * 2f * (float)j * num2), Mathf.Cos((float)Math.PI * (float)i * num), Mathf.Sin((float)Math.PI * (float)i * num) * Mathf.Sin((float)Math.PI * 2f * (float)j * num2)), new Vector2((float)i * (1f / (float)lateralCount), (float)j * (1f / (float)longitudinalCount)))
				}));
				for (int k = 0; k < array2.Length; k++)
				{
					array2[k].UV = new Vector2(array2[k].UV.y, 1f - array2[k].UV.x);
				}
				array[i + j * lateralCount] = new Polygon(array2, null, isTemporary: false, userExcludeFromFinal: false);
			}
		}
		return array;
	}

	public static Polygon[] GenerateCone(int sideCount = 20)
	{
		Polygon[] array = new Polygon[sideCount * 2];
		if (sideCount == 3)
		{
			array = new Polygon[sideCount + 1];
			array[0] = new Polygon(new Vertex[3]
			{
				new Vertex(new Vector3(0f, -1f, -1f), new Vector3(0.8402f, 0.2425f, -0.4851f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(0f, 1f, 0f), new Vector3(0.8402f, 0.2425f, -0.4851f), new Vector2(0.5f, 1f)),
				new Vertex(new Vector3(1f, -1f, 1f), new Vector3(0.8402f, 0.2425f, -0.4851f), new Vector2(1f, 0f))
			}, null, isTemporary: false, userExcludeFromFinal: false);
			array[1] = new Polygon(new Vertex[3]
			{
				new Vertex(new Vector3(1f, -1f, 1f), new Vector3(-0f, 0.2425f, 0.9701f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(0f, 1f, 0f), new Vector3(-0f, 0.2425f, 0.9701f), new Vector2(0.5f, 1f)),
				new Vertex(new Vector3(-1f, -1f, 1f), new Vector3(-0f, 0.2425f, 0.9701f), new Vector2(1f, 0f))
			}, null, isTemporary: false, userExcludeFromFinal: false);
			array[2] = new Polygon(new Vertex[3]
			{
				new Vertex(new Vector3(-1f, -1f, 1f), new Vector3(-0.8402f, 0.2425f, -0.4851f), new Vector2(0f, 0f)),
				new Vertex(new Vector3(0f, 1f, 0f), new Vector3(-0.8402f, 0.2425f, -0.4851f), new Vector2(0.5f, 1f)),
				new Vertex(new Vector3(0f, -1f, -1f), new Vector3(-0.8402f, 0.2425f, -0.4851f), new Vector2(1f, 0f))
			}, null, isTemporary: false, userExcludeFromFinal: false);
			array[3] = new Polygon(new Vertex[3]
			{
				new Vertex(new Vector3(0f, -1f, -1f), Vector3.down, new Vector2(0f, 0f)),
				new Vertex(new Vector3(1f, -1f, 1f), Vector3.down, new Vector2(1f, 1f)),
				new Vertex(new Vector3(-1f, -1f, 1f), Vector3.down, new Vector2(1f, 0f))
			}, null, isTemporary: false, userExcludeFromFinal: false);
			return array;
		}
		float num = (float)Math.PI * 2f / (float)sideCount;
		for (int i = 0; i < sideCount; i++)
		{
			Vector3 normal = new Vector3(Mathf.Sin(((float)i + 0.5f) * num), 0f, Mathf.Cos(((float)i + 0.5f) * num));
			array[i] = new Polygon(new Vertex[3]
			{
				new Vertex(new Vector3(Mathf.Sin((float)i * num), -1f, Mathf.Cos((float)i * num)), normal, new Vector2((float)i * (1f / (float)sideCount), 0f)),
				new Vertex(new Vector3(Mathf.Sin((float)(i + 1) * num), -1f, Mathf.Cos((float)(i + 1) * num)), normal, new Vector2((float)(i + 1) * (1f / (float)sideCount), 0f)),
				new Vertex(new Vector3(0f, 1f, 0f), normal, new Vector2(((float)(i + 1) * (1f / (float)sideCount) + (float)i * (1f / (float)sideCount)) / 2f, 1f))
			}, null, isTemporary: false, userExcludeFromFinal: false);
		}
		Vertex vertex = new Vertex(new Vector3(0f, -1f, 0f), Vector3.down, new Vector2(0f, 0f));
		for (int j = 0; j < sideCount; j++)
		{
			Vertex vertex2 = new Vertex(new Vector3(Mathf.Sin((float)j * (0f - num)), -1f, Mathf.Cos((float)j * (0f - num))), Vector3.down, new Vector2(Mathf.Sin((float)j * num), Mathf.Cos((float)j * num)));
			Vertex vertex3 = new Vertex(new Vector3(Mathf.Sin((float)(j + 1) * (0f - num)), -1f, Mathf.Cos((float)(j + 1) * (0f - num))), Vector3.down, new Vector2(Mathf.Sin((float)(j + 1) * num), Mathf.Cos((float)(j + 1) * num)));
			Vertex[] vertices = new Vertex[3]
			{
				vertex2,
				vertex3,
				vertex.DeepCopy()
			};
			array[sideCount + j] = new Polygon(vertices, null, isTemporary: false, userExcludeFromFinal: false);
		}
		return array;
	}

	public static Polygon[] GenerateCapsule(float height = 2f, float radius = 0.5f, int segments = 24)
	{
		if (segments % 2 != 0)
		{
			segments++;
		}
		int num = segments + 1;
		float[] array = new float[num];
		float[] array2 = new float[num];
		float[] array3 = new float[num];
		float[] array4 = new float[num];
		float num2 = 0f;
		float num3 = 0f;
		for (int i = 0; i < num; i++)
		{
			array[i] = Mathf.Sin(num2 * ((float)Math.PI / 180f));
			array2[i] = Mathf.Cos(num2 * ((float)Math.PI / 180f));
			array3[i] = Mathf.Cos(num3 * ((float)Math.PI / 180f));
			array4[i] = Mathf.Sin(num3 * ((float)Math.PI / 180f));
			num2 += 360f / (float)segments;
			num3 += 180f / (float)segments;
		}
		Vector3[] array5 = new Vector3[num * (num + 1)];
		Vector2[] array6 = new Vector2[array5.Length];
		int num4 = 0;
		float num5 = (height - radius * 2f) * 0.5f;
		if (num5 < 0f)
		{
			num5 = 0f;
		}
		float num6 = 1f / (float)(num - 1);
		int num7 = Mathf.CeilToInt((float)num * 0.5f);
		for (int j = 0; j < num7; j++)
		{
			for (int k = 0; k < num; k++)
			{
				ref Vector3 reference = ref array5[num4];
				reference = new Vector3(array[k] * array4[j], array3[j], array2[k] * array4[j]) * radius;
				array5[num4].y = num5 + array5[num4].y;
				float x = 1f - num6 * (float)k;
				float y = (array5[num4].y + height * 0.5f) / height;
				ref Vector2 reference2 = ref array6[num4];
				reference2 = new Vector2(x, y);
				num4++;
			}
		}
		int num8 = Mathf.FloorToInt((float)num * 0.5f);
		for (int l = num8; l < num; l++)
		{
			for (int m = 0; m < num; m++)
			{
				ref Vector3 reference3 = ref array5[num4];
				reference3 = new Vector3(array[m] * array4[l], array3[l], array2[m] * array4[l]) * radius;
				array5[num4].y = 0f - num5 + array5[num4].y;
				float x = 1f - num6 * (float)m;
				float y = (array5[num4].y + height * 0.5f) / height;
				ref Vector2 reference4 = ref array6[num4];
				reference4 = new Vector2(x, y);
				num4++;
			}
		}
		int[] array7 = new int[segments * (segments + 1) * 4];
		int n = 0;
		int num9 = 0;
		for (; n < segments + 1; n++)
		{
			int num10 = 0;
			while (num10 < segments)
			{
				array7[num9] = n * (segments + 1) + num10;
				array7[num9 + 1] = (n + 1) * (segments + 1) + num10;
				array7[num9 + 2] = (n + 1) * (segments + 1) + num10 + 1;
				array7[num9 + 3] = n * (segments + 1) + num10 + 1;
				num10++;
				num9 += 4;
			}
		}
		List<Polygon> list = new List<Polygon>();
		int num11 = 0;
		for (int num12 = 0; num12 < array7.Length; num12 += 4)
		{
			Polygon polygon;
			if (num11 < segments)
			{
				list.Add(polygon = new Polygon(new Vertex[3]
				{
					new Vertex(array5[array7[num12]], Vector3.zero, array6[array7[num12]]),
					new Vertex(array5[array7[num12 + 1]], Vector3.zero, array6[array7[num12 + 1]]),
					new Vertex(array5[array7[num12 + 2]], Vector3.zero, array6[array7[num12 + 2]])
				}, null, isTemporary: false, userExcludeFromFinal: false));
			}
			else if (num12 >= array7.Length - segments * 4)
			{
				list.Add(polygon = new Polygon(new Vertex[3]
				{
					new Vertex(array5[array7[num12]], Vector3.zero, array6[array7[num12]]),
					new Vertex(array5[array7[num12 + 1]], Vector3.zero, array6[array7[num12 + 1]]),
					new Vertex(array5[array7[num12 + 3]], Vector3.zero, array6[array7[num12 + 3]])
				}, null, isTemporary: false, userExcludeFromFinal: false));
			}
			else
			{
				list.Add(polygon = new Polygon(new Vertex[4]
				{
					new Vertex(array5[array7[num12]], Vector3.zero, array6[array7[num12]]),
					new Vertex(array5[array7[num12 + 1]], Vector3.zero, array6[array7[num12 + 1]]),
					new Vertex(array5[array7[num12 + 2]], Vector3.zero, array6[array7[num12 + 2]]),
					new Vertex(array5[array7[num12 + 3]], Vector3.zero, array6[array7[num12 + 3]])
				}, null, isTemporary: false, userExcludeFromFinal: false));
			}
			polygon.ResetVertexNormals();
			num11++;
		}
		return list.ToArray();
	}

	public static List<Polygon> GeneratePolygonsFromMesh(Mesh sourceMesh)
	{
		List<Polygon> list = new List<Polygon>();
		for (int i = 0; i < sourceMesh.subMeshCount; i++)
		{
			MeshTopology topology = sourceMesh.GetTopology(i);
			int num = 1;
			switch (topology)
			{
			case MeshTopology.Quads:
				num = 4;
				break;
			case MeshTopology.Triangles:
				num = 3;
				break;
			default:
				Debug.LogError(string.Concat("Unhandled sub mesh topology ", topology, ". Ignoring sub mesh."));
				continue;
			}
			int[] indices = sourceMesh.GetIndices(i);
			for (int j = 0; j < indices.Length / num; j++)
			{
				Vertex[] array = new Vertex[num];
				for (int k = 0; k < num; k++)
				{
					int num2 = indices[j * num + k];
					array[k] = new Vertex(sourceMesh.vertices[num2], sourceMesh.normals[num2], sourceMesh.uv[num2]);
				}
				Polygon item = new Polygon(array, null, isTemporary: false, userExcludeFromFinal: false);
				list.Add(item);
			}
		}
		return list;
	}

	public static void GenerateMeshFromPolygons(Polygon[] polygons, ref Mesh mesh, out List<int> polygonIndices)
	{
		if (mesh == null)
		{
			mesh = new Mesh();
		}
		mesh.Clear();
		List<Vector3> list = new List<Vector3>();
		List<Vector3> list2 = new List<Vector3>();
		List<Vector2> list3 = new List<Vector2>();
		List<Color32> list4 = new List<Color32>();
		List<int> list5 = new List<int>();
		polygonIndices = new List<int>();
		VertexList vertexList = new VertexList();
		for (int i = 0; i < polygons.Length; i++)
		{
			Polygon polygon = polygons[i];
			List<int> list6 = new List<int>();
			for (int j = 0; j < polygon.Vertices.Length; j++)
			{
				int item = vertexList.AddOrGet(polygon.Vertices[j]);
				list6.Add(item);
			}
			for (int k = 2; k < list6.Count; k++)
			{
				list5.Add(list6[0]);
				list5.Add(list6[k - 1]);
				list5.Add(list6[k]);
				polygonIndices.Add(i);
			}
		}
		for (int l = 0; l < vertexList.Vertices.Count; l++)
		{
			list.Add(vertexList.Vertices[l].Position);
			list2.Add(vertexList.Vertices[l].Normal);
			list3.Add(vertexList.Vertices[l].UV);
		}
		mesh.vertices = list.ToArray();
		mesh.normals = list2.ToArray();
		mesh.colors32 = list4.ToArray();
		mesh.uv = list3.ToArray();
		mesh.triangles = list5.ToArray();
	}

	public static void GenerateMeshFromPolygonsFast(Polygon[] polygons, ref Mesh mesh, float displacement)
	{
		if (mesh == null)
		{
			mesh = new Mesh();
		}
		mesh.Clear();
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < polygons.Length; i++)
		{
			num2 += polygons[i].Vertices.Length * 3;
		}
		Vector3[] array = new Vector3[num2];
		Vector3[] array2 = new Vector3[num2];
		Vector2[] array3 = new Vector2[num2];
		int[] array4 = new int[num2];
		int num3 = 0;
		int num4 = 0;
		foreach (Polygon polygon in polygons)
		{
			num4 += polygon.Vertices.Length;
			for (int k = 0; k < polygon.Vertices.Length; k++)
			{
				Vertex vertex = polygon.Vertices[k];
				ref Vector3 reference = ref array[num];
				reference = vertex.Position + vertex.Normal * displacement;
				ref Vector3 reference2 = ref array2[num];
				reference2 = vertex.Normal;
				ref Vector2 reference3 = ref array3[num];
				reference3 = vertex.UV;
				num++;
			}
			for (int l = 2; l < polygon.Vertices.Length; l++)
			{
				int num5 = (array4[num3] = num4 - polygon.Vertices.Length);
				num3++;
				array4[num3] = num5 + l - 1;
				num3++;
				array4[num3] = num5 + l;
				num3++;
			}
		}
		mesh.vertices = array;
		mesh.normals = array2;
		mesh.uv = array3;
		mesh.triangles = array4;
	}
}
