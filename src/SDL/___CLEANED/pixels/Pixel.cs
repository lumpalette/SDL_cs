using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class SDL_PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetPixelFormatName(SDL_PixelFormatEnum format);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetMasksForPixelFormatEnum(SDL_PixelFormatEnum format, int* bpp, uint* rMask, uint* gMask, uint* bMask, uint* aMask);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PixelFormatEnum SDL_GetPixelFormatEnumForMasks(int bpp, uint rMask, uint gMask, uint bMask, uint aMask);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PixelFormat* SDL_CreatePixelFormat(SDL_PixelFormatEnum format);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_DestroyPixelFormat(SDL_PixelFormat* format);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Palette* SDL_CreatePalette(int nColors);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetPaletteColors(SDL_Palette* palette, SDL_Color* colors, int firstColor, int nColors);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_DestroyPalette(SDL_Palette* palette);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern uint SDL_MapRGB(SDL_PixelFormat* format, byte r, byte g, byte b);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern uint SDL_MapRGBA(SDL_PixelFormat* format, byte r, byte g, byte b, byte a);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_GetRGB(uint pixel, SDL_PixelFormat* format, byte* r, byte* g, byte* b);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_GetRGBA(uint pixel, SDL_PixelFormat* format, byte* r, byte* g, byte* b, byte* a);
}