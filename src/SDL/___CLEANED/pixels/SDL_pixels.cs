using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_pixels.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pixels.h.
unsafe partial class SDL
{
	[Macro]
	public static SDL_PixelFormatEnum DefinePixelFourCC(byte a, byte b, byte c, byte d) => (SDL_PixelFormatEnum)FourCC(a, b, c, d);

	[Macro]
	public static SDL_PixelFormatEnum DefinePixelFormat(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes) => (SDL_PixelFormatEnum)((1 << 28) | ((byte)type << 24) | (order << 20) | ((byte)layout << 16) | (bits << 8) | bytes);

	[Macro]
	public static byte PixelFlag(SDL_PixelFormatEnum x) => (byte)(((uint)x >> 28) & 0x0F);

	[Macro]
	public static SDL_PixelType PixelType(SDL_PixelFormatEnum x) => (SDL_PixelType)(((uint)x >> 24) & 0x0F);

	[Macro]
	public static byte PixelOrder(SDL_PixelFormatEnum x) => (byte)(((uint)x >> 20) & 0x0F);

	[Macro]
	public static SDL_PackedLayout PixelLayout(SDL_PixelFormatEnum x) => (SDL_PackedLayout)(((uint)x >> 16) & 0x0F);

	[Macro]
	public static byte BitsPerPixel(SDL_PixelFormatEnum x) => (byte)(((uint)x >> 8) & 0xFF);

	[Macro]
	public static byte BytesPerPixel(SDL_PixelFormatEnum x) => (byte)(IsPixelFormatFourCC(x) ? (((x == SDL_PixelFormatEnum.YUY2) || (x == SDL_PixelFormatEnum.UYVY) || (x == SDL_PixelFormatEnum.YVYU) || (x == SDL_PixelFormatEnum.P010)) ? 2u : 1u) : (((uint)x >> 0) & 0xFF));

