namespace SDL_cs;

/// <summary>
/// The color type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ColorType">documentation</see> for more details.
/// </remarks>
public enum SDL_ColorType : byte
{
	/// <summary>
	/// Unknown color type.
	/// </summary>
	Unknown = 0,

	/// <summary>
	/// RGB colors consist of red, green, and blue channels of color that are added together to represent the colors we see
	/// on the screen.
	/// </summary>
	/// <remarks>
	/// To read more about RGB colors, refer to the following
	/// <see href="https://en.wikipedia.org/wiki/RGB_color_model">article</see>.
	/// </remarks>
	RGB = 1,

	/// <summary>
	/// YCbCr colors represent colors as a Y luma brightness component and red and blue chroma color offsets.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This color representation takes advantage of the fact that the human eye is more sensitive to brightness than the
	/// color in an image. The Cb and Cr components are often compressed and have lower resolution than the luma component.
	/// </para>
	/// <para>
	/// To read more about YCbCr colors, refer to the following
	/// <see href="https://en.wikipedia.org/wiki/YCbCr">article</see>.
	/// </para>
	/// </remarks>
	YCbCr = 2
}