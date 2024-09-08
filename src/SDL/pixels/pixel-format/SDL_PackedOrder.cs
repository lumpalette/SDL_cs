namespace SDL3;

/// <summary>
/// Packed component order, high bit -> low bit.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PackedOrder">documentation</see> for more details.
/// </remarks>
public enum SDL_PackedOrder
{
	None,
	XRGB,
	RGBX,
	ARGB,
	RGBA,
	XBGR,
	BGRX,
	ABGR,
	BGRA
}