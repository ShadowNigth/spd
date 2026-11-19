using UnityEngine;

namespace Sabresaurus.SabreCSG;

[ExecuteInEditMode]
public class CSGModelRuntime : MonoBehaviour
{
	private void Start()
	{
		Object.DestroyImmediate(this);
	}
}
