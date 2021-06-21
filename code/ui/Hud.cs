using Sandbox.UI;

namespace Equivalent.UI {
	public partial class MinimalHudEntity : Sandbox.HudEntity<RootPanel> {
		public MinimalHudEntity() {
			if(!IsClient) return;
			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<NameTags>();
			RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();
		}
	}
}
