namespace SDL_cs;

/// <summary>
/// General keyboard/mouse/pen state definitions.
/// </summary>
public enum SDL_State
{
	/// <summary>
	/// A value that signifies a button is no longer pressed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RELEASED">documentation</see> for more details.
	/// </remarks>
	Released,

	/// <summary>
	/// A value that signifies a button has been pressed down.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PRESSED">documentation</see> for more details.
	/// </remarks>
	Pressed
}