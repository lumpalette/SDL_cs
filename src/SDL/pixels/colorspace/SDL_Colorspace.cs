namespace SDL3;

/// <summary>
/// Colorspace definitions.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Colorspace">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_Colorspace
{
	/// <summary>
	/// Unknown colorspace.
	/// </summary>
	Unknown,

	/// <summary>
	/// sRGB is a gamma corrected colorspace, and the default colorspace for SDL rendering and 8-bit RGB surfaces.
	/// </summary>
	/// <remarks>
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709.
	/// </remarks>
	SRGB = 0x120005a0,

	/// <summary>
	/// This is a linear colorspace and the default colorspace for floating point surfaces. On Windows this is the
	/// scRGB colorspace, and on Apple platforms this is kCGColorSpaceExtendedLinearSRGB for EDR content.
	/// </summary>
	/// <remarks>
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709.
	/// </remarks>
	SRGBLinear = 0x12000500,

	/// <summary>
	/// HDR10 is a non-linear HDR colorspace and the default colorspace for 10-bit surfaces.
	/// </summary>
	Hdr10 = 0x12002600,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601.
	/// </summary>
	Jpeg = 0x220004c6,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	BT601Limited = 0x211018c6,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	BT601Full = 0x221018c6,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709.
	/// </summary>
	BT709Limited = 0x21100421,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709.
	/// </summary>
	BT709Full = 0x22100421,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020.
	/// </summary>
	BT2020Limited = 0x21102609,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020.
	/// </summary>
	BT2020Full = 0x22102609,
}