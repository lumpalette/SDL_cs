using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure that defines a display mode.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayMode">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_DisplayMode
{
	/// <summary>
	/// The display this mode is associated with.
	/// </summary>
	public SDL_DisplayId DisplayId;

	/// <summary>
	/// Pixel format.
	/// </summary>
	public SDL_PixelFormat Format;

	/// <summary>
	/// Width.
	/// </summary>
	public int Width;

	/// <summary>
	/// Height.
	/// </summary>
	public int Height;

	/// <summary>
	/// Scale converting size to pixels (e.g. a 1920x1080 mode with 2.0 scale would have 3840x2160 pixels).
	/// </summary>
	public float PixelDensity;

	/// <summary>
	/// Refresh rate (or zero for unspecified).
	/// </summary>
	public float RefreshRate;

	/// <summary>
	/// Precise refresh rate numerator (or 0 for unspecified).
	/// </summary>
	public int RefreshRateNumerator;

	/// <summary>
	/// Precise refresh rate denominator
	/// </summary>
	public int RefreshRateDenominator;

	private readonly SDL_DisplayModeData* _internal;
}