namespace Equivalent.Util;

public static class EntityExtension
{
	/// <summary>
	/// Kill an entity by applying float.MaxValue Generic Damage.
	/// </summary>
	/// <param name="ent">Entity Extension</param>
	public static void Kill( this Entity ent )
	{
		ent.TakeDamage( DamageInfo.Generic( float.MaxValue ) );
	}

	/// <summary>
	/// Get whether or not an Entity is alive.
	/// </summary>
	/// <param name="ent">Entity Extension</param>
	/// <returns>True if LifeState==LifeState.Alive</returns>
	public static bool Alive( this Entity ent )
	{
		return ent.LifeState == LifeState.Alive;
	}
}
