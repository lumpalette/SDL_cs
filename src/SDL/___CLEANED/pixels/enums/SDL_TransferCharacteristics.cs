namespace SDL_cs;

/// <summary>
/// The color transfer characteristics. These are as described by <see href="https://www.itu.int/rec/T-REC-H.273-201612-S/en"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TransferCharacteristics">documentation</see> for more details.
/// </remarks>
public enum SDL_TransferCharacteristics
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
	/// ITU-R BT.470-6 System M / ITU-R BT1700 625 PAL & SECAM.
	/// </summary>
	Gamma22 = 4,

	/// <summary>
	/// ITU-R BT.470-6 System B, G.
	/// </summary>
	Gamma28 = 5,

	/// <summary>
	/// SMPTE ST 170M / ITU-R BT.601-7 525 or 625.
	/// </summary>
	BT601 = 6,

	/// <summary>
	/// SMPTE ST 240M.
	/// </summary>
	Smpte240 = 7,

	/// <summary>
	/// Linear.
	/// </summary>
	Linear = 8,

	/// <summary>
	/// Logarithmic (100 : 1 range).
	/// </summary>
	Log100 = 9,

	/// <summary>
	/// Logarithmic (100 * Sqrt(10) : 1 range) 
	/// </summary>
	Log100Sqrt10 = 10,

	/// <summary>
	/// IEC 61966-2-4.
	/// </summary>
	IEC61966 = 11,

	/// <summary>
	/// ITU-R BT1361 Extended Colour Gamut.
	/// </summary>
	BT1361 = 12,

	/// <summary>
	/// IEC 61966-2-1 (sRGB or sYCC).
	/// </summary>
	SRGB = 13,

	/// <summary>
	/// ITU-R BT2020 for 10-bit system.
	/// </summary>
	BT2020TenBit = 14,

	/// <summary>
	/// ITU-R BT2020 for 12-bit system.
	/// </summary>
	BT2020TwelveBit = 15,

	/// <summary>
	/// SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems.
	/// </summary>
	PQ = 16,

	/// <summary>
	/// SMPTE ST 428-1
	/// </summary>
	Smpte428 = 17,

	/// <summary>
	/// RIB STD-B67, known as "hybrid log-gamma" (HLG).
	/// </summary>
	HLG = 18,

	/// <summary>
	/// Custom.
	/// </summary>
	Custom = 31
}