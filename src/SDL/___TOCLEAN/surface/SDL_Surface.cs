using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A collection of pixels used in software blitting.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Surface">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe readonly struct SDL_Surface
{
	/// <summary>
	/// Surface internal flags.
	/// </summary>
	public readonly SDL_SurfaceFlags Flags;

	/// <summary>
	/// The pixel format this surface uses.
	/// </summary>
	public readonly SDL_PixelFormat* Format;

	/// <summary>
	/// The width of the surface.
	/// </summary>
	public readonly int Width;

	/// <summary>
	/// The height of the surface.
	/// </summary>
	public readonly int Height;

	/// <summary>
	/// Length of a surface scanline, in bytes.
	/// </summary>
	public readonly int Pitch;

	/// <summary>
	/// The pixel data flattened into a 1D array.
	/// </summary>
	public readonly uint* Pixels;

	private readonly void* _reserved;

	/// <summary>
	/// The number of locks this surface has. For each time the surface is locked or unlocked, this counter goes up or down.
	/// </summary>
	public readonly int Locked;

	public readonly SDL_BlitMap* _listBlitmap;

	/// <summary>
	/// The surface's area that can be renderable.
	/// </summary>
	public readonly SDL_Rect ClipRect;

	private readonly SDL_BlitMap* _map;

	/// <summary>
	/// Reference count - used when freeing surface.
	/// </summary>
	public readonly int RefCount;
}