using Sandbox;

namespace Equivalent.Util {
	public static class EntityExtension {
		public static void Kill(this Entity ent) {
			ent.TakeDamage(DamageInfo.Generic(float.MaxValue));
		}

		public static bool Alive(this Entity ent) {
			return ent.LifeState == LifeState.Alive;
		}
	}
}