	[Macro]
	public static bool IsPixelFormatIndexed(SDL_PixelFormatEnum x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Index1) || (PixelType(x) == SDL_PixelType.Index2) || (PixelType(x) == SDL_PixelType.Index4) || (PixelType(x) == SDL_PixelType.Index8));

	[Macro]
	public static bool IsPixelFormatPacked(SDL_PixelFormatEnum x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Packed8) || (PixelType(x) == SDL_PixelType.Packed16) || (PixelType(x) == SDL_PixelType.Packed32));

	[Macro]
	public static bool IsPixelFormatArray(SDL_PixelFormatEnum x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.ArrayU8) || (PixelType(x) == SDL_PixelType.ArrayU16) || (PixelType(x) == SDL_PixelType.ArrayU32) || (PixelType(x) == SDL_PixelType.ArrayF16) || (PixelType(x) == SDL_PixelType.ArrayF32));

	[Macro]
	public static bool IsPixelFormatAlpha(SDL_PixelFormatEnum x) => IsPixelFormatPacked(x) && ((PixelOrder(x) == (uint)SDL_PackedOrder.ARGB) || (PixelOrder(x) == (uint)SDL_PackedOrder.RGBA) || (PixelOrder(x) == (uint)SDL_PackedOrder.ABGR) || (PixelOrder(x) == (uint)SDL_PackedOrder.BGRA));

	[Macro]
	public static bool IsPixelFormat10Bit(SDL_PixelFormatEnum x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Packed32) || (PixelLayout(x) == SDL_PackedLayout._2101010));

	[Macro]
	public static bool IsPixelFormatFloat(SDL_PixelFormatEnum x) => (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.ArrayF16) || (PixelType(x) == SDL_PixelType.ArrayF32));

	[Macro]
	public static bool IsPixelFormatFourCC(SDL_PixelFormatEnum x) => (x != SDL_PixelFormatEnum.Unknown) && (PixelFlag(x) != 1);

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
	public static bool IsColorspaceFullRange(SDL_Colorspace colorspace) => ColorspaceRange(colorspace) == SDL_ColorRange.Full;

	/// <summary>
	/// Get the human readable name of a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatName">here</see>
	/// </remarks>
	/// <param name="format">The pixel format to query.</param>
	/// <returns>The human readable name of the specified pixel format or "SDL_PIXELFORMAT_UNKNOWN" if the format isn't recognized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatName", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string GetPixelFormatName(SDL_PixelFormatEnum format);

	/// <summary>
	/// Convert one of the enumerated pixel formats to a bpp value and RGBA masks.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMasksForPixelFormatEnum">here</see>
	/// </remarks>
	/// <param name="format">One of the <see cref="SDL_PixelFormatEnum"/> values.</param>
	/// <param name="bpp">A bits per pixel value; usually 15, 16, or 32.</param>
	/// <param name="rMask">The red mask for the format.</param>
	/// <param name="gMask">The green mask for the format.</param>
	/// <param name="bMask">The blue mask for the format.</param>
	/// <param name="aMask">The alpha mask for the format.</param>
	/// <returns>True on success or false if the conversion wasn't possible; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMasksForPixelFormatEnum")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return:  MarshalAs(UnmanagedType.I4)]
	public static partial bool GetMasksForPixelFormatEnum(SDL_PixelFormatEnum format, out int bpp, out uint rMask, out uint gMask, out uint bMask, out uint aMask);

	/// <summary>
	/// Convert a bpp value and RGBA masks to an enumerated pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatEnumForMasks">documentation</see> for more details.
	/// </remarks>
	/// <param name="bpp">A bits per pixel value; usually 15, 16, or 32.</param>
	/// <param name="rMask">The red mask for the format.</param>
	/// <param name="gMask">The green mask for the format.</param>
	/// <param name="bMask">The blue mask for the format.</param>
	/// <param name="aMask">The alpha mask for the format.</param>
	/// <returns>The <see cref="SDL_PixelFormatEnum"/> value corresponding to the format masks, or <see cref="SDL_PixelFormatEnum.Unknown"/> if there isn't a match.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatEnumForMasks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PixelFormatEnum GetPixelFormatEnumForMasks(int bpp, uint rMask, uint gMask, uint bMask, uint aMask);

	// TODO: Check if the functions below can use a ref return, instead of using a pointer.

	/// <summary>
	/// Create an <see cref="SDL_PixelFormat"/> structure corresponding to a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePixelFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">One of the <see cref="SDL_PixelFormatEnum"/> values.</param>
	/// <returns>The new <see cref="SDL_PixelFormat"/> structure on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreatePixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PixelFormat* CreatePixelFormat(SDL_PixelFormatEnum format);

	/// <summary>
	/// Free an <see cref="SDL_PixelFormat"/> structure allocated by <see cref="CreatePixelFormat(SDL_PixelFormatEnum)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPixelFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">The <see cref="SDL_PixelFormat"/> structure to free.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyPixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyPixelFormat(SDL_PixelFormat* format);

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
	/// Set the palette for a pixel format structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPixelFormatPalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">The <see cref="SDL_PixelFormat"/> structure that will use the palette.</param>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure that will be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetPixelFormatPalette")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette);

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
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="r">The red component of the pixel in the range 0-255.</param>
	/// <param name="g">The green component of the pixel in the range 0-255.</param>
	/// <param name="b">The blue component of the pixel in the range 0-255.</param>
	/// <returns>A pixel value.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MapRGB")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint MapRGB(SDL_PixelFormat* format, byte r, byte g, byte b);

	/// <summary>
	/// Map an <see cref="SDL_Color"/> to an opaque pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGB">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="color">The <see cref="SDL_Color"/> structure to convert.</param>
	/// <returns>A pixel value.</returns>
	public static uint MapRGB(SDL_PixelFormat* format, SDL_Color color)
	{
		return MapRGB(format, color.R, color.G, color.B);
	}

	/// <summary>
	/// Map an RGBA quadruple to a pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGBA">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="r">The red component of the pixel in the range 0-255.</param>
	/// <param name="g">The green component of the pixel in the range 0-255.</param>
	/// <param name="b">The blue component of the pixel in the range 0-255.</param>
	/// <param name="a">The alpha component of the pixel in the range 0-255.</param>
	/// <returns>A pixel value.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MapRGBA")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint MapRGBA(SDL_PixelFormat* format, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Map an <see cref="SDL_Color"/> to a pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGBA">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="color">The <see cref="SDL_Color"/> structure to convert.</param>
	/// <returns>A pixel value.</returns>
	public static uint MapRGBA(SDL_PixelFormat* format, SDL_Color color)
	{
		return MapRGBA(format, color.R, color.G, color.B, color.A);
	}

	/// <summary>
	/// Get RGB values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGB">documentation</see> for more details.
	/// </remarks>
	/// <param name="pixel">A pixel value.</param>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="r">The red component.</param>
	/// <param name="g">The green component.</param>
	/// <param name="b">The blue component.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRGB")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void GetRGB(uint pixel, SDL_PixelFormat* format, out byte r, out byte g, out byte b);

	/// <summary>
	/// Get an opaque <see cref="SDL_Color"/> from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGB">documentation</see> for more details.
	/// </remarks>
	/// <param name="pixel">A pixel value.</param>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="color">The components of <paramref name="pixel"/> represented as an <see cref="SDL_Color"/>.</param>
	public static void GetRGB(uint pixel, SDL_PixelFormat* format, out SDL_Color color)
	{
		GetRGB(pixel, format, out byte r, out byte g, out byte b);
		color = new(r, g, b, AlphaOpaque);
	}

	/// <summary>
	/// Get RGBA values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGBA">documentation</see> for more details.
	/// </remarks>
	/// <param name="pixel">A pixel value.</param>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="r">The red component.</param>
	/// <param name="g">The green component.</param>
	/// <param name="b">The blue component.</param>
	/// <param name="a">The alpha component.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRGBA")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void GetRGBA(uint pixel, SDL_PixelFormat* format, out byte r, out byte g, out byte b, out byte a);

	/// <summary>
	/// Get RGBA values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGBA">documentation</see> for more details.
	/// </remarks>
	/// <param name="pixel">A pixel value.</param>
	/// <param name="format">An <see cref="SDL_PixelFormat"/> structure describing the pixel format.</param>
	/// <param name="color">The components of <paramref name="pixel"/> represented as an <see cref="SDL_Color"/>.</param>
	public static void GetRGBA(uint pixel, SDL_PixelFormat* format, out SDL_Color color)
	{
		GetRGBA(pixel, format, out byte r, out byte g, out byte b, out byte a);
		color = new(r, g, b, a);
	}

	/// <summary>
	/// RGBA format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumRGBA32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.ABGR8888 : SDL_PixelFormatEnum.RGBA8888;

	/// <summary>
	/// ARGB format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumARGB32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.BGRA8888 : SDL_PixelFormatEnum.ARGB8888;

	/// <summary>
	/// BGRA format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumBGRA32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.ARGB8888 : SDL_PixelFormatEnum.BGRA8888;

	/// <summary>
	/// ABGR format, where each channel represents 8-bits.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumABGR32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.RGBA8888 : SDL_PixelFormatEnum.ABGR8888;

	/// <summary>
	/// RGBA format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumRGBX32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.XBGR8888 : SDL_PixelFormatEnum.RGBX8888;

	/// <summary>
	/// ARGB format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumXRGB32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.BGRX8888 : SDL_PixelFormatEnum.XRGB8888;

	/// <summary>
	/// BGRA format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumBGRX32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.XRGB8888 : SDL_PixelFormatEnum.BGRX8888;

	/// <summary>
	/// ABGR format, where each channel represents 8-bits. Alpha channel is ignored.
	/// </summary>
	public static SDL_PixelFormatEnum PixelFormatEnumXBGR32 => BitConverter.IsLittleEndian ? SDL_PixelFormatEnum.RGBX8888 : SDL_PixelFormatEnum.XBGR8888;

	/// <summary>
	/// No transparency.
	/// </summary>
	public const byte AlphaOpaque = 255;

	/// <summary>
	/// Full transparency.
	/// </summary>
	public const byte AlphaTransparent = 0;
}