namespace SDL_cs;

/// <summary>
/// The color range, as described by <see href="https://www.itu.int/rec/R-REC-BT.2100-2-201807-I/en"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ColorRange">documentation</see> for more details.
/// </remarks>
public enum SDL_ColorRange : byte
{
	/// <summary>
	/// Unknown.
	/// </summary>
	Unknown = 0,

	/// <summary>
	/// Narrow range, e.g. 16-235 for 8-bit RGB and luma, and 16-240 for 8-bit chroma.
	/// </summary>
	Limited = 1,

	/// <summary>
	/// Full range, e.g. 0-255 for 8-bit RGB and luma, and 1-255 for 8-bit chroma.
	/// </summary>
	Full = 2
}