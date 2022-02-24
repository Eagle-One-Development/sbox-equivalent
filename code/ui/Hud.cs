namespace Equivalent.UI;

public partial class EquivalentHud : HudEntity<RootPanel> {
	public EquivalentHud() {
		if(!IsClient) return;
		RootPanel.SetTemplate("/ui/Hud.html");
	}
}
