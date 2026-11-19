using UnityEngine;
using UnityEngine.EventSystems;

public class BACLJEFBAMJ : JNEFNLEGJMM, IPointerExitHandler, IPointerDownHandler, IDragHandler, IPointerUpHandler, IPointerClickHandler, IEventSystemHandler
{
	public bool FDCGDOMLAGH;

	[PNAJLEIJOKM("Normal Button")]
	public Sprite FKKNNPJFFJC;

	[PNAJLEIJOKM("Pressed Button")]
	public Sprite DMOAOPGCMEE;

	public Color32 LHBPMIIAPBC = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 165);

	private int LNFGEAAOPBI = -1;

	private int EPBACCDBGPE = -1;

	private int GGALFDEOCKP = -1;

	internal bool CPNHAENAHHJ => BHCMDCLOFGL;

	internal bool MCFEOMAEBCK => LNFGEAAOPBI == Time.frameCount - 1;

	internal bool GDKHEJOFEAA => EPBACCDBGPE == Time.frameCount - 1;

	internal bool PCGHPBKGPLB => GGALFDEOCKP == Time.frameCount - 1;

	protected override void DBFCKHHDNAN(Vector2 FHIGFGMCPPK)
	{
		base.DBFCKHHDNAN(FHIGFGMCPPK);
		if (!BHCMDCLOFGL)
		{
			BHCMDCLOFGL = true;
			MNAANMAOECP = IJCCPIAIFDJ.PDNIPNGGDGC;
			LNFGEAAOPBI = Time.frameCount;
			IPJJCKEBOFH();
		}
	}

	protected void IPJJCKEBOFH()
	{
		OFBMBFLODCF.sprite = DMOAOPGCMEE;
		OFBMBFLODCF.color = ((!visible) ? ((Color32)Color.clear) : LHBPMIIAPBC);
	}

	protected void MDBPMOCFBAB()
	{
		OFBMBFLODCF.sprite = FKKNNPJFFJC;
		OFBMBFLODCF.color = ((!visible) ? ((Color32)Color.clear) : baseImageColor);
	}

	protected override void NGCCFMHBKIO()
	{
		base.NGCCFMHBKIO();
		EPBACCDBGPE = Time.frameCount;
		MDBPMOCFBAB();
	}

	public void OnPointerDown(PointerEventData MOCIGEGKFHL)
	{
		if (!BHCMDCLOFGL)
		{
			EMDIGKNNNNK = MOCIGEGKFHL.pointerId;
			DBFCKHHDNAN(MOCIGEGKFHL.position);
		}
	}

	public void OnDrag(PointerEventData MOCIGEGKFHL)
	{
		if (Input.touchCount >= EMDIGKNNNNK && BHCMDCLOFGL)
		{
			DBFCKHHDNAN(MOCIGEGKFHL.position);
		}
	}

	public void OnPointerExit(PointerEventData MOCIGEGKFHL)
	{
		if (!FDCGDOMLAGH)
		{
			OnPointerUp(MOCIGEGKFHL);
		}
	}

	public void OnPointerUp(PointerEventData MOCIGEGKFHL)
	{
		NGCCFMHBKIO();
	}

	public void OnPointerClick(PointerEventData MOCIGEGKFHL)
	{
		GGALFDEOCKP = Time.frameCount;
	}
}
