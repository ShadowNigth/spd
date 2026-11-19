using UnityEngine;

namespace SPD.Triggers;

public class BuyTrigger : MonoBehaviour
{
	public enum Team
	{
		Any,
		T,
		CT
	}

	public Team team;
}
