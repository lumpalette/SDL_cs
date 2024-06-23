using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_pixels.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pixels.h.
unsafe partial class SDL
{
	[Macro]
	public static SDL_PixelFormatEnum DefinePixelFourCC(byte a, byte b, byte c, byte d)
	{
		return new SDL_PixelFormatEnum(a, b, c, d);
	}

	[Macro]
	public static SDL_PixelFormatEnum DefinePixelFormat(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		return new SDL_PixelFormatEnum(type, order, layout, bits, bytes);
	}

	[Macro]
	public static byte PixelFlag(SDL_PixelFormatEnum format)
	{
		return (byte)((((uint)format) >> 28) & 0x0F);
	}

	[Macro]
	public static SDL_PixelType PixelType(SDL_PixelFormatEnum format)
	{
		return (SDL_PixelType)(((uint)format >> 24) & 0x0F);
	}

	[Macro]
	public static byte PixelOrder(SDL_PixelFormatEnum format)
	{
		return (byte)(((uint)format >> 20) & 0x0F);
	}

	[Macro]
	public static SDL_PackedLayout PixelLayout(SDL_PixelFormatEnum format)
	{
		return (SDL_PackedLayout)(((uint)format >> 16) & 0x0F);
	}

	[Macro]
	public static byte BitsPerPixel(SDL_PixelFormatEnum format)
	{
		return (byte)(((uint)format >> 8) & 0xFF);
	}

	[Macro]
	public static byte BytesPerPixel(SDL_PixelFormatEnum format)
	{
		if (IsPixelFormatFourCC(format))
		{
			return (byte)(((format == SDL_PixelFormatEnum.YUY2) || (format == SDL_PixelFormatEnum.UYVY) || (format == SDL_PixelFormatEnum.YVYU) || (format == SDL_PixelFormatEnum.P010)) ? 2 : 1);
		}
		return (byte)(((uint)format >> 0) & 0xFF);
	}

