namespace SDL_cs;

/// <summary>
/// Scroll direction types for the Scroll event.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MouseWheelDirection">here</see> for more details.
/// </remarks>
public enum SDL_MouseWheelDirection
{
	/// <summary>
	/// The scroll direction is normal.
	/// </summary>
	Normal,

	/// <summary>
	/// The scroll direction is flipped / natural.
	/// </summary>
	Flipped
}