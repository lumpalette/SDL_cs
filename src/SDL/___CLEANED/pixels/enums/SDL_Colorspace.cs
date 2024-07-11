namespace SDL_cs;

/// <summary>
/// All the colorspaces known to SDL.
/// </summary>
[Typedef]
public enum SDL_Colorspace : uint
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
	SRGB = 301991328,

	/// <summary>
	/// This is a linear colorspace and the default colorspace for floating point surfaces. On Windows this is the
	/// scRGB colorspace, and on Apple platforms this is kCGColorSpaceExtendedLinearSRGB for EDR content.
	/// </summary>
	/// <remarks>
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709.
	/// </remarks>
	SRGBLinear = 301991168,

	/// <summary>
	/// HDR10 is a non-linear HDR colorspace and the default colorspace for 10-bit surfaces.
	/// </summary>
	Hdr10 = 301999616,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601.
	/// </summary>
	Jpeg = 570426566,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	BT601Limited = 554703046,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	BT601Full = 571480262,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709.
	/// </summary>
	BT709Limited = 554697761,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709.
	/// </summary>
	BT709Full = 571474977,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020.
	/// </summary>
	BT2020Limited = 554706441,

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020.
	/// </summary>
	BT2020Full = 571483657,

	/// <summary>
	/// The default colorspace for RGB surfaces if no colorspace is specified.
	/// </summary>
	DefaultRGB = SRGB,

	/// <summary>
	/// The default colorspace for YUV surfaces if no colorspace is specified.
	/// </summary>
	DefaultYUV = Jpeg
}