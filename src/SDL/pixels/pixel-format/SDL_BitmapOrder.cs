namespace SDL3;

/// <summary>
/// Bitmap pixel order, high bit -> low bit.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BitmapOrder">documentation</see> for more details.
/// </remarks>
public enum SDL_BitmapOrder
{
	None,
	_4321,
	_1234
}