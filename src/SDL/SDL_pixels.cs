using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

// SDL_pixels.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pixels.h.
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

/// <summary>
/// Bitmap pixel order, high bit -> low bit.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BitmapOrder">documentation</see> for more details.
/// </remarks>
public enum SDL_BitmapOrder
{
	None,
	_4321,
	_1234
}

/// <summary>
/// Packed component order, high bit -> low bit.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PackedOrder">documentation</see> for more details.
/// </remarks>
public enum SDL_PackedOrder
{
	None,
	XRGB,
	RGBX,
	ARGB,
	RGBA,
	XBGR,
	BGRX,
	ABGR,
	BGRA
}

/// <summary>
/// Array component order, low byte -> high byte.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ArrayOrder">documentation</see> for more details.
/// </remarks>
public enum SDL_ArrayOrder
{
	None,
	RGB,
	RGBA,
	ARGB,
	BGR,
	BGRA,
	ABGR
}

/// <summary>
/// Packed component layout.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PackedLayout">documentation</see> for more details.
/// </remarks>
public enum SDL_PackedLayout
{
	None,
	_332,
	_4444,
	_1555,
	_5551,
	_565,
	_8888,
	_2101010,
	_1010102
}

/// <summary>
/// All pixel formats known to SDL.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
/// </remarks>
public enum SDL_PixelFormat
{
	Unknown,
	Index1Lsb = 0x11100100,
	Index1Msb = 0x11200100,
	Index2Lsb = 0x1c100200,
	Index2Msb = 0x1c200200,
	Index4Lsb = 0x12100400,
	Index4Msb = 0x12200400,
	Index8 = 0x13000801,
	RGB332 = 0x14110801,
	XRGB4444 = 0x15120c02,
	XBGR4444 = 0x15520c02,
	XRGB1555 = 0x15130f02,
	XBGR1555 = 0x15530f02,
	ARGB4444 = 0x15321002,
	RGBA4444 = 0x15421002,
	ABGR4444 = 0x15721002,
	BGRA4444 = 0x15821002,
	ARGB1555 = 0x15331002,
	RGBA5551 = 0x15441002,
	ABGR1555 = 0x15731002,
	BGRA5551 = 0x15841002,
	RGB565 = 0x15151002,
	BGR565 = 0x15551002,
	RGB24 = 0x17101803,
	BGR24 = 0x17401803,
	XRGB8888 = 0x16161804,
	RGBX8888 = 0x16261804,
	XBGR8888 = 0x16561804,
	BGRX8888 = 0x16661804,
	ARGB8888 = 0x16362004,
	RGBA8888 = 0x16462004,
	ABGR8888 = 0x16762004,
	BGRA8888 = 0x16862004,
	XRGB2101010 = 0x16172004,
	XBGR2101010 = 0x16572004,
	ARGB2101010 = 0x16372004,
	ABGR2101010 = 0x16772004,
	RGB48 = 0x18103006,
	BGR48 = 0x18403006,
	RGBA64 = 0x18204008,
	ARGB64 = 0x18304008,
	BGRA64 = 0x18504008,
	ABGR64 = 0x18604008,
	RGB48Float = 0x1a103006,
	BGR48Float = 0x1a403006,
	RGBA64Float = 0x1a204008,
	ARGB64Float = 0x1a304008,
	BGRA64Float = 0x1a504008,
	ABGR64Float = 0x1a604008,
	RGB96Float = 0x1b10600c,
	BGR96Float = 0x1b40600c,
	RGBA128Float = 0x1b208010,
	ARGB128Float = 0x1b308010,
	BGRA128Float = 0x1b508010,
	ABGR128Float = 0x1b608010,
	YV12 = 0x32315659,
	IYUV = 0x56555949,
	YUY2 = 0x32595559,
	UYVY = 0x59565955,
	YVYU = 0x55595659,
	NV12 = 0x3231564e,
	NV21 = 0x3132564e,
	P010 = 0x30313050,
	ExternalOes = 0x2053454f,
}

/// <summary>
/// Colorspace color type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ColorType">documentation</see> for more details.
/// </remarks>
public enum SDL_ColorType
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

