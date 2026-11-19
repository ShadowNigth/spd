using System;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Extensions/UIParticleSystem")]
[RequireComponent(typeof(CanvasRenderer), typeof(ParticleSystem))]
[ExecuteInEditMode]
public class JHHAPIJAODH : MaskableGraphic
{
	[Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
	public bool ILJGGIOALMA = true;

	private Transform COECFNBILIA;

	private ParticleSystem GPIBHDAMGLO;

	private ParticleSystem.Particle[] IHLJPBEDOHL;

	private UIVertex[] AIAGLCHGDNN = new UIVertex[4];

	private Vector4 OOOONBCDCHG = Vector4.zero;

	private ParticleSystem.TextureSheetAnimationModule GLKHNALIADA;

	private int JNCIPGNOBLD;

	private Vector2 ANJCPBAODLJ;

	private ParticleSystemRenderer CFEHBMBHFHH;

	private Material BNCCGPNKBPL;

	private Texture DODKIGKNFAM;

	private ParticleSystem.MainModule NJKOJBJNFPJ;

	public override Texture NOIJLEAHPOI => DODKIGKNFAM;

	protected bool ANDBBOOJKEL()
	{
		if (COECFNBILIA == null)
		{
			COECFNBILIA = base.transform;
		}
		if (GPIBHDAMGLO == null)
		{
			GPIBHDAMGLO = GetComponent<ParticleSystem>();
			if (GPIBHDAMGLO == null)
			{
				return false;
			}
			NJKOJBJNFPJ = GPIBHDAMGLO.main;
			if (GPIBHDAMGLO.main.maxParticles > 14000)
			{
				NJKOJBJNFPJ.maxParticles = 14000;
			}
			CFEHBMBHFHH = GPIBHDAMGLO.GetComponent<ParticleSystemRenderer>();
			if (CFEHBMBHFHH != null)
			{
				CFEHBMBHFHH.enabled = false;
			}
			Shader shader = Shader.Find("UI Extensions/Particles/Additive");
			Material material = new Material(shader);
			if (this.material == null)
			{
				this.material = material;
			}
			BNCCGPNKBPL = this.material;
			if ((bool)BNCCGPNKBPL && BNCCGPNKBPL.HasProperty("_MainTex"))
			{
				DODKIGKNFAM = BNCCGPNKBPL.mainTexture;
				if (DODKIGKNFAM == null)
				{
					DODKIGKNFAM = Texture2D.whiteTexture;
				}
			}
			this.material = BNCCGPNKBPL;
			NJKOJBJNFPJ.scalingMode = ParticleSystemScalingMode.Hierarchy;
			IHLJPBEDOHL = null;
		}
		if (IHLJPBEDOHL == null)
		{
			IHLJPBEDOHL = new ParticleSystem.Particle[GPIBHDAMGLO.main.maxParticles];
		}
		OOOONBCDCHG = new Vector4(0f, 0f, 1f, 1f);
		GLKHNALIADA = GPIBHDAMGLO.textureSheetAnimation;
		JNCIPGNOBLD = 0;
		ANJCPBAODLJ = Vector2.zero;
		if (GLKHNALIADA.enabled)
		{
			JNCIPGNOBLD = GLKHNALIADA.numTilesX * GLKHNALIADA.numTilesY;
			ANJCPBAODLJ = new Vector2(1f / (float)GLKHNALIADA.numTilesX, 1f / (float)GLKHNALIADA.numTilesY);
		}
		return true;
	}

	protected override void Awake()
	{
		base.Awake();
		if (!ANDBBOOJKEL())
		{
			base.enabled = false;
		}
	}

	protected override void OnPopulateMesh(VertexHelper MDEPPJOMAOE)
	{
		MDEPPJOMAOE.Clear();
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		Vector2 zero = Vector2.zero;
		Vector2 zero2 = Vector2.zero;
		Vector2 zero3 = Vector2.zero;
		int particles = GPIBHDAMGLO.GetParticles(IHLJPBEDOHL);
		for (int i = 0; i < particles; i++)
		{
			ParticleSystem.Particle particle = IHLJPBEDOHL[i];
			Vector2 vector = ((NJKOJBJNFPJ.simulationSpace != 0) ? COECFNBILIA.InverseTransformPoint(particle.position) : particle.position);
			float num = (0f - particle.rotation) * ((float)Math.PI / 180f);
			float f = num + (float)Math.PI / 2f;
			Color32 currentColor = particle.GetCurrentColor(GPIBHDAMGLO);
			float num2 = particle.GetCurrentSize(GPIBHDAMGLO) * 0.5f;
			if (NJKOJBJNFPJ.scalingMode == ParticleSystemScalingMode.Shape)
			{
				vector /= base.canvas.scaleFactor;
			}
			Vector4 oOOONBCDCHG = OOOONBCDCHG;
			if (GLKHNALIADA.enabled)
			{
				float num3 = 1f - particle.remainingLifetime / particle.startLifetime;
				if (GLKHNALIADA.frameOverTime.curveMin != null)
				{
					num3 = GLKHNALIADA.frameOverTime.curveMin.Evaluate(1f - particle.remainingLifetime / particle.startLifetime);
				}
				else if (GLKHNALIADA.frameOverTime.curve != null)
				{
					num3 = GLKHNALIADA.frameOverTime.curve.Evaluate(1f - particle.remainingLifetime / particle.startLifetime);
				}
				else if (GLKHNALIADA.frameOverTime.constant > 0f)
				{
					num3 = GLKHNALIADA.frameOverTime.constant - particle.remainingLifetime / particle.startLifetime;
				}
				num3 = Mathf.Repeat(num3 * (float)GLKHNALIADA.cycleCount, 1f);
				int num4 = 0;
				switch (GLKHNALIADA.animation)
				{
				case ParticleSystemAnimationType.WholeSheet:
					num4 = Mathf.FloorToInt(num3 * (float)JNCIPGNOBLD);
					break;
				case ParticleSystemAnimationType.SingleRow:
				{
					num4 = Mathf.FloorToInt(num3 * (float)GLKHNALIADA.numTilesX);
					int rowIndex = GLKHNALIADA.rowIndex;
					num4 += rowIndex * GLKHNALIADA.numTilesX;
					break;
				}
				}
				num4 %= JNCIPGNOBLD;
				oOOONBCDCHG.x = (float)(num4 % GLKHNALIADA.numTilesX) * ANJCPBAODLJ.x;
				oOOONBCDCHG.y = (float)Mathf.FloorToInt(num4 / GLKHNALIADA.numTilesX) * ANJCPBAODLJ.y;
				oOOONBCDCHG.z = oOOONBCDCHG.x + ANJCPBAODLJ.x;
				oOOONBCDCHG.w = oOOONBCDCHG.y + ANJCPBAODLJ.y;
			}
			zero.x = oOOONBCDCHG.x;
			zero.y = oOOONBCDCHG.y;
			ref UIVertex reference = ref AIAGLCHGDNN[0];
			reference = UIVertex.simpleVert;
			AIAGLCHGDNN[0].color = currentColor;
			AIAGLCHGDNN[0].uv0 = zero;
			zero.x = oOOONBCDCHG.x;
			zero.y = oOOONBCDCHG.w;
			ref UIVertex reference2 = ref AIAGLCHGDNN[1];
			reference2 = UIVertex.simpleVert;
			AIAGLCHGDNN[1].color = currentColor;
			AIAGLCHGDNN[1].uv0 = zero;
			zero.x = oOOONBCDCHG.z;
			zero.y = oOOONBCDCHG.w;
			ref UIVertex reference3 = ref AIAGLCHGDNN[2];
			reference3 = UIVertex.simpleVert;
			AIAGLCHGDNN[2].color = currentColor;
			AIAGLCHGDNN[2].uv0 = zero;
			zero.x = oOOONBCDCHG.z;
			zero.y = oOOONBCDCHG.y;
			ref UIVertex reference4 = ref AIAGLCHGDNN[3];
			reference4 = UIVertex.simpleVert;
			AIAGLCHGDNN[3].color = currentColor;
			AIAGLCHGDNN[3].uv0 = zero;
			if (num == 0f)
			{
				zero2.x = vector.x - num2;
				zero2.y = vector.y - num2;
				zero3.x = vector.x + num2;
				zero3.y = vector.y + num2;
				zero.x = zero2.x;
				zero.y = zero2.y;
				AIAGLCHGDNN[0].position = zero;
				zero.x = zero2.x;
				zero.y = zero3.y;
				AIAGLCHGDNN[1].position = zero;
				zero.x = zero3.x;
				zero.y = zero3.y;
				AIAGLCHGDNN[2].position = zero;
				zero.x = zero3.x;
				zero.y = zero2.y;
				AIAGLCHGDNN[3].position = zero;
			}
			else
			{
				Vector2 vector2 = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
				Vector2 vector3 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
				AIAGLCHGDNN[0].position = vector - vector2 - vector3;
				AIAGLCHGDNN[1].position = vector - vector2 + vector3;
				AIAGLCHGDNN[2].position = vector + vector2 + vector3;
				AIAGLCHGDNN[3].position = vector + vector2 - vector3;
			}
			MDEPPJOMAOE.AddUIVertexQuad(AIAGLCHGDNN);
		}
	}

	private void Update()
	{
		if (!ILJGGIOALMA && Application.isPlaying)
		{
			GPIBHDAMGLO.Simulate(Time.unscaledDeltaTime, withChildren: false, restart: false, fixedTimeStep: true);
			SetAllDirty();
			if ((BNCCGPNKBPL != null && DODKIGKNFAM != BNCCGPNKBPL.mainTexture) || (material != null && BNCCGPNKBPL != null && material.shader != BNCCGPNKBPL.shader))
			{
				GPIBHDAMGLO = null;
				ANDBBOOJKEL();
			}
		}
	}

	private void LateUpdate()
	{
		if (!Application.isPlaying)
		{
			SetAllDirty();
		}
		else if (ILJGGIOALMA)
		{
			GPIBHDAMGLO.Simulate(Time.unscaledDeltaTime, withChildren: false, restart: false, fixedTimeStep: true);
			SetAllDirty();
			if ((BNCCGPNKBPL != null && DODKIGKNFAM != BNCCGPNKBPL.mainTexture) || (material != null && BNCCGPNKBPL != null && material.shader != BNCCGPNKBPL.shader))
			{
				GPIBHDAMGLO = null;
				ANDBBOOJKEL();
			}
		}
		if (!(material == BNCCGPNKBPL))
		{
			GPIBHDAMGLO = null;
			ANDBBOOJKEL();
		}
	}
}
