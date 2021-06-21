using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Threading.Tasks;

using Equivalent.Player;
using Equivalent.UI;

namespace Equivalent {

	public partial class EquivalentGame : Game {
		public EquivalentGame() {
			if(IsServer) {
				Log.Info("[SV] Gamemode created");

				_ = new EquivalentHud();
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