/// <summary>
/// Colorspace color range, as described by <see href="https://www.itu.int/rec/R-REC-BT.2100-2-201807-I/en"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ColorRange">documentation</see> for more details.
/// </remarks>
public enum SDL_ColorRange
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

/// <summary>
/// Colorspace transfer characteristics.
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

/// <summary>
/// Colorspace matrix coefficients.
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

/// <summary>
/// Colorspace chroma sample location.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ChromaLocation">documentation</see> for more details.
/// </remarks>
public enum SDL_ChromaLocation
{
	/// <summary>
	/// RGB, no chroma sampling
	/// </summary>
	None = 0,

	/// <summary>
	/// In MPEG-2, MPEG-4, and AVC, Cb and Cr are taken on midpoint of the left-edge of the 2x2 square. In other words,
	/// they have the same horizontal location as the top-left pixel, but is shifted one-half pixel down vertically.
	/// </summary>
	Left = 1,

	/// <summary>
	/// In JPEG/JFIF, H.261, and MPEG-1, Cb and Cr are taken at the center of the 2x2 square. In other words, they are
	/// offset one-half pixel to the right and one-half pixel down compared to the top-left pixel.
	/// </summary>
	Center = 2,

	/// <summary>
	/// In HEVC for BT.2020 and BT.2100 content (in particular on Blu-rays), Cb and Cr are sampled at the same location
	/// as the group's top-left Y pixel ("co-sited", "co-located").
	/// </summary>
	TopLeft = 3
}

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

	/// <summary>
	/// The default colorspace for RGB surfaces if no colorspace is specified.
	/// </summary>
	RGBDefault = SRGB,

	/// <summary>
	/// The default colorspace for YUV surfaces if no colorspace is specified.
	/// </summary>
	YUVDefault = Jpeg
}

/// <summary>
/// A structure that represents a color as RGBA components.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Color">documentation</see> for more details.
/// </remarks>
/// <param name="r">The red component.</param>
/// <param name="g">The green component.</param>
/// <param name="b">The blue component.</param>
/// <param name="a">The alpha component.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Color(byte r, byte g, byte b, byte a)
{
	/// <summary>
	/// The red component.
	/// </summary>
	public byte R = r;

	/// <summary>
	/// The green component.
	/// </summary>
	public byte G = g;

	/// <summary>
	/// The blue component.
	/// </summary>
	public byte B = b;

	/// <summary>
	/// The alpha component.
	/// </summary>
	public byte A = a;
}

/// <summary>
/// A structure that represents a color as RGBA floating-point components.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FColor">documentation</see> for more details.
/// </remarks>
/// <param name="r">The red component.</param>
/// <param name="g">The green component.</param>
/// <param name="b">The blue component.</param>
/// <param name="a">The alpha component.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FColor(float r, float g, float b, float a)
{
	/// <summary>
	/// The red component, as a floating-point number.
	/// </summary>
	public float R = r;

	/// <summary>
	/// The green component, as a floating-point number.
	/// </summary>
	public float G = g;

	/// <summary>
	/// The blue component, as a floating-point number.
	/// </summary>
	public float B = b;

	/// <summary>
	/// The alpha component, as a floating-point number.
	/// </summary>
	public float A = a;
}

/// <summary>
/// A set of indexed colors representing a palette.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Palette">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Palette
{
	/// <summary>
	/// Number of elements in <see cref="Colors"/>.
	/// </summary>
	public int NumColors;

	/// <summary>
	/// An array of <see cref="SDL_Color"/> structures representing this palette, <see cref="NumColors"/> long.
	/// </summary>
	public SDL_Color* Colors;

	private readonly uint _version;

	private readonly int _refCount;
}

/// <summary>
/// Details about the format of a pixel.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormatDetails">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PixelFormatDetails
{
	public SDL_PixelFormat Format;

	public byte BitsPerPixel;

	public byte BytesPerPixel;

	private readonly byte _padding1;

	private readonly byte _padding2;

	public uint RMask;

	public uint GMask;

	public uint BMask;

	public uint AMask;

	public byte RBits;

	public byte GBits;

	public byte BBits;

	public uint ABits;

	public byte RShift;

	public byte GShift;

	public byte BShift;

	public byte AShift;
}

