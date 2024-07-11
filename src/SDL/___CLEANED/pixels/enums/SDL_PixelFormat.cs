namespace SDL_cs;

/// <summary>
/// All pixel formats known to SDL.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
/// </remarks>
public enum SDL_PixelFormat : uint
{
	Unknown = 0,
	Index1Lsb = 286261504,
	Index1Msb = 287310080,
	Index2Lsb = 470811136,
	Index2Msb = 471859712,
	Index4Lsb = 303039488,
	Index4Msb = 304088064,
	Index8 = 318769153,
	RGB332 = 336660481,
	XRGB4444 = 353504258,
	XBGR4444 = 357698562,
	XRGB1555 = 353570562,
	XBGR1555 = 357764866,
	ARGB4444 = 355602434,
	RGBA4444 = 356651010,
	ABGR4444 = 359796738,
	BGRA4444 = 360845314,
	ARGB1555 = 355667970,
	RGBA5551 = 356782082,
	ABGR1555 = 359862274,
	BGRA5551 = 360976386,
	RGB565 = 353701890,
	BGR565 = 357896194,
	RGB24 = 386930691,
	BGR24 = 390076419,
	XRGB8888 = 370546692,
	RGBX8888 = 371595268,
	XBGR8888 = 374740996,
	BGRX8888 = 375789572,
	ARGB8888 = 372645892,
	RGBA8888 = 373694468,
	ABGR8888 = 376840196,
	BGRA8888 = 377888772,
	XRGB2101010 = 370614276,
	XBGR2101010 = 374808580,
	ARGB2101010 = 372711428,
	ABGR2101010 = 376905732,
	RGB48 = 403714054,
	BGR48 = 406859782,
	RGBA64 = 404766728,
	ARGB64 = 405815304,
	BGRA64 = 407912456,
	ABGR64 = 408961032,
	RGB48Float = 437268486,
	BGR48Float = 440414214,
	RGBA64Float = 438321160,
	ARGB64Float = 439369736,
	BGRA64Float = 441466888,
	ABGR64Float = 442515464,
	RGB96Float = 454057996,
	BGR96Float = 457203724,
	RGBA128Float = 455114768,
	ARGB128Float = 456163344,
	BGRA128Float = 458260496,
	ABGR128Float = 459309072,

	/// <summary>
	/// RGBA format, where each channel represents 8-bits.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumRGBA32"/>.
	/// </remarks>
	RGBA32 = ABGR8888,

	/// <summary>
	/// ARGB format, where each channel represents 8-bits.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumARGB32"/>.
	/// </remarks>
	ARGB32 = BGRA8888,

	/// <summary>
	/// BGRA format, where each channel represents 8-bits.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumBGRA32"/>.
	/// </remarks>
	BGRA32 = ARGB8888,

	/// <summary>
	/// ABGR format, where each channel represents 8-bits.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumABGR32"/>.
	/// </remarks>
	ABGR32 = RGBA8888,

	/// <summary>
	/// RGBA format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumRGBX32"/>.
	/// </remarks>
	RGBX32 = XBGR8888,

	/// <summary>
	/// ARGB format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumXRGB32"/>.
	/// </remarks>
	XRGB32 = BGRX8888,

	/// <summary>
	/// BGRA format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumBGRX32"/>.
	/// </remarks>
	BGRX32 = XRGB8888,

	/// <summary>
	/// ABGR format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// This entry assumes the machine is little-endian. The format based on the system's endianness can be queried using
	/// <see cref="SDL.PixelFormatEnumXBGR32"/>.
	/// </remarks>
	XBGR32 = RGBX8888,

	YV12 = 842094169,
	IYUV = 1448433993,
	YUY2 = 844715353,
	UYVY = 1498831189,
	YVYU = 1431918169,
	NV12 = 842094158,
	NV21 = 825382478,
	P010 = 808530000,
	ExternalOes = 542328143,
}