	[Macro]
	public static bool IsPixelFormatIndexed(SDL_PixelFormatEnum format)
	{
		return (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.Index1) || (PixelType(format) == SDL_PixelType.Index2) || (PixelType(format) == SDL_PixelType.Index4) || (PixelType(format) == SDL_PixelType.Index8));
	}

	[Macro]
	public static bool IsPixelFormatPacked(SDL_PixelFormatEnum format)
	{
		return (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.Packed8) || (PixelType(format) == SDL_PixelType.Packed16) || (PixelType(format) == SDL_PixelType.Packed32));
	}

	[Macro]
	public static bool IsPixelFormatArray(SDL_PixelFormatEnum format)
	{
		return (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.ArrayU8) || (PixelType(format) == SDL_PixelType.ArrayU16) || (PixelType(format) == SDL_PixelType.ArrayU32) || (PixelType(format) == SDL_PixelType.ArrayF16) || (PixelType(format) == SDL_PixelType.ArrayF32));
	}

	[Macro]
	public static bool IsPixelFormatAlpha(SDL_PixelFormatEnum format)
	{
		SDL_PackedOrder order = (SDL_PackedOrder)PixelOrder(format);
		return IsPixelFormatPacked(format) && ((order == SDL_PackedOrder.ARGB) || (order == SDL_PackedOrder.RGBA) || (order == SDL_PackedOrder.ABGR) || (order == SDL_PackedOrder.BGRA));
	}

	[Macro]
	public static bool IsPixelFormat10Bit(SDL_PixelFormatEnum format)
	{
		return (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.Packed32) || (PixelLayout(format) == SDL_PackedLayout.Layout2101010));
	}

	[Macro]
	public static bool IsPixelFormatFloat(SDL_PixelFormatEnum format)
	{
		return (!IsPixelFormatFourCC(format)) && ((PixelType(format) == SDL_PixelType.ArrayF16) || (PixelType(format) == SDL_PixelType.ArrayF32));
	}

	[Macro]
	public static bool IsPixelFormatFourCC(SDL_PixelFormatEnum format)
	{
		return (format != SDL_PixelFormatEnum.Unknown) && (PixelFlag(format) != 1);
	}

	[Macro]
	public static SDL_ColorType ColorspaceType(SDL_Colorspace colorspace)
	{
		return (SDL_ColorType)(((uint)colorspace >> 28) & 0x0F);
	}

	[Macro]
	public static SDL_ColorRange ColorspaceRange(SDL_Colorspace colorspace)
	{
		return (SDL_ColorRange)(((uint)colorspace >> 24) & 0x0F);
	}

	[Macro]
	public static SDL_ChromaLocation ColorspaceChroma(SDL_Colorspace colorspace)
	{
		return (SDL_ChromaLocation)(((uint)colorspace >> 20) & 0x0F);
	}

	[Macro]
	public static SDL_ColorPrimaries ColorspacePrimaries(SDL_Colorspace colorspace)
	{
		return (SDL_ColorPrimaries)(((uint)colorspace >> 10) & 0x1F);
	}

	[Macro]
	public static SDL_TransferCharacteristics ColorspaceTransfer(SDL_Colorspace colorspace)
	{
		return (SDL_TransferCharacteristics)(((uint)colorspace >> 5) & 0x1F);
	}

	[Macro]
	public static SDL_MatrixCoefficients ColorspaceMatrix(SDL_Colorspace colorspace)
	{
		return (SDL_MatrixCoefficients)((uint)colorspace & 0x1F);
	}

	[Macro]
	public static bool IsColorspaceMatrixBT601(SDL_Colorspace colorspace)
	{
		return (ColorspaceMatrix(colorspace) == SDL_MatrixCoefficients.BT601) || (ColorspaceMatrix(colorspace) == SDL_MatrixCoefficients.BT470BG);
	}

	[Macro]
	public static bool IsColorspaceMatrixBT709(SDL_Colorspace colorspace)
	{
		return ColorspaceMatrix(colorspace) == SDL_MatrixCoefficients.BT709;
	}

	[Macro]
	public static bool IsColorspaceMatrixBT2020Ncl(SDL_Colorspace colorspace)
	{
		return ColorspaceMatrix(colorspace) == SDL_MatrixCoefficients.BT2020NCL;
	}

	[Macro]
	public static bool IsColorspaceLimitedRange(SDL_Colorspace colorspace)
	{
		return ColorspaceRange(colorspace) != SDL_ColorRange.Full;
	}

	[Macro]
	public static bool IsColorspaceFullRange(SDL_Colorspace colorspace)
	{
		return ColorspaceRange(colorspace) == SDL_ColorRange.Full;
	}

	/// <summary>
	/// Get the human readable name of a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatName">here</see>
	/// </remarks>
	/// <param name="format"> The pixel format to query. </param>
	/// <returns> The human readable name of the specified pixel format or "SDL_PIXELFORMAT_UNKNOWN" if the format isn't recognized. </returns>
	public static string GetPixelFormatName(SDL_PixelFormatEnum format)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(format))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_PixelFormatEnum format);
	}

	/// <summary>
	/// Convert a pixel format value to a bpp value and RGBA masks.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetMasksForPixelFormatEnum">here</see>
	/// </remarks>
	/// <param name="format"> One of the static properties in <see cref="SDL_PixelFormatEnum"/>. </param>
	/// <param name="bpp"> Returns a bits per pixel value; usually 15, 16, or 32. </param>
	/// <param name="rMask"> Returns the red mask for the format. </param>
	/// <param name="gMask"> Returns the green mask for the format. </param>
	/// <param name="bMask"> Returns the blue mask for the format. </param>
	/// <param name="aMask"> Returns the alpha mask for the format. </param>
	/// <returns> True on success or false if the conversion wasn't possible; call <see cref="GetError"/> for more information. </returns>
	public static bool GetMasksForPixelFormatValue(SDL_PixelFormatEnum format, out int bpp, out uint rMask, out uint gMask, out uint bMask, out uint aMask)
	{
		fixed (int* bppPtr = &bpp)
		{
			fixed (uint* rMaskPtr = &rMask, gMaskPtr = &gMask, bMaskPtr = &bMask, aPtr = &aMask)
			{
				return _PInvoke(format, bppPtr, rMaskPtr, gMaskPtr, bMaskPtr, aPtr) == 1;
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetMasksForPixelFormatEnum", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PixelFormatEnum format, int* bpp, uint* rMask, uint* gMask, uint* bMask, uint* aMask);
	}

	/// <summary>
	/// Convert a bpp value and RGBA masks to a pixel format value.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatEnumForMasks">here</see> for more details.
	/// </remarks>
	/// <param name="bpp"> A bits per pixel value; usually 15, 16, or 32 </param>
	/// <param name="rMask"> The red mask for the format. </param>
	/// <param name="gMask"> The green mask for the format. </param>
	/// <param name="bMask"> The blue mask for the format. </param>
	/// <param name="aMask"> The alpha mask for the format. </param>
	/// <returns> The <see cref="SDL_PixelFormatEnum"/> value corresponding to the format masks, or <see cref="SDL_PixelFormatEnum.Unknown"/> if there isn't a match. </returns>
	public static SDL_PixelFormatEnum GetPixelFormatValueForMasks(int bpp, uint rMask, uint gMask, uint bMask, uint aMask)
	{
		return _PInvoke(bpp, rMask, gMask, bMask, aMask);

		[DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatEnumForMasks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PixelFormatEnum _PInvoke(int bpp, uint rMask, uint gMask, uint bMask, uint aMask);
	}

	/// <summary>
	/// Create An <see cref="SDL_PixelFormat"/> structure corresponding to a pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePixelFormat">here</see> for more details.
	/// </remarks>
	/// <param name="format"> One of the static properties in <see cref="SDL_PixelFormatEnum"/>. </param>
	/// <returns> The new <see cref="SDL_PixelFormat"/> structure on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PixelFormat* CreatePixelFormat(SDL_PixelFormatEnum format)
	{
		return _PInvoke(format);

		[DllImport(LibraryName, EntryPoint = "SDL_CreatePixelFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PixelFormat* _PInvoke(SDL_PixelFormatEnum format);
	}

	/// <summary>
	/// Free An <see cref="SDL_PixelFormat"/> structure allocated by <see cref="CreatePixelFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPixelFormat">here</see> for more details.
	/// </remarks>
	/// <param name="format"> The <see cref="SDL_PixelFormat"/> structure to free. </param>
	public static void DestroyPixelFormat(SDL_PixelFormat* format)
	{
		_PInvoke(format);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyPixelFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_PixelFormat* format);
	}

	/// <summary>
	/// Create An <see cref="SDL_Palette"/> structure with the specified number of color entries.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePalette">here</see> for more details.
	/// </remarks>
	/// <param name="nColors"> Represents the number of color entries in the color palette. </param>
	/// <returns> A new <see cref="SDL_Palette"/> structure on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Palette* CreatePalette(int nColors)
	{
		return _PInvoke(nColors);

		[DllImport(LibraryName, EntryPoint = "SDL_CreatePalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Palette* _PInvoke(int nColors);
	}

	/// <summary>
	/// Set the palette for a pixel format structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetPixelFormatPalette">here</see> for more details.
	/// </remarks>
	/// <param name="format"> The <see cref="SDL_PixelFormat"/> structure that will use the palette. </param>
	/// <param name="palette"> The <see cref="SDL_Palette"/> structure that will be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette)
	{
		return _PInvoke(format, palette);

		[DllImport(LibraryName, EntryPoint = "SDL_SetPixelFormatPalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PixelFormat* format, SDL_Palette* palette);
	}

	/// <summary>
	/// Set a range of colors in a palette.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetPaletteColors">here</see> for more details.
	/// </remarks>
	/// <param name="palette"> The <see cref="SDL_Palette"/> structure to modify. </param>
	/// <param name="colors"> An array of <see cref="SDL_Color"/> structures to copy into the palette. </param>
	/// <param name="firstColor"> The index of the first palette entry to modify. </param>
	/// <param name="nColors"> The number of entries to modify. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetPaletteColors(SDL_Palette* palette, SDL_Color[] colors, int firstColor, int nColors)
	{
		// i don't think this is the right way of doing this... oh well! it works, right???
		fixed (SDL_Color* colorsPtr = colors)
		{
			return _PInvoke(palette, colorsPtr, firstColor, nColors);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetPaletteColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Palette* palette, SDL_Color* colors, int firstColor, int nColors);
	}

	/// <summary>
	/// Free An <see cref="SDL_Palette"/> structure created with <see cref="CreatePalette(int)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPalette">here</see> for more details.
	/// </remarks>
	/// <param name="palette"> The <see cref="SDL_Palette"/> structure to be freed. </param>
	public static void DestroyPalette(SDL_Palette* palette)
	{
		_PInvoke(palette);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyPalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Palette* palette);
	}

	/// <summary>
	/// Map an RGB triple to an opaque pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGB">here</see> for more details.
	/// </remarks>
	/// <param name="format"> An <see cref="SDL_PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> The red component of the pixel in the range 0-255. </param>
	/// <param name="g"> The green component of the pixel in the range 0-255. </param>
	/// <param name="b"> The blue component of the pixel in the range 0-255. </param>
	/// <returns> A pixel value. </returns>
	public static uint MapRGB(SDL_PixelFormat* format, byte r, byte g, byte b)
	{
		return _PInvoke(format, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_MapRGB", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern uint _PInvoke(SDL_PixelFormat* format, byte r, byte g, byte b);
	}

	/// <summary>
	/// Map an RGBA quadruple to a pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGBA">here</see> for more details.
	/// </remarks>
	/// <param name="format"> An <see cref="SDL_PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> The red component of the pixel in the range 0-255. </param>
	/// <param name="g"> The green component of the pixel in the range 0-255. </param>
	/// <param name="b"> The blue component of the pixel in the range 0-255. </param>
	/// <param name="a"> The blue component of the pixel in the range 0-255. </param>
	/// <returns> A pixel value. </returns>
	public static uint MapRGBA(SDL_PixelFormat* format, byte r, byte g, byte b, byte a)
	{
		return _PInvoke(format, r, g, b, a);

		[DllImport(LibraryName, EntryPoint = "SDL_MapRGBA", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern uint _PInvoke(SDL_PixelFormat* format, byte r, byte g, byte b, byte a);
	}

	/// <summary>
	/// Get RGB values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGB">here</see> for more details.
	/// </remarks>
	/// <param name="pixel"> A pixel value. </param>
	/// <param name="format"> An <see cref="SDL_PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> Returns the red component of <paramref name="pixel"/>. </param>
	/// <param name="g"> Returns the green component of <paramref name="pixel"/>. </param>
	/// <param name="b"> Returns the blue component of <paramref name="pixel"/>. </param>
	public static void GetRGB(uint pixel, SDL_PixelFormat* format, out byte r, out byte g, out byte b)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b)
		{
			_PInvoke(pixel, format, rPtr, gPtr, bPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRGBA", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(uint pixel, SDL_PixelFormat* format, byte* r, byte* g, byte* b);
	}

	/// <summary>
	/// Get RGBA values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGBA">here</see> for more details.
	/// </remarks>
	/// <param name="pixel"> A pixel value. </param>
	/// <param name="format"> An <see cref="SDL_PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> Returns the red component of <paramref name="pixel"/>. </param>
	/// <param name="g"> Returns the green component of <paramref name="pixel"/>. </param>
	/// <param name="b"> Returns the blue component of <paramref name="pixel"/>. </param>
	/// <param name="a"> Returns the alpha component of <paramref name="pixel"/>. </param>
	public static void GetRGBA(uint pixel, SDL_PixelFormat* format, out byte r, out byte g, out byte b, out byte a)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b, aPtr = &a)
		{
			_PInvoke(pixel, format, rPtr, gPtr, bPtr, aPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRGBA", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(uint pixel, SDL_PixelFormat* format, byte* r, byte* g, byte* b, byte* a);
	}

	/// <summary>
	/// No transparency.
	/// </summary>
	public const int AlphaOpaque = 255;

	/// <summary>
	/// Full transparency.
	/// </summary>
	public const int AlphaTransparent = 0;
}