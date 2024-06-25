namespace SDL_cs;

/// <summary>
/// The flip mode.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlipMode">documentation</see> for more details.
/// </remarks>
public enum SDL_FlipMode
{
	/// <summary>
	/// Do not flip.
	/// </summary>
	None,

	/// <summary>
	/// Flip horizontally.
	/// </summary>
	Horizontal,

	/// <summary>
	/// Flip vertically.
	/// </summary>
	Vertical
}