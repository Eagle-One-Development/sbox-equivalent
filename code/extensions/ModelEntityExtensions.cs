namespace Equivalent;

public static class ModelEntityExtensions {
	public static void SetGlow(this ModelEntity ent, bool state, Color col, int minrange = 0, int maxrange = 1000) {
		var glow = ent.Components.GetOrCreate<Glow>();
		glow.Active = state;
		glow.Color = col;
		glow.RangeMin = minrange;
		glow.RangeMax = maxrange;
	}
}
