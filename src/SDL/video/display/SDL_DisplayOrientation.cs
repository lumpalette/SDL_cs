namespace SDL3;

/// <summary>
/// Display orientation values; the way a display is rotated.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayOrientation">documentation</see> for more details.
/// </remarks>
public enum SDL_DisplayOrientation
{
	/// <summary>
	/// The display orientation can't be determined.
	/// </summary>
	Unknown,

	/// <summary>
	/// The display is in landscape mode, with the right side up, relative to portrait mode.
	/// </summary>
	Landscape,

	/// <summary>
	/// The display is in landscape mode, with the left side up, relative to portrait mode.
	/// </summary>
	LandscapeFlipped,

	/// <summary>
	/// The display is in portrait mode.
	/// </summary>
	Portrait,

	/// <summary>
	/// The display is in portrait mode, upside down.
	/// </summary>
	PortraitFlipped,
}