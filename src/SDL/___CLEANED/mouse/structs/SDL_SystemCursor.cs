namespace SDL_cs;

/// <summary>
/// Cursor types for <see cref="SDL.CreateCursor(SDL_SystemCursor)"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SystemCursor">documentation</see> for more details.
/// </remarks>
public enum SDL_SystemCursor
{
	/// <summary>
	/// Default cursor. Usually an arrow.
	/// </summary>
	Default,

	/// <summary>
	/// Text selection. Usually an I-beam.
	/// </summary>
	Text,

	/// <summary>
	/// Wait. Usually an hourglass or watch or spinning ball.
	/// </summary>
	Wait,

	/// <summary>
	/// Crosshair.
	/// </summary>
	Crosshair,

	/// <summary>
	/// Program is busy but still interactive. Usually it's <see cref="Wait"/> with an arrow.
	/// </summary>
	Progress,

	/// <summary>
	/// Double arrow pointing northwest and southeast.
	/// </summary>
	NWSEResize,

	/// <summary>
	/// Double arrow pointing northeast and southwest.
	/// </summary>
	NESWResize,

	/// <summary>
	/// Double arrow pointing west and east.
	/// </summary>
	EWResize,

	/// <summary>
	/// Double arrow pointing north and south.
	/// </summary>
	NSResize,

	/// <summary>
	/// Four pointed arrow pointing north, south, east, and west.
	/// </summary>
	Move,

	/// <summary>
	/// Not permitted. Usually a slashed circle or crossbones.
	/// </summary>
	NotAllowed, // that's better.

	/// <summary>
	/// Pointer that indicates a link. Usually a pointing hand.
	/// </summary>
	Pointer,

	/// <summary>
	/// Window resize top-left. This may be a single arrow or a double arrow like <see cref="NWSEResize"/>.
	/// </summary>
	NWResize,

	/// <summary>
	/// Window resize top. May be <see cref="NSResize"/>.
	/// </summary>
	NResize,

	/// <summary>
	/// Window resize top-right. May be <see cref="NESWResize"/>.
	/// </summary>
	NEResize,

	/// <summary>
	/// Window resize right. May be <see cref="EWResize"/>.
	/// </summary>
	EResize,

	/// <summary>
	/// Window resize bottom-right. May be <see cref="NWSEResize"/>.
	/// </summary>
	SEResize,

	/// <summary>
	/// Window resize bottom. May be <see cref="NSResize"/>.
	/// </summary>
	SResize,

	/// <summary>
	/// Window resize bottom-left. May be <see cref="NESWResize"/>.
	/// </summary>
	SW,

	/// <summary>
	/// Window resize left. May be <see cref="EWResize"/>.
	/// </summary>
	WResize
}