using System;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_pixels.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pixels.h.
unsafe partial class SDL
{
	/// <summary>
	/// Defines a new <see cref="SDL_PixelFormatEnum"/> based on a FourCC.
	/// </summary>
	/// <param name="a">1st character of the code.</param>
	/// <param name="b">2nd character of the code.</param>
	/// <param name="c">3rd character of the code.</param>
	/// <param name="d">4th character of the code.</param>
	/// <returns>A new pixel format, created from the provided characters.</returns>
	[Macro]
	public static SDL_PixelFormatEnum DefinePixelFourCC(byte a, byte b, byte c, byte d)
	{
		return (SDL_PixelFormatEnum)FourCC(a, b, c, d);
	}

	/// <summary>
	/// Defines a new <see cref="SDL_PixelFormatEnum"/> value with the given pixel attributes.
	/// </summary>
	/// <param name="type">The pixel type.</param>
	/// <param name="order">The pixel components' order.</param>
	/// <param name="layout">The pixel's memory layout.</param>
	/// <param name="bits">The number of bits used by the pixel's components.</param>
	/// <param name="bytes">The number of bytes used by the pixel format.</param>
	/// <returns>A new pixel format, created from the provided attributes.</returns>
	[Macro]
	public static SDL_PixelFormatEnum DefinePixelFormat(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		return (SDL_PixelFormatEnum)((1 << 28) | ((byte)type << 24) | (order << 20) | ((byte)layout << 16) | (bits << 8) | bytes);
	}

	/// <summary>
	/// Gets the flags of a given <see cref="SDL_PixelFormatEnum"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>The pixel flags of <paramref name="x"/>.</returns>
	[Macro]
	public static byte PixelFlag(SDL_PixelFormatEnum x)
	{
		return (byte)(((uint)x >> 28) & 0x0F);
	}

	/// <summary>
	/// Gets the pixel type of a given <see cref="SDL_PixelFormatEnum"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>The pixel type of <paramref name="x"/>.</returns>
	[Macro]
	public static SDL_PixelType PixelType(SDL_PixelFormatEnum x)
	{
		return (SDL_PixelType)(((uint)x >> 24) & 0x0F);
	}

	/// <summary>
	/// Gets the color components' order of a given <see cref="SDL_PixelFormatEnum"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>The pixel order of <paramref name="x"/>.</returns>
	[Macro]
	public static byte PixelOrder(SDL_PixelFormatEnum x)
	{
		return (byte)(((uint)x >> 20) & 0x0F);
	}

	/// <summary>
	/// Gets the memory layout of a given <see cref="SDL_PixelFormatEnum"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>The packed layout of <paramref name="x"/>.</returns>
	[Macro]
	public static SDL_PackedLayout PixelLayout(SDL_PixelFormatEnum x)
	{
		return (SDL_PackedLayout)(((uint)x >> 16) & 0x0F);
	}

	/// <summary>
	/// Gets the bits per pixel (bpp) of a given <see cref="SDL_PixelFormatEnum"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>The bpp of <paramref name="x"/>.</returns>
	[Macro]
	public static byte BitsPerPixel(SDL_PixelFormatEnum x)
	{
		return (byte)(((uint)x >> 8) & 0xFF);
	}

	/// <summary>
	/// Gets the bytes per pixel (Bpp) of a given <see cref="SDL_PixelFormatEnum"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>The Bpp of <paramref name="x"/>.</returns>
	[Macro]
	public static byte BytesPerPixel(SDL_PixelFormatEnum x)
	{
		if (IsPixelFormatFourCC(x))
		{
			return (byte)(((x == SDL_PixelFormatEnum.YUY2) || (x == SDL_PixelFormatEnum.UYVY) || (x == SDL_PixelFormatEnum.YVYU) || (x == SDL_PixelFormatEnum.P010)) ? 2 : 1);
		}
		return (byte)(((uint)x >> 0) & 0xFF);
	}

