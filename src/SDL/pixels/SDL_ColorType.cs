namespace SDL_cs;

/// <summary>
/// The color type.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ColorType">here</see> for more details.
/// </remarks>
public enum SDL_ColorType
{
	/// <summary>
	/// Unknown.
	/// </summary>
	Unknown = 0,

	/// <summary>
	/// RGB colors consist of red, green, and blue channels of color that are added together to represent the colors we see
	/// on the screen. See <see href="https://en.wikipedia.org/wiki/RGB_color_model"/> for more details.
	/// </summary>
	RGB = 1,

	/// <summary>
	/// YCbCr colors represent colors as a Y luma brightness component and red and blue chroma color offsets. This color
	/// representation takes advantage of the fact that the human eye is more sensitive to brightness than the color in an
	/// image. The Cb and Cr components are often compressed and have lower resolution than the luma component. See
	/// <see href="https://en.wikipedia.org/wiki/YCbCr"/> for more details.
	/// </summary>
	YCbCr = 2
}