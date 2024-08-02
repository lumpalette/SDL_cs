namespace SDL3;

/// <summary>
/// Colorspace matrix coefficients. These are as described by <see href="https://www.itu.int/rec/T-REC-H.273-201612-S/en"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MatrixCoefficients">documentation</see> for more details.
/// </remarks>
public enum SDL_MatrixCoefficients
{
	/// <summary>
	/// Identity matrix.
	/// </summary>
	Identity = 0,

	/// <summary>
	/// ITU-R BT.709-6.
	/// </summary>
	BT709 = 1,

	/// <summary>
	/// Unspecified.
	/// </summary>
	Unspecified = 2,

	/// <summary>
	/// US FCC Title 47.
	/// </summary>
	FCC = 4,

	/// <summary>
	/// ITU-R BT.470-6 System B, G / ITU-R BT.601-7 625, functionally the same as <see cref="BT601"/>.
	/// </summary>
	BT470BG = 5,

	/// <summary>
	/// ITU-R BT.601-7 525.
	/// </summary>
	BT601 = 6,

	/// <summary>
	/// SMPTE 240M.
	/// </summary>
	Smpte240 = 7,

	/// <summary>
	/// YCgCo.
	/// </summary>
	YCgCo = 8,

	/// <summary>
	/// ITU-R BT.2020-2 non-constant luminance.
	/// </summary>
	BT2020NCL = 9,

	/// <summary>
	/// ITU-R BT.2020-2 constant luminance
	/// </summary>
	BT2020CL = 10,

	/// <summary>
	/// SMPTE ST 2085.
	/// </summary>
	Smpte2085 = 11,

	/// <summary>
	/// Chromaticity-derived non-constant luminance.
	/// </summary>
	CromaDerivedNCL = 12,

	/// <summary>
	/// Chromaticity-derived constant luminance.
	/// </summary>
	CromaDerivedCL = 13,

	/// <summary>
	/// BT.2100-0 ICtCp.
	/// </summary>
	ICtCp = 14
}