unsafe partial class SDL
{
	/// <summary>
	/// A fully opaque 8-bit alpha value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ALPHA_OPAQUE">documentation</see> for more details.
	/// </remarks>
	public const byte AlphaOpaque = 255;

	/// <summary>
	/// A fully opaque floating point alpha value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ALPHA_OPAQUE_FLOAT">documentation</see> for more details.
	/// </remarks>
	public const float AlphaOpaqueFloat = 1.0f;

	/// <summary>
	/// A fully transparent 8-bit alpha value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ALPHA_TRANSPARENT">documentation</see> for more details.
	/// </remarks>
	public const byte AlphaTransparent = 0;

	/// <summary>
	/// A fully transparent floating point alpha value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ALPHA_TRANSPARENT_FLOAT">documentation</see> for more details.
	/// </remarks>
	public const float AlphaTransparentFloat = 0.0f;

	/// <summary>
	/// A macro for defining custom FourCC pixel formats.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DEFINE_PIXELFOURCC">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">The first character of the FourCC code.</param>
	/// <param name="b">The second character of the FourCC code.</param>
	/// <param name="c">The third character of the FourCC code.</param>
	/// <param name="d">The fourth character of the FourCC code.</param>
	/// <returns>A format value in the style of <see cref="SDL_PixelFormat"/>.</returns>
	[Macro]
	public static SDL_PixelFormat DefinePixelFourCC(byte a, byte b, byte c, byte d) => (SDL_PixelFormat)FourCC(a, b, c, d);

	/// <summary>
	/// A macro for defining custom non-FourCC pixel formats.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DEFINE_PIXELFORMAT">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of the new format, probably a <see cref="SDL_PixelType"/> value.</param>
	/// <param name="order">The order of the new format, probably a <see cref="SDL_BitmapOrder"/>, <see cref="SDL_PackedOrder"/>, or <see cref="SDL_ArrayOrder"/> value.</param>
	/// <param name="layout">The layout of the new format, probably an <see cref="SDL_PackedLayout"/> value or zero.</param>
	/// <param name="bits">The number of bits per pixel of the new format.</param>
	/// <param name="bytes">The number of bytes per pixel of the new format.</param>
	/// <returns>A format value in the style of <see cref="SDL_PixelFormat"/>.</returns>
	[Macro]
	public static SDL_PixelFormat DefinePixelFormat(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes) => (SDL_PixelFormat)((1 << 28) | ((byte)type << 24) | (order << 20) | ((byte)layout << 16) | (bits << 8) | bytes);

	/// <summary>
	/// A macro to retrieve the flags of an <see cref="SDL_PixelFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PIXELFLAG">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>The flags of <paramref name="format"/>.</returns>
	[Macro]
	public static uint PixelFlag(SDL_PixelFormat format) => ((uint)format >> 28) & 0x0F;

	/// <summary>
	/// A macro to retrieve the type of an <see cref="SDL_PixelFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PIXELTYPE">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>The type of <paramref name="format"/>.</returns>
	[Macro]
	public static SDL_PixelType PixelType(SDL_PixelFormat format) => (SDL_PixelType)(((uint)format >> 24) & 0x0F);

	/// <summary>
	/// A macro to retrieve the order of an <see cref="SDL_PixelFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PIXELORDER">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>The order of <paramref name="format"/>.</returns>
	[Macro]
	public static uint PixelOrder(SDL_PixelFormat format) => ((uint)format >> 20) & 0x0F;

	/// <summary>
	/// A macro to retrieve the layout of an <see cref="SDL_PixelFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PIXELLAYOUT">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>The layout of <paramref name="format"/>.</returns>
	[Macro]
	public static SDL_PackedLayout PixelLayout(SDL_PixelFormat format) => (SDL_PackedLayout)(((uint)format >> 16) & 0x0F);

	/// <summary>
	/// A macro to determine an <see cref="SDL_PixelFormat"/>'s bits per pixel.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BITSPERPIXEL">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>The bits-per-pixel of <paramref name="format"/>.</returns>
	[Macro]
	public static uint BitsPerPixel(SDL_PixelFormat format) => IsPixelFormatFourCC(format) ? 0 : (((uint)format >> 8) & 0xFF);

