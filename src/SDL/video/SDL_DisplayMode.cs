using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure that defines a display mode.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayMode">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe readonly struct SDL_DisplayMode
{
	/// <summary>
	/// The display this mode is associated with.
	/// </summary>
	public readonly SDL_DisplayId DisplayId;

	/// <summary>
	/// Pixel format.
	/// </summary>
	public readonly SDL_PixelFormatEnum Format;

	/// <summary>
	/// Width, in pixels.
	/// </summary>
	public readonly int Width;

	/// <summary>
	/// Height, in pixels.
	/// </summary>
	public readonly int Height;

	/// <summary>
	/// Scale converting size to pixels (e.g. a 1920x1080 mode with 2.0 scale would have 3840x2160 pixels)
	/// </summary>
	public readonly float PixelDensity;

	/// <summary>
	/// Refresh rate (or zero for unspecified).
	/// </summary>
	public readonly float RefreshRate;

	/// <summary>
	/// Driver-specific data, initialize to 0.
	/// </summary>
	public readonly void* DriverData;
}