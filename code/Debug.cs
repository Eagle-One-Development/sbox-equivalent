using Sandbox;

namespace Equivalent {
	public partial class Debug {
		[ConVar.Replicated("debug_enable")]
		public static bool Enabled { get; set; }
		public static void Log(object obj) {
			if(!Debug.Enabled)
				return;

			Sandbox.Log.Info($"[{(Host.IsClient ? "CL" : "SV")}] {obj}");
		}
	}
}
