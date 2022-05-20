// sandbox
global using Sandbox;
global using Sandbox.Component;
global using Sandbox.UI;
// system
global using System;
global using System.Collections.Generic;
global using System.Linq;
// internal
using Equivalent.Player;
using Equivalent.UI;

namespace Equivalent;

public partial class EquivalentGame : Game
{
	public EquivalentGame()
	{
		Log.Debug( "Game created" );
		if ( IsServer )
			_ = new EquivalentHud();
	}

	public override void ClientJoined( Client client )
	{
		base.ClientJoined( client );

		var player = new EquivalentPlayer();
		client.Pawn = player;

		player.InitialRespawn();
	}

	public override void DoPlayerSuicide( Client cl )
	{
		if ( cl.Pawn == null ) return;

		cl.Pawn.Kill();
	}
}
