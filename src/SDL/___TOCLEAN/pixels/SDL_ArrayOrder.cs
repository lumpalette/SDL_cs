namespace SDL_cs;

/// <summary>
/// Array component order, low byte -> high byte.
/// </summary>
public enum SDL_ArrayOrder : byte
{
	None,
	RGB,
	RGBA,
	ARGB,
	BGR,
	BGRA,
	ABGR
}