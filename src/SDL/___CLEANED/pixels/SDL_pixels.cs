using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_pixels.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pixels.h.
public static unsafe partial class SDL
{
	[Macro]
	public static SDL_PixelFormat DefinePixelFourCC(byte a, byte b, byte c, byte d) => (SDL_PixelFormat)FourCC(a, b, c, d);

	[Macro]
	public static SDL_PixelFormat DefinePixelFormat(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes) => (SDL_PixelFormat)((1 << 28) | ((byte)type << 24) | (order << 20) | ((byte)layout << 16) | (bits << 8) | bytes);

	[Macro]
	public static uint PixelFlag(SDL_PixelFormat x) => ((uint)x >> 28) & 0x0F;

	[Macro]
	public static SDL_PixelType PixelType(SDL_PixelFormat x) => (SDL_PixelType)(((uint)x >> 24) & 0x0F);

	[Macro]
	public static uint PixelOrder(SDL_PixelFormat x) => ((uint)x >> 20) & 0x0F;

	[Macro]
	public static SDL_PackedLayout PixelLayout(SDL_PixelFormat x) => (SDL_PackedLayout)(((uint)x >> 16) & 0x0F);

	[Macro]
	public static uint BitsPerPixel(SDL_PixelFormat x) => IsPixelFormatFourCC(x) ? 0 : (((uint)x >> 8) & 0xFF);

	[Macro]
	public static uint BytesPerPixel(SDL_PixelFormat x) => IsPixelFormatFourCC(x) ? (((x == SDL_PixelFormat.YUY2) || (x == SDL_PixelFormat.UYVY) || (x == SDL_PixelFormat.YVYU) || (x == SDL_PixelFormat.P010)) ? 2u : 1u) : (((uint)x >> 0) & 0xFF);

