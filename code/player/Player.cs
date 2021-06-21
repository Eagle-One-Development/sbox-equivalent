using Sandbox;
using System;
using System.Linq;

namespace Equivalent.Player {
	partial class EquivalentPlayer : Sandbox.Player {

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
			base.Simulate(cl);

			SimulateActiveChild(cl, ActiveChild);
		}

		public override void OnKilled() {
			base.OnKilled();

			EnableDrawing = false;
		}
	}
}
