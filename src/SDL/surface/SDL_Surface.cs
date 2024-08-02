using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// A collection of pixels used in software blitting.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Surface">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Surface
{
	/// <summary>
	/// Read-only.
	/// </summary>
	public readonly SDL_SurfaceFlags Flags;

	/// <summary>
	/// Read-only.
	/// </summary>
	public readonly SDL_PixelFormat Format;

	/// <summary>
	/// Read-only.
	/// </summary>
	public readonly int Width;

	/// <summary>
	/// Read-only.
	/// </summary>
	public readonly int Height;

	/// <summary>
	/// Read-only.
	/// </summary>
	public readonly int Pitch;

	/// <summary>
	/// Read-only pointer, writable pixels if is not <see cref="nint.Zero"/>.
	/// </summary>
	public readonly nint Pixels;

	/// <summary>
	/// Application reference count, used when freeing surface
	/// </summary>
	public int RefCount;

	private readonly SDL_SurfaceData* _internal;
}