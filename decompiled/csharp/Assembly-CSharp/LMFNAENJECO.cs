using UnityEngine;
using UnityEngine.UI;

public class LMFNAENJECO : MaskableGraphic
{
	[SerializeField]
	private float yoffset = -1f;

	[SerializeField]
	private float width = 1f;

	public float CDBOLIECGNB
	{
		get
		{
			return yoffset;
		}
		set
		{
			SetVerticesDirty();
			yoffset = value;
		}
	}

	public float HACOGJLHFJI
	{
		get
		{
			return width;
		}
		set
		{
			SetAllDirty();
			width = value;
		}
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		Rect pixelAdjustedRect = GetPixelAdjustedRect();
		Vector4 vector = new Vector4(pixelAdjustedRect.x, pixelAdjustedRect.y, pixelAdjustedRect.x + pixelAdjustedRect.width, pixelAdjustedRect.y + pixelAdjustedRect.height);
		float num = (vector.w - vector.y) * 2f;
		Color32 color = this.color;
		MDEPPJOMAOE.Clear();
		color.a = 0;
		MDEPPJOMAOE.AddVert(new Vector3(vector.x - 50f, width * vector.y + yoffset * num), color, new Vector2(0f, 0f));
		MDEPPJOMAOE.AddVert(new Vector3(vector.z + 50f, width * vector.y + yoffset * num), color, new Vector2(1f, 0f));
		color.a = (byte)(this.color.a * 255f);
		MDEPPJOMAOE.AddVert(new Vector3(vector.x - 50f, width * (vector.y / 4f) + yoffset * num), color, new Vector2(0f, 1f));
		MDEPPJOMAOE.AddVert(new Vector3(vector.z + 50f, width * (vector.y / 4f) + yoffset * num), color, new Vector2(1f, 1f));
		color.a = (byte)(this.color.a * 255f);
		MDEPPJOMAOE.AddVert(new Vector3(vector.x - 50f, width * (vector.w / 4f) + yoffset * num), color, new Vector2(0f, 1f));
		MDEPPJOMAOE.AddVert(new Vector3(vector.z + 50f, width * (vector.w / 4f) + yoffset * num), color, new Vector2(1f, 1f));
		color.a = (byte)(this.color.a * 255f);
		color.a = 0;
		MDEPPJOMAOE.AddVert(new Vector3(vector.x - 50f, width * vector.w + yoffset * num), color, new Vector2(0f, 1f));
		MDEPPJOMAOE.AddVert(new Vector3(vector.z + 50f, width * vector.w + yoffset * num), color, new Vector2(1f, 1f));
		MDEPPJOMAOE.AddTriangle(0, 1, 2);
		MDEPPJOMAOE.AddTriangle(2, 3, 1);
		MDEPPJOMAOE.AddTriangle(2, 3, 4);
		MDEPPJOMAOE.AddTriangle(4, 5, 3);
		MDEPPJOMAOE.AddTriangle(4, 5, 6);
		MDEPPJOMAOE.AddTriangle(6, 7, 5);
	}

	public void MBBKMLPILAN(VertexHelper MDEPPJOMAOE)
	{
		int num = MDEPPJOMAOE.currentVertCount - 2;
		Debug.Log(num);
		for (int i = 0; i <= num / 2 + 1; i += 2)
		{
			MDEPPJOMAOE.AddTriangle(i, i + 1, i + 2);
			MDEPPJOMAOE.AddTriangle(i + 2, i + 3, i + 1);
		}
	}
}
