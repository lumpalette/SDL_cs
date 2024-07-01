using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class SDL_PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Surface* SDL_CreateSurface(int width, int height, SDL_PixelFormatEnum format);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Surface* SDL_CreateSurfaceFrom(void* pixels, int width, int height, int pitch, SDL_PixelFormatEnum format);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_DestroySurface(SDL_Surface* surface);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PropertiesId SDL_GetSurfaceProperties(SDL_Surface* surface);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace* colorspace);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_LockSurface(SDL_Surface* surface);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_UnlockSurface(SDL_Surface* surface);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Surface* SDL_LoadBMP(byte* file);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SaveBMP(SDL_Surface* surface, byte* file);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfaceRLE(SDL_Surface* surface, int flag);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SurfaceHasRLE(SDL_Surface* surface);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfaceColorKey(SDL_Surface* surface, int enable, uint key);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SurfaceHasColorKey(SDL_Surface* surface);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSurfaceColorKey(SDL_Surface* surface, uint* key);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfaceColorMod(SDL_Surface* surface, byte r, byte g, byte b);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSurfaceColorMod(SDL_Surface* surface, byte* r, byte* g, byte* b);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfaceAlphaMod(SDL_Surface* surface, byte alpha);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSurfaceAlphaMod(SDL_Surface* surface, byte* alpha);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode* blendMode);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_FlipSurface(SDL_Surface* surface, SDL_FlipMode flip);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Surface* SDL_DuplicateSurface(SDL_Surface* surface);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Surface* SDL_ConvertSurface(SDL_Surface* surface, SDL_PixelFormat* format);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Surface* SDL_ConvertSurfaceFormat(SDL_Surface* surface, SDL_PixelFormatEnum format);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Surface* SDL_ConvertSurfaceFormatAndColorspace(SDL_Surface* surface, SDL_PixelFormatEnum format, SDL_Colorspace colorspace, SDL_PropertiesId props);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ConvertPixels(int width, int height, SDL_PixelFormatEnum srcFormat, void* src, int srcPitch, SDL_PixelFormatEnum dstFormat, void* dst, int dstPitch);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormatEnum srcFormat, SDL_Colorspace srcColorspace, SDL_PropertiesId srcProps, void* src, int srcPitch, SDL_PixelFormatEnum dstFormat, SDL_Colorspace dstColorspace, SDL_PropertiesId dstProps, void* dst, int dstPitch); // dude wtf is this function

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_PremultiplyAlpha(int width, int height, SDL_PixelFormatEnum srcFormat, void* src, int srcPitch, SDL_PixelFormatEnum dstFormat, void* dst, int dstPitch);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_FillSurfaceRect(SDL_Surface* dst, SDL_Rect* rect, uint color);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_FillSurfaceRects(SDL_Surface* dst, SDL_Rect* rects, int count, uint color);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_BlitSurface(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_BlitSurfaceUnchecked(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SoftStretch(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_BlitSurfaceScaled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_BlitSurfaceUncheckedScaled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ReadSurfacePixel(SDL_Surface* surface, int x, int y, byte* r, byte* g, byte* b, byte* a);
}