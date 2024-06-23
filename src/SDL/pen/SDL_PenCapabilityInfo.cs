using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Pen capabilities, as reported by FIXME:SDL_GetPenCapabilities().
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_PenCapabilityInfo">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenCapabilityInfo
{
	/// <summary>
	/// Physical maximum tilt angle, for XTilt and YTilt, or <see cref="SDL.PenInfoUnknown"/>.
	/// </summary>
	/// <remarks>
	/// Pens cannot typically tilt all the way to 90 degrees, so this value is usually less than 90.0f.
	/// </remarks>
	public float MaxTilt;

	/// <summary>
	/// For Wacom devices: wacom tool type ID, otherwise 0 (useful e.g. with libwacom).
	/// </summary>
	public uint WacomId;

	/// <summary>
	/// Number of pen buttons (not counting the pen tip), or <see cref="SDL.PenInfoUnknown"/>.
	/// </summary>
	public sbyte NumButtons;
}