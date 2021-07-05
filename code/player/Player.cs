using Sandbox;
using System;
using System.Linq;

namespace Equivalent.Player {
	partial class EquivalentPlayer : Sandbox.Player {

		TimeSince timeSinceDied;
		public float RespawnTime = 1;

		public virtual void InitialRespawn() {

			Respawn();
		}
		public override void Respawn() {
			SetModel("models/citizen/citizen.vmdl");

			Controller = new WalkController();
			Animator = new StandardPlayerAnimator();
			Camera = new FirstPersonCamera();

			EnableAllCollisions = true;
			EnableDrawing = true;
			EnableHideInFirstPerson = true;
			EnableShadowInFirstPerson = true;

			base.Respawn();
		}

		public override void Simulate(Client cl) {
			if(LifeState == LifeState.Dead) {
				if(timeSinceDied > RespawnTime && IsServer) {
					Respawn();
				}
				return;
			}

			var controller = GetActiveController();
			controller?.Simulate(cl, this, GetActiveAnimator());

			SimulateActiveChild(cl, ActiveChild);
		}

		public override void OnKilled() {
			Game.Current?.OnKilled(this);

			timeSinceDied = 0;
			LifeState = LifeState.Dead;
			StopUsing();

			EnableDrawing = false;
		}
	}
}
