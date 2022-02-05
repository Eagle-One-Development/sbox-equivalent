using Sandbox.UI;

namespace Equivalent.UI {
	public partial class EquivalentHud : Sandbox.HudEntity<RootPanel> {
		public EquivalentHud() {
			if(!IsClient) return;
			RootPanel.SetTemplate("/ui/Hud.html");
		}
	}
}
