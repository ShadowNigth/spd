using System.Diagnostics;

namespace Sabresaurus.SabreCSG
{
	internal static class DebugTimer
	{
		[Conditional("DEBUG_CSG")]
		public static void StartTimer()
		{
		}

		[Conditional("DEBUG_CSG")]
		public static void LogEvent(string message)
		{
		}
	}
}
