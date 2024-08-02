namespace SDL3;

/// <summary>
/// Packed component order, high bit -> low bit.
/// </summary>
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