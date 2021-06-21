using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Threading.Tasks;

using Equivalent.Player;
using Equivalent.UI;

namespace Equivalent {

	public partial class MinimalGame : Game {
		public MinimalGame() {
			if(IsServer) {
				Log.Info("[SV] Gamemode created");

				_ = new MinimalHudEntity();
			}

			if(IsClient) {
				Log.Info("[CL] Gamemode created");
			}
		}

		public override void ClientJoined(Client client) {
			base.ClientJoined(client);

			var player = new EquivalentPlayer();
			client.Pawn = player;

			player.InitialRespawn();
		}
	}
}