	/// <summary>
	/// A macro to determine an <see cref="SDL_PixelFormat"/>'s bytes per pixel.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BYTESPERPIXEL">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>The bytes-per-pixel of <paramref name="format"/>.</returns>
	[Macro]
	public static uint BytesPerPixel(SDL_PixelFormat format) => IsPixelFormatFourCC(format) ? (((format == SDL_PixelFormat.YUY2) || (format == SDL_PixelFormat.UYVY) || (format == SDL_PixelFormat.YVYU) || (format == SDL_PixelFormat.P010)) ? 2u : 1u) : (((uint)format >> 0) & 0xFF);

	/// <summary>
	/// A macro to determine if an <see cref="SDL_PixelFormat"/> is an indexed format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISPIXELFORMAT_INDEXED">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>True if the format is indexed, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatIndexed(SDL_PixelFormat format) => (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.Index1) || (PixelType(format) == SDL_PixelType.Index2) || (PixelType(format) == SDL_PixelType.Index4) || (PixelType(format) == SDL_PixelType.Index8));

	/// <summary>
	/// A macro to determine if an <see cref="SDL_PixelFormat"/> is a packed format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISPIXELFORMAT_PACKED">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>True if the format is packed, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatPacked(SDL_PixelFormat format) => (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.Packed8) || (PixelType(format) == SDL_PixelType.Packed16) || (PixelType(format) == SDL_PixelType.Packed32));

	/// <summary>
	/// A macro to determine if an <see cref="SDL_PixelFormat"/> is an array format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISPIXELFORMAT_ARRAY">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>True if the format is an array, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatArray(SDL_PixelFormat format) => (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.ArrayU8) || (PixelType(format) == SDL_PixelType.ArrayU16) || (PixelType(format) == SDL_PixelType.ArrayU32) || (PixelType(format) == SDL_PixelType.ArrayF16) || (PixelType(format) == SDL_PixelType.ArrayF32));
	
	/// <summary>
	/// A macro to determine if an <see cref="SDL_PixelFormat"/> is a 10-bit format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISPIXELFORMAT_10BIT">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>True if the format is 10-bit, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormat10Bit(SDL_PixelFormat format) => (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.Packed32) || (PixelLayout(format) == SDL_PackedLayout._2101010));

	/// <summary>
	/// A macro to determine if an SDL_PixelFormat is a floating point format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISPIXELFORMAT_FLOAT">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>True if the format is 10-bit, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatFloat(SDL_PixelFormat format) => (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.ArrayF16) || (PixelType(format) == SDL_PixelType.ArrayF32));

	/// <summary>
	/// A macro to determine if an SDL_PixelFormat has an alpha channel.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISPIXELFORMAT_ALPHA">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>True if the format has alpha, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatAlpha(SDL_PixelFormat format) => IsPixelFormatPacked(format) && ((PixelOrder(format) == (uint)SDL_PackedOrder.ARGB) || (PixelOrder(format) == (uint)SDL_PackedOrder.RGBA) || (PixelOrder(format) == (uint)SDL_PackedOrder.ABGR) || (PixelOrder(format) == (uint)SDL_PackedOrder.BGRA));

	/// <summary>
	/// A macro to determine if an <see cref="SDL_PixelFormat"/> is a "FourCC" format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISPIXELFORMAT_FOURCC">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> to check.</param>
	/// <returns>True if the format has alpha, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatFourCC(SDL_PixelFormat format) => (format != SDL_PixelFormat.Unknown) && (PixelFlag(format) != 1);

	/// <summary>
	/// RGBA format, where each channel takes up 8 bits.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatRGBA32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.ABGR8888 : SDL_PixelFormat.RGBA8888;

	/// <summary>
	/// ARGB format, where each channel takes up 8 bits.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatARGB32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.BGRA8888 : SDL_PixelFormat.ARGB8888;

	/// <summary>
	/// BGRA format, where each channel takes up 8 bits.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatBGRA32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.ARGB8888 : SDL_PixelFormat.BGRA8888;

	/// <summary>
	/// ABGR format, where each channel takes up 8 bits.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatABGR32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.RGBA8888 : SDL_PixelFormat.ABGR8888;

	/// <summary>
	/// RGBA format, where each channel takes up 8 bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatRGBX32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.XBGR8888 : SDL_PixelFormat.RGBX8888;

