namespace SDL_cs;

/// <summary>
/// Colorspace color primaries, as described by <see href="https://www.itu.int/rec/T-REC-H.273-201612-S/en"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ColorPrimaries">documentation</see> for more details.
/// </remarks>
public enum SDL_ColorPrimaries
{
	/// <summary>
	/// Unknown.
	/// </summary>
	Unknown = 0,

	/// <summary>
	/// ITU-R BT.709-6.
	/// </summary>
	BT709 = 1,

	/// <summary>
	/// Unspecified.
	/// </summary>
	Unspecified = 2,

	/// <summary>
	/// ITU-R BT.470-6 System M.
	/// </summary>
	BT470M = 4,

	/// <summary>
	/// ITU-R BT.470-6 System B, G / ITU-R BT.601-7 625.
	/// </summary>
	BT470BG = 5,

	/// <summary>
	/// ITU-R BT.601-7 525, SMPTE 170M.
	/// </summary>
	BT601 = 6,

	/// <summary>
	/// SMPTE 240M, functionally the same as <see cref="BT601"/>.
	/// </summary>
	Smpte240 = 7,

	/// <summary>
	/// Generic film (color filters using Illuminant C).
	/// </summary>
	GenericFilm = 8,

	/// <summary>
	/// ITU-R BT.2020-2 / ITU-R BT.2100-0
	/// </summary>
	BT2020 = 9,

	/// <summary>
	/// SMPTE ST 428-1.
	/// </summary>
	XYZ = 10,

	/// <summary>
	/// SMPTE RP 431-2.
	/// </summary>
	Smpte431 = 11,

	/// <summary>
	/// SMPTE EG 432-1 / DCI P3.
	/// </summary>
	Smpte432 = 12,

	/// <summary>
	/// EBU Tech. 3213-E.
	/// </summary>
	EBU3213 = 22,

	/// <summary>
	/// Custom.
	/// </summary>
	Custom = 31
}