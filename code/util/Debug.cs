namespace Equivalent;

// debug convars
public static partial class Debug
{

	[ConVar.Replicated( "debug" )]
	public static bool Enabled { get; set; }
}

// Log.Debug
public static class LoggerExtension
{
	public static void Debug( this Logger log, object obj )
	{
		if ( !Equivalent.Debug.Enabled ) return;

		log.Info( $"[{(Host.IsClient ? "CL" : "SV")}] {obj}" );
	}
}

// debug overlay methods
public static partial class Debug
{
	public static void TraceResult( TraceResult traceResult, float duration = 0 )
	{
		if ( !Enabled ) return;
		DebugOverlay.TraceResult( traceResult, duration );
	}

	public static void Sphere( Vector3 position, float radius, Color color = default, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Sphere( position, radius, color, depthTest, duration );
	}

	public static void Line( Vector3 start, Vector3 end, Color color = default, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Line( start, end, color, duration, depthTest );
	}

	public static void Axis( Vector3 position, Rotation rotation, float length = 10, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Axis( position, rotation, length, duration, depthTest );
	}

	public static void Skeleton( Entity ent, Color color, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Skeleton( ent, color, duration, depthTest );
	}

	public static void Circle( Vector3 position, Rotation rotation, float radius, Color color = default, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Circle( position, rotation, radius, color, depthTest, duration );
	}

	public static void WorldText( Vector3 position, string text, Color color = default, float duration = 0, float maxDistance = 500, int offset = 0 )
	{
		if ( !Enabled ) return;
		DebugOverlay.Text( position, offset, text, color, duration, maxDistance );
	}

	public static void ScreenText( string text, float duration = 0 )
	{
		if ( !Enabled ) return;
		DebugOverlay.ScreenText( text, duration );
	}

	public static void ScreenText( string text, int line = 0, float duration = 0 )
	{
		if ( !Enabled ) return;
		DebugOverlay.ScreenText( line, text, duration );
	}

	public static void ScreenText( Vector2 position, string text, Color color = default, float duration = 0 )
	{
		if ( !Enabled ) return;
		DebugOverlay.ScreenText( position, 0, color, text, duration );
	}

	public static void ScreenText( Vector2 position, string text, int line, Color color = default, float duration = 0 )
	{
		if ( !Enabled ) return;
		DebugOverlay.ScreenText( position, line, color, text, duration );
	}

	public static void Box( Vector3 mins, Vector3 maxs )
	{
		if ( !Enabled ) return;
		DebugOverlay.Box( mins, maxs );
	}

	public static void Box( Entity ent, Color color = default, float duration = 0 )
	{
		if ( !Enabled ) return;
		DebugOverlay.Box( ent, color, duration );
	}

	public static void Box( Vector3 position, Vector3 mins, Vector3 maxs, Color color = default, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Box( position, mins, maxs, color, depthTest );
	}

	public static void Box( Vector3 mins, Vector3 maxs, Color color = default, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Box( mins, maxs, color, duration, depthTest );
	}

	public static void Box( Vector3 position, Vector3 mins, Vector3 maxs, Color color = default, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Box( position, mins, maxs, color, duration, depthTest );
	}

	public static void Box( Vector3 position, Rotation rotation, Vector3 mins, Vector3 maxs, Color color = default, float duration = 0, bool depthTest = true )
	{
		if ( !Enabled ) return;
		DebugOverlay.Box( position, rotation, mins, maxs, color, duration, depthTest );
	}
}