	/// <summary>
	/// ARGB format, where each channel takes up 8 bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatXRGB32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.BGRX8888 : SDL_PixelFormat.XRGB8888;

	/// <summary>
	/// BGRA format, where each channel takes up 8 bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatBGRX32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.XRGB8888 : SDL_PixelFormat.BGRX8888;

	/// <summary>
	/// ABGR format, where each channel takes up 8 bits. Alpha channel is ignored.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_PixelFormat PixelFormatXBGR32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.RGBX8888 : SDL_PixelFormat.XBGR8888;

	/// <summary>
	/// A macro for defining custom <see cref="SDL_Colorspace"/> formats.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DEFINE_COLORSPACE">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of the new format, probably an <see cref="SDL_ColorType"/> value.</param>
	/// <param name="range">The range of the new format, probably a <see cref="SDL_ColorRange"/> value.</param>
	/// <param name="primaries">The primaries of the new format, probably an <see cref="SDL_ColorPrimaries"/> value.</param>
	/// <param name="transfer">The transfer characteristics of the new format, probably an <see cref="SDL_TransferCharacteristics"/> value.</param>
	/// <param name="matrix">The matrix coefficients of the new format, probably an <see cref="SDL_MatrixCoefficients"/> value.</param>
	/// <param name="chroma">The chroma sample location of the new format, probably an <see cref="SDL_ChromaLocation"/> value.</param>
	/// <returns>A format value in the style of <see cref="SDL_Colorspace"/>.</returns>
	[Macro]
	public static SDL_Colorspace DefineColorspace(SDL_ColorType type, SDL_ColorRange range, SDL_ColorPrimaries primaries, SDL_TransferCharacteristics transfer, SDL_MatrixCoefficients matrix, SDL_ChromaLocation chroma) => (SDL_Colorspace)(((byte)type << 28) | ((byte)range << 24) | ((byte)chroma << 20) | ((byte)primaries << 10) | ((byte)transfer << 5) | (byte)matrix);

	/// <summary>
	/// A macro to retrieve the type of an <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_COLORSPACETYPE">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>The <see cref="SDL_ColorType"/> for <paramref name="cspace"/>.</returns>
	[Macro]
	public static SDL_ColorType ColorspaceType(SDL_Colorspace cspace) => (SDL_ColorType)(((uint)cspace >> 28) & 0x0F);

	/// <summary>
	/// A macro to retrieve the range of an <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_COLORSPACERANGE">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>The <see cref="SDL_ColorRange"/> of <paramref name="cspace"/>.</returns>
	[Macro]
	public static SDL_ColorRange ColorspaceRange(SDL_Colorspace cspace) => (SDL_ColorRange)(((uint)cspace >> 24) & 0x0F);

	/// <summary>
	/// A macro to retrieve the chroma sample location of an <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_COLORSPACECHROMA">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>The <see cref="SDL_ChromaLocation"/> of <paramref name="cspace"/>.</returns>
	[Macro]
	public static SDL_ChromaLocation ColorspaceChroma(SDL_Colorspace cspace) => (SDL_ChromaLocation)(((uint)cspace >> 20) & 0x0F);

	/// <summary>
	/// A macro to retrieve the primaries of an <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_COLORSPACEPRIMARIES">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>The <see cref="SDL_ColorPrimaries"/> of <paramref name="cspace"/>.</returns>
	[Macro]
	public static SDL_ColorPrimaries ColorspacePrimaries(SDL_Colorspace cspace) => (SDL_ColorPrimaries)(((uint)cspace >> 10) & 0x1F);

	/// <summary>
	/// A macro to retrieve the transfer characteristics of an SDL_Colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_COLORSPACETRANSFER">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>The <see cref="SDL_TransferCharacteristics"/> of <paramref name="cspace"/>.</returns>
	[Macro]
	public static SDL_TransferCharacteristics ColorspaceTransfer(SDL_Colorspace cspace) => (SDL_TransferCharacteristics)(((uint)cspace >> 5) & 0x1F);

	/// <summary>
	/// A macro to retrieve the matrix coefficients of an SDL_Colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_COLORSPACEMATRIX">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>The <see cref="SDL_MatrixCoefficients"/> of <paramref name="cspace"/>.</returns>
	[Macro]
	public static SDL_MatrixCoefficients ColorspaceMatrix(SDL_Colorspace cspace) => (SDL_MatrixCoefficients)((uint)cspace & 0x1F);

