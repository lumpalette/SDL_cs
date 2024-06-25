namespace SDL_cs;

/// <summary>
/// Bitmap pixel order, high bit -> low bit.
/// </summary>
public enum SDL_BitmapOrder : byte
{
	None,
	Order4321,
	Order1234
}