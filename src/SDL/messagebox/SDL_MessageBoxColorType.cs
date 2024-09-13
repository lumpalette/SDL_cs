namespace SDL3;

/// <summary>
/// An enumeration of indices inside the colors array of <see cref="SDL_MessageBoxColorScheme"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxColorType">documentation</see> for more details.
/// </remarks>
public enum SDL_MessageBoxColorType
{
	Background,
	Text,
	ButtonBorder,
	ButtonBackground,
	ButtonSelected,

	/// <summary>
	/// Size of the colors array of <see cref="SDL_MessageBoxColorScheme"/>.
	/// </summary>
	Count
}