	/// <summary>
	/// A macro to determine if an <see cref="SDL_Colorspace"/> uses BT601 (or BT470BG) matrix coefficients.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISCOLORSPACE_MATRIX_BT601">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>True if BT601 or BT470BG, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceMatrixBT601(SDL_Colorspace cspace) => (ColorspaceMatrix(cspace) == SDL_MatrixCoefficients.BT601) || (ColorspaceMatrix(cspace) == SDL_MatrixCoefficients.BT470BG);

	/// <summary>
	/// A macro to determine if an <see cref="SDL_Colorspace"/> uses BT709 matrix coefficients.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISCOLORSPACE_MATRIX_BT709">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>True if BT709, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceMatrixBT709(SDL_Colorspace cspace) => ColorspaceMatrix(cspace) == SDL_MatrixCoefficients.BT709;

	/// <summary>
	/// A macro to determine if an <see cref="SDL_Colorspace"/> uses BT2020_NCL matrix coefficients.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISCOLORSPACE_MATRIX_BT2020_NCL">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>True if BT2020_NCL, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceMatrixBT2020Ncl(SDL_Colorspace cspace) => ColorspaceMatrix(cspace) == SDL_MatrixCoefficients.BT2020NCL;

	/// <summary>
	/// A macro to determine if an <see cref="SDL_Colorspace"/> has a limited range.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISCOLORSPACE_LIMITED_RANGE">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>True if limited range, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceLimitedRange(SDL_Colorspace cspace) => ColorspaceRange(cspace) != SDL_ColorRange.Full;

	/// <summary>
	/// A macro to determine if an <see cref="SDL_Colorspace"/> has a full range.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ISCOLORSPACE_FULL_RANGE">documentation</see> for more details.
	/// </remarks>
	/// <param name="cspace">An <see cref="SDL_Colorspace"/> to check.</param>
	/// <returns>True if full range, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceFullRange(SDL_Colorspace cspace) => ColorspaceRange(cspace) == SDL_ColorRange.Full;

	/// <summary>
	/// Get the human readable name of a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatName">here</see>
	/// </remarks>
	/// <param name="format">The pixel format to query.</param>
	/// <returns>The human readable name of the specified pixel format or "SDL_PIXELFORMAT_UNKNOWN" if the format isn't recognized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string GetPixelFormatName(SDL_PixelFormat format);

	/// <summary>
	/// Convert one of the enumerated pixel formats to a bpp value and RGBA masks.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMasksForPixelFormat">here</see>
	/// </remarks>
	/// <param name="format">One of the <see cref="SDL_PixelFormat"/> values.</param>
	/// <param name="bpp">A bits per pixel value; usually 15, 16, or 32.</param>
	/// <param name="rMask">A pointer filled in with the red mask for the format.</param>
	/// <param name="gMask">A pointer filled in with the green mask for the format.</param>
	/// <param name="bMask">A pointer filled in with the blue mask for the format.</param>
	/// <param name="aMask">A pointer filled in with the alpha mask for the format.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMasksForPixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetMasksForPixelFormat(SDL_PixelFormat format, int* bpp, uint* rMask, uint* gMask, uint* bMask, uint* aMask);

	/// <summary>
	/// Convert a bpp value and RGBA masks to an enumerated pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatForMasks">documentation</see> for more details.
	/// </remarks>
	/// <param name="bpp">A bits per pixel value; usually 15, 16, or 32.</param>
	/// <param name="rMask">The red mask for the format.</param>
	/// <param name="gMask">The green mask for the format.</param>
	/// <param name="bMask">The blue mask for the format.</param>
	/// <param name="aMask">The alpha mask for the format.</param>
	/// <returns>The <see cref="SDL_PixelFormat"/> value corresponding to the format masks, or <see cref="SDL_PixelFormat.Unknown"/> if there isn't a match.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatForMasks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PixelFormat GetPixelFormatForMasks(int bpp, uint rMask, uint gMask, uint bMask, uint aMask);

