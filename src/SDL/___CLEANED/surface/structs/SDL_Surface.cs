using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A collection of pixels used in software blitting.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Surface">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Surface
{
	public readonly SDL_SurfaceFlags Flags;

	public readonly SDL_PixelFormat* Format;

	public readonly int Width;

	public readonly int Height;

	public readonly int Pitch;

	public nint Pixels;

	private readonly nint _reserved;

	public readonly int Locked;

	private readonly SDL_BlitMap* _listBlitmap;

	public readonly SDL_Rect ClipRect;

	private readonly SDL_BlitMap* _map;

	public readonly int RefCount;
}