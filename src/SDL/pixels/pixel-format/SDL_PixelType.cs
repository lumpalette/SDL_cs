namespace SDL3;

/// <summary>
/// Pixel type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelType">documentation</see> for more details.
/// </remarks>
public enum SDL_PixelType
{
	Unknown,
	Index1,
	Index4,
	Index8,
	Packed8,
	Packed16,
	Packed32,
	ArrayU8,
	ArrayU16,
	ArrayU32,
	ArrayF16,
	ArrayF32,
	Index2
}