	/// <summary>
	/// Determines if a given <see cref="SDL_PixelFormatEnum"/> is indexed.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>True if the pixel type of <paramref name="x"/> is indexed, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatIndexed(SDL_PixelFormatEnum x)
	{
		return (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Index1) || (PixelType(x) == SDL_PixelType.Index2) || (PixelType(x) == SDL_PixelType.Index4) || (PixelType(x) == SDL_PixelType.Index8));
	}

	/// <summary>
	/// Determines if a given <see cref="SDL_PixelFormatEnum"/> is packed.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>True if the pixel type of <paramref name="x"/> is packed, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatPacked(SDL_PixelFormatEnum x)
	{
		return (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Packed8) || (PixelType(x) == SDL_PixelType.Packed16) || (PixelType(x) == SDL_PixelType.Packed32));
	}

	/// <summary>
	/// Determines if a given <see cref="SDL_PixelFormatEnum"/> is array.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>True if the pixel type of <paramref name="x"/> is array, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatArray(SDL_PixelFormatEnum x)
	{
		return (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.ArrayU8) || (PixelType(x) == SDL_PixelType.ArrayU16) || (PixelType(x) == SDL_PixelType.ArrayU32) || (PixelType(x) == SDL_PixelType.ArrayF16) || (PixelType(x) == SDL_PixelType.ArrayF32));
	}

	/// <summary>
	/// Determines if a given <see cref="SDL_PixelFormatEnum"/> has an alpha channel.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>True if <paramref name="x"/> has alpha, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatAlpha(SDL_PixelFormatEnum x)
	{
		SDL_PackedOrder order = (SDL_PackedOrder)PixelOrder(x);
		return IsPixelFormatPacked(x) && ((order == SDL_PackedOrder.ARGB) || (order == SDL_PackedOrder.RGBA) || (order == SDL_PackedOrder.ABGR) || (order == SDL_PackedOrder.BGRA));
	}

	/// <summary>
	/// Determines if a given <see cref="SDL_PixelFormatEnum"/> is a 10-bit format.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>True if <paramref name="x"/> is 10-bit, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormat10Bit(SDL_PixelFormatEnum x)
	{
		return (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.Packed32) || (PixelLayout(x) == SDL_PackedLayout._2101010));
	}

	/// <summary>
	/// Determines if a given <see cref="SDL_PixelFormatEnum"/> use floating-point numbers to represent color components.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>True if <paramref name="x"/> uses floating-point numbers, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatFloat(SDL_PixelFormatEnum x)
	{
		return (!IsPixelFormatFourCC(x)) && ((PixelType(x) == SDL_PixelType.ArrayF16) || (PixelType(x) == SDL_PixelType.ArrayF32));
	}

	/// <summary>
	/// Determines if a given <see cref="SDL_PixelFormatEnum"/> is a FourCC.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PixelFormatEnum"/> to query.</param>
	/// <returns>True if <paramref name="x"/> is a FourCC, false otherwise.</returns>
	[Macro]
	public static bool IsPixelFormatFourCC(SDL_PixelFormatEnum x)
	{
		return (x != SDL_PixelFormatEnum.Unknown) && (PixelFlag(x) != 1);
	}

	/// <summary>
	/// Defines a new <see cref="SDL_Colorspace"/> with the given color attributes.
	/// </summary>
	/// <param name="type">The color type.</param>
	/// <param name="range">The color range.</param>
	/// <param name="primaries">The color primaries.</param>
	/// <param name="transfer">The color transfer characteristics.</param>
	/// <param name="matrix">The matrix coefficients.</param>
	/// <param name="chroma">The chroma location.</param>
	/// <returns>A new colorspace, created from the provided attributes.</returns>
	[Macro]
	public static SDL_Colorspace DefineColorspace(SDL_ColorType type, SDL_ColorRange range, SDL_ColorPrimaries primaries, SDL_TransferCharacteristics transfer, SDL_MatrixCoefficients matrix, SDL_ChromaLocation chroma)
	{
		return (SDL_Colorspace)(((byte)type << 28) | ((byte)range << 24) | ((byte)chroma << 20) | ((byte)primaries << 10) | ((byte)transfer << 5) | (byte)matrix);
	}
	
	/// <summary>
	/// Gets the color type of a given <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>The color type of <paramref name="x"/>.</returns>
	[Macro]
	public static SDL_ColorType ColorspaceType(SDL_Colorspace x)
	{
		return (SDL_ColorType)(((uint)x >> 28) & 0x0F);
	}

	/// <summary>
	/// Gets the color range of a given <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>The color range of <paramref name="x"/>.</returns>
	[Macro]
	public static SDL_ColorRange ColorspaceRange(SDL_Colorspace x)
	{
		return (SDL_ColorRange)(((uint)x >> 24) & 0x0F);
	}
	
	/// <summary>
	/// Gets the chroma location of a given <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>The chroma location of <paramref name="x"/>.</returns>
	[Macro]
	public static SDL_ChromaLocation ColorspaceChroma(SDL_Colorspace x)
	{
		return (SDL_ChromaLocation)(((uint)x >> 20) & 0x0F);
	}

	/// <summary>
	/// Gets the color primaries of a given <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>The color primaries of <paramref name="x"/>.</returns>
	[Macro]
	public static SDL_ColorPrimaries ColorspacePrimaries(SDL_Colorspace x)
	{
		return (SDL_ColorPrimaries)(((uint)x >> 10) & 0x1F);
	}

	/// <summary>
	/// Gets the transfer characteristics of a given <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>The transfer characteristics of <paramref name="x"/></returns>
	[Macro]
	public static SDL_TransferCharacteristics ColorspaceTransfer(SDL_Colorspace x)
	{
		return (SDL_TransferCharacteristics)(((uint)x >> 5) & 0x1F);
	}

	/// <summary>
	/// Gets the matrix coefficients of a given <see cref="SDL_Colorspace"/>.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>The matrix coefficients of <paramref name="x"/></returns>
	[Macro]
	public static SDL_MatrixCoefficients ColorspaceMatrix(SDL_Colorspace x)
	{
		return (SDL_MatrixCoefficients)((uint)x & 0x1F);
	}

	/// <summary>
	/// Determines if the given <see cref="SDL_Colorspace"/> has matrix coefficients according to the ITU-R BT.601 standard.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>True if the matrix coefficients of <paramref name="x"/> refer to the ITU-R BT.601 standard, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceMatrixBT601(SDL_Colorspace x)
	{
		return (ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT601) || (ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT470BG);
	}

	/// <summary>
	/// Determines if the given <see cref="SDL_Colorspace"/> has matrix coefficients according to the ITU-R BT.709-6 standard.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>True if the matrix coefficients of <paramref name="x"/> refer to the ITU-R BT.709-6 standard, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceMatrixBT709(SDL_Colorspace x)
	{
		return ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT709;
	}

	/// <summary>
	/// Determines if the given <see cref="SDL_Colorspace"/> has matrix coefficients according to the ITU-R BT.2020-2 NCL standard.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>True if the matrix coefficients of <paramref name="x"/> refer to the ITU-R BT.2020-2 NCL standard, false otherwise.</returns>
	[Macro]
	public static bool IsColorspaceMatrixBT2020Ncl(SDL_Colorspace x)
	{
		return ColorspaceMatrix(x) == SDL_MatrixCoefficients.BT2020Ncl;
	}

	/// <summary>
	/// Determines if the range of a given <see cref="SDL_Colorspace"/> uses a limited range.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>True if the color range of <paramref name="x"/> is set to 'limited'.</returns>
	[Macro]
	public static bool IsColorspaceLimitedRange(SDL_Colorspace x)
	{
		return ColorspaceRange(x) != SDL_ColorRange.Full;
	}

	/// <summary>
	/// Determines if the range of a given <see cref="SDL_Colorspace"/> uses a full range.
	/// </summary>
	/// <param name="x">The <see cref="SDL_Colorspace"/> to query.</param>
	/// <returns>True if the color range of <paramref name="x"/> is set to 'full'.</returns>
	[Macro]
	public static bool IsColorspaceFullRange(SDL_Colorspace colorspace)
	{
		return ColorspaceRange(colorspace) == SDL_ColorRange.Full;
	}

	/// <summary>
	/// Get the human readable name of a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatName">here</see>
	/// </remarks>
	/// <param name="format">The pixel format to query.</param>
	/// <returns>The human readable name of the specified pixel format or "SDL_PIXELFORMAT_UNKNOWN" if the format isn't recognized.</returns>
	public static string GetPixelFormatName(SDL_PixelFormatEnum format)
	{
		return Marshal.PtrToStringUTF8((nint)SDL_PInvoke.SDL_GetPixelFormatName(format))!;
	}

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
	public static bool GetMasksForPixelFormatEnum(SDL_PixelFormatEnum format, out int bpp, out uint rMask, out uint gMask, out uint bMask, out uint aMask)
	{
		fixed (int* bppPtr = &bpp)
		{
			fixed (uint* rMaskPtr = &rMask, gMaskPtr = &gMask, bMaskPtr = &bMask, aPtr = &aMask)
			{
				return SDL_PInvoke.SDL_GetMasksForPixelFormatEnum(format, bppPtr, rMaskPtr, gMaskPtr, bMaskPtr, aPtr) == 1;
			}
		}
	}

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
	public static SDL_PixelFormatEnum GetPixelFormatEnumForMasks(int bpp, uint rMask, uint gMask, uint bMask, uint aMask)
	{
		return SDL_PInvoke.SDL_GetPixelFormatEnumForMasks(bpp, rMask, gMask, bMask, aMask);
	}

	/// <summary>
	/// Create an <see cref="SDL_PixelFormat"/> structure corresponding to a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePixelFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">One of the <see cref="SDL_PixelFormatEnum"/> values.</param>
	/// <returns>The new <see cref="SDL_PixelFormat"/> structure on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_PixelFormat* CreatePixelFormat(SDL_PixelFormatEnum format)
	{
		return SDL_PInvoke.SDL_CreatePixelFormat(format);
	}

	/// <summary>
	/// Free an <see cref="SDL_PixelFormat"/> structure allocated by <see cref="CreatePixelFormat(SDL_PixelFormatEnum)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPixelFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">The <see cref="SDL_PixelFormat"/> structure to free.</param>
	public static void DestroyPixelFormat(SDL_PixelFormat* format)
	{
		SDL_PInvoke.SDL_DestroyPixelFormat(format);
	}

	/// <summary>
	/// Create a palette structure with the specified number of color entries.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="nColors">Represents the number of color entries in the color palette.</param>
	/// <returns>A new <see cref="SDL_Palette"/> structure on success or <see langword="null"/> on failure (e.g. if there wasn't enough memory); call <see cref="GetError"/> for more information.</returns>
	public static SDL_Palette* CreatePalette(int nColors)
	{
		return SDL_PInvoke.SDL_CreatePalette(nColors);
	}

	/// <summary>
	/// Set the palette for a pixel format structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPixelFormatPalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">The <see cref="SDL_PixelFormat"/> structure that will use the palette.</param>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure that will be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette)
	{
		return SDL_PInvoke.SDL_SetPixelFormatPalette(format, palette);
	}

	/// <summary>
	/// Set a range of colors in a palette.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPaletteColors">documentation</see> for more details.
	/// </remarks>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure to modify.</param>
	/// <param name="colors">An array of <see cref="SDL_Color"/> structures to copy into the palette.</param>
	/// <param name="firstColor">The index of the first palette entry to modify.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetPaletteColors(SDL_Palette* palette, SDL_Color[] colors, int firstColor)
	{
		fixed (SDL_Color* colorsPtr = colors)
		{
			return SDL_PInvoke.SDL_SetPaletteColors(palette, colorsPtr, firstColor, colors.Length);
		}
	}

	/// <summary>
	/// Free a palette created with <see cref="CreatePalette(int)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure to be freed.</param>
	public static void DestroyPalette(SDL_Palette* palette)
	{
		SDL_PInvoke.SDL_DestroyPalette(palette);
	}

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
	public static uint MapRGB(SDL_PixelFormat* format, byte r, byte g, byte b)
	{
		return SDL_PInvoke.SDL_MapRGB(format, r, g, b);
	}

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
		return SDL_PInvoke.SDL_MapRGB(format, color.R, color.G, color.B);
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
	public static uint MapRGBA(SDL_PixelFormat* format, byte r, byte g, byte b, byte a)
	{
		return SDL_PInvoke.SDL_MapRGBA(format, r, g, b, a);
	}

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
		return SDL_PInvoke.SDL_MapRGBA(format, color.R, color.G, color.B, color.A);
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
	public static void GetRGB(uint pixel, SDL_PixelFormat* format, out byte r, out byte g, out byte b)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b)
		{
			SDL_PInvoke.SDL_GetRGB(pixel, format, rPtr, gPtr, bPtr);
		}
	}

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
		byte r;
		byte g;
		byte b;
		SDL_PInvoke.SDL_GetRGB(pixel, format, &r, &g, &b);
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
	public static void GetRGBA(uint pixel, SDL_PixelFormat* format, out byte r, out byte g, out byte b, out byte a)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b, aPtr = &a)
		{
			SDL_PInvoke.SDL_GetRGBA(pixel, format, rPtr, gPtr, bPtr, aPtr);
		}
	}

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
		byte r;
		byte g;
		byte b;
		byte a;
		SDL_PInvoke.SDL_GetRGBA(pixel, format, &r, &g, &b, &a);
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