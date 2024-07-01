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
}