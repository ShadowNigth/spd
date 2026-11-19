using UnityEngine;
using UnityEngine.EventSystems;

public class EKLMKHKCJED : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler, IEventSystemHandler
{
	private HFEIGOBNJHD FLAOLGPBHOO;

	private Vector2 OOIJMCFMDHN;

	private Vector2 BADIHIKMKJF;

	private Vector2 MMBLPGIIGMK;

	private bool KIKBMJAGFEM;

	private int KDKMCDMMOKC;

	private Texture2D MOJFDKEHNLL;

	private void Awake()
	{
		FLAOLGPBHOO = base.transform.root.GetComponentInChildren<HFEIGOBNJHD>();
		BADIHIKMKJF = Vector2.zero;
		KIKBMJAGFEM = false;
		MOJFDKEHNLL = FLAOLGPBHOO.KDIJIEIPMOA;
	}

	public void OnPointerDown(PointerEventData PMPJLBPPCMF)
	{
		if (!(FLAOLGPBHOO == null) && FLAOLGPBHOO.OKLNBOIJJGE && !KIKBMJAGFEM)
		{
			KIKBMJAGFEM = true;
			KDKMCDMMOKC = PMPJLBPPCMF.pointerId;
			OOIJMCFMDHN = PMPJLBPPCMF.position;
			Cursor.SetCursor(MOJFDKEHNLL, FLAOLGPBHOO.EAFHGECOEAJ, CursorMode.ForceSoftware);
		}
	}

	public void OnDrag(PointerEventData PMPJLBPPCMF)
	{
		if (!(FLAOLGPBHOO == null) && FLAOLGPBHOO.OKLNBOIJJGE && PMPJLBPPCMF.pointerId == KDKMCDMMOKC)
		{
			Vector2 position = PMPJLBPPCMF.position;
			Vector2 vector = position - OOIJMCFMDHN;
			BADIHIKMKJF = vector * Time.deltaTime;
			FLAOLGPBHOO.OFAHFNJFHJP(BADIHIKMKJF);
			OOIJMCFMDHN = PMPJLBPPCMF.position;
		}
	}

	public void OnPointerUp(PointerEventData PMPJLBPPCMF)
	{
		if (!(FLAOLGPBHOO == null) && FLAOLGPBHOO.OKLNBOIJJGE && PMPJLBPPCMF.pointerId == KDKMCDMMOKC)
		{
			BADIHIKMKJF = Vector2.zero;
			KIKBMJAGFEM = false;
			Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
		}
	}
}
