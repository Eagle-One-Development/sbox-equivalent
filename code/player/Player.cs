namespace Equivalent.Player;

partial class EquivalentPlayer : Sandbox.Player {
	// for respawning
	[Net] public TimeSince TimeSinceDied { get; set; }
	[Net] public float RespawnTime { get; set; } = 1;

	[Net] public float MaxHealth { get; set; } = 100;

	public virtual void InitialRespawn() {
		Respawn();
	}

	public override void Respawn() {
		SetModel("models/citizen/citizen.vmdl");

		Controller = new WalkController();
		Animator = new StandardPlayerAnimator();
		CameraMode = new FirstPersonCamera();

		EnableAllCollisions = true;
		EnableDrawing = true;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = true;

		LifeState = LifeState.Alive;
		Health = MaxHealth;
		Velocity = Vector3.Zero;
		WaterLevel = 0f;

		CreateHull();

		Game.Current?.MoveToSpawnpoint(this);
		ResetInterpolation();
	}

	public override void Simulate(Client cl) {
		if(LifeState == LifeState.Dead) {
			if(TimeSinceDied > RespawnTime && IsServer) {
				Respawn();
			}
			return;
		}

		GetActiveController()?.Simulate(cl, this, GetActiveAnimator());
		SimulateActiveChild(cl, ActiveChild);
	}

	public override void OnKilled() {
		Game.Current?.OnKilled(this);

		TimeSinceDied = 0;
		LifeState = LifeState.Dead;
		StopUsing();

		EnableDrawing = false;
	}
}