	[Macro]
	public static bool IsPixelFormatIndexed(SDL_PixelFormat x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Index1) || (PixelType(x) == SDL_PixelType.Index2) || (PixelType(x) == SDL_PixelType.Index4) || (PixelType(x) == SDL_PixelType.Index8));

	[Macro]
	public static bool IsPixelFormatPacked(SDL_PixelFormat x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Packed8) || (PixelType(x) == SDL_PixelType.Packed16) || (PixelType(x) == SDL_PixelType.Packed32));

	[Macro]
	public static bool IsPixelFormatArray(SDL_PixelFormat x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.ArrayU8) || (PixelType(x) == SDL_PixelType.ArrayU16) || (PixelType(x) == SDL_PixelType.ArrayU32) || (PixelType(x) == SDL_PixelType.ArrayF16) || (PixelType(x) == SDL_PixelType.ArrayF32));

	[Macro]
	public static bool IsPixelFormatAlpha(SDL_PixelFormat x) => IsPixelFormatPacked(x) && ((PixelOrder(x) == (uint)SDL_PackedOrder.ARGB) || (PixelOrder(x) == (uint)SDL_PackedOrder.RGBA) || (PixelOrder(x) == (uint)SDL_PackedOrder.ABGR) || (PixelOrder(x) == (uint)SDL_PackedOrder.BGRA));

	[Macro]
	public static bool IsPixelFormat10Bit(SDL_PixelFormat x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Packed32) || (PixelLayout(x) == SDL_PackedLayout._2101010));

	[Macro]
	public static bool IsPixelFormatFloat(SDL_PixelFormat x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.ArrayF16) || (PixelType(x) == SDL_PixelType.ArrayF32));

	[Macro]
	public static bool IsPixelFormatFourCC(SDL_PixelFormat x) => (x != SDL_PixelFormat.Unknown) && (PixelFlag(x) != 1);

	[Macro]
	public static SDL_Colorspace DefineColorspace(SDL_ColorType type, SDL_ColorRange range, SDL_ColorPrimaries primaries, SDL_TransferCharacteristics transfer, SDL_MatrixCoefficients matrix, SDL_ChromaLocation chroma) => (SDL_Colorspace)(((byte)type << 28) | ((byte)range << 24) | ((byte)chroma << 20) | ((byte)primaries << 10) | ((byte)transfer << 5) | (byte)matrix);

	[Macro]
	public static SDL_ColorType ColorspaceType(SDL_Colorspace x) => (SDL_ColorType)(((uint)x >> 28) & 0x0F);

	[Macro]
	public static SDL_ColorRange ColorspaceRange(SDL_Colorspace x) => (SDL_ColorRange)(((uint)x >> 24) & 0x0F);

	[Macro]
	public static SDL_ChromaLocation ColorspaceChroma(SDL_Colorspace x) => (SDL_ChromaLocation)(((uint)x >> 20) & 0x0F);

	[Macro]
	public static SDL_ColorPrimaries ColorspacePrimaries(SDL_Colorspace x) => (SDL_ColorPrimaries)(((uint)x >> 10) & 0x1F);

	[Macro]
	public static SDL_TransferCharacteristics ColorspaceTransfer(SDL_Colorspace x) => (SDL_TransferCharacteristics)(((uint)x >> 5) & 0x1F);

	[Macro]
	public static SDL_MatrixCoefficients ColorspaceMatrix(SDL_Colorspace x) => (SDL_MatrixCoefficients)((uint)x & 0x1F);

	[Macro]
	public static bool IsColorspaceMatrixBT601(SDL_Colorspace x) => (ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT601) || (ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT470BG);

	[Macro]
	public static bool IsColorspaceMatrixBT709(SDL_Colorspace x) => ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT709;

	[Macro]
	public static bool IsColorspaceMatrixBT2020Ncl(SDL_Colorspace x) => ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT2020NCL;

	[Macro]
	public static bool IsColorspaceLimitedRange(SDL_Colorspace x) => ColorspaceRange(x) != SDL_ColorRange.Full;

	[Macro]
	public static bool IsColorspaceFullRange(SDL_Colorspace x) => ColorspaceRange(x) == SDL_ColorRange.Full;

	/// <summary>
	/// Get the human readable name of a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatName">here</see>
	/// </remarks>
	/// <param name="format">The pixel format to query.</param>
	/// <returns>The human readable name of the specified pixel format or "SDL_PIXELFORMAT_UNKNOWN" if the format isn't recognized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatName", StringMarshallingCustomType = typeof(SDLManagedStringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
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
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMasksForPixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetMasksForPixelFormat(SDL_PixelFormat format, out int bpp, out uint rMask, out uint gMask, out uint bMask, out uint aMask);

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
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePixelFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">One of the <see cref="SDL_PixelFormat"/> values.</param>
	/// <returns>A pointer to a <see cref="SDL_PixelFormatDetails"/> structure or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreatePixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
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
	public static partial SDL_Palette* CreatePalette(int numColor);

	/// <summary>
	/// Set a range of colors in a palette.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPaletteColors">documentation</see> for more details.
	/// </remarks>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure to modify.</param>
	/// <param name="colors">An array of <see cref="SDL_Color"/> structures to copy into the palette.</param>
	/// <param name="firstColor">The index of the first palette entry to modify.</param>
	/// <param name="numColors">The number of entries to modify. Corresponds to <paramref name="colors"/>.Length.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetPaletteColors")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetPaletteColors(SDL_Palette* palette, [In] SDL_Color[] colors, int firstColor, int numColors);

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
	public static partial void GetRGB(uint pixel, SDL_PixelFormatDetails* format, SDL_Palette* palette, out byte r, out byte g, out byte b);

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
	public static partial void GetRGBA(uint pixel, SDL_PixelFormatDetails* format, SDL_Palette* palette, out byte r, out byte g, out byte b, out byte a);

	/// <summary>
	/// RGBA format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormat PixelFormatRGBA32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.ABGR8888 : SDL_PixelFormat.RGBA8888;

	/// <summary>
	/// ARGB format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormat PixelFormatARGB32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.BGRA8888 : SDL_PixelFormat.ARGB8888;

	/// <summary>
	/// BGRA format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormat PixelFormatBGRA32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.ARGB8888 : SDL_PixelFormat.BGRA8888;

	/// <summary>
	/// ABGR format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormat PixelFormatABGR32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.RGBA8888 : SDL_PixelFormat.ABGR8888;

	/// <summary>
	/// RGBA format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormat PixelFormatRGBX32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.XBGR8888 : SDL_PixelFormat.RGBX8888;

	/// <summary>
	/// ARGB format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormat PixelFormatXRGB32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.BGRX8888 : SDL_PixelFormat.XRGB8888;

	/// <summary>
	/// BGRA format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormat PixelFormatBGRX32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.XRGB8888 : SDL_PixelFormat.BGRX8888;

	/// <summary>
	/// ABGR format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormat PixelFormatXBGR32 => BitConverter.IsLittleEndian ? SDL_PixelFormat.RGBX8888 : SDL_PixelFormat.XBGR8888;

	/// <summary>
	/// The default colorspace for RGB surfaces if no colorspace is specified.
	/// </summary>
	public static SDL_Colorspace ColorspaceRGBDefault => SDL_Colorspace.SRGB;

	/// <summary>
	/// The default colorspace for YUV surfaces if no colorspace is specified.
	/// </summary>
	public static SDL_Colorspace ColorspaceYUVDefault => SDL_Colorspace.Jpeg;

	/// <summary>
	/// A fully opaque 8-bit alpha value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ALPHA_OPAQUE">documentation</see> for more details.
	/// </remarks>
	public const byte AlphaOpaque = 255;

	/// <summary>
	/// A fully transparent 8-bit alpha value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ALPHA_TRANSPARENT">documentation</see> for more details.
	/// </remarks>
	public const byte AlphaTransparent = 0;
}