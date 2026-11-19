using UnityEngine;

namespace SPD.Triggers
{
	public class BuyTrigger : MonoBehaviour
	{
		public enum Team
		{
			Any = 0,
			T = 1,
			CT = 2
		}

		public Team team;
	}
}