	/// <summary>
	/// Create an <see cref="SDL_PixelFormatDetails"/> structure corresponding to a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatDetails">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">One of the <see cref="SDL_PixelFormat"/> values.</param>
	/// <returns>A pointer to a <see cref="SDL_PixelFormatDetails"/> structure or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreatePixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: Const]
	public static partial SDL_PixelFormatDetails* GetPixelFormatDetails(SDL_PixelFormat format);

	/// <summary>
	/// Create a palette structure with the specified number of color entries.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="numColors">Represents the number of color entries in the color palette.</param>
	/// <returns>A new <see cref="SDL_Palette"/> structure on success or <see langword="null"/> on failure (e.g. if there wasn't enough memory); call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreatePalette")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Palette* CreatePalette(int numColors);

	/// <summary>
	/// Set a range of colors in a palette.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPaletteColors">documentation</see> for more details.
	/// </remarks>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure to modify.</param>
	/// <param name="colors">An array of <see cref="SDL_Color"/> structures to copy into the palette.</param>
	/// <param name="firstColor">The index of the first palette entry to modify.</param>
	/// <param name="numColors">The number of entries to modify.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetPaletteColors")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetPaletteColors(SDL_Palette* palette, [Const] SDL_Color* colors, int firstColor, int numColors);

	/// <summary>
	/// Free a palette created with <see cref="CreatePalette(int)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure to be freed.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyPalette")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyPalette(SDL_Palette* palette);

	/// <summary>
	/// Map an RGB triple to an opaque pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGB">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">A pointer to <see cref="SDL_PixelFormatDetails"/> describing the pixel format.</param>
	/// <param name="palette">An optional palette for indexed formats, may be <see langword="null"/>.</param>
	/// <param name="r">The red component of the pixel in the range 0-255.</param>
	/// <param name="g">The green component of the pixel in the range 0-255.</param>
	/// <param name="b">The blue component of the pixel in the range 0-255.</param>
	/// <returns>A pixel value.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MapRGB")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint MapRGB(SDL_PixelFormatDetails* format, SDL_Palette* palette, byte r, byte g, byte b);

	/// <summary>
	/// Map an RGBA quadruple to a pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGBA">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">A pointer to <see cref="SDL_PixelFormatDetails"/> describing the pixel format.</param>
	/// <param name="palette">An optional palette for indexed formats, may be <see langword="null"/>.</param>
	/// <param name="r">The red component of the pixel in the range 0-255.</param>
	/// <param name="g">The green component of the pixel in the range 0-255.</param>
	/// <param name="b">The blue component of the pixel in the range 0-255.</param>
	/// <param name="a">The alpha component of the pixel in the range 0-255.</param>
	/// <returns>A pixel value.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MapRGBA")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint MapRGBA(SDL_PixelFormatDetails* format, SDL_Palette* palette, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Get RGB values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGB">documentation</see> for more details.
	/// </remarks>
	/// <param name="pixel">A pixel value.</param>
	/// <param name="format">An <see cref="SDL_PixelFormatDetails"/> structure describing the pixel format.</param>
	/// <param name="palette">An optional palette for indexed formats, may be <see langword="null"/>.</param>
	/// <param name="r">A pointer filled in with the red component.</param>
	/// <param name="g">A pointer filled in with the green component.</param>
	/// <param name="b">A pointer filled in with the blue component.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRGB")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void GetRGB(uint pixel, SDL_PixelFormatDetails* format, SDL_Palette* palette, byte* r, byte* g, byte* b);

	/// <summary>
	/// Get RGBA values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGBA">documentation</see> for more details.
	/// </remarks>
	/// <param name="pixel">A pixel value.</param>
	/// <param name="format">An <see cref="SDL_PixelFormatDetails"/> structure describing the pixel format.</param>
	/// <param name="palette">An optional palette for indexed formats, may be <see langword="null"/>.</param>
	/// <param name="r">A pointer filled in with the red component.</param>
	/// <param name="g">A pointer filled in with the green component.</param>
	/// <param name="b">A pointer filled in with the blue component.</param>
	/// <param name="a">A pointer filled in with the alpha component.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRGBA")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void GetRGBA(uint pixel, SDL_PixelFormatDetails* format, SDL_Palette* palette, byte* r, byte* g, byte* b, byte* a);
}