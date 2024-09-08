namespace SDL3;

/// <summary>
/// Array component order, low byte -> high byte.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ArrayOrder">documentation</see> for more details.
/// </remarks>
public enum SDL_ArrayOrder
{
	None,
	RGB,
	RGBA,
	ARGB,
	BGR,
	BGRA,
	ABGR
}