namespace SDL_cs;

/// <summary>
/// Packed component order, high bit -> low bit.
/// </summary>
public enum SDL_PackedOrder : byte
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